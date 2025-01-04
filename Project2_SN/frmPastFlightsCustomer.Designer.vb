<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPastFlightsCustomer
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
        Me.lstFlights = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstFlights
        '
        Me.lstFlights.FormattingEnabled = True
        Me.lstFlights.ItemHeight = 16
        Me.lstFlights.Location = New System.Drawing.Point(28, 21)
        Me.lstFlights.Name = "lstFlights"
        Me.lstFlights.Size = New System.Drawing.Size(239, 292)
        Me.lstFlights.TabIndex = 0
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(12, 394)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(86, 32)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Miles Flown:"
        '
        'lblMiles
        '
        Me.lblMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMiles.Location = New System.Drawing.Point(167, 336)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(100, 23)
        Me.lblMiles.TabIndex = 4
        '
        'frmPastFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 438)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstFlights)
        Me.Name = "frmPastFlights"
        Me.Text = "Past Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstFlights As ListBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMiles As Label
End Class
