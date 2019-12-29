Public Class information
    Dim i As Integer
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
    Private Sub info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.Start("q1.exe")

        Try
            If My.Computer.FileSystem.FileExists("C:\log.txt") = True Then
                Dim fileReader As String
                fileReader = My.Computer.FileSystem.ReadAllText("C:\log.txt")
                Label1.Visible = True
                Label3.Visible = False
                Label1.Text = (fileReader)
                Button5.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Wi-Fi Hotspot Creator")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("q1.exe")
        Label1.Visible = False
        Label3.Visible = True
        Button5.Enabled = False
        i = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label3.Text = "Working On It..." Then
            Label3.Text = "Working On It"
        ElseIf Label3.Text = "Working On It" Then
            Label3.Text = "Working On It."
        ElseIf Label3.Text = "Working On It." Then
            Label3.Text = "Working On It.."
        ElseIf Label3.Text = "Working On It.." Then
            Label3.Text = "Working On It..."
        End If

        If i = 3 Then
            If My.Computer.FileSystem.FileExists("C:\log.txt") = True Then
                Dim fileReader As String
                fileReader = My.Computer.FileSystem.ReadAllText("C:\log.txt")
                Label1.Visible = True
                Label3.Visible = False
                Label1.Text = (fileReader)
                Button5.Enabled = True
                Timer1.Enabled = False

            ElseIf My.Computer.FileSystem.FileExists("C:\log.txt") = False Then
                MessageBox.Show("An Unknown Error Occured. Please Try Again Later.", "Wi-Fi Hotspot Creator | Error")
                Button5.Enabled = True
                Timer1.Enabled = False
            End If
        ElseIf i < 3 Then
            i = i + 1
        ElseIf i > 3 Then
            Try
                If My.Computer.FileSystem.FileExists("C:\log.txt") = True Then
                    Dim fileReader As String
                    fileReader = My.Computer.FileSystem.ReadAllText("C:\log.txt")
                    Label1.Visible = True
                    Label3.Visible = False
                    Label1.Text = (fileReader)
                    Button5.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Wi-Fi Hotspot Creator")

            End Try
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
    Private Sub Button5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseHover
        Button5.FlatAppearance.BorderColor = Color.DeepSkyBlue
        Button5.ForeColor = Color.White
        Button5.BackColor = Color.DeepSkyBlue
    End Sub
    Private Sub Button5_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.FlatAppearance.BorderColor = Color.DeepSkyBlue
        Button5.ForeColor = Color.DeepSkyBlue
        Button5.BackColor = Color.Transparent
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        smile.Visible = True
    End Sub

End Class
