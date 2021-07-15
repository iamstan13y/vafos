<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFoodItems
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdateFood = New System.Windows.Forms.Button()
        Me.btnDeleteFood = New System.Windows.Forms.Button()
        Me.lnklblFood = New System.Windows.Forms.LinkLabel()
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.txtFoodPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddFood = New System.Windows.Forms.Button()
        Me.txtFoodItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.FoodItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumUpDwn = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDwn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(44, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Item ID:"
        '
        'btnUpdateFood
        '
        Me.btnUpdateFood.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdateFood.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnUpdateFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateFood.FlatAppearance.BorderSize = 0
        Me.btnUpdateFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateFood.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFood.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateFood.Location = New System.Drawing.Point(384, 98)
        Me.btnUpdateFood.Name = "btnUpdateFood"
        Me.btnUpdateFood.Size = New System.Drawing.Size(70, 35)
        Me.btnUpdateFood.TabIndex = 26
        Me.btnUpdateFood.Text = "Update"
        Me.btnUpdateFood.UseVisualStyleBackColor = False
        '
        'btnDeleteFood
        '
        Me.btnDeleteFood.BackColor = System.Drawing.Color.Yellow
        Me.btnDeleteFood.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDeleteFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteFood.FlatAppearance.BorderSize = 0
        Me.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteFood.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteFood.Location = New System.Drawing.Point(384, 134)
        Me.btnDeleteFood.Name = "btnDeleteFood"
        Me.btnDeleteFood.Size = New System.Drawing.Size(70, 35)
        Me.btnDeleteFood.TabIndex = 34
        Me.btnDeleteFood.Text = "Delete"
        Me.btnDeleteFood.UseVisualStyleBackColor = False
        '
        'lnklblFood
        '
        Me.lnklblFood.AutoSize = True
        Me.lnklblFood.BackColor = System.Drawing.Color.Yellow
        Me.lnklblFood.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblFood.Location = New System.Drawing.Point(111, 201)
        Me.lnklblFood.Name = "lnklblFood"
        Me.lnklblFood.Size = New System.Drawing.Size(111, 20)
        Me.lnklblFood.TabIndex = 33
        Me.lnklblFood.TabStop = True
        Me.lnklblFood.Text = "Insert Picture"
        '
        'picFood
        '
        Me.picFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFood.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picFood.ImageLocation = ""
        Me.picFood.InitialImage = Nothing
        Me.picFood.Location = New System.Drawing.Point(228, 98)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(150, 137)
        Me.picFood.TabIndex = 32
        Me.picFood.TabStop = False
        '
        'txtFoodPrice
        '
        Me.txtFoodPrice.BackColor = System.Drawing.Color.Yellow
        Me.txtFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFoodPrice.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodPrice.Location = New System.Drawing.Point(122, 163)
        Me.txtFoodPrice.Name = "txtFoodPrice"
        Me.txtFoodPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtFoodPrice.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(64, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Price:"
        '
        'btnAddFood
        '
        Me.btnAddFood.BackColor = System.Drawing.Color.Yellow
        Me.btnAddFood.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddFood.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddFood.FlatAppearance.BorderSize = 0
        Me.btnAddFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine
        Me.btnAddFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddFood.Location = New System.Drawing.Point(384, 175)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(70, 35)
        Me.btnAddFood.TabIndex = 29
        Me.btnAddFood.Text = "Add"
        Me.btnAddFood.UseVisualStyleBackColor = False
        '
        'txtFoodItem
        '
        Me.txtFoodItem.AutoCompleteCustomSource.AddRange(New String() {"Stanley", "Charmza"})
        Me.txtFoodItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFoodItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFoodItem.BackColor = System.Drawing.Color.Yellow
        Me.txtFoodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFoodItem.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodItem.Location = New System.Drawing.Point(122, 134)
        Me.txtFoodItem.Name = "txtFoodItem"
        Me.txtFoodItem.Size = New System.Drawing.Size(100, 23)
        Me.txtFoodItem.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(21, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Food Item:"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Yellow
        Me.btnDone.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDone.Location = New System.Drawing.Point(228, 448)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(91, 39)
        Me.btnDone.TabIndex = 38
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'FoodItemsDataGridView
        '
        Me.FoodItemsDataGridView.AllowUserToAddRows = False
        Me.FoodItemsDataGridView.AllowUserToDeleteRows = False
        Me.FoodItemsDataGridView.BackgroundColor = System.Drawing.Color.Silver
        Me.FoodItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FoodItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodItemsDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FoodItemsDataGridView.GridColor = System.Drawing.Color.Red
        Me.FoodItemsDataGridView.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.FoodItemsDataGridView.Location = New System.Drawing.Point(76, 253)
        Me.FoodItemsDataGridView.Name = "FoodItemsDataGridView"
        Me.FoodItemsDataGridView.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        Me.FoodItemsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FoodItemsDataGridView.Size = New System.Drawing.Size(378, 189)
        Me.FoodItemsDataGridView.TabIndex = 39
        '
        'NumUpDwn
        '
        Me.NumUpDwn.BackColor = System.Drawing.Color.Yellow
        Me.NumUpDwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumUpDwn.Location = New System.Drawing.Point(122, 98)
        Me.NumUpDwn.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NumUpDwn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumUpDwn.Name = "NumUpDwn"
        Me.NumUpDwn.ReadOnly = True
        Me.NumUpDwn.Size = New System.Drawing.Size(100, 20)
        Me.NumUpDwn.TabIndex = 40
        Me.NumUpDwn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Valken", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(207, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Food Items"
        '
        'FrmFoodItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(537, 499)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumUpDwn)
        Me.Controls.Add(Me.FoodItemsDataGridView)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUpdateFood)
        Me.Controls.Add(Me.btnDeleteFood)
        Me.Controls.Add(Me.lnklblFood)
        Me.Controls.Add(Me.picFood)
        Me.Controls.Add(Me.txtFoodPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAddFood)
        Me.Controls.Add(Me.txtFoodItem)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFoodItems"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Green
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDwn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateFood As System.Windows.Forms.Button
    Friend WithEvents btnDeleteFood As System.Windows.Forms.Button
    Friend WithEvents lnklblFood As System.Windows.Forms.LinkLabel
    Friend WithEvents picFood As System.Windows.Forms.PictureBox
    Friend WithEvents txtFoodPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAddFood As System.Windows.Forms.Button
    Friend WithEvents txtFoodItem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents FoodItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NumUpDwn As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
