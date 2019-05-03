Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class Car

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_TextBox1.Enabled = False
        tabelCar()

        'خاص ملاء combox1

        Dim commandd As New SqlCommand("select DISTINCT id from model", connectionn)

        Dim adapterr As New SqlDataAdapter(commandd)

        Dim tablee As New DataTable()

        adapterr.Fill(tablee)

        model_id_ComBox1.DataSource = tablee

        model_id_ComBox1.DisplayMember = "id"

        clear()

    End Sub

    Private Sub AddImage_Click(sender As Object, e As EventArgs) Handles AddImage.Click
        OpenFileDialog1.Filter = "All Images |*.PND; *.JPG; *.BMP"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim constr = "Data Source=DESKTOP-CBPSEOH\MSSQLSERVERR;
                   Integrated Security=SSPI;Initial Catalog=vehicle"

        If DateTimePicker1.Text.Equals("") Or model_id_ComBox1.Text.Equals("") Or color_TextBox2.Text.Equals("") Or year_TextBox3.Text.Equals("") Or price_TextBox4.Text.Equals("") Then

            MsgBox("Enter all intformation")
        Else
            Dim con As SqlConnection = New SqlConnection(constr)
            Dim sql = "INSERT INTO [car] (date , model_id , color , year , price , picture ) VALUES (@date,@model_id , @color , @year , @price , @picture )"
            Dim sda As SqlDataAdapter = New SqlDataAdapter(sql, constr)
            Dim com As SqlCommand = New SqlCommand(sql, con)
            Try
                com.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                com.Parameters.AddWithValue("@model_id", model_id_ComBox1.Text)
                com.Parameters.AddWithValue("@color", color_TextBox2.Text)
                com.Parameters.AddWithValue("@year", year_TextBox3.Text)
                com.Parameters.AddWithValue("@price", price_TextBox4.Text)


                Dim ms As New MemoryStream

                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

                Dim picture() As Byte = ms.ToArray

                com.Parameters.AddWithValue("@picture", picture)

                con.Open()
                com.ExecuteNonQuery()
                MsgBox("Insert success")
                tabelCar()
            Catch ex As Exception

            Finally
                clear()
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Print_Button2_Click(sender As Object, e As EventArgs) Handles Print_Button2.Click

        PrintDocument1.Print()

    End Sub
    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        closingForm(e)

    End Sub 'Form1_Closing

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub clear()
        id_TextBox1.Text = " id is auto number"
        DateTimePicker1.Text = ""
        model_id_ComBox1.Text = ""
        color_TextBox2.Text = ""
        year_TextBox3.Text = ""
        price_TextBox4.Text = ""
        PictureBox1.Text = ""

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.id_TextBox1.Text = DataGridView1.Item(0, i).Value
        Me.DateTimePicker1.Text = DataGridView1.Item(1, i).Value
        Me.model_id_ComBox1.Text = DataGridView1.Item(2, i).Value
        Me.color_TextBox2.Text = DataGridView1.Item(3, i).Value
        Me.year_TextBox3.Text = DataGridView1.Item(4, i).Value
        Me.price_TextBox4.Text = DataGridView1.Item(5, i).Value
        ' Me.PictureBox1.Image = DataGridView1.Item(6, i).Value

        'Dim img As byte
        'img = DataGridView1.CurrentRow.Cells(6).Value
        'Dim ms As New MemoryStream(img)
        'Me.PictureBox1.Image = Image.FromStream(ms)

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim i As Integer
                i = DataGridView1.CurrentRow.Index

                Dim intStID As Integer = Me.DataGridView1.Item(0, i).Value
                '  Dim intStID As Integer = Me.DataGridView1.SelectedRows(0).Cells("id").Value

                'opening connection
                If Not connectionn.State = ConnectionState.Open Then
                    connectionn.Open()
                End If

                'deleting data from table
                Dim cmd As New SqlCommand()
                cmd.Connection = connectionn

                If MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmd.CommandText = "DELETE FROM car WHERE id=" & intStID
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Deletion aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

                'refresh data
                tabelCar()

            Else
                MessageBox.Show("No record selected for delete.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No record to be delete.", "Deletion Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Closing connection
        clear()
        connectionn.Close()
    End Sub

    Private Sub Updatee_Click(sender As Object, e As EventArgs) Handles Updatee.Click
        Dim con As SqlConnection = New SqlConnection(conn)

        If Me.DataGridView1.Rows.Count > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim query As String = "update car set date=@date,model_id=@model_id,color=@color,year=@year,price=@price where id=@id"
                con.Open()
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id_TextBox1.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@model_id", model_id_ComBox1.Text)
                cmd.Parameters.AddWithValue("@color", color_TextBox2.Text)
                cmd.Parameters.AddWithValue("@year", year_TextBox3.Text)
                cmd.Parameters.AddWithValue("@price", price_TextBox4.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Records updated successfully")
                tabelCar()
            Else
                MessageBox.Show("No record selected for update.", "update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No record to be update.", "update ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        clear()
        con.Close()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim searchQuery As String = "SELECT * From car WHERE
           model_id like '%" & serch_TextBox5.Text & "%'"
        connectionn.Open()
        Dim command As New SqlCommand(searchQuery, connectionn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
        connectionn.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class