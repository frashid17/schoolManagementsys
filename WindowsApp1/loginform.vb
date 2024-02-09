Imports System.IO

Public Class loginform
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtLoginUsername.Text.Trim()
        Dim password As String = txtLoginPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the entered credentials match any saved credentials
        Dim filePath As String = "user_credentials.txt"
        Dim found As Boolean = False
        Using reader As New StreamReader(filePath)
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine()
                Dim parts() As String = line.Split(",")
                If parts.Length = 2 AndAlso parts(0) = username AndAlso parts(1) = password Then
                    found = True
                    Exit While
                End If
            End While
        End Using

        If found Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Clear input fields
        txtLoginUsername.Clear()
        txtLoginPassword.Clear()


    End Sub
End Class