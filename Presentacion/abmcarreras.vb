Public Class abmcarreras

    Private Sub abmcarreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcombo()
    End Sub
    Private dt As New DataTable
    Public Sub limpiar()
        txtidcarrera.Text = ""
        txtnombre.Text = ""
        txtresolucion.Text = ""
        txtduracion.Text = ""

    End Sub
    Public Sub llenarcombo()

        Try
            Dim func As New fcarreras
            dt = func.llenarinstitucion
            cbxinstitucion.DataSource = dt
            cbxinstitucion.DisplayMember = "nombre_inst"
            cbxinstitucion.ValueMember = "id_inst"

        Catch ex As Exception
            MsgBox("Error Llenar Combo " + ex.Message)
        End Try
    End Sub
    Private Sub cbxinstitucion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxinstitucion.SelectedValueChanged
        Dim dts As New vcarreras
        Dim func As New fcarreras
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

    Private Sub txtprecioarancel_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtresolucion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    Private Sub txtduracion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtduracion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtresolucion.Text <> "" Then
            Try
                Dim dts As New vcarreras
                Dim func As New fcarreras

                dts.gidnivel = cbxnivel.SelectedValue.ToString
                dts.gnombrecarrera = UCase(txtnombre.Text)
                dts.gresolucion = UCase(txtresolucion.Text)
                dts.gduracion = CInt(txtduracion.Text)

                If func.insertar(dts) Then
                    'MessageBox.Show("La Carrera se Agrego Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaralta.Visible = False
                    lblnuevo.Visible = False
                    Me.Close()

                    'Else
                    '    MessageBox.Show("La Carrera no fue Registrada", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Nuevo Carrera" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtresolucion.Text <> "" And txtduracion.Text <> "" Then
            Try
                Dim dts As New vcarreras
                Dim func As New fcarreras

                dts.gidcarrera = CInt(txtidcarrera.Text)
                dts.gidnivel = cbxnivel.SelectedValue.ToString
                dts.gnombrecarrera = UCase(txtnombre.Text)
                dts.gresolucion = UCase(txtresolucion.Text)
                dts.gduracion = CInt(txtduracion.Text)


                If func.editar(dts) Then
                    'MessageBox.Show("La Carrera Fue Modificada Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    btnguardaredicion.Visible = False
                    lblmodificar.Visible = False
                    Me.Close()
                    'Else
                    '    MessageBox.Show("La Carrera no fue Modificada", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Editar Carrera" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click

        Try
            Dim dts As New vcarreras
            Dim func As New fcarreras

            dts.gidcarrera = CInt(txtidcarrera.Text)


            If func.eliminar(dts) Then
                MessageBox.Show("La Carrera Fue Eliminada Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiar()
                limpiar()
                lblbaja.Visible = False
                btnguardarbaja.Visible = False
                Me.Close()

            Else
                MessageBox.Show("La Carrera No fue Eliminada", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error Eliminar Carrera" + ex.Message)
        End Try

    End Sub

    Private Sub button29_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub



End Class