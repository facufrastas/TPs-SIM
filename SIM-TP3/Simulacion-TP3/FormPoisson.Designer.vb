<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPoisson
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.histograma = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnGrafico2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvFrecuencias = New System.Windows.Forms.DataGridView()
        Me.Desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Probabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.columna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLambda = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbIntervalos = New System.Windows.Forms.ComboBox()
        Me.btnChi = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        CType(Me.histograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFrecuencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'histograma
        '
        ChartArea1.Name = "ChartArea1"
        Me.histograma.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.histograma.Legends.Add(Legend1)
        Me.histograma.Location = New System.Drawing.Point(646, 10)
        Me.histograma.Name = "histograma"
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Frecuencia Observada"
        Series2.BorderColor = System.Drawing.Color.Black
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Frecuencia Esperada"
        Me.histograma.Series.Add(Series1)
        Me.histograma.Series.Add(Series2)
        Me.histograma.Size = New System.Drawing.Size(803, 655)
        Me.histograma.TabIndex = 26
        Me.histograma.Text = "Histograma"
        '
        'btnGrafico2
        '
        Me.btnGrafico2.Location = New System.Drawing.Point(25, 605)
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
        Me.GroupBox2.Location = New System.Drawing.Point(10, 218)
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
        Me.dgvFrecuencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Desde, Me.Hasta, Me.Marca, Me.fo, Me.fe, Me.Probabilidad, Me.C, Me.Acumulado})
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
        Me.dgvResultados.Location = New System.Drawing.Point(202, 31)
        Me.dgvResultados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.RowTemplate.Height = 24
        Me.dgvResultados.Size = New System.Drawing.Size(246, 167)
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
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLambda)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbIntervalos)
        Me.GroupBox1.Controls.Add(Me.btnChi)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(582, 204)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(139, 43)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "(Tamaño)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "n:"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(59, 41)
        Me.txtN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(76, 20)
        Me.txtN.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Lambda:"
        '
        'txtLambda
        '
        Me.txtLambda.Location = New System.Drawing.Point(59, 17)
        Me.txtLambda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLambda.Name = "txtLambda"
        Me.txtLambda.Size = New System.Drawing.Size(76, 20)
        Me.txtLambda.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 69)
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
        Me.cmbIntervalos.Location = New System.Drawing.Point(69, 66)
        Me.cmbIntervalos.Name = "cmbIntervalos"
        Me.cmbIntervalos.Size = New System.Drawing.Size(66, 21)
        Me.cmbIntervalos.TabIndex = 2
        Me.cmbIntervalos.Text = "Cantidad"
        '
        'btnChi
        '
        Me.btnChi.Location = New System.Drawing.Point(235, 155)
        Me.btnChi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChi.Name = "btnChi"
        Me.btnChi.Size = New System.Drawing.Size(188, 22)
        Me.btnChi.TabIndex = 6
        Me.btnChi.Text = "Prueba de Chi Cuadrado"
        Me.btnChi.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(274, 128)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(111, 22)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(274, 102)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(111, 22)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'FormPoisson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1458, 675)
        Me.Controls.Add(Me.histograma)
        Me.Controls.Add(Me.btnGrafico2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPoisson"
        Me.Text = "FormPoisson"
        CType(Me.histograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvFrecuencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents histograma As DataVisualization.Charting.Chart
    Friend WithEvents btnGrafico2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvFrecuencias As DataGridView
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbIntervalos As ComboBox
    Friend WithEvents btnChi As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLambda As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents columna1 As DataGridViewTextBoxColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Desde As DataGridViewTextBoxColumn
    Friend WithEvents Hasta As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents fo As DataGridViewTextBoxColumn
    Friend WithEvents fe As DataGridViewTextBoxColumn
    Friend WithEvents Probabilidad As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents Acumulado As DataGridViewTextBoxColumn
End Class
