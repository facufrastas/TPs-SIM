Public Class FormPoisson

    Private Sub FormPoisson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub limpiar()
        dgvResultados.Rows.Clear()
        dgvFrecuencias.Rows.Clear()

        For Each series In histograma.Series
            series.Points.Clear()
        Next
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If IsNumeric(txtLambda.Text) Then
            If txtLambda.Text >= 0 Then
                dgvResultados.Rows.Clear()
                generar()
            Else
                MessageBox.Show("Los valores deben ser positivos.")
            End If
        Else
            MessageBox.Show("Valores No Válidos.")
        End If
    End Sub

    Private Sub generar()
        Dim p As New Double
        Dim x As New Integer
        Dim a As New Double
        Dim lambda As New Integer
        lambda = CInt(txtLambda.Text)
        Dim n As New Integer
        n = CInt(txtN.Text)

        Dim random As New Random()
        Dim u As New Double

        dgvResultados.Columns(1).DefaultCellStyle.Format = "N2"

        For i = 1 To n
            p = 1
            x = -1
            a = Math.Exp(-lambda)
            Do While (p >= a)
                u = random.Next(0, 999999)
                u = u / 1000000
                p = p * u
                x = x + 1
            Loop
            Me.dgvResultados.Rows.Add(i, x)
        Next

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnGrafico2_Click(sender As Object, e As EventArgs) Handles btnGrafico2.Click
        For Each series In histograma.Series
            series.Points.Clear()
        Next
        'histograma.Series(0).CustomProperties = "PointWidth = 1"
        'histograma.ChartAreas(0).AxisY.IntervalOffset = 1
        'histograma.ChartAreas(0).AxisX.Interval = 1
        'histograma.ChartAreas(0).AxisX.LabelStyle.Angle = -90
        'histograma.BorderlineWidth = 1

        For Each Fila As DataGridViewRow In dgvFrecuencias.Rows
            histograma.Series("Frecuencia Observada").Points.AddXY(Fila.Cells(0).Value, Fila.Cells(3).Value)
            histograma.Series("Frecuencia Esperada").Points.AddXY(Fila.Cells(0).Value, Fila.Cells(4).Value)
        Next
    End Sub

    Function factorial(ByVal n As Double) As Double
        If n <= 1 Then
            Return 1
        Else
            Return factorial(n - 1) * n
        End If
    End Function

    Private Sub btnChi_Click(sender As Object, e As EventArgs) Handles btnChi.Click
        dgvFrecuencias.Rows.Clear()
        Dim intervalos As New Integer
        intervalos = cmbIntervalos.SelectedItem
        Dim i As New Integer
        Dim lambda As New Double
        lambda = txtLambda.Text
        Dim muestra As New Integer
        muestra = txtN.Text

        dgvFrecuencias.Columns(0).DefaultCellStyle.Format = "N2"
        dgvFrecuencias.Columns(1).DefaultCellStyle.Format = "N2"
        dgvFrecuencias.Columns(2).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(4).DefaultCellStyle.Format = "N2"
        dgvFrecuencias.Columns(5).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(6).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(7).DefaultCellStyle.Format = "N4"

        Dim maximo As New Double
        maximo = 0
        Dim minimo As New Double
        minimo = 0

        For Each Fila As DataGridViewRow In dgvResultados.Rows
            If Fila.Cells(1).Value > maximo Then
                maximo = Fila.Cells(1).Value
            End If
            If Fila.Cells(1).Value < minimo Then
                minimo = Fila.Cells(1).Value
            End If
        Next

        If cmbIntervalos.SelectedIndex <> -1 Then
            Dim n As New Integer
            n = CInt(txtN.Text)

            Dim valorIntervalos As New Double

            If intervalos = 5 Then
                valorIntervalos = (maximo - minimo) / 5
                Dim valorDecimalesDouble As Double = (minimo + (valorIntervalos * 2))

                Me.dgvFrecuencias.Rows.Add((minimo), (minimo + valorIntervalos), valorDecimalesDouble / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + valorIntervalos), (minimo + (valorIntervalos * 2)), (valorDecimalesDouble * 2 - valorDecimalesDouble) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 2)), (minimo + (valorIntervalos * 3)), (valorDecimalesDouble * 4 - valorDecimalesDouble * 3) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 3)), (minimo + (valorIntervalos * 4)), (valorDecimalesDouble * 4 - valorDecimalesDouble * 3) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 4)), (minimo + (valorIntervalos * 5)), (valorDecimalesDouble * 5 - valorDecimalesDouble * 4) / 2, 0, 0, 0, 0)
            End If

            If intervalos = 10 Then
                valorIntervalos = (maximo - minimo) / 10
                Dim valorDecimalesDouble As Double = (minimo + (valorIntervalos * 2))

                Me.dgvFrecuencias.Rows.Add((minimo), (minimo + valorIntervalos), valorDecimalesDouble / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + valorIntervalos), (minimo + (valorIntervalos * 2)), (valorDecimalesDouble * 2 - valorDecimalesDouble) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 2)), (minimo + (valorIntervalos * 3)), (valorDecimalesDouble * 4 - valorDecimalesDouble * 3) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 3)), (minimo + (valorIntervalos * 4)), (valorDecimalesDouble * 4 - valorDecimalesDouble * 3) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 4)), (minimo + (valorIntervalos * 5)), (valorDecimalesDouble * 5 - valorDecimalesDouble * 4) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 5)), (minimo + (valorIntervalos * 6)), (valorDecimalesDouble * 6 - valorDecimalesDouble * 5) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 6)), (minimo + (valorIntervalos * 7)), (valorDecimalesDouble * 7 - valorDecimalesDouble * 6) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 7)), (minimo + (valorIntervalos * 8)), (valorDecimalesDouble * 8 - valorDecimalesDouble * 7) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 8)), (minimo + (valorIntervalos * 9)), (valorDecimalesDouble * 9 - valorDecimalesDouble * 8) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 9)), (minimo + (valorIntervalos * 10)), (valorDecimalesDouble * 10 - valorDecimalesDouble * 9) / 2, 0, 0, 0, 0)
            End If

            If intervalos = 15 Then
                valorIntervalos = (maximo - minimo) / 15
                Dim valorDecimalesDouble As Double = (minimo + (valorIntervalos * 2))

                Me.dgvFrecuencias.Rows.Add((minimo), (minimo + valorIntervalos), valorDecimalesDouble / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + valorIntervalos), (minimo + (valorIntervalos * 2)), (valorDecimalesDouble * 2 - valorDecimalesDouble) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 2)), (minimo + (valorIntervalos * 3)), (valorDecimalesDouble * 4 - valorDecimalesDouble * 3) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 3)), (minimo + (valorIntervalos * 4)), (valorDecimalesDouble * 4 - valorDecimalesDouble * 3) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 4)), (minimo + (valorIntervalos * 5)), (valorDecimalesDouble * 5 - valorDecimalesDouble * 4) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 5)), (minimo + (valorIntervalos * 6)), (valorDecimalesDouble * 6 - valorDecimalesDouble * 5) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 6)), (minimo + (valorIntervalos * 7)), (valorDecimalesDouble * 7 - valorDecimalesDouble * 6) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 7)), (minimo + (valorIntervalos * 8)), (valorDecimalesDouble * 8 - valorDecimalesDouble * 7) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 8)), (minimo + (valorIntervalos * 9)), (valorDecimalesDouble * 9 - valorDecimalesDouble * 8) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 9)), (minimo + (valorIntervalos * 10)), (valorDecimalesDouble * 10 - valorDecimalesDouble * 9) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 10)), (minimo + (valorIntervalos * 11)), (valorDecimalesDouble * 11 - valorDecimalesDouble * 10) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 11)), (minimo + (valorIntervalos * 12)), (valorDecimalesDouble * 12 - valorDecimalesDouble * 11) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 12)), (minimo + (valorIntervalos * 13)), (valorDecimalesDouble * 13 - valorDecimalesDouble * 12) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 13)), (minimo + (valorIntervalos * 14)), (valorDecimalesDouble * 14 - valorDecimalesDouble * 13) / 2, 0, 0, 0, 0)
                Me.dgvFrecuencias.Rows.Add((minimo + (valorIntervalos * 14)), (minimo + (valorIntervalos * 15)), (valorDecimalesDouble * 15 - valorDecimalesDouble * 14) / 2, 0, 0, 0, 0)
            End If

            For Each Fila As DataGridViewRow In dgvResultados.Rows
                If intervalos = 5 Then
                    valorIntervalos = (maximo - minimo) / 5
                    If (Fila.Cells(1).Value >= minimo Or Fila.Cells(1).Value < minimo) And Fila.Cells(1).Value < (minimo + valorIntervalos) Then
                        dgvFrecuencias.Rows(0).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + valorIntervalos) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 2)) Then
                        dgvFrecuencias.Rows(1).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 2)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 3)) Then
                        dgvFrecuencias.Rows(2).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 3)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 4)) Then
                        dgvFrecuencias.Rows(3).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 4)) And Fila.Cells(1).Value <= (minimo + (valorIntervalos * 5)) Then
                        dgvFrecuencias.Rows(4).Cells(3).Value += 1
                    End If
                End If
            Next

            For Each Fila As DataGridViewRow In dgvResultados.Rows
                If intervalos = 10 Then
                    valorIntervalos = (maximo - minimo) / 10
                    If (Fila.Cells(1).Value >= minimo Or Fila.Cells(1).Value < minimo) And Fila.Cells(1).Value < (minimo + valorIntervalos) Then
                        dgvFrecuencias.Rows(0).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + valorIntervalos) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 2)) Then
                        dgvFrecuencias.Rows(1).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 2)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 3)) Then
                        dgvFrecuencias.Rows(2).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 3)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 4)) Then
                        dgvFrecuencias.Rows(3).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 4)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 5)) Then
                        dgvFrecuencias.Rows(4).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 5)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 6)) Then
                        dgvFrecuencias.Rows(5).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 6)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 7)) Then
                        dgvFrecuencias.Rows(6).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 7)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 8)) Then
                        dgvFrecuencias.Rows(7).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 8)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 9)) Then
                        dgvFrecuencias.Rows(8).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 9)) And Fila.Cells(1).Value <= (minimo + (valorIntervalos * 10)) Then
                        dgvFrecuencias.Rows(9).Cells(3).Value += 1
                    End If
                End If
            Next

            For Each Fila As DataGridViewRow In dgvResultados.Rows
                If intervalos = 15 Then
                    valorIntervalos = (maximo - minimo) / 15
                    If (Fila.Cells(1).Value >= minimo Or Fila.Cells(1).Value < minimo) And Fila.Cells(1).Value < (minimo + valorIntervalos) Then
                        dgvFrecuencias.Rows(0).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + valorIntervalos) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 2)) Then
                        dgvFrecuencias.Rows(1).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 2)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 3)) Then
                        dgvFrecuencias.Rows(2).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 3)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 4)) Then
                        dgvFrecuencias.Rows(3).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 4)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 5)) Then
                        dgvFrecuencias.Rows(4).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 5)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 6)) Then
                        dgvFrecuencias.Rows(5).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 6)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 7)) Then
                        dgvFrecuencias.Rows(6).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 7)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 8)) Then
                        dgvFrecuencias.Rows(7).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 8)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 9)) Then
                        dgvFrecuencias.Rows(8).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 9)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 10)) Then
                        dgvFrecuencias.Rows(9).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 10)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 11)) Then
                        dgvFrecuencias.Rows(10).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 11)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 12)) Then
                        dgvFrecuencias.Rows(11).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 12)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 13)) Then
                        dgvFrecuencias.Rows(12).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 13)) And Fila.Cells(1).Value < (minimo + (valorIntervalos * 14)) Then
                        dgvFrecuencias.Rows(13).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (minimo + (valorIntervalos * 14)) And Fila.Cells(1).Value <= (minimo + (valorIntervalos * 15)) Then
                        dgvFrecuencias.Rows(14).Cells(3).Value += 1
                    End If
                End If
            Next
        Else
            MessageBox.Show("Seleccione un valor para la cantidad de intervalos.")
        End If

        If intervalos = 5 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(0).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(0).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(0).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(0).Cells(0).Value)))
            dgvFrecuencias.Rows(1).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(1).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(1).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(1).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(1).Cells(0).Value)))
            dgvFrecuencias.Rows(2).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(2).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(2).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(2).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(2).Cells(0).Value)))
            dgvFrecuencias.Rows(3).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(3).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(3).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(3).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(3).Cells(0).Value)))
            dgvFrecuencias.Rows(4).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(4).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(4).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(4).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(4).Cells(0).Value)))

            dgvFrecuencias.Rows(0).Cells(4).Value = muestra * dgvFrecuencias.Rows(0).Cells(5).Value
            dgvFrecuencias.Rows(1).Cells(4).Value = muestra * dgvFrecuencias.Rows(1).Cells(5).Value
            dgvFrecuencias.Rows(2).Cells(4).Value = muestra * dgvFrecuencias.Rows(2).Cells(5).Value
            dgvFrecuencias.Rows(3).Cells(4).Value = muestra * dgvFrecuencias.Rows(3).Cells(5).Value
            dgvFrecuencias.Rows(4).Cells(4).Value = muestra * dgvFrecuencias.Rows(4).Cells(5).Value

            dgvFrecuencias.Rows(0).Cells(6).Value = ((((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value)))
            dgvFrecuencias.Rows(1).Cells(6).Value = ((((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value)))
            dgvFrecuencias.Rows(2).Cells(6).Value = ((((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value)))
            dgvFrecuencias.Rows(3).Cells(6).Value = ((((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value)))
            dgvFrecuencias.Rows(4).Cells(6).Value = ((((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value)))

            dgvFrecuencias.Rows(0).Cells(7).Value = dgvFrecuencias.Rows(0).Cells(6).Value
            dgvFrecuencias.Rows(1).Cells(7).Value = dgvFrecuencias.Rows(0).Cells(7).Value + dgvFrecuencias.Rows(1).Cells(7).Value
            dgvFrecuencias.Rows(2).Cells(7).Value = dgvFrecuencias.Rows(1).Cells(7).Value + dgvFrecuencias.Rows(2).Cells(6).Value
            dgvFrecuencias.Rows(3).Cells(7).Value = dgvFrecuencias.Rows(2).Cells(7).Value + dgvFrecuencias.Rows(3).Cells(6).Value
            dgvFrecuencias.Rows(4).Cells(7).Value = dgvFrecuencias.Rows(3).Cells(7).Value + dgvFrecuencias.Rows(4).Cells(6).Value
        End If

        If intervalos = 10 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(0).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(0).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(0).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(0).Cells(0).Value)))
            dgvFrecuencias.Rows(1).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(1).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(1).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(1).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(1).Cells(0).Value)))
            dgvFrecuencias.Rows(2).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(2).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(2).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(2).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(2).Cells(0).Value)))
            dgvFrecuencias.Rows(3).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(3).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(3).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(3).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(3).Cells(0).Value)))
            dgvFrecuencias.Rows(4).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(4).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(4).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(4).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(4).Cells(0).Value)))
            dgvFrecuencias.Rows(5).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(5).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(5).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(5).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(5).Cells(0).Value)))
            dgvFrecuencias.Rows(6).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(6).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(6).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(6).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(6).Cells(0).Value)))
            dgvFrecuencias.Rows(7).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(7).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(7).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(7).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(7).Cells(0).Value)))
            dgvFrecuencias.Rows(8).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(8).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(8).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(8).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(8).Cells(0).Value)))
            dgvFrecuencias.Rows(9).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(9).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(9).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(9).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(9).Cells(0).Value)))

            dgvFrecuencias.Rows(0).Cells(4).Value = muestra * dgvFrecuencias.Rows(0).Cells(5).Value
            dgvFrecuencias.Rows(1).Cells(4).Value = muestra * dgvFrecuencias.Rows(1).Cells(5).Value
            dgvFrecuencias.Rows(2).Cells(4).Value = muestra * dgvFrecuencias.Rows(2).Cells(5).Value
            dgvFrecuencias.Rows(3).Cells(4).Value = muestra * dgvFrecuencias.Rows(3).Cells(5).Value
            dgvFrecuencias.Rows(4).Cells(4).Value = muestra * dgvFrecuencias.Rows(4).Cells(5).Value
            dgvFrecuencias.Rows(5).Cells(4).Value = muestra * dgvFrecuencias.Rows(5).Cells(5).Value
            dgvFrecuencias.Rows(6).Cells(4).Value = muestra * dgvFrecuencias.Rows(6).Cells(5).Value
            dgvFrecuencias.Rows(7).Cells(4).Value = muestra * dgvFrecuencias.Rows(7).Cells(5).Value
            dgvFrecuencias.Rows(8).Cells(4).Value = muestra * dgvFrecuencias.Rows(8).Cells(5).Value
            dgvFrecuencias.Rows(9).Cells(4).Value = muestra * dgvFrecuencias.Rows(9).Cells(5).Value

            dgvFrecuencias.Rows(0).Cells(6).Value = ((((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value)))
            dgvFrecuencias.Rows(1).Cells(6).Value = ((((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value)))
            dgvFrecuencias.Rows(2).Cells(6).Value = ((((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value)))
            dgvFrecuencias.Rows(3).Cells(6).Value = ((((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value)))
            dgvFrecuencias.Rows(4).Cells(6).Value = ((((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value)))
            dgvFrecuencias.Rows(5).Cells(6).Value = ((((dgvFrecuencias.Rows(5).Cells(3).Value - dgvFrecuencias.Rows(5).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(5).Cells(4).Value)))
            dgvFrecuencias.Rows(6).Cells(6).Value = ((((dgvFrecuencias.Rows(6).Cells(3).Value - dgvFrecuencias.Rows(6).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(6).Cells(4).Value)))
            dgvFrecuencias.Rows(7).Cells(6).Value = ((((dgvFrecuencias.Rows(7).Cells(3).Value - dgvFrecuencias.Rows(7).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(7).Cells(4).Value)))
            dgvFrecuencias.Rows(8).Cells(6).Value = ((((dgvFrecuencias.Rows(8).Cells(3).Value - dgvFrecuencias.Rows(8).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(8).Cells(4).Value)))
            dgvFrecuencias.Rows(9).Cells(6).Value = ((((dgvFrecuencias.Rows(9).Cells(3).Value - dgvFrecuencias.Rows(9).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(9).Cells(4).Value)))

            dgvFrecuencias.Rows(0).Cells(7).Value = dgvFrecuencias.Rows(0).Cells(6).Value
            dgvFrecuencias.Rows(1).Cells(7).Value = dgvFrecuencias.Rows(0).Cells(7).Value + dgvFrecuencias.Rows(1).Cells(7).Value
            dgvFrecuencias.Rows(2).Cells(7).Value = dgvFrecuencias.Rows(1).Cells(7).Value + dgvFrecuencias.Rows(2).Cells(6).Value
            dgvFrecuencias.Rows(3).Cells(7).Value = dgvFrecuencias.Rows(2).Cells(7).Value + dgvFrecuencias.Rows(3).Cells(6).Value
            dgvFrecuencias.Rows(4).Cells(7).Value = dgvFrecuencias.Rows(3).Cells(7).Value + dgvFrecuencias.Rows(4).Cells(6).Value
            dgvFrecuencias.Rows(5).Cells(7).Value = dgvFrecuencias.Rows(4).Cells(7).Value + dgvFrecuencias.Rows(5).Cells(6).Value
            dgvFrecuencias.Rows(6).Cells(7).Value = dgvFrecuencias.Rows(5).Cells(7).Value + dgvFrecuencias.Rows(6).Cells(6).Value
            dgvFrecuencias.Rows(7).Cells(7).Value = dgvFrecuencias.Rows(6).Cells(7).Value + dgvFrecuencias.Rows(7).Cells(6).Value
            dgvFrecuencias.Rows(8).Cells(7).Value = dgvFrecuencias.Rows(7).Cells(7).Value + dgvFrecuencias.Rows(8).Cells(6).Value
            dgvFrecuencias.Rows(9).Cells(7).Value = dgvFrecuencias.Rows(8).Cells(7).Value + dgvFrecuencias.Rows(9).Cells(6).Value
        End If

        If intervalos = 15 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(0).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(0).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(0).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(0).Cells(0).Value)))
            dgvFrecuencias.Rows(1).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(1).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(1).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(1).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(1).Cells(0).Value)))
            dgvFrecuencias.Rows(2).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(2).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(2).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(2).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(2).Cells(0).Value)))
            dgvFrecuencias.Rows(3).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(3).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(3).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(3).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(3).Cells(0).Value)))
            dgvFrecuencias.Rows(4).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(4).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(4).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(4).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(4).Cells(0).Value)))
            dgvFrecuencias.Rows(5).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(5).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(5).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(5).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(5).Cells(0).Value)))
            dgvFrecuencias.Rows(6).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(6).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(6).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(6).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(6).Cells(0).Value)))
            dgvFrecuencias.Rows(7).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(7).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(7).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(7).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(7).Cells(0).Value)))
            dgvFrecuencias.Rows(8).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(8).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(8).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(8).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(8).Cells(0).Value)))
            dgvFrecuencias.Rows(9).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(9).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(9).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(9).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(9).Cells(0).Value)))
            dgvFrecuencias.Rows(10).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(10).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(10).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(10).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(10).Cells(0).Value)))
            dgvFrecuencias.Rows(11).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(11).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(11).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(11).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(11).Cells(0).Value)))
            dgvFrecuencias.Rows(12).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(12).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(12).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(12).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(12).Cells(0).Value)))
            dgvFrecuencias.Rows(13).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(13).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(13).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(13).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(13).Cells(0).Value)))
            dgvFrecuencias.Rows(14).Cells(5).Value = (((lambda ^ dgvFrecuencias.Rows(14).Cells(1).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(14).Cells(1).Value))) + (((lambda ^ dgvFrecuencias.Rows(14).Cells(0).Value) * Math.Exp(-lambda)) / (factorial(dgvFrecuencias.Rows(14).Cells(0).Value)))

            dgvFrecuencias.Rows(0).Cells(4).Value = muestra * dgvFrecuencias.Rows(0).Cells(5).Value
            dgvFrecuencias.Rows(1).Cells(4).Value = muestra * dgvFrecuencias.Rows(1).Cells(5).Value
            dgvFrecuencias.Rows(2).Cells(4).Value = muestra * dgvFrecuencias.Rows(2).Cells(5).Value
            dgvFrecuencias.Rows(3).Cells(4).Value = muestra * dgvFrecuencias.Rows(3).Cells(5).Value
            dgvFrecuencias.Rows(4).Cells(4).Value = muestra * dgvFrecuencias.Rows(4).Cells(5).Value
            dgvFrecuencias.Rows(5).Cells(4).Value = muestra * dgvFrecuencias.Rows(5).Cells(5).Value
            dgvFrecuencias.Rows(6).Cells(4).Value = muestra * dgvFrecuencias.Rows(6).Cells(5).Value
            dgvFrecuencias.Rows(7).Cells(4).Value = muestra * dgvFrecuencias.Rows(7).Cells(5).Value
            dgvFrecuencias.Rows(8).Cells(4).Value = muestra * dgvFrecuencias.Rows(8).Cells(5).Value
            dgvFrecuencias.Rows(9).Cells(4).Value = muestra * dgvFrecuencias.Rows(9).Cells(5).Value
            dgvFrecuencias.Rows(10).Cells(4).Value = muestra * dgvFrecuencias.Rows(10).Cells(5).Value
            dgvFrecuencias.Rows(11).Cells(4).Value = muestra * dgvFrecuencias.Rows(11).Cells(5).Value
            dgvFrecuencias.Rows(12).Cells(4).Value = muestra * dgvFrecuencias.Rows(12).Cells(5).Value
            dgvFrecuencias.Rows(13).Cells(4).Value = muestra * dgvFrecuencias.Rows(13).Cells(5).Value
            dgvFrecuencias.Rows(14).Cells(4).Value = muestra * dgvFrecuencias.Rows(14).Cells(5).Value

            dgvFrecuencias.Rows(0).Cells(6).Value = ((((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value)))
            dgvFrecuencias.Rows(1).Cells(6).Value = ((((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value)))
            dgvFrecuencias.Rows(2).Cells(6).Value = ((((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value)))
            dgvFrecuencias.Rows(3).Cells(6).Value = ((((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value)))
            dgvFrecuencias.Rows(4).Cells(6).Value = ((((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value)))
            dgvFrecuencias.Rows(5).Cells(6).Value = ((((dgvFrecuencias.Rows(5).Cells(3).Value - dgvFrecuencias.Rows(5).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(5).Cells(4).Value)))
            dgvFrecuencias.Rows(6).Cells(6).Value = ((((dgvFrecuencias.Rows(6).Cells(3).Value - dgvFrecuencias.Rows(6).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(6).Cells(4).Value)))
            dgvFrecuencias.Rows(7).Cells(6).Value = ((((dgvFrecuencias.Rows(7).Cells(3).Value - dgvFrecuencias.Rows(7).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(7).Cells(4).Value)))
            dgvFrecuencias.Rows(8).Cells(6).Value = ((((dgvFrecuencias.Rows(8).Cells(3).Value - dgvFrecuencias.Rows(8).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(8).Cells(4).Value)))
            dgvFrecuencias.Rows(9).Cells(6).Value = ((((dgvFrecuencias.Rows(9).Cells(3).Value - dgvFrecuencias.Rows(9).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(9).Cells(4).Value)))
            dgvFrecuencias.Rows(10).Cells(6).Value = ((((dgvFrecuencias.Rows(10).Cells(3).Value - dgvFrecuencias.Rows(10).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(10).Cells(4).Value)))
            dgvFrecuencias.Rows(11).Cells(6).Value = ((((dgvFrecuencias.Rows(11).Cells(3).Value - dgvFrecuencias.Rows(11).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(11).Cells(4).Value)))
            dgvFrecuencias.Rows(12).Cells(6).Value = ((((dgvFrecuencias.Rows(12).Cells(3).Value - dgvFrecuencias.Rows(12).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(12).Cells(4).Value)))
            dgvFrecuencias.Rows(13).Cells(6).Value = ((((dgvFrecuencias.Rows(13).Cells(3).Value - dgvFrecuencias.Rows(13).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(13).Cells(4).Value)))
            dgvFrecuencias.Rows(14).Cells(6).Value = ((((dgvFrecuencias.Rows(14).Cells(3).Value - dgvFrecuencias.Rows(14).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(14).Cells(4).Value)))

            dgvFrecuencias.Rows(0).Cells(7).Value = dgvFrecuencias.Rows(0).Cells(6).Value
            dgvFrecuencias.Rows(1).Cells(7).Value = dgvFrecuencias.Rows(0).Cells(7).Value + dgvFrecuencias.Rows(1).Cells(7).Value
            dgvFrecuencias.Rows(2).Cells(7).Value = dgvFrecuencias.Rows(1).Cells(7).Value + dgvFrecuencias.Rows(2).Cells(6).Value
            dgvFrecuencias.Rows(3).Cells(7).Value = dgvFrecuencias.Rows(2).Cells(7).Value + dgvFrecuencias.Rows(3).Cells(6).Value
            dgvFrecuencias.Rows(4).Cells(7).Value = dgvFrecuencias.Rows(3).Cells(7).Value + dgvFrecuencias.Rows(4).Cells(6).Value
            dgvFrecuencias.Rows(5).Cells(7).Value = dgvFrecuencias.Rows(4).Cells(7).Value + dgvFrecuencias.Rows(5).Cells(6).Value
            dgvFrecuencias.Rows(6).Cells(7).Value = dgvFrecuencias.Rows(5).Cells(7).Value + dgvFrecuencias.Rows(6).Cells(6).Value
            dgvFrecuencias.Rows(7).Cells(7).Value = dgvFrecuencias.Rows(6).Cells(7).Value + dgvFrecuencias.Rows(7).Cells(6).Value
            dgvFrecuencias.Rows(8).Cells(7).Value = dgvFrecuencias.Rows(7).Cells(7).Value + dgvFrecuencias.Rows(8).Cells(6).Value
            dgvFrecuencias.Rows(9).Cells(7).Value = dgvFrecuencias.Rows(8).Cells(7).Value + dgvFrecuencias.Rows(9).Cells(6).Value
            dgvFrecuencias.Rows(10).Cells(7).Value = dgvFrecuencias.Rows(9).Cells(7).Value + dgvFrecuencias.Rows(10).Cells(6).Value
            dgvFrecuencias.Rows(11).Cells(7).Value = dgvFrecuencias.Rows(10).Cells(7).Value + dgvFrecuencias.Rows(11).Cells(6).Value
            dgvFrecuencias.Rows(12).Cells(7).Value = dgvFrecuencias.Rows(11).Cells(7).Value + dgvFrecuencias.Rows(12).Cells(6).Value
            dgvFrecuencias.Rows(13).Cells(7).Value = dgvFrecuencias.Rows(12).Cells(7).Value + dgvFrecuencias.Rows(13).Cells(6).Value
            dgvFrecuencias.Rows(14).Cells(7).Value = dgvFrecuencias.Rows(13).Cells(7).Value + dgvFrecuencias.Rows(14).Cells(6).Value
        End If
    End Sub

End Class