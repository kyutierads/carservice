Imports MySql.Data.MySqlClient
Public Class Transactions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Services (Vehicle_id,servicedate) " &
                "VALUES ( " & cmbID.Text & ",'" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "')"


                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("record saved")
                Else
                    MsgBox("record not saved")

                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)


            End Try
        End If
        conn.Close()
    End Sub

    Private Sub cmbID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged
        conn.Open()

        sql = "SELECT Customers.name,Models.modelname,Types.cartype,mileage,carcolor,plate_number 
        FROM Customers, Models, Types, Vehicles
        WHERE Vehicles.customer_id = Customers.customer_id AND 
        Vehicles.model_id = Models.model_id AND 
        Models.car_id = Types.car_id AND 
        vehicle_id = " & cmbID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strcname.Text = dbread("name")
            strmodelname.Text = dbread("modelname")
            strtype.Text = dbread("cartype")
            strmileage.Text = dbread("mileage")
            strcolor.Text = dbread("carcolor")
            strplate.Text = dbread("plate_number")
        End While
        conn.Close()
    End Sub
    Private Sub cmbitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbitemID.SelectedIndexChanged
        conn.Open()

        sql = "SELECT itemname,costprice,sellprice,stock FROM Parts WHERE item_id = " & cmbitemID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            textitemname.Text = dbread("itemname")
            strcostprice.Text = dbread("costprice")
            strsellprice.Text = dbread("sellprice")
            strstocks.Text = dbread("stock")
        End While
        conn.Close()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbservicetypes.SelectedIndexChanged
        conn.Open()

        sql = "SELECT servicename,servicefee FROM Servicetypes WHERE type_id = " & cmbservicetypes.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strservename.Text = dbread("servicename")
            strservefee.Text = dbread("servicefee")
        End While
        conn.Close()
    End Sub

    Private Sub cmbMechanics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMechanics.SelectedIndexChanged
        conn.Open()

        sql = "SELECT mechname,mechaddress,mechphone FROM Mechanics WHERE mechanics_id = " & cmbMechanics.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strname.Text = dbread("mechname")
            straddress.Text = dbread("mechaddress")
            strphone.Text = dbread("mechphone")

        End While
        conn.Close()
    End Sub
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbID.Items.Clear()
        conn.Open()
        sql = "SELECT vehicle_id from Vehicles"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbID.Items.Add(dbread("vehicle_id"))
        End While
        conn.Close()

        cmbitemID.Items.Clear()

        conn.Open()
        sql = "SELECT item_id from Parts"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbitemID.Items.Add(dbread("item_id"))
        End While
        conn.Close()

        cmbservicetypes.Items.Clear()

        conn.Open()
        sql = "SELECT type_id from Servicetypes"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbservicetypes.Items.Add(dbread("type_id"))
        End While
        conn.Close()

        cmbMechanics.Items.Clear()

        conn.Open()
        sql = "SELECT mechanics_id from Mechanics"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbMechanics.Items.Add(dbread("mechanics_id"))
        End While
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Services_has_parts(service_id,item_id,quantity) 
                   VALUES ((SELECT MAX(service_id) FROM services)," & cmbitemID.Text & ", " & strquantity.Text & ")"
                dbcomm = New MySqlCommand(sql, conn)
                Dim j As Integer = dbcomm.ExecuteNonQuery
                If (j > 0) Then
                    MsgBox("record saved")
                Else
                    MsgBox("record not saved")

                End If

                sql = "UPDATE Parts SET stock = " & strstocks.Text & " - " & strquantity.Text & " 
                        WHERE item_id = " & cmbitemID.Text & ""
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("record saved")
                Else
                    MsgBox("record not saved")

                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)


            End Try
        End If
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Services_has_servicetypes (service_id,type_id) 
                   VALUES ((SELECT MAX(service_id) FROM services)," & cmbservicetypes.Text & ")"

                dbcomm = New MySqlCommand(sql, conn)

                Dim j As Integer = dbcomm.ExecuteNonQuery
                If (j > 0) Then
                    MsgBox("record saved")
                Else
                    MsgBox("record not saved")

                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)


            End Try
        End If
        conn.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Servicemechanics (service_id,mechanics_id) 
                   VALUES ((SELECT MAX(service_id) FROM services)," & cmbMechanics.Text & ")"

                dbcomm = New MySqlCommand(sql, conn)

                Dim j As Integer = dbcomm.ExecuteNonQuery
                If (j > 0) Then
                    MsgBox("record saved")
                Else
                    MsgBox("record not saved")

                End If
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)


            End Try
        End If
        conn.Close()

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        supplyparts.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        resibo.Show()
    End Sub
End Class