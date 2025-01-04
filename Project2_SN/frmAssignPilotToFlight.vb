Public Class frmAssignPilotToFlight
    Private Sub frmAssignPiltToFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtPilots As DataTable = New DataTable ' this is the table we will load from our reader
        Dim dtFlights As DataTable = New DataTable
        Call Connect()
        Call Load_Pilots(cmdSelect, drSourceTable, dtPilots)
        Call Load_Flights(cmdSelect, drSourceTable, dtFlights)
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

    Private Sub Load_Flights(cmdSelect, drSourceTable, dtFlights)
        Dim strSelect As String
        strSelect = "Select TF.intFlightID, 'Flight #' + TF.strFlightNumber +" &
            " ' Date: ' + FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as Display" &
            " From TFlights As TF Where TF.dtmFlightDate > cast(getdate() As Date)"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader
        dtFlights.Load(drSourceTable)

        'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

        cboFlights.ValueMember = "intFlightID"
        cboFlights.DisplayMember = "Display"
        cboFlights.DataSource = dtFlights


        ' Clean up
        drSourceTable.Close()
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim blnValidated As Boolean
        Call Validate_ComboBoxes(blnValidated)
        If blnValidated = True Then
            Call Connect()
            Dim strSelect As String
            Dim strInsert As String
            Dim intPilotID As Integer = cboPilots.SelectedValue
            Dim intFlightID As Integer = cboFlights.SelectedValue

            Dim cmdSelect As OleDb.OleDbCommand ' select command object
            Dim cmdInsert As OleDb.OleDbCommand ' insert command object
            Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
            Dim intNextPrimaryKey As Integer ' holds next highest PK value
            Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
            Dim result As DialogResult
            Try

                result = MessageBox.Show("Are you sure you want to assign Pilot: " & cboPilots.Text & " to " & cboFlights.Text, "Confirm Assignment", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
                Select Case result
                    Case DialogResult.Cancel
                        MessageBox.Show("Action Canceled")
                    Case DialogResult.No
                        MessageBox.Show("Action Canceled")
                    Case DialogResult.Yes


                        strSelect = "SELECT MAX(intPilotFlightID) + 1 AS intNextPrimaryKey " &
                                " FROM TPilotFlights"

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

                        strInsert = "INSERT INTO TPilotFlights (intPilotFlightID, intPilotID, intFlightID)" &
                            " VALUES (" & intNextPrimaryKey & ", " & intPilotID & ", " & intFlightID & ")"

                        MessageBox.Show(strInsert)

                        ' use insert command with sql string and connection object
                        cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                        ' execute query to insert data
                        intRowsAffected = cmdInsert.ExecuteNonQuery()

                        ' If not 0 insert successful
                        If intRowsAffected > 0 Then
                            MessageBox.Show("Flight has been added for Pilot")    ' let user know success
                            ' close new player form
                        End If
                End Select
                CloseDatabaseConnection()       ' close connection if insert didn't work
                Close()

            Catch ex As Exception

                ' Log and display error message
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub Validate_ComboBoxes(ByRef blnValidated As Boolean)
        Call Validate_cboPilots(blnValidated)
        If blnValidated = True Then
            blnValidated = False
            Call Validate_cboFlights(blnValidated)
        End If
    End Sub

    Private Sub Validate_cboPilots(ByRef blnValidated As Boolean)
        If cboPilots.SelectedIndex <> -1 Then
            blnValidated = True
        Else
            blnValidated = False
            MessageBox.Show("Must select a Pilot from the dropdown menu.")
        End If
    End Sub

    Private Sub Validate_cboFlights(ByRef blnValidated As Boolean)
        If cboFlights.SelectedIndex <> -1 Then
            blnValidated = True
        Else
            blnValidated = False
            MessageBox.Show("Must select a Flight from the dropdown menu.")
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class