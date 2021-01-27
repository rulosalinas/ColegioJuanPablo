<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminscripciones
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
        Me.dtfpreinscripcion = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtidinscripcion = New System.Windows.Forms.TextBox()
        Me.dtfinnscripcion = New System.Windows.Forms.DateTimePicker()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtfingreso = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtlegajo = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.cbxinstitucion = New System.Windows.Forms.ComboBox()
        Me.btnbuscaralumno = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtfpreinscripcion
        '
        Me.dtfpreinscripcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfpreinscripcion.Location = New System.Drawing.Point(462, 194)
        Me.dtfpreinscripcion.Name = "dtfpreinscripcion"
        Me.dtfpreinscripcion.Size = New System.Drawing.Size(107, 20)
        Me.dtfpreinscripcion.TabIndex = 369
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(424, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 368
        Me.Label8.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(424, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 367
        Me.Label6.Text = "Seña"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(462, 229)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(107, 20)
        Me.TextBox7.TabIndex = 366
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(165, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 23)
        Me.Label5.TabIndex = 365
        Me.Label5.Text = "INSCRIPCION DE ALUMNOS"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(420, 164)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox1.TabIndex = 364
        Me.CheckBox1.Text = "Preinscripcion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtidinscripcion
        '
        Me.txtidinscripcion.Location = New System.Drawing.Point(113, 85)
        Me.txtidinscripcion.Name = "txtidinscripcion"
        Me.txtidinscripcion.Size = New System.Drawing.Size(44, 20)
        Me.txtidinscripcion.TabIndex = 337
        '
        'dtfinnscripcion
        '
        Me.dtfinnscripcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfinnscripcion.Location = New System.Drawing.Point(446, 85)
        Me.dtfinnscripcion.Name = "dtfinnscripcion"
        Me.dtfinnscripcion.Size = New System.Drawing.Size(123, 20)
        Me.dtfinnscripcion.TabIndex = 358
        Me.dtfinnscripcion.Value = New Date(2019, 9, 28, 10, 28, 0, 0)
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(96, 124)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(208, 20)
        Me.txtapellido.TabIndex = 353
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(36, 128)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(44, 13)
        Me.label9.TabIndex = 352
        Me.label9.Text = "Apellido"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 356
        Me.Label10.Text = "Carrera"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(32, 89)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 336
        Me.label7.Text = "N° Inscripcion"
        '
        'txtfingreso
        '
        Me.txtfingreso.Location = New System.Drawing.Point(469, 310)
        Me.txtfingreso.Name = "txtfingreso"
        Me.txtfingreso.Size = New System.Drawing.Size(100, 20)
        Me.txtfingreso.TabIndex = 345
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(378, 313)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(88, 13)
        Me.label14.TabIndex = 344
        Me.label14.Text = "Costo Inscripcion"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(349, 89)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(91, 13)
        Me.label20.TabIndex = 354
        Me.label20.Text = "Fecha Inscripción"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(368, 121)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(168, 20)
        Me.txtnombre.TabIndex = 335
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(321, 125)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 334
        Me.label4.Text = "Nombre"
        '
        'txtlegajo
        '
        Me.txtlegajo.Location = New System.Drawing.Point(261, 82)
        Me.txtlegajo.Name = "txtlegajo"
        Me.txtlegajo.ReadOnly = True
        Me.txtlegajo.Size = New System.Drawing.Size(57, 20)
        Me.txtlegajo.TabIndex = 333
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(201, 86)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 332
        Me.label3.Text = "Legajo"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(36, 269)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(34, 13)
        Me.label13.TabIndex = 342
        Me.label13.Text = "Curso"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(187, 269)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(44, 13)
        Me.label12.TabIndex = 340
        Me.label12.Text = "División"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(36, 165)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 13)
        Me.label2.TabIndex = 331
        Me.label2.Text = "Institución"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(36, 204)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(31, 13)
        Me.label11.TabIndex = 338
        Me.label11.Text = "Nivel"
        '
        'cbxinstitucion
        '
        Me.cbxinstitucion.FormattingEnabled = True
        Me.cbxinstitucion.Location = New System.Drawing.Point(96, 164)
        Me.cbxinstitucion.Name = "cbxinstitucion"
        Me.cbxinstitucion.Size = New System.Drawing.Size(295, 21)
        Me.cbxinstitucion.TabIndex = 330
        '
        'btnbuscaralumno
        '
        Me.btnbuscaralumno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnbuscaralumno.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.find_users_applications_search_29081
        Me.btnbuscaralumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscaralumno.Image = Global.Sistema_CECULD.My.Resources.Resources.find_users_applications_search_2908
        Me.btnbuscaralumno.Location = New System.Drawing.Point(545, 118)
        Me.btnbuscaralumno.Name = "btnbuscaralumno"
        Me.btnbuscaralumno.Size = New System.Drawing.Size(26, 23)
        Me.btnbuscaralumno.TabIndex = 370
        Me.btnbuscaralumno.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.CECULD2
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(452, 375)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(119, 81)
        Me.pictureBox2.TabIndex = 351
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(15, 375)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 80)
        Me.pictureBox1.TabIndex = 350
        Me.pictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 201)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(295, 21)
        Me.ComboBox1.TabIndex = 371
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(96, 229)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(295, 21)
        Me.ComboBox2.TabIndex = 372
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(96, 263)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(68, 21)
        Me.ComboBox3.TabIndex = 373
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(237, 266)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox4.TabIndex = 374
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(215, 375)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 521
        Me.btnguardaralta.UseVisualStyleBackColor = True
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(221, 395)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 523
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(221, 395)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 522
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Location = New System.Drawing.Point(368, 395)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(60, 60)
        Me.btnSalir.TabIndex = 520
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cancelar
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrar.Location = New System.Drawing.Point(293, 395)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(60, 60)
        Me.btnBorrar.TabIndex = 519
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNuevo.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Agregar
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Location = New System.Drawing.Point(149, 395)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 60)
        Me.btnNuevo.TabIndex = 518
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'frminscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 486)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnbuscaralumno)
        Me.Controls.Add(Me.dtfpreinscripcion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtidinscripcion)
        Me.Controls.Add(Me.dtfinnscripcion)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtfingreso)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtlegajo)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.cbxinstitucion)
        Me.Name = "frminscripciones"
        Me.Text = "Inscripciones"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfpreinscripcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Private WithEvents txtidinscripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtfinnscripcion As System.Windows.Forms.DateTimePicker
    Private WithEvents txtapellido As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txtfingreso As System.Windows.Forms.TextBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label20 As System.Windows.Forms.Label
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents txtnombre As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtlegajo As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents cbxinstitucion As System.Windows.Forms.ComboBox
    Friend WithEvents btnbuscaralumno As System.Windows.Forms.Button
    Private WithEvents ComboBox1 As ComboBox
    Private WithEvents ComboBox2 As ComboBox
    Private WithEvents ComboBox3 As ComboBox
    Private WithEvents ComboBox4 As ComboBox
    Private WithEvents btnguardaralta As Button
    Private WithEvents btnguardaredicion As Button
    Private WithEvents btnguardarbaja As Button
    Private WithEvents btnSalir As Button
    Private WithEvents btnBorrar As Button
    Private WithEvents btnNuevo As Button
End Class
