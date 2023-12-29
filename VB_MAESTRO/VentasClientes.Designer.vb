<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasClientes
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
        dgclientes = New DataGridView()
        Label8 = New Label()
        txtbuscar = New TextBox()
        GroupBox1.SuspendLayout()
        CType(dgclientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgclientes)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txtbuscar)
        GroupBox1.Location = New Point(26, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(604, 242)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "SEELCCIONAR CLIENTE"
        ' 
        ' dgclientes
        ' 
        dgclientes.AllowUserToAddRows = False
        dgclientes.AllowUserToDeleteRows = False
        dgclientes.AllowUserToResizeColumns = False
        dgclientes.AllowUserToResizeRows = False
        dgclientes.BackgroundColor = Color.White
        dgclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgclientes.EditMode = DataGridViewEditMode.EditProgrammatically
        dgclientes.Location = New Point(16, 53)
        dgclientes.Name = "dgclientes"
        dgclientes.RowTemplate.Height = 25
        dgclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgclientes.Size = New Size(570, 168)
        dgclientes.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(362, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 15)
        Label8.TabIndex = 0
        Label8.Text = "BUSCAR :"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(430, 19)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(156, 23)
        txtbuscar.TabIndex = 1
        ' 
        ' VentasClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(647, 295)
        Controls.Add(GroupBox1)
        Name = "VentasClientes"
        Text = "VentasClientes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgclientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgclientes As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbuscar As TextBox
End Class
