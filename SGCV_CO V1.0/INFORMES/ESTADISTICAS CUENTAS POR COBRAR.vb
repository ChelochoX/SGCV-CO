
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class ESTADISTICAS_CUENTAS_POR_COBRAR

    Dim FECHA_INICIAL, FECHA_FINAL, FECHA_FINAL_ As Date
    Dim DaCliente, DaDetCC, DaCabRecibo As New SqlClient.SqlDataAdapter
    Dim DsCliente, DsDetCC, DsCabRecibo As New Data.DataSet
    Dim sucursal, vendedor As String
    Dim B As Integer
    Dim DaDetCuenta_Cliente, DaSegCobranza, DaInteres, DaVendedor As New SqlClient.SqlDataAdapter
    Dim DsDetCuenta_Cliente, DsSegCobranza, DsInteres, DsVendedor As New Data.DataSet
    'Dim DaCliente As New SqlClient.SqlDataAdapter
    Dim codigo_pimpre As Integer
    Dim NUM_CUOTA, COD_CUENTA, MONTO As Integer
    Dim AUX_FECHAVENC As Date
    Dim codigo_cliente As Integer

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_CLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetCC = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetCC = New Data.DataSet
            DaDetCC.Fill(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_CABECERA_RECIBO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCabRecibo = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCabRecibo = New Data.DataSet
            DaCabRecibo.Fill(Me.DsCabRecibo, "CP_CABECERA_RECIBO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_USUARIO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaVendedor = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaVendedor.Fill(Me.DsVendedor, "CONFIG_USUARIO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Function EstadoCaja(ByVal a As String, ByVal b As Date) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAB_CAJA FROM CP_CABECERA_CAJA WHERE ESTADO = '" & a & "' AND FECHA_APERTURA = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Function Recuperar_Sucursal(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "Select J.SUCURSAL FROM CP_ESTADO_CAJA E INNER JOIN CP_CAJA J ON " & _
            "E.COD_ESTADOCAJA = J.COD_ESTADOCAJA INNER JOIN CP_CABECERA_MOVIMIENTO_CAJA C " & _
            "ON J.COD_CAJA = C.COD_CAJA WHERE E.ESTADO = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
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

    Sub Cargar_Dataset()
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

    'ACTUALIZA LOS DIAS DE FECHA DE VENCIMIENTO DE LAS CUOTAS******
    Function actualizar_diasMoraVencimiento(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer) As Integer
        Try
            Dim sel As String

            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET INTERES_MORATORIO = " & a & " WHERE COD_CLIENTE = " & b & " AND CUOTA =" & c & " AND COD_CABECERA_CUENTACLI= " & d & ""
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
    Function recu_sucursal() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUCURSAL FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()
            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Private Sub ESTADISTICAS_CUENTAS_POR_COBRAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Dataset()

        Cargar_Datos()

        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja("HABILITADO", Today)
        Contador_MovCaja_Apertura = Estado_Caja
        sucursal = recu_sucursal()

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor
        iconexion.Type = ConnectionInfoType.SQL

        Me.cbVendedor.DataSource = New List(Of String)()
        vendedor = ""

    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        FECHA_INICIAL = fecha1
    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave
        Dim fecha1, fecha2 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(0)
        fecha2 = Me.DateTimePicker2.Value.Date.AddDays(0)
        FECHA_FINAL = fecha1
        FECHA_FINAL_ = fecha2
    End Sub

    Function ELIMAR_DATOS_INF() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM INF_ESTADISTICA_DEUDA_PAGO"
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

    Function Contador_Estadistica() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM INF_ESTADISTICA_DEUDA_PAGO"
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
    Function estado_recibo(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM ANULAR_DOCUMENTOS WHERE NUMERO_DOCUMENTO = '" & a & "'"
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

    Function TotalesCuotas(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUOTA),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & a & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
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

    Function TotalesInteres(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(INTERES_MORATORIO),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & a & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
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

    Function CantidadRegistros() As Integer
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


    Private Sub btnGenerar_Calculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar_Calculo.Click

        'PRIMERO HACE CALCULO GENRAL DE CUOTAS PAGADAS Y PENDIENTES *** 
        Dim PAGADO, pendiente, nrofactura As String
        Dim dias_cuota, ContadorProgreso, comparador As Integer
        Dim paraRedondeo, redondeo, aux1, aux2 As Integer
        pendiente = "PENDIENTE"
        comparador = 1
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False
        Me.btnGenerar_Calculo.Enabled = False
        '************************************
        'VERIFICA VALORES PARA INTERES MORATORIO
        Dim MONTO_INTERES, DIAS_DE_GRACIA As Integer
        Dim i, j As Integer
        For j = 0 To Me.BindingContext(Me.DsInteres, "TP_INTERES").Count - 1
            Me.BindingContext(Me.DsInteres, "TP_INTERES").Position = j
            If "INTERES MORATORIO" = Me.DsInteres.Tables("TP_INTERES").Rows(Me.BindingContext(Me.DsInteres, "TP_INTERES").Position).Item("CONCEPTO") Then
                MONTO_INTERES = Me.DsInteres.Tables("TP_INTERES").Rows(Me.BindingContext(Me.DsInteres, "TP_INTERES").Position).Item("MONTO_INTERES")
                DIAS_DE_GRACIA = Me.DsInteres.Tables("TP_INTERES").Rows(Me.BindingContext(Me.DsInteres, "TP_INTERES").Position).Item("DIAS_DE_GRACIA")
            End If
        Next
        'ACTUALIZA LAS FECHAS DE VENCIMIENTO DE LAS CUOTAS********************************
        ContadorProgreso = CantidadRegistros()
        For i = 0 To Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Count - 1
            Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position = i

            AUX_FECHAVENC = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("FECHA_VENCIMIENTO")
            PAGADO = Trim(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA"))
            NUM_CUOTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("CUOTA")
            COD_CUENTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI")
            MONTO = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("MONTO_CUOTA")
            nrofactura = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("DOCUMENTO_FACTURACION")
            dias_cuota = DateDiff(DateInterval.Day, Today, AUX_FECHAVENC)

            'SI LA CUOTA NO FUE ABONADA SE MODIFICA LOS DIAS DE VENCIMIENTO***
            If PAGADO = pendiente Then
                actualizar_diasVencimiento(dias_cuota, codigo_cliente, NUM_CUOTA, COD_CUENTA)

                'CALCULAR INTERES MORATORIO EN CASO DE ATRASO
                If dias_cuota < 0 Then
                    Dim AUX_DIAS_CUOTA As Integer
                    Dim CALCULO_AUXILIAR, CALCULO_AUXILIAR1 As Double
                    Dim para_InteresMora As Integer

                    AUX_DIAS_CUOTA = dias_cuota * -1
                    If AUX_DIAS_CUOTA > DIAS_DE_GRACIA Then
                        CALCULO_AUXILIAR1 = MONTO_INTERES / 100
                        CALCULO_AUXILIAR = (MONTO * CALCULO_AUXILIAR1) / 30
                        para_InteresMora = CInt(CALCULO_AUXILIAR) * AUX_DIAS_CUOTA
                        actualizar_diasMoraVencimiento(para_InteresMora, codigo_cliente, NUM_CUOTA, COD_CUENTA)
                    Else
                        If DIAS_DE_GRACIA <= 5 Then
                            actualizar_diasMoraVencimiento(0, codigo_cliente, NUM_CUOTA, COD_CUENTA)
                        End If
                    End If
                Else
                    actualizar_diasMoraVencimiento(0, codigo_cliente, NUM_CUOTA, COD_CUENTA)
                End If

            End If

            aux1 = i + 1
            aux2 = aux1 * 100
            paraRedondeo = aux2 / ContadorProgreso
            redondeo = Math.Round(paraRedondeo)
            If redondeo = comparador Then
                comparador = comparador + 1
                ProgressBar1.Value = redondeo
                lbprogreso.Text = "SE ESTAN ACTUALIZANDO LOS MONTOS DE LAS CUENTAS!! AGUARDE UN MOMENTO..."
                lbprogreso.Update()
                lbporcentaje.Text = "CARGANDO " & redondeo & "%"
                lbporcentaje.Update()
                If redondeo = 100 Then
                    ProgressBar1.Value = redondeo
                    lbprogreso.Text = "ACTUALIZADO CORRECTAMENTE. AGUARDE UN MOMENTO..."
                    lbprogreso.Update()
                    lbporcentaje.Text = redondeo & "%"
                    lbporcentaje.Update()
                End If
            End If
        Next

        'ELIMNAR ANTES DATOS DE TABLA INFORME****
        ELIMAR_DATOS_INF()

        Dim cod_cliente, suma_acobrar, rec_cliente, importe_recibo, suma_cobrado, total_acobrar As Integer
        Dim fecha_Vencimiento, fecha_pago, fecha_deCobro, fecha_dePago As Date
        Dim l, cliente, cuota_numero, bandera_deCobro, bandera_cobrado As Integer
        Dim datos_personales, numero_recibo, estado_cuota, cedula, telefono, cuota, cuota_deCobro As String

        bandera_deCobro = 0
        bandera_cobrado = 0

        ContadorProgreso = Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Count - 1
        comparador = 1
        For j = 0 To Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Count - 1
            Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position = j

            cliente = CInt(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("COD_CLIENTE").ToString)
            datos_personales = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("NOM_APE").ToString)
            cedula = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("CI").ToString)
            telefono = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("TELEFONO").ToString)

            '**********************************************************************************************************************
            For i = 0 To Me.BindingContext(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE").Count - 1
                Me.BindingContext(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE").Position = i

                cod_cliente = CInt(Me.DsDetCC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CLIENTE").ToString)

                If cliente = cod_cliente Then
                    fecha_Vencimiento = Me.DsDetCC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE").Position).Item("FECHA_VENCIMIENTO")
                    cuota = Trim(Me.DsDetCC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE").Position).Item("MONTO_CUOTA"))
                    estado_cuota = Trim(Me.DsDetCC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA").ToString)
                    cuota_numero = Trim(Me.DsDetCC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE").Position).Item("CUOTA").ToString)

                    If fecha_Vencimiento >= FECHA_INICIAL And fecha_Vencimiento <= FECHA_FINAL And cuota > 0 And estado_cuota = "PENDIENTE" Then
                        suma_acobrar = suma_acobrar + cuota
                        fecha_deCobro = fecha_Vencimiento
                        cuota_deCobro = cuota_numero
                        bandera_deCobro = 1
                    End If
                End If
            Next
            '*************************************************************************************************************************
            For l = 0 To Me.BindingContext(Me.DsCabRecibo, "CP_CABECERA_RECIBO").Count - 1
                Me.BindingContext(Me.DsCabRecibo, "CP_CABECERA_RECIBO").Position = l

                rec_cliente = CInt(Me.DsCabRecibo.Tables("CP_CABECERA_RECIBO").Rows(Me.BindingContext(Me.DsCabRecibo, "CP_CABECERA_RECIBO").Position).Item("COD_CLIENTE").ToString)

                If cliente = rec_cliente Then

                    fecha_pago = Me.DsCabRecibo.Tables("CP_CABECERA_RECIBO").Rows(Me.BindingContext(Me.DsCabRecibo, "CP_CABECERA_RECIBO").Position).Item("FECHA")
                    importe_recibo = CInt(Me.DsCabRecibo.Tables("CP_CABECERA_RECIBO").Rows(Me.BindingContext(Me.DsCabRecibo, "CP_CABECERA_RECIBO").Position).Item("IMPORTE_TOTAL"))
                    numero_recibo = Trim(Me.DsCabRecibo.Tables("CP_CABECERA_RECIBO").Rows(Me.BindingContext(Me.DsCabRecibo, "CP_CABECERA_RECIBO").Position).Item("NUM_RECIBO").ToString)

                    If fecha_pago >= FECHA_INICIAL And fecha_pago <= FECHA_FINAL Then
                        If estado_recibo(numero_recibo) = 0 Then
                            suma_cobrado = suma_cobrado + importe_recibo
                            fecha_dePago = fecha_pago
                            bandera_cobrado = 1
                        End If
                    End If
                End If
            Next
            '****************************************************************
            Dim Totales_cuota, Totales_interes As Integer
            Totales_cuota = TotalesCuotas(cliente)
            Totales_interes = TotalesInteres(cliente)
            total_acobrar = Totales_cuota + Totales_interes
            If suma_acobrar = 0 Then
                fecha_deCobro = Today.ToString("dd/MM/yyyy")
            End If
            If suma_cobrado = 0 Then
                fecha_dePago = Today.ToString("dd/MM/yyyy")
            End If

            If (bandera_deCobro = 1) Or (bandera_cobrado = 1) Then
                Try
                    Dim contador As Integer
                    contador = Contador_Estadistica() + 1
                    SQLconexion.Open()
                    Dim sqlbuilder As New System.Text.StringBuilder
                    With sqlbuilder
                        .Append("INSERT INTO INF_ESTADISTICA_DEUDA_PAGO")
                        .Append(" VALUES ('")
                        .Append(contador & "','")
                        .Append(sucursal & "','")
                        .Append(FECHA_INICIAL.ToString("yyyy/MM/dd") & "','")
                        .Append(FECHA_FINAL_.ToString("yyyy/MM/dd") & "','")
                        .Append(datos_personales & "','")
                        .Append(suma_acobrar & "','")
                        .Append(suma_cobrado & "','")
                        .Append(total_acobrar & "','")
                        .Append(cedula & "','")
                        .Append(telefono & "','")
                        .Append(cuota_deCobro & "','")
                        .Append(fecha_deCobro.ToString("yyyy/MM/dd") & "','")
                        .Append(fecha_dePago.ToString("yyyy/MM/dd") & "','")
                        .Append("" & "','")
                        .Append("" & "')")

                    End With
                    cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                    cmm.ExecuteNonQuery()
                    SQLconexion.Close()
                    cmm.Dispose()
                    SQLconexion.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try
            End If

            bandera_deCobro = 0
            bandera_cobrado = 0
            suma_acobrar = 0
            suma_cobrado = 0
            total_acobrar = 0

            lbprogreso.Text = "SE ESTA GENERANDO EL REPORTE DE COBROS Y PAGOS!! AGUARDE UN MOMENTO..."
            lbprogreso.Update()
  
        Next
        lbprogreso.Text = "GENERADO CORRECTAMENTE..."
        lbprogreso.Update()
        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True
        Me.btnGenerar_Calculo.Enabled = True

        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("ESTADISTICA_DEUDA_PAGO", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@vendedor", vendedor)

            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New ESTADISTICA_DEUDA_PAGO
            info.SetDataSource(ds)

            info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
            If Not DesignMode Then
                info.SetParameterValue("@vendedor", vendedor)
            End If
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cbVendedor_DropDown(sender As Object, e As System.EventArgs) Handles cbVendedor.DropDown
        Me.cbVendedor.DataSource = Me.DsVendedor.Tables("CONFIG_USUARIO")
        Me.cbVendedor.DisplayMember = "USUARIO"
    End Sub

    Private Sub cbVendedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbVendedor.SelectedIndexChanged
        vendedor = Trim(Me.DsVendedor.Tables("CONFIG_USUARIO").Rows(Me.cbVendedor.SelectedIndex).Item(6).ToString)
    End Sub
End Class