Public Class AgregarBitacoraForm
    Private Sub AgregarBitacoraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DBMngr.Instance.deleteFromDB("FROM tblBinnacleJunction WHERE BinnacleCode='" & CodeBinnTextBox.Text & "';")
        DBMngr.Instance.deleteFromDB("FROM tblBinnacle WHERE Code='" & CodeBinnTextBox.Text & "';")
        clearForm()
        Me.Hide()
        HistorialForm.Show()
    End Sub



    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CheckData() Then
            DBMngr.Instance.insertInDB("INTO tblBinnacle (Code,StartDate,FinishDate,GuarantyDate,GuarantyType,ServiceType,Plate) VALUES ('" &
                                       CodeBinnTextBox.Text & "', '" &
                                       InicioFecha.Value.ToString & "', '" &
                                       FinalFecha.Value.ToString & "','" &
                                       GarantiaFecha.Value.ToString & "', '" &
                                       GarantiaTextBox.Text & "', '" &
                                       TipoServTextBox.Text & "', '" &
                                       PlacaTextBox.Text & "');")
            clearForm()
            Me.Hide()
            HistorialForm.updateForm()
            HistorialForm.Show()
        Else
            MessageBox.Show("Todos los campos son obligatorios.", "Oops!")
        End If
    End Sub

    Private Function CheckData()
        For Each child As Control In Me.Controls
            If child.Text.Equals("") And
                child.Name IsNot "RepCodeTextBox" And
                child.Name IsNot "QuantTextBox" And
                child.Name IsNot "RepsTextBox" Then
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