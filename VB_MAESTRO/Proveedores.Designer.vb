<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        lblid = New Label()
        Label1 = New Label()
        txtcedula = New TextBox()
        txtnombres = New TextBox()
        btteliminar = New Button()
        btteditar = New Button()
        bttguardar = New Button()
        Label2 = New Label()
        Label4 = New Label()
        dataproveedor = New DataGridView()
        LinkLabel1 = New LinkLabel()
        GroupBox1.SuspendLayout()
        CType(dataproveedor, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblid)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtcedula)
        GroupBox1.Controls.Add(txtnombres)
        GroupBox1.Controls.Add(btteliminar)
        GroupBox1.Controls.Add(btteditar)
        GroupBox1.Controls.Add(bttguardar)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 108)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(574, 179)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Complete el formulario :"
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Location = New Point(194, 15)
        lblid.Name = "lblid"
        lblid.Size = New Size(0, 15)
        lblid.TabIndex = 12
        lblid.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 15)
        Label1.TabIndex = 3
        Label1.Text = "IDENTIFICACIÓN / RUC  :"
        ' 
        ' txtcedula
        ' 
        txtcedula.Location = New Point(189, 34)
        txtcedula.Name = "txtcedula"
        txtcedula.Size = New Size(136, 23)
        txtcedula.TabIndex = 1
        ' 
        ' txtnombres
        ' 
        txtnombres.Location = New Point(189, 74)
        txtnombres.Name = "txtnombres"
        txtnombres.Size = New Size(136, 23)
        txtnombres.TabIndex = 2
        ' 
        ' btteliminar
        ' 
        btteliminar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btteliminar.FlatStyle = FlatStyle.Flat
        btteliminar.Location = New Point(341, 124)
        btteliminar.Name = "btteliminar"
        btteliminar.Size = New Size(139, 33)
        btteliminar.TabIndex = 11
        btteliminar.Text = "ELIMINAR"
        btteliminar.UseVisualStyleBackColor = False
        ' 
        ' btteditar
        ' 
        btteditar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btteditar.FlatStyle = FlatStyle.Flat
        btteditar.Location = New Point(184, 124)
        btteditar.Name = "btteditar"
        btteditar.Size = New Size(139, 33)
        btteditar.TabIndex = 10
        btteditar.Text = "EDITAR"
        btteditar.UseVisualStyleBackColor = False
        ' 
        ' bttguardar
        ' 
        bttguardar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        bttguardar.FlatStyle = FlatStyle.Flat
        bttguardar.Location = New Point(34, 124)
        bttguardar.Name = "bttguardar"
        bttguardar.Size = New Size(139, 33)
        bttguardar.TabIndex = 9
        bttguardar.Text = "GUARDAR"
        bttguardar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(104, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 3
        Label2.Text = "NOMBRE :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(383, 32)
        Label4.TabIndex = 17
        Label4.Text = "PROVEEDORES - Mantenimiento"
        ' 
        ' dataproveedor
        ' 
        dataproveedor.AllowUserToAddRows = False
        dataproveedor.AllowUserToDeleteRows = False
        dataproveedor.AllowUserToResizeColumns = False
        dataproveedor.AllowUserToResizeRows = False
        dataproveedor.BackgroundColor = Color.AliceBlue
        dataproveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataproveedor.Location = New Point(12, 306)
        dataproveedor.Name = "dataproveedor"
        dataproveedor.RowTemplate.Height = 25
        dataproveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataproveedor.Size = New Size(574, 189)
        dataproveedor.TabIndex = 18
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(500, 88)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(46, 15)
        LinkLabel1.TabIndex = 19
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "NUEVO"
        ' 
        ' Proveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(606, 507)
        Controls.Add(LinkLabel1)
        Controls.Add(dataproveedor)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Name = "Proveedores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Proveedores"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dataproveedor, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents btteliminar As Button
    Friend WithEvents btteditar As Button
    Friend WithEvents bttguardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dataproveedor As DataGridView
    Friend WithEvents lblid As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
