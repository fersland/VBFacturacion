﻿Public Class Inicio
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
End Class