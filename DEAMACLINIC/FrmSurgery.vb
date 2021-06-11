Imports System.Data.SqlClient

Public Class FrmSurgery
    Private Sub FrmSurgery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PreOpVisit1.BringToFront()
        PreOpVisit1.LOadPreOp()

        BtnSAve.Visible = False
        Label10.Visible = False

        txtpass.Visible = False

    End Sub
    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaff.Click
        SurgicalTeam1.BringToFront()
        SurgicalTeam1.LoadSurgTeam()
        'BtnSAve.Visible = True
        ' Label10.Visible = True
        'lbluser.Visible = True
        '  txtpass.Visible = True
    End Sub
    Private Sub BtnOpNote_Click(sender As Object, e As EventArgs) Handles BtnOpNote.Click
        OperatioNote1.BringToFront()
        OperatioNote1.LoadOpNotes()
        '  BtnSAve.Visible = True
        ' Label10.Visible = True
        ' lbluser.Visible = True
        'txtpass.Visible = True
    End Sub
    Private Sub BtnPostOp_Click(sender As Object, e As EventArgs) Handles BtnPostOp.Click
        PostOpOrder1.BringToFront()
        PostOpOrder1.LoadSurgTeam()
        ' BtnSAve.Visible = True
        'Label10.Visible = True
        'lbluser.Visible = True
        'txtpass.Visible = True
    End Sub
    Private Sub BtnSAve_Click(sender As Object, e As EventArgs) Handles BtnSAve.Click
        If txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "User Validation")
            TxtInstr.Focus()

        ElseIf OperatioNote1.Txtproced.Text = "" And PostOpOrder1.Txtpostop.Text = "" Then
            MsgBox("PLEASE COMPLETE SURGICAL ENTRIES (e.g Postop order)", MsgBoxStyle.Information, "Medx-pro")

        Else
            SurgicalTeam1.SAVESURGTEAM()
            OperatioNote1.SaveOPNote()
            UpdateSurgRequest()

            MsgBox("SAVED SUCCESSFULLY", MsgBoxStyle.Information, "Medx-pro")

            txtpass.Text = ""

            Me.Close()

            FrmTheartre.LoadSurgery()
            FrmTheartre.LoadTreatSurgery()

        End If
    End Sub
    Private Sub BtnPreOp_Click(sender As Object, e As EventArgs) Handles BtnPreOp.Click
        PreOpVisit1.BringToFront()
        PreOpVisit1.LOadPreOp()

        BtnSAve.Visible = False
        Label10.Visible = False
        ' lbluser.Visible = False
        txtpass.Visible = False
    End Sub
    Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            TxtInstr.Focus()


        Else

        End If
    End Sub
    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtpass.Text

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
        CheckPassowrd()
        showusername()
    End Sub
    Sub UpdateSurgRequest()
        Try
            cmd = New SqlCommand("UPDATE Surgery_Request SET  Status=@stat WHERE Hospital_Num=@Hno AND Surg_ID=@Sid")
            cmd.Parameters.Add("@Stat", SqlDbType.VarChar).Value = Lbltreated.Text
            cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = TxthospNo.Text
            cmd.Parameters.Add("@Sid", SqlDbType.Int).Value = Lblsurgid.Text

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while updating Surgery status", "Medx-pro", MessageBoxButtons.OK)

        End Try
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "User Validation")
            TxtInstr.Focus()
        Else

            SurgicalTeam1.UpdateSurgTeam()
            OperatioNote1.UpdateOpNotes()

            MsgBox("UPDATED SUCCESSFULLY", MsgBoxStyle.Information, "Medx-pro")

            txtpass.Text = ""
            Me.Close()

            FrmTheartre.LoadSurgery()
            FrmTheartre.LoadTreatSurgery()

        End If
    End Sub
    Private Sub BtnDrugs_Click(sender As Object, e As EventArgs) Handles BtnDrugs.Click
        BtnSAve.Visible = False
        BtnUpdate.Visible = False
        txtpass.Visible = False
        Label10.Visible = False

        TheatreDrugs1.BringToFront()
    End Sub
    Private Sub BtnRad_Click(sender As Object, e As EventArgs) Handles BtnRad.Click
        BtnSAve.Visible = False
        BtnUpdate.Visible = False
        txtpass.Visible = False
        Label10.Visible = False

        TheatreScan1.BringToFront()
    End Sub
    Private Sub BtnLab_Click(sender As Object, e As EventArgs) Handles BtnLab.Click
        BtnSAve.Visible = False
        BtnUpdate.Visible = False
        txtpass.Visible = False
        Label10.Visible = False

        TheatreLAb1.BringToFront()
    End Sub

End Class