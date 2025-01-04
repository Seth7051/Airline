Public Class frmStatistics
    Private Sub frmStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        'Dim dtTotal As DataTable = New DataTable
        'Dim dtFlights As DataTable = New DataTable
        'Dim dtAverage As DataTable = New DataTable

        Call Connect()
        Call Populate_Total(cmdSelect, drSourceTable)
        Call Populate_Flights(cmdSelect, drSourceTable)
        Call Populate_Average(cmdSelect, drSourceTable)
        Call Populate_Pilots(cmdSelect, drSourceTable)
        Call Populate_Attendants(cmdSelect, drSourceTable)
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

    Private Sub Populate_Total(ByRef cmdSelect, ByRef drSourceTable)

        Try

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspPopulateTotalStats", m_conAdministrator)
            cmdSelect.commandtype = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            lblCustomers.Text = drSourceTable("Total")

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub Populate_Flights(cmdSelect, drSourceTable)

        Try

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspPopulateFlightsStats", m_conAdministrator)
            cmdSelect.commandtype = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            lblFlights.Text = drSourceTable("Flights")

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub Populate_Average(cmdSelect, drSourceTable)

        Try

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspPopulateAverageMilesFlown", m_conAdministrator)
            cmdSelect.commandtype = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            lblMiles.Text = drSourceTable("Average")

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub Populate_Pilots(cmdSelect, drSourceTable)

        Try

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspPopulatePilotStats", m_conAdministrator)
            cmdSelect.commandtype = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            Do
                lstPilots.Items.Add("===============================")
                lstPilots.Items.Add(" ")
                lstPilots.Items.Add("Pilot: " & drSourceTable("strName").ToString())
                lstPilots.Items.Add("Total Miles Flown: " & drSourceTable("Total").ToString())
                lstPilots.Items.Add(" ")
                lstPilots.Items.Add("===============================")
            Loop While drSourceTable.read()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub Populate_Attendants(cmdSelect, drSourceTable)

        Try


            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspPopulateAttendantStats", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            Do
                lstAttendants.Items.Add("===============================")
                lstAttendants.Items.Add(" ")
                lstAttendants.Items.Add("Pilot: " & drSourceTable("strName").ToString())
                lstAttendants.Items.Add("Total Miles Flown: " & drSourceTable("Total").ToString())
                lstAttendants.Items.Add(" ")
                lstAttendants.Items.Add("===============================")
            Loop While drSourceTable.read()

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
End Class