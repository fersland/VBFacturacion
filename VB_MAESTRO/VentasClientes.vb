Imports LOGICA

Public Class VentasClientes
    Dim objClassCliente As New LClientes

    Private Sub VentasClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgclientes.DataSource = objClassCliente.listarClienteLogica
    End Sub

    Private Sub dgclientes_DoubleClick(sender As Object, e As EventArgs) Handles dgclientes.DoubleClick
        Ventas.lblidcliente.Text = dgclientes.CurrentRow.Cells(0).Value.ToString
        Ventas.txtcedula.Text = dgclientes.CurrentRow.Cells(1).Value.ToString
        Ventas.txtnombres.Text = dgclientes.CurrentRow.Cells(2).Value.ToString
        Ventas.txtapellidos.Text = dgclientes.CurrentRow.Cells(3).Value.ToString

        Me.Hide()
    End Sub

End Class