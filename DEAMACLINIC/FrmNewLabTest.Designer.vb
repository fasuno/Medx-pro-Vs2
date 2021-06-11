<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewLabTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewLabTest))
        Me.TxtCompCost = New System.Windows.Forms.TextBox()
        Me.TxtNhisCost = New System.Windows.Forms.TextBox()
        Me.TxtPrivCost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbogroup = New System.Windows.Forms.ComboBox()
        Me.TxtTest = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSavetest = New System.Windows.Forms.Button()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.TxtMeasure = New System.Windows.Forms.TextBox()
        Me.BtnTestpar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCompCost
        '
        Me.TxtCompCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCompCost.Location = New System.Drawing.Point(135, 120)
        Me.TxtCompCost.Name = "TxtCompCost"
        Me.TxtCompCost.Size = New System.Drawing.Size(89, 20)
        Me.TxtCompCost.TabIndex = 13
        Me.TxtCompCost.Text = "0"
        '
        'TxtNhisCost
        '
        Me.TxtNhisCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNhisCost.Location = New System.Drawing.Point(135, 94)
        Me.TxtNhisCost.Name = "TxtNhisCost"
        Me.TxtNhisCost.Size = New System.Drawing.Size(89, 20)
        Me.TxtNhisCost.TabIndex = 12
        Me.TxtNhisCost.Text = "0"
        '
        'TxtPrivCost
        '
        Me.TxtPrivCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrivCost.Location = New System.Drawing.Point(135, 68)
        Me.TxtPrivCost.Name = "TxtPrivCost"
        Me.TxtPrivCost.Size = New System.Drawing.Size(89, 20)
        Me.TxtPrivCost.TabIndex = 11
        Me.TxtPrivCost.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(74, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Company:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(98, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nhis:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(85, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Private:"
        '
        'Cbogroup
        '
        Me.Cbogroup.AutoCompleteCustomSource.AddRange(New String() {"CHEMICAL PATHOLOGY", "HERMATHOLOGY", "MICRO BIOLOGY", "HISTOLOGY", "PROFILE"})
        Me.Cbogroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cbogroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbogroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbogroup.FormattingEnabled = True
        Me.Cbogroup.Items.AddRange(New Object() {"CHEMICAL PATHOLOGY", "HERMATHOLOGY", "HORMONE", "MICRO BIOLOGY", "HISTOLOGY", "PROFILE"})
        Me.Cbogroup.Location = New System.Drawing.Point(91, 35)
        Me.Cbogroup.Name = "Cbogroup"
        Me.Cbogroup.Size = New System.Drawing.Size(175, 21)
        Me.Cbogroup.TabIndex = 7
        '
        'TxtTest
        '
        Me.TxtTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTest.Location = New System.Drawing.Point(91, 10)
        Me.TxtTest.Name = "TxtTest"
        Me.TxtTest.Size = New System.Drawing.Size(329, 20)
        Me.TxtTest.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(270, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Measure:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Test Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Group:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSavetest)
        Me.Panel1.Controls.Add(Me.Btnedit)
        Me.Panel1.Controls.Add(Me.TxtCompCost)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtMeasure)
        Me.Panel1.Controls.Add(Me.TxtNhisCost)
        Me.Panel1.Controls.Add(Me.TxtPrivCost)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Cbogroup)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtTest)
        Me.Panel1.Location = New System.Drawing.Point(11, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 148)
        Me.Panel1.TabIndex = 2
        '
        'BtnSavetest
        '
        Me.BtnSavetest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSavetest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavetest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSavetest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSavetest.Location = New System.Drawing.Point(273, 108)
        Me.BtnSavetest.Name = "BtnSavetest"
        Me.BtnSavetest.Size = New System.Drawing.Size(67, 29)
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
        Me.Btnedit.Location = New System.Drawing.Point(273, 110)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(67, 27)
        Me.Btnedit.TabIndex = 14
        Me.Btnedit.Text = "     EDIT"
        Me.Btnedit.UseVisualStyleBackColor = True
        '
        'TxtMeasure
        '
        Me.TxtMeasure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMeasure.Location = New System.Drawing.Point(331, 35)
        Me.TxtMeasure.Name = "TxtMeasure"
        Me.TxtMeasure.Size = New System.Drawing.Size(89, 20)
        Me.TxtMeasure.TabIndex = 2
        '
        'BtnTestpar
        '
        Me.BtnTestpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTestpar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTestpar.ForeColor = System.Drawing.Color.Blue
        Me.BtnTestpar.Location = New System.Drawing.Point(142, 155)
        Me.BtnTestpar.Name = "BtnTestpar"
        Me.BtnTestpar.Size = New System.Drawing.Size(209, 29)
        Me.BtnTestpar.TabIndex = 3
        Me.BtnTestpar.Text = "ADD RESULT PARAMETERS"
        Me.BtnTestpar.UseVisualStyleBackColor = True
        '
        'FrmNewLabTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 185)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnTestpar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewLabTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  LABORATORY TEST"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtCompCost As TextBox
    Friend WithEvents TxtNhisCost As TextBox
    Friend WithEvents TxtPrivCost As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbogroup As ComboBox
    Friend WithEvents TxtTest As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtMeasure As TextBox
    Friend WithEvents BtnTestpar As Button
    Friend WithEvents BtnSavetest As Button
    Friend WithEvents Btnedit As Button
End Class
