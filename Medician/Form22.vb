Public Class Form22
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim c As New CrystalReport3
        CrystalReportViewer1.ReportSource = c
    End Sub
End Class