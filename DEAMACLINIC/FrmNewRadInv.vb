Imports System.Data.SqlClient
Public Class FrmNewRadInv
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub SAveNewTest()

        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Xray_ScanList VALUES ('" & TxtTest.Text & "', '" & Txtcomm.Text & "', '" & Cbogroup.Text & "', '" & TxtPrivCost.Text & "')"


            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("INVESTIGATION SUCCESSFULLY ADDED", MsgBoxStyle.OkOnly, "RADIOLOGY")

            TxtPrivCost.Text = ""
            TxtTest.Text = ""
            Txtcomm.Text = ""
            Cbogroup.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        frmLabTestList.LoadAllTestLIst()
    End Sub

    Public Sub UpdateTEST()

        Try
            Dim Updat As String = "Update Xray_ScanList Set INVESTIGATION='" & TxtTest.Text & "', GROUPS='" & Cbogroup.Text & "', COST='" & TxtPrivCost.Text & "' WHERE INVESTIGATION='" & FrmScanlist.DtgRadlist.CurrentRow.Cells(0).Value & "' "
            con.Open()
            ExecuteQuery(Updat)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Me.Close()
        FrmScanlist.LoadsCANLIst()

    End Sub

    Private Sub BtnSavetest_Click(sender As Object, e As EventArgs) Handles BtnSavetest.Click
        SAveNewTest()
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles Btnedit.Click
        UpdateTEST()
    End Sub
End Class