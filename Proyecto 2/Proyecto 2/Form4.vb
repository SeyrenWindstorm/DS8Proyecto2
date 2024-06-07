Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim smt As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando
        Dim data As SqlClient.SqlDataReader 'objeto de lectura

        Try
            Form1.ob_conexion.Open()
            smt = "UPDATE DatosCliente SET estado = '" & opcChangeEstado.Text & "', fechaf = '" & DateTimePicker2.Value.Date & "' WHERE codigo = '" & txtNAact.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, Form1.ob_conexion)
            data = cmd.ExecuteReader
            MsgBox("Datos Actualizados")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form1.ob_conexion.Close()
    End Sub

End Class