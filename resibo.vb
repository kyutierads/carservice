Imports MySql.Data.MySqlClient
Public Class resibo
    Private Sub resibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim overall As Decimal = 0
        conn.Open()

        sql = "SELECT name,modelname,cartype,mechname,servicename,servicefee,itemname,sellprice,quantity,((sellprice * quantity) + servicefee ) AS ototal,servicedate
               FROM Customers cu INNER JOIN Vehicles v ON(v.customer_id = cu.customer_id)
               INNER JOIN models mo ON(v.model_id = mo.model_id)
               INNER JOIN Types t ON(mo.car_id = t.car_id)
               INNER JOIN Services s ON(s.vehicle_id = v.vehicle_id)
               INNER JOIN servicemechanics sm ON(sm.service_id = s.service_id)
               INNER JOIN mechanics m ON(sm.service_id = s.service_id)
               INNER JOIN services_has_servicetypes shs ON(shs.service_id = s.service_id)
               INNER JOIN servicetypes st ON(shs.type_id = st.type_id)
               INNER JOIN services_has_parts servp ON(servp.service_id = s.service_id)
               INNER JOIN Parts p ON(servp.item_id = p.item_id)
               WHERE s.service_id = (SELECT MAX(service_id)FROM services);"

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strcustomername.Text = dbread("name")
            strmodelname.Text = dbread("modelname")
            strcartype.Text = dbread("cartype")
            strdate.Text = dbread("servicedate")
            strmechname.Text = dbread("mechname")
            strservicetype.Text = dbread("servicename")
            strfee.Text = dbread("servicefee")
            stritemname.Text = dbread("itemname")
            strprice.Text = dbread("sellprice")
            strqty.Text = dbread("quantity")
            stroverall.Text = dbread("ototal")
            'overall = overall + dbread("ototal")

        End While
        'stroverall.Text = overall
        conn.Close()
    End Sub
End Class