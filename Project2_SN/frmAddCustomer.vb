Public Class frmAddCustomer
    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtStates As DataTable = New DataTable

        Call Connect()
        Call Populate_States(cmdSelect, drSourceTable, dtStates)
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

    Private Sub Populate_States(ByRef cmdSelect, ByRef drSourceTable, ByRef dtStates)

        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select TS.intStateID, TS.strState From TStates as TS"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtStates.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboStates.ValueMember = "intStateID"
            cboStates.DisplayMember = "strState"
            cboStates.DataSource = dtStates

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub Close_Connection(ByRef drSourceTable)
        frmCustomerSelection.Refresh()

        ' Clean up
        drSourceTable.Close()

        ' close the database connection
        CloseDatabaseConnection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intPassengerID As Integer = 0
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim intState As Integer
        Dim strZip As String
        Dim strPhone As String
        Dim strEmail As String

        Dim blnValidated As Boolean

        Call Connect()
        Call Validate_Inputs(blnValidated, strFirstName, strLastName, strAddress, strCity, intState, strZip, strPhone, strEmail)
        If blnValidated Then
            Call Insert_Data(intPassengerID, strFirstName, strLastName, strAddress, strCity, intState, strZip, strPhone, strEmail)
        End If
    End Sub


    Private Sub Insert_Data(ByRef intPassengerID As Integer, ByRef strFirstName As String, ByRef strLastName As String, ByRef strAddress As String, ByRef strCity As String, ByRef intState As String, ByRef strZip As String, ByRef strPhone As String, ByRef strEmail As String)
        Dim cmdAddPassenger As New OleDb.OleDbCommand ' insert command object
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Try

            ' Execute command
            cmdAddPassenger.CommandText = "EXECUTE uspAddPassenger '" & intPassengerID & "','" & strFirstName & "','" & strLastName & "','" & strAddress & "','" & strCity & "','" & intState & "','" & strZip & "','" & strPhone & "','" & strEmail & "'"
            cmdAddPassenger.CommandType = CommandType.StoredProcedure

            cmdAddPassenger = New OleDb.OleDbCommand(cmdAddPassenger.CommandText, m_conAdministrator)

            intRowsAffected = cmdAddPassenger.ExecuteNonQuery()
            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Passenger has been added")    ' let user know success
                ' close new player form
            End If

            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Validate_Inputs(ByRef blnValidated As Boolean, ByRef strFirstName As String, ByRef strLastName As String, ByRef strAddress As String, ByRef strCity As String, ByRef intState As String, ByRef strZip As String, ByRef strPhone As String, ByRef strEmail As String)
        Call Validate_First_Name(strFirstName, blnValidated)
        If blnValidated Then
            blnValidated = False
            Call Validate_Last_Name(strLastName, blnValidated)
            If blnValidated Then
                blnValidated = False
                Call Validate_Address(strAddress, blnValidated)
                If blnValidated Then
                    blnValidated = False
                    Call Validate_City(strCity, blnValidated)
                    If blnValidated Then
                        blnValidated = False
                        Call Validate_State(intState, blnValidated)
                        If blnValidated Then
                            blnValidated = False
                            Call Validate_Zip(strZip, blnValidated)
                            If blnValidated Then
                                blnValidated = False
                                Call Validate_Phone(strPhone, blnValidated)
                                If blnValidated Then
                                    blnValidated = False
                                    Call Validate_Email(strEmail, blnValidated)
                                End If
                            End If
                        End If
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub Validate_First_Name(ByRef strFirstName As String, ByRef blnValidated As Boolean)
        If txtFirstName.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must eneter a first name.")
            txtFirstName.Focus()
        Else
            strFirstName = txtFirstName.Text
            blnValidated = True
        End If
    End Sub

    Private Sub Validate_Last_Name(ByRef strLastName As String, ByRef blnValidated As Boolean)
        If txtLastName.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must eneter a last name.")
            txtFirstName.Focus()
        Else
            strLastName = txtLastName.Text
            blnValidated = True
        End If
    End Sub

    Private Sub Validate_Address(ByRef strAddress As String, ByRef blnValidated As Boolean)
        If txtAddress.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must eneter an address.")
            txtAddress.Focus()
        Else
            strAddress = txtAddress.Text
            blnValidated = True
        End If
    End Sub

    Private Sub Validate_City(ByRef strCity As String, ByRef blnValidated As Boolean)
        If txtCity.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must eneter a city.")
            txtCity.Focus()
        Else
            strCity = txtCity.Text
            blnValidated = True
        End If
    End Sub

    Private Sub Validate_State(ByRef intState As String, ByRef blnValidated As Boolean)
        If cboStates.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must select a state.")
            cboStates.Focus()
        ElseIf (cboStates.Text = "Ohio" Or cboStates.Text = "Indiana" Or cboStates.Text = "Kentucky") Then
            intState = cboStates.SelectedValue
            blnValidated = True
        Else
            blnValidated = False
            MessageBox.Show("Must select a state.")
            cboStates.Focus()
        End If
    End Sub

    Private Sub Validate_Zip(ByRef strZip As String, ByRef blnValidated As Boolean)
        If txtZip.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must eneter a zip code.")
            txtZip.Focus()
        Else
            strZip = txtZip.Text
            If strZip.Length = 5 Then
                blnValidated = True
            Else
                blnValidated = False
                MessageBox.Show("Must eneter a valid zip code.")
                txtZip.Focus()
            End If
        End If
    End Sub

    Private Sub Validate_Phone(ByRef strPhone As String, ByRef blnValidated As Boolean)
        strPhone = txtPhone.Text
        Dim intPhone As Integer
        If strPhone.Length = 10 Then
            Try
                Integer.TryParse(txtPhone.Text, intPhone)
                blnValidated = True
            Catch ex As Exception
                MessageBox.Show("Must eneter a 10 digit phone number.")
                txtPhone.Focus()
                blnValidated = False
            End Try
        Else
            MessageBox.Show("Must eneter a 10 digit phone number.")
            txtPhone.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_Email(ByRef strEmail As String, ByRef blnValidated As Boolean)
        If txtEmail.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must eneter an email.")
            txtEmail.Focus()
        Else
            strEmail = txtEmail.Text
            blnValidated = True
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub
End Class