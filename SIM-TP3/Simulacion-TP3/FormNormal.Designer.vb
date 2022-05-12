<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNormal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnGrafico2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvFrecuencias = New System.Windows.Forms.DataGridView()
        Me.Desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrecuenciaMarcaClase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Probabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.columna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbIntervalos = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.btnChi = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtDesviacion = New System.Windows.Forms.TextBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.histograma = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFrecuencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.histograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGrafico2
        '
        Me.btnGrafico2.Location = New System.Drawing.Point(22, 607)
        Me.btnGrafico2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGrafico2.Name = "btnGrafico2"
        Me.btnGrafico2.Size = New System.Drawing.Size(544, 28)
        Me.btnGrafico2.TabIndex = 0
        Me.btnGrafico2.Text = "Generar Gráfico Chi Cuadrado"
        Me.btnGrafico2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvFrecuencias)
        Me.GroupBox2.Controls.Add(Me.dgvResultados)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 220)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(631, 383)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'dgvFrecuencias
        '
        Me.dgvFrecuencias.AllowUserToAddRows = False
        Me.dgvFrecuencias.AllowUserToDeleteRows = False
        Me.dgvFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFrecuencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Desde, Me.Hasta, Me.Marca, Me.fo, Me.fe, Me.FrecuenciaMarcaClase, Me.Probabilidad, Me.C, Me.Acumulado})
        Me.dgvFrecuencias.Location = New System.Drawing.Point(17, 202)
        Me.dgvFrecuencias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvFrecuencias.Name = "dgvFrecuencias"
        Me.dgvFrecuencias.ReadOnly = True
        Me.dgvFrecuencias.RowTemplate.Height = 24
        Me.dgvFrecuencias.Size = New System.Drawing.Size(601, 167)
        Me.dgvFrecuencias.TabIndex = 11
        '
        'Desde
        '
        Me.Desde.HeaderText = "Desde"
        Me.Desde.Name = "Desde"
        Me.Desde.ReadOnly = True
        '
        'Hasta
        '
        Me.Hasta.HeaderText = "Hasta"
        Me.Hasta.Name = "Hasta"
        Me.Hasta.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca de Clase"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Visible = False
        '
        'fo
        '
        Me.fo.HeaderText = "fo"
        Me.fo.Name = "fo"
        Me.fo.ReadOnly = True
        '
        'fe
        '
        Me.fe.HeaderText = "fe"
        Me.fe.Name = "fe"
        Me.fe.ReadOnly = True
        '
        'FrecuenciaMarcaClase
        '
        Me.FrecuenciaMarcaClase.HeaderText = "f(mc)"
        Me.FrecuenciaMarcaClase.Name = "FrecuenciaMarcaClase"
        Me.FrecuenciaMarcaClase.ReadOnly = True
        Me.FrecuenciaMarcaClase.Visible = False
        '
        'Probabilidad
        '
        Me.Probabilidad.HeaderText = "P()"
        Me.Probabilidad.Name = "Probabilidad"
        Me.Probabilidad.ReadOnly = True
        Me.Probabilidad.Visible = False
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        '
        'Acumulado
        '
        Me.Acumulado.HeaderText = "C (AC)"
        Me.Acumulado.Name = "Acumulado"
        Me.Acumulado.ReadOnly = True
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columna1, Me.Numero})
        Me.dgvResultados.Location = New System.Drawing.Point(205, 31)
        Me.dgvResultados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.RowTemplate.Height = 24
        Me.dgvResultados.Size = New System.Drawing.Size(245, 167)
        Me.dgvResultados.TabIndex = 10
        '
        'columna1
        '
        Me.columna1.HeaderText = "i"
        Me.columna1.Name = "columna1"
        Me.columna1.ReadOnly = True
        '
        'Numero
        '
        Me.Numero.HeaderText = "Número"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbIntervalos)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtN)
        Me.GroupBox1.Controls.Add(Me.btnChi)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Controls.Add(Me.txtDesviacion)
        Me.GroupBox1.Controls.Add(Me.txtMedia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(582, 204)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 92)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Intervalos:"
        '
        'cmbIntervalos
        '
        Me.cmbIntervalos.FormattingEnabled = True
        Me.cmbIntervalos.Items.AddRange(New Object() {"5", "10", "15"})
        Me.cmbIntervalos.Location = New System.Drawing.Point(79, 89)
        Me.cmbIntervalos.Name = "cmbIntervalos"
        Me.cmbIntervalos.Size = New System.Drawing.Size(66, 21)
        Me.cmbIntervalos.TabIndex = 3
        Me.cmbIntervalos.Text = "Cantidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(159, 66)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "(Tamaño)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(59, 66)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "n:"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(79, 64)
        Me.txtN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(76, 20)
        Me.txtN.TabIndex = 2
        '
        'btnChi
        '
        Me.btnChi.Location = New System.Drawing.Point(235, 155)
        Me.btnChi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChi.Name = "btnChi"
        Me.btnChi.Size = New System.Drawing.Size(188, 22)
        Me.btnChi.TabIndex = 7
        Me.btnChi.Text = "Prueba de Chi Cuadrado"
        Me.btnChi.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(274, 128)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(111, 22)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(274, 102)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(111, 22)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtDesviacion
        '
        Me.txtDesviacion.Location = New System.Drawing.Point(79, 40)
        Me.txtDesviacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesviacion.Name = "txtDesviacion"
        Me.txtDesviacion.Size = New System.Drawing.Size(76, 20)
        Me.txtDesviacion.TabIndex = 1
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(79, 16)
        Me.txtMedia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(76, 20)
        Me.txtMedia.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Desviación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Media: "
        '
        'histograma
        '
        ChartArea2.Name = "ChartArea1"
        Me.histograma.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.histograma.Legends.Add(Legend2)
        Me.histograma.Location = New System.Drawing.Point(643, 12)
        Me.histograma.Name = "histograma"
        Series3.BorderColor = System.Drawing.Color.Black
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Frecuencia Observada"
        Series4.BorderColor = System.Drawing.Color.Black
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Frecuencia Esperada"
        Me.histograma.Series.Add(Series3)
        Me.histograma.Series.Add(Series4)
        Me.histograma.Size = New System.Drawing.Size(797, 655)
        Me.histograma.TabIndex = 24
        Me.histograma.Text = "Histograma"
        '
        'FormNormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1452, 679)
        Me.Controls.Add(Me.histograma)
        Me.Controls.Add(Me.btnGrafico2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormNormal"
        Me.Text = "FormNormal"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvFrecuencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.histograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGrafico2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvFrecuencias As DataGridView
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbIntervalos As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents btnChi As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtDesviacion As TextBox
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents columna1 As DataGridViewTextBoxColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents histograma As DataVisualization.Charting.Chart
    Friend WithEvents Desde As DataGridViewTextBoxColumn
    Friend WithEvents Hasta As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents fo As DataGridViewTextBoxColumn
    Friend WithEvents fe As DataGridViewTextBoxColumn
    Friend WithEvents FrecuenciaMarcaClase As DataGridViewTextBoxColumn
    Friend WithEvents Probabilidad As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents Acumulado As DataGridViewTextBoxColumn
End Class
