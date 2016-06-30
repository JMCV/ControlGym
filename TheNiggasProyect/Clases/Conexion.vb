Imports MySql.Data.MySqlClient
Public Class Conexion
    Friend MysqlConexion As New MySqlConnection
    Dim Adapter As MySqlDataAdapter
    Dim command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim Data As New DataSet
    Dim Table As DataTable
    Dim servidor As String
    Dim nombreBD As String
    Dim usuario As String
    Dim password As String
    Dim puerto As Integer

    'Dim consulta As String
    Public Property PropertyServidor() As String
        Get
            ' Obtener el Valor al atributo nombre
            Return servidor
        End Get
        Set(ByVal Value As String)
            ' Enviar el Valor al atributo nombre
            servidor = Value
        End Set
    End Property
    Public Property PropertyNombreBD() As String
        Get
            ' Obtener el Valor al atributo nombre
            Return nombreBD
        End Get
        Set(ByVal Value As String)
            ' Enviar el Valor al atributo nombre
            nombreBD = Value
        End Set
    End Property
    Public Property PropertyUsuario() As String
        Get
            ' Obtener el Valor al atributo nombre
            Return usuario
        End Get
        Set(ByVal Value As String)
            ' Enviar el Valor al atributo nombre
            usuario = Value
        End Set
    End Property
    Public Property PropertyPassword() As String
        Get
            ' Obtener el Valor al atributo nombre
            Return password
        End Get
        Set(ByVal Value As String)
            ' Enviar el Valor al atributo nombre
            password = Value
        End Set
    End Property
    Public Property PropertyConexion() As MySqlConnection
        Get
            ' Obtener el Valor al atributo nombre
            Return MysqlConexion
        End Get
        Set(ByVal Value As MySqlConnection)
            ' Enviar el Valor al atributo nombre
            MysqlConexion = Value
        End Set
    End Property

    Public Property PropertyAdaptador() As MySqlDataAdapter
        Get
            ' Obtener el Valor al atributo nombre
            Return Adapter
        End Get
        Set(ByVal Value As MySqlDataAdapter)
            ' Enviar el Valor al atributo nombre
            Adapter = Value
        End Set
    End Property

    Public Property PropertyDataSet() As DataSet
        Get
            ' Obtener el Valor al atributo nombre
            Return Data
        End Get
        Set(ByVal Value As DataSet)
            ' Enviar el Valor al atributo nombre
            Data = Value
        End Set
    End Property
    Public Property PropertyCommand() As MySqlCommand
        Get
            ' Obtener el Valor al atributo nombre
            Return command
        End Get
        Set(ByVal Value As MySqlCommand)
            ' Enviar el Valor al atributo nombre
            command = Value
        End Set
    End Property
    Public Property PropertyReader() As MySqlDataReader
        Get
            ' Obtener el Valor al atributo nombre
            Return Reader
        End Get
        Set(ByVal Value As MySqlDataReader)
            ' Enviar el Valor al atributo nombre
            Reader = Value
        End Set
    End Property
    Public Property PropertyTable() As DataTable
        Get
            ' Obtener el Valor al atributo nombre
            Return Table
        End Get
        Set(ByVal Value As DataTable)
            ' Enviar el Valor al atributo nombre
            Table = Value
        End Set
    End Property
    Public Sub New()
        Me.nombreBD = "gimnasio"
        Me.servidor = "localhost"
        Me.usuario = "root"
        Me.password = "c1r7g4s"
        MysqlConexion.ConnectionString = "server=" & servidor & ";database=" & nombreBD & ";user id=" & usuario & "; password=" & password & ";"
    End Sub

    Public Sub abrirBD()
        Try
            Me.MysqlConexion.Open()
            'MsgBox("conexion exitosa!")
        Catch
            MsgBox("fallo en la conexion")
        End Try
    End Sub

    Public Sub cerrarBd()
        Try
            Me.MysqlConexion.Close()
            'MsgBox("se ha desconectado de la bd")
        Catch
            MsgBox("fallo al momento de desconectar la bd")
        End Try
    End Sub

    Function InsertUpdateDelete(ByVal consulta As String) As Boolean
        Try
            Me.PropertyConexion.Open()                      'Se abre la base de datos
            Me.PropertyCommand = New MySqlCommand           'Se crea instancia la propiedad MysqlCommand del objeto
            With Me.PropertyCommand                         'Se iniciliza la propiedad MysqlCommand del objeto
                .Connection = Me.PropertyConexion                   'indica conexion
                .CommandText = consulta                             'consulta sql
            End With
            Me.PropertyCommand.ExecuteNonQuery()            'Ejecuta el query
            Me.PropertyConexion.Close()                     'Cierra Base de datos
            Return True                                     'Retorna Exito
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio el siguiente problema: " & ex.Message)
            Return False
        End Try
    End Function

    Function GetData(ByVal consulta As String) As DataSet
        Try
            Me.PropertyConexion.Open()                      'Se abre la base de datos
            Me.PropertyCommand = New MySqlCommand           'Se crea instancia la propiedad MysqlCommand del objeto
            With Me.PropertyCommand                         'Se iniciliza la propiedad MysqlCommand del objeto
                .Connection = Me.PropertyConexion                   'indica conexion
                .CommandText = consulta                             'consulta sql               
            End With

            Me.PropertyAdaptador = New MySqlDataAdapter(Me.PropertyCommand) 'se crea instancia del adaptador del objeto
            Me.PropertyDataSet = New DataSet                                'se crea instancia del dataset del objeto
            Me.PropertyAdaptador.Fill(Me.PropertyDataSet)                   'se llena el adaptador del objeto

            If Me.PropertyDataSet.Tables(0).Rows.Count <> 0 Then            'valida registros                 
                Me.PropertyTable = New DataTable
                Me.PropertyReader = Me.PropertyCommand.ExecuteReader        'se inicializa el MysqlDataReader del objeto
                Me.PropertyTable.Load(Me.PropertyReader)
                Me.PropertyConexion.Close()                                  'cierra base de datos   
                Return Me.PropertyDataSet                                   'Retorna DataSet del Objeto    
            Else
                Me.PropertyConexion.Close()                                 'Cierra base de datos en caso de que no cumpla con la validacion
                Return Nothing                                              'Retorna Nulo    
            End If
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio el siguiente problema: " & ex.Message)
            Return Nothing
        End Try
    End Function

End Class
