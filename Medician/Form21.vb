Public Class Form21
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim b As New CrystalReport2
        CrystalReportViewer1.ReportSource = b
    End Sub
End Class