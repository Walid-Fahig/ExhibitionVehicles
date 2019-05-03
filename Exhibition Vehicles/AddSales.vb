Imports System.Data.SqlClient
Imports System.IO

Public Class AddSales
    Private Sub cancelButton2_Click(sender As Object, e As EventArgs) Handles cancelButton2.Click

        Me.Hide()
        clear()
    End Sub

    Private Sub AddSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New SqlCommand("select DISTINCT payment_type from Sales", connectionn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        paym_type_ComboBox2.DataSource = table

        paym_type_ComboBox2.DisplayMember = "payment_type"


        clear()
        query()
    End Sub

    Private Sub clear()
        id_TextBox1.Enabled = False
        user_id_TextBox1.Enabled = False

        id_TextBox1.Text = "id is auto number"
        DateTimePicker1.Text = ""
        model_id_ComboBox1.Text = ""
        color_TextBox2.Text = ""
        year_TextBox3.Text = ""
        price_TextBox4.Text = ""
        paym_type_ComboBox2.Text = ""
        user_id_TextBox1.Text = ""
    End Sub

    Sub query()
        user_id_TextBox1.Text = 1
        'Dim con As SqlConnection = New SqlConnection(conn)

        'Dim query As String = " select id from Login where username=" & "' userId '"
        'con.Open()
        'Dim cmd As New SqlCommand(query, con)
        ''cmd.Parameters.AddWithValue("@id", user_id_TextBox1.Text)
        'cmd.ExecuteNonQuery()
        'If cmd.
        'user_id_TextBox1.Text Then
        '    con.Close()
    End Sub

    Private Sub saveButton1_Click(sender As Object, e As EventArgs) Handles saveButton1.Click
        If DateTimePicker1.Text.Equals("") Or model_id_ComboBox1.Text.Equals("") Or color_TextBox2.Text.Equals("") Or year_TextBox3.Text.Equals("") Or price_TextBox4.Text.Equals("") Or paym_type_ComboBox2.Equals("") Then

            MsgBox("Enter all intformation")
        Else
            Console.WriteLine("1")

            '   Dim con As SqlConnection = New SqlConnection(conn)
            Dim sql = "INSERT INTO [Sales] (date ,model_id , color , year ,price ,payment_type , picture , user_id ) VALUES (@date , @model_id , @color , @year , @price , @payment_type , @picture , @user_id )"
            Dim sda As SqlDataAdapter = New SqlDataAdapter(sql, connectionn)
            Dim com As SqlCommand = New SqlCommand(sql, connectionn)
            Try
                Console.WriteLine("2")
                connectionn.Open()
                '  com.Parameters.AddWithValue("@id", id_TextBox1.Text)
                com.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                com.Parameters.AddWithValue("@model_id", model_id_ComboBox1.Text)
                com.Parameters.AddWithValue("@color", color_TextBox2.Text)
                com.Parameters.AddWithValue("@year", year_TextBox3.Text)
                com.Parameters.AddWithValue("@price", price_TextBox4.Text)
                com.Parameters.AddWithValue("@payment_type", paym_type_ComboBox2.Text)
                'com.Parameters.AddWithValue("@user_id", user_id_TextBox1.Text)
                Dim ms As New MemoryStream

                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

                Dim picture() As Byte = ms.ToArray
                Console.WriteLine("3")
                com.Parameters.AddWithValue("@picture", picture)
                com.ExecuteNonQuery()
                Console.WriteLine("4")
                MsgBox("Insert sales success")
                tabelSales()
            Catch ex As Exception

            Finally
                connectionn.Close()
            End Try
        End If
    End Sub

    Private Sub year_TextBox3_TextChanged(sender As Object, e As EventArgs) Handles year_TextBox3.TextChanged

    End Sub

    Private Sub year_Label5_Click(sender As Object, e As EventArgs) Handles year_Label5.Click

    End Sub

    Private Sub user_id_Label8_Click(sender As Object, e As EventArgs) Handles user_id_Label8.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub payment_type_Label7_Click(sender As Object, e As EventArgs) Handles payment_type_Label7.Click

    End Sub

    Private Sub paym_type_ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles paym_type_ComboBox2.SelectedIndexChanged

    End Sub
End Class

