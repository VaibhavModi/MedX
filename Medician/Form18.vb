Imports System.Data.OleDb
Public Class Form18
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.UseSystemPasswordChar = False
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usernm As New Char

        Dim connection As OleDbConnection = New OleDbConnection
        connection.ConnectionString = My.Settings.logindbc
        connection.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Enter Password!")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        If TextBox1.Text <> TextBox2.Text Then
            MsgBox("Please Re-Check Password and Confirm Password")
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            Dim updatequery As OleDbCommand = New OleDbCommand("UPDATE LoginTable SET [password] =@pwd WHERE [username] =@usr", connection)
            updatequery.Parameters.AddWithValue("@pwd", OleDbType.Char).Value = TextBox1.Text
            updatequery.Parameters.AddWithValue("@usr", OleDbType.Char).Value = Form9.usern
            updatequery.ExecuteNonQuery()
            MsgBox("Password Change Successfully")
            Form1.Show()
            Me.Hide()

        End If
        connection.Close()

    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class