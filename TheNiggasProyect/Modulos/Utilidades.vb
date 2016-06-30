Imports System.IO

Module Utilidades
    Public huella_path As String = "C:\BPM\HUELLA.FPT"
    Public Function ArchivoABytes(ByVal pth As String) As Byte()
        Try
            Dim fs As New FileStream(pth, FileMode.Open)
            fs.Position = 0
            Dim bytes(0 To fs.Length - 1) As Byte
            fs.Read(bytes, 0, fs.Length)
            fs.Close()
            '            File.Delete(pth)
            Return bytes
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function
    Public Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
End Module
