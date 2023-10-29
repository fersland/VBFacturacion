Imports System.Data
Imports System.Data.SqlClient

Public Class DProveedor
    Inherits Conexion

    Public Function listarProveedores() As DataTable
        Dim tb As New DataTable
        Dim da As New SqlDataAdapter("SP_PROVEEDORES_LISTAR", db)
        da.Fill(tb)
        Return tb

    End Function



End Class
