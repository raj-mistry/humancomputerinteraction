<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.UserControl11 = New _613Prototype.SchedulingSystem()
        Me.carSettings = New System.Windows.Forms.Button()
        Me.Media = New System.Windows.Forms.Button()
        Me.routesBtn = New System.Windows.Forms.Button()
        Me.ratingBtn = New System.Windows.Forms.Button()
        Me.Chat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAccount
        '
        Me.btnAccount.Enabled = False
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAccount.Location = New System.Drawing.Point(129, 630)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(147, 43)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.Text = "My Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(57, 85)
        Me.UserControl11.Margin = New System.Windows.Forms.Padding(1)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(285, 155)
        Me.UserControl11.TabIndex = 3
        '
        'carSettings
        '
        Me.carSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.carSettings.Location = New System.Drawing.Point(75, 279)
        Me.carSettings.Name = "carSettings"
        Me.carSettings.Size = New System.Drawing.Size(252, 54)
        Me.carSettings.TabIndex = 4
        Me.carSettings.Text = "Car Settings"
        Me.carSettings.UseVisualStyleBackColor = True
        '
        'Media
        '
        Me.Media.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Media.Location = New System.Drawing.Point(75, 348)
        Me.Media.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Media.Name = "Media"
        Me.Media.Size = New System.Drawing.Size(252, 53)
        Me.Media.TabIndex = 5
        Me.Media.Text = "Media"
        Me.Media.UseVisualStyleBackColor = True
        '
        'routesBtn
        '
        Me.routesBtn.Enabled = False
        Me.routesBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.routesBtn.Location = New System.Drawing.Point(75, 415)
        Me.routesBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.routesBtn.Name = "routesBtn"
        Me.routesBtn.Size = New System.Drawing.Size(252, 53)
        Me.routesBtn.TabIndex = 6
        Me.routesBtn.Text = "Routes"
        Me.routesBtn.UseVisualStyleBackColor = True
        '
        'ratingBtn
        '
        Me.ratingBtn.Enabled = False
        Me.ratingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ratingBtn.Location = New System.Drawing.Point(2, 630)
        Me.ratingBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ratingBtn.Name = "ratingBtn"
        Me.ratingBtn.Size = New System.Drawing.Size(108, 44)
        Me.ratingBtn.TabIndex = 7
        Me.ratingBtn.Text = "Rating"
        Me.ratingBtn.UseVisualStyleBackColor = True
        '
        'Chat
        '
        Me.Chat.Enabled = False
        Me.Chat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Chat.Location = New System.Drawing.Point(296, 629)
        Me.Chat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(108, 44)
        Me.Chat.TabIndex = 8
        Me.Chat.Text = "Chat"
        Me.Chat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 684)
        Me.Controls.Add(Me.Chat)
        Me.Controls.Add(Me.ratingBtn)
        Me.Controls.Add(Me.routesBtn)
        Me.Controls.Add(Me.Media)
        Me.Controls.Add(Me.carSettings)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.btnAccount)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "E-Car Rental"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAccount As Button
    Friend WithEvents UserControl11 As SchedulingSystem
    Friend WithEvents carSettings As Button
    Friend WithEvents Media As Button
    Friend WithEvents routesBtn As Button
    Friend WithEvents ratingBtn As Button
    Friend WithEvents Chat As Button
End Class
