Imports System.Data.SqlClient

Public Class Model


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Model_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'داله لعرض محتويات الجدول 
        tabell()

        TextBox1.Enabled = False
        ' TextBox1.Text = " model id is auto number"

        'خاص ملاء combox1
        Dim command As New SqlCommand("select DISTINCT make from model", connectionn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "make"

        'خاص ملاء combox2

        Dim commandd As New SqlCommand("select DISTINCT class from model", connectionn)

        Dim adapterr As New SqlDataAdapter(commandd)

        Dim tablee As New DataTable()

        adapterr.Fill(tablee)

        ComboBox2.DataSource = tablee

        ComboBox2.DisplayMember = "class"

        clear()
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        If ComboBox1.Text.Equals("") Or ComboBox2.Text.Equals("") Or TextBox3.Text.Equals("") Then

            MsgBox("Enter all intformation")
        Else
            Dim con As SqlConnection = New SqlConnection(conn)
            Dim sql = "INSERT INTO [model] (make , name , class ) VALUES (@make , @name , @class)"
            Dim sda As SqlDataAdapter = New SqlDataAdapter(sql, conn)
            Dim com As SqlCommand = New SqlCommand(sql, con)
            Try
                con.Open()
                '  com.Parameters.AddWithValue("@id", TextBox1.Text)
                com.Parameters.AddWithValue("@make", ComboBox1.Text)
                com.Parameters.AddWithValue("@name", TextBox3.Text)
                com.Parameters.AddWithValue("@class", ComboBox2.Text)
                com.ExecuteNonQuery()
                MsgBox("Insert success")
                tabell()
            Catch ex As Exception

            Finally

                TextBox3.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                con.Close()
            End Try
        End If

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

        Dim searchQuery As String = "SELECT * From model WHERE
           name like '%" & searchTextBox5.Text & "%'"
        connectionn.Open()
        Dim command As New SqlCommand(searchQuery, connectionn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
        connectionn.Close()
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
                    cmd.CommandText = "DELETE FROM model WHERE id=" & intStID
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Deletion aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

                'refresh data
                tabell()

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

    Private Sub Uppdate_Click(sender As Object, e As EventArgs) Handles Uppdate.Click
        Dim con As SqlConnection = New SqlConnection(conn)

        If Me.DataGridView1.Rows.Count > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim query As String = "update model set make=@make,name=@name,class=@class where id=@id"
                con.Open()
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                cmd.Parameters.AddWithValue("@make", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@name", TextBox3.Text)
                cmd.Parameters.AddWithValue("@class", ComboBox2.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Records updated successfully")
                tabell()
            Else
                MessageBox.Show("No record selected for update.", "update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No record to be update.", "update ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        clear()
        con.Close()
    End Sub


    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        closingForm(e)

    End Sub 'Form1_Closing

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox1.Text = DataGridView1.Item(0, i).Value
        Me.ComboBox1.Text = DataGridView1.Item(1, i).Value
        Me.TextBox3.Text = DataGridView1.Item(2, i).Value
        Me.ComboBox2.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub clear()
        TextBox1.Text = " model id is auto number"
        ComboBox1.Text = ""
        TextBox3.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class