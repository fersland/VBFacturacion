Imports System.Data.SqlClient

Public Class DProductos
    Inherits Conexion

    Public Function listarProductosDatos() As DataTable
        Dim adapter As New SqlDataAdapter("SP_PRODUCTOS_LISTAR", db)
        Dim table As New DataTable
        adapter.Fill(table)
        Return table
    End Function

    Public Function insertar(descripcion As String, precio As Decimal, stock As Integer, iva As Integer)
        Dim cmd As New SqlCommand("SP_PRODUCTOS_GUARDAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@descripcion", descripcion)
        cmd.Parameters.AddWithValue("@precio", precio)
        cmd.Parameters.AddWithValue("@stock", stock)
        cmd.Parameters.AddWithValue("@iva", iva)
        db.Open()

        Dim response As Integer

        Try
            response = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox("Error al regisrtrar el producto, compruebe los datos.")
        End Try
        Return response
    End Function

    Public Function editar(id As Integer, descripcion As String, precio As Decimal, stock As Integer, iva As Integer)
        Dim cmd As New SqlCommand("SP_PRODUCTOS_EDITAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@descripcion", descripcion)
        cmd.Parameters.AddWithValue("@precio", precio)
        cmd.Parameters.AddWithValue("@stock", stock)
        cmd.Parameters.AddWithValue("@iva", iva)
        db.Open()

        Dim response As Integer

        Try
            response = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Return response
    End Function

    Public Function eliminar(id As Integer)
        Dim cmd As New SqlCommand("SP_PRODUCTOS_ELIMINAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
        db.Open()

        Dim response As Integer

        Try
            response = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Return response
    End Function
End Class
