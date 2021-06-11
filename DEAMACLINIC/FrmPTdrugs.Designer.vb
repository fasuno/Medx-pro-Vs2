<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPTdrugs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPTdrugs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtacctcat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOname = New System.Windows.Forms.TextBox()
        Me.txtprescby = New System.Windows.Forms.TextBox()
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTotalcost = New System.Windows.Forms.Label()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btnconfirm = New System.Windows.Forms.Button()
        Me.lbldte = New System.Windows.Forms.Label()
        Me.lbltim = New System.Windows.Forms.Label()
        Me.lblpharm = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblbilledby = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblPayStatus = New System.Windows.Forms.Label()
        Me.txtpercent = New System.Windows.Forms.TextBox()
        Me.txtpresnum = New System.Windows.Forms.TextBox()
        Me.Dgvconsult = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnBill = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgvconsult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txtacctcat)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtOname)
        Me.Panel1.Controls.Add(Me.txtprescby)
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
        Me.Panel1.Location = New System.Drawing.Point(7, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 88)
        Me.Panel1.TabIndex = 0
        '
        'Txtacctcat
        '
        Me.Txtacctcat.BackColor = System.Drawing.Color.White
        Me.Txtacctcat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtacctcat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtacctcat.ForeColor = System.Drawing.Color.Black
        Me.Txtacctcat.Location = New System.Drawing.Point(632, 56)
        Me.Txtacctcat.Name = "Txtacctcat"
        Me.Txtacctcat.ReadOnly = True
        Me.Txtacctcat.Size = New System.Drawing.Size(112, 21)
        Me.Txtacctcat.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(518, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Account Category:"
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
        'txtprescby
        '
        Me.txtprescby.BackColor = System.Drawing.Color.White
        Me.txtprescby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprescby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprescby.ForeColor = System.Drawing.Color.Black
        Me.txtprescby.Location = New System.Drawing.Point(304, 56)
        Me.txtprescby.Name = "txtprescby"
        Me.txtprescby.ReadOnly = True
        Me.txtprescby.Size = New System.Drawing.Size(209, 21)
        Me.txtprescby.TabIndex = 19
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(376, 30)
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
        Me.txtsex.Location = New System.Drawing.Point(247, 30)
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
        Me.TxtSname.Location = New System.Drawing.Point(100, 5)
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
        Me.txtdate.Location = New System.Drawing.Point(100, 54)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(107, 21)
        Me.txtdate.TabIndex = 14
        '
        'txtacct
        '
        Me.txtacct.BackColor = System.Drawing.Color.White
        Me.txtacct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtacct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct.ForeColor = System.Drawing.Color.Black
        Me.txtacct.Location = New System.Drawing.Point(517, 31)
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
        Me.txtHno.Location = New System.Drawing.Point(100, 30)
        Me.txtHno.Name = "txtHno"
        Me.txtHno.ReadOnly = True
        Me.txtHno.Size = New System.Drawing.Size(107, 21)
        Me.txtHno.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(209, 33)
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
        Me.Label2.Location = New System.Drawing.Point(3, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Prescribed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(365, 7)
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
        Me.Label4.Location = New System.Drawing.Point(39, 6)
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
        Me.Label5.Location = New System.Drawing.Point(11, 32)
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
        Me.Label6.Location = New System.Drawing.Point(213, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Prescribed By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(339, 33)
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
        Me.Label8.Location = New System.Drawing.Point(430, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Account type:"
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Green
        Me.BtnSave.Location = New System.Drawing.Point(580, 388)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(96, 27)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "DISPENSE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(15, 425)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 28)
        Me.BtnPrint.TabIndex = 3
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "N"
        '
        'LblTotalcost
        '
        Me.LblTotalcost.AutoSize = True
        Me.LblTotalcost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalcost.ForeColor = System.Drawing.Color.DarkRed
        Me.LblTotalcost.Location = New System.Drawing.Point(270, 429)
        Me.LblTotalcost.Name = "LblTotalcost"
        Me.LblTotalcost.Size = New System.Drawing.Size(21, 19)
        Me.LblTotalcost.TabIndex = 5
        Me.LblTotalcost.Text = " 0"
        '
        'txtpword
        '
        Me.txtpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpword.Location = New System.Drawing.Point(427, 395)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpword.Size = New System.Drawing.Size(150, 20)
        Me.txtpword.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(171, 430)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total Bill :"
        '
        'Btnconfirm
        '
        Me.Btnconfirm.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconfirm.Location = New System.Drawing.Point(15, 426)
        Me.Btnconfirm.Name = "Btnconfirm"
        Me.Btnconfirm.Size = New System.Drawing.Size(76, 28)
        Me.Btnconfirm.TabIndex = 8
        Me.Btnconfirm.Text = "CONFIRM "
        Me.Btnconfirm.UseVisualStyleBackColor = True
        Me.Btnconfirm.Visible = False
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldte.Location = New System.Drawing.Point(619, 9)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(44, 17)
        Me.lbldte.TabIndex = 9
        Me.lbldte.Text = "Date:"
        '
        'lbltim
        '
        Me.lbltim.AutoSize = True
        Me.lbltim.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltim.Location = New System.Drawing.Point(727, 9)
        Me.lbltim.Name = "lbltim"
        Me.lbltim.Size = New System.Drawing.Size(47, 17)
        Me.lbltim.TabIndex = 10
        Me.lbltim.Text = "Time:"
        '
        'lblpharm
        '
        Me.lblpharm.AutoSize = True
        Me.lblpharm.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpharm.Location = New System.Drawing.Point(473, 9)
        Me.lblpharm.Name = "lblpharm"
        Me.lblpharm.Size = New System.Drawing.Size(71, 17)
        Me.lblpharm.TabIndex = 11
        Me.lblpharm.Text = "Pharmacy"
        Me.lblpharm.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(417, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Bill as:"
        Me.Label14.Visible = False
        '
        'lblbilledby
        '
        Me.lblbilledby.AutoSize = True
        Me.lblbilledby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilledby.ForeColor = System.Drawing.Color.Blue
        Me.lblbilledby.Location = New System.Drawing.Point(29, 9)
        Me.lblbilledby.Name = "lblbilledby"
        Me.lblbilledby.Size = New System.Drawing.Size(71, 17)
        Me.lblbilledby.TabIndex = 13
        Me.lblbilledby.Text = "Billed by:"
        Me.lblbilledby.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(167, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Payment Status:"
        Me.Label11.Visible = False
        '
        'LblPayStatus
        '
        Me.LblPayStatus.AutoSize = True
        Me.LblPayStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.LblPayStatus.Location = New System.Drawing.Point(286, 9)
        Me.LblPayStatus.Name = "LblPayStatus"
        Me.LblPayStatus.Size = New System.Drawing.Size(61, 17)
        Me.LblPayStatus.TabIndex = 14
        Me.LblPayStatus.Text = "Pending"
        Me.LblPayStatus.Visible = False
        '
        'txtpercent
        '
        Me.txtpercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpercent.Location = New System.Drawing.Point(97, 430)
        Me.txtpercent.Name = "txtpercent"
        Me.txtpercent.Size = New System.Drawing.Size(32, 20)
        Me.txtpercent.TabIndex = 16
        Me.txtpercent.Visible = False
        '
        'txtpresnum
        '
        Me.txtpresnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpresnum.Location = New System.Drawing.Point(135, 430)
        Me.txtpresnum.Name = "txtpresnum"
        Me.txtpresnum.Size = New System.Drawing.Size(32, 20)
        Me.txtpresnum.TabIndex = 17
        Me.txtpresnum.Visible = False
        '
        'Dgvconsult
        '
        Me.Dgvconsult.AllowUserToAddRows = False
        Me.Dgvconsult.AllowUserToDeleteRows = False
        Me.Dgvconsult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgvconsult.BackgroundColor = System.Drawing.Color.White
        Me.Dgvconsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvconsult.Location = New System.Drawing.Point(7, 168)
        Me.Dgvconsult.Name = "Dgvconsult"
        Me.Dgvconsult.Size = New System.Drawing.Size(803, 214)
        Me.Dgvconsult.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(7, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 29)
        Me.Panel2.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(309, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "SSS"
        '
        'BtnBill
        '
        Me.BtnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBill.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBill.ForeColor = System.Drawing.Color.Blue
        Me.BtnBill.Location = New System.Drawing.Point(681, 388)
        Me.BtnBill.Name = "BtnBill"
        Me.BtnBill.Size = New System.Drawing.Size(121, 27)
        Me.BtnBill.TabIndex = 20
        Me.BtnBill.Text = "RAISE BILL"
        Me.BtnBill.UseVisualStyleBackColor = True
        '
        'FrmPTdrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 419)
        Me.Controls.Add(Me.BtnBill)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Dgvconsult)
        Me.Controls.Add(Me.txtpresnum)
        Me.Controls.Add(Me.txtpercent)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblPayStatus)
        Me.Controls.Add(Me.lblbilledby)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblpharm)
        Me.Controls.Add(Me.lbltim)
        Me.Controls.Add(Me.lbldte)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtpword)
        Me.Controls.Add(Me.LblTotalcost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btnconfirm)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPTdrugs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  DRUGS REQUEST"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgvconsult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtOname As TextBox
    Friend WithEvents txtprescby As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txtacct As TextBox
    Friend WithEvents txtHno As TextBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblTotalcost As Label
    Friend WithEvents txtpword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Btnconfirm As Button
    Friend WithEvents lbldte As Label
    Friend WithEvents lbltim As Label
    Friend WithEvents lblpharm As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblbilledby As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblPayStatus As Label
    Friend WithEvents txtpercent As TextBox
    Friend WithEvents Txtacctcat As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtpresnum As TextBox
    Friend WithEvents Dgvconsult As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnBill As Button
End Class
