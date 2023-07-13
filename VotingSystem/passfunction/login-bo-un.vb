Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ballot.lblUsername.Text = TextBox1.Text
        Dim query As String = "SELECT * FROM tbl_Experiment Where USERNAME = @USERNAME and PASSWORD = @PASSWORD"
        Using con As SqlConnection = New SqlConnection("Data Source=R0L3S;Initial Catalog=Ultra;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()

                        cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = TextBox1.Text
                        cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = TextBox2.Text
                        da.Fill(dt)
                        If dt.Rows.Count() <= 0 Then
                            MessageBox.Show("Invalid Name or Section")
                        Else
                            MessageBox.Show("LogIn Successfully")
                            VotingForm.Show()
                            Ballot.lblUsername.Text = dt.Rows(0)(11).ToString() 'username sa ballot
                            Ballot.lblVotersID.Text = dt.Rows(0)(0).ToString() 'voters id
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub