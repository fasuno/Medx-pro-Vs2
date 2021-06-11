<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoundNotes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DischgPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblstat = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtCliSum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDiag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TxtProb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtOper = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnSaveSum = New System.Windows.Forms.Button()
        Me.TxtConstnt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblusersum = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtAppmnt = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDrugs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnDischSum = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Txtnote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dtgreport = New System.Windows.Forms.DataGridView()
        Me.TimSumm = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.DischgPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dtgreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Txtpass)
        Me.Panel1.Controls.Add(Me.Btnclear)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Txtnote)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 294)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.MaximumSize = New System.Drawing.Size(828, 335)
        Me.Panel3.MinimumSize = New System.Drawing.Size(828, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(828, 32)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.DischgPanel)
        Me.Panel4.Controls.Add(Me.BtnDischSum)
        Me.Panel4.Location = New System.Drawing.Point(374, 1)
        Me.Panel4.MaximumSize = New System.Drawing.Size(446, 310)
        Me.Panel4.MinimumSize = New System.Drawing.Size(446, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(446, 310)
        Me.Panel4.TabIndex = 4
        '
        'DischgPanel
        '
        Me.DischgPanel.AutoScroll = True
        Me.DischgPanel.Controls.Add(Me.Panel5)
        Me.DischgPanel.Controls.Add(Me.Panel6)
        Me.DischgPanel.Controls.Add(Me.Panel7)
        Me.DischgPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DischgPanel.Location = New System.Drawing.Point(0, 27)
        Me.DischgPanel.Name = "DischgPanel"
        Me.DischgPanel.Size = New System.Drawing.Size(444, 267)
        Me.DischgPanel.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblstat)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.TxtCliSum)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.TxtDiag)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Lblusername)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(388, 207)
        Me.Panel5.TabIndex = 1
        '
        'lblstat
        '
        Me.lblstat.AutoSize = True
        Me.lblstat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstat.ForeColor = System.Drawing.Color.White
        Me.lblstat.Location = New System.Drawing.Point(181, 41)
        Me.lblstat.Name = "lblstat"
        Me.lblstat.Size = New System.Drawing.Size(113, 15)
        Me.lblstat.TabIndex = 6
        Me.lblstat.Text = "Discharge Ordered"
        Me.lblstat.Visible = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(388, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "DISCHARGE SUMMARY FORM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtCliSum
        '
        Me.TxtCliSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCliSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliSum.Location = New System.Drawing.Point(6, 144)
        Me.TxtCliSum.Multiline = True
        Me.TxtCliSum.Name = "TxtCliSum"
        Me.TxtCliSum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCliSum.Size = New System.Drawing.Size(379, 62)
        Me.TxtCliSum.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Clinical Summary"
        '
        'TxtDiag
        '
        Me.TxtDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiag.Location = New System.Drawing.Point(6, 59)
        Me.TxtDiag.Multiline = True
        Me.TxtDiag.Name = "TxtDiag"
        Me.TxtDiag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDiag.Size = New System.Drawing.Size(379, 62)
        Me.TxtDiag.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Diagnosis"
        '
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.Location = New System.Drawing.Point(289, 128)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(39, 13)
        Me.Lblusername.TabIndex = 6
        Me.Lblusername.Text = "Label1"
        Me.Lblusername.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TxtProb)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.TxtOper)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(3, 216)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(388, 178)
        Me.Panel6.TabIndex = 4
        '
        'TxtProb
        '
        Me.TxtProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProb.Location = New System.Drawing.Point(6, 112)
        Me.TxtProb.Multiline = True
        Me.TxtProb.Name = "TxtProb"
        Me.TxtProb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtProb.Size = New System.Drawing.Size(379, 62)
        Me.TxtProb.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Unresolved Problems"
        '
        'TxtOper
        '
        Me.TxtOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOper.Location = New System.Drawing.Point(10, 24)
        Me.TxtOper.Multiline = True
        Me.TxtOper.Name = "TxtOper"
        Me.TxtOper.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtOper.Size = New System.Drawing.Size(375, 62)
        Me.TxtOper.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Operations"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BtnSaveSum)
        Me.Panel7.Controls.Add(Me.TxtConstnt)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.lblusersum)
        Me.Panel7.Controls.Add(Me.TxtPassword)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.DtAppmnt)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.TxtDrugs)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(3, 400)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(391, 210)
        Me.Panel7.TabIndex = 5
        '
        'BtnSaveSum
        '
        Me.BtnSaveSum.Enabled = False
        Me.BtnSaveSum.FlatAppearance.BorderSize = 2
        Me.BtnSaveSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveSum.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveSum.ForeColor = System.Drawing.Color.White
        Me.BtnSaveSum.Location = New System.Drawing.Point(184, 174)
        Me.BtnSaveSum.Name = "BtnSaveSum"
        Me.BtnSaveSum.Size = New System.Drawing.Size(200, 30)
        Me.BtnSaveSum.TabIndex = 4
        Me.BtnSaveSum.Text = "ORDER DISCHARGE"
        Me.BtnSaveSum.UseVisualStyleBackColor = True
        '
        'TxtConstnt
        '
        Me.TxtConstnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConstnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtConstnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConstnt.Location = New System.Drawing.Point(6, 96)
        Me.TxtConstnt.Name = "TxtConstnt"
        Me.TxtConstnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtConstnt.Size = New System.Drawing.Size(379, 21)
        Me.TxtConstnt.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Consultant"
        '
        'lblusersum
        '
        Me.lblusersum.AutoSize = True
        Me.lblusersum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusersum.ForeColor = System.Drawing.Color.White
        Me.lblusersum.Location = New System.Drawing.Point(150, 6)
        Me.lblusersum.Name = "lblusersum"
        Me.lblusersum.Size = New System.Drawing.Size(63, 15)
        Me.lblusersum.TabIndex = 8
        Me.lblusersum.Text = "Password:"
        Me.lblusersum.Visible = False
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Enabled = False
        Me.TxtPassword.Location = New System.Drawing.Point(10, 182)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.TxtPassword.Size = New System.Drawing.Size(168, 20)
        Me.TxtPassword.TabIndex = 7
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Location = New System.Drawing.Point(3, 152)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(387, 7)
        Me.Panel8.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Password:"
        '
        'DtAppmnt
        '
        Me.DtAppmnt.Location = New System.Drawing.Point(153, 125)
        Me.DtAppmnt.Name = "DtAppmnt"
        Me.DtAppmnt.Size = New System.Drawing.Size(196, 20)
        Me.DtAppmnt.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Follow-Up Appointment:"
        '
        'TxtDrugs
        '
        Me.TxtDrugs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDrugs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDrugs.Location = New System.Drawing.Point(6, 24)
        Me.TxtDrugs.Multiline = True
        Me.TxtDrugs.Name = "TxtDrugs"
        Me.TxtDrugs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDrugs.Size = New System.Drawing.Size(379, 51)
        Me.TxtDrugs.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Drugs On Discharge"
        '
        'BtnDischSum
        '
        Me.BtnDischSum.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDischSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDischSum.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDischSum.ForeColor = System.Drawing.Color.White
        Me.BtnDischSum.Location = New System.Drawing.Point(0, 0)
        Me.BtnDischSum.MaximumSize = New System.Drawing.Size(444, 27)
        Me.BtnDischSum.MinimumSize = New System.Drawing.Size(444, 27)
        Me.BtnDischSum.Name = "BtnDischSum"
        Me.BtnDischSum.Size = New System.Drawing.Size(444, 27)
        Me.BtnDischSum.TabIndex = 3
        Me.BtnDischSum.Text = "CLICK HERE TO DISCHARGE THIS PATIENT"
        Me.BtnDischSum.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DOCTOR'S  ROUND NOTE"
        '
        'Txtpass
        '
        Me.Txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpass.Location = New System.Drawing.Point(667, 230)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpass.Size = New System.Drawing.Size(156, 20)
        Me.Txtpass.TabIndex = 3
        '
        'Btnclear
        '
        Me.Btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclear.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnclear.Location = New System.Drawing.Point(741, 256)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(72, 23)
        Me.Btnclear.TabIndex = 2
        Me.Btnclear.Text = "CLEAR"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnsave.Location = New System.Drawing.Point(670, 256)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(68, 23)
        Me.Btnsave.TabIndex = 1
        Me.Btnsave.Text = "SAVE"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Txtnote
        '
        Me.Txtnote.BackColor = System.Drawing.Color.White
        Me.Txtnote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnote.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnote.Location = New System.Drawing.Point(4, 38)
        Me.Txtnote.Multiline = True
        Me.Txtnote.Name = "Txtnote"
        Me.Txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtnote.Size = New System.Drawing.Size(657, 248)
        Me.Txtnote.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(667, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Dtgreport)
        Me.Panel2.Location = New System.Drawing.Point(13, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 153)
        Me.Panel2.TabIndex = 3
        '
        'Dtgreport
        '
        Me.Dtgreport.AllowUserToAddRows = False
        Me.Dtgreport.AllowUserToDeleteRows = False
        Me.Dtgreport.AllowUserToResizeColumns = False
        Me.Dtgreport.AllowUserToResizeRows = False
        Me.Dtgreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtgreport.BackgroundColor = System.Drawing.Color.White
        Me.Dtgreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgreport.Location = New System.Drawing.Point(3, 3)
        Me.Dtgreport.Name = "Dtgreport"
        Me.Dtgreport.ReadOnly = True
        Me.Dtgreport.Size = New System.Drawing.Size(799, 147)
        Me.Dtgreport.TabIndex = 0
        '
        'TimSumm
        '
        Me.TimSumm.Interval = 15
        '
        'RoundNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "RoundNotes"
        Me.Size = New System.Drawing.Size(828, 451)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.DischgPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dtgreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents Txtnote As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dtgreport As DataGridView
    Friend WithEvents Lblusername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TimSumm As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DischgPanel As FlowLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtCliSum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDiag As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtProb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtOper As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSaveSum As Button
    Friend WithEvents DtAppmnt As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDrugs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnDischSum As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblusersum As Label
    Friend WithEvents TxtConstnt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblstat As Label
End Class
