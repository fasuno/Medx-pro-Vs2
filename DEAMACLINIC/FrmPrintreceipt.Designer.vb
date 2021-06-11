<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrintreceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrintreceipt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Lblcashier = New System.Windows.Forms.Label()
        Me.Lblamntword = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblLile = New System.Windows.Forms.Label()
        Me.lbltotalamnt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblservice = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblhospnum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblrcptnum = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Lblaccount = New System.Windows.Forms.Label()
        Me.Lblptname = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblph = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcompname = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Lblcashier)
        Me.Panel1.Controls.Add(Me.Lblamntword)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblLile)
        Me.Panel1.Controls.Add(Me.lbltotalamnt)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblservice)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.lblhospnum)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblrcptnum)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.Lblaccount)
        Me.Panel1.Controls.Add(Me.Lblptname)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblph)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblcompname)
        Me.Panel1.Location = New System.Drawing.Point(3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 398)
        Me.Panel1.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(307, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "=================================================="
        '
        'Lblcashier
        '
        Me.Lblcashier.AutoSize = True
        Me.Lblcashier.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcashier.ForeColor = System.Drawing.Color.Black
        Me.Lblcashier.Location = New System.Drawing.Point(98, 336)
        Me.Lblcashier.Name = "Lblcashier"
        Me.Lblcashier.Size = New System.Drawing.Size(99, 15)
        Me.Lblcashier.TabIndex = 33
        Me.Lblcashier.Text = "Cash received by:"
        '
        'Lblamntword
        '
        Me.Lblamntword.AutoSize = True
        Me.Lblamntword.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblamntword.ForeColor = System.Drawing.Color.Black
        Me.Lblamntword.Location = New System.Drawing.Point(12, 264)
        Me.Lblamntword.Name = "Lblamntword"
        Me.Lblamntword.Size = New System.Drawing.Size(98, 15)
        Me.Lblamntword.TabIndex = 32
        Me.Lblamntword.Text = "amount in words:"
        Me.Lblamntword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 245)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(307, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "=================================================="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(101, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Cash received by:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(91, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 14)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Thanks for choosen us."
        '
        'lblLile
        '
        Me.lblLile.AutoSize = True
        Me.lblLile.ForeColor = System.Drawing.Color.Black
        Me.lblLile.Location = New System.Drawing.Point(7, 289)
        Me.lblLile.Name = "lblLile"
        Me.lblLile.Size = New System.Drawing.Size(307, 13)
        Me.lblLile.TabIndex = 28
        Me.lblLile.Text = "=================================================="
        '
        'lbltotalamnt
        '
        Me.lbltotalamnt.AutoSize = True
        Me.lbltotalamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamnt.ForeColor = System.Drawing.Color.Black
        Me.lbltotalamnt.Location = New System.Drawing.Point(186, 221)
        Me.lbltotalamnt.Name = "lbltotalamnt"
        Me.lbltotalamnt.Size = New System.Drawing.Size(35, 15)
        Me.lbltotalamnt.TabIndex = 25
        Me.lbltotalamnt.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(101, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Amount Paid:"
        '
        'lblservice
        '
        Me.lblservice.AutoSize = True
        Me.lblservice.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblservice.ForeColor = System.Drawing.Color.Black
        Me.lblservice.Location = New System.Drawing.Point(101, 186)
        Me.lblservice.Name = "lblservice"
        Me.lblservice.Size = New System.Drawing.Size(83, 15)
        Me.lblservice.TabIndex = 27
        Me.lblservice.Text = "Prescribed By:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(45, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 15)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Service:"
        '
        'lblhospnum
        '
        Me.lblhospnum.AutoSize = True
        Me.lblhospnum.ForeColor = System.Drawing.Color.Black
        Me.lblhospnum.Location = New System.Drawing.Point(102, 96)
        Me.lblhospnum.Name = "lblhospnum"
        Me.lblhospnum.Size = New System.Drawing.Size(75, 13)
        Me.lblhospnum.TabIndex = 25
        Me.lblhospnum.Text = "Prescribed By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(28, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Folder No.:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(5, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(307, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "=================================================="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(307, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "=================================================="
        '
        'lblrcptnum
        '
        Me.lblrcptnum.AutoSize = True
        Me.lblrcptnum.ForeColor = System.Drawing.Color.Black
        Me.lblrcptnum.Location = New System.Drawing.Point(101, 164)
        Me.lblrcptnum.Name = "lblrcptnum"
        Me.lblrcptnum.Size = New System.Drawing.Size(75, 13)
        Me.lblrcptnum.TabIndex = 23
        Me.lblrcptnum.Text = "Prescribed By:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.ForeColor = System.Drawing.Color.Black
        Me.lbldate.Location = New System.Drawing.Point(102, 142)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(75, 13)
        Me.lbldate.TabIndex = 21
        Me.lbldate.Text = "Prescribed By:"
        '
        'Lblaccount
        '
        Me.Lblaccount.AutoSize = True
        Me.Lblaccount.ForeColor = System.Drawing.Color.Black
        Me.Lblaccount.Location = New System.Drawing.Point(102, 119)
        Me.Lblaccount.Name = "Lblaccount"
        Me.Lblaccount.Size = New System.Drawing.Size(75, 13)
        Me.Lblaccount.TabIndex = 20
        Me.Lblaccount.Text = "Prescribed By:"
        '
        'Lblptname
        '
        Me.Lblptname.AutoSize = True
        Me.Lblptname.ForeColor = System.Drawing.Color.Black
        Me.Lblptname.Location = New System.Drawing.Point(102, 73)
        Me.Lblptname.Name = "Lblptname"
        Me.Lblptname.Size = New System.Drawing.Size(75, 13)
        Me.Lblptname.TabIndex = 19
        Me.Lblptname.Text = "Prescribed By:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Account type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(58, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Receipt No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Full Name:"
        '
        'lblph
        '
        Me.lblph.AutoSize = True
        Me.lblph.ForeColor = System.Drawing.Color.Black
        Me.lblph.Location = New System.Drawing.Point(93, 24)
        Me.lblph.Name = "lblph"
        Me.lblph.Size = New System.Drawing.Size(10, 13)
        Me.lblph.TabIndex = 11
        Me.lblph.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(91, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cash Payment Receipt"
        '
        'lblcompname
        '
        Me.lblcompname.AutoSize = True
        Me.lblcompname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompname.ForeColor = System.Drawing.Color.Black
        Me.lblcompname.Location = New System.Drawing.Point(54, 3)
        Me.lblcompname.Name = "lblcompname"
        Me.lblcompname.Size = New System.Drawing.Size(0, 15)
        Me.lblcompname.TabIndex = 12
        '
        'PrintDocument1
        '
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
        'FrmPrintreceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 395)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmPrintreceipt"
        Me.Text = "  RECEIPT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblrcptnum As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Lblaccount As Label
    Friend WithEvents Lblptname As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblph As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblcompname As Label
    Friend WithEvents lblhospnum As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblservice As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lbltotalamnt As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Lblamntword As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblLile As Label
    Friend WithEvents Lblcashier As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
