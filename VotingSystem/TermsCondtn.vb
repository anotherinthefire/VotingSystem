Public Class TermsCondtn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            VoterHome.Show()
            Me.Hide()
        Else
            MessageBox.Show("Agree to the system terms and condition first before you continue.")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AdminLogin.Show()
        Me.Hide()
    End Sub

End Class
