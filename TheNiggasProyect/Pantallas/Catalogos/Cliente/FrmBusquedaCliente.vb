Public Class FrmBusquedaCliente
    Dim conexionBD As New Conexion
    Dim strQuery As String
    Private Sub BtnBusqueda_Click(sender As Object, e As EventArgs) Handles BtnBusqueda.Click
        If TxtBusquedaNumero.Text Is "" Then
            MsgBox("Favor de Ingresar el numero de cliente")
        Else
            strQuery = "SELECT id_cliente as 'No Cliente',nombre as Nombre,apellido_paterno as 'Apellido Paterno',apellido_materno as 'Apellido Materno',domicilio as Domicilio,telefono as Telefono,email as Email,case when activo is true then 'Si' else 'No' end as Activo from cliente where id_cliente =" & TxtBusquedaNumero.Text
            If conexionBD.GetData(strQuery) IsNot Nothing Then
                DtgvCliente.DataSource = conexionBD.GetData(strQuery).Tables(0).DefaultView
            Else
                MsgBox("No existe el Cliente")
                DtgvCliente.DataSource = Nothing
                DtgvCliente.Refresh()
            End If
        End If
    End Sub
    Private Sub TxtBusquedaNumero_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaNumero.TextChanged
        TxtBusquedaNombre.Text = ""
        ChkInactivos.Checked = CheckState.Unchecked
        ChkActivos.Checked = CheckState.Unchecked
    End Sub

    Private Sub TxtBusquedaNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaNombre.TextChanged
        TxtBusquedaNumero.Text = ""
        ChkInactivos.Checked = CheckState.Unchecked
        ChkActivos.Checked = CheckState.Unchecked
        If TxtBusquedaNombre.Text <> Nothing Then
            strQuery = "Select id_cliente as 'No Cliente',nombre as Nombre,apellido_paterno as 'Apellido Paterno',apellido_materno as 'Apellido Materno',domicilio as Domicilio,telefono as Telefono,email as Email,case when activo is true then 'Si' else 'No' end as Activo  from cliente where  concat_ws(' ',nombre,apellido_paterno,apellido_materno)  LIKE '%" & TxtBusquedaNombre.Text & "%'"
            If conexionBD.GetData(strQuery) IsNot Nothing Then
                DtgvCliente.DataSource = conexionBD.GetData(strQuery).Tables(0).DefaultView
            Else
                DtgvCliente.DataSource = Nothing
                DtgvCliente.Refresh()
            End If
        End If
    End Sub

    Private Sub ChkActivos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivos.CheckedChanged
        strQuery = "Select id_cliente as 'No Cliente',nombre as Nombre,apellido_paterno as 'Apellido Paterno',apellido_materno as 'Apellido Materno',domicilio as Domicilio,telefono as Telefono,email as Email,case when activo is true then 'Si' else 'No' end as Activo from cliente where activo = true"
        TxtBusquedaNumero.Text = ""
        TxtBusquedaNombre.Text = ""
        ChkInactivos.Checked = CheckState.Unchecked
        If Me.ChkActivos.CheckState Then
            If conexionBD.GetData(strQuery) IsNot Nothing Then
                DtgvCliente.DataSource = conexionBD.GetData(strQuery).Tables(0).DefaultView
            Else
                MsgBox("No existe Clientes Activos")
                DtgvCliente.DataSource = Nothing
                DtgvCliente.Refresh()
            End If
        Else
            DtgvCliente.DataSource = Nothing
            DtgvCliente.Refresh()
        End If
    End Sub



    Private Sub ChkInactivos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivos.CheckedChanged
        strQuery = "Select id_cliente as 'No Cliente',nombre as Nombre,apellido_paterno as 'Apellido Paterno',apellido_materno as 'Apellido Materno',domicilio as Domicilio,telefono as Telefono,email as Email,case when activo is true then 'Si' else 'No' end as Activo from cliente where activo = false"
        TxtBusquedaNumero.Text = ""
        TxtBusquedaNombre.Text = ""
        ChkActivos.Checked = CheckState.Unchecked

        If Me.ChkInactivos.CheckState Then
            If conexionBD.GetData(strQuery) IsNot Nothing Then
                DtgvCliente.DataSource = conexionBD.GetData(strQuery).Tables(0).DefaultView
            Else
                MsgBox("No existe Clientes Inactivos")
                DtgvCliente.DataSource = Nothing
                DtgvCliente.Refresh()
            End If
        Else
            DtgvCliente.DataSource = Nothing
            DtgvCliente.Refresh()
        End If
    End Sub
    Private Sub DtgvCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgvCliente.CellDoubleClick
        Dim row As Integer
        row = DtgvCliente.CurrentRow.Index
        HabilitarEdicion()
        TxtId.Text = DtgvCliente.Item(0, row).Value.ToString
        TxtNumeroCliente.Text = DtgvCliente.Item(0, row).Value
        TxtNombre.Text = DtgvCliente.Item(1, row).Value
        TxtApellidoPaterno.Text = DtgvCliente.Item(2, row).Value
        TxtApellidoMaterno.Text = DtgvCliente.Item(3, row).Value
        TxtDomicilio.Text = DtgvCliente.Item(4, row).Value
        TxtTelefono.Text = DtgvCliente.Item(5, row).Value
        TxtEmail.Text = DtgvCliente.Item(6, row).Value
        If DtgvCliente.Item(7, row).Value.Equals("Si") Then
            ChkActivo.CheckState = CheckState.Checked
        ElseIf DtgvCliente.Item(7, row).Value.Equals("No") Then
            ChkActivo.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub HabilitarEdicion()
        TxtNombre.Enabled = True
        TxtApellidoPaterno.Enabled = True
        TxtApellidoMaterno.Enabled = True
        TxtDomicilio.Enabled = True
        TxtTelefono.Enabled = True
        TxtEmail.Enabled = True
        ChkActivo.Enabled = True
        BtnGuardar.Enabled = True
        BtnBorrar.Enabled = True
    End Sub
    Private Sub DeshabilitarEdicion()
        TxtNombre.Enabled = False
        TxtApellidoPaterno.Enabled = False
        TxtApellidoMaterno.Enabled = False
        TxtDomicilio.Enabled = False
        TxtTelefono.Enabled = False
        TxtEmail.Enabled = False
        ChkActivo.Enabled = False
        BtnGuardar.Enabled = False
        BtnBorrar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        strQuery = "Update cliente set nombre='" & TxtNombre.Text & "',apellido_paterno='" & TxtApellidoPaterno.Text & "',apellido_materno='" & TxtApellidoMaterno.Text & "',domicilio='" & TxtDomicilio.Text & "',telefono='" & TxtTelefono.Text & "',email='" & TxtEmail.Text & "',activo=" & ChkActivo.CheckState & " where id_cliente='" & TxtId.Text & "'"
        Try
            If conexionBD.InsertUpdateDelete(strQuery) Then
                MsgBox("Cliente Guardado con Exito!")
                DeshabilitarEdicion()
                limpiarFormEdicion()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub limpiarFormEdicion()
        Dim a As Control
        For Each a In Me.GboxEdicionCliente.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        For Each a In Me.GboxFiltros.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        ChkActivo.CheckState = CheckState.Unchecked
        ChkActivos.CheckState = CheckState.Unchecked
        ChkInactivos.CheckState = CheckState.Unchecked
        DtgvCliente.DataSource = Nothing
        DtgvCliente.Refresh()
        TxtId.Text = Nothing
    End Sub

    Private Sub FrmBusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class