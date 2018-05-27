Public Class TalleresForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ClientesForm.Show()
    End Sub

    Private Sub BtnCarros_Click(sender As Object, e As EventArgs) Handles BtnCarros.Click
        Me.Hide()
        CarrosForm.Show()
    End Sub

    Private Sub TalleresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        InventarioForm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Hide()
        DistribuidoresForm.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Hide()
        InvoiceForm.Show()
    End Sub
End Class