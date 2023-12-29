Imports DATOS

Public Class LProductos
    Dim data_productos As New DProductos

    Public Function listarProductosLogica() As DataTable
        Return data_productos.listarProductosDatos
    End Function

    Public Function insertar(descripcion As String, precio As Decimal, stock As Integer)
        Return data_productos.insertar(descripcion, precio, stock)
    End Function

    Public Function editar(id As Integer, descripcion As String, precio As Decimal, stock As Integer)
        Return data_productos.editar(id, descripcion, precio, stock)
    End Function

    Public Function eliminar(id As Integer)
        Return data_productos.eliminar(id)
    End Function
End Class
