Public Class HistorialForm

    Public Plate As New String("")

    Private Sub HistorialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ComboBox1.DataSource = DBMngr.Instance.selectFromDB("Code FROM tblBinnacle WHERE Plate='" & Plate & "'")
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        BuscarCarroForm.Show()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Me.Hide()
        AgregarBitacoraForm.PlacaTextBox.Text = Plate
        AgregarBitacoraForm.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RepTextBox.Text = ""
        Dim selection = DBMngr.Instance.selectFromDB("* FROM tblBinnacle WHERE Code='" & ComboBox1.Text & "'")
        Dim selection2 = DBMngr.Instance.selectFromDB("SpareCode,Quantity FROM tblBinnacleJunction WHERE BinnacleCode='" & ComboBox1.Text & "'")
        Try
            CodeBinnTextBox.Text = selection.Item(0)
            InicioFecha.Text = selection.Item(1)
            FinalFecha.Text = selection.Item(2)
            GarantiaFecha.Text = selection.Item(3)
            GarantiaTextBox.Text = selection.Item(4)
            TipoServTextBox.Text = selection.Item(5)
            PlacaTextBox.Text = selection.Item(6)

            If selection.Item(7).Equals("False") Then
                btnFacturar.Visible = True
                btnAgregarRep.Visible = True
            Else
                btnFacturar.Visible = False
                btnAgregarRep.Visible = False
            End If

            Try
                If selection2.Count() > 0 Then
                    Dim q As New Boolean
                    q = False
                    For i As Integer = 0 To selection2.Count() - 1 Step 1
                        If Not q Then
                            RepTextBox.Text += "Codigo: " & selection2.Item(i) & " "
                            q = True
                        Else
                            RepTextBox.Text += "Cantidad: " & selection2.Item(i) & Environment.NewLine
                            q = False
                        End If
                    Next
                End If
            Catch exc As Exception

            End Try


        Catch ex As Exception
                MessageBox.Show("Error encontrando el elemento.", "Oops!")
        End Try
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        DBMngr.Instance.updateDB("tblBinnacle SET " &
                                 "Invoiced=True WHERE Code='" & ComboBox1.Text & "';")
        Dim customerId = DBMngr.Instance.selectFromDB("IdOwner FROM tblCar WHERE Plate='" & PlacaTextBox.Text & "'").Item(0)
        DBMngr.Instance.insertInDB("INTO tblInvoice (Code,CustomerId,CarPlate,PartsCost,WorkCost) VALUES ('" &
                                       CodeBinnTextBox.Text & "', '" &
                                       customerId & "', '" &
                                       PlacaTextBox.Text & "'," &
                                       getPartsCost() & "," &
                                       getTimeCost() & ");")
        btnAgregarRep.Visible = False
        btnFacturar.Visible = False
        Facturado.Visible = True
        CheckBox1.Select()
        CheckBox1.Visible = True
    End Sub

    Private Function getPartsCost()
        Dim cost As New Decimal
        Dim selection2 = DBMngr.Instance.selectFromDB("SpareCode,Quantity FROM tblBinnacleJunction WHERE BinnacleCode='" & ComboBox1.Text & "'")
        Try
            If selection2.Count() > 0 Then
                RepTextBox.Text += ""
                Dim q As New Boolean
                q = False
                Dim pc As Decimal
                For i As Integer = 0 To selection2.Count() - 1 Step 1
                    If Not q Then
                        pc = Convert.ToDecimal(DBMngr.Instance.selectFromDB("Cost FROM tblSpare WHERE Code='" & selection2.Item(0) & "'").Item(0))
                        q = True
                    Else
                        cost = pc * Convert.ToDecimal(selection2.Item(i))
                        q = False
                    End If
                Next
            End If
        Catch exc As Exception
        End Try
        Return cost
    End Function

    Private Function getTimeCost()
        Dim duration As TimeSpan = (FinalFecha.Value - InicioFecha.Value).Duration()
        Dim hours As Int32 = CInt(duration.TotalHours)
        Return hours * 10
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarRep.Click
        Me.Hide()
        IncludeSparesForm.codeBinn = CodeBinnTextBox.Text
        IncludeSparesForm.Show()

    End Sub

    Public Sub updateForm()
        ComboBox1.DataSource = DBMngr.Instance.selectFromDB("Code FROM tblBinnacle WHERE Plate='" & Plate & "'")
    End Sub
End Class