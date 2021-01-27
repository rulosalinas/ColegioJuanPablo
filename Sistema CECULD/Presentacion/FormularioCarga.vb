Imports System.Data
Imports System.Data.SqlClient
Public Class FormularioCarga
    Private dt As New DataTable
    Private Sub FormularioCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenar()
    End Sub
    
    Public Sub llenar()
        Dim cmd As New SqlCommand

        Try
            Dim func As New finscripciones
            dt = func.llenar
            cbxinstitucion.DataSource = dt
            cbxinstitucion.DisplayMember = "nombre_inst"
            cbxinstitucion.ValueMember = "id_inst"

        Catch ex As Exception
            MsgBox("error" + ex.Message)
        End Try
    End Sub
End Class