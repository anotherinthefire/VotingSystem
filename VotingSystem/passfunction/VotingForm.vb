Public Class VotingForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'SubmitVote
        Dim er As String = "Don't choose same Senator"
        Dim emp As String = "Choose a total of 8 Senator"
        'same senator vote
        '1
        If ComboBox3.SelectedItem = ComboBox4.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox3.SelectedItem = ComboBox5.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox3.SelectedItem = ComboBox6.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox3.SelectedItem = ComboBox7.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox3.SelectedItem = ComboBox8.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox3.SelectedItem = ComboBox9.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox3.SelectedItem = ComboBox10.SelectedItem Then
            MessageBox.Show(er)
            '2
        ElseIf ComboBox4.SelectedItem = ComboBox3.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox4.SelectedItem = ComboBox5.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox4.SelectedItem = ComboBox6.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox4.SelectedItem = ComboBox7.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox4.SelectedItem = ComboBox8.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox4.SelectedItem = ComboBox9.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox4.SelectedItem = ComboBox10.SelectedItem Then
            MessageBox.Show(er)
            '3
        ElseIf ComboBox5.SelectedItem = ComboBox3.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox5.SelectedItem = ComboBox4.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox5.SelectedItem = ComboBox6.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox5.SelectedItem = ComboBox7.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox5.SelectedItem = ComboBox8.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox5.SelectedItem = ComboBox9.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox5.SelectedItem = ComboBox10.SelectedItem Then
            MessageBox.Show(er)
            '4
        ElseIf ComboBox6.SelectedItem = ComboBox3.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox6.SelectedItem = ComboBox5.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox6.SelectedItem = ComboBox4.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox6.SelectedItem = ComboBox7.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox6.SelectedItem = ComboBox8.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox6.SelectedItem = ComboBox9.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox6.SelectedItem = ComboBox10.SelectedItem Then
            MessageBox.Show(er)
            '5
        ElseIf ComboBox7.SelectedItem = ComboBox3.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox7.SelectedItem = ComboBox5.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox7.SelectedItem = ComboBox6.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox7.SelectedItem = ComboBox4.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox7.SelectedItem = ComboBox8.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox7.SelectedItem = ComboBox9.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox7.SelectedItem = ComboBox10.SelectedItem Then
            MessageBox.Show(er)
            '6
        ElseIf ComboBox8.SelectedItem = ComboBox3.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox8.SelectedItem = ComboBox5.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox8.SelectedItem = ComboBox6.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox8.SelectedItem = ComboBox7.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox8.SelectedItem = ComboBox4.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox8.SelectedItem = ComboBox9.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox8.SelectedItem = ComboBox10.SelectedItem Then
            MessageBox.Show(er)
            '7
        ElseIf ComboBox9.SelectedItem = ComboBox3.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox9.SelectedItem = ComboBox5.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox9.SelectedItem = ComboBox6.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox9.SelectedItem = ComboBox7.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox9.SelectedItem = ComboBox8.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox9.SelectedItem = ComboBox4.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox9.SelectedItem = ComboBox10.SelectedItem Then
            MessageBox.Show(er)
            '8
        ElseIf ComboBox10.SelectedItem = ComboBox3.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox10.SelectedItem = ComboBox5.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox10.SelectedItem = ComboBox6.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox10.SelectedItem = ComboBox7.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox10.SelectedItem = ComboBox8.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox10.SelectedItem = ComboBox9.SelectedItem Then
            MessageBox.Show(er)
        ElseIf ComboBox10.SelectedItem = ComboBox4.SelectedItem Then
            MessageBox.Show(er)

            'ifempty
        ElseIf ComboBox4.SelectedItem = "" Then
            MessageBox.Show(emp)
        ElseIf ComboBox4.SelectedItem = "" Then
            MessageBox.Show(emp)
        ElseIf ComboBox5.SelectedItem = "" Then
            MessageBox.Show(emp)
        ElseIf ComboBox6.SelectedItem = "" Then
            MessageBox.Show(emp)
        ElseIf ComboBox7.SelectedItem = "" Then
            MessageBox.Show(emp)
        ElseIf ComboBox8.SelectedItem = "" Then
            MessageBox.Show(emp)
        ElseIf ComboBox9.SelectedItem = "" Then
            MessageBox.Show(emp)
        ElseIf ComboBox10.SelectedItem = "" Then
            MessageBox.Show(emp)

        ElseIf ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Choose a President")
        ElseIf ComboBox2.SelectedItem = "" Then
            MessageBox.Show("Choose a Vice President")

        Else
            Ballot.Show()
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
            Me.Hide()

        End If
    End Sub
End Class