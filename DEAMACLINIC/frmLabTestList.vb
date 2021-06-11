Imports System.Data.SqlClient

Public Class frmLabTestList

    Public Sub LoadAllTestLIst()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * FROM LAB_LIST ", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgAllLabTest.DataSource = tbl
        DtgAllLabTest.AutoResizeColumns()

    End Sub

    Private Sub frmLabTestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllTestLIst()
    End Sub

    Private Sub DtgAllLabTest_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgAllLabTest.CellDoubleClick
        'Dim frms = New FrmNewLabTest

        FrmNewLabTest.TxtTest.Text = DtgAllLabTest.CurrentRow.Cells(0).Value.ToString
        FrmNewLabTest.Cbogroup.Text = DtgAllLabTest.CurrentRow.Cells(1).Value.ToString
        FrmNewLabTest.TxtMeasure.Text = DtgAllLabTest.CurrentRow.Cells(5).Value.ToString
        FrmNewLabTest.TxtPrivCost.Text = DtgAllLabTest.CurrentRow.Cells(2).Value.ToString
        FrmNewLabTest.TxtNhisCost.Text = DtgAllLabTest.CurrentRow.Cells(3).Value.ToString
        FrmNewLabTest.TxtCompCost.Text = DtgAllLabTest.CurrentRow.Cells(4).Value.ToString


        'FrmNewLabTest.BtnSavetest.Enabled 

        FrmNewLabTest.Btnedit.BringToFront()
        FrmNewLabTest.ShowDialog()

    End Sub

    Private Sub BtnNewtest_Click_1(sender As Object, e As EventArgs) Handles BtnNewtest.Click
        'Dim frmn = New FrmNewLabTest

        FrmNewLabTest.TxtCompCost.Text = ""
        FrmNewLabTest.TxtMeasure.Text = ""
        FrmNewLabTest.TxtNhisCost.Text = ""
        FrmNewLabTest.TxtPrivCost.Text = ""
        FrmNewLabTest.TxtTest.Text = ""
        FrmNewLabTest.TxtCompCost.Text = ""
        FrmNewLabTest.Cbogroup.Text = ""
        FrmNewLabTest.Btnedit.Enabled = True
        FrmNewLabTest.BtnSavetest.BringToFront()

        FrmNewLabTest.ShowDialog()

    End Sub

    Public Sub SearchByGroup()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * FROM LAB_LIST where GROUPS=@grp ", con)

        cmd.Parameters.Add("@grp", SqlDbType.VarChar).Value = Cbotestgrp.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgAllLabTest.DataSource = tbl
        DtgAllLabTest.AutoResizeColumns()


    End Sub

    Private Sub Cbotestgrp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbotestgrp.SelectedIndexChanged
        SearchByGroup()
    End Sub

    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged
        LoadAllTestLIst()

    End Sub


End Class