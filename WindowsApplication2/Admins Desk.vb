Imports MySql.Data.MySqlClient
Public Class FrmAdminsDesk

    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=")
    Public Shared Sub OpenFileDialog()
        'DETERMINES THE OPENING OF THE FILE DIALOG TO ADD PICTURES IN THE RESPECTIVE FORMS
        FrmAdminsDesk.OpenFileDialog1.FileName = ""
        FrmAdminsDesk.OpenFileDialog1.Title = "Choose Image"
        FrmAdminsDesk.OpenFileDialog1.Filter = "ALL FILES(*.*)|*.*|JPEG(*.jpeg)|*jpeg|BITMAP(*.bmp)|*.bmp|JPG(*.jpg)|*.jpg|PNG(*.png)|*.png"
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        'ADD NEW USER ACCOUNT
        If txtFullname.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please Fill In All The Required Information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtConfirmPwd.Text = "" Then
            MessageBox.Show("Please Confirm Your Password Before Continuing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not txtPassword.Text = txtConfirmPwd.Text Then
            MessageBox.Show("Your Passwords Do Not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                conn.Open()
                Dim insert As String = "Insert Into `FOS_DB`.`Admins` values(@Fullname,@Username,@Password)"
                Dim cmd As New MySqlCommand(insert, conn)
                cmd.Parameters.AddWithValue("@Fullname", txtFullname.Text)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Added A New Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub btnDeleteAdmn_Click(sender As Object, e As EventArgs) Handles btnDeleteAdmn.Click
        'CODE TO REMOVE AN EXISTING USER ACCOUNT
        If Not MessageBox.Show("Are You Sure You Want To Delete Your Account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                conn.Open()
            Dim delete As String = "DELETE FROM `FOS_DB`.`Admins` Where `Fullname`='" & lblLoggenIn.Text & "'"
                Dim cmd As New MySqlCommand(delete, conn)
            ' cmd.Parameters.AddWithValue("@Fullname", txtFullname.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
            MessageBox.Show("Successfully Deleted Your Account!" & vbCrLf & "You Won't Be Able To Login Using This Account Next Time", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub chkUsername_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsername.CheckedChanged
        If chkUsername.Checked = True Then
            txtNewUsername.Enabled = True
        Else
            txtNewUsername.Enabled = False
        End If
    End Sub

    Private Sub ChkShowPwd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowPwd.CheckedChanged
        If ChkShowPwd.Checked = True Then
            txtPassword.PasswordChar = ""
            txtConfirmPwd.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
            txtConfirmPwd.PasswordChar = "*"
        End If
    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then
            txtNewPassword.Enabled = True
            txtOldPassword.Enabled = True
            txtConfirmNewPwd.Enabled = True
        Else
            txtNewPassword.Enabled = False
            txtOldPassword.Enabled = False
            txtConfirmNewPwd.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MessageBox.Show("Do You Want To Log Out To Ordering Menu?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmFoodOutlet.Show()
            Me.Close()
        Else
            If MessageBox.Show("Do You Want To Exit The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub
    Private Sub btnFoodItems_Click(sender As Object, e As EventArgs) Handles btnFoodItems.Click
        FrmFoodItems.Show()
        Me.Hide()
    End Sub
    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        FrmDesserts.Show()
        Me.Hide()
    End Sub
    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        FrmDrinks.Show()
        Me.Hide()
    End Sub
    Private Sub btnFlavours_Click(sender As Object, e As EventArgs) Handles btnFlavours.Click
        FrmFlavoursDB.Show()
        Me.Hide()
    End Sub

    Dim dr As MySqlDataReader
    Dim OldPassword As String
    Private Sub btnUpdateAdmin_Click(sender As Object, e As EventArgs) Handles btnUpdateAdmin.Click
        conn.Open()
        Dim cmd As New MySqlCommand
        cmd = New MySqlCommand("SELECT * FROM `FOS_DB`.`Admins` WHERE `Fullname`='" & lblLoggenIn.Text & "'", conn)

        Dim found As Boolean = False
        dr = cmd.ExecuteReader

        While dr.Read
            found = True
        End While

        If found = True Then
            OldPassword = dr("Password")
        End If
        dr.Close()
        If chkUsername.Checked = False Then 'Password is only changed if Username field is not filled
            If txtOldPassword.Text <> OldPassword Then
                MessageBox.Show("Old Password And Typed In Password Don't Match!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtConfirmNewPwd.Text <> txtNewPassword.Text Then
                MessageBox.Show("New Passwords Mismatch!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmd.CommandText = ("UPDATE `FOS_DB`.`Admins` SET Password=@Password WHERE Fullname=@Fullname")
                cmd.Parameters.AddWithValue("@Password", txtNewPassword.Text)
            End If
        ElseIf chkPassword.Checked = False Then
            cmd.CommandText = ("UPDATE `FOS_DB`.`Admins` SET Username=@Username WHERE Fullname=@Fullname")
            cmd.Parameters.AddWithValue("@Username", txtNewUsername.Text)
        Else
            If txtOldPassword.Text <> OldPassword Then
                MessageBox.Show("Old Password And Typed In Password Don't Match!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtConfirmNewPwd.Text <> txtNewPassword.Text Then
                MessageBox.Show("New Passwords Mismatch!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmd.CommandText = ("UPDATE `FOS_DB`.`Admins` SET Password=@Password WHERE Fullname=@Fullname")
                cmd.Parameters.AddWithValue("@Password", txtNewPassword.Text)
            Else
                cmd.CommandText = ("UPDATE `FOS_DB`.`Admins` SET Username=@Username,Password=@Password WHERE Fullname=@Fullname")
                cmd.Parameters.AddWithValue("@Username", txtNewUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtNewPassword.Text)
            End If
        End If
        cmd.Parameters.AddWithValue("@Fullname", lblLoggenIn.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Successfully Updated Your Details!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class