Imports System.Data.OleDb
Imports System.Drawing
Module Module1

    Public y As Integer = 45
    Public sum As Integer = 0
    Dim price As Integer
    Public controls As New List(Of Control)

    Public Sub make(ByVal n As Integer, ByVal c As String)
        Dim conn As New OleDbConnection
        conn.ConnectionString = My.Settings.logindbc
        conn.Open()
        Dim query As New OleDbCommand("select * from Product where ID=" & n & "", conn)
        Dim dr As OleDbDataReader
        dr = query.ExecuteReader
        If IsNumeric(c) Then
            c = "x" + c.ToString
        End If
        Dim quan As String = Replace(c, "x", "")
        Integer.Parse(quan)
        If Form12.n > 1 Then
            y = y + 35
        End If
        If (dr.Read = True) Then
            Dim newb As New Label
            newb.Name = "label"
            newb.Text = Form12.n
            newb.Location = New System.Drawing.Point(14, y)
            newb.Font = New Font("Century Schoolbook", 11.5, FontStyle.Bold)
            newb.ForeColor = Color.Gray
            newb.Size = New Size(48, 25)
            Form5.Panel2.Controls.Add(newb)
            Dim prodname As New Label
            prodname.Name = "label"
            prodname.Text = dr(1)
            prodname.Location = New System.Drawing.Point(84, y)
            prodname.Font = New Font("Century Schoolbook", 11.5, FontStyle.Bold)
            prodname.ForeColor = Color.Gray
            prodname.Size = New Size(175, 25)
            Form5.Panel2.Controls.Add(prodname)
            Dim prodprice As New Label
            prodprice.Name = "label"
            price = dr(3) * quan
            prodprice.Text = price & "₹"
            prodprice.Font = New Font("Century Schoolbook", 11.5, FontStyle.Bold)
            prodprice.Location = New System.Drawing.Point(373, y)
            prodprice.ForeColor = Color.Gray
            prodprice.Size = New Size(68, 25)
            Form5.Panel2.Controls.Add(prodprice)
            Dim prodquan As New Label
            prodquan.Name = "label"
            prodquan.Text = c
            prodquan.Font = New Font("Century Schoolbook", 11.5, FontStyle.Bold)
            prodquan.Location = New System.Drawing.Point(295, y)
            prodquan.ForeColor = Color.Gray
            prodquan.Size = New Size(48, 25)
            Form5.Panel2.Controls.Add(prodquan)
            sum = sum + price
            Form5.Label12.Text = sum & "₹"
            controls.Add(prodname)
            controls.Add(prodprice)
            controls.Add(prodquan)
            controls.Add(newb)
            Form5.Label12.Visible = True
            Form5.Label1.Visible = True
            Form5.Button2.Visible = True
            Form5.Label8.Visible = True
            Form5.Label10.Visible = True
            Form5.Label11.Visible = True
            Form5.Label14.Visible = True
            Form5.Button3.Visible = True
            Form5.Button3.Enabled = True
        End If
    End Sub

    Public Function display(ByVal id As Integer)
        Dim con As New OleDbConnection
        con.ConnectionString = My.Settings.logindbc
        con.Open()
        Dim query As New OleDbCommand("select * from Diagonosis where ID=" & id & "", con)
        Dim dr As OleDb.OleDbDataReader
        dr = query.ExecuteReader
        If dr.Read = True Then
            Form7.Label16.Text = dr(4)
            Form7.Label17.Text = dr(6)
            Form7.Label20.Text = dr(7)
            Form7.Label21.Text = dr(8)
        End If
        con.Close()
    End Function
End Module
