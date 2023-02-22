<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE_VENTAS_POR_VENDEDOR_VS_FECHA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crw = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbTodosVendedores = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbPorVendedor = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstVendedores = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDiciembre = New System.Windows.Forms.Button()
        Me.btnNoviembre = New System.Windows.Forms.Button()
        Me.btnOctubre = New System.Windows.Forms.Button()
        Me.btnSetiembre = New System.Windows.Forms.Button()
        Me.btnAgosto = New System.Windows.Forms.Button()
        Me.btnJulio = New System.Windows.Forms.Button()
        Me.btnJunio = New System.Windows.Forms.Button()
        Me.btnMayo = New System.Windows.Forms.Button()
        Me.btnAbril = New System.Windows.Forms.Button()
        Me.btnMarzo = New System.Windows.Forms.Button()
        Me.btnFebrero = New System.Windows.Forms.Button()
        Me.btnEnero = New System.Windows.Forms.Button()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbDetallado = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbResumido = New System.Windows.Forms.RadioButton()
        Me.lstAnho = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(156, 553)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(139, 26)
        Me.btnSalir.TabIndex = 1275
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerarReporte.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerarReporte.Location = New System.Drawing.Point(9, 551)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(139, 28)
        Me.btnGenerarReporte.TabIndex = 1279
        Me.btnGenerarReporte.Text = "GENERAR REPORTE"
        Me.btnGenerarReporte.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(301, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(830, 23)
        Me.Label1.TabIndex = 1272
        Me.Label1.Text = "REPORTE DE VENTAS POR VENDEDOR VS FECHA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'crw
        '
        Me.crw.ActiveViewIndex = -1
        Me.crw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.crw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crw.Cursor = System.Windows.Forms.Cursors.Default
        Me.crw.DisplayStatusBar = False
        Me.crw.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.crw.Location = New System.Drawing.Point(301, 73)
        Me.crw.Name = "crw"
        Me.crw.Size = New System.Drawing.Size(830, 527)
        Me.crw.TabIndex = 1274
        Me.crw.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 19)
        Me.Label4.TabIndex = 1286
        Me.Label4.Text = "CRITERIOS DE BUSQUEDA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(301, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(830, 23)
        Me.Label3.TabIndex = 1273
        Me.Label3.Text = "Detalles de Visualizacion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbTodosVendedores
        '
        Me.rbTodosVendedores.AutoSize = True
        Me.rbTodosVendedores.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodosVendedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbTodosVendedores.Location = New System.Drawing.Point(8, 42)
        Me.rbTodosVendedores.Name = "rbTodosVendedores"
        Me.rbTodosVendedores.Size = New System.Drawing.Size(138, 17)
        Me.rbTodosVendedores.TabIndex = 1288
        Me.rbTodosVendedores.TabStop = True
        Me.rbTodosVendedores.Text = "Todos los Vendedores"
        Me.rbTodosVendedores.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(5, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 23)
        Me.Label5.TabIndex = 1289
        Me.Label5.Text = "SELECCIONAR VENDEDOR/ES"
        '
        'rbPorVendedor
        '
        Me.rbPorVendedor.AutoSize = True
        Me.rbPorVendedor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPorVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPorVendedor.Location = New System.Drawing.Point(152, 42)
        Me.rbPorVendedor.Name = "rbPorVendedor"
        Me.rbPorVendedor.Size = New System.Drawing.Size(95, 17)
        Me.rbPorVendedor.TabIndex = 1290
        Me.rbPorVendedor.TabStop = True
        Me.rbPorVendedor.Text = "Por Vendedor"
        Me.rbPorVendedor.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 50012
        Me.Label7.Text = "SELECCIONAR MES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTodosVendedores)
        Me.GroupBox1.Controls.Add(Me.lstVendedores)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbPorVendedor)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 172)
        Me.GroupBox1.TabIndex = 50013
        Me.GroupBox1.TabStop = False
        '
        'lstVendedores
        '
        Me.lstVendedores.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVendedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstVendedores.FormattingEnabled = True
        Me.lstVendedores.Location = New System.Drawing.Point(8, 65)
        Me.lstVendedores.Name = "lstVendedores"
        Me.lstVendedores.Size = New System.Drawing.Size(264, 95)
        Me.lstVendedores.TabIndex = 50018
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDiciembre)
        Me.GroupBox2.Controls.Add(Me.btnNoviembre)
        Me.GroupBox2.Controls.Add(Me.btnOctubre)
        Me.GroupBox2.Controls.Add(Me.btnSetiembre)
        Me.GroupBox2.Controls.Add(Me.btnAgosto)
        Me.GroupBox2.Controls.Add(Me.btnJulio)
        Me.GroupBox2.Controls.Add(Me.btnJunio)
        Me.GroupBox2.Controls.Add(Me.btnMayo)
        Me.GroupBox2.Controls.Add(Me.btnAbril)
        Me.GroupBox2.Controls.Add(Me.btnMarzo)
        Me.GroupBox2.Controls.Add(Me.btnFebrero)
        Me.GroupBox2.Controls.Add(Me.btnEnero)
        Me.GroupBox2.Controls.Add(Me.btnTodos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 122)
        Me.GroupBox2.TabIndex = 50014
        Me.GroupBox2.TabStop = False
        '
        'btnDiciembre
        '
        Me.btnDiciembre.BackColor = System.Drawing.Color.White
        Me.btnDiciembre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDiciembre.FlatAppearance.BorderSize = 0
        Me.btnDiciembre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiciembre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDiciembre.Location = New System.Drawing.Point(114, 87)
        Me.btnDiciembre.Name = "btnDiciembre"
        Me.btnDiciembre.Size = New System.Drawing.Size(53, 23)
        Me.btnDiciembre.TabIndex = 50025
        Me.btnDiciembre.Text = "Dic"
        Me.btnDiciembre.UseVisualStyleBackColor = False
        '
        'btnNoviembre
        '
        Me.btnNoviembre.BackColor = System.Drawing.Color.White
        Me.btnNoviembre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNoviembre.FlatAppearance.BorderSize = 0
        Me.btnNoviembre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoviembre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNoviembre.Location = New System.Drawing.Point(61, 87)
        Me.btnNoviembre.Name = "btnNoviembre"
        Me.btnNoviembre.Size = New System.Drawing.Size(53, 23)
        Me.btnNoviembre.TabIndex = 50024
        Me.btnNoviembre.Text = "Nov"
        Me.btnNoviembre.UseVisualStyleBackColor = False
        '
        'btnOctubre
        '
        Me.btnOctubre.BackColor = System.Drawing.Color.White
        Me.btnOctubre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOctubre.FlatAppearance.BorderSize = 0
        Me.btnOctubre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOctubre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOctubre.Location = New System.Drawing.Point(8, 87)
        Me.btnOctubre.Name = "btnOctubre"
        Me.btnOctubre.Size = New System.Drawing.Size(53, 23)
        Me.btnOctubre.TabIndex = 50023
        Me.btnOctubre.Text = "Oct"
        Me.btnOctubre.UseVisualStyleBackColor = False
        '
        'btnSetiembre
        '
        Me.btnSetiembre.BackColor = System.Drawing.Color.White
        Me.btnSetiembre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSetiembre.FlatAppearance.BorderSize = 0
        Me.btnSetiembre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetiembre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSetiembre.Location = New System.Drawing.Point(220, 58)
        Me.btnSetiembre.Name = "btnSetiembre"
        Me.btnSetiembre.Size = New System.Drawing.Size(53, 23)
        Me.btnSetiembre.TabIndex = 50022
        Me.btnSetiembre.Text = "Set"
        Me.btnSetiembre.UseVisualStyleBackColor = False
        '
        'btnAgosto
        '
        Me.btnAgosto.BackColor = System.Drawing.Color.White
        Me.btnAgosto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgosto.FlatAppearance.BorderSize = 0
        Me.btnAgosto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgosto.Location = New System.Drawing.Point(167, 58)
        Me.btnAgosto.Name = "btnAgosto"
        Me.btnAgosto.Size = New System.Drawing.Size(53, 23)
        Me.btnAgosto.TabIndex = 50021
        Me.btnAgosto.Text = "Ago"
        Me.btnAgosto.UseVisualStyleBackColor = False
        '
        'btnJulio
        '
        Me.btnJulio.BackColor = System.Drawing.Color.White
        Me.btnJulio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJulio.FlatAppearance.BorderSize = 0
        Me.btnJulio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJulio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJulio.Location = New System.Drawing.Point(114, 58)
        Me.btnJulio.Name = "btnJulio"
        Me.btnJulio.Size = New System.Drawing.Size(53, 23)
        Me.btnJulio.TabIndex = 50020
        Me.btnJulio.Text = "Jul"
        Me.btnJulio.UseVisualStyleBackColor = False
        '
        'btnJunio
        '
        Me.btnJunio.BackColor = System.Drawing.Color.White
        Me.btnJunio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJunio.FlatAppearance.BorderSize = 0
        Me.btnJunio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJunio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJunio.Location = New System.Drawing.Point(61, 58)
        Me.btnJunio.Name = "btnJunio"
        Me.btnJunio.Size = New System.Drawing.Size(53, 23)
        Me.btnJunio.TabIndex = 50019
        Me.btnJunio.Text = "Jun"
        Me.btnJunio.UseVisualStyleBackColor = False
        '
        'btnMayo
        '
        Me.btnMayo.BackColor = System.Drawing.Color.White
        Me.btnMayo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMayo.FlatAppearance.BorderSize = 0
        Me.btnMayo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMayo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMayo.Location = New System.Drawing.Point(8, 58)
        Me.btnMayo.Name = "btnMayo"
        Me.btnMayo.Size = New System.Drawing.Size(53, 23)
        Me.btnMayo.TabIndex = 50018
        Me.btnMayo.Text = "May"
        Me.btnMayo.UseVisualStyleBackColor = False
        '
        'btnAbril
        '
        Me.btnAbril.BackColor = System.Drawing.Color.White
        Me.btnAbril.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbril.FlatAppearance.BorderSize = 0
        Me.btnAbril.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbril.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbril.Location = New System.Drawing.Point(220, 29)
        Me.btnAbril.Name = "btnAbril"
        Me.btnAbril.Size = New System.Drawing.Size(53, 23)
        Me.btnAbril.TabIndex = 50017
        Me.btnAbril.Text = "Abr"
        Me.btnAbril.UseVisualStyleBackColor = False
        '
        'btnMarzo
        '
        Me.btnMarzo.BackColor = System.Drawing.Color.White
        Me.btnMarzo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMarzo.FlatAppearance.BorderSize = 0
        Me.btnMarzo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarzo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMarzo.Location = New System.Drawing.Point(167, 29)
        Me.btnMarzo.Name = "btnMarzo"
        Me.btnMarzo.Size = New System.Drawing.Size(53, 23)
        Me.btnMarzo.TabIndex = 50016
        Me.btnMarzo.Text = "Mar"
        Me.btnMarzo.UseVisualStyleBackColor = False
        '
        'btnFebrero
        '
        Me.btnFebrero.BackColor = System.Drawing.Color.White
        Me.btnFebrero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFebrero.FlatAppearance.BorderSize = 0
        Me.btnFebrero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFebrero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFebrero.Location = New System.Drawing.Point(114, 29)
        Me.btnFebrero.Name = "btnFebrero"
        Me.btnFebrero.Size = New System.Drawing.Size(53, 23)
        Me.btnFebrero.TabIndex = 50015
        Me.btnFebrero.Text = "Feb"
        Me.btnFebrero.UseVisualStyleBackColor = False
        '
        'btnEnero
        '
        Me.btnEnero.BackColor = System.Drawing.Color.White
        Me.btnEnero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnero.FlatAppearance.BorderSize = 0
        Me.btnEnero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnero.Location = New System.Drawing.Point(61, 29)
        Me.btnEnero.Name = "btnEnero"
        Me.btnEnero.Size = New System.Drawing.Size(53, 23)
        Me.btnEnero.TabIndex = 50014
        Me.btnEnero.Text = "Ene"
        Me.btnEnero.UseVisualStyleBackColor = False
        '
        'btnTodos
        '
        Me.btnTodos.BackColor = System.Drawing.Color.White
        Me.btnTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTodos.FlatAppearance.BorderSize = 0
        Me.btnTodos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTodos.Location = New System.Drawing.Point(8, 29)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(53, 23)
        Me.btnTodos.TabIndex = 50013
        Me.btnTodos.Text = "Todos"
        Me.btnTodos.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbDetallado)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.rbResumido)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 74)
        Me.GroupBox4.TabIndex = 50014
        Me.GroupBox4.TabStop = False
        '
        'rbDetallado
        '
        Me.rbDetallado.AutoSize = True
        Me.rbDetallado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDetallado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbDetallado.Location = New System.Drawing.Point(8, 42)
        Me.rbDetallado.Name = "rbDetallado"
        Me.rbDetallado.Size = New System.Drawing.Size(119, 19)
        Me.rbDetallado.TabIndex = 1288
        Me.rbDetallado.TabStop = True
        Me.rbDetallado.Text = "Reporte Detallado"
        Me.rbDetallado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(5, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 23)
        Me.Label6.TabIndex = 1289
        Me.Label6.Text = "TIPO DE VISUALIZACION"
        '
        'rbResumido
        '
        Me.rbResumido.AutoSize = True
        Me.rbResumido.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbResumido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbResumido.Location = New System.Drawing.Point(133, 42)
        Me.rbResumido.Name = "rbResumido"
        Me.rbResumido.Size = New System.Drawing.Size(122, 19)
        Me.rbResumido.TabIndex = 1290
        Me.rbResumido.TabStop = True
        Me.rbResumido.Text = "Reporte Resumido"
        Me.rbResumido.UseVisualStyleBackColor = True
        '
        'lstAnho
        '
        Me.lstAnho.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAnho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstAnho.FormattingEnabled = True
        Me.lstAnho.Location = New System.Drawing.Point(137, 402)
        Me.lstAnho.Name = "lstAnho"
        Me.lstAnho.Size = New System.Drawing.Size(120, 121)
        Me.lstAnho.TabIndex = 50016
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(12, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 50017
        Me.Label2.Text = "SELECCIONAR AÑO "
        '
        'REPORTE_VENTAS_POR_VENDEDOR_VS_FECHA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1144, 616)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstAnho)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "REPORTE_VENTAS_POR_VENDEDOR_VS_FECHA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE VENTAS POR VENDEDOR VS FECHA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGenerarReporte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crw As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbTodosVendedores As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbPorVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbResumido As System.Windows.Forms.RadioButton
    Friend WithEvents btnDiciembre As System.Windows.Forms.Button
    Friend WithEvents btnNoviembre As System.Windows.Forms.Button
    Friend WithEvents btnOctubre As System.Windows.Forms.Button
    Friend WithEvents btnSetiembre As System.Windows.Forms.Button
    Friend WithEvents btnAgosto As System.Windows.Forms.Button
    Friend WithEvents btnJulio As System.Windows.Forms.Button
    Friend WithEvents btnJunio As System.Windows.Forms.Button
    Friend WithEvents btnMayo As System.Windows.Forms.Button
    Friend WithEvents btnAbril As System.Windows.Forms.Button
    Friend WithEvents btnMarzo As System.Windows.Forms.Button
    Friend WithEvents btnFebrero As System.Windows.Forms.Button
    Friend WithEvents btnEnero As System.Windows.Forms.Button
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents lstAnho As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstVendedores As System.Windows.Forms.ListBox
End Class
