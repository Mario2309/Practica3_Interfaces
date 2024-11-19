Public Class Form1

    Dim count As Integer

    Private Sub IrForm2_Click(sender As Object, e As EventArgs) Handles IrForm2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count = count + 1
        If count = 20 Then
            avanzarInactividad()
        End If
    End Sub

    Private Sub avanzarInactividad()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Async Sub MostrarMensaje()
        MessageBox.Show("Se avanzo al formulario dada tu inactividad")
        Await Task.Delay(5000)
        SendKeys.Send("{ESC}")
    End Sub
End Class
