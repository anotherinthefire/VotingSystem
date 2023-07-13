Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem2.Click
        Registration.Show()
    End Sub

    Private Sub PrivacyPolicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrivacyPolicyToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        LogIn.Show()
    End Sub
End Class