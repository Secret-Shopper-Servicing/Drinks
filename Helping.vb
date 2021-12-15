Public Class Helping
    Dim optio As Integer

    Private Sub Helping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.Helping, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        optio = Int((5 * Rnd()) + 1)
        TextBox1.Text = "Item Number " + Str(optio)
    End Sub
End Class