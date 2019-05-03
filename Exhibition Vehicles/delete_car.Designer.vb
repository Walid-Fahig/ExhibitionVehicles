<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delete_car
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AddSales_Button1 = New System.Windows.Forms.Button()
        Me.back_Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(27, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 323)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(687, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'AddSales_Button1
        '
        Me.AddSales_Button1.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.__
        Me.AddSales_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AddSales_Button1.Location = New System.Drawing.Point(558, 376)
        Me.AddSales_Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddSales_Button1.Name = "AddSales_Button1"
        Me.AddSales_Button1.Size = New System.Drawing.Size(139, 39)
        Me.AddSales_Button1.TabIndex = 2
        Me.AddSales_Button1.Text = "AddSales"
        Me.AddSales_Button1.UseVisualStyleBackColor = True
        '
        'back_Button1
        '
        Me.back_Button1.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.back
        Me.back_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.back_Button1.Location = New System.Drawing.Point(399, 376)
        Me.back_Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.back_Button1.Name = "back_Button1"
        Me.back_Button1.Size = New System.Drawing.Size(138, 39)
        Me.back_Button1.TabIndex = 0
        Me.back_Button1.Text = "back"
        Me.back_Button1.UseVisualStyleBackColor = True
        '
        'delete_car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(763, 439)
        Me.Controls.Add(Me.AddSales_Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.back_Button1)
        Me.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "delete_car"
        Me.Text = "Instruction"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents back_Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AddSales_Button1 As Button
End Class
