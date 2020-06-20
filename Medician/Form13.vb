Public Class Form13
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Close()
        Form4.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Panel1.Width = 50 Then
            Panel1.Width = 260


        ElseIf Panel1.Width = 260 Then
            Panel1.Width = 50
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.GhostWhite
        Label2.Font = New Font("Segoe UI Semibold", 13, FontStyle.Bold)

    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.LightGray
        Label2.Font = New Font("Segoe UI Semibold", 12)
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.GhostWhite
        Label3.Font = New Font("Segoe UI Semibold", 13, FontStyle.Bold)

    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.LightGray
        Label3.Font = New Font("Segoe UI Semibold", 12)
    End Sub


    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.GhostWhite
        Label4.Font = New Font("Segoe UI Semibold", 13, FontStyle.Bold)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.LightGray
        Label4.Font = New Font("Segoe UI Semibold", 12)
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.GhostWhite
        Label5.Font = New Font("Segoe UI Semibold", 13, FontStyle.Bold)
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.LightGray
        Label5.Font = New Font("Segoe UI Semibold", 12)
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.GhostWhite
        Label7.Font = New Font("Segoe UI Semibold", 13, FontStyle.Bold)

    End Sub



    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.LightGray
        Label7.Font = New Font("Segoe UI Semibold", 12)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form12.n += 1
        Call make(7, ComboBox1.Text)
        Button5.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form12.n += 1
        Call make(8, ComboBox2.Text)
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form12.n += 1
        Call make(9, ComboBox3.Text)
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form12.n += 1
        Call make(10, ComboBox4.Text)
        Button1.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form12.n += 1
        Call make(11, ComboBox5.Text)
        Button6.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form12.n += 1
        Call make(12, ComboBox6.Text)
        Button4.Enabled = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub
End Class