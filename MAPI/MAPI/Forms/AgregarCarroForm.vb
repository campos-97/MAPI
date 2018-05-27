Public Class AgregarCarroForm
    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        CarrosForm.Show()
    End Sub

    Private Sub AgregarCarroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CheckData() Then
            DBMngr.Instance.insertInDB("INTO tblCar (Plate,VIN,Descripcion,Tipo,Modelo,Año,IdOwner) VALUES ('" &
                                       PlateTextBox.Text & "', '" & VINTextBox.Text & "', '" & DescriptionTextBox.Text & "', '" & TipoTextBox.Text & "', '" &
                                       ModeloTextBox.Text & "', '" & YearInput.Value.ToString & "', " & ClientIdTextBox.Text & ");")
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