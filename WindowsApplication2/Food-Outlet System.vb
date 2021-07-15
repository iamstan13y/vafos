Imports MySql.Data.MySqlClient
Public Class frmFoodOutlet

    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=")
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        btnRmvSlctd.Visible = True
        DateTimer.Start() 'Starts the timer as the form loads
        lblBusName.Text = My.Settings.Business_Name 'The registered fast food name is displayed on the top panel
        Try
            Dim cmd As MySqlCommand
            Dim dr As MySqlDataReader
            Dim pic As [Byte]()
            Dim stream As IO.MemoryStream

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>FOOD ITEMS<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            'CODE TO RETRIEVE/DISPLAY VALUES STORED IN THE DATABASE USING THE RESPECTIVE COMMAND:  
            conn.Open()
            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 1", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblFood1.Text = dr("Food_Item")
                lblFoodPrice1.Text = dr("Price")
            End While
            dr.Close()
            'THE BINARY VALUE OF THE PICTURE IS CONVERTED BACK TO ITS ORIGINAL STATE AND DISPLAYED
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 1", conn)
            pic = DirectCast(,)
            stream = New IO.MemoryStream(pic)
            btnFood1.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 2", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblFood2.Text = dr("Food_Item")
                lblFoodPrice2.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 2", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnFood2.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 3", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblFood3.Text = dr("Food_Item")
                lblFoodPrice3.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 3", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnFood3.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 4", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblFood4.Text = dr("Food_Item")
                lblFoodPrice4.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 4", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnFood4.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 5", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblFood5.Text = dr("Food_Item")
                lblFoodPrice5.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 5", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnFood5.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 6", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblFood6.Text = dr("Food_Item")
                lblFoodPrice6.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Food_Items` WHERE `Item_ID`= 6", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnFood6.BackgroundImage = Image.FromStream(stream)
            '
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>DRINKS<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            '
            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Drinks` WHERE `Drink_ID`= 1", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDrink1.Text = dr("Drink")
                lblDrinkPrice1.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 1", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDrink1.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 2", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDrink2.Text = dr("Drink")
                lblDrinkPrice2.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 2", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDrink2.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 3", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDrink3.Text = dr("Drink")
                lblDrinkPrice3.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 3", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDrink3.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 4", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDrink4.Text = dr("Drink")
                lblDrinkPrice4.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 4", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDrink4.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 5", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDrink5.Text = dr("Drink")
                lblDrinkPrice5.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 5", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDrink5.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 6", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDrink6.Text = dr("Drink")
                lblDrinkPrice6.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Drinks` WHERE `DRINK_ID`= 6", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDrink6.BackgroundImage = Image.FromStream(stream)
            '
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>DESSERTS<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            '
            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 1", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDessert1.Text = dr("Dessert")
                lblDessertPrice1.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 1", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDessert1.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 2", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDessert2.Text = dr("Dessert")
                lblDessertPrice2.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 2", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDessert2.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 3", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDessert3.Text = dr("Dessert")
                lblDessertPrice3.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 3", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDessert3.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 4", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDessert4.Text = dr("Dessert")
                lblDessertPrice4.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 4", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDessert4.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 5", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDessert5.Text = dr("Dessert")
                lblDessertPrice5.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 5", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDessert5.BackgroundImage = Image.FromStream(stream)

            cmd = New MySqlCommand("SELECT*FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 6", conn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                lblDessert6.Text = dr("Dessert")
                lblDessertPrice6.Text = dr("Price")
            End While
            dr.Close()
            cmd = New MySqlCommand("SELECT Picture FROM `FOS_DB`.`Desserts` WHERE `DESSERT_ID`= 6", conn)
            pic = DirectCast(cmd.ExecuteScalar(), [Byte]())
            stream = New IO.MemoryStream(pic)
            btnDessert6.BackgroundImage = Image.FromStream(stream)
            conn.Close()
        Catch ex As Exception
            'ERROR THAT IS GENERATED IF ANY OF THE PROCESSES FAILS
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles DateTimer.Tick
        'DISPLAYS THE CURRENT DATE AND TIME IN THE SPECFIED FORMAT AND LABELS
        lblTime.Text = Date.Now.ToString("dddd, d MMMM, yyyy   HH:mm:ss")
        Receipt.txtDateTime.Text = lblTime.Text
    End Sub

    Private Sub bntFoodMenu_Click(sender As Object, e As EventArgs) Handles btnFoodMenu.Click
        'DISPLAYS THE FOOD MENU PANEL AND HIDES OTHER PANELS
        pnlFoodMenu.Visible = True
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlOrder.Visible = False
        pnlPayNow.Visible = False
        pointer.Location = New Point(0, 200) ' The pointer moves accordingly to the button selected
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlDrinks.Visible = True
        pnlFoodMenu.Visible = False
        pnlDesserts.Visible = False
        pnlOrder.Visible = False
        pnlPayNow.Visible = False
        pnlFoodMenu.Visible = False
        pointer.Location = New Point(0, 281)
    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        pnlDesserts.Visible = True
        pnlFoodMenu.Visible = False
        pnlDrinks.Visible = False
        pnlOrder.Visible = False
        pnlPayNow.Visible = False
        pointer.Location = New Point(0, 370)
    End Sub

    Private Sub btnMyOrder_Click(sender As Object, e As EventArgs) Handles btnMyOrder.Click
        pnlOrder.Visible = True
        pnlFoodMenu.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlPayNow.Visible = False
        pnlFoodMenu.Visible = False
        pointer.Location = New Point(0, 452)
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        pnlPayNow.Visible = True
        pnlFoodMenu.Visible = False
        pnlDrinks.Visible = False
        pnlDesserts.Visible = False
        pnlOrder.Visible = False
        pnlFoodMenu.Visible = False
        pointer.Location = New Point(0, 548)
    End Sub
    Private Sub btnFood1_Click(sender As Object, e As EventArgs) Handles btnFood1.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblFood1.Text
        Flavours.hdnPrice.Text = lblFoodPrice1.Text
        conn.Open()
        'DISPLAYS THE FORM WITH FLAVOURS OF THE ITEM SELECTED
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblFood1.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnFood2_Click(sender As Object, e As EventArgs) Handles btnFood2.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblFood2.Text
        Flavours.hdnPrice.Text = lblFoodPrice2.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblFood2.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnFood3_Click(sender As Object, e As EventArgs) Handles btnFood3.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblFood3.Text
        Flavours.hdnPrice.Text = lblFoodPrice3.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblFood3.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnFood4_Click(sender As Object, e As EventArgs) Handles btnFood4.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblFood4.Text
        Flavours.hdnPrice.Text = lblFoodPrice4.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblFood4.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnFood5_Click(sender As Object, e As EventArgs) Handles btnFood5.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblFood5.Text
        Flavours.hdnPrice.Text = lblFoodPrice5.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblFood5.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnFood6_Click(sender As Object, e As EventArgs) Handles btnFood6.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblFood6.Text
        Flavours.hdnPrice.Text = lblFoodPrice6.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblFood6.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnDrink1_Click(sender As Object, e As EventArgs) Handles btnDrink1.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDrink1.Text
        Flavours.hdnPrice.Text = lblDrinkPrice1.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDrink1.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnDrink2_Click(sender As Object, e As EventArgs) Handles btnDrink2.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDrink2.Text
        Flavours.hdnPrice.Text = lblDrinkPrice2.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDrink2.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnDrink3_Click(sender As Object, e As EventArgs) Handles btnDrink3.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDrink3.Text
        Flavours.hdnPrice.Text = lblDrinkPrice3.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDrink3.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnDrink4_Click(sender As Object, e As EventArgs) Handles btnDrink4.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDrink4.Text
        Flavours.hdnPrice.Text = lblDrinkPrice4.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDrink4.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnDrink5_Click(sender As Object, e As EventArgs) Handles btnDrink5.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDrink5.Text
        Flavours.hdnPrice.Text = lblDrinkPrice5.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDrink5.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnDrink6_Click(sender As Object, e As EventArgs) Handles btnDrink6.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDrink6.Text
        Flavours.hdnPrice.Text = lblDrinkPrice6.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDrink6.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnDessert1_Click(sender As Object, e As EventArgs) Handles btnDessert1.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDessert1.Text
        Flavours.hdnPrice.Text = lblDessertPrice1.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDessert1.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub
    Private Sub btnDessert2_Click(sender As Object, e As EventArgs) Handles btnDessert2.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDessert2.Text
        Flavours.hdnPrice.Text = lblDessertPrice2.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDessert2.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
        End While
        If found = True Then
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        Else
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnDessert3_Click(sender As Object, e As EventArgs) Handles btnDessert3.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDessert3.Text
        Flavours.hdnPrice.Text = lblDessertPrice3.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDessert3.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnDessert4_Click(sender As Object, e As EventArgs) Handles btnDessert4.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDessert4.Text
        Flavours.hdnPrice.Text = lblDessertPrice4.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDessert4.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnDessert5_Click(sender As Object, e As EventArgs) Handles btnDessert5.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDessert5.Text
        Flavours.hdnPrice.Text = lblDessertPrice5.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDessert5.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnDessert6_Click(sender As Object, e As EventArgs) Handles btnDessert6.Click
        Flavours.FlavoursLstBox.Items.Clear()
        Flavours.hdnFoodItem.Text = lblDessert6.Text
        Flavours.hdnPrice.Text = lblDessertPrice6.Text
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM `FOS_DB`.`Flavours` Where `Order_Item`='" & lblDessert6.Text & "'", conn)
        Dim found As Boolean = False
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            found = True
            Flavours.FlavoursLstBox.Items.Add(dr("Flavour"))
        End While
        If found = False Then
            Flavours.FlavoursLstBox.Items.Add("Ordinary")
        End If
        conn.Close()
        Flavours.ShowDialog()
    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        lstViewOrder.Items.Clear()
        Receipt.ReceiptListView.Items.Clear()
        lblAmount.Text = ("0.00")
        Receipt.lblAmntDue.Text = ("$0.00")
    End Sub

    Public Sub due()
        'ADDS THE TOTAL IN THE LISTVIEW'S SPECIFIED SUB INDEX
        Dim lvi As ListViewItem
        Dim total As Decimal
        For Each lvi In lstViewOrder.Items
            total = total + CDec(lvi.SubItems(2).Text)
            lblAmount.Text = CDec(total)
        Next
        Receipt.lblAmntDue.Text = "$" & lblAmount.Text
    End Sub

    Private Sub btnRmvSlctd_Click(sender As Object, e As EventArgs) Handles btnRmvSlctd.Click
        Dim lvi As ListViewItem
        lvi = lstViewOrder.SelectedItems(0)
        lvi.Remove()
    End Sub

    Private Sub lstViewOrder_VisibleChanged(sender As Object, e As EventArgs) Handles lstViewOrder.VisibleChanged
        Call due()
    End Sub

    Private Sub btnPayCash_Click(sender As Object, e As EventArgs) Handles btnPayCash.Click
        Amount.Show() 'Displays the amount input form
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'IF EXIT BUTTON IS CLICKED
        If MessageBox.Show("Are You Admin? You Can Continue To Admins' Desk", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            FrmLogin.Show() 'If user is admin
            FrmLogin.btnBack.Visible = False
        Else
            Application.Exit()
        End If
    End Sub

End Class