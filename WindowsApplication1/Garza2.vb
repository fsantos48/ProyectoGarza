Public Class Garza2
    Private Sub Garza2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New Form

        With Form2
            .BackColor = Color.Coral
            .Text = "Formulario auxiliar"
        End With

        Form2.Show()
    End Sub
End Class
