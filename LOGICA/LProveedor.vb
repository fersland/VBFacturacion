Imports DATOS

Public Class LProveedor
    Dim acceso As New DProveedor

    Public Function listarProveedoresLogica() As DataTable
        Return acceso.listarProveedores()
    End Function
End Class
