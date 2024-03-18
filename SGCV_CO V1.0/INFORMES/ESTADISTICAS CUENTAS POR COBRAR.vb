
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

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)

        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

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
        'Me.DateTimePicker1.Enabled = False
        'Me.DateTimePicker2.Enabled = False

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

        Dim ruta As String

        If vendedor.ToString.Length = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor para generar el informe", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("ESTADISTICA_DEUDA_PAGO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@vendedor", vendedor)
                da.SelectCommand.Parameters.AddWithValue("@fecha_inicial", FECHA_INICIAL)
                da.SelectCommand.Parameters.AddWithValue("@fecha_fin", FECHA_FINAL)
                da.Fill(dt)

                ' Verificar si se devolvieron filas
                If dt.Rows.Count > 0 Then
                    Dim totalFilas As Integer = 1000
                    ProgressBar1.Maximum = totalFilas
                    For i As Integer = 0 To totalFilas - 1
                        Dim progresoActual As Integer = i + 1
                        ProgressBar1.Value = progresoActual
                        Dim porcentaje As Integer = CInt((progresoActual / totalFilas) * 100)
                        lbporcentaje.Text = "CARGANDO " & porcentaje & "%"
                        lbporcentaje.Update()
                        lbprogreso.Text = "SE ESTA GENERANDO EL REPORTE DE COBROS Y PAGOS!! AGUARDE UN MOMENTO..."
                        lbprogreso.Update()
                        System.Threading.Thread.Sleep(5)
                    Next
                    ProgressBar1.Value = ProgressBar1.Maximum
                    lbprogreso.Text = "GENERADO CORRECTAMENTE"
                    lbprogreso.Update()
                    Me.btnGenerar_Calculo.Enabled = True
                    Me.cbVendedor.Enabled = True

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New ESTADISTICA_DEUDA_PAGO
                    ManejadorReportes.ConfigurarCredenciales(info)
                    info.SetDataSource(ds)
                    If Not DesignMode Then
                        info.SetParameterValue("@vendedor", vendedor)
                        info.SetParameterValue("@fecha_inicial", FECHA_INICIAL)
                        info.SetParameterValue("@fecha_fin", FECHA_FINAL)
                    End If
                    Me.CrystalReportViewer1.ReportSource = info
                Else
                    ' No se devolvieron filas, algo puede haber salido mal
                    MessageBox.Show("Ocurrio un error al generar el informe", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lbprogreso.Text = "Ocurrio un error al generar el informe"
                    lbprogreso.Update()
                    Me.btnGenerar_Calculo.Enabled = True
                    Me.cbVendedor.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al generar el informe", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lbprogreso.Text = "Ocurrio un error al generar el informe"
                lbprogreso.Update()
                Me.btnGenerar_Calculo.Enabled = True
                Me.cbVendedor.Enabled = True
            Finally
                SQLconexion.Close()
            End Try
        End If

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