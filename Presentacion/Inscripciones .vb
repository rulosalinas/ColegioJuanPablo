Public Class frminscripciones


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'boton editar
        Dim result As DialogResult
        result = MessageBox.Show("Esta Seguro que Desea Editar los Datos de la Inscripcion?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            btnNuevo.Enabled = False
            btnbaja.Enabled = False
            btneditar.Enabled = False
            btnguardaralta.Visible = False
            btnguardarbaja.Visible = False
            btnguardaredicion.Visible = True
        End If
    End Sub

    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtidalumno.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And txtdomicilio.Text <> "" And txtlocalidad.Text <> "" And txttelefono.Text <> "" Then
            Try
                Dim dts As New vinscripciones
                Dim func As New finscripciones

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

                If func.editar(dts) Then
                    MessageBox.Show("El Alumno Fue Modificado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    btnNuevo.Enabled = True
                    btnbaja.Enabled = True
                    btneditar.Enabled = True
                    btnguardaralta.Visible = False
                    btnguardarbaja.Visible = False
                    btnguardaredicion.Visible = False
                Else
                    MessageBox.Show("El Alumno no fue Modificado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnbuscaralumno_Click(sender As Object, e As EventArgs) Handles btnbuscaralumno.Click
        frmalumno.txtflag.text = 1
        frmalumno.ShowDialog()
        'formulario alumnos codificamos en evento doble clic del datagridview 

    End Sub
End Class