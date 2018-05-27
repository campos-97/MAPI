Public Class AgregarArticuloForm
    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        clearForm()
        InventarioForm.Show()
    End Sub

    Private Sub AgregarArticuloForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CheckData() Then
            DBMngr.Instance.insertInDB("INTO tblSpare (Code,Description,FabricationDate,Weight,Cost,Quantity,DistributorCode) VALUES ('" &
                                       CodigoTextBox.Text & "', '" &
                                       DescrTextBox.Text & "', '" &
                                       FechaFabricacion.Value.ToString & "', " &
                                       PesoTextBox.Text & ", " &
                                       CostoTextBox.Text & ", " &
                                       CantidadTextBox.Text & ", '" &
                                       dstrCodeTextBox.Text & "');")
            clearForm()
        Else
            MessageBox.Show("Todos los campos son obligatorios.", "Oops!")
        End If
    End Sub

    Private Function CheckData()
        For Each child As Control In Me.Controls
            If child.Text.Equals("") Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub clearForm()
        For Each child As Control In Me.Controls
            If (TypeOf child Is TextBox) Then
                child.ResetText()
            End If
        Next
    End Sub
End Class