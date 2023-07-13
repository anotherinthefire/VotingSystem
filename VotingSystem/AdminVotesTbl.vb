Imports System.Data.SqlClient
Public Class AdminVotesTbl
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        AdminHome.Show()
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
    'SEARCH VOTERS ID
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "SELECT * FROM dbo.tbl_Ballot WHERE VOTERS_ID='" & TextBox1.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            TextBox1.Text = dt.Rows(0)(0).ToString() 'VOTERS ID
                            ComboBox1.Text = dt.Rows(0)(1).ToString() 'PRESIDENT
                            ComboBox2.Text = dt.Rows(0)(2).ToString() 'VICE PRESIDENT
                            ComboBox3.Text = dt.Rows(0)(3).ToString() 'SENATOR1
                            ComboBox4.Text = dt.Rows(0)(4).ToString() 'SENATOR2
                            ComboBox5.Text = dt.Rows(0)(5).ToString() 'SENATOR3
                            ComboBox6.Text = dt.Rows(0)(6).ToString() 'SENATOR4
                            ComboBox7.Text = dt.Rows(0)(7).ToString() 'SENATOR5
                            ComboBox8.Text = dt.Rows(0)(8).ToString() 'SENATOR6
                            ComboBox9.Text = dt.Rows(0)(9).ToString() 'SENATOR7
                            ComboBox10.Text = dt.Rows(0)(10).ToString() 'SENATOR8
                            TextBox2.Text = dt.Rows(0)(11).ToString() 'REG ID
                        Else

                            TextBox1.Text = ""
                            ComboBox1.Text = ""
                            ComboBox2.Text = ""
                            ComboBox3.Text = ""
                            ComboBox4.Text = ""
                            ComboBox5.Text = ""
                            ComboBox6.Text = ""
                            ComboBox7.Text = ""
                            ComboBox8.Text = ""
                            ComboBox9.Text = ""
                            ComboBox10.Text = ""
                            TextBox2.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
    'DELETE
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Voters_ID As String = TextBox1.Text
        Dim query As String = "DELETE FROM tbl_Ballot WHERE VOTERS_ID = @VOTERS_ID"
        Using con As SqlConnection = New SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@VOTERS_ID", Voters_ID)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                ComboBox4.Text = ""
                ComboBox5.Text = ""
                ComboBox6.Text = ""
                ComboBox7.Text = ""
                ComboBox8.Text = ""
                ComboBox9.Text = ""
                ComboBox10.Text = ""
                TextBox2.Text = ""

                MessageBox.Show("Votes Deleted Succesfully!")
                BindData()
            End Using
        End Using
    End Sub
    'SEARCH REG ID
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "SELECT * FROM dbo.tbl_Ballot WHERE REG_ID='" & TextBox2.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=DANIELLA;Initial Catalog=VOTINGSYSTEMDB;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            TextBox1.Text = dt.Rows(0)(0).ToString() 'VOTERS ID
                            ComboBox1.Text = dt.Rows(0)(1).ToString() 'PRESIDENT
                            ComboBox2.Text = dt.Rows(0)(2).ToString() 'VICE PRESIDENT
                            ComboBox3.Text = dt.Rows(0)(3).ToString() 'SENATOR1
                            ComboBox4.Text = dt.Rows(0)(4).ToString() 'SENATOR2
                            ComboBox5.Text = dt.Rows(0)(5).ToString() 'SENATOR3
                            ComboBox6.Text = dt.Rows(0)(6).ToString() 'SENATOR4
                            ComboBox7.Text = dt.Rows(0)(7).ToString() 'SENATOR5
                            ComboBox8.Text = dt.Rows(0)(8).ToString() 'SENATOR6
                            ComboBox9.Text = dt.Rows(0)(9).ToString() 'SENATOR7
                            ComboBox10.Text = dt.Rows(0)(10).ToString() 'SENATOR8
                            TextBox2.Text = dt.Rows(0)(11).ToString() 'REG ID
                        Else

                            TextBox1.Text = ""
                            ComboBox1.Text = ""
                            ComboBox2.Text = ""
                            ComboBox3.Text = ""
                            ComboBox4.Text = ""
                            ComboBox5.Text = ""
                            ComboBox6.Text = ""
                            ComboBox7.Text = ""
                            ComboBox8.Text = ""
                            ComboBox9.Text = ""
                            ComboBox10.Text = ""
                            TextBox2.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub AdminVotesTbl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VOTINGSYSTEMDBDataSet.tbl_Ballot' table. You can move, or remove it, as needed.
        Me.Tbl_BallotTableAdapter.Fill(Me.VOTINGSYSTEMDBDataSet.tbl_Ballot)
    End Sub
End Class