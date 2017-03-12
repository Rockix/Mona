Class MainWindow
    Dim SAPI
    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click

        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(textBox.Text)
    End Sub

    Private Sub textBox_KeyDown(sender As Object, e As KeyEventArgs) Handles textBox.KeyDown
        If textBox.Text = "Enter text here..." Then
            textBox.Clear()
        End If
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        SAPI.Speak("Bye!")
    End Sub
End Class
