<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogoServicios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.GbRegistro = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.LblFiltro = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvServicios = New System.Windows.Forms.DataGridView()
        Me.GbServicios = New System.Windows.Forms.GroupBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.GbRegistro.SuspendLayout()
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(11, 29)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(86, 17)
        Me.LblDescripcion.TabIndex = 0
        Me.LblDescripcion.Text = "Descripcion:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(14, 49)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(652, 49)
        Me.TxtDescripcion.TabIndex = 1
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(11, 115)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(68, 17)
        Me.LblCantidad.TabIndex = 2
        Me.LblCantidad.Text = "Cantidad:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(85, 113)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.TxtCantidad.TabIndex = 3
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(205, 115)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(40, 17)
        Me.LblTipo.TabIndex = 4
        Me.LblTipo.Text = "Tipo:"
        '
        'CmbTipo
        '
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"MES", "DIA(S)"})
        Me.CmbTipo.Location = New System.Drawing.Point(242, 112)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(121, 24)
        Me.CmbTipo.TabIndex = 5
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(437, 115)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 22)
        Me.txtPrecio.TabIndex = 7
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(379, 115)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(52, 17)
        Me.LblPrecio.TabIndex = 6
        Me.LblPrecio.Text = "Precio:"
        '
        'GbRegistro
        '
        Me.GbRegistro.Controls.Add(Me.chkActivo)
        Me.GbRegistro.Controls.Add(Me.TxtDescripcion)
        Me.GbRegistro.Controls.Add(Me.txtPrecio)
        Me.GbRegistro.Controls.Add(Me.LblDescripcion)
        Me.GbRegistro.Controls.Add(Me.LblPrecio)
        Me.GbRegistro.Controls.Add(Me.LblCantidad)
        Me.GbRegistro.Controls.Add(Me.CmbTipo)
        Me.GbRegistro.Controls.Add(Me.TxtCantidad)
        Me.GbRegistro.Controls.Add(Me.LblTipo)
        Me.GbRegistro.Enabled = False
        Me.GbRegistro.Location = New System.Drawing.Point(12, 12)
        Me.GbRegistro.Name = "GbRegistro"
        Me.GbRegistro.Size = New System.Drawing.Size(689, 156)
        Me.GbRegistro.TabIndex = 8
        Me.GbRegistro.TabStop = False
        Me.GbRegistro.Text = "Registro"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(568, 115)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(84, 21)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "¿Activo?"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'LblFiltro
        '
        Me.LblFiltro.AutoSize = True
        Me.LblFiltro.Location = New System.Drawing.Point(36, 35)
        Me.LblFiltro.Name = "LblFiltro"
        Me.LblFiltro.Size = New System.Drawing.Size(43, 17)
        Me.LblFiltro.TabIndex = 9
        Me.LblFiltro.Text = "Filtro:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Location = New System.Drawing.Point(80, 35)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(564, 22)
        Me.txtBusqueda.TabIndex = 10
        '
        'DgvServicios
        '
        Me.DgvServicios.AllowUserToAddRows = False
        Me.DgvServicios.AllowUserToDeleteRows = False
        Me.DgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvServicios.Location = New System.Drawing.Point(6, 75)
        Me.DgvServicios.Name = "DgvServicios"
        Me.DgvServicios.ReadOnly = True
        Me.DgvServicios.RowTemplate.Height = 24
        Me.DgvServicios.Size = New System.Drawing.Size(675, 203)
        Me.DgvServicios.TabIndex = 11
        '
        'GbServicios
        '
        Me.GbServicios.Controls.Add(Me.DgvServicios)
        Me.GbServicios.Controls.Add(Me.LblFiltro)
        Me.GbServicios.Controls.Add(Me.txtBusqueda)
        Me.GbServicios.Location = New System.Drawing.Point(12, 183)
        Me.GbServicios.Name = "GbServicios"
        Me.GbServicios.Size = New System.Drawing.Size(689, 290)
        Me.GbServicios.TabIndex = 12
        Me.GbServicios.TabStop = False
        Me.GbServicios.Text = "Busqueda"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(26, 488)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(83, 34)
        Me.BtnNuevo.TabIndex = 13
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(125, 488)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 34)
        Me.BtnGuardar.TabIndex = 14
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(518, 500)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(175, 22)
        Me.TxtId.TabIndex = 16
        Me.TxtId.Visible = False
        '
        'FrmCatalogoServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 534)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GbServicios)
        Me.Controls.Add(Me.GbRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCatalogoServicios"
        Me.Text = "Servicios"
        Me.GbRegistro.ResumeLayout(False)
        Me.GbRegistro.PerformLayout()
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbServicios.ResumeLayout(False)
        Me.GbServicios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDescripcion As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LblCantidad As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents LblTipo As Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents LblPrecio As Label
    Friend WithEvents GbRegistro As GroupBox
    Friend WithEvents LblFiltro As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents DgvServicios As DataGridView
    Friend WithEvents GbServicios As GroupBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtId As TextBox
End Class
