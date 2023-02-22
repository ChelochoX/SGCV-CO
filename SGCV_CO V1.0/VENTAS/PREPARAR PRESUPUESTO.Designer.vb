<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PREPARAR_PRESUPUESTO
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
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDestinadoA = New System.Windows.Forms.TextBox()
        Me.txtMensaje1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregar_Producto = New System.Windows.Forms.Button()
        Me.btnQuitar_Producto = New System.Windows.Forms.Button()
        Me.dg_presupuesto = New System.Windows.Forms.DataGrid()
        Me.txtDatosVendedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMensaje_Obs = New System.Windows.Forms.TextBox()
        Me.txtContactoVendedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.brnGuardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPresupuestoNum = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbMensaje_Editado = New System.Windows.Forms.RadioButton()
        Me.rbMensaje_Ejemplo = New System.Windows.Forms.RadioButton()
        Me.txtPrecio_Unitario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbPie_MensajeEditado = New System.Windows.Forms.RadioButton()
        Me.rbPie_MensajeEjemplo = New System.Windows.Forms.RadioButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtTotalPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_SegPresupuesto = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.dg_presupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_SegPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(488, 39)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(380, 23)
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 387
        Me.Label1.Text = "Sr./Sres."
        '
        'txtDestinadoA
        '
        Me.txtDestinadoA.BackColor = System.Drawing.Color.White
        Me.txtDestinadoA.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinadoA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDestinadoA.Location = New System.Drawing.Point(17, 44)
        Me.txtDestinadoA.Name = "txtDestinadoA"
        Me.txtDestinadoA.Size = New System.Drawing.Size(442, 23)
        Me.txtDestinadoA.TabIndex = 1
        Me.txtDestinadoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMensaje1
        '
        Me.txtMensaje1.BackColor = System.Drawing.Color.White
        Me.txtMensaje1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMensaje1.Location = New System.Drawing.Point(17, 106)
        Me.txtMensaje1.Multiline = True
        Me.txtMensaje1.Name = "txtMensaje1"
        Me.txtMensaje1.Size = New System.Drawing.Size(851, 81)
        Me.txtMensaje1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(17, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 393
        Me.Label3.Text = "Detalles de Productos"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(99, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 394
        Me.Label4.Text = "Articulo"
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(546, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 19)
        Me.Label5.TabIndex = 395
        Me.Label5.Text = "Cantidad"
        '
        'txtArticulo
        '
        Me.txtArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtArticulo.BackColor = System.Drawing.Color.White
        Me.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArticulo.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtArticulo.Location = New System.Drawing.Point(102, 236)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(442, 23)
        Me.txtArticulo.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(549, 236)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(65, 23)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar_Producto
        '
        Me.btnAgregar_Producto.BackColor = System.Drawing.Color.White
        Me.btnAgregar_Producto.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnAgregar_Producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar_Producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAgregar_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_Producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar_Producto.Location = New System.Drawing.Point(740, 234)
        Me.btnAgregar_Producto.Name = "btnAgregar_Producto"
        Me.btnAgregar_Producto.Size = New System.Drawing.Size(66, 23)
        Me.btnAgregar_Producto.TabIndex = 7
        Me.btnAgregar_Producto.Text = "AGREGAR"
        Me.btnAgregar_Producto.UseVisualStyleBackColor = False
        '
        'btnQuitar_Producto
        '
        Me.btnQuitar_Producto.BackColor = System.Drawing.Color.White
        Me.btnQuitar_Producto.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnQuitar_Producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQuitar_Producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnQuitar_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar_Producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQuitar_Producto.Location = New System.Drawing.Point(807, 234)
        Me.btnQuitar_Producto.Name = "btnQuitar_Producto"
        Me.btnQuitar_Producto.Size = New System.Drawing.Size(64, 23)
        Me.btnQuitar_Producto.TabIndex = 8
        Me.btnQuitar_Producto.Text = "QUITAR"
        Me.btnQuitar_Producto.UseVisualStyleBackColor = False
        '
        'dg_presupuesto
        '
        Me.dg_presupuesto.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.dg_presupuesto.BackColor = System.Drawing.Color.GhostWhite
        Me.dg_presupuesto.BackgroundColor = System.Drawing.Color.Lavender
        Me.dg_presupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_presupuesto.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.dg_presupuesto.CaptionFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_presupuesto.CaptionForeColor = System.Drawing.Color.White
        Me.dg_presupuesto.DataMember = ""
        Me.dg_presupuesto.FlatMode = True
        Me.dg_presupuesto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_presupuesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg_presupuesto.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.dg_presupuesto.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg_presupuesto.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_presupuesto.HeaderForeColor = System.Drawing.Color.Lavender
        Me.dg_presupuesto.LinkColor = System.Drawing.Color.Teal
        Me.dg_presupuesto.Location = New System.Drawing.Point(17, 263)
        Me.dg_presupuesto.Name = "dg_presupuesto"
        Me.dg_presupuesto.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.dg_presupuesto.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg_presupuesto.ReadOnly = True
        Me.dg_presupuesto.RowHeaderWidth = 25
        Me.dg_presupuesto.SelectionBackColor = System.Drawing.Color.Teal
        Me.dg_presupuesto.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.dg_presupuesto.Size = New System.Drawing.Size(858, 213)
        Me.dg_presupuesto.TabIndex = 400
        Me.dg_presupuesto.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'txtDatosVendedor
        '
        Me.txtDatosVendedor.BackColor = System.Drawing.Color.White
        Me.txtDatosVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDatosVendedor.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatosVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDatosVendedor.Location = New System.Drawing.Point(17, 619)
        Me.txtDatosVendedor.Name = "txtDatosVendedor"
        Me.txtDatosVendedor.Size = New System.Drawing.Size(442, 23)
        Me.txtDatosVendedor.TabIndex = 10
        Me.txtDatosVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 597)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 19)
        Me.Label6.TabIndex = 401
        Me.Label6.Text = "Datos Vendedor"
        '
        'txtMensaje_Obs
        '
        Me.txtMensaje_Obs.BackColor = System.Drawing.Color.White
        Me.txtMensaje_Obs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje_Obs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMensaje_Obs.Location = New System.Drawing.Point(17, 515)
        Me.txtMensaje_Obs.Multiline = True
        Me.txtMensaje_Obs.Name = "txtMensaje_Obs"
        Me.txtMensaje_Obs.Size = New System.Drawing.Size(851, 78)
        Me.txtMensaje_Obs.TabIndex = 9
        '
        'txtContactoVendedor
        '
        Me.txtContactoVendedor.BackColor = System.Drawing.Color.White
        Me.txtContactoVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactoVendedor.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactoVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContactoVendedor.Location = New System.Drawing.Point(478, 619)
        Me.txtContactoVendedor.Name = "txtContactoVendedor"
        Me.txtContactoVendedor.Size = New System.Drawing.Size(390, 23)
        Me.txtContactoVendedor.TabIndex = 11
        Me.txtContactoVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(475, 597)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "Telefono Contacto Vendedor"
        '
        'brnGuardar
        '
        Me.brnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.brnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.brnGuardar.Location = New System.Drawing.Point(724, 648)
        Me.brnGuardar.Name = "brnGuardar"
        Me.brnGuardar.Size = New System.Drawing.Size(69, 23)
        Me.brnGuardar.TabIndex = 408
        Me.brnGuardar.Text = "GUARDAR"
        Me.brnGuardar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(126, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 23)
        Me.Label10.TabIndex = 409
        Me.Label10.Text = "PRESUPUESTO N°"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPresupuestoNum
        '
        Me.txtPresupuestoNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPresupuestoNum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresupuestoNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPresupuestoNum.Location = New System.Drawing.Point(279, 8)
        Me.txtPresupuestoNum.Name = "txtPresupuestoNum"
        Me.txtPresupuestoNum.ReadOnly = True
        Me.txtPresupuestoNum.Size = New System.Drawing.Size(126, 29)
        Me.txtPresupuestoNum.TabIndex = 100
        Me.txtPresupuestoNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbMensaje_Editado)
        Me.GroupBox2.Controls.Add(Me.rbMensaje_Ejemplo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox2.Location = New System.Drawing.Point(17, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 31)
        Me.GroupBox2.TabIndex = 412
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mensaje"
        '
        'rbMensaje_Editado
        '
        Me.rbMensaje_Editado.AutoSize = True
        Me.rbMensaje_Editado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbMensaje_Editado.Location = New System.Drawing.Point(174, 9)
        Me.rbMensaje_Editado.Name = "rbMensaje_Editado"
        Me.rbMensaje_Editado.Size = New System.Drawing.Size(111, 17)
        Me.rbMensaje_Editado.TabIndex = 1
        Me.rbMensaje_Editado.TabStop = True
        Me.rbMensaje_Editado.Text = "Mensaje Editado"
        Me.rbMensaje_Editado.UseVisualStyleBackColor = True
        '
        'rbMensaje_Ejemplo
        '
        Me.rbMensaje_Ejemplo.AutoSize = True
        Me.rbMensaje_Ejemplo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbMensaje_Ejemplo.Location = New System.Drawing.Point(55, 9)
        Me.rbMensaje_Ejemplo.Name = "rbMensaje_Ejemplo"
        Me.rbMensaje_Ejemplo.Size = New System.Drawing.Size(112, 17)
        Me.rbMensaje_Ejemplo.TabIndex = 0
        Me.rbMensaje_Ejemplo.TabStop = True
        Me.rbMensaje_Ejemplo.Text = "Mensaje Ejemplo"
        Me.rbMensaje_Ejemplo.UseVisualStyleBackColor = True
        '
        'txtPrecio_Unitario
        '
        Me.txtPrecio_Unitario.BackColor = System.Drawing.Color.White
        Me.txtPrecio_Unitario.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_Unitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecio_Unitario.Location = New System.Drawing.Point(622, 236)
        Me.txtPrecio_Unitario.Name = "txtPrecio_Unitario"
        Me.txtPrecio_Unitario.Size = New System.Drawing.Size(109, 23)
        Me.txtPrecio_Unitario.TabIndex = 6
        Me.txtPrecio_Unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(620, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 414
        Me.Label2.Text = "Precio Unitario"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbPie_MensajeEditado)
        Me.GroupBox3.Controls.Add(Me.rbPie_MensajeEjemplo)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox3.Location = New System.Drawing.Point(17, 482)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 31)
        Me.GroupBox3.TabIndex = 415
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pie Mensaje"
        '
        'rbPie_MensajeEditado
        '
        Me.rbPie_MensajeEditado.AutoSize = True
        Me.rbPie_MensajeEditado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPie_MensajeEditado.Location = New System.Drawing.Point(207, 9)
        Me.rbPie_MensajeEditado.Name = "rbPie_MensajeEditado"
        Me.rbPie_MensajeEditado.Size = New System.Drawing.Size(111, 17)
        Me.rbPie_MensajeEditado.TabIndex = 1
        Me.rbPie_MensajeEditado.TabStop = True
        Me.rbPie_MensajeEditado.Text = "Mensaje Editado"
        Me.rbPie_MensajeEditado.UseVisualStyleBackColor = True
        '
        'rbPie_MensajeEjemplo
        '
        Me.rbPie_MensajeEjemplo.AutoSize = True
        Me.rbPie_MensajeEjemplo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPie_MensajeEjemplo.Location = New System.Drawing.Point(88, 9)
        Me.rbPie_MensajeEjemplo.Name = "rbPie_MensajeEjemplo"
        Me.rbPie_MensajeEjemplo.Size = New System.Drawing.Size(112, 17)
        Me.rbPie_MensajeEjemplo.TabIndex = 0
        Me.rbPie_MensajeEjemplo.TabStop = True
        Me.rbPie_MensajeEjemplo.Text = "Mensaje Ejemplo"
        Me.rbPie_MensajeEjemplo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(17, 236)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 23)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 417
        Me.Label7.Text = "Codigo"
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label9.Location = New System.Drawing.Point(485, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 19)
        Me.Label9.TabIndex = 418
        Me.Label9.Text = "Fecha"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(799, 648)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 23)
        Me.btnSalir.TabIndex = 419
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtTotalPresupuesto
        '
        Me.txtTotalPresupuesto.BackColor = System.Drawing.Color.White
        Me.txtTotalPresupuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPresupuesto.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPresupuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalPresupuesto.Location = New System.Drawing.Point(724, 481)
        Me.txtTotalPresupuesto.Name = "txtTotalPresupuesto"
        Me.txtTotalPresupuesto.ReadOnly = True
        Me.txtTotalPresupuesto.Size = New System.Drawing.Size(151, 23)
        Me.txtTotalPresupuesto.TabIndex = 420
        Me.txtTotalPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(616, 485)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 19)
        Me.Label11.TabIndex = 421
        Me.Label11.Text = "Total Presupuesto"
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(440, 485)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 19)
        Me.Label12.TabIndex = 423
        Me.Label12.Text = "Total Cantidad"
        '
        'txtTotalCantidad
        '
        Me.txtTotalCantidad.BackColor = System.Drawing.Color.White
        Me.txtTotalCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalCantidad.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalCantidad.Location = New System.Drawing.Point(532, 481)
        Me.txtTotalCantidad.Name = "txtTotalCantidad"
        Me.txtTotalCantidad.ReadOnly = True
        Me.txtTotalCantidad.Size = New System.Drawing.Size(72, 23)
        Me.txtTotalCantidad.TabIndex = 422
        Me.txtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg_SegPresupuesto)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(884, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 643)
        Me.GroupBox1.TabIndex = 424
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRESUPUESTOS GENERADOS"
        '
        'dg_SegPresupuesto
        '
        Me.dg_SegPresupuesto.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_SegPresupuesto.BackColor = System.Drawing.Color.White
        Me.dg_SegPresupuesto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_SegPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_SegPresupuesto.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dg_SegPresupuesto.CaptionFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_SegPresupuesto.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_SegPresupuesto.DataMember = ""
        Me.dg_SegPresupuesto.FlatMode = True
        Me.dg_SegPresupuesto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_SegPresupuesto.ForeColor = System.Drawing.Color.SeaGreen
        Me.dg_SegPresupuesto.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_SegPresupuesto.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_SegPresupuesto.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_SegPresupuesto.HeaderForeColor = System.Drawing.Color.White
        Me.dg_SegPresupuesto.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_SegPresupuesto.Location = New System.Drawing.Point(5, 26)
        Me.dg_SegPresupuesto.Name = "dg_SegPresupuesto"
        Me.dg_SegPresupuesto.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_SegPresupuesto.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_SegPresupuesto.ReadOnly = True
        Me.dg_SegPresupuesto.RowHeaderWidth = 25
        Me.dg_SegPresupuesto.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_SegPresupuesto.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_SegPresupuesto.Size = New System.Drawing.Size(352, 611)
        Me.dg_SegPresupuesto.TabIndex = 401
        Me.dg_SegPresupuesto.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dg_SegPresupuesto
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "VF_CABECERA_PRESUPUESTO"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "N°"
        Me.DataGridTextBoxColumn1.MappingName = "COD_CAB_PRESUPUESTO"
        Me.DataGridTextBoxColumn1.Width = 55
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "FECHA"
        Me.DataGridTextBoxColumn2.MappingName = "FECHA_INSERTADO"
        Me.DataGridTextBoxColumn2.Width = 65
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "DESTINATARIO"
        Me.DataGridTextBoxColumn3.MappingName = "DESTINATARIO"
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_presupuesto
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "VF_DETALLE_PRESUPUESTO"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn4.MappingName = "CODIGO_ARTICULO"
        Me.DataGridTextBoxColumn4.Width = 95
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "ARTICULO"
        Me.DataGridTextBoxColumn5.MappingName = "ARTICULO"
        Me.DataGridTextBoxColumn5.Width = 350
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = "n0"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn6.MappingName = "CANTIDAD"
        Me.DataGridTextBoxColumn6.Width = 95
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = "n0"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "PRECIO UNI."
        Me.DataGridTextBoxColumn7.MappingName = "PRECIO_UNITARIO"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = "n0"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "PRECIO TOTAL"
        Me.DataGridTextBoxColumn8.MappingName = "TOTAL_PRECIO"
        Me.DataGridTextBoxColumn8.Width = 130
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(443, 285)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(150, 150)
        Me.CrystalReportViewer1.TabIndex = 425
        '
        'PREPARAR_PRESUPUESTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1262, 677)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotalCantidad)
        Me.Controls.Add(Me.txtTotalPresupuesto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtPrecio_Unitario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtPresupuestoNum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.brnGuardar)
        Me.Controls.Add(Me.txtContactoVendedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMensaje_Obs)
        Me.Controls.Add(Me.txtDatosVendedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dg_presupuesto)
        Me.Controls.Add(Me.btnQuitar_Producto)
        Me.Controls.Add(Me.btnAgregar_Producto)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMensaje1)
        Me.Controls.Add(Me.txtDestinadoA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "PREPARAR_PRESUPUESTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACION  ** SGCV + CO (E) V1.1.0          CONSULTAS Y PRECIOS AL 0994 60 60 4" & _
            "8  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        CType(Me.dg_presupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_SegPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDestinadoA As System.Windows.Forms.TextBox
    Friend WithEvents txtMensaje1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar_Producto As System.Windows.Forms.Button
    Friend WithEvents btnQuitar_Producto As System.Windows.Forms.Button
    Friend WithEvents dg_presupuesto As System.Windows.Forms.DataGrid
    Friend WithEvents txtDatosVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMensaje_Obs As System.Windows.Forms.TextBox
    Friend WithEvents txtContactoVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents brnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPresupuestoNum As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMensaje_Editado As System.Windows.Forms.RadioButton
    Friend WithEvents rbMensaje_Ejemplo As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrecio_Unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPie_MensajeEditado As System.Windows.Forms.RadioButton
    Friend WithEvents rbPie_MensajeEjemplo As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtTotalPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCantidad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_SegPresupuesto As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
