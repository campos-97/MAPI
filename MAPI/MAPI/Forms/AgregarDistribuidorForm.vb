Public Class AgregarDistribuidorForm
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Hide()
        clearForm()
        DistribuidoresForm.Show()
    End Sub

    Private Sub AgregarDistribuidorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CheckData() Then
            DBMngr.Instance.insertInDB("INTO tblDistributor (Code,Country,PhoneNumber,BuisnessMethodology,DistributionMethodology,PhysicalDirection,Email) VALUES ('" &
                                       CodigoTextBox.Text & "', '" &
                                       PaisTextBox.Text & "', " &
                                       TelefonoTextBox.Text & ", '" &
                                       MetNegTextBox.Text & "', '" &
                                       MetDistTextBox.Text & "', '" &
                                       DireccionFisicaTextBox.Text & "','" &
                                       CorreETextBox.Text & "');")
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