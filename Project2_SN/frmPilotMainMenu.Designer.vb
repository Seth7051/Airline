<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotMainMenu
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFuture = New System.Windows.Forms.Button()
        Me.btnPast = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(32, 29)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 49)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update Pilot Profile"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnFuture
        '
        Me.btnFuture.Location = New System.Drawing.Point(173, 101)
        Me.btnFuture.Name = "btnFuture"
        Me.btnFuture.Size = New System.Drawing.Size(99, 49)
        Me.btnFuture.TabIndex = 1
        Me.btnFuture.Text = "Show Future Flights"
        Me.btnFuture.UseVisualStyleBackColor = True
        '
        'btnPast
        '
        Me.btnPast.Location = New System.Drawing.Point(173, 29)
        Me.btnPast.Name = "btnPast"
        Me.btnPast.Size = New System.Drawing.Size(99, 49)
        Me.btnPast.TabIndex = 2
        Me.btnPast.Text = "Show Past Flights"
        Me.btnPast.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(32, 120)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(76, 30)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmPilotMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 161)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnPast)
        Me.Controls.Add(Me.btnFuture)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmPilotMainMenu"
        Me.Text = "Pilot Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnFuture As Button
    Friend WithEvents btnPast As Button
    Friend WithEvents btnReturn As Button
End Class
