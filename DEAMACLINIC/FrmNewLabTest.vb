Imports System.Data.SqlClient

Public Class FrmNewLabTest

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub FrmNewLabTest_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        TxtCompCost.Text = ""
        TxtMeasure.Text = ""
        TxtNhisCost.Text = ""
        TxtPrivCost.Text = ""
        TxtTest.Text = ""
        TxtCompCost.Text = ""
        Cbogroup.Text = ""

    End Sub

    Private Sub BtnTestpar_Click(sender As Object, e As EventArgs) Handles BtnTestpar.Click
        FrmTestDetails.TxtTest.Text = TxtTest.Text
        FrmTestDetails.ShowDialog()
    End Sub

    Public Sub SAveNewTest()

        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into LAB_LIST VALUES ('" & TxtTest.Text & "', '" & Cbogroup.Text & "', '" & TxtPrivCost.Text & "', '" & TxtNhisCost.Text & "', '" & TxtCompCost.Text & "', '" & TxtMeasure.Text & "')"


            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("TEST SUCCESSFULLY ADDED", MsgBoxStyle.OkOnly, "LABORATORY")

            TxtCompCost.Text = ""
            TxtMeasure.Text = ""
            TxtNhisCost.Text = ""
            TxtPrivCost.Text = ""
            TxtTest.Text = ""
            TxtCompCost.Text = ""
            Cbogroup.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        frmLabTestList.LoadAllTestLIst()
    End Sub

    Public Sub UpdateTEST()

        Try
            Dim Updat As String = "Update LAB_LIST Set TEST_NAME='" & TxtTest.Text & "', GROUPS='" & Cbogroup.Text & "', COST='" & TxtPrivCost.Text & "', NHIS='" & TxtNhisCost.Text & "', RETAINERS='" & TxtCompCost.Text & "', MEASURE='" & TxtMeasure.Text & "' WHERE Test_Name='" & frmLabTestList.DtgAllLabTest.CurrentRow.Cells(0).Value & "' "
            con.Open()
            ExecuteQuery(Updat)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Me.Close()
        frmLabTestList.LoadAllTestLIst()
    End Sub

    Private Sub BtnSavetest_Click_1(sender As Object, e As EventArgs) Handles BtnSavetest.Click
        SAveNewTest()
    End Sub

    Private Sub Btnedit_Click_1(sender As Object, e As EventArgs) Handles Btnedit.Click
        UpdateTEST()
    End Sub


End Class
