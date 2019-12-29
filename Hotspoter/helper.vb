Public Class helper

    Private Sub helper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button5_hover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.BackgroundImage = My.Resources.hover
    End Sub
    Private Sub Button5_leave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackgroundImage = My.Resources.leave
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button6.Click

        smile.Visible = True
    End Sub
End Class