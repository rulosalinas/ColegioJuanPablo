Imports System.Data
Imports System.Data.SqlClient
Public Class frminscripciones
    Private dt As New DataTable
    Private Sub fmrinscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnguardaralta.Visible = False
        btnguardarbaja.Visible = False
        btnguardaredicion.Visible = False
        btnbuscaralumno.Enabled = False
        txtdni.ReadOnly = True
        txtapellido.ReadOnly = True
        txtnombre.ReadOnly = True


        mostrar()
        llenarcombo()
        cargardatos()

    End Sub
    Public Sub limpiar()
        txtidinscripcion.Text = ""
        txtidalumno.Text = ""
        txtdni.Text = ""
        txtapellido.Text = ""
        txtnombre.Text = ""
        cbxinstitucion.Text = ""
        cbxnivel.Text = ""
        cbxcarrera.Text = ""
        cbxcurso.Text = ""
        cbxdivision.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New finscripciones
            dt = func.mostrar
            dginscripcion.Columns.Item(0).Visible = False 'ocultar columna de eliminar


            If dt.Rows.Count <> 0 Then
                dginscripcion.DataSource = dt
                txtbuscar.Enabled = True               '--habilita opciones de busqueda despues de comprobar que en la base hay elemento
                dginscripcion.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dginscripcion.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
                txtbuscar.Enabled = False
                dginscripcion.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'buscar()
    End Sub
    Private Sub buscar()

        Try
            Dim func As New finscripciones
            dt = func.buscar(cbxbusqueda.Text, txtbuscar.Text, dginscripcion)

            If dt.Rows.Count <> 0 Then    '-- comprobar que los registros exixtan
                dginscripcion.DataSource = dt
                dginscripcion.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else ' -- no se encuentran registros
                dginscripcion.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
                dginscripcion.ColumnHeadersVisible = False
                inexistente.Visible = True
                
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        dginscripcion.Columns(1).Visible = False '--oculta columna n°1 id
        dginscripcion.Columns(7).Visible = False
        dginscripcion.Columns(9).Visible = False
        dginscripcion.Columns(11).Visible = False
        dginscripcion.Columns(13).Visible = False
        dginscripcion.Columns(15).Visible = False
    End Sub
    Public Sub llenarcombo()
        'Dim cmd As New SqlCommand

        Try
            Dim func As New finscripciones
            dt = func.llenarinstitucion
            cbxinstitucion.DataSource = dt
            cbxinstitucion.DisplayMember = "nombre_inst"
            cbxinstitucion.ValueMember = "id_inst"

        Catch ex As Exception
            MsgBox("error" + ex.Message)
        End Try
    End Sub

    Private Sub cbxinstitucion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxinstitucion.SelectedIndexChanged
        Dim dts As New vinscripciones
        Dim func As New finscripciones
        Try
            dts.gidinstitucion = cbxinstitucion.SelectedValue.ToString

            dt = func.llenarnivel(dts)
            cbxnivel.DataSource = dt
            cbxnivel.DisplayMember = "nombre_nivel"
            cbxnivel.ValueMember = "id_nivel"
        Catch ex As Exception
            MsgBox("error" + ex.Message)
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
            MsgBox("error" + ex.Message)
        End Try
    End Sub

    Private Sub cbxcarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcarrera.SelectedIndexChanged
        Dim dts As New vinscripciones
        Dim func As New finscripciones
        Try
            dts.gidcarrera = Val(cbxcarrera.SelectedValue.ToString)

            dt = func.llenarcurso(dts)
            cbxcurso.DataSource = dt
            cbxcurso.DisplayMember = "nombre_curso"
            cbxcurso.ValueMember = "id_curso"
        Catch ex As Exception
            MsgBox("error" + ex.Message)
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
            MsgBox("error" + ex.Message)
        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
    'validacion de cajas de Texto

    Private Sub txtdni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Datos Obligatorios")
        End If

    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        'mostrar()
            limpiar()
            btnguardaralta.Visible = True
            btnguardarbaja.Visible = False
            btnguardaredicion.Visible = False
            btneditar.Enabled = False
            btnbaja.Enabled = False
            btnnuevo.Enabled = False
            btnbuscaralumno.Enabled = True
            dginscripcion.Enabled = False


    End Sub

    Private Sub dginscripcion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dginscripcion.CellClick
        cargardatos()
    End Sub

    Public Sub cargardatos()
        txtidinscripcion.Text = dginscripcion.SelectedCells.Item(1).Value
        txtidalumno.Text = dginscripcion.SelectedCells.Item(2).Value
        txtdni.Text = dginscripcion.SelectedCells.Item(3).Value
        txtapellido.Text = dginscripcion.SelectedCells.Item(4).Value
        txtnombre.Text = dginscripcion.SelectedCells.Item(5).Value 'item 6 estado del alumno
        cbxinstitucion.Text = dginscripcion.SelectedCells.Item(8).Value '7 cod inst
        cbxnivel.Text = dginscripcion.SelectedCells.Item(10).Value '9 id nivel
        cbxcarrera.Text = dginscripcion.SelectedCells.Item(12).Value '11idcarrera
        cbxcurso.Text = dginscripcion.SelectedCells.Item(14).Value '13 id curso
        cbxdivision.Text = dginscripcion.SelectedCells.Item(16).Value '15 iddiviion
        dtfinscripcion.Text = dginscripcion.SelectedCells.Item(17).Value
    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" Then
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


                If func.insertar(dts) Then
                    MessageBox.Show("El Alumno fue Inscripto Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    'limpiar()
                    btnguardaralta.Visible = False
                    btnguardarbaja.Visible = False
                    btnguardaredicion.Visible = False
                    btneditar.Enabled = True
                    btnbaja.Enabled = True
                    btnnuevo.Enabled = True
                    btnbuscaralumno.Enabled = False
                    dginscripcion.Enabled = True

                    'guarda y llama al formlario pagos
                    frmpagos.ShowDialog()


                Else
                    MessageBox.Show("El Alumno no fue Inscipto", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    'limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta Seguro que Desea Editar los Datos?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            mostrar()
            btnnuevo.Enabled = False
            btnbaja.Enabled = False
            btneditar.Enabled = False
            btnguardaralta.Visible = False
            btnguardarbaja.Visible = False
            btnguardaredicion.Visible = True
            btnbuscaralumno.Enabled = True
            dginscripcion.Enabled = False
        End If
    End Sub

    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtidalumno.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" Then
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

                If func.editar(dts) Then
                    MessageBox.Show("Inscripcion Modificada Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    'limpiar()
                    btnguardaralta.Visible = False
                    btnguardarbaja.Visible = False
                    btnguardaredicion.Visible = False
                    btneditar.Enabled = True
                    btnbaja.Enabled = True
                    btnnuevo.Enabled = True
                    btnbuscaralumno.Enabled = False
                    dginscripcion.Enabled = True

                Else
                    MessageBox.Show("Inscripcion no Modificada", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    'limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta Seguro que Desea Eliminar la Inscripcion?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            mostrar()
            btnnuevo.Enabled = False
            btnbaja.Enabled = False
            btneditar.Enabled = False
            btnguardaralta.Visible = False
            btnguardarbaja.Visible = True
            btnguardaredicion.Visible = False
            dginscripcion.Enabled = False


        Else
            MessageBox.Show("Cancelando Eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrar()
        End If

    End Sub

    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click

        Try
            Dim dts As New vinscripciones
            Dim func As New finscripciones

            dts.gidinscripcion = CInt(txtidinscripcion.Text)

            If func.eliminar(dts) Then
                MessageBox.Show("Inscripcion Eliminada Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                'limpiar()
                btnguardaralta.Visible = False
                btnguardarbaja.Visible = False
                btnguardaredicion.Visible = False
                btneditar.Enabled = True
                btnbaja.Enabled = True
                btnnuevo.Enabled = True
                btnbuscaralumno.Enabled = False
                dginscripcion.Enabled = True

            Else
                MessageBox.Show("Inscripcion no Eliminada", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mostrar()
                'limpiar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnbuscaralumno_Click(sender As Object, e As EventArgs) Handles btnbuscaralumno.Click
        Dim frm As New frmalumno
        frm.txtflag.Text = "1"
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub


End Class