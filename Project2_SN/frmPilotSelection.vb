Public Class frmPilotSelection
    Private Sub frmPilotSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtPilots As DataTable = New DataTable

        Call Connect()
        Call Populate_Customers(cmdSelect, drSourceTable, dtPilots)
        Call Close_Connection(drSourceTable)
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

    Private Sub Populate_Customers(ByRef cmdSelect, ByRef drSourceTable, ByRef dtPilots)

        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select TP.intPilotID, TP.strLastName + ', ' + TP.strFirstName as strName From TPilots as TP"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtPilots.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboPilot.ValueMember = "intPilotID"
            cboPilot.DisplayMember = "strName"
            cboPilot.DataSource = dtPilots

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub Close_Connection(ByRef drSourceTable)

        ' Clean up
        drSourceTable.Close()

        ' close the database connection
        CloseDatabaseConnection()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cboPilot.SelectedIndex <> -1 Then
            intPilot = cboPilot.SelectedValue
            Dim frmPilotMainMenu As New frmPilotMainMenu
            frmPilotMainMenu.ShowDialog()
        Else
            MessageBox.Show("Must select a Pilot first.")
        End If
    End Sub
End Class