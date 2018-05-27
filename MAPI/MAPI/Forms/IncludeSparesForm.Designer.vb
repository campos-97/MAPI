<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncludeSparesForm
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.QuantTextBox = New System.Windows.Forms.TextBox()
        Me.RepsTextBox = New System.Windows.Forms.TextBox()
        Me.btnAgregarRep = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RepCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(282, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Cantidad"
        '
        'QuantTextBox
        '
        Me.QuantTextBox.Location = New System.Drawing.Point(357, 137)
        Me.QuantTextBox.Name = "QuantTextBox"
        Me.QuantTextBox.Size = New System.Drawing.Size(161, 22)
        Me.QuantTextBox.TabIndex = 29
        '
        'RepsTextBox
        '
        Me.RepsTextBox.Location = New System.Drawing.Point(285, 210)
        Me.RepsTextBox.Multiline = True
        Me.RepsTextBox.Name = "RepsTextBox"
        Me.RepsTextBox.ReadOnly = True
        Me.RepsTextBox.Size = New System.Drawing.Size(233, 167)
        Me.RepsTextBox.TabIndex = 28
        '
        'btnAgregarRep
        '
        Me.btnAgregarRep.Location = New System.Drawing.Point(285, 165)
        Me.btnAgregarRep.Name = "btnAgregarRep"
        Me.btnAgregarRep.Size = New System.Drawing.Size(233, 39)
        Me.btnAgregarRep.TabIndex = 27
        Me.btnAgregarRep.Text = "Agregar"
        Me.btnAgregarRep.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(282, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Codigo"
        '
        'RepCodeTextBox
        '
        Me.RepCodeTextBox.Location = New System.Drawing.Point(357, 104)
        Me.RepCodeTextBox.Name = "RepCodeTextBox"
        Me.RepCodeTextBox.Size = New System.Drawing.Size(161, 22)
        Me.RepCodeTextBox.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(336, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "RepuestosUsados"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 54)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Listo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IncludeSparesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.QuantTextBox)
        Me.Controls.Add(Me.RepsTextBox)
        Me.Controls.Add(Me.btnAgregarRep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RepCodeTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Name = "IncludeSparesForm"
        Me.Text = "IncludeSparesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents QuantTextBox As TextBox
    Friend WithEvents RepsTextBox As TextBox
    Friend WithEvents btnAgregarRep As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents RepCodeTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
