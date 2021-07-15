Imports MySql.Data.MySqlClient
Public Class FrmDesserts
    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=")
    Private Sub lnklblDrink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblDesserts.LinkClicked
        Call FrmAdminsDesk.OpenFileDialog()
        If FrmAdminsDesk.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picDesserts.BackgroundImage = Image.FromFile(FrmAdminsDesk.OpenFileDialog1.FileName)
        End If
    End Sub
    Public Sub Desserts()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM `FOS_DB`.`Desserts`"
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dset As New DataSet
        adapter.Fill(dset)
        DessertsDataGridView.DataSource = dset.Tables(0)
    End Sub
    Private Sub btnAddDessert_Click(sender As Object, e As EventArgs) Handles btnAddDessert.Click
        Try
            'ADDS NEW DRINK
            conn.Open()
            Dim cmd As New MySqlCommand("Insert Into `FOS_DB`.`Desserts` values(@ID,@Dessert,@Price,@Picture)", conn)
            cmd.Parameters.AddWithValue("@ID", NumUpDwn.Value)
            cmd.Parameters.AddWithValue("@Dessert", txtDessert.Text)
            cmd.Parameters.AddWithValue("@Price", txtDessertPrice.Text)

            Dim pic As [Byte]()
            Dim mstream As New IO.MemoryStream
            Dim image As New Bitmap(picDesserts.BackgroundImage)
            image.Save(mstream, Imaging.ImageFormat.Jpeg)
            pic = mstream.ToArray
            mstream.Close()
            cmd.Parameters.AddWithValue("@Picture", pic)
            cmd.ExecuteNonQuery()
            Call Desserts()
            conn.Close()
            MsgBox("Successfully Added Dessert", MessageBoxIcon.Information, "Success")
            txtDessert.Clear()
            txtDessertPrice.Clear()
            picDesserts.BackgroundImage = Nothing
            NumUpDwn.Value = NumUpDwn.Value + 1
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Error")
            conn.Close()
        End Try
    End Sub
    Private Sub btnDeleteDesserts_Click(sender As Object, e As EventArgs) Handles btnDeleteDesserts.Click
        Try
            'CODE TO DELETE DESSERT
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM `FOS_DB`.`Desserts` Where `Dessert_ID`='" & NumUpDwn.Value & "'", conn)
            cmd.ExecuteNonQuery()
            Call Desserts()
            MsgBox("Successfully Deleted Dessert", MessageBoxIcon.Information, "Success")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Error")
            conn.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Do You Want To Add Flavours?", "Desserts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            FrmFlavoursDB.Show()
            Me.Close()
        Else
            FrmAdminsDesk.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Desserts()
    End Sub

    Private Sub btnUpdateDesserts_Click(sender As Object, e As EventArgs) Handles btnUpdateDesserts.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Try
            'CODE TO UPDATE DESSERT
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `FOS_DB`.`Desserts` WHERE `Dessert_ID`='" & NumUpDwn.Value & "'", conn)
            cmd.CommandText = ("UPDATE `FOS_DB`.`Desserts` SET Dessert=@Dessert,Price=@Price WHERE Dessert_ID=@DessertID")
            cmd.Parameters.AddWithValue("@Dessert", txtDessert.Text)
            cmd.Parameters.AddWithValue("@Price", txtDessertPrice.Text)
            cmd.Parameters.AddWithValue("@DessertID", NumUpDwn.Value)
            cmd.ExecuteNonQuery()
            Call Desserts()
            MessageBox.Show("Successfully Updated Dessert!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub
End Class