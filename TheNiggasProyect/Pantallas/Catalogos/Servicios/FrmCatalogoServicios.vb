Public Class FrmCatalogoServicios
    Dim conexionBd As New Conexion
    Dim strQuery As String
    Private Sub FrmCatalogoServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnGuardar.Enabled = False
        showRegistros()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbRegistro.Enabled = True
        BtnGuardar.Enabled = True
        BtnNuevo.Enabled = False
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If BtnGuardar.Text.Equals("Actualizar") Then
            strQuery = "Update servicio set descripcion='" & TxtDescripcion.Text & "', cantidad=" & TxtCantidad.Text & ", tipo='" & CmbTipo.Text & "', precio=" & txtPrecio.Text & ", activo=" & chkActivo.CheckState & " where id_servicio = " & TxtId.Text
        Else
            strQuery = "INSERT INTO servicio (descripcion, cantidad, tipo, precio, activo) 
                                VALUES ('" & TxtDescripcion.Text & "'," & TxtCantidad.Text & ",'" & CmbTipo.Text & "'," & txtPrecio.Text & "," & 1 & ")"
        End If

        If (conexionBd.InsertUpdateDelete(strQuery)) Then
            MsgBox("Servicio Guardado con exito")
        Else
            MsgBox("No se pudo Guardar el Registro")
        End If
        limpiarFormulario()
        GbRegistro.Enabled = False
        BtnGuardar.Text = "Guardar"
        BtnNuevo.Enabled = True
        BtnGuardar.Enabled = False
        txtBusqueda.Focus()
        showRegistros()
    End Sub

    Private Sub limpiarFormulario()
        Dim a As Control
        For Each a In Me.GbRegistro.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub

    Private Sub showRegistros()
        conexionBd.PropertyDataSet = New DataSet
        strQuery = "select id_servicio as Id,descripcion as Servicio, cantidad as Duracion, tipo as Tipo, precio as Costo, case when activo = '1' then 'Si' else 'No' end as Activo from servicio where activo=1"
        conexionBd.PropertyDataSet = conexionBd.GetData(strQuery)
        If (conexionBd.PropertyDataSet IsNot Nothing) Then
            DgvServicios.DataSource = conexionBd.PropertyDataSet.Tables(0).DefaultView
        Else
            DgvServicios.DataSource = Nothing
            DgvServicios.Refresh()
        End If
    End Sub


    Private Sub DgvServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvServicios.CellDoubleClick
        Dim row As Integer
        row = DgvServicios.CurrentRow.Index
        TxtDescripcion.Text = DgvServicios.Item(1, row).Value.ToString
        TxtCantidad.Text = DgvServicios.Item(2, row).Value.ToString
        txtPrecio.Text = DgvServicios.Item(4, row).Value.ToString
        TxtId.Text = DgvServicios.Item(0, row).Value.ToString
        CmbTipo.Text = DgvServicios.Item(3, row).Value.ToString
        If DgvServicios.Item(5, row).Value.Equals("Si") Then
            chkActivo.CheckState = CheckState.Checked
        ElseIf DgvServicios.Item(5, row).Value.Equals("No") Then
            chkActivo.CheckState = CheckState.Unchecked
        End If

        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        BtnGuardar.Text = "Actualizar"
        GbRegistro.Enabled = True
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text <> Nothing Then
            strQuery = "select id_servicio as Id,descripcion as Servicio, cantidad as Duracion, tipo as Tipo, precio as Costo, case when activo = '1' then 'Si' else 'No' end as Activo from servicio where descripcion LIKE '%" & txtBusqueda.Text & "%'"
            If conexionBd.GetData(strQuery) IsNot Nothing Then
                DgvServicios.DataSource = conexionBd.GetData(strQuery).Tables(0).DefaultView
            Else
                DgvServicios.DataSource = Nothing
                DgvServicios.Refresh()
            End If
        End If
    End Sub
End Class