Imports System.Data.SqlClient

Public Class FrmPrintreceipt

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

    Private Sub FrmPrintreceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lblptname.Text = FrmReceipts.txtname.Text
        lblhospnum.Text = FrmReceipts.Txthnum.Text
        Lblaccount.Text = FrmReceipts.txtaccnt.Text
        lblservice.Text = FrmReceipts.Txtserv.Text
        lblrcptnum.Text = FrmReceipts.LblReceiptnum.Text
        lbldate.Text = FrmReceipts.lbldate.Text + " | " + FrmReceipts.lbltime.Text
        lbltotalamnt.Text = FrmReceipts.lblBill.Text.ToString
        Lblcashier.Text = FrmReceipts.lblcashiername.Text

        '************************AMOUNT IN WORDS The function is found in "connstring" module **********************************
        Lblamntword.Text = NumberToText(lbltotalamnt.Text) & "naira Only"
        '===================================================================================================================

        PrintDocument1.PrinterSettings.Copies = 2


        PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.Document.PrinterSettings.Copies = 2
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1

        PrintPreviewDialog1.ShowDialog()





        Me.Close()
    End Sub

    Public Sub Showdrugs()

        If lblservice.Text = "Pharmacy" Then

            Dim tbl As New DataTable()
            cmd = New SqlCommand("Select Drug_Name AS Drug, Prescription AS Presc, Total_cost AS Cost from AllDrugsBilled WHERE Presc_num=@Pnum", con)
            cmd.Parameters.Add("@Pnum", SqlDbType.Int).Value = FrmReceipts.Txtservno.Text


            Dim adpter As New SqlDataAdapter(cmd)
            adpter.Fill(tbl)

            'dgvrcpt.DataSource = tbl

            'dgvrcpt.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            ' dgvrcpt.Columns(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            'dgvrcpt.Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            'resizeDGV()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)

        'PrintPreviewDialog1.Close()


    End Sub



End Class