<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSurgery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSurgery))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbltreated = New System.Windows.Forms.Label()
        Me.Lblsurgid = New System.Windows.Forms.Label()
        Me.BtnRad = New System.Windows.Forms.Button()
        Me.BtnPreOp = New System.Windows.Forms.Button()
        Me.BtnLab = New System.Windows.Forms.Button()
        Me.BtnDrugs = New System.Windows.Forms.Button()
        Me.BtnPostOp = New System.Windows.Forms.Button()
        Me.BtnOpNote = New System.Windows.Forms.Button()
        Me.BtnStaff = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtAcct = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtAccTyp = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSurgDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtClinic = New System.Windows.Forms.TextBox()
        Me.TxtOper = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtInstr = New System.Windows.Forms.TextBox()
        Me.TxtOrdBy = New System.Windows.Forms.TextBox()
        Me.TxtDiag = New System.Windows.Forms.TextBox()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.Txtsex = New System.Windows.Forms.TextBox()
        Me.TxtOname = New System.Windows.Forms.TextBox()
        Me.TxtSurname = New System.Windows.Forms.TextBox()
        Me.TxtRqstDate = New System.Windows.Forms.TextBox()
        Me.TxthospNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnSAve = New System.Windows.Forms.Button()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TheatreLAb1 = New DEAMACLINIC.TheatreLAb()
        Me.TheatreScan1 = New DEAMACLINIC.TheatreScan()
        Me.TheatreDrugs1 = New DEAMACLINIC.TheatreDrugs()
        Me.PreOpVisit1 = New DEAMACLINIC.PreOpVisit()
        Me.PostOpOrder1 = New DEAMACLINIC.PostOpOrder()
        Me.OperatioNote1 = New DEAMACLINIC.OperatioNote()
        Me.SurgicalTeam1 = New DEAMACLINIC.SurgicalTeam()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lbltreated)
        Me.Panel1.Controls.Add(Me.Lblsurgid)
        Me.Panel1.Controls.Add(Me.BtnRad)
        Me.Panel1.Controls.Add(Me.BtnPreOp)
        Me.Panel1.Controls.Add(Me.BtnLab)
        Me.Panel1.Controls.Add(Me.BtnDrugs)
        Me.Panel1.Controls.Add(Me.BtnPostOp)
        Me.Panel1.Controls.Add(Me.BtnOpNote)
        Me.Panel1.Controls.Add(Me.BtnStaff)
        Me.Panel1.Location = New System.Drawing.Point(2, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 369)
        Me.Panel1.TabIndex = 0
        '
        'Lbltreated
        '
        Me.Lbltreated.AutoSize = True
        Me.Lbltreated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbltreated.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltreated.Location = New System.Drawing.Point(9, 334)
        Me.Lbltreated.Name = "Lbltreated"
        Me.Lbltreated.Size = New System.Drawing.Size(50, 17)
        Me.Lbltreated.TabIndex = 29
        Me.Lbltreated.Text = "Treated"
        Me.Lbltreated.Visible = False
        '
        'Lblsurgid
        '
        Me.Lblsurgid.AutoSize = True
        Me.Lblsurgid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblsurgid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsurgid.Location = New System.Drawing.Point(9, 9)
        Me.Lblsurgid.Name = "Lblsurgid"
        Me.Lblsurgid.Size = New System.Drawing.Size(12, 17)
        Me.Lblsurgid.TabIndex = 26
        Me.Lblsurgid.Text = " "
        Me.Lblsurgid.Visible = False
        '
        'BtnRad
        '
        Me.BtnRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRad.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRad.ForeColor = System.Drawing.Color.Blue
        Me.BtnRad.Location = New System.Drawing.Point(3, 259)
        Me.BtnRad.Name = "BtnRad"
        Me.BtnRad.Size = New System.Drawing.Size(123, 29)
        Me.BtnRad.TabIndex = 7
        Me.BtnRad.Text = "Scan / X-ray"
        Me.BtnRad.UseVisualStyleBackColor = True
        '
        'BtnPreOp
        '
        Me.BtnPreOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreOp.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreOp.ForeColor = System.Drawing.Color.Blue
        Me.BtnPreOp.Location = New System.Drawing.Point(3, 73)
        Me.BtnPreOp.Name = "BtnPreOp"
        Me.BtnPreOp.Size = New System.Drawing.Size(123, 29)
        Me.BtnPreOp.TabIndex = 6
        Me.BtnPreOp.Text = "Pre-Op Visit"
        Me.BtnPreOp.UseVisualStyleBackColor = True
        '
        'BtnLab
        '
        Me.BtnLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLab.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLab.ForeColor = System.Drawing.Color.Blue
        Me.BtnLab.Location = New System.Drawing.Point(3, 228)
        Me.BtnLab.Name = "BtnLab"
        Me.BtnLab.Size = New System.Drawing.Size(123, 29)
        Me.BtnLab.TabIndex = 5
        Me.BtnLab.Text = "Laboratory"
        Me.BtnLab.UseVisualStyleBackColor = True
        '
        'BtnDrugs
        '
        Me.BtnDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDrugs.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrugs.ForeColor = System.Drawing.Color.Blue
        Me.BtnDrugs.Location = New System.Drawing.Point(3, 197)
        Me.BtnDrugs.Name = "BtnDrugs"
        Me.BtnDrugs.Size = New System.Drawing.Size(123, 29)
        Me.BtnDrugs.TabIndex = 4
        Me.BtnDrugs.Text = "Drugs"
        Me.BtnDrugs.UseVisualStyleBackColor = True
        '
        'BtnPostOp
        '
        Me.BtnPostOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPostOp.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPostOp.ForeColor = System.Drawing.Color.Blue
        Me.BtnPostOp.Location = New System.Drawing.Point(3, 166)
        Me.BtnPostOp.Name = "BtnPostOp"
        Me.BtnPostOp.Size = New System.Drawing.Size(123, 29)
        Me.BtnPostOp.TabIndex = 3
        Me.BtnPostOp.Text = "Post-Op Order"
        Me.BtnPostOp.UseVisualStyleBackColor = True
        '
        'BtnOpNote
        '
        Me.BtnOpNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpNote.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpNote.ForeColor = System.Drawing.Color.Blue
        Me.BtnOpNote.Location = New System.Drawing.Point(3, 135)
        Me.BtnOpNote.Name = "BtnOpNote"
        Me.BtnOpNote.Size = New System.Drawing.Size(123, 29)
        Me.BtnOpNote.TabIndex = 2
        Me.BtnOpNote.Text = "Operation Note"
        Me.BtnOpNote.UseVisualStyleBackColor = True
        '
        'BtnStaff
        '
        Me.BtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStaff.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaff.ForeColor = System.Drawing.Color.Blue
        Me.BtnStaff.Location = New System.Drawing.Point(3, 104)
        Me.BtnStaff.Name = "BtnStaff"
        Me.BtnStaff.Size = New System.Drawing.Size(123, 29)
        Me.BtnStaff.TabIndex = 0
        Me.BtnStaff.Text = "Surgical Team"
        Me.BtnStaff.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TheatreLAb1)
        Me.Panel2.Controls.Add(Me.TheatreScan1)
        Me.Panel2.Controls.Add(Me.TheatreDrugs1)
        Me.Panel2.Controls.Add(Me.PreOpVisit1)
        Me.Panel2.Controls.Add(Me.PostOpOrder1)
        Me.Panel2.Controls.Add(Me.OperatioNote1)
        Me.Panel2.Controls.Add(Me.SurgicalTeam1)
        Me.Panel2.Location = New System.Drawing.Point(135, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 329)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtAcct)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TxtAccTyp)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.TxtSurgDate)
        Me.Panel3.Controls.Add(Me.TxtClinic)
        Me.Panel3.Controls.Add(Me.TxtOper)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TxtInstr)
        Me.Panel3.Controls.Add(Me.TxtOrdBy)
        Me.Panel3.Controls.Add(Me.TxtDiag)
        Me.Panel3.Controls.Add(Me.TxtAge)
        Me.Panel3.Controls.Add(Me.Txtsex)
        Me.Panel3.Controls.Add(Me.TxtOname)
        Me.Panel3.Controls.Add(Me.TxtSurname)
        Me.Panel3.Controls.Add(Me.TxtRqstDate)
        Me.Panel3.Controls.Add(Me.TxthospNo)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(772, 150)
        Me.Panel3.TabIndex = 2
        '
        'TxtAcct
        '
        Me.TxtAcct.BackColor = System.Drawing.Color.White
        Me.TxtAcct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAcct.Location = New System.Drawing.Point(139, 76)
        Me.TxtAcct.Name = "TxtAcct"
        Me.TxtAcct.ReadOnly = True
        Me.TxtAcct.Size = New System.Drawing.Size(211, 20)
        Me.TxtAcct.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(77, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Account:"
        '
        'TxtAccTyp
        '
        Me.TxtAccTyp.BackColor = System.Drawing.Color.White
        Me.TxtAccTyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccTyp.Location = New System.Drawing.Point(441, 76)
        Me.TxtAccTyp.Name = "TxtAccTyp"
        Me.TxtAccTyp.ReadOnly = True
        Me.TxtAccTyp.Size = New System.Drawing.Size(272, 20)
        Me.TxtAccTyp.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(354, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 15)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Account type:"
        '
        'TxtSurgDate
        '
        Me.TxtSurgDate.Location = New System.Drawing.Point(526, 4)
        Me.TxtSurgDate.Name = "TxtSurgDate"
        Me.TxtSurgDate.Size = New System.Drawing.Size(187, 20)
        Me.TxtSurgDate.TabIndex = 26
        '
        'TxtClinic
        '
        Me.TxtClinic.BackColor = System.Drawing.Color.White
        Me.TxtClinic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtClinic.Location = New System.Drawing.Point(428, 100)
        Me.TxtClinic.Name = "TxtClinic"
        Me.TxtClinic.ReadOnly = True
        Me.TxtClinic.Size = New System.Drawing.Size(285, 20)
        Me.TxtClinic.TabIndex = 25
        '
        'TxtOper
        '
        Me.TxtOper.BackColor = System.Drawing.Color.White
        Me.TxtOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOper.Location = New System.Drawing.Point(139, 123)
        Me.TxtOper.Name = "TxtOper"
        Me.TxtOper.ReadOnly = True
        Me.TxtOper.Size = New System.Drawing.Size(211, 20)
        Me.TxtOper.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Operation:"
        '
        'TxtInstr
        '
        Me.TxtInstr.BackColor = System.Drawing.Color.White
        Me.TxtInstr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInstr.Location = New System.Drawing.Point(428, 123)
        Me.TxtInstr.Name = "TxtInstr"
        Me.TxtInstr.ReadOnly = True
        Me.TxtInstr.Size = New System.Drawing.Size(285, 20)
        Me.TxtInstr.TabIndex = 22
        '
        'TxtOrdBy
        '
        Me.TxtOrdBy.BackColor = System.Drawing.Color.White
        Me.TxtOrdBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOrdBy.Location = New System.Drawing.Point(139, 100)
        Me.TxtOrdBy.Name = "TxtOrdBy"
        Me.TxtOrdBy.ReadOnly = True
        Me.TxtOrdBy.Size = New System.Drawing.Size(211, 20)
        Me.TxtOrdBy.TabIndex = 21
        '
        'TxtDiag
        '
        Me.TxtDiag.BackColor = System.Drawing.Color.White
        Me.TxtDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiag.Location = New System.Drawing.Point(428, 52)
        Me.TxtDiag.Name = "TxtDiag"
        Me.TxtDiag.ReadOnly = True
        Me.TxtDiag.Size = New System.Drawing.Size(285, 20)
        Me.TxtDiag.TabIndex = 20
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.White
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAge.Location = New System.Drawing.Point(298, 52)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(52, 20)
        Me.TxtAge.TabIndex = 19
        '
        'Txtsex
        '
        Me.Txtsex.BackColor = System.Drawing.Color.White
        Me.Txtsex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtsex.Location = New System.Drawing.Point(139, 52)
        Me.Txtsex.Name = "Txtsex"
        Me.Txtsex.ReadOnly = True
        Me.Txtsex.Size = New System.Drawing.Size(114, 20)
        Me.Txtsex.TabIndex = 18
        '
        'TxtOname
        '
        Me.TxtOname.BackColor = System.Drawing.Color.White
        Me.TxtOname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOname.Location = New System.Drawing.Point(443, 28)
        Me.TxtOname.Name = "TxtOname"
        Me.TxtOname.ReadOnly = True
        Me.TxtOname.Size = New System.Drawing.Size(270, 20)
        Me.TxtOname.TabIndex = 17
        '
        'TxtSurname
        '
        Me.TxtSurname.BackColor = System.Drawing.Color.White
        Me.TxtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSurname.Location = New System.Drawing.Point(139, 28)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.ReadOnly = True
        Me.TxtSurname.Size = New System.Drawing.Size(211, 20)
        Me.TxtSurname.TabIndex = 16
        '
        'TxtRqstDate
        '
        Me.TxtRqstDate.BackColor = System.Drawing.Color.White
        Me.TxtRqstDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRqstDate.Location = New System.Drawing.Point(335, 4)
        Me.TxtRqstDate.Name = "TxtRqstDate"
        Me.TxtRqstDate.ReadOnly = True
        Me.TxtRqstDate.Size = New System.Drawing.Size(99, 20)
        Me.TxtRqstDate.TabIndex = 14
        '
        'TxthospNo
        '
        Me.TxthospNo.BackColor = System.Drawing.Color.White
        Me.TxthospNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxthospNo.Location = New System.Drawing.Point(139, 4)
        Me.TxthospNo.Name = "TxthospNo"
        Me.TxthospNo.ReadOnly = True
        Me.TxthospNo.Size = New System.Drawing.Size(103, 20)
        Me.TxthospNo.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(379, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Clinic:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(70, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Order By:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(354, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Instruction:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(437, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Surgery Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Diagnosis:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(259, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(102, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sex:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(353, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Other Names:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hospital No.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request Date:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Location = New System.Drawing.Point(-1, 528)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(778, 10)
        Me.Panel4.TabIndex = 1
        '
        'BtnSAve
        '
        Me.BtnSAve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSAve.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSAve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSAve.Location = New System.Drawing.Point(615, 490)
        Me.BtnSAve.Name = "BtnSAve"
        Me.BtnSAve.Size = New System.Drawing.Size(90, 29)
        Me.BtnSAve.TabIndex = 27
        Me.BtnSAve.Text = "SAVE"
        Me.BtnSAve.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.White
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Location = New System.Drawing.Point(429, 499)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpass.ReadOnly = True
        Me.txtpass.Size = New System.Drawing.Size(180, 20)
        Me.txtpass.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(333, 501)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Enter password:"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbluser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(157, 499)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(12, 17)
        Me.lbluser.TabIndex = 28
        Me.lbluser.Text = " "
        Me.lbluser.Visible = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdate.Location = New System.Drawing.Point(615, 490)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 29)
        Me.BtnUpdate.TabIndex = 29
        Me.BtnUpdate.Text = "SAVE"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        Me.BtnUpdate.Visible = False
        '
        'TheatreLAb1
        '
        Me.TheatreLAb1.BackColor = System.Drawing.Color.White
        Me.TheatreLAb1.Location = New System.Drawing.Point(-1, -1)
        Me.TheatreLAb1.Name = "TheatreLAb1"
        Me.TheatreLAb1.Size = New System.Drawing.Size(637, 329)
        Me.TheatreLAb1.TabIndex = 6
        '
        'TheatreScan1
        '
        Me.TheatreScan1.BackColor = System.Drawing.Color.White
        Me.TheatreScan1.Location = New System.Drawing.Point(0, 1)
        Me.TheatreScan1.Name = "TheatreScan1"
        Me.TheatreScan1.Size = New System.Drawing.Size(637, 329)
        Me.TheatreScan1.TabIndex = 5
        '
        'TheatreDrugs1
        '
        Me.TheatreDrugs1.BackColor = System.Drawing.Color.White
        Me.TheatreDrugs1.Location = New System.Drawing.Point(-1, 0)
        Me.TheatreDrugs1.Name = "TheatreDrugs1"
        Me.TheatreDrugs1.Size = New System.Drawing.Size(637, 329)
        Me.TheatreDrugs1.TabIndex = 4
        '
        'PreOpVisit1
        '
        Me.PreOpVisit1.BackColor = System.Drawing.Color.White
        Me.PreOpVisit1.Location = New System.Drawing.Point(0, 0)
        Me.PreOpVisit1.Name = "PreOpVisit1"
        Me.PreOpVisit1.Size = New System.Drawing.Size(637, 329)
        Me.PreOpVisit1.TabIndex = 3
        '
        'PostOpOrder1
        '
        Me.PostOpOrder1.BackColor = System.Drawing.Color.White
        Me.PostOpOrder1.Location = New System.Drawing.Point(0, 0)
        Me.PostOpOrder1.Name = "PostOpOrder1"
        Me.PostOpOrder1.Size = New System.Drawing.Size(637, 329)
        Me.PostOpOrder1.TabIndex = 2
        '
        'OperatioNote1
        '
        Me.OperatioNote1.BackColor = System.Drawing.Color.White
        Me.OperatioNote1.Location = New System.Drawing.Point(-1, -1)
        Me.OperatioNote1.Name = "OperatioNote1"
        Me.OperatioNote1.Size = New System.Drawing.Size(637, 330)
        Me.OperatioNote1.TabIndex = 1
        '
        'SurgicalTeam1
        '
        Me.SurgicalTeam1.BackColor = System.Drawing.Color.White
        Me.SurgicalTeam1.Location = New System.Drawing.Point(-1, -1)
        Me.SurgicalTeam1.Name = "SurgicalTeam1"
        Me.SurgicalTeam1.Size = New System.Drawing.Size(637, 329)
        Me.SurgicalTeam1.TabIndex = 0
        '
        'FrmSurgery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 538)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnSAve)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSurgery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  SURGERY FORM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnPreOp As Button
    Friend WithEvents BtnLab As Button
    Friend WithEvents BtnDrugs As Button
    Friend WithEvents BtnPostOp As Button
    Friend WithEvents BtnOpNote As Button
    Friend WithEvents BtnStaff As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnRad As Button
    Friend WithEvents SurgicalTeam1 As SurgicalTeam
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtInstr As TextBox
    Friend WithEvents TxtOrdBy As TextBox
    Friend WithEvents TxtDiag As TextBox
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents Txtsex As TextBox
    Friend WithEvents TxtOname As TextBox
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents TxtRqstDate As TextBox
    Friend WithEvents TxthospNo As TextBox
    Friend WithEvents TxtClinic As TextBox
    Friend WithEvents TxtOper As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Lblsurgid As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents OperatioNote1 As OperatioNote
    Friend WithEvents PostOpOrder1 As PostOpOrder
    Friend WithEvents BtnSAve As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents TxtSurgDate As DateTimePicker
    Friend WithEvents PreOpVisit1 As PreOpVisit
    Friend WithEvents Lbltreated As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents TheatreDrugs1 As TheatreDrugs
    Friend WithEvents TxtAcct As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtAccTyp As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TheatreScan1 As TheatreScan
    Friend WithEvents TheatreLAb1 As TheatreLAb
End Class
