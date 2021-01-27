Public Class frmabmpagos
    Private dt As New DataTable
    Private Sub frmpagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dts As New vpagos
        Dim func As New fpago
        txtidpago.Text = Format(func.generar_codigo)

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Public Sub limpiar()
        txtdni.Text = ""
        txtnombre.Text = ""
        txtidpago.Text = ""
        txtiddetalle.Text = ""
        txtidinscripcion.Text = ""
        txtdni.Text = ""
        txtcomprobante.Text = ""
        txtinstitucion.Text = ""
        txtnivel.Text = ""
        txtcarrera.Text = ""
        txtcurso.Text = ""
        txtdivision.Text = ""
        txtcomprobante.Text = ""
    End Sub
    'cargar el alumno al formulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagregaralumno.Click
        Dim frm As New frminscripciones
        frm.txtflag.Text = "1"
        frm.lblayuda.Visible = True
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    'cargar los iten a pagar
    Private Sub btnagregaritem_Click(sender As Object, e As EventArgs) Handles btnbuscarproducto.Click
        Try
            If txtflag2.Text = "0" Then         'el btn solo guarda el pago la primera ves las otras solo llama al frm arancel
                If Me.ValidateChildren = True And txtidinscripcion.Text <> "" Then 'evaluo si hay datos del alumno

                    txtcomprobante.Enabled = False      'congelo datos del alumno y guardo
                    cbxtipocomprobante.Enabled = False
                    dtpfechapago.Enabled = False
                    dtphorapago.Enabled = False
                    cbxformapago.Enabled = False

                    Dim dts As New vpagos
                    Dim func As New fpago

                    dts.gidinscripcion = CInt(txtidinscripcion.Text)
                    dts.gidusuario = CInt("1")
                    dts.gtipocomprobante = UCase(cbxtipocomprobante.Text)
                    dts.gnumcomprobante = CInt(txtcomprobante.Text)
                    dts.gformapago = UCase(cbxformapago.Text)
                    dts.gfpago = Convert.ToDateTime(dtpfechapago.Value.ToShortDateString)
                    dts.ghorapago = Convert.ToDateTime(dtphorapago.Value.ToShortTimeString)

                    If func.insertar(dts) Then          'cargo datos del pago y y llamo a form arancel

                        Dim frm As New Aranceles
                        frm.txtflag.Text = "1"
                        frm.txtbuscar.Text = txtinstitucion.Text 'paso la institucion para buscar los aranceles correspondintes
                        frm.cbxbusqueda.Text = "Institucion"
                        frm.txtbuscar.ReadOnly = True
                        frm.lblayuda.Visible = True
                        AddOwnedForm(frm)
                        frm.ShowDialog()
                        txtflag2.Text = "1"
                    Else
                        MessageBox.Show("No se puede cargar los Productos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MessageBox.Show("Debe ingresar un Alumno para Realizar un Pago", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Dim frm As New Aranceles
                frm.txtflag.Text = "1"
                frm.txtbuscar.Text = txtinstitucion.Text
                frm.cbxbusqueda.Text = "Institucion"
                frm.txtbuscar.ReadOnly = True
                frm.lblayuda.Visible = True
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Error Nuevo pago" + ex.Message)
        End Try

    End Sub
    Private Sub btnguardaralta_Click(sender As Object, e As EventArgs) Handles btnguardaralta.Click

        If datalistado.Rows.Count <> 0 Then         'evaluo que haya productos en el detalle de pago

            Try
                Dim dts As New vpagos
                Dim func As New fpago

                dts.gidpago = CInt(txtidpago.Text)
                dts.gidinscripcion = CInt(txtidinscripcion.Text)
                dts.gidusuario = CInt("1")
                dts.gtipocomprobante = UCase(cbxtipocomprobante.Text)
                dts.gnumcomprobante = CInt(txtcomprobante.Text)
                dts.gformapago = UCase(cbxformapago.Text)
                dts.gfpago = Convert.ToDateTime(dtpfechapago.Value.ToShortDateString)
                dts.ghorapago = Convert.ToDateTime(dtphorapago.Value.ToShortTimeString)
                'dts.gtotalpago = txttotalgral.Text


                'MessageBox.Show("No se pudo agregar item ", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'MessageBox.Show("El pago se Registro Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                btnguardaralta.Visible = False
                lblnuevo.Visible = False
                txtflag2.Text = "0"
                Me.Close()

                MessageBox.Show("El pago no fue Registrado", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MsgBox("Error Nuevo pago" + ex.Message)
            End Try
        Else
            MessageBox.Show("Debe Ingresar los productos que desea Pagar", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    'agrgar los los productos al detalle de venta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnagregararancel.Click
        Try
            If Me.ValidateChildren = True And txtidarancel.Text <> "" Then
                Dim dts As New vdetalle
                Dim func As New fdetalles

                dts.gidpago = CInt(txtidpago.Text)
                dts.gidarancel = CInt(txtidarancel.Text)
                dts.gcantidad = CInt("1")
                dts.gprecio = txtprecioarancel.Text
                dts.gdescuento = txtdescuento.Text
                dts.grecargo = txtrecargo.Text

                If func.insertar(dts) Then 'cargamos arancel y vaciamos los texbox
                    txtidarancel.Text = ""
                    txtnombrearancel.Text = ""
                    txtprecioarancel.Text = ""
                    txtdescuento.Text = "1"
                    txtrecargo.Text = "1"
                    mostrar()

                Else
                    MessageBox.Show("No se pudo agregar item ", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe ingreasar el producto a cobrar", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Error Nuevo Arancel" + ex.Message)
        End Try
        

        '        Try
        '            If dgdetalle.Rows.Count = 0 Then
        '                dgdetalle.Rows.Add(txtidarancel.Text, txtnombrearancel.Text, txtprecioarancel.Text, txtdescuento.Text, txtrecargo.Text)
        '            Else
        '                Dim fila As DataGridViewRow = New DataGridViewRow()

        '                For Each fila In dgdetalle.Rows
        '                    If fila.Cells("nombre").Value = txtnombrearancel.Text Then
        '                        MsgBox("cuota ya esta agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                    End If
        '                    dgdetalle.Rows.Add(txtidarancel.Text, txtnombrearancel.Text, txtprecioarancel.Text, txtdescuento.Text, txtrecargo.Text)
        '                Next
        '            End If

        '        Catch ex As Exception
        '            MsgBox("Error Nuevo item " + ex.Message)
        '        End Try
        '    End If

    End Sub
    'quitar el arancel del detalle 
    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        Try
            Dim dts As New vdetalle
            Dim func As New fdetalles

            dts.giddetalle = CInt(datalistado.CurrentRow.Cells("id_detalle").Value)

            If func.eliminar(dts) Then

                limpiar()
                mostrar()
            End If

        Catch ex As Exception
            MsgBox("Error quitar item" + ex.Message)
        End Try
    End Sub


    Private Sub mostrar()
        Try

            Dim func As New fdetalles

            dt = func.mostrar(txtidpago.Text)


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing '-- sentencia para cuando no exixten datos en la base
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub txtdescuento_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged
    '    Dim total As Integer = CInt(txttotal.Text) - CInt(txtdescuento.Text)
    '    txttotal.Text = total
    'End Sub

    'Private Sub txtrecargo_TextChanged(sender As Object, e As EventArgs) Handles txtrecargo.TextChanged
    '    Dim total As Integer = CInt(txttotal.Text) + CInt(txtrecargo.Text)
    '    txttotal.Text = total
    'End Sub


    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Try 'evaluamos si se quiere cancelar el pago para quitarlo de la base de datos (por cascada se quita el detalle asociado al pago) 
            Dim result As DialogResult

            result = MessageBox.Show("Desea salir sin guardar el Pago?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then

                Dim dts As New vpagos
                Dim func As New fpago

                dts.gidpago = CInt(txtidpago.Text)

                If func.eliminar(dts) Then
                    MessageBox.Show("El pago se cancelo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    txtflag2.Text = "0"
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error Pago" + ex.Message)
        End Try

    End Sub

    'Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
    '    Try
    '        txtiddetalle.Text = datalistado.SelectedCells.Item(0).Value
    '        txtidarancel.Text = datalistado.SelectedCells.Item(2).Value
    '        txtnombrearancel.Text = datalistado.SelectedCells.Item(3).Value
    '        txtprecioarancel.Text = datalistado.SelectedCells.Item(5).Value
    '        txtdescuento.Text = datalistado.SelectedCells.Item(6).Value
    '        txtrecargo.Text = datalistado.SelectedCells.Item(7).Value

    '    Catch ex As Exception
    '        MsgBox("Error datalistado" + ex.Message)
    '    End Try

    'End Sub


    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblfecha.Text = DateTime.Now.ToShortDateString()
        Me.lblhora.Text = DateTime.Now.ToLongTimeString()
    End Sub

End Class