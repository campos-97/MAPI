<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarrosForm
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
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(306, 292)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(188, 57)
        Me.CancelarBtn.TabIndex = 5
        Me.CancelarBtn.Text = "Atras"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Location = New System.Drawing.Point(306, 193)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(188, 57)
        Me.AgregarBtn.TabIndex = 4
        Me.AgregarBtn.Text = "Agregar Carro"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(306, 101)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(188, 57)
        Me.BuscarBtn.TabIndex = 3
        Me.BuscarBtn.Text = "Buscar Carro"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'CarrosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.AgregarBtn)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Name = "CarrosForm"
        Me.Text = "CarrosForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CancelarBtn As Button
    Friend WithEvents AgregarBtn As Button
    Friend WithEvents BuscarBtn As Button
End Class
