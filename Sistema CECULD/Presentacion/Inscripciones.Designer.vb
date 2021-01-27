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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbxbusqueda = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.dginscripcion = New System.Windows.Forms.DataGridView()
        Me.cbxdivision = New System.Windows.Forms.ComboBox()
        Me.cbxcurso = New System.Windows.Forms.ComboBox()
        Me.cbxcarrera = New System.Windows.Forms.ComboBox()
        Me.cbxnivel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtfinscripcion = New System.Windows.Forms.DateTimePicker()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtidinscripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.cbxinstitucion = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.button29 = New System.Windows.Forms.Button()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.btnbuscaralumno = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dginscripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Erroricono
        '
        Me.Erroricono.ContainerControl = Me
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(528, 67)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(55, 13)
        Me.Label32.TabIndex = 611
        Me.Label32.Text = "Busqueda"
        '
        'cbxbusqueda
        '
        Me.cbxbusqueda.FormattingEnabled = True
        Me.cbxbusqueda.Items.AddRange(New Object() {"DNI", "Apellido"})
        Me.cbxbusqueda.Location = New System.Drawing.Point(768, 63)
        Me.cbxbusqueda.Name = "cbxbusqueda"
        Me.cbxbusqueda.Size = New System.Drawing.Size(62, 21)
        Me.cbxbusqueda.TabIndex = 610
        Me.cbxbusqueda.Text = "DNI"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(591, 64)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(162, 20)
        Me.txtbuscar.TabIndex = 609
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(154, 105)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(88, 20)
        Me.txtdni.TabIndex = 608
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(94, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 607
        Me.Label14.Text = "DNI"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.Location = New System.Drawing.Point(358, 427)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(111, 13)
        Me.inexistente.TabIndex = 604
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistentes"
        '
        'dginscripcion
        '
        Me.dginscripcion.AllowUserToAddRows = False
        Me.dginscripcion.AllowUserToDeleteRows = False
        Me.dginscripcion.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dginscripcion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dginscripcion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dginscripcion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dginscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dginscripcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dginscripcion.Location = New System.Drawing.Point(56, 324)
        Me.dginscripcion.Name = "dginscripcion"
        Me.dginscripcion.ReadOnly = True
        Me.dginscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dginscripcion.Size = New System.Drawing.Size(775, 185)
        Me.dginscripcion.TabIndex = 603
        '
        'cbxdivision
        '
        Me.cbxdivision.FormattingEnabled = True
        Me.cbxdivision.Location = New System.Drawing.Point(342, 234)
        Me.cbxdivision.Name = "cbxdivision"
        Me.cbxdivision.Size = New System.Drawing.Size(105, 21)
        Me.cbxdivision.TabIndex = 602
        '
        'cbxcurso
        '
        Me.cbxcurso.FormattingEnabled = True
        Me.cbxcurso.Location = New System.Drawing.Point(152, 234)
        Me.cbxcurso.Name = "cbxcurso"
        Me.cbxcurso.Size = New System.Drawing.Size(103, 21)
        Me.cbxcurso.TabIndex = 601
        '
        'cbxcarrera
        '
        Me.cbxcarrera.FormattingEnabled = True
        Me.cbxcarrera.Location = New System.Drawing.Point(154, 202)
        Me.cbxcarrera.Name = "cbxcarrera"
        Me.cbxcarrera.Size = New System.Drawing.Size(295, 21)
        Me.cbxcarrera.TabIndex = 600
        '
        'cbxnivel
        '
        Me.cbxnivel.FormattingEnabled = True
        Me.cbxnivel.Location = New System.Drawing.Point(154, 175)
        Me.cbxnivel.Name = "cbxnivel"
        Me.cbxnivel.Size = New System.Drawing.Size(295, 21)
        Me.cbxnivel.TabIndex = 599
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(321, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 23)
        Me.Label5.TabIndex = 597
        Me.Label5.Text = "INSCRIPCION DE ALUMNOS"
        '
        'dtfinscripcion
        '
        Me.dtfinscripcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfinscripcion.Location = New System.Drawing.Point(189, 275)
        Me.dtfinscripcion.Name = "dtfinscripcion"
        Me.dtfinscripcion.Size = New System.Drawing.Size(123, 20)
        Me.dtfinscripcion.TabIndex = 596
        Me.dtfinscripcion.Value = New Date(2019, 9, 28, 10, 28, 0, 0)
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(313, 105)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(208, 20)
        Me.txtapellido.TabIndex = 593
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(259, 109)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(44, 13)
        Me.label9.TabIndex = 592
        Me.label9.Text = "Apellido"
        '
        'txtidinscripcion
        '
        Me.txtidinscripcion.Location = New System.Drawing.Point(171, 67)
        Me.txtidinscripcion.Name = "txtidinscripcion"
        Me.txtidinscripcion.Size = New System.Drawing.Size(44, 20)
        Me.txtidinscripcion.TabIndex = 584
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(94, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 595
        Me.Label10.Text = "Carrera"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(90, 71)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 583
        Me.label7.Text = "N° Inscripcion"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(92, 279)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(91, 13)
        Me.label20.TabIndex = 594
        Me.label20.Text = "Fecha Inscripción"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(532, 109)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 581
        Me.label4.Text = "Nombre"
        '
        'txtidalumno
        '
        Me.txtidalumno.Location = New System.Drawing.Point(313, 67)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.ReadOnly = True
        Me.txtidalumno.Size = New System.Drawing.Size(57, 20)
        Me.txtidalumno.TabIndex = 580
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(259, 71)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 579
        Me.label3.Text = "Legajo"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(579, 105)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(220, 20)
        Me.txtnombre.TabIndex = 582
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(92, 238)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(34, 13)
        Me.label13.TabIndex = 587
        Me.label13.Text = "Curso"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(292, 238)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(44, 13)
        Me.label12.TabIndex = 586
        Me.label12.Text = "División"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(94, 178)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(31, 13)
        Me.label11.TabIndex = 585
        Me.label11.Text = "Nivel"
        '
        'cbxinstitucion
        '
        Me.cbxinstitucion.FormattingEnabled = True
        Me.cbxinstitucion.Location = New System.Drawing.Point(154, 148)
        Me.cbxinstitucion.Name = "cbxinstitucion"
        Me.cbxinstitucion.Size = New System.Drawing.Size(295, 21)
        Me.cbxinstitucion.TabIndex = 577
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(94, 149)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 13)
        Me.label2.TabIndex = 578
        Me.label2.Text = "Institución"
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(504, 542)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 618
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        '
        'button29
        '
        Me.button29.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button29.Location = New System.Drawing.Point(586, 542)
        Me.button29.Name = "button29"
        Me.button29.Size = New System.Drawing.Size(60, 60)
        Me.button29.TabIndex = 616
        Me.button29.UseVisualStyleBackColor = True
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cancelar
        Me.btnbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbaja.Location = New System.Drawing.Point(417, 542)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnbaja.TabIndex = 615
        Me.btnbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(504, 542)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 614
        Me.btnguardaralta.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.modificar
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditar.Location = New System.Drawing.Point(337, 542)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(60, 60)
        Me.btneditar.TabIndex = 613
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Agregar
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnuevo.Location = New System.Drawing.Point(252, 542)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(60, 60)
        Me.btnnuevo.TabIndex = 612
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(504, 542)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 617
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        '
        'btnbuscaralumno
        '
        Me.btnbuscaralumno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnbuscaralumno.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.find_users_applications_search_29081
        Me.btnbuscaralumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscaralumno.Image = Global.Sistema_CECULD.My.Resources.Resources.find_users_applications_search_2908
        Me.btnbuscaralumno.Location = New System.Drawing.Point(805, 103)
        Me.btnbuscaralumno.Name = "btnbuscaralumno"
        Me.btnbuscaralumno.Size = New System.Drawing.Size(26, 23)
        Me.btnbuscaralumno.TabIndex = 598
        Me.btnbuscaralumno.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(71, 522)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 80)
        Me.pictureBox1.TabIndex = 590
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.CECULD2
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(710, 521)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(119, 81)
        Me.pictureBox2.TabIndex = 591
        Me.pictureBox2.TabStop = False
        '
        'frminscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 613)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.button29)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbxbusqueda)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.dginscripcion)
        Me.Controls.Add(Me.cbxdivision)
        Me.Controls.Add(Me.cbxcurso)
        Me.Controls.Add(Me.cbxcarrera)
        Me.Controls.Add(Me.cbxnivel)
        Me.Controls.Add(Me.btnbuscaralumno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtfinscripcion)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.txtidinscripcion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtidalumno)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.cbxinstitucion)
        Me.Controls.Add(Me.label2)
        Me.Name = "frminscripciones"
        Me.Text = "Inscripciones"
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dginscripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnguardaredicion As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Erroricono As System.Windows.Forms.ErrorProvider
    Private WithEvents button29 As System.Windows.Forms.Button
    Private WithEvents btnbaja As System.Windows.Forms.Button
    Private WithEvents btnguardaralta As System.Windows.Forms.Button
    Private WithEvents btneditar As System.Windows.Forms.Button
    Private WithEvents btnnuevo As System.Windows.Forms.Button
    Private WithEvents btnguardarbaja As System.Windows.Forms.Button
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents cbxbusqueda As System.Windows.Forms.ComboBox
    Private WithEvents txtbuscar As System.Windows.Forms.TextBox
    Public WithEvents txtdni As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Private WithEvents dginscripcion As System.Windows.Forms.DataGridView
    Private WithEvents cbxdivision As System.Windows.Forms.ComboBox
    Private WithEvents cbxcurso As System.Windows.Forms.ComboBox
    Private WithEvents cbxcarrera As System.Windows.Forms.ComboBox
    Private WithEvents cbxnivel As System.Windows.Forms.ComboBox
    Friend WithEvents btnbuscaralumno As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtfinscripcion As System.Windows.Forms.DateTimePicker
    Public WithEvents txtapellido As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents txtidinscripcion As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label20 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents txtidalumno As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents cbxinstitucion As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
End Class
