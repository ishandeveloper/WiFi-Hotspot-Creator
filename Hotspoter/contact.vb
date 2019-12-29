
Public Class contact
    Dim i As Integer = 0
    Private Sub contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = False Then
            PictureBox7.Image = My.Resources.oh
            Label2.Text = "Can`t Connect To The Server"
            WebBrowser1.Visible = False
        ElseIf My.Computer.Network.IsAvailable = True Then

            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub
   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = 3 Then
            WebBrowser1.Visible = True
            PictureBox7.Visible = False
            Label2.Visible = False
        End If
    End Sub
    Private Sub Button5_hover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.BackgroundImage = My.Resources.hover
    End Sub
    Private Sub Button5_leave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackgroundImage = My.Resources.leave
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        smile.Visible = True

    End Sub
End Class