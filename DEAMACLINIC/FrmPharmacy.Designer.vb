<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPharmacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPharmacy))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkAllRqst = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RqstTo = New System.Windows.Forms.DateTimePicker()
        Me.RqstFrm = New System.Windows.Forms.DateTimePicker()
        Me.txtFindRqst = New System.Windows.Forms.TextBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnfindRqst = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPend = New System.Windows.Forms.TabPage()
        Me.DtgPendDrugrqst = New System.Windows.Forms.DataGridView()
        Me.tabpharm = New System.Windows.Forms.TabControl()
        Me.TabBilled = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkAllbill = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtbillto = New System.Windows.Forms.DateTimePicker()
        Me.dtbillfrom = New System.Windows.Forms.DateTimePicker()
        Me.txtfindbill = New System.Windows.Forms.TextBox()
        Me.Btnrefbill = New System.Windows.Forms.Button()
        Me.btnfindbill = New System.Windows.Forms.Button()
        Me.Dtgbiiled = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabPend.SuspendLayout()
        CType(Me.DtgPendDrugrqst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpharm.SuspendLayout()
        Me.TabBilled.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dtgbiiled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAllRqst
        '
        Me.chkAllRqst.AutoSize = True
        Me.chkAllRqst.ForeColor = System.Drawing.Color.Black
        Me.chkAllRqst.Location = New System.Drawing.Point(793, 14)
        Me.chkAllRqst.Name = "chkAllRqst"
        Me.chkAllRqst.Size = New System.Drawing.Size(70, 19)
        Me.chkAllRqst.TabIndex = 17
        Me.chkAllRqst.Text = "View All"
        Me.chkAllRqst.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(236, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "To"
        '
        'RqstTo
        '
        Me.RqstTo.Location = New System.Drawing.Point(266, 13)
        Me.RqstTo.Name = "RqstTo"
        Me.RqstTo.Size = New System.Drawing.Size(210, 21)
        Me.RqstTo.TabIndex = 15
        '
        'RqstFrm
        '
        Me.RqstFrm.Location = New System.Drawing.Point(14, 13)
        Me.RqstFrm.Name = "RqstFrm"
        Me.RqstFrm.Size = New System.Drawing.Size(211, 21)
        Me.RqstFrm.TabIndex = 14
        '
        'txtFindRqst
        '
        Me.txtFindRqst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindRqst.Location = New System.Drawing.Point(869, 12)
        Me.txtFindRqst.Name = "txtFindRqst"
        Me.txtFindRqst.Size = New System.Drawing.Size(153, 21)
        Me.txtFindRqst.TabIndex = 12
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(485, 11)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(91, 24)
        Me.btnrefresh.TabIndex = 11
        Me.btnrefresh.Text = "     Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btnfindRqst
        '
        Me.btnfindRqst.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindRqst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindRqst.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindRqst.ForeColor = System.Drawing.Color.Green
        Me.btnfindRqst.Image = CType(resources.GetObject("btnfindRqst.Image"), System.Drawing.Image)
        Me.btnfindRqst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfindRqst.Location = New System.Drawing.Point(1028, 8)
        Me.btnfindRqst.Name = "btnfindRqst"
        Me.btnfindRqst.Size = New System.Drawing.Size(89, 24)
        Me.btnfindRqst.TabIndex = 13
        Me.btnfindRqst.Text = "      Search"
        Me.btnfindRqst.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkAllRqst)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.RqstTo)
        Me.Panel1.Controls.Add(Me.RqstFrm)
        Me.Panel1.Controls.Add(Me.txtFindRqst)
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.btnfindRqst)
        Me.Panel1.Location = New System.Drawing.Point(1, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1124, 40)
        Me.Panel1.TabIndex = 0
        '
        'TabPend
        '
        Me.TabPend.Controls.Add(Me.DtgPendDrugrqst)
        Me.TabPend.Controls.Add(Me.Panel1)
        Me.TabPend.ForeColor = System.Drawing.Color.Black
        Me.TabPend.Location = New System.Drawing.Point(4, 24)
        Me.TabPend.Name = "TabPend"
        Me.TabPend.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPend.Size = New System.Drawing.Size(1128, 490)
        Me.TabPend.TabIndex = 0
        Me.TabPend.Text = "  PENDING"
        Me.TabPend.UseVisualStyleBackColor = True
        '
        'DtgPendDrugrqst
        '
        Me.DtgPendDrugrqst.AllowUserToAddRows = False
        Me.DtgPendDrugrqst.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgPendDrugrqst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgPendDrugrqst.BackgroundColor = System.Drawing.Color.White
        Me.DtgPendDrugrqst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgPendDrugrqst.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtgPendDrugrqst.Location = New System.Drawing.Point(0, 51)
        Me.DtgPendDrugrqst.Name = "DtgPendDrugrqst"
        Me.DtgPendDrugrqst.ReadOnly = True
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DtgPendDrugrqst.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DtgPendDrugrqst.Size = New System.Drawing.Size(1125, 433)
        Me.DtgPendDrugrqst.TabIndex = 1
        '
        'tabpharm
        '
        Me.tabpharm.Controls.Add(Me.TabPend)
        Me.tabpharm.Controls.Add(Me.TabBilled)
        Me.tabpharm.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpharm.Location = New System.Drawing.Point(3, 9)
        Me.tabpharm.Name = "tabpharm"
        Me.tabpharm.SelectedIndex = 0
        Me.tabpharm.Size = New System.Drawing.Size(1136, 518)
        Me.tabpharm.TabIndex = 1
        '
        'TabBilled
        '
        Me.TabBilled.Controls.Add(Me.Panel3)
        Me.TabBilled.Controls.Add(Me.Dtgbiiled)
        Me.TabBilled.Location = New System.Drawing.Point(4, 24)
        Me.TabBilled.Name = "TabBilled"
        Me.TabBilled.Size = New System.Drawing.Size(1128, 490)
        Me.TabBilled.TabIndex = 2
        Me.TabBilled.Text = "DISPENSED"
        Me.TabBilled.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.ChkAllbill)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.dtbillto)
        Me.Panel3.Controls.Add(Me.dtbillfrom)
        Me.Panel3.Controls.Add(Me.txtfindbill)
        Me.Panel3.Controls.Add(Me.Btnrefbill)
        Me.Panel3.Controls.Add(Me.btnfindbill)
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1128, 40)
        Me.Panel3.TabIndex = 1
        '
        'ChkAllbill
        '
        Me.ChkAllbill.AutoSize = True
        Me.ChkAllbill.ForeColor = System.Drawing.Color.White
        Me.ChkAllbill.Location = New System.Drawing.Point(811, 14)
        Me.ChkAllbill.Name = "ChkAllbill"
        Me.ChkAllbill.Size = New System.Drawing.Size(70, 19)
        Me.ChkAllbill.TabIndex = 17
        Me.ChkAllbill.Text = "View All"
        Me.ChkAllbill.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(232, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "To"
        '
        'dtbillto
        '
        Me.dtbillto.Location = New System.Drawing.Point(262, 13)
        Me.dtbillto.Name = "dtbillto"
        Me.dtbillto.Size = New System.Drawing.Size(210, 21)
        Me.dtbillto.TabIndex = 15
        '
        'dtbillfrom
        '
        Me.dtbillfrom.Location = New System.Drawing.Point(10, 13)
        Me.dtbillfrom.Name = "dtbillfrom"
        Me.dtbillfrom.Size = New System.Drawing.Size(211, 21)
        Me.dtbillfrom.TabIndex = 14
        '
        'txtfindbill
        '
        Me.txtfindbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfindbill.Location = New System.Drawing.Point(887, 12)
        Me.txtfindbill.Name = "txtfindbill"
        Me.txtfindbill.Size = New System.Drawing.Size(153, 21)
        Me.txtfindbill.TabIndex = 12
        '
        'Btnrefbill
        '
        Me.Btnrefbill.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnrefbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnrefbill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnrefbill.ForeColor = System.Drawing.Color.Blue
        Me.Btnrefbill.Location = New System.Drawing.Point(481, 9)
        Me.Btnrefbill.Name = "Btnrefbill"
        Me.Btnrefbill.Size = New System.Drawing.Size(88, 26)
        Me.Btnrefbill.TabIndex = 11
        Me.Btnrefbill.Text = "Refresh"
        Me.Btnrefbill.UseVisualStyleBackColor = False
        '
        'btnfindbill
        '
        Me.btnfindbill.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindbill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindbill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnfindbill.Location = New System.Drawing.Point(1041, 9)
        Me.btnfindbill.Name = "btnfindbill"
        Me.btnfindbill.Size = New System.Drawing.Size(79, 25)
        Me.btnfindbill.TabIndex = 13
        Me.btnfindbill.Text = "Search"
        Me.btnfindbill.UseVisualStyleBackColor = False
        '
        'Dtgbiiled
        '
        Me.Dtgbiiled.AllowUserToAddRows = False
        Me.Dtgbiiled.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Dtgbiiled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dtgbiiled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtgbiiled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgbiiled.Location = New System.Drawing.Point(5, 49)
        Me.Dtgbiiled.Name = "Dtgbiiled"
        Me.Dtgbiiled.ReadOnly = True
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon
        Me.Dtgbiiled.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dtgbiiled.Size = New System.Drawing.Size(1120, 438)
        Me.Dtgbiiled.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(95, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = " Records found."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "0"
        '
        'FrmPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1137, 559)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tabpharm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPharmacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   PHARMACY  DISPENSARY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPend.ResumeLayout(False)
        CType(Me.DtgPendDrugrqst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpharm.ResumeLayout(False)
        Me.TabBilled.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Dtgbiiled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAllRqst As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RqstTo As DateTimePicker
    Friend WithEvents RqstFrm As DateTimePicker
    Friend WithEvents txtFindRqst As TextBox
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnfindRqst As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPend As TabPage
    Friend WithEvents tabpharm As TabControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtgPendDrugrqst As DataGridView
    Friend WithEvents TabBilled As TabPage
    Friend WithEvents Dtgbiiled As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChkAllbill As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtbillto As DateTimePicker
    Friend WithEvents dtbillfrom As DateTimePicker
    Friend WithEvents txtfindbill As TextBox
    Friend WithEvents Btnrefbill As Button
    Friend WithEvents btnfindbill As Button
End Class
