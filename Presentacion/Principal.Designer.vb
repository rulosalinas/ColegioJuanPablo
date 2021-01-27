<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnconsultas = New System.Windows.Forms.Button()
        Me.btnconfiguracion = New System.Windows.Forms.Button()
        Me.btninscripcion = New System.Windows.Forms.Button()
        Me.btnpagos = New System.Windows.Forms.Button()
        Me.btnmovimientos = New System.Windows.Forms.Button()
        Me.btnvarios = New System.Windows.Forms.Button()
        Me.btnalumno = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.btnconsultas)
        Me.panel1.Controls.Add(Me.btnconfiguracion)
        Me.panel1.Controls.Add(Me.btninscripcion)
        Me.panel1.Controls.Add(Me.btnpagos)
        Me.panel1.Controls.Add(Me.btnmovimientos)
        Me.panel1.Controls.Add(Me.btnvarios)
        Me.panel1.Controls.Add(Me.btnalumno)
        Me.panel1.Location = New System.Drawing.Point(43, 39)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(110, 511)
        Me.panel1.TabIndex = 11
        '
        'btnconsultas
        '
        Me.btnconsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnconsultas.BackgroundImage = CType(resources.GetObject("btnconsultas.BackgroundImage"), System.Drawing.Image)
        Me.btnconsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconsultas.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultas.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnconsultas.Location = New System.Drawing.Point(3, 218)
        Me.btnconsultas.Name = "btnconsultas"
        Me.btnconsultas.Size = New System.Drawing.Size(100, 70)
        Me.btnconsultas.TabIndex = 18
        Me.btnconsultas.Text = "CONSULTAS"
        Me.btnconsultas.UseVisualStyleBackColor = False
        '
        'btnconfiguracion
        '
        Me.btnconfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnconfiguracion.BackgroundImage = CType(resources.GetObject("btnconfiguracion.BackgroundImage"), System.Drawing.Image)
        Me.btnconfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfiguracion.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfiguracion.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnconfiguracion.Location = New System.Drawing.Point(3, 434)
        Me.btnconfiguracion.Name = "btnconfiguracion"
        Me.btnconfiguracion.Size = New System.Drawing.Size(100, 70)
        Me.btnconfiguracion.TabIndex = 17
        Me.btnconfiguracion.Text = "CONFIGUARCION"
        Me.btnconfiguracion.UseVisualStyleBackColor = False
        '
        'btninscripcion
        '
        Me.btninscripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btninscripcion.BackgroundImage = CType(resources.GetObject("btninscripcion.BackgroundImage"), System.Drawing.Image)
        Me.btninscripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btninscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninscripcion.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninscripcion.ForeColor = System.Drawing.Color.DarkCyan
        Me.btninscripcion.Location = New System.Drawing.Point(3, 74)
        Me.btninscripcion.Name = "btninscripcion"
        Me.btninscripcion.Size = New System.Drawing.Size(100, 70)
        Me.btninscripcion.TabIndex = 15
        Me.btninscripcion.Text = "INSCRIPCION"
        Me.btninscripcion.UseVisualStyleBackColor = False
        '
        'btnpagos
        '
        Me.btnpagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnpagos.BackgroundImage = CType(resources.GetObject("btnpagos.BackgroundImage"), System.Drawing.Image)
        Me.btnpagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpagos.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpagos.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnpagos.Location = New System.Drawing.Point(3, 146)
        Me.btnpagos.Name = "btnpagos"
        Me.btnpagos.Size = New System.Drawing.Size(100, 70)
        Me.btnpagos.TabIndex = 12
        Me.btnpagos.Text = "PAGOS"
        Me.btnpagos.UseVisualStyleBackColor = False
        '
        'btnmovimientos
        '
        Me.btnmovimientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmovimientos.BackgroundImage = CType(resources.GetObject("btnmovimientos.BackgroundImage"), System.Drawing.Image)
        Me.btnmovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmovimientos.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmovimientos.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnmovimientos.Location = New System.Drawing.Point(3, 362)
        Me.btnmovimientos.Name = "btnmovimientos"
        Me.btnmovimientos.Size = New System.Drawing.Size(100, 70)
        Me.btnmovimientos.TabIndex = 13
        Me.btnmovimientos.Text = "Movimientos"
        Me.btnmovimientos.UseVisualStyleBackColor = False
        '
        'btnvarios
        '
        Me.btnvarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnvarios.BackgroundImage = CType(resources.GetObject("btnvarios.BackgroundImage"), System.Drawing.Image)
        Me.btnvarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvarios.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvarios.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnvarios.Location = New System.Drawing.Point(3, 290)
        Me.btnvarios.Name = "btnvarios"
        Me.btnvarios.Size = New System.Drawing.Size(100, 70)
        Me.btnvarios.TabIndex = 14
        Me.btnvarios.Text = "Varios"
        Me.btnvarios.UseVisualStyleBackColor = False
        '
        'btnalumno
        '
        Me.btnalumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnalumno.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.btn2
        Me.btnalumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnalumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnalumno.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalumno.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnalumno.Location = New System.Drawing.Point(3, 2)
        Me.btnalumno.Name = "btnalumno"
        Me.btnalumno.Size = New System.Drawing.Size(100, 70)
        Me.btnalumno.TabIndex = 11
        Me.btnalumno.Text = "ALUMNO"
        Me.btnalumno.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.groupBox1.Controls.Add(Me.lblfecha)
        Me.groupBox1.Controls.Add(Me.lblhora)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.groupBox1.Location = New System.Drawing.Point(48, 582)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(110, 75)
        Me.groupBox1.TabIndex = 16
        Me.groupBox1.TabStop = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(5, 18)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(0, 25)
        Me.lblfecha.TabIndex = 13
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(30, 48)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(0, 20)
        Me.lblhora.TabIndex = 14
        '
        'Timer1
        '
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_CECULD.My.Resources.Resources.CECULD_FONDO
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 702)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Cobro Cuota"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnconsultas As System.Windows.Forms.Button
    Private WithEvents btnconfiguracion As System.Windows.Forms.Button
    Private WithEvents btninscripcion As System.Windows.Forms.Button
    Private WithEvents btnpagos As System.Windows.Forms.Button
    Private WithEvents btnmovimientos As System.Windows.Forms.Button
    Private WithEvents btnvarios As System.Windows.Forms.Button
    Private WithEvents btnalumno As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblfecha As System.Windows.Forms.Label
    Private WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
