Imports DATOS
Imports LOGICA

Public Class Proveedores
    Dim objetoDatos As New LProveedor

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataproveedor.DataSource = objetoDatos.listarProveedoresLogica
    End Sub

    Sub listarProveedores()
        dataproveedor.DataSource = objetoDatos.listarProveedoresLogica
    End Sub

    Sub limpiar()
        txtcedula.Text = ""
        txtnombres.Text = ""
        lblid.Text = ""
    End Sub

    Private Sub bttguardar_Click(sender As Object, e As EventArgs) Handles bttguardar.Click
        If txtcedula.Text <> "" And txtnombres.Text <> "" Then
            objetoDatos.insertarProveedores(txtcedula.Text, txtnombres.Text)
            MsgBox("El proveedor ha sido guardado correctamente.")
            listarProveedores()
            limpiar()
        End If
    End Sub

    Private Sub dataproveedor_DoubleClick(sender As Object, e As EventArgs) Handles dataproveedor.DoubleClick
        lblid.Text = dataproveedor.CurrentRow.Cells(0).Value.ToString
        txtcedula.Text = dataproveedor.CurrentRow.Cells(1).Value.ToString
        txtnombres.Text = dataproveedor.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub btteditar_Click(sender As Object, e As EventArgs) Handles btteditar.Click
        If lblid.Text <> "" Then
            objetoDatos.editarProveedores(lblid.Text, txtcedula.Text, txtnombres.Text)
            MsgBox("Los datos del proveedor han sido actualziados correctamente.")
            listarProveedores()
            limpiar()
        End If
    End Sub

    Private Sub btteliminar_Click(sender As Object, e As EventArgs) Handles btteliminar.Click
        If lblid.Text <> "" Then
            objetoDatos.eliminarProveedores(lblid.Text)
            MsgBox("El Proveedor ha sido eliminado correctamente.")
            listarProveedores()
            limpiar()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        limpiar()
    End Sub
End Class