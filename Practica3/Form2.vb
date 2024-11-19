Imports Microsoft.VisualBasic.FileIO

Public Class Form2
    Dim contadorPeliculas As Integer = 1
    Public Generos As String = Application.StartupPath & "\GENEROS.txt"
    Public Peliculas As String = Application.StartupPath & "\PELICULAS.txt"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarContador.Text = contadorPeliculas.ToString()
        ComboBoxGenero.SelectedIndex = 0
        ComboBoxCalificacion.SelectedIndex = 0
        AgregarDatosGeneros()
        Form3.CargarPeliculas()
    End Sub

    Private Async Sub MostrarMensaje()
        MessageBox.Show("No puedes crear contactos incompletos")
        Await Task.Delay(3000)
        SendKeys.Send("{ESC}")
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
        GuardarGeneros()
        Form3.GuardarPeliculas()
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

    Private Sub ComboBoxGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGenero.SelectedIndexChanged

    End Sub

    Public Sub AgregarDatosGeneros()
        If My.Computer.FileSystem.FileExists(Generos) Then
            Dim Fichero_leer As String = Generos
            Dim Campos As String()

            Dim Delimitador As String = "#"
            Using Analizador_sintactico As New TextFieldParser(Fichero_leer)

                Analizador_sintactico.SetDelimiters(Delimitador)
                While Not Analizador_sintactico.EndOfData
                    Campos = Analizador_sintactico.ReadFields
                    ComboBoxGenero.Items.Add(Campos(0))
                End While
            End Using
            My.Computer.FileSystem.DeleteFile(Generos)
        End If
    End Sub

    Public Sub AgregarGeneroNuevo()
        If My.Computer.FileSystem.FileExists(Form4.Datos) Then
            Dim Fichero_Leer As String = Form4.Datos
            Dim Campos As String()

            Dim Delimitador As String = "#"
            Using Analizador_Sintactico As New TextFieldParser(Fichero_Leer)
                Analizador_Sintactico.SetDelimiters(Delimitador)
                While Not Analizador_Sintactico.EndOfData
                    Campos = Analizador_Sintactico.ReadFields
                    ComboBoxGenero.Items.Add(Campos(0))
                End While
            End Using
            My.Computer.FileSystem.DeleteFile(Form4.Datos)
        End If
    End Sub

    Private Sub GuardarGeneros()
        Dim Contador As Integer
        For Contador = 0 To ComboBoxGenero.Items.Count - 1
            My.Computer.FileSystem.WriteAllText(Generos, ComboBoxGenero.Items(Contador) & "#" & vbCrLf, True)
        Next
    End Sub
End Class