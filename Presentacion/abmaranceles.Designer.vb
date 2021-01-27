<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabmaranceles
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
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblmodificar = New System.Windows.Forms.Label()
        Me.lblnuevo = New System.Windows.Forms.Label()
        Me.txtprecioarancel = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtidarancel = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.btnguardaralta = New System.Windows.Forms.Button()
        Me.btnguardaredicion = New System.Windows.Forms.Button()
        Me.btnguardarbaja = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtnombrearancel = New System.Windows.Forms.TextBox()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxinstitucion
        '
        Me.cbxinstitucion.FormattingEnabled = True
        Me.cbxinstitucion.Items.AddRange(New Object() {"PADRE", "MADRE", "TIO", "TIA", "ABUELO", "ABUELA", "HERMANO", "HERMANA", "OTRO", ""})
        Me.cbxinstitucion.Location = New System.Drawing.Point(86, 128)
        Me.cbxinstitucion.Name = "cbxinstitucion"
        Me.cbxinstitucion.Size = New System.Drawing.Size(186, 21)
        Me.cbxinstitucion.TabIndex = 430
        '
        'lblmbaja
        '
        Me.lblmbaja.AutoSize = True
        Me.lblmbaja.Location = New System.Drawing.Point(12, 128)
        Me.lblmbaja.Name = "lblmbaja"
        Me.lblmbaja.Size = New System.Drawing.Size(55, 13)
        Me.lblmbaja.TabIndex = 428
        Me.lblmbaja.Text = "Institucion"
        Me.lblmbaja.Visible = False
        '
        'lblbaja
        '
        Me.lblbaja.AutoSize = True
        Me.lblbaja.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblbaja.Location = New System.Drawing.Point(99, 33)
        Me.lblbaja.Name = "lblbaja"
        Me.lblbaja.Size = New System.Drawing.Size(151, 17)
        Me.lblbaja.TabIndex = 425
        Me.lblbaja.Text = " ELIMINAR ARANCEL"
        Me.lblbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblbaja.Visible = False
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(242, 266)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 420
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'lblmodificar
        '
        Me.lblmodificar.AutoSize = True
        Me.lblmodificar.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodificar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblmodificar.Location = New System.Drawing.Point(99, 33)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(158, 17)
        Me.lblmodificar.TabIndex = 424
        Me.lblmodificar.Text = "MODIFICAR ARANCEL"
        Me.lblmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblmodificar.Visible = False
        '
        'lblnuevo
        '
        Me.lblnuevo.AutoSize = True
        Me.lblnuevo.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnuevo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblnuevo.Location = New System.Drawing.Point(112, 33)
        Me.lblnuevo.Name = "lblnuevo"
        Me.lblnuevo.Size = New System.Drawing.Size(126, 17)
        Me.lblnuevo.TabIndex = 423
        Me.lblnuevo.Text = "NUEVO ARANCEL"
        Me.lblnuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblnuevo.Visible = False
        '
        'txtprecioarancel
        '
        Me.txtprecioarancel.Location = New System.Drawing.Point(86, 196)
        Me.txtprecioarancel.Name = "txtprecioarancel"
        Me.txtprecioarancel.Size = New System.Drawing.Size(186, 20)
        Me.txtprecioarancel.TabIndex = 409
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(12, 196)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(42, 13)
        Me.label9.TabIndex = 414
        Me.label9.Text = "Importe"
        '
        'txtidarancel
        '
        Me.txtidarancel.Location = New System.Drawing.Point(86, 102)
        Me.txtidarancel.MaxLength = 8
        Me.txtidarancel.Name = "txtidarancel"
        Me.txtidarancel.Size = New System.Drawing.Size(186, 20)
        Me.txtidarancel.TabIndex = 412
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(5, 105)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(79, 13)
        Me.label17.TabIndex = 418
        Me.label17.Text = "Codigo Arancel"
        '
        'btnguardaralta
        '
        Me.btnguardaralta.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaralta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaralta.Location = New System.Drawing.Point(51, 266)
        Me.btnguardaralta.Name = "btnguardaralta"
        Me.btnguardaralta.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaralta.TabIndex = 419
        Me.btnguardaralta.UseVisualStyleBackColor = True
        Me.btnguardaralta.Visible = False
        '
        'btnguardaredicion
        '
        Me.btnguardaredicion.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardaredicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardaredicion.Location = New System.Drawing.Point(51, 266)
        Me.btnguardaredicion.Name = "btnguardaredicion"
        Me.btnguardaredicion.Size = New System.Drawing.Size(60, 60)
        Me.btnguardaredicion.TabIndex = 422
        Me.btnguardaredicion.UseVisualStyleBackColor = True
        Me.btnguardaredicion.Visible = False
        '
        'btnguardarbaja
        '
        Me.btnguardarbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.guardar
        Me.btnguardarbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardarbaja.Location = New System.Drawing.Point(51, 266)
        Me.btnguardarbaja.Name = "btnguardarbaja"
        Me.btnguardarbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnguardarbaja.TabIndex = 421
        Me.btnguardarbaja.UseVisualStyleBackColor = True
        Me.btnguardarbaja.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 163)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 415
        Me.label4.Text = "Nombre"
        '
        'txtnombrearancel
        '
        Me.txtnombrearancel.Location = New System.Drawing.Point(86, 160)
        Me.txtnombrearancel.Name = "txtnombrearancel"
        Me.txtnombrearancel.Size = New System.Drawing.Size(186, 20)
        Me.txtnombrearancel.TabIndex = 410
        '
        'frmabmaranceles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 365)
        Me.Controls.Add(Me.cbxinstitucion)
        Me.Controls.Add(Me.lblmbaja)
        Me.Controls.Add(Me.lblbaja)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.lblnuevo)
        Me.Controls.Add(Me.txtprecioarancel)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.txtidarancel)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.btnguardaralta)
        Me.Controls.Add(Me.btnguardaredicion)
        Me.Controls.Add(Me.btnguardarbaja)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtnombrearancel)
        Me.Name = "frmabmaranceles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aranceles"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxinstitucion As ComboBox
    Public WithEvents lblmbaja As Label
    Public WithEvents lblbaja As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents erroricono As ErrorProvider
    Public WithEvents lblmodificar As Label
    Public WithEvents lblnuevo As Label
    Public WithEvents txtprecioarancel As TextBox
    Public WithEvents label9 As Label
    Public WithEvents txtidarancel As TextBox
    Public WithEvents label17 As Label
    Public WithEvents btnguardaralta As Button
    Public WithEvents btnguardaredicion As Button
    Public WithEvents btnguardarbaja As Button
    Public WithEvents label4 As Label
    Public WithEvents txtnombrearancel As TextBox
End Class
