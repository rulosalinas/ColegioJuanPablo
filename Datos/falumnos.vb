Imports System.Data.SqlClient
Imports System.Data
'comentario de rama 
'probando cambios git
'clase para cargar los datos de la tlabla alumnos
Public Class falumnos
    Inherits conexion 'llamamos a la clase conexion para poder usarla
    Dim cmd As New SqlCommand
    
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_alumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'data adapter lo rellenamos con los datos de datatable
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
    Public Function mostrartodos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_alumnotodos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt) 'data adapter lo rellenamos con los datos de datatable
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

    Public Function insertar(ByVal dts As valumnos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_alumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fnacimiento", dts.gfnacimiento)
            cmd.Parameters.AddWithValue("@domicilio", dts.gdomicilio)
            cmd.Parameters.AddWithValue("@localidad", dts.glocalidad)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@telalumno", dts.gtelefono)
            cmd.Parameters.AddWithValue("@falta", dts.gfalta)
            cmd.Parameters.AddWithValue("@dnitutor", dts.gdnitutor)


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

    Public Function editar(ByVal dts As valumnos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_alumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fnacimiento", dts.gfnacimiento)
            cmd.Parameters.AddWithValue("@domicilio", dts.gdomicilio)
            cmd.Parameters.AddWithValue("@localidad", dts.glocalidad)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@telalumno", dts.gtelefono)
            cmd.Parameters.AddWithValue("@falta", dts.gfalta)
            cmd.Parameters.AddWithValue("@dnitutor", dts.gdnitutor)

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

    Public Function baja(ByVal dts As valumnos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("baja_alumno")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idalumno", dts.gidalumno)
            cmd.Parameters.AddWithValue("@estado", dts.gestado)
            cmd.Parameters.AddWithValue("@fbaja", dts.gfbaja)
            cmd.Parameters.AddWithValue("@motivobaja", dts.gmotivobaja)

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

End Class


