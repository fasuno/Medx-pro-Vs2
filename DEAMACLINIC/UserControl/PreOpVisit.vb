Imports System.Data.SqlClient
Public Class PreOpVisit
    Public Sub LOadPreOp()

        cmd = New SqlCommand("Select * from PreOpVisits where Hospital_No=@Hosp_Num AND Surgery_ID=@SurID ", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
        cmd.Parameters.Add("@SurID", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            TxtBP.Text = tbl.Rows(0)(4).ToString()
            TxtTemp.Text = tbl.Rows(0)(5).ToString()
            TxtPulse.Text = tbl.Rows(0)(6).ToString()
            Txtresp.Text = tbl.Rows(0)(7).ToString()
            TxtWght.Text = tbl.Rows(0)(8).ToString()
            CboCough.Text = tbl.Rows(0)(9).ToString()
            CboFlu.Text = tbl.Rows(0)(10).ToString()
            CboSmoke.Text = tbl.Rows(0)(11).ToString()
            CboAlcohol.Text = tbl.Rows(0)(12).ToString()
            CboAllerg.Text = tbl.Rows(0)(13).ToString()
            CBoTeeth.Text = tbl.Rows(0)(14).ToString()
            CboCont.Text = tbl.Rows(0)(15).ToString()
            CboEat.Text = tbl.Rows(0)(16).ToString()
            CboNail.Text = tbl.Rows(0)(17).ToString()
            CboBowel.Text = tbl.Rows(0)(18).ToString()
            DtTime.Value = Convert.ToDateTime(tbl.Rows(0)(19))
            CboConsent.Text = tbl.Rows(0)(20).ToString()
            TxtOthers.Text = tbl.Rows(0)(21).ToString()

            TxtPassw.Visible = False
            BtnSave.Visible = False
            Txtpassupd.BringToFront()
            BtnUpdate.Visible = True
            Label20.Visible = True
            Txtpassupd.Visible = True

        Else

            CLEar()

            TxtPassw.Visible = True
            TxtPassw.BringToFront()
            BtnSave.Visible = True
            BtnUpdate.Visible = False
            Label20.Visible = True
        End If
    End Sub
    Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = TxtPassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            TxtOthers.Focus()


        Else

        End If
    End Sub
    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TxtPassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            Lbluser.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtPassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "User Validation")
            TxtOthers.Focus()
        Else

            Try

                cmd = New SqlCommand("INSERT INTO PreOpVisits VALUES(@Dat, @Tim, @SurgId, @Hno, @Bp, @Tmp, @Pulse, @Resp, @Wght, @Cough, @Catar, @Smok, @Alcoh, @Alerg, @teeth, @Lense, @Eat, @Nail, @Bowel, @TimEmpt, @Cons, @Other, @EntBy)", con)

                cmd.Parameters.Add("@Dat", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = frmMain.lbltime.Text
                cmd.Parameters.Add("@SurgId", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text
                cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text
                cmd.Parameters.Add("@Bp", SqlDbType.VarChar).Value = TxtBP.Text
                cmd.Parameters.Add("@Tmp", SqlDbType.VarChar).Value = TxtTemp.Text
                cmd.Parameters.Add("@Pulse", SqlDbType.VarChar).Value = TxtTemp.Text
                cmd.Parameters.Add("@Resp", SqlDbType.VarChar).Value = Txtresp.Text
                cmd.Parameters.Add("@Wght", SqlDbType.VarChar).Value = TxtWght.Text
                cmd.Parameters.Add("@Cough", SqlDbType.VarChar).Value = CboCough.Text
                cmd.Parameters.Add("@Catar", SqlDbType.VarChar).Value = CboFlu.Text
                cmd.Parameters.Add("@Smok", SqlDbType.VarChar).Value = CboSmoke.Text
                cmd.Parameters.Add("@Alcoh", SqlDbType.VarChar).Value = CboAlcohol.Text
                cmd.Parameters.Add("@Alerg", SqlDbType.VarChar).Value = CboAllerg.Text
                cmd.Parameters.Add("@teeth", SqlDbType.VarChar).Value = CBoTeeth.Text
                cmd.Parameters.Add("@Lense", SqlDbType.VarChar).Value = CboCont.Text
                cmd.Parameters.Add("@Eat", SqlDbType.VarChar).Value = CboEat.Text
                cmd.Parameters.Add("@Nail", SqlDbType.VarChar).Value = CboNail.Text
                cmd.Parameters.Add("@Bowel", SqlDbType.VarChar).Value = CboBowel.Text
                cmd.Parameters.Add("@TimEmpt", SqlDbType.VarChar).Value = DtTime.Text
                cmd.Parameters.Add("@Cons", SqlDbType.VarChar).Value = CboConsent.Text
                cmd.Parameters.Add("@Other", SqlDbType.VarChar).Value = TxtOthers.Text
                cmd.Parameters.Add("@EntBy", SqlDbType.VarChar).Value = FrmSurgery.lbluser.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("SAVED SUCCESSFUL", MsgBoxStyle.Information, "Pre-Op Visit")

                CLEar()

                FrmSurgery.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub
    Public Sub CLEar()
        TxtBP.Text = ""
        TxtTemp.Text = ""
        TxtPulse.Text = ""
        TxtWght.Text = ""
        Txtresp.Text = ""
        TxtOthers.Text = ""
        CboCough.Text = Nothing
        CboConsent.Text = Nothing
        CboCont.Text = Nothing
        CboAllerg.Text = Nothing
        CboBowel.Text = Nothing
        CboEat.Text = Nothing
        CboFlu.Text = Nothing
        CboNail.Text = Nothing
        CboAlcohol.Text = Nothing
        CboSmoke.Text = Nothing
        CBoTeeth.Text = Nothing
        Lbluser.Text = ""
        TxtPassw.Text = ""

    End Sub
    Private Sub TxtPassw_Leave(sender As Object, e As EventArgs) Handles TxtPassw.Leave
        CheckPassowrd()
        showusername()
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If Txtpassupd.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "User Validation")
            TxtOthers.Focus()
        Else

            Try

                cmd = New SqlCommand("UPDATE PreOpVisits SET BP=@Bps, Temp=@Tmps, Pulse=@Puls, Resp=@Rsp, Weight=@Wght, Cough=@Cogh, Catarrh_Or_Flu=@Flu, Smoke=@Smk, Alcoholic=@Alco, Allergies=@Alrg, Densure_Teeth=@teth, Contact_Lense=@CLense, Eating=@Eats, Nail_removed=@Nailr, Emptied_Bowel=@Bowl, Time_Emptied=@TEmpt, Consent=@Con, Others=@Othr, Entry_By=@EBy WHERE Surgery_ID=@Sid AND Hospital_No=@Hnum")

                ' cmd.Parameters.Add("@Dat", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                ' cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = frmMain.lbltime.Text
                'cmd.Parameters.Add("@SgId", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text
                ' cmd.Parameters.Add("@Hno", SqlDbType.Int).Value = FrmSurgery.TxthospNo.Text
                cmd.Parameters.Add("@Bps", SqlDbType.VarChar).Value = TxtBP.Text
                cmd.Parameters.Add("@Tmps", SqlDbType.VarChar).Value = TxtTemp.Text
                cmd.Parameters.Add("@Puls", SqlDbType.VarChar).Value = TxtTemp.Text
                cmd.Parameters.Add("@Rsp", SqlDbType.VarChar).Value = Txtresp.Text
                cmd.Parameters.Add("@Wght", SqlDbType.VarChar).Value = TxtWght.Text
                cmd.Parameters.Add("@Cogh", SqlDbType.NChar).Value = CboCough.Text
                cmd.Parameters.Add("@Flu", SqlDbType.NChar).Value = CboFlu.Text
                cmd.Parameters.Add("@Smk", SqlDbType.NChar).Value = CboSmoke.Text
                cmd.Parameters.Add("@Alco", SqlDbType.NChar).Value = CboAlcohol.Text
                cmd.Parameters.Add("@Alrg", SqlDbType.NChar).Value = CboAllerg.Text
                cmd.Parameters.Add("@teth", SqlDbType.NChar).Value = CBoTeeth.Text
                cmd.Parameters.Add("@CLense", SqlDbType.NChar).Value = CboCont.Text
                cmd.Parameters.Add("@Eats", SqlDbType.NChar).Value = CboEat.Text
                cmd.Parameters.Add("@Nailr", SqlDbType.NChar).Value = CboNail.Text
                cmd.Parameters.Add("@Bowl", SqlDbType.NChar).Value = CboBowel.Text
                cmd.Parameters.Add("@TEmpt", SqlDbType.VarChar).Value = DtTime.Text
                cmd.Parameters.Add("@Con", SqlDbType.NChar).Value = CboConsent.Text
                cmd.Parameters.Add("@Othr", SqlDbType.VarChar).Value = TxtOthers.Text
                cmd.Parameters.Add("@EBy", SqlDbType.VarChar).Value = Lbluser.Text

                cmd.Parameters.Add("@SId", SqlDbType.Int).Value = FrmSurgery.Lblsurgid.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmSurgery.TxthospNo.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("UPDATED SUCCESSFUL", MsgBoxStyle.Information, "Pre-Op Visit Update")

                CLEar()
                Txtpassupd.Text = ""
                FrmSurgery.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub
    Private Sub Txtpassupd_Leave(sender As Object, e As EventArgs) Handles Txtpassupd.Leave
        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpassupd.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            TxtOthers.Focus()


        Else
            Lbluser.Text = tbl.Rows(0)(1).ToString()
        End If
    End Sub

End Class
