Public Class carFeatures
    Private Sub upTemp_Click(sender As Object, e As EventArgs) Handles upTemp.Click
        degree.Text += 1
    End Sub

    Private Sub downTemp_Click(sender As Object, e As EventArgs) Handles downTemp.Click
        degree.Text -= 1
    End Sub

    Private Sub car_Click(sender As Object, e As EventArgs) Handles car.Click
        front.Enabled = True
        middle.Enabled = True
        rear.Enabled = True

        seatOn.Enabled = True
        seatOff.Enabled = True
        fanOn.Enabled = True
        fanOff.Enabled = True

        car.BorderStyle = BorderStyle.FixedSingle

        tempLoc.Text = "(Entire Car)"
        seatLoc.Text = "(Entire Car)"
        fanLoc.Text = "(Entire Car)"
    End Sub

    Private Sub front_Click(sender As Object, e As EventArgs) Handles front.Click
        front.Enabled = False
        middle.Enabled = True
        rear.Enabled = True

        seatOn.Enabled = True
        seatOff.Enabled = True
        fanOn.Enabled = True
        fanOff.Enabled = True

        car.BorderStyle = BorderStyle.None

        tempLoc.Text = "(Front)"
        seatLoc.Text = "(Front)"
        fanLoc.Text = "(Front)"
    End Sub

    Private Sub middle_Click(sender As Object, e As EventArgs) Handles middle.Click
        front.Enabled = True
        middle.Enabled = False
        rear.Enabled = True

        seatOn.Enabled = True
        seatOff.Enabled = True
        fanOn.Enabled = True
        fanOff.Enabled = True

        car.BorderStyle = BorderStyle.None

        tempLoc.Text = "(Middle)"
        seatLoc.Text = "(Middle)"
        fanLoc.Text = "(Middle)"
    End Sub

    Private Sub rear_Click(sender As Object, e As EventArgs) Handles rear.Click
        front.Enabled = True
        middle.Enabled = True
        rear.Enabled = False

        seatOn.Enabled = True
        seatOff.Enabled = True
        fanOn.Enabled = True
        fanOff.Enabled = True

        car.BorderStyle = BorderStyle.None

        tempLoc.Text = "(Rear)"
        seatLoc.Text = "(Rear)"
        fanLoc.Text = "(Rear)"
    End Sub

    Private Sub seatOn_Click(sender As Object, e As EventArgs) Handles seatOn.Click
        seatOn.Enabled = False
        seatOff.Enabled = True
    End Sub

    Private Sub seatOff_Click(sender As Object, e As EventArgs) Handles seatOff.Click
        seatOn.Enabled = True
        seatOff.Enabled = False
    End Sub

    Private Sub fanOn_Click(sender As Object, e As EventArgs) Handles fanOn.Click
        fanOn.Enabled = False
        fanOff.Enabled = True
    End Sub

    Private Sub fanOff_Click(sender As Object, e As EventArgs) Handles fanOff.Click
        fanOn.Enabled = True
        fanOff.Enabled = False
    End Sub

    Private Sub flWindow_Click(sender As Object, e As EventArgs) Handles flWindow.Click
        flWindow.Enabled = False
        frWindow.Enabled = True
        blWindow.Enabled = True
        brWindow.Enabled = True

        openWindow.Enabled = True
        closeWindow.Enabled = True

        carTop.BorderStyle = BorderStyle.None

        windowLoc.Text = "(Front Left)"
    End Sub

    Private Sub frWindow_Click(sender As Object, e As EventArgs) Handles frWindow.Click
        flWindow.Enabled = True
        frWindow.Enabled = False
        blWindow.Enabled = True
        brWindow.Enabled = True

        openWindow.Enabled = True
        closeWindow.Enabled = True

        carTop.BorderStyle = BorderStyle.None

        windowLoc.Text = "(Front Right)"
    End Sub

    Private Sub blWindow_Click(sender As Object, e As EventArgs) Handles blWindow.Click
        flWindow.Enabled = True
        frWindow.Enabled = True
        blWindow.Enabled = False
        brWindow.Enabled = True

        openWindow.Enabled = True
        closeWindow.Enabled = True

        carTop.BorderStyle = BorderStyle.None

        windowLoc.Text = "(Back Left)"
    End Sub

    Private Sub brWindow_Click(sender As Object, e As EventArgs) Handles brWindow.Click
        flWindow.Enabled = True
        frWindow.Enabled = True
        blWindow.Enabled = True
        brWindow.Enabled = False

        openWindow.Enabled = True
        closeWindow.Enabled = True

        carTop.BorderStyle = BorderStyle.None

        windowLoc.Text = "(Back Right)"
    End Sub

    Private Sub openWindow_Click(sender As Object, e As EventArgs) Handles openWindow.Click
        openWindow.Enabled = False
        closeWindow.Enabled = True
    End Sub

    Private Sub closeWindow_Click(sender As Object, e As EventArgs) Handles closeWindow.Click
        openWindow.Enabled = True
        closeWindow.Enabled = False
    End Sub

    Private Sub openTrunk_Click(sender As Object, e As EventArgs) Handles openTrunk.Click
        openTrunk.Enabled = False
        closeTrunk.Enabled = True
    End Sub

    Private Sub closeTrunk_Click(sender As Object, e As EventArgs) Handles closeTrunk.Click
        openTrunk.Enabled = True
        closeTrunk.Enabled = False
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Me.Close()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub carTop_Click(sender As Object, e As EventArgs) Handles carTop.Click
        flWindow.Enabled = True
        frWindow.Enabled = True
        blWindow.Enabled = True
        brWindow.Enabled = True

        openWindow.Enabled = True
        closeWindow.Enabled = True

        carTop.BorderStyle = BorderStyle.FixedSingle

        windowLoc.Text = "(All Windows)"
    End Sub

    Private Sub intakeOff_Click(sender As Object, e As EventArgs) Handles intakeOff.Click

        intakeOn.Enabled = True
        intakeOff.Enabled = False

    End Sub

    Private Sub intakeOn_Click(sender As Object, e As EventArgs) Handles intakeOn.Click
        intakeOn.Enabled = False
        intakeOff.Enabled = True
    End Sub

    Private Sub carFeatures_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class