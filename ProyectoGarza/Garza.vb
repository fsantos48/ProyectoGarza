Public Class Garza1
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Beep()
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "All Files(*.*)|*.*" 'Opcional
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox3.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub


End Class
