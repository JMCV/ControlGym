Imports MySql.Data.MySqlClient

Module Module1

    Public conn As MySqlConnection

    Sub conectar_bd()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "Server=localhost;Uid=root;Pwd=root;Database=nigga;CharSet=utf8mb4"
            conn.Open()
            'MessageBox.Show("Conectado al Servidor")
        Catch ex As MySqlException
            MessageBox.Show("Error de conexion")
        End Try
    End Sub

    Public Function abre_consulta(cadena As String) As DataSet
        Dim da As MySqlDataAdapter
        Dim cm As MySqlCommand
        Dim ds As DataSet
        cm = New MySqlCommand()
        cm.CommandText = cadena
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        da = New MySqlDataAdapter(cm)
        ds = New DataSet()
        da.Fill(ds)
        Return ds
    End Function
    Sub executar(cadena As String)

        Dim cm As MySqlCommand
        cm = New MySqlCommand()
        cm.CommandText = cadena
        cm.Connection = conn
        cm.Prepare()
        cm.ExecuteNonQuery()

    End Sub

End Module
