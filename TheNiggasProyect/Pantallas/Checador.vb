Imports System.IO
Public Class Checador
    Implements DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Delegate Sub FunctionCall(ByVal param)
    Private Template As DPFP.Template
    Private Verificator As DPFP.Verification.Verification
    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Capturer.StopCapture()
        Process(Sample)
        Capturer.StartCapture()
    End Sub
    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        'SetStatus("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        'SetStatus("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        'SetStatus("The fingerprint reader was connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        'SetStatus("The fingerprint reader was disconnected.")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            'MakeReport("The quality of the fingerprint sample is good.")
            'SetStatus("The quality of the fingerprint sample is good.")
        Else
            'MakeReport("The quality of the fingerprint sample is poor.")
            SetText("The quality of the fingerprint sample is poor.")
        End If
    End Sub
    Protected Sub Init()
        Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.
        Capturer.EventHandler = Me
    End Sub
    Protected Sub StartCapture()
        Capturer.StartCapture()
        'SetText("Using the fingerprint reader, scan your fingerprint.")
    End Sub

    Protected Sub StopCapture()
        Capturer.StopCapture()
    End Sub
    Protected Sub Process(ByVal Sample As DPFP.Sample)
        'MyBase.Process(Sample)
        Try
            ' Process the sample and create a feature set for the enrollment purpose.
            Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

            ' Check quality of the sample and start verification if it's good
            If Not features Is Nothing Then
                Dim conn As New Conexion()
                Dim c As Integer
                Dim str, str2 As String
                Dim huella_path As String
                Dim aBytDocumento As Byte() = Nothing
                Dim oFileStream As FileStream
                huella_path = "C:\bpm\huella_ok.fpt"
                str = "select * from cliente where huella is not null"
                conn.GetData(str)
                For c = 0 To conn.PropertyTable.Rows.Count - 1
                    'MsgBox(conn.PropertyTable.Rows(c).Item("id_cliente"))
                    aBytDocumento = conn.PropertyTable.Rows(c).Item("huella")
                    If File.Exists(huella_path) Then
                        My.Computer.FileSystem.DeleteFile(huella_path, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                    End If

                    oFileStream = New FileStream(huella_path, FileMode.CreateNew, FileAccess.Write)
                    oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
                    oFileStream.Close()

                    Using fs As IO.FileStream = IO.File.OpenRead(huella_path)
                        Dim Template2 As New DPFP.Template(fs)
                        OnTemplate(Template2)
                    End Using
                    ' Compare the feature set with our template
                    Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                    Verificator.Verify(features, Template, result)
                    UpdateStatus(result.FARAchieved)
                    If result.Verified Then
                        str2 = ""
                        str2 = conn.PropertyTable.Rows(c).Item("nombre") & " "
                        str2 += conn.PropertyTable.Rows(c).Item("apellido_paterno") & " "
                        str2 += conn.PropertyTable.Rows(c).Item("apellido_materno")
                        aBytDocumento = conn.PropertyTable.Rows(c).Item("foto")
                        SetText(str2)
                        'imagen(foto_path)
                        Dim ms As New MemoryStream(aBytDocumento)
                        PictureBox1.Image = Image.FromStream(ms)
                        Exit Sub
                    End If
                Next
                SetText("Huella no encontrada")
            End If
        Catch
        End Try
    End Sub

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()        ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function
    Protected Sub UpdateStatus(ByVal FAR As Integer)
        ' Show "False accept rate" value
        'SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR))
    End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Prompt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Prompt
        '
        Me.Prompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prompt.Location = New System.Drawing.Point(30, 278)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.ReadOnly = True
        Me.Prompt.Size = New System.Drawing.Size(522, 31)
        Me.Prompt.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(189, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(244, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Checador
        '
        Me.ClientSize = New System.Drawing.Size(581, 405)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Prompt)
        Me.Name = "Checador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Checador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        StartCapture()
        'MyBase.Text = "Fingerprint Verification"
        Verificator = New DPFP.Verification.Verification()
        UpdateStatus(0)
        Timer1.Start()
    End Sub
    Private Sub OnTemplate(ByVal template2)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template2)
    End Sub

    Private Sub _OnTemplate(ByVal template2)
        Template = template2
        'VerifyButton.Enabled = (Not template Is Nothing)
        'SaveButton.Enabled = (Not template Is Nothing)
        If Not Template Is Nothing Then
            ' MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment")
        Else
            MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment")
        End If
    End Sub
    Private Sub SetText(ByVal [text] As String)
        If Me.Prompt.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.Prompt.Text = [text]
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now
    End Sub

    Private Sub Checador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
    End Sub
End Class