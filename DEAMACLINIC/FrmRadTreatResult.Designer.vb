<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRadTreatResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRadTreatResult))
        Me.lblinvest = New System.Windows.Forms.Label()
        Me.Dtgradinvest = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtRadresult = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Lblrqstnum = New System.Windows.Forms.Label()
        Me.txtRqstby = New System.Windows.Forms.TextBox()
        Me.TxtRqstdate = New System.Windows.Forms.TextBox()
        Me.Txtrptby = New System.Windows.Forms.TextBox()
        Me.TxtDaterpt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.Dtgradinvest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblinvest
        '
        Me.lblinvest.AutoSize = True
        Me.lblinvest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvest.ForeColor = System.Drawing.Color.Blue
        Me.lblinvest.Location = New System.Drawing.Point(306, 11)
        Me.lblinvest.Name = "lblinvest"
        Me.lblinvest.Size = New System.Drawing.Size(77, 15)
        Me.lblinvest.TabIndex = 2
        Me.lblinvest.Text = "investigation"
        '
        'Dtgradinvest
        '
        Me.Dtgradinvest.AllowUserToAddRows = False
        Me.Dtgradinvest.AllowUserToDeleteRows = False
        Me.Dtgradinvest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtgradinvest.BackgroundColor = System.Drawing.Color.White
        Me.Dtgradinvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgradinvest.Location = New System.Drawing.Point(776, 31)
        Me.Dtgradinvest.Name = "Dtgradinvest"
        Me.Dtgradinvest.ReadOnly = True
        Me.Dtgradinvest.Size = New System.Drawing.Size(221, 357)
        Me.Dtgradinvest.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Dtgradinvest)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(6, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 394)
        Me.Panel1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 382)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.lblinvest)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(753, 354)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RESULT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 33)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(741, 317)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtRadresult)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IMPRESSION"
        '
        'TxtRadresult
        '
        Me.TxtRadresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRadresult.Location = New System.Drawing.Point(0, 20)
        Me.TxtRadresult.Multiline = True
        Me.TxtRadresult.Name = "TxtRadresult"
        Me.TxtRadresult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtRadresult.Size = New System.Drawing.Size(698, 182)
        Me.TxtRadresult.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtNote)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(3, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(704, 208)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NOTE"
        '
        'TxtNote
        '
        Me.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNote.Location = New System.Drawing.Point(0, 20)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtNote.Size = New System.Drawing.Size(698, 182)
        Me.TxtNote.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(753, 354)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "IMAGES"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Lblrqstnum
        '
        Me.Lblrqstnum.AutoSize = True
        Me.Lblrqstnum.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrqstnum.ForeColor = System.Drawing.Color.Blue
        Me.Lblrqstnum.Location = New System.Drawing.Point(847, 22)
        Me.Lblrqstnum.Name = "Lblrqstnum"
        Me.Lblrqstnum.Size = New System.Drawing.Size(95, 17)
        Me.Lblrqstnum.TabIndex = 22
        Me.Lblrqstnum.Text = "Request num"
        Me.Lblrqstnum.Visible = False
        '
        'txtRqstby
        '
        Me.txtRqstby.BackColor = System.Drawing.Color.White
        Me.txtRqstby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRqstby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRqstby.ForeColor = System.Drawing.Color.Black
        Me.txtRqstby.Location = New System.Drawing.Point(308, 11)
        Me.txtRqstby.Name = "txtRqstby"
        Me.txtRqstby.ReadOnly = True
        Me.txtRqstby.Size = New System.Drawing.Size(263, 21)
        Me.txtRqstby.TabIndex = 19
        '
        'TxtRqstdate
        '
        Me.TxtRqstdate.BackColor = System.Drawing.Color.White
        Me.TxtRqstdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRqstdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRqstdate.ForeColor = System.Drawing.Color.Black
        Me.TxtRqstdate.Location = New System.Drawing.Point(100, 11)
        Me.TxtRqstdate.Name = "TxtRqstdate"
        Me.TxtRqstdate.ReadOnly = True
        Me.TxtRqstdate.Size = New System.Drawing.Size(107, 21)
        Me.TxtRqstdate.TabIndex = 14
        '
        'Txtrptby
        '
        Me.Txtrptby.BackColor = System.Drawing.Color.White
        Me.Txtrptby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtrptby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrptby.ForeColor = System.Drawing.Color.Black
        Me.Txtrptby.Location = New System.Drawing.Point(308, 38)
        Me.Txtrptby.Name = "Txtrptby"
        Me.Txtrptby.ReadOnly = True
        Me.Txtrptby.Size = New System.Drawing.Size(263, 21)
        Me.Txtrptby.TabIndex = 13
        '
        'TxtDaterpt
        '
        Me.TxtDaterpt.BackColor = System.Drawing.Color.White
        Me.TxtDaterpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDaterpt.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDaterpt.ForeColor = System.Drawing.Color.Black
        Me.TxtDaterpt.Location = New System.Drawing.Point(100, 38)
        Me.TxtDaterpt.Name = "TxtDaterpt"
        Me.TxtDaterpt.ReadOnly = True
        Me.TxtDaterpt.Size = New System.Drawing.Size(62, 21)
        Me.TxtDaterpt.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Requested:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(10, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date Reported:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(213, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Requested By:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(220, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Reported By:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtDaterpt)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtRqstby)
        Me.Panel4.Controls.Add(Me.Txtrptby)
        Me.Panel4.Controls.Add(Me.TxtRqstdate)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(1, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(593, 70)
        Me.Panel4.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(186, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(598, 83)
        Me.Panel3.TabIndex = 3
        '
        'FrmRadTreatResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 490)
        Me.Controls.Add(Me.Lblrqstnum)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRadTreatResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   RADIOLOGY INVESTIGATION REPORT"
        CType(Me.Dtgradinvest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblinvest As Label
    Friend WithEvents Dtgradinvest As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Lblrqstnum As Label
    Friend WithEvents txtRqstby As TextBox
    Friend WithEvents TxtRqstdate As TextBox
    Friend WithEvents Txtrptby As TextBox
    Friend WithEvents TxtDaterpt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtRadresult As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNote As TextBox
End Class
