Imports DATOS
Imports LOGICA

Public Class Clientes
    Dim acceso As New DClientes()
    Dim objLogica As New LClientes()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub listar()
        dg_clientes.DataSource = objLogica.listarClienteLogica()
    End Sub

    Private Sub bttguardar_Click(sender As Object, e As EventArgs) Handles bttguardar.Click
        Dim acceso = New DClientes()
        If txtcedula.Text = "" Then
            MsgBox("Debe llenar todos los campos")
        Else
            Try
                objLogica.insertarClienteLogica(txtcedula.Text, txtnombres.Text, txtapellidos.Text)
                listar()
                MsgBox("Cliente registrado correctamente.")

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

        End If
    End Sub

    Private Sub btteditar_Click(sender As Object, e As EventArgs) Handles btteditar.Click
        Dim acceso = New DClientes()
        If txtcedula.Text = "" Then
            MsgBox("Debe llenar todos los campos")
        Else
            Try
                objLogica.editarClienteLogica(lblid.Text, txtcedula.Text, txtnombres.Text, txtapellidos.Text)
                listar()
                MsgBox("Cliente actualizado correctamente.")
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub

    Private Sub dg_clientes_DoubleClick(sender As Object, e As EventArgs) Handles dg_clientes.DoubleClick
        lblid.Text = dg_clientes.CurrentRow.Cells(0).Value.ToString()
        txtcedula.Text = dg_clientes.CurrentRow.Cells(1).Value.ToString()
        txtnombres.Text = dg_clientes.CurrentRow.Cells(2).Value.ToString()
        txtapellidos.Text = dg_clientes.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btteliminar_Click(sender As Object, e As EventArgs) Handles btteliminar.Click
        If lblid.Text = "" Then
            MsgBox("Seleccione un cliente para eliminar")
        Else
            Try
                objLogica.eliminarClienteLogica(lblid.Text)
                listar()
                MsgBox("Ciente ha sido eliminado")
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtapellidos.Text = ""
        txtcedula.Text = ""
        txtnombres.Text = ""
        lblid.Text = ""

    End Sub
End Class
