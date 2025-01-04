<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSelection
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
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(157, 80)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(106, 50)
        Me.btnNewCustomer.TabIndex = 8
        Me.btnNewCustomer.Text = "New Customer"
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(29, 28)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(363, 24)
        Me.cboCustomer.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(285, 80)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(106, 50)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(29, 80)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(106, 50)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmCustomerSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 152)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.cboCustomer)
        Me.Name = "frmCustomerSelection"
        Me.Text = "Customer Selection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewCustomer As Button
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReturn As Button
End Class
