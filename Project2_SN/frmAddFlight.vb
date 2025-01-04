Public Class frmAddFlight
    Dim dtFlights As DataTable = New DataTable
    Private Sub frmAddFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to


        Call Connect()
        Call Populate_Flights(cmdSelect, drSourceTable, dtFlights)
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

    Private Sub Populate_Flights(ByRef cmdSelect, ByRef drSourceTable, ByRef dtFlights)

        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select Distinct TF.intFlightID, TF.strFlightNumber" &
                        " From TFlights As TF Where TF.dtmFlightDate > cast(getdate() As Date)"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtFlights.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboFutureFlights.ValueMember = "intFlightID"
            cboFutureFlights.DisplayMember = "strFlightNumber"
            cboFutureFlights.DataSource = dtFlights

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

    Private Sub cboFutureFlights_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFutureFlights.SelectedIndexChanged
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to

        Call Connect()
        Call Populate_FromAirport_Date(cmdSelect, drSourceTable)
        Call Populate_ToAirport_Departure(cmdSelect, drSourceTable)
        CloseDatabaseConnection()

    End Sub


    Private Sub Populate_FromAirport_Date(ByRef cmdSelect, ByRef drSourceTable)
        Dim strSelect As String
        'Dim strAirport As String

        Try
            strSelect = "Select FORMAT(TF.dtmFlightDate, 'MM-dd-yyyy') as Date, TA.strAirportCity" &
            " From TFlights As TF Join TAirports As TA On TF.intFromAirportID = TA.intAirportID" &
            " Where TF.dtmFlightDate > cast(getdate() As Date) and TF.intFlightID = " & cboFutureFlights.SelectedValue


            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()
            'strAirport = drSourceTable("strAirportCity")
            lblFromAirport.Text = drSourceTable("strAirportCity")
            lblDate.Text = drSourceTable("Date")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Populate_ToAirport_Departure(ByRef cmdSelect, ByRef drSourceTable)
        Dim strSelect As String

        Try
            strSelect = "Select TF.dtmTimeofDeparture as Departure, TA.strAirportCity" &
            " From TFlights As TF Join TAirports As TA On TF.intToAirportID = TA.intAirportID" &
            " Where TF.dtmFlightDate > cast(getdate() As Date) and TF.intFlightID = " & cboFutureFlights.SelectedValue


            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            lblToAirport.Text = drSourceTable("strAirportCity")
            lblDeparture.Text = drSourceTable("Departure").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim intFlightID As Integer
        Dim strSeat As String
        Dim intPassengerID As Integer = intCustomer
        Dim blnValidated As Boolean

        Call Connect()
        Call Validate_ComboBoxes(intFlightID, strSeat, blnValidated)
        If blnValidated Then
            Call Insert_FlightPassengers(intFlightID, intPassengerID, strSeat)
        End If

    End Sub

    Private Sub Insert_FlightPassengers(ByVal intFlightID As Integer, ByVal intPassengerID As Integer, ByVal strSeat As String)
        Dim strSelect As String
        Dim strInsert As String


        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim result As DialogResult
        Try
            result = MessageBox.Show("Are you sure you want to assign Customer to Flight #" & cboFutureFlights.Text, "Confirm Assignment", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
                Case DialogResult.Yes

                    strSelect = "SELECT MAX(intFlightPassengerID) + 1 AS intNextPrimaryKey " &
                            " FROM TFlightPassengers"

                    ' Execute command
                    cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                    drSourceTable = cmdSelect.ExecuteReader

                    ' Read result( highest ID )
                    drSourceTable.Read()

                    ' Null? (empty table)
                    If drSourceTable.IsDBNull(0) = True Then

                        ' Yes, start numbering at 1
                        intNextPrimaryKey = 1

                    Else

                        ' No, get the next highest ID
                        intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))

                    End If
                    ' build insert statement (columns must match DB columns in name and the # of columns)

                    strInsert = "INSERT INTO TFlightPassengers (intFlightPassengerID, intFlightID, intPassengerID, strSeat)" &
                        " VALUES (" & intNextPrimaryKey & "," & intFlightID & "," & intPassengerID & ",'" & strSeat & "')"

                    MessageBox.Show(strInsert)

                    ' use insert command with sql string and connection object
                    cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                    ' execute query to insert data
                    intRowsAffected = cmdInsert.ExecuteNonQuery()

                    ' If not 0 insert successful
                    If intRowsAffected > 0 Then
                        MessageBox.Show("Flight has been added for Customer")    ' let user know success
                        ' close new player form
                    End If
            End Select
            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Validate_ComboBoxes(ByRef intFlightID As Integer, ByRef strSeat As String, ByRef blnValidated As Boolean)
        Call Validate_FlightNumber(intFlightID, blnValidated)
        If blnValidated Then
            blnValidated = False
            Call Validate_Seat(strSeat, blnValidated)
        End If
    End Sub

    Private Sub Validate_FlightNumber(ByRef intFlightID As Integer, ByRef blnValidated As Boolean)
        For Each row As DataRow In dtFlights.Rows
            If row("strFlightNumber").ToString() = cboFutureFlights.Text Then
                blnValidated = True
                intFlightID = cboFutureFlights.SelectedValue
            End If
        Next
        If blnValidated = False Then
            MessageBox.Show("Must select a Flight Number from the dropdown menu")
        End If
    End Sub

    Private Sub Validate_Seat(ByRef strSeat As String, ByRef blnValidated As Boolean)
        If cboSeat.Items.Contains(cboSeat.Text) Then
            blnValidated = True
            strSeat = cboSeat.Text
        Else
            blnValidated = False
            MessageBox.Show("Must select a seat from the dropdown menu")
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class