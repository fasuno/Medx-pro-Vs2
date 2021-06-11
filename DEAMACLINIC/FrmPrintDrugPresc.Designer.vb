<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintDrugPresc
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrintDrugPresc))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbltotbill = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblbillby = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblpresby = New System.Windows.Forms.Label()
        Me.lblsex = New System.Windows.Forms.Label()
        Me.lblhospnum = New System.Windows.Forms.Label()
        Me.Lblaccount = New System.Windows.Forms.Label()
        Me.Lblptname = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblph = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcompname = New System.Windows.Forms.Label()
        Me.dgvpres = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvpres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBLID)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.lbltotbill)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblbillby)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblage)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblpresby)
        Me.Panel1.Controls.Add(Me.lblsex)
        Me.Panel1.Controls.Add(Me.lblhospnum)
        Me.Panel1.Controls.Add(Me.Lblaccount)
        Me.Panel1.Controls.Add(Me.Lblptname)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblph)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblcompname)
        Me.Panel1.Controls.Add(Me.dgvpres)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 407)
        Me.Panel1.TabIndex = 0
        '
        'LBLID
        '
        Me.LBLID.AutoSize = True
        Me.LBLID.Location = New System.Drawing.Point(12, 217)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(10, 13)
        Me.LBLID.TabIndex = 77
        Me.LBLID.Text = " "
        Me.LBLID.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(188, 217)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 15)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "N"
        '
        'lbltotbill
        '
        Me.lbltotbill.AutoSize = True
        Me.lbltotbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotbill.Location = New System.Drawing.Point(205, 218)
        Me.lbltotbill.Name = "lbltotbill"
        Me.lbltotbill.Size = New System.Drawing.Size(89, 13)
        Me.lbltotbill.TabIndex = 75
        Me.lbltotbill.Text = "Prescribed By:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(127, 217)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 15)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Total Bill:"
        '
        'lblbillby
        '
        Me.lblbillby.AutoSize = True
        Me.lblbillby.Location = New System.Drawing.Point(110, 192)
        Me.lblbillby.Name = "lblbillby"
        Me.lblbillby.Size = New System.Drawing.Size(75, 13)
        Me.lblbillby.TabIndex = 73
        Me.lblbillby.Text = "Prescribed By:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(49, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 15)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Biiled By:"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Location = New System.Drawing.Point(188, 143)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(75, 13)
        Me.lblage.TabIndex = 71
        Me.lblage.Text = "Prescribed By:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(158, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Age:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-1, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(319, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "===================================================="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(307, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "=================================================="
        '
        'lblpresby
        '
        Me.lblpresby.AutoSize = True
        Me.lblpresby.Location = New System.Drawing.Point(110, 167)
        Me.lblpresby.Name = "lblpresby"
        Me.lblpresby.Size = New System.Drawing.Size(75, 13)
        Me.lblpresby.TabIndex = 69
        Me.lblpresby.Text = "Prescribed By:"
        '
        'lblsex
        '
        Me.lblsex.AutoSize = True
        Me.lblsex.Location = New System.Drawing.Point(111, 144)
        Me.lblsex.Name = "lblsex"
        Me.lblsex.Size = New System.Drawing.Size(43, 13)
        Me.lblsex.TabIndex = 68
        Me.lblsex.Text = "PrescrI:"
        '
        'lblhospnum
        '
        Me.lblhospnum.AutoSize = True
        Me.lblhospnum.Location = New System.Drawing.Point(112, 121)
        Me.lblhospnum.Name = "lblhospnum"
        Me.lblhospnum.Size = New System.Drawing.Size(75, 13)
        Me.lblhospnum.TabIndex = 67
        Me.lblhospnum.Text = "Prescribed By:"
        '
        'Lblaccount
        '
        Me.Lblaccount.AutoSize = True
        Me.Lblaccount.Location = New System.Drawing.Point(113, 99)
        Me.Lblaccount.Name = "Lblaccount"
        Me.Lblaccount.Size = New System.Drawing.Size(75, 13)
        Me.Lblaccount.TabIndex = 66
        Me.Lblaccount.Text = "Prescribed By:"
        '
        'Lblptname
        '
        Me.Lblptname.AutoSize = True
        Me.Lblptname.Location = New System.Drawing.Point(113, 77)
        Me.Lblptname.Name = "Lblptname"
        Me.Lblptname.Size = New System.Drawing.Size(75, 13)
        Me.Lblptname.TabIndex = 65
        Me.Lblptname.Text = "Prescribed By:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Account Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Hospital No.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Sex:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Prescribed By:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Patient Name:"
        '
        'lblph
        '
        Me.lblph.AutoSize = True
        Me.lblph.Location = New System.Drawing.Point(54, 25)
        Me.lblph.Name = "lblph"
        Me.lblph.Size = New System.Drawing.Size(0, 13)
        Me.lblph.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(87, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Drug Prescription Slip"
        '
        'lblcompname
        '
        Me.lblcompname.AutoSize = True
        Me.lblcompname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompname.ForeColor = System.Drawing.Color.Black
        Me.lblcompname.Location = New System.Drawing.Point(59, 4)
        Me.lblcompname.Name = "lblcompname"
        Me.lblcompname.Size = New System.Drawing.Size(0, 15)
        Me.lblcompname.TabIndex = 58
        '
        'dgvpres
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvpres.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvpres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvpres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvpres.BackgroundColor = System.Drawing.Color.White
        Me.dgvpres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvpres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpres.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvpres.ColumnHeadersHeight = 24
        Me.dgvpres.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpres.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvpres.EnableHeadersVisualStyles = False
        Me.dgvpres.GridColor = System.Drawing.Color.Black
        Me.dgvpres.Location = New System.Drawing.Point(3, 250)
        Me.dgvpres.Name = "dgvpres"
        Me.dgvpres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvpres.RowHeadersVisible = False
        Me.dgvpres.RowHeadersWidth = 25
        Me.dgvpres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpres.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvpres.RowTemplate.Height = 18
        Me.dgvpres.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpres.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvpres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvpres.Size = New System.Drawing.Size(310, 113)
        Me.dgvpres.TabIndex = 54
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FrmPrintDrugPresc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(316, 407)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FrmPrintDrugPresc"
        Me.Text = "FrmPrintDrugPresc"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvpres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents lbltotbill As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblbillby As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblage As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblpresby As Label
    Friend WithEvents lblsex As Label
    Friend WithEvents lblhospnum As Label
    Friend WithEvents Lblaccount As Label
    Friend WithEvents Lblptname As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblph As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblcompname As Label
    Friend WithEvents dgvpres As DataGridView
    Friend WithEvents LBLID As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
