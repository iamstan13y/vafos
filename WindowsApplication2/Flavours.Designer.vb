<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flavours
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
        Me.FlavoursLstBox = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hdnFoodItem = New System.Windows.Forms.Label()
        Me.hdnPrice = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FlavoursLstBox
        '
        Me.FlavoursLstBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlavoursLstBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FlavoursLstBox.Font = New System.Drawing.Font("Sans Culottes", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlavoursLstBox.ForeColor = System.Drawing.Color.Lime
        Me.FlavoursLstBox.FormattingEnabled = True
        Me.FlavoursLstBox.Location = New System.Drawing.Point(2, 31)
        Me.FlavoursLstBox.Name = "FlavoursLstBox"
        Me.FlavoursLstBox.Size = New System.Drawing.Size(208, 182)
        Me.FlavoursLstBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dacquoise", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Your Favourite"
        '
        'hdnFoodItem
        '
        Me.hdnFoodItem.AutoSize = True
        Me.hdnFoodItem.Location = New System.Drawing.Point(12, 216)
        Me.hdnFoodItem.Name = "hdnFoodItem"
        Me.hdnFoodItem.Size = New System.Drawing.Size(0, 13)
        Me.hdnFoodItem.TabIndex = 8
        Me.hdnFoodItem.Visible = False
        '
        'hdnPrice
        '
        Me.hdnPrice.AutoSize = True
        Me.hdnPrice.Location = New System.Drawing.Point(93, 216)
        Me.hdnPrice.Name = "hdnPrice"
        Me.hdnPrice.Size = New System.Drawing.Size(0, 13)
        Me.hdnPrice.TabIndex = 9
        Me.hdnPrice.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Dacquoise", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Yellow
        Me.btnCancel.Location = New System.Drawing.Point(62, 216)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 33)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Flavours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(217, 252)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.hdnPrice)
        Me.Controls.Add(Me.hdnFoodItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlavoursLstBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Flavours"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlavoursLstBox As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents hdnFoodItem As Label
    Friend WithEvents hdnPrice As Label
    Friend WithEvents btnCancel As Button
End Class
