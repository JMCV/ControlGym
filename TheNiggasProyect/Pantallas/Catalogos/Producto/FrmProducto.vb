Public Class FrmProducto
    Dim operacion As String
    Dim strQuery As String
    Dim id As Long
    Dim conexionBd As New Conexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
        operacion = "NUEVO"
        Call limpia()
        Call usar(True)
        txtnombre.Focus()
    End Sub
    Sub limpia()
        txtclave.Text = ""
        txtnombre.Text = ""
        txtunidad.Text = ""
        txtmaximo.Text = ""
        txtminimo.Text = ""
    End Sub
    Sub usar(valor As Boolean)
        txtclave.Enabled = valor
        txtnombre.Enabled = valor
        txtmaximo.Enabled = valor
        txtminimo.Enabled = valor
        txtunidad.Enabled = valor
        bt_grabar.Enabled = valor
    End Sub
    Private Sub cat_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacion = ""
        llenar()
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        operacion = "EDITAR"
        Call usar(True)
        id = dgv1.CurrentRow.Cells(0).Value
        txtclave.Text = dgv1.CurrentRow.Cells(0).Value.ToString
        txtnombre.Text = dgv1.CurrentRow.Cells(1).Value.ToString
        txtunidad.Text = dgv1.CurrentRow.Cells(5).Value.ToString
        txtmaximo.Text = dgv1.CurrentRow.Cells(2).Value.ToString
        txtminimo.Text = dgv1.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub bt_grabar_Click(sender As Object, e As EventArgs) Handles bt_grabar.Click
        Try
            If operacion = "NUEVO" Then

                strQuery = "INSERT INTO producto (nombre,unidad,maximo,minimo,cantidad) " &
                    " VALUES('" & txtnombre.Text & "','" & txtunidad.Text & "'," & txtmaximo.Text & "," & txtminimo.Text & ",0)"

                conexionBd.InsertUpdateDelete(strQuery)
                Call llenar()

            ElseIf operacion = "EDITAR" Then
                strQuery = "UPDATE producto SET nombre='" &
                     txtnombre.Text & "',unidad='" & txtunidad.Text & "',maximo=" & txtmaximo.Text & ",minimo=" & txtminimo.Text & " where idproducto=" & id
                conexionBd.InsertUpdateDelete(strQuery)
                Call llenar()
            End If
            Call limpia()
            Call usar(False)
        Catch ex As Exception
            MessageBox.Show("Ocurrio el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub llenar()
        strQuery = "select * from producto"
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MsgBox("Deseas Borrar ", vbYesNo) = vbYes Then
                id = dgv1.CurrentRow.Cells(0).Value
                strQuery = "delete from producto where id_producto=" & id
                conexionBd.InsertUpdateDelete(strQuery)
                Call llenar()
            End If
            Call limpia()
            Call usar(False)
        Catch ex As Exception
            MessageBox.Show("Ocurrio el siguiente error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If txtminimo.TextLength < 3 Then Exit Sub
        conexionBd.PropertyDataSet = conexionBd.GetData("select * from producto where nombre like '%" & txtminimo.Text & "%'")
        dgv1.DataSource = conexionBd.PropertyDataSet.Tables(0).DefaultView
        dgv1.AutoResizeColumns()
        dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TxtBusquedaProducto.TextChanged
        limpia()
        If TxtBusquedaProducto.Text <> Nothing Then
            strQuery = "Select nombre as Producto, unidad as Unidad,maximo as 'Stock Maximo',minimo as 'Stock Minimo',cantidad as 'Existencia' from producto where  nombre  LIKE '%" & TxtBusquedaProducto.Text & "%'"
            If conexionBd.GetData(strQuery) IsNot Nothing Then
                dgv1.DataSource = conexionBd.GetData(strQuery).Tables(0).DefaultView
            Else
                dgv1.DataSource = Nothing
                dgv1.Refresh()
            End If
        End If
    End Sub
End Class
