<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewRadInv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewRadInv))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtcomm = New System.Windows.Forms.TextBox()
        Me.BtnSavetest = New System.Windows.Forms.Button()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.TxtPrivCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbogroup = New System.Windows.Forms.ComboBox()
        Me.Lblinvs = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTest = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Txtcomm)
        Me.Panel1.Controls.Add(Me.BtnSavetest)
        Me.Panel1.Controls.Add(Me.Btnedit)
        Me.Panel1.Controls.Add(Me.TxtPrivCost)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Cbogroup)
        Me.Panel1.Controls.Add(Me.Lblinvs)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtTest)
        Me.Panel1.Location = New System.Drawing.Point(-1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 108)
        Me.Panel1.TabIndex = 3
        '
        'Txtcomm
        '
        Me.Txtcomm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtcomm.Location = New System.Drawing.Point(101, 85)
        Me.Txtcomm.Name = "Txtcomm"
        Me.Txtcomm.Size = New System.Drawing.Size(111, 20)
        Me.Txtcomm.TabIndex = 16
        Me.Txtcomm.Visible = False
        '
        'BtnSavetest
        '
        Me.BtnSavetest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSavetest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavetest.ForeColor = System.Drawing.Color.Green
        Me.BtnSavetest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSavetest.Location = New System.Drawing.Point(252, 62)
        Me.BtnSavetest.Name = "BtnSavetest"
        Me.BtnSavetest.Size = New System.Drawing.Size(69, 29)
        Me.BtnSavetest.TabIndex = 15
        Me.BtnSavetest.Text = "SAVE"
        Me.BtnSavetest.UseVisualStyleBackColor = True
        '
        'Btnedit
        '
        Me.Btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnedit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.Black
        Me.Btnedit.Image = CType(resources.GetObject("Btnedit.Image"), System.Drawing.Image)
        Me.Btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnedit.Location = New System.Drawing.Point(253, 63)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(68, 27)
        Me.Btnedit.TabIndex = 14
        Me.Btnedit.Text = "       EDIT"
        Me.Btnedit.UseVisualStyleBackColor = True
        '
        'TxtPrivCost
        '
        Me.TxtPrivCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrivCost.Location = New System.Drawing.Point(101, 62)
        Me.TxtPrivCost.Name = "TxtPrivCost"
        Me.TxtPrivCost.Size = New System.Drawing.Size(111, 20)
        Me.TxtPrivCost.TabIndex = 11
        Me.TxtPrivCost.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(59, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cost:"
        '
        'Cbogroup
        '
        Me.Cbogroup.AutoCompleteCustomSource.AddRange(New String() {"CHEMICAL PATHOLOGY", "HERMATHOLOGY", "MICRO BIOLOGY", "HISTOLOGY", "PROFILE"})
        Me.Cbogroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cbogroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbogroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbogroup.FormattingEnabled = True
        Me.Cbogroup.Items.AddRange(New Object() {"X-RAY", "CT SCAN", "ECG", "MAMOGRAM", "MRI", "ULTRASONOGRAPHY"})
        Me.Cbogroup.Location = New System.Drawing.Point(101, 35)
        Me.Cbogroup.Name = "Cbogroup"
        Me.Cbogroup.Size = New System.Drawing.Size(220, 21)
        Me.Cbogroup.TabIndex = 7
        '
        'Lblinvs
        '
        Me.Lblinvs.AutoSize = True
        Me.Lblinvs.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblinvs.ForeColor = System.Drawing.Color.Black
        Me.Lblinvs.Location = New System.Drawing.Point(16, 11)
        Me.Lblinvs.Name = "Lblinvs"
        Me.Lblinvs.Size = New System.Drawing.Size(81, 15)
        Me.Lblinvs.TabIndex = 1
        Me.Lblinvs.Text = "Investigation:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(50, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Group:"
        '
        'TxtTest
        '
        Me.TxtTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTest.Location = New System.Drawing.Point(101, 9)
        Me.TxtTest.Name = "TxtTest"
        Me.TxtTest.Size = New System.Drawing.Size(329, 20)
        Me.TxtTest.TabIndex = 1
        '
        'FrmNewRadInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 113)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewRadInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW RADIOLOGICAL INVESTIGATION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSavetest As Button
    Friend WithEvents Btnedit As Button
    Friend WithEvents TxtPrivCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbogroup As ComboBox
    Friend WithEvents Lblinvs As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTest As TextBox
    Friend WithEvents Txtcomm As TextBox
End Class
