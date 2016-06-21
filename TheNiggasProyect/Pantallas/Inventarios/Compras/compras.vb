Public Class compras
    Dim conexionBd As New Conexion

    Private Sub compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarComboBox("select * from proveedor where activo=1")


    End Sub

    Private Sub llenarComboBox(sql As String)
        conexionBd.PropertyDataSet = conexionBd.GetData(sql)

        With ComboBox2
            .DataSource = conexionBd.PropertyDataSet.Tables(0)
            .DisplayMember = "nombre_proveedor"
            .ValueMember = "id_proveedor"
        End With
    End Sub
End Class