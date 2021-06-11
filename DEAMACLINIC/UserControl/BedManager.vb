Imports System.Data.SqlClient

Public Class BedManager

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Txtbedno.Text = "" Or cbobedname.Text = "" Or Txtbedfee.Text = "" Then

            MsgBox("ALL FIELDS ARE REQUIRED", MsgBoxStyle.Critical, "BED LIST")
        Else
            '=======CHECK IF BED EXIST==========

            Dim cmd As New SqlCommand("Select * from Bedlist where Bed_no = @Bno and Ward_name=@wnam", con)

            cmd.Parameters.Add("@Bno", SqlDbType.Int).Value = Txtbedno.Text
            cmd.Parameters.Add("@wnam", SqlDbType.VarChar).Value = cbobedname.Text

            Dim adpt As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

            adpt.Fill(tbl)

            If tbl.Rows.Count() > 0 Then
                MsgBox("BED NUMBER ALREADY EXIST", MsgBoxStyle.Critical, "BED LIST")
                Txtbedno.Focus()

            Else

                Try

                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "insert into Bedlist Values ('" & Txtbedno.Text & "', '" & cbobedname.Text & "', '" & Txtbedfee.Text & "','" & lblstatus.Text & "')"

                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()

                    MsgBox("NEW BED CREATED", vbOKOnly, "BED LIST")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                con.Close()

                Txtbedfee.Text = ""
                Txtbedno.Text = ""
                cbobedname.Text = ""

                LoadBedlist()
            End If
        End If
    End Sub

    Private Sub Txtbedno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtbedno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub Txtbedfee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtbedfee.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim Delquery As String = " Delete From Bedlist Where Bed_ID = '" & Dgvbedlist.CurrentRow.Cells(0).Value & "'"

        ExecuteQuery(Delquery)
        MsgBox("SELECTED BED HAS BEEN DELETED", vbOKOnly, "BED LIST")

        Txtbedno.Text = ""
        Txtbedfee.Text = ""
        cbobedname.Text = ""
        Txtbedno.Focus()
        LoadBedlist()
    End Sub

    Public Sub LoadBedlist()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from Bedlist", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        Dgvbedlist.DataSource = tbl
        'con.Close()     '
    End Sub

    Private Sub BedManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBedlist()
        FrmSettings.BedManager1.Btnsave.BringToFront()
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Try
            Dim Updat As String = "Update BedList Set Bed_No='" & Txtbedno.Text & "', Ward_Name='" & cbobedname.Text & "', Charges='" & Txtbedfee.Text & "', Bed_Status='" & lblstatus.Text & "' WHERE Bed_ID='" & lblbedid.Text & "' "

            con.Open()
            ExecuteQuery(Updat)
            'con.Close()

            MsgBox("SELECTED BED HAS BEEN DELETED", vbOKOnly, "BED LIST")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Txtbedno.Text = ""
        Txtbedfee.Text = ""
        cbobedname.Text = ""
        Txtbedno.Focus()

        LoadBedlist()
    End Sub

    Private Sub Dgvbedlist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvbedlist.CellDoubleClick

        FrmSettings.BedManager1.lblbedid.Text = Dgvbedlist.CurrentRow.Cells(0).Value
        FrmSettings.BedManager1.Txtbedno.Text = Dgvbedlist.CurrentRow.Cells(1).Value
        FrmSettings.BedManager1.cbobedname.Text = Dgvbedlist.CurrentRow.Cells(2).Value
        FrmSettings.BedManager1.Txtbedfee.Text = Dgvbedlist.CurrentRow.Cells(3).Value
        FrmSettings.BedManager1.lblstatus.Text = Dgvbedlist.CurrentRow.Cells(4).Value

        FrmSettings.BedManager1.btnupd.BringToFront()

    End Sub


End Class
