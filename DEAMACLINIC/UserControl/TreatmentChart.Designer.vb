<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreatmentChart
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtgChartdrugs = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DtgDrugsChartHx = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblChartID = New System.Windows.Forms.Label()
        Me.Txtnurse = New System.Windows.Forms.TextBox()
        Me.Lblnurse = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgChartdrugs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgDrugsChartHx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 25)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(311, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TREATMENT CHART"
        '
        'DtgChartdrugs
        '
        Me.DtgChartdrugs.AllowUserToAddRows = False
        Me.DtgChartdrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgChartdrugs.BackgroundColor = System.Drawing.Color.White
        Me.DtgChartdrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgChartdrugs.Location = New System.Drawing.Point(3, 53)
        Me.DtgChartdrugs.Name = "DtgChartdrugs"
        Me.DtgChartdrugs.Size = New System.Drawing.Size(801, 165)
        Me.DtgChartdrugs.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AVAILABLE DRUGS:"
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.Location = New System.Drawing.Point(710, 226)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(92, 27)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DtgDrugsChartHx
        '
        Me.DtgDrugsChartHx.AllowUserToAddRows = False
        Me.DtgDrugsChartHx.AllowUserToDeleteRows = False
        Me.DtgDrugsChartHx.AllowUserToResizeColumns = False
        Me.DtgDrugsChartHx.AllowUserToResizeRows = False
        Me.DtgDrugsChartHx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgDrugsChartHx.BackgroundColor = System.Drawing.Color.White
        Me.DtgDrugsChartHx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDrugsChartHx.Location = New System.Drawing.Point(3, 255)
        Me.DtgDrugsChartHx.Name = "DtgDrugsChartHx"
        Me.DtgDrugsChartHx.ReadOnly = True
        Me.DtgDrugsChartHx.Size = New System.Drawing.Size(801, 171)
        Me.DtgDrugsChartHx.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(7, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DRUGS CHART HISTORY:"
        '
        'LblChartID
        '
        Me.LblChartID.AutoSize = True
        Me.LblChartID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChartID.ForeColor = System.Drawing.Color.Blue
        Me.LblChartID.Location = New System.Drawing.Point(352, 28)
        Me.LblChartID.Name = "LblChartID"
        Me.LblChartID.Size = New System.Drawing.Size(49, 15)
        Me.LblChartID.TabIndex = 6
        Me.LblChartID.Text = "Chartid"
        Me.LblChartID.Visible = False
        '
        'Txtnurse
        '
        Me.Txtnurse.Location = New System.Drawing.Point(554, 232)
        Me.Txtnurse.Name = "Txtnurse"
        Me.Txtnurse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtnurse.Size = New System.Drawing.Size(153, 20)
        Me.Txtnurse.TabIndex = 7
        '
        'Lblnurse
        '
        Me.Lblnurse.AutoSize = True
        Me.Lblnurse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnurse.ForeColor = System.Drawing.Color.Blue
        Me.Lblnurse.Location = New System.Drawing.Point(425, 28)
        Me.Lblnurse.Name = "Lblnurse"
        Me.Lblnurse.Size = New System.Drawing.Size(41, 15)
        Me.Lblnurse.TabIndex = 8
        Me.Lblnurse.Text = "Nurse"
        Me.Lblnurse.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(486, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password:"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefresh.Location = New System.Drawing.Point(681, 27)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(123, 23)
        Me.BtnRefresh.TabIndex = 10
        Me.BtnRefresh.Text = "Refresh Drug List"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(338, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 38)
        Me.Panel2.TabIndex = 11
        '
        'TreatmentChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lblnurse)
        Me.Controls.Add(Me.Txtnurse)
        Me.Controls.Add(Me.LblChartID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtgDrugsChartHx)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtgChartdrugs)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TreatmentChart"
        Me.Size = New System.Drawing.Size(807, 433)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DtgChartdrugs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgDrugsChartHx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DtgChartdrugs As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents DtgDrugsChartHx As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents LblChartID As Label
    Friend WithEvents Txtnurse As TextBox
    Friend WithEvents Lblnurse As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Panel2 As Panel
End Class
