Imports System.Data.SqlClient
Imports DATOS

Public Class Login
    Dim args = New Conexion()


    Private Sub bttlogin_Click(sender As Object, e As EventArgs) Handles bttlogin.Click
        Dim usuario As String = Val(txtusuario.Text)
        Dim clave As String = Val(txtclave.Text)

        ' Try
        args.Open()
        Dim cmd As New SqlCommand("SP_LOGIN", args)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@user", usuario)
        cmd.Parameters.AddWithValue("@clave", clave)
        cmd.Parameters.Add("@results", SqlDbType.Int).Direction = ParameterDirection.Output

        cmd.ExecuteScalar()

        If CInt(cmd.Parameters("@results").Value = 1) Then
            MsgBox("Sesion Iniciada", vbInformation)
            Inicio.Show()
        Else
            MsgBox("Error en los datos", vbCritical)
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class