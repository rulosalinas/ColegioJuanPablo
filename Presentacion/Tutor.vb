Public Class frmtutor
    Private dt As New DataTable
    Private Sub Tutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New ftutor

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
            Dim ds As New DataSet    '--copia registros data tabla
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            If cbxbusqueda.Text = "DNI" Then
                dv.RowFilter = "dni_tutor" & " like '" & txtbuscar.Text & "%'"
            Else
                dv.RowFilter = "apellido_tutor" & " like '" & txtbuscar.Text & "%'"
            End If

            If dv.Count <> 0 Then    '-- comprobar que los registros exixtan
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else ' -- no se encuentran registros
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
        Dim frm As New frmabmtutor

        frm.txtdni.Text = ""
        frm.txtapellido.Text = ""
        frm.txtnombre.Text = ""
        frm.cbxparentesco.Text = ""
        frm.txtdomicilio.Text = ""
        frm.txtlocalidad.Text = ""
        frm.txttelefono.Text = ""
        frm.txtnombre2.Text = ""
        frm.txttelefono2.Text = ""
        frm.txtnombre3.Text = ""
        frm.txttelefono3.Text = ""

        frm.lblnuevo.Visible = True
        frm.btnguardaralta.Visible = True
        frm.ShowDialog()
        mostrar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Try
            Dim result As DialogResult
            result = MessageBox.Show("Esta Seguro que Desea Editar los Datos del tutor?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then

                Dim frm As New frmabmtutor


                frm.txtdni.Text = datalistado.SelectedCells.Item(0).Value
                frm.txtapellido.Text = datalistado.SelectedCells.Item(1).Value
                frm.txtnombre.Text = datalistado.SelectedCells.Item(2).Value
                frm.txtdomicilio.Text = datalistado.SelectedCells.Item(3).Value
                frm.txtlocalidad.Text = datalistado.SelectedCells.Item(4).Value
                frm.cbxparentesco.Text = datalistado.SelectedCells.Item(5).Value
                frm.txttelefono.Text = datalistado.SelectedCells.Item(6).Value
                frm.txtnombre2.Text = datalistado.SelectedCells.Item(7).Value
                frm.txttelefono2.Text = datalistado.SelectedCells.Item(8).Value
                frm.txtnombre3.Text = datalistado.SelectedCells.Item(9).Value
                frm.txttelefono3.Text = datalistado.SelectedCells.Item(10).Value

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

            result = MessageBox.Show("Esta Seguro que Desea dar de Baja al Tutor?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then

                Dim frm As New frmabmtutor

                frm.txtdni.Text = datalistado.SelectedCells.Item(0).Value
                frm.txtapellido.Text = datalistado.SelectedCells.Item(1).Value
                frm.txtnombre.Text = datalistado.SelectedCells.Item(2).Value
                frm.txtdomicilio.Text = datalistado.SelectedCells.Item(3).Value
                frm.txtlocalidad.Text = datalistado.SelectedCells.Item(4).Value
                frm.cbxparentesco.Text = datalistado.SelectedCells.Item(5).Value
                frm.txttelefono.Text = datalistado.SelectedCells.Item(6).Value
                frm.txtnombre2.Text = datalistado.SelectedCells.Item(7).Value
                frm.txttelefono2.Text = datalistado.SelectedCells.Item(8).Value
                frm.txtnombre3.Text = datalistado.SelectedCells.Item(9).Value
                frm.txttelefono3.Text = datalistado.SelectedCells.Item(10).Value

                frm.lblbaja.Visible = True
                frm.btnguardarbaja.Visible = True
                frm.ShowDialog()
                mostrar()

            End If
        Catch ex As Exception
            MsgBox("error baja" + ex.Message)
        End Try
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        If txtflag.Text = "1" Then
            Dim frm As frmabmalumnos = CType(Owner, frmabmalumnos)

            frm.txtnombretutor.Text = datalistado.SelectedCells.Item(1).Value.ToString + ", " + datalistado.SelectedCells.Item(2).Value.ToString
            frm.txtdnitutor.Text = datalistado.SelectedCells.Item(0).Value.ToString

            Me.txtflag.Text = "0"
            Me.lblayuda.Visible = False
            Me.Close()

        End If
    End Sub
End Class