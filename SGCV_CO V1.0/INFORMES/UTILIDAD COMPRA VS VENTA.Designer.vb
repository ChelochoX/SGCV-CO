﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UTILIDAD_COMPRA_VS_VENTA
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCerrar_Periodo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.crw = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lbporcentaje = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbprogreso = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbVentasporMeta = New System.Windows.Forms.RadioButton()
        Me.rbVentasporVendedor = New System.Windows.Forms.RadioButton()
        Me.rbUtilidad = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(260, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(916, 23)
        Me.Label1.TabIndex = 1239
        Me.Label1.Text = "FORMULARIO UTILIDAD COSTO VS VENTA POR RANGO DE FECHAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 115)
        Me.GroupBox2.TabIndex = 1240
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango Fechas"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(73, 63)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(123, 27)
        Me.DateTimePicker2.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(73, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 27)
        Me.DateTimePicker1.TabIndex = 416
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 415
        Me.Label3.Text = "Hasta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(22, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 413
        Me.Label5.Text = "Desde"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCerrar_Periodo)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 340)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 127)
        Me.GroupBox4.TabIndex = 1241
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gestion de Calculos"
        '
        'btnCerrar_Periodo
        '
        Me.btnCerrar_Periodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar_Periodo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar_Periodo.ForeColor = System.Drawing.Color.Navy
        Me.btnCerrar_Periodo.Location = New System.Drawing.Point(41, 44)
        Me.btnCerrar_Periodo.Name = "btnCerrar_Periodo"
        Me.btnCerrar_Periodo.Size = New System.Drawing.Size(139, 62)
        Me.btnCerrar_Periodo.TabIndex = 11
        Me.btnCerrar_Periodo.Text = "GENERAR INFORME"
        Me.btnCerrar_Periodo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Navy
        Me.btnSalir.Location = New System.Drawing.Point(18, 680)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(222, 28)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'crw
        '
        Me.crw.ActiveViewIndex = -1
        Me.crw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.crw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crw.Cursor = System.Windows.Forms.Cursors.Default
        Me.crw.DisplayStatusBar = False
        Me.crw.Location = New System.Drawing.Point(255, 46)
        Me.crw.Name = "crw"
        Me.crw.Size = New System.Drawing.Size(916, 675)
        Me.crw.TabIndex = 1243
        Me.crw.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lbporcentaje
        '
        Me.lbporcentaje.BackColor = System.Drawing.Color.White
        Me.lbporcentaje.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbporcentaje.ForeColor = System.Drawing.Color.Blue
        Me.lbporcentaje.Location = New System.Drawing.Point(15, 499)
        Me.lbporcentaje.Name = "lbporcentaje"
        Me.lbporcentaje.Size = New System.Drawing.Size(230, 18)
        Me.lbporcentaje.TabIndex = 1259
        Me.lbporcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Blue
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 473)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(230, 23)
        Me.ProgressBar1.TabIndex = 1258
        '
        'lbprogreso
        '
        Me.lbprogreso.BackColor = System.Drawing.Color.White
        Me.lbprogreso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbprogreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbprogreso.Location = New System.Drawing.Point(15, 523)
        Me.lbprogreso.Name = "lbprogreso"
        Me.lbprogreso.Size = New System.Drawing.Size(230, 138)
        Me.lbprogreso.TabIndex = 1257
        Me.lbprogreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbVentasporMeta)
        Me.GroupBox1.Controls.Add(Me.rbVentasporVendedor)
        Me.GroupBox1.Controls.Add(Me.rbUtilidad)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(11, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 170)
        Me.GroupBox1.TabIndex = 1260
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VISUALIZAR POR"
        '
        'rbVentasporMeta
        '
        Me.rbVentasporMeta.AutoSize = True
        Me.rbVentasporMeta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVentasporMeta.Location = New System.Drawing.Point(12, 79)
        Me.rbVentasporMeta.Name = "rbVentasporMeta"
        Me.rbVentasporMeta.Size = New System.Drawing.Size(156, 19)
        Me.rbVentasporMeta.TabIndex = 5
        Me.rbVentasporMeta.TabStop = True
        Me.rbVentasporMeta.Text = "VENTAS POR META MES"
        Me.rbVentasporMeta.UseVisualStyleBackColor = True
        '
        'rbVentasporVendedor
        '
        Me.rbVentasporVendedor.AutoSize = True
        Me.rbVentasporVendedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVentasporVendedor.Location = New System.Drawing.Point(12, 49)
        Me.rbVentasporVendedor.Name = "rbVentasporVendedor"
        Me.rbVentasporVendedor.Size = New System.Drawing.Size(161, 19)
        Me.rbVentasporVendedor.TabIndex = 4
        Me.rbVentasporVendedor.TabStop = True
        Me.rbVentasporVendedor.Text = "VENTAS POR VENDEDOR"
        Me.rbVentasporVendedor.UseVisualStyleBackColor = True
        '
        'rbUtilidad
        '
        Me.rbUtilidad.AutoSize = True
        Me.rbUtilidad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUtilidad.Location = New System.Drawing.Point(12, 20)
        Me.rbUtilidad.Name = "rbUtilidad"
        Me.rbUtilidad.Size = New System.Drawing.Size(184, 19)
        Me.rbUtilidad.TabIndex = 3
        Me.rbUtilidad.TabStop = True
        Me.rbUtilidad.Text = "UTILIDAD (COSTO vs VENTA)"
        Me.rbUtilidad.UseVisualStyleBackColor = True
        '
        'UTILIDAD_COMPRA_VS_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1203, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbporcentaje)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbprogreso)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.crw)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UTILIDAD_COMPRA_VS_VENTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UTILIDAD COMPRA VS VENTA   ** SGCV + CO (E) V1.1.0          CONSULTAS Y PRECIOS A" & _
    "L 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar_Periodo As System.Windows.Forms.Button
    Friend WithEvents crw As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lbporcentaje As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbprogreso As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVentasporMeta As System.Windows.Forms.RadioButton
    Friend WithEvents rbVentasporVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbUtilidad As System.Windows.Forms.RadioButton
End Class
