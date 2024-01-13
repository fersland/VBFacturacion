<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        GroupBox1 = New GroupBox()
        dg_compras = New DataGridView()
        GroupBox2 = New GroupBox()
        lbliva = New Label()
        lblidproductos = New Label()
        lblidproveedor = New Label()
        bttadd = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txtcantidad = New TextBox()
        Label2 = New Label()
        txtstock = New TextBox()
        txtprecio = New TextBox()
        txtproducto = New TextBox()
        txtprovredor = New TextBox()
        dg_productos = New DataGridView()
        dg_proveedores = New DataGridView()
        Label1 = New Label()
        lblidcompradb = New Label()
        lblnumcompra = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtcero = New TextBox()
        txtdoce = New TextBox()
        txttotal = New TextBox()
        bttguardar = New Button()
        Label12 = New Label()
        GroupBox1.SuspendLayout()
        CType(dg_compras, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dg_productos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dg_proveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dg_compras)
        GroupBox1.Location = New Point(12, 308)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(757, 221)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "CARRITO DE COMPRAS"
        ' 
        ' dg_compras
        ' 
        dg_compras.BackgroundColor = SystemColors.ControlLightLight
        dg_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_compras.Location = New Point(15, 22)
        dg_compras.Name = "dg_compras"
        dg_compras.RowTemplate.Height = 25
        dg_compras.Size = New Size(736, 193)
        dg_compras.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lbliva)
        GroupBox2.Controls.Add(lblidproductos)
        GroupBox2.Controls.Add(lblidproveedor)
        GroupBox2.Controls.Add(bttadd)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtcantidad)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtstock)
        GroupBox2.Controls.Add(txtprecio)
        GroupBox2.Controls.Add(txtproducto)
        GroupBox2.Controls.Add(txtprovredor)
        GroupBox2.Controls.Add(dg_productos)
        GroupBox2.Controls.Add(dg_proveedores)
        GroupBox2.Location = New Point(12, 63)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1047, 228)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "GRUPOS DE SELECCION"
        ' 
        ' lbliva
        ' 
        lbliva.AutoSize = True
        lbliva.Location = New Point(525, 180)
        lbliva.Name = "lbliva"
        lbliva.Size = New Size(41, 15)
        lbliva.TabIndex = 6
        lbliva.Text = "Label9"
        ' 
        ' lblidproductos
        ' 
        lblidproductos.AutoSize = True
        lblidproductos.Location = New Point(458, 184)
        lblidproductos.Name = "lblidproductos"
        lblidproductos.Size = New Size(0, 15)
        lblidproductos.TabIndex = 5
        ' 
        ' lblidproveedor
        ' 
        lblidproveedor.AutoSize = True
        lblidproveedor.Location = New Point(381, 189)
        lblidproveedor.Name = "lblidproveedor"
        lblidproveedor.Size = New Size(0, 15)
        lblidproveedor.TabIndex = 4
        ' 
        ' bttadd
        ' 
        bttadd.BackColor = Color.PaleGreen
        bttadd.Location = New Point(922, 172)
        bttadd.Name = "bttadd"
        bttadd.Size = New Size(84, 32)
        bttadd.TabIndex = 3
        bttadd.Text = "GUARDAR"
        bttadd.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(415, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 21)
        Label4.TabIndex = 2
        Label4.Text = "PRODUCTO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(84, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 21)
        Label3.TabIndex = 2
        Label3.Text = "PROVEEDOR"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(766, 178)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 15)
        Label8.TabIndex = 2
        Label8.Text = "CANTIDAD"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(789, 138)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 2
        Label7.Text = "STOCK"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(784, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 2
        Label6.Text = "PRECIO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(763, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 2
        Label5.Text = "PRODUCTO"
        ' 
        ' txtcantidad
        ' 
        txtcantidad.Location = New Point(837, 175)
        txtcantidad.Name = "txtcantidad"
        txtcantidad.Size = New Size(79, 23)
        txtcantidad.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 15)
        Label2.TabIndex = 2
        Label2.Text = "NOMBRE PROVEEDOR"
        ' 
        ' txtstock
        ' 
        txtstock.BackColor = Color.Beige
        txtstock.Location = New Point(837, 135)
        txtstock.Name = "txtstock"
        txtstock.Size = New Size(79, 23)
        txtstock.TabIndex = 1
        ' 
        ' txtprecio
        ' 
        txtprecio.BackColor = Color.Beige
        txtprecio.Location = New Point(837, 94)
        txtprecio.Name = "txtprecio"
        txtprecio.Size = New Size(79, 23)
        txtprecio.TabIndex = 1
        ' 
        ' txtproducto
        ' 
        txtproducto.BackColor = Color.Beige
        txtproducto.Location = New Point(837, 55)
        txtproducto.Name = "txtproducto"
        txtproducto.Size = New Size(182, 23)
        txtproducto.TabIndex = 1
        ' 
        ' txtprovredor
        ' 
        txtprovredor.BackColor = Color.MistyRose
        txtprovredor.Location = New Point(158, 181)
        txtprovredor.Name = "txtprovredor"
        txtprovredor.Size = New Size(217, 23)
        txtprovredor.TabIndex = 1
        ' 
        ' dg_productos
        ' 
        dg_productos.AllowUserToAddRows = False
        dg_productos.BackgroundColor = Color.Beige
        dg_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_productos.Location = New Point(381, 40)
        dg_productos.Name = "dg_productos"
        dg_productos.ReadOnly = True
        dg_productos.RowTemplate.Height = 25
        dg_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dg_productos.Size = New Size(376, 131)
        dg_productos.TabIndex = 0
        ' 
        ' dg_proveedores
        ' 
        dg_proveedores.AllowUserToAddRows = False
        dg_proveedores.AllowUserToResizeColumns = False
        dg_proveedores.BackgroundColor = Color.MistyRose
        dg_proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_proveedores.Location = New Point(15, 40)
        dg_proveedores.Name = "dg_proveedores"
        dg_proveedores.ReadOnly = True
        dg_proveedores.RowTemplate.Height = 25
        dg_proveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dg_proveedores.Size = New Size(354, 131)
        dg_proveedores.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(725, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(334, 32)
        Label1.TabIndex = 1
        Label1.Text = "FORMULARIO DE COMPRAS"
        ' 
        ' lblidcompradb
        ' 
        lblidcompradb.AutoSize = True
        lblidcompradb.Location = New Point(324, 9)
        lblidcompradb.Name = "lblidcompradb"
        lblidcompradb.Size = New Size(41, 15)
        lblidcompradb.TabIndex = 2
        lblidcompradb.Text = "Label9"
        ' 
        ' lblnumcompra
        ' 
        lblnumcompra.AutoSize = True
        lblnumcompra.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblnumcompra.Location = New Point(151, 19)
        lblnumcompra.Name = "lblnumcompra"
        lblnumcompra.Size = New Size(0, 25)
        lblnumcompra.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(813, 355)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 15)
        Label9.TabIndex = 4
        Label9.Text = "IMPONIBLE 0%"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(807, 396)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 15)
        Label10.TabIndex = 4
        Label10.Text = "IMPONIBLE 12%"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(861, 436)
        Label11.Name = "Label11"
        Label11.Size = New Size(39, 15)
        Label11.TabIndex = 4
        Label11.Text = "TOTAL"
        ' 
        ' txtcero
        ' 
        txtcero.Location = New Point(910, 356)
        txtcero.Name = "txtcero"
        txtcero.Size = New Size(100, 23)
        txtcero.TabIndex = 5
        ' 
        ' txtdoce
        ' 
        txtdoce.Location = New Point(910, 393)
        txtdoce.Name = "txtdoce"
        txtdoce.Size = New Size(100, 23)
        txtdoce.TabIndex = 5
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(910, 431)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(100, 23)
        txttotal.TabIndex = 5
        ' 
        ' bttguardar
        ' 
        bttguardar.BackColor = Color.Coral
        bttguardar.Location = New Point(825, 474)
        bttguardar.Name = "bttguardar"
        bttguardar.Size = New Size(193, 47)
        bttguardar.TabIndex = 6
        bttguardar.Text = "GUARDAR COMPRA"
        bttguardar.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(29, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(125, 25)
        Label12.TabIndex = 7
        Label12.Text = "N° COMPRA:"
        ' 
        ' Compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1071, 539)
        Controls.Add(Label12)
        Controls.Add(bttguardar)
        Controls.Add(txttotal)
        Controls.Add(txtdoce)
        Controls.Add(txtcero)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(lblnumcompra)
        Controls.Add(lblidcompradb)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Compras"
        Text = "Compras"
        GroupBox1.ResumeLayout(False)
        CType(dg_compras, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dg_productos, ComponentModel.ISupportInitialize).EndInit()
        CType(dg_proveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dg_compras As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents bttadd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtprovredor As TextBox
    Friend WithEvents dg_productos As DataGridView
    Friend WithEvents dg_proveedores As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblidproductos As Label
    Friend WithEvents lblidproveedor As Label
    Friend WithEvents lbliva As Label
    Friend WithEvents lblidcompradb As Label
    Friend WithEvents lblnumcompra As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcero As TextBox
    Friend WithEvents txtdoce As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents bttguardar As Button
    Friend WithEvents Label12 As Label
End Class
