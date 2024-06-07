Public Class Form2


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim smt, estado As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando



        Try
            Form1.ob_conexion.Open()

            If Trim(txtNombre.Text & txtCedula.Text) = "" Or txtNarchivo.Text = "" Or txtCorreo.Text = "" Or txtDireccion.Text = "" Or txtTelefono.Text = "" Or cbProcu.Text = "" Then
                MsgBox("Campos Vacios")
            Else
                estado = "En Tramite"

                smt = "INSERT INTO dbo.DatosCliente(codigo,dni, name, telefono,correo, fecha, direccion, procu,estado) values ('" & txtNarchivo.Text & "','" & txtCedula.Text & "',
                '" & txtNombre.Text & "','" & txtTelefono.Text & "', '" & txtCorreo.Text & "','" & clFecha.Value.Date & "','" & txtDireccion.Text & "','" & cbProcu.Text & "','" & estado & "')"
                cmd = New SqlClient.SqlCommand(smt, Form1.ob_conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Los datos se guardaron correctamente")
                txtCedula.Text = ""
                txtNombre.Text = ""
                txtTelefono.Text = ""
                clFecha.Text = ""
                txtDireccion.Text = ""
                txtCorreo.Text = ""
                txtNarchivo.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form1.ob_conexion.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class