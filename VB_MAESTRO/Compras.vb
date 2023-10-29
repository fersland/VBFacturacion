Imports DATOS
Imports LOGICA

Public Class Compras
    Dim objProveedores As New LProveedor
    Dim objProductos As New LProductos
    Dim objCompras As New LCompras
    Dim objComprasDatos As New DCompras

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProveedores()
        listarProductos()
        listarCarrito()
        sumaDataGridView()
    End Sub

    Public Sub listarProveedores()
        dg_proveedores.DataSource = objProveedores.listarProveedoresLogica
    End Sub

    Public Sub listarProductos()
        dg_productos.DataSource = objProductos.listarProductosLogica
    End Sub

    Public Sub listarCarrito()
        Dim ccompras = objComprasDatos.consultaNumeroFactura()
        Dim numero As Long = CLng(ccompras)
        Dim codigo As String = Format(numero, "00000")

        lblnumcompra.Text = "COMP-" + codigo
        lblidcompradb.Text = ccompras
        dg_compras.DataSource = objCompras.listarCarritoLogica(numero)
    End Sub

    Private Sub dg_proveedores_DoubleClick(sender As Object, e As EventArgs) Handles dg_proveedores.DoubleClick
        lblidproveedor.Text = dg_proveedores.CurrentRow.Cells(0).Value.ToString()
        txtprovredor.Text = dg_proveedores.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub dg_productos_DoubleClick(sender As Object, e As EventArgs) Handles dg_productos.DoubleClick
        lblidproductos.Text = dg_productos.CurrentRow.Cells(0).Value.ToString
        txtproducto.Text = dg_productos.CurrentRow.Cells(1).Value.ToString
        txtprecio.Text = dg_productos.CurrentRow.Cells(2).Value.ToString
        txtstock.Text = dg_productos.CurrentRow.Cells(3).Value.ToString
        lbliva.Text = dg_productos.CurrentRow.Cells(4).Value.ToString
        txtcantidad.Select()
    End Sub

    Public Sub sumaDataGridView()
        Dim suma1 As Decimal
        Dim suma2 As Decimal

        If dg_compras.Rows.Count Then
            For Each fila As DataGridViewRow In dg_compras.Rows
                suma1 += Convert.ToDecimal(fila.Cells(5).Value)
            Next
        End If

        If dg_compras.Rows.Count Then
            For Each fila As DataGridViewRow In dg_compras.Rows
                suma2 += Convert.ToDecimal(fila.Cells(7).Value)
            Next
        End If

        ' Hola
        txtdoce.Text = suma1.ToString("#.00")
        txtcero.Text = suma2.ToString("#.00")
        txttotal.Text = (suma1 + suma2)

    End Sub

    Public Sub limpiar()
        txtproducto.Clear()
        txtprecio.Clear()
        txtcantidad.Clear()
        txtstock.Clear()
        lblidproductos.Text = ""

    End Sub

    Private Sub bttadd_Click(sender As Object, e As EventArgs) Handles bttadd.Click
        Dim cantidad As Integer = Val(txtcantidad.Text)
        Dim precio As Decimal = Val(txtprecio.Text)
        Dim iva As Decimal = Val(lbliva.Text)
        Dim importe As Decimal = 0
        Dim diferencia As Decimal = 0
        Dim importeMasIva As Decimal = 0

        If iva = 0 Then
            importe = cantidad * precio
            diferencia = 0
            importeMasIva = importe

        ElseIf iva > 0 Then
            importe = cantidad * precio
            diferencia = (importe * iva) / 100
            importeMasIva = importe + diferencia
        End If

        txtdoce.Text = diferencia

        If lblidproductos.Text = "" Then
            MsgBox("Debe seleccionar un producto")
        Else
            objCompras.crearCompraDetalleLogica(lblidcompradb.Text, lblidproductos.Text, txtprecio.Text, txtcantidad.Text, diferencia, importe, importeMasIva)
            listarCarrito()
            sumaDataGridView()
            limpiar()
        End If

    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtprovredor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprovredor.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub bttguardar_Click(sender As Object, e As EventArgs) Handles bttguardar.Click
        If lblidcompradb.Text = "" Then
            MsgBox("Debe seleccionar el numero de compra")
        Else
            objCompras.finalizarCompraLogica(lblidcompradb.Text, lblidproveedor.Text, txttotal.Text)
            MsgBox("Compra guardada")
            limpiar()
            dg_compras.Columns.Clear()
            listarCarrito()
        End If
    End Sub
End Class