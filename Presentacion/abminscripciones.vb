Imports System.Data
Imports System.Data.SqlClient
Public Class frmabminscripciones
    Private dt As New DataTable
    Private Sub abminscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtanio.Text = Now.Year
        dtfinscripcion.Value = Now

        txtdni.ReadOnly = True
        txtnombre.ReadOnly = True

        'Me.lblfecha.Text = String.Format("{0:dd:mm:aaaa}", DateTime.Now)
        'Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        Timer1.Interval = 1000
        Timer1.Start()
        'llenarcombo()
    End Sub

    Public Sub limpiar()
        txtidinscripcion.Text = ""
        txtidalumno.Text = ""
        txtdni.Text = ""
        txtnombre.Text = ""
        cbxinstitucion.Text = ""
        cbxnivel.Text = ""
        cbxcarrera.Text = ""
        cbxcurso.Text = ""
        cbxdivision.Text = ""
    End Sub
    Private Sub txtdni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Datos Obligatorios")
        End If

    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    Public Sub llenarcombo()

        Try
            Dim func As New finscripciones
            dt = func.llenarinstitucion
            cbxinstitucion.DataSource = dt
            cbxinstitucion.DisplayMember = "nombre_inst"
            cbxinstitucion.ValueMember = "id_inst"

        Catch ex As Exception
            MsgBox("Error Llenar Combo " + ex.Message)
        End Try
    End Sub


    Private Sub cbxinstitucion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxinstitucion.SelectedValueChanged
        Dim dts As New vinscripciones
        Dim func As New finscripciones
        Try
            dts.gidinstitucion = cbxinstitucion.SelectedValue.ToString

            dt = func.llenarnivel(dts)
            cbxnivel.DataSource = dt
            cbxnivel.DisplayMember = "nombre_nivel"
            cbxnivel.ValueMember = "id_nivel"
        Catch ex As Exception
            MsgBox("Error Llenar Institucion " + ex.Message)
        End Try
    End Sub

    Private Sub cbxnivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxnivel.SelectedIndexChanged
        Dim dts As New vinscripciones
        Dim func As New finscripciones
        Try
            dts.gidnivel = Val(cbxnivel.SelectedValue.ToString)

            dt = func.llenarcarrera(dts)
            cbxcarrera.DataSource = dt
            cbxcarrera.DisplayMember = "nombre_carrera"
            cbxcarrera.ValueMember = "id_carrera"
        Catch ex As Exception
            MsgBox("Error Llenar Nivel " + ex.Message)
        End Try
    End Sub

    Private Sub cbxcarrera_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxcarrera.SelectedValueChanged

        Dim dts As New vinscripciones
        Dim func As New finscripciones
        Try
            dts.gidcarrera = Val(cbxcarrera.SelectedValue.ToString)

            dt = func.llenarcurso(dts)
            cbxcurso.DataSource = dt
            cbxcurso.DisplayMember = "nombre_curso"
            cbxcurso.ValueMember = "id_curso"

        Catch ex As Exception
            MsgBox("Error Llenar Carrera " + ex.Message)
        End Try
    End Sub

   
    Private Sub cbxcurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcurso.SelectedIndexChanged
        Dim dts As New vinscripciones
        Dim func As New finscripciones
        Try
            dts.gidcurso = Val(cbxcurso.SelectedValue.ToString)

            dt = func.llenardivision(dts)
            cbxdivision.DataSource = dt
            cbxdivision.DisplayMember = "nombre_division"
            cbxdivision.ValueMember = "id_division"
        Catch ex As Exception
            MsgBox("Error Llenar Curso " + ex.Message)
        End Try
    End Sub
    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdni.Text <> "" Then
            Try
                Dim dts As New vinscripciones
                Dim func As New finscripciones

                dts.gidalumno = CInt(txtidalumno.Text)
                dts.gidinstitucion = cbxinstitucion.SelectedValue.ToString
                dts.gidnivel = CInt(cbxnivel.SelectedValue.ToString)
                dts.gidcarrera = CInt(cbxcarrera.SelectedValue.ToString)
                dts.gidcurso = CInt(cbxcurso.SelectedValue.ToString)
                dts.giddivision = CInt(cbxdivision.SelectedValue.ToString)
                dts.gfinscripcion = Convert.ToDateTime(dtfinscripcion.Value)
                dts.ganio = txtanio.Text


                If func.insertar(dts) Then
                    'MessageBox.Show("El Alumno fue Inscripto Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnbuscaralumno.Visible = False
                    btnguardaralta.Visible = False
                    lblnuevo.Visible = False
                    btnbuscaralumno.Enabled = False

                    'guarda y llama al formlario pagos
                    frmabmpagos.ShowDialog()
                    Me.Close()

                Else
                    MessageBox.Show("El Alumno no fue Inscipto", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox("Error Nuevo Alumno" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtidalumno.Text <> "" And txtnombre.Text <> "" And txtdni.Text <> "" Then
            Try
                Dim dts As New vinscripciones
                Dim func As New finscripciones

                dts.gidinscripcion = CInt(txtidinscripcion.Text)
                dts.gidalumno = CInt(txtidalumno.Text)
                dts.gidinstitucion = cbxinstitucion.SelectedValue.ToString
                dts.gidnivel = CInt(cbxnivel.SelectedValue.ToString)
                dts.gidcarrera = CInt(cbxcarrera.SelectedValue.ToString)
                dts.gidcurso = CInt(cbxcurso.SelectedValue.ToString)
                dts.giddivision = CInt(cbxdivision.SelectedValue.ToString)
                dts.gfinscripcion = Convert.ToDateTime(dtfinscripcion.Value)
                dts.ganio = txtanio.Text

                If func.editar(dts) Then
                    MessageBox.Show("Inscripcion Modificada Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaredicion.Visible = False
                    lblmodificar.Visible = False
                    Me.Close()

                Else
                    MessageBox.Show("Inscripcion no Modificada", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Editar Alumno" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click

        Try
            Dim dts As New vinscripciones
            Dim func As New finscripciones

            dts.gidinscripcion = CInt(txtidinscripcion.Text)

            If func.eliminar(dts) Then
                MessageBox.Show("Inscripcion Eliminada Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                lblbaja.Visible = False
                btnguardarbaja.Visible = False
                Me.Close()
            Else
                MessageBox.Show("Inscripcion no Eliminada", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error Eliminar Alumno" + ex.Message)
        End Try
    End Sub

    Private Sub btnbuscaralumno_Click_1(sender As Object, e As EventArgs) Handles btnbuscaralumno.Click
        Dim frm As New frmalumno
        frm.txtflag.Text = "1"
        frm.lblayuda.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblfecha.Text = DateTime.Now.ToShortDateString()
        Me.lblhora.Text = DateTime.Now.ToLongTimeString()

    End Sub
End Class