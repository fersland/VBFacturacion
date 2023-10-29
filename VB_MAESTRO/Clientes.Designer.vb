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
        CType(dg_clientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dg_clientes
        ' 
        dg_clientes.BackgroundColor = SystemColors.ControlLightLight
        dg_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dg_clientes.Location = New Point(93, 238)
        dg_clientes.Name = "dg_clientes"
        dg_clientes.RowTemplate.Height = 25
        dg_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dg_clientes.Size = New Size(606, 187)
        dg_clientes.TabIndex = 1
        ' 
        ' txtcedula
        ' 
        txtcedula.Location = New Point(249, 58)
        txtcedula.Name = "txtcedula"
        txtcedula.Size = New Size(136, 23)
        txtcedula.TabIndex = 2
        ' 
        ' txtnombres
        ' 
        txtnombres.Location = New Point(249, 93)
        txtnombres.Name = "txtnombres"
        txtnombres.Size = New Size(136, 23)
        txtnombres.TabIndex = 2
        ' 
        ' txtapellidos
        ' 
        txtapellidos.Location = New Point(249, 132)
        txtapellidos.Name = "txtapellidos"
        txtapellidos.Size = New Size(136, 23)
        txtapellidos.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(175, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 3
        Label1.Text = "CEDULA :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(164, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 3
        Label2.Text = "NOMBRES :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(160, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 3
        Label3.Text = "APELLIDOS :"
        ' 
        ' bttguardar
        ' 
        bttguardar.Location = New Point(93, 184)
        bttguardar.Name = "bttguardar"
        bttguardar.Size = New Size(139, 33)
        bttguardar.TabIndex = 4
        bttguardar.Text = "GUARDAR"
        bttguardar.UseVisualStyleBackColor = True
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
        btteditar.Location = New Point(243, 184)
        btteditar.Name = "btteditar"
        btteditar.Size = New Size(139, 33)
        btteditar.TabIndex = 4
        btteditar.Text = "EDITAR"
        btteditar.UseVisualStyleBackColor = True
        ' 
        ' btteliminar
        ' 
        btteliminar.Location = New Point(400, 184)
        btteliminar.Name = "btteliminar"
        btteliminar.Size = New Size(139, 33)
        btteliminar.TabIndex = 4
        btteliminar.Text = "ELIMINAR"
        btteliminar.UseVisualStyleBackColor = True
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(800, 450)
        Controls.Add(lblid)
        Controls.Add(btteliminar)
        Controls.Add(btteditar)
        Controls.Add(bttguardar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtapellidos)
        Controls.Add(txtnombres)
        Controls.Add(txtcedula)
        Controls.Add(dg_clientes)
        Name = "Clientes"
        Text = "Form1"
        CType(dg_clientes, ComponentModel.ISupportInitialize).EndInit()
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
End Class
