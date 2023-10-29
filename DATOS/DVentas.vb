Imports System.Data.SqlClient

Public Class DVentas
    Inherits Conexion

    Public Function consulta(id As Integer, dg As DataGridView)
        Try
            Dim da As New SqlDataAdapter("SELECT t2.Id, t2.Descripcion, t2.Precio, t1.Cantidad, t1.Importe 
				FROM VentasDetalle t1 INNER JOIN Productos t2 ON t1.ProductoId = t2.Id
				WHERE Id=" & id, db)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dg.DataSource = dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function consultaNumeroFactura()
        Try
            db.Open()
            Dim query = "SELECT (SELECT DISTINCT TOP 1 Id FROM Ventas ORDER BY Id DESC) + 1 AS Secuencial"
            Dim cmd As New SqlCommand(query, db)
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read Then
                Dim resultado = reader("Secuencial").ToString()

                If resultado = "" Then
                    resultado = 1
                Else
                    resultado = reader("Secuencial").ToString()
                End If

                Return resultado

                db.Close()
            Else
                    Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message())

        Finally
            db.Close()
        End Try

    End Function

    ' AGREGAR PRODUCTOS AL CARRITO DE COMPRAS
    Public Function insertarCarritoDatos(nfactura As Integer, producto As String, cant As Integer, precio As Decimal, iva As Decimal, importe As Decimal, importeMasIva As Decimal)

        Dim cmd As New SqlCommand("SP_VENTAS_DETALLE", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@NFactura", nfactura)
        cmd.Parameters.AddWithValue("@producto", producto)
        cmd.Parameters.AddWithValue("@cant", cant)
        cmd.Parameters.AddWithValue("@precio", precio)
        cmd.Parameters.AddWithValue("@iva", iva)
        cmd.Parameters.AddWithValue("@importe", importe)
        cmd.Parameters.AddWithValue("@importeMasIva", importeMasIva)

        Dim respuesta As Integer

        Try
            db.Open()
            respuesta = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            db.Close()
        End Try

        Return respuesta
    End Function


    Public Function verCarritoDatos(factura As Integer) As DataTable
        Dim da As New SqlDataAdapter("SP_VENTAS_DETALLE_LISTA " & factura, db)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function

    Public Function finalizarVenta(factura As Integer, cliente As Integer, total As Decimal)
        Dim cmd As New SqlCommand("SP_VENTAS", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@factura", factura)
        cmd.Parameters.AddWithValue("@cliente", cliente)
        cmd.Parameters.AddWithValue("@total", total)

        Dim respuesta As Integer

        Try
            db.Open()
            respuesta = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message())

        Finally
            db.Close()
        End Try

        Return respuesta


    End Function
End Class
