﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        lblid = New Label()
        bttdel = New Button()
        bttedit = New Button()
        bttsave = New Button()
        txtstock = New TextBox()
        txtprecio = New TextBox()
        txtdesc = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        GroupBox2 = New GroupBox()
        dgproductos = New DataGridView()
        checkiva = New CheckBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgproductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(357, 32)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCTOS - Mantenimiento"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(checkiva)
        GroupBox1.Controls.Add(lblid)
        GroupBox1.Controls.Add(bttdel)
        GroupBox1.Controls.Add(bttedit)
        GroupBox1.Controls.Add(bttsave)
        GroupBox1.Controls.Add(txtstock)
        GroupBox1.Controls.Add(txtprecio)
        GroupBox1.Controls.Add(txtdesc)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 72)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(687, 163)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Rellene el formulario :"
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Location = New Point(10, 35)
        lblid.Name = "lblid"
        lblid.Size = New Size(0, 15)
        lblid.TabIndex = 7
        ' 
        ' bttdel
        ' 
        bttdel.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        bttdel.FlatStyle = FlatStyle.Flat
        bttdel.Location = New Point(317, 111)
        bttdel.Name = "bttdel"
        bttdel.Size = New Size(103, 33)
        bttdel.TabIndex = 6
        bttdel.Text = "ELIMINAR"
        bttdel.UseVisualStyleBackColor = False
        ' 
        ' bttedit
        ' 
        bttedit.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        bttedit.FlatStyle = FlatStyle.Flat
        bttedit.Location = New Point(185, 111)
        bttedit.Name = "bttedit"
        bttedit.Size = New Size(103, 33)
        bttedit.TabIndex = 5
        bttedit.Text = "EDITAR"
        bttedit.UseVisualStyleBackColor = False
        ' 
        ' bttsave
        ' 
        bttsave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        bttsave.FlatStyle = FlatStyle.Flat
        bttsave.Location = New Point(38, 111)
        bttsave.Name = "bttsave"
        bttsave.Size = New Size(103, 33)
        bttsave.TabIndex = 4
        bttsave.Text = "GUARDAR"
        bttsave.UseVisualStyleBackColor = False
        ' 
        ' txtstock
        ' 
        txtstock.Location = New Point(563, 39)
        txtstock.Name = "txtstock"
        txtstock.Size = New Size(100, 23)
        txtstock.TabIndex = 3
        ' 
        ' txtprecio
        ' 
        txtprecio.Location = New Point(390, 36)
        txtprecio.Name = "txtprecio"
        txtprecio.Size = New Size(100, 23)
        txtprecio.TabIndex = 2
        ' 
        ' txtdesc
        ' 
        txtdesc.Location = New Point(117, 32)
        txtdesc.Name = "txtdesc"
        txtdesc.Size = New Size(185, 23)
        txtdesc.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(515, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 0
        Label4.Text = "Stock :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(338, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 0
        Label3.Text = "Precio :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 0
        Label2.Text = "Descripción :"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(643, 54)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(46, 15)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "NUEVO"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgproductos)
        GroupBox2.Location = New Point(12, 242)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(687, 187)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Productos"
        ' 
        ' dgproductos
        ' 
        dgproductos.AllowUserToAddRows = False
        dgproductos.AllowUserToDeleteRows = False
        dgproductos.AllowUserToResizeColumns = False
        dgproductos.AllowUserToResizeRows = False
        dgproductos.BackgroundColor = Color.Gainsboro
        dgproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgproductos.EditMode = DataGridViewEditMode.EditProgrammatically
        dgproductos.Location = New Point(10, 26)
        dgproductos.Name = "dgproductos"
        dgproductos.RowTemplate.Height = 25
        dgproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgproductos.Size = New Size(667, 150)
        dgproductos.TabIndex = 9
        ' 
        ' checkiva
        ' 
        checkiva.AutoSize = True
        checkiva.Location = New Point(514, 79)
        checkiva.Name = "checkiva"
        checkiva.Size = New Size(149, 19)
        checkiva.TabIndex = 8
        checkiva.Text = "Productos Incluye IVA ?"
        checkiva.UseVisualStyleBackColor = True
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaShell
        ClientSize = New Size(717, 426)
        Controls.Add(GroupBox2)
        Controls.Add(LinkLabel1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Productos"
        Text = "Productos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgproductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bttdel As Button
    Friend WithEvents bttedit As Button
    Friend WithEvents bttsave As Button
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgproductos As DataGridView
    Friend WithEvents lblid As Label
    Friend WithEvents checkiva As CheckBox
End Class
