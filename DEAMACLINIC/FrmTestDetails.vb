Imports System.Data.SqlClient
Public Class FrmTestDetails
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub FrmTestDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTestDetails()
        'TxtTest.Text = FrmNewLabTest.TxtTest.Text
        LoadSubLabTestPara()
    End Sub

    Private Sub BtnAdddetails_Click(sender As Object, e As EventArgs) Handles BtnAdddetails.Click

        CheckForExistingTest()  '// It check and if it does not exist go ahead and save

        TxtTestPara.Text = ""
        txtParMeasure.Text = ""
        TxtParLowRang.Text = ""
        TxtparHighrange.Text = ""
        TxtTestPara.Focus()

        con.Close()

    End Sub

    Public Sub AddTestDeails()
        '// Note: lblresult is to hold a space for entrying result later
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into LabTest_Details VALUES ('" & TxtTest.Text & "', '" & TxtTestPara.Text & "', '" & lblresult.Text & "', '" & txtParMeasure.Text & "', '" & TxtparHighrange.Text & "', '" & TxtParLowRang.Text & "')"


            cmd.Connection = con

            ' con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("TEST DETAILS SUCCESSFULLY ADDED", MsgBoxStyle.OkOnly, "LABORATORY")


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        LoadTestDetails()

    End Sub

    Public Sub LoadSubLabTestPara()

        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select Subtest from LabSubtest", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()

            adapt.Fill(tbl)

            Dim rw As DataRow

            TxtTestPara.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                TxtTestPara.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

        'Me.dtgLabrequest.Rows.Clear()

    End Sub

    Public Sub LoadTestDetails()

        cmd = New SqlCommand("Select Test, Child_range, Adult_range, Measure from LabTest_Details where Test_name=@Tname ", con)

        cmd.Parameters.Add("@Tname", SqlDbType.NVarChar).Value = FrmNewLabTest.TxtTest.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tabl As New DataTable

        adapt.Fill(tabl)
        If tabl.Rows.Count() > 0 Then
            DtgTestPar.DataSource = tabl
            DtgTestPar.AutoResizeColumns()
        Else

            MessageBox.Show("NO TEST PARAMETER FOUND FOR THIS TEST", "LABORATORY", MessageBoxButtons.OK)
            TxtTest.Focus()
            DtgTestPar.DataSource = Nothing
        End If

    End Sub

    Private Sub BtnEditdtails_Click(sender As Object, e As EventArgs) Handles BtnEditdtails.Click

        Try

            Dim Updat As String = "Update LabTest_Details Set Test='" & TxtTestPara.Text & "', Measure='" & txtParMeasure.Text & "', Child_Range='" & TxtparHighrange.Text & "', Adult_Range='" & TxtParLowRang.Text & "' WHERE Test_Name='" & TxtTest.Text & "' AND Test='" & DtgTestPar.CurrentRow.Cells(0).Value & "' "

            con.Open()
            ExecuteQuery(Updat)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        TxtTestPara.Text = ""
        txtParMeasure.Text = ""
        TxtParLowRang.Text = ""
        TxtparHighrange.Text = ""
        TxtTestPara.Focus()
        BtnAdddetails.BringToFront()
        LoadTestDetails()
    End Sub

    Public Sub CheckForExistingTest()

        con.Open()

        cmd = New SqlCommand("Select * from LabTest_Details WHERE Test_Name=@Tname AND Test=@Tst", con)


        cmd.Parameters.Add("@Tname", SqlDbType.VarChar).Value = TxtTest.Text
        cmd.Parameters.Add("@Tst", SqlDbType.VarChar).Value = TxtTestPara.Text

        Using dtr As SqlDataReader = cmd.ExecuteReader

            If dtr.HasRows Then

                MsgBox("TEST PARAMETER ALREADY EXIST", MsgBoxStyle.OkOnly, "LABORATORY")


            Else

                dtr.Close()

                AddTestDeails()

                ' con.Close()

            End If
        End Using



    End Sub

    Private Sub Btnremove_Click(sender As Object, e As EventArgs) Handles Btnremove.Click


        Dim Delquery As String = " Delete From LabTest_Details  WHERE Test_Name='" & TxtTest.Text & "' AND Test='" & TxtTestPara.Text & "' "
        con.Open()
        ExecuteQuery(Delquery)

        LoadTestDetails()
    End Sub

    Private Sub DtgTestPar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgTestPar.CellClick

        TxtTestPara.Text = DtgTestPar.CurrentRow.Cells(0).Value.ToString
        txtParMeasure.Text = DtgTestPar.CurrentRow.Cells(3).Value.ToString
        ' TxtParLowRang.Text = DtgTestPar.CurrentRow.Cells(1).Value.ToString
        TxtParLowRang.Text = DtgTestPar.CurrentRow.Cells(2).Value.ToString
        TxtparHighrange.Text = DtgTestPar.CurrentRow.Cells(1).Value.ToString

        BtnEditdtails.BringToFront()
    End Sub

End Class