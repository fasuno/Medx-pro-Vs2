<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNursing
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNursing))
        Me.tabnursing = New System.Windows.Forms.TabControl()
        Me.tpgpending = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgpendingvitals = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAllPendVitals = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PenVitTo = New System.Windows.Forms.DateTimePicker()
        Me.PenVitFrm = New System.Windows.Forms.DateTimePicker()
        Me.txtpendVit = New System.Windows.Forms.TextBox()
        Me.btnrefvitals = New System.Windows.Forms.Button()
        Me.btnfindpendvit = New System.Windows.Forms.Button()
        Me.cbopenvitals = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtgtreatedvitals = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkviewalltreatedvitals = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreatVitDtto = New System.Windows.Forms.DateTimePicker()
        Me.TreatVitDtFrm = New System.Windows.Forms.DateTimePicker()
        Me.txttrtvitals = New System.Windows.Forms.TextBox()
        Me.btnreftrtvital = New System.Windows.Forms.Button()
        Me.btnFindtrtvitals = New System.Windows.Forms.Button()
        Me.cbotreatedvit = New System.Windows.Forms.ComboBox()
        Me.tabnursing.SuspendLayout()
        Me.tpgpending.SuspendLayout()
        CType(Me.dtgpendingvitals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgtreatedvitals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabnursing
        '
        Me.tabnursing.Controls.Add(Me.tpgpending)
        Me.tabnursing.Controls.Add(Me.TabPage2)
        Me.tabnursing.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabnursing.Location = New System.Drawing.Point(0, 8)
        Me.tabnursing.Name = "tabnursing"
        Me.tabnursing.SelectedIndex = 0
        Me.tabnursing.Size = New System.Drawing.Size(1136, 443)
        Me.tabnursing.TabIndex = 0
        '
        'tpgpending
        '
        Me.tpgpending.Controls.Add(Me.Label3)
        Me.tpgpending.Controls.Add(Me.Label2)
        Me.tpgpending.Controls.Add(Me.dtgpendingvitals)
        Me.tpgpending.Controls.Add(Me.Panel1)
        Me.tpgpending.ForeColor = System.Drawing.Color.Black
        Me.tpgpending.Location = New System.Drawing.Point(4, 24)
        Me.tpgpending.Name = "tpgpending"
        Me.tpgpending.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgpending.Size = New System.Drawing.Size(1128, 415)
        Me.tpgpending.TabIndex = 0
        Me.tpgpending.Text = "  PENDING"
        Me.tpgpending.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(103, 495)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = " Records found."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 495)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "0"
        '
        'dtgpendingvitals
        '
        Me.dtgpendingvitals.AllowUserToAddRows = False
        Me.dtgpendingvitals.AllowUserToDeleteRows = False
        Me.dtgpendingvitals.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        Me.dtgpendingvitals.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgpendingvitals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgpendingvitals.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgpendingvitals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgpendingvitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgpendingvitals.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgpendingvitals.GridColor = System.Drawing.Color.Black
        Me.dtgpendingvitals.Location = New System.Drawing.Point(3, 51)
        Me.dtgpendingvitals.Name = "dtgpendingvitals"
        Me.dtgpendingvitals.ReadOnly = True
        Me.dtgpendingvitals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtgpendingvitals.Size = New System.Drawing.Size(1121, 327)
        Me.dtgpendingvitals.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkAllPendVitals)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PenVitTo)
        Me.Panel1.Controls.Add(Me.PenVitFrm)
        Me.Panel1.Controls.Add(Me.txtpendVit)
        Me.Panel1.Controls.Add(Me.btnrefvitals)
        Me.Panel1.Controls.Add(Me.btnfindpendvit)
        Me.Panel1.Controls.Add(Me.cbopenvitals)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 40)
        Me.Panel1.TabIndex = 0
        '
        'chkAllPendVitals
        '
        Me.chkAllPendVitals.AutoSize = True
        Me.chkAllPendVitals.ForeColor = System.Drawing.Color.Black
        Me.chkAllPendVitals.Location = New System.Drawing.Point(799, 15)
        Me.chkAllPendVitals.Name = "chkAllPendVitals"
        Me.chkAllPendVitals.Size = New System.Drawing.Size(70, 19)
        Me.chkAllPendVitals.TabIndex = 17
        Me.chkAllPendVitals.Text = "View All"
        Me.chkAllPendVitals.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(387, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "To"
        '
        'PenVitTo
        '
        Me.PenVitTo.Location = New System.Drawing.Point(417, 12)
        Me.PenVitTo.Name = "PenVitTo"
        Me.PenVitTo.Size = New System.Drawing.Size(210, 21)
        Me.PenVitTo.TabIndex = 15
        '
        'PenVitFrm
        '
        Me.PenVitFrm.Location = New System.Drawing.Point(165, 12)
        Me.PenVitFrm.Name = "PenVitFrm"
        Me.PenVitFrm.Size = New System.Drawing.Size(211, 21)
        Me.PenVitFrm.TabIndex = 14
        '
        'txtpendVit
        '
        Me.txtpendVit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpendVit.Location = New System.Drawing.Point(875, 13)
        Me.txtpendVit.Name = "txtpendVit"
        Me.txtpendVit.Size = New System.Drawing.Size(153, 21)
        Me.txtpendVit.TabIndex = 12
        '
        'btnrefvitals
        '
        Me.btnrefvitals.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrefvitals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefvitals.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefvitals.ForeColor = System.Drawing.Color.Blue
        Me.btnrefvitals.Image = CType(resources.GetObject("btnrefvitals.Image"), System.Drawing.Image)
        Me.btnrefvitals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefvitals.Location = New System.Drawing.Point(636, 3)
        Me.btnrefvitals.Name = "btnrefvitals"
        Me.btnrefvitals.Size = New System.Drawing.Size(94, 31)
        Me.btnrefvitals.TabIndex = 11
        Me.btnrefvitals.Text = "     Refresh"
        Me.btnrefvitals.UseVisualStyleBackColor = False
        '
        'btnfindpendvit
        '
        Me.btnfindpendvit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindpendvit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindpendvit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindpendvit.ForeColor = System.Drawing.Color.Green
        Me.btnfindpendvit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfindpendvit.Location = New System.Drawing.Point(1033, 11)
        Me.btnfindpendvit.Name = "btnfindpendvit"
        Me.btnfindpendvit.Size = New System.Drawing.Size(85, 24)
        Me.btnfindpendvit.TabIndex = 13
        Me.btnfindpendvit.Text = "Search"
        Me.btnfindpendvit.UseVisualStyleBackColor = False
        '
        'cbopenvitals
        '
        Me.cbopenvitals.ForeColor = System.Drawing.Color.Red
        Me.cbopenvitals.FormattingEnabled = True
        Me.cbopenvitals.Items.AddRange(New Object() {"SELECT CLINIC", "GOPD", "MOPD", "POPD", "SOPD", "ANC", "GYNAE", "A&E", "EUROLOGY", "DEMATOLOGY", "ART"})
        Me.cbopenvitals.Location = New System.Drawing.Point(6, 11)
        Me.cbopenvitals.Name = "cbopenvitals"
        Me.cbopenvitals.Size = New System.Drawing.Size(151, 23)
        Me.cbopenvitals.TabIndex = 0
        Me.cbopenvitals.Text = "<--SELECT CLINIC-->"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgtreatedvitals)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1128, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  TREATED"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtgtreatedvitals
        '
        Me.dtgtreatedvitals.AllowUserToAddRows = False
        Me.dtgtreatedvitals.AllowUserToDeleteRows = False
        Me.dtgtreatedvitals.AllowUserToResizeRows = False
        Me.dtgtreatedvitals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgtreatedvitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgtreatedvitals.Location = New System.Drawing.Point(6, 52)
        Me.dtgtreatedvitals.Name = "dtgtreatedvitals"
        Me.dtgtreatedvitals.ReadOnly = True
        Me.dtgtreatedvitals.Size = New System.Drawing.Size(1121, 327)
        Me.dtgtreatedvitals.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(57, 386)
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
        Me.Label5.Location = New System.Drawing.Point(9, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkviewalltreatedvitals)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TreatVitDtto)
        Me.Panel2.Controls.Add(Me.TreatVitDtFrm)
        Me.Panel2.Controls.Add(Me.txttrtvitals)
        Me.Panel2.Controls.Add(Me.btnreftrtvital)
        Me.Panel2.Controls.Add(Me.btnFindtrtvitals)
        Me.Panel2.Controls.Add(Me.cbotreatedvit)
        Me.Panel2.Location = New System.Drawing.Point(4, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1118, 40)
        Me.Panel2.TabIndex = 2
        '
        'chkviewalltreatedvitals
        '
        Me.chkviewalltreatedvitals.AutoSize = True
        Me.chkviewalltreatedvitals.ForeColor = System.Drawing.Color.Black
        Me.chkviewalltreatedvitals.Location = New System.Drawing.Point(794, 16)
        Me.chkviewalltreatedvitals.Name = "chkviewalltreatedvitals"
        Me.chkviewalltreatedvitals.Size = New System.Drawing.Size(70, 19)
        Me.chkviewalltreatedvitals.TabIndex = 18
        Me.chkviewalltreatedvitals.Text = "View All"
        Me.chkviewalltreatedvitals.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(378, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "To"
        '
        'TreatVitDtto
        '
        Me.TreatVitDtto.Location = New System.Drawing.Point(402, 12)
        Me.TreatVitDtto.Name = "TreatVitDtto"
        Me.TreatVitDtto.Size = New System.Drawing.Size(210, 21)
        Me.TreatVitDtto.TabIndex = 15
        '
        'TreatVitDtFrm
        '
        Me.TreatVitDtFrm.Location = New System.Drawing.Point(163, 12)
        Me.TreatVitDtFrm.Name = "TreatVitDtFrm"
        Me.TreatVitDtFrm.Size = New System.Drawing.Size(211, 21)
        Me.TreatVitDtFrm.TabIndex = 14
        '
        'txttrtvitals
        '
        Me.txttrtvitals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttrtvitals.Location = New System.Drawing.Point(870, 14)
        Me.txttrtvitals.Name = "txttrtvitals"
        Me.txttrtvitals.Size = New System.Drawing.Size(153, 21)
        Me.txttrtvitals.TabIndex = 12
        '
        'btnreftrtvital
        '
        Me.btnreftrtvital.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreftrtvital.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreftrtvital.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreftrtvital.ForeColor = System.Drawing.Color.Blue
        Me.btnreftrtvital.Image = CType(resources.GetObject("btnreftrtvital.Image"), System.Drawing.Image)
        Me.btnreftrtvital.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreftrtvital.Location = New System.Drawing.Point(617, 3)
        Me.btnreftrtvital.Name = "btnreftrtvital"
        Me.btnreftrtvital.Size = New System.Drawing.Size(92, 31)
        Me.btnreftrtvital.TabIndex = 11
        Me.btnreftrtvital.Text = "    Refresh"
        Me.btnreftrtvital.UseVisualStyleBackColor = False
        '
        'btnFindtrtvitals
        '
        Me.btnFindtrtvitals.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFindtrtvitals.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindtrtvitals.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindtrtvitals.ForeColor = System.Drawing.Color.Green
        Me.btnFindtrtvitals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFindtrtvitals.Location = New System.Drawing.Point(1025, 11)
        Me.btnFindtrtvitals.Name = "btnFindtrtvitals"
        Me.btnFindtrtvitals.Size = New System.Drawing.Size(80, 24)
        Me.btnFindtrtvitals.TabIndex = 13
        Me.btnFindtrtvitals.Text = "Search"
        Me.btnFindtrtvitals.UseVisualStyleBackColor = False
        '
        'cbotreatedvit
        '
        Me.cbotreatedvit.FormattingEnabled = True
        Me.cbotreatedvit.Items.AddRange(New Object() {"SELECT CLINIC", "GOPD", "MOPD", "POPD", "SOPD", "ANC", "GYNAE", "A&E", "EUROLOGY", "DEMATOLOGY", "ART"})
        Me.cbotreatedvit.Location = New System.Drawing.Point(6, 11)
        Me.cbotreatedvit.Name = "cbotreatedvit"
        Me.cbotreatedvit.Size = New System.Drawing.Size(151, 23)
        Me.cbotreatedvit.TabIndex = 0
        Me.cbotreatedvit.Text = "<--SELECT CLINIC-->"
        '
        'frmNursing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1136, 452)
        Me.Controls.Add(Me.tabnursing)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNursing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "       VITAL SIGNS TABLE"
        Me.tabnursing.ResumeLayout(False)
        Me.tpgpending.ResumeLayout(False)
        Me.tpgpending.PerformLayout()
        CType(Me.dtgpendingvitals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgtreatedvitals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabnursing As TabControl
    Friend WithEvents tpgpending As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbopenvitals As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PenVitTo As DateTimePicker
    Friend WithEvents PenVitFrm As DateTimePicker
    Friend WithEvents txtpendVit As TextBox
    Friend WithEvents btnrefvitals As Button
    Friend WithEvents btnfindpendvit As Button
    Friend WithEvents dtgpendingvitals As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TreatVitDtto As DateTimePicker
    Friend WithEvents TreatVitDtFrm As DateTimePicker
    Friend WithEvents txttrtvitals As TextBox
    Friend WithEvents btnreftrtvital As Button
    Friend WithEvents btnFindtrtvitals As Button
    Friend WithEvents cbotreatedvit As ComboBox
    Friend WithEvents chkAllPendVitals As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkviewalltreatedvitals As CheckBox
    Friend WithEvents dtgtreatedvitals As DataGridView
End Class
