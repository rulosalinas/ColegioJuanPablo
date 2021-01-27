Imports System.Data.SqlClient
Imports System.Data
Public Class faranceles
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_aranceles")
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
    'ver bien busqueda 
    Public Function buscarxistitucion(ByVal nominst As String, ByVal dg As DataGridView) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_aranceles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@nombreinst", nominst)

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
    Public Function insertar(ByVal dts As varanceles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_aranceles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idinstitucion", dts.gidinstitucion)
            cmd.Parameters.AddWithValue("@nombrearancel", dts.gnombrearancel)
            cmd.Parameters.AddWithValue("@precioarancel", dts.gprecioarancel)

            'cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2

            If cmd.ExecuteNonQuery Then
                'Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
                'MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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

    Public Function editar(ByVal dts As varanceles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("modificar_aranceles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idarancel", dts.gidarancel)
            cmd.Parameters.AddWithValue("@idinstitucion", dts.gidinstitucion)
            cmd.Parameters.AddWithValue("@nombrearancel", dts.gnombrearancel)
            cmd.Parameters.AddWithValue("@precioarancel", dts.gprecioarancel)

            'cmd.Parameters.Add("@MENSAJE", SqlDbType.VarChar, 100).Direction = 2

            If cmd.ExecuteNonQuery Then
                ' Dim MENSAJE As String = cmd.Parameters("@MENSAJE").Value.ToString
                'MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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
    Public Function eliminar(dts As varanceles) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_arancel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idarancel", SqlDbType.NVarChar, 50).Value = dts.gidarancel
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
    Public Function llenarinstitucion() As DataTable
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
        End Try
    End Function

End Class
