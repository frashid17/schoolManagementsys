Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


               ' Get the username and password from the input fields
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Validate if the fields are not empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save the username and password to a text file
        Using writer As StreamWriter = New StreamWriter("user_credentials.txt", True)
            writer.WriteLine(username & "," & password)
        End Using

        MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear input fields
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the username and password from the input fields
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Read the text file to check if the username and password match
        Dim found As Boolean = False
        Using reader As StreamReader = New StreamReader("user_credentials.txt")
            Dim line As String
            While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                Dim parts As String() = line.Split(","c)
                If parts.Length = 2 AndAlso parts(0) = username AndAlso parts(1) = password Then
                    found = True
                    Exit While
                End If
            End While
        End Using

        ' Display appropriate message based on login status
        If found Then
            MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Clear input fields
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    ' Helper function for inline assignment
    Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    End Sub
End Class
