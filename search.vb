Imports MySql.Data.MySqlClient

Public Class search

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            sql = "SELECT name,modelname,cartype,servicename,itemname,servicefee,servicedate
                   FROM  Customers cu INNER JOIN Vehicles v ON (v.customer_id = cu.customer_id)
                   INNER JOIN Models mo ON(v.model_id = mo.model_id)
                    INNER JOIN Types t ON(mo.car_id = t.car_id)
                    INNER JOIN Services s ON(s.vehicle_id = v.vehicle_id)
                    INNER JOIN services_has_servicetypes shs ON(shs.service_id = s.service_id)
                    INNER JOIN servicetypes st ON (shs.type_id = st.type_id)
                    INNER JOIN services_has_parts shp ON(shp.service_id = s.service_id)
                    INNER JOIN Parts p ON (shp.item_id = p.item_id);"

            'dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "services")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "services"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (quiz1.Checked) Then
            Dim search As String
            search = "  search for a car model and list all the parts that were used to repair those car models."
            searching.Text = search
            Try
                conn.Open()

                sql = "SELECT cu.name, Modelname,cartype,itemname 
                       FROM Customers cu INNER JOIN Vehicles v ON (v.customer_id = cu.customer_id )
                       INNER JOIN Models mo ON(v.model_id = mo.model_id )
                       INNER JOIN Types t ON (mo.car_id = t.car_id)
                       INNER JOIN Services s ON (s.vehicle_id = v.vehicle_id)
                       INNER JOIN Services_has_parts shp ON (shp.service_id = s.service_id)
                       INNER JOIN Parts p ON (shp.item_id = p.item_id)
                       WHERE modelname LIKE  '%" & TextBox1.Text & "%';"
                'dbcomm = New MySqlCommand(sql, conn)
                DataAdapter1 = New MySqlDataAdapter(sql, conn)
                dset = New DataSet()
                DataAdapter1.Fill(dset, "Customers")
                DataGridView1.DataSource = dset
                DataGridView1.DataMember = "Customers"
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

            Catch exception As Exception
                MsgBox("Error in code. Error is :" & exception.Message)
            End Try

            conn.Close()
        End If
        Dim sirts As String

        If (quiz2.Checked) Then
            sirts = "search for a supplier and list all delivered part/accessories."
            searching.Text = sirts

            Try
                conn.Open()

                sql = "SELECT  supname,itemname, costprice,qty,supplydate
                       FROM Suppliers s INNER JOIN Supplies spl ON(spl.supplier_id = s.supplier_id)
                       INNER JOIN Parts p ON(spl.item_id = p.item_id)
                       WHERE supname LIKE '%" & TextBox1.Text & "%' ;"
                'dbcomm = New MySqlCommand(sql, conn)
                DataAdapter1 = New MySqlDataAdapter(sql, conn)
                dset = New DataSet()
                DataAdapter1.Fill(dset, "Suppliers, Part")
                DataGridView1.DataSource = dset
                DataGridView1.DataMember = "Suppliers, Part"
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

            Catch exception As Exception
                MsgBox("Error in code. Error is :" & exception.Message)
            End Try

            conn.Close()

        End If

        If (quiz3.Checked) Then
            Dim hanap As String
            hanap = "search for a mechanic and list all the cars he serviced."
            searching.Text = hanap


            Try
                conn.Open()

                sql = "SELECT mechname,modelname,cartype,servicedate
                       FROM Mechanics mec INNER JOIN Servicemechanics sm ON (sm.mechanics_id = mec.mechanics_id)
                       INNER JOIN Services s ON (sm.service_id = s.service_id)
                       INNER JOIN Vehicles v ON (s.vehicle_id = v.vehicle_id)
                       INNER JOIN Models mo ON(v.model_id = mo.model_id )
                       INNER JOIN Types t ON (mo.car_id = t.car_id)
                       WHERE mechname LIKE '%" & TextBox1.Text & "%';"

                DataAdapter1 = New MySqlDataAdapter(sql, conn)
                dset = New DataSet()
                DataAdapter1.Fill(dset, "Mechanics")
                DataGridView1.DataSource = dset
                DataGridView1.DataMember = "Mechanics"
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

            Catch exception As Exception
                MsgBox("Error in code. Error is :" & exception.Message)
            End Try

            conn.Close()

        End If
        Dim pangitaa As String
        If (quiz4.Checked) Then
            pangitaa = "search for a service and list all cars that went through it."
            searching.Text = pangitaa

            Try
                conn.Open()

                sql = "SELECT servicename, modelname,cartype,servicedate
                       FROM Servicetypes st INNER JOIN services_has_servicetypes shs ON (shs.type_id = st.type_id )
                       INNER JOIN Services s ON(shs.service_id = s.service_id)
                       INNER JOIN Vehicles v ON(s.vehicle_id = v.vehicle_id)
                       INNER JOIN Models mo ON(v.vehicle_id = mo.model_id)
                       INNER JOIN Types t ON(mo.car_id = t.car_id)
                       WHERE servicename LIKE '%" & TextBox1.Text & "%';"
                'dbcomm = New MySqlCommand(sql, conn)
                DataAdapter1 = New MySqlDataAdapter(sql, conn)
                dset = New DataSet()
                DataAdapter1.Fill(dset, "Servicetypes")
                DataGridView1.DataSource = dset
                DataGridView1.DataMember = "Servicetypes"
            Catch ex As MySqlException
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

            Catch exception As Exception
                MsgBox("Error in code. Error is :" & exception.Message)
            End Try

            conn.Close()



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim quiz5search As String
        quiz5search = " input a date range and list all cars that were serviced on those dates. "
        searching.Text = quiz5search
        sql = "Select servicename, modelname,cartype,servicedate
                       From Servicetypes st INNER Join services_has_servicetypes shs ON (shs.type_id = st.type_id )
                       INNER Join Services s ON(shs.service_id = s.service_id)
                       INNER Join Vehicles v ON(s.vehicle_id = v.vehicle_id)
                       INNER Join Models mo ON(v.vehicle_id = mo.model_id)
                       INNER Join Types t ON(mo.car_id = t.car_id)
               Where s.servicedate BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        dset = New DataSet()
        DataAdapter1.Fill(dset, "services")
        DataGridView1.DataSource = dset
        DataGridView1.DataMember = "services"

        conn.Close()
    End Sub


End Class