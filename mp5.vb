Imports MySql.Data.MySqlClient
Public Class mp5


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()

            sql = "SELECT * FROM servicetypes"
            'dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "servicetypes")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "servicetypes"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = Val(cmbID.Text)

        Dim servicename = strservename.Text

        Dim servicefee = strservefee.Text
        'Dim IDtem = itemID.Text
        'Dim IDmech = mechID.Text


        Dim ans = MessageBox.Show("do you want to update this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE servicetypes SET 
                servicename = '" & servicename & "', servicefee = '" & servicefee & "' "
                sql &= " where type_id = '" & id & "' "

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
                sql = "DELETE from servicetypes where type_id = " & id

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

        Dim servicename = strservename.Text

        Dim servicefee = strservefee.Text


        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO servicetypes (servicename,servicefee) " &
                                   "VALUES ( '" & servicename & "' , '" & servicefee & "' )"


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

        sql = "SELECT servicename,servicefee FROM Servicetypes WHERE type_id = " & cmbID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strservename.Text = dbread("servicename")
            strservefee.Text = dbread("servicefee")
        End While
        conn.Close()
    End Sub

    Private Sub mp5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbID.Items.Clear()

        conn.Open()
        sql = "SELECT type_id from Servicetypes"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbID.Items.Add(dbread("type_id"))
        End While
        conn.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub strservefee_TextChanged(sender As Object, e As EventArgs) Handles strservefee.TextChanged

    End Sub

    Private Sub strservename_TextChanged(sender As Object, e As EventArgs) Handles strservename.TextChanged

    End Sub
End Class