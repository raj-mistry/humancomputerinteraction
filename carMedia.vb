
Public Class carMedia

    Public Sub New()


        InitializeComponent()

    End Sub

    Private Sub radioOn_Click(sender As Object, e As EventArgs) Handles radioOn.Click
        My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.BackgroundLoop)
        radioOn.Enabled = False
        radioOff.Enabled = True
    End Sub

    Private Sub radioOff_Click(sender As Object, e As EventArgs) Handles radioOff.Click
        My.Computer.Audio.Stop()
        radioOn.Enabled = True
        radioOff.Enabled = False

    End Sub

    Private Sub navOn_Click(sender As Object, e As EventArgs) Handles navOn.Click
        My.Computer.Audio.Play(My.Resources.navigation, AudioPlayMode.BackgroundLoop)
        navOn.Enabled = False
        navOff.Enabled = True
    End Sub

    Private Sub navOff_Click(sender As Object, e As EventArgs) Handles navOff.Click
        My.Computer.Audio.Stop()
        navOn.Enabled = True
        navOff.Enabled = False
    End Sub

    Private Sub speakerOn_Click(sender As Object, e As EventArgs) Handles speakerOn.Click
        speakerOn.Enabled = False
        speakerOff.Enabled = True
    End Sub

    Private Sub speakerOff_Click(sender As Object, e As EventArgs) Handles speakerOff.Click
        speakerOn.Enabled = True
        speakerOff.Enabled = False
    End Sub
End Class