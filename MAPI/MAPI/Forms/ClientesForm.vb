Public Class ClientesForm
    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Me.Hide()
        BuscarClienteForm.updateForm()
        BuscarClienteForm.Show()
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Hide()
        TalleresForm.Show()
    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        Me.Hide()
        AgregarClienteForm.Show()
    End Sub

    Private Sub ClientesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class