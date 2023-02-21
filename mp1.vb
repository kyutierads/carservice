Imports MySql.Data.MySqlClient

Public Class mp1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim manufacturers = strmanufacturers.Text
        Dim location = strlocation.Text
        'Dim model = strmodel.Text
        'Dim cartype = strcartype.Text

        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO manufacturers(Company,Clocation)" &
                                   "VALUES ( '" & manufacturers & "' , '" & location & "' )"


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = Val(cmbID.Text)

        Dim manufacturers = strmanufacturers.Text
        Dim location = strlocation.Text

        Dim ans = MessageBox.Show("do you want to update this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE manufacturers SET Company = '" & manufacturers & "', Clocation = '" & location & "' "
                sql &= " where manufactures_id = '" & id & "' "

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged
        conn.Open()

        sql = "SELECT Company,Clocation FROM Manufacturers WHERE manufactures_id = " & cmbID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strmanufacturers.Text = dbread("Company")
            strlocation.Text = dbread("Clocation")

        End While
        conn.Close()

    End Sub

    Private Sub mp1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbID.Items.Clear()

        conn.Open()
        sql = "SELECT manufactures_id from Manufacturers"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbID.Items.Add(dbread("manufactures_id"))
        End While
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer = Val(InputBox("enter Manufacturers id to be deleted", "delete record"))
        Dim ans = MessageBox.Show("do you want to delete this record?", "record deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then

            Try
                conn.Open()
                sql = "DELETE from manufacturers where manufactures_id = " & id

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            conn.Open()

            sql = "SELECT * from manufacturers;"
            'dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "manufacturers")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "manufacturers"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()

    End Sub
End Class