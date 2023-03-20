Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserControl11_Load(sender As Object, e As EventArgs) Handles UserControl11.Load

    End Sub

    Private Sub carSettings_Click(sender As Object, e As EventArgs) Handles carSettings.Click
        Dim carFeature As New carFeatures()
        carFeature.Show()
    End Sub

    Private Sub Media_Click(sender As Object, e As EventArgs) Handles Media.Click
        Dim carMedia As New carMedia()
        carMedia.Show()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click

    End Sub
End Class
