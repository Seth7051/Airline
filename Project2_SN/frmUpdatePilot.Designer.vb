<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePilot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dtpHire = New System.Windows.Forms.DateTimePicker()
        Me.dtpTermination = New System.Windows.Forms.DateTimePicker()
        Me.dtpLicense = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(174, 103)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(141, 24)
        Me.cboRole.TabIndex = 56
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(174, 143)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(183, 22)
        Me.txtEmployeeID.TabIndex = 52
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(174, 65)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(183, 22)
        Me.txtLastName.TabIndex = 51
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(174, 24)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(183, 22)
        Me.txtFirstName.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Date of Licensing:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Date of Termination:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Pilot Role:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Date Of Hire:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "First Name:"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(107, 378)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(92, 42)
        Me.btnReturn.TabIndex = 40
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(219, 378)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 42)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "Update Pilot"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dtpHire
        '
        Me.dtpHire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHire.Location = New System.Drawing.Point(174, 187)
        Me.dtpHire.Name = "dtpHire"
        Me.dtpHire.Size = New System.Drawing.Size(153, 22)
        Me.dtpHire.TabIndex = 57
        '
        'dtpTermination
        '
        Me.dtpTermination.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermination.Location = New System.Drawing.Point(174, 229)
        Me.dtpTermination.Name = "dtpTermination"
        Me.dtpTermination.Size = New System.Drawing.Size(153, 22)
        Me.dtpTermination.TabIndex = 58
        '
        'dtpLicense
        '
        Me.dtpLicense.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLicense.Location = New System.Drawing.Point(174, 271)
        Me.dtpLicense.Name = "dtpLicense"
        Me.dtpLicense.Size = New System.Drawing.Size(153, 22)
        Me.dtpLicense.TabIndex = 59
        '
        'frmUpdatePilot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 450)
        Me.Controls.Add(Me.dtpLicense)
        Me.Controls.Add(Me.dtpTermination)
        Me.Controls.Add(Me.dtpHire)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmUpdatePilot"
        Me.Text = "Update Pilot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboRole As ComboBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dtpHire As DateTimePicker
    Friend WithEvents dtpTermination As DateTimePicker
    Friend WithEvents dtpLicense As DateTimePicker
End Class
