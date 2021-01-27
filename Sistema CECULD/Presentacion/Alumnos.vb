Public Class frmalumnos

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private dt As New DataTable
    Private Sub tabPage1_Click(sender As Object, e As EventArgs) Handles tabinscripciones.Click

        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New falumnos
            dt = func.mostrar
            'datalistado.Columns.Item("Eliminar").Visible = False linea para ocultar columna de eliminar


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

        btnnuevo.Visible = True '--habilita boton nuevo
        btneditar.Visible = False '-- desabilita editar
        buscar()
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet    '--copia registros data table
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbxbusqueda.Text & " like '" & txtbuscar.Text & "%'"

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
        datalistado.Columns(1).Visible = False '--oculta columna n°1 id
    End Sub

    Private Sub label30_Click(sender As Object, e As EventArgs) Handles label30.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkmarzo.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles chkjunio.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkdiciembre.CheckedChanged

    End Sub

    Private Sub comboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxsexo.SelectedIndexChanged

    End Sub

    Private Sub label6_Click(sender As Object, e As EventArgs) Handles label6.Click

    End Sub

    Private Sub label7_Click(sender As Object, e As EventArgs) Handles label7.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtcarrera.TextChanged

    End Sub

    Private Sub textBox18_TextChanged(sender As Object, e As EventArgs) Handles txtmbaja.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tabPage2_Click(sender As Object, e As EventArgs) Handles tabPage2.Click

    End Sub
End Class