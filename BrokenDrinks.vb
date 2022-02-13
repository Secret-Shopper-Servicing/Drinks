Public Class BrokenDrinks
    Dim Breakages As Integer
    Dim WarnedBefore As Boolean = False
    Private Sub BrokenDrinks_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Play(My.Resources.WorkPlaceGroovesHitLikeAndSmashSubscribeIfYouAgree, AudioPlayMode.BackgroundLoop)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Breakages += 1
        Label2.Text = "NOW you broke " & Breakages & " GLASSES"
    End Sub

    Private Sub BrokenDrinks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If WarnedBefore = False Then
            Breakages = 1
        End If
        WarnedBefore = True
        My.Computer.Audio.Play(My.Resources.TooManyDrinku, AudioPlayMode.BackgroundLoop)
    End Sub
End Class