Public Class CarrosForm
    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Hide()
        TalleresForm.Show()
    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Me.Hide()
        BuscarCarroForm.Show()
    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Me.Hide()
        AgregarCarroForm.Show()
    End Sub

    Private Sub CarrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class