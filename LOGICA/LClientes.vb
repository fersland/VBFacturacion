Imports DATOS

Public Class LClientes
    Dim acceso As New DClientes()

    Public Function listarClienteLogica() As DataTable
        Return acceso.ListarClientes()
    End Function

    Public Function insertarClienteLogica(cedula As String, nombres As String, apellidos As String)
        Return acceso.InsertarClientes(cedula, nombres, apellidos)
    End Function

    Public Function editarClienteLogica(id As Integer, cedula As String, nombres As String, apellidos As String)
        Return acceso.ActualizarClientes(id, cedula, nombres, apellidos)
    End Function

    Public Function eliminarClienteLogica(id As Integer)
        Return acceso.eliminarClientes(id)
    End Function

End Class
