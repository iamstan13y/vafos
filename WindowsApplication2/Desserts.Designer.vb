<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesserts
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
        Me.lnklblDesserts = New System.Windows.Forms.LinkLabel()
        Me.txtDessertPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDessert = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpdateDesserts = New System.Windows.Forms.Button()
        Me.btnDeleteDesserts = New System.Windows.Forms.Button()
        Me.picDesserts = New System.Windows.Forms.PictureBox()
        Me.btnAddDessert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DessertsDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumUpDwn = New System.Windows.Forms.NumericUpDown()
        CType(Me.picDesserts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DessertsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDwn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(12, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Dessert ID:"
        '
        'lnklblDesserts
        '
        Me.lnklblDesserts.AutoSize = True
        Me.lnklblDesserts.BackColor = System.Drawing.Color.Yellow
        Me.lnklblDesserts.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblDesserts.Location = New System.Drawing.Point(86, 184)
        Me.lnklblDesserts.Name = "lnklblDesserts"
        Me.lnklblDesserts.Size = New System.Drawing.Size(111, 20)
        Me.lnklblDesserts.TabIndex = 59
        Me.lnklblDesserts.TabStop = True
        Me.lnklblDesserts.Text = "Insert Picture"
        '
        'txtDessertPrice
        '
        Me.txtDessertPrice.BackColor = System.Drawing.Color.Yellow
        Me.txtDessertPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDessertPrice.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDessertPrice.Location = New System.Drawing.Point(97, 146)
        Me.txtDessertPrice.Name = "txtDessertPrice"
        Me.txtDessertPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtDessertPrice.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(39, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Price:"
        '
        'txtDessert
        '
        Me.txtDessert.AutoCompleteCustomSource.AddRange(New String() {"Stanley", "Charmza"})
        Me.txtDessert.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDessert.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDessert.BackColor = System.Drawing.Color.Yellow
        Me.txtDessert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDessert.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDessert.Location = New System.Drawing.Point(97, 117)
        Me.txtDessert.Name = "txtDessert"
        Me.txtDessert.Size = New System.Drawing.Size(100, 23)
        Me.txtDessert.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(19, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Dessert:"
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
        Me.Button1.Location = New System.Drawing.Point(203, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnUpdateDesserts
        '
        Me.btnUpdateDesserts.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdateDesserts.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnUpdateDesserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateDesserts.FlatAppearance.BorderSize = 0
        Me.btnUpdateDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateDesserts.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDesserts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateDesserts.Location = New System.Drawing.Point(359, 81)
        Me.btnUpdateDesserts.Name = "btnUpdateDesserts"
        Me.btnUpdateDesserts.Size = New System.Drawing.Size(70, 35)
        Me.btnUpdateDesserts.TabIndex = 52
        Me.btnUpdateDesserts.Text = "Update"
        Me.btnUpdateDesserts.UseVisualStyleBackColor = False
        '
        'btnDeleteDesserts
        '
        Me.btnDeleteDesserts.BackColor = System.Drawing.Color.Yellow
        Me.btnDeleteDesserts.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDeleteDesserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteDesserts.FlatAppearance.BorderSize = 0
        Me.btnDeleteDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDesserts.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDesserts.Location = New System.Drawing.Point(359, 117)
        Me.btnDeleteDesserts.Name = "btnDeleteDesserts"
        Me.btnDeleteDesserts.Size = New System.Drawing.Size(70, 35)
        Me.btnDeleteDesserts.TabIndex = 60
        Me.btnDeleteDesserts.Text = "Delete"
        Me.btnDeleteDesserts.UseVisualStyleBackColor = False
        '
        'picDesserts
        '
        Me.picDesserts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picDesserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDesserts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDesserts.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picDesserts.ImageLocation = ""
        Me.picDesserts.InitialImage = Nothing
        Me.picDesserts.Location = New System.Drawing.Point(203, 81)
        Me.picDesserts.Name = "picDesserts"
        Me.picDesserts.Size = New System.Drawing.Size(150, 137)
        Me.picDesserts.TabIndex = 58
        Me.picDesserts.TabStop = False
        '
        'btnAddDessert
        '
        Me.btnAddDessert.BackColor = System.Drawing.Color.Yellow
        Me.btnAddDessert.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnAddDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddDessert.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddDessert.FlatAppearance.BorderSize = 0
        Me.btnAddDessert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine
        Me.btnAddDessert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnAddDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDessert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddDessert.Location = New System.Drawing.Point(359, 158)
        Me.btnAddDessert.Name = "btnAddDessert"
        Me.btnAddDessert.Size = New System.Drawing.Size(70, 35)
        Me.btnAddDessert.TabIndex = 55
        Me.btnAddDessert.Text = "Add"
        Me.btnAddDessert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Valken", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(160, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Desserts"
        '
        'DessertsDataGridView
        '
        Me.DessertsDataGridView.AllowUserToAddRows = False
        Me.DessertsDataGridView.AllowUserToDeleteRows = False
        Me.DessertsDataGridView.BackgroundColor = System.Drawing.Color.Silver
        Me.DessertsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DessertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DessertsDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DessertsDataGridView.GridColor = System.Drawing.Color.Red
        Me.DessertsDataGridView.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DessertsDataGridView.Location = New System.Drawing.Point(51, 243)
        Me.DessertsDataGridView.Name = "DessertsDataGridView"
        Me.DessertsDataGridView.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        Me.DessertsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DessertsDataGridView.Size = New System.Drawing.Size(369, 182)
        Me.DessertsDataGridView.TabIndex = 66
        '
        'NumUpDwn
        '
        Me.NumUpDwn.BackColor = System.Drawing.Color.Yellow
        Me.NumUpDwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumUpDwn.Location = New System.Drawing.Point(97, 83)
        Me.NumUpDwn.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NumUpDwn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumUpDwn.Name = "NumUpDwn"
        Me.NumUpDwn.ReadOnly = True
        Me.NumUpDwn.Size = New System.Drawing.Size(100, 20)
        Me.NumUpDwn.TabIndex = 67
        Me.NumUpDwn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FrmDesserts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(465, 477)
        Me.Controls.Add(Me.NumUpDwn)
        Me.Controls.Add(Me.DessertsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUpdateDesserts)
        Me.Controls.Add(Me.btnDeleteDesserts)
        Me.Controls.Add(Me.lnklblDesserts)
        Me.Controls.Add(Me.picDesserts)
        Me.Controls.Add(Me.txtDessertPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAddDessert)
        Me.Controls.Add(Me.txtDessert)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDesserts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Green
        CType(Me.picDesserts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DessertsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDwn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateDesserts As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDesserts As System.Windows.Forms.Button
    Friend WithEvents lnklblDesserts As System.Windows.Forms.LinkLabel
    Friend WithEvents picDesserts As System.Windows.Forms.PictureBox
    Friend WithEvents txtDessertPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAddDessert As System.Windows.Forms.Button
    Friend WithEvents txtDessert As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DessertsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NumUpDwn As System.Windows.Forms.NumericUpDown
End Class
