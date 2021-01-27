Imports System.Data
Imports System.Data.SqlClient

Public Class frmalumno
    Private dt As New DataTable
    Private Sub frmalumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()
        estado()

    End Sub

    Public Sub estado()
        If datalistado.SelectedCells.Item(10).Value = "INACTIVO" Then
            btnestadoactivo.Visible = False
            btnestadoinactivo.Visible = True

        Else
            btnestadoinactivo.Visible = False
            btnestadoactivo.Visible = True
        End If
    End Sub

    Private Sub mostrar()
        Try
            'Dim dts As New valumnos
            Dim func As New falumnos
           
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
                dv.RowFilter = "dni_alu" & " like '" & txtbuscar.Text & "%'"
            Else
                dv.RowFilter = "apellido_alu" & " like '" & txtbuscar.Text & "%'"
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
        Dim frm As New frmabmalumnos

        frm.txtidalumno.Text = ""
        frm.txtapellido.Text = ""
        frm.txtnombre.Text = ""
        frm.txtdni.Text = ""
        frm.dtfnacimiento.Text = ""
        frm.txtdomicilio.Text = ""
        frm.txtlocalidad.Text = ""
        frm.cbxsexo.Text = ""
        frm.txttelefono.Text = ""
        frm.dtfalta.Text = ""
        frm.txtdnitutor.Text = ""
        frm.txtnombretutor.Text = ""
        frm.lblnuevo.Visible = True
        frm.btnbuscartutor.Visible = True
        frm.btnguardaralta.Visible = True
        frm.ShowDialog()
        mostrar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Esta Seguro que Desea Editar los Datos del Alumno?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            Dim frm As New frmabmalumnos

            If datalistado.SelectedCells.Item(10).Value = "ACTIVO" Then
                frm.txtidalumno.Text = datalistado.SelectedCells.Item(0).Value
                frm.txtapellido.Text = datalistado.SelectedCells.Item(1).Value
                frm.txtnombre.Text = datalistado.SelectedCells.Item(2).Value
                frm.txtdni.Text = datalistado.SelectedCells.Item(3).Value
                frm.dtfnacimiento.Text = datalistado.SelectedCells.Item(4).Value
                frm.txtdomicilio.Text = datalistado.SelectedCells.Item(5).Value
                frm.txtlocalidad.Text = datalistado.SelectedCells.Item(6).Value
                frm.cbxsexo.Text = datalistado.SelectedCells.Item(7).Value
                frm.txttelefono.Text = datalistado.SelectedCells.Item(8).Value
                frm.dtfalta.Text = datalistado.SelectedCells.Item(9).Value
                frm.txtdnitutor.Text = datalistado.SelectedCells.Item(13).Value
                frm.txtnombretutor.Text = datalistado.SelectedCells.Item(14).Value + ", " + datalistado.SelectedCells.Item(15).Value
                frm.lblmodificar.Visible = True
                frm.btnbuscartutor.Visible = True
                frm.btnguardaredicion.Visible = True
                frm.ShowDialog()
                mostrar()
            Else
                MessageBox.Show("El Alumno esta Inactivo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            mostrar()
            estado()
        End If
        
        
    End Sub

    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Dim result As DialogResult

        result = MessageBox.Show("Esta Seguro que Desea dar de Baja al Alumno?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            Dim frm As New frmabmalumnos

            If datalistado.SelectedCells.Item(10).Value = "ACTIVO" Then
                frm.txtidalumno.Text = datalistado.SelectedCells.Item(0).Value
                frm.txtapellido.Text = datalistado.SelectedCells.Item(1).Value
                frm.txtnombre.Text = datalistado.SelectedCells.Item(2).Value
                frm.txtdni.Text = datalistado.SelectedCells.Item(3).Value
                frm.dtfnacimiento.Text = datalistado.SelectedCells.Item(4).Value
                frm.txtdomicilio.Text = datalistado.SelectedCells.Item(5).Value
                frm.txtlocalidad.Text = datalistado.SelectedCells.Item(6).Value
                frm.cbxsexo.Text = datalistado.SelectedCells.Item(7).Value
                frm.txttelefono.Text = datalistado.SelectedCells.Item(8).Value
                frm.dtfalta.Text = datalistado.SelectedCells.Item(9).Value
                frm.txtdnitutor.Text = datalistado.SelectedCells.Item(13).Value
                frm.txtnombretutor.Text = datalistado.SelectedCells.Item(14).Value + ", " + datalistado.SelectedCells.Item(15).Value
                frm.gbbaja.Visible = True
                'frm.lblmbaja.Visible = True
                'frm.lblbaja.Visible = True
                'frm.lblfbaja.Visible = True
                'frm.txtmbaja.Visible = True
                'frm.dtfbaja.Visible = True
                frm.btnguardarbaja.Visible = True
                frm.ShowDialog()
                mostrar()
            Else
                MessageBox.Show("El Alumno esta Inactivo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            mostrar()
            estado()
        End If

    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        estado()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            'Dim dts As New valumnos
            Dim func As New falumnos

            If CheckBox1.CheckState = CheckState.Unchecked Then
                dt = func.mostrar
            Else
                dt = func.mostrartodos
            End If

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
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
    'codigo para pasar los datos al frminscripciones
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            Dim frm As frmabminscripciones = CType(Owner, frmabminscripciones)

            If datalistado.SelectedCells.Item(10).Value = "ACTIVO" Then
                frm.txtidalumno.Text = datalistado.SelectedCells.Item(0).Value.ToString
                frm.txtnombre.Text = datalistado.SelectedCells.Item(1).Value.ToString + ", " + datalistado.SelectedCells.Item(2).Value.ToString
                frm.txtdni.Text = datalistado.SelectedCells.Item(3).Value.ToString
                Me.txtflag.Text = "0"
                Me.lblayuda.visible = False
                Me.Close()
            Else
                MessageBox.Show("El Alumno no Puede ser Inscripto por que encuentra Inactivo", "Cargando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub



End Class

