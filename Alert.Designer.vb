<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alert
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
        Me.AlertLabel = New System.Windows.Forms.Label()
        Me.UserTypeLabel = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.ActionButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AlertLabel
        '
        Me.AlertLabel.AutoSize = True
        Me.AlertLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlertLabel.ForeColor = System.Drawing.Color.Red
        Me.AlertLabel.Location = New System.Drawing.Point(118, 94)
        Me.AlertLabel.Name = "AlertLabel"
        Me.AlertLabel.Size = New System.Drawing.Size(172, 65)
        Me.AlertLabel.TabIndex = 7
        Me.AlertLabel.Text = "ALERT!"
        '
        'UserTypeLabel
        '
        Me.UserTypeLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UserTypeLabel.Location = New System.Drawing.Point(12, 64)
        Me.UserTypeLabel.Name = "UserTypeLabel"
        Me.UserTypeLabel.Size = New System.Drawing.Size(385, 30)
        Me.UserTypeLabel.TabIndex = 8
        Me.UserTypeLabel.Text = "(OWNER)"
        Me.UserTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DescriptionLabel.Location = New System.Drawing.Point(12, 178)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(385, 63)
        Me.DescriptionLabel.TabIndex = 9
        Me.DescriptionLabel.Text = "Description"
        Me.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActionButton
        '
        Me.ActionButton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ActionButton.Location = New System.Drawing.Point(109, 269)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(191, 43)
        Me.ActionButton.TabIndex = 10
        Me.ActionButton.Text = "Action"
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelButton.Location = New System.Drawing.Point(109, 336)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(191, 43)
        Me.CancelButton.TabIndex = 12
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 455)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ActionButton)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.UserTypeLabel)
        Me.Controls.Add(Me.AlertLabel)
        Me.Name = "Alert"
        Me.Text = "Alert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlertLabel As Label
    Friend WithEvents UserTypeLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents ActionButton As Button
    Friend WithEvents CancelButton As Button
End Class
