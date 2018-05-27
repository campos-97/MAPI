<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.ClientIdTextBox = New System.Windows.Forms.TextBox()
        Me.ManCostTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.RepCostTextBox = New System.Windows.Forms.TextBox()
        Me.DescrTextBox = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(198, 377)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(152, 31)
        Me.btnAtras.TabIndex = 0
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(438, 377)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(152, 31)
        Me.btnPagar.TabIndex = 1
        Me.btnPagar.Text = "SaldarCuenta"
        Me.btnPagar.UseVisualStyleBackColor = True
        Me.btnPagar.Visible = False
        '
        'CodeTextBox
        '
        Me.CodeTextBox.Location = New System.Drawing.Point(377, 93)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.ReadOnly = True
        Me.CodeTextBox.Size = New System.Drawing.Size(214, 22)
        Me.CodeTextBox.TabIndex = 2
        '
        'ClientIdTextBox
        '
        Me.ClientIdTextBox.Location = New System.Drawing.Point(376, 134)
        Me.ClientIdTextBox.Name = "ClientIdTextBox"
        Me.ClientIdTextBox.ReadOnly = True
        Me.ClientIdTextBox.Size = New System.Drawing.Size(214, 22)
        Me.ClientIdTextBox.TabIndex = 3
        '
        'ManCostTextBox
        '
        Me.ManCostTextBox.Location = New System.Drawing.Point(376, 245)
        Me.ManCostTextBox.Name = "ManCostTextBox"
        Me.ManCostTextBox.ReadOnly = True
        Me.ManCostTextBox.Size = New System.Drawing.Size(214, 22)
        Me.ManCostTextBox.TabIndex = 4
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.Location = New System.Drawing.Point(376, 174)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.ReadOnly = True
        Me.PlacaTextBox.Size = New System.Drawing.Size(214, 22)
        Me.PlacaTextBox.TabIndex = 5
        '
        'RepCostTextBox
        '
        Me.RepCostTextBox.Location = New System.Drawing.Point(376, 208)
        Me.RepCostTextBox.Name = "RepCostTextBox"
        Me.RepCostTextBox.ReadOnly = True
        Me.RepCostTextBox.Size = New System.Drawing.Size(214, 22)
        Me.RepCostTextBox.TabIndex = 6
        '
        'DescrTextBox
        '
        Me.DescrTextBox.Location = New System.Drawing.Point(377, 285)
        Me.DescrTextBox.Name = "DescrTextBox"
        Me.DescrTextBox.ReadOnly = True
        Me.DescrTextBox.Size = New System.Drawing.Size(214, 22)
        Me.DescrTextBox.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(331, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(198, 31)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BuscarTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ClienteCed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PlacaVehiculo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PrecioDeRepuestos "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PrecioManoDeObra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Servicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Estado"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(376, 323)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.ReadOnly = True
        Me.StateTextBox.Size = New System.Drawing.Size(214, 22)
        Me.StateTextBox.TabIndex = 17
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DescrTextBox)
        Me.Controls.Add(Me.RepCostTextBox)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(Me.ManCostTextBox)
        Me.Controls.Add(Me.ClientIdTextBox)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "InvoiceForm"
        Me.Text = "InvoiceForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents btnPagar As Button
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents ClientIdTextBox As TextBox
    Friend WithEvents ManCostTextBox As TextBox
    Friend WithEvents PlacaTextBox As TextBox
    Friend WithEvents RepCostTextBox As TextBox
    Friend WithEvents DescrTextBox As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StateTextBox As TextBox
End Class
