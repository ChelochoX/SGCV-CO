Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class Reporte_Atrasos_Cobranzas

    ''PARA USAR ACTUALIZACION DE CUENTA CLIENTE
    Dim DaCuentasPagadas, DaDatosCabCuenta, DaDetCuenta_Cliente, DaSegCobranza, DaInteres, DaHistorial_PagoCC, DaCabCuenta_Cliente As New SqlClient.SqlDataAdapter
    Dim DsCuentasPagadas, DsDatosCabCuenta, DsDetCuenta_Cliente, DsSegCobranza, DsInteres, DsHistorial_PagoCC, DsCabCuenta_Cliente As New Data.DataSet

    Dim fechaprimero As DateTime
    Dim fechaultimo As DateTime


    'PROCESOS DE ACTUALIZACIONES
    'ACTUALIZA LOS DIAS DE FECHA DE VENCIMIENTO DE LAS CUOTAS******
    Function actualizar_diasVencimiento(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer) As Integer
        Try
            Dim sel As String

            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET DIAS_A_VENCER = " & a & " WHERE COD_CLIENTE = " & b & " AND CUOTA =" & c & " AND COD_CABECERA_CUENTACLI= " & d & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()
            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    'SUMATORIA CUENTA DE CLIENTE POR CABECERA ******
    Function Sumatoria_PorCuentaCliente(ByVal a As Integer, ByVal b As Integer, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUOTA),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & a & " AND COD_CABECERA_CUENTACLI = " & b & " AND ESTADO_CUOTA = '" & c & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()
            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    'ACTUALIZA LA CABECERA CUENTA DE CLIENTE ******
    Function Actualizar_Cuenta_Cliente(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE VF_CABECERA_CUENTACLIENTE SET MONTO_CUENTA = " & a & " WHERE COD_CLIENTE = " & b & " AND COD_CABECERA_CUENTACLI = " & c & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()
            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub btnGenerarDash_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarDash.Click

        ' ''INICIALIZAMOS LOS VALORES
        Label15.Text = "Generando Datos..."
        Label16.Text = "Generando Datos..."
        Label17.Text = "Generando Datos..."
        Label18.Text = "Generando Datos..."
        Label9.Text = "Generando Datos..."
        Label10.Text = "Generando Datos..."
        Label11.Text = "Generando Datos..."
        Label19.Text = "Generando Datos..."

        'actualizamos los datos
        Label15.Update()
        Label16.Update()
        Label17.Update()
        Label18.Update()
        Label9.Update()
        Label10.Update()
        Label11.Update()
        Label19.Update()

        ' DEHABILITAMOS EL BOTON DE GENERAR
        btnGenerarDash.Enabled = False

        'PROGRESS BAR
        Dim redondeo, aux1, aux2, ContadorProgreso, CantidadRegistros_ As Integer
        Dim paraRedondeo As Decimal

        'PRIMERO ACTUALIZAMOS LAS CUENTAS DE LOS CLIENTES
        'ACTUALIZA LAS FECHAS DE VENCIMIENTO DE LAS CUOTAS********************************
        Dim NUM_CUOTA, COD_CUENTA, MONTO As Integer
        Dim AUX_FECHAVENC As Date
        'Dim CLIENTE_ As String
        Dim PAGADO As String
        Dim dias_cuota As Integer
        Dim pendiente As String
        pendiente = "PENDIENTE"
        Dim codigo_cliente As Integer

        'PRIMER CONTEO PARA EL PROGRESS BAR
        CantidadRegistros_ = CantidadRegistros_Detalle()

        Dim A As Integer
        For A = 0 To Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Count - 1
            Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position = A
            codigo_cliente = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CLIENTE")
            AUX_FECHAVENC = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("FECHA_VENCIMIENTO")
            PAGADO = Trim(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA"))
            NUM_CUOTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("CUOTA")
            COD_CUENTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI")
            MONTO = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("MONTO_CUOTA")
            dias_cuota = DateDiff(DateInterval.Day, Today, AUX_FECHAVENC)

            'SI LA CUOTA NO FUE ABONADA SE MODIFICA LOS DIAS DE VENCIMIENTO***
            If PAGADO = pendiente Then
                actualizar_diasVencimiento(dias_cuota, codigo_cliente, NUM_CUOTA, COD_CUENTA)
            End If

            'UTILIZAMOS EL PROGRESS BAR
            If ContadorProgreso < CantidadRegistros_ Then
                ContadorProgreso = ContadorProgreso + 1
                aux1 = A + 1
                aux2 = aux1 * 100
                paraRedondeo = aux2 / CantidadRegistros_
                redondeo = Math.Round(paraRedondeo)
                If redondeo <> 100 Then
                    'comparador = comparador + 1
                    ProgressBar1.Value = redondeo
                    lbprogreso.Text = "SE ESTAN GENERANDO LOS INFORMES!! AGUARDE UN MOMENTO..."
                    lbprogreso.Update()
                    lbporcentaje.Text = "CARGANDO " & redondeo & "%"
                    lbporcentaje.Update()
                Else
                    If redondeo = 100 Then
                        ProgressBar1.Value = redondeo
                        lbprogreso.Text = "ACTUALIZANDO LOS DATOS DE LAS CUENTAS DE CLIENTES. AGUARDE UN MOMENTO..."
                        lbprogreso.Update()
                        lbporcentaje.Text = redondeo & "%"
                        lbporcentaje.Update()
                    End If
                End If
            End If

        Next
        ''************************************************************************
        'ACTUALIZAR CABECERA DE CUENTA DE CLIENTE****

        'SEGUNDO CONTEO PARA EL PROGRESS BAR
        CantidadRegistros_ = CantidadRegistros_Cabecera()
        ProgressBar1.Value = 0
        lbporcentaje.Text = "0%"
        lbporcentaje.Update()
        ContadorProgreso = 0
        paraRedondeo = 0
        aux1 = 0
        aux2 = 0

        Dim Cabecera_CuentaCliente, Sumatoria_porCuenta, y As Integer

        For y = 0 To Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Count - 1
            Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Position = y

            codigo_cliente = Me.DsCabCuenta_Cliente.Tables("VF_CABECERA_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Position).Item("COD_CLIENTE")
            Cabecera_CuentaCliente = CInt(Me.DsCabCuenta_Cliente.Tables("VF_CABECERA_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI"))

            Sumatoria_porCuenta = Sumatoria_PorCuentaCliente(codigo_cliente, Cabecera_CuentaCliente, "PENDIENTE")
            Actualizar_Cuenta_Cliente(Sumatoria_porCuenta, codigo_cliente, Cabecera_CuentaCliente)


            'UTILIZAMOS EL PROGRESS BAR
            If ContadorProgreso < CantidadRegistros_ Then
                ContadorProgreso = ContadorProgreso + 1
                aux1 = y + 1
                aux2 = aux1 * 100
                paraRedondeo = aux2 / CantidadRegistros_
                redondeo = Math.Round(paraRedondeo)
                If redondeo <> 100 Then
                    ProgressBar1.Value = redondeo
                    lbprogreso.Text = "ACTUALIZANDO LOS DATOS DE LAS CUENTAS DE CLIENTES. AGUARDE UN MOMENTO..."
                    lbprogreso.Update()
                    lbporcentaje.Text = "CARGANDO " & redondeo & "%"
                    lbporcentaje.Update()
                Else
                    If redondeo = 100 Then
                        ProgressBar1.Value = redondeo
                        lbprogreso.Text = "ACTUALIZADOS CORRECTAMENTE. GRACIAS POR AGUARDAR!!"
                        lbprogreso.Update()
                        lbporcentaje.Text = redondeo & "%"
                        lbporcentaje.Update()
                    End If
                End If
            End If
        Next

        ' CARGAMOS LOS VALORES PARA MOSTRAR EN EL DASH BOARD

        '' PRIMERO MOSTRAMOS LOS DE ATRASOS MENORES O IGUALES A 30
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_COBROATRASOS_HASTA_30", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label15.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
        '' PRIMERO MOSTRAMOS LOS DE ATRASOS MAYOR A 30 Y MENOR A 61
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_COBROATRASOS_HASTA_60", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label16.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
        '' PRIMERO MOSTRAMOS LOS DE ATRASOS MAYOR A 60 Y MENOR A 91
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_COBROATRASOS_HASTA_90", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label17.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
        '' PRIMERO MOSTRAMOS LOS DE ATRASOS MAYOR A 90 
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_COBROATRASOS_MAYOR_A_90", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label18.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

        'PARA MOSTRAR LO QUE SE DEBE COBRAR HOY
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_MONTO_A_COBRAR_HOY", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label9.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try


        'PARA MOSTRAR LO QUE SE DEBE COBRAR EN LA SEMANA
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_MONTO_A_COBRAR_ESTA_SEMANA", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label10.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

        'PARA MOSTRAR LO QUE SE DEBE COBRAR EN EL MES
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_MONTO_A_COBRAR_EN_EL_MES", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label11.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

        'PARA MOSTRAR LO QUE SE COBRO EN EL MES
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_MONTO_COBRADO_EN_EL_MES", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@fechaprimero", fechaprimero)
            da.SelectCommand.Parameters.AddWithValue("@fechaultimo", fechaultimo)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            If (dt.Rows.Count > 0) Then
                Label19.Text = Puntos(dt.Rows(0)("TOTAL").ToString) & " " & "GS"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try


        ''DESBLOQUEAMOS LOS BOTONES
        Me.btnListado30.Enabled = True
        Me.btnListado60.Enabled = True
        Me.btnListadoMenor90.Enabled = True
        Me.btnListadoMayor90.Enabled = True
        Me.btnParaCobrarHoy.Enabled = True
        Me.btnParaCobrarEstaSemana.Enabled = True
        Me.btnMontoCobrarenelMes.Enabled = True
        Me.btnMontoCobradoenelMes.Enabled = True

        ' HABILITAMOS EL BOTON DE GENERAR
        btnGenerarDash.Enabled = True
    End Sub

    Private Sub btnListado30_Click(sender As System.Object, e As System.EventArgs) Handles btnListado30.Click
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_HASTA_30", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADO_ATRASOS_HASTA_30
            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

    End Sub

    Private Sub btnListado60_Click(sender As System.Object, e As System.EventArgs) Handles btnListado60.Click
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_HASTA_60", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADO_ATRASOS_HASTA_60
            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnListadoMenor90_Click(sender As System.Object, e As System.EventArgs) Handles btnListadoMenor90.Click
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_HASTA_90", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADO_ATRASOS_HASTA_90
            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnListadoMayor90_Click(sender As System.Object, e As System.EventArgs) Handles btnListadoMayor90.Click

        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_MAYOR_A_90", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADOSATRASOS_MAYOR_A_90
            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnParaCobrarHoy_Click(sender As System.Object, e As System.EventArgs) Handles btnParaCobrarHoy.Click

        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_MONTO_A_COBRAR_HOY", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADO_MONTO_PARA_COBRAR_HOY
            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnParaCobrarEstaSemana_Click(sender As System.Object, e As System.EventArgs) Handles btnParaCobrarEstaSemana.Click

        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_LISTADO_MONTO_PARA_COBRAR_ESTA_SEMANA", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADO_MONTO_PARA_COBRAR_ESTA_SEMANA
            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnMontoCobrarenelMes_Click(sender As System.Object, e As System.EventArgs) Handles btnMontoCobrarenelMes.Click
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_LISTADO_MONTO_PARA_COBRAR_ESTE_MES", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADO_MONTO_PARA_COBRAR_EN_EL_MES
            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

    End Sub

    Private Sub btnMontoCobradoenelMes_Click(sender As System.Object, e As System.EventArgs) Handles btnMontoCobradoenelMes.Click
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("DASH_LISTADO_MONTO_COBRADO_EN_EL_MES", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@fechaprimero", fechaprimero)
            da.SelectCommand.Parameters.AddWithValue("@fechaultimo", fechaultimo)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New DSH_LISTADO_MONTO_COBRADO_EN_EL_MES
            info.SetDataSource(ds)
            info.SetParameterValue("@fechaprimero", fechaprimero)
            info.SetParameterValue("@fechaultimo", fechaultimo)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            Me.CrystalReportViewer1.Zoom(65)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaDetCuenta_Cliente.Fill(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_CABECERA_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCabCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaCabCuenta_Cliente.Fill(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_INTERES"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaInteres = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaInteres.Fill(Me.DsInteres, "TP_INTERES")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Function CantidadRegistros_Detalle() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM VF_DETALLE_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

    Function CantidadRegistros_Cabecera() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM VF_CABECERA_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

    Private Sub Reporte_Atrasos_Cobranzas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()

        ''inicializaciones a la impresion
        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor
        iconexion.Type = ConnectionInfoType.SQL


        'CALCULAMOS EL PRIMER Y ULTIMO DIA PARA USAR EN EL CALCULO
        fechaprimero = DateSerial(Year(Today), Month(Today), 1)
        fechaultimo = DateSerial(Year(Today), Month(Today) + 1, 0)

        ' ''INICIALIZAMOS LOS VALORES
        Label15.Text = "Pendiente de Generar..."
        Label16.Text = "Pendiente de Generar..."
        Label17.Text = "Pendiente de Generar..."
        Label18.Text = "Pendiente de Generar..."
        Label9.Text = "Pendiente de Generar..."
        Label10.Text = "Pendiente de Generar..."
        Label11.Text = "Pendiente de Generar..."
        Label19.Text = "Pendiente de Generar..."

        'BLOQUEAMOS LOS BOTONES
        Me.btnListado30.Enabled = False
        Me.btnListado60.Enabled = False
        Me.btnListadoMenor90.Enabled = False
        Me.btnListadoMayor90.Enabled = False
        Me.btnParaCobrarHoy.Enabled = False
        Me.btnParaCobrarEstaSemana.Enabled = False
        Me.btnMontoCobrarenelMes.Enabled = False
        Me.btnMontoCobradoenelMes.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class