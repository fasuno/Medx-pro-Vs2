<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRadInv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRadInv))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DtgPtRadInv = New System.Windows.Forms.DataGridView()
        Me.Txtrqstid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.LblTotalcost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOname = New System.Windows.Forms.TextBox()
        Me.txtrqstby = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.TxtSname = New System.Windows.Forms.TextBox()
        Me.txtacct = New System.Windows.Forms.TextBox()
        Me.txtHno = New System.Windows.Forms.TextBox()
        Me.Btnconfirm = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LblPayStat = New System.Windows.Forms.Label()
        Me.lblbilledby = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblrad = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtactcat = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.LblRepdate = New System.Windows.Forms.Label()
        Me.LblRepTim = New System.Windows.Forms.Label()
        Me.LblRepby = New System.Windows.Forms.Label()
        Me.txtpercent = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DtgPtRadInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(8, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(847, 286)
        Me.Panel2.TabIndex = 41
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(841, 270)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DtgPtRadInv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(833, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RADIOLOGY INVESTIGATION"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DtgPtRadInv
        '
        Me.DtgPtRadInv.AllowUserToAddRows = False
        Me.DtgPtRadInv.AllowUserToDeleteRows = False
        Me.DtgPtRadInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgPtRadInv.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPtRadInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgPtRadInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPtRadInv.Location = New System.Drawing.Point(4, 4)
        Me.DtgPtRadInv.Name = "DtgPtRadInv"
        Me.DtgPtRadInv.ReadOnly = True
        Me.DtgPtRadInv.Size = New System.Drawing.Size(825, 232)
        Me.DtgPtRadInv.TabIndex = 0
        '
        'Txtrqstid
        '
        Me.Txtrqstid.BackColor = System.Drawing.Color.White
        Me.Txtrqstid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtrqstid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrqstid.ForeColor = System.Drawing.Color.Black
        Me.Txtrqstid.Location = New System.Drawing.Point(220, 10)
        Me.Txtrqstid.Name = "Txtrqstid"
        Me.Txtrqstid.ReadOnly = True
        Me.Txtrqstid.Size = New System.Drawing.Size(78, 21)
        Me.Txtrqstid.TabIndex = 22
        Me.Txtrqstid.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(146, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Request ID:"
        Me.Label12.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(340, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Total Bill :"
        '
        'txtpword
        '
        Me.txtpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpword.Location = New System.Drawing.Point(554, 430)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpword.Size = New System.Drawing.Size(150, 20)
        Me.txtpword.TabIndex = 46
        '
        'LblTotalcost
        '
        Me.LblTotalcost.AutoSize = True
        Me.LblTotalcost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalcost.ForeColor = System.Drawing.Color.DarkRed
        Me.LblTotalcost.Location = New System.Drawing.Point(439, 431)
        Me.LblTotalcost.Name = "LblTotalcost"
        Me.LblTotalcost.Size = New System.Drawing.Size(17, 19)
        Me.LblTotalcost.TabIndex = 45
        Me.LblTotalcost.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(421, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "N"
        '
        'txtOname
        '
        Me.txtOname.BackColor = System.Drawing.Color.White
        Me.txtOname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOname.ForeColor = System.Drawing.Color.Black
        Me.txtOname.Location = New System.Drawing.Point(455, 5)
        Me.txtOname.Name = "txtOname"
        Me.txtOname.ReadOnly = True
        Me.txtOname.Size = New System.Drawing.Size(339, 21)
        Me.txtOname.TabIndex = 20
        '
        'txtrqstby
        '
        Me.txtrqstby.BackColor = System.Drawing.Color.White
        Me.txtrqstby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrqstby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrqstby.ForeColor = System.Drawing.Color.Black
        Me.txtrqstby.Location = New System.Drawing.Point(307, 56)
        Me.txtrqstby.Name = "txtrqstby"
        Me.txtrqstby.ReadOnly = True
        Me.txtrqstby.Size = New System.Drawing.Size(221, 21)
        Me.txtrqstby.TabIndex = 19
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(432, 30)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(44, 21)
        Me.txtage.TabIndex = 18
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsex.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.ForeColor = System.Drawing.Color.Black
        Me.txtsex.Location = New System.Drawing.Point(308, 30)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(85, 21)
        Me.txtsex.TabIndex = 17
        '
        'TxtSname
        '
        Me.TxtSname.BackColor = System.Drawing.Color.White
        Me.TxtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSname.ForeColor = System.Drawing.Color.Black
        Me.TxtSname.Location = New System.Drawing.Point(109, 5)
        Me.TxtSname.Name = "TxtSname"
        Me.TxtSname.ReadOnly = True
        Me.TxtSname.Size = New System.Drawing.Size(259, 21)
        Me.TxtSname.TabIndex = 16
        '
        'txtacct
        '
        Me.txtacct.BackColor = System.Drawing.Color.White
        Me.txtacct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtacct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct.ForeColor = System.Drawing.Color.Black
        Me.txtacct.Location = New System.Drawing.Point(567, 31)
        Me.txtacct.Name = "txtacct"
        Me.txtacct.ReadOnly = True
        Me.txtacct.Size = New System.Drawing.Size(227, 21)
        Me.txtacct.TabIndex = 13
        '
        'txtHno
        '
        Me.txtHno.BackColor = System.Drawing.Color.White
        Me.txtHno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHno.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHno.ForeColor = System.Drawing.Color.Black
        Me.txtHno.Location = New System.Drawing.Point(110, 30)
        Me.txtHno.Name = "txtHno"
        Me.txtHno.ReadOnly = True
        Me.txtHno.Size = New System.Drawing.Size(158, 21)
        Me.txtHno.TabIndex = 12
        '
        'Btnconfirm
        '
        Me.Btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnconfirm.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconfirm.Location = New System.Drawing.Point(89, 426)
        Me.Btnconfirm.Name = "Btnconfirm"
        Me.Btnconfirm.Size = New System.Drawing.Size(76, 28)
        Me.Btnconfirm.TabIndex = 48
        Me.Btnconfirm.Text = "CONFIRM "
        Me.Btnconfirm.UseVisualStyleBackColor = True
        Me.Btnconfirm.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.Location = New System.Drawing.Point(708, 427)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 27)
        Me.BtnSave.TabIndex = 42
        Me.BtnSave.Text = "SEND FOR PAYMENT"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(274, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Sex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(14, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Requested:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(48, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Surname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(19, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hospital_Num:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(218, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Requested By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(396, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(480, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Account type:"
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(13, 426)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(74, 28)
        Me.BtnPrint.TabIndex = 43
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LblPayStat
        '
        Me.LblPayStat.AutoSize = True
        Me.LblPayStat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayStat.ForeColor = System.Drawing.Color.DarkRed
        Me.LblPayStat.Location = New System.Drawing.Point(421, 11)
        Me.LblPayStat.Name = "LblPayStat"
        Me.LblPayStat.Size = New System.Drawing.Size(61, 17)
        Me.LblPayStat.TabIndex = 39
        Me.LblPayStat.Text = "Pending"
        '
        'lblbilledby
        '
        Me.lblbilledby.AutoSize = True
        Me.lblbilledby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilledby.ForeColor = System.Drawing.Color.Navy
        Me.lblbilledby.Location = New System.Drawing.Point(10, 5)
        Me.lblbilledby.Name = "lblbilledby"
        Me.lblbilledby.Size = New System.Drawing.Size(71, 17)
        Me.lblbilledby.TabIndex = 38
        Me.lblbilledby.Text = "Billed by:"
        Me.lblbilledby.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(497, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Bill as:"
        Me.Label14.Visible = False
        '
        'lblrad
        '
        Me.lblrad.AutoSize = True
        Me.lblrad.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrad.Location = New System.Drawing.Point(553, 19)
        Me.lblrad.Name = "lblrad"
        Me.lblrad.Size = New System.Drawing.Size(73, 17)
        Me.lblrad.TabIndex = 36
        Me.lblrad.Text = "Radiology"
        Me.lblrad.Visible = False
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(740, 10)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(47, 17)
        Me.lbltime.TabIndex = 35
        Me.lbltime.Text = "Time:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(632, 10)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(44, 17)
        Me.lbldate.TabIndex = 34
        Me.lbldate.Text = "Date:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txtactcat)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtOname)
        Me.Panel1.Controls.Add(Me.txtrqstby)
        Me.Panel1.Controls.Add(Me.txtage)
        Me.Panel1.Controls.Add(Me.txtsex)
        Me.Panel1.Controls.Add(Me.TxtSname)
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.Controls.Add(Me.txtacct)
        Me.Panel1.Controls.Add(Me.txtHno)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(29, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 88)
        Me.Panel1.TabIndex = 33
        '
        'Txtactcat
        '
        Me.Txtactcat.BackColor = System.Drawing.Color.White
        Me.Txtactcat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtactcat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtactcat.ForeColor = System.Drawing.Color.Black
        Me.Txtactcat.Location = New System.Drawing.Point(645, 56)
        Me.Txtactcat.Name = "Txtactcat"
        Me.Txtactcat.ReadOnly = True
        Me.Txtactcat.Size = New System.Drawing.Size(149, 21)
        Me.Txtactcat.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(531, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 15)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Account Category:"
        '
        'txtdate
        '
        Me.txtdate.BackColor = System.Drawing.Color.White
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Location = New System.Drawing.Point(110, 56)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(107, 21)
        Me.txtdate.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(372, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Other Names:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(302, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Payment Status:"
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(126, 429)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(24, 20)
        Me.txtresult.TabIndex = 49
        Me.txtresult.Visible = False
        '
        'LblRepdate
        '
        Me.LblRepdate.AutoSize = True
        Me.LblRepdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepdate.Location = New System.Drawing.Point(269, 431)
        Me.LblRepdate.Name = "LblRepdate"
        Me.LblRepdate.Size = New System.Drawing.Size(0, 17)
        Me.LblRepdate.TabIndex = 50
        Me.LblRepdate.Visible = False
        '
        'LblRepTim
        '
        Me.LblRepTim.AutoSize = True
        Me.LblRepTim.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepTim.Location = New System.Drawing.Point(269, 431)
        Me.LblRepTim.Name = "LblRepTim"
        Me.LblRepTim.Size = New System.Drawing.Size(0, 17)
        Me.LblRepTim.TabIndex = 51
        Me.LblRepTim.Visible = False
        '
        'LblRepby
        '
        Me.LblRepby.AutoSize = True
        Me.LblRepby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepby.ForeColor = System.Drawing.Color.Navy
        Me.LblRepby.Location = New System.Drawing.Point(8, 22)
        Me.LblRepby.Name = "LblRepby"
        Me.LblRepby.Size = New System.Drawing.Size(78, 17)
        Me.LblRepby.TabIndex = 52
        Me.LblRepby.Text = "Report by:"
        Me.LblRepby.Visible = False
        '
        'txtpercent
        '
        Me.txtpercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpercent.Location = New System.Drawing.Point(183, 430)
        Me.txtpercent.Name = "txtpercent"
        Me.txtpercent.Size = New System.Drawing.Size(23, 20)
        Me.txtpercent.TabIndex = 53
        Me.txtpercent.Visible = False
        '
        'FrmRadInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(862, 455)
        Me.Controls.Add(Me.Txtrqstid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpercent)
        Me.Controls.Add(Me.LblRepby)
        Me.Controls.Add(Me.LblRepTim)
        Me.Controls.Add(Me.LblRepdate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtpword)
        Me.Controls.Add(Me.LblTotalcost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnconfirm)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.LblPayStat)
        Me.Controls.Add(Me.lblbilledby)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblrad)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtresult)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRadInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   RADIOLOGY BILLING FORM"
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DtgPtRadInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DtgPtRadInv As DataGridView
    Friend WithEvents Txtrqstid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpword As TextBox
    Friend WithEvents LblTotalcost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOname As TextBox
    Friend WithEvents txtrqstby As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents txtacct As TextBox
    Friend WithEvents txtHno As TextBox
    Friend WithEvents Btnconfirm As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents LblPayStat As Label
    Friend WithEvents lblbilledby As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblrad As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtresult As TextBox
    Friend WithEvents LblRepdate As Label
    Friend WithEvents LblRepTim As Label
    Friend WithEvents LblRepby As Label
    Friend WithEvents txtpercent As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents Txtactcat As TextBox
    Friend WithEvents Label15 As Label
End Class
