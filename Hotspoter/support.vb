Public Class support

    Private Sub Starter_Click(sender As Object, e As EventArgs) Handles Starter.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FPJVTMZGN2SVS")
    End Sub
    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Starter.MouseHover
        Starter.FlatAppearance.BorderColor = Color.DeepSkyBlue
        Starter.ForeColor = Color.White
        Starter.BackColor = Color.DeepSkyBlue
    End Sub
    Private Sub Button1_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Starter.MouseLeave
        Starter.FlatAppearance.BorderColor = Color.DeepSkyBlue
        Starter.ForeColor = Color.DeepSkyBlue
        Starter.BackColor = Color.Transparent
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button5_hover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Button6.BackgroundImage = My.Resources.hover
    End Sub
    Private Sub Button5_leave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackgroundImage = My.Resources.leave
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub
End Class