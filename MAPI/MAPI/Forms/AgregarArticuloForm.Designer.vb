<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarArticuloForm
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dstrCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaFabricacion = New System.Windows.Forms.DateTimePicker()
        Me.DescrTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(457, 376)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(132, 56)
        Me.BtnGuardar.TabIndex = 12
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(616, 376)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(132, 56)
        Me.BtnAtras.TabIndex = 13
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(140, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "CodigoDeDistribuidor"
        '
        'dstrCodeTextBox
        '
        Me.dstrCodeTextBox.Location = New System.Drawing.Point(338, 259)
        Me.dstrCodeTextBox.Name = "dstrCodeTextBox"
        Me.dstrCodeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.dstrCodeTextBox.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Costo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Peso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha De Fabricación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Codigo"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(338, 225)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CantidadTextBox.TabIndex = 31
        '
        'CostoTextBox
        '
        Me.CostoTextBox.Location = New System.Drawing.Point(338, 187)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CostoTextBox.TabIndex = 30
        '
        'PesoTextBox
        '
        Me.PesoTextBox.Location = New System.Drawing.Point(338, 144)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PesoTextBox.TabIndex = 29
        '
        'FechaFabricacion
        '
        Me.FechaFabricacion.Location = New System.Drawing.Point(338, 104)
        Me.FechaFabricacion.Name = "FechaFabricacion"
        Me.FechaFabricacion.Size = New System.Drawing.Size(200, 22)
        Me.FechaFabricacion.TabIndex = 28
        '
        'DescrTextBox
        '
        Me.DescrTextBox.Location = New System.Drawing.Point(338, 287)
        Me.DescrTextBox.Multiline = True
        Me.DescrTextBox.Name = "DescrTextBox"
        Me.DescrTextBox.Size = New System.Drawing.Size(327, 52)
        Me.DescrTextBox.TabIndex = 27
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Location = New System.Drawing.Point(338, 64)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodigoTextBox.TabIndex = 26
        '
        'AgregarArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dstrCodeTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(Me.FechaFabricacion)
        Me.Controls.Add(Me.DescrTextBox)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "AgregarArticuloForm"
        Me.Text = "AgregarArticuloForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dstrCodeTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents CostoTextBox As TextBox
    Friend WithEvents PesoTextBox As TextBox
    Friend WithEvents FechaFabricacion As DateTimePicker
    Friend WithEvents DescrTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
End Class
