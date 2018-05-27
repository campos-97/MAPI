<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCarroForm
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
        Me.VINTextBox = New System.Windows.Forms.TextBox()
        Me.PlateTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnHistorial = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OwnerIdTextBox = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VINTextBox
        '
        Me.VINTextBox.Location = New System.Drawing.Point(211, 80)
        Me.VINTextBox.Name = "VINTextBox"
        Me.VINTextBox.ReadOnly = True
        Me.VINTextBox.Size = New System.Drawing.Size(341, 22)
        Me.VINTextBox.TabIndex = 0
        '
        'PlateTextBox
        '
        Me.PlateTextBox.Location = New System.Drawing.Point(211, 121)
        Me.PlateTextBox.Name = "PlateTextBox"
        Me.PlateTextBox.ReadOnly = True
        Me.PlateTextBox.Size = New System.Drawing.Size(341, 22)
        Me.PlateTextBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(211, 163)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(341, 67)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'AñoTextBox
        '
        Me.AñoTextBox.Location = New System.Drawing.Point(211, 332)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.ReadOnly = True
        Me.AñoTextBox.Size = New System.Drawing.Size(341, 22)
        Me.AñoTextBox.TabIndex = 5
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Location = New System.Drawing.Point(211, 290)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.ReadOnly = True
        Me.ModeloTextBox.Size = New System.Drawing.Size(341, 22)
        Me.ModeloTextBox.TabIndex = 4
        '
        'TipoTextBox
        '
        Me.TipoTextBox.Location = New System.Drawing.Point(211, 249)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.ReadOnly = True
        Me.TipoTextBox.Size = New System.Drawing.Size(341, 22)
        Me.TipoTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "VIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Placa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Modelo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Año"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(173, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(395, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 13
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(539, 37)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Buscar por"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Número"
        '
        'BtnHistorial
        '
        Me.BtnHistorial.Location = New System.Drawing.Point(211, 398)
        Me.BtnHistorial.Name = "BtnHistorial"
        Me.BtnHistorial.Size = New System.Drawing.Size(341, 37)
        Me.BtnHistorial.TabIndex = 17
        Me.BtnHistorial.Text = "Historial"
        Me.BtnHistorial.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(633, 388)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(107, 47)
        Me.BtnAtras.TabIndex = 18
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(64, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ced Dueño"
        '
        'OwnerIdTextBox
        '
        Me.OwnerIdTextBox.Location = New System.Drawing.Point(211, 370)
        Me.OwnerIdTextBox.Name = "OwnerIdTextBox"
        Me.OwnerIdTextBox.ReadOnly = True
        Me.OwnerIdTextBox.Size = New System.Drawing.Size(341, 22)
        Me.OwnerIdTextBox.TabIndex = 19
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(633, 207)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 47)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'BuscarCarroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.OwnerIdTextBox)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnHistorial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PlateTextBox)
        Me.Controls.Add(Me.VINTextBox)
        Me.Name = "BuscarCarroForm"
        Me.Text = "BuscarCarroForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VINTextBox As TextBox
    Friend WithEvents PlateTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents AñoTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnHistorial As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents OwnerIdTextBox As TextBox
    Friend WithEvents btnDelete As Button
End Class
