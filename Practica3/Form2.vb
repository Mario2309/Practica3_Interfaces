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

        ListaPelis.Items.Add(texto)
        contadorPeliculas += 1
        MostrarContador.Text = contadorPeliculas.ToString()
    End Sub

    Private Sub ListaPelis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPelis.SelectedIndexChanged
        Dim indexes As ListView.SelectedIndexCollection = Me.ListaPelis.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            MostrarContador.Text = Me.ListaPelis.Items(index).Text
            Me.TextBoxTitulo.Text = Me.ListaPelis.Items(index).SubItems(1).Text
            Me.TextBoxCalificacion.Text = Me.ListaPelis.Items(index).SubItems(2).Text
            Me.TextBoxAutor.Text = Me.ListaPelis.Items(index).SubItems(3).Text
            Me.TextAnioLanzamiento.Text = Me.ListaPelis.Items(index).SubItems(4).ToString()

            limpiar()
        Next

    End Sub

    Private Sub limpiar()
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
End Class