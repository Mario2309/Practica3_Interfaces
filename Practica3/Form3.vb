Imports Microsoft.VisualBasic.FileIO

Public Class Form3

    Public ListaPeliculas As String = Application.StartupPath & "\PELICULAS.txt"

    Private Async Sub MostrarMensaje()
        MessageBox.Show("Ocurrio un error al importar las peliculas")
        Await Task.Delay(3000)
        SendKeys.Send("{ESC}")
    End Sub

    Public Sub ListaPelis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPelis.SelectedIndexChanged
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

    Public Sub GuardarPeliculas()
        For Each contenido As ListViewItem In ListaPelis.Items
            Dim linea As String = String.Join("#",
                                                contenido.SubItems(0).Text,
                                                contenido.SubItems(1).Text,
                                                contenido.SubItems(2).Text,
                                                contenido.SubItems(3).Text,
                                                contenido.SubItems(4).Text,
                                                contenido.SubItems(5).Text
                                            )
            My.Computer.FileSystem.WriteAllText(ListaPeliculas, linea & vbCrLf, True)
        Next
    End Sub

    Public Sub CargarPeliculas()
        If My.Computer.FileSystem.FileExists(ListaPeliculas) Then
            Dim fichero As String = ListaPeliculas
            Dim campos As String()
            Dim indice As Integer
            Dim delimitador As String = "#"
            ListaPelis.Items.Clear()

            Using Analizador_sintactico As New TextFieldParser(ListaPeliculas)
                Analizador_sintactico.SetDelimiters(delimitador)
                While Not Analizador_sintactico.EndOfData
                    campos = Analizador_sintactico.ReadFields()

                    If campos.Length >= 6 Then
                        Dim item As New ListViewItem(campos(0))
                        item.SubItems.Add(campos(1))
                        item.SubItems.Add(campos(2))
                        item.SubItems.Add(campos(3))
                        item.SubItems.Add(campos(4))
                        item.SubItems.Add(campos(5))

                        ListaPelis.Items.Add(item)
                    End If
                End While
            End Using
            My.Computer.FileSystem.DeleteFile(ListaPeliculas)
        Else
            MostrarMensaje()

        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form2.Show()
    End Sub


End Class