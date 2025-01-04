Public Class frmUpdateAttendant
    Private Sub frmUpdateAttendant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to

        Call Connect()
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


    Private Sub Populate_Pilot(ByRef cmdSelect, ByRef drSourceTable)
        Dim strSelect As String

        Try
            ' Build the select statement to obtain Cities

            strSelect = "Select TA.intAttendantID, TA.strFirstName, TA.strLastName, TA.strEmployeeID," &
                        " FORMAT(TA.dtmDateofHire, 'MM-dd-yyyy') as dtmHire, FORMAT(TA.dtmDateofTermination, 'MM-dd-yyyy') as dtmTerm" &
                        " From TAttendants as TA" &
                        " Where TA.intAttendantID = " & intAttendant

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox


            txtFirstName.Text = drSourceTable("strFirstName")
            txtLastName.Text = drSourceTable("strLastName")
            txtEmployeeID.Text = drSourceTable("strEmployeeID")
            dtpHire.Text = drSourceTable("dtmHire")
            dtpTerm.Text = drSourceTable("dtmTerm")

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

        Dim blnValidated As Boolean

        Call Connect()
        Call Validate_Inputs(blnValidated, strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTerm)
        If blnValidated Then
            Call Update_Data(strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTerm)
        End If
    End Sub

    Private Sub Update_Data(ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmDateOfHire As Date, ByRef dtmDateOfTerm As Date)
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
            strSelect = "Update TAttendants Set " &
                        "strFirstName = '" & strFirstName & "', " &
                        "strLastName = '" & strLastName & "', " &
                        "strEmployeeID = '" & strEmployeeID & "', " &
                        "dtmDateofHire = '" & dtmDateOfHire & "', " &
                        "dtmDateofTermination = '" & dtmDateOfTerm & "' " &
                        "Where intAttendantID = " & intAttendant


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
            MessageBox.Show("It is not possible to be fired before being hired.")
        Else
            blnValidated = True
            dtmDateOfHire = dtpHire.Value
            dtmDateOfTerm = dtpHire.Value
        End If

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()

    End Sub
End Class