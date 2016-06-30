Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmCatalogoEmpleado
    Dim strQuery As String
    Dim conexionBd As New Conexion
    Delegate Sub FunctionCall(ByVal param)
    Private Template As DPFP.Template
    Private Sub BtnNuevoEmpleado_Click(sender As Object, e As EventArgs) Handles BtnNuevoEmpleado.Click
        GbEmpleado.Enabled = True
        BtnGuardarEmpleado.Enabled = True
        BtnNuevoEmpleado.Enabled = False
        txtNombreEmpleado.Focus()
    End Sub
    Private Sub PbClienteNuevo_DoubleClick(sender As Object, e As EventArgs) Handles PbClienteNuevo.DoubleClick
        If OfdImagenesCliente.ShowDialog() = DialogResult.OK Then
            PbClienteNuevo.Image = Image.FromFile(OfdImagenesCliente.FileName)
            PbClienteNuevo.ImageLocation = OfdImagenesCliente.FileName
        End If
    End Sub
    Private Sub BtnGuardarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnGuardarEmpleado.Click
        Dim conexionBD As New Conexion()
        Dim strQuery As String = ""
        Dim ParametroHuella As New MySql.Data.MySqlClient.MySqlParameter("@Documento", MySqlDbType.Blob)
        Dim ParametroFoto As New MySql.Data.MySqlClient.MySqlParameter("@Documento2", MySqlDbType.Blob)
        Dim PropertyCommand = New MySqlCommand
        conexionBd.abrirBD() 'Se crea instancia la propiedad MysqlCommand del objeto
        Try
            If File.Exists(huella_path) Then
                My.Computer.FileSystem.DeleteFile(huella_path, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            End If
            If BtnGuardarEmpleado.Text.Equals("Actualizar") Then

                If Not pone_huella() Then
                    Exit Sub
                End If

                ParametroHuella.Value = ArchivoABytes(huella_path)
                PropertyCommand.Parameters.Add(ParametroHuella.ParameterName, ParametroHuella.MySqlDbType)
                PropertyCommand.Parameters(ParametroHuella.ParameterName).Value = ParametroHuella.Value

                'guarda foto en command de mysql
                ParametroFoto.Value = ArchivoABytes(PbClienteNuevo.ImageLocation)
                PropertyCommand.Parameters.Add(ParametroFoto.ParameterName, ParametroFoto.MySqlDbType)
                PropertyCommand.Parameters(ParametroFoto.ParameterName).Value = ParametroFoto.Value

                strQuery = "Update empleado Set 
                        nombre_empleado='" & txtNombreEmpleado.Text &
                        "', apellido_paterno='" & TxtApellidoPaternoEmpleado.Text &
                        "', apellido_materno='" & TxtApellidoMaternoEmpleado.Text &
                        "', puesto='" & TxtPuestoEmpleado.Text &
                        "', telefono='" & TxtTelefonoEmpleado.Text &
                        "', correo_electronico='" & TxtCorreoEmpleado.Text &
                        "', domicilio='" & TxtDomicilioEmpleado.Text &
                        "', usuario='" & TextBox1.Text &
                        "', password='" & TextBox2.Text &
                        "', activo=" & ChkActivoEmpleado.CheckState &
                        " WHERE id_empleado=" & TxtIdEmpleado.Text
            Else
                If Not pone_huella() Then
                    Exit Sub
                End If
                Dim serverDate As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                ParametroHuella.Value = ArchivoABytes(huella_path)
                PropertyCommand.Parameters.Add(ParametroHuella.ParameterName, ParametroHuella.MySqlDbType)
                PropertyCommand.Parameters(ParametroHuella.ParameterName).Value = ParametroHuella.Value

                'guarda foto en command de mysql
                ParametroFoto.Value = ArchivoABytes(PbClienteNuevo.ImageLocation)
                PropertyCommand.Parameters.Add(ParametroFoto.ParameterName, ParametroFoto.MySqlDbType)
                PropertyCommand.Parameters(ParametroFoto.ParameterName).Value = ParametroFoto.Value
                strQuery = "INSERT INTO empleado (nombre_empleado, apellido_paterno, apellido_materno, " &
                    "puesto, telefono, correo_electronico, domicilio, fecha_registro,usuario,password, " &
                    "activo,huella,foto) 
                        VALUES ('" & txtNombreEmpleado.Text &
                                "','" & TxtApellidoPaternoEmpleado.Text & "','" & TxtApellidoMaternoEmpleado.Text &
                                "','" & TxtPuestoEmpleado.Text & "','" & TxtTelefonoEmpleado.Text &
                                "','" & TxtCorreoEmpleado.Text & "','" & TxtDomicilioEmpleado.Text &
                                "','" & serverDate & "','" & TextBox1.Text & "','" & TextBox2.Text &
                                "','1'," & ParametroHuella.ParameterName & "," & ParametroFoto.ParameterName & ")"
            End If
            PropertyCommand.Connection = conexionBd.PropertyConexion                   'indica conexion
            PropertyCommand.CommandText = strQuery                             ' consulta sql
            PropertyCommand.ExecuteNonQuery()

            MsgBox("Empleado Guardado con exito")

            limpiarFormulario()
            GbEmpleado.Enabled = False
            BtnGuardarEmpleado.Text = "Guardar"
            BtnNuevoEmpleado.Enabled = True
            BtnGuardarEmpleado.Enabled = False
            TxtBusquedaEmpleado.Focus()
            showRegistros()
        Catch
            MsgBox("El Empleado No se pudo Guardar." & vbCrLf & "Error: " & Err.Description)
        End Try
    End Sub
    Function pone_huella() As Boolean
        'Enroller.ID = conexionBD.PropertyTable.Rows(0).Item("maximo")
        Dim Enroller As New FrmHuella()
        AddHandler Enroller.OnTemplate, AddressOf OnTemplate
        Enroller.ShowDialog()
        If Enroller.ID = 1 Then
            Using fs As IO.FileStream = IO.File.Open(huella_path, IO.FileMode.Create, IO.FileAccess.Write)
                Template.Serialize(fs)
            End Using
        End If
        If Not File.Exists(huella_path) Then
            MsgBox("No se guardo la huella correctamente")
            Return False
        End If
        Return True
    End Function
    Private Sub OnTemplate(ByVal template)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template)
    End Sub
    Private Sub _OnTemplate(ByVal template)
        Me.Template = template
        ''VerifyButton.Enabled = (Not template Is Nothing)
        'SaveButton.Enabled = (Not template Is Nothing)
        If Not template Is Nothing Then
            'MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment")
        Else
            MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment")
        End If
    End Sub
    Private Sub limpiarFormulario()
        Dim a As Control
        For Each a In Me.GbEmpleado.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        PbClienteNuevo.Image = Nothing
        PbClienteNuevo.ImageLocation = Nothing
    End Sub

    Private Sub showRegistros()
        conexionBd.PropertyDataSet = New DataSet
        strQuery = "select id_empleado as 'No.Empleado',nombre_empleado as Nombre,apellido_paterno as 'Apellido Paterno',apellido_materno as 'Apellido Materno', puesto as Puesto,domicilio as Domicilio, telefono as Telefono,correo_electronico as Email, case when activo = '1' then 'Si' else 'No' end as Activo from empleado where activo=1"

        conexionBd.PropertyDataSet = conexionBd.GetData(strQuery)
        If (conexionBd.PropertyDataSet IsNot Nothing) Then
            DgvEmpleados.DataSource = conexionBd.PropertyDataSet.Tables(0).DefaultView
        Else
            DgvEmpleados.DataSource = Nothing
            DgvEmpleados.Refresh()
        End If

    End Sub

    Private Sub FrmCatalogoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnGuardarEmpleado.Enabled = False
        showRegistros()
    End Sub

    Private Sub DgvEmpleados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvEmpleados.CellMouseDoubleClick
        Dim row As Integer
        row = DgvEmpleados.CurrentRow.Index
        TxtIdEmpleado.Text = DgvEmpleados.Item(0, row).Value.ToString
        conexionBd.GetData("select usuario,password,foto from empleado where id_empleado=" & TxtIdEmpleado.Text)
        txtNombreEmpleado.Text = DgvEmpleados.Item(1, row).Value.ToString
        TxtApellidoPaternoEmpleado.Text = DgvEmpleados.Item(2, row).Value.ToString
        TxtApellidoMaternoEmpleado.Text = DgvEmpleados.Item(3, row).Value.ToString
        TxtPuestoEmpleado.Text = DgvEmpleados.Item(4, row).Value.ToString
        TxtDomicilioEmpleado.Text = DgvEmpleados.Item(5, row).Value.ToString
        TxtTelefonoEmpleado.Text = DgvEmpleados.Item(6, row).Value.ToString
        TxtCorreoEmpleado.Text = DgvEmpleados.Item(7, row).Value.ToString
        TextBox1.Text = conexionBd.PropertyTable.Rows(0).Item("usuario").ToString
        TextBox2.Text = conexionBd.PropertyTable.Rows(0).Item("password").ToString
        If DgvEmpleados.Item(8, row).Value.Equals("Si") Then
            ChkActivoEmpleado.CheckState = CheckState.Checked
        ElseIf DgvEmpleados.Item(8, row).Value.Equals("No") Then
            ChkActivoEmpleado.CheckState = CheckState.Unchecked
        End If
        If Not IsDBNull(conexionBd.PropertyTable.Rows(0).Item("foto")) Then
            Dim aBytDocumento As Byte() = Nothing
            aBytDocumento = conexionBd.PropertyTable.Rows(0).Item("foto")
            Dim ms As New MemoryStream(aBytDocumento)
            PbClienteNuevo.Image = Image.FromStream(ms)
        Else
            PbClienteNuevo.Image = Nothing
        End If
        BtnNuevoEmpleado.Enabled = False
        BtnGuardarEmpleado.Enabled = True
        BtnGuardarEmpleado.Text = "Actualizar"
        GbEmpleado.Enabled = True
        txtNombreEmpleado.Focus()
    End Sub

    Private Sub TxtBusquedaEmpleado_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaEmpleado.TextChanged
        If TxtBusquedaEmpleado.Text <> Nothing Then
            strQuery = "select id_empleado as 'No.Empleado',nombre_empleado as Nombre,apellido_paterno as 'Apellido Paterno',apellido_materno as 'Apellido Materno', puesto as Puesto,domicilio as Domicilio, telefono as Telefono,correo_electronico as Email, case when activo = '1' then 'Si' else 'No' end as Activo from empleado where nombre_empleado LIKE '%" & TxtBusquedaEmpleado.Text & "%' or apellido_paterno LIKE '%" & TxtBusquedaEmpleado.Text & "%' or apellido_materno LIKE '%" & TxtBusquedaEmpleado.Text & "%' or id_empleado LIKE '%" & TxtBusquedaEmpleado.Text & "%'"
            If conexionBd.GetData(strQuery) IsNot Nothing Then
                DgvEmpleados.DataSource = conexionBd.GetData(strQuery).Tables(0).DefaultView
            Else
                DgvEmpleados.DataSource = Nothing
                DgvEmpleados.Refresh()
            End If
        End If
    End Sub

    Private Sub DgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleados.CellContentClick

    End Sub
End Class