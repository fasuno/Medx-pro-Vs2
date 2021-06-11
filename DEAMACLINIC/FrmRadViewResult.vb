Imports System.Data.SqlClient

Public Class FrmRadViewResult

    Public Sub LoadPatientRadInestigation()

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Investigation, Status, Reported_by FROM RadRequestAndResult  Where Request_Num=@Rqnum", con)
        cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = FrmRadiology.DtgRAdtreated.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtgradinvest.DataSource = tbls
        Dtgradinvest.AutoResizeColumns()

    End Sub

    Private Sub FrmRadViewResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientRadInestigation()
        TxtRadresult.ReadOnly = True
        TxtRadresult.Text = ""
        TxtNote.Text = ""
        TxtNote.ReadOnly = True
    End Sub

    Private Sub Dtgradinvest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgradinvest.CellClick
        cmd = New SqlCommand("Select * from RadRequestAndResult Where Request_Num=@Rqstno AND investigation=@inv", con)
        cmd.Parameters.Add("@Rqstno", SqlDbType.Int).Value = Txtrqstnum.Text
        cmd.Parameters.Add("@inv", SqlDbType.VarChar).Value = Dtgradinvest.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            TxtRadresult.Text = tbl.Rows(0)(19).ToString
            TxtNote.Text = tbl.Rows(0)(20).ToString

            lblinvest.Text = Dtgradinvest.CurrentRow.Cells(0).Value.ToString
            Txtreptby.Text = Dtgradinvest.CurrentRow.Cells(2).Value.ToString

        Else

            MsgBox("NO RESULT FOUND FOR THE SELECTED INVESTIGATION", MsgBoxStyle.Information, "Medx-pro")

        End If

    End Sub


End Class