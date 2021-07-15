Public Class Flavours
    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles FlavoursLstBox.ItemCheck
        Me.Close() 'closes the form if user selects an option
        Dim FoodItem As String = hdnFoodItem.Text
        Dim Flavour As String = FlavoursLstBox.SelectedItem.ToString()
        Dim Price As String = hdnPrice.Text

        If e.NewValue = CheckState.Checked Then
            '
            'ARRAYTO INSERT SELECTED ITEMS IN THE AVAILABLE ORDER LISTVIEW 
            '
            Dim std As String() = New String(3) {}
            Dim lvi As ListViewItem

            std(0) = FoodItem
            std(1) = Flavour
            std(2) = Price

            lvi = New ListViewItem(std)
            frmFoodOutlet.lstViewOrder.Items.Add(lvi)
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close() 'closes the form if user decides not to make an option
    End Sub
End Class