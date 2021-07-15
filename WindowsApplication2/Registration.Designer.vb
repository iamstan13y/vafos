<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtBusName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegKey = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Broken Glass", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(217, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FOOD-OUTLET SYSTEM"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Yellow
        Me.btnRegister.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture1
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Arista 2.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Red
        Me.btnRegister.Location = New System.Drawing.Point(348, 458)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(207, 87)
        Me.btnRegister.TabIndex = 0
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRegister.UseVisualStyleBackColor = False
        Me.btnRegister.UseWaitCursor = True
        '
        'txtBusName
        '
        Me.txtBusName.BackColor = System.Drawing.Color.Yellow
        Me.txtBusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusName.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusName.ForeColor = System.Drawing.Color.Silver
        Me.txtBusName.Location = New System.Drawing.Point(416, 449)
        Me.txtBusName.MaxLength = 20
        Me.txtBusName.Multiline = True
        Me.txtBusName.Name = "txtBusName"
        Me.txtBusName.Size = New System.Drawing.Size(217, 38)
        Me.txtBusName.TabIndex = 1
        Me.txtBusName.Text = "fast food name"
        Me.txtBusName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(191, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BUSINESS NAME:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(156, 513)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "REGISTRATION KEY:"
        Me.Label3.Visible = False
        '
        'txtRegKey
        '
        Me.txtRegKey.BackColor = System.Drawing.Color.Yellow
        Me.txtRegKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegKey.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegKey.ForeColor = System.Drawing.Color.Silver
        Me.txtRegKey.Location = New System.Drawing.Point(416, 513)
        Me.txtRegKey.MaxLength = 15
        Me.txtRegKey.Multiline = True
        Me.txtRegKey.Name = "txtRegKey"
        Me.txtRegKey.Size = New System.Drawing.Size(217, 38)
        Me.txtRegKey.TabIndex = 3
        Me.txtRegKey.Text = "XXX-XXX-XXX-XXX"
        Me.txtRegKey.Visible = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Yellow
        Me.btnContinue.BackgroundImage = Global.Vegatronix.My.Resources.Resources.CONT
        Me.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnContinue.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnContinue.FlatAppearance.BorderSize = 0
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Arista 2.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.Red
        Me.btnContinue.Location = New System.Drawing.Point(632, 557)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(55, 47)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnContinue.UseVisualStyleBackColor = False
        Me.btnContinue.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.BackgroundImage = Global.Vegatronix.My.Resources.Resources._014
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arista 2.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(691, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(41, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Screenshot__23_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 642)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRegKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBusName)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arista 2.0", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtBusName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRegKey As System.Windows.Forms.TextBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
