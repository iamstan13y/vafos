Public Class Registration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        btnRegister.Visible = False
        Label2.Visible = True
        Label3.Visible = True
        txtBusName.Visible = True
        txtRegKey.Visible = True
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtBusName.Click
        txtBusName.Clear()
        'Changes The Font Of The Textbox:
        txtBusName.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtBusName.ForeColor = Color.Red 'Changes The Fore Colour Of The Textbox
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtRegKey.Click
        txtRegKey.Clear()
        txtRegKey.Font = New Font("Lucida Fax", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        txtRegKey.ForeColor = Color.Red
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtRegKey.TextChanged
        If txtRegKey.Text.Count = 15 Then 'Counts the number of characters in the textbox
            btnContinue.Visible = True
        Else
            btnContinue.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim BusName, Regkey As String
        BusName = txtBusName.Text
        Regkey = txtRegKey.Text
        If IsNumeric(BusName) Then
            MessageBox.Show("Business Name Cannot Be In Numeric Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Regkey = My.Settings.Registration_Key Then 'Validation Of Product Key
                My.Settings.Business_Name = BusName
                My.Settings.Save() 'Saves The Name Of the Newly Registered Business
                Settings.Show()
                Me.Close()
            Else
                'If A Wrong Product Key Has Been Input:
                MessageBox.Show("Please Provide A Valid Product Key!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'If Exit Button Is Clicked:
        If MessageBox.Show("Are You Sure You Want To Exit? You Can ALways Come Back And Register Later", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtBusName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusName.KeyPress
       
    End Sub

End Class