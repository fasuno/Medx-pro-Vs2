Imports System.Data.SqlClient

Public Class FrmBiller
    Public Sub generatenum()

        Try

            con.Open()

            cmd = New SqlCommand("Select  MAX(Service_No) from PendingBills", con)

            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then


                '// The for statement will fill all cells in presc number column with the same value that the above sql statement genegrate

                'For Col As Integer = 0 To dgprescription.Rows.Count() - 1
                ' dgprescription.Rows(Col).Cells(0).Value = dt.Item(0) + 1
                ' Next

                Me.Txtservno.Text = dt.Item(0) + 1
                dt.Close()
                'Else

                ' con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub Loadservice()

        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select Service from Services", con)
            adapt = New SqlDataAdapter(cmd)

            'con.Open()   ' Open connection
            adapt.Fill(tbl)

            Dim rw As DataRow

            TxtService.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                TxtService.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If Txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "Medx-pro")

        Else

            Dim res As MsgBoxResult
            res = MsgBox("SEND THIS BILL?", MsgBoxStyle.YesNo, "Medx-pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    cmd = New SqlCommand("INSERT INTO PendingBills VALUES(@Snum, @Dte, @Tim, @Hnum, @Sname, @Oname, @Tcst, @Serv, @ActType, @Bby, @ActCat, @Paym)", con)

                    cmd.Parameters.Add("@Snum", SqlDbType.Int).Value = Txtservno.Text
                    cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = Convert.ToDateTime(frmMain.lbldate.Text).Date
                    cmd.Parameters.Add("@tim", SqlDbType.Time).Value = Convert.ToDateTime(frmMain.lbltime.Text).TimeOfDay
                    cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = Txthnum.Text
                    cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = txtSname.Text
                    cmd.Parameters.Add("@oname", SqlDbType.VarChar).Value = TxtOname.Text
                    cmd.Parameters.Add("@Tcst", SqlDbType.Int).Value = TxtTotcost.Text
                    cmd.Parameters.Add("@Serv", SqlDbType.NVarChar).Value = TxtService.Text
                    cmd.Parameters.Add("@ActType", SqlDbType.NVarChar).Value = txtaccnt.Text
                    cmd.Parameters.Add("@Bby", SqlDbType.NVarChar).Value = Lbluser.Text
                    cmd.Parameters.Add("@ActCat", SqlDbType.VarChar).Value = TxtAcctCat.Text
                    cmd.Parameters.Add("@Paym", SqlDbType.VarChar).Value = DBNull.Value

                    cmd.Connection = con

                    con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    '      MsgBox("PATIENT BILL", MsgBoxStyle.Information, "Medx-pro"

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                Me.Close()

                frmCashier.sortPendingBilss()

            Else
                TxtTotcost.Focus()

            End If
        End If
    End Sub
    Private Sub FrmBiller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadservice()
        generatenum()
    End Sub
    Sub showusername()

        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            Lbluser.Text = tbl.Rows(0)(1).ToString()

        Else
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            Txtpassword.Focus()

        End If

    End Sub
    Private Sub Txtpassword_Leave(sender As Object, e As EventArgs) Handles Txtpassword.Leave
        showusername()
    End Sub


End Class