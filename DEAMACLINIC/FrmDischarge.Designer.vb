<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDischarge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDischarge))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHospnum = New System.Windows.Forms.TextBox()
        Me.TxtConsultant = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBedNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtward = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDiag = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSex = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtOthername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSurname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.CbodisType = New System.Windows.Forms.ComboBox()
        Me.TxtAdmitID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtremark = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnDischarge = New System.Windows.Forms.Button()
        Me.LbladmitDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hospital No.:"
        '
        'TxtHospnum
        '
        Me.TxtHospnum.BackColor = System.Drawing.Color.White
        Me.TxtHospnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHospnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHospnum.ForeColor = System.Drawing.Color.Black
        Me.TxtHospnum.Location = New System.Drawing.Point(104, 6)
        Me.TxtHospnum.Name = "TxtHospnum"
        Me.TxtHospnum.ReadOnly = True
        Me.TxtHospnum.Size = New System.Drawing.Size(129, 21)
        Me.TxtHospnum.TabIndex = 1
        '
        'TxtConsultant
        '
        Me.TxtConsultant.BackColor = System.Drawing.Color.White
        Me.TxtConsultant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConsultant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConsultant.ForeColor = System.Drawing.Color.Black
        Me.TxtConsultant.Location = New System.Drawing.Point(104, 151)
        Me.TxtConsultant.Name = "TxtConsultant"
        Me.TxtConsultant.ReadOnly = True
        Me.TxtConsultant.Size = New System.Drawing.Size(360, 21)
        Me.TxtConsultant.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(28, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Consultant:"
        '
        'TxtBedNo
        '
        Me.TxtBedNo.BackColor = System.Drawing.Color.White
        Me.TxtBedNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBedNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBedNo.ForeColor = System.Drawing.Color.Black
        Me.TxtBedNo.Location = New System.Drawing.Point(364, 127)
        Me.TxtBedNo.Name = "TxtBedNo"
        Me.TxtBedNo.ReadOnly = True
        Me.TxtBedNo.Size = New System.Drawing.Size(100, 21)
        Me.TxtBedNo.TabIndex = 5
        Me.TxtBedNo.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(301, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bed No.:"
        '
        'Txtward
        '
        Me.Txtward.BackColor = System.Drawing.Color.White
        Me.Txtward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtward.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtward.ForeColor = System.Drawing.Color.Black
        Me.Txtward.Location = New System.Drawing.Point(104, 127)
        Me.Txtward.Name = "Txtward"
        Me.Txtward.ReadOnly = True
        Me.Txtward.Size = New System.Drawing.Size(191, 21)
        Me.Txtward.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(57, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ward:"
        '
        'TxtDiag
        '
        Me.TxtDiag.BackColor = System.Drawing.Color.White
        Me.TxtDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiag.ForeColor = System.Drawing.Color.Black
        Me.TxtDiag.Location = New System.Drawing.Point(104, 102)
        Me.TxtDiag.Name = "TxtDiag"
        Me.TxtDiag.ReadOnly = True
        Me.TxtDiag.Size = New System.Drawing.Size(360, 21)
        Me.TxtDiag.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(33, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Diagnosis:"
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.White
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.ForeColor = System.Drawing.Color.Black
        Me.TxtAge.Location = New System.Drawing.Point(254, 78)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(100, 21)
        Me.TxtAge.TabIndex = 11
        Me.TxtAge.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(212, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Age:"
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.Color.White
        Me.TxtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.ForeColor = System.Drawing.Color.Black
        Me.TxtSex.Location = New System.Drawing.Point(104, 78)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.ReadOnly = True
        Me.TxtSex.Size = New System.Drawing.Size(100, 21)
        Me.TxtSex.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(67, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sex:"
        '
        'TxtOthername
        '
        Me.TxtOthername.BackColor = System.Drawing.Color.White
        Me.TxtOthername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOthername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOthername.ForeColor = System.Drawing.Color.Black
        Me.TxtOthername.Location = New System.Drawing.Point(104, 54)
        Me.TxtOthername.Name = "TxtOthername"
        Me.TxtOthername.ReadOnly = True
        Me.TxtOthername.Size = New System.Drawing.Size(360, 21)
        Me.TxtOthername.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(14, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Other Names:"
        '
        'TxtSurname
        '
        Me.TxtSurname.BackColor = System.Drawing.Color.White
        Me.TxtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurname.ForeColor = System.Drawing.Color.Black
        Me.TxtSurname.Location = New System.Drawing.Point(104, 30)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.ReadOnly = True
        Me.TxtSurname.Size = New System.Drawing.Size(241, 21)
        Me.TxtSurname.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(37, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Surname:"
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.Black
        Me.TxtPass.Location = New System.Drawing.Point(150, 302)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.TxtPass.Size = New System.Drawing.Size(162, 21)
        Me.TxtPass.TabIndex = 19
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbluser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.ForeColor = System.Drawing.Color.Blue
        Me.Lbluser.Location = New System.Drawing.Point(12, 261)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(12, 17)
        Me.Lbluser.TabIndex = 18
        Me.Lbluser.Text = " "
        Me.Lbluser.Visible = False
        '
        'CbodisType
        '
        Me.CbodisType.FormattingEnabled = True
        Me.CbodisType.Items.AddRange(New Object() {"DISCHARGE HOME", "LAMA", "DEATH", "ABSCONDED"})
        Me.CbodisType.Location = New System.Drawing.Point(143, 192)
        Me.CbodisType.Name = "CbodisType"
        Me.CbodisType.Size = New System.Drawing.Size(261, 21)
        Me.CbodisType.TabIndex = 20
        '
        'TxtAdmitID
        '
        Me.TxtAdmitID.BackColor = System.Drawing.Color.White
        Me.TxtAdmitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdmitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmitID.ForeColor = System.Drawing.Color.Black
        Me.TxtAdmitID.Location = New System.Drawing.Point(335, 6)
        Me.TxtAdmitID.Name = "TxtAdmitID"
        Me.TxtAdmitID.ReadOnly = True
        Me.TxtAdmitID.Size = New System.Drawing.Size(129, 21)
        Me.TxtAdmitID.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(239, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Admission No.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(41, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Discharge Type:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(50, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Enter password:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(-6, 177)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 7)
        Me.Panel1.TabIndex = 25
        '
        'Txtremark
        '
        Me.Txtremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtremark.ForeColor = System.Drawing.Color.Black
        Me.Txtremark.Location = New System.Drawing.Point(143, 219)
        Me.Txtremark.Multiline = True
        Me.Txtremark.Name = "Txtremark"
        Me.Txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtremark.Size = New System.Drawing.Size(261, 59)
        Me.Txtremark.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(81, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Remark:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(-4, 286)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(485, 7)
        Me.Panel2.TabIndex = 26
        '
        'BtnDischarge
        '
        Me.BtnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDischarge.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDischarge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDischarge.Location = New System.Drawing.Point(318, 299)
        Me.BtnDischarge.Name = "BtnDischarge"
        Me.BtnDischarge.Size = New System.Drawing.Size(146, 26)
        Me.BtnDischarge.TabIndex = 28
        Me.BtnDischarge.Text = "DISCHRAGE"
        Me.BtnDischarge.UseVisualStyleBackColor = True
        '
        'LbladmitDate
        '
        Me.LbladmitDate.AutoSize = True
        Me.LbladmitDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbladmitDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbladmitDate.ForeColor = System.Drawing.Color.Blue
        Me.LbladmitDate.Location = New System.Drawing.Point(12, 219)
        Me.LbladmitDate.Name = "LbladmitDate"
        Me.LbladmitDate.Size = New System.Drawing.Size(12, 17)
        Me.LbladmitDate.TabIndex = 29
        Me.LbladmitDate.Text = " "
        Me.LbladmitDate.Visible = False
        '
        'FrmDischarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 331)
        Me.Controls.Add(Me.LbladmitDate)
        Me.Controls.Add(Me.BtnDischarge)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Txtremark)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtAdmitID)
        Me.Controls.Add(Me.CbodisType)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Lbluser)
        Me.Controls.Add(Me.TxtSurname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtOthername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtSex)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDiag)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtward)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBedNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtConsultant)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtHospnum)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDischarge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   DISCHARGE FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtHospnum As TextBox
    Friend WithEvents TxtConsultant As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBedNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtward As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDiag As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSex As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtOthername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Lbluser As Label
    Friend WithEvents CbodisType As ComboBox
    Friend WithEvents TxtAdmitID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txtremark As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnDischarge As Button
    Friend WithEvents LbladmitDate As Label
End Class
