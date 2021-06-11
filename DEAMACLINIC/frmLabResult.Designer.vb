<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLabResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabResult))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkcompl = New System.Windows.Forms.CheckBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassw = New System.Windows.Forms.TextBox()
        Me.DtgTest = New System.Windows.Forms.DataGridView()
        Me.txtpwordrev = New System.Windows.Forms.TextBox()
        Me.BtnReview = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbltestname = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Dtgresults = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Txtnote = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblreviewby = New System.Windows.Forms.Label()
        Me.lblrqstnum = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbltim = New System.Windows.Forms.Label()
        Me.lblreportby = New System.Windows.Forms.Label()
        Me.lbldte = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Txtactcat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOname = New System.Windows.Forms.TextBox()
        Me.txtRqstby = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.TxtSname = New System.Windows.Forms.TextBox()
        Me.TxtRqstdate = New System.Windows.Forms.TextBox()
        Me.txtacct = New System.Windows.Forms.TextBox()
        Me.txtHnum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnBill = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dtgresults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnBill)
        Me.Panel1.Controls.Add(Me.chkcompl)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtpassw)
        Me.Panel1.Controls.Add(Me.DtgTest)
        Me.Panel1.Controls.Add(Me.txtpwordrev)
        Me.Panel1.Controls.Add(Me.BtnReview)
        Me.Panel1.Location = New System.Drawing.Point(824, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 307)
        Me.Panel1.TabIndex = 0
        '
        'chkcompl
        '
        Me.chkcompl.AutoSize = True
        Me.chkcompl.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcompl.ForeColor = System.Drawing.Color.DarkRed
        Me.chkcompl.Location = New System.Drawing.Point(162, 248)
        Me.chkcompl.Name = "chkcompl"
        Me.chkcompl.Size = New System.Drawing.Size(103, 21)
        Me.chkcompl.TabIndex = 29
        Me.chkcompl.Text = "Complete ?"
        Me.chkcompl.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(7, 277)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(113, 25)
        Me.btnsave.TabIndex = 26
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Enter Password:"
        '
        'txtpassw
        '
        Me.txtpassw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassw.Enabled = False
        Me.txtpassw.Location = New System.Drawing.Point(7, 251)
        Me.txtpassw.Name = "txtpassw"
        Me.txtpassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpassw.Size = New System.Drawing.Size(151, 20)
        Me.txtpassw.TabIndex = 2
        '
        'DtgTest
        '
        Me.DtgTest.AllowUserToAddRows = False
        Me.DtgTest.AllowUserToDeleteRows = False
        Me.DtgTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgTest.BackgroundColor = System.Drawing.Color.White
        Me.DtgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgTest.Location = New System.Drawing.Point(3, 3)
        Me.DtgTest.Name = "DtgTest"
        Me.DtgTest.ReadOnly = True
        Me.DtgTest.Size = New System.Drawing.Size(263, 214)
        Me.DtgTest.TabIndex = 0
        '
        'txtpwordrev
        '
        Me.txtpwordrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpwordrev.Enabled = False
        Me.txtpwordrev.Location = New System.Drawing.Point(7, 251)
        Me.txtpwordrev.Name = "txtpwordrev"
        Me.txtpwordrev.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpwordrev.Size = New System.Drawing.Size(151, 20)
        Me.txtpwordrev.TabIndex = 28
        '
        'BtnReview
        '
        Me.BtnReview.Enabled = False
        Me.BtnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReview.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReview.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReview.Location = New System.Drawing.Point(7, 277)
        Me.BtnReview.Name = "BtnReview"
        Me.BtnReview.Size = New System.Drawing.Size(113, 25)
        Me.BtnReview.TabIndex = 27
        Me.BtnReview.Text = "    REVIEW"
        Me.BtnReview.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbltestname)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(4, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(814, 307)
        Me.Panel2.TabIndex = 0
        '
        'lbltestname
        '
        Me.lbltestname.AutoSize = True
        Me.lbltestname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestname.ForeColor = System.Drawing.Color.Maroon
        Me.lbltestname.Location = New System.Drawing.Point(459, 7)
        Me.lbltestname.Name = "lbltestname"
        Me.lbltestname.Size = New System.Drawing.Size(0, 19)
        Me.lbltestname.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(802, 293)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dtgresults)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(794, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RESULT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Dtgresults
        '
        Me.Dtgresults.AllowUserToAddRows = False
        Me.Dtgresults.AllowUserToDeleteRows = False
        Me.Dtgresults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtgresults.BackgroundColor = System.Drawing.Color.White
        Me.Dtgresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgresults.Location = New System.Drawing.Point(3, 4)
        Me.Dtgresults.Name = "Dtgresults"
        Me.Dtgresults.Size = New System.Drawing.Size(788, 257)
        Me.Dtgresults.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Txtnote)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(794, 265)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Note: (e.g Histology, Cytology)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Txtnote
        '
        Me.Txtnote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnote.Location = New System.Drawing.Point(6, 6)
        Me.Txtnote.Multiline = True
        Me.Txtnote.Name = "Txtnote"
        Me.Txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtnote.Size = New System.Drawing.Size(781, 259)
        Me.Txtnote.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.lblreviewby)
        Me.Panel3.Controls.Add(Me.lblrqstnum)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lbltim)
        Me.Panel3.Controls.Add(Me.lblreportby)
        Me.Panel3.Controls.Add(Me.lbldte)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1089, 100)
        Me.Panel3.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(801, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Reviewed By:"
        '
        'lblreviewby
        '
        Me.lblreviewby.AutoSize = True
        Me.lblreviewby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblreviewby.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblreviewby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreviewby.ForeColor = System.Drawing.Color.Navy
        Me.lblreviewby.Location = New System.Drawing.Point(881, 67)
        Me.lblreviewby.Name = "lblreviewby"
        Me.lblreviewby.Size = New System.Drawing.Size(12, 17)
        Me.lblreviewby.TabIndex = 24
        Me.lblreviewby.Text = " "
        '
        'lblrqstnum
        '
        Me.lblrqstnum.AutoSize = True
        Me.lblrqstnum.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrqstnum.ForeColor = System.Drawing.Color.Blue
        Me.lblrqstnum.Location = New System.Drawing.Point(795, 8)
        Me.lblrqstnum.Name = "lblrqstnum"
        Me.lblrqstnum.Size = New System.Drawing.Size(95, 17)
        Me.lblrqstnum.TabIndex = 22
        Me.lblrqstnum.Text = "Request num"
        Me.lblrqstnum.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(803, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Reported By:"
        '
        'lbltim
        '
        Me.lbltim.AutoSize = True
        Me.lbltim.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltim.Location = New System.Drawing.Point(989, 3)
        Me.lbltim.Name = "lbltim"
        Me.lbltim.Size = New System.Drawing.Size(47, 17)
        Me.lbltim.TabIndex = 18
        Me.lbltim.Text = "Time:"
        '
        'lblreportby
        '
        Me.lblreportby.AutoSize = True
        Me.lblreportby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblreportby.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblreportby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreportby.ForeColor = System.Drawing.Color.Navy
        Me.lblreportby.Location = New System.Drawing.Point(881, 36)
        Me.lblreportby.Name = "lblreportby"
        Me.lblreportby.Size = New System.Drawing.Size(12, 17)
        Me.lblreportby.TabIndex = 21
        Me.lblreportby.Text = " "
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldte.Location = New System.Drawing.Point(895, 3)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(44, 17)
        Me.lbldte.TabIndex = 17
        Me.lbldte.Text = "Date:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Txtactcat)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtOname)
        Me.Panel4.Controls.Add(Me.txtRqstby)
        Me.Panel4.Controls.Add(Me.txtage)
        Me.Panel4.Controls.Add(Me.txtsex)
        Me.Panel4.Controls.Add(Me.TxtSname)
        Me.Panel4.Controls.Add(Me.TxtRqstdate)
        Me.Panel4.Controls.Add(Me.txtacct)
        Me.Panel4.Controls.Add(Me.txtHnum)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(10, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(779, 88)
        Me.Panel4.TabIndex = 16
        '
        'Txtactcat
        '
        Me.Txtactcat.BackColor = System.Drawing.Color.White
        Me.Txtactcat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtactcat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtactcat.ForeColor = System.Drawing.Color.Black
        Me.Txtactcat.Location = New System.Drawing.Point(645, 56)
        Me.Txtactcat.Name = "Txtactcat"
        Me.Txtactcat.ReadOnly = True
        Me.Txtactcat.Size = New System.Drawing.Size(123, 21)
        Me.Txtactcat.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(541, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Account category:"
        '
        'txtOname
        '
        Me.txtOname.BackColor = System.Drawing.Color.White
        Me.txtOname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOname.ForeColor = System.Drawing.Color.Black
        Me.txtOname.Location = New System.Drawing.Point(455, 4)
        Me.txtOname.Name = "txtOname"
        Me.txtOname.ReadOnly = True
        Me.txtOname.Size = New System.Drawing.Size(312, 21)
        Me.txtOname.TabIndex = 20
        '
        'txtRqstby
        '
        Me.txtRqstby.BackColor = System.Drawing.Color.White
        Me.txtRqstby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRqstby.ForeColor = System.Drawing.Color.Black
        Me.txtRqstby.Location = New System.Drawing.Point(308, 57)
        Me.txtRqstby.Name = "txtRqstby"
        Me.txtRqstby.ReadOnly = True
        Me.txtRqstby.Size = New System.Drawing.Size(230, 20)
        Me.txtRqstby.TabIndex = 19
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(430, 30)
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
        Me.txtsex.Location = New System.Drawing.Point(308, 30)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(85, 21)
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
        Me.TxtSname.Size = New System.Drawing.Size(259, 21)
        Me.TxtSname.TabIndex = 16
        '
        'TxtRqstdate
        '
        Me.TxtRqstdate.BackColor = System.Drawing.Color.White
        Me.TxtRqstdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRqstdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRqstdate.ForeColor = System.Drawing.Color.Black
        Me.TxtRqstdate.Location = New System.Drawing.Point(100, 56)
        Me.TxtRqstdate.Name = "TxtRqstdate"
        Me.TxtRqstdate.ReadOnly = True
        Me.TxtRqstdate.Size = New System.Drawing.Size(107, 21)
        Me.TxtRqstdate.TabIndex = 14
        '
        'txtacct
        '
        Me.txtacct.BackColor = System.Drawing.Color.White
        Me.txtacct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtacct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct.ForeColor = System.Drawing.Color.Black
        Me.txtacct.Location = New System.Drawing.Point(567, 31)
        Me.txtacct.Name = "txtacct"
        Me.txtacct.ReadOnly = True
        Me.txtacct.Size = New System.Drawing.Size(200, 21)
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
        Me.Label9.Location = New System.Drawing.Point(271, 33)
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
        Me.Label2.Location = New System.Drawing.Point(3, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Requested:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(365, 5)
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
        Me.Label4.Location = New System.Drawing.Point(41, 6)
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
        Me.Label5.Location = New System.Drawing.Point(13, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hospital_Num:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(213, 59)
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
        Me.Label7.Location = New System.Drawing.Point(399, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(480, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Account type:"
        '
        'BtnBill
        '
        Me.BtnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBill.ForeColor = System.Drawing.Color.Blue
        Me.BtnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBill.Location = New System.Drawing.Point(126, 277)
        Me.BtnBill.Name = "BtnBill"
        Me.BtnBill.Size = New System.Drawing.Size(140, 25)
        Me.BtnBill.TabIndex = 30
        Me.BtnBill.Text = "RAISE BILL"
        Me.BtnBill.UseVisualStyleBackColor = True
        '
        'frmLabResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1093, 422)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLabResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   LABORATORY TEST RESULT "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DtgTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dtgresults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DtgTest As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Dtgresults As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Txtnote As TextBox
    Friend WithEvents lbltestname As Label
    Friend WithEvents lblreportby As Label
    Friend WithEvents lbltim As Label
    Friend WithEvents lbldte As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtOname As TextBox
    Friend WithEvents txtRqstby As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents TxtRqstdate As TextBox
    Friend WithEvents txtacct As TextBox
    Friend WithEvents txtHnum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblrqstnum As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassw As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblreviewby As Label
    Friend WithEvents BtnReview As Button
    Friend WithEvents txtpwordrev As TextBox
    Friend WithEvents chkcompl As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txtactcat As TextBox
    Friend WithEvents BtnBill As Button
End Class
