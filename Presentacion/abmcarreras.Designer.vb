<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abmcarreras
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
        Me.cbxinstitucion = New System.Windows.Forms.ComboBox()
        Me.lblmbaja = New System.Windows.Forms.Label()
        Me.lblbaja = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lblmodificar = New System.Windows.Forms.Label()
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.txtresolucion = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtidcarrera = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbxnivel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtduracion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxinstitucion
        '
        Me.cbxinstitucion.FormattingEnabled = True
        Me.cbxinstitucion.Items.AddRange(New Object() {"PADRE", "MADRE", "TIO", "TIA", "ABUELO", "ABUELA", "HERMANO", "HERMANA", "OTRO", ""})
        Me.cbxinstitucion.Location = New System.Drawing.Point(97, 135)
        Me.cbxinstitucion.Name = "cbxinstitucion"
        Me.cbxinstitucion.Size = New System.Drawing.Size(217, 21)
        Me.cbxinstitucion.TabIndex = 445
        '
        'lblmbaja
        '
        Me.lblmbaja.AutoSize = True
        Me.lblmbaja.Location = New System.Drawing.Point(23, 138)
        Me.lblmbaja.Name = "lblmbaja"
        Me.lblmbaja.Size = New System.Drawing.Size(55, 13)
        Me.lblmbaja.TabIndex = 444
        Me.lblmbaja.Text = "Institucion"
        Me.lblmbaja.Visible = False
        '
        'lblbaja
        '
        Me.lblbaja.AutoSize = True
        Me.lblbaja.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblbaja.Location = New System.Drawing.Point(120, 36)
        Me.lblbaja.Name = "lblbaja"
        Me.lblbaja.Size = New System.Drawing.Size(153, 17)
        Me.lblbaja.TabIndex = 443
        Me.lblbaja.Text = " ELIMINAR CARRERA"
        Me.lblbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblbaja.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(263, 278)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 438
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lblmodificar
        '
        Me.lblmodificar.AutoSize = True
        Me.lblmodificar.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblmodificar.Location = New System.Drawing.Point(120, 36)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(160, 17)
        Me.lblmodificar.TabIndex = 442
        Me.lblmodificar.Text = "MODIFICAR CARRERA"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblmodificar.Visible = False
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(133, 36)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(127, 17)
        Me.lblnuevo.TabIndex = 441
        Me.lblnuevo.Text = "NUEVA CARRERA"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblnuevo.Visible = False
        '
        'txtresolucion
        '
        Me.txtresolucion.Location = New System.Drawing.Point(97, 227)
        Me.txtresolucion.Name = "txtresolucion"
        Me.txtresolucion.Size = New System.Drawing.Size(89, 20)
        Me.txtresolucion.TabIndex = 431
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(23, 229)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(60, 13)
        Me.label9.TabIndex = 434
        Me.label9.Text = "Resolucion"
        '
        'txtidcarrera
        '
        Me.txtidcarrera.Location = New System.Drawing.Point(97, 105)
        Me.txtidcarrera.MaxLength = 8
        Me.txtidcarrera.Name = "txtidcarrera"
        Me.txtidcarrera.Size = New System.Drawing.Size(217, 20)
        Me.txtidcarrera.TabIndex = 433
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(23, 109)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(77, 13)
        Me.label17.TabIndex = 436
        Me.label17.Text = "Codigo Carrera"
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(72, 278)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 437
        Me.btnguardaralta.UseVisualStyleBackColor = True
        Me.btnguardaralta.Visible = False
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(72, 278)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 440
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        Me.btnguardaredicion.Visible = False
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(72, 278)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 439
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        Me.btnguardarbaja.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(23, 200)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 435
        Me.label4.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(97, 197)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(217, 20)
        Me.txtnombre.TabIndex = 432
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'cbxnivel
        '
        Me.cbxnivel.FormattingEnabled = True
        Me.cbxnivel.Items.AddRange(New Object() {"PADRE", "MADRE", "TIO", "TIA", "ABUELO", "ABUELA", "HERMANO", "HERMANA", "OTRO", ""})
        Me.cbxnivel.Location = New System.Drawing.Point(97, 166)
        Me.cbxnivel.Name = "cbxnivel"
        Me.cbxnivel.Size = New System.Drawing.Size(217, 21)
        Me.cbxnivel.TabIndex = 447
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 446
        Me.Label1.Text = "Nivel"
        Me.Label1.Visible = False
        '
        'txtduracion
        '
        Me.txtduracion.Location = New System.Drawing.Point(248, 229)
        Me.txtduracion.Name = "txtduracion"
        Me.txtduracion.Size = New System.Drawing.Size(66, 20)
        Me.txtduracion.TabIndex = 448
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 449
        Me.Label2.Text = "Duracion"
        '
        'abmcarreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 365)
        Me.Controls.Add(Me.txtduracion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxnivel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxinstitucion)
        Me.Controls.Add(Me.lblmbaja)
        Me.Controls.Add(Me.lblbaja)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.txtresolucion)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.txtidcarrera)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "abmcarreras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abmcarreras"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxinstitucion As System.Windows.Forms.ComboBox
    Public WithEvents lblmbaja As System.Windows.Forms.Label
    Public WithEvents lblbaja As System.Windows.Forms.Label
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Public WithEvents lblmodificar As System.Windows.Forms.Label
    Public WithEvents lblnuevo As System.Windows.Forms.Label
    Public WithEvents txtresolucion As System.Windows.Forms.TextBox
    Public WithEvents label9 As System.Windows.Forms.Label
    Public WithEvents txtidcarrera As System.Windows.Forms.TextBox
    Public WithEvents label17 As System.Windows.Forms.Label
    Public WithEvents btnguardaralta As System.Windows.Forms.Button
    Public WithEvents btnguardaredicion As System.Windows.Forms.Button
    Public WithEvents btnguardarbaja As System.Windows.Forms.Button
    Public WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbxnivel As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtduracion As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
End Class
