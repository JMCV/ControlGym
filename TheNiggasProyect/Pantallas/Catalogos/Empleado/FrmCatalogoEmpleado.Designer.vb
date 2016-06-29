<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogoEmpleado
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
        Me.GbEmpleado = New System.Windows.Forms.GroupBox()
        Me.ChkActivoEmpleado = New System.Windows.Forms.CheckBox()
        Me.TxtPuestoEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtCorreoEmpleado = New System.Windows.Forms.TextBox()
        Me.LblPuesto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.TxtApellidoMaternoEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtDomicilioEmpleado = New System.Windows.Forms.TextBox()
        Me.LblApellidoMaterno = New System.Windows.Forms.Label()
        Me.TxtApellidoPaternoEmpleado = New System.Windows.Forms.TextBox()
        Me.LblApellidoPaterno = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GbBusquedaEmpleado = New System.Windows.Forms.GroupBox()
        Me.TxtBusquedaEmpleado = New System.Windows.Forms.TextBox()
        Me.LblFiltroEmpleado = New System.Windows.Forms.Label()
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.BtnNuevoEmpleado = New System.Windows.Forms.Button()
        Me.BtnGuardarEmpleado = New System.Windows.Forms.Button()
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbEmpleado.SuspendLayout()
        Me.GbBusquedaEmpleado.SuspendLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbEmpleado
        '
        Me.GbEmpleado.Controls.Add(Me.TextBox2)
        Me.GbEmpleado.Controls.Add(Me.Label2)
        Me.GbEmpleado.Controls.Add(Me.TextBox1)
        Me.GbEmpleado.Controls.Add(Me.Label1)
        Me.GbEmpleado.Controls.Add(Me.ChkActivoEmpleado)
        Me.GbEmpleado.Controls.Add(Me.TxtPuestoEmpleado)
        Me.GbEmpleado.Controls.Add(Me.TxtCorreoEmpleado)
        Me.GbEmpleado.Controls.Add(Me.LblPuesto)
        Me.GbEmpleado.Controls.Add(Me.Label5)
        Me.GbEmpleado.Controls.Add(Me.LblDomicilio)
        Me.GbEmpleado.Controls.Add(Me.TxtApellidoMaternoEmpleado)
        Me.GbEmpleado.Controls.Add(Me.TxtDomicilioEmpleado)
        Me.GbEmpleado.Controls.Add(Me.LblApellidoMaterno)
        Me.GbEmpleado.Controls.Add(Me.TxtApellidoPaternoEmpleado)
        Me.GbEmpleado.Controls.Add(Me.LblApellidoPaterno)
        Me.GbEmpleado.Controls.Add(Me.LblTelefono)
        Me.GbEmpleado.Controls.Add(Me.txtNombreEmpleado)
        Me.GbEmpleado.Controls.Add(Me.TxtTelefonoEmpleado)
        Me.GbEmpleado.Controls.Add(Me.LblNombre)
        Me.GbEmpleado.Enabled = False
        Me.GbEmpleado.Location = New System.Drawing.Point(41, 12)
        Me.GbEmpleado.Name = "GbEmpleado"
        Me.GbEmpleado.Size = New System.Drawing.Size(686, 191)
        Me.GbEmpleado.TabIndex = 0
        Me.GbEmpleado.TabStop = False
        Me.GbEmpleado.Text = "Nuevo Empleado"
        '
        'ChkActivoEmpleado
        '
        Me.ChkActivoEmpleado.AutoSize = True
        Me.ChkActivoEmpleado.Location = New System.Drawing.Point(545, 148)
        Me.ChkActivoEmpleado.Name = "ChkActivoEmpleado"
        Me.ChkActivoEmpleado.Size = New System.Drawing.Size(84, 21)
        Me.ChkActivoEmpleado.TabIndex = 50
        Me.ChkActivoEmpleado.Text = "¿Activo?"
        Me.ChkActivoEmpleado.UseVisualStyleBackColor = True
        '
        'TxtPuestoEmpleado
        '
        Me.TxtPuestoEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPuestoEmpleado.Location = New System.Drawing.Point(122, 137)
        Me.TxtPuestoEmpleado.Name = "TxtPuestoEmpleado"
        Me.TxtPuestoEmpleado.Size = New System.Drawing.Size(150, 22)
        Me.TxtPuestoEmpleado.TabIndex = 7
        '
        'TxtCorreoEmpleado
        '
        Me.TxtCorreoEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCorreoEmpleado.Location = New System.Drawing.Point(406, 102)
        Me.TxtCorreoEmpleado.Name = "TxtCorreoEmpleado"
        Me.TxtCorreoEmpleado.Size = New System.Drawing.Size(263, 22)
        Me.TxtCorreoEmpleado.TabIndex = 6
        '
        'LblPuesto
        '
        Me.LblPuesto.AutoSize = True
        Me.LblPuesto.Location = New System.Drawing.Point(60, 137)
        Me.LblPuesto.Name = "LblPuesto"
        Me.LblPuesto.Size = New System.Drawing.Size(56, 17)
        Me.LblPuesto.TabIndex = 12
        Me.LblPuesto.Text = "Puesto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Correo Electronico:"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(332, 66)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(68, 17)
        Me.LblDomicilio.TabIndex = 10
        Me.LblDomicilio.Text = "Domicilio:"
        '
        'TxtApellidoMaternoEmpleado
        '
        Me.TxtApellidoMaternoEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidoMaternoEmpleado.Location = New System.Drawing.Point(122, 71)
        Me.TxtApellidoMaternoEmpleado.Name = "TxtApellidoMaternoEmpleado"
        Me.TxtApellidoMaternoEmpleado.Size = New System.Drawing.Size(150, 22)
        Me.TxtApellidoMaternoEmpleado.TabIndex = 3
        '
        'TxtDomicilioEmpleado
        '
        Me.TxtDomicilioEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDomicilioEmpleado.Location = New System.Drawing.Point(406, 66)
        Me.TxtDomicilioEmpleado.Name = "TxtDomicilioEmpleado"
        Me.TxtDomicilioEmpleado.Size = New System.Drawing.Size(263, 22)
        Me.TxtDomicilioEmpleado.TabIndex = 4
        '
        'LblApellidoMaterno
        '
        Me.LblApellidoMaterno.AutoSize = True
        Me.LblApellidoMaterno.Location = New System.Drawing.Point(6, 74)
        Me.LblApellidoMaterno.Name = "LblApellidoMaterno"
        Me.LblApellidoMaterno.Size = New System.Drawing.Size(118, 17)
        Me.LblApellidoMaterno.TabIndex = 4
        Me.LblApellidoMaterno.Text = "Apellido Materno:"
        '
        'TxtApellidoPaternoEmpleado
        '
        Me.TxtApellidoPaternoEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidoPaternoEmpleado.Location = New System.Drawing.Point(406, 30)
        Me.TxtApellidoPaternoEmpleado.Name = "TxtApellidoPaternoEmpleado"
        Me.TxtApellidoPaternoEmpleado.Size = New System.Drawing.Size(150, 22)
        Me.TxtApellidoPaternoEmpleado.TabIndex = 2
        '
        'LblApellidoPaterno
        '
        Me.LblApellidoPaterno.AutoSize = True
        Me.LblApellidoPaterno.Location = New System.Drawing.Point(293, 33)
        Me.LblApellidoPaterno.Name = "LblApellidoPaterno"
        Me.LblApellidoPaterno.Size = New System.Drawing.Size(116, 17)
        Me.LblApellidoPaterno.TabIndex = 2
        Me.LblApellidoPaterno.Text = "Apellido Paterno:"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(48, 107)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(68, 17)
        Me.LblTelefono.TabIndex = 6
        Me.LblTelefono.Text = "Telefono:"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(122, 33)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(150, 22)
        Me.txtNombreEmpleado.TabIndex = 1
        '
        'TxtTelefonoEmpleado
        '
        Me.TxtTelefonoEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefonoEmpleado.Location = New System.Drawing.Point(122, 107)
        Me.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado"
        Me.TxtTelefonoEmpleado.Size = New System.Drawing.Size(150, 22)
        Me.TxtTelefonoEmpleado.TabIndex = 5
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(54, 36)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(62, 17)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'GbBusquedaEmpleado
        '
        Me.GbBusquedaEmpleado.Controls.Add(Me.TxtBusquedaEmpleado)
        Me.GbBusquedaEmpleado.Controls.Add(Me.LblFiltroEmpleado)
        Me.GbBusquedaEmpleado.Controls.Add(Me.DgvEmpleados)
        Me.GbBusquedaEmpleado.Location = New System.Drawing.Point(12, 222)
        Me.GbBusquedaEmpleado.Name = "GbBusquedaEmpleado"
        Me.GbBusquedaEmpleado.Size = New System.Drawing.Size(715, 243)
        Me.GbBusquedaEmpleado.TabIndex = 1
        Me.GbBusquedaEmpleado.TabStop = False
        Me.GbBusquedaEmpleado.Text = "Busqueda"
        '
        'TxtBusquedaEmpleado
        '
        Me.TxtBusquedaEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBusquedaEmpleado.Location = New System.Drawing.Point(151, 34)
        Me.TxtBusquedaEmpleado.Name = "TxtBusquedaEmpleado"
        Me.TxtBusquedaEmpleado.Size = New System.Drawing.Size(547, 22)
        Me.TxtBusquedaEmpleado.TabIndex = 11
        '
        'LblFiltroEmpleado
        '
        Me.LblFiltroEmpleado.AutoSize = True
        Me.LblFiltroEmpleado.Location = New System.Drawing.Point(104, 34)
        Me.LblFiltroEmpleado.Name = "LblFiltroEmpleado"
        Me.LblFiltroEmpleado.Size = New System.Drawing.Size(43, 17)
        Me.LblFiltroEmpleado.TabIndex = 10
        Me.LblFiltroEmpleado.Text = "Filtro:"
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        Me.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Location = New System.Drawing.Point(29, 70)
        Me.DgvEmpleados.MultiSelect = False
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvEmpleados.RowTemplate.Height = 24
        Me.DgvEmpleados.Size = New System.Drawing.Size(669, 162)
        Me.DgvEmpleados.TabIndex = 0
        '
        'BtnNuevoEmpleado
        '
        Me.BtnNuevoEmpleado.Location = New System.Drawing.Point(41, 485)
        Me.BtnNuevoEmpleado.Name = "BtnNuevoEmpleado"
        Me.BtnNuevoEmpleado.Size = New System.Drawing.Size(90, 30)
        Me.BtnNuevoEmpleado.TabIndex = 2
        Me.BtnNuevoEmpleado.Text = "Nuevo"
        Me.BtnNuevoEmpleado.UseVisualStyleBackColor = True
        '
        'BtnGuardarEmpleado
        '
        Me.BtnGuardarEmpleado.Location = New System.Drawing.Point(163, 485)
        Me.BtnGuardarEmpleado.Name = "BtnGuardarEmpleado"
        Me.BtnGuardarEmpleado.Size = New System.Drawing.Size(90, 30)
        Me.BtnGuardarEmpleado.TabIndex = 9
        Me.BtnGuardarEmpleado.Text = "Guardar"
        Me.BtnGuardarEmpleado.UseVisualStyleBackColor = True
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(503, 485)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(224, 22)
        Me.TxtIdEmpleado.TabIndex = 4
        Me.TxtIdEmpleado.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(406, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Usuario:"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(406, 159)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(103, 22)
        Me.TextBox2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password:"
        '
        'FrmCatalogoEmpleado
        '
        Me.ClientSize = New System.Drawing.Size(747, 536)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Controls.Add(Me.BtnGuardarEmpleado)
        Me.Controls.Add(Me.BtnNuevoEmpleado)
        Me.Controls.Add(Me.GbBusquedaEmpleado)
        Me.Controls.Add(Me.GbEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCatalogoEmpleado"
        Me.Text = "Catalogo de Empleado"
        Me.GbEmpleado.ResumeLayout(False)
        Me.GbEmpleado.PerformLayout()
        Me.GbBusquedaEmpleado.ResumeLayout(False)
        Me.GbBusquedaEmpleado.PerformLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GbEmpleado As GroupBox
    Friend WithEvents ChkActivoEmpleado As CheckBox
    Friend WithEvents TxtPuestoEmpleado As TextBox
    Friend WithEvents TxtCorreoEmpleado As TextBox
    Friend WithEvents LblPuesto As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents TxtApellidoMaternoEmpleado As TextBox
    Friend WithEvents TxtDomicilioEmpleado As TextBox
    Friend WithEvents LblApellidoMaterno As Label
    Friend WithEvents TxtApellidoPaternoEmpleado As TextBox
    Friend WithEvents LblApellidoPaterno As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents TxtTelefonoEmpleado As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents GbBusquedaEmpleado As GroupBox
    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents TxtBusquedaEmpleado As TextBox
    Friend WithEvents LblFiltroEmpleado As Label
    Friend WithEvents BtnNuevoEmpleado As Button
    Friend WithEvents BtnGuardarEmpleado As Button
    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
