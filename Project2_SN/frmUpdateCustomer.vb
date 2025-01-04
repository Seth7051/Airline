Public Class frmUpdateCustomer
    Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtStates As DataTable = New DataTable

        Call Connect()
        Call Populate_States(cmdSelect, drSourceTable, dtStates)
        Call Populate_Customer(cmdSelect, drSourceTable)
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


    Private Sub Populate_Customer(ByRef cmdSelect, ByRef drSourceTable)
        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select * From TPassengers as TP" &
                " Where TP.intPassengerID = " & intCustomer

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            txtFirstName.Text = drSourceTable("strFirstName")
            txtLastName.Text = drSourceTable("strLastName")
            txtAddress.Text = drSourceTable("strAddress")
            txtCity.Text = drSourceTable("strCity")
            cboStates.SelectedValue = drSourceTable("intStateID")
            txtZip.Text = drSourceTable("strZip")
            txtPhone.Text = drSourceTable("strPhoneNumber")
            txtEmail.Text = drSourceTable("strEmail")

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
            Call Update_Data(strFirstName, strLastName, strAddress, strCity, intState, strZip, strPhone, strEmail)
        End If
    End Sub


    Private Sub Update_Data(ByRef strFirstName As String, ByRef strLastName As String, ByRef strAddress As String, ByRef strCity As String, ByRef intState As String, ByRef strZip As String, ByRef strPhone As String, ByRef strEmail As String)
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim cmdUpdate As New OleDb.OleDbCommand

        Try

            ' open database this is in module
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            strFirstName = txtFirstName.Text
            strLastName = txtLastName.Text
            strAddress = txtAddress.Text
            strCity = txtCity.Text
            intState = cboStates.SelectedValue
            strZip = txtZip.Text
            strPhone = txtPhone.Text
            strEmail = txtEmail.Text


            ' Build the select statement using PK from name selected
            cmdUpdate.CommandText = "EXECUTE uspUpdatePassenger '" & intCustomer & "','" & strFirstName & "','" & strLastName & "','" & strAddress & "','" & strCity & "','" & intState & "','" & strZip & "','" & strPhone & "','" & strEmail & "'"
            cmdUpdate.CommandType = CommandType.StoredProcedure

            cmdUpdate = New OleDb.OleDbCommand(cmdUpdate.CommandText, m_conAdministrator)

            intRowsAffected = cmdUpdate.ExecuteNonQuery()

            ' have to let the user know what happened 
            If intRowsAffected = 1 Then
                MessageBox.Show("Update successful")
            Else
                MessageBox.Show("Update failed")
            End If

            ' close the database connection
            CloseDatabaseConnection()

            Close()



        Catch ex As Exception
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
        Close()

    End Sub
End Class