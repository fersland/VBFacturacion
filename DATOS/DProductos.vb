Imports System.Data.SqlClient

Public Class DProductos
    Inherits Conexion

    Public Function listarProductosDatos() As DataTable
        Dim adapter As New SqlDataAdapter("SP_PRODUCTOS_LISTAR", db)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function


End Class
