<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmANCfollowUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmANCfollowUp))
        Me.Txtremark = New System.Windows.Forms.TextBox()
        Me.cboappnmnt = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtheght = New System.Windows.Forms.TextBox()
        Me.txtbp = New System.Windows.Forms.TextBox()
        Me.txtfh = New System.Windows.Forms.TextBox()
        Me.txtprepos = New System.Windows.Forms.TextBox()
        Me.txtwght = New System.Windows.Forms.TextBox()
        Me.txturine = New System.Windows.Forms.TextBox()
        Me.txtlie = New System.Windows.Forms.TextBox()
        Me.txtga = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpassw = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnScan = New System.Windows.Forms.Button()
        Me.BtnDrugs = New System.Windows.Forms.Button()
        Me.btnLAB = New System.Windows.Forms.Button()
        Me.Btnadmit = New System.Windows.Forms.Button()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtbook = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtedd = New System.Windows.Forms.DateTimePicker()
        Me.txtgravs = New System.Windows.Forms.TextBox()
        Me.txtpar = New System.Windows.Forms.TextBox()
        Me.dtfolwup = New System.Windows.Forms.DateTimePicker()
        Me.dtflwuptime = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtlmp = New System.Windows.Forms.DateTimePicker()
        Me.lblbkid = New System.Windows.Forms.Label()
        Me.Btnsendvitals = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtremark
        '
        Me.Txtremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtremark.Location = New System.Drawing.Point(4, 224)
        Me.Txtremark.Multiline = True
        Me.Txtremark.Name = "Txtremark"
        Me.Txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtremark.Size = New System.Drawing.Size(677, 122)
        Me.Txtremark.TabIndex = 26
        '
        'cboappnmnt
        '
        Me.cboappnmnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboappnmnt.FormattingEnabled = True
        Me.cboappnmnt.Items.AddRange(New Object() {"1 week", "2 weeks", "3 weeks", "4 weeks", "5 weeks", "6 weeks", "7 weeks", "8 weeks", "9 weeks", "10 weeks", "11 weeks", "12 weeks", "13 weeks", "14 weeks", "15 weeks", "16 weeks", "17 weeks", "18 weeks", "19 weeks", "20 weeks", "21 weeks"})
        Me.cboappnmnt.Location = New System.Drawing.Point(189, 105)
        Me.cboappnmnt.Name = "cboappnmnt"
        Me.cboappnmnt.Size = New System.Drawing.Size(250, 21)
        Me.cboappnmnt.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(77, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 15)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Next Appointment:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(9, 204)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 15)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "REMARKS:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblbkid)
        Me.Panel2.Controls.Add(Me.txtheght)
        Me.Panel2.Controls.Add(Me.txtbp)
        Me.Panel2.Controls.Add(Me.txtfh)
        Me.Panel2.Controls.Add(Me.txtprepos)
        Me.Panel2.Controls.Add(Me.txtwght)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txturine)
        Me.Panel2.Controls.Add(Me.txtlie)
        Me.Panel2.Controls.Add(Me.txtga)
        Me.Panel2.Controls.Add(Me.cboappnmnt)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(3, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(463, 133)
        Me.Panel2.TabIndex = 48
        '
        'txtheght
        '
        Me.txtheght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtheght.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtheght.Location = New System.Drawing.Point(342, 75)
        Me.txtheght.Name = "txtheght"
        Me.txtheght.Size = New System.Drawing.Size(97, 21)
        Me.txtheght.TabIndex = 61
        '
        'txtbp
        '
        Me.txtbp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbp.Location = New System.Drawing.Point(342, 51)
        Me.txtbp.Name = "txtbp"
        Me.txtbp.Size = New System.Drawing.Size(97, 21)
        Me.txtbp.TabIndex = 60
        '
        'txtfh
        '
        Me.txtfh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfh.Location = New System.Drawing.Point(342, 27)
        Me.txtfh.Name = "txtfh"
        Me.txtfh.Size = New System.Drawing.Size(97, 21)
        Me.txtfh.TabIndex = 59
        '
        'txtprepos
        '
        Me.txtprepos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprepos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprepos.Location = New System.Drawing.Point(342, 4)
        Me.txtprepos.Name = "txtprepos"
        Me.txtprepos.Size = New System.Drawing.Size(97, 21)
        Me.txtprepos.TabIndex = 58
        '
        'txtwght
        '
        Me.txtwght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtwght.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwght.Location = New System.Drawing.Point(88, 75)
        Me.txtwght.Name = "txtwght"
        Me.txtwght.Size = New System.Drawing.Size(97, 21)
        Me.txtwght.TabIndex = 57
        '
        'txturine
        '
        Me.txturine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txturine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txturine.Location = New System.Drawing.Point(88, 51)
        Me.txturine.Name = "txturine"
        Me.txturine.Size = New System.Drawing.Size(97, 21)
        Me.txturine.TabIndex = 56
        '
        'txtlie
        '
        Me.txtlie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlie.Location = New System.Drawing.Point(88, 27)
        Me.txtlie.Name = "txtlie"
        Me.txtlie.Size = New System.Drawing.Size(97, 21)
        Me.txtlie.TabIndex = 55
        '
        'txtga
        '
        Me.txtga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtga.Location = New System.Drawing.Point(88, 3)
        Me.txtga.Name = "txtga"
        Me.txtga.Size = New System.Drawing.Size(97, 21)
        Me.txtga.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(250, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 15)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Fundal Height:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(31, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 15)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Weight:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(309, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 15)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "BP:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(40, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 15)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Urine:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(259, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Foetal Heart:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(52, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 15)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "LIE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(186, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Presentation and Position:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(50, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 15)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "G.A:"
        '
        'txtpassw
        '
        Me.txtpassw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassw.Location = New System.Drawing.Point(13, 76)
        Me.txtpassw.Name = "txtpassw"
        Me.txtpassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpassw.Size = New System.Drawing.Size(165, 21)
        Me.txtpassw.TabIndex = 62
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.BtnScan)
        Me.Panel3.Controls.Add(Me.Btnsendvitals)
        Me.Panel3.Controls.Add(Me.BtnDrugs)
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.btnLAB)
        Me.Panel3.Controls.Add(Me.Btnadmit)
        Me.Panel3.Controls.Add(Me.txtpassw)
        Me.Panel3.Controls.Add(Me.btnupdate)
        Me.Panel3.Location = New System.Drawing.Point(469, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(212, 133)
        Me.Panel3.TabIndex = 63
        '
        'BtnScan
        '
        Me.BtnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScan.Image = CType(resources.GetObject("BtnScan.Image"), System.Drawing.Image)
        Me.BtnScan.Location = New System.Drawing.Point(107, 2)
        Me.BtnScan.Name = "BtnScan"
        Me.BtnScan.Size = New System.Drawing.Size(48, 43)
        Me.BtnScan.TabIndex = 65
        Me.BtnScan.Text = " "
        Me.BtnScan.UseVisualStyleBackColor = True
        '
        'BtnDrugs
        '
        Me.BtnDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDrugs.Image = CType(resources.GetObject("BtnDrugs.Image"), System.Drawing.Image)
        Me.BtnDrugs.Location = New System.Drawing.Point(3, 2)
        Me.BtnDrugs.Name = "BtnDrugs"
        Me.BtnDrugs.Size = New System.Drawing.Size(48, 43)
        Me.BtnDrugs.TabIndex = 66
        Me.BtnDrugs.Text = " "
        Me.BtnDrugs.UseVisualStyleBackColor = True
        '
        'btnLAB
        '
        Me.btnLAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLAB.Image = CType(resources.GetObject("btnLAB.Image"), System.Drawing.Image)
        Me.btnLAB.Location = New System.Drawing.Point(55, 2)
        Me.btnLAB.Name = "btnLAB"
        Me.btnLAB.Size = New System.Drawing.Size(48, 43)
        Me.btnLAB.TabIndex = 64
        Me.btnLAB.Text = " "
        Me.btnLAB.UseVisualStyleBackColor = True
        '
        'Btnadmit
        '
        Me.Btnadmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnadmit.Image = CType(resources.GetObject("Btnadmit.Image"), System.Drawing.Image)
        Me.Btnadmit.Location = New System.Drawing.Point(158, 2)
        Me.Btnadmit.Name = "Btnadmit"
        Me.Btnadmit.Size = New System.Drawing.Size(48, 43)
        Me.Btnadmit.TabIndex = 67
        Me.Btnadmit.Text = " "
        Me.Btnadmit.UseVisualStyleBackColor = True
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.DarkMagenta
        Me.lblusername.Location = New System.Drawing.Point(445, 203)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(10, 15)
        Me.lblusername.TabIndex = 66
        Me.lblusername.Text = " "
        Me.lblusername.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(16, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 15)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(43, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "L.M.P:"
        '
        'dtbook
        '
        Me.dtbook.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbook.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtbook.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbook.Location = New System.Drawing.Point(92, 6)
        Me.dtbook.Name = "dtbook"
        Me.dtbook.Size = New System.Drawing.Size(218, 22)
        Me.dtbook.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Date Booked:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(316, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "EDD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(354, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Gravida:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(468, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Para:"
        '
        'dtedd
        '
        Me.dtedd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtedd.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtedd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtedd.Location = New System.Drawing.Point(358, 32)
        Me.dtedd.Name = "dtedd"
        Me.dtedd.Size = New System.Drawing.Size(218, 22)
        Me.dtedd.TabIndex = 33
        '
        'txtgravs
        '
        Me.txtgravs.BackColor = System.Drawing.Color.White
        Me.txtgravs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgravs.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgravs.ForeColor = System.Drawing.Color.Green
        Me.txtgravs.Location = New System.Drawing.Point(411, 6)
        Me.txtgravs.Name = "txtgravs"
        Me.txtgravs.ReadOnly = True
        Me.txtgravs.Size = New System.Drawing.Size(54, 22)
        Me.txtgravs.TabIndex = 31
        '
        'txtpar
        '
        Me.txtpar.BackColor = System.Drawing.Color.White
        Me.txtpar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpar.ForeColor = System.Drawing.Color.Green
        Me.txtpar.Location = New System.Drawing.Point(509, 6)
        Me.txtpar.Name = "txtpar"
        Me.txtpar.ReadOnly = True
        Me.txtpar.Size = New System.Drawing.Size(67, 22)
        Me.txtpar.TabIndex = 30
        '
        'dtfolwup
        '
        Me.dtfolwup.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfolwup.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtfolwup.Enabled = False
        Me.dtfolwup.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfolwup.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfolwup.Location = New System.Drawing.Point(584, 33)
        Me.dtfolwup.Name = "dtfolwup"
        Me.dtfolwup.Size = New System.Drawing.Size(96, 22)
        Me.dtfolwup.TabIndex = 34
        Me.dtfolwup.Visible = False
        '
        'dtflwuptime
        '
        Me.dtflwuptime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtflwuptime.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtflwuptime.Enabled = False
        Me.dtflwuptime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtflwuptime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtflwuptime.Location = New System.Drawing.Point(584, 8)
        Me.dtflwuptime.Name = "dtflwuptime"
        Me.dtflwuptime.ShowUpDown = True
        Me.dtflwuptime.Size = New System.Drawing.Size(96, 22)
        Me.dtflwuptime.TabIndex = 35
        Me.dtflwuptime.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtflwuptime)
        Me.Panel1.Controls.Add(Me.dtfolwup)
        Me.Panel1.Controls.Add(Me.txtpar)
        Me.Panel1.Controls.Add(Me.txtgravs)
        Me.Panel1.Controls.Add(Me.dtedd)
        Me.Panel1.Controls.Add(Me.dtlmp)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtbook)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 59)
        Me.Panel1.TabIndex = 29
        '
        'dtlmp
        '
        Me.dtlmp.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtlmp.CalendarForeColor = System.Drawing.Color.Black
        Me.dtlmp.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtlmp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtlmp.Location = New System.Drawing.Point(91, 31)
        Me.dtlmp.Name = "dtlmp"
        Me.dtlmp.Size = New System.Drawing.Size(218, 22)
        Me.dtlmp.TabIndex = 32
        '
        'lblbkid
        '
        Me.lblbkid.AutoSize = True
        Me.lblbkid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbkid.ForeColor = System.Drawing.Color.Blue
        Me.lblbkid.Location = New System.Drawing.Point(315, 134)
        Me.lblbkid.Name = "lblbkid"
        Me.lblbkid.Size = New System.Drawing.Size(10, 15)
        Me.lblbkid.TabIndex = 62
        Me.lblbkid.Text = " "
        Me.lblbkid.Visible = False
        '
        'Btnsendvitals
        '
        Me.Btnsendvitals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsendvitals.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsendvitals.ForeColor = System.Drawing.Color.Green
        Me.Btnsendvitals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsendvitals.Location = New System.Drawing.Point(12, 102)
        Me.Btnsendvitals.Name = "Btnsendvitals"
        Me.Btnsendvitals.Size = New System.Drawing.Size(81, 23)
        Me.Btnsendvitals.TabIndex = 69
        Me.Btnsendvitals.Text = "SAVE"
        Me.Btnsendvitals.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Green
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(13, 102)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 23)
        Me.btnsave.TabIndex = 49
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.DarkRed
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(98, 102)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(80, 23)
        Me.btnclose.TabIndex = 50
        Me.btnclose.Text = " CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Green
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdate.Location = New System.Drawing.Point(12, 102)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(80, 23)
        Me.btnupdate.TabIndex = 68
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Location = New System.Drawing.Point(0, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 5)
        Me.Panel4.TabIndex = 67
        '
        'FrmANCfollowUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(685, 352)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txtremark)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmANCfollowUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ANTE-NATAL FOLLOW-UP FORM"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtremark As TextBox
    Friend WithEvents cboappnmnt As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtheght As TextBox
    Friend WithEvents txtbp As TextBox
    Friend WithEvents txtfh As TextBox
    Friend WithEvents txtprepos As TextBox
    Friend WithEvents txtwght As TextBox
    Friend WithEvents txturine As TextBox
    Friend WithEvents txtlie As TextBox
    Friend WithEvents txtga As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents txtpassw As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btnadmit As Button
    Friend WithEvents BtnDrugs As Button
    Friend WithEvents BtnScan As Button
    Friend WithEvents btnLAB As Button
    Friend WithEvents lblusername As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtbook As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtedd As DateTimePicker
    Friend WithEvents txtgravs As TextBox
    Friend WithEvents txtpar As TextBox
    Friend WithEvents dtfolwup As DateTimePicker
    Friend WithEvents dtflwuptime As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtlmp As DateTimePicker
    Friend WithEvents btnupdate As Button
    Friend WithEvents Btnsendvitals As Button
    Friend WithEvents lblbkid As Label
    Friend WithEvents Panel4 As Panel
End Class
