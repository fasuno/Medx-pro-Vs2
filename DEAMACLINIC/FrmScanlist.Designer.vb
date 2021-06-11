<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScanlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmScanlist))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtgRadlist = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.BtnNewtest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbotestgrp = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgRadlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DtgRadlist)
        Me.Panel1.Location = New System.Drawing.Point(4, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 343)
        Me.Panel1.TabIndex = 2
        '
        'DtgRadlist
        '
        Me.DtgRadlist.AllowUserToAddRows = False
        Me.DtgRadlist.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        Me.DtgRadlist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgRadlist.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgRadlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgRadlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgRadlist.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgRadlist.Location = New System.Drawing.Point(0, 2)
        Me.DtgRadlist.Name = "DtgRadlist"
        Me.DtgRadlist.ReadOnly = True
        Me.DtgRadlist.Size = New System.Drawing.Size(793, 336)
        Me.DtgRadlist.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ChkAll)
        Me.Panel2.Controls.Add(Me.BtnNewtest)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Cbotestgrp)
        Me.Panel2.Location = New System.Drawing.Point(4, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 42)
        Me.Panel2.TabIndex = 3
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAll.ForeColor = System.Drawing.Color.Black
        Me.ChkAll.Location = New System.Drawing.Point(394, 16)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(86, 19)
        Me.ChkAll.TabIndex = 3
        Me.ChkAll.Text = "VIEW ALL"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'BtnNewtest
        '
        Me.BtnNewtest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewtest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewtest.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnNewtest.Image = CType(resources.GetObject("BtnNewtest.Image"), System.Drawing.Image)
        Me.BtnNewtest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewtest.Location = New System.Drawing.Point(3, 14)
        Me.BtnNewtest.Name = "BtnNewtest"
        Me.BtnNewtest.Size = New System.Drawing.Size(62, 24)
        Me.BtnNewtest.TabIndex = 1
        Me.BtnNewtest.Text = "      New"
        Me.BtnNewtest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sort by group--->"
        '
        'Cbotestgrp
        '
        Me.Cbotestgrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbotestgrp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbotestgrp.FormattingEnabled = True
        Me.Cbotestgrp.Items.AddRange(New Object() {"X-RAY", "CT SCAN", "ECG", "MAMOGRAM", "MRI", "ULTRASONOGRAPHY"})
        Me.Cbotestgrp.Location = New System.Drawing.Point(178, 14)
        Me.Cbotestgrp.Name = "Cbotestgrp"
        Me.Cbotestgrp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbotestgrp.Size = New System.Drawing.Size(188, 23)
        Me.Cbotestgrp.TabIndex = 1
        '
        'FrmScanlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 387)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmScanlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   RADIOLOGY INVESTIGATIONS"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DtgRadlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DtgRadlist As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ChkAll As CheckBox
    Friend WithEvents BtnNewtest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cbotestgrp As ComboBox
End Class
