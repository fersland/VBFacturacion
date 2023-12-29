Imports DATOS
Imports LOGICA

Public Class Productos
    Dim dataProductos As New DProductos()
    Dim logicaProductos As New LProductos()
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lblid.Visible = False
    End Sub

    Public Sub listar()
        dgproductos.DataSource = logicaProductos.listarProductosLogica()
    End Sub

    Private Sub bttsave_Click(sender As Object, e As EventArgs) Handles bttsave.Click

        If txtdesc.Text = "" Or txtprecio.Text = "" Or txtstock.Text = "" Then
            MsgBox("Debe llenar todos los campos.")
        Else
            Try
                Dim iva As Integer = 0
                If checkiva.Checked = True Then
                    iva = 12
                Else
                    iva = 0
                End If

                logicaProductos.insertar(txtdesc.Text, txtprecio.Text, txtstock.Text, iva)
                listar()
                MsgBox("Producto agregado correctamente.")
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub

    Sub limpiar()
        txtdesc.Text = ""
        txtprecio.Text = ""
        txtstock.Text = ""

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        limpiar()
    End Sub

    Private Sub bttedit_Click(sender As Object, e As EventArgs) Handles bttedit.Click
        Dim iva As Integer
        If checkiva.Checked = True Then
            iva = 12
        Else
            iva = 0
        End If

        If txtdesc.Text = "" Or txtprecio.Text = "" Or txtstock.Text = "" Then
            MsgBox("Debe llenar todos los campos.")
        Else
            Try
                logicaProductos.editar(lblid.Text, txtdesc.Text, txtprecio.Text, txtstock.Text, iva)
                listar()
                MsgBox("Producto editado correctamente.")
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub

    Private Sub dgproductos_DoubleClick(sender As Object, e As EventArgs) Handles dgproductos.DoubleClick
        lblid.Text = dgproductos.CurrentRow.Cells(0).Value.ToString
        txtdesc.Text = dgproductos.CurrentRow.Cells(1).Value.ToString
        txtprecio.Text = dgproductos.CurrentRow.Cells(2).Value.ToString
        txtstock.Text = dgproductos.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub bttdel_Click(sender As Object, e As EventArgs) Handles bttdel.Click
        If txtdesc.Text = "" Or txtprecio.Text = "" Or txtstock.Text = "" Then
            MsgBox("Debe llenar todos los campos.")
        Else
            Try
                logicaProductos.eliminar(lblid.Text)
                listar()
                MsgBox("Producto eliminado correctamente.")
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub
End Class