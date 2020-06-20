
Public Class Form4

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = ("Welcome, " & Form1.name)
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
        Dim a As New Label
        a.Text = "sdsd"
        a.Location = New System.Drawing.Point(180, 40)
        Panel1.Controls.Add(a)
        Form5.Label1.Visible = False
        Form5.Label12.Visible = False
        Form5.Button2.Visible = False
        Form5.Label8.Visible = False
        Form5.Label10.Visible = False
        Form5.Label11.Visible = False
        Form5.Label14.Visible = False
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


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Show()

    End Sub



    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Panel1.Width = 50 Then
            Panel1.Width = 250


        ElseIf Panel1.Width = 250 Then
            Panel1.Width = 50
        End If
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


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Form12.Hide()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        Form13.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form14.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form15.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Me.Hide()
        Form16.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Hide()
        Form19.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
