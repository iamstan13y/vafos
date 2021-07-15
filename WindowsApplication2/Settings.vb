Imports MySql.Data.MySqlClient

Public Class Settings

    'GLOBAL VARIABLES
    Dim cntdwn As Integer = 600 'Variable which determines the creation of a new database as the timer ticks
    Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=") 'MySQL Connection to the MySQL host
    Dim cmd As MySqlCommand 'MySQL Command which will later be used in reference to the connnection 
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SettingsTimer.Start() 'The timer is started as the form loads
        lstboxConsole.Items.Add(TimeOfDay & " Creating New Database...") 'Notifies the user that a new database is being created 
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles SettingsTimer.Tick
        cntdwn -= 1 'The countdown starts as the the timer ticks
        If cntdwn = 500 Then 'Checks if the countdown value is equal to 500
            'OPERATIONS TO CARRY OUT IF THE CONDITION IS TRUE
            Try
                conn.Open() 'The connection is opened
                cmd = New MySqlCommand("Create Schema `FOS_DB`", conn) 'Command to create new database
                cmd.ExecuteNonQuery()
                'User is notified if the operation was a success
                lstboxConsole.Items.Add(TimeOfDay & " Successfully Created Database!")
                CheckBox1.Checked = True
            Catch ex As Exception
                SettingsTimer.Stop() 'stops the timer
                If ex.Message = "Can't create database 'fos_db'; database exists" Then  'in case a database with the same name exists already
                    'EXISTING DATABASE IS DELETED AND OPERATION RETRIES AGAIN
                    lstboxConsole.Items.Add(TimeOfDay & " Failed To Create Database!")
                    lstboxConsole.Items.Add(TimeOfDay & " A Database With The Same Name Exists!")
                    lstboxConsole.Items.Add(TimeOfDay & " Retrying...")
                    cmd = New MySqlCommand("Drop Schema `FOS_DB`", conn) 'Command to delete database
                    cmd.ExecuteNonQuery()
                    SettingsTimer2.Start()
                    conn.Close()
                ElseIf ex.Message = "Unable to connect to any of the specified MySQL hosts." Then 'in case the MySQL server isnt working or not available
                    lstboxConsole.Items.Add(TimeOfDay & " Connection To The MySQL Host Failed")
                    lstboxConsole.Items.Add(TimeOfDay & " Make Sure The Server Is On And Retry")
                    lblError.Visible = True
                    picLoading.Visible = False
                    btnRetry.Visible = True
                End If
            End Try
        ElseIf cntdwn = 450 Then
            lstboxConsole.Items.Add(TimeOfDay & " Creating New Tables...") 'Notifies the user that tables are being created
            'COMMANDS TO CREATE NEW TABLES
            cmd = New MySqlCommand("CREATE TABLE `FOS_DB`.`Admins` (`Fullname` LONGTEXT, `Username` VARCHAR(12), `Password` VARCHAR(15))", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("CREATE TABLE `FOS_DB`.`Food_Items` (`Item_ID` VARCHAR(1), `Food_Item` LONGTEXT, `Price` VARCHAR(6), `Picture` LONGBLOB)", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("CREATE TABLE `FOS_DB`.`Drinks` (`Drink_ID` VARCHAR(1), `Drink` LONGTEXT, `Price` VARCHAR(6), `Picture` LONGBLOB)", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("CREATE TABLE `FOS_DB`.`Desserts` (`Dessert_ID` VARCHAR(1), `Dessert` LONGTEXT, `Price` VARCHAR(6), `Picture` LONGBLOB)", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("CREATE TABLE `FOS_DB`.`Flavours` (`Order_Item` TEXT, `Flavour` VARCHAR(20))", conn)
            cmd.ExecuteNonQuery()
        ElseIf cntdwn = 350 Then
            lstboxConsole.Items.Add(TimeOfDay & " Successfully Created New Tables!") 'Displays message if all tables created successfully
            CheckBox2.Checked = True
        ElseIf cntdwn = 300 Then
            lstboxConsole.Items.Add(TimeOfDay & " Finalizing Your Settings...") 'Notification to user for final settings
            'Setting The Primary Keys In The Database Tables
            cmd = New MySqlCommand("ALTER TABLE `FOS_DB`.`Admins` ADD PRIMARY KEY(`Username`)", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("ALTER TABLE `FOS_DB`.`Food_Items` ADD PRIMARY KEY(`Item_ID`)", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("ALTER TABLE `FOS_DB`.`Drinks` ADD PRIMARY KEY(`Drink_ID`)", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("ALTER TABLE `FOS_DB`.`Desserts` ADD PRIMARY KEY(`Dessert_ID`)", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("ALTER TABLE `FOS_DB`.`Flavours` ADD PRIMARY KEY(`Flavour`)", conn)
            cmd.ExecuteNonQuery()
        ElseIf cntdwn = 100 Then
            lstboxConsole.Items.Add(TimeOfDay & " Everything Now Setup...") 'Notifies the user if all operations were successful
        ElseIf cntdwn = 95 Then
            lstboxConsole.Items.Add(TimeOfDay & " Go Ahead and Manage Your Database") 'User is now given the option to continue
            CheckBox3.Checked = True
            lblDone.Visible = True
            picLoading.Visible = False
            btnContinue.Visible = True
            SettingsTimer.Stop()
        End If
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        'IF USER CLICKS RETRY BUTTON
        SettingsTimer2.Start()
        lblError.Visible = False
        picLoading.Visible = True
        btnRetry.Visible = False
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'The form which shows up if user clicks the continue button
        FrmNewAccount.Show()
        Me.Close()
    End Sub

    Private Sub SettingsTimer2_Tick(sender As Object, e As EventArgs) Handles SettingsTimer2.Tick
        cntdwn += 10 'The value of countdown increases as timer ticks
        If cntdwn = 600 Then
            SettingsTimer2.Stop() 'stops the timer if the condition has been met
            SettingsTimer.Start() 'starts the timer
        End If
    End Sub
End Class