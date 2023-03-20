Imports Microsoft.Win32

Public Class SchedulingSystem

    Public scheduleData As List(Of timeSlot)

    Public Structure timeSlot
        Dim day As String
        Dim startTime As String
        Dim endTime As String
        Dim id As Integer
        Dim booked As Boolean
        Dim previousStart As String
        Dim previousEnd As String
    End Structure

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        scheduleData = New List(Of timeSlot)

    End Sub
    Private Sub bookCar_Click(sender As Object, e As EventArgs) Handles bookACar.Click
        Dim carBooker As CarBooking = New CarBooking(Me)
        carBooker.Show()
    End Sub

    Private Sub setCarSchedule_Click(sender As Object, e As EventArgs) Handles setCarSchedule.Click
        Dim carScheduler As CarScheduler = New CarScheduler(Me)
        carScheduler.Show()
    End Sub

    Public Sub bookCar(id As Integer, day As DateTime, startTime As DateTime, endTime As DateTime)

        For x = 0 To scheduleData.Count - 1
            If scheduleData(x).id = id Then
                Dim ts As timeSlot

                ts.id = scheduleData(x).id
                ts.day = day.ToString("yyyy-MM-dd")
                ts.startTime = startTime.ToString("HH:mm tt")
                ts.endTime = endTime.ToString("HH:mm tt")
                ts.previousStart = scheduleData(x).previousStart
                ts.previousEnd = scheduleData(x).previousEnd
                ts.booked = True
                scheduleData(x) = ts
            End If
        Next

    End Sub

    Public Sub cancelCar(id As Integer)

        For x = 0 To scheduleData.Count - 1
            If scheduleData(x).id = id Then
                Dim ts As timeSlot

                ts.id = scheduleData(x).id
                ts.day = scheduleData(x).day
                ts.previousStart = scheduleData(x).previousStart
                ts.previousEnd = scheduleData(x).previousEnd
                ts.startTime = scheduleData(x).previousStart
                ts.endTime = scheduleData(x).previousEnd
                ts.booked = False

                scheduleData(x) = ts
            End If
        Next

    End Sub

    Private Sub SchedulingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
