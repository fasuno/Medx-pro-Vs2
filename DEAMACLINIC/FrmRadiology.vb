Imports System.Data.SqlClient

Public Class FrmRadiology

    Public Sub SortPendRadRqst()

        Dim tbls As New DataTable()
        cmd = New SqlCommand("Select * from Pend_RadRequest WHERE Date BETWEEN @datetfrom AND @datetto", con)
        '  cmd.Parameters.Add("@datetfrom", SqlDbType.Date).Value = DateFrm.Value
        ' cmd.Parameters.Add("@datetto", SqlDbType.Date).Value = DateTo.Value
        ' cmd.Parameters.Add("@Accnt", SqlDbType.VarChar).Value = CboAcct.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbls)

        'Dtgpendrad.DataSource = tbls
        'Dtgpendrad.AutoResizeColumns()

        lblrec.Text = DtgRadBilled.RowCount
    End Sub

    Public Sub SortPendRADBill()

        Dim btbls As New DataTable()
        cmd = New SqlCommand("Select * from Pend_RadRequest WHERE Date BETWEEN @datefrom AND @dateto", con)
        cmd.Parameters.Add("@datefrom", SqlDbType.Date).Value = Datebillfrm.Value
        cmd.Parameters.Add("@dateto", SqlDbType.Date).Value = DatebillTo.Value
        ' cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = Cboacctbill.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(btbls)

        DtgRadBilled.DataSource = btbls
        DtgRadBilled.AutoResizeColumns()

        lblrec.Text = DtgRadBilled.RowCount

    End Sub

    Private Sub DtgRAdtreated_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgRAdtreated.CellDoubleClick

        '  Dim frms = New FrmRadViewResult

        FrmRadViewResult.Txtrqstnum.Text = DtgRAdtreated.CurrentRow.Cells(0).Value.ToString
        FrmRadViewResult.txtHnum.Text = DtgRAdtreated.CurrentRow.Cells(2).Value.ToString
        FrmRadViewResult.TxtSname.Text = DtgRAdtreated.CurrentRow.Cells(3).Value.ToString
        FrmRadViewResult.txtOname.Text = DtgRAdtreated.CurrentRow.Cells(4).Value.ToString
        FrmRadViewResult.txtsex.Text = DtgRAdtreated.CurrentRow.Cells(6).Value.ToString
        FrmRadViewResult.txtage.Text = DtgRAdtreated.CurrentRow.Cells(5).Value.ToString
        FrmRadViewResult.txtacct.Text = DtgRAdtreated.CurrentRow.Cells(7).Value.ToString
        FrmRadViewResult.TxtRptdate.Text = DtgRAdtreated.CurrentRow.Cells(9).Value
        FrmRadViewResult.txtrqstdate.Text = DtgRAdtreated.CurrentRow.Cells(1).Value
        FrmRadViewResult.txtRqstby.Text = DtgRAdtreated.CurrentRow.Cells(8).Value.ToString

        FrmRadViewResult.ShowDialog()

    End Sub

    Public Sub SortTreatedList()

        Dim mtbls As New DataTable()

        cmd = New SqlCommand("Select DISTINCT Request_NUm, Date_Requested, Hospital_No, Surname, Other_Name, Age, Sex, Account, Requested_by, Date_Reported, Report_Status from VwRADResult WHERE Date_Reported BETWEEN @Tdatefrom AND @Tdateto ", con)
        cmd.Parameters.Add("@Tdatefrom", SqlDbType.Date).Value = DateTrtdFrom.Value
        cmd.Parameters.Add("@Tdateto", SqlDbType.Date).Value = DateTrtdTo.Value
        ' cmd.Parameters.Add("@Accnt", SqlDbType.VarChar).Value = CboacctTrtd.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(mtbls)

        DtgRAdtreated.DataSource = mtbls
        DtgRAdtreated.AutoResizeColumns()

        lblrec.Text = DtgRAdtreated.RowCount

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs)

        cmd = New SqlCommand("Select * from Pend_RadRequest where Hospital_No=@Hosp_Num", con)
        ' cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = Txtfinrad.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            '    Dtgpendrad.DataSource = tbl

        Else
            MessageBox.Show("NO PENDING REQUEST(s) FOUND", "Medx-pro", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs)
        SortPendRadRqst()
    End Sub

    Private Sub Dtgpendrad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Dim frm = New FrmRadInv

        '   FrmRadInv.Txtrqstid.Text = Dtgpendrad.CurrentRow.Cells(0).Value
        '  FrmRadInv.txtdate.Text = Dtgpendrad.CurrentRow.Cells(1).Value
        '' FrmRadInv.txtHno.Text = Dtgpendrad.CurrentRow.Cells(3).Value.ToString
        '  FrmRadInv.TxtSname.Text = Dtgpendrad.CurrentRow.Cells(4).Value.ToString
        '  FrmRadInv.txtOname.Text = Dtgpendrad.CurrentRow.Cells(5).Value.ToString
        ' FrmRadInv.txtage.Text = Dtgpendrad.CurrentRow.Cells(6).Value.ToString
        ' FrmRadInv.txtsex.Text = Dtgpendrad.CurrentRow.Cells(7).Value.ToString
        ' FrmRadInv.txtacct.Text = Dtgpendrad.CurrentRow.Cells(8).Value.ToString
        ' FrmRadInv.Txtactcat.Text = Dtgpendrad.CurrentRow.Cells(9).Value.ToString
        'FrmRadInv.txtrqstby.Text = Dtgpendrad.CurrentRow.Cells(12).Value.ToString

        FrmRadInv.ShowDialog()
    End Sub

    Private Sub Btnfindbill_Click(sender As Object, e As EventArgs) Handles Btnfindbill.Click

        cmd = New SqlCommand("Select * from Pend_RadRequest where Hospital_Num=@Hospt_Num", con)
        cmd.Parameters.Add("Hospt_Num", SqlDbType.VarChar).Value = TxtfindBill.Text

        adapt = New SqlDataAdapter(cmd)
        Dim ntbl As New DataTable

        adapt.Fill(ntbl)
        If ntbl.Rows.Count() > 0 Then
            DtgRadBilled.DataSource = ntbl

        Else
            MessageBox.Show("NO RESQUEST(s) FOUND", "Medx-pro", MessageBoxButtons.OK)


            lblrec.Text = DtgRadBilled.RowCount

        End If

    End Sub

    Private Sub RefBill_Click(sender As Object, e As EventArgs) Handles RefBill.Click
        SortPendRADBill()
    End Sub

    Private Sub DtgRadBilled_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgRadBilled.CellDoubleClick
        'Dim frms = New frmRADResult

        frmRADResult.Lblrqstnum.Text = DtgRadBilled.CurrentRow.Cells(0).Value.ToString
        frmRADResult.txtHnum.Text = DtgRadBilled.CurrentRow.Cells(3).Value.ToString
        frmRADResult.TxtSname.Text = DtgRadBilled.CurrentRow.Cells(4).Value.ToString
        frmRADResult.txtOname.Text = DtgRadBilled.CurrentRow.Cells(5).Value.ToString
        frmRADResult.txtsex.Text = DtgRadBilled.CurrentRow.Cells(7).Value.ToString
        frmRADResult.txtage.Text = DtgRadBilled.CurrentRow.Cells(6).Value.ToString
        frmRADResult.txtacct.Text = DtgRadBilled.CurrentRow.Cells(8).Value.ToString
        frmRADResult.Txtactcat.Text = DtgRadBilled.CurrentRow.Cells(9).Value.ToString
        frmRADResult.TxtRqstdate.Text = DtgRadBilled.CurrentRow.Cells(1).Value
        frmRADResult.txtRqstby.Text = DtgRadBilled.CurrentRow.Cells(12).Value.ToString



        frmRADResult.ShowDialog()

    End Sub

    Private Sub BtnRefTrtd_Click(sender As Object, e As EventArgs) Handles BtnRefTrtd.Click
        SortTreatedList()

    End Sub

    Private Sub Btnsearchtrtd_Click(sender As Object, e As EventArgs) Handles Btnsearchtrtd.Click

        cmd = New SqlCommand("Select Request_Num, Date_Requested, Hospital_No, Surname, Other_Name, Age, Sex, Account, Requested_by, Date_Reported, Report_Status From VwRADResult where Hospital_No=@H_Num", con)
        cmd.Parameters.Add("@H_Num", SqlDbType.VarChar).Value = TxtfindTrtd.Text

        adapt = New SqlDataAdapter(cmd)
        Dim ftbl As New DataTable

        adapt.Fill(ftbl)
        If ftbl.Rows.Count() > 0 Then
            DtgRAdtreated.DataSource = ftbl
            TxtfindTrtd.Text = ""
        Else
            MessageBox.Show("NO RADIOLOGY RESULT FOUND", "Medx-pro", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub FrmRadiology_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    SortPendRadRqst()
        SortPendRADBill()
        SortTreatedList()
    End Sub


End Class