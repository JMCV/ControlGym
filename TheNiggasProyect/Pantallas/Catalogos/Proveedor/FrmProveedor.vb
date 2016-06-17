
Public Class FrmProveedor
    Friend id_proveedor As Integer = 0
    Dim conexionBd As New Conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call actualizarDataGrid("")
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value
        id_proveedor = id
        Dim sql As String
        sql = "select * from proveedor where id_proveedor= " & id & ""
        conexionBd.PropertyDataSet = conexionBd.GetData(sql)
        If conexionBd.PropertyTable.Rows.Count > 0 Then

            TextBox1.Text = conexionBd.PropertyTable.Rows(0).Item("nombre_proveedor").ToString
            TextBox2.Text = conexionBd.PropertyTable.Rows(0).Item("apellido_paterno").ToString
            TextBox3.Text = conexionBd.PropertyTable.Rows(0).Item("apellido_materno").ToString
            TextBox4.Text = conexionBd.PropertyTable.Rows(0).Item("rfc").ToString
            TextBox5.Text = conexionBd.PropertyTable.Rows(0).Item("telefono").ToString
            TextBox6.Text = conexionBd.PropertyTable.Rows(0).Item("correo_electronico").ToString
            TextBox7.Text = conexionBd.PropertyTable.Rows(0).Item("calle").ToString
            TextBox8.Text = conexionBd.PropertyTable.Rows(0).Item("colonia").ToString
            TextBox9.Text = conexionBd.PropertyTable.Rows(0).Item("cp").ToString
            TextBox10.Text = conexionBd.PropertyTable.Rows(0).Item("estado").ToString
            TextBox11.Text = conexionBd.PropertyTable.Rows(0).Item("municipio").ToString
            ComboBox1.Text = conexionBd.PropertyTable.Rows(0).Item("tipo_persona").ToString
            Button3.Enabled = True
            Button2.Enabled = False
            Button4.Enabled = True
            Call usoTextBox(True)

        End If
    End Sub

    Private Sub actualizarDataGrid(cadena As String)
        Dim sql As String
        conexionBd.PropertyDataSet = New DataSet
        sql = "select id_proveedor as Id,nombre_proveedor as Nombre,
        concat(apellido_paterno,' ',apellido_materno) as Apellidos,rfc,tipo_persona as tipo,telefono,
        correo_electronico as email from proveedor where activo=1"
        If cadena.Equals("") Then
            conexionBd.PropertyDataSet = conexionBd.GetData(sql)
        Else
            conexionBd.PropertyDataSet = conexionBd.GetData(cadena)
        End If

        If (conexionBd.PropertyDataSet IsNot Nothing) Then
            DataGridView1.DataSource = conexionBd.PropertyDataSet.Tables(0).DefaultView
            DataGridView1.AutoResizeColumns()
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Else
            DataGridView1.DataSource = Nothing
            DataGridView1.Refresh()
        End If

    End Sub
    Private Sub usoTextBox(bandera As Boolean)

        TextBox1.ReadOnly = bandera
        TextBox2.ReadOnly = bandera
        TextBox3.ReadOnly = bandera
        TextBox4.ReadOnly = bandera
        TextBox5.ReadOnly = bandera
        TextBox6.ReadOnly = bandera
        TextBox7.ReadOnly = bandera
        TextBox8.ReadOnly = bandera
        TextBox9.ReadOnly = bandera
        TextBox10.ReadOnly = bandera
        TextBox11.ReadOnly = bandera

    End Sub

    Private Sub limpiarTextBox()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call usoTextBox(False)
        Call limpiarTextBox()
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If id_proveedor = 0 Then

            Dim nombre As String = TextBox1.Text
            Dim apellidoPaterno As String = TextBox2.Text
            Dim apellidoMaterno As String = TextBox3.Text
            Dim rfc As String = TextBox4.Text
            Dim tipo As String = ComboBox1.Text
            Dim telefono As String = TextBox5.Text
            Dim correo As String = TextBox6.Text
            Dim calle As String = TextBox7.Text
            Dim colonia As String = TextBox8.Text
            Dim cp As String = TextBox9.Text
            Dim estado As String = TextBox10.Text
            Dim municipio As String = TextBox11.Text

            Dim sql As String = "insert into proveedor(nombre_proveedor, apellido_paterno," &
                                "apellido_materno,rfc,tipo_persona,telefono,correo_electronico,calle,colonia,cp,estado," &
                                "municipio,fecha_registro,activo) values ('" & nombre & "', '" & apellidoPaterno & "','" & apellidoMaterno & "','" &
                                 rfc & "','" & tipo & "','" & telefono & "','" & correo & "','" & calle & "','" & colonia & "','" &
                                 cp & "', '" & estado & "','" & municipio & "', CURDATE(), 1)"

            Dim bandera As Integer = MessageBox.Show("¿Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo)
            If bandera = 6 Then
                conexionBd.InsertUpdateDelete(sql)
                'Call prepararExecute(sql)
                Call limpiarTextBox()
                Call usoTextBox(True)
                Call actualizarDataGrid("")
                Button2.Enabled = False
                MessageBox.Show("Se guardo el proveedor correctamente")
            End If

        End If

        If id_proveedor <> 0 Then

            Dim nombre As String = TextBox1.Text
            Dim apellidoPaterno As String = TextBox2.Text
            Dim apellidoMaterno As String = TextBox3.Text
            Dim rfc As String = TextBox4.Text
            Dim tipo As String = ComboBox1.Text
            Dim telefono As String = TextBox5.Text
            Dim correo As String = TextBox6.Text
            Dim calle As String = TextBox7.Text
            Dim colonia As String = TextBox8.Text
            Dim cp As String = TextBox9.Text
            Dim estado As String = TextBox10.Text
            Dim municipio As String = TextBox11.Text

            Dim sql As String = "update proveedor set nombre_proveedor = '" & nombre & "',apellido_paterno = '" &
                                apellidoPaterno & "', apellido_materno = '" & apellidoMaterno & "',rfc = '" &
                                rfc & "',tipo_persona = '" & tipo & "',telefono = '" & telefono & "',correo_electronico = '" &
                                correo & "',calle = '" & calle & "',colonia = '" & colonia & "',cp = '" &
                                cp & "',estado = '" & estado & "', municipio ='" & municipio & "' where id_proveedor = " & id_proveedor & " "

            Dim bandera As Integer = MessageBox.Show("¿Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo)
            If bandera = 6 Then
                conexionBd.InsertUpdateDelete(sql)
                'Call prepararExecute(sql)
                Call limpiarTextBox()
                Call usoTextBox(True)
                Call actualizarDataGrid("")
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                MessageBox.Show("Se modificó el proveedor correctamente")
                id_proveedor = 0
            End If

        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call usoTextBox(False)
        Button3.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bandera As Integer = MessageBox.Show("¿Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo)
        If bandera = 6 Then
            Dim sql As String = "update proveedor set activo=0 where id_proveedor = " & id_proveedor & ""
            conexionBd.InsertUpdateDelete(sql)
            'Call prepararExecute(sql)
            Call limpiarTextBox()
            Call usoTextBox(True)
            Call actualizarDataGrid("")
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            MessageBox.Show("Se eliminó el proveedor correctamente")
            id_proveedor = 0
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Dim sql As String = "select id_proveedor as Id,nombre_proveedor as Nombre,
        concat(apellido_paterno,' ',apellido_materno) as Apellidos,rfc,tipo_persona as tipo,telefono,
        correo_electronico as email from proveedor where activo=1 and (
    nombre_proveedor like '%" & TextBox12.Text & "%' or 
    concat(apellido_paterno,' ',apellido_materno) like '%" & TextBox12.Text & "%' or 
    rfc like '%" & TextBox12.Text & "%' or 
    correo_electronico like '%" & TextBox12.Text & "%' or
    telefono like '%" & TextBox12.Text & "%')"
        Call actualizarDataGrid(sql)
        Call limpiarTextBox()
        Call usoTextBox(True)
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
