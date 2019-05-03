Imports System.Data.SqlClient

Public Class Sales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabelSales()


    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        closingForm(e)

    End Sub 'Form1_Closings

    Private Sub print_Button2_Click(sender As Object, e As EventArgs) Handles print_Button2.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Search_Button2_Click(sender As Object, e As EventArgs) Handles Search_Button2.Click
        Dim searchQuery As String = "SELECT * From Sales WHERE
           model_id like '%" & Search_TextBox1.Text & "%'"
        connectionn.Open()
        Dim command As New SqlCommand(searchQuery, connectionn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
        connectionn.Close()
    End Sub
End Class