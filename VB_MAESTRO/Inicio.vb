Public Class Inicio
    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click
        Dim f As New Clientes
        Me.IsMdiContainer = True
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaciónToolStripMenuItem.Click
        Dim fact As New Ventas
        Me.IsMdiContainer = True
        fact.MdiParent = Me
        fact.Show()
    End Sub

    Private Sub NuevaCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaCompraToolStripMenuItem.Click
        Dim comp As New Compras
        Me.IsMdiContainer = True
        comp.MdiParent = Me
        comp.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click
        Dim vista As New Productos
        Me.IsMdiContainer = True
        vista.MdiParent = Me
        vista.Show()
    End Sub

    Private Sub VerProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerProveedoresToolStripMenuItem.Click
        Dim verProveedores As New Proveedores
        Me.IsMdiContainer = True
        verProveedores.MdiParent = Me
        verProveedores.Show()
    End Sub
End Class