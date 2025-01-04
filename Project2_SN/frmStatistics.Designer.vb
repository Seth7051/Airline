<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistics
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
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFlights = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lstPilots = New System.Windows.Forms.ListBox()
        Me.lstAttendants = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Number of Customers"
        '
        'lblMiles
        '
        Me.lblMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMiles.Location = New System.Drawing.Point(15, 164)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(98, 17)
        Me.lblMiles.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Average Customer Miles Flown"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Flights Taken by All Customers"
        '
        'lblFlights
        '
        Me.lblFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFlights.Location = New System.Drawing.Point(15, 102)
        Me.lblFlights.Name = "lblFlights"
        Me.lblFlights.Size = New System.Drawing.Size(98, 17)
        Me.lblFlights.TabIndex = 6
        '
        'lblCustomers
        '
        Me.lblCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustomers.Location = New System.Drawing.Point(15, 40)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(98, 17)
        Me.lblCustomers.TabIndex = 7
        '
        'lstPilots
        '
        Me.lstPilots.FormattingEnabled = True
        Me.lstPilots.ItemHeight = 16
        Me.lstPilots.Location = New System.Drawing.Point(281, 8)
        Me.lstPilots.Name = "lstPilots"
        Me.lstPilots.Size = New System.Drawing.Size(194, 276)
        Me.lstPilots.TabIndex = 8
        '
        'lstAttendants
        '
        Me.lstAttendants.FormattingEnabled = True
        Me.lstAttendants.ItemHeight = 16
        Me.lstAttendants.Location = New System.Drawing.Point(514, 7)
        Me.lstAttendants.Name = "lstAttendants"
        Me.lstAttendants.Size = New System.Drawing.Size(194, 276)
        Me.lstAttendants.TabIndex = 9
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(12, 240)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(83, 43)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 305)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstAttendants)
        Me.Controls.Add(Me.lstPilots)
        Me.Controls.Add(Me.lblCustomers)
        Me.Controls.Add(Me.lblFlights)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStatistics"
        Me.Text = "Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMiles As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFlights As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents lstPilots As ListBox
    Friend WithEvents lstAttendants As ListBox
    Friend WithEvents btnReturn As Button
End Class
