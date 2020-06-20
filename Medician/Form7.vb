Public Class Form7


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

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.GhostWhite
        Label7.Font = New Font("Segoe UI Semibold", 13, FontStyle.Bold)

    End Sub



    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.LightGray
        Label7.Font = New Font("Segoe UI Semibold", 12)
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = ("Welcome, " & Form1.name)
        Dim cur As Icon

        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim count As Integer
        Dim myList As New List(Of String)
        For Each cb As CheckBox In Panel3.Controls.OfType(Of CheckBox)
            If cb.Checked Then
                count += 1
                myList.Add(cb.Text)
            End If
        Next
        If count > 4 Or count < 3 Then
            MsgBox("Please enter 3 to 4 symptoms!")
            For Each cb As CheckBox In Panel3.Controls.OfType(Of CheckBox)
                If cb.Checked Then
                    cb.Checked = False
                End If
            Next
        Else
            Label15.Show()
            Label11.Show()
            Label12.Show()
            Label15.Text = String.Join(", ", myList)
            If myList.Contains("Coughing") And myList.Contains("Sneezing") And myList.Contains("Runny Nose") Then
                Call display(1)
            ElseIf myList.Contains("Dizziness") And myList.Contains("Dry Mouth") And myList.Contains("Headache") Then
                Call display(2)
            ElseIf myList.Contains("Itchy Bumps") And myList.Contains("Loss of Appetite") And myList.Contains("Dry Cough") And myList.Contains("Blisters") Then
                Call display(3)
            ElseIf myList.Contains("Wheezing") And myList.Contains("Shortness of Breath") And myList.Contains("Tight Chest") Then
                Call display(4)
            ElseIf myList.Contains("Body Ache") And myList.Contains("Dry Cough") And myList.Contains("Headache") And myList.Contains("High Fever") Then
                Call display(5)
            ElseIf myList.Contains("Loss of Appetite") And myList.Contains("Nausea") And myList.Contains("Headache") And myList.Contains("Cramp") Then
                Call display(6)
            ElseIf myList.Contains("Loss of Appetite") And myList.Contains("Nausea") And myList.Contains("Cramps") And myList.Contains("High fever") Then
                Call display(6)
                Label14.Show()
                Label17.Show()
            Else
                MsgBox("Your symptoms are complicated. Consulting a doctor is recommended!")
            End If
            Label16.Show()
            Label14.Show()
            Label17.Show()
            Label19.Show()
            Label20.Show()
            Label21.Show()
            Label22.Show()
            For Each cb As CheckBox In Panel3.Controls.OfType(Of CheckBox)
                If cb.Checked Then
                    cb.Checked = False
                End If
            Next
        End If


    End Sub

End Class