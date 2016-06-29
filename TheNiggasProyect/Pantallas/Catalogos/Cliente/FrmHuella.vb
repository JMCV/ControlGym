Public Class FrmHuella
    Implements DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Public ID As Integer
    Public Event OnTemplate(ByVal template)
    Private Enroller As DPFP.Processing.Enrollment
    Delegate Sub FunctionCall(ByVal param)



    Protected Sub Process(ByVal Sample As DPFP.Sample)
        'Process(Sample)

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then
            Try
                'SetStatus("The fingerprint feature set was created.")
                Enroller.AddFeatures(features)              ' Add feature set to template.
            Finally
                UpdateStatus()

                ' Check if template has been created.
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready        ' Report success and stop capturing
                        RaiseEvent OnTemplate(Enroller.Template)
                        SetText("Click Close, and then click Fingerprint Verification.")
                        Botton(True)
                        ' Write template into the file stream
                        StopCapture()
                    Case DPFP.Processing.Enrollment.Status.Failed       ' Report failure and restart capturing
                        Enroller.Clear()
                        StopCapture()
                        RaiseEvent OnTemplate(Nothing)
                        StartCapture()

                End Select
            End Try
        End If
    End Sub

    Protected Sub UpdateStatus()
        ' Show number of samples needed.
        SetText(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded))
    End Sub

    Private Sub FrmHuella_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        Me.ID = 0
        StartCapture()
        Enroller = New DPFP.Processing.Enrollment()         ' Create an enrollment.
        UpdateStatus()
    End Sub


    Protected Overridable Sub Init()
        Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.
        Capturer.EventHandler = Me                              ' Subscribe for capturing events.
    End Sub

    Protected Sub Process_ima(ByVal Sample As DPFP.Sample)
        Picture.Image = ConvertSampleToBitmap(Sample)
    End Sub

    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing                          ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)              ' TODO: return bitmap as a result
        Return bitmap
    End Function

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

    Protected Sub StartCapture()
        Capturer.StartCapture()
        'SetStatus("Using the fingerprint reader, scan your fingerprint.")
    End Sub

    Protected Sub StopCapture()
        Capturer.StopCapture()
    End Sub

    Private Sub CaptureForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        StopCapture()
    End Sub

    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        'SetStatus("The fingerprint sample was captured.")
        SetText("Scan the same fingerprint again.")
        Process_ima(Sample)
        Process(Sample)
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

    Protected Sub SetStatus(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.StatusText.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetStatus)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.StatusText.AppendText([text] & vbCrLf & ID)
        End If
        'StatusLine.Text = status
        'Invoke(New FunctionCall(AddressOf _SetStatus), status)
    End Sub
    Private Sub SetText(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.Prompt.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.Prompt.Text = [text]
        End If
    End Sub
    Protected Sub DrawPicture(ByVal bmp)
        Picture.Image = New Bitmap(bmp, Picture.Size)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Picture.Image = New Bitmap(bmp, Picture.Size)
    End Sub

    Protected Sub Botton(ByVal val As String)
        Invoke(New FunctionCall(AddressOf _Botton), True)
    End Sub

    Private Sub _Botton(ByVal val As String)
        CloseButton.Visible = val
        Call CloseButton_Click(Nothing, Nothing)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.ID = 1
        Me.Close()
    End Sub

End Class