Imports MySql.Data.MySqlClient
Public Class customerhistory
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles history.TextChanged
        Dim search As String
        search = "search for a customer and list the service history and transaction of all the cars he brought to the shop."
        Label3.Text = search
        Try
            conn.Open()

            sql = "SELECT name,modelname,cartype,mechname,servicename,itemname,servicefee,servicedate
                   FROM customers cu INNER JOIN Vehicles v ON(v.customer_id = cu.customer_id)
                    INNER JOIN Models mo ON (v.model_id = mo.model_id )
                    INNER JOIN Types t ON(mo.car_id = t.car_id)
                    INNER JOIN Services s ON (s.vehicle_id = v.vehicle_id)
                    INNER JOIN servicemechanics sm ON(sm.service_id = s.service_id)
                    INNER JOIN mechanics m ON (sm.mechanics_id = m.mechanics_id)
                    INNER JOIN services_has_servicetypes shs ON (shs.service_id = s.service_id)
                    INNER JOIN Servicetypes st ON (shs.type_id = st.type_id)
                    INNER JOIN services_has_parts shp ON (shp.service_id = s.service_id)
                    INNER JOIN Parts p ON (shp.item_id = p.item_id)
                    WHERE name LIKE '%" & history.Text & "%'

                   "
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
    End Sub
End Class