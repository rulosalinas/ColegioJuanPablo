Imports System.Data.SqlClient
Imports System.Data
Public Class fpago
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pagos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function buscar(ByVal opcion As String, ByVal dato As String, ByVal dg As DataGridView) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@opcion", opcion)
            cmd.Parameters.AddWithValue("@dato", dato)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar(ByVal dts As vpagos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@idinscripcion", dts.gidinscripcion)
            cmd.Parameters.AddWithValue("@tipocomprobante", dts.gtipocomprobante)
            cmd.Parameters.AddWithValue("@numcomprobante", dts.gnumcomprobante)
            cmd.Parameters.AddWithValue("@fechapago", dts.gfpago)
            cmd.Parameters.AddWithValue("@horapago", dts.ghorapago)
            cmd.Parameters.AddWithValue("@formapago", dts.gformapago)
            cmd.Parameters.AddWithValue("@totalpago", dts.gtotalpago)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function editar(ByVal dts As vpagos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idpago", dts.gidpago)
            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@idinscripcion", dts.gidinscripcion)
            cmd.Parameters.AddWithValue("@tipocomprobante", dts.gtipocomprobante)
            cmd.Parameters.AddWithValue("@numcomprobante", dts.gnumcomprobante)
            cmd.Parameters.AddWithValue("@fechapago", dts.gfpago)
            cmd.Parameters.AddWithValue("@horapago", dts.ghorapago)
            cmd.Parameters.AddWithValue("@formapago", dts.gformapago)
            cmd.Parameters.AddWithValue("@totalpago", dts.gtotalpago)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(dts As vpagos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_pago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idpago", SqlDbType.NVarChar, 50).Value = dts.gidpago
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function
    Public Function generarcodigo() As Integer
        Try
            conectado()
            cmd = New SqlCommand("genear_codigopago")
            Dim param As New SqlParameter("@codigo", SqlDbType.Int)
            param.Direction = ParameterDirection.Output
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(param)
                .ExecuteNonQuery()
                Return .Parameters("@codigo").Value
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
    'Public Function generar_codigo() As Integer
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("genear_codigopago")
    '        Dim param As New SqlParameter("@codigo", SqlDbType.Int)
    '        param.Direction = ParameterDirection.Output
    '        With cmd
    '            .CommandType = CommandType.StoredProcedure
    '            .Parameters.Add(param)
    '            .ExecuteNonQuery()
    '            Return .Parameters("@codigo").Value
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return 0
    '    End Try
    'End Function
    Public Function generar_codigo() As Integer
        Try
            conectado()
            cmd = New SqlCommand("generar_codigopago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Direction = 2

            If cmd.ExecuteNonQuery Then
                Dim Cod As String = cmd.Parameters("@codigo").Value.ToString

                Return cmd.Parameters("@codigo").Value
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
