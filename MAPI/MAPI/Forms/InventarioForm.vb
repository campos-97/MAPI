Public Class InventarioForm
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        TalleresForm.Show()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Me.Hide()
        AgregarArticuloForm.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If BuscarTextBox.Text IsNot "" Then
            Try
                Dim selection = DBMngr.Instance.selectFromDB("* FROM tblSpare WHERE Code='" & BuscarTextBox.Text & "'")

                CodigoTextBox.Text = selection.Item(0)
                DescrTextBox.Text = selection.Item(1)
                FechaFabricacion.Text = selection.Item(2)
                PesoTextBox.Text = selection.Item(3)
                CostoTextBox.Text = selection.Item(4)
                CantidadTextBox.Text = selection.Item(5)
                dstrCodeTextBox.Text = selection.Item(6)
            Catch ex As Exception
                MessageBox.Show("Error encontrando el elemento.", "Oops!")
            End Try
        End If
    End Sub
End Class