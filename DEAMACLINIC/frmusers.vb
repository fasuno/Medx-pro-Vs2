Imports System.Data.SqlClient

Public Class frmusers

    Public Sub ExecuteQuery(query As String)
        Dim cmd As New SqlCommand(query, Con)
        con.Close()

        con.Open()
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Hide()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtpassword.Text = "" And txtusername.Text = "" Then
            MsgBox("USERNAME/PASSWORD FIELD CANNOT BE EMPTY", MsgBoxStyle.Information, "Medx-pro")
            txtusername.Focus()
        Else

            con.Open()

        Dim cmd As New SqlCommand("Select * from UsersReg Where Username=@User AND Password=@Pw", con)

        cmd.Parameters.AddWithValue("@User", txtusername.Text)
        cmd.Parameters.AddWithValue("@Pw", txtpassword.Text)

        Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("THE USERNAME/PASSWORD ALREADY EXIST, PLEASE CHOOSE ANOTHER", MsgBoxStyle.Information, "Medx-pro")
                txtusername.Text = ""
                txtusername.Focus()

                con.Close()

            Else


                dr.Close()

                Try
                    cmd.CommandType = System.Data.CommandType.Text

                    cmd.CommandText = "INSERT INTO  UsersReg VALUES('" & txtfullname.Text & "', '" & txtusername.Text & "', '" & txtpassword.Text & "', '" & Txtroleid.Text & "','" & cborole.Text & "')"

                    cmd.Connection = con
                    cmd.ExecuteNonQuery()

                    MsgBox("NEW USER CREATED", MsgBoxStyle.Information, "Medx-pro")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

                Txtroleid.Text = ""
                txtfullname.Text = ""
                txtusername.Text = ""
                txtpassword.Text = ""
                cborole.Text = ""

                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Dim updateQuery As String = "Update UsersReg Set  Roleid= '" & Txtroleid.Text & "', Full_name = '" & txtfullname.Text & "', Username = '" & txtusername.Text & "', Password = '" & txtpassword.Text & "', Role= '" & cborole.Text & "' WHERE User_id = '" & TxtuserId.Text & "'"

        ExecuteQuery(updateQuery)

        MessageBox.Show("USER DETAILS SUCCESSFULLY EDITED")

        TxtuserId.Text = ""
        txtfullname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        Txtroleid.Text = ""
        cborole.Text = ""

        Me.Close()
    End Sub

    Public Sub PopulaeUSersrole()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Role from UsersRole ", con)


        adapt = New SqlDataAdapter(cmd)

        ' con.Open()   ' Open connection

        adapt.Fill(tbl)
        cborole.DataSource = tbl
        cborole.DisplayMember = "Role"

        ' con.Close()

    End Sub

    Private Sub frmusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadALLUsers()
        PopulaeUSersrole()
        cborole.Text = ""
        btnsave.BringToFront()
    End Sub

    Public Sub showuroleID()

        cmd = New SqlCommand("Select * from UsersRole where Role=@rol", con)
        cmd.Parameters.Add("@rol", SqlDbType.VarChar).Value = cborole.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display Role ID

            Txtroleid.Text = tbl.Rows(0)(0).ToString()

        Else


        End If

    End Sub

    Private Sub cborole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cborole.SelectedIndexChanged
        showuroleID()

    End Sub

    Public Sub LoadALLUsers()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select User_Id, Full_Name, Username, Password, Role FROM UsersReg ", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Dgvusers.DataSource = tbl
        Dgvusers.Columns(0).Visible = False
        Dgvusers.Columns(3).Visible = False
        Dgvusers.AutoResizeColumns()

    End Sub

    Private Sub Dgvusers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvusers.CellDoubleClick

        txtfullname.Text = Dgvusers.CurrentRow.Cells(1).Value.ToString
        TxtuserId.Text = Dgvusers.CurrentRow.Cells(0).Value.ToString
        txtusername.Text = Dgvusers.CurrentRow.Cells(2).Value.ToString
        txtpassword.Text = Dgvusers.CurrentRow.Cells(3).Value.ToString
        cborole.Text = Dgvusers.CurrentRow.Cells(4).Value.ToString

        btnupdate.BringToFront()
    End Sub

    Private Sub TxtConf_Leave(sender As Object, e As EventArgs) Handles TxtConf.Leave
        If txtpassword.Text = TxtConf.Text Then
            cborole.Focus()
        Else
            MsgBox("THE PASSWORD DOES NOT MATCH", MsgBoxStyle.Information, "Medx-pro")
            txtpassword.Text = ""
            TxtConf.Text = ""
            txtpassword.Focus()
        End If
    End Sub
End Class