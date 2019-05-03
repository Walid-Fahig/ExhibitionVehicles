Public Class Main
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelToolStripMenuItem.Click
        Model.Show()
        Me.Hide()
    End Sub

    Private Sub CarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarToolStripMenuItem.Click
        Car.Show()
        Me.Hide()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Sales.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        ViewHelp.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'History.Show()
        ' Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sales.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = userId

        Timer1.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("Are You Sure to Exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit!") = MsgBoxResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        closingForm(e)

    End Sub 'Form1_Closing

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("dd-MMM-yy  hh:mm:ss tt")
    End Sub

    Private Sub Main_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'If e.KeyChar = Chr(18) Then
        '    Model.Show()
        '    Me.Hide()
        'End If
    End Sub

    Private Sub InfoDeletecarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoDeletecarToolStripMenuItem.Click
        delete_car.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Car.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Model.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class