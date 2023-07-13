Public Class VoterHome
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
    End Sub

    Private Sub RegisterToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem2.Click
        Dim Registration As New Registration
        Registration.MdiParent = Me
        Registration.Show()
    End Sub

    Private Sub PrivacyPolicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrivacyPolicyToolStripMenuItem.Click
        Dim Agreement As New Agreement
        Agreement.MdiParent = Me
        Agreement.Show()
    End Sub

    Private Sub InstructionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InstructionToolStripMenuItem1.Click
        Dim Instruction As New Instruction
        Instruction.MdiParent = Me
        Instruction.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim VotersLogin As New VoterLogin
        VotersLogin.MdiParent = Me
        VotersLogin.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        TermsCondtn.Show()
        Me.Close()
    End Sub
End Class