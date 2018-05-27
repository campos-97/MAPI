Public Class InvoiceForm
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If BuscarTextBox.Text IsNot "" Then
            Try
                Dim selection = DBMngr.Instance.selectFromDB("* FROM tblInvoice WHERE Code='" & BuscarTextBox.Text & "'")
                Dim description = DBMngr.Instance.selectFromDB("ServiceType FROM tblBinnacle WHERE Code='" & BuscarTextBox.Text & "'").Item(0)

                CodeTextBox.Text = selection.Item(0)
                ClientIdTextBox.Text = selection.Item(1)
                PlacaTextBox.Text = selection.Item(2)
                RepCostTextBox.Text = selection.Item(4)
                ManCostTextBox.Text = selection.Item(5)
                DescrTextBox.Text = description

                If selection.Item(3).Equals("True") Then
                    StateTextBox.Text = "Deuda Cancelada"
                Else
                    StateTextBox.Text = "Pendiente de pago"
                    btnPagar.Visible = True
                End If

            Catch ex As Exception
                MessageBox.Show("Error encontrando el elemento.", "Oops!")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        DBMngr.Instance.updateDB("tblInvoice SET " &
                                 "Paid= True WHERE Code='" & CodeTextBox.Text & "';")
        btnPagar.Visible = False
        StateTextBox.Text = "Deuda Cancelada"
    End Sub

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        TalleresForm.Show()
    End Sub
End Class