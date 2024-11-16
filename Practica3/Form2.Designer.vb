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
        Me.TextBoxTitulo = New System.Windows.Forms.TextBox()
        Me.TextBoxAutor = New System.Windows.Forms.TextBox()
        Me.TextBoxAnio = New System.Windows.Forms.TextBox()
        Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgreGenero = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.ComboBoxCalificacion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextContador
        '
        Me.TextContador.AutoSize = True
        Me.TextContador.Location = New System.Drawing.Point(71, 40)
        Me.TextContador.Name = "TextContador"
        Me.TextContador.Size = New System.Drawing.Size(56, 13)
        Me.TextContador.TabIndex = 0
        Me.TextContador.Text = "Contador: "
        '
        'MostrarContador
        '
        Me.MostrarContador.AutoSize = True
        Me.MostrarContador.Location = New System.Drawing.Point(133, 40)
        Me.MostrarContador.Name = "MostrarContador"
        Me.MostrarContador.Size = New System.Drawing.Size(10, 13)
        Me.MostrarContador.TabIndex = 1
        Me.MostrarContador.Text = "-"
        '
        'TextNombrePelicula
        '
        Me.TextNombrePelicula.AutoSize = True
        Me.TextNombrePelicula.Location = New System.Drawing.Point(266, 40)
        Me.TextNombrePelicula.Name = "TextNombrePelicula"
        Me.TextNombrePelicula.Size = New System.Drawing.Size(79, 13)
        Me.TextNombrePelicula.TabIndex = 2
        Me.TextNombrePelicula.Text = "Titulo Pelicula :"
        '
        'TextNombreAutor
        '
        Me.TextNombreAutor.AutoSize = True
        Me.TextNombreAutor.Location = New System.Drawing.Point(270, 76)
        Me.TextNombreAutor.Name = "TextNombreAutor"
        Me.TextNombreAutor.Size = New System.Drawing.Size(75, 13)
        Me.TextNombreAutor.TabIndex = 3
        Me.TextNombreAutor.Text = "Nombre Autor:"
        '
        'TextAnioLanzamiento
        '
        Me.TextAnioLanzamiento.AutoSize = True
        Me.TextAnioLanzamiento.Location = New System.Drawing.Point(35, 114)
        Me.TextAnioLanzamiento.Name = "TextAnioLanzamiento"
        Me.TextAnioLanzamiento.Size = New System.Drawing.Size(92, 13)
        Me.TextAnioLanzamiento.TabIndex = 4
        Me.TextAnioLanzamiento.Text = "Año Lanzamiento:"
        '
        'TextGenero
        '
        Me.TextGenero.AutoSize = True
        Me.TextGenero.Location = New System.Drawing.Point(297, 114)
        Me.TextGenero.Name = "TextGenero"
        Me.TextGenero.Size = New System.Drawing.Size(48, 13)
        Me.TextGenero.TabIndex = 5
        Me.TextGenero.Text = "Genero :"
        '
        'TxtCalificacion
        '
        Me.TxtCalificacion.AutoSize = True
        Me.TxtCalificacion.Location = New System.Drawing.Point(60, 76)
        Me.TxtCalificacion.Name = "TxtCalificacion"
        Me.TxtCalificacion.Size = New System.Drawing.Size(67, 13)
        Me.TxtCalificacion.TabIndex = 6
        Me.TxtCalificacion.Text = "Calificación :"
        '
        'TextBoxTitulo
        '
        Me.TextBoxTitulo.Location = New System.Drawing.Point(351, 37)
        Me.TextBoxTitulo.Name = "TextBoxTitulo"
        Me.TextBoxTitulo.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxTitulo.TabIndex = 8
        '
        'TextBoxAutor
        '
        Me.TextBoxAutor.Location = New System.Drawing.Point(351, 73)
        Me.TextBoxAutor.Name = "TextBoxAutor"
        Me.TextBoxAutor.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxAutor.TabIndex = 10
        '
        'TextBoxAnio
        '
        Me.TextBoxAnio.Location = New System.Drawing.Point(133, 111)
        Me.TextBoxAnio.Name = "TextBoxAnio"
        Me.TextBoxAnio.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxAnio.TabIndex = 11
        '
        'ComboBoxGenero
        '
        Me.ComboBoxGenero.FormattingEnabled = True
        Me.ComboBoxGenero.Items.AddRange(New Object() {"--", "Terror"})
        Me.ComboBoxGenero.Location = New System.Drawing.Point(351, 111)
        Me.ComboBoxGenero.Name = "ComboBoxGenero"
        Me.ComboBoxGenero.Size = New System.Drawing.Size(123, 21)
        Me.ComboBoxGenero.TabIndex = 12
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(18, 161)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 32)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(118, 161)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 32)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgreGenero
        '
        Me.btnAgreGenero.Location = New System.Drawing.Point(318, 161)
        Me.btnAgreGenero.Name = "btnAgreGenero"
        Me.btnAgreGenero.Size = New System.Drawing.Size(94, 32)
        Me.btnAgreGenero.TabIndex = 15
        Me.btnAgreGenero.Text = "Agregar Genero"
        Me.btnAgreGenero.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(418, 161)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 32)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(218, 161)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 32)
        Me.btnConsultar.TabIndex = 17
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'ComboBoxCalificacion
        '
        Me.ComboBoxCalificacion.FormattingEnabled = True
        Me.ComboBoxCalificacion.Items.AddRange(New Object() {"--", "⁜", "⁜⁜", "⁜⁜⁜", "⁜⁜⁜⁜", "⁜⁜⁜⁜⁜"})
        Me.ComboBoxCalificacion.Location = New System.Drawing.Point(133, 73)
        Me.ComboBoxCalificacion.Name = "ComboBoxCalificacion"
        Me.ComboBoxCalificacion.Size = New System.Drawing.Size(123, 21)
        Me.ComboBoxCalificacion.TabIndex = 18
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 209)
        Me.Controls.Add(Me.ComboBoxCalificacion)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgreGenero)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.ComboBoxGenero)
        Me.Controls.Add(Me.TextBoxAnio)
        Me.Controls.Add(Me.TextBoxAutor)
        Me.Controls.Add(Me.TextBoxTitulo)
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
    Friend WithEvents TextBoxTitulo As TextBox
    Friend WithEvents TextBoxAutor As TextBox
    Friend WithEvents TextBoxAnio As TextBox
    Friend WithEvents ComboBoxGenero As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgreGenero As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents ComboBoxCalificacion As ComboBox
End Class
