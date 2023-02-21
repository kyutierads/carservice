Imports MySql.Data.MySqlClient

Public Class supplyparts
    Private Sub cmbsupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsupplier.SelectedIndexChanged
        conn.Open()

        sql = "SELECT supname,supaddress,supphone FROM Suppliers WHERE supplier_id = " & cmbsupplier.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strsupname.Text = dbread("supname")
            strsupadd.Text = dbread("supaddress")
            strsuphone.Text = dbread("supphone")

        End While
        conn.Close()
    End Sub
    Private Sub cmbID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged


        conn.Open()

        sql = "SELECT itemname,costprice,sellprice,stock FROM Parts
        WHERE item_id = " & cmbID.Text

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
    Private Sub supplyparts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbsupplier.Items.Clear()
        conn.Open()
        sql = "SELECT supplier_id from Suppliers"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbsupplier.Items.Add(dbread("supplier_id"))
        End While
        conn.Close()

        cmbID.Items.Clear()
        conn.Open()
        sql = "SELECT item_id from parts"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbID.Items.Add(dbread("item_id"))
        End While
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim itemname = textitemname.Text
        Dim itemprice = strcostprice.Text
        'Dim phone = strphone.Text


        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO  Supplies(supplier_id,item_id,qty,supplydate) 
                       VALUES (" & cmbsupplier.Text & ", " & cmbID.Text & ",
                       " & strquantity.Text & ",'" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "')"
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
            sql = "UPDATE parts SET stock = stock + " & strquantity.Text & "
                   WHERE item_id = " & cmbID.Text & ""
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()


            conn.Close()
            supplyparts_Load(sender, e)

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        textitemname.Clear()
        strcostprice.Clear()
        strsellprice.Clear()
        strstocks.Clear()
        strsupname.Clear()
        strsupadd.Clear()
        strsuphone.Clear()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()

            sql = "SELECT supname, itemname, costprice, sellprice, qty, supplydate 
                   FROM Suppliers s INNER JOIN Supplies spl ON(spl.supplier_id = s.supplier_id)
                    INNER JOIN Parts p ON(spl.item_id = p.item_id);"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "Suppliers, Parts")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "Suppliers, Parts"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Suppliers (supname,supaddress,supphone) " &
                                   "VALUES ( '" & strsupname.Text & "' ,'" & strsupadd.Text & "' , '" & strsuphone.Text & "')"


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
            conn.Close()
            supplyparts_Load(sender, e)

        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class