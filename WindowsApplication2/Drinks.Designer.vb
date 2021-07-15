<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrinks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdateDrink = New System.Windows.Forms.Button()
        Me.btnDeleteDrink = New System.Windows.Forms.Button()
        Me.lnklblDrink = New System.Windows.Forms.LinkLabel()
        Me.picDrink = New System.Windows.Forms.PictureBox()
        Me.txtDrinkPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddDrink = New System.Windows.Forms.Button()
        Me.txtDrink = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DrinksDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumUpDwn = New System.Windows.Forms.NumericUpDown()
        CType(Me.picDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrinksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDwn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(223, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(32, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Drink ID:"
        '
        'btnUpdateDrink
        '
        Me.btnUpdateDrink.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdateDrink.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnUpdateDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateDrink.FlatAppearance.BorderSize = 0
        Me.btnUpdateDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateDrink.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDrink.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateDrink.Location = New System.Drawing.Point(379, 71)
        Me.btnUpdateDrink.Name = "btnUpdateDrink"
        Me.btnUpdateDrink.Size = New System.Drawing.Size(70, 35)
        Me.btnUpdateDrink.TabIndex = 39
        Me.btnUpdateDrink.Text = "Update"
        Me.btnUpdateDrink.UseVisualStyleBackColor = False
        '
        'btnDeleteDrink
        '
        Me.btnDeleteDrink.BackColor = System.Drawing.Color.Yellow
        Me.btnDeleteDrink.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDeleteDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteDrink.FlatAppearance.BorderSize = 0
        Me.btnDeleteDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDrink.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDrink.Location = New System.Drawing.Point(379, 107)
        Me.btnDeleteDrink.Name = "btnDeleteDrink"
        Me.btnDeleteDrink.Size = New System.Drawing.Size(70, 35)
        Me.btnDeleteDrink.TabIndex = 47
        Me.btnDeleteDrink.Text = "Delete"
        Me.btnDeleteDrink.UseVisualStyleBackColor = False
        '
        'lnklblDrink
        '
        Me.lnklblDrink.AutoSize = True
        Me.lnklblDrink.BackColor = System.Drawing.Color.Yellow
        Me.lnklblDrink.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblDrink.Location = New System.Drawing.Point(106, 174)
        Me.lnklblDrink.Name = "lnklblDrink"
        Me.lnklblDrink.Size = New System.Drawing.Size(111, 20)
        Me.lnklblDrink.TabIndex = 46
        Me.lnklblDrink.TabStop = True
        Me.lnklblDrink.Text = "Insert Picture"
        '
        'picDrink
        '
        Me.picDrink.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDrink.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picDrink.ImageLocation = ""
        Me.picDrink.InitialImage = Nothing
        Me.picDrink.Location = New System.Drawing.Point(223, 71)
        Me.picDrink.Name = "picDrink"
        Me.picDrink.Size = New System.Drawing.Size(150, 137)
        Me.picDrink.TabIndex = 45
        Me.picDrink.TabStop = False
        '
        'txtDrinkPrice
        '
        Me.txtDrinkPrice.BackColor = System.Drawing.Color.Yellow
        Me.txtDrinkPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrinkPrice.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrinkPrice.Location = New System.Drawing.Point(117, 136)
        Me.txtDrinkPrice.Name = "txtDrinkPrice"
        Me.txtDrinkPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtDrinkPrice.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(59, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Price:"
        '
        'btnAddDrink
        '
        Me.btnAddDrink.BackColor = System.Drawing.Color.Yellow
        Me.btnAddDrink.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnAddDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddDrink.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddDrink.FlatAppearance.BorderSize = 0
        Me.btnAddDrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine
        Me.btnAddDrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnAddDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDrink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddDrink.Location = New System.Drawing.Point(379, 148)
        Me.btnAddDrink.Name = "btnAddDrink"
        Me.btnAddDrink.Size = New System.Drawing.Size(70, 35)
        Me.btnAddDrink.TabIndex = 42
        Me.btnAddDrink.Text = "Add"
        Me.btnAddDrink.UseVisualStyleBackColor = False
        '
        'txtDrink
        '
        Me.txtDrink.AutoCompleteCustomSource.AddRange(New String() {"Stanley", "Charmza"})
        Me.txtDrink.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDrink.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDrink.BackColor = System.Drawing.Color.Yellow
        Me.txtDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrink.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrink.Location = New System.Drawing.Point(117, 107)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.Size = New System.Drawing.Size(100, 23)
        Me.txtDrink.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(56, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Drink:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Valken", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(179, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Drinks"
        '
        'DrinksDataGridView
        '
        Me.DrinksDataGridView.AllowUserToAddRows = False
        Me.DrinksDataGridView.AllowUserToDeleteRows = False
        Me.DrinksDataGridView.BackgroundColor = System.Drawing.Color.Silver
        Me.DrinksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DrinksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrinksDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DrinksDataGridView.GridColor = System.Drawing.Color.Red
        Me.DrinksDataGridView.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DrinksDataGridView.Location = New System.Drawing.Point(62, 233)
        Me.DrinksDataGridView.Name = "DrinksDataGridView"
        Me.DrinksDataGridView.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        Me.DrinksDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DrinksDataGridView.Size = New System.Drawing.Size(369, 182)
        Me.DrinksDataGridView.TabIndex = 67
        '
        'NumUpDwn
        '
        Me.NumUpDwn.BackColor = System.Drawing.Color.Yellow
        Me.NumUpDwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumUpDwn.Location = New System.Drawing.Point(117, 76)
        Me.NumUpDwn.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NumUpDwn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumUpDwn.Name = "NumUpDwn"
        Me.NumUpDwn.ReadOnly = True
        Me.NumUpDwn.Size = New System.Drawing.Size(100, 20)
        Me.NumUpDwn.TabIndex = 68
        Me.NumUpDwn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FrmDrinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(505, 467)
        Me.Controls.Add(Me.NumUpDwn)
        Me.Controls.Add(Me.DrinksDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUpdateDrink)
        Me.Controls.Add(Me.btnDeleteDrink)
        Me.Controls.Add(Me.lnklblDrink)
        Me.Controls.Add(Me.picDrink)
        Me.Controls.Add(Me.txtDrinkPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAddDrink)
        Me.Controls.Add(Me.txtDrink)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDrinks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Green
        CType(Me.picDrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrinksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDwn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateDrink As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDrink As System.Windows.Forms.Button
    Friend WithEvents lnklblDrink As System.Windows.Forms.LinkLabel
    Friend WithEvents picDrink As System.Windows.Forms.PictureBox
    Friend WithEvents txtDrinkPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAddDrink As System.Windows.Forms.Button
    Friend WithEvents txtDrink As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrinksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NumUpDwn As System.Windows.Forms.NumericUpDown
End Class
