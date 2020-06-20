Public Class Form15

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox9.Left += 1.0
        If PictureBox9.Left = 855 Then
            Timer1.Dispose()
            Timer1.Stop()
            MsgBox("Your Ambulance has arrived! Bring the mareej")
        End If

    End Sub

    Private Sub Request_Click(sender As Object, e As EventArgs) Handles Request.Click
        Dim box As New List(Of Control)
        box.Add(TextBox1)
        box.Add(TextBox2)
        box.Add(TextBox3)
        box.Add(TextBox4)
        box.Add(TextBox5)
        box.Add(TextBox7)
        box.Add(TextBox8)
        For Each tb As TextBox In box
            If tb.Text = "" Then
                MsgBox("Enter all the details!")
                tb.Focus()
                Exit Sub
            End If
        Next
        MsgBox("Your Ambulance is on its way!")
        Timer1.Start()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Form4.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form4.Show()
        Me.Hide()

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

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class