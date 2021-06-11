<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmrecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmrecords))
        Me.Tabrec = New System.Windows.Forms.TabControl()
        Me.Tabpagfolder = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Dtgfolder = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CboSearch = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker13 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker14 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btnfindfolder = New System.Windows.Forms.Button()
        Me.Btnnew = New System.Windows.Forms.Button()
        Me.TabPageappt = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtgApt = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBOaptclinic = New System.Windows.Forms.ComboBox()
        Me.viewallappt = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dto = New System.Windows.Forms.DateTimePicker()
        Me.from = New System.Windows.Forms.DateTimePicker()
        Me.Txtsearchappt = New System.Windows.Forms.TextBox()
        Me.Btnref = New System.Windows.Forms.Button()
        Me.btnsearchAppt = New System.Windows.Forms.Button()
        Me.BtnNewAppt = New System.Windows.Forms.Button()
        Me.Tabrec.SuspendLayout()
        Me.Tabpagfolder.SuspendLayout()
        CType(Me.Dtgfolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabPageappt.SuspendLayout()
        CType(Me.DtgApt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabrec
        '
        Me.Tabrec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabrec.Controls.Add(Me.Tabpagfolder)
        Me.Tabrec.Controls.Add(Me.TabPageappt)
        Me.Tabrec.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabrec.Location = New System.Drawing.Point(5, 12)
        Me.Tabrec.Name = "Tabrec"
        Me.Tabrec.SelectedIndex = 0
        Me.Tabrec.Size = New System.Drawing.Size(1163, 443)
        Me.Tabrec.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.Tabrec.TabIndex = 0
        '
        'Tabpagfolder
        '
        Me.Tabpagfolder.Controls.Add(Me.Label9)
        Me.Tabpagfolder.Controls.Add(Me.Label10)
        Me.Tabpagfolder.Controls.Add(Me.Dtgfolder)
        Me.Tabpagfolder.Controls.Add(Me.Panel3)
        Me.Tabpagfolder.Location = New System.Drawing.Point(4, 22)
        Me.Tabpagfolder.Name = "Tabpagfolder"
        Me.Tabpagfolder.Size = New System.Drawing.Size(1155, 417)
        Me.Tabpagfolder.TabIndex = 3
        Me.Tabpagfolder.Text = "FOLDER"
        Me.Tabpagfolder.ToolTipText = "Patient Folders"
        Me.Tabpagfolder.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 392)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Records found."
        '
        'Dtgfolder
        '
        Me.Dtgfolder.AllowUserToAddRows = False
        Me.Dtgfolder.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        Me.Dtgfolder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dtgfolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtgfolder.BackgroundColor = System.Drawing.Color.White
        Me.Dtgfolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgfolder.Location = New System.Drawing.Point(2, 47)
        Me.Dtgfolder.Name = "Dtgfolder"
        Me.Dtgfolder.ReadOnly = True
        Me.Dtgfolder.Size = New System.Drawing.Size(1150, 327)
        Me.Dtgfolder.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.CboSearch)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.dtto)
        Me.Panel3.Controls.Add(Me.dtfrom)
        Me.Panel3.Controls.Add(Me.txtfind)
        Me.Panel3.Controls.Add(Me.btnview)
        Me.Panel3.Controls.Add(Me.btnfindfolder)
        Me.Panel3.Controls.Add(Me.Btnnew)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1151, 39)
        Me.Panel3.TabIndex = 4
        '
        'CboSearch
        '
        Me.CboSearch.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSearch.FormattingEnabled = True
        Me.CboSearch.Items.AddRange(New Object() {"Phone No", "Hospital No", "Surname"})
        Me.CboSearch.Location = New System.Drawing.Point(686, 8)
        Me.CboSearch.Name = "CboSearch"
        Me.CboSearch.Size = New System.Drawing.Size(145, 25)
        Me.CboSearch.TabIndex = 11
        Me.CboSearch.Text = "  ---Search By---"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.ForeColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(633, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 38)
        Me.Panel1.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.DateTimePicker13)
        Me.Panel8.Controls.Add(Me.DateTimePicker14)
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Controls.Add(Me.TextBox3)
        Me.Panel8.Controls.Add(Me.Button10)
        Me.Panel8.Controls.Add(Me.Button11)
        Me.Panel8.Controls.Add(Me.Button12)
        Me.Panel8.ForeColor = System.Drawing.Color.White
        Me.Panel8.Location = New System.Drawing.Point(8, 88)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1145, 55)
        Me.Panel8.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(501, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "To"
        '
        'DateTimePicker13
        '
        Me.DateTimePicker13.Location = New System.Drawing.Point(535, 29)
        Me.DateTimePicker13.Name = "DateTimePicker13"
        Me.DateTimePicker13.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker13.TabIndex = 6
        '
        'DateTimePicker14
        '
        Me.DateTimePicker14.Location = New System.Drawing.Point(255, 29)
        Me.DateTimePicker14.Name = "DateTimePicker14"
        Me.DateTimePicker14.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker14.TabIndex = 5
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(862, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(196, 20)
        Me.TextBox3.TabIndex = 4
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(277, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "To"
        '
        'dtto
        '
        Me.dtto.Location = New System.Drawing.Point(303, 12)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(203, 20)
        Me.dtto.TabIndex = 6
        '
        'dtfrom
        '
        Me.dtfrom.Location = New System.Drawing.Point(70, 12)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(203, 20)
        Me.dtfrom.TabIndex = 5
        '
        'txtfind
        '
        Me.txtfind.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfind.Location = New System.Drawing.Point(837, 8)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(186, 25)
        Me.txtfind.TabIndex = 4
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnview.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.Blue
        Me.btnview.Image = CType(resources.GetObject("btnview.Image"), System.Drawing.Image)
        Me.btnview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnview.Location = New System.Drawing.Point(511, 8)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(90, 25)
        Me.btnview.TabIndex = 2
        Me.btnview.Text = "     Refresh"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'btnfindfolder
        '
        Me.btnfindfolder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfindfolder.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindfolder.ForeColor = System.Drawing.Color.Green
        Me.btnfindfolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfindfolder.Location = New System.Drawing.Point(1025, 7)
        Me.btnfindfolder.Name = "btnfindfolder"
        Me.btnfindfolder.Size = New System.Drawing.Size(86, 26)
        Me.btnfindfolder.TabIndex = 4
        Me.btnfindfolder.Text = "Search"
        Me.btnfindfolder.UseVisualStyleBackColor = False
        '
        'Btnnew
        '
        Me.Btnnew.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnnew.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnew.ForeColor = System.Drawing.Color.Blue
        Me.Btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnnew.Location = New System.Drawing.Point(2, 5)
        Me.Btnnew.Name = "Btnnew"
        Me.Btnnew.Size = New System.Drawing.Size(64, 28)
        Me.Btnnew.TabIndex = 1
        Me.Btnnew.Text = "New"
        Me.Btnnew.UseVisualStyleBackColor = False
        '
        'TabPageappt
        '
        Me.TabPageappt.Controls.Add(Me.Label1)
        Me.TabPageappt.Controls.Add(Me.Label2)
        Me.TabPageappt.Controls.Add(Me.DtgApt)
        Me.TabPageappt.Controls.Add(Me.Panel4)
        Me.TabPageappt.Location = New System.Drawing.Point(4, 22)
        Me.TabPageappt.Name = "TabPageappt"
        Me.TabPageappt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageappt.Size = New System.Drawing.Size(1155, 417)
        Me.TabPageappt.TabIndex = 1
        Me.TabPageappt.Text = "APPOINTMENT"
        Me.TabPageappt.ToolTipText = "Book Appoinment"
        Me.TabPageappt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Records found."
        '
        'DtgApt
        '
        Me.DtgApt.AllowUserToAddRows = False
        Me.DtgApt.AllowUserToDeleteRows = False
        Me.DtgApt.AllowUserToOrderColumns = True
        Me.DtgApt.BackgroundColor = System.Drawing.Color.White
        Me.DtgApt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgApt.Location = New System.Drawing.Point(5, 48)
        Me.DtgApt.Name = "DtgApt"
        Me.DtgApt.ReadOnly = True
        Me.DtgApt.Size = New System.Drawing.Size(1150, 327)
        Me.DtgApt.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.CBOaptclinic)
        Me.Panel4.Controls.Add(Me.viewallappt)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.dto)
        Me.Panel4.Controls.Add(Me.from)
        Me.Panel4.Controls.Add(Me.Txtsearchappt)
        Me.Panel4.Controls.Add(Me.Btnref)
        Me.Panel4.Controls.Add(Me.btnsearchAppt)
        Me.Panel4.Controls.Add(Me.BtnNewAppt)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1151, 42)
        Me.Panel4.TabIndex = 2
        '
        'CBOaptclinic
        '
        Me.CBOaptclinic.FormattingEnabled = True
        Me.CBOaptclinic.Items.AddRange(New Object() {"SELECT CLINIC", "GOPD", "MOPD", "POPD", "SOPD", "ANC", "GYNAE", "A&E", "EUROLOGY", "DEMATOLOGY", "ART"})
        Me.CBOaptclinic.Location = New System.Drawing.Point(88, 16)
        Me.CBOaptclinic.Name = "CBOaptclinic"
        Me.CBOaptclinic.Size = New System.Drawing.Size(131, 21)
        Me.CBOaptclinic.TabIndex = 6
        Me.CBOaptclinic.Text = "  SELECT CLINIC"
        '
        'viewallappt
        '
        Me.viewallappt.AutoSize = True
        Me.viewallappt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewallappt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewallappt.Location = New System.Drawing.Point(801, 16)
        Me.viewallappt.Name = "viewallappt"
        Me.viewallappt.Size = New System.Drawing.Size(77, 21)
        Me.viewallappt.TabIndex = 9
        Me.viewallappt.Text = "View All"
        Me.viewallappt.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.DateTimePicker5)
        Me.Panel5.Controls.Add(Me.DateTimePicker6)
        Me.Panel5.Controls.Add(Me.Button6)
        Me.Panel5.Controls.Add(Me.TextBox4)
        Me.Panel5.Controls.Add(Me.Button7)
        Me.Panel5.Controls.Add(Me.Button8)
        Me.Panel5.Controls.Add(Me.Button9)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(8, 88)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1145, 55)
        Me.Panel5.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(501, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "To"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Location = New System.Drawing.Point(535, 29)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker5.TabIndex = 6
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.Location = New System.Drawing.Point(255, 29)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker6.TabIndex = 5
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(862, 29)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(196, 20)
        Me.TextBox4.TabIndex = 4
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(436, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "To"
        '
        'dto
        '
        Me.dto.Location = New System.Drawing.Point(461, 15)
        Me.dto.Name = "dto"
        Me.dto.Size = New System.Drawing.Size(209, 20)
        Me.dto.TabIndex = 6
        '
        'from
        '
        Me.from.Location = New System.Drawing.Point(225, 16)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(206, 20)
        Me.from.TabIndex = 5
        '
        'Txtsearchappt
        '
        Me.Txtsearchappt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsearchappt.Location = New System.Drawing.Point(882, 11)
        Me.Txtsearchappt.Name = "Txtsearchappt"
        Me.Txtsearchappt.Size = New System.Drawing.Size(160, 25)
        Me.Txtsearchappt.TabIndex = 4
        '
        'Btnref
        '
        Me.Btnref.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnref.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnref.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnref.ForeColor = System.Drawing.Color.Blue
        Me.Btnref.Image = CType(resources.GetObject("Btnref.Image"), System.Drawing.Image)
        Me.Btnref.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnref.Location = New System.Drawing.Point(676, 11)
        Me.Btnref.Name = "Btnref"
        Me.Btnref.Size = New System.Drawing.Size(93, 24)
        Me.Btnref.TabIndex = 2
        Me.Btnref.Text = "    Refresh"
        Me.Btnref.UseVisualStyleBackColor = False
        '
        'btnsearchAppt
        '
        Me.btnsearchAppt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsearchAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchAppt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchAppt.ForeColor = System.Drawing.Color.Green
        Me.btnsearchAppt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearchAppt.Location = New System.Drawing.Point(1046, 10)
        Me.btnsearchAppt.Name = "btnsearchAppt"
        Me.btnsearchAppt.Size = New System.Drawing.Size(95, 26)
        Me.btnsearchAppt.TabIndex = 4
        Me.btnsearchAppt.Text = "Search"
        Me.btnsearchAppt.UseVisualStyleBackColor = False
        '
        'BtnNewAppt
        '
        Me.BtnNewAppt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNewAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAppt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAppt.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewAppt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAppt.Location = New System.Drawing.Point(4, 10)
        Me.BtnNewAppt.Name = "BtnNewAppt"
        Me.BtnNewAppt.Size = New System.Drawing.Size(69, 29)
        Me.BtnNewAppt.TabIndex = 1
        Me.BtnNewAppt.Text = "New"
        Me.BtnNewAppt.UseVisualStyleBackColor = False
        '
        'Frmrecords
        '
        Me.AcceptButton = Me.btnfindfolder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1172, 453)
        Me.Controls.Add(Me.Tabrec)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frmrecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " MEDICAL RECORDS"
        Me.Tabrec.ResumeLayout(False)
        Me.Tabpagfolder.ResumeLayout(False)
        Me.Tabpagfolder.PerformLayout()
        CType(Me.Dtgfolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TabPageappt.ResumeLayout(False)
        Me.TabPageappt.PerformLayout()
        CType(Me.DtgApt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabrec As TabControl
    Friend WithEvents TabPageappt As TabPage
    Friend WithEvents DtgApt As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dto As DateTimePicker
    Friend WithEvents from As DateTimePicker
    Friend WithEvents Txtsearchappt As TextBox
    Friend WithEvents Btnref As Button
    Friend WithEvents btnsearchAppt As Button
    Friend WithEvents BtnNewAppt As Button
    Friend WithEvents Tabpagfolder As TabPage
    Friend WithEvents Dtgfolder As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker13 As DateTimePicker
    Friend WithEvents DateTimePicker14 As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtto As DateTimePicker
    Friend WithEvents dtfrom As DateTimePicker
    Friend WithEvents txtfind As TextBox
    Friend WithEvents btnview As Button
    Friend WithEvents btnfindfolder As Button
    Friend WithEvents Btnnew As Button
    Friend WithEvents viewallappt As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBOaptclinic As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CboSearch As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
