Imports System.Data.SqlClient

Public Class PtRadHist
    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles Btnnew.Click
        FrmRadrequest.LoadRAdlist()
        FrmRadrequest.ShowDialog()
    End Sub

    Public Sub LoadRAdilogicalHx()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_NUm, Date_Requested, Requested_by, Date_Reported from vwRadRequestAndResult WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Me.DtgRadHx.DataSource = tbl

    End Sub

    Private Sub PtRadHist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LoadRAdilogicalHx()
    End Sub

    Private Sub DtgRadHx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgRadHx.CellDoubleClick

        FrmRadTreatResult.TxtRqstdate.Text = DtgRadHx.CurrentRow.Cells(1).Value
        FrmRadTreatResult.txtRqstby.Text = DtgRadHx.CurrentRow.Cells(2).Value.ToString

        FrmRadTreatResult.Lblrqstnum.Text = FrmPtRecords.PtRadHist1.DtgRadHx.CurrentRow.Cells(0).Value

        FrmRadTreatResult.LoadPatientRadInestigation()
        FrmRadTreatResult.ShowDialog()
    End Sub


End Class
