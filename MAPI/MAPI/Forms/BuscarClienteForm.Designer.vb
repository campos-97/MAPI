<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClienteForm
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
        Dim DirectionLabel As System.Windows.Forms.Label
        Dim CellphoneNumberLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CedTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.DirectionTextBox = New System.Windows.Forms.TextBox()
        Me.CellphoneTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnCarros = New System.Windows.Forms.Button()
        Me.btnDondeUpdate = New System.Windows.Forms.Button()
        DirectionLabel = New System.Windows.Forms.Label()
        CellphoneNumberLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DirectionLabel
        '
        DirectionLabel.AutoSize = True
        DirectionLabel.Location = New System.Drawing.Point(98, 288)
        DirectionLabel.Name = "DirectionLabel"
        DirectionLabel.Size = New System.Drawing.Size(68, 17)
        DirectionLabel.TabIndex = 24
        DirectionLabel.Text = "Direction:"
        '
        'CellphoneNumberLabel
        '
        CellphoneNumberLabel.AutoSize = True
        CellphoneNumberLabel.Location = New System.Drawing.Point(98, 249)
        CellphoneNumberLabel.Name = "CellphoneNumberLabel"
        CellphoneNumberLabel.Size = New System.Drawing.Size(129, 17)
        CellphoneNumberLabel.TabIndex = 23
        CellphoneNumberLabel.Text = "Cellphone Number:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(98, 209)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(107, 17)
        PhoneNumberLabel.TabIndex = 22
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(98, 169)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(75, 17)
        FullNameLabel.TabIndex = 21
        FullNameLabel.Text = "Full Name:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(98, 130)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 20
        IdLabel.Text = "Id:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clientes"
        '
        'CedTextBox
        '
        Me.CedTextBox.Location = New System.Drawing.Point(572, 36)
        Me.CedTextBox.Name = "CedTextBox"
        Me.CedTextBox.Size = New System.Drawing.Size(148, 22)
        Me.CedTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Buscar Cliente Por Cedula"
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(624, 64)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(96, 35)
        Me.BuscarBtn.TabIndex = 4
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'DirectionTextBox
        '
        Me.DirectionTextBox.Location = New System.Drawing.Point(257, 285)
        Me.DirectionTextBox.Name = "DirectionTextBox"
        Me.DirectionTextBox.ReadOnly = True
        Me.DirectionTextBox.Size = New System.Drawing.Size(121, 22)
        Me.DirectionTextBox.TabIndex = 29
        '
        'CellphoneTextBox
        '
        Me.CellphoneTextBox.Location = New System.Drawing.Point(257, 246)
        Me.CellphoneTextBox.Name = "CellphoneTextBox"
        Me.CellphoneTextBox.ReadOnly = True
        Me.CellphoneTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CellphoneTextBox.TabIndex = 28
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(257, 204)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(121, 22)
        Me.PhoneTextBox.TabIndex = 27
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(257, 166)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(121, 22)
        Me.NameTextBox.TabIndex = 26
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(257, 127)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(121, 22)
        Me.IdTextBox.TabIndex = 25
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(470, 137)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(250, 49)
        Me.BtnActualizar.TabIndex = 32
        Me.BtnActualizar.Text = "Actualizar Datos"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(470, 204)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(250, 49)
        Me.BtnEliminar.TabIndex = 33
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(611, 389)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(109, 49)
        Me.BtnAtras.TabIndex = 34
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnCarros
        '
        Me.BtnCarros.Location = New System.Drawing.Point(90, 331)
        Me.BtnCarros.Name = "BtnCarros"
        Me.BtnCarros.Size = New System.Drawing.Size(288, 58)
        Me.BtnCarros.TabIndex = 35
        Me.BtnCarros.Text = "Vehiculos Asociados"
        Me.BtnCarros.UseVisualStyleBackColor = True
        '
        'btnDondeUpdate
        '
        Me.btnDondeUpdate.Location = New System.Drawing.Point(470, 389)
        Me.btnDondeUpdate.Name = "btnDondeUpdate"
        Me.btnDondeUpdate.Size = New System.Drawing.Size(250, 49)
        Me.btnDondeUpdate.TabIndex = 36
        Me.btnDondeUpdate.Text = "Listo"
        Me.btnDondeUpdate.UseVisualStyleBackColor = True
        Me.btnDondeUpdate.Visible = False
        '
        'BuscarClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDondeUpdate)
        Me.Controls.Add(Me.BtnCarros)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.DirectionTextBox)
        Me.Controls.Add(Me.CellphoneTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(DirectionLabel)
        Me.Controls.Add(CellphoneNumberLabel)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CedTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "BuscarClienteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CedTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BuscarBtn As Button
    Friend WithEvents DirectionTextBox As TextBox
    Friend WithEvents CellphoneTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents BtnCarros As Button
    Friend WithEvents btnDondeUpdate As Button
End Class
