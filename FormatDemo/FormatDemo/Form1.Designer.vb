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
        Me.btnEntry = New System.Windows.Forms.Label()
        Me.btnFormatted = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.btnNumberF = New System.Windows.Forms.Button()
        Me.btnFixedF = New System.Windows.Forms.Button()
        Me.btnExpo = New System.Windows.Forms.Button()
        Me.btnCurrency = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnLDate = New System.Windows.Forms.Button()
        Me.btnLTime = New System.Windows.Forms.Button()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnDateAndTime = New System.Windows.Forms.Button()
        Me.btnSTime = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEntry
        '
        Me.btnEntry.AutoSize = True
        Me.btnEntry.Location = New System.Drawing.Point(19, 33)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(115, 13)
        Me.btnEntry.TabIndex = 0
        Me.btnEntry.Text = "Enter a number or date"
        '
        'btnFormatted
        '
        Me.btnFormatted.AutoSize = True
        Me.btnFormatted.Location = New System.Drawing.Point(19, 91)
        Me.btnFormatted.Name = "btnFormatted"
        Me.btnFormatted.Size = New System.Drawing.Size(54, 13)
        Me.btnFormatted.TabIndex = 1
        Me.btnFormatted.Text = "Formatted"
        '
        'lblFormat
        '
        Me.lblFormat.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblFormat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFormat.Location = New System.Drawing.Point(212, 90)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(207, 23)
        Me.lblFormat.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSTime)
        Me.GroupBox1.Controls.Add(Me.btnDateAndTime)
        Me.GroupBox1.Controls.Add(Me.btnDate)
        Me.GroupBox1.Controls.Add(Me.btnLTime)
        Me.GroupBox1.Controls.Add(Me.btnLDate)
        Me.GroupBox1.Controls.Add(Me.btnNumberF)
        Me.GroupBox1.Controls.Add(Me.btnFixedF)
        Me.GroupBox1.Controls.Add(Me.btnExpo)
        Me.GroupBox1.Controls.Add(Me.btnCurrency)
        Me.GroupBox1.Controls.Add(Me.btnPercent)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 226)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(212, 30)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtUserEntry.TabIndex = 4
        '
        'btnNumberF
        '
        Me.btnNumberF.Location = New System.Drawing.Point(37, 29)
        Me.btnNumberF.Name = "btnNumberF"
        Me.btnNumberF.Size = New System.Drawing.Size(111, 23)
        Me.btnNumberF.TabIndex = 5
        Me.btnNumberF.Text = "Number format (n)"
        Me.btnNumberF.UseVisualStyleBackColor = True
        '
        'btnFixedF
        '
        Me.btnFixedF.Location = New System.Drawing.Point(37, 68)
        Me.btnFixedF.Name = "btnFixedF"
        Me.btnFixedF.Size = New System.Drawing.Size(111, 23)
        Me.btnFixedF.TabIndex = 6
        Me.btnFixedF.Text = "Fixed-point format(f)"
        Me.btnFixedF.UseVisualStyleBackColor = True
        '
        'btnExpo
        '
        Me.btnExpo.Location = New System.Drawing.Point(37, 115)
        Me.btnExpo.Name = "btnExpo"
        Me.btnExpo.Size = New System.Drawing.Size(111, 23)
        Me.btnExpo.TabIndex = 7
        Me.btnExpo.Text = "Exponential format (e)"
        Me.btnExpo.UseVisualStyleBackColor = True
        '
        'btnCurrency
        '
        Me.btnCurrency.Location = New System.Drawing.Point(37, 158)
        Me.btnCurrency.Name = "btnCurrency"
        Me.btnCurrency.Size = New System.Drawing.Size(111, 23)
        Me.btnCurrency.TabIndex = 8
        Me.btnCurrency.Text = "Currency Format (c)"
        Me.btnCurrency.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Location = New System.Drawing.Point(37, 203)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(111, 23)
        Me.btnPercent.TabIndex = 9
        Me.btnPercent.Text = "Percent Format (p)"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'btnLDate
        '
        Me.btnLDate.Location = New System.Drawing.Point(270, 68)
        Me.btnLDate.Name = "btnLDate"
        Me.btnLDate.Size = New System.Drawing.Size(113, 23)
        Me.btnLDate.TabIndex = 10
        Me.btnLDate.Text = "Long Date (D)"
        Me.btnLDate.UseVisualStyleBackColor = True
        '
        'btnLTime
        '
        Me.btnLTime.Location = New System.Drawing.Point(270, 158)
        Me.btnLTime.Name = "btnLTime"
        Me.btnLTime.Size = New System.Drawing.Size(113, 23)
        Me.btnLTime.TabIndex = 11
        Me.btnLTime.Text = "Long Time (T)"
        Me.btnLTime.UseVisualStyleBackColor = True
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(270, 29)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(113, 23)
        Me.btnDate.TabIndex = 12
        Me.btnDate.Text = "Short Date (d)"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnDateAndTime
        '
        Me.btnDateAndTime.Location = New System.Drawing.Point(270, 197)
        Me.btnDateAndTime.Name = "btnDateAndTime"
        Me.btnDateAndTime.Size = New System.Drawing.Size(113, 23)
        Me.btnDateAndTime.TabIndex = 13
        Me.btnDateAndTime.Text = "Full Date/Time (F)"
        Me.btnDateAndTime.UseVisualStyleBackColor = True
        '
        'btnSTime
        '
        Me.btnSTime.Location = New System.Drawing.Point(270, 115)
        Me.btnSTime.Name = "btnSTime"
        Me.btnSTime.Size = New System.Drawing.Size(113, 23)
        Me.btnSTime.TabIndex = 14
        Me.btnSTime.Text = "Short Time (t)"
        Me.btnSTime.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(466, 478)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.btnFormatted)
        Me.Controls.Add(Me.btnEntry)
        Me.Name = "Form1"
        Me.Text = "Format Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEntry As System.Windows.Forms.Label
    Friend WithEvents btnFormatted As System.Windows.Forms.Label
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserEntry As System.Windows.Forms.TextBox
    Friend WithEvents btnNumberF As System.Windows.Forms.Button
    Friend WithEvents btnFixedF As System.Windows.Forms.Button
    Friend WithEvents btnExpo As System.Windows.Forms.Button
    Friend WithEvents btnCurrency As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnLDate As System.Windows.Forms.Button
    Friend WithEvents btnLTime As System.Windows.Forms.Button
    Friend WithEvents btnDateAndTime As System.Windows.Forms.Button
    Friend WithEvents btnDate As System.Windows.Forms.Button
    Friend WithEvents btnSTime As System.Windows.Forms.Button

End Class
