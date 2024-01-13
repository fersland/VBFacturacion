<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        VerClientesToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ComprasToolStripMenuItem = New ToolStripMenuItem()
        NuevaCompraToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        FacturaciónToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ClientesToolStripMenuItem, ProveedoresToolStripMenuItem, ComprasToolStripMenuItem, VentasToolStripMenuItem, ProductosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1213, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(48, 20)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerClientesToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 20)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' VerClientesToolStripMenuItem
        ' 
        VerClientesToolStripMenuItem.Name = "VerClientesToolStripMenuItem"
        VerClientesToolStripMenuItem.Size = New Size(135, 22)
        VerClientesToolStripMenuItem.Text = "Ver Clientes"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(84, 20)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' ComprasToolStripMenuItem
        ' 
        ComprasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevaCompraToolStripMenuItem})
        ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        ComprasToolStripMenuItem.Size = New Size(67, 20)
        ComprasToolStripMenuItem.Text = "Compras"
        ' 
        ' NuevaCompraToolStripMenuItem
        ' 
        NuevaCompraToolStripMenuItem.Name = "NuevaCompraToolStripMenuItem"
        NuevaCompraToolStripMenuItem.Size = New Size(154, 22)
        NuevaCompraToolStripMenuItem.Text = "Nueva Compra"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FacturaciónToolStripMenuItem})
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(53, 20)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' FacturaciónToolStripMenuItem
        ' 
        FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        FacturaciónToolStripMenuItem.Size = New Size(136, 22)
        FacturaciónToolStripMenuItem.Text = "Facturación"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MantenimientoToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(73, 20)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(156, 22)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1213, 760)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Inicio"
        Text = "Inicio"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
End Class
