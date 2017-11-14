<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblRmCharge = New System.Windows.Forms.Label()
        Me.lblAddCharge = New System.Windows.Forms.Label()
        Me.lblSbTot = New System.Windows.Forms.Label()
        Me.lblTx = New System.Windows.Forms.Label()
        Me.lblTotchrg = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highlander Hotel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNightlyCharge)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.lblCharge)
        Me.GroupBox1.Controls.Add(Me.lblNights)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtRoomService)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Controls.Add(Me.lblTotchrg)
        Me.GroupBox3.Controls.Add(Me.lblTx)
        Me.GroupBox3.Controls.Add(Me.lblSbTot)
        Me.GroupBox3.Controls.Add(Me.lblAddCharge)
        Me.GroupBox3.Controls.Add(Me.lblRmCharge)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblTotalCharges)
        Me.GroupBox3.Controls.Add(Me.lblAddCharges)
        Me.GroupBox3.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox3.Location = New System.Drawing.Point(134, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 197)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(71, 96)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(71, 62)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(73, 13)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Today's Date:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Location = New System.Drawing.Point(239, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 23)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(239, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 23)
        Me.Label3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 0
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Location = New System.Drawing.Point(26, 26)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(40, 13)
        Me.lblNights.TabIndex = 0
        Me.lblNights.Text = "Nights:"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(13, 63)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(79, 13)
        Me.lblCharge.TabIndex = 1
        Me.lblCharge.Text = "Nightly Charge:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Room Service:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Telephone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Misc:"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(94, 26)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 2
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(94, 63)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtNightlyCharge.TabIndex = 3
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(94, 19)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomService.TabIndex = 4
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(94, 47)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 5
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(94, 74)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 20)
        Me.txtMisc.TabIndex = 6
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.AutoSize = True
        Me.lblRoomCharges.Location = New System.Drawing.Point(24, 38)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(80, 13)
        Me.lblRoomCharges.TabIndex = 0
        Me.lblRoomCharges.Text = "Room Charges:"
        '
        'lblAddCharges
        '
        Me.lblAddCharges.AutoSize = True
        Me.lblAddCharges.Location = New System.Drawing.Point(24, 68)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(96, 13)
        Me.lblAddCharges.TabIndex = 8
        Me.lblAddCharges.Text = "Additonal Charges:"
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.AutoSize = True
        Me.lblTotalCharges.Location = New System.Drawing.Point(24, 168)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(76, 13)
        Me.lblTotalCharges.TabIndex = 9
        Me.lblTotalCharges.Text = "Total Charges:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(24, 129)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 10
        Me.lblTax.Text = "Tax:"
        '
        'lblRmCharge
        '
        Me.lblRmCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRmCharge.Location = New System.Drawing.Point(162, 28)
        Me.lblRmCharge.Name = "lblRmCharge"
        Me.lblRmCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblRmCharge.TabIndex = 11
        '
        'lblAddCharge
        '
        Me.lblAddCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddCharge.Location = New System.Drawing.Point(162, 68)
        Me.lblAddCharge.Name = "lblAddCharge"
        Me.lblAddCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblAddCharge.TabIndex = 12
        '
        'lblSbTot
        '
        Me.lblSbTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSbTot.Location = New System.Drawing.Point(162, 95)
        Me.lblSbTot.Name = "lblSbTot"
        Me.lblSbTot.Size = New System.Drawing.Size(100, 23)
        Me.lblSbTot.TabIndex = 13
        '
        'lblTx
        '
        Me.lblTx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTx.Location = New System.Drawing.Point(162, 128)
        Me.lblTx.Name = "lblTx"
        Me.lblTx.Size = New System.Drawing.Size(100, 23)
        Me.lblTx.TabIndex = 14
        '
        'lblTotchrg
        '
        Me.lblTotchrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotchrg.Location = New System.Drawing.Point(162, 168)
        Me.lblTotchrg.Name = "lblTotchrg"
        Me.lblTotchrg.Size = New System.Drawing.Size(100, 23)
        Me.lblTotchrg.TabIndex = 15
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(27, 95)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubTotal.TabIndex = 16
        Me.lblSubTotal.Text = "Subtotal:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(57, 447)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(118, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(217, 447)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 446)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(545, 482)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Room Charge Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblCharge As System.Windows.Forms.Label
    Friend WithEvents lblNights As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents lblAddCharges As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents lblTotchrg As System.Windows.Forms.Label
    Friend WithEvents lblTx As System.Windows.Forms.Label
    Friend WithEvents lblSbTot As System.Windows.Forms.Label
    Friend WithEvents lblAddCharge As System.Windows.Forms.Label
    Friend WithEvents lblRmCharge As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
