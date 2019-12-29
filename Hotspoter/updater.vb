Imports System.Net
Public Class updater
    Dim link As String
    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filename As String = Application.StartupPath + "\update.txt"


        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try
            ' Make a WebClient.
            Dim web_client As WebClient = New WebClient

            ' Download the file.
            web_client.DownloadFile("http://hotspotteam.tk/hotspot/update.txt", filename)


        Catch ex As Exception
            MessageBox.Show("We were unable to establish a connection with the server.", "Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Label3.Text = "Can`t Check For Update !"
            PictureBox1.Image = My.Resources.oh

        End Try
        If System.IO.File.Exists(filename) = True Then

            Label3.Text = System.IO.File.ReadAllText(filename)
            If Label3.Text = ("Your Version Is Up To Date !") Then
                PictureBox1.Image = My.Resources.ok
                Button5.Enabled = False
            Else
                PictureBox1.Image = My.Resources.oh
                Button5.Enabled = True
            End If
            System.IO.File.Delete(filename)
        End If
        Me.Cursor = Cursors.Default

        Dim filename2 As String = Application.StartupPath + "\link.txt"



        Application.DoEvents()

        Try
            ' Make a WebClient.
            Dim web_client As WebClient = New WebClient

            ' Download the file.
            web_client.DownloadFile("http://hotspotteam.tk/hotspot/link.txt", filename2)


        Catch ex As Exception
            '     MessageBox.Show(ex.Message, "Download Error", _
            '        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Label3.Text = "Can`t Check For Update !"
            PictureBox1.Image = My.Resources.oh

        End Try
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        smile.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("autoupdater.exe")
        Application.Exit()
    End Sub
End Class