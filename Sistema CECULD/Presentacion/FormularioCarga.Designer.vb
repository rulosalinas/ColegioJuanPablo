<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCarga
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
        Me.Division = New System.Windows.Forms.Label()
        Me.cbxdivision = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxcurso = New System.Windows.Forms.ComboBox()
        Me.cbxcarrera = New System.Windows.Forms.ComboBox()
        Me.cbxnivel = New System.Windows.Forms.ComboBox()
        Me.cbxinstitucion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Division
        '
        Me.Division.AutoSize = True
        Me.Division.Location = New System.Drawing.Point(26, 246)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(44, 13)
        Me.Division.TabIndex = 19
        Me.Division.Text = "Division"
        '
        'cbxdivision
        '
        Me.cbxdivision.FormattingEnabled = True
        Me.cbxdivision.Location = New System.Drawing.Point(121, 243)
        Me.cbxdivision.Name = "cbxdivision"
        Me.cbxdivision.Size = New System.Drawing.Size(174, 21)
        Me.cbxdivision.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Curso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Carrera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nivel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Institucion"
        '
        'cbxcurso
        '
        Me.cbxcurso.FormattingEnabled = True
        Me.cbxcurso.Location = New System.Drawing.Point(121, 196)
        Me.cbxcurso.Name = "cbxcurso"
        Me.cbxcurso.Size = New System.Drawing.Size(174, 21)
        Me.cbxcurso.TabIndex = 13
        '
        'cbxcarrera
        '
        Me.cbxcarrera.FormattingEnabled = True
        Me.cbxcarrera.Location = New System.Drawing.Point(121, 145)
        Me.cbxcarrera.Name = "cbxcarrera"
        Me.cbxcarrera.Size = New System.Drawing.Size(174, 21)
        Me.cbxcarrera.TabIndex = 12
        '
        'cbxnivel
        '
        Me.cbxnivel.FormattingEnabled = True
        Me.cbxnivel.Location = New System.Drawing.Point(121, 99)
        Me.cbxnivel.Name = "cbxnivel"
        Me.cbxnivel.Size = New System.Drawing.Size(174, 21)
        Me.cbxnivel.TabIndex = 11
        '
        'cbxinstitucion
        '
        Me.cbxinstitucion.FormattingEnabled = True
        Me.cbxinstitucion.Location = New System.Drawing.Point(121, 49)
        Me.cbxinstitucion.Name = "cbxinstitucion"
        Me.cbxinstitucion.Size = New System.Drawing.Size(174, 21)
        Me.cbxinstitucion.TabIndex = 10
        '
        'FormularioCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 356)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.cbxdivision)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxcurso)
        Me.Controls.Add(Me.cbxcarrera)
        Me.Controls.Add(Me.cbxnivel)
        Me.Controls.Add(Me.cbxinstitucion)
        Me.Name = "FormularioCarga"
        Me.Text = "FormularioCarga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Division As System.Windows.Forms.Label
    Friend WithEvents cbxdivision As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxcurso As System.Windows.Forms.ComboBox
    Friend WithEvents cbxcarrera As System.Windows.Forms.ComboBox
    Friend WithEvents cbxnivel As System.Windows.Forms.ComboBox
    Friend WithEvents cbxinstitucion As System.Windows.Forms.ComboBox
End Class
