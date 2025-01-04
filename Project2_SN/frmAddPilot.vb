Public Class frmAddPilot
    Private Sub frmAddPilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtRoles As DataTable = New DataTable

        Call Connect()
        Call Populate_Roles(cmdSelect, drSourceTable, dtRoles)
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

    Private Sub Close_Connection(ByRef drSourceTable)

        ' Clean up
        drSourceTable.Close()

        ' close the database connection
        CloseDatabaseConnection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strID As String
        Dim dtmHire As Date
        Dim dtmTerm As Date
        Dim dtmLicense As Date
        Dim intRole As Integer

        Dim blnValidated As Boolean
        Call Connect()
        Call Validate_Inputs(blnValidated, strFirstName, strLastName, strID, dtmHire, dtmTerm, dtmLicense, intRole)
        If blnValidated Then
            Call Add_Pilot(strFirstName, strLastName, strID, dtmHire, dtmTerm, dtmLicense, intRole)
        End If
    End Sub


    Private Sub Add_Pilot(ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmHire As Date, ByRef dtmTerm As Date, ByRef dtmLicense As Date, ByRef intRole As Integer)
        Dim strSelect As String
        Dim strInsert As String
        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Try

            strSelect = "SELECT MAX(intPilotID) + 1 AS intNextPrimaryKey " &
                            " FROM TPilots"

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

            strInsert = "INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)" &
                " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastName & "','" & strEmployeeID & "','" & dtmHire & "','" & dtmTerm & "','" & dtmLicense & "'," & intRole & ")"

            MessageBox.Show(strInsert)

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Pilot has been added")    ' let user know success
                ' close new player form
            End If

            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Validate_Inputs(ByRef blnValidated As Boolean, ByRef strFirstName As String, ByRef strLastName As String, ByRef strID As String, ByRef dtmHire As Date, ByRef dtmTerm As Date, ByRef dtmLicense As Date, ByRef intRole As Integer)
        Call Validate_First_Name(strFirstName, blnValidated)
        If blnValidated Then
            blnValidated = False
            Call Validate_Last_Name(strLastName, blnValidated)
            If blnValidated Then
                blnValidated = False
                Call Validate_EmployeeID(blnValidated, strID)
                If blnValidated Then
                    blnValidated = False
                    Call Validate_Role(blnValidated, intRole)
                    If blnValidated Then
                        blnValidated = False
                        Call Validate_Hire_Term_License(blnValidated, dtmHire, dtmTerm, dtmLicense)
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
            MessageBox.Show("Must select a pilot role from the drop down menu.")
        End If

        'If cboRole.Items.Contains(cboRole.Text) Then
        '    blnValidated = True
        '    intRole = cboRole.SelectedValue
        'Else
        '    blnValidated = False
        '    MessageBox.Show("Must select pilot role from the drop down menu.")
        'End If
    End Sub

    Private Sub Validate_EmployeeID(ByRef blnValidated As Boolean, ByRef strID As String)
        If txtEmployeeID.Text = "" Then
            blnValidated = False
            MessageBox.Show("Must enter an employee ID.")
            txtEmployeeID.Focus()
        Else
            blnValidated = True
            strID = txtEmployeeID.Text
        End If
    End Sub

    Private Sub Validate_Hire_Term_License(ByRef blnValidated As Boolean, ByRef dtmHire As Date, ByRef dtmTerm As Date, ByRef dtmLicense As Date)
        If dtpHire.Value > dtpTermination.Value Then
            blnValidated = False
            MessageBox.Show("Not possible to be fired before you were hired.")
        ElseIf (dtpLicense.Value > dtpHire.Value Or dtpLicense.Value > dtpTermination.Value) Then
            blnValidated = False
            MessageBox.Show("Not possible to be a pilot before licensed.")
        Else
            blnValidated = True
            dtmHire = dtpHire.Value
            dtmTerm = dtpTermination.Value
            dtmLicense = dtpLicense.Value
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()

    End Sub


End Class