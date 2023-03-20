Public Class Alert

    Public Shared UserTypeOwner = "(OWNER)"
    Public Shared UserTypeRider = "(RIDER)"

    Public Shared DescriptionCollision = "There has been a collision"
    Public Shared DescriptionIntrusion = "There has been an attempted intrusion"
    Public Shared DescriptionTechProblem = "There has been a tech problem"

    Public Shared ActionPullOver = "Pull Over"
    Public Shared ActionReport = "Report"


    Private Action As String

    Public Sub New(userType As String, description As String, action As String)
        Me.Action = action

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.UserTypeLabel.Text = userType
        Me.DescriptionLabel.Text = description
        Me.ActionButton.Text = action
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click
        MsgBox(Action + " Successful!")
        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub

    Private Sub DescriptionLabel_Click(sender As Object, e As EventArgs) Handles DescriptionLabel.Click

    End Sub
End Class