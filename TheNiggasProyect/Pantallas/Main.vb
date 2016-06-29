Public Class Principal
    Dim newFrmCatalogoClientes As New FrmCatalogoClientes
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Call New FrmCatalogoClientes() With {.MdiParent = Me, .StartPosition = 1}.Show()
    End Sub
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Gracias por Utilizar NIGGA'S GYM")
        Me.Close()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Call New FrmBusquedaCliente() With {.MdiParent = Me, .StartPosition = 1}.Show()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        Call New FrmProveedor() With {.MdiParent = Me, .StartPosition = 1}.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Call New FrmProducto() With {.MdiParent = Me, .StartPosition = 1}.Show()
    End Sub

    Private Sub OSCARPUTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OSCARPUTOToolStripMenuItem.Click
        MsgBox("oscar es bien puto")
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoToolStripMenuItem.Click

    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        Call New compras() With {.MdiParent = Me, .StartPosition = 1}.Show()
    End Sub

    Private Sub CatálogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogoToolStripMenuItem.Click
        Call New consultaCompra() With {.MdiParent = Me, .StartPosition = 1}.Show()
    End Sub
End Class