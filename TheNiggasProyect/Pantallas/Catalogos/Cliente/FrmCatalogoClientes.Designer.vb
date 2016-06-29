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
        Me.BtnGuardarCliente = New System.Windows.Forms.Button()
        Me.OfdImagenesCliente = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt_nuevo = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.PbClienteNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(53, 41)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(107, 34)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(156, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtApellidoPaterno
        '
        Me.TxtApellidoPaterno.Location = New System.Drawing.Point(107, 65)
        Me.TxtApellidoPaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        Me.TxtApellidoPaterno.Size = New System.Drawing.Size(156, 20)
        Me.TxtApellidoPaterno.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Appelido Paterno:"
        '
        'TxtApellidoMaterno
        '
        Me.TxtApellidoMaterno.Location = New System.Drawing.Point(107, 95)
        Me.TxtApellidoMaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        Me.TxtApellidoMaterno.Size = New System.Drawing.Size(156, 20)
        Me.TxtApellidoMaterno.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido Materno:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(342, 34)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(156, 20)
        Me.TxtTelefono.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telefono:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(342, 65)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(156, 20)
        Me.TxtEmail.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email:"
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(342, 95)
        Me.TxtDomicilio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(156, 20)
        Me.TxtDomicilio.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Domicilio:"
        '
        'PbClienteNuevo
        '
        Me.PbClienteNuevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PbClienteNuevo.Location = New System.Drawing.Point(565, 21)
        Me.PbClienteNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.PbClienteNuevo.Name = "PbClienteNuevo"
        Me.PbClienteNuevo.Size = New System.Drawing.Size(90, 110)
        Me.PbClienteNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbClienteNuevo.TabIndex = 13
        Me.PbClienteNuevo.TabStop = False
        '
        'BtnGuardarCliente
        '
        Me.BtnGuardarCliente.Location = New System.Drawing.Point(107, 336)
        Me.BtnGuardarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardarCliente.Name = "BtnGuardarCliente"
        Me.BtnGuardarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarCliente.TabIndex = 15
        Me.BtnGuardarCliente.Text = "Guardar"
        Me.BtnGuardarCliente.UseVisualStyleBackColor = True
        '
        'OfdImagenesCliente
        '
        Me.OfdImagenesCliente.FileName = "OfdImagenes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 29)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AllowUserToOrderColumns = True
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(14, 136)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(705, 192)
        Me.dgv1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt_nuevo
        '
        Me.bt_nuevo.Location = New System.Drawing.Point(25, 336)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.bt_nuevo.TabIndex = 19
        Me.bt_nuevo.Text = "Nuevo"
        Me.bt_nuevo.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(644, 336)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 21
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'FrmCatalogoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 363)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_nuevo)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGuardarCliente)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCatalogoClientes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo Cliente"
        CType(Me.PbClienteNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnGuardarCliente As Button
    Friend WithEvents OfdImagenesCliente As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents bt_nuevo As Button
    Private WithEvents CloseButton As Button
End Class
