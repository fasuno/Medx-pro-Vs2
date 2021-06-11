<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCashreceipt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCashreceipt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtIme = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cbopaymode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtservice = New System.Windows.Forms.TextBox()
        Me.lblreceiptnum = New System.Windows.Forms.Label()
        Me.LblTidnum = New System.Windows.Forms.Label()
        Me.Btnremoveserv = New System.Windows.Forms.Button()
        Me.lblTID = New System.Windows.Forms.Label()
        Me.BtnAddservice = New System.Windows.Forms.Button()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Txtfullname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtgServices = New System.Windows.Forms.DataGridView()
        Me.Service = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblcashiername = New System.Windows.Forms.Label()
        Me.Txtpassw = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtIme)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Cbopaymode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblBill)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtamount)
        Me.Panel1.Controls.Add(Me.txtservice)
        Me.Panel1.Controls.Add(Me.lblreceiptnum)
        Me.Panel1.Controls.Add(Me.LblTidnum)
        Me.Panel1.Controls.Add(Me.Btnremoveserv)
        Me.Panel1.Controls.Add(Me.lblTID)
        Me.Panel1.Controls.Add(Me.BtnAddservice)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.Txtfullname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DtgServices)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 349)
        Me.Panel1.TabIndex = 0
        '
        'dtIme
        '
        Me.dtIme.Location = New System.Drawing.Point(294, 14)
        Me.dtIme.Name = "dtIme"
        Me.dtIme.ShowUpDown = True
        Me.dtIme.Size = New System.Drawing.Size(85, 20)
        Me.dtIme.TabIndex = 28
        Me.dtIme.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Mode of Payment:"
        '
        'Cbopaymode
        '
        Me.Cbopaymode.FormattingEnabled = True
        Me.Cbopaymode.Items.AddRange(New Object() {"CASH", "POS", "TRANSFER", "CHEQUE"})
        Me.Cbopaymode.Location = New System.Drawing.Point(113, 95)
        Me.Cbopaymode.Name = "Cbopaymode"
        Me.Cbopaymode.Size = New System.Drawing.Size(231, 21)
        Me.Cbopaymode.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "N"
        '
        'lblBill
        '
        Me.lblBill.AutoSize = True
        Me.lblBill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBill.ForeColor = System.Drawing.Color.DarkRed
        Me.lblBill.Location = New System.Drawing.Point(86, 323)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(21, 19)
        Me.lblBill.TabIndex = 19
        Me.lblBill.Text = " 0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "N"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Service:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total Bill:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Amount:"
        '
        'txtamount
        '
        Me.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtamount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(85, 141)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(129, 22)
        Me.txtamount.TabIndex = 21
        Me.txtamount.Text = " "
        '
        'txtservice
        '
        Me.txtservice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtservice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtservice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtservice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtservice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservice.Location = New System.Drawing.Point(85, 68)
        Me.txtservice.Name = "txtservice"
        Me.txtservice.Size = New System.Drawing.Size(259, 22)
        Me.txtservice.TabIndex = 20
        '
        'lblreceiptnum
        '
        Me.lblreceiptnum.AutoSize = True
        Me.lblreceiptnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreceiptnum.Location = New System.Drawing.Point(271, 0)
        Me.lblreceiptnum.Name = "lblreceiptnum"
        Me.lblreceiptnum.Size = New System.Drawing.Size(40, 15)
        Me.lblreceiptnum.TabIndex = 19
        Me.lblreceiptnum.Text = "Rnum"
        Me.lblreceiptnum.Visible = False
        '
        'LblTidnum
        '
        Me.LblTidnum.AutoSize = True
        Me.LblTidnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTidnum.Location = New System.Drawing.Point(351, -1)
        Me.LblTidnum.Name = "LblTidnum"
        Me.LblTidnum.Size = New System.Drawing.Size(28, 15)
        Me.LblTidnum.TabIndex = 18
        Me.LblTidnum.Text = "000"
        Me.LblTidnum.Visible = False
        '
        'Btnremoveserv
        '
        Me.Btnremoveserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnremoveserv.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnremoveserv.ForeColor = System.Drawing.Color.DarkRed
        Me.Btnremoveserv.Location = New System.Drawing.Point(313, 139)
        Me.Btnremoveserv.Name = "Btnremoveserv"
        Me.Btnremoveserv.Size = New System.Drawing.Size(87, 25)
        Me.Btnremoveserv.TabIndex = 13
        Me.Btnremoveserv.Text = "REMOVE"
        Me.Btnremoveserv.UseVisualStyleBackColor = True
        '
        'lblTID
        '
        Me.lblTID.AutoSize = True
        Me.lblTID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTID.Location = New System.Drawing.Point(317, -1)
        Me.lblTID.Name = "lblTID"
        Me.lblTID.Size = New System.Drawing.Size(28, 15)
        Me.lblTID.TabIndex = 17
        Me.lblTID.Text = "TID"
        Me.lblTID.Visible = False
        '
        'BtnAddservice
        '
        Me.BtnAddservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddservice.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddservice.ForeColor = System.Drawing.Color.Green
        Me.BtnAddservice.Location = New System.Drawing.Point(219, 139)
        Me.BtnAddservice.Name = "BtnAddservice"
        Me.BtnAddservice.Size = New System.Drawing.Size(92, 25)
        Me.BtnAddservice.TabIndex = 12
        Me.BtnAddservice.Text = "ADD SERVICE"
        Me.BtnAddservice.UseVisualStyleBackColor = True
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(190, 9)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(39, 15)
        Me.lbltime.TabIndex = 11
        Me.lbltime.Text = "Time:"
        Me.lbltime.Visible = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(88, 9)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(36, 15)
        Me.lbldate.TabIndex = 10
        Me.lbldate.Text = "Date:"
        Me.lbldate.Visible = False
        '
        'Txtfullname
        '
        Me.Txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtfullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtfullname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfullname.Location = New System.Drawing.Point(85, 40)
        Me.Txtfullname.Name = "Txtfullname"
        Me.Txtfullname.Size = New System.Drawing.Size(259, 22)
        Me.Txtfullname.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FULL NAME:"
        '
        'DtgServices
        '
        Me.DtgServices.AllowUserToAddRows = False
        Me.DtgServices.BackgroundColor = System.Drawing.Color.White
        Me.DtgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Service, Me.Amount, Me.ServID})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgServices.DefaultCellStyle = DataGridViewCellStyle1
        Me.DtgServices.Location = New System.Drawing.Point(3, 174)
        Me.DtgServices.Name = "DtgServices"
        Me.DtgServices.ReadOnly = True
        Me.DtgServices.Size = New System.Drawing.Size(397, 137)
        Me.DtgServices.TabIndex = 7
        '
        'Service
        '
        Me.Service.HeaderText = "SERVICE"
        Me.Service.Name = "Service"
        Me.Service.ReadOnly = True
        Me.Service.Width = 200
        '
        'Amount
        '
        Me.Amount.HeaderText = "AMOUNT"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'ServID
        '
        Me.ServID.HeaderText = "Service_No"
        Me.ServID.Name = "ServID"
        Me.ServID.ReadOnly = True
        Me.ServID.Visible = False
        '
        'lblcashiername
        '
        Me.lblcashiername.AutoSize = True
        Me.lblcashiername.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcashiername.Location = New System.Drawing.Point(13, 366)
        Me.lblcashiername.Name = "lblcashiername"
        Me.lblcashiername.Size = New System.Drawing.Size(79, 15)
        Me.lblcashiername.TabIndex = 16
        Me.lblcashiername.Text = "Casher name"
        Me.lblcashiername.Visible = False
        '
        'Txtpassw
        '
        Me.Txtpassw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpassw.Location = New System.Drawing.Point(105, 360)
        Me.Txtpassw.Name = "Txtpassw"
        Me.Txtpassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpassw.Size = New System.Drawing.Size(151, 20)
        Me.Txtpassw.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Green
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(262, 357)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(69, 25)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(7, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Enter password:"
        '
        'Btnclose
        '
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclose.ForeColor = System.Drawing.Color.DarkRed
        Me.Btnclose.Location = New System.Drawing.Point(335, 356)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(69, 25)
        Me.Btnclose.TabIndex = 15
        Me.Btnclose.Text = "CANCEL"
        Me.Btnclose.UseVisualStyleBackColor = True
        '
        'FrmCashreceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 385)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Txtpassw)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblcashiername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCashreceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  NEW CASH RECEIPT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DtgServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Txtfullname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtgServices As DataGridView
    Friend WithEvents Btnremoveserv As Button
    Friend WithEvents BtnAddservice As Button
    Friend WithEvents Txtpassw As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnclose As Button
    Friend WithEvents lblcashiername As Label
    Friend WithEvents lblTID As Label
    Friend WithEvents LblTidnum As Label
    Friend WithEvents lblBill As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblreceiptnum As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents txtservice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Service As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents ServID As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Cbopaymode As ComboBox
    Friend WithEvents dtIme As DateTimePicker
End Class
