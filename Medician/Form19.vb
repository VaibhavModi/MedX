Public Class Form19

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
        Me.Hide()
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

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Panel1.Width = 50 Then
            Panel1.Width = 260


        ElseIf Panel1.Width = 260 Then
            Panel1.Width = 50
        End If
    End Sub

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim h, w, b As Double
        h = TextBox1.Text
        w = TextBox2.Text
        b = w / (h * h) * 10000
        Label12.Text = (Math.Round(b, 2))
        Label11.Show()
        Label12.Show()
        Label14.Show()

        If Label12.Text < 16 Then
            Label14.Text = ("You are very severly underweight")
        ElseIf b > 16 And b < 18.5 Then
            Label14.Text = ("You are underweight")
        ElseIf b > 18.5 And b < 25 Then
            Label14.Text = ("You are Normal")
        ElseIf b > 25 And b < 30 Then
            Label14.Text = ("You are overweight")
        ElseIf b > 30 And b < 35 Then
            Label14.Text = ("You are Moderately overweight (Obese Class I)")
        ElseIf b > 35 And b < 40 Then
            Label14.Text = ("You are severly overweight (Obese Class II)")
        ElseIf b > 40 And b < 45 Then
            Label14.Text = ("You are very severly overweight (Obese Class III)")
        ElseIf b > 45 And b < 50 Then
            Label14.Text = ("You are morbidly overweight (Obese Class IV)")
        ElseIf b > 50 And b < 60 Then
            Label14.Text = ("You are Super Obese (Obese Class V)")
        Else
            Label14.Text = ("You are Hyper Obese (Obese Class VI)")

        End If

    End Sub

    Private Sub Label10_Click_1(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class