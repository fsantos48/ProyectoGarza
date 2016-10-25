Public Class Garza1
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Beep()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "All Files(*.*)|*.*" 'Opcional
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox3.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Garza1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
