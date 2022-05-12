Public Class Form1

    Private Sub btnCongruencialMultiplicativo_Click(sender As Object, e As EventArgs) Handles btnCongruencialMultiplicativo.Click
        Dim VentanaCongruencialMultiplicativo As FormCongruencialMultiplicativo = New FormCongruencialMultiplicativo()
        FormCongruencialMultiplicativo.Show()
    End Sub

    Private Sub btnCongruencialLineal_Click(sender As Object, e As EventArgs) Handles btnCongruencialLineal.Click
        Dim VentanaCongruencialLineal As FormCongruencialLineal = New FormCongruencialLineal()
        FormCongruencialLineal.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Quiere cerrar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

End Class
