Imports System.Data.SqlClient
Public Class ftutor

    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_tutor")
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

    Public Function insertar(ByVal dts As vtutor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_tutor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@dnitutor", dts.gdnitutor)
            cmd.Parameters.AddWithValue("@apellidotutor", dts.gapellidotutor)
            cmd.Parameters.AddWithValue("@nombretutor", dts.gnombretutor)
            cmd.Parameters.AddWithValue("@domtutor", dts.gdomtutor)
            cmd.Parameters.AddWithValue("@localidadtutor", dts.glocalidadtutor)
            cmd.Parameters.AddWithValue("@parentescotutor", dts.gparentescotutor)
            cmd.Parameters.AddWithValue("@teltutor", dts.gteltutor)
            cmd.Parameters.AddWithValue("@nombretutor2", dts.gnomtutor2)
            cmd.Parameters.AddWithValue("@teltutor2", dts.gteltutor2)
            cmd.Parameters.AddWithValue("@nombretutor3", dts.gnomtutor3)
            cmd.Parameters.AddWithValue("@teltutor3", dts.gteltutor3)

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

    Public Function editar(ByVal dts As vtutor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_tutor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@dnitutor", dts.gdnitutor)
            cmd.Parameters.AddWithValue("@apellidotutor", dts.gapellidotutor)
            cmd.Parameters.AddWithValue("@nombretutor", dts.gnombretutor)
            cmd.Parameters.AddWithValue("@domtutor", dts.gdomtutor)
            cmd.Parameters.AddWithValue("@localidadtutor", dts.glocalidadtutor)
            cmd.Parameters.AddWithValue("@parentescotutor", dts.gparentescotutor)
            cmd.Parameters.AddWithValue("@teltutor", dts.gteltutor)
            cmd.Parameters.AddWithValue("@nombretutor2", dts.gnomtutor2)
            cmd.Parameters.AddWithValue("@teltutor2", dts.gteltutor2)
            cmd.Parameters.AddWithValue("@nombretutor3", dts.gnomtutor3)
            cmd.Parameters.AddWithValue("@teltutor3", dts.gteltutor3)

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


    Public Function eliminar(dts As vtutor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_tutor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@dnitutor", SqlDbType.NVarChar, 50).Value = dts.gdnitutor
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
