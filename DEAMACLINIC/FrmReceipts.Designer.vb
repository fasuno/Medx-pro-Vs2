<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReceipts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceipts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtgDetails = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDetails = New System.Windows.Forms.Button()
        Me.Txthnum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtaccnt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtserv = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.Txtservno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcashiername = New System.Windows.Forms.Label()
        Me.LblReceiptnum = New System.Windows.Forms.Label()
        Me.lblpaystat = New System.Windows.Forms.Label()
        Me.btnreprint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cbopaymode = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(213, 9)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(39, 15)
        Me.lbltime.TabIndex = 1
        Me.lbltime.Text = "Time:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(96, 9)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(36, 15)
        Me.lbldate.TabIndex = 2
        Me.lbldate.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hospital Num:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(93, 38)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(258, 22)
        Me.txtname.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DtgDetails)
        Me.Panel1.Location = New System.Drawing.Point(4, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 203)
        Me.Panel1.TabIndex = 5
        '
        'DtgDetails
        '
        Me.DtgDetails.AllowUserToAddRows = False
        Me.DtgDetails.AllowUserToDeleteRows = False
        Me.DtgDetails.BackgroundColor = System.Drawing.Color.White
        Me.DtgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDetails.GridColor = System.Drawing.Color.Black
        Me.DtgDetails.Location = New System.Drawing.Point(6, 6)
        Me.DtgDetails.Name = "DtgDetails"
        Me.DtgDetails.Size = New System.Drawing.Size(374, 190)
        Me.DtgDetails.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Green
        Me.BtnSave.Location = New System.Drawing.Point(304, 409)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(81, 24)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "PRINT"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDetails
        '
        Me.BtnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDetails.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetails.ForeColor = System.Drawing.Color.Blue
        Me.BtnDetails.Location = New System.Drawing.Point(13, 165)
        Me.BtnDetails.Name = "BtnDetails"
        Me.BtnDetails.Size = New System.Drawing.Size(81, 24)
        Me.BtnDetails.TabIndex = 6
        Me.BtnDetails.Text = "DETAILS"
        Me.BtnDetails.UseVisualStyleBackColor = True
        '
        'Txthnum
        '
        Me.Txthnum.BackColor = System.Drawing.Color.White
        Me.Txthnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txthnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txthnum.ForeColor = System.Drawing.Color.Black
        Me.Txthnum.Location = New System.Drawing.Point(93, 62)
        Me.Txthnum.Name = "Txthnum"
        Me.Txthnum.ReadOnly = True
        Me.Txthnum.Size = New System.Drawing.Size(150, 22)
        Me.Txthnum.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Service:"
        '
        'txtaccnt
        '
        Me.txtaccnt.BackColor = System.Drawing.Color.White
        Me.txtaccnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaccnt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccnt.ForeColor = System.Drawing.Color.Black
        Me.txtaccnt.Location = New System.Drawing.Point(93, 87)
        Me.txtaccnt.Name = "txtaccnt"
        Me.txtaccnt.ReadOnly = True
        Me.txtaccnt.Size = New System.Drawing.Size(150, 22)
        Me.txtaccnt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Account Type:"
        '
        'Txtserv
        '
        Me.Txtserv.BackColor = System.Drawing.Color.White
        Me.Txtserv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtserv.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtserv.ForeColor = System.Drawing.Color.Black
        Me.Txtserv.Location = New System.Drawing.Point(93, 111)
        Me.Txtserv.Name = "Txtserv"
        Me.Txtserv.ReadOnly = True
        Me.Txtserv.Size = New System.Drawing.Size(150, 22)
        Me.Txtserv.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(201, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Bill:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(260, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "N"
        '
        'lblBill
        '
        Me.lblBill.AutoSize = True
        Me.lblBill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBill.ForeColor = System.Drawing.Color.DarkRed
        Me.lblBill.Location = New System.Drawing.Point(279, 167)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(13, 19)
        Me.lblBill.TabIndex = 16
        Me.lblBill.Text = " "
        '
        'Txtservno
        '
        Me.Txtservno.BackColor = System.Drawing.Color.White
        Me.Txtservno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtservno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtservno.ForeColor = System.Drawing.Color.Black
        Me.Txtservno.Location = New System.Drawing.Point(312, 111)
        Me.Txtservno.Name = "Txtservno"
        Me.Txtservno.ReadOnly = True
        Me.Txtservno.Size = New System.Drawing.Size(76, 22)
        Me.Txtservno.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(244, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Service No."
        '
        'Txtpassword
        '
        Me.Txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpassword.Location = New System.Drawing.Point(112, 411)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpassword.Size = New System.Drawing.Size(187, 20)
        Me.Txtpassword.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(17, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Enter password:"
        '
        'lblcashiername
        '
        Me.lblcashiername.AutoSize = True
        Me.lblcashiername.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcashiername.Location = New System.Drawing.Point(284, 69)
        Me.lblcashiername.Name = "lblcashiername"
        Me.lblcashiername.Size = New System.Drawing.Size(79, 15)
        Me.lblcashiername.TabIndex = 21
        Me.lblcashiername.Text = "Casher name"
        Me.lblcashiername.Visible = False
        '
        'LblReceiptnum
        '
        Me.LblReceiptnum.AutoSize = True
        Me.LblReceiptnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceiptnum.Location = New System.Drawing.Point(108, 169)
        Me.LblReceiptnum.Name = "LblReceiptnum"
        Me.LblReceiptnum.Size = New System.Drawing.Size(75, 15)
        Me.LblReceiptnum.TabIndex = 22
        Me.LblReceiptnum.Text = "Receipt num"
        Me.LblReceiptnum.Visible = False
        '
        'lblpaystat
        '
        Me.lblpaystat.AutoSize = True
        Me.lblpaystat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaystat.Location = New System.Drawing.Point(10, 9)
        Me.lblpaystat.Name = "lblpaystat"
        Me.lblpaystat.Size = New System.Drawing.Size(31, 15)
        Me.lblpaystat.TabIndex = 23
        Me.lblpaystat.Text = "Paid"
        Me.lblpaystat.Visible = False
        '
        'btnreprint
        '
        Me.btnreprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreprint.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreprint.ForeColor = System.Drawing.Color.Green
        Me.btnreprint.Location = New System.Drawing.Point(304, 409)
        Me.btnreprint.Name = "btnreprint"
        Me.btnreprint.Size = New System.Drawing.Size(81, 24)
        Me.btnreprint.TabIndex = 24
        Me.btnreprint.Text = "REPRINT"
        Me.btnreprint.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Mode of Payment:"
        '
        'Cbopaymode
        '
        Me.Cbopaymode.FormattingEnabled = True
        Me.Cbopaymode.Items.AddRange(New Object() {"CASH", "POS", "TRANSFER", "CHEQUE"})
        Me.Cbopaymode.Location = New System.Drawing.Point(112, 137)
        Me.Cbopaymode.Name = "Cbopaymode"
        Me.Cbopaymode.Size = New System.Drawing.Size(231, 21)
        Me.Cbopaymode.TabIndex = 28
        '
        'FrmReceipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 435)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cbopaymode)
        Me.Controls.Add(Me.lblpaystat)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblReceiptnum)
        Me.Controls.Add(Me.lblcashiername)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txtservno)
        Me.Controls.Add(Me.lblBill)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txtserv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtaccnt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txthnum)
        Me.Controls.Add(Me.BtnDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreprint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  RECEIPT"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DtgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDetails As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Txthnum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaccnt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtserv As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBill As Label
    Friend WithEvents DtgDetails As DataGridView
    Friend WithEvents Txtservno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcashiername As Label
    Friend WithEvents LblReceiptnum As Label
    Friend WithEvents lblpaystat As Label
    Friend WithEvents btnreprint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Cbopaymode As ComboBox
End Class
