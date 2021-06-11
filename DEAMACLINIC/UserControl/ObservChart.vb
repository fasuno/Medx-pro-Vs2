Imports System.Data.SqlClient

Public Class ObservChart

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            TxtBp.Focus()
        ElseIf TxtBp.Text = "" Or TxtTemp.Text = "" Or TxtPulse.Text = "" Then
            MsgBox("VITAL SIGNS FIELDS CANNOT BE EMPTY", MsgBoxStyle.Information, "Medx-pro")
            TxtBp.Focus()
        Else

            Try

                cmd = New SqlCommand("INSERT INTO ObservationChart VALUES(@Dtes, @Tm, @AdmId, @hnum, @Bp, @Temp, @Puls, @Resp, @Bow, @Blad, @Rem, @Ent)", con)

                cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                cmd.Parameters.Add("@Tm", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                cmd.Parameters.Add("@AdmId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                cmd.Parameters.Add("@Bp", SqlDbType.VarChar).Value = TxtBp.Text
                cmd.Parameters.Add("@Temp", SqlDbType.VarChar).Value = TxtTemp.Text
                cmd.Parameters.Add("@Puls", SqlDbType.VarChar).Value = TxtPulse.Text
                cmd.Parameters.Add("@Resp", SqlDbType.VarChar).Value = TxtResp.Text
                cmd.Parameters.Add("@Bow", SqlDbType.VarChar).Value = Txtbowel.Text
                cmd.Parameters.Add("@Blad", SqlDbType.VarChar).Value = TxtBlad.Text
                cmd.Parameters.Add("@Rem", SqlDbType.VarChar).Value = TxtRem.Text
                cmd.Parameters.Add("@Ent", SqlDbType.VarChar).Value = Lbluser.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            con.Close()
            TxtBp.Text = ""
            TxtTemp.Text = ""
            TxtPulse.Text = ""
            Txtbowel.Text = ""
            TxtBlad.Text = ""
            TxtResp.Text = ""
            TxtRem.Text = ""
            Lbluser.Text = ""
            Txtpass.Text = ""

        End If
        LoadObsvChart()
    End Sub

    Private Sub BtnCls_Click(sender As Object, e As EventArgs) Handles BtnCls.Click
        TxtBp.Text = ""
        TxtTemp.Text = ""
        TxtPulse.Text = ""
        Txtbowel.Text = ""
        TxtBlad.Text = ""
        TxtResp.Text = ""
        TxtRem.Text = ""
        Lbluser.Text = ""
        Txtpass.Text = ""

        BtnSave.Enabled = True

    End Sub

    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            Lbluser.Text = tbl.Rows(0)(1).ToString()

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
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            TxtBp.Focus()


        Else

        End If
    End Sub

    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub LoadObsvChart()
        Dim tb As New DataTable
        cmd = New SqlCommand("Select Date, Time, Bp, Temp, Pulse, Respiration, Bowel, Bladder, Remarks, Entry_By FROM ObservationChart WHERE Admission_ID='" & FrmAdmitFolder.LbladmitID.Text & "'", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        DtgObserv.DataSource = tb
    End Sub

    Private Sub DtgObserv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgObserv.CellDoubleClick
        TxtBp.Text = DtgObserv.CurrentRow.Cells(2).Value
        TxtTemp.Text = DtgObserv.CurrentRow.Cells(3).Value
        TxtPulse.Text = DtgObserv.CurrentRow.Cells(4).Value
        TxtResp.Text = DtgObserv.CurrentRow.Cells(5).Value
        Txtbowel.Text = DtgObserv.CurrentRow.Cells(6).Value
        TxtBlad.Text = DtgObserv.CurrentRow.Cells(7).Value
        TxtRem.Text = DtgObserv.CurrentRow.Cells(8).Value
        BtnSave.Enabled = False
    End Sub

End Class
