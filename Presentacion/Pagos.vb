Public Class Pagos
    Private dt As New DataTable
    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fpago
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
            MsgBox("Procedimiento Buscar " + ex.Message)
        End Try

    End Sub
    Private Sub buscar()
        Try
            Dim func As New fpago
            dt = func.buscar(cbxbusqueda.Text, txtbuscar.Text, datalistado)

            If dt.Rows.Count <> 0 Then    '-- comprobar que los registros exixtan
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else ' -- no se encuentran registros
                datalistado.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If

        Catch ex As Exception
            MsgBox("Procedimiento Buscar " + ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        'datalistado.Columns(1).Visible = False '--oculta columna n°1 id
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim frm As New frmabmpagos

        frm.txtidpago.Text = ""
        frm.txtiddetalle.Text = ""
        frm.txtnombre.Text = ""
        frm.txtidinscripcion.Text = ""
        frm.txtdni.Text = ""
        frm.txtinstitucion.Text = ""
        frm.txtnivel.Text = ""
        frm.txtcarrera.Text = ""
        frm.txtcurso.Text = ""
        frm.txtnivel.Text = ""


        frm.txtflag2.Text = "0"
        frm.lblnuevo.Visible = True
        frm.btnguardaralta.Visible = True
        frm.ShowDialog()
        mostrar()
    End Sub


    'Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
    '    Try
    '        Dim result As DialogResult

    '        result = MessageBox.Show("Esta Seguro que Desea dar de Baja el Pago?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '        If result = DialogResult.OK Then

    '            Dim frm As New frmabmpagos

    '            frm.txtidpago.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtiddetalle.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtnombre.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtidinscripcion.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtdni.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtinstitucion.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtnivel.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtcarrera.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtcurso.Text = datalistado.SelectedCells.Item(0).Value
    '            frm.txtnivel.Text = datalistado.SelectedCells.Item(0).Value

    '            frm.lblbaja.Visible = True
    '            frm.btnguardarbaja.Visible = True
    '            frm.ShowDialog()
    '            mostrar()

    '        End If
    '    Catch ex As Exception
    '        MsgBox("error baja" + ex.Message)
    '    End Try
    'End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    'Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
    '    If txtflag.Text = "1" Then
    '        Dim frm As frmabmpagos = CType(Owner, frmabmpagos)

    '        frm.txtnombretutor.Text = datalistado.SelectedCells.Item(1).Value.ToString + ", " + datalistado.SelectedCells.Item(2).Value.ToString
    '        frm.txtdnitutor.Text = datalistado.SelectedCells.Item(0).Value.ToString

    '        Me.txtflag.Text = "0"
    '        Me.lblayuda.Visible = False
    '        Me.Close()

    '    End If
    'End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub
End Class