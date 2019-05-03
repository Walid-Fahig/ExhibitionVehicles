
Imports System.Data.SqlClient

Module Module2
    Public userId As String

    Public conn As String = "Data Source=DESKTOP-CBPSEOH;Initial Catalog=vehicle;Integrated Security=True"



    Public connectionn As SqlConnection = New SqlConnection(conn)


    'model خاص بملاء جدول 
    Sub tabell()
        Dim adp As SqlDataAdapter = New SqlDataAdapter _
            ("select * from model", connectionn)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        Model.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Sub tabelCar()
        Dim adp As SqlDataAdapter = New SqlDataAdapter _
            ("select * from Car", connectionn)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        Car.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Sub tabelSales()
        Dim adp As SqlDataAdapter = New SqlDataAdapter _
            ("select * from sales", connectionn)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        Sales.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Sub tabelDelete_car()
        Dim adp As SqlDataAdapter = New SqlDataAdapter _
            ("select * from car_del", connectionn)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        delete_car.DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Sub closingForm(e)
        If MessageBox.Show(" Are you sure you want to Exit?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        End If ' Call method to save file...
    End Sub
End Module
