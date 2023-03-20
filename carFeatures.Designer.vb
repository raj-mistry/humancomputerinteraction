<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class carFeatures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carFeatures))
        Me.temperature = New System.Windows.Forms.Label()
        Me.degree = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.upTemp = New System.Windows.Forms.Button()
        Me.downTemp = New System.Windows.Forms.Button()
        Me.outTemp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.degreeOut = New System.Windows.Forms.Label()
        Me.carTemp = New System.Windows.Forms.Label()
        Me.rear = New System.Windows.Forms.Button()
        Me.middle = New System.Windows.Forms.Button()
        Me.front = New System.Windows.Forms.Button()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.tempLoc = New System.Windows.Forms.Label()
        Me.seatLoc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.seatOff = New System.Windows.Forms.Button()
        Me.seatOn = New System.Windows.Forms.Button()
        Me.fanLoc = New System.Windows.Forms.Label()
        Me.fan = New System.Windows.Forms.Label()
        Me.fanOff = New System.Windows.Forms.Button()
        Me.fanOn = New System.Windows.Forms.Button()
        Me.windowLoc = New System.Windows.Forms.Label()
        Me.window = New System.Windows.Forms.Label()
        Me.blWindow = New System.Windows.Forms.Button()
        Me.flWindow = New System.Windows.Forms.Button()
        Me.frWindow = New System.Windows.Forms.Button()
        Me.brWindow = New System.Windows.Forms.Button()
        Me.carTop = New System.Windows.Forms.PictureBox()
        Me.openWindow = New System.Windows.Forms.Button()
        Me.closeWindow = New System.Windows.Forms.Button()
        Me.defrost = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.openTrunk = New System.Windows.Forms.Button()
        Me.closeTrunk = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.intakeOn = New System.Windows.Forms.Button()
        Me.intakeOff = New System.Windows.Forms.Button()
        Me.intakeLbl = New System.Windows.Forms.Label()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'temperature
        '
        Me.temperature.AutoSize = True
        Me.temperature.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.temperature.Location = New System.Drawing.Point(139, 186)
        Me.temperature.Name = "temperature"
        Me.temperature.Size = New System.Drawing.Size(136, 30)
        Me.temperature.TabIndex = 0
        Me.temperature.Text = "Temperature"
        '
        'degree
        '
        Me.degree.AutoSize = True
        Me.degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.degree.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.degree.Location = New System.Drawing.Point(50, 243)
        Me.degree.Name = "degree"
        Me.degree.Size = New System.Drawing.Size(82, 67)
        Me.degree.TabIndex = 1
        Me.degree.Text = "20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(117, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "°"
        '
        'upTemp
        '
        Me.upTemp.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.upTemp.Location = New System.Drawing.Point(136, 239)
        Me.upTemp.Name = "upTemp"
        Me.upTemp.Size = New System.Drawing.Size(43, 38)
        Me.upTemp.TabIndex = 3
        Me.upTemp.Text = "🔼"
        Me.upTemp.UseVisualStyleBackColor = True
        '
        'downTemp
        '
        Me.downTemp.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.downTemp.Location = New System.Drawing.Point(136, 283)
        Me.downTemp.Name = "downTemp"
        Me.downTemp.Size = New System.Drawing.Size(43, 38)
        Me.downTemp.TabIndex = 4
        Me.downTemp.Text = "🔽"
        Me.downTemp.UseVisualStyleBackColor = True
        '
        'outTemp
        '
        Me.outTemp.AutoSize = True
        Me.outTemp.Location = New System.Drawing.Point(247, 334)
        Me.outTemp.Name = "outTemp"
        Me.outTemp.Size = New System.Drawing.Size(117, 15)
        Me.outTemp.TabIndex = 5
        Me.outTemp.Text = "Outside Temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "°"
        '
        'degreeOut
        '
        Me.degreeOut.AutoSize = True
        Me.degreeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.degreeOut.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.degreeOut.Location = New System.Drawing.Point(276, 243)
        Me.degreeOut.Name = "degreeOut"
        Me.degreeOut.Size = New System.Drawing.Size(56, 67)
        Me.degreeOut.TabIndex = 7
        Me.degreeOut.Text = "5"
        '
        'carTemp
        '
        Me.carTemp.AutoSize = True
        Me.carTemp.Location = New System.Drawing.Point(71, 334)
        Me.carTemp.Name = "carTemp"
        Me.carTemp.Size = New System.Drawing.Size(94, 15)
        Me.carTemp.TabIndex = 8
        Me.carTemp.Text = "Car Temperature"
        '
        'rear
        '
        Me.rear.Location = New System.Drawing.Point(267, 136)
        Me.rear.Name = "rear"
        Me.rear.Size = New System.Drawing.Size(75, 23)
        Me.rear.TabIndex = 9
        Me.rear.Text = "Rear"
        Me.rear.UseVisualStyleBackColor = True
        '
        'middle
        '
        Me.middle.Location = New System.Drawing.Point(170, 136)
        Me.middle.Name = "middle"
        Me.middle.Size = New System.Drawing.Size(75, 23)
        Me.middle.TabIndex = 10
        Me.middle.Text = "Middle"
        Me.middle.UseVisualStyleBackColor = True
        '
        'front
        '
        Me.front.Location = New System.Drawing.Point(71, 136)
        Me.front.Name = "front"
        Me.front.Size = New System.Drawing.Size(75, 23)
        Me.front.TabIndex = 11
        Me.front.Text = "Front"
        Me.front.UseVisualStyleBackColor = True
        '
        'car
        '
        Me.car.Image = CType(resources.GetObject("car.Image"), System.Drawing.Image)
        Me.car.Location = New System.Drawing.Point(71, 23)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(271, 97)
        Me.car.TabIndex = 12
        Me.car.TabStop = False
        '
        'tempLoc
        '
        Me.tempLoc.AutoSize = True
        Me.tempLoc.Location = New System.Drawing.Point(275, 198)
        Me.tempLoc.Name = "tempLoc"
        Me.tempLoc.Size = New System.Drawing.Size(66, 15)
        Me.tempLoc.TabIndex = 13
        Me.tempLoc.Text = "(Entire Car)"
        '
        'seatLoc
        '
        Me.seatLoc.AutoSize = True
        Me.seatLoc.Location = New System.Drawing.Point(271, 380)
        Me.seatLoc.Name = "seatLoc"
        Me.seatLoc.Size = New System.Drawing.Size(66, 15)
        Me.seatLoc.TabIndex = 14
        Me.seatLoc.Text = "(Entire Car)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(155, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Seat Heater"
        '
        'seatOff
        '
        Me.seatOff.Enabled = False
        Me.seatOff.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.seatOff.Location = New System.Drawing.Point(242, 411)
        Me.seatOff.Name = "seatOff"
        Me.seatOff.Size = New System.Drawing.Size(75, 34)
        Me.seatOff.TabIndex = 16
        Me.seatOff.Text = "OFF"
        Me.seatOff.UseVisualStyleBackColor = True
        '
        'seatOn
        '
        Me.seatOn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.seatOn.Location = New System.Drawing.Point(100, 411)
        Me.seatOn.Name = "seatOn"
        Me.seatOn.Size = New System.Drawing.Size(75, 34)
        Me.seatOn.TabIndex = 17
        Me.seatOn.Text = "ON"
        Me.seatOn.UseVisualStyleBackColor = True
        '
        'fanLoc
        '
        Me.fanLoc.AutoSize = True
        Me.fanLoc.Location = New System.Drawing.Point(120, 487)
        Me.fanLoc.Name = "fanLoc"
        Me.fanLoc.Size = New System.Drawing.Size(66, 15)
        Me.fanLoc.TabIndex = 18
        Me.fanLoc.Text = "(Entire Car)"
        '
        'fan
        '
        Me.fan.AutoSize = True
        Me.fan.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.fan.Location = New System.Drawing.Point(71, 479)
        Me.fan.Name = "fan"
        Me.fan.Size = New System.Drawing.Size(43, 25)
        Me.fan.TabIndex = 19
        Me.fan.Text = "Fan"
        '
        'fanOff
        '
        Me.fanOff.Enabled = False
        Me.fanOff.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fanOff.Location = New System.Drawing.Point(71, 569)
        Me.fanOff.Name = "fanOff"
        Me.fanOff.Size = New System.Drawing.Size(75, 34)
        Me.fanOff.TabIndex = 20
        Me.fanOff.Text = "OFF"
        Me.fanOff.UseVisualStyleBackColor = True
        '
        'fanOn
        '
        Me.fanOn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fanOn.Location = New System.Drawing.Point(71, 519)
        Me.fanOn.Name = "fanOn"
        Me.fanOn.Size = New System.Drawing.Size(75, 34)
        Me.fanOn.TabIndex = 21
        Me.fanOn.Text = "ON"
        Me.fanOn.UseVisualStyleBackColor = True
        '
        'windowLoc
        '
        Me.windowLoc.AutoSize = True
        Me.windowLoc.Location = New System.Drawing.Point(273, 638)
        Me.windowLoc.Name = "windowLoc"
        Me.windowLoc.Size = New System.Drawing.Size(81, 15)
        Me.windowLoc.TabIndex = 22
        Me.windowLoc.Text = "(All Windows)"
        '
        'window
        '
        Me.window.AutoSize = True
        Me.window.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.window.Location = New System.Drawing.Point(145, 630)
        Me.window.Name = "window"
        Me.window.Size = New System.Drawing.Size(122, 25)
        Me.window.TabIndex = 23
        Me.window.Text = "Car Window"
        '
        'blWindow
        '
        Me.blWindow.Location = New System.Drawing.Point(50, 776)
        Me.blWindow.Name = "blWindow"
        Me.blWindow.Size = New System.Drawing.Size(75, 23)
        Me.blWindow.TabIndex = 24
        Me.blWindow.Text = "Back Left"
        Me.blWindow.UseVisualStyleBackColor = True
        '
        'flWindow
        '
        Me.flWindow.Location = New System.Drawing.Point(50, 728)
        Me.flWindow.Name = "flWindow"
        Me.flWindow.Size = New System.Drawing.Size(75, 23)
        Me.flWindow.TabIndex = 25
        Me.flWindow.Text = "Front Left"
        Me.flWindow.UseVisualStyleBackColor = True
        '
        'frWindow
        '
        Me.frWindow.Location = New System.Drawing.Point(284, 728)
        Me.frWindow.Name = "frWindow"
        Me.frWindow.Size = New System.Drawing.Size(75, 23)
        Me.frWindow.TabIndex = 26
        Me.frWindow.Text = "Front Right"
        Me.frWindow.UseVisualStyleBackColor = True
        '
        'brWindow
        '
        Me.brWindow.Location = New System.Drawing.Point(284, 776)
        Me.brWindow.Name = "brWindow"
        Me.brWindow.Size = New System.Drawing.Size(75, 23)
        Me.brWindow.TabIndex = 27
        Me.brWindow.Text = "Back Right"
        Me.brWindow.UseVisualStyleBackColor = True
        '
        'carTop
        '
        Me.carTop.Image = CType(resources.GetObject("carTop.Image"), System.Drawing.Image)
        Me.carTop.Location = New System.Drawing.Point(145, 672)
        Me.carTop.Name = "carTop"
        Me.carTop.Size = New System.Drawing.Size(124, 191)
        Me.carTop.TabIndex = 28
        Me.carTop.TabStop = False
        '
        'openWindow
        '
        Me.openWindow.Location = New System.Drawing.Point(112, 878)
        Me.openWindow.Name = "openWindow"
        Me.openWindow.Size = New System.Drawing.Size(75, 34)
        Me.openWindow.TabIndex = 29
        Me.openWindow.Text = "OPEN"
        Me.openWindow.UseVisualStyleBackColor = True
        '
        'closeWindow
        '
        Me.closeWindow.Enabled = False
        Me.closeWindow.Location = New System.Drawing.Point(228, 878)
        Me.closeWindow.Name = "closeWindow"
        Me.closeWindow.Size = New System.Drawing.Size(75, 34)
        Me.closeWindow.TabIndex = 30
        Me.closeWindow.Text = "CLOSE"
        Me.closeWindow.UseVisualStyleBackColor = True
        '
        'defrost
        '
        Me.defrost.AutoSize = True
        Me.defrost.Location = New System.Drawing.Point(151, 930)
        Me.defrost.Name = "defrost"
        Me.defrost.Size = New System.Drawing.Size(116, 19)
        Me.defrost.TabIndex = 31
        Me.defrost.Text = "Defrost Windows"
        Me.defrost.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 955)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'openTrunk
        '
        Me.openTrunk.Location = New System.Drawing.Point(128, 963)
        Me.openTrunk.Name = "openTrunk"
        Me.openTrunk.Size = New System.Drawing.Size(75, 23)
        Me.openTrunk.TabIndex = 33
        Me.openTrunk.Text = "OPEN"
        Me.openTrunk.UseVisualStyleBackColor = True
        '
        'closeTrunk
        '
        Me.closeTrunk.Enabled = False
        Me.closeTrunk.Location = New System.Drawing.Point(128, 1015)
        Me.closeTrunk.Name = "closeTrunk"
        Me.closeTrunk.Size = New System.Drawing.Size(75, 23)
        Me.closeTrunk.TabIndex = 34
        Me.closeTrunk.Text = "CLOSE"
        Me.closeTrunk.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.LightSkyBlue
        Me.save.Location = New System.Drawing.Point(311, 997)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 35
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.OrangeRed
        Me.cancel.Location = New System.Drawing.Point(311, 1026)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 36
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 1052)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 37
        '
        'intakeOn
        '
        Me.intakeOn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.intakeOn.Location = New System.Drawing.Point(242, 519)
        Me.intakeOn.Name = "intakeOn"
        Me.intakeOn.Size = New System.Drawing.Size(75, 34)
        Me.intakeOn.TabIndex = 41
        Me.intakeOn.Text = "ON"
        Me.intakeOn.UseVisualStyleBackColor = True
        '
        'intakeOff
        '
        Me.intakeOff.Enabled = False
        Me.intakeOff.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.intakeOff.Location = New System.Drawing.Point(242, 569)
        Me.intakeOff.Name = "intakeOff"
        Me.intakeOff.Size = New System.Drawing.Size(75, 34)
        Me.intakeOff.TabIndex = 40
        Me.intakeOff.Text = "OFF"
        Me.intakeOff.UseVisualStyleBackColor = True
        '
        'intakeLbl
        '
        Me.intakeLbl.AutoSize = True
        Me.intakeLbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.intakeLbl.Location = New System.Drawing.Point(242, 479)
        Me.intakeLbl.Name = "intakeLbl"
        Me.intakeLbl.Size = New System.Drawing.Size(68, 25)
        Me.intakeLbl.TabIndex = 39
        Me.intakeLbl.Text = "Intake"
        '
        'carFeatures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(405, 789)
        Me.Controls.Add(Me.intakeOn)
        Me.Controls.Add(Me.intakeOff)
        Me.Controls.Add(Me.intakeLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.closeTrunk)
        Me.Controls.Add(Me.openTrunk)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.defrost)
        Me.Controls.Add(Me.closeWindow)
        Me.Controls.Add(Me.openWindow)
        Me.Controls.Add(Me.carTop)
        Me.Controls.Add(Me.brWindow)
        Me.Controls.Add(Me.frWindow)
        Me.Controls.Add(Me.flWindow)
        Me.Controls.Add(Me.blWindow)
        Me.Controls.Add(Me.window)
        Me.Controls.Add(Me.windowLoc)
        Me.Controls.Add(Me.fanOn)
        Me.Controls.Add(Me.fanOff)
        Me.Controls.Add(Me.fan)
        Me.Controls.Add(Me.fanLoc)
        Me.Controls.Add(Me.seatOn)
        Me.Controls.Add(Me.seatOff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.seatLoc)
        Me.Controls.Add(Me.tempLoc)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.front)
        Me.Controls.Add(Me.middle)
        Me.Controls.Add(Me.rear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.carTemp)
        Me.Controls.Add(Me.degreeOut)
        Me.Controls.Add(Me.outTemp)
        Me.Controls.Add(Me.downTemp)
        Me.Controls.Add(Me.upTemp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.degree)
        Me.Controls.Add(Me.temperature)
        Me.Name = "carFeatures"
        Me.Text = "carFeatures"
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents temperature As Label
    Friend WithEvents degree As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents upTemp As Button
    Friend WithEvents downTemp As Button
    Friend WithEvents outTemp As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents degreeOut As Label
    Friend WithEvents carTemp As Label
    Friend WithEvents rear As Button
    Friend WithEvents middle As Button
    Friend WithEvents front As Button
    Friend WithEvents car As PictureBox
    Friend WithEvents tempLoc As Label
    Friend WithEvents seatLoc As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents seatOff As Button
    Friend WithEvents seatOn As Button
    Friend WithEvents fanLoc As Label
    Friend WithEvents fan As Label
    Friend WithEvents fanOff As Button
    Friend WithEvents fanOn As Button
    Friend WithEvents windowLoc As Label
    Friend WithEvents window As Label
    Friend WithEvents blWindow As Button
    Friend WithEvents flWindow As Button
    Friend WithEvents frWindow As Button
    Friend WithEvents brWindow As Button
    Friend WithEvents carTop As PictureBox
    Friend WithEvents openWindow As Button
    Friend WithEvents closeWindow As Button
    Friend WithEvents defrost As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents openTrunk As Button
    Friend WithEvents closeTrunk As Button
    Friend WithEvents save As Button
    Friend WithEvents cancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents intakeOn As Button
    Friend WithEvents intakeOff As Button
    Friend WithEvents intakeLbl As Label
End Class
