Imports System.Data.SqlClient

Public Class NurseReport

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            Txtnote.Focus()
        ElseIf Txtnote.Text = "" Then
            MsgBox("REPORT FIELD IS EMPTY", MsgBoxStyle.Information, "Medx-pro")
            Txtnote.Focus()
        Else
            Try

                ' cmd.CommandType = System.Data.CommandType.Text
                'cmd.CommandText = "insert into NurseReport Values ('" & FrmAdmitFolder.LbladmitID.Text & "','" & FrmAdmitFolder.Lblhospnum.Text & "', '" & frmMain.lbldate.Text & "', 
                '" & frmMain.lbltime.Text & "', '" & Txtnote.Text & "', '" & lblnursename.Text & "')"

                cmd = New SqlCommand("INSERT INTO NurseReport VALUES(@AdmId, @hnum, @Dtes, @Tm, @Not, @Snam)", con)

                cmd.Parameters.Add("@AdmId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                cmd.Parameters.Add("@Tm", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                cmd.Parameters.Add("@Not", SqlDbType.NVarChar).Value = Txtnote.Text
                cmd.Parameters.Add("@Snam", SqlDbType.VarChar).Value = lblnursename.Text


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

        LoadNurseReport()
    End Sub

    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            lblnursename.Text = tbl.Rows(0)(1).ToString()

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
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "Medx-pro")
            Txtnote.Focus()


        Else

        End If
    End Sub

    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub LoadNurseReport()

        Dim tb As New DataTable
        cmd = New SqlCommand("Select Date, Time, Note, Reported_By FROM NurseReport WHERE Admission_ID='" & FrmAdmitFolder.LbladmitID.Text & "'", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        Dtgreport.DataSource = tb

    End Sub

    Private Sub Dtgreport_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dtgreport.CellMouseClick
        Txtnote.Text = Dtgreport.CurrentRow.Cells(2).Value.ToString
        Btnsave.Enabled = False
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Txtnote.Text = ""
        Txtpass.Text = ""
        Btnsave.Enabled = True

    End Sub


End Class
