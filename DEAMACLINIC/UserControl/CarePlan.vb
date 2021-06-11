Imports System.Data.SqlClient

Public Class CarePlan
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-pro")
            TxtDiagnosis.Focus()
        ElseIf TxtDiagnosis.Text = "" Then
            MsgBox("FIELDs CANNOT BE EMPTY", MsgBoxStyle.Information, "Medx-pro")
            TxtDiagnosis.Focus()
        Else
            Try

                ' cmd.CommandType = System.Data.CommandType.Text
                'cmd.CommandText = "insert into NurseReport Values ('" & FrmAdmitFolder.LbladmitID.Text & "','" & FrmAdmitFolder.Lblhospnum.Text & "', '" & frmMain.lbldate.Text & "', 
                '" & frmMain.lbltime.Text & "', '" & Txtnote.Text & "', '" & lblnursename.Text & "')"

                cmd = New SqlCommand("INSERT INTO NurseCarePlan VALUES(@Dtes, @Tim, @hnum, @AdmId, @Diag, @Obj, @Nurs, @Eval,  @EntBy)", con)

                cmd.Parameters.Add("@Dtes", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                cmd.Parameters.Add("@Tim", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = FrmAdmitFolder.Lblhospnum.Text
                cmd.Parameters.Add("@AdmId", SqlDbType.Int).Value = FrmAdmitFolder.LbladmitID.Text
                cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = TxtDiagnosis.Text
                cmd.Parameters.Add("@Obj", SqlDbType.VarChar).Value = TxtObjec.Text
                cmd.Parameters.Add("@Nurs", SqlDbType.VarChar).Value = TxtNursOrd.Text
                cmd.Parameters.Add("@Eval", SqlDbType.VarChar).Value = TxtEval.Text
                cmd.Parameters.Add("@EntBy", SqlDbType.VarChar).Value = lblnursename.Text

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            con.Close()
            TxtNursOrd.Text = ""
            TxtObjec.Text = ""
            TxtDiagnosis.Text = ""
            TxtEval.Text = ""
            Txtpass.Text = ""
        End If

        LoadNurseCare()

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
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            TxtDiagnosis.Focus()


        Else

        End If
    End Sub

    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub LoadNurseCare()

        Dim tb As New DataTable
        cmd = New SqlCommand("Select Date, Time, Diagnosis, Objectives, Nursing_Order, Evaluation FROM NurseCarePlan WHERE AdmissionID='" & FrmAdmitFolder.LbladmitID.Text & "'", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        Dtgcareplan.DataSource = tb

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        TxtNursOrd.Text = ""
        TxtDiagnosis.Text = ""
        TxtEval.Text = ""
        TxtObjec.Text = ""
        Txtpass.Text = ""
        Btnsave.Enabled = True

    End Sub

    Private Sub Dtgcareplan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dtgcareplan.CellMouseClick
        TxtDiagnosis.Text = Dtgcareplan.CurrentRow.Cells(2).Value.ToString
        TxtObjec.Text = Dtgcareplan.CurrentRow.Cells(3).Value.ToString
        TxtNursOrd.Text = Dtgcareplan.CurrentRow.Cells(4).Value.ToString
        TxtEval.Text = Dtgcareplan.CurrentRow.Cells(5).Value.ToString

        Btnsave.Enabled = False
    End Sub

End Class
