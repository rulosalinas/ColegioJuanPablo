<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmalumno
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
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbxbusqueda = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnestadoactivo = New System.Windows.Forms.Button()
        Me.btnestadoinactivo = New System.Windows.Forms.Button()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblayuda = New System.Windows.Forms.Label()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(551, 78)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(55, 13)
        Me.Label32.TabIndex = 347
        Me.Label32.Text = "Busqueda"
        '
        'cbxbusqueda
        '
        Me.cbxbusqueda.FormattingEnabled = True
        Me.cbxbusqueda.Items.AddRange(New Object() {"DNI", "Apellido"})
        Me.cbxbusqueda.Location = New System.Drawing.Point(791, 74)
        Me.cbxbusqueda.Name = "cbxbusqueda"
        Me.cbxbusqueda.Size = New System.Drawing.Size(62, 21)
        Me.cbxbusqueda.TabIndex = 1
        Me.cbxbusqueda.Text = "DNI"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(614, 75)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(162, 20)
        Me.txtbuscar.TabIndex = 0
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.SystemColors.Control
        Me.inexistente.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.LinkColor = System.Drawing.Color.Red
        Me.inexistente.Location = New System.Drawing.Point(311, 208)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(214, 17)
        Me.inexistente.TabIndex = 6
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "NO SE ENCONTRARON DATOS"
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(614, 415)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 11
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.CECULD2
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(744, 394)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(119, 81)
        Me.pictureBox2.TabIndex = 331
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(11, 395)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 80)
        Me.pictureBox1.TabIndex = 330
        Me.pictureBox1.TabStop = False
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cancelar
        Me.btnbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbaja.Location = New System.Drawing.Point(458, 415)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnbaja.TabIndex = 9
        Me.btnbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.modificar
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditar.Location = New System.Drawing.Point(378, 415)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(60, 60)
        Me.btneditar.TabIndex = 8
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Agregar
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnuevo.Location = New System.Drawing.Point(293, 415)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(60, 60)
        Me.btnnuevo.TabIndex = 7
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(12, 122)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(852, 257)
        Me.datalistado.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(309, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "LISTADO DE ALUMNOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnestadoactivo
        '
        Me.btnestadoactivo.BackColor = System.Drawing.Color.LimeGreen
        Me.btnestadoactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnestadoactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnestadoactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnestadoactivo.Location = New System.Drawing.Point(13, 66)
        Me.btnestadoactivo.Name = "btnestadoactivo"
        Me.btnestadoactivo.Size = New System.Drawing.Size(160, 30)
        Me.btnestadoactivo.TabIndex = 353
        Me.btnestadoactivo.Text = "ALUMNO ACTIVO"
        Me.btnestadoactivo.UseVisualStyleBackColor = False
        '
        'btnestadoinactivo
        '
        Me.btnestadoinactivo.BackColor = System.Drawing.Color.Red
        Me.btnestadoinactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnestadoinactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnestadoinactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnestadoinactivo.Location = New System.Drawing.Point(13, 66)
        Me.btnestadoinactivo.Name = "btnestadoinactivo"
        Me.btnestadoinactivo.Size = New System.Drawing.Size(160, 30)
        Me.btnestadoinactivo.TabIndex = 354
        Me.btnestadoinactivo.Text = "ALUMNO INACTIVO"
        Me.btnestadoinactivo.UseVisualStyleBackColor = False
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(831, 18)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(33, 20)
        Me.txtflag.TabIndex = 358
        Me.txtflag.Text = "0"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 359
        Me.CheckBox1.Text = "Todos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblayuda
        '
        Me.lblayuda.AutoSize = True
        Me.lblayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblayuda.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblayuda.Location = New System.Drawing.Point(260, 103)
        Me.lblayuda.Name = "lblayuda"
        Me.lblayuda.Size = New System.Drawing.Size(346, 16)
        Me.lblayuda.TabIndex = 360
        Me.lblayuda.Text = "DOBLE CLICK PARA SELECCIONAR EL ALUMNO"
        Me.lblayuda.Visible = False
        '
        'frmalumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 489)
        Me.Controls.Add(Me.lblayuda)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.btnestadoactivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbxbusqueda)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.btnestadoinactivo)
        Me.Name = "frmalumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents cbxbusqueda As System.Windows.Forms.ComboBox
    Private WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btnbaja As System.Windows.Forms.Button
    Private WithEvents btneditar As System.Windows.Forms.Button
    Private WithEvents btnnuevo As System.Windows.Forms.Button
    Private WithEvents datalistado As System.Windows.Forms.DataGridView
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnestadoactivo As System.Windows.Forms.Button
    Friend WithEvents btnestadoinactivo As System.Windows.Forms.Button
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblayuda As System.Windows.Forms.Label
End Class
