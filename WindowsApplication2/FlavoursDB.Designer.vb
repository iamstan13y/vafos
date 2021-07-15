<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFlavoursDB
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtFlavour = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDeleteFlavour = New System.Windows.Forms.Button()
        Me.btnAddFlavour = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlavoursDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtFoodItemFlvr = New System.Windows.Forms.TextBox()
        CType(Me.FlavoursDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFlavour
        '
        Me.txtFlavour.BackColor = System.Drawing.Color.Yellow
        Me.txtFlavour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFlavour.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlavour.Location = New System.Drawing.Point(110, 90)
        Me.txtFlavour.Name = "txtFlavour"
        Me.txtFlavour.Size = New System.Drawing.Size(100, 23)
        Me.txtFlavour.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(30, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Flavour:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(9, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Food Item:"
        '
        'btnDeleteFlavour
        '
        Me.btnDeleteFlavour.BackColor = System.Drawing.Color.Yellow
        Me.btnDeleteFlavour.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDeleteFlavour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteFlavour.FlatAppearance.BorderSize = 0
        Me.btnDeleteFlavour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteFlavour.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteFlavour.Location = New System.Drawing.Point(158, 119)
        Me.btnDeleteFlavour.Name = "btnDeleteFlavour"
        Me.btnDeleteFlavour.Size = New System.Drawing.Size(70, 35)
        Me.btnDeleteFlavour.TabIndex = 59
        Me.btnDeleteFlavour.Text = "Delete"
        Me.btnDeleteFlavour.UseVisualStyleBackColor = False
        '
        'btnAddFlavour
        '
        Me.btnAddFlavour.BackColor = System.Drawing.Color.Yellow
        Me.btnAddFlavour.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnAddFlavour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddFlavour.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddFlavour.FlatAppearance.BorderSize = 0
        Me.btnAddFlavour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine
        Me.btnAddFlavour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnAddFlavour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFlavour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddFlavour.Location = New System.Drawing.Point(82, 119)
        Me.btnAddFlavour.Name = "btnAddFlavour"
        Me.btnAddFlavour.Size = New System.Drawing.Size(70, 35)
        Me.btnAddFlavour.TabIndex = 54
        Me.btnAddFlavour.Text = "Add"
        Me.btnAddFlavour.UseVisualStyleBackColor = False
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
        Me.btnDone.Location = New System.Drawing.Point(110, 335)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(91, 39)
        Me.btnDone.TabIndex = 61
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Valken", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(99, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 29)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Flavours"
        '
        'FlavoursDataGridView
        '
        Me.FlavoursDataGridView.AllowUserToAddRows = False
        Me.FlavoursDataGridView.AllowUserToDeleteRows = False
        Me.FlavoursDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlavoursDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FlavoursDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.FlavoursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FlavoursDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FlavoursDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.FlavoursDataGridView.GridColor = System.Drawing.Color.Red
        Me.FlavoursDataGridView.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.FlavoursDataGridView.Location = New System.Drawing.Point(33, 172)
        Me.FlavoursDataGridView.Name = "FlavoursDataGridView"
        Me.FlavoursDataGridView.ReadOnly = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow
        Me.FlavoursDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.FlavoursDataGridView.Size = New System.Drawing.Size(236, 137)
        Me.FlavoursDataGridView.TabIndex = 63
        '
        'txtFoodItemFlvr
        '
        Me.txtFoodItemFlvr.AutoCompleteCustomSource.AddRange(New String() {"Stanley", "Charmza"})
        Me.txtFoodItemFlvr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFoodItemFlvr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFoodItemFlvr.BackColor = System.Drawing.Color.Yellow
        Me.txtFoodItemFlvr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFoodItemFlvr.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodItemFlvr.Location = New System.Drawing.Point(110, 61)
        Me.txtFoodItemFlvr.Name = "txtFoodItemFlvr"
        Me.txtFoodItemFlvr.Size = New System.Drawing.Size(100, 23)
        Me.txtFoodItemFlvr.TabIndex = 53
        '
        'FrmFlavoursDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(310, 386)
        Me.Controls.Add(Me.FlavoursDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnDeleteFlavour)
        Me.Controls.Add(Me.txtFlavour)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAddFlavour)
        Me.Controls.Add(Me.txtFoodItemFlvr)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFlavoursDB"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Green
        CType(Me.FlavoursDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeleteFlavour As System.Windows.Forms.Button
    Friend WithEvents txtFlavour As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAddFlavour As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlavoursDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtFoodItemFlvr As System.Windows.Forms.TextBox
End Class
