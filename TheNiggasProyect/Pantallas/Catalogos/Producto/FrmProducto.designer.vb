﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
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
        Me.bt_nuevo = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.bt_grabar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtminimo = New System.Windows.Forms.TextBox()
        Me.txtmaximo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtunidad = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusquedaProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_nuevo
        '
        Me.bt_nuevo.Location = New System.Drawing.Point(16, 442)
        Me.bt_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(100, 28)
        Me.bt_nuevo.TabIndex = 0
        Me.bt_nuevo.Text = "Nuevo"
        Me.bt_nuevo.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AllowUserToOrderColumns = True
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(16, 190)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(877, 236)
        Me.dgv1.TabIndex = 1
        '
        'txtclave
        '
        Me.txtclave.Enabled = False
        Me.txtclave.Location = New System.Drawing.Point(662, 445)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(231, 22)
        Me.txtclave.TabIndex = 5
        Me.txtclave.Visible = False
        '
        'bt_grabar
        '
        Me.bt_grabar.Enabled = False
        Me.bt_grabar.Location = New System.Drawing.Point(124, 442)
        Me.bt_grabar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_grabar.Name = "bt_grabar"
        Me.bt_grabar.Size = New System.Drawing.Size(100, 28)
        Me.bt_grabar.TabIndex = 10
        Me.bt_grabar.Text = "Grabar"
        Me.bt_grabar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 442)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 26)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBusquedaProducto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtunidad)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(877, 171)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'txtminimo
        '
        Me.txtminimo.Enabled = False
        Me.txtminimo.Location = New System.Drawing.Point(303, 22)
        Me.txtminimo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtminimo.Name = "txtminimo"
        Me.txtminimo.Size = New System.Drawing.Size(75, 22)
        Me.txtminimo.TabIndex = 19
        '
        'txtmaximo
        '
        Me.txtmaximo.Enabled = False
        Me.txtmaximo.Location = New System.Drawing.Point(157, 19)
        Me.txtmaximo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmaximo.Name = "txtmaximo"
        Me.txtmaximo.Size = New System.Drawing.Size(75, 22)
        Me.txtmaximo.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Maximo:"
        '
        'txtunidad
        '
        Me.txtunidad.Enabled = False
        Me.txtunidad.Location = New System.Drawing.Point(554, 27)
        Me.txtunidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunidad.Name = "txtunidad"
        Me.txtunidad.Size = New System.Drawing.Size(123, 22)
        Me.txtunidad.TabIndex = 16
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(156, 28)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(307, 22)
        Me.txtnombre.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Unidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripcion:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtminimo)
        Me.GroupBox2.Controls.Add(Me.txtmaximo)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 55)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Minimo:"
        '
        'TxtBusquedaProducto
        '
        Me.TxtBusquedaProducto.Location = New System.Drawing.Point(156, 133)
        Me.TxtBusquedaProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBusquedaProducto.Name = "TxtBusquedaProducto"
        Me.TxtBusquedaProducto.Size = New System.Drawing.Size(705, 22)
        Me.TxtBusquedaProducto.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Filtro Busqueda:"
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_grabar)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.bt_nuevo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProducto"
        Me.Text = "Productos"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_nuevo As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents txtclave As TextBox
    Friend WithEvents bt_grabar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBusquedaProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtminimo As TextBox
    Friend WithEvents txtmaximo As TextBox
    Friend WithEvents txtunidad As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
