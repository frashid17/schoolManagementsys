Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).


    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs)
        Dim Img As Bitmap = Bitmap.FromFile("C:\\images\butterfly.png")
        Me.BackgroundImage = Img
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.TransparencyKey = Img.GetPixel(10, 10)
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
