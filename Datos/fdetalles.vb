Imports System.Data.SqlClient
Imports System.Data
Public Class fdetalles
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar(ByVal id As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idpago", id)
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
            cmd = New SqlCommand("buscar_detalle")
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
    Public Function insertar(ByVal dtsd As vdetalle) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idpago", dtsd.gidpago)
            cmd.Parameters.AddWithValue("@idarancel", dtsd.gidarancel)
            cmd.Parameters.AddWithValue("@cantidad", dtsd.gcantidad)
            cmd.Parameters.AddWithValue("@precio", dtsd.gprecio)
            cmd.Parameters.AddWithValue("@descuento", dtsd.gdescuento)
            cmd.Parameters.AddWithValue("@recargo", dtsd.grecargo)
            cmd.Parameters.AddWithValue("@total", dtsd.gtotal)


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
    Public Function editar(ByVal dts As vdetalle) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddetalle", dts.giddetalle)
            cmd.Parameters.AddWithValue("@idpago", dts.gidpago)
            cmd.Parameters.AddWithValue("@idarancel", dts.gidarancel)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)
            cmd.Parameters.AddWithValue("@descuento", dts.gdescuento)
            cmd.Parameters.AddWithValue("@recargo", dts.grecargo)

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
    Public Function eliminar(dts As vdetalle) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@iddetalle", SqlDbType.NVarChar, 50).Value = dts.giddetalle
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
    
End Class
