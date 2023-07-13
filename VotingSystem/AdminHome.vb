Public Class AdminHome
    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
    End Sub

    Private Sub VOTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOTESToolStripMenuItem.Click
        Dim AdminVotesTbl As New AdminVotesTbl
        AdminVotesTbl.MdiParent = Me
        AdminVotesTbl.Show()
    End Sub

    Private Sub REGISTRATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRATIONToolStripMenuItem.Click
        Dim AdminRegTbl As New AdminRegTbl
        AdminRegTbl.MdiParent = Me
        AdminRegTbl.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        TermsCondtn.Show()
        Me.Hide()
    End Sub
End Class