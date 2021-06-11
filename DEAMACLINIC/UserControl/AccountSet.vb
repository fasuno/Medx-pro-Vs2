Imports System.Data.SqlClient

Public Class AccountSet

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into BillSetting Values ('" & txtacctType.Text & "', '" & txtperc.Text & "', '" & txtcomp.Text.ToString & "', '" & txtaddr.Text & "', '" & txtcontact.Text & "', '" & txtphone.Text & "',  '" & txtemail.Text & "', '" & Lblacctid.Text & "', '" & Cbocat.Text & "')"

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()

            MsgBox("NEW ACCOUNT CREATED", vbOKOnly, "PATIENT ACCOUNT")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()

        txtacctType.Text = ""
        txtaddr.Text = ""
        txtcomp.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
        txtperc.Text = ""
        txtphone.Text = ""
        txtacctType.Focus()

    End Sub

    Private Sub txtperc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtperc.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub Btnclr_Click(sender As Object, e As EventArgs) Handles Btnclr.Click
        txtacctType.Text = ""
        txtaddr.Text = ""
        txtcomp.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
        txtperc.Text = ""
        txtphone.Text = ""
        Cbocat.Text = ""
        txtacctType.Focus()
    End Sub

End Class
