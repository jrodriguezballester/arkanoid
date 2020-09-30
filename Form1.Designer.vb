<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fjuego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Nave = New System.Windows.Forms.Button()
        Me.Bola = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Nave
        '
        Me.Nave.Location = New System.Drawing.Point(383, 418)
        Me.Nave.Name = "Nave"
        Me.Nave.Size = New System.Drawing.Size(80, 25)
        Me.Nave.TabIndex = 0
        Me.Nave.Text = "-----"
        Me.Nave.UseVisualStyleBackColor = True
        '
        'Bola
        '
        Me.Bola.AutoSize = True
        Me.Bola.Checked = True
        Me.Bola.Location = New System.Drawing.Point(153, 190)
        Me.Bola.Name = "Bola"
        Me.Bola.Size = New System.Drawing.Size(17, 16)
        Me.Bola.TabIndex = 1
        Me.Bola.TabStop = True
        Me.Bola.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Fjuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 453)
        Me.Controls.Add(Me.Bola)
        Me.Controls.Add(Me.Nave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fjuego"
        Me.Text = "Arkanoid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nave As Button
    Friend WithEvents Bola As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
