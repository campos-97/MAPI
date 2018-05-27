<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dstrCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Por Codigo"
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(224, 36)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(141, 22)
        Me.BuscarTextBox.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(388, 30)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(87, 34)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(495, 365)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(213, 58)
        Me.BtnAtras.TabIndex = 4
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(70, 365)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(213, 58)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Agregar Articulo"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Costo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Peso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Fecha De Fabricación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Codigo"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(275, 245)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.ReadOnly = True
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CantidadTextBox.TabIndex = 17
        '
        'CostoTextBox
        '
        Me.CostoTextBox.Location = New System.Drawing.Point(275, 207)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.ReadOnly = True
        Me.CostoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CostoTextBox.TabIndex = 16
        '
        'PesoTextBox
        '
        Me.PesoTextBox.Location = New System.Drawing.Point(275, 164)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.ReadOnly = True
        Me.PesoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PesoTextBox.TabIndex = 15
        '
        'FechaFabricacion
        '
        Me.FechaFabricacion.Enabled = False
        Me.FechaFabricacion.Location = New System.Drawing.Point(275, 124)
        Me.FechaFabricacion.Name = "FechaFabricacion"
        Me.FechaFabricacion.Size = New System.Drawing.Size(200, 22)
        Me.FechaFabricacion.TabIndex = 14
        '
        'DescrTextBox
        '
        Me.DescrTextBox.Location = New System.Drawing.Point(275, 307)
        Me.DescrTextBox.Multiline = True
        Me.DescrTextBox.Name = "DescrTextBox"
        Me.DescrTextBox.ReadOnly = True
        Me.DescrTextBox.Size = New System.Drawing.Size(327, 52)
        Me.DescrTextBox.TabIndex = 13
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Location = New System.Drawing.Point(275, 84)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodigoTextBox.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "CodigoDeDistribuidor"
        '
        'dstrCodeTextBox
        '
        Me.dstrCodeTextBox.Location = New System.Drawing.Point(275, 279)
        Me.dstrCodeTextBox.Name = "dstrCodeTextBox"
        Me.dstrCodeTextBox.ReadOnly = True
        Me.dstrCodeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.dstrCodeTextBox.TabIndex = 24
        '
        'InventarioForm
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
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InventarioForm"
        Me.Text = "Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents BtnAgregar As Button
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
    Friend WithEvents Label8 As Label
    Friend WithEvents dstrCodeTextBox As TextBox
End Class
