Imports System.Data.SqlClient

Public Class Nursinghx

    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            TxtNurse.Text = tbl.Rows(0)(1).ToString()

        Else

        End If

    End Sub

    Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            TxtNurse.Focus()
        Else

        End If
    End Sub

    Private Sub Txtpassw_Leave(sender As Object, e As EventArgs) Handles Txtpassw.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If Txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            TxtNurse.Focus()

        ElseIf Txtconsultant.Text = "" Then
            MsgBox("PLEASE ENTER THE CONSULTANT IN CHARGE", MsgBoxStyle.Information, "Medx-pro")
            Txtconsultant.Focus()

        Else

            Try

                cmd = New SqlCommand("INSERT INTO NursingHx VALUES(@Dte, @Tim, @hnum, @AdmId, @Cons, @Pmed, @PrMed, @Nutr, @Elim, @Act, @Sle, @Comm, @Fel, @Fam, @Sexl, @Cop, @Val, @Immu, @Other, @Infor, @Temp, @Bp, @Pul, @Resp, @Hgt, @Wght, @Apex, @Palp, @Ausc, @Urin, @Perc, @Gen, @Lab, @Diag, @Nurs)", con)

                cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                cmd.Parameters.Add("@Tim", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                cmd.Parameters.Add("@AdmId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                cmd.Parameters.Add("@Cons", SqlDbType.VarChar).Value = Txtconsultant.Text
                cmd.Parameters.Add("@Pmed", SqlDbType.NVarChar).Value = TxtPastMedHx.Text
                cmd.Parameters.Add("@Prmed", SqlDbType.NVarChar).Value = TxtPresMedHx.Text
                cmd.Parameters.Add("@Nutr", SqlDbType.NVarChar).Value = TxtNutri.Text
                cmd.Parameters.Add("@Elim", SqlDbType.VarChar).Value = TxtElim.Text
                cmd.Parameters.Add("@Act", SqlDbType.VarChar).Value = TxtActivity.Text
                cmd.Parameters.Add("@Sle", SqlDbType.VarChar).Value = TxtSleep.Text
                cmd.Parameters.Add("@Comm", SqlDbType.VarChar).Value = TxtComm.Text
                cmd.Parameters.Add("@Fel", SqlDbType.VarChar).Value = TxtFeeling.Text
                cmd.Parameters.Add("@Fam", SqlDbType.VarChar).Value = TxtFamily.Text
                cmd.Parameters.Add("@Sexl", SqlDbType.VarChar).Value = TxtSexuality.Text
                cmd.Parameters.Add("@Cop", SqlDbType.VarChar).Value = TxtCoping.Text
                cmd.Parameters.Add("@Val", SqlDbType.VarChar).Value = TxtValues.Text
                cmd.Parameters.Add("@Immu", SqlDbType.VarChar).Value = TxtImmu.Text
                cmd.Parameters.Add("@Other", SqlDbType.VarChar).Value = TxtOthers.Text
                cmd.Parameters.Add("@Infor", SqlDbType.VarChar).Value = TxtInformant.Text
                cmd.Parameters.Add("@Temp", SqlDbType.VarChar).Value = TxtTemp.Text
                cmd.Parameters.Add("@Bp", SqlDbType.VarChar).Value = TxtBP.Text
                cmd.Parameters.Add("@Pul", SqlDbType.VarChar).Value = TxtPulse.Text
                cmd.Parameters.Add("@Resp", SqlDbType.VarChar).Value = TxtResp.Text
                cmd.Parameters.Add("@Hgt", SqlDbType.VarChar).Value = TxtHgt.Text
                cmd.Parameters.Add("@Wght", SqlDbType.VarChar).Value = TxtWght.Text
                cmd.Parameters.Add("@Apex", SqlDbType.VarChar).Value = TxtApex.Text
                cmd.Parameters.Add("@Palp", SqlDbType.VarChar).Value = TxtPalp.Text
                cmd.Parameters.Add("@Ausc", SqlDbType.VarChar).Value = TxtAusc.Text
                cmd.Parameters.Add("@Urin", SqlDbType.VarChar).Value = TxtUrin.Text
                cmd.Parameters.Add("@Perc", SqlDbType.VarChar).Value = TxtPercu.Text
                cmd.Parameters.Add("@Gen", SqlDbType.VarChar).Value = TxtGenInsp.Text
                cmd.Parameters.Add("@Lab", SqlDbType.VarChar).Value = TxtLabRes.Text
                cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = TxtNursDiag.Text
                cmd.Parameters.Add("@Nurs", SqlDbType.VarChar).Value = TxtNurse.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()

                MsgBox("NURSING HISTORY SAVED SUCCESSFULLY", MsgBoxStyle.Information, "Medx-pro")
                TxtNurse.Focus()
                Txtpassw.Text = ""
                Btnsave.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            con.Close()

        End If
    End Sub

    Public Sub LoadNurseHx()
        cmd = New SqlCommand("Select * from NursingHx where HospitalNo=@Hosp_Num And AdmissionID=@AdmID", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
        cmd.Parameters.Add("@AdmID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            Txtconsultant.Text = tbl.Rows(0)(4).ToString()
            TxtPastMedHx.Text = tbl.Rows(0)(5).ToString()
            TxtPresMedHx.Text = tbl.Rows(0)(6).ToString()
            TxtNutri.Text = tbl.Rows(0)(7).ToString()
            TxtElim.Text = tbl.Rows(0)(8).ToString()
            TxtActivity.Text = tbl.Rows(0)(9).ToString()
            TxtSleep.Text = tbl.Rows(0)(10).ToString()
            TxtComm.Text = tbl.Rows(0)(11).ToString()
            TxtFeeling.Text = tbl.Rows(0)(12).ToString()
            TxtFamily.Text = tbl.Rows(0)(13).ToString()
            TxtSexuality.Text = tbl.Rows(0)(14).ToString()
            TxtCoping.Text = tbl.Rows(0)(15).ToString()
            TxtValues.Text = tbl.Rows(0)(16).ToString()
            TxtImmu.Text = tbl.Rows(0)(17).ToString()
            TxtOthers.Text = tbl.Rows(0)(18).ToString()
            TxtInformant.Text = tbl.Rows(0)(19).ToString()
            TxtTemp.Text = tbl.Rows(0)(20).ToString()
            TxtBP.Text = tbl.Rows(0)(21).ToString()
            TxtPulse.Text = tbl.Rows(0)(22).ToString()
            TxtResp.Text = tbl.Rows(0)(23).ToString()
            TxtHgt.Text = tbl.Rows(0)(24).ToString()
            TxtWght.Text = tbl.Rows(0)(25).ToString()
            TxtApex.Text = tbl.Rows(0)(26).ToString()
            TxtPalp.Text = tbl.Rows(0)(27).ToString()
            TxtAusc.Text = tbl.Rows(0)(28).ToString()
            TxtUrin.Text = tbl.Rows(0)(29).ToString()
            TxtPercu.Text = tbl.Rows(0)(30).ToString()
            TxtGenInsp.Text = tbl.Rows(0)(31).ToString()
            TxtLabRes.Text = tbl.Rows(0)(32).ToString()
            TxtNursDiag.Text = tbl.Rows(0)(33).ToString()
            TxtNurse.Text = tbl.Rows(0)(34).ToString()

            Btnsave.Enabled = False
        End If
    End Sub

End Class
