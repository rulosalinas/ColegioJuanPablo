<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabmpagos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtinstitucion = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label27 = New System.Windows.Forms.Label()
        Me.txtcurso = New System.Windows.Forms.TextBox()
        Me.label35 = New System.Windows.Forms.Label()
        Me.txtdivision = New System.Windows.Forms.TextBox()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        Me.label37 = New System.Windows.Forms.Label()
        Me.txtcomprobante = New System.Windows.Forms.TextBox()
        Me.label45 = New System.Windows.Forms.Label()
        Me.txtidinscripcion = New System.Windows.Forms.TextBox()
        Me.label47 = New System.Windows.Forms.Label()
        Me.txtcarrera = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidpago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtiddetalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfechapago = New System.Windows.Forms.DateTimePicker()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtphorapago = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxformapago = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxtipocomprobante = New System.Windows.Forms.ComboBox()
        Me.txtprecioarancel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnombrearancel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtidarancel = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtrecargo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Productos = New System.Windows.Forms.TextBox()
        Me.txttotalgral = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtflag2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnagregaralumno = New System.Windows.Forms.Button()
        Me.btnlistado = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarproducto = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.btnagregararancel = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnmarzo = New System.Windows.Forms.Button()
        Me.btnabril = New System.Windows.Forms.Button()
        Me.btnmayo = New System.Windows.Forms.Button()
        Me.btnjunio = New System.Windows.Forms.Button()
        Me.btnjulio = New System.Windows.Forms.Button()
        Me.btnagosto = New System.Windows.Forms.Button()
        Me.btnseptiembre = New System.Windows.Forms.Button()
        Me.btnoctubre = New System.Windows.Forms.Button()
        Me.btnnoviembre = New System.Windows.Forms.Button()
        Me.btndiciembre = New System.Windows.Forms.Button()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtinstitucion
        '
        Me.txtinstitucion.Enabled = False
        Me.txtinstitucion.Location = New System.Drawing.Point(61, 52)
        Me.txtinstitucion.Name = "txtinstitucion"
        Me.txtinstitucion.Size = New System.Drawing.Size(255, 20)
        Me.txtinstitucion.TabIndex = 342
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Location = New System.Drawing.Point(334, 21)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(92, 20)
        Me.txtdni.TabIndex = 339
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(294, 25)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(35, 13)
        Me.Label43.TabIndex = 338
        Me.Label43.Text = "D.N.I."
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(488, 21)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(262, 20)
        Me.txtnombre.TabIndex = 336
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(3, 84)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(70, 13)
        Me.label27.TabIndex = 335
        Me.label27.Text = "Comprobante"
        '
        'txtcurso
        '
        Me.txtcurso.Enabled = False
        Me.txtcurso.Location = New System.Drawing.Point(734, 52)
        Me.txtcurso.Name = "txtcurso"
        Me.txtcurso.Size = New System.Drawing.Size(36, 20)
        Me.txtcurso.TabIndex = 326
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.Enabled = False
        Me.label35.Location = New System.Drawing.Point(700, 56)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(34, 13)
        Me.label35.TabIndex = 325
        Me.label35.Text = "Curso"
        '
        'txtdivision
        '
        Me.txtdivision.Enabled = False
        Me.txtdivision.Location = New System.Drawing.Point(773, 52)
        Me.txtdivision.Name = "txtdivision"
        Me.txtdivision.Size = New System.Drawing.Size(37, 20)
        Me.txtdivision.TabIndex = 324
        '
        'txtnivel
        '
        Me.txtnivel.Enabled = False
        Me.txtnivel.Location = New System.Drawing.Point(358, 52)
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(67, 20)
        Me.txtnivel.TabIndex = 322
        '
        'label37
        '
        Me.label37.AutoSize = True
        Me.label37.Enabled = False
        Me.label37.Location = New System.Drawing.Point(322, 56)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(31, 13)
        Me.label37.TabIndex = 321
        Me.label37.Text = "Nivel"
        '
        'txtcomprobante
        '
        Me.txtcomprobante.Location = New System.Drawing.Point(79, 80)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(82, 20)
        Me.txtcomprobante.TabIndex = 318
        '
        'label45
        '
        Me.label45.AutoSize = True
        Me.label45.Enabled = False
        Me.label45.Location = New System.Drawing.Point(434, 25)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(44, 13)
        Me.label45.TabIndex = 317
        Me.label45.Text = "Nombre"
        '
        'txtidinscripcion
        '
        Me.txtidinscripcion.Enabled = False
        Me.txtidinscripcion.Location = New System.Drawing.Point(221, 21)
        Me.txtidinscripcion.Name = "txtidinscripcion"
        Me.txtidinscripcion.Size = New System.Drawing.Size(60, 20)
        Me.txtidinscripcion.TabIndex = 316
        '
        'label47
        '
        Me.label47.AutoSize = True
        Me.label47.Location = New System.Drawing.Point(7, 56)
        Me.label47.Name = "label47"
        Me.label47.Size = New System.Drawing.Size(55, 13)
        Me.label47.TabIndex = 314
        Me.label47.Text = "Institución"
        '
        'txtcarrera
        '
        Me.txtcarrera.Enabled = False
        Me.txtcarrera.Location = New System.Drawing.Point(477, 52)
        Me.txtcarrera.Name = "txtcarrera"
        Me.txtcarrera.Size = New System.Drawing.Size(217, 20)
        Me.txtcarrera.TabIndex = 344
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "Carrera"
        '
        'txtidpago
        '
        Me.txtidpago.Enabled = False
        Me.txtidpago.Location = New System.Drawing.Point(71, 21)
        Me.txtidpago.Name = "txtidpago"
        Me.txtidpago.Size = New System.Drawing.Size(58, 20)
        Me.txtidpago.TabIndex = 346
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 345
        Me.Label2.Text = "N° Pago"
        '
        'txtiddetalle
        '
        Me.txtiddetalle.Location = New System.Drawing.Point(62, 24)
        Me.txtiddetalle.Name = "txtiddetalle"
        Me.txtiddetalle.Size = New System.Drawing.Size(64, 20)
        Me.txtiddetalle.TabIndex = 348
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "Id Detalle"
        '
        'dtpfechapago
        '
        Me.dtpfechapago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechapago.Location = New System.Drawing.Point(612, 81)
        Me.dtpfechapago.Name = "dtpfechapago"
        Me.dtpfechapago.Size = New System.Drawing.Size(99, 20)
        Me.dtpfechapago.TabIndex = 349
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.SystemColors.Control
        Me.inexistente.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.LinkColor = System.Drawing.Color.Red
        Me.inexistente.Location = New System.Drawing.Point(341, 392)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(232, 17)
        Me.inexistente.TabIndex = 392
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "NO SE AGREGARON ELEMENTOS"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.Location = New System.Drawing.Point(21, 314)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(827, 172)
        Me.datalistado.TabIndex = 391
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(421, 31)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(100, 17)
        Me.lblnuevo.TabIndex = 426
        Me.lblnuevo.Text = "NUEVO PAGO"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(145, 25)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 631
        Me.label7.Text = "N° Inscripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 633
        Me.Label5.Text = "Forma Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(564, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 634
        Me.Label6.Text = "Fecha"
        '
        'dtphorapago
        '
        Me.dtphorapago.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphorapago.Location = New System.Drawing.Point(474, 62)
        Me.dtphorapago.Name = "dtphorapago"
        Me.dtphorapago.Size = New System.Drawing.Size(99, 20)
        Me.dtphorapago.TabIndex = 635
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 636
        Me.Label8.Text = "Hora"
        '
        'cbxformapago
        '
        Me.cbxformapago.FormattingEnabled = True
        Me.cbxformapago.Items.AddRange(New Object() {"CONTADO", "TARJETA"})
        Me.cbxformapago.Location = New System.Drawing.Point(405, 80)
        Me.cbxformapago.Name = "cbxformapago"
        Me.cbxformapago.Size = New System.Drawing.Size(142, 21)
        Me.cbxformapago.TabIndex = 637
        Me.cbxformapago.Text = "CONTADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 639
        Me.Label9.Text = "Tipo"
        '
        'cbxtipocomprobante
        '
        Me.cbxtipocomprobante.FormattingEnabled = True
        Me.cbxtipocomprobante.Items.AddRange(New Object() {"RECIBO", "FACTURA"})
        Me.cbxtipocomprobante.Location = New System.Drawing.Point(227, 82)
        Me.cbxtipocomprobante.Name = "cbxtipocomprobante"
        Me.cbxtipocomprobante.Size = New System.Drawing.Size(85, 21)
        Me.cbxtipocomprobante.TabIndex = 640
        Me.cbxtipocomprobante.Text = "RECIBO"
        '
        'txtprecioarancel
        '
        Me.txtprecioarancel.Location = New System.Drawing.Point(444, 23)
        Me.txtprecioarancel.Name = "txtprecioarancel"
        Me.txtprecioarancel.Size = New System.Drawing.Size(79, 20)
        Me.txtprecioarancel.TabIndex = 642
        Me.txtprecioarancel.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 641
        Me.Label10.Text = "Precio"
        '
        'txtnombrearancel
        '
        Me.txtnombrearancel.Location = New System.Drawing.Point(209, 23)
        Me.txtnombrearancel.Name = "txtnombrearancel"
        Me.txtnombrearancel.Size = New System.Drawing.Size(185, 20)
        Me.txtnombrearancel.TabIndex = 644
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(130, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 643
        Me.Label11.Text = "Nombre"
        '
        'txtidarancel
        '
        Me.txtidarancel.Location = New System.Drawing.Point(180, 23)
        Me.txtidarancel.Name = "txtidarancel"
        Me.txtidarancel.Size = New System.Drawing.Size(25, 20)
        Me.txtidarancel.TabIndex = 645
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(592, 24)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(39, 20)
        Me.txtdescuento.TabIndex = 650
        Me.txtdescuento.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(637, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 648
        Me.Label12.Text = "Recargo"
        '
        'txtrecargo
        '
        Me.txtrecargo.Location = New System.Drawing.Point(688, 24)
        Me.txtrecargo.Name = "txtrecargo"
        Me.txtrecargo.Size = New System.Drawing.Size(55, 20)
        Me.txtrecargo.TabIndex = 647
        Me.txtrecargo.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(529, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 646
        Me.Label13.Text = "Descuento"
        '
        'Productos
        '
        Me.Productos.Location = New System.Drawing.Point(768, 490)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(79, 20)
        Me.Productos.TabIndex = 658
        '
        'txttotalgral
        '
        Me.txttotalgral.Location = New System.Drawing.Point(768, 516)
        Me.txttotalgral.Name = "txttotalgral"
        Me.txttotalgral.Size = New System.Drawing.Size(79, 20)
        Me.txttotalgral.TabIndex = 659
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(700, 490)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 660
        Me.Label16.Text = "Productos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(700, 519)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 661
        Me.Label17.Text = "Total"
        '
        'txtflag2
        '
        Me.txtflag2.Location = New System.Drawing.Point(837, 12)
        Me.txtflag2.Name = "txtflag2"
        Me.txtflag2.Size = New System.Drawing.Size(27, 20)
        Me.txtflag2.TabIndex = 662
        Me.txtflag2.Text = "0"
        Me.txtflag2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.cbxtipocomprobante)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbxformapago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.txtidpago)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcarrera)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtinstitucion)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.label27)
        Me.GroupBox1.Controls.Add(Me.txtcurso)
        Me.GroupBox1.Controls.Add(Me.label35)
        Me.GroupBox1.Controls.Add(Me.txtdivision)
        Me.GroupBox1.Controls.Add(Me.txtnivel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.label37)
        Me.GroupBox1.Controls.Add(Me.btnagregaralumno)
        Me.GroupBox1.Controls.Add(Me.txtcomprobante)
        Me.GroupBox1.Controls.Add(Me.label45)
        Me.GroupBox1.Controls.Add(Me.txtidinscripcion)
        Me.GroupBox1.Controls.Add(Me.label47)
        Me.GroupBox1.Controls.Add(Me.dtpfechapago)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 114)
        Me.GroupBox1.TabIndex = 664
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pago"
        '
        'btnagregaralumno
        '
        Me.btnagregaralumno.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.buscar
        Me.btnagregaralumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregaralumno.Location = New System.Drawing.Point(773, 13)
        Me.btnagregaralumno.Name = "btnagregaralumno"
        Me.btnagregaralumno.Size = New System.Drawing.Size(39, 36)
        Me.btnagregaralumno.TabIndex = 430
        Me.btnagregaralumno.UseVisualStyleBackColor = True
        '
        'btnlistado
        '
        Me.btnlistado.Location = New System.Drawing.Point(25, 57)
        Me.btnlistado.Name = "btnlistado"
        Me.btnlistado.Size = New System.Drawing.Size(123, 35)
        Me.btnlistado.TabIndex = 665
        Me.btnlistado.Text = "Consultar Pago"
        Me.btnlistado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.txtdescuento)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtidarancel)
        Me.GroupBox2.Controls.Add(Me.txtnombrearancel)
        Me.GroupBox2.Controls.Add(Me.txtrecargo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtprecioarancel)
        Me.GroupBox2.Controls.Add(Me.btnbuscarproducto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtiddetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 53)
        Me.GroupBox2.TabIndex = 666
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'btnbuscarproducto
        '
        Me.btnbuscarproducto.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.buscar
        Me.btnbuscarproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarproducto.Location = New System.Drawing.Point(750, 11)
        Me.btnbuscarproducto.Name = "btnbuscarproducto"
        Me.btnbuscarproducto.Size = New System.Drawing.Size(39, 38)
        Me.btnbuscarproducto.TabIndex = 373
        Me.btnbuscarproducto.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.btnquitar
        Me.btnquitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnquitar.Location = New System.Drawing.Point(820, 252)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(27, 25)
        Me.btnquitar.TabIndex = 663
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'btnagregararancel
        '
        Me.btnagregararancel.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.btnAgregar1
        Me.btnagregararancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregararancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnagregararancel.Location = New System.Drawing.Point(820, 224)
        Me.btnagregararancel.Name = "btnagregararancel"
        Me.btnagregararancel.Size = New System.Drawing.Size(27, 25)
        Me.btnagregararancel.TabIndex = 651
        Me.btnagregararancel.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(484, 493)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 370
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(303, 493)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 369
        Me.btnguardaralta.UseVisualStyleBackColor = True
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblhora.Location = New System.Drawing.Point(801, 45)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(31, 17)
        Me.lblhora.TabIndex = 668
        Me.lblhora.Text = "Hora"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblfecha.Location = New System.Drawing.Point(795, 31)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(36, 17)
        Me.lblfecha.TabIndex = 667
        Me.lblfecha.Text = "Fecha"
        '
        'Timer1
        '
        '
        'btnmarzo
        '
        Me.btnmarzo.Location = New System.Drawing.Point(22, 287)
        Me.btnmarzo.Name = "btnmarzo"
        Me.btnmarzo.Size = New System.Drawing.Size(80, 21)
        Me.btnmarzo.TabIndex = 670
        Me.btnmarzo.Text = "Marzo"
        Me.btnmarzo.UseVisualStyleBackColor = True
        '
        'btnabril
        '
        Me.btnabril.Location = New System.Drawing.Point(105, 287)
        Me.btnabril.Name = "btnabril"
        Me.btnabril.Size = New System.Drawing.Size(80, 21)
        Me.btnabril.TabIndex = 671
        Me.btnabril.Text = "Abril"
        Me.btnabril.UseVisualStyleBackColor = True
        '
        'btnmayo
        '
        Me.btnmayo.Location = New System.Drawing.Point(188, 287)
        Me.btnmayo.Name = "btnmayo"
        Me.btnmayo.Size = New System.Drawing.Size(80, 21)
        Me.btnmayo.TabIndex = 672
        Me.btnmayo.Text = "Mayo"
        Me.btnmayo.UseVisualStyleBackColor = True
        '
        'btnjunio
        '
        Me.btnjunio.Location = New System.Drawing.Point(271, 287)
        Me.btnjunio.Name = "btnjunio"
        Me.btnjunio.Size = New System.Drawing.Size(80, 21)
        Me.btnjunio.TabIndex = 673
        Me.btnjunio.Text = "Junio"
        Me.btnjunio.UseVisualStyleBackColor = True
        '
        'btnjulio
        '
        Me.btnjulio.Location = New System.Drawing.Point(354, 287)
        Me.btnjulio.Name = "btnjulio"
        Me.btnjulio.Size = New System.Drawing.Size(80, 21)
        Me.btnjulio.TabIndex = 674
        Me.btnjulio.Text = "Julio"
        Me.btnjulio.UseVisualStyleBackColor = True
        '
        'btnagosto
        '
        Me.btnagosto.Location = New System.Drawing.Point(437, 287)
        Me.btnagosto.Name = "btnagosto"
        Me.btnagosto.Size = New System.Drawing.Size(80, 21)
        Me.btnagosto.TabIndex = 675
        Me.btnagosto.Text = "Agosto"
        Me.btnagosto.UseVisualStyleBackColor = True
        '
        'btnseptiembre
        '
        Me.btnseptiembre.Location = New System.Drawing.Point(520, 287)
        Me.btnseptiembre.Name = "btnseptiembre"
        Me.btnseptiembre.Size = New System.Drawing.Size(80, 21)
        Me.btnseptiembre.TabIndex = 676
        Me.btnseptiembre.Text = "Septiembre"
        Me.btnseptiembre.UseVisualStyleBackColor = True
        '
        'btnoctubre
        '
        Me.btnoctubre.Location = New System.Drawing.Point(603, 287)
        Me.btnoctubre.Name = "btnoctubre"
        Me.btnoctubre.Size = New System.Drawing.Size(80, 21)
        Me.btnoctubre.TabIndex = 677
        Me.btnoctubre.Text = "Octubre"
        Me.btnoctubre.UseVisualStyleBackColor = True
        '
        'btnnoviembre
        '
        Me.btnnoviembre.Location = New System.Drawing.Point(686, 287)
        Me.btnnoviembre.Name = "btnnoviembre"
        Me.btnnoviembre.Size = New System.Drawing.Size(80, 21)
        Me.btnnoviembre.TabIndex = 678
        Me.btnnoviembre.Text = "Noviembre"
        Me.btnnoviembre.UseVisualStyleBackColor = True
        '
        'btndiciembre
        '
        Me.btndiciembre.Location = New System.Drawing.Point(769, 287)
        Me.btndiciembre.Name = "btndiciembre"
        Me.btndiciembre.Size = New System.Drawing.Size(80, 21)
        Me.btndiciembre.TabIndex = 679
        Me.btndiciembre.Text = "Diciembre"
        Me.btndiciembre.UseVisualStyleBackColor = True
        '
        'frmabmpagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 559)
        Me.Controls.Add(Me.btndiciembre)
        Me.Controls.Add(Me.btnnoviembre)
        Me.Controls.Add(Me.btnoctubre)
        Me.Controls.Add(Me.btnseptiembre)
        Me.Controls.Add(Me.btnagosto)
        Me.Controls.Add(Me.btnjulio)
        Me.Controls.Add(Me.btnjunio)
        Me.Controls.Add(Me.btnmayo)
        Me.Controls.Add(Me.btnabril)
        Me.Controls.Add(Me.btnmarzo)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnlistado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtflag2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txttotalgral)
        Me.Controls.Add(Me.Productos)
        Me.Controls.Add(Me.btnquitar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtphorapago)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.btnagregararancel)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Name = "frmabmpagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abmpagos"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Public WithEvents btnguardaralta As System.Windows.Forms.Button
    Friend WithEvents btnbuscarproducto As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Public WithEvents txtinstitucion As System.Windows.Forms.TextBox
    Public WithEvents txtdni As System.Windows.Forms.TextBox
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Public WithEvents label27 As System.Windows.Forms.Label
    Public WithEvents txtcurso As System.Windows.Forms.TextBox
    Public WithEvents label35 As System.Windows.Forms.Label
    Public WithEvents txtdivision As System.Windows.Forms.TextBox
    Public WithEvents txtnivel As System.Windows.Forms.TextBox
    Public WithEvents label37 As System.Windows.Forms.Label
    Public WithEvents txtcomprobante As System.Windows.Forms.TextBox
    Public WithEvents label45 As System.Windows.Forms.Label
    Public WithEvents txtidinscripcion As System.Windows.Forms.TextBox
    Public WithEvents label47 As System.Windows.Forms.Label
    Public WithEvents txtcarrera As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtidpago As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtiddetalle As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents dtpfechapago As System.Windows.Forms.DateTimePicker
    Public WithEvents lblnuevo As System.Windows.Forms.Label
    Friend WithEvents btnagregaralumno As System.Windows.Forms.Button
    Public WithEvents label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents dtphorapago As System.Windows.Forms.DateTimePicker
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxformapago As System.Windows.Forms.ComboBox
    Friend WithEvents cbxtipocomprobante As System.Windows.Forms.ComboBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnagregararancel As System.Windows.Forms.Button
    Public WithEvents txtdescuento As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtrecargo As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtidarancel As System.Windows.Forms.TextBox
    Public WithEvents txtnombrearancel As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtprecioarancel As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents datalistado As System.Windows.Forms.DataGridView
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txttotalgral As System.Windows.Forms.TextBox
    Friend WithEvents Productos As System.Windows.Forms.TextBox
    Public WithEvents txtflag2 As System.Windows.Forms.TextBox
    Friend WithEvents btnquitar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlistado As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btndiciembre As System.Windows.Forms.Button
    Friend WithEvents btnnoviembre As System.Windows.Forms.Button
    Friend WithEvents btnoctubre As System.Windows.Forms.Button
    Friend WithEvents btnseptiembre As System.Windows.Forms.Button
    Friend WithEvents btnagosto As System.Windows.Forms.Button
    Friend WithEvents btnjulio As System.Windows.Forms.Button
    Friend WithEvents btnjunio As System.Windows.Forms.Button
    Friend WithEvents btnmayo As System.Windows.Forms.Button
    Friend WithEvents btnabril As System.Windows.Forms.Button
    Friend WithEvents btnmarzo As System.Windows.Forms.Button
End Class
