<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCongruencialMultiplicativo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtXo = New System.Windows.Forms.TextBox()
        Me.txtK = New System.Windows.Forms.TextBox()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnChi = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbIntervalos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.columna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvNumeros = New System.Windows.Forms.DataGridView()
        Me.Iteración = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Número = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvFrecuencias = New System.Windows.Forms.DataGridView()
        Me.Intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGrafico = New System.Windows.Forms.Button()
        Me.histograma = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFrecuencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.histograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Xo: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "k:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "g:"
        '
        'txtXo
        '
        Me.txtXo.Location = New System.Drawing.Point(35, 17)
        Me.txtXo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtXo.Name = "txtXo"
        Me.txtXo.Size = New System.Drawing.Size(76, 20)
        Me.txtXo.TabIndex = 0
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(35, 40)
        Me.txtK.Margin = New System.Windows.Forms.Padding(2)
        Me.txtK.Name = "txtK"
        Me.txtK.Size = New System.Drawing.Size(76, 20)
        Me.txtK.TabIndex = 1
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(35, 62)
        Me.txtG.Margin = New System.Windows.Forms.Padding(2)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(76, 20)
        Me.txtG.TabIndex = 2
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(35, 86)
        Me.txtA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(76, 20)
        Me.txtA.TabIndex = 3
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(35, 108)
        Me.txtM.Margin = New System.Windows.Forms.Padding(2)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(76, 20)
        Me.txtM.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "a:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "m:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "(Semilla)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 88)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "(Constante Multiplicativa)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(115, 111)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "(Módulo)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(308, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(232, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Xo, a, m, g deben ser enteros y mayores a cero."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(308, 33)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Xo tiene que ser un número impar."
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(266, 64)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(111, 22)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(266, 120)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(111, 22)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(35, 131)
        Me.txtN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(76, 20)
        Me.txtN.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 133)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "n:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(115, 133)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "(Tamaño)"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(266, 93)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(111, 22)
        Me.btnSiguiente.TabIndex = 8
        Me.btnSiguiente.Text = "Siguiente Número"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnChi
        '
        Me.btnChi.Location = New System.Drawing.Point(229, 146)
        Me.btnChi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChi.Name = "btnChi"
        Me.btnChi.Size = New System.Drawing.Size(188, 22)
        Me.btnChi.TabIndex = 10
        Me.btnChi.Text = "Prueba de Chi Cuadrado"
        Me.btnChi.UseVisualStyleBackColor = True
        Me.btnChi.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 175)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Intervalos:"
        Me.Label15.Visible = False
        '
        'cmbIntervalos
        '
        Me.cmbIntervalos.FormattingEnabled = True
        Me.cmbIntervalos.Items.AddRange(New Object() {"5", "10", "15"})
        Me.cmbIntervalos.Location = New System.Drawing.Point(71, 172)
        Me.cmbIntervalos.Name = "cmbIntervalos"
        Me.cmbIntervalos.Size = New System.Drawing.Size(73, 21)
        Me.cmbIntervalos.TabIndex = 6
        Me.cmbIntervalos.Text = "Cantidad"
        Me.cmbIntervalos.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbIntervalos)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.btnChi)
        Me.GroupBox1.Controls.Add(Me.btnSiguiente)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtN)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtM)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Controls.Add(Me.txtG)
        Me.GroupBox1.Controls.Add(Me.txtK)
        Me.GroupBox1.Controls.Add(Me.txtXo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(582, 204)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columna1, Me.columna2, Me.columna3, Me.columna4, Me.columna5})
        Me.dgvResultados.Location = New System.Drawing.Point(80, 210)
        Me.dgvResultados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.RowTemplate.Height = 24
        Me.dgvResultados.Size = New System.Drawing.Size(443, 167)
        Me.dgvResultados.TabIndex = 10
        '
        'columna1
        '
        Me.columna1.HeaderText = "i"
        Me.columna1.Name = "columna1"
        Me.columna1.ReadOnly = True
        '
        'columna2
        '
        Me.columna2.HeaderText = "a.Xi"
        Me.columna2.Name = "columna2"
        Me.columna2.ReadOnly = True
        '
        'columna3
        '
        Me.columna3.HeaderText = "Xi+1"
        Me.columna3.Name = "columna3"
        Me.columna3.ReadOnly = True
        '
        'columna4
        '
        Me.columna4.HeaderText = "(Xi+1)/(m-1)"
        Me.columna4.Name = "columna4"
        Me.columna4.ReadOnly = True
        '
        'columna5
        '
        Me.columna5.HeaderText = "Xi/(m-1)"
        Me.columna5.Name = "columna5"
        Me.columna5.ReadOnly = True
        Me.columna5.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvNumeros)
        Me.GroupBox2.Controls.Add(Me.dgvResultados)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 219)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(582, 381)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'dgvNumeros
        '
        Me.dgvNumeros.AllowUserToAddRows = False
        Me.dgvNumeros.AllowUserToDeleteRows = False
        Me.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Iteración, Me.Número})
        Me.dgvNumeros.Location = New System.Drawing.Point(173, 17)
        Me.dgvNumeros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvNumeros.Name = "dgvNumeros"
        Me.dgvNumeros.ReadOnly = True
        Me.dgvNumeros.RowTemplate.Height = 24
        Me.dgvNumeros.Size = New System.Drawing.Size(244, 189)
        Me.dgvNumeros.TabIndex = 13
        '
        'Iteración
        '
        Me.Iteración.HeaderText = "i"
        Me.Iteración.Name = "Iteración"
        Me.Iteración.ReadOnly = True
        '
        'Número
        '
        Me.Número.HeaderText = "n"
        Me.Número.Name = "Número"
        Me.Número.ReadOnly = True
        '
        'dgvFrecuencias
        '
        Me.dgvFrecuencias.AllowUserToAddRows = False
        Me.dgvFrecuencias.AllowUserToDeleteRows = False
        Me.dgvFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFrecuencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Intervalo, Me.fo, Me.fe, Me.C, Me.Acumulado})
        Me.dgvFrecuencias.Enabled = False
        Me.dgvFrecuencias.Location = New System.Drawing.Point(621, 295)
        Me.dgvFrecuencias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvFrecuencias.Name = "dgvFrecuencias"
        Me.dgvFrecuencias.ReadOnly = True
        Me.dgvFrecuencias.RowTemplate.Height = 24
        Me.dgvFrecuencias.Size = New System.Drawing.Size(544, 167)
        Me.dgvFrecuencias.TabIndex = 12
        '
        'Intervalo
        '
        Me.Intervalo.HeaderText = "Intervalo"
        Me.Intervalo.Name = "Intervalo"
        Me.Intervalo.ReadOnly = True
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
        'btnGrafico
        '
        Me.btnGrafico.Location = New System.Drawing.Point(21, 614)
        Me.btnGrafico.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGrafico.Name = "btnGrafico"
        Me.btnGrafico.Size = New System.Drawing.Size(544, 28)
        Me.btnGrafico.TabIndex = 0
        Me.btnGrafico.Text = "Generar Gráfico"
        Me.btnGrafico.UseVisualStyleBackColor = True
        '
        'histograma
        '
        ChartArea1.Name = "ChartArea1"
        Me.histograma.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.histograma.Legends.Add(Legend1)
        Me.histograma.Location = New System.Drawing.Point(606, 26)
        Me.histograma.Name = "histograma"
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Frecuencia"
        Me.histograma.Series.Add(Series1)
        Me.histograma.Size = New System.Drawing.Size(724, 604)
        Me.histograma.TabIndex = 4
        Me.histograma.Text = "Histograma"
        Me.histograma.Visible = False
        '
        'FormCongruencialMultiplicativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 599)
        Me.Controls.Add(Me.dgvFrecuencias)
        Me.Controls.Add(Me.btnGrafico)
        Me.Controls.Add(Me.histograma)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCongruencialMultiplicativo"
        Me.Text = "FormCongruencialMultiplicativo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFrecuencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.histograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtXo As TextBox
    Friend WithEvents txtK As TextBox
    Friend WithEvents txtG As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnChi As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbIntervalos As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvFrecuencias As DataGridView
    Friend WithEvents Intervalo As DataGridViewTextBoxColumn
    Friend WithEvents fo As DataGridViewTextBoxColumn
    Friend WithEvents fe As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents Acumulado As DataGridViewTextBoxColumn
    Friend WithEvents btnGrafico As Button
    Friend WithEvents histograma As DataVisualization.Charting.Chart
    Friend WithEvents dgvNumeros As DataGridView
    Friend WithEvents Iteración As DataGridViewTextBoxColumn
    Friend WithEvents Número As DataGridViewTextBoxColumn
    Friend WithEvents columna1 As DataGridViewTextBoxColumn
    Friend WithEvents columna2 As DataGridViewTextBoxColumn
    Friend WithEvents columna3 As DataGridViewTextBoxColumn
    Friend WithEvents columna4 As DataGridViewTextBoxColumn
    Friend WithEvents columna5 As DataGridViewTextBoxColumn
End Class
