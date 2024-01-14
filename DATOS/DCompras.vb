
Imports System.Data.SqlClient

Public Class DCompras
    Inherits Conexion

    Public Function listarCarrito(compra As Integer) As DataTable
        Dim tb As New DataTable
        Dim da As New SqlDataAdapter("SP_COMPRASDETALLE_LISTAR " & compra, db)
        da.Fill(tb)
        Return tb
    End Function

    Public Function consultaNumeroFactura()
        Try
            db.Open()
            Dim query = "SELECT (SELECT DISTINCT TOP 1 Id FROM Compras ORDER BY Id DESC) + 1 AS Secuencial"
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

    Public Function crearCompraDetalle(factura As Integer, producto As String, precio As Decimal, cantidad As Integer, iva As Decimal, importe As Decimal, importeMasIva As Decimal)
        Dim cmd As New SqlCommand("SP_COMPRAS_DETALLE", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@factura", factura)
        cmd.Parameters.AddWithValue("@producto", producto)
        cmd.Parameters.AddWithValue("@precio", precio)
        cmd.Parameters.AddWithValue("@cant", cantidad)
        cmd.Parameters.AddWithValue("@iva", iva)
        cmd.Parameters.AddWithValue("@importe", importe)
        cmd.Parameters.AddWithValue("@importeMasIva", importeMasIva)

        db.Open()

        Dim respuesta As Integer

        Try

            respuesta = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        Return respuesta
    End Function

    Public Function finalizarCompraDatos(factura As Integer, proveedor As Integer, total As Decimal)
        Dim cmd As New SqlCommand("SP_COMPRAS", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@factura", factura)
        cmd.Parameters.AddWithValue("@proveedor", proveedor)
        cmd.Parameters.AddWithValue("@total", total)
        db.Open()

        Dim respuesta As Integer

        Try
            respuesta = cmd.ExecuteNonQuery
            db.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Return respuesta
    End Function

End Class
