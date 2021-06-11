Public Class FrmSettings
    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        AccountSet1.BringToFront()
    End Sub

    Private Sub btnserv_Click(sender As Object, e As EventArgs) Handles btnserv.Click
        ServiceSetings1.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CompanyInfo1.BringToFront()
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CompanyInfo1.BringToFront()
    End Sub

    Private Sub Btnbed_Click(sender As Object, e As EventArgs) Handles Btnbed.Click
        BedManager1.BringToFront()
    End Sub

    Private Sub Btnaddrole_Click(sender As Object, e As EventArgs) Handles Btnaddrole.Click
        Addroles1.BringToFront()
    End Sub
End Class