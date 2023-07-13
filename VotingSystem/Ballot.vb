Imports System.Data.SqlClient
Public Class Ballot
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Print
        TextBox1.Text = ""
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("==================VOTER=============================" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("VotersID: " + vbTab & lblVotersID.Text + vbTab + vbTab + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("=================VOTES==============================" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("President: " + vbTab & Label4.Text + vbNewLine)
        TextBox1.AppendText("Vice-President: " + vbTab & Label6.Text + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("Senators:" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText(Label8.Text + vbTab + vbTab + Label12.Text + vbNewLine)
        TextBox1.AppendText(Label9.Text + vbTab + vbTab + Label13.Text + vbNewLine)
        TextBox1.AppendText(Label10.Text + vbTab + vbTab + Label14.Text + vbNewLine)
        TextBox1.AppendText(Label11.Text + vbTab + vbTab + Label15.Text + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("====================================================" + vbNewLine)

        PrintPreviewDialog1.ShowDialog()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class