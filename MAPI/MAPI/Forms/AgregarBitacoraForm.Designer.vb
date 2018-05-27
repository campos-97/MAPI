<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarBitacoraForm
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
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.InicioFecha = New System.Windows.Forms.DateTimePicker()
        Me.FinalFecha = New System.Windows.Forms.DateTimePicker()
        Me.GarantiaFecha = New System.Windows.Forms.DateTimePicker()
        Me.GarantiaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TipoServTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CodeBinnTextBox = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.Location = New System.Drawing.Point(265, 100)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.ReadOnly = True
        Me.PlacaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PlacaTextBox.TabIndex = 0
        '
        'InicioFecha
        '
        Me.InicioFecha.Location = New System.Drawing.Point(265, 145)
        Me.InicioFecha.Name = "InicioFecha"
        Me.InicioFecha.Size = New System.Drawing.Size(200, 22)
        Me.InicioFecha.TabIndex = 1
        '
        'FinalFecha
        '
        Me.FinalFecha.Location = New System.Drawing.Point(265, 189)
        Me.FinalFecha.Name = "FinalFecha"
        Me.FinalFecha.Size = New System.Drawing.Size(200, 22)
        Me.FinalFecha.TabIndex = 2
        '
        'GarantiaFecha
        '
        Me.GarantiaFecha.Location = New System.Drawing.Point(265, 234)
        Me.GarantiaFecha.Name = "GarantiaFecha"
        Me.GarantiaFecha.Size = New System.Drawing.Size(200, 22)
        Me.GarantiaFecha.TabIndex = 3
        '
        'GarantiaTextBox
        '
        Me.GarantiaTextBox.Location = New System.Drawing.Point(265, 277)
        Me.GarantiaTextBox.Name = "GarantiaTextBox"
        Me.GarantiaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.GarantiaTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "VehiculoPlaca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FechaDeInicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "FechaDeFinalización"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "FechaDeGarantía"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TipoDeGarantía"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TipoDeServicio"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(659, 372)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 39)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TipoServTextBox
        '
        Me.TipoServTextBox.Location = New System.Drawing.Point(265, 318)
        Me.TipoServTextBox.Name = "TipoServTextBox"
        Me.TipoServTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TipoServTextBox.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Codigo"
        '
        'CodeBinnTextBox
        '
        Me.CodeBinnTextBox.Location = New System.Drawing.Point(265, 67)
        Me.CodeBinnTextBox.Name = "CodeBinnTextBox"
        Me.CodeBinnTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CodeBinnTextBox.TabIndex = 24
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(524, 372)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 39)
        Me.BtnGuardar.TabIndex = 16
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'AgregarBitacoraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CodeBinnTextBox)
        Me.Controls.Add(Me.TipoServTextBox)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GarantiaTextBox)
        Me.Controls.Add(Me.GarantiaFecha)
        Me.Controls.Add(Me.FinalFecha)
        Me.Controls.Add(Me.InicioFecha)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Name = "AgregarBitacoraForm"
        Me.Text = "AgregarBitacoraForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlacaTextBox As TextBox
    Friend WithEvents InicioFecha As DateTimePicker
    Friend WithEvents FinalFecha As DateTimePicker
    Friend WithEvents GarantiaFecha As DateTimePicker
    Friend WithEvents GarantiaTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents TipoServTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CodeBinnTextBox As TextBox
    Friend WithEvents BtnGuardar As Button
End Class
