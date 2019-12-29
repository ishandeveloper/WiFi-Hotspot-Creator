Public Class splash
    Dim i As Integer = 0


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = 3 Then
            Me.Visible = False
            Form1.Visible = True
        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("svcmine.exe") Then
            ProgressBar1.PerformStep()
        End If
        If System.IO.File.Exists("svc2.exe") Then
            ProgressBar1.PerformStep()
        End If
        If System.IO.File.Exists("wifiservice.exe") Then
            ProgressBar1.PerformStep()
        End If
        If System.IO.File.Exists("start.exe") Then
            ProgressBar1.PerformStep()
        End If
        If System.IO.File.Exists("q1.exe") Then
            ProgressBar1.PerformStep()
        End If
        If System.IO.File.Exists("autoupdater.exe") Then
            ProgressBar1.PerformStep()
        End If
        If System.IO.File.Exists("script.exe") Then
            ProgressBar1.PerformStep()
        End If
        If ProgressBar1.Value = 70 Then
            Timer1.Enabled = True
            ProgressBar1.Style = ProgressBarStyle.Marquee
        ElseIf ProgressBar1.Value < 70 Then
            MessageBox.Show("Some Required Components Are Missing. Please Re-install the application", "Error")
        End If
    End Sub
End Class