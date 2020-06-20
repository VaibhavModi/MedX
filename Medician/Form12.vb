Public Class Form12
    Public n As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Form1.Close()
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()
        Form1.Show()
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

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If Panel1.Width = 50 Then
            Panel1.Width = 260


        ElseIf Panel1.Width = 260 Then
            Panel1.Width = 50
        End If
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        n = n + 1
        Call make(1, ComboBox1.Text)
        Button5.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n = n + 1
        Call make(2, ComboBox4.Text)
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        n = n + 1
        Call make(3, ComboBox3.Text)
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = n + 1
        Call make(4, ComboBox2.Text)
        Button1.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        n = n + 1
        Call make(5, ComboBox6.Text)
        Button6.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        n = n + 1
        Call make(6, ComboBox5.Text)
        Button4.Enabled = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub
End Class