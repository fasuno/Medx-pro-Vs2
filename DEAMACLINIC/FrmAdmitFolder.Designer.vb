<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmitFolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmitFolder))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btncons = New System.Windows.Forms.Button()
        Me.Btnscanhx = New System.Windows.Forms.Button()
        Me.BtnLabhx = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btnrndnote = New System.Windows.Forms.Button()
        Me.BtnNurserpt = New System.Windows.Forms.Button()
        Me.BtnFluidbal = New System.Windows.Forms.Button()
        Me.Btndrughx = New System.Windows.Forms.Button()
        Me.Btnobschrt = New System.Windows.Forms.Button()
        Me.BtntrtChrt = New System.Windows.Forms.Button()
        Me.btncareplan = New System.Windows.Forms.Button()
        Me.BtnNursehx = New System.Windows.Forms.Button()
        Me.Btnprofile = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Lbldiag = New System.Windows.Forms.Label()
        Me.Lblage = New System.Windows.Forms.Label()
        Me.Lblsex = New System.Windows.Forms.Label()
        Me.Lblhospnum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbladmitID = New System.Windows.Forms.Label()
        Me.FluidBalChart1 = New DEAMACLINIC.FluidBalChart()
        Me.ObservChart1 = New DEAMACLINIC.ObservChart()
        Me.TreatmentChart1 = New DEAMACLINIC.TreatmentChart()
        Me.InpatientConslt1 = New DEAMACLINIC.InpatientConslt()
        Me.InpatientLabHx1 = New DEAMACLINIC.InpatientLabHx()
        Me.InpatientRadHx1 = New DEAMACLINIC.InpatientRadHx()
        Me.InpatientDrugsHx1 = New DEAMACLINIC.InpatientDrugsHx()
        Me.CarePlan1 = New DEAMACLINIC.CarePlan()
        Me.Nursinghx1 = New DEAMACLINIC.Nursinghx()
        Me.RoundNotes1 = New DEAMACLINIC.RoundNotes()
        Me.NurseReport1 = New DEAMACLINIC.NurseReport()
        Me.Profile1 = New DEAMACLINIC.Profile()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btncons)
        Me.Panel1.Controls.Add(Me.Btnscanhx)
        Me.Panel1.Controls.Add(Me.BtnLabhx)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Btnrndnote)
        Me.Panel1.Controls.Add(Me.BtnNurserpt)
        Me.Panel1.Controls.Add(Me.BtnFluidbal)
        Me.Panel1.Controls.Add(Me.Btndrughx)
        Me.Panel1.Controls.Add(Me.Btnobschrt)
        Me.Panel1.Controls.Add(Me.BtntrtChrt)
        Me.Panel1.Controls.Add(Me.btncareplan)
        Me.Panel1.Controls.Add(Me.BtnNursehx)
        Me.Panel1.Controls.Add(Me.Btnprofile)
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(127, 456)
        Me.Panel1.TabIndex = 0
        '
        'Btncons
        '
        Me.Btncons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncons.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncons.ForeColor = System.Drawing.Color.Blue
        Me.Btncons.Location = New System.Drawing.Point(3, 368)
        Me.Btncons.Name = "Btncons"
        Me.Btncons.Size = New System.Drawing.Size(119, 28)
        Me.Btncons.TabIndex = 13
        Me.Btncons.Text = "Consultaions"
        Me.Btncons.UseVisualStyleBackColor = True
        '
        'Btnscanhx
        '
        Me.Btnscanhx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnscanhx.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnscanhx.ForeColor = System.Drawing.Color.Blue
        Me.Btnscanhx.Location = New System.Drawing.Point(3, 338)
        Me.Btnscanhx.Name = "Btnscanhx"
        Me.Btnscanhx.Size = New System.Drawing.Size(119, 28)
        Me.Btnscanhx.TabIndex = 12
        Me.Btnscanhx.Text = "Scan / X-ray Hx"
        Me.Btnscanhx.UseVisualStyleBackColor = True
        '
        'BtnLabhx
        '
        Me.BtnLabhx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLabhx.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLabhx.ForeColor = System.Drawing.Color.Blue
        Me.BtnLabhx.Location = New System.Drawing.Point(3, 308)
        Me.BtnLabhx.Name = "BtnLabhx"
        Me.BtnLabhx.Size = New System.Drawing.Size(119, 28)
        Me.BtnLabhx.TabIndex = 11
        Me.BtnLabhx.Text = "Lab Test Hx"
        Me.BtnLabhx.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.ForeColor = System.Drawing.Color.Blue
        Me.Panel4.Location = New System.Drawing.Point(-1, 265)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(127, 7)
        Me.Panel4.TabIndex = 10
        '
        'Btnrndnote
        '
        Me.Btnrndnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnrndnote.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnrndnote.ForeColor = System.Drawing.Color.Blue
        Me.Btnrndnote.Location = New System.Drawing.Point(3, 231)
        Me.Btnrndnote.Name = "Btnrndnote"
        Me.Btnrndnote.Size = New System.Drawing.Size(119, 28)
        Me.Btnrndnote.TabIndex = 8
        Me.Btnrndnote.Text = "Ward Round Note"
        Me.Btnrndnote.UseVisualStyleBackColor = True
        '
        'BtnNurserpt
        '
        Me.BtnNurserpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNurserpt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNurserpt.ForeColor = System.Drawing.Color.Blue
        Me.BtnNurserpt.Location = New System.Drawing.Point(3, 201)
        Me.BtnNurserpt.Name = "BtnNurserpt"
        Me.BtnNurserpt.Size = New System.Drawing.Size(119, 28)
        Me.BtnNurserpt.TabIndex = 7
        Me.BtnNurserpt.Text = "Nurse Report"
        Me.BtnNurserpt.UseVisualStyleBackColor = True
        '
        'BtnFluidbal
        '
        Me.BtnFluidbal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFluidbal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFluidbal.ForeColor = System.Drawing.Color.Blue
        Me.BtnFluidbal.Location = New System.Drawing.Point(3, 171)
        Me.BtnFluidbal.Name = "BtnFluidbal"
        Me.BtnFluidbal.Size = New System.Drawing.Size(119, 28)
        Me.BtnFluidbal.TabIndex = 6
        Me.BtnFluidbal.Text = "Fluid Balance"
        Me.BtnFluidbal.UseVisualStyleBackColor = True
        '
        'Btndrughx
        '
        Me.Btndrughx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndrughx.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndrughx.ForeColor = System.Drawing.Color.Blue
        Me.Btndrughx.Location = New System.Drawing.Point(3, 278)
        Me.Btndrughx.Name = "Btndrughx"
        Me.Btndrughx.Size = New System.Drawing.Size(119, 28)
        Me.Btndrughx.TabIndex = 5
        Me.Btndrughx.Text = "Drugs Hx"
        Me.Btndrughx.UseVisualStyleBackColor = True
        '
        'Btnobschrt
        '
        Me.Btnobschrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnobschrt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnobschrt.ForeColor = System.Drawing.Color.Blue
        Me.Btnobschrt.Location = New System.Drawing.Point(3, 141)
        Me.Btnobschrt.Name = "Btnobschrt"
        Me.Btnobschrt.Size = New System.Drawing.Size(119, 28)
        Me.Btnobschrt.TabIndex = 4
        Me.Btnobschrt.Text = "Observ. Chart"
        Me.Btnobschrt.UseVisualStyleBackColor = True
        '
        'BtntrtChrt
        '
        Me.BtntrtChrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtntrtChrt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtntrtChrt.ForeColor = System.Drawing.Color.Blue
        Me.BtntrtChrt.Location = New System.Drawing.Point(3, 110)
        Me.BtntrtChrt.Name = "BtntrtChrt"
        Me.BtntrtChrt.Size = New System.Drawing.Size(119, 28)
        Me.BtntrtChrt.TabIndex = 3
        Me.BtntrtChrt.Text = "Treatment Chart"
        Me.BtntrtChrt.UseVisualStyleBackColor = True
        '
        'btncareplan
        '
        Me.btncareplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncareplan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncareplan.ForeColor = System.Drawing.Color.Blue
        Me.btncareplan.Location = New System.Drawing.Point(3, 80)
        Me.btncareplan.Name = "btncareplan"
        Me.btncareplan.Size = New System.Drawing.Size(119, 28)
        Me.btncareplan.TabIndex = 2
        Me.btncareplan.Text = "Care Plan"
        Me.btncareplan.UseVisualStyleBackColor = True
        '
        'BtnNursehx
        '
        Me.BtnNursehx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNursehx.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNursehx.ForeColor = System.Drawing.Color.Blue
        Me.BtnNursehx.Location = New System.Drawing.Point(3, 50)
        Me.BtnNursehx.Name = "BtnNursehx"
        Me.BtnNursehx.Size = New System.Drawing.Size(119, 28)
        Me.BtnNursehx.TabIndex = 1
        Me.BtnNursehx.Text = "Nursing Hx"
        Me.BtnNursehx.UseVisualStyleBackColor = True
        '
        'Btnprofile
        '
        Me.Btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnprofile.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprofile.ForeColor = System.Drawing.Color.Blue
        Me.Btnprofile.Location = New System.Drawing.Point(3, 20)
        Me.Btnprofile.Name = "Btnprofile"
        Me.Btnprofile.Size = New System.Drawing.Size(119, 28)
        Me.Btnprofile.TabIndex = 0
        Me.Btnprofile.Text = "Profile"
        Me.Btnprofile.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FluidBalChart1)
        Me.Panel2.Controls.Add(Me.ObservChart1)
        Me.Panel2.Controls.Add(Me.TreatmentChart1)
        Me.Panel2.Controls.Add(Me.InpatientConslt1)
        Me.Panel2.Controls.Add(Me.InpatientLabHx1)
        Me.Panel2.Controls.Add(Me.InpatientRadHx1)
        Me.Panel2.Controls.Add(Me.InpatientDrugsHx1)
        Me.Panel2.Controls.Add(Me.CarePlan1)
        Me.Panel2.Controls.Add(Me.Nursinghx1)
        Me.Panel2.Controls.Add(Me.RoundNotes1)
        Me.Panel2.Controls.Add(Me.NurseReport1)
        Me.Panel2.Controls.Add(Me.Profile1)
        Me.Panel2.Location = New System.Drawing.Point(129, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(830, 456)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.label)
        Me.Panel3.Controls.Add(Me.Lbldiag)
        Me.Panel3.Controls.Add(Me.Lblage)
        Me.Panel3.Controls.Add(Me.Lblsex)
        Me.Panel3.Controls.Add(Me.Lblhospnum)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(963, 33)
        Me.Panel3.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(355, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(6, 32)
        Me.Panel7.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(265, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(6, 32)
        Me.Panel6.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(152, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(6, 32)
        Me.Panel5.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(315, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "yrs"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(367, 10)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(63, 15)
        Me.label.TabIndex = 6
        Me.label.Text = "Diagnosis:"
        '
        'Lbldiag
        '
        Me.Lbldiag.AutoSize = True
        Me.Lbldiag.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldiag.ForeColor = System.Drawing.Color.White
        Me.Lbldiag.Location = New System.Drawing.Point(434, 10)
        Me.Lbldiag.Name = "Lbldiag"
        Me.Lbldiag.Size = New System.Drawing.Size(10, 15)
        Me.Lbldiag.TabIndex = 5
        Me.Lbldiag.Text = " "
        '
        'Lblage
        '
        Me.Lblage.AutoSize = True
        Me.Lblage.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblage.ForeColor = System.Drawing.Color.White
        Me.Lblage.Location = New System.Drawing.Point(289, 10)
        Me.Lblage.Name = "Lblage"
        Me.Lblage.Size = New System.Drawing.Size(10, 15)
        Me.Lblage.TabIndex = 4
        Me.Lblage.Text = " "
        '
        'Lblsex
        '
        Me.Lblsex.AutoSize = True
        Me.Lblsex.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsex.ForeColor = System.Drawing.Color.White
        Me.Lblsex.Location = New System.Drawing.Point(170, 9)
        Me.Lblsex.Name = "Lblsex"
        Me.Lblsex.Size = New System.Drawing.Size(27, 15)
        Me.Lblsex.TabIndex = 3
        Me.Lblsex.Text = "Sex"
        '
        'Lblhospnum
        '
        Me.Lblhospnum.AutoSize = True
        Me.Lblhospnum.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblhospnum.ForeColor = System.Drawing.Color.White
        Me.Lblhospnum.Location = New System.Drawing.Point(88, 9)
        Me.Lblhospnum.Name = "Lblhospnum"
        Me.Lblhospnum.Size = New System.Drawing.Size(10, 15)
        Me.Lblhospnum.TabIndex = 1
        Me.Lblhospnum.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hospital No.:"
        '
        'LbladmitID
        '
        Me.LbladmitID.AutoSize = True
        Me.LbladmitID.BackColor = System.Drawing.Color.Blue
        Me.LbladmitID.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbladmitID.ForeColor = System.Drawing.Color.White
        Me.LbladmitID.Location = New System.Drawing.Point(876, 9)
        Me.LbladmitID.Name = "LbladmitID"
        Me.LbladmitID.Size = New System.Drawing.Size(10, 15)
        Me.LbladmitID.TabIndex = 10
        Me.LbladmitID.Text = " "
        Me.LbladmitID.Visible = False
        '
        'FluidBalChart1
        '
        Me.FluidBalChart1.BackColor = System.Drawing.Color.White
        Me.FluidBalChart1.Location = New System.Drawing.Point(0, 3)
        Me.FluidBalChart1.Name = "FluidBalChart1"
        Me.FluidBalChart1.Size = New System.Drawing.Size(828, 453)
        Me.FluidBalChart1.TabIndex = 11
        '
        'ObservChart1
        '
        Me.ObservChart1.BackColor = System.Drawing.Color.White
        Me.ObservChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ObservChart1.Location = New System.Drawing.Point(2, 4)
        Me.ObservChart1.Name = "ObservChart1"
        Me.ObservChart1.Size = New System.Drawing.Size(832, 449)
        Me.ObservChart1.TabIndex = 10
        '
        'TreatmentChart1
        '
        Me.TreatmentChart1.BackColor = System.Drawing.Color.White
        Me.TreatmentChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreatmentChart1.Location = New System.Drawing.Point(1, 4)
        Me.TreatmentChart1.Name = "TreatmentChart1"
        Me.TreatmentChart1.Size = New System.Drawing.Size(827, 449)
        Me.TreatmentChart1.TabIndex = 9
        '
        'InpatientConslt1
        '
        Me.InpatientConslt1.BackColor = System.Drawing.Color.White
        Me.InpatientConslt1.Location = New System.Drawing.Point(2, 4)
        Me.InpatientConslt1.Name = "InpatientConslt1"
        Me.InpatientConslt1.Size = New System.Drawing.Size(828, 453)
        Me.InpatientConslt1.TabIndex = 8
        '
        'InpatientLabHx1
        '
        Me.InpatientLabHx1.BackColor = System.Drawing.Color.White
        Me.InpatientLabHx1.Location = New System.Drawing.Point(2, 4)
        Me.InpatientLabHx1.Name = "InpatientLabHx1"
        Me.InpatientLabHx1.Size = New System.Drawing.Size(828, 453)
        Me.InpatientLabHx1.TabIndex = 7
        '
        'InpatientRadHx1
        '
        Me.InpatientRadHx1.BackColor = System.Drawing.Color.White
        Me.InpatientRadHx1.Location = New System.Drawing.Point(0, 4)
        Me.InpatientRadHx1.Name = "InpatientRadHx1"
        Me.InpatientRadHx1.Size = New System.Drawing.Size(828, 453)
        Me.InpatientRadHx1.TabIndex = 6
        '
        'InpatientDrugsHx1
        '
        Me.InpatientDrugsHx1.BackColor = System.Drawing.Color.White
        Me.InpatientDrugsHx1.Location = New System.Drawing.Point(1, 3)
        Me.InpatientDrugsHx1.Name = "InpatientDrugsHx1"
        Me.InpatientDrugsHx1.Size = New System.Drawing.Size(828, 453)
        Me.InpatientDrugsHx1.TabIndex = 5
        '
        'CarePlan1
        '
        Me.CarePlan1.BackColor = System.Drawing.Color.White
        Me.CarePlan1.Location = New System.Drawing.Point(1, 4)
        Me.CarePlan1.Name = "CarePlan1"
        Me.CarePlan1.Size = New System.Drawing.Size(829, 452)
        Me.CarePlan1.TabIndex = 4
        '
        'Nursinghx1
        '
        Me.Nursinghx1.BackColor = System.Drawing.Color.White
        Me.Nursinghx1.Location = New System.Drawing.Point(0, 3)
        Me.Nursinghx1.Name = "Nursinghx1"
        Me.Nursinghx1.Size = New System.Drawing.Size(830, 453)
        Me.Nursinghx1.TabIndex = 3
        '
        'RoundNotes1
        '
        Me.RoundNotes1.BackColor = System.Drawing.Color.White
        Me.RoundNotes1.Location = New System.Drawing.Point(0, 3)
        Me.RoundNotes1.Name = "RoundNotes1"
        Me.RoundNotes1.Size = New System.Drawing.Size(828, 453)
        Me.RoundNotes1.TabIndex = 2
        '
        'NurseReport1
        '
        Me.NurseReport1.BackColor = System.Drawing.Color.White
        Me.NurseReport1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NurseReport1.Location = New System.Drawing.Point(-1, 4)
        Me.NurseReport1.Name = "NurseReport1"
        Me.NurseReport1.Size = New System.Drawing.Size(831, 448)
        Me.NurseReport1.TabIndex = 1
        '
        'Profile1
        '
        Me.Profile1.BackColor = System.Drawing.Color.White
        Me.Profile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Profile1.Location = New System.Drawing.Point(0, 4)
        Me.Profile1.Name = "Profile1"
        Me.Profile1.Size = New System.Drawing.Size(830, 447)
        Me.Profile1.TabIndex = 0
        '
        'FrmAdmitFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 490)
        Me.Controls.Add(Me.LbladmitID)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdmitFolder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WARD MANAGER "
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Profile1 As Profile
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Lblhospnum As Label
    Friend WithEvents Lblsex As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label As Label
    Friend WithEvents Lbldiag As Label
    Friend WithEvents Lblage As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Btnprofile As Button
    Friend WithEvents BtntrtChrt As Button
    Friend WithEvents btncareplan As Button
    Friend WithEvents BtnNursehx As Button
    Friend WithEvents Btndrughx As Button
    Friend WithEvents Btnobschrt As Button
    Friend WithEvents Btnrndnote As Button
    Friend WithEvents BtnNurserpt As Button
    Friend WithEvents BtnFluidbal As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnLabhx As Button
    Friend WithEvents Btnscanhx As Button
    Friend WithEvents Btncons As Button
    Friend WithEvents NurseReport1 As NurseReport
    Friend WithEvents LbladmitID As Label
    Friend WithEvents RoundNotes1 As RoundNotes
    Friend WithEvents Nursinghx1 As Nursinghx
    Friend WithEvents CarePlan1 As CarePlan
    Friend WithEvents InpatientLabHx1 As InpatientLabHx
    Friend WithEvents InpatientRadHx1 As InpatientRadHx
    Friend WithEvents InpatientDrugsHx1 As InpatientDrugsHx
    Friend WithEvents InpatientConslt1 As InpatientConslt
    Friend WithEvents TreatmentChart1 As TreatmentChart
    Friend WithEvents ObservChart1 As ObservChart
    Friend WithEvents FluidBalChart1 As FluidBalChart
End Class
