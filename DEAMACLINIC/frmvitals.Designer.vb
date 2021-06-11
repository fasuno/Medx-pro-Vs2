<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmvitals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvitals))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btncls = New System.Windows.Forms.Button()
        Me.BtnChng = New System.Windows.Forms.Button()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.chkRoom = New System.Windows.Forms.CheckBox()
        Me.chkDoc = New System.Windows.Forms.CheckBox()
        Me.cborooms = New System.Windows.Forms.ComboBox()
        Me.cbodoctor = New System.Windows.Forms.ComboBox()
        Me.lblsurname = New System.Windows.Forms.Label()
        Me.lblothernames = New System.Windows.Forms.Label()
        Me.timetaken = New System.Windows.Forms.DateTimePicker()
        Me.Datetaken = New System.Windows.Forms.DateTimePicker()
        Me.lblhospnum = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.lblsex = New System.Windows.Forms.Label()
        Me.lblaccounttype = New System.Windows.Forms.Label()
        Me.lblclinic = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.txtResp = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtPulse = New System.Windows.Forms.TextBox()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtBp = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblcat = New System.Windows.Forms.Label()
        Me.LblDocID = New System.Windows.Forms.Label()
        Me.LblPendConslt = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Blue
        Me.GroupBox1.Controls.Add(Me.lbluser)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btncls)
        Me.GroupBox1.Controls.Add(Me.BtnChng)
        Me.GroupBox1.Controls.Add(Me.BtnSend)
        Me.GroupBox1.Controls.Add(Me.chkRoom)
        Me.GroupBox1.Controls.Add(Me.chkDoc)
        Me.GroupBox1.Controls.Add(Me.cborooms)
        Me.GroupBox1.Controls.Add(Me.cbodoctor)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POST TO"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(34, 91)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(13, 19)
        Me.lbluser.TabIndex = 16
        Me.lbluser.Text = " "
        Me.lbluser.Visible = False
        '
        'txtpass
        '
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.Location = New System.Drawing.Point(141, 82)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpass.Size = New System.Drawing.Size(140, 26)
        Me.txtpass.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Password:"
        '
        'Btncls
        '
        Me.Btncls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncls.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncls.ForeColor = System.Drawing.Color.White
        Me.Btncls.Location = New System.Drawing.Point(439, 52)
        Me.Btncls.Name = "Btncls"
        Me.Btncls.Size = New System.Drawing.Size(85, 29)
        Me.Btncls.TabIndex = 6
        Me.Btncls.Text = "CANCEL"
        Me.Btncls.UseVisualStyleBackColor = True
        '
        'BtnChng
        '
        Me.BtnChng.Enabled = False
        Me.BtnChng.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChng.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChng.ForeColor = System.Drawing.Color.White
        Me.BtnChng.Location = New System.Drawing.Point(439, 84)
        Me.BtnChng.Name = "BtnChng"
        Me.BtnChng.Size = New System.Drawing.Size(85, 29)
        Me.BtnChng.TabIndex = 5
        Me.BtnChng.Text = "CHANGE"
        Me.BtnChng.UseVisualStyleBackColor = True
        '
        'BtnSend
        '
        Me.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSend.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.White
        Me.BtnSend.Location = New System.Drawing.Point(439, 20)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(85, 29)
        Me.BtnSend.TabIndex = 4
        Me.BtnSend.Text = "SEND"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'chkRoom
        '
        Me.chkRoom.AutoSize = True
        Me.chkRoom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRoom.ForeColor = System.Drawing.Color.White
        Me.chkRoom.Location = New System.Drawing.Point(47, 60)
        Me.chkRoom.Name = "chkRoom"
        Me.chkRoom.Size = New System.Drawing.Size(91, 19)
        Me.chkRoom.TabIndex = 3
        Me.chkRoom.Text = "Consulting:"
        Me.chkRoom.UseVisualStyleBackColor = True
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDoc.ForeColor = System.Drawing.Color.White
        Me.chkDoc.Location = New System.Drawing.Point(47, 31)
        Me.chkDoc.Name = "chkDoc"
        Me.chkDoc.Size = New System.Drawing.Size(67, 19)
        Me.chkDoc.TabIndex = 2
        Me.chkDoc.Text = "Doctor:"
        Me.chkDoc.UseVisualStyleBackColor = True
        '
        'cborooms
        '
        Me.cborooms.AutoCompleteCustomSource.AddRange(New String() {"Room1", "Room2", "Room3", "Room4", "Room5"})
        Me.cborooms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cborooms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cborooms.Enabled = False
        Me.cborooms.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborooms.ForeColor = System.Drawing.Color.Black
        Me.cborooms.FormattingEnabled = True
        Me.cborooms.Items.AddRange(New Object() {"Room1", "Room2", "Room3", "Room4", "Room5"})
        Me.cborooms.Location = New System.Drawing.Point(141, 56)
        Me.cborooms.Name = "cborooms"
        Me.cborooms.Size = New System.Drawing.Size(163, 23)
        Me.cborooms.TabIndex = 1
        '
        'cbodoctor
        '
        Me.cbodoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbodoctor.Enabled = False
        Me.cbodoctor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodoctor.ForeColor = System.Drawing.Color.Black
        Me.cbodoctor.FormattingEnabled = True
        Me.cbodoctor.Location = New System.Drawing.Point(141, 27)
        Me.cbodoctor.Name = "cbodoctor"
        Me.cbodoctor.Size = New System.Drawing.Size(208, 23)
        Me.cbodoctor.TabIndex = 0
        '
        'lblsurname
        '
        Me.lblsurname.AutoSize = True
        Me.lblsurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblsurname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsurname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblsurname.Location = New System.Drawing.Point(64, 5)
        Me.lblsurname.Name = "lblsurname"
        Me.lblsurname.Size = New System.Drawing.Size(44, 15)
        Me.lblsurname.TabIndex = 10
        Me.lblsurname.Text = "Label1"
        '
        'lblothernames
        '
        Me.lblothernames.AutoSize = True
        Me.lblothernames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblothernames.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblothernames.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblothernames.Location = New System.Drawing.Point(226, 5)
        Me.lblothernames.Name = "lblothernames"
        Me.lblothernames.Size = New System.Drawing.Size(44, 15)
        Me.lblothernames.TabIndex = 11
        Me.lblothernames.Text = "Label2"
        '
        'timetaken
        '
        Me.timetaken.Enabled = False
        Me.timetaken.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timetaken.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timetaken.Location = New System.Drawing.Point(445, 73)
        Me.timetaken.Name = "timetaken"
        Me.timetaken.Size = New System.Drawing.Size(89, 20)
        Me.timetaken.TabIndex = 12
        '
        'Datetaken
        '
        Me.Datetaken.Enabled = False
        Me.Datetaken.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datetaken.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datetaken.Location = New System.Drawing.Point(353, 73)
        Me.Datetaken.Name = "Datetaken"
        Me.Datetaken.Size = New System.Drawing.Size(89, 20)
        Me.Datetaken.TabIndex = 13
        '
        'lblhospnum
        '
        Me.lblhospnum.AutoSize = True
        Me.lblhospnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblhospnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhospnum.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblhospnum.Location = New System.Drawing.Point(90, 29)
        Me.lblhospnum.Name = "lblhospnum"
        Me.lblhospnum.Size = New System.Drawing.Size(44, 15)
        Me.lblhospnum.TabIndex = 14
        Me.lblhospnum.Text = "Label2"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblage.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblage.Location = New System.Drawing.Point(223, 29)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(44, 15)
        Me.lblage.TabIndex = 15
        Me.lblage.Text = "Label2"
        '
        'lblsex
        '
        Me.lblsex.AutoSize = True
        Me.lblsex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblsex.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsex.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblsex.Location = New System.Drawing.Point(312, 30)
        Me.lblsex.Name = "lblsex"
        Me.lblsex.Size = New System.Drawing.Size(44, 15)
        Me.lblsex.TabIndex = 18
        Me.lblsex.Text = "Label2"
        '
        'lblaccounttype
        '
        Me.lblaccounttype.AutoSize = True
        Me.lblaccounttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblaccounttype.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccounttype.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblaccounttype.Location = New System.Drawing.Point(70, 52)
        Me.lblaccounttype.Name = "lblaccounttype"
        Me.lblaccounttype.Size = New System.Drawing.Size(44, 15)
        Me.lblaccounttype.TabIndex = 19
        Me.lblaccounttype.Text = "Label2"
        '
        'lblclinic
        '
        Me.lblclinic.AutoSize = True
        Me.lblclinic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblclinic.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclinic.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblclinic.Location = New System.Drawing.Point(436, 29)
        Me.lblclinic.Name = "lblclinic"
        Me.lblclinic.Size = New System.Drawing.Size(44, 15)
        Me.lblclinic.TabIndex = 20
        Me.lblclinic.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Hospital No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Account:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(390, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Clinic:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(496, 109)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(10, 15)
        Me.lbltime.TabIndex = 36
        Me.lbltime.Text = " "
        Me.lbltime.Visible = False
        '
        'txtResp
        '
        Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResp.Location = New System.Drawing.Point(234, 181)
        Me.txtResp.Name = "txtResp"
        Me.txtResp.Size = New System.Drawing.Size(84, 20)
        Me.txtResp.TabIndex = 35
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(147, 148)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(81, 20)
        Me.txtWeight.TabIndex = 34
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(288, 147)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(84, 20)
        Me.txtHeight.TabIndex = 33
        '
        'txtPulse
        '
        Me.txtPulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse.Location = New System.Drawing.Point(374, 112)
        Me.txtPulse.Name = "txtPulse"
        Me.txtPulse.Size = New System.Drawing.Size(84, 20)
        Me.txtPulse.TabIndex = 32
        '
        'txtTemp
        '
        Me.txtTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.Location = New System.Drawing.Point(234, 115)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(84, 20)
        Me.txtTemp.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(153, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Respiration:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(234, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Height:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(59, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "BP:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(97, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Weight:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(326, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 15)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Pulse:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(188, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 15)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Temp:"
        '
        'TxtBp
        '
        Me.TxtBp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBp.Location = New System.Drawing.Point(96, 116)
        Me.TxtBp.Name = "TxtBp"
        Me.TxtBp.Size = New System.Drawing.Size(84, 20)
        Me.TxtBp.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(-1, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 10)
        Me.Panel1.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(311, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 15)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Account Category:"
        '
        'lblcat
        '
        Me.lblcat.AutoSize = True
        Me.lblcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblcat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblcat.Location = New System.Drawing.Point(429, 52)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(10, 15)
        Me.lblcat.TabIndex = 39
        Me.lblcat.Text = " "
        '
        'LblDocID
        '
        Me.LblDocID.AutoSize = True
        Me.LblDocID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDocID.Location = New System.Drawing.Point(407, 181)
        Me.LblDocID.Name = "LblDocID"
        Me.LblDocID.Size = New System.Drawing.Size(10, 15)
        Me.LblDocID.TabIndex = 41
        Me.LblDocID.Text = " "
        Me.LblDocID.Visible = False
        '
        'LblPendConslt
        '
        Me.LblPendConslt.AutoSize = True
        Me.LblPendConslt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPendConslt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPendConslt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblPendConslt.Location = New System.Drawing.Point(454, 183)
        Me.LblPendConslt.Name = "LblPendConslt"
        Me.LblPendConslt.Size = New System.Drawing.Size(52, 15)
        Me.LblPendConslt.TabIndex = 43
        Me.LblPendConslt.Text = "Pending"
        Me.LblPendConslt.Visible = False
        '
        'frmvitals
        '
        Me.AcceptButton = Me.BtnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(538, 337)
        Me.Controls.Add(Me.LblPendConslt)
        Me.Controls.Add(Me.LblDocID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblcat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtBp)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.txtResp)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtPulse)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblclinic)
        Me.Controls.Add(Me.lblaccounttype)
        Me.Controls.Add(Me.lblsex)
        Me.Controls.Add(Me.lblage)
        Me.Controls.Add(Me.lblhospnum)
        Me.Controls.Add(Me.Datetaken)
        Me.Controls.Add(Me.timetaken)
        Me.Controls.Add(Me.lblothernames)
        Me.Controls.Add(Me.lblsurname)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmvitals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   VITAL SIGNS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cborooms As ComboBox
    Friend WithEvents cbodoctor As ComboBox
    Friend WithEvents Btncls As Button
    Friend WithEvents BtnChng As Button
    Friend WithEvents BtnSend As Button
    Friend WithEvents chkRoom As CheckBox
    Friend WithEvents chkDoc As CheckBox
    Friend WithEvents lblsurname As Label
    Friend WithEvents lblothernames As Label
    Friend WithEvents timetaken As DateTimePicker
    Friend WithEvents Datetaken As DateTimePicker
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblhospnum As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lblsex As Label
    Friend WithEvents lblaccounttype As Label
    Friend WithEvents lblclinic As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents txtResp As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtPulse As TextBox
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtBp As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblcat As Label
    Friend WithEvents LblDocID As Label
    Friend WithEvents LblPendConslt As Label
End Class
