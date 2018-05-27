Public Class BuscarClienteForm

    Dim dbMngr As DBMngr = DBMngr.Instance

    Private Sub BuscarClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim selection = dbMngr.selectFromDB("FullName FROM tblClient")
        ComboBox1.DataSource = selection
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CedTextBox.Text = dbMngr.selectFromDB("Id FROM tblClient WHERE FullName='" & ComboBox1.Text & "'").Item(0)
    End Sub

    Private Sub BuscarBtn_Click(sender As Object, e As EventArgs) Handles BuscarBtn.Click
        Try
            Dim selection = dbMngr.selectFromDB("* FROM tblClient WHERE FullName='" & ComboBox1.Text & "'")

            IdTextBox.Text = selection.Item(0)
            NameTextBox.Text = selection.Item(1)
            PhoneTextBox.Text = selection.Item(2)
            CellphoneTextBox.Text = selection.Item(3)
            DirectionTextBox.Text = selection.Item(4)
        Catch ex As Exception
            MessageBox.Show("Error encontrando el elemento.", "Oops!")
        End Try

    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        ClientesForm.Show()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If IdTextBox.Text IsNot "" Then
            PhoneTextBox.ReadOnly = False
            CellphoneTextBox.ReadOnly = False
            DirectionTextBox.ReadOnly = False
            BtnCarros.Visible = False
            BtnActualizar.Visible = False
            BtnAtras.Visible = False
            BtnEliminar.Visible = False
            btnDondeUpdate.Visible = True
        End If
    End Sub

    Private Sub btnDondeUpdate_Click(sender As Object, e As EventArgs) Handles btnDondeUpdate.Click
        If CheckData() Then
            DBMngr.Instance.updateDB("tblClient SET " &
                                 "PhoneNumber=" & PhoneTextBox.Text &
                                 ",CellphoneNumber=" & CellphoneTextBox.Text &
                                 ",Direction='" & DirectionTextBox.Text &
                                 "' WHERE Id=" & IdTextBox.Text & ";")
        End If

        PhoneTextBox.ReadOnly = True
        CellphoneTextBox.ReadOnly = True
        DirectionTextBox.ReadOnly = True
        BtnCarros.Visible = True
        BtnActualizar.Visible = True
        BtnAtras.Visible = True
        BtnEliminar.Visible = True
        btnDondeUpdate.Visible = False
    End Sub

    Private Function CheckData()
        If PhoneTextBox.Text.Equals("") Or
            CellphoneTextBox.Text.Equals("") Or
            DirectionTextBox.Text.Equals("") Then
            Return False
        End If
        Return True
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If IdTextBox.Text IsNot "" Then
            DBMngr.Instance.deleteFromDB("FROM tblCar WHERE IdOwner=" & IdTextBox.Text & ";")
            DBMngr.Instance.deleteFromDB("FROM tblClient WHERE Id=" & IdTextBox.Text & ";")
            Dim selection = dbMngr.selectFromDB("FullName FROM tblClient")
            ComboBox1.DataSource = selection
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