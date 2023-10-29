Imports DATOS

Public Class LCompras
    Dim class_compras As New DCompras

    Public Function listarCarritoLogica(compra As Integer) As DataTable
        Return class_compras.listarCarrito(compra)
    End Function

    Public Function crearCompraDetalleLogica(factura As Integer, producto As String, precio As Decimal, cantidad As Integer, iva As Decimal, importe As Decimal, importeMasIva As Decimal)
        Return class_compras.crearCompraDetalle(factura, producto, precio, cantidad, iva, importe, importeMasIva)
    End Function

    Public Function finalizarCompraLogica(factura As Integer, proveedor As Integer, total As Decimal)
        Return class_compras.finalizarCompraDatos(factura, proveedor, total)
    End Function
End Class
