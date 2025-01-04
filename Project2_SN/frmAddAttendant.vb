Public Class frmAddAttendant

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As String
        Dim dtmDateOfHire As Date
        Dim dtmDateOfTerm As Date

        Dim blnValidated As Boolean

        Call Connect()
        Call Validate_Inputs(blnValidated, strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTerm)
        If blnValidated Then
            Call Add_Attendant(strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTerm)
        End If
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

    Private Sub Add_Attendant(ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmDateOfHire As Date, ByRef dtmDateOfTerm As Date)
        Dim strSelect As String
        Dim strInsert As String
        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Try

            strSelect = "SELECT MAX(intAttendantID) + 1 AS intNextPrimaryKey " &
                            " FROM TAttendants"

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

            strInsert = "INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination)" &
                " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastName & "','" & strEmployeeID & "','" & dtmDateOfHire & "','" & dtmDateOfTerm & "')"

            MessageBox.Show(strInsert)

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Attendant has been added")    ' let user know success
                ' close new player form
            End If

            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Validate_Inputs(ByRef blnValidated As Boolean, ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmDateOfHire As Date, ByRef dtmDateOfTerm As Date)
        Call Validate_First_Name(strFirstName, blnValidated)
        If blnValidated Then
            blnValidated = False
            Call Validate_Last_Name(strLastName, blnValidated)
            If blnValidated Then
                blnValidated = False
                Call Validate_EmployeeID(blnValidated, strEmployeeID)
                If blnValidated Then
                    blnValidated = False
                    Call Validate_Hire_Term(blnValidated, dtmDateOfHire, dtmDateOfTerm)
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

    Private Sub Validate_Hire_Term(ByRef blnValidated As Boolean, ByRef dtmDateOfHire As Date, ByRef dtmDateOfTerm As Date)
        If dtpHire.Value > dtpTerm.Value Then
            blnValidated = False
            MessageBox.Show("Not possible to be fired before you were hired.")
        Else
            blnValidated = True
            dtmDateOfHire = dtpHire.Value
            dtmDateOfTerm = dtpTerm.Value
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()

    End Sub
End Class