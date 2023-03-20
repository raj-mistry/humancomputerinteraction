<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carMedia
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
        Me.radioOn = New System.Windows.Forms.Button()
        Me.radioOff = New System.Windows.Forms.Button()
        Me.navOn = New System.Windows.Forms.Button()
        Me.navOff = New System.Windows.Forms.Button()
        Me.speakerOn = New System.Windows.Forms.Button()
        Me.speakerOff = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radioOn
        '
        Me.radioOn.Location = New System.Drawing.Point(52, 71)
        Me.radioOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radioOn.Name = "radioOn"
        Me.radioOn.Size = New System.Drawing.Size(82, 22)
        Me.radioOn.TabIndex = 0
        Me.radioOn.Text = "On"
        Me.radioOn.UseVisualStyleBackColor = True
        '
        'radioOff
        '
        Me.radioOff.Location = New System.Drawing.Point(169, 71)
        Me.radioOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radioOff.Name = "radioOff"
        Me.radioOff.Size = New System.Drawing.Size(82, 22)
        Me.radioOff.TabIndex = 1
        Me.radioOff.Text = "Off"
        Me.radioOff.UseVisualStyleBackColor = True
        '
        'navOn
        '
        Me.navOn.Location = New System.Drawing.Point(440, 71)
        Me.navOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.navOn.Name = "navOn"
        Me.navOn.Size = New System.Drawing.Size(82, 22)
        Me.navOn.TabIndex = 2
        Me.navOn.Text = "On"
        Me.navOn.UseVisualStyleBackColor = True
        '
        'navOff
        '
        Me.navOff.Location = New System.Drawing.Point(565, 71)
        Me.navOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.navOff.Name = "navOff"
        Me.navOff.Size = New System.Drawing.Size(82, 22)
        Me.navOff.TabIndex = 3
        Me.navOff.Text = "Off"
        Me.navOff.UseVisualStyleBackColor = True
        '
        'speakerOn
        '
        Me.speakerOn.Location = New System.Drawing.Point(237, 214)
        Me.speakerOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.speakerOn.Name = "speakerOn"
        Me.speakerOn.Size = New System.Drawing.Size(82, 22)
        Me.speakerOn.TabIndex = 4
        Me.speakerOn.Text = "On"
        Me.speakerOn.UseVisualStyleBackColor = True
        '
        'speakerOff
        '
        Me.speakerOff.Location = New System.Drawing.Point(368, 214)
        Me.speakerOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.speakerOff.Name = "speakerOff"
        Me.speakerOff.Size = New System.Drawing.Size(82, 22)
        Me.speakerOff.TabIndex = 5
        Me.speakerOff.Text = "Off"
        Me.speakerOff.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(114, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Radio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(429, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Navigation Narration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(311, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Speaker"
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(234, 252)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(217, 45)
        Me.TrackBar1.TabIndex = 9
        '
        'carMedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.speakerOff)
        Me.Controls.Add(Me.speakerOn)
        Me.Controls.Add(Me.navOff)
        Me.Controls.Add(Me.navOn)
        Me.Controls.Add(Me.radioOff)
        Me.Controls.Add(Me.radioOn)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "carMedia"
        Me.Text = "Media"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioOn As Button
    Friend WithEvents radioOff As Button
    Friend WithEvents navOn As Button
    Friend WithEvents navOff As Button
    Friend WithEvents speakerOn As Button
    Friend WithEvents speakerOff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar1 As TrackBar
End Class
