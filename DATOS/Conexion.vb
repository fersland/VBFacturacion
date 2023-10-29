Imports System.Data.SqlClient

Public Class Conexion
    Public db As New SqlConnection("data source=FER-DEVELOV\SQLEXPRESS;initial catalog=CodySoftVBFacturacion;integrated security=true")

    Public Function conectar() As Boolean
        Try
            db.Open()
            'MsgBox("Exito en tu prueba :)")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
