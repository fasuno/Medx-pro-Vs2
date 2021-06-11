Imports System.Data.SqlClient

Public Class frmLABORATORY

    Public Sub SortPendlabRqst()

        Dim tbls As New DataTable()
        cmd = New SqlCommand("Select * from Pend_LabRequest WHERE Date BETWEEN @datfrom AND @datto", con)
        ' cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = RqstFrm.Value
        'cmd.Parameters.Add("@datto", SqlDbType.Date).Value = RqstTo.Value
        'cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = cboaccnt.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbls)

        '        DtgPendLabReqst.DataSource = tbls
        '       DtgPendLabReqst.AutoResizeColumns()

        'lblcount.Text = DtgPendLabReqst.RowCount
    End Sub
    Public Sub LoadLAbtestReview()

        Dim tbls As New DataTable()
        cmd = New SqlCommand("Select * from LabTestReview WHERE Date BETWEEN @datfrom AND @datto", con)
        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = datrevfrm.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = datrevto.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbls)

        DtgReview.DataSource = tbls
        DtgReview.AutoResizeColumns()

        'lblcount.Text = DtgPendLabReqst.RowCount
    End Sub
    Public Sub SortPendlabBill()

        Dim btbls As New DataTable()
        cmd = New SqlCommand("Select * from Pend_LabRequest WHERE Date BETWEEN @datefrom AND @dateto", con)
        cmd.Parameters.Add("@datefrom", SqlDbType.Date).Value = dtbillfrom.Value
        cmd.Parameters.Add("@dateto", SqlDbType.Date).Value = dtbillto.Value
        'cmd.Parameters.Add("@Accnt", SqlDbType.VarChar).Value = CboBilled.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(btbls)

        Dtgbiiled.DataSource = btbls
        Dtgbiiled.AutoResizeColumns()

        lblcount.Text = Dtgbiiled.RowCount

    End Sub
    Public Sub SortLAbTreated()

        Dim btbls As New DataTable()
        cmd = New SqlCommand("Select * from LabTreated WHERE Date BETWEEN @datetfrom AND @datetto", con)
        cmd.Parameters.Add("@datetfrom", SqlDbType.Date).Value = DtLabfrm.Value
        cmd.Parameters.Add("@datetto", SqlDbType.Date).Value = DtlabTo.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(btbls)

        DtgLabtrt.DataSource = btbls
        DtgLabtrt.AutoResizeColumns()

        lblcount.Text = DtgLabtrt.RowCount

    End Sub
    Private Sub btnfindRqst_Click(sender As Object, e As EventArgs)

        cmd = New SqlCommand("Select * from Pend_LabRequest where Hospital_No=@Hosp_Num", con)
        '  cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = txtFindRqst.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            '    DtgPendLabReqst.DataSource = tbl

        Else
            MessageBox.Show("LABORATORY RESQUEST(s) NOT FOUND", "LABORATORY", MessageBoxButtons.OK)

        End If

    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs)
        SortPendlabRqst()
    End Sub
    Private Sub DtgPendLabReqst_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'sDim frm As New FrmLabInvRqst

        ' FrmLabInvRqst.Txtrqstid.Text = DtgPendLabReqst.CurrentRow.Cells(0).Value
        ' FrmLabInvRqst.txtdate.Text = DtgPendLabReqst.CurrentRow.Cells(1).Value
        'FrmLabInvRqst.txtHno.Text = DtgPendLabReqst.CurrentRow.Cells(3).Value.ToString
        'F rmLabInvRqst.TxtSname.Text = DtgPendLabReqst.CurrentRow.Cells(4).Value.ToString
        'FrmLabInvRqst.txtOname.Text = DtgPendLabReqst.CurrentRow.Cells(5).Value.ToString
        'FrmLabInvRqst.txtage.Text = DtgPendLabReqst.CurrentRow.Cells(6).Value.ToString
        'FrmLabInvRqst.txtsex.Text = DtgPendLabReqst.CurrentRow.Cells(7).Value.ToString
        'FrmLabInvRqst.txtacct.Text = DtgPendLabReqst.CurrentRow.Cells(8).Value.ToString
        'FrmLabInvRqst.Txtacctcat.Text = DtgPendLabReqst.CurrentRow.Cells(9).Value.ToString
        'FrmLabInvRqst.txtrqstby.Text = DtgPendLabReqst.CurrentRow.Cells(12).Value.ToString

        FrmLabInvRqst.ShowDialog()

    End Sub
    Private Sub Btnrefbill_Click(sender As Object, e As EventArgs) Handles Btnrefbill.Click
        SortPendlabBill()

    End Sub
    Private Sub Dtgbiiled_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgbiiled.CellDoubleClick

        'Dim frms = New frmLabResult

        frmLabResult.lblrqstnum.Text = Dtgbiiled.CurrentRow.Cells(0).Value.ToString
        frmLabResult.txtHnum.Text = Dtgbiiled.CurrentRow.Cells(3).Value.ToString
        frmLabResult.TxtSname.Text = Dtgbiiled.CurrentRow.Cells(4).Value.ToString
        frmLabResult.txtOname.Text = Dtgbiiled.CurrentRow.Cells(5).Value.ToString
        frmLabResult.txtsex.Text = Dtgbiiled.CurrentRow.Cells(7).Value.ToString
        frmLabResult.txtage.Text = Dtgbiiled.CurrentRow.Cells(6).Value.ToString
        frmLabResult.txtacct.Text = Dtgbiiled.CurrentRow.Cells(8).Value.ToString
        frmLabResult.Txtactcat.Text = Dtgbiiled.CurrentRow.Cells(9).Value.ToString
        frmLabResult.TxtRqstdate.Text = Dtgbiiled.CurrentRow.Cells(1).Value
        frmLabResult.txtRqstby.Text = Dtgbiiled.CurrentRow.Cells(12).Value.ToString

        '// Load Test and Notes
        frmLabResult.LoadPatientTest()
        frmLabResult.LoadNotes()

        frmLabResult.ShowDialog()

    End Sub
    Private Sub frmLABORATORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  SortPendlabRqst()

        SortPendlabBill()

        LoadLAbtestReview()

        SortLAbTreated()
    End Sub
    Private Sub BtnLoadRevw_Click(sender As Object, e As EventArgs) Handles BtnLoadRevw.Click
        LoadLAbtestReview()
    End Sub
    Private Sub DtgReview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgReview.CellDoubleClick

        ' Dim fom As New frmLabResult

        frmLabResult.lblrqstnum.Text = DtgReview.CurrentRow.Cells(0).Value.ToString
        frmLabResult.txtHnum.Text = DtgReview.CurrentRow.Cells(3).Value.ToString
        frmLabResult.TxtSname.Text = DtgReview.CurrentRow.Cells(4).Value.ToString
        frmLabResult.txtOname.Text = DtgReview.CurrentRow.Cells(5).Value.ToString
        frmLabResult.txtage.Text = DtgReview.CurrentRow.Cells(6).Value.ToString
        frmLabResult.txtsex.Text = DtgReview.CurrentRow.Cells(7).Value.ToString
        frmLabResult.txtacct.Text = DtgReview.CurrentRow.Cells(8).Value.ToString
        frmLabResult.Txtactcat.Text = DtgReview.CurrentRow.Cells(9).Value.ToString
        frmLabResult.txtRqstby.Text = DtgReview.CurrentRow.Cells(10).Value.ToString
        frmLabResult.TxtRqstdate.Text = DtgReview.CurrentRow.Cells(11).Value
        frmLabResult.lblreportby.Text = DtgReview.CurrentRow.Cells(12).Value.ToString

        frmLabResult.BtnReview.BringToFront()
        frmLabResult.BtnReview.Enabled = True
        frmLabResult.txtpwordrev.BringToFront()
        frmLabResult.txtpwordrev.Enabled = True

        frmLabResult.chkcompl.Enabled = False

        frmLabResult.ShowDialog()
    End Sub
    Private Sub BtnLoadTreat_Click(sender As Object, e As EventArgs) Handles BtnLoadTreat.Click
        SortLAbTreated()
    End Sub
    Private Sub btnsrchtreat_Click(sender As Object, e As EventArgs) Handles btnsrchtreat.Click

        cmd = New SqlCommand("Select * from LabTreated where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = txttreatlab.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            DtgLabtrt.DataSource = tbl
            DtgLabtrt.AutoResizeColumns()

        Else
            MessageBox.Show("RESULT NOT FOUND! CHECK OTHER STATUS", "LABORATORY", MessageBoxButtons.OK)

        End If

    End Sub
    Private Sub DtgLabtrt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgLabtrt.CellDoubleClick
        ' Dim fomr = New frmLabResult
        frmLabResult.lblrqstnum.Text = DtgLabtrt.CurrentRow.Cells(0).Value.ToString
        frmLabResult.txtHnum.Text = DtgLabtrt.CurrentRow.Cells(3).Value.ToString
        frmLabResult.TxtSname.Text = DtgLabtrt.CurrentRow.Cells(4).Value.ToString
        frmLabResult.txtOname.Text = DtgLabtrt.CurrentRow.Cells(5).Value.ToString
        frmLabResult.txtsex.Text = DtgLabtrt.CurrentRow.Cells(7).Value.ToString
        frmLabResult.txtage.Text = DtgLabtrt.CurrentRow.Cells(6).Value.ToString
        frmLabResult.txtacct.Text = DtgLabtrt.CurrentRow.Cells(8).Value.ToString
        frmLabResult.Txtactcat.Text = DtgLabtrt.CurrentRow.Cells(9).Value.ToString
        frmLabResult.TxtRqstdate.Text = DtgLabtrt.CurrentRow.Cells(11).Value
        frmLabResult.txtRqstby.Text = DtgLabtrt.CurrentRow.Cells(10).Value.ToString
        frmLabResult.lblreportby.Text = DtgLabtrt.CurrentRow.Cells(12).Value.ToString

        frmLabResult.BtnReview.Enabled = False
        frmLabResult.btnsave.Enabled = False
        frmLabResult.txtpassw.Enabled = False
        frmLabResult.txtpwordrev.Enabled = False
        frmLabResult.Dtgresults.ReadOnly = True

        frmLabResult.chkcompl.Enabled = False

        frmLabResult.ShowDialog()
    End Sub

    Private Sub btnfindbill_Click(sender As Object, e As EventArgs) Handles btnfindbill.Click

        cmd = New SqlCommand("Select * FROM Pend_LabRequest where Hospital_No=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = txtfindbill.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgbiiled.DataSource = tbl
            Dtgbiiled.AutoResizeColumns()

        Else
            MessageBox.Show("LAB REQUEST NOT FOUND! CHECK OTHER STATUS", "Medx-pro", MessageBoxButtons.OK)

        End If

    End Sub

End Class