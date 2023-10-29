<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        bttlogin = New Button()
        txtclave = New TextBox()
        Label2 = New Label()
        txtusuario = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(bttlogin)
        GroupBox1.Controls.Add(txtclave)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtusuario)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 56)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(362, 232)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "INICIAR SESIÓN"
        ' 
        ' bttlogin
        ' 
        bttlogin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        bttlogin.Location = New Point(98, 150)
        bttlogin.Name = "bttlogin"
        bttlogin.Size = New Size(160, 44)
        bttlogin.TabIndex = 3
        bttlogin.Text = "INICIAR SESIÓN"
        bttlogin.UseVisualStyleBackColor = False
        ' 
        ' txtclave
        ' 
        txtclave.Location = New Point(136, 105)
        txtclave.Name = "txtclave"
        txtclave.Size = New Size(153, 23)
        txtclave.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 0
        Label2.Text = "CLAVE :"
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(136, 55)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(153, 23)
        txtusuario.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "USUARIO :"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(386, 313)
        Controls.Add(GroupBox1)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bttlogin As Button
    Friend WithEvents txtclave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label1 As Label
End Class
