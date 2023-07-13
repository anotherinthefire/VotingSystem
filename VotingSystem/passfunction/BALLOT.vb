Imports System.Data.SqlClient
Public Class Ballot
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Print
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim font As New Font("Comic Sans MS", 50, FontStyle.Underline)
        e.Graphics.DrawString(Label4.Text, font, Brushes.DarkGreen, 150, 150)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Back
        Me.Close()
        VotingForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Complete
        Dim username As String = lblUsername.Text
        Dim VOTERS_ID As String = lblVotersID.Text
        Dim PRESIDENT As String = Label4.Text
        Dim VP As String = Label6.Text
        Dim SENATOR1 As String = Label8.Text
        Dim SENATOR2 As String = Label9.Text
        Dim SENATOR3 As String = Label10.Text
        Dim SENATOR4 As String = Label11.Text
        Dim SENATOR5 As String = Label12.Text
        Dim SENATOR6 As String = Label13.Text
        Dim SENATOR7 As String = Label14.Text
        Dim SENATOR8 As String = Label15.Text

        Dim query As String = "INSERT INTO tbl_Ballot VALUES (@VOTERS_ID, @PRESIDENT, @VICE_PRESIDENT, @SENATOR1, @SENATOR2, @SENATOR3, @SENATOR4, @SENATOR5, @SENATOR6, @SENATOR7, @SENATOR8)"
        Using con As SqlConnection = New SqlClient.SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@VOTERS_ID", VOTERS_ID)
                cmd.Parameters.AddWithValue("@PRESIDENT", PRESIDENT)
                cmd.Parameters.AddWithValue("@VICE_PRESIDENT", VP)
                cmd.Parameters.AddWithValue("@SENATOR1", SENATOR1)
                cmd.Parameters.AddWithValue("@SENATOR2", SENATOR2)
                cmd.Parameters.AddWithValue("@SENATOR3", SENATOR3)
                cmd.Parameters.AddWithValue("@SENATOR4", SENATOR4)
                cmd.Parameters.AddWithValue("@SENATOR5", SENATOR5)
                cmd.Parameters.AddWithValue("@SENATOR6", SENATOR6)
                cmd.Parameters.AddWithValue("@SENATOR7", SENATOR7)
                cmd.Parameters.AddWithValue("@SENATOR8", SENATOR8)

                lblVotersID.Text = ""
                Label4.Name = ""
                Label6.Text = ""
                Label8.Text = ""
                Label9.Text = ""
                Label10.Text = ""
                Label11.Text = ""
                Label12.Text = ""
                Label13.Text = ""
                Label14.Text = ""
                Label15.Text = ""
                con.Open()
                cmd.ExecuteNonQuery()

                MessageBox.Show("Votes Submitted!")
                con.Close()

            End Using
        End Using

        VotingForm.Close()
        Me.Close()
    End Sub
End Class