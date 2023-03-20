Public Class AlertPrompter

    Public Shared Function OwnerCollisionAlert() As Alert
        Return New Alert(Alert.UserTypeOwner, Alert.DescriptionCollision, Alert.ActionPullOver)
    End Function

    Public Shared Function RiderCollisionAlert() As Alert
        Return New Alert(Alert.UserTypeRider, Alert.DescriptionCollision, Alert.ActionPullOver)
    End Function

    Public Shared Function OwnerIntrusionAlert() As Alert
        Return New Alert(Alert.UserTypeOwner, Alert.DescriptionCollision, Alert.ActionPullOver)

    End Function
    Public Shared Function RiderIntrusionAlert() As Alert
        Return New Alert(Alert.UserTypeRider, Alert.DescriptionCollision, Alert.ActionPullOver)

    End Function
    Public Shared Function TechProblemAlert() As Alert
        Return New Alert(Alert.UserTypeRider, Alert.DescriptionCollision, Alert.ActionPullOver)
    End Function

    ' The number of prompters that will eventually prompt the user with an alert. As soon as an
    ' AlertPrompter shows an alert, it is no longer considered active.
    Public Shared ActivePrompters As Integer = 0

    Private alert As Alert
    Private WithEvents timer As Timer

    Public Sub New(delaySeconds As Integer, alert As Alert)
        Me.alert = alert
        Me.timer = New Timer()
        Me.timer.Interval = delaySeconds * 1000 ' will be cancelled after first interval call
        Me.timer.Start()

        ActivePrompters += 1
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Me.alert.Show()
        Me.timer.Stop()

        ActivePrompters -= 1
    End Sub
End Class
