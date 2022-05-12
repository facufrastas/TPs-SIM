<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCongruencialLineal = New System.Windows.Forms.Button()
        Me.btnCongruencialMultiplicativo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCongruencialLineal
        '
        Me.btnCongruencialLineal.Location = New System.Drawing.Point(11, 37)
        Me.btnCongruencialLineal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCongruencialLineal.Name = "btnCongruencialLineal"
        Me.btnCongruencialLineal.Size = New System.Drawing.Size(205, 28)
        Me.btnCongruencialLineal.TabIndex = 0
        Me.btnCongruencialLineal.Text = "Método Congruencial Lineal"
        Me.btnCongruencialLineal.UseVisualStyleBackColor = True
        '
        'btnCongruencialMultiplicativo
        '
        Me.btnCongruencialMultiplicativo.Location = New System.Drawing.Point(11, 69)
        Me.btnCongruencialMultiplicativo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCongruencialMultiplicativo.Name = "btnCongruencialMultiplicativo"
        Me.btnCongruencialMultiplicativo.Size = New System.Drawing.Size(205, 28)
        Me.btnCongruencialMultiplicativo.TabIndex = 1
        Me.btnCongruencialMultiplicativo.Text = "Método Congruencial Multiplicativo"
        Me.btnCongruencialMultiplicativo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Trabajo Práctico Nro. 1 Simulación"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 113)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCongruencialMultiplicativo)
        Me.Controls.Add(Me.btnCongruencialLineal)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCongruencialLineal As Button
    Friend WithEvents btnCongruencialMultiplicativo As Button
    Friend WithEvents Label1 As Label
End Class
