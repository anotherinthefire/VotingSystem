Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Print
        TextBox1.Text = ""
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("========VOTER=========================================" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("VotersID: " + vbTab & lblVotersID.Text + vbTab + vbTab + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("========VOTES=========================================" + vbNewLine)
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
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("======================================================" + vbNewLine)
        PrintPreviewDialog1.ShowDialog()
    End Sub

'print docu code
'note:sa ballot[design]pa right click printpreviewdialog1 tapos properties>behavior>document>printdocument1
 Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim font As New Font("Comic Sans MS", 50, FontStyle.Underline)
        e.Graphics.DrawString(Label4.Text, font, Brushes.DarkGreen, 150, 150)
    End Sub