Imports System.Data.SqlClient

Public Class FrmDischarge
    Private Sub BtnDischarge_Click(sender As Object, e As EventArgs) Handles BtnDischarge.Click
        If TxtPass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
            Txtremark.Focus()

        Else


            Try

                cmd = New SqlCommand("INSERT INTO DischargePT VALUES(@Aid, @Adte, @Disdat, @tim, @Hnum, @Sname, @Oname, @Sex, @Age, @Dia,@DisTyp, @wrd, @bdno, @con, @Rmk, @Eby)", con)

                cmd.Parameters.Add("@Aid", SqlDbType.Int).Value = TxtAdmitID.Text
                cmd.Parameters.Add("@Adte", SqlDbType.Date).Value = Convert.ToDateTime(LbladmitDate.Text).Date
                cmd.Parameters.Add("@Disdat", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = frmMain.lbltime.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = TxtHospnum.Text
                cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = TxtSurname.Text
                cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = TxtOthername.Text
                cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = TxtSex.Text
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = TxtAge.Text
                cmd.Parameters.Add("@Dia", SqlDbType.NVarChar).Value = TxtDiag.Text
                cmd.Parameters.Add("@DisTyp", SqlDbType.VarChar).Value = CbodisType.Text
                cmd.Parameters.Add("@Wrd", SqlDbType.VarChar).Value = Txtward.Text
                cmd.Parameters.Add("@Bdno", SqlDbType.Int).Value = TxtBedNo.Text
                cmd.Parameters.Add("@Con", SqlDbType.VarChar).Value = TxtConsultant.Text
                cmd.Parameters.Add("@Rmk", SqlDbType.VarChar).Value = Txtremark.Text
                cmd.Parameters.Add("@Eby", SqlDbType.VarChar).Value = Lbluser.Text


                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("PATIENT HAVE BEEN SUCCESSFULLY DISCHARGED", MsgBoxStyle.Information, "Medx-Pro")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            UpdateDischargeDate()
            UpdateBedlist()

            FrmWardManager.LoadDischargedPT()
            FrmWardManager.LoadPTonadmission()

            Me.Close()
        End If


    End Sub
    Public Sub UpdateDischargeDate()

        Try

            cmd = New SqlCommand("UPDATE Admitted SET  Discharged_Date=@Ddate, Admission_Status='Discharged' WHERE Hospital_Num=@HNum And Admit_ID=@AdID")

            cmd.Parameters.Add("@Ddate", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
            cmd.Parameters.Add("@HNum", SqlDbType.VarChar).Value = TxtHospnum.Text
            cmd.Parameters.Add("@AdID", SqlDbType.Int).Value = TxtAdmitID.Text


            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Sub UpdateBedlist()

        Try

            cmd = New SqlCommand("UPDATE Bedlist SET  Bed_Status='Free' WHERE Bed_No=@BNum")

            cmd.Parameters.Add("@BNum", SqlDbType.Int).Value = TxtBedNo.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub
    Sub showusername()

        '==============CHECK USER VALIDITY
        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @pword", con)

        cmd.Parameters.Add("@pword", SqlDbType.VarChar).Value = TxtPass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbls As New DataTable()

        adpt.Fill(tbls)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbls.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "User Validation")
            Txtremark.Focus()
        Else

            '// Show users name after log in, this method will be called on frmlogin LOGIN button
            cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TxtPass.Text

            Dim adpts As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

            adpt.Fill(tbl)

            If tbl.Rows.Count() > 0 Then

                'Display the person data

                Lbluser.Text = tbl.Rows(0)(1).ToString()


            End If

        End If

    End Sub

    Private Sub TxtPass_Leave(sender As Object, e As EventArgs) Handles TxtPass.Leave
        showusername()
    End Sub
End Class