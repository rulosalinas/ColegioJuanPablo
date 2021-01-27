﻿Imports System.Data.SqlClient
Public Class fcarreras
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_carrera")
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

    Public Function insertar(ByVal dts As vcarreras) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_carreras")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idnivel", dts.gidnivel)
            cmd.Parameters.AddWithValue("@nombrecarrera", dts.gnombrecarrera)
            cmd.Parameters.AddWithValue("@resolucion", dts.gresolucion)
            cmd.Parameters.AddWithValue("@duracion", dts.gduracion)

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

    Public Function editar(ByVal dts As vcarreras) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_carreras")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcarrera", dts.gidcarrera)
            cmd.Parameters.AddWithValue("@idnivel", dts.gidnivel)
            cmd.Parameters.AddWithValue("@nombrecarrera", dts.gnombrecarrera)
            cmd.Parameters.AddWithValue("@resolucion", dts.gresolucion)
            cmd.Parameters.AddWithValue("@duracion", dts.gduracion)

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

    Public Function eliminar(dts As vcarreras) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_carrera")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcarrera", SqlDbType.NVarChar, 50).Value = dts.gidcarrera 'ver bien
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
