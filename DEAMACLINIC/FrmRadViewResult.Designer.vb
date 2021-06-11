<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRadViewResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRadViewResult))
        Me.lblinvest = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dtgradinvest = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtRadresult = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Lblrqstnum = New System.Windows.Forms.Label()
        Me.txtOname = New System.Windows.Forms.TextBox()
        Me.txtRqstby = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.TxtSname = New System.Windows.Forms.TextBox()
        Me.TxtRptdate = New System.Windows.Forms.TextBox()
        Me.txtacct = New System.Windows.Forms.TextBox()
        Me.txtHnum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtrqstdate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txtrqstnum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtreptby = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Dtgradinvest, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblinvest.ForeColor = System.Drawing.Color.DarkRed
        Me.lblinvest.Location = New System.Drawing.Point(306, 10)
        Me.lblinvest.Name = "lblinvest"
        Me.lblinvest.Size = New System.Drawing.Size(10, 15)
        Me.lblinvest.TabIndex = 2
        Me.lblinvest.Text = " "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Dtgradinvest)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(2, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 394)
        Me.Panel1.TabIndex = 4
        '
        'Dtgradinvest
        '
        Me.Dtgradinvest.AllowUserToAddRows = False
        Me.Dtgradinvest.AllowUserToDeleteRows = False
        Me.Dtgradinvest.BackgroundColor = System.Drawing.Color.White
        Me.Dtgradinvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgradinvest.GridColor = System.Drawing.Color.Black
        Me.Dtgradinvest.Location = New System.Drawing.Point(776, 32)
        Me.Dtgradinvest.Name = "Dtgradinvest"
        Me.Dtgradinvest.ReadOnly = True
        Me.Dtgradinvest.Size = New System.Drawing.Size(221, 350)
        Me.Dtgradinvest.TabIndex = 1
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 32)
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
        Me.Lblrqstnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrqstnum.ForeColor = System.Drawing.Color.Blue
        Me.Lblrqstnum.Location = New System.Drawing.Point(20, 59)
        Me.Lblrqstnum.Name = "Lblrqstnum"
        Me.Lblrqstnum.Size = New System.Drawing.Size(76, 15)
        Me.Lblrqstnum.TabIndex = 22
        Me.Lblrqstnum.Text = "Request No.:"
        '
        'txtOname
        '
        Me.txtOname.BackColor = System.Drawing.Color.White
        Me.txtOname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOname.ForeColor = System.Drawing.Color.Black
        Me.txtOname.Location = New System.Drawing.Point(359, 4)
        Me.txtOname.Name = "txtOname"
        Me.txtOname.ReadOnly = True
        Me.txtOname.Size = New System.Drawing.Size(240, 21)
        Me.txtOname.TabIndex = 20
        '
        'txtRqstby
        '
        Me.txtRqstby.BackColor = System.Drawing.Color.White
        Me.txtRqstby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRqstby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRqstby.ForeColor = System.Drawing.Color.Black
        Me.txtRqstby.Location = New System.Drawing.Point(278, 56)
        Me.txtRqstby.Name = "txtRqstby"
        Me.txtRqstby.ReadOnly = True
        Me.txtRqstby.Size = New System.Drawing.Size(263, 21)
        Me.txtRqstby.TabIndex = 19
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(659, 31)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(44, 21)
        Me.txtage.TabIndex = 18
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsex.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.ForeColor = System.Drawing.Color.Black
        Me.txtsex.Location = New System.Drawing.Point(547, 31)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(67, 21)
        Me.txtsex.TabIndex = 17
        '
        'TxtSname
        '
        Me.TxtSname.BackColor = System.Drawing.Color.White
        Me.TxtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSname.ForeColor = System.Drawing.Color.Black
        Me.TxtSname.Location = New System.Drawing.Point(100, 5)
        Me.TxtSname.Name = "TxtSname"
        Me.TxtSname.ReadOnly = True
        Me.TxtSname.Size = New System.Drawing.Size(162, 21)
        Me.TxtSname.TabIndex = 16
        '
        'TxtRptdate
        '
        Me.TxtRptdate.BackColor = System.Drawing.Color.White
        Me.TxtRptdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRptdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRptdate.ForeColor = System.Drawing.Color.Black
        Me.TxtRptdate.Location = New System.Drawing.Point(878, 65)
        Me.TxtRptdate.Name = "TxtRptdate"
        Me.TxtRptdate.ReadOnly = True
        Me.TxtRptdate.Size = New System.Drawing.Size(107, 21)
        Me.TxtRptdate.TabIndex = 14
        '
        'txtacct
        '
        Me.txtacct.BackColor = System.Drawing.Color.White
        Me.txtacct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtacct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct.ForeColor = System.Drawing.Color.Black
        Me.txtacct.Location = New System.Drawing.Point(359, 31)
        Me.txtacct.Name = "txtacct"
        Me.txtacct.ReadOnly = True
        Me.txtacct.Size = New System.Drawing.Size(140, 21)
        Me.txtacct.TabIndex = 13
        '
        'txtHnum
        '
        Me.txtHnum.BackColor = System.Drawing.Color.White
        Me.txtHnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHnum.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHnum.ForeColor = System.Drawing.Color.Black
        Me.txtHnum.Location = New System.Drawing.Point(100, 30)
        Me.txtHnum.Name = "txtHnum"
        Me.txtHnum.ReadOnly = True
        Me.txtHnum.Size = New System.Drawing.Size(162, 21)
        Me.txtHnum.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(510, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Sex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(784, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Reported:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(269, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Other Names:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(35, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Surname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(19, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hospital No.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(183, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Requested By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(620, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Age:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(837, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "ReportedBy"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtrqstdate)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Txtrqstnum)
        Me.Panel4.Controls.Add(Me.Lblrqstnum)
        Me.Panel4.Controls.Add(Me.txtOname)
        Me.Panel4.Controls.Add(Me.txtRqstby)
        Me.Panel4.Controls.Add(Me.txtage)
        Me.Panel4.Controls.Add(Me.txtsex)
        Me.Panel4.Controls.Add(Me.TxtSname)
        Me.Panel4.Controls.Add(Me.txtacct)
        Me.Panel4.Controls.Add(Me.txtHnum)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(10, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(758, 88)
        Me.Panel4.TabIndex = 16
        '
        'txtrqstdate
        '
        Me.txtrqstdate.BackColor = System.Drawing.Color.White
        Me.txtrqstdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrqstdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrqstdate.ForeColor = System.Drawing.Color.Black
        Me.txtrqstdate.Location = New System.Drawing.Point(642, 57)
        Me.txtrqstdate.Name = "txtrqstdate"
        Me.txtrqstdate.ReadOnly = True
        Me.txtrqstdate.Size = New System.Drawing.Size(107, 21)
        Me.txtrqstdate.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(547, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Date Requested:"
        '
        'Txtrqstnum
        '
        Me.Txtrqstnum.BackColor = System.Drawing.Color.White
        Me.Txtrqstnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtrqstnum.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrqstnum.ForeColor = System.Drawing.Color.Black
        Me.Txtrqstnum.Location = New System.Drawing.Point(100, 56)
        Me.Txtrqstnum.Name = "Txtrqstnum"
        Me.Txtrqstnum.ReadOnly = True
        Me.Txtrqstnum.Size = New System.Drawing.Size(77, 21)
        Me.Txtrqstnum.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(272, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Account type:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Txtreptby)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TxtRptdate)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(0, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1011, 100)
        Me.Panel3.TabIndex = 3
        '
        'Txtreptby
        '
        Me.Txtreptby.BackColor = System.Drawing.Color.White
        Me.Txtreptby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtreptby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtreptby.ForeColor = System.Drawing.Color.Black
        Me.Txtreptby.Location = New System.Drawing.Point(775, 34)
        Me.Txtreptby.Name = "Txtreptby"
        Me.Txtreptby.ReadOnly = True
        Me.Txtreptby.Size = New System.Drawing.Size(221, 21)
        Me.Txtreptby.TabIndex = 24
        '
        'FrmRadViewResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRadViewResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   PATIENT RADIOLOGY INVESTIGATION REPORT"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Dtgradinvest, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblinvest As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dtgradinvest As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Lblrqstnum As Label
    Friend WithEvents txtOname As TextBox
    Friend WithEvents txtRqstby As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents TxtRptdate As TextBox
    Friend WithEvents txtacct As TextBox
    Friend WithEvents txtHnum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txtrqstnum As TextBox
    Friend WithEvents Txtreptby As TextBox
    Friend WithEvents txtrqstdate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtRadresult As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNote As TextBox
End Class
