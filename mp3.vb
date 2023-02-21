Imports MySql.Data.MySqlClient
Public Class mp3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = Val(cmbID.Text)

        Dim models = cartypes.Text

        Dim ans = MessageBox.Show("do you want to update this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE types SET cartype = '" & models & "'"
                sql &= " where car_id = '" & id & "' "

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
        Dim id As Integer = Val(InputBox("enter customer id to be deleted", "delete record"))
        Dim ans = MessageBox.Show("do you want to delete this record?", "record deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then

            Try
                conn.Open()
                sql = "DELETE from types where car_id = " & id

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

            sql = "SELECT * FROM types"
            'dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "types")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "types"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim models = cartypes.Text
        'Dim myear = modelyear.Text

        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Types(cartype)" &
                                   "VALUES ( '" & models & "' )"


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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged
        conn.Open()

        sql = "SELECT cartype FROM Types WHERE car_id = " & cmbID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cartypes.Text = dbread("cartype")


        End While
        conn.Close()
    End Sub

    Private Sub mp3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbID.Items.Clear()

        conn.Open()
        sql = "SELECT car_id from Types"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbID.Items.Add(dbread("car_id"))
        End While
        conn.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cartypes_TextChanged(sender As Object, e As EventArgs) Handles cartypes.TextChanged

    End Sub
End Class