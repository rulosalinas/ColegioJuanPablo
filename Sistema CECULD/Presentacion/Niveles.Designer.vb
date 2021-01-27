<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Niveles
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
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbEliminar = New System.Windows.Forms.CheckBox()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgInstitucion = New System.Windows.Forms.DataGridView()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtInstitucion = New System.Windows.Forms.TextBox()
        Me.lblInstitucio = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbLogoPrincipal = New System.Windows.Forms.PictureBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogoPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.Location = New System.Drawing.Point(348, 249)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(111, 13)
        Me.inexistente.TabIndex = 417
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistentes"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'cbEliminar
        '
        Me.cbEliminar.AutoSize = True
        Me.cbEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEliminar.Location = New System.Drawing.Point(735, 120)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(70, 17)
        Me.cbEliminar.TabIndex = 418
        Me.cbEliminar.Text = "Eliminar"
        Me.cbEliminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'dgInstitucion
        '
        Me.dgInstitucion.AllowUserToAddRows = False
        Me.dgInstitucion.AllowUserToDeleteRows = False
        Me.dgInstitucion.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgInstitucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgInstitucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInstitucion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInstitucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInstitucion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgInstitucion.Location = New System.Drawing.Point(51, 143)
        Me.dgInstitucion.Name = "dgInstitucion"
        Me.dgInstitucion.ReadOnly = True
        Me.dgInstitucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInstitucion.Size = New System.Drawing.Size(754, 235)
        Me.dgInstitucion.TabIndex = 416
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(103, 103)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(421, 20)
        Me.txtDomicilio.TabIndex = 406
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(421, 20)
        Me.txtNombre.TabIndex = 405
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(48, 106)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.lblDomicilio.TabIndex = 413
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(48, 69)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 412
        Me.lblNombre.Text = "Nombre"
        '
        'txtInstitucion
        '
        Me.txtInstitucion.Location = New System.Drawing.Point(145, 31)
        Me.txtInstitucion.Name = "txtInstitucion"
        Me.txtInstitucion.Size = New System.Drawing.Size(66, 20)
        Me.txtInstitucion.TabIndex = 404
        '
        'lblInstitucio
        '
        Me.lblInstitucio.AutoSize = True
        Me.lblInstitucio.Location = New System.Drawing.Point(48, 34)
        Me.lblInstitucio.Name = "lblInstitucio"
        Me.lblInstitucio.Size = New System.Drawing.Size(91, 13)
        Me.lblInstitucio.TabIndex = 411
        Me.lblInstitucio.Text = "Código Institución"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Location = New System.Drawing.Point(528, 428)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(60, 60)
        Me.btnSalir.TabIndex = 409
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'pbLogoPrincipal
        '
        Me.pbLogoPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.pbLogoPrincipal.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.CECULD
        Me.pbLogoPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogoPrincipal.ErrorImage = Nothing
        Me.pbLogoPrincipal.Image = Global.Sistema_CECULD.My.Resources.Resources.CECULD1
        Me.pbLogoPrincipal.InitialImage = Nothing
        Me.pbLogoPrincipal.Location = New System.Drawing.Point(705, 408)
        Me.pbLogoPrincipal.Name = "pbLogoPrincipal"
        Me.pbLogoPrincipal.Size = New System.Drawing.Size(100, 80)
        Me.pbLogoPrincipal.TabIndex = 410
        Me.pbLogoPrincipal.TabStop = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cancelar
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrar.Location = New System.Drawing.Point(428, 428)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(60, 60)
        Me.btnBorrar.TabIndex = 408
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNuevo.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Agregar
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Location = New System.Drawing.Point(228, 428)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 60)
        Me.btnNuevo.TabIndex = 407
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(329, 428)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 419
        Me.btnguardaralta.UseVisualStyleBackColor = True
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(329, 428)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 421
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(329, 428)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 420
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        '
        'Niveles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 519)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.cbEliminar)
        Me.Controls.Add(Me.dgInstitucion)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtInstitucion)
        Me.Controls.Add(Me.lblInstitucio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pbLogoPrincipal)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "Niveles"
        Me.Text = "Niveles"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInstitucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogoPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbEliminar As System.Windows.Forms.CheckBox
    Private WithEvents dgInstitucion As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents lblDomicilio As System.Windows.Forms.Label
    Private WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents txtInstitucion As System.Windows.Forms.TextBox
    Private WithEvents lblInstitucio As System.Windows.Forms.Label
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents pbLogoPrincipal As System.Windows.Forms.PictureBox
    Private WithEvents btnBorrar As System.Windows.Forms.Button
    Private WithEvents btnNuevo As System.Windows.Forms.Button
    Private WithEvents btnguardaralta As System.Windows.Forms.Button
    Private WithEvents btnguardaredicion As System.Windows.Forms.Button
    Private WithEvents btnguardarbaja As System.Windows.Forms.Button
End Class
