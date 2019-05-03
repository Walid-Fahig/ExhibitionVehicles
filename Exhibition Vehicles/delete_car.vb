Imports System.Data.SqlClient

Public Class delete_car
    Private Sub back_Button1_Click(sender As Object, e As EventArgs) Handles back_Button1.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub delete_car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabelDelete_car()
    End Sub

    Private Sub AddSales_Button1_Click(sender As Object, e As EventArgs) Handles AddSales_Button1.Click
        AddSales.Show()
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        AddSales.id_TextBox1.Text = DataGridView1.Item(0, i).Value
        AddSales.DateTimePicker1.Text = DataGridView1.Item(1, i).Value
        AddSales.model_id_ComboBox1.Text = DataGridView1.Item(2, i).Value
        AddSales.color_TextBox2.Text = DataGridView1.Item(3, i).Value
        AddSales.year_TextBox3.Text = DataGridView1.Item(4, i).Value
        AddSales.price_TextBox4.Text = DataGridView1.Item(5, i).Value

    End Sub
End Class