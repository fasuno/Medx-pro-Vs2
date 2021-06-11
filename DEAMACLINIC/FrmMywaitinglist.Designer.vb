<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMywaitinglist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMywaitinglist))
        Me.TabMylist = New System.Windows.Forms.TabControl()
        Me.Tabpag1 = New System.Windows.Forms.TabPage()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Dtgmypendlist = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dttopend = New System.Windows.Forms.DateTimePicker()
        Me.dtfrmpend = New System.Windows.Forms.DateTimePicker()
        Me.txtfindpt = New System.Windows.Forms.TextBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnfindpt = New System.Windows.Forms.Button()
        Me.TabPageappt = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtgMyconsultation = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Dttrtedto = New System.Windows.Forms.DateTimePicker()
        Me.Dttrtedfrom = New System.Windows.Forms.DateTimePicker()
        Me.txtgetpt = New System.Windows.Forms.TextBox()
        Me.btnrefreshconsult = New System.Windows.Forms.Button()
        Me.btngetpt = New System.Windows.Forms.Button()
        Me.Btnnew = New System.Windows.Forms.Button()
        Me.btnfindfolder = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker14 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker13 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.viewallfolder = New System.Windows.Forms.CheckBox()
        Me.BtnNewAppt = New System.Windows.Forms.Button()
        Me.btnsearchAppt = New System.Windows.Forms.Button()
        Me.Btnref = New System.Windows.Forms.Button()
        Me.Txtsearchappt = New System.Windows.Forms.TextBox()
        Me.from = New System.Windows.Forms.DateTimePicker()
        Me.dto = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.viewallappt = New System.Windows.Forms.CheckBox()
        Me.CBOaptclinic = New System.Windows.Forms.ComboBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.btnsearchDiag = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.TxtsearchDiag = New System.Windows.Forms.TextBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.DateTimePicker12 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker11 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.DateTimePicker10 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker9 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabMylist.SuspendLayout()
        Me.Tabpag1.SuspendLayout()
        CType(Me.Dtgmypendlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPageappt.SuspendLayout()
        CType(Me.DtgMyconsultation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabMylist
        '
        Me.TabMylist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabMylist.Controls.Add(Me.Tabpag1)
        Me.TabMylist.Controls.Add(Me.TabPageappt)
        Me.TabMylist.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMylist.Location = New System.Drawing.Point(-1, 7)
        Me.TabMylist.Name = "TabMylist"
        Me.TabMylist.SelectedIndex = 0
        Me.TabMylist.Size = New System.Drawing.Size(1152, 476)
        Me.TabMylist.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabMylist.TabIndex = 1
        '
        'Tabpag1
        '
        Me.Tabpag1.Controls.Add(Me.lbl4)
        Me.Tabpag1.Controls.Add(Me.Label13)
        Me.Tabpag1.Controls.Add(Me.Label9)
        Me.Tabpag1.Controls.Add(Me.Label10)
        Me.Tabpag1.Controls.Add(Me.Dtgmypendlist)
        Me.Tabpag1.Controls.Add(Me.Panel3)
        Me.Tabpag1.Location = New System.Drawing.Point(4, 22)
        Me.Tabpag1.Name = "Tabpag1"
        Me.Tabpag1.Size = New System.Drawing.Size(1144, 450)
        Me.Tabpag1.TabIndex = 3
        Me.Tabpag1.Text = "PENDING"
        Me.Tabpag1.ToolTipText = "Patient Folders"
        Me.Tabpag1.UseVisualStyleBackColor = True
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(72, 429)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(52, 15)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "Records"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 429)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 15)
        Me.Label9.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 430)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 6
        '
        'Dtgmypendlist
        '
        Me.Dtgmypendlist.AllowUserToAddRows = False
        Me.Dtgmypendlist.AllowUserToDeleteRows = False
        Me.Dtgmypendlist.AllowUserToOrderColumns = True
        Me.Dtgmypendlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtgmypendlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgmypendlist.Location = New System.Drawing.Point(3, 50)
        Me.Dtgmypendlist.Name = "Dtgmypendlist"
        Me.Dtgmypendlist.ReadOnly = True
        Me.Dtgmypendlist.Size = New System.Drawing.Size(1130, 368)
        Me.Dtgmypendlist.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.dttopend)
        Me.Panel3.Controls.Add(Me.dtfrmpend)
        Me.Panel3.Controls.Add(Me.txtfindpt)
        Me.Panel3.Controls.Add(Me.btnrefresh)
        Me.Panel3.Controls.Add(Me.btnfindpt)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1129, 41)
        Me.Panel3.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(230, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "To"
        '
        'dttopend
        '
        Me.dttopend.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttopend.Location = New System.Drawing.Point(261, 11)
        Me.dttopend.Name = "dttopend"
        Me.dttopend.Size = New System.Drawing.Size(210, 22)
        Me.dttopend.TabIndex = 17
        '
        'dtfrmpend
        '
        Me.dtfrmpend.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrmpend.Location = New System.Drawing.Point(10, 11)
        Me.dtfrmpend.Name = "dtfrmpend"
        Me.dtfrmpend.Size = New System.Drawing.Size(211, 22)
        Me.dtfrmpend.TabIndex = 16
        '
        'txtfindpt
        '
        Me.txtfindpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfindpt.Location = New System.Drawing.Point(858, 14)
        Me.txtfindpt.Name = "txtfindpt"
        Me.txtfindpt.Size = New System.Drawing.Size(170, 20)
        Me.txtfindpt.TabIndex = 14
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrefresh.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(480, 8)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(93, 25)
        Me.btnrefresh.TabIndex = 12
        Me.btnrefresh.Text = "    Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btnfindpt
        '
        Me.btnfindpt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindpt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindpt.ForeColor = System.Drawing.Color.Green
        Me.btnfindpt.Image = CType(resources.GetObject("btnfindpt.Image"), System.Drawing.Image)
        Me.btnfindpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfindpt.Location = New System.Drawing.Point(1034, 9)
        Me.btnfindpt.Name = "btnfindpt"
        Me.btnfindpt.Size = New System.Drawing.Size(90, 26)
        Me.btnfindpt.TabIndex = 15
        Me.btnfindpt.Text = "     Search"
        Me.btnfindpt.UseVisualStyleBackColor = False
        '
        'TabPageappt
        '
        Me.TabPageappt.Controls.Add(Me.Label14)
        Me.TabPageappt.Controls.Add(Me.Label15)
        Me.TabPageappt.Controls.Add(Me.Label1)
        Me.TabPageappt.Controls.Add(Me.Label2)
        Me.TabPageappt.Controls.Add(Me.DtgMyconsultation)
        Me.TabPageappt.Controls.Add(Me.Panel4)
        Me.TabPageappt.Location = New System.Drawing.Point(4, 22)
        Me.TabPageappt.Name = "TabPageappt"
        Me.TabPageappt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageappt.Size = New System.Drawing.Size(1144, 450)
        Me.TabPageappt.TabIndex = 1
        Me.TabPageappt.Text = "TREATED"
        Me.TabPageappt.ToolTipText = "Book Appoinment"
        Me.TabPageappt.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(68, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Records"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 426)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 15)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 4
        '
        'DtgMyconsultation
        '
        Me.DtgMyconsultation.AllowUserToAddRows = False
        Me.DtgMyconsultation.AllowUserToDeleteRows = False
        Me.DtgMyconsultation.AllowUserToOrderColumns = True
        Me.DtgMyconsultation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgMyconsultation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DtgMyconsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgMyconsultation.Location = New System.Drawing.Point(3, 47)
        Me.DtgMyconsultation.Name = "DtgMyconsultation"
        Me.DtgMyconsultation.ReadOnly = True
        Me.DtgMyconsultation.Size = New System.Drawing.Size(1135, 367)
        Me.DtgMyconsultation.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Ivory
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Dttrtedto)
        Me.Panel4.Controls.Add(Me.Dttrtedfrom)
        Me.Panel4.Controls.Add(Me.txtgetpt)
        Me.Panel4.Controls.Add(Me.btnrefreshconsult)
        Me.Panel4.Controls.Add(Me.btngetpt)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1137, 44)
        Me.Panel4.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(232, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "To"
        '
        'Dttrtedto
        '
        Me.Dttrtedto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dttrtedto.Location = New System.Drawing.Point(266, 15)
        Me.Dttrtedto.Name = "Dttrtedto"
        Me.Dttrtedto.Size = New System.Drawing.Size(210, 22)
        Me.Dttrtedto.TabIndex = 17
        '
        'Dttrtedfrom
        '
        Me.Dttrtedfrom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dttrtedfrom.Location = New System.Drawing.Point(12, 15)
        Me.Dttrtedfrom.Name = "Dttrtedfrom"
        Me.Dttrtedfrom.Size = New System.Drawing.Size(211, 22)
        Me.Dttrtedfrom.TabIndex = 16
        '
        'txtgetpt
        '
        Me.txtgetpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgetpt.Location = New System.Drawing.Point(866, 17)
        Me.txtgetpt.Name = "txtgetpt"
        Me.txtgetpt.Size = New System.Drawing.Size(170, 20)
        Me.txtgetpt.TabIndex = 14
        '
        'btnrefreshconsult
        '
        Me.btnrefreshconsult.BackColor = System.Drawing.Color.White
        Me.btnrefreshconsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefreshconsult.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefreshconsult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnrefreshconsult.Image = CType(resources.GetObject("btnrefreshconsult.Image"), System.Drawing.Image)
        Me.btnrefreshconsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefreshconsult.Location = New System.Drawing.Point(485, 13)
        Me.btnrefreshconsult.Name = "btnrefreshconsult"
        Me.btnrefreshconsult.Size = New System.Drawing.Size(95, 25)
        Me.btnrefreshconsult.TabIndex = 12
        Me.btnrefreshconsult.Text = "      Refresh"
        Me.btnrefreshconsult.UseVisualStyleBackColor = False
        '
        'btngetpt
        '
        Me.btngetpt.BackColor = System.Drawing.Color.White
        Me.btngetpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngetpt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngetpt.ForeColor = System.Drawing.Color.Green
        Me.btngetpt.Image = CType(resources.GetObject("btngetpt.Image"), System.Drawing.Image)
        Me.btngetpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngetpt.Location = New System.Drawing.Point(1042, 11)
        Me.btngetpt.Name = "btngetpt"
        Me.btngetpt.Size = New System.Drawing.Size(92, 26)
        Me.btngetpt.TabIndex = 15
        Me.btngetpt.Text = "      Search"
        Me.btngetpt.UseVisualStyleBackColor = False
        '
        'Btnnew
        '
        Me.Btnnew.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnnew.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnew.ForeColor = System.Drawing.Color.Navy
        Me.Btnnew.Location = New System.Drawing.Point(2, 29)
        Me.Btnnew.Name = "Btnnew"
        Me.Btnnew.Size = New System.Drawing.Size(75, 23)
        Me.Btnnew.TabIndex = 1
        Me.Btnnew.Text = "New"
        Me.Btnnew.UseVisualStyleBackColor = False
        '
        'btnfindfolder
        '
        Me.btnfindfolder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindfolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindfolder.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindfolder.ForeColor = System.Drawing.Color.Green
        Me.btnfindfolder.Location = New System.Drawing.Point(1046, 26)
        Me.btnfindfolder.Name = "btnfindfolder"
        Me.btnfindfolder.Size = New System.Drawing.Size(75, 26)
        Me.btnfindfolder.TabIndex = 4
        Me.btnfindfolder.Text = "Search"
        Me.btnfindfolder.UseVisualStyleBackColor = False
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnview.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.Navy
        Me.btnview.Location = New System.Drawing.Point(636, 26)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(68, 25)
        Me.btnview.TabIndex = 2
        Me.btnview.Text = "Refresh"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(870, 29)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(170, 20)
        Me.txtfind.TabIndex = 4
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.Navy
        Me.btndelete.Location = New System.Drawing.Point(79, 29)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'dtfrom
        '
        Me.dtfrom.Location = New System.Drawing.Point(163, 29)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(211, 20)
        Me.dtfrom.TabIndex = 5
        '
        'dtto
        '
        Me.dtto.Location = New System.Drawing.Point(417, 29)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(210, 20)
        Me.dtto.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(383, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 15)
        Me.Label8.TabIndex = 7
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel8.ForeColor = System.Drawing.Color.White
        Me.Panel8.Location = New System.Drawing.Point(8, 88)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1145, 55)
        Me.Panel8.TabIndex = 8
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Navy
        Me.Button12.Location = New System.Drawing.Point(2, 29)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 1
        Me.Button12.Text = "New"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Green
        Me.Button11.Location = New System.Drawing.Point(1064, 26)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 26)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "Search"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Navy
        Me.Button10.Location = New System.Drawing.Point(79, 29)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "View"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(862, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(196, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Location = New System.Drawing.Point(156, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DateTimePicker14
        '
        Me.DateTimePicker14.Location = New System.Drawing.Point(255, 29)
        Me.DateTimePicker14.Name = "DateTimePicker14"
        Me.DateTimePicker14.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker14.TabIndex = 5
        '
        'DateTimePicker13
        '
        Me.DateTimePicker13.Location = New System.Drawing.Point(535, 29)
        Me.DateTimePicker13.Name = "DateTimePicker13"
        Me.DateTimePicker13.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker13.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(501, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 7
        '
        'viewallfolder
        '
        Me.viewallfolder.AutoSize = True
        Me.viewallfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewallfolder.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewallfolder.ForeColor = System.Drawing.Color.Black
        Me.viewallfolder.Location = New System.Drawing.Point(782, 29)
        Me.viewallfolder.Name = "viewallfolder"
        Me.viewallfolder.Size = New System.Drawing.Size(77, 21)
        Me.viewallfolder.TabIndex = 10
        Me.viewallfolder.Text = "View All"
        Me.viewallfolder.UseVisualStyleBackColor = True
        '
        'BtnNewAppt
        '
        Me.BtnNewAppt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNewAppt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewAppt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAppt.ForeColor = System.Drawing.Color.Navy
        Me.BtnNewAppt.Location = New System.Drawing.Point(2, 30)
        Me.BtnNewAppt.Name = "BtnNewAppt"
        Me.BtnNewAppt.Size = New System.Drawing.Size(58, 23)
        Me.BtnNewAppt.TabIndex = 1
        Me.BtnNewAppt.Text = "New"
        Me.BtnNewAppt.UseVisualStyleBackColor = False
        '
        'btnsearchAppt
        '
        Me.btnsearchAppt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsearchAppt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearchAppt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchAppt.ForeColor = System.Drawing.Color.Green
        Me.btnsearchAppt.Location = New System.Drawing.Point(1046, 26)
        Me.btnsearchAppt.Name = "btnsearchAppt"
        Me.btnsearchAppt.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchAppt.TabIndex = 4
        Me.btnsearchAppt.Text = "Search"
        Me.btnsearchAppt.UseVisualStyleBackColor = False
        '
        'Btnref
        '
        Me.Btnref.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnref.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnref.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnref.ForeColor = System.Drawing.Color.Navy
        Me.Btnref.Location = New System.Drawing.Point(685, 30)
        Me.Btnref.Name = "Btnref"
        Me.Btnref.Size = New System.Drawing.Size(69, 23)
        Me.Btnref.TabIndex = 2
        Me.Btnref.Text = "Refresh"
        Me.Btnref.UseVisualStyleBackColor = False
        '
        'Txtsearchappt
        '
        Me.Txtsearchappt.Location = New System.Drawing.Point(880, 29)
        Me.Txtsearchappt.Name = "Txtsearchappt"
        Me.Txtsearchappt.Size = New System.Drawing.Size(160, 20)
        Me.Txtsearchappt.TabIndex = 4
        '
        'from
        '
        Me.from.Location = New System.Drawing.Point(218, 32)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(206, 20)
        Me.from.TabIndex = 5
        '
        'dto
        '
        Me.dto.Location = New System.Drawing.Point(468, 32)
        Me.dto.Name = "dto"
        Me.dto.Size = New System.Drawing.Size(209, 20)
        Me.dto.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(436, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(8, 88)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1145, 55)
        Me.Panel5.TabIndex = 8
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Navy
        Me.Button9.Location = New System.Drawing.Point(2, 29)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "New"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Green
        Me.Button8.Location = New System.Drawing.Point(1064, 26)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 26)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Navy
        Me.Button7.Location = New System.Drawing.Point(79, 29)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "View"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(862, 29)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(196, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Navy
        Me.Button6.Location = New System.Drawing.Point(156, 29)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.Location = New System.Drawing.Point(255, 29)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker6.TabIndex = 5
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Location = New System.Drawing.Point(535, 29)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker5.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(501, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 7
        '
        'viewallappt
        '
        Me.viewallappt.AutoSize = True
        Me.viewallappt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewallappt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewallappt.Location = New System.Drawing.Point(792, 31)
        Me.viewallappt.Name = "viewallappt"
        Me.viewallappt.Size = New System.Drawing.Size(77, 21)
        Me.viewallappt.TabIndex = 9
        Me.viewallappt.Text = "View All"
        Me.viewallappt.UseVisualStyleBackColor = True
        '
        'CBOaptclinic
        '
        Me.CBOaptclinic.FormattingEnabled = True
        Me.CBOaptclinic.Items.AddRange(New Object() {"SELECT CLINIC", "GOPD", "MOPD", "POPD", "SOPD", "ANC", "GYNAE", "A&E", "EUROLOGY", "DEMATOLOGY", "ART"})
        Me.CBOaptclinic.Location = New System.Drawing.Point(66, 31)
        Me.CBOaptclinic.Name = "CBOaptclinic"
        Me.CBOaptclinic.Size = New System.Drawing.Size(119, 21)
        Me.CBOaptclinic.TabIndex = 6
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button20.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.Navy
        Me.Button20.Location = New System.Drawing.Point(2, 29)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 23)
        Me.Button20.TabIndex = 1
        Me.Button20.Text = "New"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'btnsearchDiag
        '
        Me.btnsearchDiag.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsearchDiag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearchDiag.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchDiag.ForeColor = System.Drawing.Color.Green
        Me.btnsearchDiag.Location = New System.Drawing.Point(1046, 26)
        Me.btnsearchDiag.Name = "btnsearchDiag"
        Me.btnsearchDiag.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchDiag.TabIndex = 4
        Me.btnsearchDiag.Text = "Search"
        Me.btnsearchDiag.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button19.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.Navy
        Me.Button19.Location = New System.Drawing.Point(79, 29)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(75, 23)
        Me.Button19.TabIndex = 2
        Me.Button19.Text = "View"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'TxtsearchDiag
        '
        Me.TxtsearchDiag.Location = New System.Drawing.Point(844, 29)
        Me.TxtsearchDiag.Name = "TxtsearchDiag"
        Me.TxtsearchDiag.Size = New System.Drawing.Size(196, 20)
        Me.TxtsearchDiag.TabIndex = 4
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button18.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.Navy
        Me.Button18.Location = New System.Drawing.Point(156, 29)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(75, 23)
        Me.Button18.TabIndex = 3
        Me.Button18.Text = "Delete"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'DateTimePicker12
        '
        Me.DateTimePicker12.Location = New System.Drawing.Point(255, 29)
        Me.DateTimePicker12.Name = "DateTimePicker12"
        Me.DateTimePicker12.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker12.TabIndex = 5
        '
        'DateTimePicker11
        '
        Me.DateTimePicker11.Location = New System.Drawing.Point(535, 29)
        Me.DateTimePicker11.Name = "DateTimePicker11"
        Me.DateTimePicker11.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker11.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(501, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 15)
        Me.Label6.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel7.ForeColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(8, 88)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1145, 55)
        Me.Panel7.TabIndex = 8
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button17.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.Navy
        Me.Button17.Location = New System.Drawing.Point(2, 29)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(75, 23)
        Me.Button17.TabIndex = 1
        Me.Button17.Text = "New"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button16.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Green
        Me.Button16.Location = New System.Drawing.Point(1064, 26)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 26)
        Me.Button16.TabIndex = 4
        Me.Button16.Text = "Search"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Navy
        Me.Button15.Location = New System.Drawing.Point(79, 29)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 2
        Me.Button15.Text = "View"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(862, 29)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(196, 20)
        Me.TextBox6.TabIndex = 4
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Navy
        Me.Button14.Location = New System.Drawing.Point(156, 29)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 3
        Me.Button14.Text = "Delete"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'DateTimePicker10
        '
        Me.DateTimePicker10.Location = New System.Drawing.Point(255, 29)
        Me.DateTimePicker10.Name = "DateTimePicker10"
        Me.DateTimePicker10.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker10.TabIndex = 5
        '
        'DateTimePicker9
        '
        Me.DateTimePicker9.Location = New System.Drawing.Point(535, 29)
        Me.DateTimePicker9.Name = "DateTimePicker9"
        Me.DateTimePicker9.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker9.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(501, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 7
        '
        'FrmMywaitinglist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1154, 484)
        Me.Controls.Add(Me.TabMylist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMywaitinglist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "          PERSONAL WAITING LIST"
        Me.TabMylist.ResumeLayout(False)
        Me.Tabpag1.ResumeLayout(False)
        Me.Tabpag1.PerformLayout()
        CType(Me.Dtgmypendlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPageappt.ResumeLayout(False)
        Me.TabPageappt.PerformLayout()
        CType(Me.DtgMyconsultation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabMylist As TabControl
    Friend WithEvents Tabpag1 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Dtgmypendlist As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabPageappt As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtgMyconsultation As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btnnew As Button
    Friend WithEvents btnfindfolder As Button
    Friend WithEvents btnview As Button
    Friend WithEvents txtfind As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents dtfrom As DateTimePicker
    Friend WithEvents dtto As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents DateTimePicker14 As DateTimePicker
    Friend WithEvents DateTimePicker13 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents viewallfolder As CheckBox
    Friend WithEvents BtnNewAppt As Button
    Friend WithEvents btnsearchAppt As Button
    Friend WithEvents Btnref As Button
    Friend WithEvents Txtsearchappt As TextBox
    Friend WithEvents from As DateTimePicker
    Friend WithEvents dto As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents viewallappt As CheckBox
    Friend WithEvents CBOaptclinic As ComboBox
    Friend WithEvents Button20 As Button
    Friend WithEvents btnsearchDiag As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents TxtsearchDiag As TextBox
    Friend WithEvents Button18 As Button
    Friend WithEvents DateTimePicker12 As DateTimePicker
    Friend WithEvents DateTimePicker11 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button14 As Button
    Friend WithEvents DateTimePicker10 As DateTimePicker
    Friend WithEvents DateTimePicker9 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dttopend As DateTimePicker
    Friend WithEvents dtfrmpend As DateTimePicker
    Friend WithEvents txtfindpt As TextBox
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnfindpt As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Dttrtedto As DateTimePicker
    Friend WithEvents Dttrtedfrom As DateTimePicker
    Friend WithEvents txtgetpt As TextBox
    Friend WithEvents btnrefreshconsult As Button
    Friend WithEvents btngetpt As Button
    Friend WithEvents lbl4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
