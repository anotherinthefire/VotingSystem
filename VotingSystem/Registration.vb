Imports System.Data.SqlClient
Imports System.IO
Public Class Registration
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Images|*.jpg;*.png;*,gif;*.bmp"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.ImageLocation = TextBox10.Text
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'ERROR HANDLING
        Try 'LAST NAME
            If TextBox1.Text = "" Then
                Throw New ApplicationException("Enter your Last Name")
            End If
        Catch ex As Exception
            TextBox1.Text = ex.Message
        End Try

        Try 'FIRST NAME
            If TextBox2.Text = "" Then
                Throw New ApplicationException("Enter your First Name")
            End If
        Catch ex As Exception
            TextBox2.Text = ex.Message
        End Try

        Try 'ADDRESS
            If TextBox4.Text = "" Then
                Throw New ApplicationException("Enter your Address")
            End If
        Catch ex As Exception
            TextBox4.Text = ex.Message
        End Try

        Try 'USERNAME
            If TextBox8.Text = "" Then
                Throw New ApplicationException("Enter your Preferred Username")
            End If
        Catch ex As Exception
            TextBox8.Text = ex.Message
        End Try

        Try 'PASSWORD
            If TextBox9.Text = "" Then
                Throw New ApplicationException("Enter your Preferred Password")
            End If
        Catch ex As Exception
            TextBox9.Text = ex.Message
        End Try

        'DB
        Dim VOTERS_ID As Integer = TextBox11.Text
        Dim FIRSTNAME As String = TextBox2.Text
        Dim MIDDLENAME As String = TextBox3.Text
        Dim LASTNAME As String = TextBox1.Text
        Dim AGE As Integer = TextBox5.Text
        Dim BIRTHDAY As Date = DateTimePicker1.Text

        Dim GENDER As String = ""
        If RadioButton1.Checked Then
            GENDER = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            GENDER = RadioButton2.Text
        End If

        Dim CIVILSTATUS As String = ComboBox1.SelectedItem
        Dim NATIONALITY As String = TextBox7.Text
        Dim OCCUPATION As String = TextBox6.Text
        Dim ADDRESS As String = TextBox4.Text
        Dim USERNAME As String = TextBox8.Text
        Dim PASSWORD As String = TextBox9.Text
        Dim memstr As New MemoryStream
        PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)

        'INSERT
        Dim query As String = "INSERT INTO tbl_Registrations VALUES (@VOTERS_ID, @LASTNAME, @FIRSTNAME, @MIDDLENAME, @ADDRESS,@GENDER, @AGE,  @BIRTHDAY,  @CIVILSTATUS, @NATIONALITY, @OCCUPATION, @USERNAME, @PASSWORD, @Image)"
        Using con As SqlConnection = New SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue(“@VOTERS_ID”, VOTERS_ID)
                cmd.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                cmd.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                cmd.Parameters.AddWithValue("@LASTNAME", LASTNAME)
                cmd.Parameters.AddWithValue("@AGE", AGE)
                cmd.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY)
                cmd.Parameters.AddWithValue("@GENDER", GENDER)
                cmd.Parameters.AddWithValue("@CIVILSTATUS", CIVILSTATUS)
                cmd.Parameters.AddWithValue("@NATIONALITY", NATIONALITY)
                cmd.Parameters.AddWithValue("@OCCUPATION", OCCUPATION)
                cmd.Parameters.AddWithValue("@ADDRESS", ADDRESS)
                cmd.Parameters.AddWithValue("@USERNAME", USERNAME)
                cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD)
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = memstr.ToArray

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox11.Text = ""
                ComboBox1.SelectedItem = ""
                DateTimePicker1.Text = ""

                MessageBox.Show("Registered Successfully!")
            End Using
        End Using
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    'Delete Image
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = Nothing
    End Sub
End Class