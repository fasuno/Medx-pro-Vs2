<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDrugsbill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDrugsbill))
        Me.lblbilledby = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DtgDrugbill = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.LblTotalcost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtacctcat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdatebill = New System.Windows.Forms.Label()
        Me.txtOthername = New System.Windows.Forms.TextBox()
        Me.txtpresby = New System.Windows.Forms.TextBox()
        Me.txtbilledby = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.TxtSurname = New System.Windows.Forms.TextBox()
        Me.txtaccnt = New System.Windows.Forms.TextBox()
        Me.txtHnum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblPaymentstatus = New System.Windows.Forms.Label()
        Me.lblpay = New System.Windows.Forms.Label()
        Me.lblrqstid = New System.Windows.Forms.Label()
        Me.lblconfirmby = New System.Windows.Forms.Label()
        Me.lbldte = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DtgDrugbill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblbilledby
        '
        Me.lblbilledby.AutoSize = True
        Me.lblbilledby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilledby.ForeColor = System.Drawing.Color.Blue
        Me.lblbilledby.Location = New System.Drawing.Point(8, 55)
        Me.lblbilledby.Name = "lblbilledby"
        Me.lblbilledby.Size = New System.Drawing.Size(105, 17)
        Me.lblbilledby.TabIndex = 28
        Me.lblbilledby.Text = "Dispensed  by:"
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
        Me.TabPage1.Controls.Add(Me.DtgDrugbill)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(833, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DRUGS PRESCRIPTION"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DtgDrugbill
        '
        Me.DtgDrugbill.AllowUserToAddRows = False
        Me.DtgDrugbill.AllowUserToDeleteRows = False
        Me.DtgDrugbill.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgDrugbill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgDrugbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDrugbill.Location = New System.Drawing.Point(4, 4)
        Me.DtgDrugbill.Name = "DtgDrugbill"
        Me.DtgDrugbill.ReadOnly = True
        Me.DtgDrugbill.Size = New System.Drawing.Size(825, 232)
        Me.DtgDrugbill.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(272, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total Bill :"
        '
        'txtpword
        '
        Me.txtpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpword.Location = New System.Drawing.Point(511, 430)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpword.Size = New System.Drawing.Size(150, 20)
        Me.txtpword.TabIndex = 21
        '
        'LblTotalcost
        '
        Me.LblTotalcost.AutoSize = True
        Me.LblTotalcost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalcost.ForeColor = System.Drawing.Color.Red
        Me.LblTotalcost.Location = New System.Drawing.Point(376, 431)
        Me.LblTotalcost.Name = "LblTotalcost"
        Me.LblTotalcost.Size = New System.Drawing.Size(21, 19)
        Me.LblTotalcost.TabIndex = 20
        Me.LblTotalcost.Text = " 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "N"
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(8, 427)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(74, 28)
        Me.BtnPrint.TabIndex = 18
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Green
        Me.BtnSave.Location = New System.Drawing.Point(665, 426)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 27)
        Me.BtnSave.TabIndex = 17
        Me.BtnSave.Text = "CONFIRM PAYMENT"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(4, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(847, 286)
        Me.Panel2.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txtacctcat)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtOthername)
        Me.Panel1.Controls.Add(Me.txtpresby)
        Me.Panel1.Controls.Add(Me.txtbilledby)
        Me.Panel1.Controls.Add(Me.lblbilledby)
        Me.Panel1.Controls.Add(Me.txtage)
        Me.Panel1.Controls.Add(Me.txtsex)
        Me.Panel1.Controls.Add(Me.TxtSurname)
        Me.Panel1.Controls.Add(Me.txtaccnt)
        Me.Panel1.Controls.Add(Me.txtHnum)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(4, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 88)
        Me.Panel1.TabIndex = 14
        '
        'Txtacctcat
        '
        Me.Txtacctcat.BackColor = System.Drawing.Color.White
        Me.Txtacctcat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtacctcat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtacctcat.ForeColor = System.Drawing.Color.Black
        Me.Txtacctcat.Location = New System.Drawing.Point(635, 29)
        Me.Txtacctcat.Name = "Txtacctcat"
        Me.Txtacctcat.ReadOnly = True
        Me.Txtacctcat.Size = New System.Drawing.Size(199, 21)
        Me.Txtacctcat.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(523, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 15)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Account category:"
        '
        'txtdatebill
        '
        Me.txtdatebill.AutoSize = True
        Me.txtdatebill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtdatebill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatebill.Location = New System.Drawing.Point(694, 11)
        Me.txtdatebill.Name = "txtdatebill"
        Me.txtdatebill.Size = New System.Drawing.Size(14, 19)
        Me.txtdatebill.TabIndex = 30
        Me.txtdatebill.Text = " "
        '
        'txtOthername
        '
        Me.txtOthername.BackColor = System.Drawing.Color.White
        Me.txtOthername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOthername.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthername.ForeColor = System.Drawing.Color.Black
        Me.txtOthername.Location = New System.Drawing.Point(564, 5)
        Me.txtOthername.Name = "txtOthername"
        Me.txtOthername.ReadOnly = True
        Me.txtOthername.Size = New System.Drawing.Size(271, 21)
        Me.txtOthername.TabIndex = 20
        '
        'txtpresby
        '
        Me.txtpresby.BackColor = System.Drawing.Color.White
        Me.txtpresby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpresby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpresby.ForeColor = System.Drawing.Color.Black
        Me.txtpresby.Location = New System.Drawing.Point(500, 54)
        Me.txtpresby.Name = "txtpresby"
        Me.txtpresby.ReadOnly = True
        Me.txtpresby.Size = New System.Drawing.Size(334, 21)
        Me.txtpresby.TabIndex = 19
        '
        'txtbilledby
        '
        Me.txtbilledby.BackColor = System.Drawing.Color.White
        Me.txtbilledby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbilledby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbilledby.ForeColor = System.Drawing.Color.Black
        Me.txtbilledby.Location = New System.Drawing.Point(116, 55)
        Me.txtbilledby.Name = "txtbilledby"
        Me.txtbilledby.ReadOnly = True
        Me.txtbilledby.Size = New System.Drawing.Size(278, 21)
        Me.txtbilledby.TabIndex = 29
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(171, 28)
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
        Me.txtsex.Location = New System.Drawing.Point(49, 28)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(83, 21)
        Me.txtsex.TabIndex = 17
        '
        'TxtSurname
        '
        Me.TxtSurname.BackColor = System.Drawing.Color.White
        Me.TxtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSurname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurname.ForeColor = System.Drawing.Color.Black
        Me.TxtSurname.Location = New System.Drawing.Point(256, 4)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.ReadOnly = True
        Me.TxtSurname.Size = New System.Drawing.Size(216, 21)
        Me.TxtSurname.TabIndex = 16
        '
        'txtaccnt
        '
        Me.txtaccnt.BackColor = System.Drawing.Color.White
        Me.txtaccnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaccnt.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccnt.ForeColor = System.Drawing.Color.Black
        Me.txtaccnt.Location = New System.Drawing.Point(284, 29)
        Me.txtaccnt.Name = "txtaccnt"
        Me.txtaccnt.ReadOnly = True
        Me.txtaccnt.Size = New System.Drawing.Size(233, 21)
        Me.txtaccnt.TabIndex = 13
        '
        'txtHnum
        '
        Me.txtHnum.BackColor = System.Drawing.Color.White
        Me.txtHnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHnum.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHnum.ForeColor = System.Drawing.Color.Black
        Me.txtHnum.Location = New System.Drawing.Point(99, 5)
        Me.txtHnum.Name = "txtHnum"
        Me.txtHnum.ReadOnly = True
        Me.txtHnum.Size = New System.Drawing.Size(92, 21)
        Me.txtHnum.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(12, 31)
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
        Me.Label2.Location = New System.Drawing.Point(589, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Dispensed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(474, 5)
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
        Me.Label4.Location = New System.Drawing.Point(197, 7)
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
        Me.Label5.Location = New System.Drawing.Point(12, 7)
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
        Me.Label6.Location = New System.Drawing.Point(403, 59)
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
        Me.Label7.Location = New System.Drawing.Point(138, 31)
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
        Me.Label8.Location = New System.Drawing.Point(222, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Account:"
        '
        'LblPaymentstatus
        '
        Me.LblPaymentstatus.AutoSize = True
        Me.LblPaymentstatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentstatus.ForeColor = System.Drawing.Color.Red
        Me.LblPaymentstatus.Location = New System.Drawing.Point(185, 9)
        Me.LblPaymentstatus.Name = "LblPaymentstatus"
        Me.LblPaymentstatus.Size = New System.Drawing.Size(12, 17)
        Me.LblPaymentstatus.TabIndex = 25
        Me.LblPaymentstatus.Text = " "
        Me.LblPaymentstatus.Visible = False
        '
        'lblpay
        '
        Me.lblpay.AutoSize = True
        Me.lblpay.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpay.Location = New System.Drawing.Point(57, 8)
        Me.lblpay.Name = "lblpay"
        Me.lblpay.Size = New System.Drawing.Size(113, 17)
        Me.lblpay.TabIndex = 24
        Me.lblpay.Text = "Payment Status:"
        Me.lblpay.Visible = False
        '
        'lblrqstid
        '
        Me.lblrqstid.AutoSize = True
        Me.lblrqstid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrqstid.Location = New System.Drawing.Point(23, 8)
        Me.lblrqstid.Name = "lblrqstid"
        Me.lblrqstid.Size = New System.Drawing.Size(20, 17)
        Me.lblrqstid.TabIndex = 28
        Me.lblrqstid.Text = "id"
        Me.lblrqstid.Visible = False
        '
        'lblconfirmby
        '
        Me.lblconfirmby.AutoSize = True
        Me.lblconfirmby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmby.ForeColor = System.Drawing.Color.Red
        Me.lblconfirmby.Location = New System.Drawing.Point(121, 432)
        Me.lblconfirmby.Name = "lblconfirmby"
        Me.lblconfirmby.Size = New System.Drawing.Size(12, 17)
        Me.lblconfirmby.TabIndex = 29
        Me.lblconfirmby.Text = " "
        Me.lblconfirmby.Visible = False
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldte.Location = New System.Drawing.Point(694, 12)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(12, 17)
        Me.lbldte.TabIndex = 30
        Me.lbldte.Text = " "
        '
        'FrmDrugsbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 414)
        Me.Controls.Add(Me.lbldte)
        Me.Controls.Add(Me.lblconfirmby)
        Me.Controls.Add(Me.txtdatebill)
        Me.Controls.Add(Me.lblrqstid)
        Me.Controls.Add(Me.lblpay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtpword)
        Me.Controls.Add(Me.LblTotalcost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblPaymentstatus)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDrugsbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " DRUGS BILLING FORM"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DtgDrugbill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblbilledby As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DtgDrugbill As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpword As TextBox
    Friend WithEvents LblTotalcost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtOthername As TextBox
    Friend WithEvents txtpresby As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents txtaccnt As TextBox
    Friend WithEvents txtHnum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbilledby As TextBox
    Friend WithEvents LblPaymentstatus As Label
    Friend WithEvents lblpay As Label
    Friend WithEvents lblrqstid As Label
    Friend WithEvents lblconfirmby As Label
    Friend WithEvents txtdatebill As Label
    Friend WithEvents lbldte As Label
    Friend WithEvents Txtacctcat As TextBox
    Friend WithEvents Label11 As Label
End Class
