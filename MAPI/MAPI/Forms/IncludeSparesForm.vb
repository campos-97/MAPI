Public Class IncludeSparesForm

    Public codeBinn As New String("")

    Private Sub IncludeSparesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        clearForm()
        HistorialForm.Show()
    End Sub

    Private Sub btnAgregarRep_Click_1(sender As Object, e As EventArgs) Handles btnAgregarRep.Click
        If RepCodeTextBox.Text IsNot "" And QuantTextBox.Text IsNot "" Then
            Dim selection = DBMngr.Instance.selectFromDB("* FROM tblSpare WHERE Code='" & RepCodeTextBox.Text & "'")
            Try
                Dim code = selection.Item(0)
                Dim quant = Convert.ToInt32(selection.Item(5))

                If quant - Convert.ToInt32(QuantTextBox.Text) > 0 Then
                    If codeBinn IsNot "" Then
                        DBMngr.Instance.insertInDB("INTO tblBinnacleJunction (BinnacleCode,SpareCode,Quantity) VALUES ('" &
                                       codeBinn & "', '" &
                                       RepCodeTextBox.Text & "'," &
                                       QuantTextBox.Text & ");")
                        RepsTextBox.Text += "Codigo: " & code & " " & "  Cantidad: " & QuantTextBox.Text & Environment.NewLine
                        RepCodeTextBox.Text = ""
                        QuantTextBox.Text = ""
                    Else
                        MessageBox.Show("Porfavor indique el codigo de bitacora.", "Oops!")
                    End If
                Else
                    MessageBox.Show("Error de existencia del repuesto.", "Oops!")
                End If

            Catch ex As Exception
                MessageBox.Show("Error encontrando el elemento.", "Oops!")
            End Try
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