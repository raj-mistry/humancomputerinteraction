<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dayFilter = New System.Windows.Forms.DateTimePicker()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelCreateBooking = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.begin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.finish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Available = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Book = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Booked = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.labelAvailable = New System.Windows.Forms.Label()
        Me.labelBooked = New System.Windows.Forms.Label()
        Me.startTimeFilter = New System.Windows.Forms.DateTimePicker()
        Me.endTimeFilter = New System.Windows.Forms.DateTimePicker()
        Me.ClearFilter = New System.Windows.Forms.Button()
        Me.filterByTime = New System.Windows.Forms.CheckBox()
        Me.labelStart = New System.Windows.Forms.Label()
        Me.labelEnd = New System.Windows.Forms.Label()
        Me.filterByDay = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timeslotError = New System.Windows.Forms.Label()
        CType(Me.Available, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Booked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dayFilter
        '
        Me.dayFilter.Location = New System.Drawing.Point(23, 144)
        Me.dayFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.dayFilter.Name = "dayFilter"
        Me.dayFilter.Size = New System.Drawing.Size(211, 23)
        Me.dayFilter.TabIndex = 0
        '
        'Day
        '
        Me.Day.HeaderText = "Day"
        Me.Day.MinimumWidth = 8
        Me.Day.Name = "Day"
        Me.Day.Width = 150
        '
        'Start
        '
        Me.Start.HeaderText = "Start"
        Me.Start.MinimumWidth = 8
        Me.Start.Name = "Start"
        Me.Start.Width = 150
        '
        'labelCreateBooking
        '
        Me.labelCreateBooking.AutoSize = True
        Me.labelCreateBooking.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelCreateBooking.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labelCreateBooking.Location = New System.Drawing.Point(25, 39)
        Me.labelCreateBooking.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelCreateBooking.Name = "labelCreateBooking"
        Me.labelCreateBooking.Size = New System.Drawing.Size(377, 45)
        Me.labelCreateBooking.TabIndex = 2
        Me.labelCreateBooking.Text = "Book a Vehicle Timeslot"
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Day"
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "id"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "End Time"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "id"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'begin
        '
        Me.begin.HeaderText = "Begin"
        Me.begin.MinimumWidth = 8
        Me.begin.Name = "begin"
        Me.begin.Width = 150
        '
        'finish
        '
        Me.finish.HeaderText = "Finish"
        Me.finish.MinimumWidth = 8
        Me.finish.Name = "finish"
        Me.finish.Width = 150
        '
        'Available
        '
        Me.Available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Available.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.Book})
        Me.Available.Location = New System.Drawing.Point(23, 366)
        Me.Available.Margin = New System.Windows.Forms.Padding(2)
        Me.Available.Name = "Available"
        Me.Available.RowHeadersWidth = 62
        Me.Available.RowTemplate.Height = 33
        Me.Available.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Available.Size = New System.Drawing.Size(964, 157)
        Me.Available.TabIndex = 4
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "id"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "End Time"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'Book
        '
        Me.Book.HeaderText = "Book"
        Me.Book.MinimumWidth = 8
        Me.Book.Name = "Book"
        Me.Book.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Book.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Book.Text = "Book"
        Me.Book.UseColumnTextForButtonValue = True
        Me.Book.Width = 150
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFilter.Location = New System.Drawing.Point(572, 128)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(146, 33)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Booked
        '
        Me.Booked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Booked.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.Cancel, Me.edit})
        Me.Booked.Location = New System.Drawing.Point(23, 575)
        Me.Booked.Margin = New System.Windows.Forms.Padding(2)
        Me.Booked.Name = "Booked"
        Me.Booked.RowHeadersWidth = 62
        Me.Booked.RowTemplate.Height = 33
        Me.Booked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Booked.Size = New System.Drawing.Size(964, 157)
        Me.Booked.TabIndex = 6
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "id"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "End Time"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'Cancel
        '
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.MinimumWidth = 8
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseColumnTextForButtonValue = True
        Me.Cancel.Width = 150
        '
        'edit
        '
        Me.edit.HeaderText = "Edit"
        Me.edit.Name = "edit"
        Me.edit.UseColumnTextForButtonValue = True
        '
        'labelAvailable
        '
        Me.labelAvailable.AutoSize = True
        Me.labelAvailable.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelAvailable.Location = New System.Drawing.Point(25, 334)
        Me.labelAvailable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelAvailable.Name = "labelAvailable"
        Me.labelAvailable.Size = New System.Drawing.Size(103, 30)
        Me.labelAvailable.TabIndex = 7
        Me.labelAvailable.Text = "Available"
        '
        'labelBooked
        '
        Me.labelBooked.AutoSize = True
        Me.labelBooked.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelBooked.Location = New System.Drawing.Point(25, 545)
        Me.labelBooked.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelBooked.Name = "labelBooked"
        Me.labelBooked.Size = New System.Drawing.Size(88, 30)
        Me.labelBooked.TabIndex = 8
        Me.labelBooked.Text = "Booked"
        '
        'startTimeFilter
        '
        Me.startTimeFilter.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.startTimeFilter.Location = New System.Drawing.Point(23, 227)
        Me.startTimeFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.startTimeFilter.Name = "startTimeFilter"
        Me.startTimeFilter.Size = New System.Drawing.Size(211, 23)
        Me.startTimeFilter.TabIndex = 9
        '
        'endTimeFilter
        '
        Me.endTimeFilter.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.endTimeFilter.Location = New System.Drawing.Point(23, 297)
        Me.endTimeFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.endTimeFilter.Name = "endTimeFilter"
        Me.endTimeFilter.Size = New System.Drawing.Size(211, 23)
        Me.endTimeFilter.TabIndex = 11
        '
        'ClearFilter
        '
        Me.ClearFilter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearFilter.Location = New System.Drawing.Point(572, 216)
        Me.ClearFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearFilter.Name = "ClearFilter"
        Me.ClearFilter.Size = New System.Drawing.Size(146, 33)
        Me.ClearFilter.TabIndex = 13
        Me.ClearFilter.Text = "Clear Filter"
        Me.ClearFilter.UseVisualStyleBackColor = True
        '
        'filterByTime
        '
        Me.filterByTime.AutoSize = True
        Me.filterByTime.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.filterByTime.Location = New System.Drawing.Point(272, 216)
        Me.filterByTime.Name = "filterByTime"
        Me.filterByTime.Size = New System.Drawing.Size(166, 34)
        Me.filterByTime.TabIndex = 14
        Me.filterByTime.Text = "Filter By Time"
        Me.filterByTime.UseVisualStyleBackColor = True
        '
        'labelStart
        '
        Me.labelStart.AutoSize = True
        Me.labelStart.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelStart.Location = New System.Drawing.Point(23, 195)
        Me.labelStart.Name = "labelStart"
        Me.labelStart.Size = New System.Drawing.Size(114, 30)
        Me.labelStart.TabIndex = 17
        Me.labelStart.Text = "Start Time"
        '
        'labelEnd
        '
        Me.labelEnd.AutoSize = True
        Me.labelEnd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelEnd.Location = New System.Drawing.Point(23, 265)
        Me.labelEnd.Name = "labelEnd"
        Me.labelEnd.Size = New System.Drawing.Size(104, 30)
        Me.labelEnd.TabIndex = 18
        Me.labelEnd.Text = "End Time"
        '
        'filterByDay
        '
        Me.filterByDay.AutoSize = True
        Me.filterByDay.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.filterByDay.Location = New System.Drawing.Point(272, 128)
        Me.filterByDay.Name = "filterByDay"
        Me.filterByDay.Size = New System.Drawing.Size(155, 34)
        Me.filterByDay.TabIndex = 19
        Me.filterByDay.Text = "Filter By Day"
        Me.filterByDay.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(23, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 30)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(456, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Booking start and end time will adjust to your desired start and end time"
        '
        'timeslotError
        '
        Me.timeslotError.AutoSize = True
        Me.timeslotError.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.timeslotError.ForeColor = System.Drawing.Color.Red
        Me.timeslotError.Location = New System.Drawing.Point(572, 315)
        Me.timeslotError.Name = "timeslotError"
        Me.timeslotError.Size = New System.Drawing.Size(417, 19)
        Me.timeslotError.TabIndex = 23
        Me.timeslotError.Text = "timeslot is not compatible with your desired schedule."
        Me.timeslotError.Visible = False
        '
        'CarBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 766)
        Me.Controls.Add(Me.timeslotError)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.filterByDay)
        Me.Controls.Add(Me.labelEnd)
        Me.Controls.Add(Me.labelStart)
        Me.Controls.Add(Me.filterByTime)
        Me.Controls.Add(Me.ClearFilter)
        Me.Controls.Add(Me.endTimeFilter)
        Me.Controls.Add(Me.startTimeFilter)
        Me.Controls.Add(Me.labelBooked)
        Me.Controls.Add(Me.labelAvailable)
        Me.Controls.Add(Me.Booked)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.Available)
        Me.Controls.Add(Me.labelCreateBooking)
        Me.Controls.Add(Me.dayFilter)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CarBooking"
        Me.Text = "CarBooking"
        CType(Me.Available, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Booked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dayFilter As DateTimePicker
    Friend WithEvents Day As DataGridViewTextBoxColumn
    Friend WithEvents Start As DataGridViewTextBoxColumn
    Friend WithEvents labelCreateBooking As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents startTime As DataGridViewTextBoxColumn
    Friend WithEvents endTime As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents begin As DataGridViewTextBoxColumn
    Friend WithEvents finish As DataGridViewTextBoxColumn
    Friend WithEvents Available As DataGridView
    Friend WithEvents btnFilter As Button
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Book As DataGridViewButtonColumn
    Friend WithEvents Booked As DataGridView
    Friend WithEvents labelAvailable As Label
    Friend WithEvents labelBooked As Label
    Friend WithEvents startTimeFilter As DateTimePicker
    Friend WithEvents endTimeFilter As DateTimePicker
    Friend WithEvents ClearFilter As Button
    Friend WithEvents filterByTime As CheckBox
    Friend WithEvents labelStart As Label
    Friend WithEvents labelEnd As Label
    Friend WithEvents filterByDay As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents Cancel As DataGridViewButtonColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents timeslotError As Label
End Class
