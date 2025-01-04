<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantMainMenu
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnPast = New System.Windows.Forms.Button()
        Me.btnFuture = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(21, 121)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(76, 30)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnPast
        '
        Me.btnPast.Location = New System.Drawing.Point(162, 30)
        Me.btnPast.Name = "btnPast"
        Me.btnPast.Size = New System.Drawing.Size(108, 66)
        Me.btnPast.TabIndex = 6
        Me.btnPast.Text = "Show Past Flights"
        Me.btnPast.UseVisualStyleBackColor = True
        '
        'btnFuture
        '
        Me.btnFuture.Location = New System.Drawing.Point(162, 102)
        Me.btnFuture.Name = "btnFuture"
        Me.btnFuture.Size = New System.Drawing.Size(108, 66)
        Me.btnFuture.TabIndex = 5
        Me.btnFuture.Text = "Show Future Flights"
        Me.btnFuture.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(21, 30)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 66)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Attendant Profile"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmAttendantMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 183)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnPast)
        Me.Controls.Add(Me.btnFuture)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmAttendantMainMenu"
        Me.Text = "Attendant Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnPast As Button
    Friend WithEvents btnFuture As Button
    Friend WithEvents btnUpdate As Button
End Class
