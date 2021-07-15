Imports MySql.Data.MySqlClient

Public Class FrmNewAccount
    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=")
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then 'Checks if checkbox has been checked
            'CLEARS PASSWORD CHARACTERS IN SELECTED TEXTBOXES
            txtPassword.PasswordChar = ""
            txtCnfmPwd.PasswordChar = ""
        Else
            'SETS THE PASSWORD CHARACTERS
            txtPassword.PasswordChar = "*"
            txtCnfmPwd.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtFullname_Click(sender As Object, e As EventArgs) Handles txtFullname.Click
        txtFullname.Clear() 'clears the text in the textbox
        'CHANGES THE FONTSTLYE, FONTSIZE AND COLOUR IN THE TEXTBOX
        txtFullname.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtFullname.ForeColor = Color.Red
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.Clear()
        txtPassword.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtPassword.ForeColor = Color.Red
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub txtCnfmPwd_Click(sender As Object, e As EventArgs) Handles txtCnfmPwd.Click
        txtCnfmPwd.Clear()
        txtCnfmPwd.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtCnfmPwd.ForeColor = Color.Red
        txtCnfmPwd.PasswordChar = "*"
        CheckBox1.Enabled = True
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Clear()
        txtUsername.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtUsername.ForeColor = Color.Red
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassword.Text <> txtCnfmPwd.Text Then 'if password and confirmed password aren't the same
            MsgBox("Your Passwords Do Not Match", MsgBoxStyle.Critical, "Failed") 'User is notified if condition is true
        Else
            Try
                'Commands to add new admin account
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO `FOS_DB`.`Admins` values(@Fullname,@Username,@Password)", conn)
                cmd.Parameters.AddWithValue("@Fullname", txtFullname.Text)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.ExecuteNonQuery()
                My.Settings.Admin_Exists = True
                My.Settings.Save()
                MsgBox("Successfully Created New Admin Account!", MsgBoxStyle.Information, "Success")
                conn.Close()
                MsgBox("Welcome " & txtFullname.Text & ", You Are The New Admin." & vbCrLf & "Please Make Sure That All Tables Are Filled Before Launching The Ordering Menu", MsgBoxStyle.Information, "Information")
                FrmLogin.btnBack.Visible = False
                FrmLogin.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error") 'error message that is generated if the process failed
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub txtCnfmPwd_TextChanged(sender As Object, e As EventArgs) Handles txtCnfmPwd.TextChanged
        If txtCnfmPwd.Text.Count = txtPassword.Text.Count Then 'Checks If number of characters in textboxes is equal
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub

    Private Sub txtFullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsControl(e.KeyChar) = True Or Char.IsSeparator(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Please Input A Name With Valid Characters!", MsgBoxStyle.Exclamation, "Wrong Input")
        End If
    End Sub

End Class