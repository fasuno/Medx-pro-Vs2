<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewAdmit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewAdmit))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtTime = New System.Windows.Forms.DateTimePicker()
        Me.Dtdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.TxtOname = New System.Windows.Forms.TextBox()
        Me.Txtsex = New System.Windows.Forms.TextBox()
        Me.Txtage = New System.Windows.Forms.TextBox()
        Me.Txtclinic = New System.Windows.Forms.TextBox()
        Me.Txtadmtyp = New System.Windows.Forms.TextBox()
        Me.Txtdiag = New System.Windows.Forms.TextBox()
        Me.Txtinstr = New System.Windows.Forms.TextBox()
        Me.cboward = New System.Windows.Forms.ComboBox()
        Me.cbobedno = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtcons = New System.Windows.Forms.TextBox()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.BtnAdmit = New System.Windows.Forms.Button()
        Me.Txthospnum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbladmitid = New System.Windows.Forms.Label()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.Lblstatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(1, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 28)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(161, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "ADMIT PATIENT INTO"
        '
        'dtTime
        '
        Me.dtTime.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtTime.Location = New System.Drawing.Point(384, 28)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.ShowUpDown = True
        Me.dtTime.Size = New System.Drawing.Size(94, 21)
        Me.dtTime.TabIndex = 2
        '
        'Dtdate
        '
        Me.Dtdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtdate.Location = New System.Drawing.Point(384, 3)
        Me.Dtdate.Name = "Dtdate"
        Me.Dtdate.Size = New System.Drawing.Size(94, 21)
        Me.Dtdate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Surname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Other Names:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Clinic:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Diagnosis:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Instruction:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Sex:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Ward:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Admission type:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(328, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Bed No.:"
        '
        'txtsname
        '
        Me.txtsname.BackColor = System.Drawing.Color.White
        Me.txtsname.Location = New System.Drawing.Point(99, 30)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.ReadOnly = True
        Me.txtsname.Size = New System.Drawing.Size(174, 20)
        Me.txtsname.TabIndex = 12
        '
        'TxtOname
        '
        Me.TxtOname.BackColor = System.Drawing.Color.White
        Me.TxtOname.Location = New System.Drawing.Point(99, 54)
        Me.TxtOname.Name = "TxtOname"
        Me.TxtOname.ReadOnly = True
        Me.TxtOname.Size = New System.Drawing.Size(283, 20)
        Me.TxtOname.TabIndex = 13
        '
        'Txtsex
        '
        Me.Txtsex.BackColor = System.Drawing.Color.White
        Me.Txtsex.Location = New System.Drawing.Point(99, 79)
        Me.Txtsex.Name = "Txtsex"
        Me.Txtsex.ReadOnly = True
        Me.Txtsex.Size = New System.Drawing.Size(95, 20)
        Me.Txtsex.TabIndex = 15
        '
        'Txtage
        '
        Me.Txtage.BackColor = System.Drawing.Color.White
        Me.Txtage.Location = New System.Drawing.Point(234, 79)
        Me.Txtage.Name = "Txtage"
        Me.Txtage.ReadOnly = True
        Me.Txtage.Size = New System.Drawing.Size(43, 20)
        Me.Txtage.TabIndex = 16
        '
        'Txtclinic
        '
        Me.Txtclinic.BackColor = System.Drawing.Color.White
        Me.Txtclinic.Location = New System.Drawing.Point(329, 79)
        Me.Txtclinic.Name = "Txtclinic"
        Me.Txtclinic.ReadOnly = True
        Me.Txtclinic.Size = New System.Drawing.Size(148, 20)
        Me.Txtclinic.TabIndex = 17
        '
        'Txtadmtyp
        '
        Me.Txtadmtyp.BackColor = System.Drawing.Color.White
        Me.Txtadmtyp.Location = New System.Drawing.Point(99, 104)
        Me.Txtadmtyp.Name = "Txtadmtyp"
        Me.Txtadmtyp.ReadOnly = True
        Me.Txtadmtyp.Size = New System.Drawing.Size(229, 20)
        Me.Txtadmtyp.TabIndex = 18
        '
        'Txtdiag
        '
        Me.Txtdiag.BackColor = System.Drawing.Color.White
        Me.Txtdiag.Location = New System.Drawing.Point(99, 128)
        Me.Txtdiag.Name = "Txtdiag"
        Me.Txtdiag.ReadOnly = True
        Me.Txtdiag.Size = New System.Drawing.Size(378, 20)
        Me.Txtdiag.TabIndex = 19
        '
        'Txtinstr
        '
        Me.Txtinstr.BackColor = System.Drawing.Color.White
        Me.Txtinstr.Location = New System.Drawing.Point(99, 151)
        Me.Txtinstr.Multiline = True
        Me.Txtinstr.Name = "Txtinstr"
        Me.Txtinstr.ReadOnly = True
        Me.Txtinstr.Size = New System.Drawing.Size(229, 44)
        Me.Txtinstr.TabIndex = 20
        '
        'cboward
        '
        Me.cboward.FormattingEnabled = True
        Me.cboward.Location = New System.Drawing.Point(99, 229)
        Me.cboward.Name = "cboward"
        Me.cboward.Size = New System.Drawing.Size(224, 21)
        Me.cboward.TabIndex = 21
        '
        'cbobedno
        '
        Me.cbobedno.FormattingEnabled = True
        Me.cbobedno.Location = New System.Drawing.Point(387, 229)
        Me.cbobedno.Name = "cbobedno"
        Me.cbobedno.Size = New System.Drawing.Size(49, 21)
        Me.cbobedno.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(2, 279)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 5)
        Me.Panel2.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(74, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Password:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(22, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Consultant:"
        '
        'Txtcons
        '
        Me.Txtcons.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcons.Location = New System.Drawing.Point(99, 253)
        Me.Txtcons.Name = "Txtcons"
        Me.Txtcons.Size = New System.Drawing.Size(337, 20)
        Me.Txtcons.TabIndex = 25
        '
        'Txtpass
        '
        Me.Txtpass.Location = New System.Drawing.Point(143, 292)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpass.Size = New System.Drawing.Size(152, 20)
        Me.Txtpass.TabIndex = 26
        '
        'BtnAdmit
        '
        Me.BtnAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmit.ForeColor = System.Drawing.Color.Green
        Me.BtnAdmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdmit.Location = New System.Drawing.Point(299, 289)
        Me.BtnAdmit.Name = "BtnAdmit"
        Me.BtnAdmit.Size = New System.Drawing.Size(83, 23)
        Me.BtnAdmit.TabIndex = 27
        Me.BtnAdmit.Text = "ADMIT"
        Me.BtnAdmit.UseVisualStyleBackColor = True
        '
        'Txthospnum
        '
        Me.Txthospnum.BackColor = System.Drawing.Color.White
        Me.Txthospnum.Location = New System.Drawing.Point(99, 6)
        Me.Txthospnum.Name = "Txthospnum"
        Me.Txthospnum.ReadOnly = True
        Me.Txthospnum.Size = New System.Drawing.Size(95, 20)
        Me.Txthospnum.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Hospital No.:"
        '
        'Lbladmitid
        '
        Me.Lbladmitid.AutoSize = True
        Me.Lbladmitid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbladmitid.Location = New System.Drawing.Point(231, 8)
        Me.Lbladmitid.Name = "Lbladmitid"
        Me.Lbladmitid.Size = New System.Drawing.Size(10, 15)
        Me.Lbladmitid.TabIndex = 31
        Me.Lbladmitid.Text = " "
        Me.Lbladmitid.Visible = False
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.Location = New System.Drawing.Point(334, 179)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(10, 15)
        Me.Lbluser.TabIndex = 32
        Me.Lbluser.Text = " "
        '
        'Lblstatus
        '
        Me.Lblstatus.AutoSize = True
        Me.Lblstatus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstatus.Location = New System.Drawing.Point(354, 205)
        Me.Lblstatus.Name = "Lblstatus"
        Me.Lblstatus.Size = New System.Drawing.Size(82, 15)
        Me.Lblstatus.TabIndex = 33
        Me.Lblstatus.Text = "On admission"
        '
        'FrmNewAdmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 318)
        Me.Controls.Add(Me.Lbluser)
        Me.Controls.Add(Me.Lbladmitid)
        Me.Controls.Add(Me.Txthospnum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnAdmit)
        Me.Controls.Add(Me.Txtpass)
        Me.Controls.Add(Me.Txtcons)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbobedno)
        Me.Controls.Add(Me.cboward)
        Me.Controls.Add(Me.Txtinstr)
        Me.Controls.Add(Me.Txtdiag)
        Me.Controls.Add(Me.Txtadmtyp)
        Me.Controls.Add(Me.Txtclinic)
        Me.Controls.Add(Me.Txtage)
        Me.Controls.Add(Me.Txtsex)
        Me.Controls.Add(Me.TxtOname)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.Dtdate)
        Me.Controls.Add(Me.dtTime)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lblstatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewAdmit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   NEW ADMISSION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dtdate As DateTimePicker
    Friend WithEvents dtTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsname As TextBox
    Friend WithEvents TxtOname As TextBox
    Friend WithEvents Txtsex As TextBox
    Friend WithEvents Txtage As TextBox
    Friend WithEvents Txtclinic As TextBox
    Friend WithEvents Txtadmtyp As TextBox
    Friend WithEvents Txtdiag As TextBox
    Friend WithEvents Txtinstr As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboward As ComboBox
    Friend WithEvents cbobedno As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Txtcons As TextBox
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents BtnAdmit As Button
    Friend WithEvents Txthospnum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Lbladmitid As Label
    Friend WithEvents Lbluser As Label
    Friend WithEvents Lblstatus As Label
End Class
