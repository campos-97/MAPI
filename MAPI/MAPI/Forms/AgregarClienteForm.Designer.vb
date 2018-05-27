<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarClienteForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim IdLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim CellphoneNumberLabel As System.Windows.Forms.Label
        Dim DirectionLabel As System.Windows.Forms.Label
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.DirectionTextBox = New System.Windows.Forms.TextBox()
        Me.CellphoneTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        CellphoneNumberLabel = New System.Windows.Forms.Label()
        DirectionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(283, 111)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(283, 150)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(75, 17)
        FullNameLabel.TabIndex = 3
        FullNameLabel.Text = "Full Name:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(283, 190)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(107, 17)
        PhoneNumberLabel.TabIndex = 5
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'CellphoneNumberLabel
        '
        CellphoneNumberLabel.AutoSize = True
        CellphoneNumberLabel.Location = New System.Drawing.Point(283, 230)
        CellphoneNumberLabel.Name = "CellphoneNumberLabel"
        CellphoneNumberLabel.Size = New System.Drawing.Size(129, 17)
        CellphoneNumberLabel.TabIndex = 7
        CellphoneNumberLabel.Text = "Cellphone Number:"
        '
        'DirectionLabel
        '
        DirectionLabel.AutoSize = True
        DirectionLabel.Location = New System.Drawing.Point(283, 269)
        DirectionLabel.Name = "DirectionLabel"
        DirectionLabel.Size = New System.Drawing.Size(68, 17)
        DirectionLabel.TabIndex = 9
        DirectionLabel.Text = "Direction:"
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Location = New System.Drawing.Point(653, 371)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(120, 54)
        Me.GuardarBtn.TabIndex = 13
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(501, 371)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(120, 54)
        Me.CancelarBtn.TabIndex = 14
        Me.CancelarBtn.Text = "Atras"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(442, 108)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdTextBox.TabIndex = 15
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(442, 147)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameTextBox.TabIndex = 16
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(442, 185)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox.TabIndex = 17
        '
        'DirectionTextBox
        '
        Me.DirectionTextBox.Location = New System.Drawing.Point(442, 266)
        Me.DirectionTextBox.Name = "DirectionTextBox"
        Me.DirectionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DirectionTextBox.TabIndex = 19
        '
        'CellphoneTextBox
        '
        Me.CellphoneTextBox.Location = New System.Drawing.Point(442, 227)
        Me.CellphoneTextBox.Name = "CellphoneTextBox"
        Me.CellphoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CellphoneTextBox.TabIndex = 18
        '
        'AgregarClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DirectionTextBox)
        Me.Controls.Add(Me.CellphoneTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(DirectionLabel)
        Me.Controls.Add(CellphoneNumberLabel)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(IdLabel)
        Me.Name = "AgregarClienteForm"
        Me.Text = "AgregarClienteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GuardarBtn As Button
    Friend WithEvents CancelarBtn As Button
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents DirectionTextBox As TextBox
    Friend WithEvents CellphoneTextBox As TextBox
End Class
