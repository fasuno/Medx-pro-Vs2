Imports System.Data.SqlClient
Public Class Addroles

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub Btnaddrole_Click(sender As Object, e As EventArgs) Handles Btnaddrole.Click
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into UsersRole VALUES ('" & txtrole.Text & "', '" & txtdecr.Text & "')"

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("ROLE SUCCESSFULLY ADDED", MsgBoxStyle.OkOnly, "Medx-pro")

            txtdecr.Text = ""
            txtrole.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Loadrole()
    End Sub
    Public Sub Loadrole()

        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from UsersRole", con)

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        dgvrole.DataSource = tbl
        dgvrole.AutoResizeColumns()
        dgvrole.ReadOnly = True
        dgvrole.Columns(0).Visible = False


    End Sub
    Private Sub Addroles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrole()
    End Sub

End Class
