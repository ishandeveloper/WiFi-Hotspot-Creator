Public Class team

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Process.Start("http://onhax.net")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Visible = False
        Form1.Visible = True
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub team_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        smile.Visible = True
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        secret.Visible = True
    End Sub
End Class