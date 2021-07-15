Imports MySql.Data.MySqlClient
Public Class FrmFoodItems

    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=")
    Public Sub FoodDta() 'Sub procedure which is called after making an alteration to the specified
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Food_Items`", conn) 'code to specify the table to be selected
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dset As New DataSet
        adapter.Fill(dset)
        FoodItemsDataGridView.DataSource = dset.Tables(0) 'Displays the table data in a DataGridView
    End Sub

    Private Sub lnklblFood_LinkClicked() Handles lnklblFood.LinkClicked
        Call FrmAdminsDesk.OpenFileDialog() 'calls the OpenFileDialog sub procedure in the specified form 
        'PLACES THE SELECTED IMAGE IN THE PICTUREBOX:
        If FrmAdminsDesk.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            'The selected picture is loaded into the Picture Box
            picFood.BackgroundImage = Image.FromFile(FrmAdminsDesk.OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Form6_Load() Handles MyBase.Load
        Call FoodDta() 'Calls the sub procedure when the form loads 
    End Sub
    Private Sub btnDone_Click() Handles btnDone.Click
        If MessageBox.Show("Do You Want To Add Flavours?", "Food Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            FrmFlavoursDB.Show() 'The form is showed if user selects the option "YES"
            Me.Close()
        Else
            FrmAdminsDesk.Show() 'The user is taken back to this form if they disagree
            Me.Close()
        End If
    End Sub

    Private Sub btnUpdateFood_Click() Handles btnUpdateFood.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn 'Specifies the connectio to use for the commands

        If txtFoodItem.Text = "" And txtFoodPrice.Text = "" Then 'Checks if all fields are filled
            MsgBox("Please Select At Least One Field To Update!", MsgBoxStyle.Exclamation, "Failed")
        Else
            'CODE TO UPDATE FOOD ITEMS
            conn.Close()
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`='" & NumUpDwn.Value & "'", conn)
            If txtFoodItem.Text = "" Then 'Price is only updated if Food item field is not filled 
                cmd.CommandText = ("UPDATE `FOS_DB`.`Food_Items` SET Price=@Price WHERE Item_ID=@ItemID")
                cmd.Parameters.AddWithValue("@Price", txtFoodPrice.Text)
            ElseIf txtFoodPrice.Text = "" Then 'Food item is updated only if Price field is not filled
                cmd.CommandText = ("UPDATE `FOS_DB`.`Food_Items` SET Food_Item=@FoodItem WHERE Item_ID=@ItemID")
                cmd.Parameters.AddWithValue("@FoodItem", txtFoodItem.Text)
            Else 'Both price and food item are updated if all fields are filled
                cmd.CommandText = ("UPDATE `FOS_DB`.`Food_Items` SET Food_Item=@FoodItem,Price=@Price WHERE Item_ID=@ItemID")
                cmd.Parameters.AddWithValue("@FoodItem", txtFoodItem.Text)
                cmd.Parameters.AddWithValue("@Price", txtFoodPrice.Text)
            End If
            cmd.Parameters.AddWithValue("@ItemID", NumUpDwn.Value)
            cmd.ExecuteNonQuery()
            Call FoodDta() 'The sub procedure is called after updating order items
            MessageBox.Show("Successfully Updated Food Item!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeleteFood_Click() Handles btnDeleteFood.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
            'CODE TO DELETE FOOD ITEMS
            Dim dr As MySqlDataReader
            conn.Close()
            conn.Open()
            'Deletes the specified food item:
            cmd = New MySqlCommand("SELECT * FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`='" & NumUpDwn.Value & "'", conn)
            Dim found As Boolean = False
            dr = cmd.ExecuteReader
            While dr.Read()
            found = True 'The state of found is toggled to true if the item to be deleted has been found in database 
            End While
            dr.Close()
            If found = True Then 'Determines if the item to be deleted is found in the database
                cmd.CommandText = ("DELETE FROM `FOS_DB`.`Food_Items` Where `Item_ID`='" & NumUpDwn.Value & "'")
                cmd.ExecuteNonQuery()
                Call FoodDta() 'Sub procedure is called after deleting
                MsgBox("Successfully Deleted Food Item", MessageBoxIcon.Information, "Success")
            Else
                MsgBox("Item Not In The Database. Please Select A Valid ID And Try Again!", MsgBoxStyle.Exclamation, "Error")
            End If
    End Sub

    Private Sub btnAddFood_Click() Handles btnAddFood.Click
        If Not IsNumeric(txtFoodPrice.Text) Then
            MsgBox("Price Cannot Contain Text Characters Or Cannot Be In Text Format!", MessageBoxIcon.Exclamation, "Input Error")
        ElseIf txtFoodPrice.Text > 50 Then
            MsgBox("Price Is Too High To Be Charged For A Food Item!", MessageBoxIcon.Exclamation, "Warning")
        ElseIf txtFoodPrice.Text <= 0 Then
            MsgBox("Price Cannot Be Negative (less than 0) Or Cannot Be Equal To Zero!", MessageBoxIcon.Exclamation, "Warning")
        Else
            Try
                'CODE TO ADD FOOD ITEMS
                conn.Open() 'opens the connection to allow editions
                Dim cmd As New MySqlCommand("INSERT INTO `FOS_DB`.`Food_Items` values(@ItemID,@FoodItem,@Price,@Picture)", conn)
                'THE NEW VALUES ARE ADDED TO THE DATABASE AT SPECIFIED PARAMETERS IN THAT ORDER:
                cmd.Parameters.AddWithValue("@ItemID", NumUpDwn.Value)
                cmd.Parameters.AddWithValue("@FoodItem", txtFoodItem.Text)
                cmd.Parameters.AddWithValue("@Price", txtFoodPrice.Text)

                'THE PICTURE IS CONVERTED INTO BINARY AND ITS VALUE IS STORED IN THE DATABASE:
                Dim pic As [Byte]()
                Dim mstream As New IO.MemoryStream
                Dim image As New Bitmap(picFood.BackgroundImage)
                image.Save(mstream, Imaging.ImageFormat.Jpeg)
                pic = mstream.ToArray
                mstream.Close()
                cmd.Parameters.AddWithValue("@Picture", pic) 'the resulting binary value is finally added to the database
                cmd.ExecuteNonQuery()
                Call FoodDta()
                conn.Close() 'connection is closed after making operations
                MessageBox.Show("Successfully Added New Food Item!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'CLEARS THE TEXTBOXES AND PICTUREBOXES AFTER ADDING NEW RECORD
                txtFoodItem.Clear()
                txtFoodPrice.Clear()
                picFood.BackgroundImage = Nothing
                NumUpDwn.Value = NumUpDwn.Value + 1 'Increments the current value of the numeric updown 
            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Error") 'Shows the automatically generated error message
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub txtFoodItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFoodItem.KeyPress
        If Char.IsLetter(e.KeyChar) = True Or Char.IsControl(e.KeyChar) = True Or Char.IsSeparator(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Please Use Valid Characters For Your Food Item!", MsgBoxStyle.Exclamation, "Wrong Input")
        End If
    End Sub
End Class