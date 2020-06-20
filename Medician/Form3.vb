Imports System.Data.OleDb

Public Class Form3
    Public Sub clear()
        Me.TextBox1.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.ComboBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.clear()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As OleDbConnection = New OleDbConnection
        connection.ConnectionString = My.Settings.logindbc
        connection.Open()
        Dim dr As OleDb.OleDbDataReader
        Dim newid As Integer
        Dim query1 As OleDbCommand = New OleDbCommand("SELECT [ID] from LoginTable Order By ID DESC", connection)
        dr = query1.ExecuteReader
        If dr.Read = True Then
            newid = dr(0)
        End If
        Dim updatequery As New OleDbCommand("UPDATE LoginTable SET [username]='" & TextBox1.Text & "', [password]='" & TextBox3.Text & "',[securityq]='" & ComboBox1.Text & "',[securitya]='" & TextBox4.Text & "' WHERE ID=" & newid & "", connection)
        Try
            updatequery.ExecuteNonQuery()
            updatequery.Dispose()
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Profile Created")
        Form1.Show()
        Me.Close()
        Form1.clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
    End Sub
End Class