Public Class ConfirmationWindow

    Public carBooking As CarBooking
    Public details As String
    Public id As Integer
    Public day As DateTime
    Public startTime As DateTime
    Public endTime As DateTime
    Public Sub New(cb As CarBooking, id As Integer, day As DateTime, startTime As DateTime, endTime As DateTime)




        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.carBooking = cb
        Me.details = "Day: " + day.ToString("yyyy-MM-dd") & vbCrLf &
            "Start Time: " + startTime.ToString("HH:mm tt") & vbCrLf &
            "End Time: " + endTime.ToString("HH:mm tt")
        Me.id = id
        Me.day = day
        Me.startTime = startTime
        Me.endTime = endTime

        Me.bookingDetails.Text = Me.details

    End Sub
    Private Sub ConfirmationWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub acceptButton_Click(sender As Object, e As EventArgs) Handles acceptButton.Click
        Me.carBooking.schedulingSystem.bookCar(Me.id, Me.day, Me.startTime, Me.endTime)
        Me.carBooking.SetScheduleData()
        Me.Close()
    End Sub

    Private Sub denyButton_Click(sender As Object, e As EventArgs) Handles denyButton.Click
        Me.Close()
    End Sub
End Class