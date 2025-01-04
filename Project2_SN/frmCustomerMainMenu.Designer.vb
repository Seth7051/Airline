<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMainMenu
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
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.btnFutureFlights = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(56, 12)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(106, 50)
        Me.btnAddFlight.TabIndex = 1
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'btnFutureFlights
        '
        Me.btnFutureFlights.Location = New System.Drawing.Point(228, 91)
        Me.btnFutureFlights.Name = "btnFutureFlights"
        Me.btnFutureFlights.Size = New System.Drawing.Size(106, 49)
        Me.btnFutureFlights.TabIndex = 2
        Me.btnFutureFlights.Text = "Show Future Flights"
        Me.btnFutureFlights.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(228, 13)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 49)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update Customer"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(56, 91)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(106, 49)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "Show Past Flights"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(5, 165)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmCustomerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 203)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFutureFlights)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Name = "frmCustomerMainMenu"
        Me.Text = "Customer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnFutureFlights As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnReturn As Button
End Class
