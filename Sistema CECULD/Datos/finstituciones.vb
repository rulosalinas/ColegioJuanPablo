Imports System.Data.SqlClient

Public Class finstituciones
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_institucion")
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

    Public Function insertar(ByVal dts As vinstitucion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_institucion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre_inst", dts.gnombre_inst)
            cmd.Parameters.AddWithValue("@domicilio_inst", dts.gdomicilio_inst)
            cmd.Parameters.AddWithValue("@cuit_insto", dts.gcuit_inst)
            cmd.Parameters.AddWithValue("@logo_inst", dts.glogo_inst)

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

    Public Function editar(ByVal dts As vinstitucion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_institucion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_inst", dts.gid_inst)
            cmd.Parameters.AddWithValue("@nombre_inst", dts.gnombre_inst)
            cmd.Parameters.AddWithValue("@domicilio_inst", dts.gdomicilio_inst)
            cmd.Parameters.AddWithValue("@cuit_insto", dts.gcuit_inst)
            cmd.Parameters.AddWithValue("@logo_inst", dts.glogo_inst)

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

    Public Function eliminar(dts As vinstitucion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_institucion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@id_inst", SqlDbType.NVarChar, 50).Value = dts.gid_inst
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
