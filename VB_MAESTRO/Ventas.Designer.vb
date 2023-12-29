<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        bttadd = New Button()
        dgproductos = New DataGridView()
        dgcarrito = New DataGridView()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        txtbuscarproductos = New TextBox()
        GroupBox3 = New GroupBox()
        bttbuscarcliente = New Button()
        lblidcliente = New Label()
        txtapellidos = New TextBox()
        Label3 = New Label()
        txtnombres = New TextBox()
        Label2 = New Label()
        txtcedula = New TextBox()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        GroupBox5 = New GroupBox()
        lbliva = New Label()
        lblidproductos = New Label()
        txtcantidad = New TextBox()
        Label7 = New Label()
        txtstock = New TextBox()
        Label4 = New Label()
        txtprecio = New TextBox()
        Label5 = New Label()
        txtproducto = New TextBox()
        Label6 = New Label()
        GroupBox6 = New GroupBox()
        txttotal = New TextBox()
        Label12 = New Label()
        txtbasedoce = New TextBox()
        Label11 = New Label()
        txtbasecero = New TextBox()
        Label10 = New Label()
        Label13 = New Label()
        lblnumventa = New Label()
        lblidventadb = New Label()
        btt_finalizar = New Button()
        CType(dgproductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgcarrito, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' bttadd
        ' 
        bttadd.BackColor = Color.DarkSalmon
        bttadd.Location = New Point(170, 122)
        bttadd.Name = "bttadd"
        bttadd.Size = New Size(76, 30)
        bttadd.TabIndex = 0
        bttadd.Text = "AGREGAR"
        bttadd.UseVisualStyleBackColor = False
        ' 
        ' dgproductos
        ' 
        dgproductos.AllowUserToAddRows = False
        dgproductos.AllowUserToDeleteRows = False
        dgproductos.AllowUserToResizeColumns = False
        dgproductos.AllowUserToResizeRows = False
        dgproductos.BackgroundColor = Color.White
        dgproductos.BorderStyle = BorderStyle.Fixed3D
        dgproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgproductos.EditMode = DataGridViewEditMode.EditOnEnter
        dgproductos.Location = New Point(16, 43)
        dgproductos.Name = "dgproductos"
        dgproductos.ReadOnly = True
        dgproductos.RowTemplate.Height = 25
        dgproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgproductos.Size = New Size(744, 111)
        dgproductos.TabIndex = 2
        ' 
        ' dgcarrito
        ' 
        dgcarrito.AllowUserToAddRows = False
        dgcarrito.BackgroundColor = Color.White
        dgcarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgcarrito.GridColor = Color.Yellow
        dgcarrito.Location = New Point(16, 21)
        dgcarrito.Name = "dgcarrito"
        dgcarrito.ReadOnly = True
        dgcarrito.RowTemplate.Height = 25
        dgcarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgcarrito.Size = New Size(744, 195)
        dgcarrito.TabIndex = 4
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgproductos)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(txtbuscarproductos)
        GroupBox2.Location = New Point(11, 97)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(767, 168)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "LISTADO DE PRODUCTOS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(536, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 15)
        Label9.TabIndex = 0
        Label9.Text = "BUSCAR :"
        ' 
        ' txtbuscarproductos
        ' 
        txtbuscarproductos.Location = New Point(604, 14)
        txtbuscarproductos.Name = "txtbuscarproductos"
        txtbuscarproductos.Size = New Size(156, 23)
        txtbuscarproductos.TabIndex = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(bttbuscarcliente)
        GroupBox3.Controls.Add(lblidcliente)
        GroupBox3.Controls.Add(txtapellidos)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(txtnombres)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(txtcedula)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Location = New Point(275, 7)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(777, 75)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "DATOS DE CLIENTE"
        ' 
        ' bttbuscarcliente
        ' 
        bttbuscarcliente.BackColor = Color.Gainsboro
        bttbuscarcliente.Location = New Point(651, 28)
        bttbuscarcliente.Name = "bttbuscarcliente"
        bttbuscarcliente.Size = New Size(119, 31)
        bttbuscarcliente.TabIndex = 11
        bttbuscarcliente.Text = "BUSCAR CLIENTE"
        bttbuscarcliente.UseVisualStyleBackColor = False
        ' 
        ' lblidcliente
        ' 
        lblidcliente.AutoSize = True
        lblidcliente.Location = New Point(157, 10)
        lblidcliente.Name = "lblidcliente"
        lblidcliente.Size = New Size(0, 15)
        lblidcliente.TabIndex = 2
        ' 
        ' txtapellidos
        ' 
        txtapellidos.BackColor = Color.Beige
        txtapellidos.Location = New Point(492, 32)
        txtapellidos.Name = "txtapellidos"
        txtapellidos.Size = New Size(156, 23)
        txtapellidos.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(415, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 0
        Label3.Text = "APELLIDOS :"
        ' 
        ' txtnombres
        ' 
        txtnombres.BackColor = Color.Beige
        txtnombres.Location = New Point(252, 30)
        txtnombres.Name = "txtnombres"
        txtnombres.Size = New Size(156, 23)
        txtnombres.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(179, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 0
        Label2.Text = "NOMBRES :"
        ' 
        ' txtcedula
        ' 
        txtcedula.BackColor = Color.Beige
        txtcedula.Location = New Point(79, 30)
        txtcedula.Name = "txtcedula"
        txtcedula.Size = New Size(94, 23)
        txtcedula.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 0
        Label1.Text = "CEDULA :"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgcarrito)
        GroupBox4.Location = New Point(11, 273)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(767, 228)
        GroupBox4.TabIndex = 7
        GroupBox4.TabStop = False
        GroupBox4.Text = "CARRITO DE COMPRAS"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(lbliva)
        GroupBox5.Controls.Add(lblidproductos)
        GroupBox5.Controls.Add(txtcantidad)
        GroupBox5.Controls.Add(Label7)
        GroupBox5.Controls.Add(txtstock)
        GroupBox5.Controls.Add(Label4)
        GroupBox5.Controls.Add(txtprecio)
        GroupBox5.Controls.Add(bttadd)
        GroupBox5.Controls.Add(Label5)
        GroupBox5.Controls.Add(txtproducto)
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Location = New Point(800, 99)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(249, 168)
        GroupBox5.TabIndex = 6
        GroupBox5.TabStop = False
        GroupBox5.Text = "AGREGAR PRODUCTOS"
        ' 
        ' lbliva
        ' 
        lbliva.AutoSize = True
        lbliva.Location = New Point(7, 84)
        lbliva.Name = "lbliva"
        lbliva.Size = New Size(41, 15)
        lbliva.TabIndex = 5
        lbliva.Text = "Label8"
        ' 
        ' lblidproductos
        ' 
        lblidproductos.AutoSize = True
        lblidproductos.Location = New Point(245, 17)
        lblidproductos.Name = "lblidproductos"
        lblidproductos.Size = New Size(0, 15)
        lblidproductos.TabIndex = 4
        ' 
        ' txtcantidad
        ' 
        txtcantidad.Location = New Point(92, 125)
        txtcantidad.Name = "txtcantidad"
        txtcantidad.PlaceholderText = "0"
        txtcantidad.Size = New Size(75, 23)
        txtcantidad.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(16, 128)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 2
        Label7.Text = "CANTIDAD :"
        ' 
        ' txtstock
        ' 
        txtstock.BackColor = Color.Bisque
        txtstock.Location = New Point(89, 96)
        txtstock.Name = "txtstock"
        txtstock.Size = New Size(111, 23)
        txtstock.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 0
        Label4.Text = "STOCK :"
        ' 
        ' txtprecio
        ' 
        txtprecio.BackColor = Color.Bisque
        txtprecio.Location = New Point(89, 60)
        txtprecio.Name = "txtprecio"
        txtprecio.Size = New Size(111, 23)
        txtprecio.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 0
        Label5.Text = "PRECIO :"
        ' 
        ' txtproducto
        ' 
        txtproducto.BackColor = Color.Bisque
        txtproducto.Location = New Point(89, 22)
        txtproducto.Name = "txtproducto"
        txtproducto.Size = New Size(157, 23)
        txtproducto.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 0
        Label6.Text = "PRODUCTO :"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(txttotal)
        GroupBox6.Controls.Add(Label12)
        GroupBox6.Controls.Add(txtbasedoce)
        GroupBox6.Controls.Add(Label11)
        GroupBox6.Controls.Add(txtbasecero)
        GroupBox6.Controls.Add(Label10)
        GroupBox6.Location = New Point(800, 273)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(224, 131)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "TOTALES"
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(140, 93)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(73, 23)
        txttotal.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(44, 96)
        Label12.Name = "Label12"
        Label12.Size = New Size(90, 15)
        Label12.TabIndex = 0
        Label12.Text = "TOTAL A PAGAR"
        ' 
        ' txtbasedoce
        ' 
        txtbasedoce.Location = New Point(140, 61)
        txtbasedoce.Name = "txtbasedoce"
        txtbasedoce.Size = New Size(73, 23)
        txtbasedoce.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(11, 64)
        Label11.Name = "Label11"
        Label11.Size = New Size(123, 15)
        Label11.TabIndex = 0
        Label11.Text = "BASE IMPONIBLE 12%"
        ' 
        ' txtbasecero
        ' 
        txtbasecero.Location = New Point(140, 28)
        txtbasecero.Name = "txtbasecero"
        txtbasecero.Size = New Size(73, 23)
        txtbasecero.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(17, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 15)
        Label10.TabIndex = 0
        Label10.Text = "BASE IMPONIBLE 0%"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(11, 13)
        Label13.Name = "Label13"
        Label13.Size = New Size(124, 30)
        Label13.TabIndex = 2
        Label13.Text = "N° VENTA: "
        ' 
        ' lblnumventa
        ' 
        lblnumventa.AutoSize = True
        lblnumventa.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblnumventa.Location = New Point(134, 15)
        lblnumventa.Name = "lblnumventa"
        lblnumventa.Size = New Size(0, 30)
        lblnumventa.TabIndex = 9
        ' 
        ' lblidventadb
        ' 
        lblidventadb.AutoSize = True
        lblidventadb.Location = New Point(7, 25)
        lblidventadb.Name = "lblidventadb"
        lblidventadb.Size = New Size(0, 15)
        lblidventadb.TabIndex = 10
        ' 
        ' btt_finalizar
        ' 
        btt_finalizar.BackColor = Color.DarkSeaGreen
        btt_finalizar.FlatStyle = FlatStyle.System
        btt_finalizar.ForeColor = SystemColors.Desktop
        btt_finalizar.Location = New Point(820, 421)
        btt_finalizar.Name = "btt_finalizar"
        btt_finalizar.Size = New Size(178, 68)
        btt_finalizar.TabIndex = 11
        btt_finalizar.Text = "FINALIZAR VENTA"
        btt_finalizar.UseVisualStyleBackColor = False
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1065, 506)
        Controls.Add(btt_finalizar)
        Controls.Add(lblidventadb)
        Controls.Add(lblnumventa)
        Controls.Add(Label13)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Ventas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ventas"
        CType(dgproductos, ComponentModel.ISupportInitialize).EndInit()
        CType(dgcarrito, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bttadd As Button
    Friend WithEvents dgproductos As DataGridView
    Friend WithEvents dgcarrito As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbuscarproductos As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbasedoce As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtbasecero As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblidcliente As Label
    Friend WithEvents lblidproductos As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblnumventa As Label
    Friend WithEvents lblidventadb As Label
    Friend WithEvents bttbuscarcliente As Button
    Friend WithEvents lbliva As Label
    Friend WithEvents btt_finalizar As Button
End Class
