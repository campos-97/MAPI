<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistorialForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RepTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CodeBinnTextBox = New System.Windows.Forms.TextBox()
        Me.TipoServTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GarantiaTextBox = New System.Windows.Forms.TextBox()
        Me.GarantiaFecha = New System.Windows.Forms.DateTimePicker()
        Me.FinalFecha = New System.Windows.Forms.DateTimePicker()
        Me.InicioFecha = New System.Windows.Forms.DateTimePicker()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.Facturado = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(105, 396)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(404, 32)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "AgregarBitacora"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(528, 375)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(200, 53)
        Me.BtnAtras.TabIndex = 2
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codigo"
        '
        'RepTextBox
        '
        Me.RepTextBox.Enabled = False
        Me.RepTextBox.Location = New System.Drawing.Point(528, 99)
        Me.RepTextBox.Multiline = True
        Me.RepTextBox.Name = "RepTextBox"
        Me.RepTextBox.ReadOnly = True
        Me.RepTextBox.Size = New System.Drawing.Size(200, 210)
        Me.RepTextBox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(552, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Repuestos Utilizados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(102, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Codigo"
        '
        'CodeBinnTextBox
        '
        Me.CodeBinnTextBox.Enabled = False
        Me.CodeBinnTextBox.Location = New System.Drawing.Point(309, 69)
        Me.CodeBinnTextBox.Name = "CodeBinnTextBox"
        Me.CodeBinnTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodeBinnTextBox.TabIndex = 38
        '
        'TipoServTextBox
        '
        Me.TipoServTextBox.Enabled = False
        Me.TipoServTextBox.Location = New System.Drawing.Point(309, 320)
        Me.TipoServTextBox.Name = "TipoServTextBox"
        Me.TipoServTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TipoServTextBox.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "TipoDeServicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "TipoDeGarantía"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "FechaDeGarantía"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "FechaDeFinalización"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "FechaDeInicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "VehiculoPlaca"
        '
        'GarantiaTextBox
        '
        Me.GarantiaTextBox.Enabled = False
        Me.GarantiaTextBox.Location = New System.Drawing.Point(309, 279)
        Me.GarantiaTextBox.Name = "GarantiaTextBox"
        Me.GarantiaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.GarantiaTextBox.TabIndex = 30
        '
        'GarantiaFecha
        '
        Me.GarantiaFecha.Enabled = False
        Me.GarantiaFecha.Location = New System.Drawing.Point(309, 236)
        Me.GarantiaFecha.Name = "GarantiaFecha"
        Me.GarantiaFecha.Size = New System.Drawing.Size(200, 22)
        Me.GarantiaFecha.TabIndex = 29
        '
        'FinalFecha
        '
        Me.FinalFecha.Enabled = False
        Me.FinalFecha.Location = New System.Drawing.Point(309, 191)
        Me.FinalFecha.Name = "FinalFecha"
        Me.FinalFecha.Size = New System.Drawing.Size(200, 22)
        Me.FinalFecha.TabIndex = 28
        '
        'InicioFecha
        '
        Me.InicioFecha.Enabled = False
        Me.InicioFecha.Location = New System.Drawing.Point(309, 147)
        Me.InicioFecha.Name = "InicioFecha"
        Me.InicioFecha.Size = New System.Drawing.Size(200, 22)
        Me.InicioFecha.TabIndex = 27
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.Enabled = False
        Me.PlacaTextBox.Location = New System.Drawing.Point(309, 102)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PlacaTextBox.TabIndex = 26
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(105, 348)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(404, 35)
        Me.btnFacturar.TabIndex = 40
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        Me.btnFacturar.Visible = False
        '
        'Facturado
        '
        Me.Facturado.AutoSize = True
        Me.Facturado.Location = New System.Drawing.Point(107, 357)
        Me.Facturado.Name = "Facturado"
        Me.Facturado.Size = New System.Drawing.Size(72, 17)
        Me.Facturado.TabIndex = 41
        Me.Facturado.Text = "Facturado"
        Me.Facturado.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(309, 357)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 42
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 53)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "AgregarRepuestos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HistorialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Facturado)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CodeBinnTextBox)
        Me.Controls.Add(Me.TipoServTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GarantiaTextBox)
        Me.Controls.Add(Me.GarantiaFecha)
        Me.Controls.Add(Me.FinalFecha)
        Me.Controls.Add(Me.InicioFecha)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RepTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "HistorialForm"
        Me.Text = "HistorialForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RepTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CodeBinnTextBox As TextBox
    Friend WithEvents TipoServTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GarantiaTextBox As TextBox
    Friend WithEvents GarantiaFecha As DateTimePicker
    Friend WithEvents FinalFecha As DateTimePicker
    Friend WithEvents InicioFecha As DateTimePicker
    Friend WithEvents PlacaTextBox As TextBox
    Friend WithEvents btnFacturar As Button
    Friend WithEvents Facturado As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
End Class
