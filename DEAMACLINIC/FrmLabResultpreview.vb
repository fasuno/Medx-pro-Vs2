Imports System.Data.SqlClient

Public Class FrmLabResultpreview
    Private Sub FrmLabResultpreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTest.Text = ""
        ' LoadPatientTest()
        Dtginv.AutoResizeColumns()
        Dtgtestresult.DataSource = Nothing
        Txtnotes.Text = ""
    End Sub

    Public Sub LoadPatientTest()  '// This method will be called from PtLabHX datagrid

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Test_Name, Request_Num FROM LabRequest  Where Request_Num=@Rqnum", con)
        cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = FrmPtRecords.PtLabHist1.DtgLabhx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtginv.DataSource = tbls
        ' Dtginv.AutoResizeColumns()


    End Sub

    Public Sub LoadPtForConsult()
        '// This method will be called from PtLabHX datagrid

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Test_Name, Request_NUm FROM LabRequest Where Request_Num=@Rqnum", con)
        cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = frmGenConsult.DtgLab.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtginv.DataSource = tbls
        ' Dtginv.AutoResizeColumns()


    End Sub

    Public Sub LoadPtForWard()

        '// This method will be called from PtLabHX datagrid
        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Test_Name FROM LabRequest  Where Request_Num=@Rqnum", con)
        cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = FrmAdmitFolder.InpatientLabHx1.DtgLabhx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtginv.DataSource = tbls
        ' Dtginv.AutoResizeColumns()


    End Sub

    Public Sub LoadPtForTheatre()

        '// This method will be called from PtLabHX datagrid
        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Test_Name FROM LabRequest  Where Request_Num=@Rqnum", con)
        cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = FrmSurgery.TheatreLAb1.DtgLabhx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtginv.DataSource = tbls
        ' Dtginv.AutoResizeColumns()


    End Sub

    Private Sub Dtginv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtginv.CellClick

        LblTest.Text = Dtginv.CurrentRow.Cells(0).Value
        showotherdetails()

        cmd = New SqlCommand("Select Test_parameters, Result, Ref_value, Measure from LABRESULTS Where Request_Num=@RqstNum AND Test_Name=@Test", con)

        cmd.Parameters.Add("@Test", SqlDbType.VarChar).Value = Dtginv.CurrentRow.Cells(0).Value
        cmd.Parameters.Add("@Rqstnum", SqlDbType.Int).Value = Dtginv.CurrentRow.Cells(1).Value ' Lblrqstnum.Text

        Dim adapt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then
            Dtgtestresult.DataSource = tbl

            Dtgtestresult.Columns(1).Width = 355
            Dtgtestresult.Columns(2).Width = 120
            Dtgtestresult.Columns(0).Width = 180
            Dtgtestresult.Columns(0).DefaultCellStyle.ForeColor = Color.DarkBlue

        Else
            LblTest.Text = ""
            MsgBox("NO RESULT FOUND FOR THE SELECTED TEST", MsgBoxStyle.Information, "LABORATORY")

        End If

    End Sub

    Public Sub showotherdetails()

        cmd = New SqlCommand("Select * from LABRESULTS Where Request_Num=@RqsNum AND Test_Name=@Tst", con)

        cmd.Parameters.Add("Tst", SqlDbType.VarChar).Value = Dtginv.CurrentRow.Cells(0).Value
        cmd.Parameters.Add("Rqsnum", SqlDbType.Int).Value = Lblrqstnum.Text

        Dim adapt As New SqlDataAdapter(cmd)
        Dim ntbl As New DataTable

        adapt.Fill(ntbl)
        If ntbl.Rows.Count() > 0 Then
            Txtdaterprt.Text = ntbl.Rows(0)(16)
            Txtnotes.Text = ntbl.Rows(0)(18).ToString()
            Txtreprtby.Text = ntbl.Rows(0)(15).ToString()

        End If

    End Sub


End Class