Public Class frmabmaranceles

    Private Sub frmabmaranceles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcombo()
    End Sub
    Private dt As New DataTable
    Public Sub limpiar()
        txtidarancel.Text = ""
        txtprecioarancel.Text = ""
        txtnombrearancel.Text = ""

    End Sub
    Public Sub llenarcombo()

        Try
            Dim func As New faranceles
            dt = func.llenarinstitucion
            cbxinstitucion.DataSource = dt
            cbxinstitucion.DisplayMember = "nombre_inst"
            cbxinstitucion.ValueMember = "id_inst"

        Catch ex As Exception
            MsgBox("Error Llenar Combo " + ex.Message)
        End Try
    End Sub

    Private Sub txtprecioarancel_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtprecioarancel.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombrearancel.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Datos Obligatorios")
        End If
    End Sub

    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click
        If Me.ValidateChildren = True And txtnombrearancel.Text <> "" And txtprecioarancel.Text <> "" Then
            Try
                Dim dts As New varanceles
                Dim func As New faranceles

                'dts.gidarancel = CInt(txtidarancel.Text)
                dts.gidinstitucion = cbxinstitucion.SelectedValue.ToString
                dts.gnombrearancel = UCase(txtnombrearancel.Text)
                dts.gprecioarancel = txtprecioarancel.Text

                If func.insertar(dts) Then
                    MessageBox.Show("El Arancel se Agrego Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    btnguardaralta.Visible = False
                    lblnuevo.Visible = False
                    Me.Close()

                Else
                    MessageBox.Show("El Arancel no fue Registrado", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Nuevo Tutor" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardaredicion_Click(sender As Object, e As EventArgs) Handles btnguardaredicion.Click
        If Me.ValidateChildren = True And txtnombrearancel.Text <> "" And txtprecioarancel.Text <> "" Then
            Try
                Dim dts As New varanceles
                Dim func As New faranceles

                dts.gidarancel = CInt(txtidarancel.Text)
                dts.gidinstitucion = cbxinstitucion.SelectedValue.ToString
                dts.gnombrearancel = UCase(txtnombrearancel.Text)
                dts.gprecioarancel = txtprecioarancel.Text


                If func.editar(dts) Then
                    MessageBox.Show("El Arancel Fue Modificado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    btnguardaredicion.Visible = False
                    lblmodificar.Visible = False
                    Me.Close()
                Else
                    MessageBox.Show("El Arancel no fue Modificado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("Error Editar Arancel" + ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnguardarbaja_Click(sender As Object, e As EventArgs) Handles btnguardarbaja.Click

        Try
            Dim dts As New varanceles
            Dim func As New faranceles

            dts.gidarancel = CInt(txtidarancel.Text)


            If func.eliminar(dts) Then
                MessageBox.Show("El Arancel Fue Eliminado Correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                limpiar()
                limpiar()
                lblbaja.Visible = False
                btnguardarbaja.Visible = False
                Me.Close()

            Else
                MessageBox.Show("El Arancel No fue Eliminado", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error Eliminar Arancel" + ex.Message)
        End Try

    End Sub

    Private Sub button29_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub cbxinstitucion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxinstitucion.SelectedIndexChanged

    End Sub
End Class