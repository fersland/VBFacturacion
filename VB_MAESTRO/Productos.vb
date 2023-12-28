Imports DATOS
Imports LOGICA

Public Class Productos
    Dim dataProductos As New DProductos()
    Dim logicaProductos As New LProductos()
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub listar()
        dgproductos.DataSource = logicaProductos.listarProductosLogica()
    End Sub

    Private Sub bttsave_Click(sender As Object, e As EventArgs) Handles bttsave.Click
        listar()
    End Sub
End Class