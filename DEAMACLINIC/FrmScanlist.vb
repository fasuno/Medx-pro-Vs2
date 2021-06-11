Imports System.Data.SqlClient
Public Class FrmScanlist
    Public Sub LoadsCANLIst()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select INVESTIGATION, GROUPS, COST FROM Xray_ScanList ", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgRadlist.DataSource = tbl
        DtgRadlist.AutoResizeColumns()

    End Sub

    Public Sub SearchByGroup()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select INVESTIGATION, GROUPS, COST FROM Xray_ScanList where GROUPS=@grp ", con)

        cmd.Parameters.Add("@grp", SqlDbType.VarChar).Value = Cbotestgrp.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgRadlist.DataSource = tbl
        DtgRadlist.AutoResizeColumns()


    End Sub

    Private Sub FrmScanlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadsCANLIst()
    End Sub

    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged
        LoadsCANLIst()
    End Sub

    Private Sub Cbotestgrp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbotestgrp.SelectedIndexChanged
        SearchByGroup()
    End Sub

    Private Sub DtgRadlist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgRadlist.CellDoubleClick
        FrmNewRadInv.TxtTest.Text = DtgRadlist.CurrentRow.Cells(0).Value.ToString
        FrmNewRadInv.Cbogroup.Text = DtgRadlist.CurrentRow.Cells(1).Value.ToString
        FrmNewRadInv.TxtPrivCost.Text = DtgRadlist.CurrentRow.Cells(2).Value.ToString

        FrmNewRadInv.Btnedit.BringToFront()
        FrmNewRadInv.ShowDialog()
    End Sub

    Private Sub BtnNewtest_Click(sender As Object, e As EventArgs) Handles BtnNewtest.Click
        FrmNewRadInv.TxtTest.Text = ""
        FrmNewRadInv.Cbogroup.Text = ""
        FrmNewRadInv.TxtPrivCost.Text = ""

        FrmNewRadInv.BtnSavetest.BringToFront()
        FrmNewRadInv.ShowDialog()
    End Sub

End Class