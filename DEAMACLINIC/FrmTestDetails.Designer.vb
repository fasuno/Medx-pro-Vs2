<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTestDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTestDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnremove = New System.Windows.Forms.Button()
        Me.TxtTestPara = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAdddetails = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtparHighrange = New System.Windows.Forms.TextBox()
        Me.TxtParLowRang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtParMeasure = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTest = New System.Windows.Forms.TextBox()
        Me.BtnEditdtails = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DtgTestPar = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DtgTestPar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btnremove)
        Me.Panel1.Controls.Add(Me.TxtTestPara)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnAdddetails)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtParMeasure)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtTest)
        Me.Panel1.Controls.Add(Me.BtnEditdtails)
        Me.Panel1.Location = New System.Drawing.Point(27, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 129)
        Me.Panel1.TabIndex = 0
        '
        'Btnremove
        '
        Me.Btnremove.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnremove.Location = New System.Drawing.Point(410, 97)
        Me.Btnremove.Name = "Btnremove"
        Me.Btnremove.Size = New System.Drawing.Size(69, 25)
        Me.Btnremove.TabIndex = 8
        Me.Btnremove.Text = "REMOVE"
        Me.Btnremove.UseVisualStyleBackColor = True
        '
        'TxtTestPara
        '
        Me.TxtTestPara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtTestPara.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtTestPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTestPara.Location = New System.Drawing.Point(93, 39)
        Me.TxtTestPara.Name = "TxtTestPara"
        Me.TxtTestPara.Size = New System.Drawing.Size(188, 20)
        Me.TxtTestPara.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Parameter:"
        '
        'BtnAdddetails
        '
        Me.BtnAdddetails.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdddetails.ForeColor = System.Drawing.Color.Black
        Me.BtnAdddetails.Location = New System.Drawing.Point(410, 69)
        Me.BtnAdddetails.Name = "BtnAdddetails"
        Me.BtnAdddetails.Size = New System.Drawing.Size(70, 26)
        Me.BtnAdddetails.TabIndex = 1
        Me.BtnAdddetails.Text = "ADD"
        Me.BtnAdddetails.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(289, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Measure:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtparHighrange)
        Me.GroupBox1.Controls.Add(Me.TxtParLowRang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(14, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 50)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RANGE"
        '
        'TxtparHighrange
        '
        Me.TxtparHighrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtparHighrange.Location = New System.Drawing.Point(263, 20)
        Me.TxtparHighrange.Name = "TxtparHighrange"
        Me.TxtparHighrange.Size = New System.Drawing.Size(119, 22)
        Me.TxtparHighrange.TabIndex = 7
        '
        'TxtParLowRang
        '
        Me.TxtParLowRang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtParLowRang.Location = New System.Drawing.Point(57, 21)
        Me.TxtParLowRang.Name = "TxtParLowRang"
        Me.TxtParLowRang.Size = New System.Drawing.Size(134, 22)
        Me.TxtParLowRang.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(197, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Children:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Adult:"
        '
        'txtParMeasure
        '
        Me.txtParMeasure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParMeasure.Location = New System.Drawing.Point(350, 38)
        Me.txtParMeasure.Name = "txtParMeasure"
        Me.txtParMeasure.Size = New System.Drawing.Size(76, 20)
        Me.txtParMeasure.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Test Name:"
        '
        'TxtTest
        '
        Me.TxtTest.BackColor = System.Drawing.Color.White
        Me.TxtTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTest.Location = New System.Drawing.Point(93, 10)
        Me.TxtTest.Name = "TxtTest"
        Me.TxtTest.ReadOnly = True
        Me.TxtTest.Size = New System.Drawing.Size(333, 20)
        Me.TxtTest.TabIndex = 1
        '
        'BtnEditdtails
        '
        Me.BtnEditdtails.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditdtails.ForeColor = System.Drawing.Color.Black
        Me.BtnEditdtails.Location = New System.Drawing.Point(409, 71)
        Me.BtnEditdtails.Name = "BtnEditdtails"
        Me.BtnEditdtails.Size = New System.Drawing.Size(70, 26)
        Me.BtnEditdtails.TabIndex = 7
        Me.BtnEditdtails.Text = "EDIT"
        Me.BtnEditdtails.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.Black
        Me.lblresult.Location = New System.Drawing.Point(25, 78)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 15)
        Me.lblresult.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DtgTestPar)
        Me.Panel2.Location = New System.Drawing.Point(4, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 198)
        Me.Panel2.TabIndex = 1
        '
        'DtgTestPar
        '
        Me.DtgTestPar.AllowUserToAddRows = False
        Me.DtgTestPar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgTestPar.Location = New System.Drawing.Point(4, 3)
        Me.DtgTestPar.Name = "DtgTestPar"
        Me.DtgTestPar.ReadOnly = True
        Me.DtgTestPar.Size = New System.Drawing.Size(518, 190)
        Me.DtgTestPar.TabIndex = 1
        '
        'FrmTestDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(537, 345)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTestDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   LABORATORY TEST DETAILS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DtgTestPar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTest As TextBox
    Friend WithEvents txtParMeasure As TextBox
    Friend WithEvents TxtParLowRang As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAdddetails As Button
    Friend WithEvents BtnEditdtails As Button
    Friend WithEvents TxtTestPara As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtparHighrange As TextBox
    Friend WithEvents lblresult As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtgTestPar As DataGridView
    Friend WithEvents Btnremove As Button
End Class
