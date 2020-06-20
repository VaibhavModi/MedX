Imports System.Data.OleDb
Public Class Form6

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

        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form4.Show()
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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = ("Welcome, " & Form1.name)
        Dim cur As Icon

        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Panel1.Width = 50 Then
            Panel1.Width = 260


        ElseIf Panel1.Width = 260 Then
            Panel1.Width = 50

        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name1 As New Label
        name1.Name = "label"
        name1.Text = Form1.name
        name1.Location = New System.Drawing.Point(262, 225)
        name1.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        name1.ForeColor = Color.DimGray
        name1.BackColor = Color.LightGray
        name1.Size = New Size(155, 18)
        name1.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(name1)

        Dim name2 As New Label
        name2.Name = "label"
        name2.Text = Form1.name2
        name2.Location = New System.Drawing.Point(262, 274)
        name2.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        name2.ForeColor = Color.DimGray
        name2.BackColor = Color.LightGray
        name2.Size = New Size(155, 18)
        name2.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(name2)

        Dim mob1 As New Label
        mob1.Name = "label"
        mob1.Text = Form1.mob
        mob1.Location = New System.Drawing.Point(262, 328)
        mob1.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        mob1.ForeColor = Color.DimGray
        mob1.BackColor = Color.LightGray
        mob1.Size = New Size(155, 18)
        mob1.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(mob1)

        Dim sex As New Label
        sex.Name = "label"
        sex.Text = Form1.sex
        sex.Location = New System.Drawing.Point(285, 380)
        sex.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        sex.ForeColor = Color.DimGray
        sex.BackColor = Color.LightGray
        sex.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(sex)

        Dim age As New Label
        age.Name = "label"
        age.Text = Form1.age
        age.Location = New System.Drawing.Point(285, 435)
        age.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        age.ForeColor = Color.DimGray
        age.BackColor = Color.LightGray
        age.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(age)

        Dim uname As New Label
        uname.Name = "label"
        uname.Text = Form1.uname
        uname.Location = New System.Drawing.Point(626, 227)
        uname.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        uname.ForeColor = Color.DimGray
        uname.BackColor = Color.LightGray
        uname.Size = New Size(200, 18)
        uname.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(uname)

        Dim sq As New Label
        sq.Name = "label"
        sq.Text = Form1.sq
        sq.Location = New System.Drawing.Point(625, 275)
        sq.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        sq.ForeColor = Color.DimGray
        sq.BackColor = Color.LightGray
        sq.Size = New Size(200, 18)
        sq.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(sq)

        Dim sa As New Label
        sa.Name = "label"
        sa.Text = Form1.sa
        sa.Location = New System.Drawing.Point(611, 327)
        sa.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        sa.ForeColor = Color.DimGray
        sa.BackColor = Color.LightGray
        sa.Size = New Size(155, 18)
        sa.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(sa)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
        Me.Hide()
    End Sub


End Class