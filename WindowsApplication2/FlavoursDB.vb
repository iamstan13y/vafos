Imports MySql.Data.MySqlClient
Public Class FrmFlavoursDB
    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=")
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
        FrmAdminsDesk.Show()
    End Sub
    Public Sub Flavours()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM `FOS_DB`.`Flavours`"
        Dim adapter As New MySqlDataAdapter
        Dim dt As New DataTable
        adapter.SelectCommand = cmd
        adapter.Fill(dt)
        FlavoursDataGridView.DataSource = dt
    End Sub
    Private Sub btnDeleteFlavour_Click(sender As Object, e As EventArgs) Handles btnDeleteFlavour.Click
        Try
            'CODE TO DELETE FLAVOUR
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM `FOS_DB`.`Flavours` Where Flavour='" & txtFlavour.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Call Flavours()
            MsgBox("Successfully Deleted Flavour", MessageBoxIcon.Information, "Success")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Error")
            conn.Close()
        End Try
    End Sub
    Private Sub btnAddFlavour_Click(sender As Object, e As EventArgs) Handles btnAddFlavour.Click
        Try
            'CODE TO ADD NEW FLAVOUR
            conn.Open()
            Dim cmd As New MySqlCommand("Insert Into `FOS_DB`.`Flavours` values(@FoodItem,@Flavour)", conn)
            cmd.Parameters.AddWithValue("@FoodItem", txtFoodItemFlvr.Text)
            cmd.Parameters.AddWithValue("@Flavour", txtFlavour.Text)
            cmd.ExecuteNonQuery()
            Call Flavours()
            conn.Close()
            MsgBox("Successfully Added Flavour", MessageBoxIcon.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Error")
            conn.Close()
        End Try
    End Sub
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Flavours() 'calls the sub function as the form loads
    End Sub
End Class