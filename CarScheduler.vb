Imports System.Net.Mime.MediaTypeNames

Public Class CarScheduler

    Private schedulingSystem As SchedulingSystem
    Public Sub New(system As SchedulingSystem)

        InitializeComponent()
        Me.schedulingSystem = system

        If system.scheduleData.Count > 0 Then
            SetScheduleData()
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles startPicker.ValueChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If startPicker.Value > endPicker.Value Then
            errorTime.Visible = True
        Else
            errorTime.Visible = False
            Schedule.Rows.Add(generateId(), Me.dayPicker.Value.ToString("yyyy-MM-dd"), Me.startPicker.Value.ToString("HH:mm tt"), Me.endPicker.Value.ToString("HH:mm tt"), False)
            'clearText()
            saveData()
        End If
    End Sub

    Private Function generateId() As Integer
        Dim data As List(Of SchedulingSystem.timeSlot) = schedulingSystem.scheduleData
        Dim largestId = 0
        For Each timeSlot As SchedulingSystem.timeSlot In data
            If timeSlot.id > largestId Then
                largestId = timeSlot.id
            End If
        Next

        Return largestId + 1
    End Function

    Private Sub clearText()
        Me.dayPicker.ResetText()
        Me.startPicker.ResetText()
        Me.endPicker.ResetText()
    End Sub
    Private Sub setText(day, startTime, endTime)
        Me.labelDate.Text = day
        Me.dayPicker.Value = Convert.ToDateTime(day)
        Me.startPicker.Value = Convert.ToDateTime(startTime)
        Me.endPicker.Value = Convert.ToDateTime(endTime)
    End Sub

    Private Sub Schedule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Schedule.CellContentClick
        Try
            If Schedule.Columns(e.ColumnIndex).Name = "Edit" Then 'edit the schedule
                Dim dr As DataGridViewRow = Schedule.SelectedRows(0)
                Me.setText(dr.Cells(1).Value.ToString(), dr.Cells(2).Value.ToString(), dr.Cells(3).Value.ToString())
            ElseIf Schedule.Columns(e.ColumnIndex).Name = "update" Then 'update the schedule
                Dim dr As DataGridViewRow = Schedule.SelectedRows(0)

                dr.Cells(1).Value = Me.dayPicker.Value.ToString("yyyy-MM-dd")
                dr.Cells(2).Value = Me.startPicker.Value.ToString("HH:mm tt")
                dr.Cells(3).Value = Me.endPicker.Value.ToString("HH:mm tt")
            ElseIf Schedule.Columns(e.ColumnIndex).Name = "delete" Then 'delete the schedule
                Schedule.Rows.RemoveAt(Schedule.SelectedRows(0).Index)
            End If
            saveData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub saveData()
        Dim Data As New List(Of SchedulingSystem.timeSlot)
        For Each r As DataGridViewRow In Schedule.Rows
            If r.Cells(0).Value IsNot Nothing Then
                Dim timeSlot As SchedulingSystem.timeSlot

                timeSlot.id = CInt(r.Cells(0).Value)
                timeSlot.day = r.Cells(1).Value.ToString()
                timeSlot.startTime = r.Cells(2).Value.ToString()
                timeSlot.endTime = r.Cells(3).Value.ToString()
                timeSlot.previousStart = r.Cells(2).Value.ToString()
                timeSlot.previousEnd = r.Cells(3).Value.ToString()
                timeSlot.booked = r.Cells(4).Value
                Data.Add(timeSlot)
            End If
            'System.Diagnostics.Debug.WriteLine(String.Join(" ", Data))
        Next
        schedulingSystem.scheduleData = Data

        'System.Diagnostics.Debug.WriteLine(String.Join(" ", Data))


    End Sub

    Private Sub SetScheduleData()
        Dim data As List(Of SchedulingSystem.timeSlot) = schedulingSystem.scheduleData
        For Each timeSlot As SchedulingSystem.timeSlot In data
            Schedule.Rows.Add(timeSlot.id, timeSlot.day, timeSlot.startTime, timeSlot.endTime, timeSlot.booked)
        Next
    End Sub

    Private Sub CarScheduler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errorTime.Visible = False
    End Sub
End Class