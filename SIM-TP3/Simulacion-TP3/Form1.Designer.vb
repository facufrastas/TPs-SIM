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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCongruencialMultiplicativo = New System.Windows.Forms.Button()
        Me.btnCongruencialLineal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Trabajo Práctico Nro. 3 Simulación"
        '
        'btnCongruencialMultiplicativo
        '
        Me.btnCongruencialMultiplicativo.Location = New System.Drawing.Point(11, 67)
        Me.btnCongruencialMultiplicativo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCongruencialMultiplicativo.Name = "btnCongruencialMultiplicativo"
        Me.btnCongruencialMultiplicativo.Size = New System.Drawing.Size(205, 28)
        Me.btnCongruencialMultiplicativo.TabIndex = 4
        Me.btnCongruencialMultiplicativo.Text = "Distribución Exponencial"
        Me.btnCongruencialMultiplicativo.UseVisualStyleBackColor = True
        '
        'btnCongruencialLineal
        '
        Me.btnCongruencialLineal.Location = New System.Drawing.Point(11, 35)
        Me.btnCongruencialLineal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCongruencialLineal.Name = "btnCongruencialLineal"
        Me.btnCongruencialLineal.Size = New System.Drawing.Size(205, 28)
        Me.btnCongruencialLineal.TabIndex = 3
        Me.btnCongruencialLineal.Text = "Distribución Uniforme"
        Me.btnCongruencialLineal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 99)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Distribución Poisson"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 131)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 28)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Distribución Normal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 169)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCongruencialMultiplicativo)
        Me.Controls.Add(Me.btnCongruencialLineal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCongruencialMultiplicativo As Button
    Friend WithEvents btnCongruencialLineal As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
