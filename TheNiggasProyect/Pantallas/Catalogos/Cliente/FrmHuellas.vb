Imports GriauleFingerprintLibrary
Public Class FrmHuellas

    Private CORE As FingerprintCore
    Private readImage As GriauleFingerprintLibrary.DataTypes.FingerprintRawImage
    Private template As GriauleFingerprintLibrary.DataTypes.FingerprintTemplate
    Private Sub FrmHuellas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CORE = New FingerprintCore
    End Sub
End Class