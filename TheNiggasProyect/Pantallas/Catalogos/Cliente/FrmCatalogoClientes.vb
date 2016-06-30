Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmCatalogoClientes
    Delegate Sub FunctionCall(ByVal param)
    Private Template As DPFP.Template
    Dim operacion As String
    Dim strQuery As String
    Dim id As Long
    Dim conexionBd As New Conexion



    Private Sub cat_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacion = "NUEVO"
        llenar()
    End Sub
    Sub llenar()
        strQuery = "select id_cliente,nombre,apellido_paterno,apellido_materno,domicilio,email,telefono,foto from cliente"
        conexionBd.PropertyDataSet = conexionBd.GetData(strQuery)
        If conexionBd.PropertyDataSet IsNot Nothing Then
            dgv1.DataSource = conexionBd.PropertyDataSet.Tables(0).DefaultView
            dgv1.AutoResizeColumns()
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Else
            dgv1.DataSource = Nothing
            dgv1.Refresh()
        End If

    End Sub

    Private Sub BtnGuardarCliente_Click(sender As Object, e As EventArgs) Handles BtnGuardarCliente.Click
        Try
            Dim conexionBD As New Conexion()
            Dim serverDate As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
            Dim strQuery As String = ""
            Dim ParametroHuella As New MySql.Data.MySqlClient.MySqlParameter("@Documento", MySqlDbType.Blob)
            Dim ParametroFoto As New MySql.Data.MySqlClient.MySqlParameter("@Documento2", MySqlDbType.Blob)
            Dim PropertyCommand = New MySqlCommand
            conexionBD.abrirBD() 'Se crea instancia la propiedad MysqlCommand del objeto

            'BORRAR EL ARCHIVO DE HUELLA
            If File.Exists(huella_path) Then
                My.Computer.FileSystem.DeleteFile(huella_path, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            End If
            'llamar la huella
            If operacion = "NUEVO" Then

                If Not pone_huella() Then
                    Exit Sub
                End If

                'guarda huella en command de mysql
                ParametroHuella.Value = ArchivoABytes(huella_path)
                PropertyCommand.Parameters.Add(ParametroHuella.ParameterName, ParametroHuella.MySqlDbType)
                PropertyCommand.Parameters(ParametroHuella.ParameterName).Value = ParametroHuella.Value

                'guarda foto en command de mysql
                ParametroFoto.Value = ArchivoABytes(PbClienteNuevo.ImageLocation)
                PropertyCommand.Parameters.Add(ParametroFoto.ParameterName, ParametroFoto.MySqlDbType)
                PropertyCommand.Parameters(ParametroFoto.ParameterName).Value = ParametroFoto.Value

                strQuery = "INSERT INTO cliente (nombre, apellido_paterno, apellido_materno, domicilio," &
                    " telefono, email, fecha_registro, activo, huella,foto)
                VALUES ('" & TxtNombre.Text & "','" & TxtApellidoPaterno.Text & "','" &
                TxtApellidoMaterno.Text & "','" & TxtDomicilio.Text & "','" & TxtTelefono.Text &
                "','" & TxtEmail.Text & "','" & serverDate & "',1," & ParametroHuella.ParameterName &
                "," & ParametroFoto.ParameterName & ")"

            ElseIf operacion = "EDITAR" Then

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

                strQuery = "update cliente set nombre='" & TxtNombre.Text &
                "',apellido_paterno='" & TxtApellidoPaterno.Text &
                "', apellido_materno='" & TxtApellidoMaterno.Text &
                "', domicilio='" & TxtDomicilio.Text &
                "', telefono='" & TxtTelefono.Text &
                "', email='" & TxtEmail.Text &
                "',huella=" & ParametroHuella.ParameterName &
                ",foto=" & ParametroFoto.ParameterName & " where id_cliente=" & id

            End If

            ' Se iniciliza la propiedad MysqlCommand del objeto
            PropertyCommand.Connection = conexionBD.PropertyConexion                   'indica conexion
            PropertyCommand.CommandText = strQuery                             ' consulta sql
            PropertyCommand.ExecuteNonQuery()

            MsgBox("Cliente Guardado con exito")
            Call limpiarFormulario()
            conexionBD.cerrarBd()

        Catch ex As Exception
            MsgBox("Error al Guardar el cliente." & vbCrLf & "Error: " & ex.Message)
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
    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        operacion = "EDITAR"
        Call usar(True)
        id = dgv1.CurrentRow.Cells(0).Value
        TxtNombre.Text = dgv1.CurrentRow.Cells(1).Value.ToString
        TxtApellidoPaterno.Text = dgv1.CurrentRow.Cells(2).Value.ToString
        TxtApellidoMaterno.Text = dgv1.CurrentRow.Cells(3).Value.ToString
        TxtDomicilio.Text = dgv1.CurrentRow.Cells(4).Value.ToString
        TxtTelefono.Text = dgv1.CurrentRow.Cells(5).Value.ToString
        TxtEmail.Text = dgv1.CurrentRow.Cells(6).Value.ToString
        Dim aBytDocumento As Byte() = Nothing
        aBytDocumento = dgv1.CurrentRow.Cells(7).Value
        Dim ms As New MemoryStream(aBytDocumento)
        PbClienteNuevo.Image = Image.FromStream(ms)
    End Sub
    Private Sub limpiarFormulario()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        TxtNombre.Focus()
        PbClienteNuevo.Image = Nothing
        PbClienteNuevo.ImageLocation = Nothing
    End Sub
    Private Sub usar(ByVal valor As Boolean)
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Enabled = valor
            End If
        Next
        TxtNombre.Focus()
        BtnGuardarCliente.Enabled = valor
    End Sub
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Checador.Show()
    End Sub


    Private Sub PbClienteNuevo_DoubleClick(sender As Object, e As EventArgs) Handles PbClienteNuevo.DoubleClick
        If OfdImagenesCliente.ShowDialog() = DialogResult.OK Then
            PbClienteNuevo.Image = Image.FromFile(OfdImagenesCliente.FileName)
            PbClienteNuevo.ImageLocation = OfdImagenesCliente.FileName
        End If
    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
        operacion = "NUEVO"
        Call limpiarFormulario()
        Call usar(True)
        TxtNombre.Focus()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub


End Class
