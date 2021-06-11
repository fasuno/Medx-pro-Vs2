Imports System.Data.SqlClient
Public Class FrmTheartre
    Public Sub LoadSurgery()

        Dim tbls As New DataTable()
        cmd = New SqlCommand("Select * from Surgery_Request WHERE Surgery_Date BETWEEN @datfrom AND @datto And Status='Pending'", con)
        cmd.Parameters.Add("@datfrom", SqlDbType.Date).Value = Dtfrmpend.Value
        cmd.Parameters.Add("@datto", SqlDbType.Date).Value = DttoPend.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbls)

        DtgPend.DataSource = tbls
        DtgPend.AutoResizeColumns()
        DtgPend.Columns(14).Visible = False
        lblcount.Text = DtgPend.RowCount

    End Sub
    Public Sub LoadTreatSurgery()
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from Surgery_Request WHERE Surgery_Date BETWEEN @dfrom AND @dao And Status='Treated'", con)
        cmd.Parameters.Add("@dfrom", SqlDbType.Date).Value = DtfrmTrt.Value
        cmd.Parameters.Add("@dao", SqlDbType.Date).Value = DtToTrt.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        DtgTreat.DataSource = tbl
        DtgTreat.AutoResizeColumns()
        DtgTreat.Columns(14).Visible = False
        lblcount.Text = DtgPend.RowCount
    End Sub
    Private Sub FrmTheartre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '// SET DATETIME TO A PARTICULAR DATE
        Dim dt = DateTime.Now
        Dim startDt = New DateTime(dt.Year, dt.Month, 1)
        Dim EndDt = startDt.AddMonths(1).AddDays(-1)

        Dtfrmpend.Value = startDt
        DttoPend.Value = EndDt
        DtfrmTrt.Value = startDt
        DtToTrt.Value = EndDt

        LoadSurgery()

    End Sub
    Private Sub BtnRelPend_Click(sender As Object, e As EventArgs) Handles BtnRelPend.Click
        LoadSurgery()
        LoadTreatSurgery()
    End Sub
    Private Sub BtnLoadTreat_Click(sender As Object, e As EventArgs) Handles BtnLoadTreat.Click
        LoadTreatSurgery()
    End Sub
    Private Sub DtgPend_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DtgPend.MouseDoubleClick

        FrmSurgery.Lblsurgid.Text = DtgPend.CurrentRow.Cells(0).Value
        FrmSurgery.TxtRqstDate.Text = DtgPend.CurrentRow.Cells(1).Value
        FrmSurgery.TxthospNo.Text = DtgPend.CurrentRow.Cells(3).Value
        FrmSurgery.TxtSurname.Text = DtgPend.CurrentRow.Cells(4).Value
        FrmSurgery.TxtOname.Text = DtgPend.CurrentRow.Cells(5).Value
        FrmSurgery.Txtsex.Text = DtgPend.CurrentRow.Cells(6).Value
        FrmSurgery.TxtAge.Text = DtgPend.CurrentRow.Cells(7).Value
        FrmSurgery.TxtDiag.Text = DtgPend.CurrentRow.Cells(8).Value
        FrmSurgery.TxtOper.Text = DtgPend.CurrentRow.Cells(9).Value
        FrmSurgery.TxtSurgDate.Text = DtgPend.CurrentRow.Cells(10).Value
        FrmSurgery.TxtInstr.Text = DtgPend.CurrentRow.Cells(11).Value
        FrmSurgery.TxtOrdBy.Text = DtgPend.CurrentRow.Cells(12).Value
        FrmSurgery.TxtClinic.Text = DtgPend.CurrentRow.Cells(13).Value
        FrmSurgery.TxtAcct.Text = DtgPend.CurrentRow.Cells(15).Value
        FrmSurgery.TxtAccTyp.Text = DtgPend.CurrentRow.Cells(16).Value

        FrmSurgery.txtpass.ReadOnly = False

        FrmSurgery.ShowDialog()
    End Sub
    Private Sub DtgTreat_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DtgTreat.MouseDoubleClick
        FrmSurgery.TxtRqstDate.Text = DtgTreat.CurrentRow.Cells(1).Value
        FrmSurgery.TxthospNo.Text = DtgTreat.CurrentRow.Cells(3).Value
        FrmSurgery.TxtSurname.Text = DtgTreat.CurrentRow.Cells(4).Value
        FrmSurgery.TxtOname.Text = DtgTreat.CurrentRow.Cells(5).Value
        FrmSurgery.Txtsex.Text = DtgTreat.CurrentRow.Cells(6).Value
        FrmSurgery.TxtAge.Text = DtgTreat.CurrentRow.Cells(7).Value
        FrmSurgery.TxtDiag.Text = DtgTreat.CurrentRow.Cells(8).Value
        FrmSurgery.TxtOper.Text = DtgTreat.CurrentRow.Cells(9).Value
        FrmSurgery.TxtSurgDate.Text = DtgTreat.CurrentRow.Cells(10).Value
        FrmSurgery.TxtInstr.Text = DtgTreat.CurrentRow.Cells(11).Value
        FrmSurgery.TxtOrdBy.Text = DtgTreat.CurrentRow.Cells(12).Value
        FrmSurgery.TxtClinic.Text = DtgTreat.CurrentRow.Cells(13).Value
        FrmSurgery.Lblsurgid.Text = DtgTreat.CurrentRow.Cells(0).Value
        FrmSurgery.TxtAcct.Text = DtgPend.CurrentRow.Cells(15).Value
        FrmSurgery.TxtAccTyp.Text = DtgPend.CurrentRow.Cells(16).Value

        FrmSurgery.PreOpVisit1.BtnUpdate.BringToFront()
        FrmSurgery.PreOpVisit1.BtnSave.Visible = False
        FrmSurgery.PreOpVisit1.Txtpassupd.Visible = True
        FrmSurgery.PreOpVisit1.Label21.Visible = True

        FrmSurgery.txtpass.ReadOnly = False

        FrmSurgery.ShowDialog()
    End Sub
    Private Sub btnserchpend_Click(sender As Object, e As EventArgs) Handles btnserchpend.Click
        Dim tb As New DataTable()
        cmd = New SqlCommand("Select * from Surgery_Request WHERE Hospital_Num=@Hnum", con)
        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = txtserchpend.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tb)

        DtgPend.DataSource = tb
        DtgPend.AutoResizeColumns()
        DtgPend.Columns(14).Visible = False
        lblcount.Text = DtgPend.RowCount
    End Sub
    Private Sub btnsrchtrt_Click(sender As Object, e As EventArgs) Handles btnsrchtrt.Click
        Dim tbla As New DataTable()
        cmd = New SqlCommand("Select * from Surgery_Request WHERE Hospital_Num=@Hno", con)
        cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = txtserchpend.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbla)

        DtgTreat.DataSource = tbla
        DtgTreat.AutoResizeColumns()
        DtgTreat.Columns(14).Visible = False
        lblcount.Text = DtgPend.RowCount
    End Sub
    Private Sub txtfindTrt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfindTrt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtserchpend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtserchpend.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class