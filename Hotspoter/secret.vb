Public Class secret

    Private Sub secret_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = (My.Computer.Info.OSPlatform + "10cls")
    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click
        Me.Visible = False
        team.Visible = False
        claim.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyPictureBox.Location = New Point(MyPictureBox.Location.X + 1, MyPictureBox.Location.Y)
        If MyPictureBox.Location.X = 0 Then
            Timer1.Enabled = False
        End If

    End Sub
    Private Sub info_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles info.MouseHover
        info.FlatAppearance.BorderColor = Color.DeepSkyBlue
        info.ForeColor = Color.White
        info.BackColor = Color.DeepSkyBlue
    End Sub
    Private Sub info_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles info.MouseLeave
        info.FlatAppearance.BorderColor = Color.DeepSkyBlue
        info.ForeColor = Color.DeepSkyBlue
        info.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(Label5.Text)
        Button2.Text = "Copied"
    End Sub
    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.FlatAppearance.BorderColor = Color.DeepSkyBlue
        Button2.ForeColor = Color.White
        Button2.BackColor = Color.DeepSkyBlue
    End Sub
    Private Sub Button2_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.FlatAppearance.BorderColor = Color.DeepSkyBlue
        Button2.ForeColor = Color.DeepSkyBlue
        Button2.BackColor = Color.Transparent
    End Sub
End Class