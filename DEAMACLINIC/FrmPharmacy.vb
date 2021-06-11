
Imports System.Data.SqlClient

Public Class FrmPharmacy

    Public Sub LoadALL()

        Dim tbls As New DataTable()
        cmd = New SqlCommand("Select * from Pend_DrugPresc", con)


        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbls)

        DtgPendDrugrqst.DataSource = tbls
        DtgPendDrugrqst.AutoResizeColumns()
    End Sub

    Public Sub SortPendlist()

        Dim tbls As New DataTable()
        cmd = New SqlCommand("Select * from Pend_DrugPresc WHERE Date BETWEEN @datfrom AND @datto", con)
        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = RqstFrm.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = RqstTo.Value
        ' cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = cboacct.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbls)

        DtgPendDrugrqst.DataSource = tbls
        DtgPendDrugrqst.AutoResizeColumns()

        Label2.Text = DtgPendDrugrqst.RowCount
    End Sub

    Public Sub SortTreatedlist()

        Dim tbls As New DataTable()
        cmd = New SqlCommand("Select * from Treated_Pharm WHERE Date BETWEEN @datfrom AND @datto", con)
        '  cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = Dttreat.Value
        ' cmd.Parameters.Add("@datto", SqlDbType.Date).Value = DttreatTo.Value
        ' cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = cboacct.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbls)

        'dtgTreatrqst.DataSource = tbls
        'dtgTreatrqst.AutoResizeColumns()

        'Label2.Text = dtgTreatrqst.RowCount
    End Sub

    Public Sub SortBiiled()

        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select Presc_num, Date, Hospital_num, Surname, Other_names, Age, Sex, Account_type, Account_Category, Total_cost, Billed_by, Payment_Status, Prescribed_By FROM PharmPend_Bill WHERE Date BETWEEN @dtfrom AND @dtto", con)
        cmd.Parameters.Add("@dtfrom", SqlDbType.Date).Value = dtbillfrom.Value
        cmd.Parameters.Add("@dtto", SqlDbType.Date).Value = dtbillto.Value
        ' cmd.Parameters.Add("@Accnt", SqlDbType.VarChar).Value = CboBilled.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        Dtgbiiled.DataSource = tbl
        Dtgbiiled.AutoResizeColumns()

        Label2.Text = Dtgbiiled.RowCount
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        SortPendlist()
    End Sub

    Private Sub btnfindRqst_Click(sender As Object, e As EventArgs) Handles btnfindRqst.Click

        cmd = New SqlCommand("Select * from Pend_DrugPresc where Hospital_No=@Hospi_Num", con)
        cmd.Parameters.Add("Hospi_Num", SqlDbType.VarChar).Value = txtFindRqst.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            DtgPendDrugrqst.DataSource = tbl
            DtgPendDrugrqst.AutoResizeColumns()
        Else
            MessageBox.Show("DRUG RESQUEST(s) NOT FOUND", "PHARMACY", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub DtgPendDrugrqst_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgPendDrugrqst.CellDoubleClick
        Dim frm As New FrmPTdrugs

        FrmPTdrugs.txtpresnum.Text = DtgPendDrugrqst.CurrentRow.Cells(0).Value.ToString
        FrmPTdrugs.TxtSname.Text = DtgPendDrugrqst.CurrentRow.Cells(4).Value.ToString
        FrmPTdrugs.txtdate.Text = DtgPendDrugrqst.CurrentRow.Cells(1).Value
        FrmPTdrugs.txtHno.Text = DtgPendDrugrqst.CurrentRow.Cells(3).Value.ToString
        FrmPTdrugs.txtOname.Text = DtgPendDrugrqst.CurrentRow.Cells(5).Value.ToString
        FrmPTdrugs.txtage.Text = DtgPendDrugrqst.CurrentRow.Cells(6).Value.ToString
        FrmPTdrugs.txtsex.Text = DtgPendDrugrqst.CurrentRow.Cells(7).Value.ToString
        FrmPTdrugs.txtacct.Text = DtgPendDrugrqst.CurrentRow.Cells(8).Value.ToString
        FrmPTdrugs.Txtacctcat.Text = DtgPendDrugrqst.CurrentRow.Cells(9).Value.ToString
        FrmPTdrugs.txtprescby.Text = DtgPendDrugrqst.CurrentRow.Cells(12).Value.ToString


        FrmPTdrugs.ShowDrugsDetails()

        FrmPTdrugs.ShowDialog()

    End Sub

    Private Sub Btnrefbill_Click(sender As Object, e As EventArgs) Handles Btnrefbill.Click
        SortBiiled()
    End Sub

    Private Sub Dtgbiiled_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgbiiled.CellDoubleClick
        'Dim frms = New FrmDrugsbill

        FrmDrugsbill.lblrqstid.Text = Dtgbiiled.CurrentRow.Cells(0).Value.ToString
        FrmDrugsbill.TxtSurname.Text = Dtgbiiled.CurrentRow.Cells(3).Value.ToString
        FrmDrugsbill.txtOthername.Text = Dtgbiiled.CurrentRow.Cells(4).Value.ToString
        FrmDrugsbill.txtdatebill.Text = Dtgbiiled.CurrentRow.Cells(1).Value
        FrmDrugsbill.txtHnum.Text = Dtgbiiled.CurrentRow.Cells(2).Value.ToString
        FrmDrugsbill.txtbilledby.Text = Dtgbiiled.CurrentRow.Cells(10).Value.ToString
        FrmDrugsbill.txtage.Text = Dtgbiiled.CurrentRow.Cells(5).Value.ToString
        FrmDrugsbill.txtsex.Text = Dtgbiiled.CurrentRow.Cells(6).Value.ToString
        FrmDrugsbill.txtaccnt.Text = Dtgbiiled.CurrentRow.Cells(7).Value.ToString
        FrmDrugsbill.Txtacctcat.Text = Dtgbiiled.CurrentRow.Cells(8).Value.ToString
        FrmDrugsbill.LblTotalcost.Text = Dtgbiiled.CurrentRow.Cells(9).Value.ToString
        FrmDrugsbill.LblPaymentstatus.Text = Dtgbiiled.CurrentRow.Cells(11).Value.ToString
        FrmDrugsbill.txtpresby.Text = Dtgbiiled.CurrentRow.Cells(12).Value.ToString

        FrmDrugsbill.txtpword.Text = ""

        FrmDrugsbill.ShowDialog()
    End Sub

    Private Sub FrmPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = frmMain
        ' Loadit()
        SortPendlist()
        SortBiiled()
        'SortTreatedlist()
    End Sub

    Private Sub chkAllRqst_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllRqst.CheckedChanged
        If chkAllRqst.Checked Then
            LoadALL()

        End If
    End Sub

    Private Sub btnrloadtrtd_Click(sender As Object, e As EventArgs)
        SortTreatedlist()
    End Sub

    Private Sub btnfindbill_Click(sender As Object, e As EventArgs) Handles btnfindbill.Click
        cmd = New SqlCommand("Select Presc_num, Date, Hospital_num, Surname, Other_names, Age, Sex, Account_type, Account_Category, Total_cost, Billed_by, Payment_Status, Prescribed_By FROM PharmPend_Bill WHERE Hospital_Num=@Hos_Num", con)
        ' cmd.Parameters.Add("@dtfrom", SqlDbType.Date).Value = dtbillfrom.Value
        cmd.Parameters.Add("@Hos_Num", SqlDbType.VarChar).Value = txtfindbill.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgbiiled.DataSource = tbl
            Dtgbiiled.AutoResizeColumns()
        Else
            MessageBox.Show("PATIENT DISPENSED DRUGS(s) NOT FOUND", "Medx-pro", MessageBoxButtons.OK)

        End If
    End Sub

End Class