Public Class AgregarClienteForm

    Private Sub AgregarClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Hide()
        ClientesForm.Show()
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        If CheckData() Then
            DBMngr.Instance.insertInDB("INTO tblClient (Id,FullName,PhoneNumber,CellphoneNumber,Direction) VALUES (" &
                                       IdTextBox.Text & ", '" &
                                       NameTextBox.Text & "', " &
                                       PhoneTextBox.Text & "," &
                                       CellphoneTextBox.Text & ", '" &
                                       DirectionTextBox.Text & "');")
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