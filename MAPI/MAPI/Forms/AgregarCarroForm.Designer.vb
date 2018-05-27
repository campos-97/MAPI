<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCarroForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PlateTextBox = New System.Windows.Forms.TextBox()
        Me.VINTextBox = New System.Windows.Forms.TextBox()
        Me.IdCliente = New System.Windows.Forms.Label()
        Me.ClientIdTextBox = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.YearInput = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Placa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "VIN"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Location = New System.Drawing.Point(174, 328)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(341, 22)
        Me.ModeloTextBox.TabIndex = 16
        '
        'TipoTextBox
        '
        Me.TipoTextBox.Location = New System.Drawing.Point(174, 287)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(341, 22)
        Me.TipoTextBox.TabIndex = 15
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(174, 186)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(341, 82)
        Me.DescriptionTextBox.TabIndex = 14
        '
        'PlateTextBox
        '
        Me.PlateTextBox.Location = New System.Drawing.Point(174, 144)
        Me.PlateTextBox.Name = "PlateTextBox"
        Me.PlateTextBox.Size = New System.Drawing.Size(341, 22)
        Me.PlateTextBox.TabIndex = 13
        '
        'VINTextBox
        '
        Me.VINTextBox.Location = New System.Drawing.Point(174, 103)
        Me.VINTextBox.Name = "VINTextBox"
        Me.VINTextBox.Size = New System.Drawing.Size(341, 22)
        Me.VINTextBox.TabIndex = 12
        '
        'IdCliente
        '
        Me.IdCliente.AutoSize = True
        Me.IdCliente.Location = New System.Drawing.Point(71, 62)
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.Size = New System.Drawing.Size(62, 17)
        Me.IdCliente.TabIndex = 25
        Me.IdCliente.Text = "IdCliente"
        '
        'ClientIdTextBox
        '
        Me.ClientIdTextBox.Location = New System.Drawing.Point(174, 59)
        Me.ClientIdTextBox.Name = "ClientIdTextBox"
        Me.ClientIdTextBox.Size = New System.Drawing.Size(341, 22)
        Me.ClientIdTextBox.TabIndex = 24
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(577, 382)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 38)
        Me.BtnGuardar.TabIndex = 26
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(668, 382)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(85, 38)
        Me.BtnAtras.TabIndex = 27
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'YearInput
        '
        Me.YearInput.Location = New System.Drawing.Point(174, 367)
        Me.YearInput.Name = "YearInput"
        Me.YearInput.Size = New System.Drawing.Size(200, 22)
        Me.YearInput.TabIndex = 28
        '
        'AgregarCarroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.YearInput)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.IdCliente)
        Me.Controls.Add(Me.ClientIdTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PlateTextBox)
        Me.Controls.Add(Me.VINTextBox)
        Me.Name = "AgregarCarroForm"
        Me.Text = "AgregarCarroForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PlateTextBox As TextBox
    Friend WithEvents VINTextBox As TextBox
    Friend WithEvents IdCliente As Label
    Friend WithEvents ClientIdTextBox As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents YearInput As DateTimePicker
End Class
