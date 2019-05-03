Imports System.Data.SqlClient

Public Class Form1
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        If ComboBox1.Text.Length <= 0 Then
            ' MessageBox.Show("Please enter Username!")
            MessageBox.Show("Please enter Username!", "information login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter Password!", "information login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'MessageBox.Show("Please enter Password!")
        Else

            Dim str As String = "Data Source=DESKTOP-CBPSEOH;Initial Catalog=vehicle;Integrated Security=True"

            Dim sql As String = "select count(*) from login where
           username=@username and password=@password"

            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@username", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@password", TextBox1.Text)
                    Dim value = cmd.ExecuteScalar()
                    If value > 0 Then
                        ' MessageBox.Show("Login sucessfully!")
                        userId = ComboBox1.Text
                        Form2.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid login", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
                clear()
                Conn.Close
            End Using
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim connection As New SqlConnection("Data Source=DESKTOP-CBPSEOH\MSSQLSERVERR;
        'Integrated Security=SSPI;Initial Catalog=vehicle")

        Dim command As New SqlCommand("select username from login", connectionn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "username"

        clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event

            ButtonLogin_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        closingForm(e)

    End Sub 'Form1_Closing

    Private Sub clear()
        ComboBox1.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
