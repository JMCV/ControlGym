<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogoClientes
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PbClienteNuevo = New System.Windows.Forms.PictureBox()
        Me.BtnCapturaHuellaDigital = New System.Windows.Forms.Button()
        Me.BtnGuardarCliente = New System.Windows.Forms.Button()
        Me.BtnAgregarFotoCliente = New System.Windows.Forms.Button()
        Me.OfdImagenesCliente = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PbClienteNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(72, 42)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(62, 17)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(143, 42)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(206, 22)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtApellidoPaterno
        '
        Me.TxtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidoPaterno.Location = New System.Drawing.Point(143, 80)
        Me.TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        Me.TxtApellidoPaterno.Size = New System.Drawing.Size(206, 22)
        Me.TxtApellidoPaterno.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Appelido Paterno:"
        '
        'TxtApellidoMaterno
        '
        Me.TxtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellidoMaterno.Location = New System.Drawing.Point(143, 112)
        Me.TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        Me.TxtApellidoMaterno.Size = New System.Drawing.Size(206, 22)
        Me.TxtApellidoMaterno.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido Materno:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.Location = New System.Drawing.Point(143, 150)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(206, 22)
        Me.TxtTelefono.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telefono:"
        '
        'TxtEmail
        '
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmail.Location = New System.Drawing.Point(143, 178)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(206, 22)
        Me.TxtEmail.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email:"
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDomicilio.Location = New System.Drawing.Point(143, 209)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(206, 22)
        Me.TxtDomicilio.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Domicilio:"
        '
        'PbClienteNuevo
        '
        Me.PbClienteNuevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PbClienteNuevo.Location = New System.Drawing.Point(448, 50)
        Me.PbClienteNuevo.Name = "PbClienteNuevo"
        Me.PbClienteNuevo.Size = New System.Drawing.Size(119, 134)
        Me.PbClienteNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbClienteNuevo.TabIndex = 13
        Me.PbClienteNuevo.TabStop = False
        '
        'BtnCapturaHuellaDigital
        '
        Me.BtnCapturaHuellaDigital.Location = New System.Drawing.Point(174, 254)
        Me.BtnCapturaHuellaDigital.Name = "BtnCapturaHuellaDigital"
        Me.BtnCapturaHuellaDigital.Size = New System.Drawing.Size(119, 31)
        Me.BtnCapturaHuellaDigital.TabIndex = 14
        Me.BtnCapturaHuellaDigital.Text = "Huella Digital"
        Me.BtnCapturaHuellaDigital.UseVisualStyleBackColor = True
        '
        'BtnGuardarCliente
        '
        Me.BtnGuardarCliente.Location = New System.Drawing.Point(448, 308)
        Me.BtnGuardarCliente.Name = "BtnGuardarCliente"
        Me.BtnGuardarCliente.Size = New System.Drawing.Size(119, 31)
        Me.BtnGuardarCliente.TabIndex = 15
        Me.BtnGuardarCliente.Text = "Guardar"
        Me.BtnGuardarCliente.UseVisualStyleBackColor = True
        '
        'BtnAgregarFotoCliente
        '
        Me.BtnAgregarFotoCliente.Location = New System.Drawing.Point(448, 195)
        Me.BtnAgregarFotoCliente.Name = "BtnAgregarFotoCliente"
        Me.BtnAgregarFotoCliente.Size = New System.Drawing.Size(119, 31)
        Me.BtnAgregarFotoCliente.TabIndex = 16
        Me.BtnAgregarFotoCliente.Text = "Agregar Foto"
        Me.BtnAgregarFotoCliente.UseVisualStyleBackColor = True
        '
        'OfdImagenesCliente
        '
        Me.OfdImagenesCliente.FileName = "OfdImagenes"
        '
        'FrmCatalogoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 374)
        Me.Controls.Add(Me.BtnAgregarFotoCliente)
        Me.Controls.Add(Me.BtnGuardarCliente)
        Me.Controls.Add(Me.BtnCapturaHuellaDigital)
        Me.Controls.Add(Me.PbClienteNuevo)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtApellidoMaterno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtApellidoPaterno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCatalogoClientes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo Cliente"
        CType(Me.PbClienteNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellidoPaterno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtApellidoMaterno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PbClienteNuevo As PictureBox
    Friend WithEvents BtnCapturaHuellaDigital As Button
    Friend WithEvents BtnGuardarCliente As Button
    Friend WithEvents BtnAgregarFotoCliente As Button
    Friend WithEvents OfdImagenesCliente As OpenFileDialog
End Class
