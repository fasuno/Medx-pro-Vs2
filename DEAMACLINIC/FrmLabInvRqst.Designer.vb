<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLabInvRqst
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabInvRqst))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblPayStatus = New System.Windows.Forms.Label()
        Me.lblbilledby = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbllab = New System.Windows.Forms.Label()
        Me.lbltim = New System.Windows.Forms.Label()
        Me.lbldte = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtacctcat = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOname = New System.Windows.Forms.TextBox()
        Me.txtrqstby = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.TxtSname = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtacct = New System.Windows.Forms.TextBox()
        Me.txtHno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtrqstid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DtgPtLabTest = New System.Windows.Forms.DataGridView()
        Me.Btnconfirm = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.LblTotalcost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Txtperc = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DtgPtLabTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(179, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Payment Status:"
        '
        'LblPayStatus
        '
        Me.LblPayStatus.AutoSize = True
        Me.LblPayStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.LblPayStatus.Location = New System.Drawing.Point(298, 9)
        Me.LblPayStatus.Name = "LblPayStatus"
        Me.LblPayStatus.Size = New System.Drawing.Size(61, 17)
        Me.LblPayStatus.TabIndex = 22
        Me.LblPayStatus.Text = "Pending"
        '
        'lblbilledby
        '
        Me.lblbilledby.AutoSize = True
        Me.lblbilledby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilledby.ForeColor = System.Drawing.Color.Blue
        Me.lblbilledby.Location = New System.Drawing.Point(41, 9)
        Me.lblbilledby.Name = "lblbilledby"
        Me.lblbilledby.Size = New System.Drawing.Size(71, 17)
        Me.lblbilledby.TabIndex = 21
        Me.lblbilledby.Text = "Billed by:"
        Me.lblbilledby.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(372, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Bill as:"
        Me.Label14.Visible = False
        '
        'lbllab
        '
        Me.lbllab.AutoSize = True
        Me.lbllab.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllab.Location = New System.Drawing.Point(428, 9)
        Me.lbllab.Name = "lbllab"
        Me.lbllab.Size = New System.Drawing.Size(80, 17)
        Me.lbllab.TabIndex = 19
        Me.lbllab.Text = "Laboratory"
        Me.lbllab.Visible = False
        '
        'lbltim
        '
        Me.lbltim.AutoSize = True
        Me.lbltim.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltim.ForeColor = System.Drawing.Color.Blue
        Me.lbltim.Location = New System.Drawing.Point(642, 10)
        Me.lbltim.Name = "lbltim"
        Me.lbltim.Size = New System.Drawing.Size(47, 17)
        Me.lbltim.TabIndex = 18
        Me.lbltim.Text = "Time:"
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldte.ForeColor = System.Drawing.Color.Blue
        Me.lbldte.Location = New System.Drawing.Point(534, 10)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(44, 17)
        Me.lbldte.TabIndex = 17
        Me.lbldte.Text = "Date:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txtacctcat)
        Me.Panel1.Controls.Add(Me.Label13)
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
        Me.Panel1.Location = New System.Drawing.Point(28, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 88)
        Me.Panel1.TabIndex = 16
        '
        'Txtacctcat
        '
        Me.Txtacctcat.BackColor = System.Drawing.Color.White
        Me.Txtacctcat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtacctcat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtacctcat.ForeColor = System.Drawing.Color.Black
        Me.Txtacctcat.Location = New System.Drawing.Point(630, 56)
        Me.Txtacctcat.Name = "Txtacctcat"
        Me.Txtacctcat.ReadOnly = True
        Me.Txtacctcat.Size = New System.Drawing.Size(164, 21)
        Me.Txtacctcat.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(520, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Account category:"
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
        Me.txtrqstby.Location = New System.Drawing.Point(290, 57)
        Me.txtrqstby.Name = "txtrqstby"
        Me.txtrqstby.ReadOnly = True
        Me.txtrqstby.Size = New System.Drawing.Size(224, 21)
        Me.txtrqstby.TabIndex = 19
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(430, 30)
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
        'txtdate
        '
        Me.txtdate.BackColor = System.Drawing.Color.White
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Location = New System.Drawing.Point(110, 56)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(89, 21)
        Me.txtdate.TabIndex = 14
        '
        'txtacct
        '
        Me.txtacct.BackColor = System.Drawing.Color.White
        Me.txtacct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtacct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct.ForeColor = System.Drawing.Color.Black
        Me.txtacct.Location = New System.Drawing.Point(580, 30)
        Me.txtacct.Name = "txtacct"
        Me.txtacct.ReadOnly = True
        Me.txtacct.Size = New System.Drawing.Size(214, 21)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(274, 31)
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
        Me.Label5.Location = New System.Drawing.Point(20, 31)
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
        Me.Label6.Location = New System.Drawing.Point(203, 60)
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
        Me.Label7.Location = New System.Drawing.Point(399, 30)
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
        Me.Label8.Location = New System.Drawing.Point(493, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Account type:"
        '
        'Txtrqstid
        '
        Me.Txtrqstid.BackColor = System.Drawing.Color.White
        Me.Txtrqstid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtrqstid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrqstid.ForeColor = System.Drawing.Color.Black
        Me.Txtrqstid.Location = New System.Drawing.Point(797, 9)
        Me.Txtrqstid.Name = "Txtrqstid"
        Me.Txtrqstid.ReadOnly = True
        Me.Txtrqstid.Size = New System.Drawing.Size(26, 21)
        Me.Txtrqstid.TabIndex = 22
        Me.Txtrqstid.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(719, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Request ID:"
        Me.Label12.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(7, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(847, 286)
        Me.Panel2.TabIndex = 24
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
        Me.TabPage1.Controls.Add(Me.DtgPtLabTest)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(833, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LABORATORY INVESTIGATION"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DtgPtLabTest
        '
        Me.DtgPtLabTest.AllowUserToAddRows = False
        Me.DtgPtLabTest.AllowUserToDeleteRows = False
        Me.DtgPtLabTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgPtLabTest.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPtLabTest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgPtLabTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPtLabTest.Location = New System.Drawing.Point(4, 4)
        Me.DtgPtLabTest.Name = "DtgPtLabTest"
        Me.DtgPtLabTest.Size = New System.Drawing.Size(825, 232)
        Me.DtgPtLabTest.TabIndex = 0
        '
        'Btnconfirm
        '
        Me.Btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnconfirm.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconfirm.ForeColor = System.Drawing.Color.Green
        Me.Btnconfirm.Location = New System.Drawing.Point(89, 425)
        Me.Btnconfirm.Name = "Btnconfirm"
        Me.Btnconfirm.Size = New System.Drawing.Size(76, 28)
        Me.Btnconfirm.TabIndex = 32
        Me.Btnconfirm.Text = "CONFIRM "
        Me.Btnconfirm.UseVisualStyleBackColor = True
        Me.Btnconfirm.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(234, 431)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Total Bill :"
        Me.Label10.Visible = False
        '
        'txtpword
        '
        Me.txtpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpword.Location = New System.Drawing.Point(553, 429)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpword.Size = New System.Drawing.Size(150, 20)
        Me.txtpword.TabIndex = 30
        '
        'LblTotalcost
        '
        Me.LblTotalcost.AutoSize = True
        Me.LblTotalcost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalcost.ForeColor = System.Drawing.Color.DarkRed
        Me.LblTotalcost.Location = New System.Drawing.Point(333, 430)
        Me.LblTotalcost.Name = "LblTotalcost"
        Me.LblTotalcost.Size = New System.Drawing.Size(21, 19)
        Me.LblTotalcost.TabIndex = 29
        Me.LblTotalcost.Text = " 0"
        Me.LblTotalcost.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "N"
        Me.Label1.Visible = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(12, 425)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(74, 28)
        Me.BtnPrint.TabIndex = 27
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = True
        Me.BtnPrint.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Green
        Me.BtnSave.Location = New System.Drawing.Point(707, 425)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 27)
        Me.BtnSave.TabIndex = 26
        Me.BtnSave.Text = "SEND FOR PAYMENT"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Txtperc
        '
        Me.Txtperc.BackColor = System.Drawing.Color.White
        Me.Txtperc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtperc.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtperc.ForeColor = System.Drawing.Color.Black
        Me.Txtperc.Location = New System.Drawing.Point(171, 430)
        Me.Txtperc.Name = "Txtperc"
        Me.Txtperc.ReadOnly = True
        Me.Txtperc.Size = New System.Drawing.Size(43, 21)
        Me.Txtperc.TabIndex = 23
        Me.Txtperc.Visible = False
        '
        'FrmLabInvRqst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(855, 455)
        Me.Controls.Add(Me.Txtrqstid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txtperc)
        Me.Controls.Add(Me.Btnconfirm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtpword)
        Me.Controls.Add(Me.LblTotalcost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblPayStatus)
        Me.Controls.Add(Me.lblbilledby)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbllab)
        Me.Controls.Add(Me.lbltim)
        Me.Controls.Add(Me.lbldte)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLabInvRqst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   LABORATORY TEST REQUEST"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DtgPtLabTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents LblPayStatus As Label
    Friend WithEvents lblbilledby As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbllab As Label
    Friend WithEvents lbltim As Label
    Friend WithEvents lbldte As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtOname As TextBox
    Friend WithEvents txtrqstby As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txtacct As TextBox
    Friend WithEvents txtHno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DtgPtLabTest As DataGridView
    Friend WithEvents Btnconfirm As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpword As TextBox
    Friend WithEvents LblTotalcost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Txtrqstid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtperc As TextBox
    Friend WithEvents Txtacctcat As TextBox
    Friend WithEvents Label13 As Label
End Class
