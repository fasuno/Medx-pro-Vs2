<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabTestList
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabTestList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtgAllLabTest = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.BtnNewtest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbotestgrp = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgAllLabTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DtgAllLabTest)
        Me.Panel1.Location = New System.Drawing.Point(3, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 343)
        Me.Panel1.TabIndex = 0
        '
        'DtgAllLabTest
        '
        Me.DtgAllLabTest.AllowUserToAddRows = False
        Me.DtgAllLabTest.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy
        Me.DtgAllLabTest.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgAllLabTest.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgAllLabTest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DtgAllLabTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgAllLabTest.DefaultCellStyle = DataGridViewCellStyle6
        Me.DtgAllLabTest.Location = New System.Drawing.Point(3, 3)
        Me.DtgAllLabTest.Name = "DtgAllLabTest"
        Me.DtgAllLabTest.ReadOnly = True
        Me.DtgAllLabTest.Size = New System.Drawing.Size(898, 336)
        Me.DtgAllLabTest.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ChkAll)
        Me.Panel2.Controls.Add(Me.BtnNewtest)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Cbotestgrp)
        Me.Panel2.Location = New System.Drawing.Point(7, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 42)
        Me.Panel2.TabIndex = 1
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAll.ForeColor = System.Drawing.Color.Black
        Me.ChkAll.Location = New System.Drawing.Point(435, 15)
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
        Me.BtnNewtest.ForeColor = System.Drawing.Color.Navy
        Me.BtnNewtest.Image = CType(resources.GetObject("BtnNewtest.Image"), System.Drawing.Image)
        Me.BtnNewtest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewtest.Location = New System.Drawing.Point(3, 14)
        Me.BtnNewtest.Name = "BtnNewtest"
        Me.BtnNewtest.Size = New System.Drawing.Size(73, 24)
        Me.BtnNewtest.TabIndex = 1
        Me.BtnNewtest.Text = "    NEW"
        Me.BtnNewtest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 18)
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
        Me.Cbotestgrp.Items.AddRange(New Object() {"CHEMICAL PATHOLOGY", "HERMATHOLOGY", "HORMONE", "MICRO BIOLOGY", "HISTOLOGY", "PROFILE"})
        Me.Cbotestgrp.Location = New System.Drawing.Point(187, 14)
        Me.Cbotestgrp.Name = "Cbotestgrp"
        Me.Cbotestgrp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cbotestgrp.Size = New System.Drawing.Size(242, 23)
        Me.Cbotestgrp.TabIndex = 1
        '
        'frmLabTestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 392)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLabTestList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   LABORATORY TEST LIST"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DtgAllLabTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DtgAllLabTest As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Cbotestgrp As ComboBox
    Friend WithEvents BtnNewtest As Button
    Friend WithEvents ChkAll As CheckBox
End Class
