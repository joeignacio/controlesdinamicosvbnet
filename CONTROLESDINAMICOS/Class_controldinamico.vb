Public Class Class_controldinamico
    Inherits Class_conexion

    Function listar_controles_dinamicos() As DataTable
        Dim dt As New DataTable
        Dim obj_conexion As New Class_conexion
        Try
            Dim da As New SqlClient.SqlDataAdapter("SELECT idcontrol, descripcion FROM dbo.CONTROL_DINAMICO WITH (NOLOCK) WHERE (estado = 'A')", obj_conexion.conectar)
            da.Fill(dt)
        Catch ex As Exception
            obj_conexion.desconectar()
        End Try
        obj_conexion.desconectar()
        Return dt
    End Function

End Class
