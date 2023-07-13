      Dim ae As String = "Make sure to fill out all the data needed"
        'ERROR HANDLING

        Try 'LAST NAME
            If TextBox1.Text = "" Then
                Label1.ForeColor = Color.Red
                Throw New ApplicationException(ae)

                'FIRST NAME
            ElseIf TextBox2.Text = "" Then
                Label2.ForeColor = Color.Red
                Throw New ApplicationException(ae)

                'ADDRESS
            ElseIf TextBox4.Text = "" Then
                Label4.ForeColor = Color.Red
                Throw New ApplicationException(ae)

                'USERNAME
            ElseIf TextBox8.Text = "" Then
                Label11.ForeColor = Color.Red
                Throw New ApplicationException(ae)

                'PASSWORD
            ElseIf TextBox9.Text = "" Then
                Label12.ForeColor = Color.Red
                Throw New ApplicationException(ae)

                'Civil Stat
            ElseIf ComboBox1.SelectedItem = "" Then
                Label8.BackColor = Color.Red
                Throw New ApplicationException(ae)
            Else