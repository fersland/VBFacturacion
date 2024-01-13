Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DATOS
Imports LOGICA

Public Class Ventas

    Dim objClassCliente As New LClientes
    Dim objClassProducto As New LProductos
    Dim objClassVenta As New DVentas
    Dim objClassVentaDetalle As New LVentas

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reado()
        listarProductos()
        listarCarrito()
        ocultarLabels()
        masVentas()
        totalesGridView()
    End Sub

    Public Sub masVentas()
        Dim consulta = objClassVenta.consultaNumeroFactura()
        Dim numero As Long = CLng(consulta)
        Dim codigo As String = Format(numero, "00000")
        Dim letras As String

        letras = "VENT-" + codigo
        lblnumventa.Text = letras
        lblidventadb.Text = consulta
    End Sub

    ' Datos de solo lectura
    Public Sub reado()
        txtcedula.ReadOnly = True
        txtnombres.ReadOnly = True
        txtapellidos.ReadOnly = True
        txtproducto.ReadOnly = True
        txtprecio.ReadOnly = True
        txtstock.ReadOnly = True
        txtbasecero.ReadOnly = True
        txtbasedoce.ReadOnly = True
        txttotal.ReadOnly = True
    End Sub

    Public Sub obtenerTotal()
        Dim total As Decimal = 0

        If dgcarrito.Rows.Count Then
            For Each fila As DataGridViewRow In dgcarrito.Rows
                total += Convert.ToDecimal(fila.Cells(4).Value.ToString())
            Next
        End If
        txtbasecero.Text = total.ToString("0.00")
    End Sub

    Public Sub listarProductos()
        dgproductos.DataSource = objClassProducto.listarProductosLogica
    End Sub

    Public Sub listarCarrito()
        Dim consulta = objClassVenta.consultaNumeroFactura()
        Dim numero As Long = CLng(consulta)
        Dim codigo As String = Format(numero, "00000")
        Dim letras As String

        'letras = "VENT-" + codigo

        dgcarrito.DataSource = objClassVentaDetalle.verCarritoLogica(numero)

    End Sub

    Private Sub dgproductos_DoubleClick(sender As Object, e As EventArgs) Handles dgproductos.DoubleClick
        lblidproductos.Text = dgproductos.CurrentRow.Cells(0).Value.ToString
        txtproducto.Text = dgproductos.CurrentRow.Cells(1).Value.ToString
        txtprecio.Text = dgproductos.CurrentRow.Cells(2).Value.ToString
        txtstock.Text = dgproductos.CurrentRow.Cells(3).Value.ToString
        lbliva.Text = dgproductos.CurrentRow.Cells(4).Value.ToString
    End Sub

    Public Sub limpiar()
        lblidproductos.Text = ""
        lbliva.Text = ""

        txtprecio.Text = ""
        txtstock.Text = ""
        txtproducto.Text = ""
        txtcantidad.Text = ""
    End Sub

    Public Sub limpiarVenta()
        lblidventadb.Text = ""
        txtbasecero.Text = ""
        txtbasedoce.Text = ""
        txttotal.Text = ""
        lblidcliente.Text = ""
        txtcedula.Text = ""
        txtnombres.Text = ""
        txtapellidos.Text = ""
        dgcarrito.Columns.Clear()

    End Sub
    Public Sub ocultarLabels()
        lblidventadb.Visible = False
        lblidcliente.Visible = False
        lblidproductos.Visible = False
        lbliva.Visible = False

    End Sub

    Public Sub totalesGridView()
        Dim suma1 As Decimal = 0
        Dim suma2 As Decimal = 0

        Dim suma As Decimal = 0
        Dim sumaDoce As Decimal = 0

        ' IVA CERO
        If dgcarrito.Rows.Count Then
            For Each fila As DataGridViewRow In dgcarrito.Rows
                suma += Convert.ToDecimal(fila.Cells(4).Value)
            Next
        End If

        ' IVA DOCE
        If dgcarrito.Rows.Count Then
            For Each fila As DataGridViewRow In dgcarrito.Rows
                sumaDoce += Convert.ToDecimal(fila.Cells(5).Value)
            Next
        End If

        txtbasecero.Text = suma.ToString("#.00")
        txtbasedoce.Text = sumaDoce.ToString("#.00")

        suma1 = txtbasecero.Text
        suma2 = txtbasedoce.Text

        txttotal.Text = (suma1 + suma2)
    End Sub

    Private Sub bttadd_Click(sender As Object, e As EventArgs) Handles bttadd.Click

        Dim importe As Decimal = 0
        Dim importeMasIva As Decimal = 0
        Dim precio As Decimal = 0
        Dim cantidad As Integer = 0
        Dim contador As Integer = 0

        Dim iva As Decimal = 0
        Dim diferencia As Decimal = 0

        precio = txtprecio.Text
        cantidad = txtcantidad.Text
        iva = lbliva.Text

        If cantidad = 0 Then
            MsgBox("Debe ingresar la cantidad del producto")
            txtcantidad.Clear()
            txtcantidad.Select()
        Else

            If iva = 0 Then
                importe = cantidad * precio
                diferencia = 0
                importeMasIva = importe
            ElseIf iva > 0 Then
                importe = cantidad * precio
                diferencia = (importe * iva) / 100
                importeMasIva = importe + diferencia
            End If

            objClassVenta.insertarCarritoDatos(lblidventadb.Text, lblidproductos.Text, txtcantidad.Text, txtprecio.Text, diferencia, importe, importeMasIva)
            listarCarrito()
            totalesGridView()

            limpiar()

        End If

    End Sub

    Private Sub bttbuscarcliente_Click(sender As Object, e As EventArgs) Handles bttbuscarcliente.Click
        VentasClientes.Show()
    End Sub

    Private Sub btt_finalizar_Click(sender As Object, e As EventArgs) Handles btt_finalizar.Click

        Dim laventa = lblidventadb.Text
        Dim elcliente = lblidcliente.Text
        Dim total = txttotal.Text

        If lblidcliente.Text = "" Then
            MsgBox("Debe seleccionar un cliente")
        Else
            objClassVentaDetalle.finalizarVentaLogica(Convert.ToInt32(laventa), Convert.ToInt32(elcliente), Convert.ToDecimal(total))
            MsgBox("Venta Finalizada")
            limpiarVenta()
            masVentas()
        End If
    End Sub
End Class