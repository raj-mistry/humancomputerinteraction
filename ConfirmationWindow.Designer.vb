<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmationWindow
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
        Me.labelConfirm = New System.Windows.Forms.Label()
        Me.acceptButton = New System.Windows.Forms.Button()
        Me.denyButton = New System.Windows.Forms.Button()
        Me.bookingDetails = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelConfirm
        '
        Me.labelConfirm.AutoSize = True
        Me.labelConfirm.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelConfirm.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labelConfirm.Location = New System.Drawing.Point(75, 48)
        Me.labelConfirm.Name = "labelConfirm"
        Me.labelConfirm.Size = New System.Drawing.Size(299, 47)
        Me.labelConfirm.TabIndex = 0
        Me.labelConfirm.Text = "Booking Request"
        '
        'acceptButton
        '
        Me.acceptButton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.acceptButton.Location = New System.Drawing.Point(75, 512)
        Me.acceptButton.Name = "acceptButton"
        Me.acceptButton.Size = New System.Drawing.Size(112, 35)
        Me.acceptButton.TabIndex = 1
        Me.acceptButton.Text = "Accept"
        Me.acceptButton.UseVisualStyleBackColor = True
        '
        'denyButton
        '
        Me.denyButton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.denyButton.Location = New System.Drawing.Point(262, 512)
        Me.denyButton.Name = "denyButton"
        Me.denyButton.Size = New System.Drawing.Size(112, 35)
        Me.denyButton.TabIndex = 2
        Me.denyButton.Text = "Deny"
        Me.denyButton.UseVisualStyleBackColor = True
        '
        'bookingDetails
        '
        Me.bookingDetails.AutoSize = True
        Me.bookingDetails.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bookingDetails.Location = New System.Drawing.Point(143, 184)
        Me.bookingDetails.Name = "bookingDetails"
        Me.bookingDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bookingDetails.Size = New System.Drawing.Size(152, 25)
        Me.bookingDetails.TabIndex = 3
        Me.bookingDetails.Text = "Booking Details"
        '
        'ConfirmationWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 606)
        Me.Controls.Add(Me.bookingDetails)
        Me.Controls.Add(Me.denyButton)
        Me.Controls.Add(Me.acceptButton)
        Me.Controls.Add(Me.labelConfirm)
        Me.Name = "ConfirmationWindow"
        Me.Text = "ConfirmationWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelConfirm As Label
    Friend WithEvents acceptButton As Button
    Friend WithEvents denyButton As Button
    Friend WithEvents bookingDetails As Label
End Class
