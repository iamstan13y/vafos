Public Class Splashscreen
    'Variable Declarations
    Dim x As Integer = 1000 'Initial Value For Variable x Which Determines The Loading Of The Splashscreem
    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplshScrnTimer.Start() 'Starts The Timer For The Splashscreen To Load
        If My.Settings.Business_Name.Count = 0 Then 'Checks If The Product Has Been Registered Yet
            'Processes To Carry Out If The Condition Has Been Met:
            Label3.Text = "THIS PRODUCT IS NOT LICENSED"
            lblBusName.Visible = False
        Else
            'Processes If The Condition Is Otherwise:
            lblBusName.Text = My.Settings.Business_Name
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles SplshScrnTimer.Tick
        x -= 1 'The Value of x decreases As The Timer Ticks
        If x = 0 Then 'Checks if The value is now equal to 0
            'Processes To Carry Out If The Condition Has Been Met:
            If My.Settings.Business_Name.Count = 0 Then   'Checks If The Product Has Been Registered Yet
                Registration.Show() 'This Form Shows Up If The Product Isn't Registered
                Me.Close()
            Else
                If My.Settings.Admin_Exists = True Then
                    FrmLogin.btnBack.Visible = False
                End If
                FrmLogin.Show() 'This Form Shows Up If The Product Is Registered
                Me.Close()
               
            End If
        End If
    End Sub
End Class