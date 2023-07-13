Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class AdminRegTbl
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AdminHome.Show()
        Me.Hide()
    End Sub
    'SUB CLASS FOR DATA GRID VIEW
    Public Sub BindData()
        Dim query As String = "SELECT * FROM tbl_Ballot"
        Using con As SqlConnection = New SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)

                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
    'SEARCH
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "SELECT * FROM dbo.tbl_Registrations WHERE VOTERS_ID ='" & TextBox10.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            TextBox10.Text = dt.Rows(0)(0).ToString() 'VOTERS_ID
                            TextBox2.Text = dt.Rows(0)(1).ToString() 'FIRST NAME
                            TextBox3.Text = dt.Rows(0)(2).ToString() 'MIDDLE NAME
                            TextBox1.Text = dt.Rows(0)(3).ToString() 'LAST NAME
                            TextBox5.Text = dt.Rows(0)(4).ToString() 'AGE
                            'DateTimePicker1.Text = dt.Rows(0)(5).ToString() 'BIRTHDAY
                            ComboBox1.SelectedItem = dt.Rows(0)(6).ToString() 'GENDER
                            ComboBox2.SelectedItem = dt.Rows(0)(7).ToString() 'CIVILSTATUS
                            TextBox6.Text = dt.Rows(0)(8).ToString() 'NATIONALITY
                            TextBox7.Text = dt.Rows(0)(9).ToString() 'OCCUPATION
                            TextBox4.Text = dt.Rows(0)(10).ToString() 'ADDRESS
                            TextBox8.Text = dt.Rows(0)(11).ToString() 'USERNAME
                            TextBox9.Text = dt.Rows(0)(12).ToString() 'PASSWORD
                        Else
                            TextBox10.Text = ""
                            TextBox2.Text = ""
                            TextBox3.Text = ""
                            TextBox1.Text = ""
                            TextBox5.Text = ""
                            'DateTimePicker1.Text = ""
                            ComboBox1.SelectedItem = ""
                            ComboBox2.SelectedItem = ""
                            TextBox6.Text = ""
                            TextBox7.Text = ""
                            TextBox4.Text = ""
                            TextBox8.Text = ""
                            TextBox9.Text = ""
                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub AdminRegTbl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VOTINGSYSTEMDBDataSet1.tbl_Registrations' table. You can move, or remove it, as needed.
        Me.Tbl_RegistrationsTableAdapter.Fill(Me.VOTINGSYSTEMDBDataSet1.tbl_Registrations)

    End Sub
    'DELETE
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Voters_ID As String = TextBox1.Text
        Dim query As String = "DELETE FROM dbo.tbl_Ballot WHERE VOTERS_ID = @VOTERS_ID"
        Using con As SqlConnection = New SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@VOTERS_ID", Voters_ID)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                TextBox10.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox1.Text = ""
                TextBox5.Text = ""
                ComboBox1.Text = ""
                ComboBox2.SelectedItem = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox4.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""

                MessageBox.Show("Voter Deleted Successfully!")
                BindData()
            End Using
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Images|*.jpg;*.png;*,gif;*.bmp"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.ImageLocation = TextBox10.Text
        End If
    End Sub
    'UPDATE
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim VOTERS_ID As Integer = TextBox10.Text
        Dim FIRSTNAME As String = TextBox2.Text
        Dim MIDDLENAME As String = TextBox3.Text
        Dim LASTNAME As String = TextBox1.Text
        Dim AGE As String = TextBox5.Text
        Dim BIRTHDAY As Date = DateTimePicker1.Text
        Dim GENDER As String = ComboBox1.SelectedItem
        Dim CIVILSTATUS As String = ComboBox2.SelectedItem
        Dim NATIONALITY As String = TextBox6.Text
        Dim OCCUPATION As String = TextBox7.Text
        Dim ADDRESS As String = TextBox4.Text
        Dim USERNAME As String = TextBox8.Text
        Dim PASSWORD As String = TextBox9.Text
        'Dim memstr As New MemoryStream
        ' PictureBox1.Image.Save(memstr, PictureBox1.Image.RawFormat)

        'INSERT
        Dim query As String = "UPDATE tbl_Registrations SET LASTNAME = @LASTNAME, FIRSTNAME = @FIRSTNAME, MIDDLENAME = @MIDDLENAME, ADDRESS = @ADDRESS,GENDER = @GENDER, AGE = @AGE,  BIRTHDAY = @BIRTHDAY,  CIVILSTATUS = @CIVILSTATUS, NATIONALITY = @NATIONALITY, OCCUPATION = @OCCUPATION, USERNAME = @USERNAME, PASSWORD @PASSWORD WHERE VOTERS_ID = @VOTERS_ID"
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
                'cmd.Parameters.Add("@Image", SqlDbType.Image).Value = memstr.ToArray

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
                TextBox10.Text = ""
                ComboBox1.SelectedItem = ""
                DateTimePicker1.Text = ""

                MessageBox.Show("Updated Successfully!")
            End Using
        End Using
    End Sub
End Class