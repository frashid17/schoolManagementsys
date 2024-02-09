Public Class signupform
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        If username = "" Or password = "" Or confirmPassword = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save username and password to a text file
        Dim filePath As String = "user_credentials.txt"
        Using writer As New IO.StreamWriter(filePath, True)
            writer.WriteLine(username & "," & password)
        End Using

        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear input fields
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        loginform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        dashboard.Show()

    End Sub
End Class
