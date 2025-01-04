Public Class frmDeleteAttendant
    Private Sub frmDeleteAttendant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtAttendants As DataTable = New DataTable ' this is the table we will load from our reader

        Call Connect()
        Call Load_Pilots(cmdSelect, drSourceTable, dtAttendants)
        Call CloseDatabaseConnection()
    End Sub

    Private Sub Connect()

        Try


            ' open the DB this is in module
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If
        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub Load_Pilots(cmdSelect, drSourceTable, dtAttendants)
        Dim strSelect As String
        strSelect = "Select intAttendantID, TP.strLastName + ',' + TP.strFirstName as strName" &
                        " From TAttendants as TP"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader
        dtAttendants.Load(drSourceTable)

        'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

        cboAttendants.ValueMember = "intAttendantID"
        cboAttendants.DisplayMember = "strName"
        cboAttendants.DataSource = dtAttendants


        ' Clean up
        drSourceTable.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strDelete As String = ""
        Dim strSelect As String = String.Empty
        Dim strName As String = ""
        Dim intRowsAffected As Integer
        Dim cmdDelete As OleDb.OleDbCommand ' this will be used for our Delete statement
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim result As DialogResult  ' this is the result of which button the user selects

        Call Connect()

        Try
            ' always ask before deleting!!!!
            result = MessageBox.Show("Are you sure you want to Delete Attendant: " & cboAttendants.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
                Case DialogResult.Yes


                    ' Build the delete statement using PK from name selected

                    strDelete = "Delete FROM TAttendants Where intAttendantID = " & cboAttendants.SelectedValue

                    ' Delete the record(s) 
                    cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()

                    ' Did it work?
                    If intRowsAffected > 0 Then

                        ' Yes, success
                        MessageBox.Show("Delete successful")

                    End If

            End Select

            ' close the database connection
            CloseDatabaseConnection()

            ' call the Form Load sub to refresh the combo box data after a delete
            frmDeleteAttendant_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()

    End Sub
End Class