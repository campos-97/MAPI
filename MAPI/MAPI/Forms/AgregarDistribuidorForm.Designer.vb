<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarDistribuidorForm
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
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionFisicaTextBox = New System.Windows.Forms.TextBox()
        Me.CorreETextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.MetDistTextBox = New System.Windows.Forms.TextBox()
        Me.MetNegTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Location = New System.Drawing.Point(263, 72)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(169, 22)
        Me.CodigoTextBox.TabIndex = 0
        '
        'PaisTextBox
        '
        Me.PaisTextBox.Location = New System.Drawing.Point(263, 112)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(169, 22)
        Me.PaisTextBox.TabIndex = 1
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(263, 150)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(169, 22)
        Me.TelefonoTextBox.TabIndex = 2
        '
        'DireccionFisicaTextBox
        '
        Me.DireccionFisicaTextBox.Location = New System.Drawing.Point(263, 273)
        Me.DireccionFisicaTextBox.Multiline = True
        Me.DireccionFisicaTextBox.Name = "DireccionFisicaTextBox"
        Me.DireccionFisicaTextBox.Size = New System.Drawing.Size(465, 53)
        Me.DireccionFisicaTextBox.TabIndex = 5
        '
        'CorreETextBox
        '
        Me.CorreETextBox.Location = New System.Drawing.Point(263, 332)
        Me.CorreETextBox.Name = "CorreETextBox"
        Me.CorreETextBox.Size = New System.Drawing.Size(465, 22)
        Me.CorreETextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Metodo De Negocio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Dirección Física"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Metodo De Entrega"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Correo Electrónico"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(477, 387)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(121, 42)
        Me.BtnGuardar.TabIndex = 14
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(631, 387)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(121, 42)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'MetDistTextBox
        '
        Me.MetDistTextBox.Location = New System.Drawing.Point(263, 231)
        Me.MetDistTextBox.Name = "MetDistTextBox"
        Me.MetDistTextBox.Size = New System.Drawing.Size(169, 22)
        Me.MetDistTextBox.TabIndex = 16
        '
        'MetNegTextBox
        '
        Me.MetNegTextBox.Location = New System.Drawing.Point(263, 190)
        Me.MetNegTextBox.Name = "MetNegTextBox"
        Me.MetNegTextBox.Size = New System.Drawing.Size(169, 22)
        Me.MetNegTextBox.TabIndex = 17
        '
        'AgregarDistribuidorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MetNegTextBox)
        Me.Controls.Add(Me.MetDistTextBox)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CorreETextBox)
        Me.Controls.Add(Me.DireccionFisicaTextBox)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Name = "AgregarDistribuidorForm"
        Me.Text = "AgregarDistribuidorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DireccionFisicaTextBox As TextBox
    Friend WithEvents CorreETextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents MetDistTextBox As TextBox
    Friend WithEvents MetNegTextBox As TextBox
End Class
