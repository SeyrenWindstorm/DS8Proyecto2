Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim smt As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando
        Dim data As SqlClient.SqlDataReader 'objeto de lectura
        Try
            Form1.ob_conexion.Open()
            smt = "Select * From Procuradores "
            cmd = New SqlClient.SqlCommand(smt, Form1.ob_conexion)
            data = cmd.ExecuteReader
            While (data.Read())
                dgvProcu.Rows.Add(data("DNI"), data("Name"), data("Telefono"), data("Correo"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form1.ob_conexion.Close()
    End Sub
End Class