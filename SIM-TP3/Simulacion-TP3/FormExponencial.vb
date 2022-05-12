Public Class FormExponencial

    Private Sub FormExponencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If IsNumeric(txtN.Text) Then
            If txtN.Text > 0 Then
                dgvResultados.Rows.Clear()
                generar()
            Else
                MessageBox.Show("El tamaño de la muestra debe ser positivo.")
            End If
        End If
    End Sub

    Private Sub generar()
        Dim n As New Integer
        n = CInt(txtN.Text)
        Dim random As New Random()
        Dim numero As New Double
        Dim totalSumatoria As New Double

        Dim media As New Double
        media = CInt(txtMedia.Text)
        Dim valorFinal As New Double

        dgvResultados.Columns(1).DefaultCellStyle.Format = "N2"

        For i = 1 To n
            numero = random.Next(0, 999999)
            numero = numero / 1000000
            valorFinal = Math.Log(1 - numero) * (-media)
            Dim final As Double = Trim(Microsoft.VisualBasic.Left(valorFinal, 6))
            Me.dgvResultados.Rows.Add(i, final)
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnGrafico2_Click(sender As Object, e As EventArgs) Handles btnGrafico2.Click
        For Each series In histograma.Series
            series.Points.Clear()
        Next

        Dim intervalos As New Integer
        intervalos = cmbIntervalos.SelectedIndex

        Dim maximo As New Double
        maximo = 0
        Dim minimo As New Double

        For Each Fila As DataGridViewRow In dgvResultados.Rows
            minimo = Fila.Cells(1).Value
        Next

        For Each Fila As DataGridViewRow In dgvResultados.Rows
            If Fila.Cells(1).Value > 0 Then
                If Fila.Cells(1).Value > maximo Then
                    maximo = Fila.Cells(1).Value
                End If
                If Fila.Cells(1).Value < minimo Then
                    minimo = Fila.Cells(1).Value
                End If
            End If
            If Fila.Cells(1).Value < 0 Then
                If Fila.Cells(1).Value < minimo Then
                    minimo = Fila.Cells(1).Value
                End If
                If Fila.Cells(1).Value > maximo Then
                    maximo = Fila.Cells(1).Value
                End If
            End If
        Next

        If intervalos = 5 Then
            histograma.ChartAreas(0).AxisX.Interval = maximo / 5
        End If

        If intervalos = 10 Then
            histograma.ChartAreas(0).AxisX.Interval = maximo / 10
        End If

        If intervalos = 15 Then
            histograma.ChartAreas(0).AxisX.Interval = maximo / 15
        End If

        'histograma.Series(0).CustomProperties = "PointWidth = 1"
        'histograma.ChartAreas(0).AxisY.IntervalOffset = 1
        'histograma.ChartAreas(0).AxisX.Interval = 1
        histograma.ChartAreas(0).AxisX.LabelStyle.Angle = -90
        'histograma.BorderlineWidth = 1

        For Each Fila As DataGridViewRow In dgvFrecuencias.Rows
            histograma.Series("Frecuencia Observada").Points.AddXY(Fila.Cells(0).Value, Fila.Cells(3).Value)
            histograma.Series("Frecuencia Esperada").Points.AddXY(Fila.Cells(0).Value, Fila.Cells(4).Value)
        Next
    End Sub

    Private Sub btnChi_Click(sender As Object, e As EventArgs) Handles btnChi.Click
        dgvFrecuencias.Rows.Clear()
        Dim intervalos As New Integer
        intervalos = cmbIntervalos.SelectedItem
        Dim muestra As New Integer
        muestra = txtN.Text
        Dim media As New Double
        media = txtMedia.Text
        Dim lambda As New Double
        lambda = 1 / media
        Me.txtLambda.Text = lambda
        Dim i As New Integer

        dgvFrecuencias.Columns(0).DefaultCellStyle.Format = "N2"
        dgvFrecuencias.Columns(1).DefaultCellStyle.Format = "N2"
        dgvFrecuencias.Columns(2).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(2).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(4).DefaultCellStyle.Format = "N2"
        dgvFrecuencias.Columns(5).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(6).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(7).DefaultCellStyle.Format = "N4"
        dgvFrecuencias.Columns(8).DefaultCellStyle.Format = "N4"

        Dim maximo As New Double
        maximo = 0
        Dim minimo As New Double

        For Each Fila As DataGridViewRow In dgvResultados.Rows
            minimo = Fila.Cells(1).Value
        Next

        For Each Fila As DataGridViewRow In dgvResultados.Rows
            If Fila.Cells(1).Value > 0 Then
                If Fila.Cells(1).Value > maximo Then
                    maximo = Fila.Cells(1).Value
                End If
                If Fila.Cells(1).Value < minimo Then
                    minimo = Fila.Cells(1).Value
                End If
            End If
            If Fila.Cells(1).Value < 0 Then
                If Fila.Cells(1).Value < minimo Then
                    minimo = Fila.Cells(1).Value
                End If
                If Fila.Cells(1).Value > maximo Then
                    maximo = Fila.Cells(1).Value
                End If
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
            dgvFrecuencias.Rows(0).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(2).Value)) * (dgvFrecuencias.Rows(0).Cells(1).Value - dgvFrecuencias.Rows(0).Cells(0).Value)
            dgvFrecuencias.Rows(1).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(2).Value)) * (dgvFrecuencias.Rows(1).Cells(1).Value - dgvFrecuencias.Rows(1).Cells(0).Value)
            dgvFrecuencias.Rows(2).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(2).Value)) * (dgvFrecuencias.Rows(2).Cells(1).Value - dgvFrecuencias.Rows(2).Cells(0).Value)
            dgvFrecuencias.Rows(3).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(2).Value)) * (dgvFrecuencias.Rows(3).Cells(1).Value - dgvFrecuencias.Rows(3).Cells(0).Value)
            dgvFrecuencias.Rows(4).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(2).Value)) * (dgvFrecuencias.Rows(4).Cells(1).Value - dgvFrecuencias.Rows(4).Cells(0).Value)

            dgvFrecuencias.Rows(0).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(0).Value))
            dgvFrecuencias.Rows(1).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(0).Value))
            dgvFrecuencias.Rows(2).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(0).Value))
            dgvFrecuencias.Rows(3).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(0).Value))
            dgvFrecuencias.Rows(4).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(0).Value))

            dgvFrecuencias.Rows(0).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(6).Value * muestra
            dgvFrecuencias.Rows(1).Cells(4).Value = dgvFrecuencias.Rows(1).Cells(6).Value * muestra
            dgvFrecuencias.Rows(2).Cells(4).Value = dgvFrecuencias.Rows(2).Cells(6).Value * muestra
            dgvFrecuencias.Rows(3).Cells(4).Value = dgvFrecuencias.Rows(3).Cells(6).Value * muestra
            dgvFrecuencias.Rows(4).Cells(4).Value = dgvFrecuencias.Rows(4).Cells(6).Value * muestra

            dgvFrecuencias.Rows(0).Cells(7).Value = ((((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value)))
            dgvFrecuencias.Rows(1).Cells(7).Value = ((((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value)))
            dgvFrecuencias.Rows(2).Cells(7).Value = ((((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value)))
            dgvFrecuencias.Rows(3).Cells(7).Value = ((((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value)))
            dgvFrecuencias.Rows(4).Cells(7).Value = ((((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value)))

            For Each Fila As DataGridViewRow In dgvFrecuencias.Rows
                If Fila.Cells(4).Value = 0 Then
                    Fila.Cells(7).Value = 0
                End If
            Next

            dgvFrecuencias.Rows(0).Cells(8).Value = dgvFrecuencias.Rows(0).Cells(7).Value
            dgvFrecuencias.Rows(1).Cells(8).Value = dgvFrecuencias.Rows(0).Cells(8).Value + dgvFrecuencias.Rows(1).Cells(7).Value
            dgvFrecuencias.Rows(2).Cells(8).Value = dgvFrecuencias.Rows(1).Cells(8).Value + dgvFrecuencias.Rows(2).Cells(7).Value
            dgvFrecuencias.Rows(3).Cells(8).Value = dgvFrecuencias.Rows(2).Cells(8).Value + dgvFrecuencias.Rows(3).Cells(7).Value
            dgvFrecuencias.Rows(4).Cells(8).Value = dgvFrecuencias.Rows(3).Cells(8).Value + dgvFrecuencias.Rows(4).Cells(7).Value
        End If

        If intervalos = 10 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(2).Value)) * (dgvFrecuencias.Rows(0).Cells(1).Value - dgvFrecuencias.Rows(0).Cells(0).Value)
            dgvFrecuencias.Rows(1).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(2).Value)) * (dgvFrecuencias.Rows(1).Cells(1).Value - dgvFrecuencias.Rows(1).Cells(0).Value)
            dgvFrecuencias.Rows(2).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(2).Value)) * (dgvFrecuencias.Rows(2).Cells(1).Value - dgvFrecuencias.Rows(2).Cells(0).Value)
            dgvFrecuencias.Rows(3).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(2).Value)) * (dgvFrecuencias.Rows(3).Cells(1).Value - dgvFrecuencias.Rows(3).Cells(0).Value)
            dgvFrecuencias.Rows(4).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(2).Value)) * (dgvFrecuencias.Rows(4).Cells(1).Value - dgvFrecuencias.Rows(4).Cells(0).Value)
            dgvFrecuencias.Rows(5).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(5).Cells(2).Value)) * (dgvFrecuencias.Rows(5).Cells(1).Value - dgvFrecuencias.Rows(5).Cells(0).Value)
            dgvFrecuencias.Rows(6).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(6).Cells(2).Value)) * (dgvFrecuencias.Rows(6).Cells(1).Value - dgvFrecuencias.Rows(6).Cells(0).Value)
            dgvFrecuencias.Rows(7).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(7).Cells(2).Value)) * (dgvFrecuencias.Rows(7).Cells(1).Value - dgvFrecuencias.Rows(7).Cells(0).Value)
            dgvFrecuencias.Rows(8).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(8).Cells(2).Value)) * (dgvFrecuencias.Rows(8).Cells(1).Value - dgvFrecuencias.Rows(8).Cells(0).Value)
            dgvFrecuencias.Rows(9).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(9).Cells(2).Value)) * (dgvFrecuencias.Rows(9).Cells(1).Value - dgvFrecuencias.Rows(9).Cells(0).Value)

            dgvFrecuencias.Rows(0).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(0).Value))
            dgvFrecuencias.Rows(1).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(0).Value))
            dgvFrecuencias.Rows(2).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(0).Value))
            dgvFrecuencias.Rows(3).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(0).Value))
            dgvFrecuencias.Rows(4).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(0).Value))
            dgvFrecuencias.Rows(5).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(5).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(5).Cells(0).Value))
            dgvFrecuencias.Rows(6).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(6).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(6).Cells(0).Value))
            dgvFrecuencias.Rows(7).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(7).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(7).Cells(0).Value))
            dgvFrecuencias.Rows(8).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(8).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(8).Cells(0).Value))
            dgvFrecuencias.Rows(9).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(9).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(9).Cells(0).Value))

            dgvFrecuencias.Rows(0).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(6).Value * muestra
            dgvFrecuencias.Rows(1).Cells(4).Value = dgvFrecuencias.Rows(1).Cells(6).Value * muestra
            dgvFrecuencias.Rows(2).Cells(4).Value = dgvFrecuencias.Rows(2).Cells(6).Value * muestra
            dgvFrecuencias.Rows(3).Cells(4).Value = dgvFrecuencias.Rows(3).Cells(6).Value * muestra
            dgvFrecuencias.Rows(4).Cells(4).Value = dgvFrecuencias.Rows(4).Cells(6).Value * muestra
            dgvFrecuencias.Rows(5).Cells(4).Value = dgvFrecuencias.Rows(5).Cells(6).Value * muestra
            dgvFrecuencias.Rows(6).Cells(4).Value = dgvFrecuencias.Rows(6).Cells(6).Value * muestra
            dgvFrecuencias.Rows(7).Cells(4).Value = dgvFrecuencias.Rows(7).Cells(6).Value * muestra
            dgvFrecuencias.Rows(8).Cells(4).Value = dgvFrecuencias.Rows(8).Cells(6).Value * muestra

            dgvFrecuencias.Rows(0).Cells(7).Value = ((((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value)))
            dgvFrecuencias.Rows(1).Cells(7).Value = ((((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value)))
            dgvFrecuencias.Rows(2).Cells(7).Value = ((((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value)))
            dgvFrecuencias.Rows(3).Cells(7).Value = ((((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value)))
            dgvFrecuencias.Rows(4).Cells(7).Value = ((((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value)))
            dgvFrecuencias.Rows(5).Cells(7).Value = ((((dgvFrecuencias.Rows(5).Cells(3).Value - dgvFrecuencias.Rows(5).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(5).Cells(4).Value)))
            dgvFrecuencias.Rows(6).Cells(7).Value = ((((dgvFrecuencias.Rows(6).Cells(3).Value - dgvFrecuencias.Rows(6).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(6).Cells(4).Value)))
            dgvFrecuencias.Rows(7).Cells(7).Value = ((((dgvFrecuencias.Rows(7).Cells(3).Value - dgvFrecuencias.Rows(7).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(7).Cells(4).Value)))
            dgvFrecuencias.Rows(8).Cells(7).Value = ((((dgvFrecuencias.Rows(8).Cells(3).Value - dgvFrecuencias.Rows(8).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(8).Cells(4).Value)))
            dgvFrecuencias.Rows(9).Cells(7).Value = ((((dgvFrecuencias.Rows(9).Cells(3).Value - dgvFrecuencias.Rows(9).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(9).Cells(4).Value)))

            For Each Fila As DataGridViewRow In dgvFrecuencias.Rows
                If Fila.Cells(4).Value = 0 Then
                    Fila.Cells(7).Value = 0
                End If
            Next

            dgvFrecuencias.Rows(0).Cells(8).Value = dgvFrecuencias.Rows(0).Cells(7).Value
            dgvFrecuencias.Rows(1).Cells(8).Value = dgvFrecuencias.Rows(0).Cells(8).Value + dgvFrecuencias.Rows(1).Cells(7).Value
            dgvFrecuencias.Rows(2).Cells(8).Value = dgvFrecuencias.Rows(1).Cells(8).Value + dgvFrecuencias.Rows(2).Cells(7).Value
            dgvFrecuencias.Rows(3).Cells(8).Value = dgvFrecuencias.Rows(2).Cells(8).Value + dgvFrecuencias.Rows(3).Cells(7).Value
            dgvFrecuencias.Rows(4).Cells(8).Value = dgvFrecuencias.Rows(3).Cells(8).Value + dgvFrecuencias.Rows(4).Cells(7).Value
            dgvFrecuencias.Rows(5).Cells(8).Value = dgvFrecuencias.Rows(4).Cells(8).Value + dgvFrecuencias.Rows(5).Cells(7).Value
            dgvFrecuencias.Rows(6).Cells(8).Value = dgvFrecuencias.Rows(5).Cells(8).Value + dgvFrecuencias.Rows(6).Cells(7).Value
            dgvFrecuencias.Rows(7).Cells(8).Value = dgvFrecuencias.Rows(6).Cells(8).Value + dgvFrecuencias.Rows(7).Cells(7).Value
            dgvFrecuencias.Rows(8).Cells(8).Value = dgvFrecuencias.Rows(7).Cells(8).Value + dgvFrecuencias.Rows(8).Cells(7).Value
            dgvFrecuencias.Rows(9).Cells(8).Value = dgvFrecuencias.Rows(8).Cells(8).Value + dgvFrecuencias.Rows(9).Cells(7).Value
        End If

        If intervalos = 15 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(2).Value)) * (dgvFrecuencias.Rows(0).Cells(1).Value - dgvFrecuencias.Rows(0).Cells(0).Value)
            dgvFrecuencias.Rows(1).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(2).Value)) * (dgvFrecuencias.Rows(1).Cells(1).Value - dgvFrecuencias.Rows(1).Cells(0).Value)
            dgvFrecuencias.Rows(2).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(2).Value)) * (dgvFrecuencias.Rows(2).Cells(1).Value - dgvFrecuencias.Rows(2).Cells(0).Value)
            dgvFrecuencias.Rows(3).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(2).Value)) * (dgvFrecuencias.Rows(3).Cells(1).Value - dgvFrecuencias.Rows(3).Cells(0).Value)
            dgvFrecuencias.Rows(4).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(2).Value)) * (dgvFrecuencias.Rows(4).Cells(1).Value - dgvFrecuencias.Rows(4).Cells(0).Value)
            dgvFrecuencias.Rows(5).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(5).Cells(2).Value)) * (dgvFrecuencias.Rows(5).Cells(1).Value - dgvFrecuencias.Rows(5).Cells(0).Value)
            dgvFrecuencias.Rows(6).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(6).Cells(2).Value)) * (dgvFrecuencias.Rows(6).Cells(1).Value - dgvFrecuencias.Rows(6).Cells(0).Value)
            dgvFrecuencias.Rows(7).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(7).Cells(2).Value)) * (dgvFrecuencias.Rows(7).Cells(1).Value - dgvFrecuencias.Rows(7).Cells(0).Value)
            dgvFrecuencias.Rows(8).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(8).Cells(2).Value)) * (dgvFrecuencias.Rows(8).Cells(1).Value - dgvFrecuencias.Rows(8).Cells(0).Value)
            dgvFrecuencias.Rows(9).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(9).Cells(2).Value)) * (dgvFrecuencias.Rows(9).Cells(1).Value - dgvFrecuencias.Rows(9).Cells(0).Value)
            dgvFrecuencias.Rows(10).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(10).Cells(2).Value)) * (dgvFrecuencias.Rows(10).Cells(1).Value - dgvFrecuencias.Rows(10).Cells(0).Value)
            dgvFrecuencias.Rows(11).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(11).Cells(2).Value)) * (dgvFrecuencias.Rows(11).Cells(1).Value - dgvFrecuencias.Rows(11).Cells(0).Value)
            dgvFrecuencias.Rows(12).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(12).Cells(2).Value)) * (dgvFrecuencias.Rows(12).Cells(1).Value - dgvFrecuencias.Rows(12).Cells(0).Value)
            dgvFrecuencias.Rows(13).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(13).Cells(2).Value)) * (dgvFrecuencias.Rows(13).Cells(1).Value - dgvFrecuencias.Rows(13).Cells(0).Value)
            dgvFrecuencias.Rows(14).Cells(5).Value = (lambda * Math.Exp(-lambda * dgvFrecuencias.Rows(14).Cells(2).Value)) * (dgvFrecuencias.Rows(14).Cells(1).Value - dgvFrecuencias.Rows(14).Cells(0).Value)

            dgvFrecuencias.Rows(0).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(0).Cells(0).Value))
            dgvFrecuencias.Rows(1).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(1).Cells(0).Value))
            dgvFrecuencias.Rows(2).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(2).Cells(0).Value))
            dgvFrecuencias.Rows(3).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(3).Cells(0).Value))
            dgvFrecuencias.Rows(4).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(4).Cells(0).Value))
            dgvFrecuencias.Rows(5).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(5).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(5).Cells(0).Value))
            dgvFrecuencias.Rows(6).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(6).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(6).Cells(0).Value))
            dgvFrecuencias.Rows(7).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(7).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(7).Cells(0).Value))
            dgvFrecuencias.Rows(8).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(8).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(8).Cells(0).Value))
            dgvFrecuencias.Rows(9).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(9).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(9).Cells(0).Value))
            dgvFrecuencias.Rows(10).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(10).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(10).Cells(0).Value))
            dgvFrecuencias.Rows(11).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(11).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(11).Cells(0).Value))
            dgvFrecuencias.Rows(12).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(12).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(12).Cells(0).Value))
            dgvFrecuencias.Rows(13).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(13).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(13).Cells(0).Value))
            dgvFrecuencias.Rows(14).Cells(6).Value = (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(14).Cells(1).Value)) - (1 - Math.Exp(-lambda * dgvFrecuencias.Rows(14).Cells(0).Value))

            dgvFrecuencias.Rows(0).Cells(4).Value = dgvFrecuencias.Rows(0).Cells(6).Value * muestra
            dgvFrecuencias.Rows(1).Cells(4).Value = dgvFrecuencias.Rows(1).Cells(6).Value * muestra
            dgvFrecuencias.Rows(2).Cells(4).Value = dgvFrecuencias.Rows(2).Cells(6).Value * muestra
            dgvFrecuencias.Rows(3).Cells(4).Value = dgvFrecuencias.Rows(3).Cells(6).Value * muestra
            dgvFrecuencias.Rows(4).Cells(4).Value = dgvFrecuencias.Rows(4).Cells(6).Value * muestra
            dgvFrecuencias.Rows(5).Cells(4).Value = dgvFrecuencias.Rows(5).Cells(6).Value * muestra
            dgvFrecuencias.Rows(6).Cells(4).Value = dgvFrecuencias.Rows(6).Cells(6).Value * muestra
            dgvFrecuencias.Rows(7).Cells(4).Value = dgvFrecuencias.Rows(7).Cells(6).Value * muestra
            dgvFrecuencias.Rows(8).Cells(4).Value = dgvFrecuencias.Rows(8).Cells(6).Value * muestra
            dgvFrecuencias.Rows(9).Cells(4).Value = dgvFrecuencias.Rows(9).Cells(6).Value * muestra
            dgvFrecuencias.Rows(10).Cells(4).Value = dgvFrecuencias.Rows(10).Cells(6).Value * muestra
            dgvFrecuencias.Rows(11).Cells(4).Value = dgvFrecuencias.Rows(11).Cells(6).Value * muestra
            dgvFrecuencias.Rows(12).Cells(4).Value = dgvFrecuencias.Rows(12).Cells(6).Value * muestra
            dgvFrecuencias.Rows(13).Cells(4).Value = dgvFrecuencias.Rows(13).Cells(6).Value * muestra
            dgvFrecuencias.Rows(14).Cells(4).Value = dgvFrecuencias.Rows(14).Cells(6).Value * muestra

            dgvFrecuencias.Rows(0).Cells(7).Value = ((((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value)))
            dgvFrecuencias.Rows(1).Cells(7).Value = ((((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value)))
            dgvFrecuencias.Rows(2).Cells(7).Value = ((((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value)))
            dgvFrecuencias.Rows(3).Cells(7).Value = ((((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value)))
            dgvFrecuencias.Rows(4).Cells(7).Value = ((((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value)))
            dgvFrecuencias.Rows(5).Cells(7).Value = ((((dgvFrecuencias.Rows(5).Cells(3).Value - dgvFrecuencias.Rows(5).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(5).Cells(4).Value)))
            dgvFrecuencias.Rows(6).Cells(7).Value = ((((dgvFrecuencias.Rows(6).Cells(3).Value - dgvFrecuencias.Rows(6).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(6).Cells(4).Value)))
            dgvFrecuencias.Rows(7).Cells(7).Value = ((((dgvFrecuencias.Rows(7).Cells(3).Value - dgvFrecuencias.Rows(7).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(7).Cells(4).Value)))
            dgvFrecuencias.Rows(8).Cells(7).Value = ((((dgvFrecuencias.Rows(8).Cells(3).Value - dgvFrecuencias.Rows(8).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(8).Cells(4).Value)))
            dgvFrecuencias.Rows(9).Cells(7).Value = ((((dgvFrecuencias.Rows(9).Cells(3).Value - dgvFrecuencias.Rows(9).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(9).Cells(4).Value)))
            dgvFrecuencias.Rows(10).Cells(7).Value = ((((dgvFrecuencias.Rows(10).Cells(3).Value - dgvFrecuencias.Rows(10).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(10).Cells(4).Value)))
            dgvFrecuencias.Rows(11).Cells(7).Value = ((((dgvFrecuencias.Rows(11).Cells(3).Value - dgvFrecuencias.Rows(11).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(11).Cells(4).Value)))
            dgvFrecuencias.Rows(12).Cells(7).Value = ((((dgvFrecuencias.Rows(12).Cells(3).Value - dgvFrecuencias.Rows(12).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(12).Cells(4).Value)))
            dgvFrecuencias.Rows(13).Cells(7).Value = ((((dgvFrecuencias.Rows(13).Cells(3).Value - dgvFrecuencias.Rows(13).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(13).Cells(4).Value)))
            dgvFrecuencias.Rows(14).Cells(7).Value = ((((dgvFrecuencias.Rows(14).Cells(3).Value - dgvFrecuencias.Rows(14).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(14).Cells(4).Value)))

            For Each Fila As DataGridViewRow In dgvFrecuencias.Rows
                If Fila.Cells(4).Value = 0 Then
                    Fila.Cells(7).Value = 0
                End If
            Next

            dgvFrecuencias.Rows(0).Cells(8).Value = dgvFrecuencias.Rows(0).Cells(7).Value
            dgvFrecuencias.Rows(1).Cells(8).Value = dgvFrecuencias.Rows(0).Cells(8).Value + dgvFrecuencias.Rows(1).Cells(7).Value
            dgvFrecuencias.Rows(2).Cells(8).Value = dgvFrecuencias.Rows(1).Cells(8).Value + dgvFrecuencias.Rows(2).Cells(7).Value
            dgvFrecuencias.Rows(3).Cells(8).Value = dgvFrecuencias.Rows(2).Cells(8).Value + dgvFrecuencias.Rows(3).Cells(7).Value
            dgvFrecuencias.Rows(4).Cells(8).Value = dgvFrecuencias.Rows(3).Cells(8).Value + dgvFrecuencias.Rows(4).Cells(7).Value
            dgvFrecuencias.Rows(5).Cells(8).Value = dgvFrecuencias.Rows(4).Cells(8).Value + dgvFrecuencias.Rows(5).Cells(7).Value
            dgvFrecuencias.Rows(6).Cells(8).Value = dgvFrecuencias.Rows(5).Cells(8).Value + dgvFrecuencias.Rows(6).Cells(7).Value
            dgvFrecuencias.Rows(7).Cells(8).Value = dgvFrecuencias.Rows(6).Cells(8).Value + dgvFrecuencias.Rows(7).Cells(7).Value
            dgvFrecuencias.Rows(8).Cells(8).Value = dgvFrecuencias.Rows(7).Cells(8).Value + dgvFrecuencias.Rows(8).Cells(7).Value
            dgvFrecuencias.Rows(9).Cells(8).Value = dgvFrecuencias.Rows(8).Cells(8).Value + dgvFrecuencias.Rows(9).Cells(7).Value
            dgvFrecuencias.Rows(10).Cells(8).Value = dgvFrecuencias.Rows(9).Cells(8).Value + dgvFrecuencias.Rows(10).Cells(7).Value
            dgvFrecuencias.Rows(11).Cells(8).Value = dgvFrecuencias.Rows(10).Cells(8).Value + dgvFrecuencias.Rows(11).Cells(7).Value
            dgvFrecuencias.Rows(12).Cells(8).Value = dgvFrecuencias.Rows(11).Cells(8).Value + dgvFrecuencias.Rows(12).Cells(7).Value
            dgvFrecuencias.Rows(13).Cells(8).Value = dgvFrecuencias.Rows(12).Cells(8).Value + dgvFrecuencias.Rows(13).Cells(7).Value
            dgvFrecuencias.Rows(14).Cells(8).Value = dgvFrecuencias.Rows(13).Cells(8).Value + dgvFrecuencias.Rows(14).Cells(7).Value
        End If
    End Sub

End Class