Imports System.Data.SqlClient
Public Class fcursos
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_curso")
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

    Public Function insertar(ByVal dts As vcursos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_curso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcarrera", dts.gidcarrera)
            cmd.Parameters.AddWithValue("@nombrecurso", dts.gnombrecurso)

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

    Public Function editar(ByVal dts As vcursos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_curso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcurso", dts.gidcurso)
            cmd.Parameters.AddWithValue("@idcarrera", dts.gidcarrera)
            cmd.Parameters.AddWithValue("@nombrecurso", dts.gnombrecurso)


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

    Public Function eliminar(dts As vcursos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_curso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcurso", SqlDbType.NVarChar, 50).Value = dts.gidcurso 'ver bien
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
