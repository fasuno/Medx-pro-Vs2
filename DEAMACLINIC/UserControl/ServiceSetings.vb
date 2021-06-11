Imports System.Data.SqlClient

Public Class ServiceSetings

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub Btnaddserv_Click(sender As Object, e As EventArgs) Handles Btnaddserv.Click
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Services VALUES ('" & txtserv.Text & "')"

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("SERVICE SUCCESSFULLY ADDED", MsgBoxStyle.OkOnly, "SETTINGS")

            txtserv.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        LoadService()
    End Sub

    Public Sub LoadService()

        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from Services", con)

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        dtgservice.DataSource = tbl
        dtgservice.AutoResizeColumns()
        dtgservice.ReadOnly = True

    End Sub

    Private Sub ServiceSetings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadService()
    End Sub

End Class
