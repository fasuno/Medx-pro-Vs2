Imports System.Data.SqlClient

Public Class FrmRefer

    Public Sub PopulateCboDOCTOR()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Full_Name from UsersReg WHERE Role='MEDICAL DOCTOR'", con)


        adapt = New SqlDataAdapter(cmd)

        con.Open()   ' Open connection

        adapt.Fill(tbl)
        CboDoc.DataSource = tbl
        CboDoc.DisplayMember = "Full_Name"


        con.Close()

    End Sub
    Sub showDOCID()

        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Full_Name=@user", con)
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = CboDoc.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then
            LblDocid.Text = tbl.Rows(0)(0).ToString

        End If

    End Sub
    Private Sub FrmRefer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateCboDOCTOR()
        CboDoc.SelectedItem = Nothing
    End Sub
    Private Sub CboDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDoc.SelectedIndexChanged
        showDOCID()
    End Sub
    Public Sub Populatewaitinglist()

        Try

            cmd = New SqlCommand("INSERT INTO Pend_WaitingList VALUES(@Dtse, @time, @Snm, @Onm, @hnu, @Age, @Sxx, @Act, @Acat, @Bps, @Tmpr, @Pls, @Whgt, @hght, @Resp, @Cli, @Docx, @Rmm, @Snt, @Doid)", con)

            cmd.Parameters.Add("@Dtse", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
            cmd.Parameters.Add("@time", SqlDbType.VarChar).Value = frmMain.lbltime.Text
            cmd.Parameters.Add("@snm", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
            cmd.Parameters.Add("@onm", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
            cmd.Parameters.Add("@hnu", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
            cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
            cmd.Parameters.Add("@Sxx", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
            cmd.Parameters.Add("@Act", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtaccount.Text
            cmd.Parameters.Add("@Acat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
            cmd.Parameters.Add("@Bps", SqlDbType.NVarChar).Value = FrmPtRecords.Txtbp.Text
            cmd.Parameters.Add("@Tmpr", SqlDbType.NVarChar).Value = FrmPtRecords.txttemp.Text
            cmd.Parameters.Add("@Pls", SqlDbType.VarChar).Value = FrmPtRecords.txtpulse.Text
            cmd.Parameters.Add("@Whgt", SqlDbType.VarChar).Value = FrmPtRecords.txtweight.Text
            cmd.Parameters.Add("@hght", SqlDbType.VarChar).Value = FrmPtRecords.txtheight.Text
            cmd.Parameters.Add("@Resp", SqlDbType.VarChar).Value = FrmPtRecords.txtresp.Text
            cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = Cboclinic.Text
            cmd.Parameters.Add("@Docx", SqlDbType.VarChar).Value = CboDoc.Text
            cmd.Parameters.Add("@Rmm", SqlDbType.VarChar).Value = DBNull.Value
            cmd.Parameters.Add("@Snt", SqlDbType.VarChar).Value = lbluser.Text
            cmd.Parameters.Add("@Doid", SqlDbType.VarChar).Value = LblDocid.Text

            MsgBox("PATIENT REFERED SUCCESSFULY", MsgBoxStyle.OkOnly, "Medx-pro")

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lbluser.Text = tbl.Rows(0)(1).ToString()

        Else
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            Txtpass.Focus()

        End If

    End Sub
    Private Sub BtnRefer_Click(sender As Object, e As EventArgs) Handles BtnRefer.Click
        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            Txtpass.Focus()
        Else
            Populatewaitinglist()
            FrmMywaitinglist.LoadDocPendLIst()
        End If
        Me.Close()
    End Sub
    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        showusername()
    End Sub

End Class