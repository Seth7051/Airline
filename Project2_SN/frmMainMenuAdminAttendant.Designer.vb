<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenuAdminAttendant
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnFlight = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(142, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 58)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete Attendant"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(17, 131)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(98, 47)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnFlight
        '
        Me.btnFlight.Location = New System.Drawing.Point(261, 25)
        Me.btnFlight.Name = "btnFlight"
        Me.btnFlight.Size = New System.Drawing.Size(113, 58)
        Me.btnFlight.TabIndex = 5
        Me.btnFlight.Text = "Add Attendant to Flight"
        Me.btnFlight.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(17, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 58)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Attendant"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmMainMenuAdminAttendant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 186)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnFlight)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmMainMenuAdminAttendant"
        Me.Text = "Admin - Attendant"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnFlight As Button
    Friend WithEvents btnAdd As Button
End Class
