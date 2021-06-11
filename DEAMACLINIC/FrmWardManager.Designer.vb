<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWardManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWardManager))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tabward = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Dgvpend = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DttoPend = New System.Windows.Forms.DateTimePicker()
        Me.Dtfrmpend = New System.Windows.Forms.DateTimePicker()
        Me.BtnRelPend = New System.Windows.Forms.Button()
        Me.BtnFindpend = New System.Windows.Forms.Button()
        Me.Txtfindpend = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Dgvonadmision = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtAto = New System.Windows.Forms.DateTimePicker()
        Me.DtAfrm = New System.Windows.Forms.DateTimePicker()
        Me.BtnReLoadAdmit = New System.Windows.Forms.Button()
        Me.BtnFindon = New System.Windows.Forms.Button()
        Me.TxtFindon = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvDischrged = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Disto = New System.Windows.Forms.DateTimePicker()
        Me.Disfrm = New System.Windows.Forms.DateTimePicker()
        Me.ReloadDis = New System.Windows.Forms.Button()
        Me.BtnfindDischrg = New System.Windows.Forms.Button()
        Me.TxtfindDischrg = New System.Windows.Forms.TextBox()
        Me.Tabward.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dgvpend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgvonadmision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvDischrged, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabward
        '
        Me.Tabward.Controls.Add(Me.TabPage1)
        Me.Tabward.Controls.Add(Me.TabPage2)
        Me.Tabward.Controls.Add(Me.TabPage3)
        Me.Tabward.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabward.Location = New System.Drawing.Point(2, 7)
        Me.Tabward.Name = "Tabward"
        Me.Tabward.SelectedIndex = 0
        Me.Tabward.Size = New System.Drawing.Size(988, 373)
        Me.Tabward.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dgvpend)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(980, 345)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PENDING"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Dgvpend
        '
        Me.Dgvpend.AllowUserToAddRows = False
        Me.Dgvpend.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        Me.Dgvpend.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvpend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgvpend.BackgroundColor = System.Drawing.Color.White
        Me.Dgvpend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvpend.Location = New System.Drawing.Point(0, 42)
        Me.Dgvpend.Name = "Dgvpend"
        Me.Dgvpend.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvpend.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgvpend.Size = New System.Drawing.Size(977, 300)
        Me.Dgvpend.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DttoPend)
        Me.Panel1.Controls.Add(Me.Dtfrmpend)
        Me.Panel1.Controls.Add(Me.BtnRelPend)
        Me.Panel1.Controls.Add(Me.BtnFindpend)
        Me.Panel1.Controls.Add(Me.Txtfindpend)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(631, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Enter Hospital No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "To"
        '
        'DttoPend
        '
        Me.DttoPend.Location = New System.Drawing.Point(246, 11)
        Me.DttoPend.Name = "DttoPend"
        Me.DttoPend.Size = New System.Drawing.Size(229, 22)
        Me.DttoPend.TabIndex = 22
        '
        'Dtfrmpend
        '
        Me.Dtfrmpend.Location = New System.Drawing.Point(4, 11)
        Me.Dtfrmpend.Name = "Dtfrmpend"
        Me.Dtfrmpend.Size = New System.Drawing.Size(211, 22)
        Me.Dtfrmpend.TabIndex = 21
        '
        'BtnRelPend
        '
        Me.BtnRelPend.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRelPend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRelPend.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRelPend.ForeColor = System.Drawing.Color.Blue
        Me.BtnRelPend.Image = CType(resources.GetObject("BtnRelPend.Image"), System.Drawing.Image)
        Me.BtnRelPend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRelPend.Location = New System.Drawing.Point(481, 10)
        Me.BtnRelPend.Name = "BtnRelPend"
        Me.BtnRelPend.Size = New System.Drawing.Size(89, 23)
        Me.BtnRelPend.TabIndex = 20
        Me.BtnRelPend.Text = "     Refresh"
        Me.BtnRelPend.UseVisualStyleBackColor = False
        '
        'BtnFindpend
        '
        Me.BtnFindpend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindpend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFindpend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFindpend.Location = New System.Drawing.Point(875, 3)
        Me.BtnFindpend.Name = "BtnFindpend"
        Me.BtnFindpend.Size = New System.Drawing.Size(83, 29)
        Me.BtnFindpend.TabIndex = 2
        Me.BtnFindpend.Text = "SEARCH"
        Me.BtnFindpend.UseVisualStyleBackColor = True
        '
        'Txtfindpend
        '
        Me.Txtfindpend.Location = New System.Drawing.Point(730, 10)
        Me.Txtfindpend.Name = "Txtfindpend"
        Me.Txtfindpend.Size = New System.Drawing.Size(142, 22)
        Me.Txtfindpend.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Dgvonadmision)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(980, 345)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADMITED"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Dgvonadmision
        '
        Me.Dgvonadmision.AllowUserToAddRows = False
        Me.Dgvonadmision.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        Me.Dgvonadmision.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgvonadmision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgvonadmision.BackgroundColor = System.Drawing.Color.White
        Me.Dgvonadmision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvonadmision.Location = New System.Drawing.Point(2, 42)
        Me.Dgvonadmision.Name = "Dgvonadmision"
        Me.Dgvonadmision.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvonadmision.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgvonadmision.Size = New System.Drawing.Size(977, 300)
        Me.Dgvonadmision.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DtAto)
        Me.Panel2.Controls.Add(Me.DtAfrm)
        Me.Panel2.Controls.Add(Me.BtnReLoadAdmit)
        Me.Panel2.Controls.Add(Me.BtnFindon)
        Me.Panel2.Controls.Add(Me.TxtFindon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 37)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(617, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Enter Hospital No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "To"
        '
        'DtAto
        '
        Me.DtAto.Location = New System.Drawing.Point(246, 11)
        Me.DtAto.Name = "DtAto"
        Me.DtAto.Size = New System.Drawing.Size(229, 22)
        Me.DtAto.TabIndex = 27
        '
        'DtAfrm
        '
        Me.DtAfrm.Location = New System.Drawing.Point(4, 11)
        Me.DtAfrm.Name = "DtAfrm"
        Me.DtAfrm.Size = New System.Drawing.Size(211, 22)
        Me.DtAfrm.TabIndex = 26
        '
        'BtnReLoadAdmit
        '
        Me.BtnReLoadAdmit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReLoadAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReLoadAdmit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReLoadAdmit.ForeColor = System.Drawing.Color.Blue
        Me.BtnReLoadAdmit.Image = CType(resources.GetObject("BtnReLoadAdmit.Image"), System.Drawing.Image)
        Me.BtnReLoadAdmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReLoadAdmit.Location = New System.Drawing.Point(481, 10)
        Me.BtnReLoadAdmit.Name = "BtnReLoadAdmit"
        Me.BtnReLoadAdmit.Size = New System.Drawing.Size(89, 23)
        Me.BtnReLoadAdmit.TabIndex = 25
        Me.BtnReLoadAdmit.Text = "     Refresh"
        Me.BtnReLoadAdmit.UseVisualStyleBackColor = False
        '
        'BtnFindon
        '
        Me.BtnFindon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFindon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFindon.Location = New System.Drawing.Point(879, 4)
        Me.BtnFindon.Name = "BtnFindon"
        Me.BtnFindon.Size = New System.Drawing.Size(89, 29)
        Me.BtnFindon.TabIndex = 2
        Me.BtnFindon.Text = "SEARCH"
        Me.BtnFindon.UseVisualStyleBackColor = True
        '
        'TxtFindon
        '
        Me.TxtFindon.Location = New System.Drawing.Point(716, 10)
        Me.TxtFindon.Name = "TxtFindon"
        Me.TxtFindon.Size = New System.Drawing.Size(160, 22)
        Me.TxtFindon.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvDischrged)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(980, 345)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DISCHARGED"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvDischrged
        '
        Me.DgvDischrged.AllowUserToAddRows = False
        Me.DgvDischrged.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        Me.DgvDischrged.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvDischrged.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvDischrged.BackgroundColor = System.Drawing.Color.White
        Me.DgvDischrged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDischrged.Location = New System.Drawing.Point(2, 42)
        Me.DgvDischrged.Name = "DgvDischrged"
        Me.DgvDischrged.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDischrged.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvDischrged.Size = New System.Drawing.Size(977, 300)
        Me.DgvDischrged.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Disto)
        Me.Panel3.Controls.Add(Me.Disfrm)
        Me.Panel3.Controls.Add(Me.ReloadDis)
        Me.Panel3.Controls.Add(Me.BtnfindDischrg)
        Me.Panel3.Controls.Add(Me.TxtfindDischrg)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 37)
        Me.Panel3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(618, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 14)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Enter Hospital No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "To"
        '
        'Disto
        '
        Me.Disto.Location = New System.Drawing.Point(248, 10)
        Me.Disto.Name = "Disto"
        Me.Disto.Size = New System.Drawing.Size(229, 22)
        Me.Disto.TabIndex = 33
        '
        'Disfrm
        '
        Me.Disfrm.Location = New System.Drawing.Point(6, 10)
        Me.Disfrm.Name = "Disfrm"
        Me.Disfrm.Size = New System.Drawing.Size(211, 22)
        Me.Disfrm.TabIndex = 32
        '
        'ReloadDis
        '
        Me.ReloadDis.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReloadDis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ReloadDis.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReloadDis.ForeColor = System.Drawing.Color.Blue
        Me.ReloadDis.Image = CType(resources.GetObject("ReloadDis.Image"), System.Drawing.Image)
        Me.ReloadDis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReloadDis.Location = New System.Drawing.Point(483, 9)
        Me.ReloadDis.Name = "ReloadDis"
        Me.ReloadDis.Size = New System.Drawing.Size(89, 23)
        Me.ReloadDis.TabIndex = 31
        Me.ReloadDis.Text = "     Refresh"
        Me.ReloadDis.UseVisualStyleBackColor = False
        '
        'BtnfindDischrg
        '
        Me.BtnfindDischrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnfindDischrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnfindDischrg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnfindDischrg.Location = New System.Drawing.Point(875, 10)
        Me.BtnfindDischrg.Name = "BtnfindDischrg"
        Me.BtnfindDischrg.Size = New System.Drawing.Size(94, 23)
        Me.BtnfindDischrg.TabIndex = 2
        Me.BtnfindDischrg.Text = " SEARCH"
        Me.BtnfindDischrg.UseVisualStyleBackColor = True
        '
        'TxtfindDischrg
        '
        Me.TxtfindDischrg.Location = New System.Drawing.Point(718, 10)
        Me.TxtfindDischrg.Name = "TxtfindDischrg"
        Me.TxtfindDischrg.Size = New System.Drawing.Size(151, 22)
        Me.TxtfindDischrg.TabIndex = 1
        '
        'FrmWardManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 383)
        Me.Controls.Add(Me.Tabward)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmWardManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " WARD MANAGER"
        Me.Tabward.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dgvpend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Dgvonadmision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvDischrged, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabward As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Dgvpend As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txtfindpend As TextBox
    Friend WithEvents BtnFindpend As Button
    Friend WithEvents Dgvonadmision As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnFindon As Button
    Friend WithEvents TxtFindon As TextBox
    Friend WithEvents DgvDischrged As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnfindDischrg As Button
    Friend WithEvents TxtfindDischrg As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DttoPend As DateTimePicker
    Friend WithEvents Dtfrmpend As DateTimePicker
    Friend WithEvents BtnRelPend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtAto As DateTimePicker
    Friend WithEvents DtAfrm As DateTimePicker
    Friend WithEvents BtnReLoadAdmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Disto As DateTimePicker
    Friend WithEvents Disfrm As DateTimePicker
    Friend WithEvents ReloadDis As Button
End Class
