Public Class Main
    Dim Drink As String
    Dim DrinkCount As Integer = 0
    Private Sub Main_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Helping.ShowDialog()
        My.Computer.Audio.Play(My.Resources.WorkPlaceGroovesHitLikeAndSmashSubscribeIfYouAgree, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        MessageBox.Show("Do NOT Try To Get Rid Of Me..." + Environment.NewLine + "You Still Need More Drinks" + Environment.NewLine + "If You Need Help, Get Help From The Assistance ...........", "WoW ......")
    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelperButton.Click
        MessageBox.Show("Ye Me Too ............................................", "Helping The Poor Souls ..")
        Helping.ShowDialog()
        My.Computer.Audio.Play(My.Resources.WorkPlaceGroovesHitLikeAndSmashSubscribeIfYouAgree, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MilkButton.Click, WaterButton.Click, BeverageButton.Click, CoffeeButton.Click, OrangeButton.Click
        DrinkCount = DrinkCount + 1

        If DrinkCount > 5 Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            BrokenDrinks.Show()
        Else
            DispensingPleaseWait.ShowDialog()
            My.Computer.Audio.Play(My.Resources.WorkPlaceGroovesHitLikeAndSmashSubscribeIfYouAgree, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.WorkPlaceGroovesHitLikeAndSmashSubscribeIfYouAgree, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub WeLoveDrinks_Tick(sender As Object, e As EventArgs) Handles WeLoveDrinks.Tick
        If DrinkCount <= 5 And DrinkCount > 0 Then
            DrinkCount -= 1
        End If
    End Sub
End Class
