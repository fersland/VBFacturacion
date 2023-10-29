Imports DATOS

Public Class LProductos
    Dim data_productos As New DProductos

    Public Function listarProductosLogica() As DataTable
        Return data_productos.listarProductosDatos
    End Function

End Class
