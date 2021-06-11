Imports System.Data.SqlClient

Public Class FrmNewdrugs

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Try
            ' Dim Updat As String = "UPDATE Drug_List SET  Reorder_Level='" & txtRoderlev.Text.ToString & "', Stock_Bal='" & txtstockbal.Text.ToString & "', New_Stock='" & txtnewstock.Text.ToString & "', Unit_Cost='" & txtcostperunit.Text.ToString & "', Entry_By='" & lblusername.Text.ToString & "' WHERE Category='" & cbodrugcat.Text & "'"

            Dim Updat As String = "UPDATE Drug_List SET Drug_Name='" & txtdrugname.Text.ToString & "', Reorder_Level='" & txtRoderlev.Text.ToString & "', Batch_No='" & TxtBatchno.Text.ToString & "', Location='" & TxtLocat.Text.ToString & "', Unit='" & cbounit.Text.ToString & "', Category='" & cbodrugcat.Text.ToString & "', Stock_Bal='" & txtstockbal.Text.ToString & "', New_Stock='" & txtnewstock.Text.ToString & "', Unit_Cost='" & txtcostperunit.Text.ToString & "', Entry_By='" & lblusername.Text.ToString & "' WHERE Drug_Id='" & txtdrugid.Text & "'"

            con.Open()
            ExecuteQuery(Updat)
            MessageBox.Show(" DRIGS DETAILS UPDATED SUCCESSFULLY", "PHARMACY", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        txtnewstock.Text = ""

        txtstockbal.Text = ""
        txtcostperunit.Text = ""

        txtpassw.Text = ""
        lblusername.Text = ""
        TxtLocat.Text = ""
        txtdrugname.Text = ""



        'Me.Close()

        frmAllDrugs.LoadAllDrugLIst()
    End Sub

    Public Sub CheckPassowrd()
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass AND Role=@rol", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtpassw.Text
        cmd.Parameters.Add("@rol", SqlDbType.VarChar).Value = frmMain.lblrole.Text
        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            lblusername.Text = tbl.Rows(0)(1).ToString()
        End If
    End Sub

    Private Sub txtnewstock_Leave(sender As Object, e As EventArgs) Handles txtnewstock.Leave
        Dim st As Integer
        Dim ns As Integer
        Dim sum As Integer
        st = Val(txtstockbal.Text)
        ns = Val(txtnewstock.Text)
        sum = st + ns
        txtstockbal.Text = sum
    End Sub

    Private Sub FrmNewdrugs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbldate.Text = Now.Date
    End Sub

    Private Sub txtpassw_Leave(sender As Object, e As EventArgs) Handles txtpassw.Leave
        CheckPassowrd()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub


End Class