Public Class frmabmalumnos

    Private Sub frmabmalumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtfalta.Value = Now
        dtfbaja.Value = Now
    End Sub
    Public Sub limpiar()
        txtidalumno.Text = ""
        txtapellido.Text = ""
        txtnombre.Text = ""
        txtdomicilio.Text = ""
        txtdni.Text = ""
        cbxsexo.Text = ""
        txttelefono.Text = ""
        txtlocalidad.Text = ""
    End Sub
    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Validaciones para que las cajas de texto no esten vacias
    Private Sub txtapellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtapellido.Validating
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
    'ingresar solo letras en el nombre
    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'validar que solo se ingresen numeros en el dni
    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtdni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    'validar que se ingresen numeros en el telefono
    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtdnitutor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdnitutor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    Private Sub txtnombretutor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombretutor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And txtdomicilio.Text <> "" And txtlocalidad.Text <> "" And txttelefono.Text <> "" And txtdnitutor.Text <> "" And txtnombretutor.Text <> "" Then
            Try
                Dim dts As New valumnos
                Dim func As New falumnos

                dts.gapellidos = UCase(txtapellido.Text)    'ucase convierte la caja de texto en mayuscula y lcase en minuscula 
                dts.gnombres = UCase(txtnombre.Text)
                dts.gdni = txtdni.Text
                dts.gfnacimiento = Convert.ToDateTime(dtfnacimiento.Text)
                dts.gdomicilio = UCase(txtdomicilio.Text)
                dts.glocalidad = UCase(txtlocalidad.Text)
                dts.gsexo = cbxsexo.Text
                dts.gtelefono = txttelefono.Text
                dts.gfalta = Convert.ToDateTime(dtfalta.Text)
                dts.gdnitutor = CInt(txtdnitutor.Text)

                If func.insertar(dts) Then
                    MessageBox.Show("El Alumno se Registro Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaralta.Visible = False
                    lblnuevo.Visible = False
                    btnbuscartutor.Visible = False

                    Me.Close()

                Else
                    MessageBox.Show("El Alumno no fue Registrado", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtidalumno.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And txtdomicilio.Text <> "" And txtlocalidad.Text <> "" And txttelefono.Text <> "" And txtdnitutor.Text <> "" And txtnombretutor.Text <> "" Then
            Try
                Dim dts As New valumnos
                Dim func As New falumnos

                dts.gidalumno = txtidalumno.Text
                dts.gapellidos = UCase(txtapellido.Text)    'ucase convierte la caja de texto en mayuscula y lcase en minuscula 
                dts.gnombres = UCase(txtnombre.Text)
                dts.gdni = txtdni.Text
                dts.gfnacimiento = Convert.ToDateTime(dtfnacimiento.Text)
                dts.gdomicilio = UCase(txtdomicilio.Text)
                dts.glocalidad = UCase(txtlocalidad.Text)
                dts.gsexo = cbxsexo.Text
                dts.gtelefono = txttelefono.Text
                dts.gfalta = Convert.ToDateTime(dtfalta.Text)
                dts.gdnitutor = CInt(txtdnitutor.Text)

                If func.editar(dts) Then
                    MessageBox.Show("El Alumno Fue Modificado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    btnguardaredicion.Visible = False
                    lblmodificar.Visible = False
                    btnbuscartutor.Visible = False

                    Me.Close()
                Else
                    MessageBox.Show("El Alumno no fue Modificado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click
        If Me.ValidateChildren = True And txtidalumno.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And txtdomicilio.Text <> "" And txtlocalidad.Text <> "" And txttelefono.Text <> "" Then
            Try
                Dim dts As New valumnos
                Dim func As New falumnos

                dts.gidalumno = txtidalumno.Text
                dts.gestado = "INACTIVO"
                dts.gfbaja = Convert.ToDateTime(dtfbaja.Text)
                dts.gmotivobaja = UCase(txtmbaja.Text)


                If func.baja(dts) Then
                    MessageBox.Show("El Alumno Fue dado de Baja Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    gbbaja.Visible = False
                    lblmbaja.Visible = False
                    lblbaja.Visible = False
                    lblfbaja.Visible = False
                    txtmbaja.Visible = False
                    dtfbaja.Visible = False
                    btnguardarbaja.Visible = False
                    Me.Close()

                Else
                    MessageBox.Show("El Alumno no fue dado de Baja", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub button29_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscartutor.Click
        Dim frm As New frmtutor
        frm.txtflag.Text = "1"
        frm.lblayuda.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

End Class