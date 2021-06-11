Imports System.Data.SqlClient

Public Class frmPrinRAdrqst

    Public Sub showCompDetails()

        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from Companyinfo", con)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then


            lblcompname.Text = tbl.Rows(0)(0).ToString()
            lblph.Text = tbl.Rows(0)(2).ToString() + ", email:" + tbl.Rows(0)(3).ToString()
            ' txtphone.Text = tbl.Rows(0)(2).ToString()
            'txtemail.Text = tbl.Rows(0)(3).ToString()

        Else
        End If

    End Sub

    Private Sub frmPrinRAdrqst_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        showCompDetails()
        lbldate.Text = Now.Date
        Showlabtest()

        PrintPreviewDialog1.Document = PrintDocument1

        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.Document.PrinterSettings.Copies = 2
        PrintPreviewDialog1.ShowDialog()

        Me.Close()
    End Sub


    Dim drs As SqlDataReader
    Dim sqls As String

    Public Sub Showlabtest()

        Dim Y As Integer
        Dim btbls As New DataTable()

        cmd = New SqlCommand("Select Investigation, Comment from RadRequestAndResult WHERE Request_Num= '" & LBLID.Text & "'", con)

        Dim adpter As New SqlDataAdapter(cmd)

        adpter.Fill(btbls)

        Dgvradprint.DataSource = btbls

        Dgvradprint.Height += 19
        If Y = 19 Then

            Y += 19
            Panel1.Height += Y
            Me.Height += Y
            Dgvradprint.Height += Y
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
        aPS.PrinterSettings.Copies = 2

    End Sub

    Private Sub Dgvradprint_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles Dgvradprint.RowsAdded
        If sender.Rows.Count > 0 Then
            Dim newHeight As Integer = 0
            For Each row As DataGridViewRow In sender.Rows
                newHeight += row.Height
            Next

            ' Need to have this size doubled to give the buffer room for horizontal scroll bar.
            ' without it, if the horizontal scroll bar is displayed, then it will put in the 
            ' vertical scroll bar for the last row. If the column headers are hidden, then 
            ' add the height of the first row.

            If sender.ColumnHeadersVisible Then
                newHeight += sender.ColumnHeadersHeight * 2
            Else
                newHeight += sender.Rows(0).Height
            End If
            sender.Height = newHeight


        End If
    End Sub
End Class