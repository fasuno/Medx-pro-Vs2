<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLabResultpreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLabResultpreview))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Txtreprtby = New System.Windows.Forms.TextBox()
        Me.Txtdaterprt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lblrqstnum = New System.Windows.Forms.Label()
        Me.txtclinic = New System.Windows.Forms.TextBox()
        Me.Txtdiag = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRqstBy = New System.Windows.Forms.TextBox()
        Me.Txtdatrqst = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dtginv = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Dtgtestresult = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Txtnotes = New System.Windows.Forms.TextBox()
        Me.LblTest = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.Dtginv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dtgtestresult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.Txtreprtby)
        Me.panel1.Controls.Add(Me.Txtdaterprt)
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Controls.Add(Me.Label6)
        Me.panel1.Controls.Add(Me.Lblrqstnum)
        Me.panel1.Controls.Add(Me.txtclinic)
        Me.panel1.Controls.Add(Me.Txtdiag)
        Me.panel1.Controls.Add(Me.Label4)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.TxtRqstBy)
        Me.panel1.Controls.Add(Me.Txtdatrqst)
        Me.panel1.Controls.Add(Me.Label5)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.Location = New System.Drawing.Point(4, 7)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(880, 75)
        Me.panel1.TabIndex = 0
        '
        'Txtreprtby
        '
        Me.Txtreprtby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtreprtby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtreprtby.Location = New System.Drawing.Point(369, 39)
        Me.Txtreprtby.Name = "Txtreprtby"
        Me.Txtreprtby.Size = New System.Drawing.Size(237, 21)
        Me.Txtreprtby.TabIndex = 8
        '
        'Txtdaterprt
        '
        Me.Txtdaterprt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdaterprt.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdaterprt.Location = New System.Drawing.Point(164, 41)
        Me.Txtdaterprt.Name = "Txtdaterprt"
        Me.Txtdaterprt.Size = New System.Drawing.Size(108, 21)
        Me.Txtdaterprt.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(70, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date Reported:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(285, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Reported By:"
        '
        'Lblrqstnum
        '
        Me.Lblrqstnum.AutoSize = True
        Me.Lblrqstnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrqstnum.Location = New System.Drawing.Point(808, 44)
        Me.Lblrqstnum.Name = "Lblrqstnum"
        Me.Lblrqstnum.Size = New System.Drawing.Size(59, 15)
        Me.Lblrqstnum.TabIndex = 7
        Me.Lblrqstnum.Text = "Rqst num"
        Me.Lblrqstnum.Visible = False
        '
        'txtclinic
        '
        Me.txtclinic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclinic.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclinic.Location = New System.Drawing.Point(663, 39)
        Me.txtclinic.Name = "txtclinic"
        Me.txtclinic.Size = New System.Drawing.Size(114, 21)
        Me.txtclinic.TabIndex = 3
        '
        'Txtdiag
        '
        Me.Txtdiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdiag.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdiag.Location = New System.Drawing.Point(650, 5)
        Me.Txtdiag.Name = "Txtdiag"
        Me.Txtdiag.Size = New System.Drawing.Size(195, 21)
        Me.Txtdiag.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(578, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Diagnosis:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(244, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Requested By:"
        '
        'TxtRqstBy
        '
        Me.TxtRqstBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRqstBy.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRqstBy.Location = New System.Drawing.Point(335, 7)
        Me.TxtRqstBy.Name = "TxtRqstBy"
        Me.TxtRqstBy.Size = New System.Drawing.Size(237, 21)
        Me.TxtRqstBy.TabIndex = 5
        '
        'Txtdatrqst
        '
        Me.Txtdatrqst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdatrqst.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdatrqst.Location = New System.Drawing.Point(130, 7)
        Me.Txtdatrqst.Name = "Txtdatrqst"
        Me.Txtdatrqst.Size = New System.Drawing.Size(108, 21)
        Me.Txtdatrqst.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(612, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Clinic:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date Requested:"
        '
        'Dtginv
        '
        Me.Dtginv.AllowUserToAddRows = False
        Me.Dtginv.AllowUserToDeleteRows = False
        Me.Dtginv.AllowUserToResizeColumns = False
        Me.Dtginv.AllowUserToResizeRows = False
        Me.Dtginv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtginv.BackgroundColor = System.Drawing.Color.White
        Me.Dtginv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtginv.GridColor = System.Drawing.Color.Black
        Me.Dtginv.Location = New System.Drawing.Point(651, 116)
        Me.Dtginv.Name = "Dtginv"
        Me.Dtginv.ReadOnly = True
        Me.Dtginv.Size = New System.Drawing.Size(230, 287)
        Me.Dtginv.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(1, 116)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(644, 295)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dtgtestresult)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RESULT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Dtgtestresult
        '
        Me.Dtgtestresult.AllowUserToAddRows = False
        Me.Dtgtestresult.AllowUserToDeleteRows = False
        Me.Dtgtestresult.AllowUserToResizeColumns = False
        Me.Dtgtestresult.AllowUserToResizeRows = False
        Me.Dtgtestresult.BackgroundColor = System.Drawing.Color.White
        Me.Dtgtestresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgtestresult.GridColor = System.Drawing.Color.Black
        Me.Dtgtestresult.Location = New System.Drawing.Point(0, 3)
        Me.Dtgtestresult.Name = "Dtgtestresult"
        Me.Dtgtestresult.ReadOnly = True
        Me.Dtgtestresult.Size = New System.Drawing.Size(630, 260)
        Me.Dtgtestresult.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Txtnotes)
        Me.TabPage2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Note: (e.g Histology, Cytology)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Txtnotes
        '
        Me.Txtnotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnotes.Location = New System.Drawing.Point(7, 6)
        Me.Txtnotes.Multiline = True
        Me.Txtnotes.Name = "Txtnotes"
        Me.Txtnotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtnotes.Size = New System.Drawing.Size(626, 255)
        Me.Txtnotes.TabIndex = 7
        '
        'LblTest
        '
        Me.LblTest.AutoSize = True
        Me.LblTest.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTest.ForeColor = System.Drawing.Color.DarkRed
        Me.LblTest.Location = New System.Drawing.Point(316, 88)
        Me.LblTest.Name = "LblTest"
        Me.LblTest.Size = New System.Drawing.Size(127, 22)
        Me.LblTest.TabIndex = 7
        Me.LblTest.Text = "Requested By:"
        '
        'FrmLabResultpreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(889, 407)
        Me.Controls.Add(Me.LblTest)
        Me.Controls.Add(Me.Dtginv)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLabResultpreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "      LABORATORY TEST RESULT"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.Dtginv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dtgtestresult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtclinic As TextBox
    Friend WithEvents Txtdiag As TextBox
    Friend WithEvents TxtRqstBy As TextBox
    Friend WithEvents Txtdatrqst As TextBox
    Friend WithEvents Dtginv As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Txtnotes As TextBox
    Friend WithEvents Dtgtestresult As DataGridView
    Friend WithEvents LblTest As Label
    Friend WithEvents Lblrqstnum As Label
    Friend WithEvents Txtreprtby As TextBox
    Friend WithEvents Txtdaterprt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
