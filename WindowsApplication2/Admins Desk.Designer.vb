<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdminsDesk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminsDesk))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnFoodItems = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFlavours = New System.Windows.Forms.Button()
        Me.btnDesserts = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnUpdateAdmin = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.btnDeleteAdmn = New System.Windows.Forms.Button()
        Me.txtConfirmNewPwd = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.chkUsername = New System.Windows.Forms.CheckBox()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ChkShowPwd = New System.Windows.Forms.CheckBox()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConfirmPwd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblLoggenIn = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 711)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logged in as:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 711)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(1, Byte), True)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(12, 95)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(518, 398)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.Yellow
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.btnFoodItems)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnFlavours)
        Me.TabPage1.Controls.Add(Me.btnDesserts)
        Me.TabPage1.Controls.Add(Me.btnDrinks)
        Me.TabPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(510, 368)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menu Items"
        '
        'btnFoodItems
        '
        Me.btnFoodItems.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnFoodItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFoodItems.FlatAppearance.BorderSize = 0
        Me.btnFoodItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoodItems.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoodItems.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFoodItems.Image = Global.Vegatronix.My.Resources.Resources.menuu
        Me.btnFoodItems.Location = New System.Drawing.Point(38, 149)
        Me.btnFoodItems.Name = "btnFoodItems"
        Me.btnFoodItems.Size = New System.Drawing.Size(181, 68)
        Me.btnFoodItems.TabIndex = 31
        Me.btnFoodItems.Text = " Food Items"
        Me.btnFoodItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFoodItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFoodItems.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(90, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 27)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Manage Order Items:"
        '
        'btnFlavours
        '
        Me.btnFlavours.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnFlavours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFlavours.FlatAppearance.BorderSize = 0
        Me.btnFlavours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlavours.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlavours.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFlavours.Image = Global.Vegatronix.My.Resources.Resources.xyx
        Me.btnFlavours.Location = New System.Drawing.Point(257, 281)
        Me.btnFlavours.Name = "btnFlavours"
        Me.btnFlavours.Size = New System.Drawing.Size(181, 68)
        Me.btnFlavours.TabIndex = 29
        Me.btnFlavours.Text = " Flavours"
        Me.btnFlavours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFlavours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFlavours.UseVisualStyleBackColor = True
        '
        'btnDesserts
        '
        Me.btnDesserts.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDesserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDesserts.FlatAppearance.BorderSize = 0
        Me.btnDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesserts.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesserts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDesserts.Image = Global.Vegatronix.My.Resources.Resources.dz
        Me.btnDesserts.Location = New System.Drawing.Point(257, 149)
        Me.btnDesserts.Name = "btnDesserts"
        Me.btnDesserts.Size = New System.Drawing.Size(181, 68)
        Me.btnDesserts.TabIndex = 28
        Me.btnDesserts.Text = " Desserts"
        Me.btnDesserts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDesserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDesserts.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDrinks.FlatAppearance.BorderSize = 0
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDrinks.Image = Global.Vegatronix.My.Resources.Resources.drinkee
        Me.btnDrinks.Location = New System.Drawing.Point(38, 281)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(179, 68)
        Me.btnDrinks.TabIndex = 27
        Me.btnDrinks.Text = "  Drinks"
        Me.btnDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.Yellow
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(510, 368)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Administrators"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(0, 169)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(510, 193)
        Me.TabControl2.TabIndex = 66
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Yellow
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.btnUpdateAdmin)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.chkPassword)
        Me.TabPage4.Controls.Add(Me.btnDeleteAdmn)
        Me.TabPage4.Controls.Add(Me.txtConfirmNewPwd)
        Me.TabPage4.Controls.Add(Me.txtNewPassword)
        Me.TabPage4.Controls.Add(Me.txtOldPassword)
        Me.TabPage4.Controls.Add(Me.chkUsername)
        Me.TabPage4.Controls.Add(Me.txtNewUsername)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(502, 163)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = " My Account"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Yellow
        Me.Label22.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(234, 92)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 18)
        Me.Label22.TabIndex = 96
        Me.Label22.Text = "Confirm:"
        '
        'btnUpdateAdmin
        '
        Me.btnUpdateAdmin.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdateAdmin.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnUpdateAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateAdmin.FlatAppearance.BorderSize = 0
        Me.btnUpdateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAdmin.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAdmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateAdmin.Location = New System.Drawing.Point(345, 122)
        Me.btnUpdateAdmin.Name = "btnUpdateAdmin"
        Me.btnUpdateAdmin.Size = New System.Drawing.Size(134, 35)
        Me.btnUpdateAdmin.TabIndex = 84
        Me.btnUpdateAdmin.Text = "Update Details"
        Me.btnUpdateAdmin.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Yellow
        Me.Label21.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(179, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(131, 18)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "New Password:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Yellow
        Me.Label20.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(188, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 18)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "Old Password:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Yellow
        Me.Label19.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(218, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 18)
        Me.Label19.TabIndex = 93
        Me.Label19.Text = "Username:"
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.chkPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPassword.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPassword.Location = New System.Drawing.Point(16, 111)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(137, 19)
        Me.chkPassword.TabIndex = 92
        Me.chkPassword.Text = "Change Password"
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'btnDeleteAdmn
        '
        Me.btnDeleteAdmn.BackColor = System.Drawing.Color.Yellow
        Me.btnDeleteAdmn.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnDeleteAdmn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteAdmn.FlatAppearance.BorderSize = 0
        Me.btnDeleteAdmn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAdmn.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAdmn.Location = New System.Drawing.Point(10, 6)
        Me.btnDeleteAdmn.Name = "btnDeleteAdmn"
        Me.btnDeleteAdmn.Size = New System.Drawing.Size(135, 74)
        Me.btnDeleteAdmn.TabIndex = 86
        Me.btnDeleteAdmn.Text = "Delete My Account!"
        Me.btnDeleteAdmn.UseVisualStyleBackColor = False
        '
        'txtConfirmNewPwd
        '
        Me.txtConfirmNewPwd.BackColor = System.Drawing.Color.Yellow
        Me.txtConfirmNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmNewPwd.Enabled = False
        Me.txtConfirmNewPwd.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPwd.Location = New System.Drawing.Point(316, 93)
        Me.txtConfirmNewPwd.Name = "txtConfirmNewPwd"
        Me.txtConfirmNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmNewPwd.Size = New System.Drawing.Size(163, 23)
        Me.txtConfirmNewPwd.TabIndex = 91
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.Yellow
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.Enabled = False
        Me.txtNewPassword.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(316, 64)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(163, 23)
        Me.txtNewPassword.TabIndex = 90
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BackColor = System.Drawing.Color.Yellow
        Me.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldPassword.Enabled = False
        Me.txtOldPassword.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPassword.Location = New System.Drawing.Point(316, 35)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(163, 23)
        Me.txtOldPassword.TabIndex = 89
        '
        'chkUsername
        '
        Me.chkUsername.AutoSize = True
        Me.chkUsername.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.chkUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkUsername.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUsername.Location = New System.Drawing.Point(16, 86)
        Me.chkUsername.Name = "chkUsername"
        Me.chkUsername.Size = New System.Drawing.Size(142, 19)
        Me.chkUsername.TabIndex = 88
        Me.chkUsername.Text = "Change Username"
        Me.chkUsername.UseVisualStyleBackColor = True
        '
        'txtNewUsername
        '
        Me.txtNewUsername.BackColor = System.Drawing.Color.Yellow
        Me.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewUsername.Enabled = False
        Me.txtNewUsername.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.Location = New System.Drawing.Point(316, 6)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(163, 23)
        Me.txtNewUsername.TabIndex = 81
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Yellow
        Me.TabPage5.Controls.Add(Me.ChkShowPwd)
        Me.TabPage5.Controls.Add(Me.btnAddAdmin)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.txtConfirmPwd)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.txtFullname)
        Me.TabPage5.Controls.Add(Me.txtPassword)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.txtUsername)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(502, 163)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "New Account"
        '
        'ChkShowPwd
        '
        Me.ChkShowPwd.AutoSize = True
        Me.ChkShowPwd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow
        Me.ChkShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkShowPwd.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowPwd.Location = New System.Drawing.Point(168, 134)
        Me.ChkShowPwd.Name = "ChkShowPwd"
        Me.ChkShowPwd.Size = New System.Drawing.Size(122, 19)
        Me.ChkShowPwd.TabIndex = 87
        Me.ChkShowPwd.Text = "Show Password"
        Me.ChkShowPwd.UseVisualStyleBackColor = True
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.Color.Yellow
        Me.btnAddAdmin.BackgroundImage = Global.Vegatronix.My.Resources.Resources.huaha
        Me.btnAddAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddAdmin.FlatAppearance.BorderSize = 0
        Me.btnAddAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine
        Me.btnAddAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddAdmin.Location = New System.Drawing.Point(347, 30)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(96, 69)
        Me.btnAddAdmin.TabIndex = 85
        Me.btnAddAdmin.Text = "Add"
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(97, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Confirm:"
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.BackColor = System.Drawing.Color.Yellow
        Me.txtConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPwd.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPwd.Location = New System.Drawing.Point(178, 105)
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPwd.Size = New System.Drawing.Size(163, 23)
        Me.txtConfirmPwd.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(90, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 18)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Fullname:"
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.Color.Yellow
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullname.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(178, 11)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(163, 23)
        Me.txtFullname.TabIndex = 80
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Yellow
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(178, 76)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(163, 23)
        Me.txtPassword.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(83, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.AutoCompleteCustomSource.AddRange(New String() {"Stanley", "Charmza"})
        Me.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUsername.BackColor = System.Drawing.Color.Yellow
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(178, 47)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(163, 23)
        Me.txtUsername.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(81, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Username:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(83, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(303, 27)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Manage System Admins:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox2.BackgroundImage = Global.Vegatronix.My.Resources.Resources.key
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(182, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 102)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Yellow
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.LinkLabel3)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(510, 368)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(178, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Copyright © 2018"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 312)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(300, 18)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "&Email: stanleybrikkz464@gmail.com"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(93, 286)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(307, 18)
        Me.LinkLabel3.TabIndex = 7
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "www.linkedin.com/charedzerakeithp"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 18)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "&LinkedIn:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(80, 265)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(306, 18)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "+263 777 991 928/+263 778 989 449"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Contact:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "For Feedback:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(279, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "&Developed By: Charedzera Keith P"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(6, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(330, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Vegatronix Food-Outlet System Ver 1.0.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Screenshot__21_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(113, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 171)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblLoggenIn
        '
        Me.lblLoggenIn.AutoSize = True
        Me.lblLoggenIn.BackColor = System.Drawing.Color.Yellow
        Me.lblLoggenIn.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggenIn.ForeColor = System.Drawing.Color.Black
        Me.lblLoggenIn.Location = New System.Drawing.Point(150, 500)
        Me.lblLoggenIn.Name = "lblLoggenIn"
        Me.lblLoggenIn.Size = New System.Drawing.Size(15, 13)
        Me.lblLoggenIn.TabIndex = 31
        Me.lblLoggenIn.Text = "."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(415, 499)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(52, 15)
        Me.LinkLabel1.TabIndex = 32
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Logout"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Yellow
        Me.Label16.Font = New System.Drawing.Font("Vtks good luck for you", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(143, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(230, 55)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Admin's Desk"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Yellow
        Me.Label18.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(33, 500)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Logged In As:"
        '
        'FrmAdminsDesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.Vegatronix.My.Resources.Resources.Picture3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(542, 535)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblLoggenIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdminsDesk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin's Desk"
        Me.TransparencyKey = System.Drawing.Color.Green
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    ' Friend WithEvents AdminsTableAdapter As _FOS_Project_DatabaseDataSetTableAdapters.AdminsTableAdapter
    'Friend WithEvents TableAdapterManager As _FOS_Project_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnDesserts As System.Windows.Forms.Button
    Friend WithEvents btnDrinks As System.Windows.Forms.Button
    Friend WithEvents btnFlavours As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLoggenIn As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnFoodItems As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ChkShowPwd As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddAdmin As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAdmn As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAdmin As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtConfirmNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkUsername As System.Windows.Forms.CheckBox
    Friend WithEvents txtNewUsername As System.Windows.Forms.TextBox
    Friend WithEvents chkPassword As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
