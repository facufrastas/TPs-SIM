Public Class FormUniforme

    Private Sub FormUniforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If IsNumeric(txtA.Text) And IsNumeric(txtB.Text) Then
                If txtB.Text > txtA.Text Then
                    dgvResultados.Rows.Clear()
                    generar()
                Else
                    MessageBox.Show("¡El valor de B tiene que ser mayor que el valor de A!")
                End If

            Else
            MessageBox.Show("Valores No Válidos.")
        End If
    End Sub

    Private Sub generar()
        Dim a As New Integer
        a = CInt(txtA.Text)
        Dim b As New Integer
        b = CInt(txtB.Text)
        Dim n As New Integer
        n = CInt(txtN.Text)
        Dim random As New Random()
        Dim numero As New Double
        Dim num As New Double

        dgvResultados.Columns(1).DefaultCellStyle.Format = "N2"

        For i = 1 To n

            numero = random.Next(0, 999999)
            numero = numero / 1000000
            num = a + (numero * (b - a))

            Me.dgvResultados.Rows.Add(i, num)
        Next
    End Sub

    Private Sub limpiar()
        dgvResultados.Rows.Clear()
        dgvFrecuencias.Rows.Clear()

        For Each series In histograma.Series
            series.Points.Clear()
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
        'histograma.ChartAreas(0).AxisX.Interval = 5
        'histograma.ChartAreas(0).AxisX.LabelStyle.Angle = -90
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
        Dim i As New Integer

        If cmbIntervalos.SelectedIndex <> -1 Then
            Dim n As New Integer
            n = CInt(txtN.Text)
            Dim a As New Integer
            a = CInt(txtA.Text)
            Dim b As New Integer
            b = CInt(txtB.Text)
            Dim totalSumatoria As New Double
            Dim valorIntervalos As New Double

            dgvFrecuencias.Columns(0).DefaultCellStyle.Format = "N2"
            dgvFrecuencias.Columns(1).DefaultCellStyle.Format = "N2"
            dgvFrecuencias.Columns(2).DefaultCellStyle.Format = "N4"
            dgvFrecuencias.Columns(4).DefaultCellStyle.Format = "N2"
            dgvFrecuencias.Columns(5).DefaultCellStyle.Format = "N4"
            dgvFrecuencias.Columns(6).DefaultCellStyle.Format = "N4"

            If intervalos = 5 Then
                valorIntervalos = (b - a) / 5

                Me.dgvFrecuencias.Rows.Add((a), (a + valorIntervalos), (a + (a + valorIntervalos)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + valorIntervalos), (a + (valorIntervalos * 2)), ((a + valorIntervalos) + (a + valorIntervalos * 2)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 2)), (a + (valorIntervalos * 3)), ((a + valorIntervalos * 2) + (a + valorIntervalos * 3)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 3)), (a + (valorIntervalos * 4)), ((a + valorIntervalos * 3) + (a + valorIntervalos * 4)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 4)), (a + (valorIntervalos * 5)), ((a + valorIntervalos * 4) + (a + valorIntervalos * 5)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
            End If

            If intervalos = 10 Then
                valorIntervalos = (b - a) / 10

                Me.dgvFrecuencias.Rows.Add((a), (a + valorIntervalos), (a + (a + valorIntervalos)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + valorIntervalos), (a + (valorIntervalos * 2)), ((a + valorIntervalos) + (a + valorIntervalos * 2)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 2)), (a + (valorIntervalos * 3)), ((a + valorIntervalos * 2) + (a + valorIntervalos * 3)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 3)), (a + (valorIntervalos * 4)), ((a + valorIntervalos * 3) + (a + valorIntervalos * 4)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 4)), (a + (valorIntervalos * 5)), ((a + valorIntervalos * 4) + (a + valorIntervalos * 5)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 5)), (a + (valorIntervalos * 6)), ((a + valorIntervalos * 5) + (a + valorIntervalos * 6)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 6)), (a + (valorIntervalos * 7)), ((a + valorIntervalos * 6) + (a + valorIntervalos * 7)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 7)), (a + (valorIntervalos * 8)), ((a + valorIntervalos * 7) + (a + valorIntervalos * 8)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 8)), (a + (valorIntervalos * 9)), ((a + valorIntervalos * 8) + (a + valorIntervalos * 9)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 9)), (a + (valorIntervalos * 10)), ((a + valorIntervalos * 9) + (a + valorIntervalos * 10)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
            End If

            If intervalos = 15 Then
                valorIntervalos = (b - a) / 15

                Me.dgvFrecuencias.Rows.Add((a), (a + valorIntervalos), (a + (a + valorIntervalos)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + valorIntervalos), (a + (valorIntervalos * 2)), ((a + valorIntervalos) + (a + valorIntervalos * 2)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 2)), (a + (valorIntervalos * 3)), ((a + valorIntervalos * 2) + (a + valorIntervalos * 3)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 3)), (a + (valorIntervalos * 4)), ((a + valorIntervalos * 3) + (a + valorIntervalos * 4)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 4)), (a + (valorIntervalos * 5)), ((a + valorIntervalos * 4) + (a + valorIntervalos * 5)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 5)), (a + (valorIntervalos * 6)), ((a + valorIntervalos * 5) + (a + valorIntervalos * 6)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 6)), (a + (valorIntervalos * 7)), ((a + valorIntervalos * 6) + (a + valorIntervalos * 7)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 7)), (a + (valorIntervalos * 8)), ((a + valorIntervalos * 7) + (a + valorIntervalos * 8)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 8)), (a + (valorIntervalos * 9)), ((a + valorIntervalos * 8) + (a + valorIntervalos * 9)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 9)), (a + (valorIntervalos * 10)), ((a + valorIntervalos * 9) + (a + valorIntervalos * 10)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 10)), (a + (valorIntervalos * 11)), ((a + valorIntervalos * 10) + (a + valorIntervalos * 11)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 11)), (a + (valorIntervalos * 12)), ((a + valorIntervalos * 11) + (a + valorIntervalos * 12)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 12)), (a + (valorIntervalos * 13)), ((a + valorIntervalos * 12) + (a + valorIntervalos * 13)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 13)), (a + (valorIntervalos * 14)), ((a + valorIntervalos * 13) + (a + valorIntervalos * 14)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
                Me.dgvFrecuencias.Rows.Add((a + (valorIntervalos * 14)), (a + (valorIntervalos * 15)), ((a + valorIntervalos * 14) + (a + valorIntervalos * 15)) / 2, 0, (Math.Round(n / intervalos)), 0, 0)
            End If

            For Each Fila As DataGridViewRow In dgvResultados.Rows
                If intervalos = 5 Then
                    valorIntervalos = (b - a) / 5
                    If (Fila.Cells(1).Value >= a Or Fila.Cells(1).Value < a) And Fila.Cells(1).Value < (a + valorIntervalos) Then
                        dgvFrecuencias.Rows(0).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + valorIntervalos) And Fila.Cells(1).Value < (a + (valorIntervalos * 2)) Then
                        dgvFrecuencias.Rows(1).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 2)) And Fila.Cells(1).Value < (a + (valorIntervalos * 3)) Then
                        dgvFrecuencias.Rows(2).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 3)) And Fila.Cells(1).Value < (a + (valorIntervalos * 4)) Then
                        dgvFrecuencias.Rows(3).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 4)) And Fila.Cells(1).Value <= (a + (valorIntervalos * 5)) Then
                        dgvFrecuencias.Rows(4).Cells(3).Value += 1
                    End If
                End If
            Next

            For Each Fila As DataGridViewRow In dgvResultados.Rows
                If intervalos = 10 Then
                    valorIntervalos = (b - a) / 10
                    If (Fila.Cells(1).Value >= a Or Fila.Cells(1).Value < a) And Fila.Cells(1).Value < (a + valorIntervalos) Then
                        dgvFrecuencias.Rows(0).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + valorIntervalos) And Fila.Cells(1).Value < (a + (valorIntervalos * 2)) Then
                        dgvFrecuencias.Rows(1).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 2)) And Fila.Cells(1).Value < (a + (valorIntervalos * 3)) Then
                        dgvFrecuencias.Rows(2).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 3)) And Fila.Cells(1).Value < (a + (valorIntervalos * 4)) Then
                        dgvFrecuencias.Rows(3).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 4)) And Fila.Cells(1).Value < (a + (valorIntervalos * 5)) Then
                        dgvFrecuencias.Rows(4).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 5)) And Fila.Cells(1).Value < (a + (valorIntervalos * 6)) Then
                        dgvFrecuencias.Rows(5).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 6)) And Fila.Cells(1).Value < (a + (valorIntervalos * 7)) Then
                        dgvFrecuencias.Rows(6).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 7)) And Fila.Cells(1).Value < (a + (valorIntervalos * 8)) Then
                        dgvFrecuencias.Rows(7).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 8)) And Fila.Cells(1).Value < (a + (valorIntervalos * 9)) Then
                        dgvFrecuencias.Rows(8).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 9)) And Fila.Cells(1).Value <= (a + (valorIntervalos * 10)) Then
                        dgvFrecuencias.Rows(9).Cells(3).Value += 1
                    End If
                End If
            Next

            For Each Fila As DataGridViewRow In dgvResultados.Rows
                If intervalos = 15 Then
                    valorIntervalos = (b - a) / 15
                    If (Fila.Cells(1).Value >= a Or Fila.Cells(1).Value < a) And Fila.Cells(1).Value < (a + valorIntervalos) Then
                        dgvFrecuencias.Rows(0).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + valorIntervalos) And Fila.Cells(1).Value < (a + (valorIntervalos * 2)) Then
                        dgvFrecuencias.Rows(1).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 2)) And Fila.Cells(1).Value < (a + (valorIntervalos * 3)) Then
                        dgvFrecuencias.Rows(2).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 3)) And Fila.Cells(1).Value < (a + (valorIntervalos * 4)) Then
                        dgvFrecuencias.Rows(3).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 4)) And Fila.Cells(1).Value < (a + (valorIntervalos * 5)) Then
                        dgvFrecuencias.Rows(4).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 5)) And Fila.Cells(1).Value < (a + (valorIntervalos * 6)) Then
                        dgvFrecuencias.Rows(5).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 6)) And Fila.Cells(1).Value < (a + (valorIntervalos * 7)) Then
                        dgvFrecuencias.Rows(6).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 7)) And Fila.Cells(1).Value < (a + (valorIntervalos * 8)) Then
                        dgvFrecuencias.Rows(7).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 8)) And Fila.Cells(1).Value < (a + (valorIntervalos * 9)) Then
                        dgvFrecuencias.Rows(8).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 9)) And Fila.Cells(1).Value < (a + (valorIntervalos * 10)) Then
                        dgvFrecuencias.Rows(9).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 10)) And Fila.Cells(1).Value < (a + (valorIntervalos * 11)) Then
                        dgvFrecuencias.Rows(10).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 11)) And Fila.Cells(1).Value < (a + (valorIntervalos * 12)) Then
                        dgvFrecuencias.Rows(11).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 12)) And Fila.Cells(1).Value < (a + (valorIntervalos * 13)) Then
                        dgvFrecuencias.Rows(12).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 13)) And Fila.Cells(1).Value < (a + (valorIntervalos * 14)) Then
                        dgvFrecuencias.Rows(13).Cells(3).Value += 1
                    End If
                    If Fila.Cells(1).Value >= (a + (valorIntervalos * 14)) And Fila.Cells(1).Value <= (a + (valorIntervalos * 15)) Then
                        dgvFrecuencias.Rows(14).Cells(3).Value += 1
                    End If
                End If
            Next
        Else
            MessageBox.Show("Seleccione un valor para la cantidad de intervalos.")
        End If

        If intervalos = 5 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value))
            dgvFrecuencias.Rows(1).Cells(5).Value = (((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value))
            dgvFrecuencias.Rows(2).Cells(5).Value = (((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value))
            dgvFrecuencias.Rows(3).Cells(5).Value = (((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value))
            dgvFrecuencias.Rows(4).Cells(5).Value = (((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value))

            dgvFrecuencias.Rows(0).Cells(6).Value = dgvFrecuencias.Rows(0).Cells(5).Value
            dgvFrecuencias.Rows(1).Cells(6).Value = dgvFrecuencias.Rows(0).Cells(6).Value + dgvFrecuencias.Rows(1).Cells(5).Value
            dgvFrecuencias.Rows(2).Cells(6).Value = dgvFrecuencias.Rows(1).Cells(6).Value + dgvFrecuencias.Rows(2).Cells(5).Value
            dgvFrecuencias.Rows(3).Cells(6).Value = dgvFrecuencias.Rows(2).Cells(6).Value + dgvFrecuencias.Rows(3).Cells(5).Value
            dgvFrecuencias.Rows(4).Cells(6).Value = dgvFrecuencias.Rows(3).Cells(6).Value + dgvFrecuencias.Rows(4).Cells(5).Value
        End If

        If intervalos = 10 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value))
            dgvFrecuencias.Rows(1).Cells(5).Value = (((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value))
            dgvFrecuencias.Rows(2).Cells(5).Value = (((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value))
            dgvFrecuencias.Rows(3).Cells(5).Value = (((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value))
            dgvFrecuencias.Rows(4).Cells(5).Value = (((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value))
            dgvFrecuencias.Rows(5).Cells(5).Value = (((dgvFrecuencias.Rows(5).Cells(3).Value - dgvFrecuencias.Rows(5).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(5).Cells(4).Value))
            dgvFrecuencias.Rows(6).Cells(5).Value = (((dgvFrecuencias.Rows(6).Cells(3).Value - dgvFrecuencias.Rows(6).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(6).Cells(4).Value))
            dgvFrecuencias.Rows(7).Cells(5).Value = (((dgvFrecuencias.Rows(7).Cells(3).Value - dgvFrecuencias.Rows(7).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(7).Cells(4).Value))
            dgvFrecuencias.Rows(8).Cells(5).Value = (((dgvFrecuencias.Rows(8).Cells(3).Value - dgvFrecuencias.Rows(8).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(8).Cells(4).Value))
            dgvFrecuencias.Rows(9).Cells(5).Value = (((dgvFrecuencias.Rows(9).Cells(3).Value - dgvFrecuencias.Rows(9).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(9).Cells(4).Value))

            dgvFrecuencias.Rows(0).Cells(6).Value = dgvFrecuencias.Rows(0).Cells(5).Value
            dgvFrecuencias.Rows(1).Cells(6).Value = dgvFrecuencias.Rows(0).Cells(6).Value + dgvFrecuencias.Rows(1).Cells(5).Value
            dgvFrecuencias.Rows(2).Cells(6).Value = dgvFrecuencias.Rows(1).Cells(6).Value + dgvFrecuencias.Rows(2).Cells(5).Value
            dgvFrecuencias.Rows(3).Cells(6).Value = dgvFrecuencias.Rows(2).Cells(6).Value + dgvFrecuencias.Rows(3).Cells(5).Value
            dgvFrecuencias.Rows(4).Cells(6).Value = dgvFrecuencias.Rows(3).Cells(6).Value + dgvFrecuencias.Rows(4).Cells(5).Value
            dgvFrecuencias.Rows(5).Cells(6).Value = dgvFrecuencias.Rows(4).Cells(6).Value + dgvFrecuencias.Rows(5).Cells(5).Value
            dgvFrecuencias.Rows(6).Cells(6).Value = dgvFrecuencias.Rows(5).Cells(6).Value + dgvFrecuencias.Rows(6).Cells(5).Value
            dgvFrecuencias.Rows(7).Cells(6).Value = dgvFrecuencias.Rows(6).Cells(6).Value + dgvFrecuencias.Rows(7).Cells(5).Value
            dgvFrecuencias.Rows(8).Cells(6).Value = dgvFrecuencias.Rows(7).Cells(6).Value + dgvFrecuencias.Rows(8).Cells(5).Value
            dgvFrecuencias.Rows(9).Cells(6).Value = dgvFrecuencias.Rows(8).Cells(6).Value + dgvFrecuencias.Rows(9).Cells(5).Value
        End If

        If intervalos = 15 Then
            dgvFrecuencias.Rows(0).Cells(5).Value = (((dgvFrecuencias.Rows(0).Cells(3).Value - dgvFrecuencias.Rows(0).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(0).Cells(4).Value))
            dgvFrecuencias.Rows(1).Cells(5).Value = (((dgvFrecuencias.Rows(1).Cells(3).Value - dgvFrecuencias.Rows(1).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(1).Cells(4).Value))
            dgvFrecuencias.Rows(2).Cells(5).Value = (((dgvFrecuencias.Rows(2).Cells(3).Value - dgvFrecuencias.Rows(2).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(2).Cells(4).Value))
            dgvFrecuencias.Rows(3).Cells(5).Value = (((dgvFrecuencias.Rows(3).Cells(3).Value - dgvFrecuencias.Rows(3).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(3).Cells(4).Value))
            dgvFrecuencias.Rows(4).Cells(5).Value = (((dgvFrecuencias.Rows(4).Cells(3).Value - dgvFrecuencias.Rows(4).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(4).Cells(4).Value))
            dgvFrecuencias.Rows(5).Cells(5).Value = (((dgvFrecuencias.Rows(5).Cells(3).Value - dgvFrecuencias.Rows(5).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(5).Cells(4).Value))
            dgvFrecuencias.Rows(6).Cells(5).Value = (((dgvFrecuencias.Rows(6).Cells(3).Value - dgvFrecuencias.Rows(6).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(6).Cells(4).Value))
            dgvFrecuencias.Rows(7).Cells(5).Value = (((dgvFrecuencias.Rows(7).Cells(3).Value - dgvFrecuencias.Rows(7).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(7).Cells(4).Value))
            dgvFrecuencias.Rows(8).Cells(5).Value = (((dgvFrecuencias.Rows(8).Cells(3).Value - dgvFrecuencias.Rows(8).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(8).Cells(4).Value))
            dgvFrecuencias.Rows(9).Cells(5).Value = (((dgvFrecuencias.Rows(9).Cells(3).Value - dgvFrecuencias.Rows(9).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(9).Cells(4).Value))
            dgvFrecuencias.Rows(10).Cells(5).Value = (((dgvFrecuencias.Rows(10).Cells(3).Value - dgvFrecuencias.Rows(10).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(10).Cells(4).Value))
            dgvFrecuencias.Rows(11).Cells(5).Value = (((dgvFrecuencias.Rows(11).Cells(3).Value - dgvFrecuencias.Rows(11).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(11).Cells(4).Value))
            dgvFrecuencias.Rows(12).Cells(5).Value = (((dgvFrecuencias.Rows(12).Cells(3).Value - dgvFrecuencias.Rows(12).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(12).Cells(4).Value))
            dgvFrecuencias.Rows(13).Cells(5).Value = (((dgvFrecuencias.Rows(13).Cells(3).Value - dgvFrecuencias.Rows(13).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(13).Cells(4).Value))
            dgvFrecuencias.Rows(14).Cells(5).Value = (((dgvFrecuencias.Rows(14).Cells(3).Value - dgvFrecuencias.Rows(14).Cells(4).Value) ^ 2) / (dgvFrecuencias.Rows(14).Cells(4).Value))

            dgvFrecuencias.Rows(0).Cells(6).Value = dgvFrecuencias.Rows(0).Cells(5).Value
            dgvFrecuencias.Rows(1).Cells(6).Value = dgvFrecuencias.Rows(0).Cells(6).Value + dgvFrecuencias.Rows(1).Cells(5).Value
            dgvFrecuencias.Rows(2).Cells(6).Value = dgvFrecuencias.Rows(1).Cells(6).Value + dgvFrecuencias.Rows(2).Cells(5).Value
            dgvFrecuencias.Rows(3).Cells(6).Value = dgvFrecuencias.Rows(2).Cells(6).Value + dgvFrecuencias.Rows(3).Cells(5).Value
            dgvFrecuencias.Rows(4).Cells(6).Value = dgvFrecuencias.Rows(3).Cells(6).Value + dgvFrecuencias.Rows(4).Cells(5).Value
            dgvFrecuencias.Rows(5).Cells(6).Value = dgvFrecuencias.Rows(4).Cells(6).Value + dgvFrecuencias.Rows(5).Cells(5).Value
            dgvFrecuencias.Rows(6).Cells(6).Value = dgvFrecuencias.Rows(5).Cells(6).Value + dgvFrecuencias.Rows(6).Cells(5).Value
            dgvFrecuencias.Rows(7).Cells(6).Value = dgvFrecuencias.Rows(6).Cells(6).Value + dgvFrecuencias.Rows(7).Cells(5).Value
            dgvFrecuencias.Rows(8).Cells(6).Value = dgvFrecuencias.Rows(7).Cells(6).Value + dgvFrecuencias.Rows(8).Cells(5).Value
            dgvFrecuencias.Rows(9).Cells(6).Value = dgvFrecuencias.Rows(8).Cells(6).Value + dgvFrecuencias.Rows(9).Cells(5).Value
            dgvFrecuencias.Rows(10).Cells(6).Value = dgvFrecuencias.Rows(9).Cells(6).Value + dgvFrecuencias.Rows(10).Cells(5).Value
            dgvFrecuencias.Rows(11).Cells(6).Value = dgvFrecuencias.Rows(10).Cells(6).Value + dgvFrecuencias.Rows(11).Cells(5).Value
            dgvFrecuencias.Rows(12).Cells(6).Value = dgvFrecuencias.Rows(11).Cells(6).Value + dgvFrecuencias.Rows(12).Cells(5).Value
            dgvFrecuencias.Rows(13).Cells(6).Value = dgvFrecuencias.Rows(12).Cells(6).Value + dgvFrecuencias.Rows(13).Cells(5).Value
            dgvFrecuencias.Rows(14).Cells(6).Value = dgvFrecuencias.Rows(13).Cells(6).Value + dgvFrecuencias.Rows(14).Cells(5).Value
        End If
    End Sub

End Class