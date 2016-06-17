Public Class FrmCatalogoClientes
    Private Sub BtnAgregarFotoCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarFotoCliente.Click
        If OfdImagenesCliente.ShowDialog() = DialogResult.OK Then
            PbClienteNuevo.Image = Image.FromFile(OfdImagenesCliente.FileName)
        End If
    End Sub
    Private Sub BtnGuardarCliente_Click(sender As Object, e As EventArgs) Handles BtnGuardarCliente.Click
        Dim conexionBD As New Conexion()
        Dim serverDate As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
        Dim strQuery As String = "INSERT INTO cliente (nombre, apellido_paterno, apellido_materno, domicilio, telefono, email,fecha_registro,activo) 
                                VALUES ('" & TxtNombre.Text & "','" & TxtApellidoPaterno.Text & "','" & TxtApellidoMaterno.Text & "','" & TxtDomicilio.Text & "','" & TxtTelefono.Text & "','" & TxtEmail.Text & "','" & serverDate & "'," & 1 & ")"
        If (conexionBD.InsertUpdateDelete(strQuery)) Then
            MsgBox("Cliente Guardado con exito")
            Call limpiarFormulario()
        Else
            MsgBox("No se pudo Guardar el Registro")
        End If
    End Sub
    Private Sub limpiarFormulario()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        TxtNombre.Focus()
    End Sub
End Class
