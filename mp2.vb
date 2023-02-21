Imports MySql.Data.MySqlClient
Public Class mp2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer = Val(InputBox("enter Model id to be deleted", "delete record"))
        Dim ans = MessageBox.Show("do you want to delete this record?", "record deleted", MessageBoxButtons.YesNoCancel)

        If ans = DialogResult.Yes Then

            Try
                conn.Open()
                sql = "DELETE from models where model_id = " & id

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
        Dim id As Integer = Val(cmbID.Text)

        Dim models = strmodelname.Text
        Dim myear = strmodelyear.Text

        Dim ans = MessageBox.Show("do you want to update this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "UPDATE Models SET modelname = '" & models & "', modelyear = '" & myear & "' "
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()

            sql = "SELECT * FROM models"
            'dbcomm = New MySqlCommand(sql, conn)
            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            dset = New DataSet()
            DataAdapter1.Fill(dset, "models")
            DataGridView1.DataSource = dset
            DataGridView1.DataMember = "models"
        Catch ex As MySqlException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        Catch exception As Exception
            MsgBox("Error in code. Error is :" & exception.Message)
        End Try

        conn.Close()
    End Sub
    Private Sub cmbID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged
        conn.Open()

        sql = "SELECT Modelname,modelyear FROM Models WHERE model_id = " & cmbID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strmodelname.Text = dbread("modelname")
            strmodelyear.Text = dbread("modelyear")

        End While
        conn.Close()
    End Sub

    Private Sub cmbMID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmanufID.SelectedIndexChanged

        conn.Open()

        sql = "SELECT Company FROM Manufacturers WHERE manufactures_id = " & cmbmanufID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strmanu.Text = dbread("Company")

        End While
        conn.Close()
    End Sub

    Private Sub mp2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbID.Items.Clear()

        conn.Open()
        sql = "SELECT model_id from Models"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbID.Items.Add(dbread("model_id"))
        End While
        conn.Close()

        cmbmanufID.Items.Clear()
        conn.Open()
        sql = "SELECT manufactures_id from Manufacturers"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbmanufID.Items.Add(dbread("manufactures_id"))
        End While
        conn.Close()

        cmbTYPEID.Items.Clear()
        conn.Open()
        sql = "SELECT car_id from Types"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            cmbTYPEID.Items.Add(dbread("car_id"))
        End While
        conn.Close()

    End Sub

    Private Sub cmbTYPEID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTYPEID.SelectedIndexChanged
        conn.Open()

        sql = "SELECT cartype FROM Types WHERE car_id = " & cmbTYPEID.Text

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader
        While dbread.Read
            strtype.Text = dbread("cartype")

        End While
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim models = strmodelname.Text
        Dim myear = strmodelyear.Text

        Dim ans = MessageBox.Show("do you want to save this record?", "save record", MessageBoxButtons.YesNoCancel)
        If ans = DialogResult.Yes Then
            Try
                conn.Open()
                sql = "INSERT INTO Models(manufactures_id,car_id,modelname,modelyear)" &
                                   "VALUES (" & cmbmanufID.Text & "," & cmbTYPEID.Text & ", '" & models & "' , '" & myear & "' )"


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



End Class