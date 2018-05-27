<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesForm
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
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(305, 80)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(188, 57)
        Me.BuscarBtn.TabIndex = 0
        Me.BuscarBtn.Text = "Buscar Cliente"
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Location = New System.Drawing.Point(305, 172)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(188, 57)
        Me.AgregarBtn.TabIndex = 1
        Me.AgregarBtn.Text = "Agregar Cliente"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Location = New System.Drawing.Point(305, 271)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(188, 57)
        Me.CancelarBtn.TabIndex = 2
        Me.CancelarBtn.Text = "Atras"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'ClientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.AgregarBtn)
        Me.Controls.Add(Me.BuscarBtn)
        Me.Name = "ClientesForm"
        Me.Text = "ClienteForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BuscarBtn As Button
    Friend WithEvents AgregarBtn As Button
    Friend WithEvents CancelarBtn As Button
End Class
