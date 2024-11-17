Public Class Form4

    Public Datos As String = Application.StartupPath & "\COCHES.txt"
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Public Sub GrabarDatosFichero()


    End Sub


End Class