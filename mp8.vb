Imports MySql.Data.MySqlClient
Public Class mp8

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()

            sql = "SELECT * from Vehicles"

            'dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "vehicles")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "vehicles"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = Val(cmbID.Text)

        Dim ans = MessageBox.Show("do you want to update this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE vehicles SET  mileage = '" & strmileage.Text & "','" & strcolor.Text & "'','" & strplate.Text & "' "
                sql &= " where vehicle_id = '" & id & "' "

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("record updated")
                Else
                    MsgBox("record not updated")


                End If



            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try

        End If
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer = Val(InputBox("enter vehicles id to be deleted", "delete record"))
        Dim ans = MessageBox.Show("do you want to delete this record?", "record deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then

            Try
                conn.Open()
                sql = "DELETE from vehicles where vehicle_id = " & id

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery
                If (i > 0) Then
                    MsgBox("record deleted")
                Else
                    MsgBox("record not deleted")

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
                sql = "INSERT INTO vehicles (model_id,customer_id,mileage,carcolor,plate_number) " &
                "VALUES ( " & cmbModel.Text & " , " & cmbcustID.Text & ", '" & strmileage.Text & "', '" & strcolor.Text & "','" & strplate.Text & "' )"


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

    Private Sub mp8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        sql = "SELECT vehicle_id from Vehicles"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbID.Items.Add(dbread("vehicle_id"))
        End While
        conn.Close()

        conn.Open()
        sql = "SELECT model_id from Models"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbModel.Items.Add(dbread("model_id"))
        End While
        conn.Close()

        conn.Open()
        sql = "SELECT customer_id from Customers"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbcustID.Items.Add(dbread("customer_id"))
        End While
        conn.Close()
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        conn.Open()

        sql = "SELECT modelname FROM Models WHERE model_id = " & cmbModel.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strmodelname.Text = dbread("modelname")

        End While
        conn.Close()
    End Sub

    Private Sub cmbcustID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcustID.SelectedIndexChanged
        conn.Open()

        sql = "SELECT name FROM Customers WHERE customer_id = " & cmbcustID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strcname.Text = dbread("name")

        End While
        conn.Close()
    End Sub
End Class
