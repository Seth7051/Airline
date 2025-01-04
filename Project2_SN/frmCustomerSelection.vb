Public Class frmCustomerSelection
    Private Sub CustomerMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtPassengers As DataTable = New DataTable

        Call Connect()
        Call Populate_Customers(cmdSelect, drSourceTable, dtPassengers)
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

    Private Sub Populate_Customers(ByRef cmdSelect, ByRef drSourceTable, ByRef dtPassengers)

        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select TP.intPassengerID, TP.strLastName + ', ' + TP.strFirstName as strName From TPassengers as TP"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtPassengers.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboCustomer.ValueMember = "intPassengerID"
            cboCustomer.DisplayMember = "strName"
            cboCustomer.DataSource = dtPassengers

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

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Dim frmAddCustomer As New frmAddCustomer

        frmAddCustomer.ShowDialog()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cboCustomer.SelectedIndex <> -1 Then
            intCustomer = cboCustomer.SelectedValue
            Dim frmCustomerMainMenu As New frmCustomerMainMenu
            frmCustomerMainMenu.ShowDialog()
        Else
            MessageBox.Show("Must select a Customer first.")
        End If


    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class