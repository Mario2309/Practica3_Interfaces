Public Class Form2
    Dim contadorPeliculas As Integer = 1

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarContador.Text = contadorPeliculas.ToString()
        ComboBoxGenero.SelectedIndex = 0
        ComboBoxCalificacion.SelectedIndex = 0
    End Sub

    Private Async Sub MostrarMensaje()
        MessageBox.Show("No puedes crear contactos incompletos")
        Await Task.Delay(3000) ' Espera 3 segundos
        SendKeys.Send("{ESC}") ' Simula la tecla ESC para cerrar el MessageBox
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(TextBoxTitulo.Text) Or
            ComboBoxCalificacion.Text = "--" Or
            String.IsNullOrEmpty(TextBoxAutor.Text) Or
            String.IsNullOrEmpty(TextBoxAnio.Text) Or
            ComboBoxGenero.Text = "--" Then

            MostrarMensaje()

        Else

            Dim texto As New ListViewItem(contadorPeliculas.ToString())
            texto.SubItems.Add(TextBoxTitulo.Text)
            texto.SubItems.Add(ComboBoxCalificacion.Text)
            texto.SubItems.Add(TextBoxAutor.Text)
            texto.SubItems.Add(TextBoxAnio.Text)
            texto.SubItems.Add(ComboBoxGenero.Text)

            Form3.ListaPelis.Items.Add(texto)
            contadorPeliculas += 1
            MostrarContador.Text = contadorPeliculas.ToString()

            limpiar()
        End If
    End Sub

    Public Sub limpiar()
        Me.TextBoxTitulo.Clear()
        Me.ComboBoxCalificacion.SelectedIndex = 0
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