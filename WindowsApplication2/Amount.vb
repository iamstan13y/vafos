Public Class Amount

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "1" 'Displays the clicked number in the specified textbox
        Else
            'Displays the clicked number and the numbers clicked before
            txtAmount.Text = txtAmount.Text + "1"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "4"
        Else
            txtAmount.Text = txtAmount.Text + "4"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "3"
        Else
            txtAmount.Text = txtAmount.Text + "3"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "5"
        Else
            txtAmount.Text = txtAmount.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "6"
        Else
            txtAmount.Text = txtAmount.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "7"
        Else
            txtAmount.Text = txtAmount.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "8"
        Else
            txtAmount.Text = txtAmount.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "9"
        Else
            txtAmount.Text = txtAmount.Text + "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "0"
        Else
            txtAmount.Text = txtAmount.Text + "0"
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not (txtAmount.Text.Contains(".")) Then 'checks if the "." has not been clicked yet
            txtAmount.Text += "." 'displays the "." for the first and last time once clicked
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        txtAmount.Text = "0"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtAmount.Text = "0" Then
            txtAmount.Text = "2"
        Else
            txtAmount.Text = txtAmount.Text + "2"
        End If
    End Sub

    Public Function Change(paid As Decimal, charged As Decimal) 'function to calculate change issued to customer
        Change = paid - charged
    End Function

    Private Sub btnDone_Click() Handles btnDone.Click
        If txtAmount.Text = "" Then
            MsgBox("You Did Not Input Any Amount!", MessageBoxIcon.Error, "Error") 'notifies the user if they haven't input anything
        Else
            Dim amntpaid As Decimal = txtAmount.Text
            Dim amntcharged As Decimal = frmFoodOutlet.lblAmount.Text

            'CHANGE IS CALCULATED WITH REFERENCE TO THE PUBLIC FUNCTION WHICH CALCULATES CHANGE:
            If amntpaid >= amntcharged Then
                Me.Close()
                'The amounts issued, charged and change are displayed on the receipt:
                Receipt.lblAmountIssued.Text = "$" & amntpaid
                Receipt.lblChange.Text = "$" & Change(amntpaid, amntcharged)
                For Each lvi As ListViewItem In frmFoodOutlet.lstViewOrder.Items
                    Dim newLvi As ListViewItem = lvi.Clone
                    For Each Lvsi As ListViewItem.ListViewSubItem In lvi.SubItems
                        newLvi.SubItems.Add(New ListViewItem.ListViewSubItem(newLvi, Lvsi.Text))
                    Next
                    Receipt.ReceiptListView.Items.Add(newLvi)
                    newLvi.BackColor = Color.White
                    newLvi.ForeColor = Color.Black
                    newLvi.Font = New Font("Microsoft Sans Serif", 8.0!, FontStyle.Regular)
                Next
                Receipt.Show()
                'Vew order listview is cleared after an order has been made
                frmFoodOutlet.lstViewOrder.Clear()
                frmFoodOutlet.lblAmount.Text = "$0.00"
            Else
                'if user has input an amount which is less than required
                MsgBox("You Have Insufficient Funds!", MessageBoxIcon.Error, "Error")
            End If
        End If
    End Sub
End Class