Public Class Form4

    Public Datos As String = Application.StartupPath & "\GenerosNuevos.txt"
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Public Sub GrabarDatosFichero(textBoxNombreGen As TextBox)
        Dim contador As Integer
        For contador = 0 To Form2.ComboBoxGenero.Items.Count - 1
            My.Computer.FileSystem.WriteAllText(Datos, textBoxNombreGen.ToString() & "#", True)
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        GrabarDatosFichero(TextBoxNombreGen)
        Form2.AgregarGeneroNuevo()
        Me.Hide()
        Form2.Show()
    End Sub
End Class