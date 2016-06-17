Imports GriauleFingerprintLibrary
Public Class FrmHuellas

    Private CORE As FingerprintCore
    Private readImage As GriauleFingerprintLibrary.DataTypes.FingerprintRawImage
    Private template As GriauleFingerprintLibrary.DataTypes.FingerprintTemplate
    Private Sub FrmHuellas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CORE = New FingerprintCore
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("te la comes pinche oscar")
    End Sub
End Class