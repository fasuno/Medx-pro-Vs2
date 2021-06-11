Imports System.Data.SqlClient

Public Class RoundNotes

    Dim summformcolpse As Boolean = True
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            Txtnote.Focus()
        ElseIf Txtnote.Text = "" Then
            MsgBox("REPORT FIELD IS EMPTY", MsgBoxStyle.Information, "Medx-pro")
            Txtnote.Focus()
        Else

            Try

                cmd = New SqlCommand("INSERT INTO WardRoundNotes VALUES(@AdmId, @hnum, @Dtes, @Tm, @Not, @Snam)", con)

                cmd.Parameters.Add("@AdmId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                cmd.Parameters.Add("@Tm", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                cmd.Parameters.Add("@Not", SqlDbType.NVarChar).Value = Txtnote.Text
                cmd.Parameters.Add("@Snam", SqlDbType.VarChar).Value = Lblusername.Text


                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            con.Close()
            Txtnote.Text = ""
            Txtpass.Text = ""
        End If

        LoadRounrNotes()

    End Sub

    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            Lblusername.Text = tbl.Rows(0)(1).ToString()

        Else

        End If

    End Sub

    Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            Txtnote.Focus()


        Else

        End If
    End Sub

    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub LoadRounrNotes()

        Dim tb As New DataTable
        cmd = New SqlCommand("Select Date, Time, Note, Doctor FROM WardRoundNotes WHERE Admission_ID='" & FrmAdmitFolder.LbladmitID.Text & "'", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        Dtgreport.DataSource = tb

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Txtnote.Text = ""
        Txtpass.Text = ""
        Btnsave.Enabled = True
    End Sub

    Private Sub Dtgreport_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dtgreport.CellMouseClick
        Txtnote.Text = Dtgreport.CurrentRow.Cells(2).Value.ToString
        Btnsave.Enabled = False
    End Sub

    Private Sub RoundNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Size = Panel4.MinimumSize
        Panel3.Size = Panel3.MinimumSize
    End Sub

    Private Sub BtnDischSum_Click(sender As Object, e As EventArgs) Handles BtnDischSum.Click
        TimSumm.Start()
    End Sub

    Private Sub TimSumm_Tick(sender As Object, e As EventArgs) Handles TimSumm.Tick
        If summformcolpse Then

            Panel4.Height += 10
            If Panel4.Size = Panel4.MaximumSize Then
                Panel3.Size = Panel3.MaximumSize
                TimSumm.Stop()
                summformcolpse = False

            End If
        Else

            Panel4.Height -= 10
            If Panel4.Size = Panel4.MinimumSize Then
                Panel3.Size = Panel3.MinimumSize
                TimSumm.Stop()
                summformcolpse = True

            End If

        End If
    End Sub

    Private Sub BtnSaveSum_Click(sender As Object, e As EventArgs) Handles BtnSaveSum.Click

        If TxtPassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
        Else

            If TxtConstnt.Text = "" Then
                MsgBox("PLEASE ENTER CONSULTANT NAME", MsgBoxStyle.Critical, "Medx-pro")
            Else

                Dim res As MsgBoxResult
                res = MsgBox("ORDER DISCHARGE OF THIS PATIENT ?", MsgBoxStyle.YesNo, "Medx-Pro")
                If (res = MsgBoxResult.Yes) Then

                    Try

                        cmd = New SqlCommand("INSERT INTO Discharge_Summ VALUES(@EntDte, @EntTim, @AdmId, @HospNo, @Diag, @CliSum, @Oper, @Pro, @Drug, @Flwup, @OrdBy, @Cosult)", con)

                        cmd.Parameters.Add("@EntDte", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                        cmd.Parameters.Add("@EntTim", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                        cmd.Parameters.Add("@AdmID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                        cmd.Parameters.Add("@HospNo", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = TxtDiag.Text
                        cmd.Parameters.Add("@Clisum", SqlDbType.NVarChar).Value = TxtCliSum.Text
                        cmd.Parameters.Add("@Oper", SqlDbType.VarChar).Value = TxtOper.Text
                        cmd.Parameters.Add("@Pro", SqlDbType.NVarChar).Value = TxtProb.Text
                        cmd.Parameters.Add("@Drug", SqlDbType.NVarChar).Value = TxtDrugs.Text
                        cmd.Parameters.Add("@Flwup", SqlDbType.Date).Value = DtAppmnt.Value.Date
                        cmd.Parameters.Add("@OrdBy", SqlDbType.VarChar).Value = lblusersum.Text
                        cmd.Parameters.Add("@Cosult", SqlDbType.VarChar).Value = TxtConstnt.Text

                        cmd.Connection = con

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        MsgBox("PATIENT DISCHARGE ORDERED", MsgBoxStyle.OkOnly, "Medx-pro")

                        BtnSaveSum.Enabled = False
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try

                    UpdateADmitStatus()
                    FrmWardManager.LoadPTonadmission()

                    Panel3.Size = Panel3.MinimumSize
                    Panel4.Size = Panel4.MinimumSize

                End If
            End If
        End If
    End Sub

    Public Sub UpdateADmitStatus()

        Try
            ' Dim Updat As String = ("Update RadRequestAndResult Set Result = '" & TxtRadresult.Text.ToString & "', Date_reported = '" & lbldte.Text & "', Time_reported = '" & lbltim.Text & "', Reported_by = '" & Lblreprtby.Text & "', Status='" & lbltrtd.Text.ToString & "' WHERE Request_Num='" & Lblrqstnum.Text & "' AND Investigation = '" & lblinvest.Text.ToString & "'")

            cmd = New SqlCommand("UPDATE Admitted SET Admission_Status=@AdmSta WHERE Hospital_Num=@HNum And Admit_ID=@AdID")

            cmd.Parameters.Add("@AdmSta", SqlDbType.NVarChar).Value = lblstat.Text
            cmd.Parameters.Add("@HNum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
            cmd.Parameters.Add("@AdID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text


            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub TxtPassword_Leave(sender As Object, e As EventArgs) Handles TxtPassword.Leave
        CheckPassowrdSum()
        showusernameSum()
    End Sub

    Sub showusernameSum()

        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TxtPassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            lblusersum.Text = tbl.Rows(0)(1).ToString()

        Else

        End If

    End Sub

    Sub CheckPassowrdSum()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = TxtPassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            TxtConstnt.Focus()

        Else

        End If
    End Sub

    Public Sub LoadDishcSum()

        cmd = New SqlCommand("Select * from Discharge_Summ where Hospital_No=@HospNum And Admission_ID=@AdmtID", con)
        cmd.Parameters.Add("@HospNum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
        cmd.Parameters.Add("@AdmtID", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            TxtDiag.Text = tbl.Rows(0)(4).ToString()
            TxtCliSum.Text = tbl.Rows(0)(5).ToString()
            TxtOper.Text = tbl.Rows(0)(6).ToString()
            TxtProb.Text = tbl.Rows(0)(7).ToString()
            TxtDrugs.Text = tbl.Rows(0)(8).ToString()
            DtAppmnt.Value = tbl.Rows(0)(9)
            TxtConstnt.Text = tbl.Rows(0)(11).ToString()

            BtnSaveSum.Enabled = False
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        BtnSaveSum.Enabled = True
    End Sub

    Private Sub TxtConstnt_TextChanged(sender As Object, e As EventArgs) Handles TxtConstnt.TextChanged
        TxtPassword.Enabled = True
    End Sub

End Class
