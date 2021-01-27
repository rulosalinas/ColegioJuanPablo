Imports System.Data.SqlClient
Public Class fniveles
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_nivel")
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

    Public Function insertar(ByVal dts As vniveles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_niveles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idinstitucion", dts.gidinstitucion)
            cmd.Parameters.AddWithValue("@nombrenivel", dts.gnombrenivel)
            cmd.Parameters.AddWithValue("@cuotanivel", dts.gcuotanivel)

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

    Public Function editar(ByVal dts As vniveles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_nivel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idnivel", dts.gidnivel)
            cmd.Parameters.AddWithValue("@idinstitucion", dts.gidinstitucion)
            cmd.Parameters.AddWithValue("@nombrenivel", dts.gnombrenivel)
            cmd.Parameters.AddWithValue("@cuotanivel", dts.gcuotanivel)

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

    Public Function eliminar(dts As vniveles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_nivel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idnivel", SqlDbType.NVarChar, 50).Value = dts.gidnivel 'ver bien
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
