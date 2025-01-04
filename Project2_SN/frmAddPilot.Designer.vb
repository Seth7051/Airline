<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPilot
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
        Me.dtpLicense = New System.Windows.Forms.DateTimePicker()
        Me.dtpTermination = New System.Windows.Forms.DateTimePicker()
        Me.dtpHire = New System.Windows.Forms.DateTimePicker()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpLicense
        '
        Me.dtpLicense.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLicense.Location = New System.Drawing.Point(176, 265)
        Me.dtpLicense.Name = "dtpLicense"
        Me.dtpLicense.Size = New System.Drawing.Size(141, 22)
        Me.dtpLicense.TabIndex = 91
        '
        'dtpTermination
        '
        Me.dtpTermination.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermination.Location = New System.Drawing.Point(176, 223)
        Me.dtpTermination.Name = "dtpTermination"
        Me.dtpTermination.Size = New System.Drawing.Size(141, 22)
        Me.dtpTermination.TabIndex = 90
        '
        'dtpHire
        '
        Me.dtpHire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHire.Location = New System.Drawing.Point(176, 181)
        Me.dtpHire.Name = "dtpHire"
        Me.dtpHire.Size = New System.Drawing.Size(141, 22)
        Me.dtpHire.TabIndex = 89
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(176, 97)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(141, 24)
        Me.cboRole.TabIndex = 88
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(176, 137)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(183, 22)
        Me.txtEmployeeID.TabIndex = 87
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(176, 59)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(183, 22)
        Me.txtLastName.TabIndex = 86
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(176, 18)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(183, 22)
        Me.txtFirstName.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Date of Licensing:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Date of Termination:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Pilot Role:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Date Of Hire:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Employee ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 17)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Last Name:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 17)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "First Name:"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(111, 367)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(92, 42)
        Me.btnReturn.TabIndex = 77
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(226, 367)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 42)
        Me.btnAdd.TabIndex = 76
        Me.btnAdd.Text = "Add Pilot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmAddPilot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 429)
        Me.Controls.Add(Me.dtpLicense)
        Me.Controls.Add(Me.dtpTermination)
        Me.Controls.Add(Me.dtpHire)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmAddPilot"
        Me.Text = "Add Pilot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpLicense As DateTimePicker
    Friend WithEvents dtpTermination As DateTimePicker
    Friend WithEvents dtpHire As DateTimePicker
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnAdd As Button
End Class
