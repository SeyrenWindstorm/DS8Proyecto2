Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader
Public Class Form1
    Public ob_conexion
    Public servidor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Visible = True
        Dim c As Integer
        c = c + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario, psw, BD, servidor As String

        Try
            servidor = ”DESKTOP-LUO8R0F” 'nombre del equipo
            usuario = ”sa” 'usuario administrador
            psw = ”synyster2011” 'contraseña
            BD = ”Proyecto” 'Nombre de la BD
            ob_conexion = New SqlClient.SqlConnection 'variable de conexión que está en el módulo
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" 'cadena de conexión
            ob_conexion.Open() 'Abrir la base de datos
            MsgBox("Conectado al servidor y la BD")

        Catch ex As Exception
            MsgBox(ex.Message) 'captura de error
            Me.Close()
        End Try
        ob_conexion.Close()
    End Sub
End Class
