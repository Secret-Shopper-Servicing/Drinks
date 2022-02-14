Public Class DispensingPleaseWait


    Private Sub DispensingPleaseWait_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ProgressBar1.Value = 0
        O.Enabled = True
        My.Computer.Audio.Play(My.Resources.UserFOlder, AudioPlayMode.Background)
    End Sub

    Private Sub O_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O.Tick
        If Not ProgressBar1.Value = 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
        Else
            O.Enabled = False
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            If Me.Visible = True Then
                MessageBox.Show("Lovely", "MMM")
                My.Computer.Audio.Play(My.Resources.MMM, AudioPlayMode.WaitToComplete)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub DispensingPleaseWait_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class