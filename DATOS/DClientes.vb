Imports System.Data.SqlClient

Public Class DClientes
    Inherits Conexion

    Public Function ListarClientes() As DataTable
        Dim da As New SqlDataAdapter("SP_CLIENTES_LISTAR", db)
        Dim table As New DataTable
        da.Fill(table)
        Return table
    End Function

    Public Function InsertarClientes(cedula As String, nombres As String, apellidos As String)
        Dim cmd As New SqlCommand("SP_CLIENTES_GUARDAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cedula", cedula)
        cmd.Parameters.AddWithValue("@nombres", nombres)
        cmd.Parameters.AddWithValue("@apellidos", apellidos)
        db.Open()

        Dim response As Integer
        Try
            response = cmd.ExecuteNonQuery
            db.Close()

        Catch ex As Exception
            MsgBox("Error al registrar al cliente")
        End Try

        Return response
    End Function

    Public Function ActualizarClientes(id As Integer, cedula As String, nombres As String, apellidos As String)
        Dim cmd As New SqlCommand("SP_CLIENTES_EDITAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@cedula", cedula)
        cmd.Parameters.AddWithValue("@nombres", nombres)
        cmd.Parameters.AddWithValue("@apellidos", apellidos)
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

    Public Function eliminarClientes(id As Integer)
        Dim cmd As New SqlCommand("SP_CLIENTES_ELIMINAR", db)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", id)
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
