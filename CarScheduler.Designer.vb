<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarScheduler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.startPicker = New System.Windows.Forms.DateTimePicker()
        Me.endPicker = New System.Windows.Forms.DateTimePicker()
        Me.dayPicker = New System.Windows.Forms.DateTimePicker()
        Me.Schedule = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Booked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.update = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.labelStart = New System.Windows.Forms.Label()
        Me.labelEnd = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.labelSchedule = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.errorTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'startPicker
        '
        Me.startPicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.startPicker.Location = New System.Drawing.Point(49, 154)
        Me.startPicker.Margin = New System.Windows.Forms.Padding(2)
        Me.startPicker.Name = "startPicker"
        Me.startPicker.Size = New System.Drawing.Size(311, 23)
        Me.startPicker.TabIndex = 0
        Me.startPicker.Value = New Date(2022, 11, 6, 0, 0, 0, 0)
        '
        'endPicker
        '
        Me.endPicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.endPicker.Location = New System.Drawing.Point(377, 155)
        Me.endPicker.Margin = New System.Windows.Forms.Padding(2)
        Me.endPicker.Name = "endPicker"
        Me.endPicker.Size = New System.Drawing.Size(351, 23)
        Me.endPicker.TabIndex = 1
        '
        'dayPicker
        '
        Me.dayPicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.dayPicker.Location = New System.Drawing.Point(51, 96)
        Me.dayPicker.Margin = New System.Windows.Forms.Padding(2)
        Me.dayPicker.Name = "dayPicker"
        Me.dayPicker.Size = New System.Drawing.Size(678, 23)
        Me.dayPicker.TabIndex = 2
        '
        'Schedule
        '
        Me.Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Schedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.DataGridViewTextBoxColumn1, Me.startTime, Me.endTime, Me.Booked, Me.Edit, Me.update, Me.delete})
        Me.Schedule.Location = New System.Drawing.Point(49, 235)
        Me.Schedule.Margin = New System.Windows.Forms.Padding(2)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.RowHeadersWidth = 62
        Me.Schedule.RowTemplate.Height = 33
        Me.Schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Schedule.Size = New System.Drawing.Size(1311, 209)
        Me.Schedule.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 2
        Me.id.Name = "id"
        Me.id.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'startTime
        '
        Me.startTime.HeaderText = "Start Time"
        Me.startTime.MinimumWidth = 8
        Me.startTime.Name = "startTime"
        Me.startTime.Width = 150
        '
        'endTime
        '
        Me.endTime.HeaderText = "End Time"
        Me.endTime.MinimumWidth = 8
        Me.endTime.Name = "endTime"
        Me.endTime.Width = 150
        '
        'Booked
        '
        Me.Booked.HeaderText = "Booked"
        Me.Booked.Name = "Booked"
        Me.Booked.ReadOnly = True
        Me.Booked.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Booked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.MinimumWidth = 8
        Me.Edit.Name = "Edit"
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        Me.Edit.Width = 150
        '
        'update
        '
        Me.update.HeaderText = "Update"
        Me.update.MinimumWidth = 8
        Me.update.Name = "update"
        Me.update.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.update.Text = "Update"
        Me.update.UseColumnTextForButtonValue = True
        Me.update.Width = 150
        '
        'delete
        '
        Me.delete.HeaderText = "Delete"
        Me.delete.MinimumWidth = 8
        Me.delete.Name = "delete"
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.delete.Text = "Delete"
        Me.delete.UseColumnTextForButtonValue = True
        Me.delete.Width = 150
        '
        'labelStart
        '
        Me.labelStart.AutoSize = True
        Me.labelStart.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelStart.Location = New System.Drawing.Point(51, 134)
        Me.labelStart.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelStart.Name = "labelStart"
        Me.labelStart.Size = New System.Drawing.Size(50, 19)
        Me.labelStart.TabIndex = 4
        Me.labelStart.Text = "Start"
        '
        'labelEnd
        '
        Me.labelEnd.AutoSize = True
        Me.labelEnd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelEnd.Location = New System.Drawing.Point(387, 134)
        Me.labelEnd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelEnd.Name = "labelEnd"
        Me.labelEnd.Size = New System.Drawing.Size(39, 19)
        Me.labelEnd.TabIndex = 5
        Me.labelEnd.Text = "End"
        '
        'labelDate
        '
        Me.labelDate.AutoSize = True
        Me.labelDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDate.Location = New System.Drawing.Point(49, 69)
        Me.labelDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(48, 19)
        Me.labelDate.TabIndex = 6
        Me.labelDate.Text = "Date"
        '
        'labelSchedule
        '
        Me.labelSchedule.AutoSize = True
        Me.labelSchedule.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelSchedule.Location = New System.Drawing.Point(49, 203)
        Me.labelSchedule.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelSchedule.Name = "labelSchedule"
        Me.labelSchedule.Size = New System.Drawing.Size(82, 19)
        Me.labelSchedule.TabIndex = 7
        Me.labelSchedule.Text = "Schedule"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(166, 194)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 28)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'errorTime
        '
        Me.errorTime.AutoSize = True
        Me.errorTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.errorTime.ForeColor = System.Drawing.Color.Crimson
        Me.errorTime.Location = New System.Drawing.Point(272, 199)
        Me.errorTime.Name = "errorTime"
        Me.errorTime.Size = New System.Drawing.Size(281, 19)
        Me.errorTime.TabIndex = 9
        Me.errorTime.Text = "end time is larger than start time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(51, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Schedule your Vehicle Availability"
        '
        'CarScheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1411, 479)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.errorTime)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.labelSchedule)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.labelEnd)
        Me.Controls.Add(Me.labelStart)
        Me.Controls.Add(Me.Schedule)
        Me.Controls.Add(Me.dayPicker)
        Me.Controls.Add(Me.endPicker)
        Me.Controls.Add(Me.startPicker)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CarScheduler"
        Me.Text = "CarScheduler"
        CType(Me.Schedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startPicker As DateTimePicker
    Friend WithEvents endPicker As DateTimePicker
    Friend WithEvents dayPicker As DateTimePicker
    Friend WithEvents Schedule As DataGridView
    Friend WithEvents labelStart As Label
    Friend WithEvents labelEnd As Label
    Friend WithEvents labelDate As Label
    Friend WithEvents labelSchedule As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents startTime As DataGridViewTextBoxColumn
    Friend WithEvents endTime As DataGridViewTextBoxColumn
    Friend WithEvents Booked As DataGridViewCheckBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents update As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
    Friend WithEvents errorTime As Label
    Friend WithEvents Label1 As Label
End Class
