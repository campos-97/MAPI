Public Class BuscarDistribuidorForm
    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        DistribuidoresForm.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If SearchCodeTextBox.Text IsNot "" Then
            Try
                Dim selection = DBMngr.Instance.selectFromDB("* FROM tblDistributor WHERE Code='" & SearchCodeTextBox.Text & "'")

                CodigoTextBox.Text = selection.Item(0)
                PaisTextBox.Text = selection.Item(1)
                TelefonoTextBox.Text = selection.Item(2)
                NegocioTextBox.Text = selection.Item(3)
                EntregaTextBox.Text = selection.Item(4)
                DireccionFisicaTextBox.Text = selection.Item(5)
                CorreETextBox.Text = selection.Item(6)
            Catch ex As Exception
                MessageBox.Show("Error encontrando el elemento.", "Oops!")
            End Try
        End If
    End Sub

    Private Sub BuscarDistribuidorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If CodigoTextBox.Text IsNot "" Then
            DBMngr.Instance.deleteFromDB("FROM tblDistributor WHERE Code='" & CodigoTextBox.Text & "';")
            clearForm()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        PaisTextBox.ReadOnly = False
        TelefonoTextBox.ReadOnly = False
        NegocioTextBox.ReadOnly = False
        EntregaTextBox.ReadOnly = False
        DireccionFisicaTextBox.ReadOnly = False
        CorreETextBox.ReadOnly = False
        btnListoUpdate.Visible = True
        BtnEditar.Visible = False
        btnEliminar.Visible = False
        BtnAtras.Visible = False
    End Sub

    Private Sub clearForm()
        For Each child As Control In Me.Controls
            If (TypeOf child Is TextBox) Then
                child.ResetText()
            End If
        Next
    End Sub

    Private Function CheckData()
        For Each child As Control In Me.Controls
            If child.Text.Equals("") Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnListoUpdate_Click(sender As Object, e As EventArgs) Handles btnListoUpdate.Click
        If CheckData() Then
            DBMngr.Instance.updateDB("tblDistributor SET " &
                                 "Country='" & PaisTextBox.Text &
                                 "',PhoneNumber=" & TelefonoTextBox.Text &
                                 ",BuisnessMethodology='" & NegocioTextBox.Text &
                                 "',DistributionMethodology='" & EntregaTextBox.Text &
                                 "',PhysicalDirection='" & DireccionFisicaTextBox.Text &
                                 "',Email='" & CorreETextBox.Text &
                                 "' WHERE Code='" & CodigoTextBox.Text & "';")
        End If

        PaisTextBox.ReadOnly = True
        TelefonoTextBox.ReadOnly = True
        NegocioTextBox.ReadOnly = True
        EntregaTextBox.ReadOnly = True
        DireccionFisicaTextBox.ReadOnly = True
        CorreETextBox.ReadOnly = True
        btnListoUpdate.Visible = False
        BtnEditar.Visible = True
        btnEliminar.Visible = True
        BtnAtras.Visible = True
    End Sub
End Class