Public Class frmFutureFlightsPilot
    Private Sub frmFutureFlightsPilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intMiles As Integer
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to

        Call Connect()
        Call Populate_Details(cmdSelect, drSourceTable)

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

    Private Sub Populate_Details(ByRef cmdSelect, ByRef drSourceTable)
        Dim strSelect As String
        Dim intMiles As Integer
        Dim objParam As OleDb.OleDbParameter

        Try

            cmdSelect = New OleDb.OleDbCommand("uspFutureFlightsPilot", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            objParam = cmdSelect.Parameters.Add("@PilotID", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = intPilot

            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()
            lstFlights.Items.Add("Pilot: " & drSourceTable("strName").ToString)
            lstFlights.Items.Add("Pilot Role: " & drSourceTable("strPilotRole"))
            lstFlights.Items.Add("=============================")

            Do
                intMiles += drSourceTable("intMilesFlown")

                lstFlights.Items.Add("  ")
                lstFlights.Items.Add("Flight Number: " & vbTab & drSourceTable("strFlightNumber").ToString())
                lstFlights.Items.Add("Flight Date: " & vbTab & drSourceTable("FlightDate").ToString())
                lstFlights.Items.Add("Time of Departure: " & vbTab & drSourceTable("dtmTimeofDeparture").ToString())
                lstFlights.Items.Add("From: " & vbTab & drSourceTable("strAirportCity").ToString())
                lstFlights.Items.Add("To: " & vbTab & drSourceTable("ToAirportCity").ToString())
                lstFlights.Items.Add("  ")
                lstFlights.Items.Add("=============================")
            Loop While drSourceTable.read()

            lblMiles.Text = intMiles

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub

End Class