<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carreras
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
        Me.lblayuda = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbxbusqueda = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblayuda
        '
        Me.lblayuda.AutoSize = True
        Me.lblayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblayuda.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblayuda.Location = New System.Drawing.Point(281, 103)
        Me.lblayuda.Name = "lblayuda"
        Me.lblayuda.Size = New System.Drawing.Size(356, 16)
        Me.lblayuda.TabIndex = 404
        Me.lblayuda.Text = "DOBLE CLICK PARA SELECCIONAR LA CARRERA"
        Me.lblayuda.Visible = False
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(830, 17)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(33, 20)
        Me.txtflag.TabIndex = 403
        Me.txtflag.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(307, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 30)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "LISTADO DE CARRERAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(568, 67)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(55, 13)
        Me.Label32.TabIndex = 402
        Me.Label32.Text = "Busqueda"
        '
        'cbxbusqueda
        '
        Me.cbxbusqueda.FormattingEnabled = True
        Me.cbxbusqueda.Items.AddRange(New Object() {"Nombre", "Institucion"})
        Me.cbxbusqueda.Location = New System.Drawing.Point(808, 63)
        Me.cbxbusqueda.Name = "cbxbusqueda"
        Me.cbxbusqueda.Size = New System.Drawing.Size(62, 21)
        Me.cbxbusqueda.TabIndex = 392
        Me.cbxbusqueda.Text = "Nombre"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(631, 64)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(162, 20)
        Me.txtbuscar.TabIndex = 391
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.SystemColors.Control
        Me.inexistente.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.LinkColor = System.Drawing.Color.Red
        Me.inexistente.Location = New System.Drawing.Point(356, 228)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(214, 17)
        Me.inexistente.TabIndex = 394
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "NO SE ENCONTRARON DATOS"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(9, 131)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(854, 231)
        Me.datalistado.TabIndex = 393
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Vista__68_
        Me.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncerrar.Location = New System.Drawing.Point(635, 412)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 60)
        Me.btncerrar.TabIndex = 398
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.CECULD2
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(733, 391)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(119, 81)
        Me.pictureBox2.TabIndex = 401
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(8, 392)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 80)
        Me.pictureBox1.TabIndex = 400
        Me.pictureBox1.TabStop = False
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnbaja.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.cancelar
        Me.btnbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbaja.Location = New System.Drawing.Point(459, 412)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(60, 60)
        Me.btnbaja.TabIndex = 397
        Me.btnbaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.modificar
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditar.Location = New System.Drawing.Point(379, 412)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(60, 60)
        Me.btneditar.TabIndex = 396
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.Agregar
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnuevo.Location = New System.Drawing.Point(294, 412)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(60, 60)
        Me.btnnuevo.TabIndex = 395
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Carreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 489)
        Me.Controls.Add(Me.lblayuda)
        Me.Controls.Add(Me.txtflag)
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
        Me.Name = "Carreras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carreras"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblayuda As System.Windows.Forms.Label
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
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
End Class
