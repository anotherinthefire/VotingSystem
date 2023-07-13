Public Class VotingForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Submit Vote
        Ballot.Label4.Text = ComboBox1.SelectedItem
        Ballot.Label6.Text = ComboBox2.SelectedItem
        Ballot.Label8.Text = ComboBox3.SelectedItem
        Ballot.Label9.Text = ComboBox4.SelectedItem
        Ballot.Label10.Text = ComboBox5.SelectedItem
        Ballot.Label11.Text = ComboBox6.SelectedItem
        Ballot.Label12.Text = ComboBox7.SelectedItem
        Ballot.Label13.Text = ComboBox8.SelectedItem
        Ballot.Label14.Text = ComboBox9.SelectedItem
        Ballot.Label15.Text = ComboBox10.SelectedItem

        Ballot.PictureBox1.Image = Registration.PictureBox1.Image
        Ballot.Show()
        Me.Hide()
    End Sub
End Class