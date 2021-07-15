Imports MySql.Data.MySqlClient
Public Class FrmDrinks
    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Do You Want To Add Flavours?", "Drinks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            FrmFlavoursDB.Show()
            Me.Close()
        Else
            Me.Close()
            FrmAdminsDesk.Show()
        End If
    End Sub
    Private Sub btnAddDrink_Click(sender As Object, e As EventArgs) Handles btnAddDrink.Click
        If Not IsNumeric(txtDrinkPrice.Text) Then
            MsgBox("Price Cannot Contain Text Characters Or Cannot Be In Text Format!", MessageBoxIcon.Exclamation, "Input Error")
        ElseIf txtDrinkPrice.Text > 50 Then
            MsgBox("Price Is Too High To Be Charged For A Single Drink!", MessageBoxIcon.Exclamation, "Warning")
        ElseIf txtDrinkPrice.Text <= 0 Then
            MsgBox("Price Cannot Be Negative (less than 0) Or Cannot Be Equal To Zero!", MessageBoxIcon.Exclamation, "Warning")
        Else
            Try
                'CODE TO ADD NEW DRINK
                conn.Open()
                Dim cmd As New MySqlCommand("Insert Into `FOS_DB`.`Drinks` values(@DRINKID,@Drink,@Price,@Picture)", conn)
                cmd.Parameters.AddWithValue("@DRINKID", NumUpDwn.Value)
                cmd.Parameters.AddWithValue("@Drink", txtDrink.Text)
                cmd.Parameters.AddWithValue("@Price", txtDrinkPrice.Text)

                Dim pic As [Byte]()
                Dim mstream As New IO.MemoryStream
                Dim image As New Bitmap(picDrink.BackgroundImage)
                image.Save(mstream, Imaging.ImageFormat.Jpeg)
                pic = mstream.ToArray
                mstream.Close()
                cmd.Parameters.AddWithValue("@Picture", pic)
                cmd.ExecuteNonQuery()
                Call drinks()
                conn.Close()
                MessageBox.Show("Successfully Added Drink", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDrink.Clear()
                txtDrinkPrice.Clear()
                picDrink.BackgroundImage = Nothing
                NumUpDwn.Value = NumUpDwn.Value + 1
            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Error")
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnDeleteDrink_Click(sender As Object, e As EventArgs) Handles btnDeleteDrink.Click
        Try
            'CODE TO DELETE DRINK
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM `FOS_DB`.`Drinks` Where `DRINK_ID`='" & NumUpDwn.Value & "'", conn)
            cmd.ExecuteNonQuery()
            Call drinks()
            MessageBox.Show("Successfully Deleted Drink", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Error")
            conn.Close()
        End Try
    End Sub
    Public Sub drinks()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM `FOS_DB`.`Drinks`"
        Dim adapter As New MySqlDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = cmd
        adapter.Fill(dt)
        DrinksDataGridView.DataSource = dt
    End Sub
    Private Sub lnklblDrink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblDrink.LinkClicked
        Call FrmAdminsDesk.OpenFileDialog()
        If FrmAdminsDesk.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picDrink.BackgroundImage = Image.FromFile(FrmAdminsDesk.OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call drinks()
    End Sub

    Private Sub btnUpdateDrink_Click(sender As Object, e As EventArgs) Handles btnUpdateDrink.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Try
            'CODE TO UPDATE DRINKS
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `FOS_DB`.`Drinks` WHERE `Drink_ID`='" & NumUpDwn.Value & "'", conn)
            cmd.CommandText = ("UPDATE `FOS_DB`.`Drinks` SET Drink=@Drink,Price=@Price WHERE Drink_ID=@DrinkID")
            cmd.Parameters.AddWithValue("@Drink", txtDrink.Text)
            cmd.Parameters.AddWithValue("@Price", txtDrinkPrice.Text)
            cmd.Parameters.AddWithValue("@DrinkID", NumUpDwn.Value)
            cmd.ExecuteNonQuery()
            Call drinks()
            MessageBox.Show("Successfully Updated Drink!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub
End Class