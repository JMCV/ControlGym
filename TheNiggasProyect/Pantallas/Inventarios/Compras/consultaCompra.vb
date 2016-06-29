Public Class consultaCompra
    Dim conexionBd As New Conexion

    Private Sub consultaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select es.id_entrada_salida as id,p.nombre_proveedor as Proveedor, f.folio as Folio,f.tipo_documento as Tipo,
f.fecha as Fecha,f.subtotal as SubTotal, f.iva as Iva, f.total as Total from factura f 
join proveedor p on p.id_proveedor = f.id_proveedor
join entrada_salida es on es.id_factura = f.id_factura
where es.activo = 1
order by f.fecha"
        actualizarCatalogoCompras(sql)

    End Sub

    Sub actualizarCatalogoCompras(sql As String)
        conexionBd.PropertyDataSet = conexionBd.GetData(sql)
        If (conexionBd.PropertyDataSet IsNot Nothing) Then
            DataGridView1.DataSource = conexionBd.PropertyDataSet.Tables(0).DefaultView
            DataGridView1.AutoResizeColumns()
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Else
            DataGridView1.DataSource = Nothing
            DataGridView1.Refresh()
        End If
    End Sub

    Sub actualizarCatalogoDetalleCompras(sql As String)
        conexionBd.PropertyDataSet = conexionBd.GetData(sql)
        If (conexionBd.PropertyDataSet IsNot Nothing) Then
            DataGridView2.DataSource = conexionBd.PropertyDataSet.Tables(0).DefaultView
            DataGridView2.AutoResizeColumns()
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Else
            DataGridView2.DataSource = Nothing
            DataGridView2.Refresh()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim sql As String = "select es.id_entrada_salida as id,p.nombre_proveedor as Proveedor, f.folio as Folio,f.tipo_documento as Tipo,
f.fecha as Fecha,f.subtotal as SubTotal, f.iva as Iva, f.total as Total from factura f 
join proveedor p on p.id_proveedor = f.id_proveedor 
join entrada_salida es on es.id_factura = f.id_factura
where (p.nombre_proveedor like '%" & TextBox1.Text & "%' or 
f.folio like '%" & TextBox1.Text & "%' or f.tipo_documento like '%" & TextBox1.Text & "%' or 
f.fecha like '%" & TextBox1.Text & "%') and es.activo=1 
order by f.fecha"
        actualizarCatalogoCompras(sql)
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim id_entrada_salida As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim sql As String = "select p.id_producto as id,p.nombre as Nombre, des.precio_unitario as Precio,
des.cantidad as Cantidad, des.total as Total from detalle_entrada_salida des 
join producto p on p.id_producto = des.id_producto 
where des.id_entrada_salida = " & id_entrada_salida & ""

        actualizarCatalogoDetalleCompras(sql)

    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick

        Dim bandera As Integer = MessageBox.Show("¿Estás seguro que deseas eliminar?", "Confirmacion", MessageBoxButtons.YesNo)
        If bandera = 6 Then
            Dim sql As String
            Dim id_entrada_salida As Integer = DataGridView1.CurrentRow.Cells(0).Value
            For index As Integer = 0 To (DataGridView2.RowCount - 1)
                Dim id_producto As Integer = DataGridView2.Rows.Item(index).Cells(0).Value
                Dim cantidad As Integer = DataGridView2.Rows.Item(index).Cells(3).Value
                sql = "update producto set cantidad =  cantidad - " & cantidad & " where id_producto = " & id_producto
                conexionBd.InsertUpdateDelete(sql)
            Next index
            sql = "update entrada_salida set activo=0 where id_entrada_salida = " & id_entrada_salida & ""
            conexionBd.InsertUpdateDelete(sql)
            sql = "update factura f join entrada_salida es on es.id_factura = f.id_factura
set f.activo=0 where es.id_entrada_salida = " & id_entrada_salida & ""
            conexionBd.InsertUpdateDelete(sql)
            MessageBox.Show("Se eliminó la compra correctamente")

            sql = "select es.id_entrada_salida as id,p.nombre_proveedor as Proveedor, f.folio as Folio,f.tipo_documento as Tipo,
f.fecha as Fecha,f.subtotal as SubTotal, f.iva as Iva, f.total as Total from factura f 
join proveedor p on p.id_proveedor = f.id_proveedor
join entrada_salida es on es.id_factura = f.id_factura
where es.activo = 1
order by f.fecha"
            actualizarCatalogoCompras(sql)


        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If String.IsNullOrEmpty(DataGridView1.CurrentRow.Cells(0).Value) Then
            Exit Sub
        End If
        Dim id_entrada_salida As Integer = DataGridView1.CurrentRow.Cells(0).Value

        Dim sql As String = "select p.id_producto as id,p.nombre as Nombre, des.precio_unitario as Precio,
des.cantidad as Cantidad, des.total as Total from detalle_entrada_salida des 
join producto p on p.id_producto = des.id_producto 
where des.id_entrada_salida = " & id_entrada_salida & " "

        actualizarCatalogoDetalleCompras(sql)

    End Sub
End Class