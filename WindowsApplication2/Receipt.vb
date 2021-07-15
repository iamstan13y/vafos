
Public Class Receipt

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Displays The Name Of The Registered Business On Top Of The Receipt
        lblBusName.Text = My.Settings.Business_Name
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'For Printing The Receipt Form
        btnPrint.Visible = False
        Me.Activate()
        PrintForm1.Form = Me
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.Print()
        Me.close
    End Sub
End Class