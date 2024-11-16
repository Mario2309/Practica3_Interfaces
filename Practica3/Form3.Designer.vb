<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ListaPelis = New System.Windows.Forms.ListView()
        Me.Contador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Calificacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Autor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AnioLanzamiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListaPelis
        '
        Me.ListaPelis.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Contador, Me.Titulo, Me.Calificacion, Me.Autor, Me.AnioLanzamiento, Me.Genero})
        Me.ListaPelis.GridLines = True
        Me.ListaPelis.HideSelection = False
        Me.ListaPelis.Location = New System.Drawing.Point(1, 80)
        Me.ListaPelis.Name = "ListaPelis"
        Me.ListaPelis.Size = New System.Drawing.Size(525, 216)
        Me.ListaPelis.TabIndex = 8
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
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(421, 21)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(94, 32)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = True
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 29)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(396, 15)
        Me.txtDescripcion.TabIndex = 15
        Me.txtDescripcion.Text = "Estas son las peliculas que hay, para modificar alguna haz clic en ellas."
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 296)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.ListaPelis)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaPelis As ListView
    Friend WithEvents Contador As ColumnHeader
    Friend WithEvents Titulo As ColumnHeader
    Friend WithEvents Calificacion As ColumnHeader
    Friend WithEvents Autor As ColumnHeader
    Friend WithEvents AnioLanzamiento As ColumnHeader
    Friend WithEvents Genero As ColumnHeader
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtDescripcion As Label
End Class
