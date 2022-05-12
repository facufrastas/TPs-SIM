Public Class Form1
    Private Sub btnCongruencialLineal_Click(sender As Object, e As EventArgs) Handles btnCongruencialLineal.Click
        Dim VentanaDistribucionUniforme As FormUniforme = New FormUniforme()
        FormUniforme.Show()
    End Sub

    Private Sub btnCongruencialMultiplicativo_Click(sender As Object, e As EventArgs) Handles btnCongruencialMultiplicativo.Click
        Dim VentanaDistribucionExponencial As FormExponencial = New FormExponencial()
        FormExponencial.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VentanaDistribucionPoisson As FormPoisson = New FormPoisson()
        FormPoisson.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim VentanaDistribucionNormal As FormNormal = New FormNormal()
        FormNormal.Show()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Quiere cerrar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class
