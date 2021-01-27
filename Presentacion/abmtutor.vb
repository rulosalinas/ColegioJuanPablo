Public Class frmabmtutor
    Private dt As New DataTable
    Public Sub limpiar()
        txtdni.Text = ""
        txtapellido.Text = ""
        txtnombre.Text = ""
        txtdomicilio.Text = ""
        cbxparentesco.Text = ""
        txttelefono.Text = ""
        txtdomicilio.Text = ""
        txtlocalidad.Text = ""
        txtnombre2.Text = ""
        txttelefono2.Text = ""
        txtnombre3.Text = ""
        txttelefono3.Text = ""
    End Sub
    'Validaciones para que las cajas de texto no esten vacias
    Private Sub txtdni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
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

    Private Sub txtapellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
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
    Private Sub txttelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    Private Sub txttelefono_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
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

    'validar que se ingresen numeros en el telefono
    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    Private Sub txtdomicilio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdomicilio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub
    Private Sub txtlocalidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtlocalidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtdni.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txttelefono.Text <> "" And txtdomicilio.Text <> "" And txtlocalidad.Text <> "" Then
            Try
                Dim dts As New vtutor
                Dim func As New ftutor

                dts.gdnitutor = CInt(txtdni.Text)
                dts.gapellidotutor = UCase(txtapellido.Text)
                dts.gnombretutor = UCase(txtnombre.Text)
                dts.gdomtutor = UCase(txtdomicilio.Text)
                dts.glocalidadtutor = UCase(txtlocalidad.Text)
                dts.gparentescotutor = cbxparentesco.Text
                dts.gteltutor = UCase(txttelefono.Text)
                dts.gnomtutor2 = UCase(txtnombre2.Text)
                dts.gteltutor2 = UCase(txttelefono2.Text)
                dts.gnomtutor3 = UCase(txtnombre3.Text)
                dts.gteltutor3 = UCase(txttelefono3.Text)

                If func.insertar(dts) Then
                    MessageBox.Show("El Tutor se Registro Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaralta.Visible = False
                    lblnuevo.Visible = False
                    Me.Close()

                Else
                    MessageBox.Show("El Tutor no fue Registrado", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Nuevp Tutor" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtdni.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txttelefono.Text <> "" And txtdomicilio.Text <> "" And txtlocalidad.Text <> "" Then
            Try
                Dim dts As New vtutor
                Dim func As New ftutor

                dts.gdnitutor = CInt(txtdni.Text)
                dts.gapellidotutor = UCase(txtapellido.Text)
                dts.gnombretutor = UCase(txtnombre.Text)
                dts.gdomtutor = UCase(txtdomicilio.Text)
                dts.glocalidadtutor = UCase(txtlocalidad.Text)
                dts.gparentescotutor = cbxparentesco.Text
                dts.gteltutor = UCase(txttelefono.Text)
                dts.gnomtutor2 = UCase(txtnombre2.Text)
                dts.gteltutor2 = UCase(txttelefono2.Text)
                dts.gnomtutor3 = UCase(txtnombre3.Text)
                dts.gteltutor3 = UCase(txttelefono3.Text)


                If func.editar(dts) Then
                    MessageBox.Show("El Tutor Fue Modificado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    btnguardaredicion.Visible = False
                    lblmodificar.Visible = False
                    Me.Close()
                Else
                    MessageBox.Show("El Tutor no fue Modificado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Editar Tutor" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click

        Try
            Dim dts As New vtutor
            Dim func As New ftutor

            dts.gdnitutor = CInt(txtdni.Text)


            If func.eliminar(dts) Then
                MessageBox.Show("El Tutor Fue Eliminado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiar()
                limpiar()
                lblbaja.Visible = False
                btnguardarbaja.Visible = False
                Me.Close()

            Else
                MessageBox.Show("El Tutor No fue Eliminado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error Editar Tutor" + ex.Message)
        End Try

    End Sub

    Private Sub button29_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub


End Class