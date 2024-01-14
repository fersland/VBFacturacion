Imports DATOS

Public Class LProveedor
    Dim acceso As New DProveedor

    Public Function listarProveedoresLogica() As DataTable
        Return acceso.listarProveedores()
    End Function

    Public Function insertarProveedores(ruc As String, nombre As String)
        Return acceso.InsertarProveedores(ruc, nombre)
    End Function

    Public Function editarProveedores(id As Integer, ruc As String, nombre As String)
        Return acceso.EditarProveedores(id, ruc, nombre)
    End Function

    Public Function eliminarProveedores(id As Integer)
        Return acceso.EliminarProveedores(id)
    End Function

End Class
