<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BedManager
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BedManager))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtbedno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbobedname = New System.Windows.Forms.ComboBox()
        Me.Txtbedfee = New System.Windows.Forms.TextBox()
        Me.btndel = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.Dgvbedlist = New System.Windows.Forms.DataGridView()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.lblbedid = New System.Windows.Forms.Label()
        CType(Me.Dgvbedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 10)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bed No.:"
        '
        'Txtbedno
        '
        Me.Txtbedno.Location = New System.Drawing.Point(131, 16)
        Me.Txtbedno.Name = "Txtbedno"
        Me.Txtbedno.Size = New System.Drawing.Size(75, 20)
        Me.Txtbedno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ward Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bed Fee (per night):"
        '
        'cbobedname
        '
        Me.cbobedname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbobedname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbobedname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobedname.FormattingEnabled = True
        Me.cbobedname.Items.AddRange(New Object() {"PRIVATE WARD", "GENERAL WARD"})
        Me.cbobedname.Location = New System.Drawing.Point(131, 43)
        Me.cbobedname.Name = "cbobedname"
        Me.cbobedname.Size = New System.Drawing.Size(152, 21)
        Me.cbobedname.TabIndex = 7
        '
        'Txtbedfee
        '
        Me.Txtbedfee.Location = New System.Drawing.Point(131, 70)
        Me.Txtbedfee.Name = "Txtbedfee"
        Me.Txtbedfee.Size = New System.Drawing.Size(75, 20)
        Me.Txtbedfee.TabIndex = 9
        '
        'btndel
        '
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.Maroon
        Me.btndel.Image = CType(resources.GetObject("btndel.Image"), System.Drawing.Image)
        Me.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndel.Location = New System.Drawing.Point(208, 96)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 26)
        Me.btndel.TabIndex = 10
        Me.btndel.Text = "      Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Green
        Me.Btnsave.Image = CType(resources.GetObject("Btnsave.Image"), System.Drawing.Image)
        Me.Btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsave.Location = New System.Drawing.Point(131, 96)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 26)
        Me.Btnsave.TabIndex = 11
        Me.Btnsave.Text = "   Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'btnupd
        '
        Me.btnupd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupd.ForeColor = System.Drawing.Color.Navy
        Me.btnupd.Image = CType(resources.GetObject("btnupd.Image"), System.Drawing.Image)
        Me.btnupd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupd.Location = New System.Drawing.Point(130, 96)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(75, 26)
        Me.btnupd.TabIndex = 12
        Me.btnupd.Text = "     Update"
        Me.btnupd.UseVisualStyleBackColor = True
        '
        'Dgvbedlist
        '
        Me.Dgvbedlist.AllowUserToAddRows = False
        Me.Dgvbedlist.AllowUserToDeleteRows = False
        Me.Dgvbedlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgvbedlist.BackgroundColor = System.Drawing.Color.White
        Me.Dgvbedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvbedlist.GridColor = System.Drawing.Color.White
        Me.Dgvbedlist.Location = New System.Drawing.Point(3, 128)
        Me.Dgvbedlist.Name = "Dgvbedlist"
        Me.Dgvbedlist.ReadOnly = True
        Me.Dgvbedlist.Size = New System.Drawing.Size(390, 108)
        Me.Dgvbedlist.TabIndex = 13
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(24, 102)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(32, 15)
        Me.lblstatus.TabIndex = 14
        Me.lblstatus.Text = "Free"
        Me.lblstatus.Visible = False
        '
        'lblbedid
        '
        Me.lblbedid.AutoSize = True
        Me.lblbedid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbedid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbedid.Location = New System.Drawing.Point(269, 16)
        Me.lblbedid.Name = "lblbedid"
        Me.lblbedid.Size = New System.Drawing.Size(12, 17)
        Me.lblbedid.TabIndex = 15
        Me.lblbedid.Text = " "
        Me.lblbedid.Visible = False
        '
        'BedManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblbedid)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.Dgvbedlist)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.Txtbedfee)
        Me.Controls.Add(Me.cbobedname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtbedno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BedManager"
        Me.Size = New System.Drawing.Size(396, 252)
        CType(Me.Dgvbedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtbedno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbobedname As ComboBox
    Friend WithEvents Txtbedfee As TextBox
    Friend WithEvents btndel As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents btnupd As Button
    Friend WithEvents Dgvbedlist As DataGridView
    Friend WithEvents lblstatus As Label
    Friend WithEvents lblbedid As Label
End Class
