Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Form2
    Public Sub clear()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.ComboBox1.Text = ""
        Me.CheckBox1.Checked = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.clear()

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.clear()
        If CheckBox1.Checked = False Then
            MsgBox("Please Agree to the Terms & Condition")
        ElseIf CheckBox1.Checked = True Then
            Dim connection As OleDbConnection = New OleDbConnection
            connection.ConnectionString = My.Settings.logindbc
            connection.Open()
            Dim updatequery As OleDbCommand = New OleDbCommand("INSERT INTO LoginTable (name1,name2,mobile,age,sex) VALUES(@name1,@name2,@num,@age,@sex)", connection)
            ComboBox1.Text = ""
            updatequery.Parameters.Add("@name1", OleDbType.VarChar).Value = TextBox1.Text
            updatequery.Parameters.Add("@name2", OleDbType.VarChar).Value = TextBox2.Text
            updatequery.Parameters.Add("@num", OleDbType.Numeric).Value = TextBox3.Text
            updatequery.Parameters.Add("@age", OleDbType.Numeric).Value = TextBox4.Text
            updatequery.Parameters.Add("@sex", OleDbType.VarChar).Value = ComboBox1.Text
            updatequery.ExecuteNonQuery()
            ComboBox1.Text = ""
            Me.Hide()
            Form3.Show()
            connection.Close()
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = (My.Resources.icons8_cursor_filled_50)
        Me.Cursor = New Cursor(cur.Handle)
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

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class