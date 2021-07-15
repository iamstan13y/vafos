<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Me.SettingsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lstboxConsole = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.lblDone = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.SettingsTimer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SettingsTimer
        '
        '
        'lstboxConsole
        '
        Me.lstboxConsole.BackColor = System.Drawing.Color.Black
        Me.lstboxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstboxConsole.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxConsole.ForeColor = System.Drawing.Color.Lime
        Me.lstboxConsole.FormattingEnabled = True
        Me.lstboxConsole.ItemHeight = 18
        Me.lstboxConsole.Location = New System.Drawing.Point(3, 242)
        Me.lstboxConsole.Name = "lstboxConsole"
        Me.lstboxConsole.Size = New System.Drawing.Size(490, 182)
        Me.lstboxConsole.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Vtks Mercearia", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 72)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FOOD-OUTLET SYSTEM"
        '
        'picLoading
        '
        Me.picLoading.BackColor = System.Drawing.Color.Yellow
        Me.picLoading.Image = Global.Vegatronix.My.Resources.Resources.QWERTY
        Me.picLoading.Location = New System.Drawing.Point(47, 182)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(399, 26)
        Me.picLoading.TabIndex = 3
        Me.picLoading.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Yellow
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 425)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(169, 22)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Creating Database"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Yellow
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(12, 451)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(149, 22)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Creating Tables"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Yellow
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(12, 477)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(173, 22)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "Finalizing Settings"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'lblDone
        '
        Me.lblDone.AutoSize = True
        Me.lblDone.BackColor = System.Drawing.Color.Yellow
        Me.lblDone.Font = New System.Drawing.Font("Valken", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDone.ForeColor = System.Drawing.Color.Blue
        Me.lblDone.Location = New System.Drawing.Point(167, 173)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(142, 45)
        Me.lblDone.TabIndex = 7
        Me.lblDone.Text = "DONE!"
        Me.lblDone.Visible = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Yellow
        Me.btnContinue.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture4
        Me.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnContinue.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnContinue.FlatAppearance.BorderSize = 0
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Arista 2.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.Red
        Me.btnContinue.Location = New System.Drawing.Point(160, 518)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(149, 67)
        Me.btnContinue.TabIndex = 8
        Me.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnContinue.UseVisualStyleBackColor = False
        Me.btnContinue.UseWaitCursor = True
        Me.btnContinue.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Yellow
        Me.lblError.Font = New System.Drawing.Font("Valken", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(149, 173)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(160, 45)
        Me.lblError.TabIndex = 9
        Me.lblError.Text = "ERROR!"
        Me.lblError.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(71, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "&DO NOT INTERRUPT THIS ACTION!"
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.Color.Yellow
        Me.btnRetry.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRetry.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnRetry.FlatAppearance.BorderSize = 0
        Me.btnRetry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRetry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetry.Font = New System.Drawing.Font("Arista 2.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetry.ForeColor = System.Drawing.Color.Yellow
        Me.btnRetry.Location = New System.Drawing.Point(142, 515)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(167, 73)
        Me.btnRetry.TabIndex = 11
        Me.btnRetry.Text = "RETRY!"
        Me.btnRetry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRetry.UseVisualStyleBackColor = False
        Me.btnRetry.UseWaitCursor = True
        Me.btnRetry.Visible = False
        '
        'SettingsTimer2
        '
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(495, 597)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblDone)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.picLoading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstboxConsole)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TransparencyKey = System.Drawing.Color.Brown
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SettingsTimer As System.Windows.Forms.Timer
    Friend WithEvents lstboxConsole As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picLoading As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDone As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRetry As System.Windows.Forms.Button
    Friend WithEvents SettingsTimer2 As System.Windows.Forms.Timer
End Class
