<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VISUALIZAR_CUENTA_CLIENTE
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstnombre = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNombreApellido = New System.Windows.Forms.RadioButton()
        Me.rbRuc = New System.Windows.Forms.RadioButton()
        Me.rbCedula = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbPendientes = New System.Windows.Forms.RadioButton()
        Me.rbPagados = New System.Windows.Forms.RadioButton()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCobrador = New System.Windows.Forms.TextBox()
        Me.txtFecha_Seguimiento = New System.Windows.Forms.TextBox()
        Me.txtMontoCompromiso = New System.Windows.Forms.TextBox()
        Me.dg_CuentaCliente = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgDetallesCobranza = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtCuentaActual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtCedula_Cliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dg_Historial_PagoCC = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgFacturasNo = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgFacturasPagadas = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtDeudaTotalGral = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_CuentaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetallesCobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_Historial_PagoCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFacturasNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFacturasPagadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 470)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 161)
        Me.GroupBox1.TabIndex = 1280
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exportar a"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimir.Location = New System.Drawing.Point(37, 27)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(172, 35)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(37, 65)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(172, 37)
        Me.btnLimpiar.TabIndex = 1282
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(37, 108)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(172, 34)
        Me.btnSalir.TabIndex = 1278
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lstnombre
        '
        Me.lstnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstnombre.ForeColor = System.Drawing.Color.Blue
        Me.lstnombre.FormattingEnabled = True
        Me.lstnombre.Location = New System.Drawing.Point(15, 162)
        Me.lstnombre.Name = "lstnombre"
        Me.lstnombre.Size = New System.Drawing.Size(251, 82)
        Me.lstnombre.TabIndex = 1275
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(346, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(934, 20)
        Me.Label1.TabIndex = 1276
        Me.Label1.Text = "VISUALIZAR CUENTA DE CLIENTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(343, 20)
        Me.Label2.TabIndex = 1277
        Me.Label2.Text = "Buscar Datos de Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Blue
        Me.txtCliente.Location = New System.Drawing.Point(15, 134)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(251, 22)
        Me.txtCliente.TabIndex = 1281
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNombreApellido)
        Me.GroupBox2.Controls.Add(Me.rbRuc)
        Me.GroupBox2.Controls.Add(Me.rbCedula)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(16, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 46)
        Me.GroupBox2.TabIndex = 1281
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por"
        '
        'rbNombreApellido
        '
        Me.rbNombreApellido.AutoSize = True
        Me.rbNombreApellido.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbNombreApellido.Location = New System.Drawing.Point(125, 19)
        Me.rbNombreApellido.Name = "rbNombreApellido"
        Me.rbNombreApellido.Size = New System.Drawing.Size(124, 17)
        Me.rbNombreApellido.TabIndex = 2
        Me.rbNombreApellido.TabStop = True
        Me.rbNombreApellido.Text = "NOMBRE/APELLIDO"
        Me.rbNombreApellido.UseVisualStyleBackColor = True
        '
        'rbRuc
        '
        Me.rbRuc.AutoSize = True
        Me.rbRuc.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbRuc.Location = New System.Drawing.Point(77, 19)
        Me.rbRuc.Name = "rbRuc"
        Me.rbRuc.Size = New System.Drawing.Size(47, 17)
        Me.rbRuc.TabIndex = 1
        Me.rbRuc.TabStop = True
        Me.rbRuc.Text = "RUC"
        Me.rbRuc.UseVisualStyleBackColor = True
        '
        'rbCedula
        '
        Me.rbCedula.AutoSize = True
        Me.rbCedula.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbCedula.Location = New System.Drawing.Point(8, 19)
        Me.rbCedula.Name = "rbCedula"
        Me.rbCedula.Size = New System.Drawing.Size(66, 17)
        Me.rbCedula.TabIndex = 0
        Me.rbCedula.TabStop = True
        Me.rbCedula.Text = "CEDULA"
        Me.rbCedula.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbPendientes)
        Me.GroupBox3.Controls.Add(Me.rbPagados)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(249, 39)
        Me.GroupBox3.TabIndex = 1282
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Visualizar por"
        '
        'rbPendientes
        '
        Me.rbPendientes.AutoSize = True
        Me.rbPendientes.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbPendientes.Location = New System.Drawing.Point(152, 15)
        Me.rbPendientes.Name = "rbPendientes"
        Me.rbPendientes.Size = New System.Drawing.Size(88, 17)
        Me.rbPendientes.TabIndex = 1
        Me.rbPendientes.TabStop = True
        Me.rbPendientes.Text = "PENDIENTES"
        Me.rbPendientes.UseVisualStyleBackColor = True
        '
        'rbPagados
        '
        Me.rbPagados.AutoSize = True
        Me.rbPagados.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPagados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbPagados.Location = New System.Drawing.Point(74, 15)
        Me.rbPagados.Name = "rbPagados"
        Me.rbPagados.Size = New System.Drawing.Size(73, 17)
        Me.rbPagados.TabIndex = 0
        Me.rbPagados.TabStop = True
        Me.rbPagados.Text = "PAGADAS"
        Me.rbPagados.UseVisualStyleBackColor = True
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObservacion.Location = New System.Drawing.Point(765, 141)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(413, 48)
        Me.txtObservacion.TabIndex = 1297
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(765, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 19)
        Me.Label7.TabIndex = 1301
        Me.Label7.Text = "Observacion de Seguimiento Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(948, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 19)
        Me.Label6.TabIndex = 1300
        Me.Label6.Text = "Monto Compromiso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(762, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 19)
        Me.Label5.TabIndex = 1299
        Me.Label5.Text = "Fecha Proximo Seguimiento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(768, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 19)
        Me.Label12.TabIndex = 1298
        Me.Label12.Text = "Cobrador"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCobrador
        '
        Me.txtCobrador.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCobrador.ForeColor = System.Drawing.Color.Green
        Me.txtCobrador.Location = New System.Drawing.Point(768, 57)
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.Size = New System.Drawing.Size(344, 23)
        Me.txtCobrador.TabIndex = 1303
        Me.txtCobrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFecha_Seguimiento
        '
        Me.txtFecha_Seguimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha_Seguimiento.ForeColor = System.Drawing.Color.Green
        Me.txtFecha_Seguimiento.Location = New System.Drawing.Point(765, 102)
        Me.txtFecha_Seguimiento.Name = "txtFecha_Seguimiento"
        Me.txtFecha_Seguimiento.Size = New System.Drawing.Size(177, 23)
        Me.txtFecha_Seguimiento.TabIndex = 1304
        Me.txtFecha_Seguimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoCompromiso
        '
        Me.txtMontoCompromiso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCompromiso.ForeColor = System.Drawing.Color.Green
        Me.txtMontoCompromiso.Location = New System.Drawing.Point(948, 102)
        Me.txtMontoCompromiso.Name = "txtMontoCompromiso"
        Me.txtMontoCompromiso.Size = New System.Drawing.Size(164, 23)
        Me.txtMontoCompromiso.TabIndex = 1305
        Me.txtMontoCompromiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dg_CuentaCliente
        '
        Me.dg_CuentaCliente.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_CuentaCliente.BackColor = System.Drawing.Color.White
        Me.dg_CuentaCliente.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_CuentaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_CuentaCliente.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg_CuentaCliente.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_CuentaCliente.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_CuentaCliente.DataMember = ""
        Me.dg_CuentaCliente.FlatMode = True
        Me.dg_CuentaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_CuentaCliente.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg_CuentaCliente.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_CuentaCliente.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_CuentaCliente.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_CuentaCliente.HeaderForeColor = System.Drawing.Color.White
        Me.dg_CuentaCliente.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_CuentaCliente.Location = New System.Drawing.Point(273, 195)
        Me.dg_CuentaCliente.Name = "dg_CuentaCliente"
        Me.dg_CuentaCliente.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_CuentaCliente.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_CuentaCliente.ReadOnly = True
        Me.dg_CuentaCliente.RowHeadersVisible = False
        Me.dg_CuentaCliente.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_CuentaCliente.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_CuentaCliente.Size = New System.Drawing.Size(1007, 443)
        Me.dg_CuentaCliente.TabIndex = 1306
        Me.dg_CuentaCliente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dg_CuentaCliente
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle2.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle2.MappingName = "VF_DETALLE_CUENTACLIENTE"
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "TIPO_DOCUMENTO"
        Me.DataGridTextBoxColumn2.MappingName = "TIPO_DOCUMENTO"
        Me.DataGridTextBoxColumn2.Width = 85
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "DOCUMENTO"
        Me.DataGridTextBoxColumn3.MappingName = "DOCUMENTO_FACTURACION"
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "FECHA FACTURACION"
        Me.DataGridTextBoxColumn4.MappingName = "FECHA_FACTURACION"
        Me.DataGridTextBoxColumn4.Width = 95
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "CUOTA N°"
        Me.DataGridTextBoxColumn5.MappingName = "CUOTA"
        Me.DataGridTextBoxColumn5.Width = 90
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "A VENCER EN "
        Me.DataGridTextBoxColumn6.MappingName = "DIAS_A_VENCER"
        Me.DataGridTextBoxColumn6.Width = 90
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = "n0"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "CUOTA"
        Me.DataGridTextBoxColumn7.MappingName = "MONTO_CUOTA"
        Me.DataGridTextBoxColumn7.Width = 90
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "VENCIMIENTO"
        Me.DataGridTextBoxColumn8.MappingName = "FECHA_VENCIMIENTO"
        Me.DataGridTextBoxColumn8.Width = 95
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "ESTADO CUOTA"
        Me.DataGridTextBoxColumn9.MappingName = "ESTADO_CUOTA"
        Me.DataGridTextBoxColumn9.Width = 90
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "FECHA PAGO"
        Me.DataGridTextBoxColumn13.MappingName = "FECHA_PAGO"
        Me.DataGridTextBoxColumn13.Width = 95
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = "n0"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "MORA"
        Me.DataGridTextBoxColumn14.MappingName = "INTERES_MORATORIO"
        Me.DataGridTextBoxColumn14.Width = 85
        '
        'dgDetallesCobranza
        '
        Me.dgDetallesCobranza.AlternatingBackColor = System.Drawing.Color.White
        Me.dgDetallesCobranza.BackColor = System.Drawing.Color.White
        Me.dgDetallesCobranza.BackgroundColor = System.Drawing.Color.Ivory
        Me.dgDetallesCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDetallesCobranza.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDetallesCobranza.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetallesCobranza.CaptionForeColor = System.Drawing.Color.Lavender
        Me.dgDetallesCobranza.DataMember = ""
        Me.dgDetallesCobranza.FlatMode = True
        Me.dgDetallesCobranza.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetallesCobranza.ForeColor = System.Drawing.Color.Black
        Me.dgDetallesCobranza.GridLineColor = System.Drawing.Color.Wheat
        Me.dgDetallesCobranza.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.dgDetallesCobranza.HeaderFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetallesCobranza.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDetallesCobranza.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDetallesCobranza.Location = New System.Drawing.Point(570, 44)
        Me.dgDetallesCobranza.Name = "dgDetallesCobranza"
        Me.dgDetallesCobranza.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.dgDetallesCobranza.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDetallesCobranza.ReadOnly = True
        Me.dgDetallesCobranza.RowHeadersVisible = False
        Me.dgDetallesCobranza.SelectionBackColor = System.Drawing.Color.Wheat
        Me.dgDetallesCobranza.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDetallesCobranza.Size = New System.Drawing.Size(181, 145)
        Me.dgDetallesCobranza.TabIndex = 1307
        Me.dgDetallesCobranza.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDetallesCobranza
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "CP_SEGUIM_COBRANZA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "FECHA SEGUIMIENTO"
        Me.DataGridTextBoxColumn1.MappingName = "FECHA_SEGUIMIENTO"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "COBRADOR"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = "n0"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "MONTO_COMPROMISO"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'txtCuentaActual
        '
        Me.txtCuentaActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCuentaActual.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCuentaActual.Location = New System.Drawing.Point(278, 162)
        Me.txtCuentaActual.Multiline = True
        Me.txtCuentaActual.Name = "txtCuentaActual"
        Me.txtCuentaActual.ReadOnly = True
        Me.txtCuentaActual.Size = New System.Drawing.Size(282, 29)
        Me.txtCuentaActual.TabIndex = 1309
        Me.txtCuentaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(278, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 19)
        Me.Label3.TabIndex = 1308
        Me.Label3.Text = "Deuda Actual"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(473, 306)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(329, 173)
        Me.CrystalReportViewer1.TabIndex = 1310
        '
        'txtCedula_Cliente
        '
        Me.txtCedula_Cliente.BackColor = System.Drawing.Color.White
        Me.txtCedula_Cliente.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula_Cliente.ForeColor = System.Drawing.Color.Blue
        Me.txtCedula_Cliente.Location = New System.Drawing.Point(276, 56)
        Me.txtCedula_Cliente.Name = "txtCedula_Cliente"
        Me.txtCedula_Cliente.ReadOnly = True
        Me.txtCedula_Cliente.Size = New System.Drawing.Size(284, 29)
        Me.txtCedula_Cliente.TabIndex = 1312
        Me.txtCedula_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(276, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 19)
        Me.Label4.TabIndex = 1311
        Me.Label4.Text = "Cedula Cliente"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg_Historial_PagoCC
        '
        Me.dg_Historial_PagoCC.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_Historial_PagoCC.BackColor = System.Drawing.Color.White
        Me.dg_Historial_PagoCC.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_Historial_PagoCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_Historial_PagoCC.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg_Historial_PagoCC.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Historial_PagoCC.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_Historial_PagoCC.DataMember = ""
        Me.dg_Historial_PagoCC.FlatMode = True
        Me.dg_Historial_PagoCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Historial_PagoCC.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg_Historial_PagoCC.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_Historial_PagoCC.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_Historial_PagoCC.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Historial_PagoCC.HeaderForeColor = System.Drawing.Color.White
        Me.dg_Historial_PagoCC.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_Historial_PagoCC.Location = New System.Drawing.Point(273, 195)
        Me.dg_Historial_PagoCC.Name = "dg_Historial_PagoCC"
        Me.dg_Historial_PagoCC.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_Historial_PagoCC.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_Historial_PagoCC.ReadOnly = True
        Me.dg_Historial_PagoCC.RowHeadersVisible = False
        Me.dg_Historial_PagoCC.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_Historial_PagoCC.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_Historial_PagoCC.Size = New System.Drawing.Size(1007, 443)
        Me.dg_Historial_PagoCC.TabIndex = 1313
        Me.dg_Historial_PagoCC.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.dg_Historial_PagoCC
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25})
        Me.DataGridTableStyle3.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle3.HeaderFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "VF_HISTORIAL_PAGO_CUENTACLIENTE"
        Me.DataGridTableStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridTableStyle3.SelectionForeColor = System.Drawing.Color.Blue
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "TIPO DOCUMENTO"
        Me.DataGridTextBoxColumn16.MappingName = "TIPO_DOCUMENT0"
        Me.DataGridTextBoxColumn16.Width = 85
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "DOCUMENTO"
        Me.DataGridTextBoxColumn17.MappingName = "DOCUMENTO_FACTURACION"
        Me.DataGridTextBoxColumn17.Width = 120
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "FECHA FACTURACION"
        Me.DataGridTextBoxColumn18.MappingName = "FECHA_FACTURACION"
        Me.DataGridTextBoxColumn18.Width = 95
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "CUOTA N°"
        Me.DataGridTextBoxColumn19.MappingName = "CUOTA"
        Me.DataGridTextBoxColumn19.Width = 90
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = "n0"
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "A VENCER EN "
        Me.DataGridTextBoxColumn20.MappingName = "DIAS_A_VENCER"
        Me.DataGridTextBoxColumn20.Width = 90
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = "n0"
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "CUOTA"
        Me.DataGridTextBoxColumn21.MappingName = "MONTO_CUOTA"
        Me.DataGridTextBoxColumn21.Width = 90
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "VENCIMIENTO"
        Me.DataGridTextBoxColumn22.MappingName = "FECHA_VENCIMIENTO"
        Me.DataGridTextBoxColumn22.Width = 95
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "ESTADO CUOTA"
        Me.DataGridTextBoxColumn23.MappingName = "ESTADO_CUOTA"
        Me.DataGridTextBoxColumn23.Width = 90
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "FECHA PAGO"
        Me.DataGridTextBoxColumn24.MappingName = "FECHA_PAGO"
        Me.DataGridTextBoxColumn24.Width = 95
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn25.Format = "n0"
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "MORA"
        Me.DataGridTextBoxColumn25.MappingName = "INTERES_MORATORIO"
        Me.DataGridTextBoxColumn25.Width = 85
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 19)
        Me.Label8.TabIndex = 1314
        Me.Label8.Text = "Listado de Facturas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgFacturasNo
        '
        Me.dgFacturasNo.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.dgFacturasNo.BackColor = System.Drawing.Color.OldLace
        Me.dgFacturasNo.BackgroundColor = System.Drawing.Color.Tan
        Me.dgFacturasNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgFacturasNo.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.dgFacturasNo.CaptionFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasNo.CaptionForeColor = System.Drawing.Color.OldLace
        Me.dgFacturasNo.DataMember = ""
        Me.dgFacturasNo.FlatMode = True
        Me.dgFacturasNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasNo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgFacturasNo.GridLineColor = System.Drawing.Color.Tan
        Me.dgFacturasNo.HeaderBackColor = System.Drawing.Color.Wheat
        Me.dgFacturasNo.HeaderFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasNo.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.dgFacturasNo.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturasNo.Location = New System.Drawing.Point(16, 268)
        Me.dgFacturasNo.Name = "dgFacturasNo"
        Me.dgFacturasNo.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.dgFacturasNo.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgFacturasNo.ReadOnly = True
        Me.dgFacturasNo.RowHeadersVisible = False
        Me.dgFacturasNo.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.dgFacturasNo.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturasNo.Size = New System.Drawing.Size(252, 198)
        Me.dgFacturasNo.TabIndex = 1315
        Me.dgFacturasNo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.dgFacturasNo
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn15})
        Me.DataGridTableStyle4.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle4.HeaderFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle4.MappingName = "VF_DETALLE_CUENTACLIENTE"
        Me.DataGridTableStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridTableStyle4.SelectionForeColor = System.Drawing.Color.Blue
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "FACTURA N°"
        Me.DataGridTextBoxColumn15.MappingName = "DOCUMENTO_FACTURACION"
        Me.DataGridTextBoxColumn15.Width = 210
        '
        'dgFacturasPagadas
        '
        Me.dgFacturasPagadas.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.dgFacturasPagadas.BackColor = System.Drawing.Color.OldLace
        Me.dgFacturasPagadas.BackgroundColor = System.Drawing.Color.Tan
        Me.dgFacturasPagadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgFacturasPagadas.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.dgFacturasPagadas.CaptionFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasPagadas.CaptionForeColor = System.Drawing.Color.OldLace
        Me.dgFacturasPagadas.DataMember = ""
        Me.dgFacturasPagadas.FlatMode = True
        Me.dgFacturasPagadas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasPagadas.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgFacturasPagadas.GridLineColor = System.Drawing.Color.Tan
        Me.dgFacturasPagadas.HeaderBackColor = System.Drawing.Color.Wheat
        Me.dgFacturasPagadas.HeaderFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasPagadas.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.dgFacturasPagadas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturasPagadas.Location = New System.Drawing.Point(16, 268)
        Me.dgFacturasPagadas.Name = "dgFacturasPagadas"
        Me.dgFacturasPagadas.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.dgFacturasPagadas.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgFacturasPagadas.ReadOnly = True
        Me.dgFacturasPagadas.RowHeadersVisible = False
        Me.dgFacturasPagadas.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.dgFacturasPagadas.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturasPagadas.Size = New System.Drawing.Size(252, 198)
        Me.dgFacturasPagadas.TabIndex = 1316
        Me.dgFacturasPagadas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.dgFacturasPagadas
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn26})
        Me.DataGridTableStyle5.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle5.HeaderFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "VF_HISTORIAL_PAGO_CUENTACLIENTE"
        Me.DataGridTableStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridTableStyle5.SelectionForeColor = System.Drawing.Color.Blue
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "FACTURA N°"
        Me.DataGridTextBoxColumn26.MappingName = "DOCUMENTO_FACTURACION"
        Me.DataGridTextBoxColumn26.Width = 210
        '
        'txtDeudaTotalGral
        '
        Me.txtDeudaTotalGral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDeudaTotalGral.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeudaTotalGral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDeudaTotalGral.Location = New System.Drawing.Point(276, 108)
        Me.txtDeudaTotalGral.Multiline = True
        Me.txtDeudaTotalGral.Name = "txtDeudaTotalGral"
        Me.txtDeudaTotalGral.ReadOnly = True
        Me.txtDeudaTotalGral.Size = New System.Drawing.Size(284, 29)
        Me.txtDeudaTotalGral.TabIndex = 1318
        Me.txtDeudaTotalGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(276, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(284, 19)
        Me.Label9.TabIndex = 1317
        Me.Label9.Text = "Deuda Total General"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VISUALIZAR_CUENTA_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1285, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDeudaTotalGral)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtCedula_Cliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCuentaActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgDetallesCobranza)
        Me.Controls.Add(Me.txtMontoCompromiso)
        Me.Controls.Add(Me.txtFecha_Seguimiento)
        Me.Controls.Add(Me.txtCobrador)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dg_Historial_PagoCC)
        Me.Controls.Add(Me.dgFacturasNo)
        Me.Controls.Add(Me.dgFacturasPagadas)
        Me.Controls.Add(Me.dg_CuentaCliente)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "VISUALIZAR_CUENTA_CLIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VISUALIZAR CUENTA CLIENTE   ** SGCV + CO (E) V1.1.0          CONSULTAS Y PRECIOS " & _
    "AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_CuentaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetallesCobranza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_Historial_PagoCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFacturasNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFacturasPagadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lstnombre As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNombreApellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbRuc As System.Windows.Forms.RadioButton
    Friend WithEvents rbCedula As System.Windows.Forms.RadioButton
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rbPagados As System.Windows.Forms.RadioButton
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCobrador As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha_Seguimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoCompromiso As System.Windows.Forms.TextBox
    Friend WithEvents dg_CuentaCliente As System.Windows.Forms.DataGrid
    Friend WithEvents dgDetallesCobranza As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtCuentaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtCedula_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Historial_PagoCC As System.Windows.Forms.DataGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgFacturasNo As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgFacturasPagadas As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtDeudaTotalGral As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
