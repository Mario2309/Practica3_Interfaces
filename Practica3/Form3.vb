Public Class Form3

    Public ListaPeliculas As String = Application.StartupPath & "\PELICULAS.txt"
    Private Sub ListaPelis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPelis.SelectedIndexChanged
        Dim indexes As ListView.SelectedIndexCollection = Me.ListaPelis.SelectedIndices
        For Each index As Integer In indexes
            Form2.MostrarContador.Text = Me.ListaPelis.Items(index).Text
            Form2.TextBoxTitulo.Text = Me.ListaPelis.Items(index).SubItems(1).Text
            Form2.ComboBoxCalificacion.Text = Me.ListaPelis.Items(index).SubItems(2).Text
            Form2.TextBoxAutor.Text = Me.ListaPelis.Items(index).SubItems(3).Text
            Form2.TextBoxAnio.Text = Me.ListaPelis.Items(index).SubItems(4).Text
            Form2.ComboBoxGenero.Text = Me.ListaPelis.Items(index).SubItems(5).Text
        Next
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form2.Show()
    End Sub


End Class