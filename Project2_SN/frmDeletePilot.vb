Public Class frmDeletePilot
    Private Sub frmDeletePilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtPilots As DataTable = New DataTable ' this is the table we will load from our reader

        Call Connect()
        Call Load_Pilots(cmdSelect, drSourceTable, dtPilots)
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

    Private Sub Load_Pilots(cmdSelect, drSourceTable, dtPilots)
        Dim strSelect As String
        strSelect = "Select intPilotID, TP.strLastName + ',' + TP.strFirstName as strName" &
                        " From TPilots as TP"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader
        dtPilots.Load(drSourceTable)

        'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

        cboPilots.ValueMember = "intPilotID"
        cboPilots.DisplayMember = "strName"
        cboPilots.DataSource = dtPilots


        ' Clean up
        drSourceTable.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strDelete As String = ""
        Dim strSelect As String = String.Empty
        Dim strName As String = ""
        Dim intRowsAffected As Integer
        Dim cmdDelete As New OleDb.OleDbCommand ' this will be used for our Delete statement
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim result As DialogResult  ' this is the result of which button the user selects

        Call Connect()

        Try
            ' always ask before deleting!!!!
            result = MessageBox.Show("Are you sure you want to Delete Pilot: " & cboPilots.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
                Case DialogResult.Yes

                    cmdDelete.CommandText = "EXECUTE uspDeletePilot '" & cboPilots.SelectedValue & "'"
                    cmdDelete.CommandType = CommandType.StoredProcedure

                    cmdDelete = New OleDb.OleDbCommand(cmdDelete.CommandText, m_conAdministrator)

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
            frmDeletePilot_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()

    End Sub
End Class