<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateAttendant
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dtpHire = New System.Windows.Forms.DateTimePicker()
        Me.dtpTerm = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Hire:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Termination:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(155, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(197, 22)
        Me.txtFirstName.TabIndex = 5
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(155, 123)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(197, 22)
        Me.txtEmployeeID.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(155, 69)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(197, 22)
        Me.txtLastName.TabIndex = 10
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(52, 295)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(97, 45)
        Me.btnReturn.TabIndex = 11
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(171, 295)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 45)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dtpHire
        '
        Me.dtpHire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHire.Location = New System.Drawing.Point(155, 175)
        Me.dtpHire.Name = "dtpHire"
        Me.dtpHire.Size = New System.Drawing.Size(150, 22)
        Me.dtpHire.TabIndex = 13
        '
        'dtpTerm
        '
        Me.dtpTerm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerm.Location = New System.Drawing.Point(155, 228)
        Me.dtpTerm.Name = "dtpTerm"
        Me.dtpTerm.Size = New System.Drawing.Size(150, 22)
        Me.dtpTerm.TabIndex = 14
        '
        'frmUpdateAttendant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 373)
        Me.Controls.Add(Me.dtpTerm)
        Me.Controls.Add(Me.dtpHire)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUpdateAttendant"
        Me.Text = "Update Attendant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dtpHire As DateTimePicker
    Friend WithEvents dtpTerm As DateTimePicker
End Class
