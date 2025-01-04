<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMainMenu
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
        Me.btnPilots = New System.Windows.Forms.Button()
        Me.btnAttendants = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPilots
        '
        Me.btnPilots.Location = New System.Drawing.Point(124, 36)
        Me.btnPilots.Name = "btnPilots"
        Me.btnPilots.Size = New System.Drawing.Size(94, 43)
        Me.btnPilots.TabIndex = 0
        Me.btnPilots.Text = "Manage Pilots"
        Me.btnPilots.UseVisualStyleBackColor = True
        '
        'btnAttendants
        '
        Me.btnAttendants.Location = New System.Drawing.Point(238, 36)
        Me.btnAttendants.Name = "btnAttendants"
        Me.btnAttendants.Size = New System.Drawing.Size(94, 43)
        Me.btnAttendants.TabIndex = 1
        Me.btnAttendants.Text = "Manage Attendants"
        Me.btnAttendants.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(10, 36)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 43)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(352, 36)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(94, 43)
        Me.btnStatistics.TabIndex = 3
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'frmAdminMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 113)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAttendants)
        Me.Controls.Add(Me.btnPilots)
        Me.Name = "frmAdminMainMenu"
        Me.Text = "Admin Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPilots As Button
    Friend WithEvents btnAttendants As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnStatistics As Button
End Class
