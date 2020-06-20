Public Class Form10
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Form4.Show()
        Me.Close()
        Form1.Hide()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub
End Class