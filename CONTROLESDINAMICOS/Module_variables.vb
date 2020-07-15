Imports System.Data.SqlClient

Public Module Module_variables

    'variable de conexión
    '==================================================================================================================================
    Public cn As New SqlConnection

    'variables para las transacciones
    '==================================================================================================================================
    Public myTrans As SqlTransaction 'controla las transacciones
    Public Comando As SqlCommand 'para utilizar tipos de comandos
    Public estado_transaccion As String = "" 'estado que se encuentra una transaccion
    Public error_conexion_number As Integer = 0

    'variables de acceso a la base de datos
    '==================================================================================================================================
    Public existencia_bd As Boolean = True 'verifica existencia de base de datos
    Public ususql As String = "sa" 'usuario del servidor
    Public clavesql As String = "123456" 'contraséña del servidor
    Public BaseDatos As String = "BDCONTROLESDINAMICOS" 'nombre de la Base de Datos
    Public Servidor As String = "SERVER" 'nombre del servidor

End Module
