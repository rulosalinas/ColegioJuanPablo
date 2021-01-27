<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabmtutor
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
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblbaja = New System.Windows.Forms.Label()
        Me.lblmodificar = New System.Windows.Forms.Label()
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.txtlocalidad = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.txttelefono2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmbaja = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttelefono3 = New System.Windows.Forms.TextBox()
        Me.txtnombre3 = New System.Windows.Forms.TextBox()
        Me.txtnombre2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxparentesco = New System.Windows.Forms.ComboBox()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'lblbaja
        '
        Me.lblbaja.AutoSize = True
        Me.lblbaja.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblbaja.Location = New System.Drawing.Point(255, 53)
        Me.lblbaja.Name = "lblbaja"
        Me.lblbaja.Size = New System.Drawing.Size(132, 17)
        Me.lblbaja.TabIndex = 398
        Me.lblbaja.Text = " ELIMINAR TUTOR"
        Me.lblbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblbaja.Visible = False
        '
        'lblmodificar
        '
        Me.lblmodificar.AutoSize = True
        Me.lblmodificar.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblmodificar.Location = New System.Drawing.Point(252, 53)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(139, 17)
        Me.lblmodificar.TabIndex = 397
        Me.lblmodificar.Text = "MODIFICAR TUTOR"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblmodificar.Visible = False
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(268, 53)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(107, 17)
        Me.lblnuevo.TabIndex = 396
        Me.lblnuevo.Text = "NUEVO TUTOR"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblnuevo.Visible = False
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(81, 152)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(186, 20)
        Me.txtapellido.TabIndex = 369
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(18, 155)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(44, 13)
        Me.label9.TabIndex = 379
        Me.label9.Text = "Apellido"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(81, 122)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(186, 20)
        Me.txtdni.TabIndex = 372
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(18, 125)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(35, 13)
        Me.label17.TabIndex = 391
        Me.label17.Text = "D.N.I."
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(12, 36)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(44, 13)
        Me.label16.TabIndex = 390
        Me.label16.Text = "Nombre"
        '
        'txtlocalidad
        '
        Me.txtlocalidad.Location = New System.Drawing.Point(81, 288)
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.Size = New System.Drawing.Size(230, 20)
        Me.txtlocalidad.TabIndex = 375
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(18, 291)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(53, 13)
        Me.label8.TabIndex = 388
        Me.label8.Text = "Localidad"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(18, 182)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 380
        Me.label4.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(81, 180)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(186, 20)
        Me.txtnombre.TabIndex = 370
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(18, 264)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(49, 13)
        Me.label5.TabIndex = 381
        Me.label5.Text = "Domicilio"
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Location = New System.Drawing.Point(81, 261)
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(230, 20)
        Me.txtdomicilio.TabIndex = 371
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(390, 335)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 393
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(199, 335)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 392
        Me.btnguardaralta.UseVisualStyleBackColor = True
        Me.btnguardaralta.Visible = False
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(199, 335)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 395
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        Me.btnguardaredicion.Visible = False
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(199, 335)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 394
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        Me.btnguardarbaja.Visible = False
        '
        'txttelefono2
        '
        Me.txttelefono2.Location = New System.Drawing.Point(64, 66)
        Me.txttelefono2.MaxLength = 10
        Me.txttelefono2.Name = "txttelefono2"
        Me.txttelefono2.Size = New System.Drawing.Size(234, 20)
        Me.txttelefono2.TabIndex = 399
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 400
        Me.Label1.Text = "Teléfono"
        '
        'lblmbaja
        '
        Me.lblmbaja.AutoSize = True
        Me.lblmbaja.Location = New System.Drawing.Point(18, 211)
        Me.lblmbaja.Name = "lblmbaja"
        Me.lblmbaja.Size = New System.Drawing.Size(61, 13)
        Me.lblmbaja.TabIndex = 406
        Me.lblmbaja.Text = "Parentesco"
        Me.lblmbaja.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttelefono3)
        Me.GroupBox1.Controls.Add(Me.txtnombre3)
        Me.GroupBox1.Controls.Add(Me.txtnombre2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttelefono2)
        Me.GroupBox1.Controls.Add(Me.label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(339, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 206)
        Me.GroupBox1.TabIndex = 407
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Otros Contactos"
        '
        'txttelefono3
        '
        Me.txttelefono3.Location = New System.Drawing.Point(64, 165)
        Me.txttelefono3.MaxLength = 10
        Me.txttelefono3.Name = "txttelefono3"
        Me.txttelefono3.Size = New System.Drawing.Size(234, 20)
        Me.txttelefono3.TabIndex = 411
        '
        'txtnombre3
        '
        Me.txtnombre3.Location = New System.Drawing.Point(64, 128)
        Me.txtnombre3.Name = "txtnombre3"
        Me.txtnombre3.Size = New System.Drawing.Size(234, 20)
        Me.txtnombre3.TabIndex = 410
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(64, 33)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(234, 20)
        Me.txtnombre2.TabIndex = 409
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 402
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 404
        Me.Label3.Text = "Teléfono"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(81, 234)
        Me.txttelefono.MaxLength = 10
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(185, 20)
        Me.txttelefono.TabIndex = 405
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 406
        Me.Label6.Text = "Teléfono"
        '
        'cbxparentesco
        '
        Me.cbxparentesco.FormattingEnabled = True
        Me.cbxparentesco.Items.AddRange(New Object() {"PADRE", "MADRE", "TIO", "TIA", "ABUELO", "ABUELA", "HERMANO", "HERMANA", "OTRO", ""})
        Me.cbxparentesco.Location = New System.Drawing.Point(81, 208)
        Me.cbxparentesco.Name = "cbxparentesco"
        Me.cbxparentesco.Size = New System.Drawing.Size(186, 21)
        Me.cbxparentesco.TabIndex = 408
        '
        'frmabmtutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 410)
        Me.Controls.Add(Me.cbxparentesco)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblmbaja)
        Me.Controls.Add(Me.lblbaja)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.txtlocalidad)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Name = "frmabmtutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutor"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Public WithEvents lblbaja As System.Windows.Forms.Label
    Public WithEvents lblmodificar As System.Windows.Forms.Label
    Public WithEvents lblnuevo As System.Windows.Forms.Label
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Public WithEvents btnguardaralta As System.Windows.Forms.Button
    Public WithEvents btnguardaredicion As System.Windows.Forms.Button
    Public WithEvents btnguardarbaja As System.Windows.Forms.Button
    Public WithEvents txtapellido As System.Windows.Forms.TextBox
    Public WithEvents label9 As System.Windows.Forms.Label
    Public WithEvents txtdni As System.Windows.Forms.TextBox
    Public WithEvents label17 As System.Windows.Forms.Label
    Public WithEvents label16 As System.Windows.Forms.Label
    Public WithEvents txtlocalidad As System.Windows.Forms.TextBox
    Public WithEvents label8 As System.Windows.Forms.Label
    Public WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents txtnombre As System.Windows.Forms.TextBox
    Public WithEvents label5 As System.Windows.Forms.Label
    Public WithEvents txtdomicilio As System.Windows.Forms.TextBox
    Public WithEvents txttelefono2 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblmbaja As System.Windows.Forms.Label
    Public WithEvents txttelefono As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxparentesco As System.Windows.Forms.ComboBox
    Public WithEvents txtnombre3 As System.Windows.Forms.TextBox
    Public WithEvents txtnombre2 As System.Windows.Forms.TextBox
    Public WithEvents txttelefono3 As System.Windows.Forms.TextBox
End Class
