Imports System.Globalization

Public Class Form1

    Private Sub btnTipos_Click(sender As Object, e As EventArgs) Handles btnTipos.Click
        If IsNumeric(txtTipo1.Text) And IsNumeric(txtTipo2.Text) And IsNumeric(txtTipo3.Text) And IsNumeric(txtTipo4.Text) And IsNumeric(txtTipo5.Text) Then
            If txtTipo1.Text > 0 And txtTipo2.Text > 0 And txtTipo3.Text > 0 Then
                Dim n1 As New Double
                n1 = txtTipo1.Text
                Dim n2 As New Double
                n2 = txtTipo2.Text
                Dim n3 As New Double
                n3 = txtTipo3.Text
                Dim n4 As New Double
                n4 = txtTipo4.Text
                Dim n5 As New Double
                n5 = txtTipo5.Text

                If n1 > 1 And n1 < 100 Then
                    n1 = n1 / 100
                End If

                If n2 > 1 And n2 < 100 Then
                    n2 = n2 / 100
                End If

                If n3 > 1 And n3 < 100 Then
                    n3 = n3 / 100
                End If

                If n4 > 1 And n4 < 100 Then
                    n4 = n4 / 100
                End If

                If n5 > 1 And n5 < 100 Then
                    n5 = n5 / 100
                End If

                If (n1 + n2 + n3 + n4 + n5) = 100 Or (n1 + n2 + n3 + n4 + n5) = 1 Then
                    generarTipos()
                Else
                    MessageBox.Show("Las probabilidades deben sumar 100 o 1 (valores decimales) entre todas.")
                End If
            Else
                MessageBox.Show("Los valores deben ser positivos.")
            End If
        Else
            MessageBox.Show("Valores No Válidos.")
        End If
    End Sub

    Private Sub btnTiemposCostos_Click(sender As Object, e As EventArgs) Handles btnTiemposCostos.Click
        If (IsNumeric(txtTiempo1.Text) And IsNumeric(txtTiempo2.Text) And IsNumeric(txtTiempo3.Text) And IsNumeric(txtTiempo4.Text) And IsNumeric(txtTiempo5.Text) And IsNumeric(txtTiempo6.Text) And IsNumeric(txtTiempo7.Text) And IsNumeric(txtTiempo8.Text) And IsNumeric(txtTiempo9.Text)) And IsNumeric(txtTiempo10.Text) And txtTiempo1.Text > 0 And txtTiempo2.Text > 0 And txtTiempo3.Text > 0 And txtTiempo4.Text > 0 And txtTiempo5.Text > 0 And txtTiempo6.Text > 0 And txtTiempo7.Text > 0 And txtTiempo8.Text > 0 And txtTiempo9.Text > 0 And txtTiempo10.Text > 0 Then
            Dim n1 As New Double
            n1 = txtTiempo1.Text
            Dim n2 As New Double
            n2 = txtTiempo2.Text
            Dim n3 As New Double
            n3 = txtTiempo3.Text
            Dim n4 As New Double
            n4 = txtTiempo4.Text
            Dim n5 As New Double
            n5 = txtTiempo5.Text
            Dim n6 As New Double
            n6 = txtTiempo6.Text
            Dim n7 As New Double
            n7 = txtTiempo7.Text
            Dim n8 As New Double
            n8 = txtTiempo8.Text
            Dim n9 As New Double
            n9 = txtTiempo9.Text
            Dim n10 As New Double
            n10 = txtTiempo10.Text
            Dim c1 As New Double
            c1 = txtCosto1.Text
            Dim c2 As New Double
            c2 = txtCosto2.Text
            Dim c3 As New Double
            c3 = txtCosto3.Text
            Dim c4 As New Double
            c4 = txtCosto4.Text
            Dim c5 As New Double
            c5 = txtCosto5.Text

            If n1 <= n2 And n3 <= n4 And n5 <= n6 And n7 <= n8 And n9 <= n10 Then
                generarDatos()
            Else
                MessageBox.Show("El valor Hasta de los tipos deben ser MAYOR al de Desde del tiempo correspondiente.")
            End If

        End If
    End Sub

    Public Sub generarTipos()
        Dim prob1 As New Double
        prob1 = txtTipo1.Text
        Dim prob2 As New Double
        prob2 = txtTipo2.Text
        Dim prob3 As New Double
        prob3 = txtTipo3.Text
        Dim prob4 As New Double
        prob4 = txtTipo4.Text
        Dim prob5 As New Double
        prob5 = txtTipo5.Text

        If prob1 > 1 And prob2 > 1 And prob3 > 1 And prob4 > 1 And prob5 > 1 Then
            prob1 = prob1 / 100
            prob2 = prob2 / 100
            prob3 = prob3 / 100
            prob4 = prob4 / 100
            prob5 = prob5 / 100
        End If

        If dgvTipos.CurrentCell Is Nothing Then
            dgvTipos.Rows.Add("Tipo 1", prob1, prob1, 0, prob1 - 0.01)
            dgvTipos.Rows.Add("Tipo 2", prob2, prob1 + prob2, prob1, (prob1 + prob2) - 0.01)
            dgvTipos.Rows.Add("Tipo 3", prob3, prob1 + prob2 + prob3, (prob1 + prob2), (prob1 + prob2 + prob3) - 0.01)
            dgvTipos.Rows.Add("Tipo 4", prob4, prob1 + prob2 + prob3 + prob4, (prob1 + prob2 + prob3), (prob1 + prob2 + prob3 + prob4) - 0.01)
            dgvTipos.Rows.Add("Tipo 5", prob5, prob1 + prob2 + prob3 + prob4 + prob5, (prob1 + prob2 + prob3 + prob4), (prob1 + prob2 + prob3 + prob4 + prob5) - 0.01)
        End If
    End Sub

    Public Sub generarDatos()
        Dim n1 As New Double
        n1 = txtTiempo1.Text / 60
        Dim n2 As New Double
        n2 = txtTiempo2.Text / 60
        Dim n3 As New Double
        n3 = txtTiempo3.Text / 60
        Dim n4 As New Double
        n4 = txtTiempo4.Text / 60
        Dim n5 As New Double
        n5 = txtTiempo5.Text / 60
        Dim n6 As New Double
        n6 = txtTiempo6.Text / 60
        Dim n7 As New Double
        n7 = txtTiempo7.Text / 60
        Dim n8 As New Double
        n8 = txtTiempo8.Text / 60
        Dim n9 As New Double
        n9 = txtTiempo9.Text / 60
        Dim n10 As New Double
        n10 = txtTiempo10.Text / 60

        Dim c1 As New Double
        c1 = txtCosto1.Text
        Dim c2 As New Double
        c2 = txtCosto2.Text
        Dim c3 As New Double
        c3 = txtCosto3.Text
        Dim c4 As New Double
        c4 = txtCosto4.Text
        Dim c5 As New Double
        c5 = txtCosto5.Text

        dgvDatos.Rows.Add("Tipo 1", "U(" + Math.Round(n1, 2).ToString() + "';" + Math.Round(n2, 2).ToString() + "')", c1)
        dgvDatos.Rows.Add("Tipo 2", "U(" + Math.Round(n3, 2).ToString() + "';" + Math.Round(n4, 2).ToString() + "')", c2)
        dgvDatos.Rows.Add("Tipo 3", "U(" + Math.Round(n5, 2).ToString() + "';" + Math.Round(n6, 2).ToString() + "')", c3)
        dgvDatos.Rows.Add("Tipo 4", "U(" + Math.Round(n7, 2).ToString() + "';" + Math.Round(n8, 2).ToString() + "')", c4)
        dgvDatos.Rows.Add("Tipo 5", "U(" + Math.Round(n9, 2).ToString() + "';" + Math.Round(n10, 2).ToString() + "')", c5)
    End Sub

    Private Sub btnLimpiarGrilla1_Click(sender As Object, e As EventArgs) Handles btnLimpiarGrilla1.Click
        dgvTipos.Rows.Clear()
    End Sub

    Private Sub brnLimpiarGrilla2_Click(sender As Object, e As EventArgs) Handles brnLimpiarGrilla2.Click
        dgvDatos.Rows.Clear()
    End Sub

    Private Sub btnLimpiarGrilla3_Click(sender As Object, e As EventArgs) Handles btnLimpiarGrilla3.Click
        If Not dgvResultados.CurrentCell Is Nothing Then
            For r = (dgvResultados.ColumnCount) - 1 To 91 Step -1
                dgvResultados.Columns.RemoveAt(r)
            Next
            dgvResultados.Rows.Clear()
        End If
    End Sub

    Private Sub btnSimulacion_Click(sender As Object, e As EventArgs) Handles btnSimulacion.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-AR")
        dgvResultados.Rows.Clear()
        If Not (dgvTipos.CurrentCell Is Nothing) And Not (dgvDatos.CurrentCell Is Nothing) And txtHoras.Text <> "" And txtTipo1.Text <> "" And txtTipo2.Text <> "" And txtTipo3.Text <> "" And txtTipo4.Text <> "" And txtTipo5.Text <> "" And txtTiempo1.Text <> "" And txtTiempo2.Text <> "" And txtTiempo3.Text <> "" And txtTiempo4.Text <> "" And txtTiempo5.Text <> "" And txtTiempo6.Text <> "" And txtTiempo7.Text <> "" And txtTiempo8.Text <> "" And txtTiempo9.Text <> "" And txtTiempo10.Text <> "" And txtCosto1.Text <> "" And txtCosto2.Text <> "" And txtCosto3.Text <> "" And txtCosto4.Text <> "" And txtCosto5.Text <> "" And txtIndice.Text <> "" Then
            '    ''---------------------------------------------------------------Inicio datos hardcodeados---------------------------------------------------------------
            'txtTipo1.Text = 0.1
            'txtTipo2.Text = 0.5
            'txtTipo3.Text = 0.15
            'txtTipo4.Text = 0.15
            'txtTipo5.Text = 0.1

            ''Tiempo en segundos.
            'txtTiempo1.Text = 30
            'txtTiempo2.Text = 30
            'txtTiempo3.Text = 45
            'txtTiempo4.Text = 55
            'txtTiempo5.Text = 55
            'txtTiempo6.Text = 85
            'txtTiempo7.Text = 90
            'txtTiempo8.Text = 130
            'txtTiempo9.Text = 150
            'txtTiempo10.Text = 210

            'txtCosto1.Text = 0
            'txtCosto2.Text = 3
            'txtCosto3.Text = 6
            'txtCosto4.Text = 9
            'txtCosto5.Text = 12

            'generarTipos()
            'generarDatos()

            'txtHoras.Text = 10
            'txtHoras.Text = txtHoras.Text
            'txtIndice.Text = 1.2
            ''---------------------------------------------------------------Final datos hardcodeados---------------------------------------------------------------

            'Agragación de las columnas de los elementos clientes.
            For j = 0 To 49
                dgvResultados.Columns.Add("Column", "Tipo Auto")
                dgvResultados.Columns.Add("Column", "Hora Llegada")
                dgvResultados.Columns.Add("Column", "Hora Salida")
                dgvResultados.Columns.Add("Column", "Estado")
                dgvResultados.Columns.Add("Column", "Cabina")
            Next

            'Definición de la cantidad de decimales para las columnas.
            dgvResultados.Columns(1).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(2).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(3).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(4).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(5).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(6).DefaultCellStyle.Format = "N0"
            dgvResultados.Columns(7).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(8).DefaultCellStyle.Format = "C2"
            dgvResultados.Columns(109).DefaultCellStyle.Format = "N0"
            dgvResultados.Columns(110).DefaultCellStyle.Format = "C2"
            dgvResultados.Columns(111).DefaultCellStyle.Format = "N0"

            'Formato de 2 decimales para la hora de llegada de cada auto en cada cabina.
            For j = 9 To 108 Step 2
                dgvResultados.Columns(j).DefaultCellStyle.Format = "N2"
            Next

            'Formato de 2 decimales para la hora de llegada de cada auto.
            For j = 113 To (dgvResultados.ColumnCount - 1) Step 5
                dgvResultados.Columns(j).DefaultCellStyle.Format = "N2"
            Next

            'Formato de 2 decimales para la hora de salida de cada auto.
            For j = 114 To (dgvResultados.ColumnCount - 2) Step 5
                dgvResultados.Columns(j).DefaultCellStyle.Format = "N2"
            Next

            'Formato de 0 decimales para la cabina del auto
            For j = 116 To (dgvResultados.ColumnCount - 1) Step 5
                dgvResultados.Columns(j).DefaultCellStyle.Format = "N0"
            Next

            'Definción de variables para ubicar a los valores de las grillas.
            Dim probabilidadTipo1 As New Double
            probabilidadTipo1 = txtTipo1.Text
            Dim probabilidadTipo2 As New Double
            probabilidadTipo1 = txtTipo2.Text
            Dim probabilidadTipo3 As New Double
            probabilidadTipo1 = txtTipo3.Text
            Dim probabilidadTipo4 As New Double
            probabilidadTipo1 = txtTipo4.Text
            Dim probabilidadTipo5 As New Double
            probabilidadTipo1 = txtTipo5.Text

            Dim tiempo1 As New Double
            tiempo1 = txtTiempo1.Text
            Dim tiempo2 As New Double
            tiempo2 = txtTiempo2.Text
            Dim tiempo3 As New Double
            tiempo3 = txtTiempo3.Text
            Dim tiempo4 As New Double
            tiempo4 = txtTiempo4.Text
            Dim tiempo5 As New Double
            tiempo5 = txtTiempo5.Text
            Dim tiempo6 As New Double
            tiempo6 = txtTiempo6.Text
            Dim tiempo7 As New Double
            tiempo7 = txtTiempo7.Text
            Dim tiempo8 As New Double
            tiempo8 = txtTiempo8.Text
            Dim tiempo9 As New Double
            tiempo9 = txtTiempo9.Text
            Dim tiempo10 As New Double
            tiempo10 = txtTiempo10.Text

            Dim costo1 As New Double
            costo1 = txtCosto1.Text
            Dim costo2 As New Double
            costo2 = txtCosto2.Text
            Dim costo3 As New Double
            costo3 = txtCosto3.Text
            Dim costo4 As New Double
            costo4 = txtCosto4.Text
            Dim costo5 As New Double
            costo5 = txtCosto5.Text

            'Definición de variables
            Dim horas As New Double
            horas = txtHoras.Text
            horas = horas * 60
            Dim indice As New Double
            indice = txtIndice.Text

            Dim minimo As New Double
            Dim cantidadCabinasHabilitadas As New Integer

            Dim evento As String
            Dim evento_1 As String
            Dim evento_2 As String
            Dim reloj As New Double

            Dim random As New Random
            Dim aleatorioTipo As New Double
            Dim aleatorioTiempo As New Double
            Dim tiempoLlegada As New Double
            Dim proximaLlegada As New Double
            Dim tipoVehiculo As New Integer
            Dim tiempoAtencion As New Double
            Dim monto As New Double
            Dim cantCabinasHabilitadas As New Integer
            Dim acRecaudacion As New Double
            Dim cola As New Integer
            cola = 0
            Dim cantAutos As New Integer
            cantAutos = 0
            Dim tipoAuto(49) As String
            Dim horaLlegadaAuto(49) As Double
            Dim horaSalidaAuto(49) As Double
            Dim estadoCabina(49) As String
            Dim cabinaAuto(49) As Integer
            Dim cabina(49) As Double
            Dim estado(49) As String
            Dim cabinaAutoRecienLlegado As New Integer
            Dim totalCabinasPromedio As New Double
            Dim promedioCabinas As New Double
            Dim maximaCantidadCabinas As New Integer
            maximaCantidadCabinas = 0
            Dim promPorCabina(50) As Integer
            Dim minimoColoreado As New Integer
            Dim columnaEvento As String = ""
            Dim columnaMinimo As Double = 0

            For j = 0 To 49
                promPorCabina(j) = 0
            Next

            'Blanquea los elementos servidores.
            For j = 0 To 49
                cabina(j) = Nothing
                tipoAuto(j) = Nothing
                horaLlegadaAuto(j) = Nothing
                estadoCabina(j) = Nothing
                cabinaAuto(j) = Nothing
            Next

            'Primera fila.
            evento = "Inicialización"
            evento_1 = evento
            evento_2 = evento
            reloj = 0.00
            cola = 0
            cantCabinasHabilitadas = 2
            acRecaudacion = 0
            aleatorioTipo = random.Next(1, 999)
            aleatorioTipo = aleatorioTipo / 1000

            'Definición del Tiempo entre Llegadas y de la Próxima Llegada.
            tiempoLlegada = -(indice) * Math.Log(1 - aleatorioTipo)
            proximaLlegada = tiempoLlegada + reloj
            tiempoAtencion = Nothing

            'Agrega la primera fila.
            dgvResultados.Rows.Add(evento, reloj, aleatorioTipo, tiempoLlegada, proximaLlegada, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre",
                                                   Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre",
                                                   Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre",
                                                   Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre",
                                                   Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", Nothing, "Libre", cantCabinasHabilitadas, acRecaudacion, cola,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing,
                                                   Nothing, Nothing, Nothing, Nothing, Nothing)

            Dim i As Integer
            i = 0
            'Arranque de las iteraciones.
            Do
                i += 1
                'Definición de los random.
                aleatorioTipo = random.Next(1, 999)
                aleatorioTipo = aleatorioTipo / 1000
                aleatorioTiempo = random.Next(1, 999)
                aleatorioTiempo = aleatorioTiempo / 1000

                'Definición de los eventos.
                evento_2 = evento_1
                evento_1 = evento
                evento = columnaEvento

                'Si es la segunda iteración.
                If evento_1 = "Inicialización" Then
                    evento = "Llegada Auto"
                    reloj = proximaLlegada
                End If

                'Borra la cabina "j".
                For j = 0 To 49
                    If cabina(j) = reloj Then
                        cabina(j) = 0
                    End If
                Next

                'Definición del Tiempo entre Llegadas.
                tiempoLlegada = -(indice) * Math.Log(1 - aleatorioTipo)

                'Si es Fin de Cobro, no calcula randoms.
                'Si es Llegada Auto, calcula la próxima llegada.
                If evento = "Fin de Cobro" Then
                    aleatorioTiempo = Nothing
                    aleatorioTipo = Nothing
                    tiempoLlegada = Nothing
                    tiempoAtencion = Nothing
                    cantAutos -= 1
                ElseIf evento = "Llegada Auto" Then
                    cantAutos += 1
                    proximaLlegada = tiempoLlegada + reloj
                End If

                'Definición del Tipo de Vehículo.
                If aleatorioTiempo <> Nothing Or evento = "Llegada Auto" Then
                    If (aleatorioTiempo > dgvTipos.Rows(0).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(0).Cells(4).Value) Then
                        tipoVehiculo = 1
                    End If

                    If (aleatorioTiempo > dgvTipos.Rows(1).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(1).Cells(4).Value) Then
                        tipoVehiculo = 2
                    End If

                    If (aleatorioTiempo > dgvTipos.Rows(2).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(2).Cells(4).Value) Then
                        tipoVehiculo = 3
                    End If

                    If (aleatorioTiempo > dgvTipos.Rows(3).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(3).Cells(4).Value) Then
                        tipoVehiculo = 4
                    End If

                    If (aleatorioTiempo > dgvTipos.Rows(4).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(4).Cells(4).Value) Then
                        tipoVehiculo = 5
                    End If
                Else
                    tipoVehiculo = Nothing
                End If

                'Definición del Tiempo de Atención del Auto y del Monto a Cobrar.
                If evento = "Llegada Auto" Then
                    If tipoVehiculo = 1 Then
                        tiempoAtencion = tiempo1
                        monto = costo1
                    End If

                    If tipoVehiculo = 2 Then
                        tiempoAtencion = aleatorioTiempo * ((tiempo4 - tiempo3) + tiempo3)
                        monto = costo2
                    End If

                    If tipoVehiculo = 3 Then
                        tiempoAtencion = aleatorioTiempo * ((tiempo6 - tiempo5) + tiempo5)
                        monto = costo3
                    End If

                    If tipoVehiculo = 4 Then
                        tiempoAtencion = aleatorioTiempo * ((tiempo8 - tiempo7) + tiempo7)
                        monto = costo4
                    End If

                    If tipoVehiculo = 5 Then
                        tiempoAtencion = aleatorioTiempo * ((tiempo10 - tiempo9) + tiempo9)
                        monto = costo5
                    End If
                End If

                'Definición de la cabina a la que va el auto.
                For j = 0 To 49
                    If evento = "Llegada Auto" Then
                        If estado(j) = "" Or estado(j) = "Libre" Then
                            estado(j) = "Ocupado"
                            cabina(j) = tiempoAtencion + reloj
                            cabinaAutoRecienLlegado = j + 1
                            Exit For
                        End If
                    End If
                Next

                'Búsqueda del mínimo.
                minimo = proximaLlegada
                For j = 0 To 49
                    If cabina(j) > 0 And cabina(j) < minimo Then
                        minimo = cabina(j)
                        columnaEvento = "Fin de Cobro"
                        columnaMinimo = minimo
                        minimoColoreado = dgvResultados.Rows(i).Cells(j).Value
                    End If
                Next

                If proximaLlegada = minimo Then
                    columnaEvento = "Llegada Auto"
                    columnaMinimo = minimo
                End If

                'Definición de los datos de los autos.
                If evento = "Llegada Auto" Then
                    For j = 0 To 49
                        If aleatorioTiempo <> Nothing Then
                            'Caso que el auto sea del tipo 1.
                            If (aleatorioTiempo > dgvTipos.Rows(0).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(0).Cells(4).Value) Then
                                If tipoAuto(j) = Nothing Then
                                    tipoAuto(j) = 1
                                    horaLlegadaAuto(j) = reloj
                                    horaSalidaAuto(j) = reloj + tiempoAtencion
                                    estadoCabina(j) = "Siendo Cobrado"
                                    cabinaAuto(j) = cabinaAutoRecienLlegado
                                    Exit For
                                End If
                            End If

                            'Caso que el auto sea del tipo 2.
                            If (aleatorioTiempo > dgvTipos.Rows(1).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(1).Cells(4).Value) Then
                                If tipoAuto(j) = Nothing Then
                                    tipoAuto(j) = 2
                                    horaLlegadaAuto(j) = reloj
                                    horaSalidaAuto(j) = reloj + tiempoAtencion
                                    estadoCabina(j) = "Siendo Cobrado"
                                    cabinaAuto(j) = cabinaAutoRecienLlegado
                                    Exit For
                                End If
                            End If

                            'Caso que el auto sea del tipo 3.
                            If (aleatorioTiempo > dgvTipos.Rows(2).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(2).Cells(4).Value) Then
                                If tipoAuto(j) = Nothing Then
                                    tipoAuto(j) = 3
                                    horaLlegadaAuto(j) = reloj
                                    horaSalidaAuto(j) = reloj + tiempoAtencion
                                    estadoCabina(j) = "Siendo Cobrado"
                                    cabinaAuto(j) = cabinaAutoRecienLlegado
                                    Exit For
                                End If
                            End If

                            'Caso que el auto sea del tipo 4.
                            If (aleatorioTiempo > dgvTipos.Rows(3).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(3).Cells(4).Value) Then
                                If tipoAuto(j) = Nothing Then
                                    tipoAuto(j) = 4
                                    horaLlegadaAuto(j) = reloj
                                    horaSalidaAuto(j) = reloj + tiempoAtencion
                                    estadoCabina(j) = "Siendo Cobrado"
                                    cabinaAuto(j) = cabinaAutoRecienLlegado
                                    Exit For
                                End If
                            End If

                            'Caso que el auto sea del tipo 5.
                            If (aleatorioTiempo > dgvTipos.Rows(4).Cells(3).Value And aleatorioTiempo < dgvTipos.Rows(4).Cells(4).Value) Then
                                If tipoAuto(j) = Nothing Then
                                    tipoAuto(j) = 5
                                    horaLlegadaAuto(j) = reloj
                                    horaSalidaAuto(j) = reloj + tiempoAtencion
                                    estadoCabina(j) = "Siendo Cobrado"
                                    cabinaAuto(j) = cabinaAutoRecienLlegado
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                End If

                'Cambia el estado de la cabina a Libre cuando se terminó el cobro de ésta última.
                For j = 0 To 49
                    If estado(j) = "Ocupado" And cabina(j) = 0 Then
                        estado(j) = Nothing
                        cabina(j) = Nothing
                    End If
                    'Vacía los datos de los elementos Cliente una vez que ya se terminó el cobro del mismo.
                    If horaSalidaAuto(j) = reloj Then
                        If tipoAuto(j) = 1 Then
                            monto = costo1
                        End If
                        If tipoAuto(j) = 2 Then
                            monto = costo2
                        End If
                        If tipoAuto(j) = 3 Then
                            monto = costo3
                        End If
                        If tipoAuto(j) = 4 Then
                            monto = costo4
                        End If
                        If tipoAuto(j) = 5 Then
                            monto = costo5
                        End If
                        tipoAuto(j) = Nothing
                        horaLlegadaAuto(j) = Nothing
                        horaSalidaAuto(j) = Nothing
                        estadoCabina(j) = Nothing
                        cabinaAuto(j) = Nothing
                    End If
                Next

                'Definición de la cantidad de cabinas habilitadas en la iteración.
                cantCabinasHabilitadas = 0
                For j = 0 To 49
                    If cabina(j) <> Nothing Then
                        cantCabinasHabilitadas += 1
                    End If
                Next
                For j = 0 To 49
                    If estado(j) = "Ocupado" Then
                        promPorCabina(j) += 1
                    End If
                Next
                If cantCabinasHabilitadas = 1 Then
                    cantCabinasHabilitadas = 2
                End If

                'Determinación de la cantidad de cabinas para cálculo del promedio.
                totalCabinasPromedio += cantCabinasHabilitadas

                'Determinación de la mayor cantidad de cabinas habilitadas.
                If cantCabinasHabilitadas > maximaCantidadCabinas Then
                    maximaCantidadCabinas = cantCabinasHabilitadas
                End If

                'Acumulación de las cabinas.
                If evento = "Fin de Cobro" Then
                    acRecaudacion = acRecaudacion + monto
                End If

                ''Definición de la cantidad de autos en cola.
                If cantAutos > 51 Then
                    cola += 1
                ElseIf cantAutos < 51 Then
                    cola = cola
                End If

                'If tiempoAtencion = 0 Then
                '    tiempoAtencion = Nothing
                'End If

                'Adición de la fila con los datos correspondientes de la iteración.
                dgvResultados.Rows.Add(evento, reloj, aleatorioTipo, tiempoLlegada, proximaLlegada, aleatorioTiempo, tipoVehiculo, tiempoAtencion, monto,
                                                    cabina(0), estado(0), cabina(1), estado(1), cabina(2), estado(2), cabina(3), estado(3), cabina(4), estado(4),
                                                    cabina(5), estado(5), cabina(6), estado(6), cabina(7), estado(7), cabina(8), estado(8), cabina(9), estado(9),
                                                    cabina(10), estado(10), cabina(11), estado(11), cabina(12), estado(12), cabina(13), estado(13), cabina(14), estado(14),
                                                    cabina(15), estado(15), cabina(16), estado(16), cabina(17), estado(17), cabina(18), estado(18), cabina(19), estado(19),
                                                    cabina(20), estado(20), cabina(21), estado(21), cabina(22), estado(22), cabina(23), estado(23), cabina(24), estado(24),
                                                    cabina(25), estado(25), cabina(26), estado(26), cabina(27), estado(27), cabina(28), estado(28), cabina(29), estado(29),
                                                    cabina(30), estado(30), cabina(31), estado(31), cabina(32), estado(32), cabina(33), estado(33), cabina(34), estado(34),
                                                    cabina(35), estado(35), cabina(36), estado(36), cabina(37), estado(37), cabina(38), estado(38), cabina(39), estado(39),
                                                    cabina(40), estado(40), cabina(41), estado(41), cabina(42), estado(42), cabina(43), estado(43), cabina(44), estado(44),
                                                    cabina(45), estado(45), cabina(46), estado(46), cabina(47), estado(47), cabina(48), estado(48), cabina(49), estado(49),
                                                    cantCabinasHabilitadas, acRecaudacion, cola,
                                                    tipoAuto(0), horaLlegadaAuto(0), horaSalidaAuto(0), estadoCabina(0), cabinaAuto(0),
                                                    tipoAuto(1), horaLlegadaAuto(1), horaSalidaAuto(1), estadoCabina(1), cabinaAuto(1),
                                                    tipoAuto(2), horaLlegadaAuto(2), horaSalidaAuto(2), estadoCabina(2), cabinaAuto(2),
                                                    tipoAuto(3), horaLlegadaAuto(3), horaSalidaAuto(3), estadoCabina(3), cabinaAuto(3),
                                                    tipoAuto(4), horaLlegadaAuto(4), horaSalidaAuto(4), estadoCabina(4), cabinaAuto(4),
                                                    tipoAuto(5), horaLlegadaAuto(5), horaSalidaAuto(5), estadoCabina(5), cabinaAuto(5),
                                                    tipoAuto(6), horaLlegadaAuto(6), horaSalidaAuto(6), estadoCabina(6), cabinaAuto(6),
                                                    tipoAuto(7), horaLlegadaAuto(7), horaSalidaAuto(7), estadoCabina(7), cabinaAuto(7),
                                                    tipoAuto(8), horaLlegadaAuto(8), horaSalidaAuto(8), estadoCabina(8), cabinaAuto(8),
                                                    tipoAuto(9), horaLlegadaAuto(9), horaSalidaAuto(9), estadoCabina(9), cabinaAuto(9),
                                                    tipoAuto(10), horaLlegadaAuto(10), horaSalidaAuto(10), estadoCabina(10), cabinaAuto(10),
                                                    tipoAuto(11), horaLlegadaAuto(11), horaSalidaAuto(11), estadoCabina(11), cabinaAuto(11),
                                                    tipoAuto(12), horaLlegadaAuto(12), horaSalidaAuto(12), estadoCabina(12), cabinaAuto(12),
                                                    tipoAuto(13), horaLlegadaAuto(13), horaSalidaAuto(13), estadoCabina(13), cabinaAuto(13),
                                                    tipoAuto(14), horaLlegadaAuto(14), horaSalidaAuto(14), estadoCabina(14), cabinaAuto(14),
                                                    tipoAuto(15), horaLlegadaAuto(15), horaSalidaAuto(15), estadoCabina(15), cabinaAuto(15),
                                                    tipoAuto(16), horaLlegadaAuto(16), horaSalidaAuto(16), estadoCabina(16), cabinaAuto(16),
                                                    tipoAuto(17), horaLlegadaAuto(17), horaSalidaAuto(17), estadoCabina(17), cabinaAuto(17),
                                                    tipoAuto(18), horaLlegadaAuto(18), horaSalidaAuto(18), estadoCabina(18), cabinaAuto(18),
                                                    tipoAuto(19), horaLlegadaAuto(19), horaSalidaAuto(19), estadoCabina(19), cabinaAuto(19),
                                                    tipoAuto(20), horaLlegadaAuto(20), horaSalidaAuto(20), estadoCabina(20), cabinaAuto(20),
                                                    tipoAuto(21), horaLlegadaAuto(21), horaSalidaAuto(21), estadoCabina(21), cabinaAuto(21),
                                                    tipoAuto(22), horaLlegadaAuto(22), horaSalidaAuto(22), estadoCabina(22), cabinaAuto(22),
                                                    tipoAuto(23), horaLlegadaAuto(23), horaSalidaAuto(23), estadoCabina(23), cabinaAuto(23),
                                                    tipoAuto(24), horaLlegadaAuto(24), horaSalidaAuto(24), estadoCabina(24), cabinaAuto(24),
                                                    tipoAuto(25), horaLlegadaAuto(25), horaSalidaAuto(25), estadoCabina(25), cabinaAuto(25),
                                                    tipoAuto(26), horaLlegadaAuto(26), horaSalidaAuto(26), estadoCabina(26), cabinaAuto(26),
                                                    tipoAuto(27), horaLlegadaAuto(27), horaSalidaAuto(27), estadoCabina(27), cabinaAuto(27),
                                                    tipoAuto(28), horaLlegadaAuto(28), horaSalidaAuto(28), estadoCabina(28), cabinaAuto(28),
                                                    tipoAuto(29), horaLlegadaAuto(29), horaSalidaAuto(29), estadoCabina(29), cabinaAuto(29),
                                                    tipoAuto(30), horaLlegadaAuto(30), horaSalidaAuto(30), estadoCabina(30), cabinaAuto(30),
                                                    tipoAuto(31), horaLlegadaAuto(31), horaSalidaAuto(31), estadoCabina(31), cabinaAuto(31),
                                                    tipoAuto(32), horaLlegadaAuto(32), horaSalidaAuto(32), estadoCabina(32), cabinaAuto(32),
                                                    tipoAuto(33), horaLlegadaAuto(33), horaSalidaAuto(33), estadoCabina(33), cabinaAuto(33),
                                                    tipoAuto(34), horaLlegadaAuto(34), horaSalidaAuto(34), estadoCabina(34), cabinaAuto(34),
                                                    tipoAuto(35), horaLlegadaAuto(35), horaSalidaAuto(35), estadoCabina(35), cabinaAuto(35),
                                                    tipoAuto(36), horaLlegadaAuto(36), horaSalidaAuto(36), estadoCabina(36), cabinaAuto(36),
                                                    tipoAuto(37), horaLlegadaAuto(37), horaSalidaAuto(37), estadoCabina(37), cabinaAuto(37),
                                                    tipoAuto(38), horaLlegadaAuto(38), horaSalidaAuto(38), estadoCabina(38), cabinaAuto(38),
                                                    tipoAuto(39), horaLlegadaAuto(39), horaSalidaAuto(39), estadoCabina(39), cabinaAuto(39),
                                                    tipoAuto(40), horaLlegadaAuto(40), horaSalidaAuto(40), estadoCabina(40), cabinaAuto(40),
                                                    tipoAuto(41), horaLlegadaAuto(41), horaSalidaAuto(41), estadoCabina(41), cabinaAuto(41),
                                                    tipoAuto(42), horaLlegadaAuto(42), horaSalidaAuto(42), estadoCabina(42), cabinaAuto(42),
                                                    tipoAuto(43), horaLlegadaAuto(43), horaSalidaAuto(43), estadoCabina(43), cabinaAuto(43),
                                                    tipoAuto(44), horaLlegadaAuto(44), horaSalidaAuto(44), estadoCabina(44), cabinaAuto(44),
                                                    tipoAuto(45), horaLlegadaAuto(45), horaSalidaAuto(45), estadoCabina(45), cabinaAuto(45),
                                                    tipoAuto(46), horaLlegadaAuto(46), horaSalidaAuto(46), estadoCabina(46), cabinaAuto(46),
                                                    tipoAuto(47), horaLlegadaAuto(47), horaSalidaAuto(47), estadoCabina(47), cabinaAuto(47),
                                                    tipoAuto(48), horaLlegadaAuto(48), horaSalidaAuto(48), estadoCabina(48), cabinaAuto(48),
                                                    tipoAuto(49), horaLlegadaAuto(49), horaSalidaAuto(49), estadoCabina(49), cabinaAuto(49))

                reloj = columnaMinimo

                'Pinta la celda del próximo evento.
                If minimo = proximaLlegada Then
                    dgvResultados.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                ElseIf minimo <> proximaLlegada Then

                    For j = 9 To 108 Step 2
                        If IsNumeric(dgvResultados.Rows(i).Cells(j).Value) Then
                            If dgvResultados.Rows(i).Cells(j).Value = reloj Then
                                dgvResultados.Rows(i).Cells(j).Style.BackColor = Color.Yellow
                                Exit For
                            End If
                        End If
                    Next
                End If

            Loop While reloj <= horas

            'Cantidad promedio de cabinas.
            promedioCabinas = totalCabinasPromedio / (dgvResultados.RowCount - 2)
            txtCantPromedioCabinas.Text = (Math.Round(promedioCabinas, 2)).ToString()

            'Monto recaudado en 100 horas
            txtMontoRecaudado.Text = "$" + acRecaudacion.ToString()

            'Promedio de cada cantidad de cabinas.
            For i = 1 To dgvPromedios.ColumnCount - 1
                dgvPromedios.Rows(0).Cells(i).Value = promPorCabina(i) / (dgvResultados.RowCount - 2)
                dgvPromedios.Columns(i).DefaultCellStyle.Format = "N4"
            Next
            dgvPromedios.Rows(0).Cells(1).Value = 1
            dgvPromedios.Columns(1).DefaultCellStyle.Format = "N2"

            'Cantidad máxima de cabinas habilitadas.
            txtCantMaxCabinas.Text = maximaCantidadCabinas.ToString()

            'Elimina los tiempos de las cabinas que están libres (no tienen autos).
            For i = 0 To dgvResultados.RowCount - 1
                For j = 9 To 108
                    If IsNumeric(dgvResultados.Rows(i).Cells(j).Value) Then
                        If dgvResultados.Rows(i).Cells(j).Value = 0 Then
                            dgvResultados.Rows(i).Cells(j).Value = Nothing
                        End If
                        Continue For
                    End If
                Next
            Next

            'Pinta grupos de 4 columnas para cada auto, y elimina en caso que no haya elemento cliente.
            For i = 0 To dgvResultados.RowCount - 1
                For j = 112 To (dgvResultados.ColumnCount - 1) Step 10
                    'Columna de la Hora de Llegada del Auto.
                    For k = 113 To (dgvResultados.ColumnCount - 1) Step 10
                        dgvResultados.Rows(i).Cells(k).Style.BackColor = Color.Beige

                    Next

                    'Elimina los valores de las celdas de horas de llegada de los autos en caso que sea 0 (no hay auto).
                    For a = 113 To (dgvResultados.ColumnCount - 1) Step 5
                        If dgvResultados.Rows(i).Cells(a).Value = 0 Then
                            dgvResultados.Rows(i).Cells(a).Value = Nothing
                        End If
                    Next

                    'Columna de la Hora de Salida del Auto.
                    For k = 114 To (dgvResultados.ColumnCount - 1) Step 10
                        dgvResultados.Rows(i).Cells(k).Style.BackColor = Color.Beige
                        If dgvResultados.Rows(i).Cells(k).Value = 0 Then
                            dgvResultados.Rows(i).Cells(k).Value = Nothing
                        End If
                    Next

                    'Elimina los valores de las celdas de horas de salida de los autos en caso que sea 0 (no hay auto).
                    For b = 114 To (dgvResultados.ColumnCount - 1) Step 5
                        If dgvResultados.Rows(i).Cells(b).Value = 0 Then
                            dgvResultados.Rows(i).Cells(b).Value = Nothing
                        End If
                    Next

                    'Columna del Estado del Auto.
                    For l = 115 To (dgvResultados.ColumnCount - 1) Step 10
                        dgvResultados.Rows(i).Cells(l).Style.BackColor = Color.Beige
                    Next

                    'Columna del la Cabina en la que está el Auto.
                    For m = 116 To (dgvResultados.ColumnCount - 1) Step 10
                        dgvResultados.Rows(i).Cells(m).Style.BackColor = Color.Beige
                        If dgvResultados.Rows(i).Cells(m).Value = 0 Or dgvResultados.Rows(i).Cells(m).Value = 0.00 Then
                            dgvResultados.Rows(i).Cells(m).Value = Nothing
                        End If
                    Next

                    'Elimina los valores de las cabinas de los autos en caso que sea 0 (no hay auto).
                    For c = 116 To (dgvResultados.ColumnCount - 1) Step 5
                        If dgvResultados.Rows(i).Cells(c).Value = 0 Then
                            dgvResultados.Rows(i).Cells(c).Value = Nothing
                        End If
                    Next

                    ''Columna del Tipo de Auto.
                    dgvResultados.Rows(i).Cells(j).Style.BackColor = Color.Beige
                Next
            Next

        Else
            If txtHoras.Text = "" Then
                MessageBox.Show("Ingrese la cantidad de horas que quiere simular.")
            End If
            If txtIndice.Text = "" Then
                MessageBox.Show("Ingrese el índice de llegada de autos deseado.")
            End If
            If dgvTipos.CurrentCell Is Nothing Then
                MessageBox.Show("Ingrese los valores para las probabilidades de los tipos de autos antes de comenzar con la simulación.")
            End If
            If dgvDatos.CurrentCell Is Nothing Then
                MessageBox.Show("Ingrese los valores que faltan para los tiempos y costos de cada tipo de auto antes de comenzar con la simulación.")
            End If
        End If
    End Sub
End Class