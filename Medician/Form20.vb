Public Class Form20
    Private Sub CrystalReportViewer2_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer2.Load

    End Sub

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim a As New CrystalReport1
        CrystalReportViewer2.ReportSource = a
    End Sub
End Class