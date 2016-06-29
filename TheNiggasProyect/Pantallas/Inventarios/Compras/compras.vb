Public Class compras
    Dim conexionBd As New Conexion

    Friend subtotal As Double = 0
    Friend iva As Double = 0
    Friend total As Double = 0

    Private Sub compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarComboBoxProveedor("select id_proveedor,nombre_proveedor from proveedor where activo=1")
        llenarComboBoxProducto("select id_producto,nombre from producto")


    End Sub

    Private Sub llenarComboBoxProveedor(sql As String)
        conexionBd.PropertyDataSet = conexionBd.GetData(sql)

        With ComboBox2
            .DataSource = conexionBd.PropertyDataSet.Tables(0)
            .DisplayMember = "nombre_proveedor"
            .ValueMember = "id_proveedor"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub

    Private Sub llenarComboBoxProducto(sql As String)
        conexionBd.PropertyDataSet = conexionBd.GetData(sql)

        With ComboBox3
            .DataSource = conexionBd.PropertyDataSet.Tables(0)
            .DisplayMember = "nombre"
            .ValueMember = "id_producto"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.Rows.Add(ComboBox3.SelectedValue, ComboBox3.Text, TextBox2.Text, TextBox3.Text)
        calcularTotalFactura(TextBox2.Text, TextBox3.Text)
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub calcularTotalFactura(cantidad As Double, precio As Double)
        subtotal = subtotal + (cantidad * precio)
        iva = subtotal * 0.16
        total = subtotal + iva

        TextBox4.Text = subtotal
        TextBox5.Text = iva
        TextBox6.Text = total
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

        Dim bandera As Integer = MessageBox.Show("¿Desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo)
        If bandera = 6 Then
            calcularTotalFactura(DataGridView1.CurrentRow.Cells(2).Value, -DataGridView1.CurrentRow.Cells(3).Value)
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bandera As Integer = MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo)
        If bandera = 6 Then

            Dim fecha As String = DateTimePicker1.Value.ToShortDateString
            fecha = Format(CDate(fecha), "yyyy/MM/dd")
            Dim folio As String = TextBox1.Text
            Dim tipo As String = ComboBox1.Text
            Dim id_proveedor As Integer = ComboBox2.SelectedValue
            Dim observaciones As String = TextBox7.Text

            Dim sql As String = "insert into factura(folio,tipo_documento,fecha,subtotal,iva,total,
observaciones,id_proveedor,activo) values ('" & folio & "','" & tipo & "','" & fecha & "'," & subtotal & ",
" & iva & "," & total & ",'" & observaciones & "'," & id_proveedor & ",1)"

            conexionBd.InsertUpdateDelete(sql)

            sql = "select max(id_factura) as id from factura"
            conexionBd.PropertyDataSet = conexionBd.GetData(sql)
            If conexionBd.PropertyTable.Rows.Count > 0 Then
                Dim id_factura As Integer = conexionBd.PropertyTable.Rows(0).Item("id")
                sql = "insert into entrada_salida(id_factura,tipo,fecha,subtotal,iva,descuento,total,observacion,activo) 
values(" & id_factura & ",'ENTRADA','" & fecha & "'," & subtotal & "," & iva & ",0," & total & ",'" & observaciones & "',1)"
                conexionBd.InsertUpdateDelete(sql)
            End If

            sql = "select max(id_entrada_salida) as id from entrada_salida"
            conexionBd.PropertyDataSet = conexionBd.GetData(sql)
            If conexionBd.PropertyTable.Rows.Count > 0 Then
                Dim id_entrada_salida As Integer = conexionBd.PropertyTable.Rows(0).Item("id")
                For index As Integer = 0 To (DataGridView1.RowCount - 2)
                    Dim id_producto As Integer = DataGridView1.Rows.Item(index).Cells(0).Value
                    Dim cantidad As Double = DataGridView1.Rows.Item(index).Cells(2).Value
                    Dim precio As Double = DataGridView1.Rows.Item(index).Cells(3).Value
                    sql = "insert into detalle_entrada_salida(id_producto,id_entrada_salida,
precio_unitario,cantidad,total) values (" & id_producto & "," & id_entrada_salida & ",
" & precio & "," & cantidad & "," & (precio * cantidad) & ")"
                    conexionBd.InsertUpdateDelete(sql)
                    sql = "select cantidad from producto where id_producto = " & id_producto & ""
                    conexionBd.PropertyDataSet = conexionBd.GetData(sql)
                    If conexionBd.PropertyTable.Rows.Count > 0 Then
                        Dim inventario As Integer = conexionBd.PropertyTable.Rows(0).Item("cantidad")
                        sql = "update producto set cantidad = " & (cantidad + inventario) & " where id_producto = " & id_producto & ""
                        conexionBd.InsertUpdateDelete(sql)
                    End If

                Next index

                MessageBox.Show("Se registró la compra correctamente")
            End If




        End If
    End Sub

End Class