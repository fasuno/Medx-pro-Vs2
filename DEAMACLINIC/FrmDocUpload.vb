Imports System.Data.SqlClient
Public Class FrmDocUpload
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub Btnbrowse_Click(sender As Object, e As EventArgs) Handles Btnbrowse.Click
        Try
            OpenFileDialog1.Filter = "PDF | *.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                txtfilename.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        Timer1.Start()
    End Sub

    Private Sub FrmDocUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Now.Date
    End Sub

    Public Sub LoadScannefile()

        cmd = New SqlCommand("Select * from ScannedDocs where HospitalNo=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.VarChar).Value = txthospnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        Dgvfile.DataSource = tbl

        Dgvfile.Columns(0).Visible = False
        Dgvfile.Columns(5).Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            '===========================

            Dim fs As System.IO.FileStream = New System.IO.FileStream(txtfilename.Text, IO.FileMode.Open)
            Dim buffer(fs.Length) As Byte
            fs.Read(buffer, 0, fs.Length)
            fs.Close()

            '===============

            con.Open()

            cmd = New SqlCommand("INSERT INTO ScannedDocs VALUES(@date, @Hno, @name, @Doctitle, @Docfname)", con)
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
            cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = txthospnum.Text
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = Txtname.Text
            cmd.Parameters.Add("@Doctitle", SqlDbType.VarChar).Value = txtdoctiltle.Text
            cmd.Parameters.Add("@Docfname", SqlDbType.VarBinary).Value = buffer

            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            cmd.Parameters.Clear()

            MsgBox("Scanned file uploaded successfully.", MsgBoxStyle.Information, "Medx-pro - File upload")
            txtfilename.Text = ""
            txtdoctiltle.Text = ""
            ProgressBar1.Value = 0
        End If
        'con.Close()
        LoadScannefile()
    End Sub

    Private Sub Btnview_Click(sender As Object, e As EventArgs) Handles Btnview.Click
        Try
            con.Open()
            cmd = New SqlCommand("Select * from ScannedDocs where DocID = @ID", con)
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Dgvfile.CurrentRow.Cells(0).Value

            adapt = New SqlDataAdapter(cmd)
            Dim tbl As New DataTable

            adapt.Fill(tbl)
            con.Close()

            'Convert byte[] to pdf
            If tbl.Rows.Count > 0 Then
                Dim bArray As Byte() = CType(tbl.Rows(0).Item("File_Name"), Byte())
                If bArray.Length > 0 Then

                    Dim fs As System.IO.FileStream = New System.IO.FileStream("Test.pdf", IO.FileMode.Create)
                    fs.Write(bArray, 0, bArray.Length)
                    fs.Close()

                    '==========OPEN THE FILE IN ACROBAT

                    Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
                    startInfo.FileName = "AcroRd32.exe"
                    startInfo.Arguments = "Test.pdf"
                    Process.Start(startInfo)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try


    End Sub

    Private Sub Btndel_Click(sender As Object, e As EventArgs) Handles Btndel.Click
        Dim Delquery As String = " Delete From ScannedDocs Where DocID = '" & Dgvfile.CurrentRow.Cells(0).Value & "'"

        ExecuteQuery(Delquery)
        MsgBox("FILE DELETED", vbOKOnly, "Medx-pro")


        txtdoctiltle.Focus()
        LoadScannefile()
    End Sub


End Class