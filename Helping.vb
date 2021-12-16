Public Class Helping
    Dim optio As Integer

    Private Sub Helping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.Helping, AudioPlayMode.WaitToComplete)
        Button2.Enabled = False
        My.Computer.Audio.Play(My.Resources.BaristaLady, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case Int((5 * Rnd()) + 1)
            Case 1
                TextBox1.Text = "Try Walter"
            Case 2
                TextBox1.Text = "Malk is Good"
            Case 3
                TextBox1.Text = "Cophie"
            Case 4
                TextBox1.Text = "YumYum OrangeL"
            Case 5
                TextBox1.Text = "Beverage Nice"
        End Select
        My.Computer.Audio.Play(My.Resources.Helping, AudioPlayMode.WaitToComplete)
        Button2.Enabled = True
        My.Computer.Audio.Play(My.Resources.BaristaLady, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DispensingPleaseWait.ShowDialog()
        Me.Close()
    End Sub
End Class