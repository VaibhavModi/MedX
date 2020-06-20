Imports System.Data.OleDb
Public Class Form9
    Public usern As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn As New OleDbConnection
        usern = TextBox1.Text
        conn.ConnectionString = My.Settings.logindbc
        conn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from LoginTable where [username]='" & TextBox1.Text & "'and [securityq]='" & ComboBox1.Text & "'and [securitya]='" & TextBox2.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If (dr.Read = True) Then
            MsgBox("Record Found")
            Form18.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Details!")
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
        End If
        conn.Close()

        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class