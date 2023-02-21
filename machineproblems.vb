Imports FontAwesome.Sharp

Public Class machineproblems

    Private Sub addform(frm As Form)
        MPpanels.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        MPpanels.Controls.Add(frm)
        frm.Show()

    End Sub
    Private Sub change_menu(menu As String)
        Select Case menu
            Case "HOME"
                addform(homepage)
            Case "erd"
                addform(ERD)
            Case "MP1"
                addform(mp1)
            Case "MP2"
                addform(mp2)
            Case "MP3"
                addform(mp3)
            Case "MP4"
                addform(mp4)
            Case "MP5"
                addform(mp5)
            Case "MP6"
                addform(mp6)
            Case "MP7"
                addform(mp7)
            Case "MP8"
                addform(mp8)
            Case "MP9"
                addform(mp9)
            Case "Transac"
                addform(Transactions)
            Case "search"
                addform(search)
            Case "history"
                addform(customerhistory)
            Case "compute"
                addform(compute)
        End Select
    End Sub

    Private Sub MP9CUSTOMERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP9CUSTOMERSToolStripMenuItem.Click
        change_menu("MP9")
    End Sub
    Private Sub MP8OWNERCARSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP8OWNERCARSToolStripMenuItem.Click
        change_menu("MP8")
    End Sub
    Private Sub MP7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP7ToolStripMenuItem.Click
        change_menu("MP7")
    End Sub

    Private Sub MP6PARTSACCESSORIESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP6PARTSACCESSORIESToolStripMenuItem.Click
        change_menu("MP6")
    End Sub

    Private Sub MP5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP5ToolStripMenuItem.Click
        change_menu("MP5")
    End Sub

    Private Sub MP4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP4ToolStripMenuItem.Click
        change_menu("MP4")
    End Sub

    Private Sub machineproblems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("HOME")
    End Sub
    Private Sub MP3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP3ToolStripMenuItem.Click
        change_menu("MP3")
    End Sub

    Private Sub MP2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP2ToolStripMenuItem.Click
        change_menu("MP2")
    End Sub

    Private Sub MP1CUSTOMERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP1CUSTOMERSToolStripMenuItem.Click
        change_menu("MP1")
    End Sub

    Private Sub TRANSACTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSACTIONToolStripMenuItem.Click
        Transactions.Show()
    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHToolStripMenuItem.Click
        change_menu("search")
    End Sub

    Private Sub SEARCHFORCUSTOMERSHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHFORCUSTOMERSHISTORYToolStripMenuItem.Click
        change_menu("history")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        change_menu("HOME")
    End Sub

    Private Sub ERDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ERDToolStripMenuItem.Click
        change_menu("erd")
    End Sub

    Private Sub TOTALINCOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOTALINCOMEToolStripMenuItem.Click
        change_menu("compute")
    End Sub
End Class