Public Class CarBooking


    Public schedulingSystem As SchedulingSystem
    Public Sub New(system As SchedulingSystem)

        InitializeComponent()
        Me.schedulingSystem = system

        If system.scheduleData.Count > 0 Then
            SetScheduleData()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Available_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Available.CellContentClick
        Try
            If Available.Columns(e.ColumnIndex).Name = "Book" Then
                Dim dr As DataGridViewRow = Available.SelectedRows(0)

                Dim data As List(Of SchedulingSystem.timeSlot) = schedulingSystem.scheduleData

                For Each timeSlot As SchedulingSystem.timeSlot In data

                    If (CInt(dr.Cells(0).Value) = timeSlot.id) Then
                        If ((Convert.ToDateTime(timeSlot.startTime) <= Me.startTimeFilter.Value) And
                            (Convert.ToDateTime(timeSlot.endTime) >= Me.startTimeFilter.Value) And
                            (timeSlot.day = Me.dayFilter.Value.ToString("yyyy-MM-dd"))) Then

                            Me.timeslotError.Visible = False
                            Dim confirmationWindow = New ConfirmationWindow(Me, dr.Cells(0).Value, Me.dayFilter.Value, Me.startTimeFilter.Value, Me.endTimeFilter.Value)
                            confirmationWindow.Show()
                        Else
                            Me.timeslotError.Visible = True


                        End If

                        Exit For
                    End If
                Next




            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Booked_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Booked.CellContentClick
        Try
            If Booked.Columns(e.ColumnIndex).Name = "Cancel" Then
                Dim dr As DataGridViewRow = Booked.SelectedRows(0)
                schedulingSystem.cancelCar(dr.Cells(0).Value)
                SetScheduleData()


            ElseIf Booked.Columns(e.ColumnIndex).Name = "edit" Then
                Dim dr As DataGridViewRow = Booked.SelectedRows(0)
                Dim confirmationWindow = New ConfirmationWindow(Me, dr.Cells(0).Value, Me.dayFilter.Value, Me.startTimeFilter.Value, Me.endTimeFilter.Value)
                confirmationWindow.Show()
                SetScheduleData()

            End If
        Catch ex As Exception

        End Try
    End Sub



    Public Sub SetScheduleData()
        Available.Rows.Clear()
        Booked.Rows.Clear()
        Dim data As List(Of SchedulingSystem.timeSlot) = schedulingSystem.scheduleData
        For Each timeSlot As SchedulingSystem.timeSlot In data
            If timeSlot.booked = False Then
                Available.Rows.Add(timeSlot.id, timeSlot.day, timeSlot.startTime, timeSlot.endTime)
            End If
            If timeSlot.booked = True Then
                Booked.Rows.Add(timeSlot.id, timeSlot.day, timeSlot.startTime, timeSlot.endTime)
            End If
        Next
    End Sub
    Private Sub SetFilteredData(day As DateTime, startTime As DateTime, endTime As DateTime)
        Available.Rows.Clear()
        Booked.Rows.Clear()
        Dim data As List(Of SchedulingSystem.timeSlot) = schedulingSystem.scheduleData
        For Each timeSlot As SchedulingSystem.timeSlot In data
            If ((timeSlot.day = day.ToString("yyyy-MM-dd") Or filterByDay.Checked = False) And
                ((Convert.ToDateTime(timeSlot.startTime) <= startTimeFilter.Value Or filterByTime.Checked = False) And
                (Convert.ToDateTime(timeSlot.endTime) >= endTimeFilter.Value Or filterByTime.Checked = False))) Then
                If timeSlot.booked = False Then
                    Available.Rows.Add(timeSlot.id, timeSlot.day, timeSlot.startTime, timeSlot.endTime)
                End If
                If timeSlot.booked = True Then
                    Booked.Rows.Add(timeSlot.id, timeSlot.day, timeSlot.startTime, timeSlot.endTime)
                End If
            End If
        Next
    End Sub

    Private Sub CarBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub resetFilters()
        filterByDay.Checked = False
        filterByTime.Checked = False
        SetScheduleData()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        SetFilteredData(Me.dayFilter.Value, Me.startTimeFilter.Value, Me.endTimeFilter.Value)
    End Sub

    Private Sub ClearFilter_Click(sender As Object, e As EventArgs) Handles ClearFilter.Click
        resetFilters()
    End Sub
End Class