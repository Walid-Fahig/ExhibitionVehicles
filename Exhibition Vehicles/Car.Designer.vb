<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Car
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Car))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.serch_Label1 = New System.Windows.Forms.Label()
        Me.id_TextBox1 = New System.Windows.Forms.TextBox()
        Me.id_Label2 = New System.Windows.Forms.Label()
        Me.model_id_Label3 = New System.Windows.Forms.Label()
        Me.color_Label4 = New System.Windows.Forms.Label()
        Me.year_Label5 = New System.Windows.Forms.Label()
        Me.price_Label6 = New System.Windows.Forms.Label()
        Me.color_TextBox2 = New System.Windows.Forms.TextBox()
        Me.year_TextBox3 = New System.Windows.Forms.TextBox()
        Me.price_TextBox4 = New System.Windows.Forms.TextBox()
        Me.serch_TextBox5 = New System.Windows.Forms.TextBox()
        Me.model_id_ComBox1 = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.date_Label1 = New System.Windows.Forms.Label()
        Me.AddImage = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Print_Button2 = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Updatee = New System.Windows.Forms.Button()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(469, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(381, 363)
        Me.DataGridView1.TabIndex = 1
        '
        'serch_Label1
        '
        Me.serch_Label1.AutoSize = True
        Me.serch_Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serch_Label1.Location = New System.Drawing.Point(10, 23)
        Me.serch_Label1.Name = "serch_Label1"
        Me.serch_Label1.Size = New System.Drawing.Size(112, 33)
        Me.serch_Label1.TabIndex = 2
        Me.serch_Label1.Text = "Model_id :"
        '
        'id_TextBox1
        '
        Me.id_TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_TextBox1.Location = New System.Drawing.Point(79, 29)
        Me.id_TextBox1.Name = "id_TextBox1"
        Me.id_TextBox1.Size = New System.Drawing.Size(143, 29)
        Me.id_TextBox1.TabIndex = 4
        '
        'id_Label2
        '
        Me.id_Label2.AutoSize = True
        Me.id_Label2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_Label2.Location = New System.Drawing.Point(6, 29)
        Me.id_Label2.Name = "id_Label2"
        Me.id_Label2.Size = New System.Drawing.Size(33, 33)
        Me.id_Label2.TabIndex = 5
        Me.id_Label2.Text = "id"
        '
        'model_id_Label3
        '
        Me.model_id_Label3.AutoSize = True
        Me.model_id_Label3.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model_id_Label3.Location = New System.Drawing.Point(6, 127)
        Me.model_id_Label3.Name = "model_id_Label3"
        Me.model_id_Label3.Size = New System.Drawing.Size(99, 33)
        Me.model_id_Label3.TabIndex = 6
        Me.model_id_Label3.Text = "model_id"
        '
        'color_Label4
        '
        Me.color_Label4.AutoSize = True
        Me.color_Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_Label4.Location = New System.Drawing.Point(6, 171)
        Me.color_Label4.Name = "color_Label4"
        Me.color_Label4.Size = New System.Drawing.Size(62, 33)
        Me.color_Label4.TabIndex = 7
        Me.color_Label4.Text = "color"
        '
        'year_Label5
        '
        Me.year_Label5.AutoSize = True
        Me.year_Label5.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year_Label5.Location = New System.Drawing.Point(6, 219)
        Me.year_Label5.Name = "year_Label5"
        Me.year_Label5.Size = New System.Drawing.Size(57, 33)
        Me.year_Label5.TabIndex = 8
        Me.year_Label5.Text = "year"
        '
        'price_Label6
        '
        Me.price_Label6.AutoSize = True
        Me.price_Label6.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_Label6.Location = New System.Drawing.Point(6, 270)
        Me.price_Label6.Name = "price_Label6"
        Me.price_Label6.Size = New System.Drawing.Size(62, 33)
        Me.price_Label6.TabIndex = 9
        Me.price_Label6.Text = "price"
        '
        'color_TextBox2
        '
        Me.color_TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_TextBox2.Location = New System.Drawing.Point(79, 171)
        Me.color_TextBox2.Name = "color_TextBox2"
        Me.color_TextBox2.Size = New System.Drawing.Size(143, 29)
        Me.color_TextBox2.TabIndex = 10
        '
        'year_TextBox3
        '
        Me.year_TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year_TextBox3.Location = New System.Drawing.Point(79, 219)
        Me.year_TextBox3.Name = "year_TextBox3"
        Me.year_TextBox3.Size = New System.Drawing.Size(143, 29)
        Me.year_TextBox3.TabIndex = 11
        '
        'price_TextBox4
        '
        Me.price_TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_TextBox4.Location = New System.Drawing.Point(79, 265)
        Me.price_TextBox4.Name = "price_TextBox4"
        Me.price_TextBox4.Size = New System.Drawing.Size(143, 29)
        Me.price_TextBox4.TabIndex = 12
        '
        'serch_TextBox5
        '
        Me.serch_TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serch_TextBox5.Location = New System.Drawing.Point(139, 27)
        Me.serch_TextBox5.Name = "serch_TextBox5"
        Me.serch_TextBox5.Size = New System.Drawing.Size(449, 29)
        Me.serch_TextBox5.TabIndex = 13
        '
        'model_id_ComBox1
        '
        Me.model_id_ComBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model_id_ComBox1.FormattingEnabled = True
        Me.model_id_ComBox1.Location = New System.Drawing.Point(108, 123)
        Me.model_id_ComBox1.Name = "model_id_ComBox1"
        Me.model_id_ComBox1.Size = New System.Drawing.Size(143, 32)
        Me.model_id_ComBox1.TabIndex = 14
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.date_Label1)
        Me.GroupBox1.Controls.Add(Me.id_TextBox1)
        Me.GroupBox1.Controls.Add(Me.id_Label2)
        Me.GroupBox1.Controls.Add(Me.AddImage)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.model_id_ComBox1)
        Me.GroupBox1.Controls.Add(Me.model_id_Label3)
        Me.GroupBox1.Controls.Add(Me.color_Label4)
        Me.GroupBox1.Controls.Add(Me.color_TextBox2)
        Me.GroupBox1.Controls.Add(Me.year_TextBox3)
        Me.GroupBox1.Controls.Add(Me.year_Label5)
        Me.GroupBox1.Controls.Add(Me.price_Label6)
        Me.GroupBox1.Controls.Add(Me.price_TextBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 301)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Car data"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(79, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(143, 29)
        Me.DateTimePicker1.TabIndex = 22
        '
        'date_Label1
        '
        Me.date_Label1.AutoSize = True
        Me.date_Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Label1.Location = New System.Drawing.Point(7, 80)
        Me.date_Label1.Name = "date_Label1"
        Me.date_Label1.Size = New System.Drawing.Size(58, 33)
        Me.date_Label1.TabIndex = 21
        Me.date_Label1.Text = "date"
        '
        'AddImage
        '
        Me.AddImage.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.File_Picture
        Me.AddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AddImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddImage.Location = New System.Drawing.Point(257, 206)
        Me.AddImage.Name = "AddImage"
        Me.AddImage.Size = New System.Drawing.Size(168, 42)
        Me.AddImage.TabIndex = 18
        Me.AddImage.Text = "Browse Img"
        Me.AddImage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(275, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Print_Button2
        '
        Me.Print_Button2.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.Printer
        Me.Print_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Print_Button2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print_Button2.Location = New System.Drawing.Point(212, 414)
        Me.Print_Button2.Name = "Print_Button2"
        Me.Print_Button2.Size = New System.Drawing.Size(129, 35)
        Me.Print_Button2.TabIndex = 20
        Me.Print_Button2.Text = "Print"
        Me.Print_Button2.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.x
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Delete.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(269, 370)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(127, 38)
        Me.Delete.TabIndex = 17
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Updatee
        '
        Me.Updatee.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.Update
        Me.Updatee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Updatee.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatee.Location = New System.Drawing.Point(131, 370)
        Me.Updatee.Name = "Updatee"
        Me.Updatee.Size = New System.Drawing.Size(133, 38)
        Me.Updatee.TabIndex = 16
        Me.Updatee.Text = "Update"
        Me.Updatee.UseVisualStyleBackColor = True
        '
        'Insert
        '
        Me.Insert.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.__
        Me.Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Insert.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Location = New System.Drawing.Point(12, 370)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(113, 38)
        Me.Insert.TabIndex = 15
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.search
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(615, 28)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(133, 32)
        Me.Search.TabIndex = 3
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Exhibition_Vehicles.My.Resources.Resources.back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(76, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Car
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(873, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Print_Button2)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Updatee)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.serch_TextBox5)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.serch_Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Car"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents serch_Label1 As Label
    Friend WithEvents Search As Button
    Friend WithEvents id_TextBox1 As TextBox
    Friend WithEvents id_Label2 As Label
    Friend WithEvents model_id_Label3 As Label
    Friend WithEvents color_Label4 As Label
    Friend WithEvents year_Label5 As Label
    Friend WithEvents price_Label6 As Label
    Friend WithEvents color_TextBox2 As TextBox
    Friend WithEvents year_TextBox3 As TextBox
    Friend WithEvents price_TextBox4 As TextBox
    Friend WithEvents serch_TextBox5 As TextBox
    Friend WithEvents model_id_ComBox1 As ComboBox
    Friend WithEvents Insert As Button
    Friend WithEvents Updatee As Button
    Friend WithEvents Delete As Button
    Friend WithEvents AddImage As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Print_Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents date_Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
