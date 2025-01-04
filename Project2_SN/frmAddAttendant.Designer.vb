<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAttendant
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpHire = New System.Windows.Forms.DateTimePicker()
        Me.dtpTerm = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(183, 306)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 47)
        Me.btnAdd.TabIndex = 87
        Me.btnAdd.Text = "Add Attendant"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(58, 306)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(103, 47)
        Me.btnReturn.TabIndex = 86
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(167, 80)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(197, 22)
        Me.txtLastName.TabIndex = 85
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(167, 134)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(197, 22)
        Me.txtEmployeeID.TabIndex = 84
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(167, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(197, 22)
        Me.txtFirstName.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 17)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Date of Termination:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Date of Hire:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Employee ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 17)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Last Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "First Name:"
        '
        'dtpHire
        '
        Me.dtpHire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHire.Location = New System.Drawing.Point(167, 186)
        Me.dtpHire.Name = "dtpHire"
        Me.dtpHire.Size = New System.Drawing.Size(145, 22)
        Me.dtpHire.TabIndex = 88
        '
        'dtpTerm
        '
        Me.dtpTerm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerm.Location = New System.Drawing.Point(167, 234)
        Me.dtpTerm.Name = "dtpTerm"
        Me.dtpTerm.Size = New System.Drawing.Size(145, 22)
        Me.dtpTerm.TabIndex = 89
        '
        'frmAddAttendant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 365)
        Me.Controls.Add(Me.dtpTerm)
        Me.Controls.Add(Me.dtpHire)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Name = "frmAddAttendant"
        Me.Text = "frmAddAttendant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpHire As DateTimePicker
    Friend WithEvents dtpTerm As DateTimePicker
End Class
