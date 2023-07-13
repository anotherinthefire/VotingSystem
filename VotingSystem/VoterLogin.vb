Imports System.Data.SqlClient
Public Class VoterLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ballot.lblUsername.Text = TextBox1.Text
        Dim query As String = "SELECT * from tbl_Registrations where USERNAME = @USERNAME and PASSWORD = @PASSWORD"
        Using con As SqlConnection = New SqlConnection("Data Source=Daniella;Initial Catalog=VOTINGSYSTEMDB;integrated security=true")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()

                        cmd.Parameters.AddWithValue("@USERNAME", SqlDbType.VarChar).Value = TextBox1.Text
                        cmd.Parameters.AddWithValue("@PASSWORD", SqlDbType.VarChar).Value = TextBox2.Text
                        da.Fill(dt)
                        If dt.Rows.Count() <= 0 Then
                            MessageBox.Show("Invalid Name or Section")
                        Else
                            MessageBox.Show("Login Successfully")
                            VotingForm.Show()
                            Ballot.lblVotersID.Text = dt.Rows(0)(0).ToString()
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TermsCondtn.Show()
        Me.Hide()
    End Sub
End Class