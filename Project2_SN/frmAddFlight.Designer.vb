<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFlight
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.cboSeat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFutureFlights = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.lblFromAirport = New System.Windows.Forms.Label()
        Me.lblToAirport = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Flight #"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(190, 351)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(85, 40)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(43, 351)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(85, 40)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'cboSeat
        '
        Me.cboSeat.FormattingEnabled = True
        Me.cboSeat.Items.AddRange(New Object() {"1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B", "5A", "5B", "6A", "6B"})
        Me.cboSeat.Location = New System.Drawing.Point(78, 285)
        Me.cboSeat.Name = "cboSeat"
        Me.cboSeat.Size = New System.Drawing.Size(121, 24)
        Me.cboSeat.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Seat:"
        '
        'cboFutureFlights
        '
        Me.cboFutureFlights.FormattingEnabled = True
        Me.cboFutureFlights.Location = New System.Drawing.Point(139, 26)
        Me.cboFutureFlights.Name = "cboFutureFlights"
        Me.cboFutureFlights.Size = New System.Drawing.Size(97, 24)
        Me.cboFutureFlights.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "From:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Departure Time:"
        '
        'lblDeparture
        '
        Me.lblDeparture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeparture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeparture.Location = New System.Drawing.Point(154, 93)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(131, 20)
        Me.lblDeparture.TabIndex = 17
        '
        'lblFromAirport
        '
        Me.lblFromAirport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFromAirport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromAirport.Location = New System.Drawing.Point(78, 181)
        Me.lblFromAirport.Name = "lblFromAirport"
        Me.lblFromAirport.Size = New System.Drawing.Size(150, 20)
        Me.lblFromAirport.TabIndex = 18
        '
        'lblToAirport
        '
        Me.lblToAirport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToAirport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToAirport.Location = New System.Drawing.Point(78, 229)
        Me.lblToAirport.Name = "lblToAirport"
        Me.lblToAirport.Size = New System.Drawing.Size(150, 20)
        Me.lblToAirport.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(78, 144)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(150, 23)
        Me.lblDate.TabIndex = 21
        '
        'frmAddFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 428)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblToAirport)
        Me.Controls.Add(Me.lblFromAirport)
        Me.Controls.Add(Me.lblDeparture)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.cboSeat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboFutureFlights)
        Me.Name = "frmAddFlight"
        Me.Text = "Book Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents cboSeat As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFutureFlights As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDeparture As Label
    Friend WithEvents lblFromAirport As Label
    Friend WithEvents lblToAirport As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDate As Label
End Class
