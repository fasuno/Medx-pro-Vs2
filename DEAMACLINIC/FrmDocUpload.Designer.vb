<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDocUpload
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocUpload))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthospnum = New System.Windows.Forms.TextBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Btnbrowse = New System.Windows.Forms.Button()
        Me.txtdoctiltle = New System.Windows.Forms.TextBox()
        Me.Dgvfile = New System.Windows.Forms.DataGridView()
        Me.Btndel = New System.Windows.Forms.Button()
        Me.Btnview = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Lbldocid = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgvfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hospital No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full Name:"
        '
        'txthospnum
        '
        Me.txthospnum.BackColor = System.Drawing.Color.White
        Me.txthospnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthospnum.ForeColor = System.Drawing.Color.Black
        Me.txthospnum.Location = New System.Drawing.Point(88, 7)
        Me.txthospnum.Name = "txthospnum"
        Me.txthospnum.ReadOnly = True
        Me.txthospnum.Size = New System.Drawing.Size(104, 20)
        Me.txthospnum.TabIndex = 2
        '
        'Txtname
        '
        Me.Txtname.BackColor = System.Drawing.Color.White
        Me.Txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtname.ForeColor = System.Drawing.Color.Black
        Me.Txtname.Location = New System.Drawing.Point(88, 31)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.ReadOnly = True
        Me.Txtname.Size = New System.Drawing.Size(317, 20)
        Me.Txtname.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtfilename)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnUpload)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Btnbrowse)
        Me.Panel1.Controls.Add(Me.txtdoctiltle)
        Me.Panel1.Location = New System.Drawing.Point(-3, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 83)
        Me.Panel1.TabIndex = 4
        '
        'txtfilename
        '
        Me.txtfilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfilename.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtfilename.Location = New System.Drawing.Point(18, 32)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(309, 20)
        Me.txtfilename.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Document Title:"
        '
        'BtnUpload
        '
        Me.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpload.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpload.ForeColor = System.Drawing.Color.White
        Me.BtnUpload.Location = New System.Drawing.Point(333, 55)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpload.TabIndex = 8
        Me.BtnUpload.Text = "UPLOAD"
        Me.BtnUpload.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 56)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(309, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'Btnbrowse
        '
        Me.Btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbrowse.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbrowse.ForeColor = System.Drawing.Color.White
        Me.Btnbrowse.Location = New System.Drawing.Point(333, 29)
        Me.Btnbrowse.Name = "Btnbrowse"
        Me.Btnbrowse.Size = New System.Drawing.Size(75, 23)
        Me.Btnbrowse.TabIndex = 6
        Me.Btnbrowse.Text = "BROWSE"
        Me.Btnbrowse.UseVisualStyleBackColor = True
        '
        'txtdoctiltle
        '
        Me.txtdoctiltle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdoctiltle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdoctiltle.Location = New System.Drawing.Point(113, 3)
        Me.txtdoctiltle.Name = "txtdoctiltle"
        Me.txtdoctiltle.Size = New System.Drawing.Size(295, 20)
        Me.txtdoctiltle.TabIndex = 5
        '
        'Dgvfile
        '
        Me.Dgvfile.AllowUserToAddRows = False
        Me.Dgvfile.AllowUserToDeleteRows = False
        Me.Dgvfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgvfile.BackgroundColor = System.Drawing.Color.White
        Me.Dgvfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvfile.Location = New System.Drawing.Point(0, 166)
        Me.Dgvfile.Name = "Dgvfile"
        Me.Dgvfile.ReadOnly = True
        Me.Dgvfile.Size = New System.Drawing.Size(416, 119)
        Me.Dgvfile.TabIndex = 5
        '
        'Btndel
        '
        Me.Btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndel.ForeColor = System.Drawing.Color.Maroon
        Me.Btndel.Location = New System.Drawing.Point(67, 141)
        Me.Btndel.Name = "Btndel"
        Me.Btndel.Size = New System.Drawing.Size(62, 23)
        Me.Btndel.TabIndex = 10
        Me.Btndel.Text = "DELETE"
        Me.Btndel.UseVisualStyleBackColor = True
        '
        'Btnview
        '
        Me.Btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnview.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnview.ForeColor = System.Drawing.Color.Navy
        Me.Btnview.Location = New System.Drawing.Point(2, 141)
        Me.Btnview.Name = "Btnview"
        Me.Btnview.Size = New System.Drawing.Size(64, 23)
        Me.Btnview.TabIndex = 11
        Me.Btnview.Text = "VIEW"
        Me.Btnview.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(341, 7)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(32, 15)
        Me.lbldate.TabIndex = 12
        Me.lbldate.Text = "Date"
        '
        'Lbldocid
        '
        Me.Lbldocid.AutoSize = True
        Me.Lbldocid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldocid.Location = New System.Drawing.Point(215, 7)
        Me.Lbldocid.Name = "Lbldocid"
        Me.Lbldocid.Size = New System.Drawing.Size(10, 15)
        Me.Lbldocid.TabIndex = 13
        Me.Lbldocid.Text = " "
        Me.Lbldocid.Visible = False
        '
        'FrmDocUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(417, 285)
        Me.Controls.Add(Me.Lbldocid)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Btnview)
        Me.Controls.Add(Me.Btndel)
        Me.Controls.Add(Me.Dgvfile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.txthospnum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SCANNED DOCUMENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgvfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txthospnum As TextBox
    Friend WithEvents Txtname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnUpload As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Btnbrowse As Button
    Friend WithEvents txtdoctiltle As TextBox
    Friend WithEvents txtfilename As TextBox
    Friend WithEvents Dgvfile As DataGridView
    Friend WithEvents Btndel As Button
    Friend WithEvents Btnview As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbldate As Label
    Friend WithEvents Lbldocid As Label
End Class
