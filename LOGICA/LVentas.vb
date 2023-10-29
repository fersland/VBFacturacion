Imports DATOS

Public Class LVentas
    Dim acceso As New DVentas

    Public Function insertarCarritoLogica(nfactura As Integer, producto As String, cant As Integer, precio As Decimal, iva As Decimal, importe As Decimal, importeMasIva As Decimal)
        Return acceso.insertarCarritoDatos(nfactura, producto, cant, precio, iva, importe, importeMasIva)
    End Function

    Public Function verCarritoLogica(factura As Integer) As DataTable
        Return acceso.verCarritoDatos(factura)
    End Function

    Public Function finalizarVentaLogica(factura As Integer, cliente As Integer, total As Decimal)
        Return acceso.finalizarVenta(factura, cliente, total)
    End Function
End Class
