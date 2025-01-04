Public Class frmUpdatePilot
    Private Sub frmUpdatePilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtRoles As DataTable = New DataTable

        Call Connect()
        Call Populate_Roles(cmdSelect, drSourceTable, dtRoles)
        Call Populate_Pilot(cmdSelect, drSourceTable)
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

    Private Sub Populate_Roles(ByRef cmdSelect, ByRef drSourceTable, ByRef dtRoles)

        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select TPR.intPilotRoleID, TPR.strPilotRole From TPilotRoles as TPR"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtRoles.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboRole.ValueMember = "intPilotRoleID"
            cboRole.DisplayMember = "strPilotRole"
            cboRole.DataSource = dtRoles

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub


    Private Sub Populate_Pilot(ByRef cmdSelect, ByRef drSourceTable)
        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select TP.intPilotID, TP.strFirstName, TP.strLastName, TP.strEmployeeID,   FORMAT(TP.dtmDateofHire, 'MM-dd-yyyy') as dtmHire," &
                        " FORMAT(TP.dtmDateofTermination, 'MM-dd-yyyy') as dtmTerm, FORMAT(TP.dtmDateofLicense, 'MM-dd-yyyy') as dtmLicense, TP.intPilotRoleID" &
                        " From TPilots as TP" &
                        " Where TP.intPilotID = " & intPilot

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox


            txtFirstName.Text = drSourceTable("strFirstName")
            txtLastName.Text = drSourceTable("strLastName")
            cboRole.SelectedValue = drSourceTable("intPilotRoleID")
            txtEmployeeID.Text = drSourceTable("strEmployeeID")
            dtpHire.Value = drSourceTable("dtmHire")
            dtpTermination.Value = drSourceTable("dtmTerm")
            dtpLicense.Value = drSourceTable("dtmLicense")

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
        Dim strEmployeeID As String
        Dim dtmDateOfHire As Date
        Dim dtmDateOfTerm As Date
        Dim dtmDateOfLicense As Date
        Dim intRole As Integer

        Dim blnValidated As Boolean

        Call Connect()
        Call Validate_Inputs(blnValidated, strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTerm, dtmDateOfLicense, intRole)
        If blnValidated Then
            Call Update_Data(strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTerm, dtmDateOfLicense, intRole)
        End If
    End Sub

    Private Sub Update_Data(ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmDateOfHire As Date, ByRef dtmDateOfTerm As Date, ByRef dtmDateOfLicense As Date, ByRef intRole As Integer)
        Dim strSelect As String
        Dim strInsert As String
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim cmdUpdate As OleDb.OleDbCommand

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


            ' Build the select statement using PK from name selected
            strSelect = "Update TPilots Set " &
                        "strFirstName = '" & strFirstName & "', " &
                        "strLastName = '" & strLastName & "', " &
                        "strEmployeeID = '" & strEmployeeID & "', " &
                        "dtmDateofHire = '" & dtmDateOfHire & "', " &
                        "dtmDateofTermination = '" & dtmDateOfTerm & "', " &
                        "dtmDateofLicense = '" & dtmDateOfLicense & "', " &
                        "intPilotRoleID = " & intRole & " " &
                        "Where intPilotID = " & intPilot


            ' uncomment out the following message box line to use as a tool to check your sql statement
            ' remember anything not a numeric value going into SQL Server must have single quotes '
            ' around it, including dates.

            MessageBox.Show(strSelect)


            ' make the connection
            cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            ' IUpdate the row with execute the statement
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

    Private Sub Validate_Inputs(ByRef blnValidated As Boolean, ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmDateOfHire As Date, ByRef dtmDateOfTerm As Date, ByRef dtmDateOfLicense As Date, ByRef intRole As Integer)
        Call Validate_First_Name(strFirstName, blnValidated)
        If blnValidated Then
            blnValidated = False
            Call Validate_Last_Name(strLastName, blnValidated)
            If blnValidated Then
                blnValidated = False
                Call Validate_EmployeeID(blnValidated, strEmployeeID)
                If blnValidated Then
                    blnValidated = False
                    Call Validate_Role(blnValidated, intRole)
                    If blnValidated Then
                        blnValidated = False
                        Call Validate_Hire_Term_License(blnValidated, dtmDateOfHire, dtmDateOfTerm, dtmDateOfLicense)
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

    Private Sub Validate_Role(ByRef blnValidated As Boolean, ByRef intRole As Integer)

        If cboRole.SelectedIndex <> -1 Then
            blnValidated = True
            intRole = cboRole.SelectedValue
        Else
            blnValidated = False
            MessageBox.Show("Must select a pilot role from the drop-down menu.")
        End If
    End Sub

    Private Sub Validate_EmployeeID(ByRef blnValidated As Boolean, ByRef strEmployeeID As String)
        If txtEmployeeID.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must enter an employee ID.")
            txtEmployeeID.Focus()
        Else
            blnValidated = True
            strEmployeeID = txtEmployeeID.Text
        End If
    End Sub

    Private Sub Validate_Hire_Term_License(ByRef blnValidated As Boolean, ByRef dtmDateOfHire As Date, ByRef dtmDateOfTerm As Date, ByRef dtmDateOfLicense As Date)
        If dtpHire.Value > dtpTermination.Value Then
            blnValidated = False
            MessageBox.Show("Not possible to be fired before you were hired.")
        ElseIf (dtpLicense.Value > dtpHire.Value Or dtpLicense.Value > dtpTermination.Value) Then
            blnValidated = False
            MessageBox.Show("Not possible to be a pilot before licensed.")
        Else
            blnValidated = True
            dtmDateOfHire = dtpHire.Value
            dtmDateOfTerm = dtpTermination.Value
            dtmDateOfLicense = dtpLicense.Value
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()

    End Sub
End Class