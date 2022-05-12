Public Class FormCongruencialMultiplicativo
    Private this As Object

    Private Sub FormCongruencialMultiplicativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        txtN.Text = "20"
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If IsNumeric(txtXo.Text) And IsNumeric(txtA.Text) And IsNumeric(txtM.Text) Then
            If txtXo.Text > 0 And txtA.Text > 0 And txtM.Text > 0 Then
                If (txtXo.Text) Mod 2 > 0 Then
                    dgvResultados.Rows.Clear()
                    generar()
                Else
                    MessageBox.Show("La raíz Xo debe ser impar.")
                End If
            Else
                MessageBox.Show("Los valores deben ser positivos.")
            End If
        Else
            MessageBox.Show("Valores No Válidos.")
        End If
    End Sub

    Private Sub generar()
        Dim x0 As New Integer
        x0 = CInt(txtXo.Text)
        Dim k As New Integer
        k = CInt(txtK.Text)
        Dim g As New Integer
        g = CInt(txtG.Text)
        Dim a As New Integer
        a = CInt(txtA.Text)
        Dim m As New Integer
        m = CInt(txtM.Text)
        Dim n As New Integer
        n = CInt(txtN.Text)
        Dim xi As New Integer
        xi = x0
        Dim xs As New Integer
        xs = x0
        Dim Random As New Random()
        Dim numero As New Double

        'For i = 1 To n
        '    numero = Random.Next(0, 9999)
        '    numero = numero / 10000
        '    Me.dgvNumeros.Rows.Add(i, numero)
        'Next

        dgvResultados.Columns(3).DefaultCellStyle.Format = "N4  "

        For i = 1 To n Step 2
            xs = (a * xi) Mod m

            Dim rndi1 As Double = (xs) / (m - 1)
            Dim rndi2 As Double = (xi) / (m - 1)

            Dim rndi1s As String = rndi1.ToString + ",0000"
            Dim rndi2s As String = rndi2.ToString + ",0000"

            Dim rand1 As Double = Trim(Microsoft.VisualBasic.Left(rndi1s, 4))
            Dim rand2 As Double = Trim(Microsoft.VisualBasic.Left(rndi2s, 4))

            Me.dgvNumeros.Rows.Add(i, rand1)
            Me.dgvNumeros.Rows.Add(i + 1, rand2)
            'Me.dgvResultados.Rows.Add(i, a * xi, xs, Trim(Microsoft.VisualBasic.Left(rndi1s, 6)), Trim(Microsoft.VisualBasic.Left(rndi2s, 6)))
            xi = xs
        Next

        xi = x0
        xs = x0
        For Each Fila As DataGridViewRow In dgvNumeros.Rows
            xs = (a * xi) Mod m
            Me.dgvResultados.Rows.Add(Fila.Cells(0).Value, a * xi, xs, xs / (m - 1))
            xi = xs
        Next
    End Sub

    Private Sub txtG_TextChanged(sender As Object, e As EventArgs) Handles txtG.TextChanged
        If txtG.Text <> "" Then
            txtM.Text = (2 ^ CInt(txtG.Text)).ToString()
        End If
    End Sub

    Private Sub txtK_TextChanged(sender As Object, e As EventArgs) Handles txtK.TextChanged
        If txtK.Text <> "" Then
            txtA.Text = (3 + 8 * (CInt(txtK.Text))).ToString()
        End If
    End Sub

    Private Sub FormCongruencialLineal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Quiere cerrar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub limpiar()
        txtXo.Text = ""
        txtA.Text = ""
        txtM.Text = ""
        txtK.Text = ""
        txtG.Text = ""
        cmbIntervalos.SelectedIndex = -1

        dgvResultados.Rows.Clear()
        dgvFrecuencias.Rows.Clear()

        For Each series In histograma.Series
            series.Points.Clear()
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If IsNumeric(txtXo.Text) And IsNumeric(txtA.Text) And IsNumeric(txtM.Text) Then
            If txtXo.Text > 0 And txtA.Text > 0 And txtM.Text > 0 Then
                generarSiguiente()
            Else
                MessageBox.Show("Los valores deben ser positivos.")
            End If
        Else
            MessageBox.Show("Valores No válidos.")
        End If
    End Sub

    Private Sub generarSiguiente()
        Dim i As Integer = dgvResultados.Rows.Count
        Dim xi, xs, a, c, m As Integer

        a = CInt(txtA.Text)
        m = CInt(txtM.Text)

        xi = Me.dgvResultados.Rows(i - 1).Cells(2).Value

        xs = (a * xi + c) Mod m
        Dim rndi1 As Double = (xs) / (m - 1)
        Dim rndi2 As Double = (xi) / (m - 1)

        Dim rndi1s As String = rndi1.ToString + ",0000"
        Dim rndi2s As String = rndi2.ToString + ",0000"

        Me.dgvResultados.Rows.Add(i + 1, a * xi + c, xs, Trim(Microsoft.VisualBasic.Left(rndi1s, 6)), Trim(Microsoft.VisualBasic.Left(rndi2s, 6)))
        ''xi = xs
    End Sub

    Private Sub btnGrafico2_Click(sender As Object, e As EventArgs) Handles btnGrafico.Click
        For Each series In histograma.Series
            series.Points.Clear()
        Next
        histograma.Series(0).CustomProperties = "PointWidth = 1"
        histograma.ChartAreas(0).AxisY.IntervalOffset = 1
        histograma.ChartAreas(0).AxisX.Interval = 1
        ''histograma.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        ''histograma.ChartAreas(0).AxisY.MajorGrid.Enabled = False
        histograma.ChartAreas(0).AxisX.LabelStyle.Angle = -90
        histograma.BorderlineWidth = 1

        For Each Fila As DataGridViewRow In dgvFrecuencias.Rows
            histograma.Series("Frecuencia").Points.AddXY(Fila.Cells(0).Value, Fila.Cells(1).Value)
        Next
    End Sub

    Private Sub btnChi_Click(sender As Object, e As EventArgs) Handles btnChi.Click
        dgvFrecuencias.Rows.Clear()
        Dim intervalos As New Integer
        intervalos = cmbIntervalos.SelectedItem

        If cmbIntervalos.SelectedIndex <> -1 Then
            Dim n As New Integer
            n = CInt(txtN.Text)

            If intervalos = 5 Then
                Me.dgvFrecuencias.Rows.Add("0,0 - 0,2", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,2 - 0,4", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,4 - 0,6", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,6 - 0,8", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,8 - 1,0", 0, n / intervalos, 0, 0)
            End If

            If intervalos = 10 Then
                Me.dgvFrecuencias.Rows.Add("0,0 - 0,1", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,1 - 0,2", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,2 - 0,3", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,3 - 0,4", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,4 - 0,5", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,5 - 0,6", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,6 - 0,7", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,7 - 0,8", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,8 - 0,9", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,9 - 1,0", 0, n / intervalos, 0, 0)
            End If

            If intervalos = 15 Then
                Me.dgvFrecuencias.Rows.Add("0,0 - 0,0667", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,0667 - 0,1334", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,1334 - 0,2001", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,2001 - 0,2668", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,2668 - 0,3335", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,3335 - 0,4002", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,4002 - 0,4669", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,4669 - 0,5336", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,5336 - 0,6003", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,6003 - 0,667", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,667 - 0,7337", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,7337 - 0.8004", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,8004 - 0,8671", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,8671 - 0,9338", 0, n / intervalos, 0, 0)
                Me.dgvFrecuencias.Rows.Add("0,9338 - 1,0", 0, n / intervalos, 0, 0)
            End If

            For Each Fila As DataGridViewRow In dgvFrecuencias.Rows
                If intervalos = 5 Then
                    If Fila.Cells(3).Value >= 0 And Fila.Cells(3).Value < 0.2 Then
                        dgvFrecuencias.Rows(0).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.2 And Fila.Cells(3).Value < 0.4 Then
                        dgvFrecuencias.Rows(1).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.4 And Fila.Cells(3).Value < 0.6 Then
                        dgvFrecuencias.Rows(2).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.6 And Fila.Cells(3).Value < 0.8 Then
                        dgvFrecuencias.Rows(3).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.8 And Fila.Cells(3).Value <= 1 Then
                        dgvFrecuencias.Rows(4).Cells(1).Value += 1
                    End If
                End If

                If intervalos = 10 Then
                    If Fila.Cells(3).Value >= 0 And Fila.Cells(3).Value < 0.1 Then
                        dgvFrecuencias.Rows(0).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.1 And Fila.Cells(3).Value < 0.2 Then
                        dgvFrecuencias.Rows(1).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.2 And Fila.Cells(3).Value < 0.3 Then
                        dgvFrecuencias.Rows(2).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.3 And Fila.Cells(3).Value < 0.4 Then
                        dgvFrecuencias.Rows(3).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.4 And Fila.Cells(3).Value < 0.5 Then
                        dgvFrecuencias.Rows(4).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.5 And Fila.Cells(3).Value < 0.6 Then
                        dgvFrecuencias.Rows(5).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.6 And Fila.Cells(3).Value < 0.7 Then
                        dgvFrecuencias.Rows(6).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.7 And Fila.Cells(3).Value < 0.8 Then
                        dgvFrecuencias.Rows(7).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.8 And Fila.Cells(3).Value < 0.9 Then
                        dgvFrecuencias.Rows(8).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.9 And Fila.Cells(3).Value <= 1 Then
                        dgvFrecuencias.Rows(9).Cells(1).Value += 1
                    End If
                End If

                If intervalos = 15 Then
                    If Fila.Cells(3).Value >= 0 And Fila.Cells(3).Value < 0.0667 Then
                        dgvFrecuencias.Rows(0).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.0667 And Fila.Cells(3).Value < 0.1334 Then
                        dgvFrecuencias.Rows(1).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.1334 And Fila.Cells(3).Value < 0.2001 Then
                        dgvFrecuencias.Rows(2).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.2001 And Fila.Cells(3).Value < 0.2668 Then
                        dgvFrecuencias.Rows(3).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.2668 And Fila.Cells(3).Value < 0.3335 Then
                        dgvFrecuencias.Rows(4).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.3335 And Fila.Cells(3).Value < 0.4002 Then
                        dgvFrecuencias.Rows(5).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.4002 And Fila.Cells(3).Value < 0.4669 Then
                        dgvFrecuencias.Rows(6).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.4669 And Fila.Cells(3).Value < 0.5336 Then
                        dgvFrecuencias.Rows(7).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.5336 And Fila.Cells(3).Value < 0.6003 Then
                        dgvFrecuencias.Rows(8).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.6003 And Fila.Cells(3).Value <= 0.667 Then
                        dgvFrecuencias.Rows(9).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.667 And Fila.Cells(3).Value <= 0.7337 Then
                        dgvFrecuencias.Rows(9).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.7337 And Fila.Cells(3).Value <= 0.8004 Then
                        dgvFrecuencias.Rows(9).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.8004 And Fila.Cells(3).Value <= 0.8671 Then
                        dgvFrecuencias.Rows(9).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.8671 And Fila.Cells(3).Value <= 0.9338 Then
                        dgvFrecuencias.Rows(9).Cells(1).Value += 1
                    End If
                    If Fila.Cells(3).Value >= 0.9338 And Fila.Cells(3).Value <= 1 Then
                        dgvFrecuencias.Rows(9).Cells(1).Value += 1
                    End If
                End If
            Next

            If intervalos = 5 Then
                dgvFrecuencias.Rows(0).Cells(3).Value = ((dgvFrecuencias.Rows(0).Cells(1).Value - dgvFrecuencias.Rows(0).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(0).Cells(2).Value))
                dgvFrecuencias.Rows(1).Cells(3).Value = ((dgvFrecuencias.Rows(1).Cells(1).Value - dgvFrecuencias.Rows(1).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(1).Cells(2).Value))
                dgvFrecuencias.Rows(2).Cells(3).Value = ((dgvFrecuencias.Rows(2).Cells(1).Value - dgvFrecuencias.Rows(2).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(2).Cells(2).Value))
                dgvFrecuencias.Rows(3).Cells(3).Value = ((dgvFrecuencias.Rows(3).Cells(1).Value - dgvFrecuencias.Rows(3).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(3).Cells(2).Value))
                dgvFrecuencias.Rows(4).Cells(3).Value = ((dgvFrecuencias.Rows(4).Cells(1).Value - dgvFrecuencias.Rows(4).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(4).Cells(2).Value))

                dgvFrecuencias.Rows(0).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(3).Value
                dgvFrecuencias.Rows(1).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(4).Value + dgvFrecuencias.Rows(1).Cells(3).Value
                dgvFrecuencias.Rows(2).Cells(4).Value = dgvFrecuencias.Rows(1).Cells(4).Value + dgvFrecuencias.Rows(2).Cells(3).Value
                dgvFrecuencias.Rows(3).Cells(4).Value = dgvFrecuencias.Rows(2).Cells(4).Value + dgvFrecuencias.Rows(3).Cells(3).Value
                dgvFrecuencias.Rows(4).Cells(4).Value = dgvFrecuencias.Rows(3).Cells(4).Value + dgvFrecuencias.Rows(4).Cells(3).Value
            End If

            If intervalos = 10 Then
                dgvFrecuencias.Rows(0).Cells(3).Value = ((dgvFrecuencias.Rows(0).Cells(1).Value - dgvFrecuencias.Rows(0).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(0).Cells(2).Value))
                dgvFrecuencias.Rows(1).Cells(3).Value = ((dgvFrecuencias.Rows(1).Cells(1).Value - dgvFrecuencias.Rows(1).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(1).Cells(2).Value))
                dgvFrecuencias.Rows(2).Cells(3).Value = ((dgvFrecuencias.Rows(2).Cells(1).Value - dgvFrecuencias.Rows(2).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(2).Cells(2).Value))
                dgvFrecuencias.Rows(3).Cells(3).Value = ((dgvFrecuencias.Rows(3).Cells(1).Value - dgvFrecuencias.Rows(3).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(3).Cells(2).Value))
                dgvFrecuencias.Rows(4).Cells(3).Value = ((dgvFrecuencias.Rows(4).Cells(1).Value - dgvFrecuencias.Rows(4).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(4).Cells(2).Value))
                dgvFrecuencias.Rows(5).Cells(3).Value = ((dgvFrecuencias.Rows(5).Cells(1).Value - dgvFrecuencias.Rows(5).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(5).Cells(2).Value))
                dgvFrecuencias.Rows(6).Cells(3).Value = ((dgvFrecuencias.Rows(6).Cells(1).Value - dgvFrecuencias.Rows(6).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(6).Cells(2).Value))
                dgvFrecuencias.Rows(7).Cells(3).Value = ((dgvFrecuencias.Rows(7).Cells(1).Value - dgvFrecuencias.Rows(7).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(7).Cells(2).Value))
                dgvFrecuencias.Rows(8).Cells(3).Value = ((dgvFrecuencias.Rows(8).Cells(1).Value - dgvFrecuencias.Rows(8).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(8).Cells(2).Value))
                dgvFrecuencias.Rows(9).Cells(3).Value = ((dgvFrecuencias.Rows(9).Cells(1).Value - dgvFrecuencias.Rows(9).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(9).Cells(2).Value))

                dgvFrecuencias.Rows(0).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(3).Value
                dgvFrecuencias.Rows(1).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(4).Value + dgvFrecuencias.Rows(1).Cells(3).Value
                dgvFrecuencias.Rows(2).Cells(4).Value = dgvFrecuencias.Rows(1).Cells(4).Value + dgvFrecuencias.Rows(2).Cells(3).Value
                dgvFrecuencias.Rows(3).Cells(4).Value = dgvFrecuencias.Rows(2).Cells(4).Value + dgvFrecuencias.Rows(3).Cells(3).Value
                dgvFrecuencias.Rows(4).Cells(4).Value = dgvFrecuencias.Rows(3).Cells(4).Value + dgvFrecuencias.Rows(4).Cells(3).Value
                dgvFrecuencias.Rows(5).Cells(4).Value = dgvFrecuencias.Rows(4).Cells(4).Value + dgvFrecuencias.Rows(5).Cells(3).Value
                dgvFrecuencias.Rows(6).Cells(4).Value = dgvFrecuencias.Rows(5).Cells(4).Value + dgvFrecuencias.Rows(6).Cells(3).Value
                dgvFrecuencias.Rows(7).Cells(4).Value = dgvFrecuencias.Rows(6).Cells(4).Value + dgvFrecuencias.Rows(7).Cells(3).Value
                dgvFrecuencias.Rows(8).Cells(4).Value = dgvFrecuencias.Rows(7).Cells(4).Value + dgvFrecuencias.Rows(8).Cells(3).Value
                dgvFrecuencias.Rows(9).Cells(4).Value = dgvFrecuencias.Rows(8).Cells(4).Value + dgvFrecuencias.Rows(9).Cells(3).Value
            End If

            If intervalos = 15 Then
                dgvFrecuencias.Rows(0).Cells(3).Value = ((dgvFrecuencias.Rows(0).Cells(1).Value - dgvFrecuencias.Rows(0).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(0).Cells(2).Value))
                dgvFrecuencias.Rows(1).Cells(3).Value = ((dgvFrecuencias.Rows(1).Cells(1).Value - dgvFrecuencias.Rows(1).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(1).Cells(2).Value))
                dgvFrecuencias.Rows(2).Cells(3).Value = ((dgvFrecuencias.Rows(2).Cells(1).Value - dgvFrecuencias.Rows(2).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(2).Cells(2).Value))
                dgvFrecuencias.Rows(3).Cells(3).Value = ((dgvFrecuencias.Rows(3).Cells(1).Value - dgvFrecuencias.Rows(3).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(3).Cells(2).Value))
                dgvFrecuencias.Rows(4).Cells(3).Value = ((dgvFrecuencias.Rows(4).Cells(1).Value - dgvFrecuencias.Rows(4).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(4).Cells(2).Value))
                dgvFrecuencias.Rows(5).Cells(3).Value = ((dgvFrecuencias.Rows(5).Cells(1).Value - dgvFrecuencias.Rows(5).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(5).Cells(2).Value))
                dgvFrecuencias.Rows(6).Cells(3).Value = ((dgvFrecuencias.Rows(6).Cells(1).Value - dgvFrecuencias.Rows(6).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(6).Cells(2).Value))
                dgvFrecuencias.Rows(7).Cells(3).Value = ((dgvFrecuencias.Rows(7).Cells(1).Value - dgvFrecuencias.Rows(7).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(7).Cells(2).Value))
                dgvFrecuencias.Rows(8).Cells(3).Value = ((dgvFrecuencias.Rows(8).Cells(1).Value - dgvFrecuencias.Rows(8).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(8).Cells(2).Value))
                dgvFrecuencias.Rows(9).Cells(3).Value = ((dgvFrecuencias.Rows(9).Cells(1).Value - dgvFrecuencias.Rows(9).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(9).Cells(2).Value))
                dgvFrecuencias.Rows(10).Cells(3).Value = ((dgvFrecuencias.Rows(10).Cells(1).Value - dgvFrecuencias.Rows(10).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(10).Cells(2).Value))
                dgvFrecuencias.Rows(11).Cells(3).Value = ((dgvFrecuencias.Rows(11).Cells(1).Value - dgvFrecuencias.Rows(11).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(11).Cells(2).Value))
                dgvFrecuencias.Rows(12).Cells(3).Value = ((dgvFrecuencias.Rows(12).Cells(1).Value - dgvFrecuencias.Rows(12).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(12).Cells(2).Value))
                dgvFrecuencias.Rows(13).Cells(3).Value = ((dgvFrecuencias.Rows(13).Cells(1).Value - dgvFrecuencias.Rows(13).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(13).Cells(2).Value))
                dgvFrecuencias.Rows(14).Cells(3).Value = ((dgvFrecuencias.Rows(14).Cells(1).Value - dgvFrecuencias.Rows(14).Cells(2).Value) ^ 2 / (dgvFrecuencias.Rows(14).Cells(2).Value))

                dgvFrecuencias.Rows(0).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(3).Value
                dgvFrecuencias.Rows(1).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(4).Value + dgvFrecuencias.Rows(1).Cells(3).Value
                dgvFrecuencias.Rows(2).Cells(4).Value = dgvFrecuencias.Rows(1).Cells(4).Value + dgvFrecuencias.Rows(2).Cells(3).Value
                dgvFrecuencias.Rows(3).Cells(4).Value = dgvFrecuencias.Rows(2).Cells(4).Value + dgvFrecuencias.Rows(3).Cells(3).Value
                dgvFrecuencias.Rows(4).Cells(4).Value = dgvFrecuencias.Rows(3).Cells(4).Value + dgvFrecuencias.Rows(4).Cells(3).Value
                dgvFrecuencias.Rows(5).Cells(4).Value = dgvFrecuencias.Rows(4).Cells(4).Value + dgvFrecuencias.Rows(5).Cells(3).Value
                dgvFrecuencias.Rows(6).Cells(4).Value = dgvFrecuencias.Rows(5).Cells(4).Value + dgvFrecuencias.Rows(6).Cells(3).Value
                dgvFrecuencias.Rows(7).Cells(4).Value = dgvFrecuencias.Rows(6).Cells(4).Value + dgvFrecuencias.Rows(7).Cells(3).Value
                dgvFrecuencias.Rows(8).Cells(4).Value = dgvFrecuencias.Rows(7).Cells(4).Value + dgvFrecuencias.Rows(8).Cells(3).Value
                dgvFrecuencias.Rows(9).Cells(4).Value = dgvFrecuencias.Rows(8).Cells(4).Value + dgvFrecuencias.Rows(9).Cells(3).Value
                dgvFrecuencias.Rows(10).Cells(4).Value = dgvFrecuencias.Rows(9).Cells(4).Value + dgvFrecuencias.Rows(10).Cells(3).Value
                dgvFrecuencias.Rows(11).Cells(4).Value = dgvFrecuencias.Rows(10).Cells(4).Value + dgvFrecuencias.Rows(11).Cells(3).Value
                dgvFrecuencias.Rows(12).Cells(4).Value = dgvFrecuencias.Rows(11).Cells(4).Value + dgvFrecuencias.Rows(12).Cells(3).Value
                dgvFrecuencias.Rows(13).Cells(4).Value = dgvFrecuencias.Rows(12).Cells(4).Value + dgvFrecuencias.Rows(13).Cells(3).Value
                dgvFrecuencias.Rows(14).Cells(4).Value = dgvFrecuencias.Rows(13).Cells(4).Value + dgvFrecuencias.Rows(14).Cells(3).Value
            End If
        Else
            MessageBox.Show("Seleccione un valor para la cantidad de intervalos.")
        End If
    End Sub
End Class