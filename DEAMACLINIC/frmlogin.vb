
Imports System.Data.SqlClient

Public Class frmlogin

    Sub showCompname()

        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from Companyinfo", con)

        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()

        adp.Fill(tb)

        If tb.Rows.Count() > 0 Then

            frmMain.lblhospname.Text = tb.Rows(0)(0).ToString()

        Else
        End If

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim cmd As New SqlCommand("Select * from UsersReg where Username = @Username and Password = @password", con)

        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtusername.Text

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassword.Text


        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() <= 0 Then
            MsgBox("LOG IN FAILED! PLEASE TRY AGAIN", MsgBoxStyle.OkOnly, "Medx-pro")

            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        Else
            Me.Hide()
            'frmMain.lblmail.Text = txtusername.Text
            frmMain.ToolxPanel.Visible = True
            frmMain.Panel1.Visible = True
            frmMain.showusername()
            showCompname()
        End If

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub
End Class