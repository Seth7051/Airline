<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenuAdminPilot
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
        Me.btnFlight = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(22, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 47)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Pilot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnFlight
        '
        Me.btnFlight.Location = New System.Drawing.Point(256, 22)
        Me.btnFlight.Name = "btnFlight"
        Me.btnFlight.Size = New System.Drawing.Size(98, 47)
        Me.btnFlight.TabIndex = 1
        Me.btnFlight.Text = "Add Pilot to Flight"
        Me.btnFlight.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(12, 128)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(98, 47)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(137, 22)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 47)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Pilot"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmMainMenuAdminPilot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 187)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnFlight)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmMainMenuAdminPilot"
        Me.Text = "Admin - Pilot"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFlight As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
End Class
