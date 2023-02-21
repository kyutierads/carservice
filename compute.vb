Imports MySql.Data.MySqlClient
Public Class compute
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iserv As Decimal


        Try
            conn.Open()
            sql = "SELECT servicefee
                    FROM services_has_servicetypes shs
                    INNER JOIN services s ON (shs.service_id = s.service_id)
                    INNER JOIN servicetypes st ON(shs.type_id = st.type_id)
                    WHERE shs.type_id = st.type_id AND 
                    servicedate BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "'AND
                    '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read
                iserv = iserv + dbread("servicefee")
            End While

            conn.Close()
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Catch except As Exception
            MsgBox(except.Message)
        End Try
        conn.Close()

        Dim sprice As Decimal
        Dim iparts As Decimal
        Try
            conn.Open()
            sql = " SELECT shp.item_id,sellprice,quantity
                    FROM Services_has_parts shp 
                    INNER JOIN services s ON(shp.service_id = s.service_id)
                    INNER JOIN parts p ON(shp.item_id = p.item_id)
                    WHERE s.service_id = shp.service_id AND 
                    servicedate BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "'AND
                    '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'"

            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read
                sprice = CDec(dbread("sellprice")) * CDec(dbread("quantity"))
                iparts = iparts + sprice

            End While

            conn.Close()
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Catch except As Exception
            MsgBox(except.Message)
        End Try
        conn.Close()
        strdaterangeincome.Text = (iparts + iparts).ToString("C2")

    End Sub

    Private Sub compute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim incomeservice As Decimal
        Dim sprice As Decimal
        Dim incomeparts As Decimal

        Try
            conn.Open()
            sql = "SELECT servicefee
                    FROM services_has_servicetypes shs
                    INNER JOIN services s ON (shs.service_id = s.service_id)
                    INNER JOIN servicetypes st ON(shs.type_id = st.type_id)
                    WHERE shs.type_id = st.type_id  "
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read
                incomeservice = incomeservice + dbread("servicefee")
            End While

            conn.Close()
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Catch kabet As Exception
            MsgBox(kabet.Message)
        End Try
        conn.Close()

        Try
            conn.Open()
            sql = " SELECT shp.item_id,sellprice,quantity
                    FROM Services_has_parts shp 
                    INNER JOIN services s ON(shp.service_id = s.service_id)
                    INNER JOIN parts p ON(shp.item_id = p.item_id)
                    WHERE s.service_id = shp.service_id;"
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read
                sprice = CDec(dbread("sellprice")) * CDec(dbread("quantity"))
                incomeparts = incomeparts + sprice

            End While

            conn.Close()
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Catch kabet As Exception
            MsgBox(kabet.Message)
        End Try
        conn.Close()
        strincomeshop.Text = (incomeparts + incomeservice).ToString("C2")
    End Sub
End Class