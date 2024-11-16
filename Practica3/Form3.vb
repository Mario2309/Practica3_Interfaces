Public Class Form3
    Private Sub ListaPelis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPelis.SelectedIndexChanged
        Dim indexes As ListView.SelectedIndexCollection = Me.ListaPelis.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            Form2.MostrarContador.Text = Me.ListaPelis.Items(index).Text
            Form2.TextBoxTitulo.Text = Me.ListaPelis.Items(index).SubItems(1).Text
            Form2.TextBoxCalificacion.Text = Me.ListaPelis.Items(index).SubItems(2).Text
            Form2.TextBoxAutor.Text = Me.ListaPelis.Items(index).SubItems(3).Text
            Form2.TextAnioLanzamiento.Text = Me.ListaPelis.Items(index).SubItems(4).ToString()

            Form2.limpiar()
        Next
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class