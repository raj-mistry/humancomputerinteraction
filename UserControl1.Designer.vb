<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulingSystem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.bookACar = New System.Windows.Forms.Button()
        Me.setCarSchedule = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bookACar
        '
        Me.bookACar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bookACar.Location = New System.Drawing.Point(17, 87)
        Me.bookACar.Margin = New System.Windows.Forms.Padding(2)
        Me.bookACar.Name = "bookACar"
        Me.bookACar.Size = New System.Drawing.Size(256, 54)
        Me.bookACar.TabIndex = 0
        Me.bookACar.Text = "Book a Car"
        Me.bookACar.UseVisualStyleBackColor = True
        '
        'setCarSchedule
        '
        Me.setCarSchedule.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.setCarSchedule.Location = New System.Drawing.Point(17, 15)
        Me.setCarSchedule.Margin = New System.Windows.Forms.Padding(2)
        Me.setCarSchedule.Name = "setCarSchedule"
        Me.setCarSchedule.Size = New System.Drawing.Size(256, 54)
        Me.setCarSchedule.TabIndex = 1
        Me.setCarSchedule.Text = "Set Car Schedule"
        Me.setCarSchedule.UseVisualStyleBackColor = True
        '
        'SchedulingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.setCarSchedule)
        Me.Controls.Add(Me.bookACar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SchedulingSystem"
        Me.Size = New System.Drawing.Size(286, 157)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bookACar As Button
    Friend WithEvents setCarSchedule As Button
End Class
