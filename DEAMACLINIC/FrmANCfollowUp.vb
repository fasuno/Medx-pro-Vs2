Imports System.Data.SqlClient
Public Class FrmANCfollowUp

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub removefrompending()

        Dim Delquery As String = " Delete From Pending_Vitals Where Hospital_No = '" & FrmANCform.lblhospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            txtpassw.Focus()

        Else
            lblusername.Text = tbl.Rows(0)(1).ToString()

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub BtnDrugs_Click(sender As Object, e As EventArgs) Handles BtnDrugs.Click
        Dim frm = New FrmDrugsPresc

        frm.BtnANCdrugs.BringToFront()
        frm.LoadDrugs()
        frm.ShowDialog()
    End Sub

    Private Sub btnLAB_Click(sender As Object, e As EventArgs) Handles btnLAB.Click
        Dim frms = New FrmLabrequest

        frms.BtnSndAncLab.BringToFront()
        frms.LoadLAbTest()
        frms.ShowDialog()
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles BtnScan.Click
        Dim fr = New FrmRadrequest

        fr.BtnSndAncRad.BringToFront()
        fr.LoadRAdlist()
        fr.ShowDialog()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")

        Else

            Dim res As MsgBoxResult
            res = MsgBox("ARE YOU SURE YOU WANT TO SAVE?", MsgBoxStyle.YesNo, "Medx-Pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    ' cmd.CommandType = System.Data.CommandType.Text
                    'cmd.CommandText = "insert into ANCVitals Values ('" & FrmANCform.lblbkid.Text & "','" & FrmANCform.lblhospnum.Text & "', '" & dtfolwup.Value & "', '" & dtflwuptime.Value & "', '" & txtga.Text & "', '" & txtheght.Text & "', '" & txtprepos.Text & "', '" & txtlie.Text & "', '" & txtfh.Text & "', '" & txtbp.Text & "', '" & txturine.Text & "', '" & txtwght.Text & "', '" & cboappnmnt.Text & "', '" & lblusername.Text & "', '" & Txtremark.Text & "')"
                    cmd = New SqlCommand("INSERT INTO ANCVitals VALUES(@Bid, @Hnum, @dte, @tim, @ga, @Fdl, @Pre, @Li, @Fh, @Bp, @Uri, @Wgh, @Apt, @User, @Rmrk)", con)

                    cmd.Parameters.Add("@Bid", SqlDbType.Int).Value = FrmANCform.lblbkid.Text
                    cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
                    cmd.Parameters.Add("@dte", SqlDbType.Date).Value = dtfolwup.Value.Date
                    cmd.Parameters.Add("@tim", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                    cmd.Parameters.Add("@ga", SqlDbType.VarChar).Value = txtga.Text
                    cmd.Parameters.Add("@Fdl", SqlDbType.VarChar).Value = txtheght.Text
                    cmd.Parameters.Add("@Pre", SqlDbType.VarChar).Value = txtprepos.Text
                    cmd.Parameters.Add("@Li", SqlDbType.VarChar).Value = txtlie.Text
                    cmd.Parameters.Add("@Fh", SqlDbType.VarChar).Value = txtfh.Text
                    cmd.Parameters.Add("@Bp", SqlDbType.VarChar).Value = txtbp.Text
                    cmd.Parameters.Add("@Uri", SqlDbType.VarChar).Value = txturine.Text
                    cmd.Parameters.Add("@Wgh", SqlDbType.VarChar).Value = txtwght.Text
                    cmd.Parameters.Add("@Apt", SqlDbType.VarChar).Value = cboappnmnt.Text
                    cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = lblusername.Text
                    cmd.Parameters.Add("@Rmrk", SqlDbType.VarChar).Value = Txtremark.Text


                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()
                    'con.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                con.Close()

                Me.Close()
            End If
        End If


        FrmANCform.LoadAncVitals()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")

        Else

            Try
                ' Dim Updat As String = "Update ANCVitals Set GA='" & txtga.Text & "', Fundal='" & txtheght.Text & "', Presentation='" txtprepos.Text & "', Lie='" & txtlie.Text & "', Foetal_Heart='" & txtfh.Text & "', Bp='" & txtbp.Text & "', Urine='" & txturine.Text & "', Weight='" & txtwght.Text & "', Next_Appointment='" & cboappnmnt.Text & "', Entry_By='" & lblusername.Text & "', Remarks='" & Txtremark.Text & "' WHERE Hospital_Num='" & FrmANCform.lblhospnum.Text & "' AND  Date='" & dtfolwup.Value & "'"

                cmd = New SqlCommand("UPDATE ANCVitals SET GA=@gas, Fundal=@Fun, Presentation=@Presn, Lie=@Le, Foetal_Heart=@Fht, Bp=@Bpe, Urine=@Urn, Weight=@Wegh, Next_Appointment=@Aptt, Entry_By=@Usrr, Remarks=@Rmks WHERE Hospital_Num ='" & FrmANCform.lblhospnum.Text & "' AND  Date=@Dtes")

                cmd.Parameters.Add("@gas", SqlDbType.VarChar).Value = txtga.Text
                cmd.Parameters.Add("@Fun", SqlDbType.VarChar).Value = txtheght.Text
                cmd.Parameters.Add("@Presn", SqlDbType.VarChar).Value = txtprepos.Text
                cmd.Parameters.Add("@Le", SqlDbType.VarChar).Value = txtlie.Text
                cmd.Parameters.Add("@Fht", SqlDbType.VarChar).Value = txtfh.Text
                cmd.Parameters.Add("@Bpe", SqlDbType.VarChar).Value = txtbp.Text
                cmd.Parameters.Add("@Urn", SqlDbType.VarChar).Value = txturine.Text
                cmd.Parameters.Add("@Wegh", SqlDbType.VarChar).Value = txtwght.Text
                cmd.Parameters.Add("@Aptt", SqlDbType.VarChar).Value = cboappnmnt.Text
                cmd.Parameters.Add("@Usrr", SqlDbType.VarChar).Value = lblusername.Text
                cmd.Parameters.Add("@Rmks", SqlDbType.VarChar).Value = Txtremark.Text

                cmd.Parameters.Add("@dtes", SqlDbType.Date).Value = dtfolwup.Value.Date

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("FOLLOW UP VITAL EDITED", "Medx-pro", MessageBoxButtons.OK)

                FrmANCform.LoadAncVitals()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
        Me.Close()

        '// Call the refresh appointment grid method from the records form

    End Sub

    Private Sub removeANCfrompend()

        Dim Delquery As String = " Delete From Pending_Vitals Where Hospital_No = '" & FrmANCform.lblhospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Private Sub Btnadmit_Click(sender As Object, e As EventArgs) Handles Btnadmit.Click

        ' FrmAdmitpt.LoadDiagnosis()
        FrmAdmitpt.Btnorderadmit.BringToFront()
        FrmAdmitpt.ShowDialog()

    End Sub

    Private Sub Btnsendvitals_Click(sender As Object, e As EventArgs) Handles Btnsendvitals.Click

        If txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")

        Else

            Dim res As MsgBoxResult
            res = MsgBox("ARE YOU SURE YOU WANT TO SAVE?", MsgBoxStyle.YesNo, "Medx-Pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    ' cmd.CommandType = System.Data.CommandType.Text
                    'cmd.CommandText = "insert into ANCVitals Values ('" & lblbkid.Text & "','" & FrmPtRecords.Lblhopnum.Text & "',  '" & dtfolwup.Value & "', '" & dtflwuptime.Value & "', '" & txtga.Text & "', '" & txtheght.Text & "', '" & txtprepos.Text & "', '" & txtlie.Text & "', '" & txtfh.Text & "', '" & txtbp.Text & "', '" & txturine.Text & "', '" & txtwght.Text & "', '" & cboappnmnt.Text & "', '" & lblusername.Text & "', '" & Txtremark.Text & "')"

                    cmd = New SqlCommand("INSERT INTO ANCVitals VALUES(@Bkid, @Hno, @dtte, @timm, @gas, @Fd, @Pr, @Ly, @Fh, @Bps, @Ur, @Wg, @Appt, @Usr, @Rmr)", con)

                    cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = lblbkid.Text
                    cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                    cmd.Parameters.Add("@dtte", SqlDbType.Date).Value = dtfolwup.Value.Date
                    cmd.Parameters.Add("@timm", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                    cmd.Parameters.Add("@gas", SqlDbType.VarChar).Value = txtga.Text
                    cmd.Parameters.Add("@Fd", SqlDbType.VarChar).Value = txtheght.Text
                    cmd.Parameters.Add("@Pr", SqlDbType.VarChar).Value = txtprepos.Text
                    cmd.Parameters.Add("@Ly", SqlDbType.VarChar).Value = txtlie.Text
                    cmd.Parameters.Add("@Fh", SqlDbType.VarChar).Value = txtfh.Text
                    cmd.Parameters.Add("@Bps", SqlDbType.VarChar).Value = txtbp.Text
                    cmd.Parameters.Add("@Ur", SqlDbType.VarChar).Value = txturine.Text
                    cmd.Parameters.Add("@Wg", SqlDbType.VarChar).Value = txtwght.Text
                    cmd.Parameters.Add("@Appt", SqlDbType.VarChar).Value = cboappnmnt.Text
                    cmd.Parameters.Add("@Usr", SqlDbType.VarChar).Value = lblusername.Text
                    cmd.Parameters.Add("@Rmr", SqlDbType.VarChar).Value = Txtremark.Text

                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                con.Close()

                Me.Close()
            End If
        End If


        FrmANCform.LoadAncVitals()

    End Sub

    Private Sub txtpassw_Leave(sender As Object, e As EventArgs) Handles txtpassw.Leave
        showusername()
    End Sub


End Class