Public Class Form2
    Dim contadorPeliculas As Integer = 1

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarContador.Text = contadorPeliculas.ToString()
        ComboBoxGenero.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim texto As New ListViewItem(MostrarContador.ToString())
        texto.SubItems.Add(TextBoxTitulo.Text)
        texto.SubItems.Add(TextBoxCalificacion.Text)
        texto.SubItems.Add(TextBoxCalificacion.Text)
        texto.SubItems.Add(TextBoxAutor.Text)
        texto.SubItems.Add(TextAnioLanzamiento.Text)
        texto.SubItems.Add(ComboBoxGenero.Text)

        Form3.ListaPelis.Items.Add(texto)
        contadorPeliculas += 1
        MostrarContador.Text = contadorPeliculas.ToString()
    End Sub

    Public Sub limpiar()
        Me.TextBoxTitulo.Clear()
        Me.TextBoxCalificacion.Clear()
        Me.TextBoxAutor.Clear()
        Me.TextBoxAnio.Clear()
        Me.ComboBoxGenero.SelectedIndex = 0
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        limpiar()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnAgreGenero_Click(sender As Object, e As EventArgs) Handles btnAgreGenero.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class