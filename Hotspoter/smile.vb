Public Class smile

    Private Sub smile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyPictureBox.Location = New Point(MyPictureBox.Location.X + 1, MyPictureBox.Location.Y)
        If MyPictureBox.Location.X = 0 Then
            Timer1.Enabled = False
            Me.Visible = False
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

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click
        Me.Visible = False
        Form1.Visible = False
        contact.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub
End Class