Imports System.Data.SqlClient
Public Class AdmissionHX

    Public Sub LoadAdmitHx()
        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * FROM AdmissionHX WHERE Hospital_Num = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        DtgAdmt.DataSource = tbl
        DtgAdmt.AutoResizeColumns()
        DtgAdmt.Columns(0).Visible = False
        DtgAdmt.Columns(1).Visible = False
        DtgAdmt.Columns(2).Visible = False
        DtgAdmt.Columns(10).Visible = False

    End Sub

    Private Sub DtgAdmt_MouseClick(sender As Object, e As MouseEventArgs) Handles DtgAdmt.MouseClick

        FrmAdmitFolder.Lblhospnum.Text = FrmPtRecords.Lblhopnum.Text
        FrmAdmitFolder.LbladmitID.Text = DtgAdmt.CurrentRow.Cells(0).Value
        FrmAdmitFolder.Lblsex.Text = DtgAdmt.CurrentRow.Cells(1).Value
        FrmAdmitFolder.Lblage.Text = DtgAdmt.CurrentRow.Cells(2).Value
        FrmAdmitFolder.Lbldiag.Text = DtgAdmt.CurrentRow.Cells(4).Value


        FrmAdmitFolder.NurseReport1.Btnclear.Visible = False
        FrmAdmitFolder.NurseReport1.Btnedit.Visible = False
        FrmAdmitFolder.NurseReport1.Btnsave.Visible = False
        FrmAdmitFolder.NurseReport1.Txtpass.Visible = False
        FrmAdmitFolder.NurseReport1.Label6.Visible = False

        FrmAdmitFolder.RoundNotes1.Btnsave.Visible = False
        FrmAdmitFolder.RoundNotes1.Btnclear.Visible = False
        FrmAdmitFolder.RoundNotes1.BtnSaveSum.Visible = False
        FrmAdmitFolder.RoundNotes1.Txtpass.Visible = False
        FrmAdmitFolder.RoundNotes1.TxtPassword.Visible = False
        FrmAdmitFolder.RoundNotes1.Label2.Visible = False

        FrmAdmitFolder.Nursinghx1.Btnsave.Visible = False
        FrmAdmitFolder.Nursinghx1.Txtpassw.Visible = False
        FrmAdmitFolder.Nursinghx1.Label33.Visible = False


        FrmAdmitFolder.CarePlan1.Btnsave.Visible = False
        FrmAdmitFolder.CarePlan1.Btnclear.Visible = False
        FrmAdmitFolder.CarePlan1.Btnedit.Visible = False
        FrmAdmitFolder.CarePlan1.Txtpass.Visible = False
        FrmAdmitFolder.CarePlan1.Label6.Visible = False

        FrmAdmitFolder.InpatientRadHx1.Btnnew.Visible = False
        FrmAdmitFolder.InpatientDrugsHx1.Btnnew.Visible = False
        FrmAdmitFolder.InpatientLabHx1.Btnnew.Visible = False
        FrmAdmitFolder.InpatientConslt1.BtnNewcons.Visible = False


        FrmAdmitFolder.TreatmentChart1.BtnSave.Visible = False
        FrmAdmitFolder.TreatmentChart1.Txtnurse.Visible = False
        FrmAdmitFolder.TreatmentChart1.Label4.Visible = False
        FrmAdmitFolder.ObservChart1.BtnSave.Visible = False
        FrmAdmitFolder.ObservChart1.BtnCls.Visible = False
        FrmAdmitFolder.ObservChart1.Txtpass.Visible = False
        FrmAdmitFolder.ObservChart1.Label5.Visible = False

        FrmAdmitFolder.LoadProfile()
        FrmAdmitFolder.ShowDialog()
    End Sub


End Class
