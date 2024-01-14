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

    ' GUARDAR PROVEEDORES
    Public Function InsertarProveedores(ruc As String, nombre As String)
        Dim cmd As New SqlCommand("SP_PROVEEDORES_GUARDAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ruc", ruc)
        cmd.Parameters.AddWithValue("@nombre", nombre)
        db.Open()

        Dim response As Integer
        Try
            response = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox("Error al registrar, revisar los datos.")
        End Try
        Return response
    End Function

    ' EDIATR PROVEEDORES
    Public Function EditarProveedores(id As Integer, ruc As String, nombre As String)
        Dim cmd As New SqlCommand("SP_PROVEEDORES_EDITAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@ruc", ruc)
        cmd.Parameters.AddWithValue("@nombre", nombre)
        db.Open()

        Dim response As Integer

        Try
            response = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox("Error al editar, revise los datos.")
        End Try

        Return response
    End Function

    ' ELIMINAR PROVEEDORES
    Public Function EliminarProveedores(id As Integer)
        Dim cmd As New SqlCommand("SP_PROVEEDORES_ELIMINAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
        db.Open()

        Dim response As Integer

        Try
            response = cmd.ExecuteNonQuery
            db.Close()
        Catch ex As Exception
            MsgBox("El proveedor no se elimino correctamente.")
        End Try

        Return response
    End Function

End Class
