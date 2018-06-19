Public Class BuscarCarroForm
    Private Sub BuscarCarroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim comboOptions As New List(Of String)
        comboOptions.Add("VIN")
        comboOptions.Add("Plate")
        ComboBox1.DataSource = comboOptions
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        clearForm()
        CarrosForm.Show()
    End Sub

    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles BtnHistorial.Click
        Me.Hide()
        If PlateTextBox.Text IsNot "" Then
            HistorialForm.Plate = PlateTextBox.Text
            HistorialForm.Show()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TextBox1.Text IsNot "" Then
            Dim selection = DBMngr.Instance.selectFromDB("* FROM tblCar WHERE " & ComboBox1.SelectedValue.ToString &
                                            " = '" & TextBox1.Text & "'")
            Try
                PlateTextBox.Text = selection.Item(0)
                VINTextBox.Text = selection.Item(1)
                DescriptionTextBox.Text = selection.Item(2)
                TipoTextBox.Text = selection.Item(3)
                ModeloTextBox.Text = selection.Item(4)
                AñoTextBox.Text = selection.Item(5)
                OwnerIdTextBox.Text = selection.Item(6)
            Catch ex As Exception
                MessageBox.Show("Error encontrando el elemento.", "Oops!")
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If VINTextBox.Text IsNot "" Then
            DBMngr.Instance.deleteFromDB("FROM tblCar WHERE VIN='" & VINTextBox.Text & "';")
            clearForm()
        End If
    End Sub

    Private Sub clearForm()
        For Each child As Control In Me.Controls
            If (TypeOf child Is TextBox) Then
                child.ResetText()
            End If
        Next
    End Sub
End Class