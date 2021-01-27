Public Class Inicio

    Private Sub progressBar1_Click(sender As Object, e As EventArgs) Handles progressBar1.Click
        progressBar1.Value = 0
        progressBar1.Maximum = 100
        timer1.Interval = 40
        timer1.Enabled = True
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If progressBar1.Value < 100 Then
            progressBar1.Value = progressBar1.Value + 1
            Label2.Text = "Cargando el sistema al " & progressBar1.Value & "%"

        Else
            timer1.Enabled = False
            Me.Hide()
            Login.Show()
        End If

    End Sub
End Class
