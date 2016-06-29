<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBusquedaCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblNumeroCliente = New System.Windows.Forms.Label()
        Me.TxtBusquedaNumero = New System.Windows.Forms.TextBox()
        Me.TxtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.BtnBusqueda = New System.Windows.Forms.Button()
        Me.GboxFiltros = New System.Windows.Forms.GroupBox()
        Me.GboxAllClientes = New System.Windows.Forms.GroupBox()
        Me.ChkActivos = New System.Windows.Forms.CheckBox()
        Me.ChkInactivos = New System.Windows.Forms.CheckBox()
        Me.GbData = New System.Windows.Forms.GroupBox()
        Me.DtgvCliente = New System.Windows.Forms.DataGridView()
        Me.GboxEdicionCliente = New System.Windows.Forms.GroupBox()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.TxtNumeroCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.GboxFiltros.SuspendLayout()
        Me.GboxAllClientes.SuspendLayout()
        Me.GbData.SuspendLayout()
        CType(Me.DtgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxEdicionCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNumeroCliente
        '
        Me.LblNumeroCliente.AutoSize = True
        Me.LblNumeroCliente.Location = New System.Drawing.Point(25, 52)
        Me.LblNumeroCliente.Name = "LblNumeroCliente"
        Me.LblNumeroCliente.Size = New System.Drawing.Size(129, 17)
        Me.LblNumeroCliente.TabIndex = 0
        Me.LblNumeroCliente.Text = "Numero de Cliente:"
        '
        'TxtBusquedaNumero
        '
        Me.TxtBusquedaNumero.Location = New System.Drawing.Point(160, 52)
        Me.TxtBusquedaNumero.Name = "TxtBusquedaNumero"
        Me.TxtBusquedaNumero.Size = New System.Drawing.Size(145, 22)
        Me.TxtBusquedaNumero.TabIndex = 1
        '
        'TxtBusquedaNombre
        '
        Me.TxtBusquedaNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBusquedaNombre.Location = New System.Drawing.Point(160, 87)
        Me.TxtBusquedaNombre.Name = "TxtBusquedaNombre"
        Me.TxtBusquedaNombre.Size = New System.Drawing.Size(303, 22)
        Me.TxtBusquedaNombre.TabIndex = 3
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.AutoSize = True
        Me.LblNombreCliente.Location = New System.Drawing.Point(25, 87)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(129, 17)
        Me.LblNombreCliente.TabIndex = 2
        Me.LblNombreCliente.Text = "Nombre de Cliente:"
        '
        'BtnBusqueda
        '
        Me.BtnBusqueda.Location = New System.Drawing.Point(311, 52)
        Me.BtnBusqueda.Name = "BtnBusqueda"
        Me.BtnBusqueda.Size = New System.Drawing.Size(75, 23)
        Me.BtnBusqueda.TabIndex = 4
        Me.BtnBusqueda.Text = "Buscar"
        Me.BtnBusqueda.UseVisualStyleBackColor = True
        '
        'GboxFiltros
        '
        Me.GboxFiltros.Controls.Add(Me.GboxAllClientes)
        Me.GboxFiltros.Controls.Add(Me.TxtBusquedaNumero)
        Me.GboxFiltros.Controls.Add(Me.BtnBusqueda)
        Me.GboxFiltros.Controls.Add(Me.LblNumeroCliente)
        Me.GboxFiltros.Controls.Add(Me.TxtBusquedaNombre)
        Me.GboxFiltros.Controls.Add(Me.LblNombreCliente)
        Me.GboxFiltros.Location = New System.Drawing.Point(21, 23)
        Me.GboxFiltros.Name = "GboxFiltros"
        Me.GboxFiltros.Size = New System.Drawing.Size(892, 152)
        Me.GboxFiltros.TabIndex = 5
        Me.GboxFiltros.TabStop = False
        Me.GboxFiltros.Text = "Filtros de Busqueda"
        '
        'GboxAllClientes
        '
        Me.GboxAllClientes.Controls.Add(Me.ChkActivos)
        Me.GboxAllClientes.Controls.Add(Me.ChkInactivos)
        Me.GboxAllClientes.Location = New System.Drawing.Point(638, 21)
        Me.GboxAllClientes.Name = "GboxAllClientes"
        Me.GboxAllClientes.Size = New System.Drawing.Size(155, 110)
        Me.GboxAllClientes.TabIndex = 7
        Me.GboxAllClientes.TabStop = False
        Me.GboxAllClientes.Text = "Todos los Clientes"
        '
        'ChkActivos
        '
        Me.ChkActivos.AutoSize = True
        Me.ChkActivos.Location = New System.Drawing.Point(37, 35)
        Me.ChkActivos.Name = "ChkActivos"
        Me.ChkActivos.Size = New System.Drawing.Size(75, 21)
        Me.ChkActivos.TabIndex = 6
        Me.ChkActivos.Text = "Activos"
        Me.ChkActivos.UseVisualStyleBackColor = True
        '
        'ChkInactivos
        '
        Me.ChkInactivos.AutoSize = True
        Me.ChkInactivos.Location = New System.Drawing.Point(37, 66)
        Me.ChkInactivos.Name = "ChkInactivos"
        Me.ChkInactivos.Size = New System.Drawing.Size(85, 21)
        Me.ChkInactivos.TabIndex = 5
        Me.ChkInactivos.Text = "Inactivos"
        Me.ChkInactivos.UseVisualStyleBackColor = True
        '
        'GbData
        '
        Me.GbData.Controls.Add(Me.DtgvCliente)
        Me.GbData.Location = New System.Drawing.Point(21, 181)
        Me.GbData.Name = "GbData"
        Me.GbData.Size = New System.Drawing.Size(892, 349)
        Me.GbData.TabIndex = 6
        Me.GbData.TabStop = False
        Me.GbData.Text = "Resultado"
        '
        'DtgvCliente
        '
        Me.DtgvCliente.AllowUserToAddRows = False
        Me.DtgvCliente.AllowUserToOrderColumns = True
        Me.DtgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DtgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtgvCliente.Location = New System.Drawing.Point(3, 18)
        Me.DtgvCliente.Name = "DtgvCliente"
        Me.DtgvCliente.RowTemplate.Height = 24
        Me.DtgvCliente.Size = New System.Drawing.Size(886, 328)
        Me.DtgvCliente.TabIndex = 0
        '
        'GboxEdicionCliente
        '
        Me.GboxEdicionCliente.Controls.Add(Me.ChkActivo)
        Me.GboxEdicionCliente.Controls.Add(Me.BtnBorrar)
        Me.GboxEdicionCliente.Controls.Add(Me.BtnGuardar)
        Me.GboxEdicionCliente.Controls.Add(Me.Label7)
        Me.GboxEdicionCliente.Controls.Add(Me.TxtEmail)
        Me.GboxEdicionCliente.Controls.Add(Me.Label6)
        Me.GboxEdicionCliente.Controls.Add(Me.TxtTelefono)
        Me.GboxEdicionCliente.Controls.Add(Me.Label5)
        Me.GboxEdicionCliente.Controls.Add(Me.TxtDomicilio)
        Me.GboxEdicionCliente.Controls.Add(Me.Label4)
        Me.GboxEdicionCliente.Controls.Add(Me.TxtApellidoMaterno)
        Me.GboxEdicionCliente.Controls.Add(Me.Label3)
        Me.GboxEdicionCliente.Controls.Add(Me.TxtApellidoPaterno)
        Me.GboxEdicionCliente.Controls.Add(Me.TxtNumeroCliente)
        Me.GboxEdicionCliente.Controls.Add(Me.Label1)
        Me.GboxEdicionCliente.Controls.Add(Me.Label2)
        Me.GboxEdicionCliente.Controls.Add(Me.TxtNombre)
        Me.GboxEdicionCliente.Location = New System.Drawing.Point(919, 181)
        Me.GboxEdicionCliente.Name = "GboxEdicionCliente"
        Me.GboxEdicionCliente.Size = New System.Drawing.Size(431, 349)
        Me.GboxEdicionCliente.TabIndex = 7
        Me.GboxEdicionCliente.TabStop = False
        Me.GboxEdicionCliente.Text = "Editar o Borrar"
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.Enabled = False
        Me.ChkActivo.Location = New System.Drawing.Point(282, 35)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(84, 21)
        Me.ChkActivo.TabIndex = 8
        Me.ChkActivo.Text = "¿Activo?"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Enabled = False
        Me.BtnBorrar.Location = New System.Drawing.Point(260, 300)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 18
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Location = New System.Drawing.Point(133, 300)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Email:"
        '
        'TxtEmail
        '
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Location = New System.Drawing.Point(148, 256)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(250, 22)
        Me.TxtEmail.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Telefono:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Location = New System.Drawing.Point(148, 223)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(250, 22)
        Me.TxtTelefono.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Domicilio:"
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDomicilio.Enabled = False
        Me.TxtDomicilio.Location = New System.Drawing.Point(148, 166)
        Me.TxtDomicilio.Multiline = True
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(250, 50)
        Me.TxtDomicilio.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Apellido Materno:"
        '
        'TxtApellidoMaterno
        '
        Me.TxtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidoMaterno.Enabled = False
        Me.TxtApellidoMaterno.Location = New System.Drawing.Point(148, 130)
        Me.TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        Me.TxtApellidoMaterno.Size = New System.Drawing.Size(250, 22)
        Me.TxtApellidoMaterno.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Apellido Paterno:"
        '
        'TxtApellidoPaterno
        '
        Me.TxtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidoPaterno.Enabled = False
        Me.TxtApellidoPaterno.Location = New System.Drawing.Point(148, 102)
        Me.TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        Me.TxtApellidoPaterno.Size = New System.Drawing.Size(250, 22)
        Me.TxtApellidoPaterno.TabIndex = 9
        '
        'TxtNumeroCliente
        '
        Me.TxtNumeroCliente.Enabled = False
        Me.TxtNumeroCliente.Location = New System.Drawing.Point(148, 39)
        Me.TxtNumeroCliente.Name = "TxtNumeroCliente"
        Me.TxtNumeroCliente.Size = New System.Drawing.Size(87, 22)
        Me.TxtNumeroCliente.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No. Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre de Cliente:"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(148, 74)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(250, 22)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(1083, 72)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(150, 22)
        Me.TxtId.TabIndex = 19
        Me.TxtId.Visible = False
        '
        'FrmBusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 563)
        Me.Controls.Add(Me.GboxEdicionCliente)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.GbData)
        Me.Controls.Add(Me.GboxFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBusquedaCliente"
        Me.Text = "Buscar Cliente"
        Me.GboxFiltros.ResumeLayout(False)
        Me.GboxFiltros.PerformLayout()
        Me.GboxAllClientes.ResumeLayout(False)
        Me.GboxAllClientes.PerformLayout()
        Me.GbData.ResumeLayout(False)
        CType(Me.DtgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxEdicionCliente.ResumeLayout(False)
        Me.GboxEdicionCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumeroCliente As Label
    Friend WithEvents TxtBusquedaNumero As TextBox
    Friend WithEvents TxtBusquedaNombre As TextBox
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents BtnBusqueda As Button
    Friend WithEvents GboxFiltros As GroupBox
    Friend WithEvents GbData As GroupBox
    Friend WithEvents DtgvCliente As DataGridView
    Friend WithEvents GboxAllClientes As GroupBox
    Friend WithEvents ChkActivos As CheckBox
    Friend WithEvents ChkInactivos As CheckBox
    Friend WithEvents GboxEdicionCliente As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellidoPaterno As TextBox
    Friend WithEvents TxtNumeroCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellidoMaterno As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents ChkActivo As CheckBox
End Class
