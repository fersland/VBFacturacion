<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dg_clientes = New DataGridView()
        txtcedula = New TextBox()
        txtnombres = New TextBox()
        txtapellidos = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        bttguardar = New Button()
        lblid = New Label()
        btteditar = New Button()
        btteliminar = New Button()
        PrintDialog1 = New PrintDialog()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        LinkLabel1 = New LinkLabel()
        CType(dg_clientes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dg_clientes
        ' 
        dg_clientes.BackgroundColor = SystemColors.ControlLightLight
        dg_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_clientes.Location = New Point(34, 287)
        dg_clientes.Name = "dg_clientes"
        dg_clientes.RowTemplate.Height = 25
        dg_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dg_clientes.Size = New Size(742, 187)
        dg_clientes.TabIndex = 12
        ' 
        ' txtcedula
        ' 
        txtcedula.Location = New Point(109, 29)
        txtcedula.Name = "txtcedula"
        txtcedula.Size = New Size(136, 23)
        txtcedula.TabIndex = 1
        ' 
        ' txtnombres
        ' 
        txtnombres.Location = New Point(109, 64)
        txtnombres.Name = "txtnombres"
        txtnombres.Size = New Size(136, 23)
        txtnombres.TabIndex = 2
        ' 
        ' txtapellidos
        ' 
        txtapellidos.Location = New Point(109, 103)
        txtapellidos.Name = "txtapellidos"
        txtapellidos.Size = New Size(136, 23)
        txtapellidos.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 3
        Label1.Text = "CEDULA :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 3
        Label2.Text = "NOMBRES :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 3
        Label3.Text = "APELLIDOS :"
        ' 
        ' bttguardar
        ' 
        bttguardar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        bttguardar.FlatStyle = FlatStyle.Flat
        bttguardar.Location = New Point(89, 140)
        bttguardar.Name = "bttguardar"
        bttguardar.Size = New Size(139, 33)
        bttguardar.TabIndex = 9
        bttguardar.Text = "GUARDAR"
        bttguardar.UseVisualStyleBackColor = False
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Location = New Point(452, 85)
        lblid.Name = "lblid"
        lblid.Size = New Size(0, 15)
        lblid.TabIndex = 5
        lblid.Visible = False
        ' 
        ' btteditar
        ' 
        btteditar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btteditar.FlatStyle = FlatStyle.Flat
        btteditar.Location = New Point(239, 140)
        btteditar.Name = "btteditar"
        btteditar.Size = New Size(139, 33)
        btteditar.TabIndex = 10
        btteditar.Text = "EDITAR"
        btteditar.UseVisualStyleBackColor = False
        ' 
        ' btteliminar
        ' 
        btteliminar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btteliminar.FlatStyle = FlatStyle.Flat
        btteliminar.Location = New Point(396, 140)
        btteliminar.Name = "btteliminar"
        btteliminar.Size = New Size(139, 33)
        btteliminar.TabIndex = 11
        btteliminar.Text = "ELIMINAR"
        btteliminar.UseVisualStyleBackColor = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(34, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(321, 32)
        Label4.TabIndex = 6
        Label4.Text = "CLIENTES - Mantenimiento"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtcedula)
        GroupBox1.Controls.Add(txtnombres)
        GroupBox1.Controls.Add(btteliminar)
        GroupBox1.Controls.Add(btteditar)
        GroupBox1.Controls.Add(txtapellidos)
        GroupBox1.Controls.Add(bttguardar)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(34, 85)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(742, 179)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Complete el formulario :"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(698, 66)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(46, 15)
        LinkLabel1.TabIndex = 13
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "NUEVO"
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HighlightText
        ClientSize = New Size(800, 501)
        Controls.Add(LinkLabel1)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(lblid)
        Controls.Add(dg_clientes)
        Name = "Clientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CLIENTES | ERP"
        CType(dg_clientes, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dg_clientes As DataGridView
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bttguardar As Button
    Friend WithEvents lblid As Label
    Friend WithEvents btteditar As Button
    Friend WithEvents btteliminar As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
