<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextContador = New System.Windows.Forms.Label()
        Me.MostrarContador = New System.Windows.Forms.Label()
        Me.TextNombrePelicula = New System.Windows.Forms.Label()
        Me.TextNombreAutor = New System.Windows.Forms.Label()
        Me.TextAnioLanzamiento = New System.Windows.Forms.Label()
        Me.TextGenero = New System.Windows.Forms.Label()
        Me.TxtCalificacion = New System.Windows.Forms.Label()
        Me.ListaPelis = New System.Windows.Forms.ListView()
        Me.Contador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Calificacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Autor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AnioLanzamiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBoxTitulo = New System.Windows.Forms.TextBox()
        Me.TextBoxCalificacion = New System.Windows.Forms.TextBox()
        Me.TextBoxAutor = New System.Windows.Forms.TextBox()
        Me.TextBoxAnio = New System.Windows.Forms.TextBox()
        Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgreGenero = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextContador
        '
        Me.TextContador.AutoSize = True
        Me.TextContador.Location = New System.Drawing.Point(74, 47)
        Me.TextContador.Name = "TextContador"
        Me.TextContador.Size = New System.Drawing.Size(56, 13)
        Me.TextContador.TabIndex = 0
        Me.TextContador.Text = "Contador: "
        '
        'MostrarContador
        '
        Me.MostrarContador.AutoSize = True
        Me.MostrarContador.Location = New System.Drawing.Point(136, 47)
        Me.MostrarContador.Name = "MostrarContador"
        Me.MostrarContador.Size = New System.Drawing.Size(10, 13)
        Me.MostrarContador.TabIndex = 1
        Me.MostrarContador.Text = "-"
        '
        'TextNombrePelicula
        '
        Me.TextNombrePelicula.AutoSize = True
        Me.TextNombrePelicula.Location = New System.Drawing.Point(269, 47)
        Me.TextNombrePelicula.Name = "TextNombrePelicula"
        Me.TextNombrePelicula.Size = New System.Drawing.Size(79, 13)
        Me.TextNombrePelicula.TabIndex = 2
        Me.TextNombrePelicula.Text = "Titulo Pelicula :"
        '
        'TextNombreAutor
        '
        Me.TextNombreAutor.AutoSize = True
        Me.TextNombreAutor.Location = New System.Drawing.Point(273, 83)
        Me.TextNombreAutor.Name = "TextNombreAutor"
        Me.TextNombreAutor.Size = New System.Drawing.Size(75, 13)
        Me.TextNombreAutor.TabIndex = 3
        Me.TextNombreAutor.Text = "Nombre Autor:"
        '
        'TextAnioLanzamiento
        '
        Me.TextAnioLanzamiento.AutoSize = True
        Me.TextAnioLanzamiento.Location = New System.Drawing.Point(38, 121)
        Me.TextAnioLanzamiento.Name = "TextAnioLanzamiento"
        Me.TextAnioLanzamiento.Size = New System.Drawing.Size(92, 13)
        Me.TextAnioLanzamiento.TabIndex = 4
        Me.TextAnioLanzamiento.Text = "Año Lanzamiento:"
        '
        'TextGenero
        '
        Me.TextGenero.AutoSize = True
        Me.TextGenero.Location = New System.Drawing.Point(300, 121)
        Me.TextGenero.Name = "TextGenero"
        Me.TextGenero.Size = New System.Drawing.Size(48, 13)
        Me.TextGenero.TabIndex = 5
        Me.TextGenero.Text = "Genero :"
        '
        'TxtCalificacion
        '
        Me.TxtCalificacion.AutoSize = True
        Me.TxtCalificacion.Location = New System.Drawing.Point(63, 83)
        Me.TxtCalificacion.Name = "TxtCalificacion"
        Me.TxtCalificacion.Size = New System.Drawing.Size(67, 13)
        Me.TxtCalificacion.TabIndex = 6
        Me.TxtCalificacion.Text = "Calificación :"
        '
        'ListaPelis
        '
        Me.ListaPelis.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Contador, Me.Titulo, Me.Calificacion, Me.Autor, Me.AnioLanzamiento, Me.Genero})
        Me.ListaPelis.GridLines = True
        Me.ListaPelis.HideSelection = False
        Me.ListaPelis.Location = New System.Drawing.Point(0, 215)
        Me.ListaPelis.Name = "ListaPelis"
        Me.ListaPelis.Size = New System.Drawing.Size(525, 216)
        Me.ListaPelis.TabIndex = 7
        Me.ListaPelis.UseCompatibleStateImageBehavior = False
        Me.ListaPelis.View = System.Windows.Forms.View.Details
        '
        'Contador
        '
        Me.Contador.Text = "Contador"
        '
        'Titulo
        '
        Me.Titulo.Text = "Titulo"
        Me.Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Titulo.Width = 98
        '
        'Calificacion
        '
        Me.Calificacion.Text = "Calificacion"
        Me.Calificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Calificacion.Width = 99
        '
        'Autor
        '
        Me.Autor.Text = "Autor"
        Me.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Autor.Width = 87
        '
        'AnioLanzamiento
        '
        Me.AnioLanzamiento.Text = "Lanzamiento"
        Me.AnioLanzamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnioLanzamiento.Width = 95
        '
        'Genero
        '
        Me.Genero.Text = "Genero"
        Me.Genero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Genero.Width = 82
        '
        'TextBoxTitulo
        '
        Me.TextBoxTitulo.Location = New System.Drawing.Point(354, 44)
        Me.TextBoxTitulo.Name = "TextBoxTitulo"
        Me.TextBoxTitulo.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxTitulo.TabIndex = 8
        '
        'TextBoxCalificacion
        '
        Me.TextBoxCalificacion.Location = New System.Drawing.Point(136, 76)
        Me.TextBoxCalificacion.Name = "TextBoxCalificacion"
        Me.TextBoxCalificacion.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxCalificacion.TabIndex = 9
        '
        'TextBoxAutor
        '
        Me.TextBoxAutor.Location = New System.Drawing.Point(354, 80)
        Me.TextBoxAutor.Name = "TextBoxAutor"
        Me.TextBoxAutor.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxAutor.TabIndex = 10
        '
        'TextBoxAnio
        '
        Me.TextBoxAnio.Location = New System.Drawing.Point(136, 118)
        Me.TextBoxAnio.Name = "TextBoxAnio"
        Me.TextBoxAnio.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxAnio.TabIndex = 11
        '
        'ComboBoxGenero
        '
        Me.ComboBoxGenero.FormattingEnabled = True
        Me.ComboBoxGenero.Items.AddRange(New Object() {"--", "Terror"})
        Me.ComboBoxGenero.Location = New System.Drawing.Point(354, 118)
        Me.ComboBoxGenero.Name = "ComboBoxGenero"
        Me.ComboBoxGenero.Size = New System.Drawing.Size(123, 21)
        Me.ComboBoxGenero.TabIndex = 12
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(36, 161)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 32)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(153, 161)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 32)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgreGenero
        '
        Me.btnAgreGenero.Location = New System.Drawing.Point(276, 161)
        Me.btnAgreGenero.Name = "btnAgreGenero"
        Me.btnAgreGenero.Size = New System.Drawing.Size(94, 32)
        Me.btnAgreGenero.TabIndex = 15
        Me.btnAgreGenero.Text = "Agregar Genero"
        Me.btnAgreGenero.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(400, 161)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 32)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 431)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgreGenero)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.ComboBoxGenero)
        Me.Controls.Add(Me.TextBoxAnio)
        Me.Controls.Add(Me.TextBoxAutor)
        Me.Controls.Add(Me.TextBoxCalificacion)
        Me.Controls.Add(Me.TextBoxTitulo)
        Me.Controls.Add(Me.ListaPelis)
        Me.Controls.Add(Me.TxtCalificacion)
        Me.Controls.Add(Me.TextGenero)
        Me.Controls.Add(Me.TextAnioLanzamiento)
        Me.Controls.Add(Me.TextNombreAutor)
        Me.Controls.Add(Me.TextNombrePelicula)
        Me.Controls.Add(Me.MostrarContador)
        Me.Controls.Add(Me.TextContador)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextContador As Label
    Friend WithEvents MostrarContador As Label
    Friend WithEvents TextNombrePelicula As Label
    Friend WithEvents TextNombreAutor As Label
    Friend WithEvents TextAnioLanzamiento As Label
    Friend WithEvents TextGenero As Label
    Friend WithEvents TxtCalificacion As Label
    Friend WithEvents ListaPelis As ListView
    Friend WithEvents Contador As ColumnHeader
    Friend WithEvents Titulo As ColumnHeader
    Friend WithEvents Calificacion As ColumnHeader
    Friend WithEvents Autor As ColumnHeader
    Friend WithEvents AnioLanzamiento As ColumnHeader
    Friend WithEvents Genero As ColumnHeader
    Friend WithEvents TextBoxTitulo As TextBox
    Friend WithEvents TextBoxCalificacion As TextBox
    Friend WithEvents TextBoxAutor As TextBox
    Friend WithEvents TextBoxAnio As TextBox
    Friend WithEvents ComboBoxGenero As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgreGenero As Button
    Friend WithEvents btnSalir As Button
End Class
