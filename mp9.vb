Imports MySql.Data.MySqlClient

Public Class mp9

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()

            sql = "SELECT * FROM customers"
            'dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "customers")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "customers"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer = Val(InputBox("enter customer id to be deleted", "delete record"))
        Dim ans = MessageBox.Show("do you want to delete this record?", "record deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then

            Try
                conn.Open()
                sql = "DELETE from customers where customer_id = " & id

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = Val(ComboBox1.Text)
        Dim name = Cname.Text
        Dim address = Cadd.Text
        Dim phone = Cphone.Text


        Dim ans = MessageBox.Show("do you want to update this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE customers SET name = '" & name & "', address = '" & address & "', phone = '" & phone & "' "
                sql &= " where customer_id = '" & id & "' "

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


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim name = Cname.Text
        Dim address = Cadd.Text
        Dim phone = Cphone.Text


        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO customers (name,address, phone) " &
                                   "VALUES ( '" & name & "' , '" & address & "'  , '" & phone & "' )"


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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Open()

        sql = "SELECT name,address,phone FROM Customers WHERE customer_id = " & ComboBox1.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            Cname.Text = dbread("name")
            Cadd.Text = dbread("address")
            Cphone.Text = dbread("phone")
        End While
        conn.Close()
    End Sub

    Private Sub mp9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        conn.Open()
        sql = "SELECT customer_id from Customers"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            ComboBox1.Items.Add(dbread("customer_id"))
        End While
        conn.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Cphone_TextChanged(sender As Object, e As EventArgs) Handles Cphone.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Cadd_TextChanged(sender As Object, e As EventArgs) Handles Cadd.TextChanged

    End Sub

    Private Sub Cname_TextChanged(sender As Object, e As EventArgs) Handles Cname.TextChanged

    End Sub
End Class