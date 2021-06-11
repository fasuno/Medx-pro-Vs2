
Imports System.Data.SqlClient

Public Class frmvitals

    Sub showDOCID()

        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Full_Name=@user", con)
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = cbodoctor.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then
            LblDocID.Text = tbl.Rows(0)(0).ToString

        Else
        End If

    End Sub

    Private Sub chkDoc_CheckedChanged(sender As Object, e As EventArgs) Handles chkDoc.CheckedChanged

        If chkDoc.Checked = True Then
            cbodoctor.Enabled = True
            chkRoom.Checked = False
            cborooms.Enabled = False
            cborooms.SelectedItem = Nothing

            PopulateCboDOCTOR()


        End If
    End Sub

    Private Sub chkRoom_CheckedChanged(sender As Object, e As EventArgs) Handles chkRoom.CheckedChanged
        If chkRoom.Checked = True Then
            cbodoctor.Enabled = False
            chkDoc.Checked = False
            cborooms.Enabled = True
            cbodoctor.SelectedItem = Nothing
            LblDocID.Text = ""

        End If
    End Sub

    Private Sub Btncls_Click(sender As Object, e As EventArgs) Handles Btncls.Click
        Me.Close()
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        ' MsgBox("PLEASE SELECT A DOCTOR OR CONSULTING ROOM", MsgBoxStyle.OkOnly, "Medx-pro")

        checkuserAndSave()
        frmNursing.sortvitalssigns()
        frmNursing.sorttreatvitals()

    End Sub

    Public Sub checkuserAndSave()

        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @pword", con)

        cmd.Parameters.Add("@pword", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            txtpass.Focus()
        Else

            '// Else if password is right, Commit the entry to datatbase

            Try

                cmd = New SqlCommand("INSERT INTO Treated_Vitals VALUES(@Dte, @tim, @Snme, @Onme, @hno, @Age, @Sx, @Acct, @Bp, @Tmp, @Pul, @Wgt, @hgt, @Res, @Clin, @Doc, @Rm, @Sntby, @Actcat)", con)

                cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Datetaken.Value.Date
                cmd.Parameters.Add("@tim", SqlDbType.VarChar).Value = lbltime.Text
                cmd.Parameters.Add("@snme", SqlDbType.VarChar).Value = lblsurname.Text
                cmd.Parameters.Add("@onme", SqlDbType.VarChar).Value = lblothernames.Text
                cmd.Parameters.Add("@hno", SqlDbType.VarChar).Value = lblhospnum.Text
                cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = lblage.Text
                cmd.Parameters.Add("@Sx", SqlDbType.VarChar).Value = lblsex.Text
                cmd.Parameters.Add("@Acct", SqlDbType.VarChar).Value = lblaccounttype.Text
                cmd.Parameters.Add("@Bp", SqlDbType.NVarChar).Value = TxtBp.Text
                cmd.Parameters.Add("@Tmp", SqlDbType.NVarChar).Value = txtTemp.Text
                cmd.Parameters.Add("@Pul", SqlDbType.VarChar).Value = txtPulse.Text
                cmd.Parameters.Add("@Wgt", SqlDbType.VarChar).Value = txtWeight.Text
                cmd.Parameters.Add("@hgt", SqlDbType.VarChar).Value = txtHeight.Text
                cmd.Parameters.Add("@Res", SqlDbType.VarChar).Value = txtResp.Text
                cmd.Parameters.Add("@Clin", SqlDbType.VarChar).Value = lblclinic.Text
                cmd.Parameters.Add("@Doc", SqlDbType.VarChar).Value = cbodoctor.Text
                cmd.Parameters.Add("@Rm", SqlDbType.VarChar).Value = cborooms.Text
                cmd.Parameters.Add("@Sntby", SqlDbType.VarChar).Value = lbluser.Text
                cmd.Parameters.Add("@Actcat", SqlDbType.VarChar).Value = lblcat.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("PATIENT HAVE BEEN ASSIGNED SUCCESSFULLY", MsgBoxStyle.OkOnly, "Medx-pro")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            Populatewaitinglist()
            '// Remove the patient from pending
            removefrompending()

            frmAllwaitingList.LoadAllPendLIst()
            FrmMywaitinglist.LoadDocPendLIst()

            Me.Close()
        End If
        ' Populatewaitinglist()

    End Sub

    Public Sub removefrompending()

        Dim Delquery As String = " Delete From Pending_Vitals Where Hospital_No = '" & lblhospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub reloadTreatedVitalsigns()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from Treated_Vitals", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        frmNursing.dtgtreatedvitals.DataSource = tbl
        con.Close()     '
    End Sub

    Public Sub updatewaitinglist()

        Try
            ' Dim Updat As String = "Update Pend_WaitingList Set date='" & Datetaken.Value & "', time='" & lbltime.Text & "', BP='" & TxtBp.Text & "', 
            ' Temp ='" & txtTemp.Text & "', Pulse='" & txtPulse.Text & "', Weight='" & txtWeight.Text & "',Height='" & txtHeight.Text & "', Respiration='" & txtResp.Text & "', See_Doctor='" & cbodoctor.Text & "',Room='" & cborooms.Text & "' WHERE Hospital_No='" & lblhospnum.Text & "' AND date='" & Datetaken.Text.ToString & "'"

            cmd = New SqlCommand("UPDATE Pend_WaitingList SET Date=@Dt, Time=@Tm, BP=@bpp, Temp=@Tp, Pulse=@Pls, Weight=@Wt, Height=@Ht, Respiration=@Rsp, See_Doctor=@Dr, Room=@Rom, Doctor_ID=@Dcid WHERE Hospital_No='" & lblhospnum.Text & "' AND date=@Dt")

            cmd.Parameters.Add("@Dt", SqlDbType.Date).Value = Datetaken.Value.Date
            cmd.Parameters.Add("@Tm", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Bpp", SqlDbType.NVarChar).Value = TxtBp.Text
            cmd.Parameters.Add("@Tp", SqlDbType.NVarChar).Value = txtTemp.Text
            cmd.Parameters.Add("@Pls", SqlDbType.VarChar).Value = txtPulse.Text
            cmd.Parameters.Add("@Wt", SqlDbType.VarChar).Value = txtWeight.Text
            cmd.Parameters.Add("@ht", SqlDbType.VarChar).Value = txtHeight.Text
            cmd.Parameters.Add("@Rsp", SqlDbType.VarChar).Value = txtResp.Text
            cmd.Parameters.Add("@Dr", SqlDbType.VarChar).Value = cbodoctor.Text
            cmd.Parameters.Add("@Rom", SqlDbType.VarChar).Value = cborooms.Text
            cmd.Parameters.Add("@Dcid", SqlDbType.VarChar).Value = LblDocID.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        Me.Close()
    End Sub

    Private Sub BtnChng_Click(sender As Object, e As EventArgs) Handles BtnChng.Click
        Try
            ' Dim Updat As String = "Update Treated_Vitals Set Date='" & Datetaken.Value & "', time='" & lbltime.Text & "', BP='" & TxtBp.Text & "', Temp='" & txtTemp.Text & "', Pulse='" & txtPulse.Text & "', Weight='" & txtWeight.Text & "', Height='" & txtHeight.Text & "', Respiration='" & txtResp.Text & "', See_Doctor='" & cbodoctor.Text & "',Room='" & cborooms.Text & "' WHERE Hospital_No='" & lblhospnum.Text & "' AND date='" & Datetaken.Text.ToString & "'"

            cmd = New SqlCommand("UPDATE Treated_Vitals SET Date=@Dat, Time=@Tym, BP=@bbp, Temp=@Tp, Pulse=@Pu, Weight=@Wtt, Height=@Htt, Respiration=@Rspn, See_Doctor=@Drs, Room=@Roms  WHERE Hospital_No='" & lblhospnum.Text & "' AND date=@Dat")

            cmd.Parameters.Add("@Dat", SqlDbType.Date).Value = Datetaken.Value.Date
            cmd.Parameters.Add("@Tym", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@Bbp", SqlDbType.NVarChar).Value = TxtBp.Text
            cmd.Parameters.Add("@Tp", SqlDbType.NVarChar).Value = txtTemp.Text
            cmd.Parameters.Add("@Pu", SqlDbType.VarChar).Value = txtPulse.Text
            cmd.Parameters.Add("@Wtt", SqlDbType.VarChar).Value = txtWeight.Text
            cmd.Parameters.Add("@htt", SqlDbType.VarChar).Value = txtHeight.Text
            cmd.Parameters.Add("@Rspn", SqlDbType.VarChar).Value = txtResp.Text
            cmd.Parameters.Add("@Drs", SqlDbType.VarChar).Value = cbodoctor.Text
            cmd.Parameters.Add("@Roms", SqlDbType.VarChar).Value = cborooms.Text

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            reloadTreatedVitalsigns()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        frmNursing.sorttreatvitals()

        updatewaitinglist()
        frmAllwaitingList.LoadAllPendLIst()
        FrmMywaitinglist.LoadDocPendLIst()

        Me.Close()

    End Sub

    Public Sub PopulateCboDOCTOR()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Full_Name from UsersReg WHERE Role='Medical Doctor'", con)

        adapt = New SqlDataAdapter(cmd)

        con.Open()   ' Open connection

        adapt.Fill(tbl)
        cbodoctor.DataSource = tbl
        cbodoctor.DisplayMember = "Full_Name"

        con.Close()

    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lbluser.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        showusername()
    End Sub

    Public Sub Populatewaitinglist()

        Try

            cmd = New SqlCommand("INSERT INTO Pend_WaitingList VALUES(@Dtse, @time, @Snm, @Onm, @hnu, @Age, @Sxx, @Act, @Acat, @Bps, @Tmpr, @Pls, @Whgt, @hght, @Resp, @Cli, @Docx, @Rmm, @Snt, @Did, @Sts)", con)

            cmd.Parameters.Add("@Dtse", SqlDbType.Date).Value = Datetaken.Value.Date
            cmd.Parameters.Add("@time", SqlDbType.VarChar).Value = lbltime.Text
            cmd.Parameters.Add("@snm", SqlDbType.VarChar).Value = lblsurname.Text
            cmd.Parameters.Add("@onm", SqlDbType.VarChar).Value = lblothernames.Text
            cmd.Parameters.Add("@hnu", SqlDbType.VarChar).Value = lblhospnum.Text
            cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = lblage.Text
            cmd.Parameters.Add("@Sxx", SqlDbType.VarChar).Value = lblsex.Text
            cmd.Parameters.Add("@Act", SqlDbType.VarChar).Value = lblaccounttype.Text
            cmd.Parameters.Add("@Acat", SqlDbType.VarChar).Value = lblcat.Text
            cmd.Parameters.Add("@Bps", SqlDbType.NVarChar).Value = TxtBp.Text
            cmd.Parameters.Add("@Tmpr", SqlDbType.NVarChar).Value = txtTemp.Text
            cmd.Parameters.Add("@Pls", SqlDbType.VarChar).Value = txtPulse.Text
            cmd.Parameters.Add("@Whgt", SqlDbType.VarChar).Value = txtWeight.Text
            cmd.Parameters.Add("@hght", SqlDbType.VarChar).Value = txtHeight.Text
            cmd.Parameters.Add("@Resp", SqlDbType.VarChar).Value = txtResp.Text
            cmd.Parameters.Add("@Cli", SqlDbType.VarChar).Value = lblclinic.Text
            cmd.Parameters.Add("@Docx", SqlDbType.VarChar).Value = cbodoctor.Text
            cmd.Parameters.Add("@Rmm", SqlDbType.VarChar).Value = cborooms.Text
            cmd.Parameters.Add("@Snt", SqlDbType.VarChar).Value = lbluser.Text
            cmd.Parameters.Add("@Did", SqlDbType.VarChar).Value = LblDocID.Text

            cmd.Parameters.Add("@Sts", SqlDbType.VarChar).Value = LblPendConslt.Text


            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub frmvitals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbltime.Text = timetaken.Text
    End Sub

    Private Sub timetaken_ValueChanged(sender As Object, e As EventArgs) Handles timetaken.ValueChanged
        lbltime.Text = timetaken.Text
    End Sub

    Sub cleartxt()
        TxtBp.Text = ""
        txtHeight.Text = ""
        txtpass.Text = ""
        txtPulse.Text = ""
        txtTemp.Text = ""
        txtWeight.Text = ""
    End Sub

    Private Sub cbodoctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodoctor.SelectedIndexChanged
        cmd = New SqlCommand("Select * from UsersReg where Full_Name=@user", con)
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = cbodoctor.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then
            LblDocID.Text = tbl.Rows(0)(0).ToString


            ' Else
        End If

    End Sub

    Private Sub txtTemp_Leave(sender As Object, e As EventArgs) Handles txtTemp.Leave

        If Val(txtTemp.Text) > 37 Then
            txtTemp.ForeColor = Color.Red

        End If
    End Sub
End Class