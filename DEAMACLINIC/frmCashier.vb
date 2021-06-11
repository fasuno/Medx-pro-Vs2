
Imports System.Data.SqlClient

Public Class frmCashier

    Sub GetPOSTotals()

        cmd = New SqlCommand("Select * from [VwReceiptsSumm] WHERE Time_paid BETWEEN @stms AND @Etms AND Payment_Mode='POS'", con)
        cmd.Parameters.Add("@Stms", SqlDbType.DateTime).Value = StartTime.Value
        cmd.Parameters.Add("@Etms", SqlDbType.DateTime).Value = EndTime.Value

        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()

        adp.Fill(tb)

        If tb.Rows.Count() > 0 Then

            '// Sum up all the rows found
            Dim Bil As Integer = 0
            For ca As Integer = 0 To tb.Rows.Count() - 1
                Bil = Bil + tb.Rows(ca)(3)
            Next

            lblPostot.Text = Bil.ToString("#,#")

        Else
            lblPostot.Text = 0

        End If

    End Sub
    Sub GetCashTotals()

        cmd = New SqlCommand("Select * from [VwReceiptsSumm] WHERE Time_paid BETWEEN @stims AND @Etims AND Payment_Mode='CASH'", con)
        cmd.Parameters.Add("@Stims", SqlDbType.DateTime).Value = StartTime.Value
        cmd.Parameters.Add("@Etims", SqlDbType.DateTime).Value = EndTime.Value

        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()

        adp.Fill(tb)

        If tb.Rows.Count() > 0 Then

            '// Sum up all the rows found
            Dim Bil As Integer = 0
            For ca As Integer = 0 To tb.Rows.Count() - 1
                Bil = Bil + tb.Rows(ca)(3)
            Next

            Lblcashtot.Text = Bil.ToString("#,#")

        Else
            Lblcashtot.Text = 0

        End If

    End Sub
    Sub GetTRASTotals()

        cmd = New SqlCommand("Select * from [VwReceiptsSumm] WHERE Time_paid BETWEEN @stm AND @Etm AND Payment_Mode='TRANSFER'", con)
        cmd.Parameters.Add("@Stm", SqlDbType.DateTime).Value = StartTime.Value
        cmd.Parameters.Add("@Etm", SqlDbType.DateTime).Value = EndTime.Value

        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()

        adp.Fill(tb)

        If tb.Rows.Count() > 0 Then

            '// Sum up all the rows found
            Dim Bil As Integer = 0
            For ca As Integer = 0 To tb.Rows.Count() - 1
                Bil = Bil + tb.Rows(ca)(3)
            Next

            LblTransTot.Text = Bil.ToString("#,#")

        Else
            LblTransTot.Text = 0

        End If

    End Sub
    Sub GetCHEQTotals()

        cmd = New SqlCommand("Select * from [VwReceiptsSumm] WHERE Time_paid BETWEEN @st AND @Et AND Payment_Mode='CHEQUE'", con)
        cmd.Parameters.Add("@St", SqlDbType.DateTime).Value = StartTime.Value
        cmd.Parameters.Add("@Et", SqlDbType.DateTime).Value = EndTime.Value

        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()

        adp.Fill(tb)

        If tb.Rows.Count() > 0 Then

            '// Sum up all the rows found
            Dim Bil As Integer = 0
            For ca As Integer = 0 To tb.Rows.Count() - 1
                Bil = Bil + tb.Rows(ca)(3)
            Next

            lblChequeTot.Text = Bil.ToString("#,#")

        Else
            lblChequeTot.Text = 0

        End If

    End Sub
    Public Sub sortPendingBilss()

        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select * from PendingBills WHERE Date BETWEEN @dfrom AND @dto", con)
        cmd.Parameters.Add("@dfrom", SqlDbType.Date).Value = Rdatfrom.Value
        cmd.Parameters.Add("@dto", SqlDbType.Date).Value = RdateTo.Value

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        DtgPendbills.DataSource = tbl
        DtgPendbills.AutoResizeColumns()

    End Sub
    Public Sub LoadReceipts()

        Dim tbls As New DataTable()

        cmd = New SqlCommand("Select * from [RECEIPTS] WHERE Time_paid BETWEEN @stim AND @Etim", con)

        cmd.Parameters.Add("@Stim", SqlDbType.DateTime).Value = StartTime.Value
        cmd.Parameters.Add("@Etim", SqlDbType.DateTime).Value = EndTime.Value

        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(tbls)

        Dtgreceipts.DataSource = tbls
        Dtgreceipts.AutoResizeColumns()
        Dtgreceipts.Columns(3).Width = 250
        Dtgreceipts.Columns(7).Width = 200
        Dtgreceipts.Columns(1).DefaultCellStyle.Format = "hh\:mm\:ss tt"        ' 

        '// GET ALL THE TOTALS

        GetCashTotals()

        GetPOSTotals()

        GetTRASTotals()

        GetCHEQTotals()

        GetTotalCost()
    End Sub
    Public Sub LoadCashiers()

        Cbocashiers.SelectedItem = Nothing

        Dim tabls As New DataTable()
        cmd = New SqlCommand("Select DISTINCT Cashier FROM RECEIPTS WHERE Date BETWEEN @from And @To", con)
        cmd.Parameters.Add("@from", SqlDbType.Date).Value = StartTime.Value
        cmd.Parameters.Add("@To", SqlDbType.Date).Value = EndTime.Value
        '//Note: I used Select distinct to avoid duplication of the names that will display in the combobox

        Dim adpt As New SqlDataAdapter(cmd)
        adpt.Fill(tabls)

        Cbocashiers.DataSource = tabls
        Cbocashiers.DisplayMember = "Cashier"

        '  Cbocashiers.Text = "Select Cashier"

    End Sub

    Public Sub GetTotalCost()

        Dim Bill As Integer = 0
        For s As Integer = 0 To Dtgreceipts.Rows.Count() - 1
            Bill = Bill + Dtgreceipts.Rows(s).Cells(5).Value
        Next

        lbltotal.Text = Bill.ToString("#,#")

    End Sub

    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sortPendingBilss()
        LoadReceipts()
        LoadCashiers()


        '// CALL FROM PAYPOINT BUTTON ON MAINFORM

        '  StartTime.Value = New DateTime(Now.Year, Now.Month, Now.Day).AddHours(7)
        ' EndTime.Value = New DateTime(Now.Year, Now.Month, Now.Day).AddHours(23).AddMinutes(59)
        ' Dtfrm.Value = New Date(Now.Year, Now.Month, 1)
        'Dtfrm.Value = New DateTime(Now.Year, Now.Month, 1).AddHours(7)

        'Call Btnreload.PerformClick()
    End Sub

    Private Sub DtgPendbills_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'Dim frms = New FrmReceipts
        FrmReceipts.txtname.Text = DtgPendbills.CurrentRow.Cells(4).Value + "  " + DtgPendbills.CurrentRow.Cells(5).Value '// Concatenate the first name and other names in one textbox
        FrmReceipts.Txthnum.Text = DtgPendbills.CurrentRow.Cells(3).Value
        FrmReceipts.Txtserv.Text = DtgPendbills.CurrentRow.Cells(7).Value
        FrmReceipts.lblBill.Text = DtgPendbills.CurrentRow.Cells(6).Value
        FrmReceipts.txtaccnt.Text = DtgPendbills.CurrentRow.Cells(8).Value
        FrmReceipts.Txtservno.Text = DtgPendbills.CurrentRow.Cells(0).Value

        FrmReceipts.BtnSave.BringToFront()
        FrmReceipts.ShowDialog()

    End Sub

    Public Sub FindbyHnum()
        Try

            Dim tbln As New DataTable()
            cmd = New SqlCommand("Select * from RECEIPTS WHERE Hospital_No=@Hno ", con)

            cmd.Parameters.Add("@Hno", SqlDbType.VarChar).Value = Txtfindreceipt.Text

            Dim adpter As New SqlDataAdapter(cmd)
            adpter.Fill(tbln)
            If tbln.Rows.Count() > 0 Then
                Dtgreceipts.DataSource = tbln

            Else
                MessageBox.Show("NO RECEIPT FOUND FOR THIS PATIENT", "BILLING", MessageBoxButtons.OK)
                Txtfindreceipt.Text = ""
                Dtgreceipts.AutoResizeColumns()
                Dtgreceipts.Columns(3).Width = 250
                Dtgreceipts.Columns(7).Width = 200


            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Txtfindreceipt.Text = ""

        End Try

    End Sub

    Private Sub Dtgreceipts_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)

        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 AndAlso e.RowIndex <> -1 Then     '// i put 2 bcos column index starts from zero , i.e the first colmun is 0

            Using gridBrush As Brush = New SolidBrush(Me.Dtgreceipts.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell  
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)  
                    'If next row cell has different content, only draw bottom border line of current cell  
                    If e.RowIndex < Dtgreceipts.Rows.Count - 2 AndAlso Dtgreceipts.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell  
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells  
                    If Not e.Value Is Nothing Then

                        If e.RowIndex > 0 AndAlso Dtgreceipts.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then

                        Else
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Top - 1, e.CellBounds.Right - 1, e.CellBounds.Top - 1)
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)

                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If


    End Sub

    Private Sub Dtgreceipts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        FrmReceipts.txtname.Text = Dtgreceipts.CurrentRow.Cells(3).Value
        FrmReceipts.Txthnum.Text = Dtgreceipts.CurrentRow.Cells(4).Value
        FrmReceipts.Txtserv.Text = Dtgreceipts.CurrentRow.Cells(6).Value
        FrmReceipts.lblBill.Text = Dtgreceipts.CurrentRow.Cells(5).Value
        FrmReceipts.txtaccnt.Text = Dtgreceipts.CurrentRow.Cells(9).Value.ToString
        FrmReceipts.Txtservno.Text = Dtgreceipts.CurrentRow.Cells(8).Value.ToString
        FrmReceipts.LblReceiptnum.Text = Dtgreceipts.CurrentRow.Cells(2).Value
        FrmReceipts.lblcashiername.Text = Dtgreceipts.CurrentRow.Cells(7).Value

        FrmReceipts.btnreprint.BringToFront()
        FrmReceipts.ShowDialog()
    End Sub

    Private Sub Btnreload_Click_1(sender As Object, e As EventArgs) Handles Btnreload.Click
        LoadCashiers()
        LoadReceipts()
        Cbocashiers.Text = "Select Cashier"

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        FrmCashreceipt.ShowDialog()
    End Sub

    Private Sub Cbocashiers_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cbocashiers.SelectedIndexChanged
        cmd = New SqlCommand("Select * from [RECEIPTS] WHERE Cashier=@cashier AND Time_paid BETWEEN @stims AND @Etims", con)

        cmd.Parameters.Add("@Stims", SqlDbType.DateTime).Value = StartTime.Value
        cmd.Parameters.Add("@Etims", SqlDbType.DateTime).Value = EndTime.Value
        cmd.Parameters.Add("@cashier", SqlDbType.VarChar).Value = Cbocashiers.Text

        Dim tbles As New DataTable()
        Dim adpters As New SqlDataAdapter(cmd)
        adpters.Fill(tbles)
        If tbles.Rows.Count() > 0 Then
            Dtgreceipts.DataSource = tbles


            Dtgreceipts.AutoResizeColumns()
            Dtgreceipts.Columns(3).Width = 250
            Dtgreceipts.Columns(7).Width = 200
            Dtgreceipts.Columns(1).DefaultCellStyle.Format = "hh\:mm\:ss tt"


            Txtfindreceipt.Text = ""

            GetTotalCost()
        End If
    End Sub

    Private Sub Chview_CheckedChanged_1(sender As Object, e As EventArgs) Handles Chview.CheckedChanged
        If Chview.Checked = True Then

            LoadReceipts()

            Cbocashiers.SelectedItem = Nothing
            Cbocashiers.Enabled = False

            Txtfindreceipt.Text = ""

        Else
            Cbocashiers.Enabled = True
            LoadCashiers()
        End If
    End Sub

    Private Sub BtnFind_Click_1(sender As Object, e As EventArgs) Handles BtnFind.Click

        FindbyHnum()
        GetTotalCost()
    End Sub

    Private Sub BtnreLbills_Click_1(sender As Object, e As EventArgs) Handles BtnreLbills.Click
        sortPendingBilss()
    End Sub

    Private Sub BtnFindbill_Click_1(sender As Object, e As EventArgs) Handles BtnFindbill.Click
        Dim tbln As New DataTable()
        cmd = New SqlCommand("Select * from PendingBills WHERE Hospital_Num=@hno", con)

        cmd.Parameters.Add("@hno", SqlDbType.VarChar).Value = Txtfindbill.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbln)
        If tbln.Rows.Count() > 0 Then
            DtgPendbills.DataSource = tbln

        Else
            MessageBox.Show("THERE IS NO BILL FOR THIS PATIENT", "BILLING", MessageBoxButtons.OK)

        End If

        DtgPendbills.AutoResizeColumns()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class