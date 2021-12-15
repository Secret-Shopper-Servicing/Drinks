Public Class Main

    Private Sub Main_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Helping.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        MessageBox.Show("Do NOT Try To Get Rid Of Me..." + Environment.NewLine + "You Still Need More Drinks" + Environment.NewLine + "If You Need Help, Get Help From The Assistance ...........", "WoW ......")
    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelperButton.Click
        MessageBox.Show("Ye Me Too ............................................", "Helping The Poor Souls ..")
        Helping.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MilkButton.Click

    End Sub
End Class
