Public Class Form5


    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.GhostWhite
        Label2.Font = New Font("Segoe UI Semibold", 13, FontStyle.Bold)

    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.LightGray
        Label2.Font = New Font("Segoe UI Semibold", 12)
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form4.Show()
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

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = ("Welcome, " & Form1.name)
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
        If Form12.n > 0 Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()
        Form1.Show()
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each lb As Label In Module1.controls
            Controls.Remove(lb)
            lb.Dispose()
        Next
        Form12.n = 0
        Module1.y = 45
        Module1.sum = 0
        Label12.Text = ""
        Form12.Button1.Enabled = True
        Form12.Button2.Enabled = True
        Form12.Button3.Enabled = True
        Form12.Button4.Enabled = True
        Form12.Button5.Enabled = True
        Form12.Button6.Enabled = True
        Form12.ComboBox1.Text = "x1"
        Form12.ComboBox2.Text = "x1"
        Form12.ComboBox3.Text = "x1"
        Form12.ComboBox4.Text = "x1"
        Form12.ComboBox5.Text = "x1"
        Form12.ComboBox6.Text = "x1"
        Form13.Button1.Enabled = True
        Form13.Button2.Enabled = True
        Form13.Button3.Enabled = True
        Form13.Button4.Enabled = True
        Form13.Button5.Enabled = True
        Form13.Button6.Enabled = True
        Form13.ComboBox1.Text = "x1"
        Form13.ComboBox2.Text = "x1"
        Form13.ComboBox3.Text = "x1"
        Form13.ComboBox4.Text = "x1"
        Form13.ComboBox5.Text = "x1"
        Form13.ComboBox6.Text = "x1"
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Thanks For Shopping!")
    End Sub
End Class
