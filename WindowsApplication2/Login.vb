Imports MySql.Data.MySqlClient
Public Class FrmLogin
    'GLOBAL VARIABLES
    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=") 'Connection to the server
    Dim found As Boolean = False
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim user As String = ""
    Dim trials As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'CHECKS IF TEXTBOXES WITH REQUIRED INFO ARE ALL FILLED
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtPassword.Text = "password" Or txtUsername.Text = "username" Then
            MessageBox.Show("Please Fill In All User Credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conn.Open()
                'COMPARES INPUT VALUES WITH VALUES STORED IN DATABASE
                cmd = New MySqlCommand("SELECT * FROM `FOS_DB`.`Admins` WHERE `Username`='" & txtUsername.Text & "' AND `Password`='" & txtPassword.Text & "'", conn)
                dr = cmd.ExecuteReader()
                'READS DATA FROM THE DATABASE USING THE SPECIFIED COMMAND
                While dr.Read()
                    found = True
                    user = dr("Fullname") 'returns the fullname of the logged in user if details exist
                End While

            If found = True Then
                frmFoodOutlet.Close()
                    FrmAdminsDesk.lblLoggenIn.Text = user 'The current logged in user's fullname is displayed 
                FrmAdminsDesk.Show()
                    Me.Close()
            Else
                'IF USER DETAILS ARE NOT FOUND
                    trials += 1 'count starts to increment as user inputs wrong details
                    If trials = 3 Then 'if wrong details have been input 3times
                        MessageBox.Show("You Have Entered An Incorrect Username Or Password 3 Times. System Is Now Exiting!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Application.Exit()
                    Else
                        'if user has input wrong details
                        MessageBox.Show("Wrong Username Or Password. Please Try Again", "Login Failed!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                        txtUsername.Clear()
                        txtPassword.Clear()
                    End If
                End If
                conn.Close()
            Catch ex As Exception
                'in case the MySQL server isnt working or not available
                MsgBox("Connection To The MySQL Host Failed." & vbCrLf & "Please Make Sure The Server Is Enabled And Retry!", MessageBoxIcon.Error, "Error")
            End Try
        End If
    End Sub
    Private Sub txtPassword_Click1(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.Clear()
        txtPassword.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtPassword.ForeColor = Color.Red
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Clear()
        txtUsername.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtUsername.ForeColor = Color.Red
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'IF USER DECIDES TO CREATE NEW ADMIN ACCOUNT IN CASE NON EXISTS
        If MessageBox.Show("Do You Want To Go Back And Create New Admin Account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim regKey As String
            regKey = InputBox("Enter Registration Key!", "Confirm Registration")
            If regKey = My.Settings.Registration_Key Then
                FrmNewAccount.Show()
                Me.Close()
            Else
                MsgBox("Wrong Registration Key! Try Again Later", MessageBoxIcon.Error, "Confirmation Failed")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'IF USER DECIDES TO EXIST
        If MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit() 'Exits the entire system
        End If
    End Sub

    Private Sub NotAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles NotAdmin.CheckedChanged
        'IF USER IS NOT ADMIN:
        If NotAdmin.Checked = True Then
            If MessageBox.Show("Do You Want To Proceed To Food Ordering Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                frmFoodOutlet.Show()
                Me.Close()
            Else
                NotAdmin.Checked = False
            End If
        End If
    End Sub
End Class