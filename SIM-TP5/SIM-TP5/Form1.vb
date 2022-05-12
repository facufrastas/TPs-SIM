Imports System.Globalization

Public Class Form1

    Private Sub btnTipos_Click(sender As Object, e As EventArgs) Handles btnTipos.Click
        If IsNumeric(txtTipo1.Text) And IsNumeric(txtTipo2.Text) And IsNumeric(txtTipo3.Text) Then
            If txtTipo1.Text > 0 And txtTipo2.Text > 0 And txtTipo3.Text > 0 Then
                Dim n1 As New Double
                n1 = txtTipo1.Text
                Dim n2 As New Double
                n2 = txtTipo2.Text
                Dim n3 As New Double
                n3 = txtTipo3.Text

                If n1 > 1 And n1 < 100 Then
                    n1 = n1 / 100
                End If

                If n2 > 1 And n2 < 100 Then
                    n2 = n2 / 100
                End If

                If n3 > 1 And n3 < 100 Then
                    n3 = n3 / 100
                End If

                If (n1 + n2 + n3) = 100 Or (n1 + n2 + n3) = 1 Then
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

    Private Sub btnTiempos_Click(sender As Object, e As EventArgs) Handles btnTiempos.Click
        If IsNumeric(txtTiempo1.Text) And IsNumeric(txtTiempo2.Text) And IsNumeric(txtTiempo3.Text) And IsNumeric(txtTiempo4.Text) Then
            If txtTiempo1.Text > 0 And txtTiempo2.Text > 0 And txtTiempo3.Text > 0 And txtTiempo4.Text > 0 Then
                Dim n1 As New Double
                n1 = txtTiempo1.Text
                Dim n2 As New Double
                n2 = txtTiempo2.Text
                Dim n3 As New Double
                n3 = txtTiempo3.Text
                Dim n4 As New Double
                n4 = txtTiempo4.Text

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

                If (n1 + n2 + n3 + n4) = 100 Or (n1 + n2 + n3 + n4) = 1 Then
                    generarTiempos()
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

    Public Sub generarTipos()
        Dim prob1 As New Double
        prob1 = txtTipo1.Text
        Dim prob2 As New Double
        prob2 = txtTipo2.Text
        Dim prob3 As New Double
        prob3 = txtTipo3.Text

        If prob1 > 1 And prob2 > 1 And prob3 > 1 Then
            prob1 = prob1 / 100
            prob2 = prob2 / 100
            prob3 = prob3 / 100
        End If

        If dgvTipos.CurrentCell Is Nothing Then
            dgvTipos.Rows.Add("Auto Pequeño", prob1, prob1, 0, prob1 - 0.01)
            dgvTipos.Rows.Add("Auto Grande", prob2, prob1 + prob2, prob1, (prob1 + prob2) - 0.01)
            dgvTipos.Rows.Add("Utilitario", prob3, prob1 + prob2 + prob3, (prob1 + prob2), (prob1 + prob2 + prob3) - 0.01)
        End If
    End Sub

    Public Sub generarTiempos()
        Dim prob1 As New Double
        prob1 = txtTiempo1.Text
        Dim prob2 As New Double
        prob2 = txtTiempo2.Text
        Dim prob3 As New Double
        prob3 = txtTiempo3.Text
        Dim prob4 As New Double
        prob4 = txtTiempo4.Text

        If prob1 > 1 And prob2 > 1 And prob3 > 1 And prob4 > 1 Then
            prob1 = prob1 / 100
            prob2 = prob2 / 100
            prob3 = prob3 / 100
            prob4 = prob4 / 100
        End If

        If dgvTiempos.CurrentCell Is Nothing Then
            dgvTiempos.Rows.Add(1, prob1, prob1, 0, prob1 - 0.01)
            dgvTiempos.Rows.Add(2, prob2, prob1 + prob2, prob1, (prob1 + prob2) - 0.01)
            dgvTiempos.Rows.Add(3, prob3, prob1 + prob2 + prob3, (prob1 + prob2), (prob1 + prob2 + prob3) - 0.01)
            dgvTiempos.Rows.Add(4, prob4, prob1 + prob2 + prob3 + prob4, (prob1 + prob2 + prob3), (prob1 + prob2 + prob3 + prob4))
        End If
    End Sub

    Private Sub btnLimpiar1_Click(sender As Object, e As EventArgs) Handles btnLimpiar1.Click
        dgvTipos.Rows.Clear()
    End Sub

    Private Sub btnLimpiar2_Click(sender As Object, e As EventArgs) Handles btnLimpiar2.Click
        dgvTiempos.Rows.Clear()
    End Sub

    Private Sub btnLimpiar3_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar3.Click
        If Not dgvResultados.CurrentCell Is Nothing Then
            For r = (dgvResultados.ColumnCount) - 1 To 37 Step -1
                dgvResultados.Columns.RemoveAt(r)
            Next
            dgvResultados.Rows.Clear()
        End If
    End Sub

    Private Sub btnSimulacion_Click(sender As Object, e As EventArgs) Handles btnSimulacion.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-AR")
        If Not (dgvTipos.CurrentCell Is Nothing) And Not (dgvTiempos.CurrentCell Is Nothing) Then
            generarTiempos()
            generarTipos()
        Else
            If dgvTipos.CurrentCell Is Nothing Then
                MessageBox.Show("Ingrese los valores para los tipos de coches antes de empezar la simulación.")
            End If

            If dgvTiempos.CurrentCell Is Nothing Then
                MessageBox.Show("Ingrese los valores para los tiempos de estacionamiento antes de empezar la simulación.")
            End If
        End If
        If Not (dgvTipos.CurrentCell Is Nothing) And Not (dgvTiempos.CurrentCell Is Nothing) And txtIndice.Text <> "" And txtCobro.Text <> "" And txtIteraciones.Text <> "" And txtInicio.Text <> "" And Not (cmbColas.SelectedIndex = -1) And txtInicio.Text <> "" And txtFinal.Text <> "" Then
            For j = 0 To 19
                dgvResultados.Columns.Add("Column", "Tipo Auto")
                dgvResultados.Columns.Add("Column", "Hora Llegada")
                dgvResultados.Columns.Add("Column", "Estado")
                dgvResultados.Columns.Add("Column", "Lugar")
            Next
            Dim iteraciones As New Integer
            iteraciones = txtIteraciones.Text
            Dim desde As New Double
            desde = txtInicio.Text
            Dim hasta As New Double
            hasta = txtFinal.Text
            Dim indice As New Double
            indice = txtIndice.Text
            Dim cobro As New Double
            cobro = txtCobro.Text
            Dim contador As New Integer
            contador = 0

            Dim random As New Random()
            Dim random2 As New Random()

            Dim numero3 As New Double
            Dim numero4 As New Integer

            Dim minimoColoreado As New Double
            Dim flagColor As New Integer

            dgvResultados.Columns(1).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(2).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(3).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(4).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(5).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(6).DefaultCellStyle.Format = "N0"
            dgvResultados.Columns(7).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(8).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(9).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(10).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(11).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(12).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(13).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(14).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(15).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(16).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(17).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(18).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(19).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(20).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(21).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(22).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(23).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(24).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(25).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(26).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(28).DefaultCellStyle.Format = "N2"
            dgvResultados.Columns(33).DefaultCellStyle.Format = "C2"
            dgvResultados.Columns(36).DefaultCellStyle.Format = "N2"

            For r = 37 To (dgvResultados.ColumnCount - 1) Step 4
                dgvResultados.Columns(r).DefaultCellStyle.Format = "N0"
                dgvResultados.Columns(r + 2).DefaultCellStyle.Format = "N0"
                dgvResultados.Columns(r + 1).DefaultCellStyle.Format = "N2"
            Next

            Dim tipo1 As New Double
            tipo1 = dgvTipos.Rows(0).Cells(3).Value
            Dim tipo2 As New Double
            tipo2 = dgvTipos.Rows(0).Cells(4).Value
            Dim tipo3 As New Double
            tipo3 = dgvTipos.Rows(1).Cells(3).Value
            Dim tipo4 As New Double
            tipo4 = dgvTipos.Rows(1).Cells(4).Value
            Dim tipo5 As New Double
            tipo5 = dgvTipos.Rows(2).Cells(3).Value
            Dim tipo6 As New Double
            tipo6 = dgvTipos.Rows(2).Cells(4).Value

            Dim tiempo1 As New Double
            tiempo1 = dgvTiempos.Rows(0).Cells(3).Value
            Dim tiempo2 As New Double
            tiempo2 = dgvTiempos.Rows(0).Cells(4).Value
            Dim tiempo3 As New Double
            tiempo3 = dgvTiempos.Rows(1).Cells(3).Value
            Dim tiempo4 As New Double
            tiempo4 = dgvTiempos.Rows(1).Cells(4).Value
            Dim tiempo5 As New Double
            tiempo5 = dgvTiempos.Rows(2).Cells(3).Value
            Dim tiempo6 As New Double
            tiempo6 = dgvTiempos.Rows(2).Cells(4).Value
            Dim tiempo7 As New Double
            tiempo7 = dgvTiempos.Rows(3).Cells(3).Value
            Dim tiempo8 As New Double
            tiempo8 = dgvTiempos.Rows(3).Cells(4).Value

            ''Primera Iteración
            Dim minimo As New Double
            Dim cocheraOcupada As New Integer
            cocheraOcupada = 0

            If cmbColas.SelectedIndex = 0 Then
                dgvResultados.Columns(31).Visible = False
                dgvResultados.Columns(32).Visible = False
            Else
                dgvResultados.Columns(31).Visible = True
                dgvResultados.Columns(32).Visible = True
            End If

            ''Código Nuevo
            Dim evento As String
            Dim evento_1 As String
            Dim evento_2 As String

            Dim reloj As Double
            Dim rnd1 As New Double
            Dim rnda1(199) As Double
            Dim tiempoEntreLlegadas As Double
            Dim proximaLlegada As Double
            Dim rnd2 As New Double
            Dim rnda2(199) As Double
            Dim tiempoAtencion As Integer
            Dim nuevoFinCobro As Double

            Dim estacionamiento(19) As Double

            Dim tipoAuto(19) As String
            Dim horaLlegadaAuto(19) As Double
            Dim estadoAuto(19) As String
            Dim lugarAuto(19) As Integer

            ''Blanquea
            For j = 0 To 19
                estacionamiento(j) = Nothing
                tipoAuto(j) = Nothing
                horaLlegadaAuto(j) = Nothing
                estadoAuto(j) = Nothing
                lugarAuto(j) = Nothing
            Next

            Dim tiempoCobro As Double
            Dim finCobro As Double
            Dim finCobro_1 As Double
            Dim finCobroTemporal As Double
            Dim estadoCola1 As String
            Dim cola1 As Integer
            Dim estadoCola2 As String
            Dim cola2 As Integer
            Dim acRecaudacion As Double
            Dim autosAceptados As Integer
            Dim autosRechazados As Integer
            Dim rnd3 As New Double
            Dim rnda3(199) As Double
            'Dim rnda4(199) As Integer

            Dim columna37 As String = ""
            Dim columna38 As Double
            Dim columna39 As Integer = 0

            ''Primera Fila

            'dgvResultados.Rows(0).Cells(0).Value = "Inicializacion"
            evento = "Inicializacion"
            evento_1 = evento
            evento_2 = evento
            finCobro_1 = finCobro
            'dgvResultados.Rows(0).Cells(1).Value = 0.00
            reloj = 0.00

            'dgvResultados.Rows(0).Cells(29).Value = "Libre"
            estadoCola1 = "Libre"

            'dgvResultados.Rows(0).Cells(30).Value = 0
            cola1 = 0

            'dgvResultados.Rows(0).Cells(31).Value = "Libre"
            estadoCola2 = "Libre"

            'dgvResultados.Rows(0).Cells(32).Value = 0
            cola2 = 0

            'dgvResultados.Rows(0).Cells(33).Value = 0
            acRecaudacion = 0

            'dgvResultados.Rows(0).Cells(34).Value = 0
            autosAceptados = 0

            'dgvResultados.Rows(0).Cells(35).Value = 0
            autosRechazados = 0

            'dgvResultados.Rows(0).Cells(2).Value = rnd1
            'Carga los arreglos con random.
            For j = 0 To 199
                rnda1(j) = random.NextDouble
                rnda2(j) = random.NextDouble
                rnda3(j) = random.NextDouble
            Next
            rnd1 = rnda1(0)

            tiempoEntreLlegadas = (indice * (-1)) * Math.Log(1 - rnd1)
            proximaLlegada = tiempoEntreLlegadas + reloj

            rnd2 = Nothing
            rnd3 = Nothing
            numero4 = Nothing

            tiempoAtencion = Nothing

            'Agrega la Primera Fila.
            dgvResultados.Rows.Add(evento, reloj, rnd1, tiempoEntreLlegadas, proximaLlegada, Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, estadoCola1, cola1, estadoCola2, cola2, acRecaudacion, autosAceptados, autosRechazados, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing,
                                           Nothing, Nothing, Nothing, Nothing)
            Dim i As Integer
            i = 1
            Dim count As Integer
            count = 0
            Do
                i += 1
                If i > 199 Then
                    i = 0
                Else
                    i = i
                End If

                'For i = 1 To (reloj >= hasta)
                'If i Mod 100 = 0 And i <> 0 Then
                'i = i
                'End If

                'rnd1 = random.Next(1, 999999) / 1000000
                'rnd2 = random.Next(1, 999999) / 1000000
                'rnd3 = random.Next(1, 999999) / 1000000

                rnd1 = rnda1(i)
                rnd2 = rnda2(i)
                rnd3 = rnda3(i)
                'numero4 = rnda4(i)
                'rnd1 = random.NextDouble
                'rnd2 = random.NextDouble
                'rnd3 = random.NextDouble
                'numero4 = random2.Next(0, 19)

                evento_2 = evento_1
                evento_1 = evento
                evento = columna37
                cobro = CInt(txtCobro.Text)
                nuevoFinCobro = cobro + reloj
                finCobro_1 = finCobro
                'reloj = columna38

                If evento_1 = "Inicializacion" Then
                    evento = "Llegada Auto"
                    reloj = proximaLlegada
                End If

                ''Borra el estacionamiento "j".
                For j = 0 To 19
                    If estacionamiento(j) = reloj Then
                        estacionamiento(j) = 0
                    End If
                Next

                ''(2)Definición del primer Random.
                ''(3)Definición del Tiempo entre Llegadas.

                tiempoEntreLlegadas = (indice * (-1)) * Math.Log(1 - rnd1)

                If evento <> "Llegada Auto" Then
                    rnd1 = Nothing
                    rnd2 = Nothing
                    tiempoEntreLlegadas = Nothing
                Else
                    ''(4)Definición de la Próxima Llegada.
                    proximaLlegada = tiempoEntreLlegadas + reloj
                End If

                ''(5)Definición del segundo Random.
                If evento = "Llegada Auto" Then
                    If cocheraOcupada < 21 Then 'cambie 21 x 20
                        cocheraOcupada += 1
                    Else
                        cocheraOcupada = cocheraOcupada
                        'rnd2 = Nothing
                    End If
                Else
                    rnd2 = Nothing
                End If

                ''(6)Definición del Tiempo de Atención (Fin estadia).
                If rnd2 <> Nothing Then
                    If (rnd2 >= tiempo1 And rnd2 < tiempo3) Then
                        tiempoAtencion = 1
                    End If

                    If (rnd2 >= tiempo3 And rnd2 < tiempo5) Then
                        tiempoAtencion = 2
                    End If

                    If (rnd2 >= tiempo5 And rnd2 < tiempo7) Then
                        tiempoAtencion = 3
                    End If

                    If (rnd2 >= tiempo7 And rnd2 <= tiempo8) Then
                        tiempoAtencion = 4
                    End If
                Else
                    tiempoAtencion = Nothing
                End If

                ''(7-26)Definición del Tiempo de Estacionamiento.
                If rnd2 <> Nothing Then
                    Dim lleno As Boolean
                    lleno = False
                    numero4 = 0
                    For numero4 = 0 To 19
                        If estacionamiento(numero4) <> 0 Then
                            lleno = True
                        Else
                            lleno = False
                            estacionamiento(numero4) = (tiempoAtencion * 60) + reloj
                            columna37 = numero4
                            Exit For
                        End If
                    Next
                    If lleno = True Then
                        autosRechazados += 1
                        rnd2 = Nothing
                        tiempoAtencion = Nothing
                        'estacionamiento(numero4) = Nothing
                        tiempoCobro = Nothing
                        finCobro = Nothing
                    End If
                End If


                ''(27)Definición del Tiempo de Cobro (Fin de Cobro).
                ''(28)Definición del Tiempo de Fin de Cobro.
                ''Mostrar el tiempo de próxima llegada de la fila anterior..
                If evento = "Fin de Estadía" And evento_1 <> "Fin de Estadía" Then
                    cobro = CInt(txtCobro.Text)
                    tiempoCobro = cobro
                    finCobro = reloj + cobro
                Else
                    tiempoCobro = Nothing
                    cobro = Nothing
                End If

                ''Mostrar el tiempo de fin de cobro de la fila anterior.(Aparentemente innecesario).
                If finCobro = reloj Then
                    finCobro = Nothing
                End If

                ''Búsqueda del mínimo
                minimo = proximaLlegada
                For j = 0 To 19
                    If estacionamiento(j) > 0 And estacionamiento(j) < minimo Then
                        minimo = estacionamiento(j)
                        columna37 = "Fin de Estadía"
                        columna38 = minimo

                    End If
                Next
                If evento_1 <> "Inicializacion" Then
                    If finCobro > 0 And finCobro < minimo Then
                        minimo = finCobro
                        columna37 = "Fin de Cobro"
                        columna38 = minimo

                    End If
                End If
                If proximaLlegada <= minimo Then
                    minimo = proximaLlegada
                    columna37 = "Llegada Auto"
                    columna38 = minimo

                End If

                ''Definición del primer evento luego de la Inicialización.
                If proximaLlegada = minimo Then
                    columna37 = "Llegada Auto"
                    columna38 = proximaLlegada
                End If

                ''Definición de los datos de los autos.
                For j = 0 To 19
                    ''(34)Definición del Random para el tipo de auto.
                    'If dgvResultados.Rows(i - 1).Cells(j).Value = Nothing And dgvResultados.Rows(i).Cells(0).Value = "Llegada Auto" Then
                    If tipoAuto(j) = Nothing And evento = "Llegada Auto" Then
                        If cocheraOcupada < 21 Then
                            numero3 = rnd3
                            ''Definición del Tipo de Auto.
                            'If (dgvResultados.Rows(i).Cells(36).Value >= tipo1 And dgvResultados.Rows(i).Cells(36).Value < tipo3) Then
                            If (rnd3 >= tipo1 And rnd3 < tipo3) Then
                                tipoAuto(j) = "Auto Pequeño"
                                horaLlegadaAuto(j) = reloj
                                estadoAuto(j) = "Estacionado"
                                lugarAuto(j) = numero4 + 1
                                Exit For
                            End If

                            'If (dgvResultados.Rows(i).Cells(36).Value >= tipo3 And dgvResultados.Rows(i).Cells(36).Value < tipo5) Then
                            If (rnd3 >= tipo3 And rnd3 < tipo5) Then
                                tipoAuto(j) = "Auto Grande"
                                horaLlegadaAuto(j) = reloj
                                estadoAuto(j) = "Estacionado"
                                lugarAuto(j) = numero4 + 1
                                Exit For
                            End If

                            If (rnd3 >= tipo5 And rnd3 <= tipo6) Then
                                tipoAuto(j) = "Utilitario"
                                horaLlegadaAuto(j) = reloj
                                estadoAuto(j) = "Estacionado"
                                lugarAuto(j) = numero4 + 1
                                Exit For
                            Else
                                numero3 = Nothing
                            End If
                        End If
                    Else
                        Continue For
                    End If
                Next

                ''Cambiar el estado del auto si es el caso.
                For j = 0 To 19
                    ''Pregunto si es un Fin de Estadía, y compruebo cuál es el auto que se va de la cochera, para poder cambiar el estado del mismo.
                    If evento = "Fin de Estadía" And (((horaLlegadaAuto(j) + 60) = reloj) Or ((horaLlegadaAuto(j) + 120) = reloj) Or ((horaLlegadaAuto(j) + 180) = reloj) Or ((horaLlegadaAuto(j) + 240) = reloj)) Then

                        If cmbColas.SelectedIndex = 0 Then
                            estadoAuto(j) = "Siendo Cobrado"
                            If estadoCola1 = "Libre" And cola1 = 0 Then
                                estadoAuto(j) = "Siendo Cobrado"
                                Exit For
                                'ElseIf cola1 > 0 Or evento_1 = "Fin de Estadía" Then
                            ElseIf cola1 > 0 Then
                                estadoAuto(j) = "Esperando Cobro"
                                Exit For
                            End If
                        Else
                                estadoAuto(j) = "Siendo Cobrado"
                            If estadoCola1 = "Libre" And cola1 = 0 And estadoCola2 = "Libre" And cola2 = 0 Then
                                estadoAuto(j) = "Siendo Cobrado"
                                Exit For
                            ElseIf cola1 > 0 And cola2 > 0 Then
                                estadoAuto(j) = "Esperando Cobro"
                                Exit For
                            End If
                        End If
                    End If
                    ''Si el tiempo de cobro es por ejemplo 2, la resta sería igual a 62, 122, 182 y 222 (lo mismo que 60 + cobro, 120 + cobro, 180 + cobro y 240 + cobro), pero con la suma no funciona.
                    'If evento = "Fin de Cobro" And (((reloj - horaLlegadaAuto(j)) = tiempoCobro4) Or ((reloj - horaLlegadaAuto(j)) = tiempoCobro3) Or ((reloj - horaLlegadaAuto(j)) = tiempoCobro2) Or ((reloj - horaLlegadaAuto(j)) = tiempoCobro1)) Then
                    If evento = "Fin de Cobro" And estadoAuto(j) = "Siendo Cobrado" Then
                        tipoAuto(j) = Nothing
                        horaLlegadaAuto(j) = Nothing
                        estadoAuto(j) = Nothing
                        lugarAuto(j) = Nothing
                    End If
                    If evento = "Fin de Estadía" And evento_1 = "Fin de Estadía" And estadoAuto(j) = "Siendo Cobrado" Then
                        If (((horaLlegadaAuto(j) + 60) = reloj) Or ((horaLlegadaAuto(j) + 120) = reloj) Or ((horaLlegadaAuto(j) + 180) = reloj) Or ((horaLlegadaAuto(j) + 240) = reloj)) Then

                        Else
                            tipoAuto(j) = Nothing
                            horaLlegadaAuto(j) = Nothing
                            estadoAuto(j) = Nothing
                            lugarAuto(j) = Nothing
                        End If
                    End If
                Next

                ''Borra el estacionamiento "j".
                'For j = 0 To 19
                '    If estacionamiento(j) = reloj Then
                '        estacionamiento(j) = Nothing
                '    End If
                'Next

                ''(33)Definición del Monto a Cobrar.(AGREGAR)
                For j = 0 To 19
                    'If evento = "Fin de Estadía" And estadoAuto(j) = "Siendo Cobrado" And ((horaLlegadaAuto(j) + reloj = 60) Or (horaLlegadaAuto(j) + reloj = 120) Or (horaLlegadaAuto(j) + reloj = 180) Or (horaLlegadaAuto(j) + reloj = 240)) Then
                    If evento = "Fin de Estadía" And estadoAuto(j) = "Siendo Cobrado" Then
                        If tipoAuto(j) = "Auto Pequeño" Then
                            If (((reloj - horaLlegadaAuto(j)) = 240)) Then
                                acRecaudacion += 4
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 180)) Then
                                acRecaudacion += 3
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 120)) Then
                                acRecaudacion += 2
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 60)) Then
                                acRecaudacion += 1
                            End If
                            Exit For
                        End If

                        If tipoAuto(j) = "Auto Grande" Then
                            If (((reloj - horaLlegadaAuto(j)) = 240)) Then
                                acRecaudacion += 4.8
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 180)) Then
                                acRecaudacion += 3.6
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 120)) Then
                                acRecaudacion += 2.4
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 60)) Then
                                acRecaudacion += 1.2
                            End If
                            Exit For
                        End If

                        If tipoAuto(j) = "Utilitario" Then
                            If (((reloj - horaLlegadaAuto(j)) = 240)) Then
                                acRecaudacion += 6
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 180)) Then
                                acRecaudacion += 4.5
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 120)) Then
                                acRecaudacion += 3
                            End If
                            If (((reloj - horaLlegadaAuto(j)) = 60)) Then
                                acRecaudacion += 1.5
                            End If
                            Exit For
                        End If
                    Else
                        acRecaudacion += 0
                    End If
                Next

                If evento = "Llegada Auto" And evento_1 = "Fin de Estadía" Then
                    minimo = finCobro
                    columna37 = "Fin de Cobro"
                    columna38 = minimo
                End If

                ''Si tengo un Fin de estadia, y antes del cobro del mismo, surge otro Fin de estadia, se guarda el valor del Fin de Cobro del último evento Fin de estadia.
                If evento = "Fin de Estadía" And evento_1 = "Fin de Estadía" And evento <> "Llegada Auto" Then
                    finCobro = finCobro_1
                    minimo = finCobro
                    finCobroTemporal = reloj + txtCobro.Text
                    columna37 = "Fin de Cobro"
                    columna38 = minimo
                    'Else
                    '    'finCobroTemporal = Nothing
                End If

                If evento_2 <> "Inicializacion" Then
                    If evento = "Fin de Cobro" And evento_1 = "Fin de Estadía" And evento_2 = "Fin de Estadía" Then
                        If (cmbColas.SelectedIndex = 0) Then
                            'Acá debería poner tiempoCobro en 2
                            'finCobro = nuevoFinCobro
                            finCobro = reloj + CInt(txtCobro.Text)
                            minimo = finCobro
                            columna37 = "Fin de Cobro"
                            columna38 = minimo
                        Else
                            finCobro = nuevoFinCobro
                            minimo = finCobro
                            columna37 = "Fin de Cobro"
                            columna38 = minimo
                        End If
                    ElseIf evento = "Fin de Cobro" And evento_1 = "Fin de Cobro" And evento_2 = "Fin de Estadía" And (cmbColas.SelectedIndex = 1) Then
                        finCobro = finCobroTemporal
                        'minimo = finCobro
                        'columna38 = minimo
                    Else
                        'finCobroTemporal = Nothing
                    End If
                End If

                If evento = "Fin de Estadía" And evento_1 = "Fin de Cobro" And evento_2 = "Fin de Cobro" Then
                    finCobro = reloj + CInt(txtCobro.Text)
                    minimo = finCobro
                    columna37 = "Fin de Cobro"
                    columna38 = minimo
                End If

                If evento = "Fin de Cobro" And evento_1 = "Fin de Estadía" And evento_2 = "Fin de Estadía" And cmbColas.SelectedIndex = 1 Then
                    finCobro = finCobroTemporal
                    If finCobro <= proximaLlegada Then
                        minimo = finCobro
                        columna38 = minimo
                    End If
                End If

                ''Contador de Autos
                If evento = "Fin de Cobro" Then
                    If cocheraOcupada = 21 Then
                        cocheraOcupada -= 2
                    ElseIf cocheraOcupada >= 0 Then
                        cocheraOcupada -= 1
                    Else
                        cocheraOcupada = 0
                    End If
                End If

                ''(32)Definición de la cantidad de Autos Aceptados en el sistema.
                ''(33)Definición de la cantidad de Autos Rechazados en el sistema.
                If cocheraOcupada <= 20 And evento = "Llegada Auto" Then
                    autosAceptados += 1
                ElseIf cocheraOcupada > 20 And evento = "Llegada Auto" Then
                    'autosRechazados += 1
                    'rnd2 = Nothing
                    'tiempoAtencion = Nothing
                    ''estacionamiento(numero4) = Nothing
                    'tiempoCobro = Nothing
                    'finCobro = Nothing
                End If

                ''Definición de Colas
                ''COLA 1
                If cmbColas.SelectedIndex = 0 Then
                    ''(29)Definición del Estado de la Caja 1.
                    ''(30)Definición de la Cola de la Caja 1.(ver)
                    If evento_1 <> "Inicializacion" Then
                        If evento = "Fin de Estadía" Then
                            estadoCola1 = "Ocupado"
                            If finCobro <> Nothing And evento_1 = "Fin de Estadía" Then
                                cola1 += 1
                            End If
                        ElseIf evento = "Fin de Cobro" And evento_1 = "Fin de Estadía" And evento_2 = "Fin de Estadía" Then
                            estadoCola1 = "Ocupado"
                            cola1 -= 1
                        ElseIf evento = "Llegada Auto" And evento_1 = "Fin de Estadía" Then
                            estadoCola1 = "Ocupado"
                        Else
                            estadoCola1 = "Libre"
                            cola1 = 0
                        End If

                        If finCobro = 0 And cola1 > 0 And evento = "Fin de Cobro" Then
                            cola1 -= 1
                        End If
                    End If

                    If cola1 > 0 Then
                        estadoCola1 = "Ocupado"
                    End If

                    ''COLA 2
                ElseIf cmbColas.SelectedIndex = 1 Then
                    If evento_1 <> "Inicializacion" Then

                        If estadoCola1 = "Ocupado" And evento = "Llegada Auto" Then
                            estadoCola1 = "Ocupado"

                        ElseIf evento = "Fin de Estadía" Then
                            estadoCola1 = "Ocupado"

                        ElseIf reloj = finCobro_1 And cola1 = 0 Then
                            estadoCola1 = "Libre"

                        ElseIf evento = "Fin de Cobro" And evento_1 <> "Fin de Cobro" Then
                            estadoCola1 = "Ocupado"

                        Else
                            estadoCola1 = "Libre"
                            cola1 = 0
                        End If
                        If finCobro = 0 And cola1 > 0 And evento = "Fin de Cobro" Then
                            cola1 -= 1
                        End If
                    End If

                    If cola1 > 0 Then
                        estadoCola1 = "Ocupado"
                    End If

                    If evento_1 <> "Inicializacion" Then
                        If evento = "Fin de Cobro" And evento_1 = "Fin de Cobro" And estadoCola2 = "Libre" Then
                            estadoCola2 = "Ocupado"
                        ElseIf evento_1 = "Fin de Estadía" And evento_2 = "Fin de Estadía" Then
                            estadoCola2 = "Ocupado"
                        ElseIf evento = "Fin de Estadía" And evento_1 = "Fin de Estadía" And estadoCola1 = "Ocupado" Then
                            estadoCola2 = "Ocupado"
                        Else
                            estadoCola2 = "Libre"
                        End If
                        If finCobro <> Nothing And cola1 > 0 And evento = "Fin de Cobro" Then
                            cola2 -= 1
                        End If
                    End If

                    If cola2 > 0 Then
                        estadoCola2 = "Ocupado"
                    End If
                End If

                ''Guardado del mínimo (Hora próxima del reloj).
                columna38 = minimo

                ''Borra Ceros.
                'For j = 0 To 19
                '    If lugarAuto(j) = 0 Then
                '        tipoAuto(j) = Nothing
                '        horaLlegadaAuto(j) = Nothing
                '        estadoAuto(j) = Nothing
                '        lugarAuto(j) = Nothing
                '    End If
                'Next

                'Agrega Fila.
                'If (reloj >= desde And reloj <= hasta) Then
                If (reloj >= desde And count < iteraciones) Then
                    dgvResultados.Rows.Add(evento, reloj, rnd1, tiempoEntreLlegadas, proximaLlegada, rnd2, tiempoAtencion, estacionamiento(0), estacionamiento(1),
                            estacionamiento(2), estacionamiento(3), estacionamiento(4), estacionamiento(5), estacionamiento(6), estacionamiento(7),
                            estacionamiento(8), estacionamiento(9), estacionamiento(10), estacionamiento(11), estacionamiento(12), estacionamiento(13),
                            estacionamiento(14), estacionamiento(15), estacionamiento(16), estacionamiento(17), estacionamiento(18), estacionamiento(19),
                            tiempoCobro, finCobro, estadoCola1, cola1, estadoCola2, cola2, acRecaudacion, autosAceptados, autosRechazados, rnd3,
                            tipoAuto(0), horaLlegadaAuto(0), estadoAuto(0), lugarAuto(0),
                            tipoAuto(1), horaLlegadaAuto(1), estadoAuto(1), lugarAuto(1),
                            tipoAuto(2), horaLlegadaAuto(2), estadoAuto(2), lugarAuto(2),
                            tipoAuto(3), horaLlegadaAuto(3), estadoAuto(3), lugarAuto(3),
                            tipoAuto(4), horaLlegadaAuto(4), estadoAuto(4), lugarAuto(4),
                            tipoAuto(5), horaLlegadaAuto(5), estadoAuto(5), lugarAuto(5),
                            tipoAuto(6), horaLlegadaAuto(6), estadoAuto(6), lugarAuto(6),
                            tipoAuto(7), horaLlegadaAuto(7), estadoAuto(7), lugarAuto(7),
                            tipoAuto(8), horaLlegadaAuto(8), estadoAuto(8), lugarAuto(8),
                            tipoAuto(9), horaLlegadaAuto(9), estadoAuto(9), lugarAuto(9),
                            tipoAuto(10), horaLlegadaAuto(10), estadoAuto(10), lugarAuto(10),
                            tipoAuto(11), horaLlegadaAuto(11), estadoAuto(11), lugarAuto(11),
                            tipoAuto(12), horaLlegadaAuto(12), estadoAuto(12), lugarAuto(12),
                            tipoAuto(13), horaLlegadaAuto(13), estadoAuto(13), lugarAuto(13),
                            tipoAuto(14), horaLlegadaAuto(14), estadoAuto(14), lugarAuto(14),
                            tipoAuto(15), horaLlegadaAuto(15), estadoAuto(15), lugarAuto(15),
                            tipoAuto(16), horaLlegadaAuto(16), estadoAuto(16), lugarAuto(16),
                            tipoAuto(17), horaLlegadaAuto(17), estadoAuto(17), lugarAuto(17),
                            tipoAuto(18), horaLlegadaAuto(18), estadoAuto(18), lugarAuto(18),
                            tipoAuto(19), horaLlegadaAuto(19), estadoAuto(19), lugarAuto(19))
                    count += 1
                End If

                ''Defino Siguiente Reloj.
                reloj = columna38

                ''Agrega la última fila
                If reloj >= hasta Then
                    dgvResultados.Rows.Add(evento, reloj, rnd1, tiempoEntreLlegadas, proximaLlegada, rnd2, tiempoAtencion, estacionamiento(0), estacionamiento(1),
                            estacionamiento(2), estacionamiento(3), estacionamiento(4), estacionamiento(5), estacionamiento(6), estacionamiento(7),
                            estacionamiento(8), estacionamiento(9), estacionamiento(10), estacionamiento(11), estacionamiento(12), estacionamiento(13),
                            estacionamiento(14), estacionamiento(15), estacionamiento(16), estacionamiento(17), estacionamiento(18), estacionamiento(19),
                            tiempoCobro, finCobro, estadoCola1, cola1, estadoCola2, cola2, acRecaudacion, autosAceptados, autosRechazados, rnd3,
                            tipoAuto(0), horaLlegadaAuto(0), estadoAuto(0), lugarAuto(0),
                            tipoAuto(1), horaLlegadaAuto(1), estadoAuto(1), lugarAuto(1),
                            tipoAuto(2), horaLlegadaAuto(2), estadoAuto(2), lugarAuto(2),
                            tipoAuto(3), horaLlegadaAuto(3), estadoAuto(3), lugarAuto(3),
                            tipoAuto(4), horaLlegadaAuto(4), estadoAuto(4), lugarAuto(4),
                            tipoAuto(5), horaLlegadaAuto(5), estadoAuto(5), lugarAuto(5),
                            tipoAuto(6), horaLlegadaAuto(6), estadoAuto(6), lugarAuto(6),
                            tipoAuto(7), horaLlegadaAuto(7), estadoAuto(7), lugarAuto(7),
                            tipoAuto(8), horaLlegadaAuto(8), estadoAuto(8), lugarAuto(8),
                            tipoAuto(9), horaLlegadaAuto(9), estadoAuto(9), lugarAuto(9),
                            tipoAuto(10), horaLlegadaAuto(10), estadoAuto(10), lugarAuto(10),
                            tipoAuto(11), horaLlegadaAuto(11), estadoAuto(11), lugarAuto(11),
                            tipoAuto(12), horaLlegadaAuto(12), estadoAuto(12), lugarAuto(12),
                            tipoAuto(13), horaLlegadaAuto(13), estadoAuto(13), lugarAuto(13),
                            tipoAuto(14), horaLlegadaAuto(14), estadoAuto(14), lugarAuto(14),
                            tipoAuto(15), horaLlegadaAuto(15), estadoAuto(15), lugarAuto(15),
                            tipoAuto(16), horaLlegadaAuto(16), estadoAuto(16), lugarAuto(16),
                            tipoAuto(17), horaLlegadaAuto(17), estadoAuto(17), lugarAuto(17),
                            tipoAuto(18), horaLlegadaAuto(18), estadoAuto(18), lugarAuto(18),
                            tipoAuto(19), horaLlegadaAuto(19), estadoAuto(19), lugarAuto(19))
                End If
            Loop While reloj <= hasta

            For i = 0 To dgvResultados.RowCount - 1
                'Pinta la celda que sea la del mínimo.
                minimoColoreado = dgvResultados.Rows(i).Cells(4).Value
                For j = 7 To 26
                    If dgvResultados.Rows(i).Cells(j).Value < minimoColoreado And dgvResultados.Rows(i).Cells(j).Value <> 0 Then
                        minimoColoreado = dgvResultados.Rows(i).Cells(j).Value
                        flagColor = j
                    End If
                Next
                If dgvResultados.Rows(i).Cells(28).Value < minimoColoreado And dgvResultados.Rows(i).Cells(28).Value <> 0 Then
                    minimoColoreado = dgvResultados.Rows(i).Cells(28).Value
                    flagColor = 2
                End If
                If dgvResultados.Rows(i).Cells(4).Value <= minimoColoreado And dgvResultados.Rows(i).Cells(4).Value <> 0 Then
                    dgvResultados.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                    minimoColoreado = dgvResultados.Rows(i).Cells(4).Value
                    flagColor = 3
                End If

                If flagColor = 2 Then
                    dgvResultados.Rows(i).Cells(28).Style.BackColor = Color.Yellow
                ElseIf flagColor = 3 Then
                    dgvResultados.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                Else
                    dgvResultados.Rows(i).Cells(flagColor).Style.BackColor = Color.Yellow
                End If

                flagColor = Nothing

                ''Colorea de a grupos de 4 columnas (Beige).
                For j = 37 To (dgvResultados.ColumnCount - 1) Step 8
                    ''Columna de la Hora de Llegada del Auto.
                    For k = 38 To (dgvResultados.ColumnCount - 1) Step 8
                        dgvResultados.Rows(i).Cells(k).Style.BackColor = Color.Beige
                        If dgvResultados.Rows(i).Cells(k).Value = 0.00 Then
                            dgvResultados.Rows(i).Cells(k).Value = Nothing
                        End If
                    Next

                    ''Columna del Estado del Auto.
                    For l = 39 To (dgvResultados.ColumnCount - 1) Step 8
                        dgvResultados.Rows(i).Cells(l).Style.BackColor = Color.Beige
                    Next

                    ''Columna del Lugar de Estacionamiento del Auto.
                    For m = 40 To (dgvResultados.ColumnCount - 1) Step 8
                        dgvResultados.Rows(i).Cells(m).Style.BackColor = Color.Beige
                        If dgvResultados.Rows(i).Cells(m).Value = 0 Then
                            dgvResultados.Rows(i).Cells(m).Value = Nothing
                        End If
                    Next

                    ''Columna del Tipo de Auto.
                    dgvResultados.Rows(i).Cells(j).Style.BackColor = Color.Beige
                Next

                ''Grupos de 4 columnas que quedaron en blanco, deja los valores en Nothing cuando es el caso.
                For j = 41 To (dgvResultados.ColumnCount - 1) Step 8
                    ''Columna de la Hora de Llegada del Auto.
                    For k = 42 To (dgvResultados.ColumnCount - 1) Step 8
                        dgvResultados.Rows(i).Cells(k).Style.BackColor = Color.NavajoWhite
                        If dgvResultados.Rows(i).Cells(k).Value = 0.00 Then
                            dgvResultados.Rows(i).Cells(k).Value = Nothing
                        End If
                    Next

                    ''Columna del Estado del Auto.
                    For l = 43 To (dgvResultados.ColumnCount - 1) Step 8
                        dgvResultados.Rows(i).Cells(l).Style.BackColor = Color.NavajoWhite
                    Next

                    ''Columna del Lugar de Estacionamiento del Auto.
                    For m = 44 To (dgvResultados.ColumnCount - 1) Step 8
                        dgvResultados.Rows(i).Cells(m).Style.BackColor = Color.NavajoWhite
                        If dgvResultados.Rows(i).Cells(m).Value = 0 Then
                            dgvResultados.Rows(i).Cells(m).Value = Nothing
                        End If
                    Next

                    ''Columna del Tipo de Auto.
                    dgvResultados.Rows(i).Cells(j).Style.BackColor = Color.NavajoWhite
                Next
            Next
        Else
            If txtIndice.Text = "" Then
                MessageBox.Show("Ingrese el índice de llegada de coches deseado.")
            End If

            If txtCobro.Text = "" Then
                MessageBox.Show("Ingrese el tiempo de cobro deseado.")
            End If

            If txtIteraciones.Text = "" Then
                MessageBox.Show("Ingrese la cantidad de iteraciones deseadas.")
            End If

            If txtInicio.Text = "" Then
                MessageBox.Show("Ingrese la hora inicial deseada.")
            End If

            If cmbColas.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione la cantidad de colas deseada.")
            End If
        End If
    End Sub
End Class