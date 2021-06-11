<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTheartre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTheartre))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DttoPend = New System.Windows.Forms.DateTimePicker()
        Me.Dtfrmpend = New System.Windows.Forms.DateTimePicker()
        Me.txtserchpend = New System.Windows.Forms.TextBox()
        Me.BtnRelPend = New System.Windows.Forms.Button()
        Me.btnserchpend = New System.Windows.Forms.Button()
        Me.DtgPend = New System.Windows.Forms.DataGridView()
        Me.DtgTreat = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtToTrt = New System.Windows.Forms.DateTimePicker()
        Me.DtfrmTrt = New System.Windows.Forms.DateTimePicker()
        Me.txtfindTrt = New System.Windows.Forms.TextBox()
        Me.BtnLoadTreat = New System.Windows.Forms.Button()
        Me.btnsrchtrt = New System.Windows.Forms.Button()
        Me.TabPaid = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.tabsurgery = New System.Windows.Forms.TabControl()
        Me.TabTreated = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblcounttrt = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.DtgPend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgTreat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPaid.SuspendLayout()
        Me.tabsurgery.SuspendLayout()
        Me.TabTreated.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.DttoPend)
        Me.Panel4.Controls.Add(Me.Dtfrmpend)
        Me.Panel4.Controls.Add(Me.txtserchpend)
        Me.Panel4.Controls.Add(Me.BtnRelPend)
        Me.Panel4.Controls.Add(Me.btnserchpend)
        Me.Panel4.Location = New System.Drawing.Point(4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1124, 40)
        Me.Panel4.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(775, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 14)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Enter Hospital No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(431, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "To"
        '
        'DttoPend
        '
        Me.DttoPend.Location = New System.Drawing.Point(249, 13)
        Me.DttoPend.Name = "DttoPend"
        Me.DttoPend.Size = New System.Drawing.Size(229, 21)
        Me.DttoPend.TabIndex = 15
        '
        'Dtfrmpend
        '
        Me.Dtfrmpend.Location = New System.Drawing.Point(7, 13)
        Me.Dtfrmpend.Name = "Dtfrmpend"
        Me.Dtfrmpend.Size = New System.Drawing.Size(211, 21)
        Me.Dtfrmpend.TabIndex = 14
        '
        'txtserchpend
        '
        Me.txtserchpend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserchpend.Location = New System.Drawing.Point(875, 13)
        Me.txtserchpend.Name = "txtserchpend"
        Me.txtserchpend.Size = New System.Drawing.Size(153, 21)
        Me.txtserchpend.TabIndex = 12
        '
        'BtnRelPend
        '
        Me.BtnRelPend.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRelPend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRelPend.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRelPend.ForeColor = System.Drawing.Color.Blue
        Me.BtnRelPend.Image = CType(resources.GetObject("BtnRelPend.Image"), System.Drawing.Image)
        Me.BtnRelPend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRelPend.Location = New System.Drawing.Point(484, 12)
        Me.BtnRelPend.Name = "BtnRelPend"
        Me.BtnRelPend.Size = New System.Drawing.Size(89, 23)
        Me.BtnRelPend.TabIndex = 11
        Me.BtnRelPend.Text = "     Refresh"
        Me.BtnRelPend.UseVisualStyleBackColor = False
        '
        'btnserchpend
        '
        Me.btnserchpend.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnserchpend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnserchpend.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserchpend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnserchpend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnserchpend.Location = New System.Drawing.Point(1034, 11)
        Me.btnserchpend.Name = "btnserchpend"
        Me.btnserchpend.Size = New System.Drawing.Size(82, 24)
        Me.btnserchpend.TabIndex = 13
        Me.btnserchpend.Text = "Search"
        Me.btnserchpend.UseVisualStyleBackColor = False
        '
        'DtgPend
        '
        Me.DtgPend.AllowUserToAddRows = False
        Me.DtgPend.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgPend.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgPend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgPend.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPend.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgPend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgPend.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgPend.GridColor = System.Drawing.Color.LightGray
        Me.DtgPend.Location = New System.Drawing.Point(4, 48)
        Me.DtgPend.Name = "DtgPend"
        Me.DtgPend.ReadOnly = True
        Me.DtgPend.Size = New System.Drawing.Size(1124, 373)
        Me.DtgPend.TabIndex = 2
        '
        'DtgTreat
        '
        Me.DtgTreat.AllowUserToAddRows = False
        Me.DtgTreat.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue
        Me.DtgTreat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgTreat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgTreat.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgTreat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DtgTreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgTreat.DefaultCellStyle = DataGridViewCellStyle6
        Me.DtgTreat.GridColor = System.Drawing.Color.Maroon
        Me.DtgTreat.Location = New System.Drawing.Point(3, 51)
        Me.DtgTreat.Name = "DtgTreat"
        Me.DtgTreat.ReadOnly = True
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.DtgTreat.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DtgTreat.Size = New System.Drawing.Size(1119, 367)
        Me.DtgTreat.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(111, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = " Records found."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DtToTrt)
        Me.Panel2.Controls.Add(Me.DtfrmTrt)
        Me.Panel2.Controls.Add(Me.txtfindTrt)
        Me.Panel2.Controls.Add(Me.BtnLoadTreat)
        Me.Panel2.Controls.Add(Me.btnsrchtrt)
        Me.Panel2.Location = New System.Drawing.Point(3, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1118, 40)
        Me.Panel2.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(770, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 14)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Enter Hospital No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(232, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "To"
        '
        'DtToTrt
        '
        Me.DtToTrt.Location = New System.Drawing.Point(266, 13)
        Me.DtToTrt.Name = "DtToTrt"
        Me.DtToTrt.Size = New System.Drawing.Size(210, 21)
        Me.DtToTrt.TabIndex = 15
        '
        'DtfrmTrt
        '
        Me.DtfrmTrt.Location = New System.Drawing.Point(12, 13)
        Me.DtfrmTrt.Name = "DtfrmTrt"
        Me.DtfrmTrt.Size = New System.Drawing.Size(211, 21)
        Me.DtfrmTrt.TabIndex = 14
        '
        'txtfindTrt
        '
        Me.txtfindTrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfindTrt.Location = New System.Drawing.Point(869, 13)
        Me.txtfindTrt.Name = "txtfindTrt"
        Me.txtfindTrt.Size = New System.Drawing.Size(153, 21)
        Me.txtfindTrt.TabIndex = 12
        '
        'BtnLoadTreat
        '
        Me.BtnLoadTreat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLoadTreat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLoadTreat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadTreat.ForeColor = System.Drawing.Color.Blue
        Me.BtnLoadTreat.Image = CType(resources.GetObject("BtnLoadTreat.Image"), System.Drawing.Image)
        Me.BtnLoadTreat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLoadTreat.Location = New System.Drawing.Point(485, 12)
        Me.BtnLoadTreat.Name = "BtnLoadTreat"
        Me.BtnLoadTreat.Size = New System.Drawing.Size(89, 23)
        Me.BtnLoadTreat.TabIndex = 11
        Me.BtnLoadTreat.Text = "     Refresh"
        Me.BtnLoadTreat.UseVisualStyleBackColor = False
        '
        'btnsrchtrt
        '
        Me.btnsrchtrt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsrchtrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsrchtrt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsrchtrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsrchtrt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsrchtrt.Location = New System.Drawing.Point(1028, 10)
        Me.btnsrchtrt.Name = "btnsrchtrt"
        Me.btnsrchtrt.Size = New System.Drawing.Size(85, 24)
        Me.btnsrchtrt.TabIndex = 13
        Me.btnsrchtrt.Text = "Search"
        Me.btnsrchtrt.UseVisualStyleBackColor = False
        '
        'TabPaid
        '
        Me.TabPaid.Controls.Add(Me.Label10)
        Me.TabPaid.Controls.Add(Me.lblcount)
        Me.TabPaid.Controls.Add(Me.Panel4)
        Me.TabPaid.Controls.Add(Me.DtgPend)
        Me.TabPaid.Location = New System.Drawing.Point(4, 24)
        Me.TabPaid.Name = "TabPaid"
        Me.TabPaid.Size = New System.Drawing.Size(1138, 450)
        Me.TabPaid.TabIndex = 3
        Me.TabPaid.Text = "PENDING"
        Me.TabPaid.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(58, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Records Found."
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(7, 425)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(16, 16)
        Me.lblcount.TabIndex = 8
        Me.lblcount.Text = "0"
        '
        'tabsurgery
        '
        Me.tabsurgery.Controls.Add(Me.TabPaid)
        Me.tabsurgery.Controls.Add(Me.TabTreated)
        Me.tabsurgery.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabsurgery.Location = New System.Drawing.Point(3, 4)
        Me.tabsurgery.Name = "tabsurgery"
        Me.tabsurgery.SelectedIndex = 0
        Me.tabsurgery.Size = New System.Drawing.Size(1146, 478)
        Me.tabsurgery.TabIndex = 5
        '
        'TabTreated
        '
        Me.TabTreated.Controls.Add(Me.Label2)
        Me.TabTreated.Controls.Add(Me.Lblcounttrt)
        Me.TabTreated.Controls.Add(Me.DtgTreat)
        Me.TabTreated.Controls.Add(Me.Label4)
        Me.TabTreated.Controls.Add(Me.Label5)
        Me.TabTreated.Controls.Add(Me.Panel2)
        Me.TabTreated.ForeColor = System.Drawing.Color.Transparent
        Me.TabTreated.Location = New System.Drawing.Point(4, 24)
        Me.TabTreated.Name = "TabTreated"
        Me.TabTreated.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTreated.Size = New System.Drawing.Size(1138, 450)
        Me.TabTreated.TabIndex = 1
        Me.TabTreated.Text = "  TREATED"
        Me.TabTreated.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(51, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Records Found."
        '
        'Lblcounttrt
        '
        Me.Lblcounttrt.AutoSize = True
        Me.Lblcounttrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcounttrt.Location = New System.Drawing.Point(8, 425)
        Me.Lblcounttrt.Name = "Lblcounttrt"
        Me.Lblcounttrt.Size = New System.Drawing.Size(16, 16)
        Me.Lblcounttrt.TabIndex = 8
        Me.Lblcounttrt.Text = "0"
        '
        'FrmTheartre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1146, 478)
        Me.Controls.Add(Me.tabsurgery)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTheartre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  SURGERY LIST"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DtgPend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgTreat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPaid.ResumeLayout(False)
        Me.TabPaid.PerformLayout()
        Me.tabsurgery.ResumeLayout(False)
        Me.TabTreated.ResumeLayout(False)
        Me.TabTreated.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DttoPend As DateTimePicker
    Friend WithEvents Dtfrmpend As DateTimePicker
    Friend WithEvents txtserchpend As TextBox
    Friend WithEvents BtnRelPend As Button
    Friend WithEvents btnserchpend As Button
    Friend WithEvents DtgPend As DataGridView
    Friend WithEvents DtgTreat As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DtToTrt As DateTimePicker
    Friend WithEvents DtfrmTrt As DateTimePicker
    Friend WithEvents txtfindTrt As TextBox
    Friend WithEvents BtnLoadTreat As Button
    Friend WithEvents btnsrchtrt As Button
    Friend WithEvents TabPaid As TabPage
    Friend WithEvents tabsurgery As TabControl
    Friend WithEvents TabTreated As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lblcounttrt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
