<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserType
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
        Me.radAdministration = New System.Windows.Forms.RadioButton()
        Me.radAttendant = New System.Windows.Forms.RadioButton()
        Me.radPilot = New System.Windows.Forms.RadioButton()
        Me.radCustomer = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radAdministration
        '
        Me.radAdministration.AutoSize = True
        Me.radAdministration.Location = New System.Drawing.Point(29, 163)
        Me.radAdministration.Name = "radAdministration"
        Me.radAdministration.Size = New System.Drawing.Size(118, 21)
        Me.radAdministration.TabIndex = 3
        Me.radAdministration.TabStop = True
        Me.radAdministration.Text = "Administration"
        Me.radAdministration.UseVisualStyleBackColor = True
        '
        'radAttendant
        '
        Me.radAttendant.AutoSize = True
        Me.radAttendant.Location = New System.Drawing.Point(29, 117)
        Me.radAttendant.Name = "radAttendant"
        Me.radAttendant.Size = New System.Drawing.Size(90, 21)
        Me.radAttendant.TabIndex = 2
        Me.radAttendant.TabStop = True
        Me.radAttendant.Text = "Attendant"
        Me.radAttendant.UseVisualStyleBackColor = True
        '
        'radPilot
        '
        Me.radPilot.AutoSize = True
        Me.radPilot.Location = New System.Drawing.Point(29, 71)
        Me.radPilot.Name = "radPilot"
        Me.radPilot.Size = New System.Drawing.Size(56, 21)
        Me.radPilot.TabIndex = 1
        Me.radPilot.TabStop = True
        Me.radPilot.Text = "Pilot"
        Me.radPilot.UseVisualStyleBackColor = True
        '
        'radCustomer
        '
        Me.radCustomer.AutoSize = True
        Me.radCustomer.Location = New System.Drawing.Point(29, 25)
        Me.radCustomer.Name = "radCustomer"
        Me.radCustomer.Size = New System.Drawing.Size(89, 21)
        Me.radCustomer.TabIndex = 0
        Me.radCustomer.TabStop = True
        Me.radCustomer.Text = "Customer"
        Me.radCustomer.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(141, 214)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(83, 34)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmUserType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 260)
        Me.Controls.Add(Me.radAdministration)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.radAttendant)
        Me.Controls.Add(Me.radPilot)
        Me.Controls.Add(Me.radCustomer)
        Me.Name = "frmUserType"
        Me.Text = "User Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radAdministration As RadioButton
    Friend WithEvents radAttendant As RadioButton
    Friend WithEvents radPilot As RadioButton
    Friend WithEvents radCustomer As RadioButton
    Friend WithEvents btnSubmit As Button
End Class
