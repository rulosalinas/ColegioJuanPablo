Public Class Carreras
    Private dt As New DataTable
    Private Sub Carreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fcarreras

            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True               '--habilita opciones de busqueda despues de comprobar que en la base hay elemento
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            If cbxbusqueda.Text = "Nombre" Then
                dv.RowFilter = "nombre_carrera" & " like '" & txtbuscar.Text & "%'"
            Else
                dv.RowFilter = "id_inst" & " like '" & txtbuscar.Text & "%'"
            End If

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        'datalistado.Columns(1).Visible = False '--oculta columna n°1 id
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar() 'llamada al procedimiento buscar
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim frm As New abmcarreras

        frm.txtnombre.Text = ""
        frm.txtresolucion.Text = ""
        frm.txtduracion.Text = ""


        frm.lblnuevo.Visible = True
        frm.btnguardaralta.Visible = True
        frm.ShowDialog()
        mostrar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Try
            Dim result As DialogResult
            result = MessageBox.Show("Esta Seguro que Desea Editar los Datos de la Carrera?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then

                Dim frm As New abmcarreras
                frm.txtidcarrera.Text = datalistado.SelectedCells.Item(0).Value
                frm.cbxinstitucion.Text = datalistado.SelectedCells.Item(4).Value
                frm.cbxnivel.Text = datalistado.SelectedCells.Item(2).Value
                frm.txtnombre.Text = datalistado.SelectedCells.Item(5).Value
                frm.txtresolucion.Text = datalistado.SelectedCells.Item(6).Value
                frm.txtduracion.Text = datalistado.SelectedCells.Item(7).Value


                frm.lblmodificar.Visible = True
                frm.btnguardaredicion.Visible = True
                frm.ShowDialog()
                mostrar()

            Else
                mostrar()
            End If
        Catch ex As Exception
            MsgBox("error editar" + ex.Message)
        End Try


    End Sub

    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Try
            Dim result As DialogResult

            result = MessageBox.Show("Esta Seguro que Desea dar de Baja ela Carrera?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then

                Dim frm As New abmcarreras

                frm.txtidcarrera.Text = datalistado.SelectedCells.Item(0).Value
                frm.cbxinstitucion.Text = datalistado.SelectedCells.Item(3).Value
                frm.cbxnivel.Text = datalistado.SelectedCells.Item(1).Value
                frm.txtnombre.Text = datalistado.SelectedCells.Item(5).Value
                frm.txtresolucion.Text = datalistado.SelectedCells.Item(6).Value
                frm.txtduracion.Text = datalistado.SelectedCells.Item(7).Value

                frm.lblbaja.Visible = True
                frm.btnguardarbaja.Visible = True
                frm.ShowDialog()
                mostrar()

            End If
        Catch ex As Exception
            MsgBox("Error baja" + ex.Message)
        End Try
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub


    'Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
    '    If txtflag.Text = "1" Then
    '        Dim frm As frmabmpagos = CType(Owner, frmabmpagos)


    '        frm.txtidarancel.Text = datalistado.SelectedCells.Item(0).Value.ToString
    '        frm.txtnombrearancel.Text = datalistado.SelectedCells.Item(2).Value.ToString
    '        frm.txtprecioarancel.Text = datalistado.SelectedCells.Item(3).Value.ToString
    '        Me.txtflag.Text = "0"
    '        Me.lblayuda.Visible = False
    '        Me.Close()

    '    End If
    'End Sub
End Class