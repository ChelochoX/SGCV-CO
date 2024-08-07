Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Reporting.WinForms

Public Class Reporte_Atrasos_Cobranzas

    ''PARA USAR ACTUALIZACION DE CUENTA CLIENTE
    Dim DaCuentasPagadas, DaDatosCabCuenta, DaDetCuenta_Cliente, DaSegCobranza, DaInteres, DaHistorial_PagoCC, DaCabCuenta_Cliente, DaVendedor As New SqlClient.SqlDataAdapter
    Dim DsCuentasPagadas, DsDatosCabCuenta, DsDetCuenta_Cliente, DsSegCobranza, DsInteres, DsHistorial_PagoCC, DsCabCuenta_Cliente, DsVendedor As New Data.DataSet

    Dim fechaprimero As DateTime
    Dim fechaultimo As DateTime

    Dim vendedor As String

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

    Private Sub btnGenerarDash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarDash.Click

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
        lbporcentaje.Text = "CARGANDO... "
        lbporcentaje.Update()
        lbprogreso.Text = "INICIANDO PROCESO..."
        lbprogreso.Update()

        ' DEHABILITAMOS EL BOTON DE GENERAR
        btnGenerarDash.Enabled = False
        cbVendedor.Enabled = False

        'Llamamos al procedimiento
        Try
            conectar()
            Using command As New SqlCommand("ESTADISTICO_COBRANZA_ATRASOS", SQLconexion)
                command.CommandType = CommandType.StoredProcedure
                command.CommandTimeout = 120
                SQLconexion.Open()
                command.ExecuteNonQuery()
                SQLconexion.Close()
                'MessageBox.Show("Procedimiento ejecutado correctamente.", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            'Primer mensaje de Progreso
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

            'Segundo mensaje de Progreso
            totalFilas = 1000
            ProgressBar1.Maximum = totalFilas
            For i As Integer = 0 To totalFilas - 1
                Dim progresoActual As Integer = i + 1
                ProgressBar1.Value = progresoActual
                Dim porcentaje As Integer = CInt((progresoActual / totalFilas) * 100)
                lbporcentaje.Text = "CARGANDO " & porcentaje & "%"
                lbporcentaje.Update()
                lbprogreso.Text = "ACTUALIZANDO LOS DATOS DE LAS CUENTAS DE CLIENTES. AGUARDE UN MOMENTO..."
                lbprogreso.Update()
                System.Threading.Thread.Sleep(5)
            Next
            ProgressBar1.Value = ProgressBar1.Maximum
            lbprogreso.Text = "ACTUALIZADOS CORRECTAMENTE. GRACIAS POR AGUARDAR!!"
            lbprogreso.Update()


        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al procesar los datos para el Reporte.  " + ex.ToString, "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SQLconexion.Close()
        End Try


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
        Me.Button2.Enabled = True

        ' HABILITAMOS EL BOTON DE GENERAR y vendedor
        btnGenerarDash.Enabled = True
        cbVendedor.Enabled = True

    End Sub

    Private Sub btnListado30_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = True) Handles btnListado30.Click
        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Busqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_HASTA_30", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                If vendedorObligatorio Then
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", DBNull.Value)
                End If
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADO_ATRASOS_HASTA_30
                info.SetDataSource(ds)
                info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
                If Not DesignMode Then
                    info.SetParameterValue("@VENDEDOR", If(vendedorObligatorio, vendedor, DBNull.Value))
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnListado60_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = True) Handles btnListado60.Click

        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Busqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_HASTA_60", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                If vendedorObligatorio Then
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", DBNull.Value)
                End If
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADO_ATRASOS_HASTA_60
                info.SetDataSource(ds)
                info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
                If Not DesignMode Then
                    info.SetParameterValue("@VENDEDOR", If(vendedorObligatorio, vendedor, DBNull.Value))
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnListadoMenor90_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = True) Handles btnListadoMenor90.Click
        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Busqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_HASTA_90", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                If vendedorObligatorio Then
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", DBNull.Value)
                End If
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADO_ATRASOS_HASTA_90
                info.SetDataSource(ds)
                info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
                If Not DesignMode Then
                    info.SetParameterValue("@VENDEDOR", If(vendedorObligatorio, vendedor, DBNull.Value))
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnListadoMayor90_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = True) Handles btnListadoMayor90.Click
        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Busqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_LISTADOSATRASOS_MAYOR_A_90", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                If vendedorObligatorio Then
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", DBNull.Value)
                End If
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADOSATRASOS_MAYOR_A_90
                info.SetDataSource(ds)
                info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
                If Not DesignMode Then
                    info.SetParameterValue("@VENDEDOR", If(vendedorObligatorio, vendedor, DBNull.Value))
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnParaCobrarHoy_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = False) Handles btnParaCobrarHoy.Click
        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Búsqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_MONTO_A_COBRAR_HOY", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                ' Añadir parámetro vendedor o DBNull según corresponda
                If vendedorObligatorio Then
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", DBNull.Value)
                End If

                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADO_MONTO_PARA_COBRAR_HOY
                info.SetDataSource(ds)
                info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
                If Not DesignMode Then
                    info.SetParameterValue("@VENDEDOR", If(vendedorObligatorio, vendedor, DBNull.Value))
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub


    Private Sub btnParaCobrarEstaSemana_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = False) Handles btnParaCobrarEstaSemana.Click
        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Búsqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_LISTADO_MONTO_PARA_COBRAR_ESTA_SEMANA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                ' Añadir parámetro vendedor o DBNull según corresponda
                If vendedorObligatorio Then
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", DBNull.Value)
                End If

                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADO_MONTO_PARA_COBRAR_ESTA_SEMANA
                info.SetDataSource(ds)
                info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
                If Not DesignMode Then
                    info.SetParameterValue("@VENDEDOR", If(vendedorObligatorio, vendedor, DBNull.Value))
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub


    Private Sub btnMontoCobrarenelMes_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = False) Handles btnMontoCobrarenelMes.Click
        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Búsqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_LISTADO_MONTO_PARA_COBRAR_ESTE_MES", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                ' Añadir parámetro vendedor o DBNull según corresponda
                If vendedorObligatorio Then
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@VENDEDOR", DBNull.Value)
                End If

                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADO_MONTO_PARA_COBRAR_EN_EL_MES
                info.SetDataSource(ds)
                info.SetDatabaseLogon(iconexion.UserID, iconexion.Password, iconexion.ServerName, iconexion.DatabaseName)
                If Not DesignMode Then
                    info.SetParameterValue("@VENDEDOR", If(vendedorObligatorio, vendedor, DBNull.Value))
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub


    Private Sub btnMontoCobradoenelMes_Click(sender As System.Object, e As System.EventArgs, Optional vendedorObligatorio As Boolean = False) Handles btnMontoCobradoenelMes.Click
        ' Validar si se requiere el vendedor y si no se ha proporcionado
        If vendedorObligatorio AndAlso String.IsNullOrEmpty(vendedor) Then
            MessageBox.Show("Debe Seleccionar un Vendedor para realizar la Búsqueda", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbVendedor.Focus()
        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("DASH_LISTADO_MONTO_COBRADO_EN_EL_MES", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                ' Añadir los parámetros de fecha
                da.SelectCommand.Parameters.AddWithValue("@fechaprimero", fechaprimero)
                da.SelectCommand.Parameters.AddWithValue("@fechaultimo", fechaultimo)

                ' Añadir parámetro vendedor o DBNull según corresponda
                If vendedorObligatorio AndAlso Not String.IsNullOrEmpty(vendedor) Then
                    da.SelectCommand.Parameters.AddWithValue("@vendedor", vendedor)
                Else
                    da.SelectCommand.Parameters.AddWithValue("@vendedor", DBNull.Value)
                End If

                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DSH_LISTADO_MONTO_COBRADO_EN_EL_MES
                info.SetDataSource(ds)
                info.SetParameterValue("@fechaprimero", fechaprimero)
                info.SetParameterValue("@fechaultimo", fechaultimo)
                ' Añadir el parámetro de vendedor al informe si es obligatorio
                If vendedorObligatorio Then
                    info.SetParameterValue("@vendedor", vendedor)
                Else
                    info.SetParameterValue("@vendedor", DBNull.Value)
                End If
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                Me.CrystalReportViewer1.Zoom(65)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
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

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub Reporte_Atrasos_Cobranzas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()

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
        Me.Button2.Enabled = False

        Me.cbVendedor.DataSource = New List(Of String)()
        vendedor = ""
        cbVendedor.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cbVendedor_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbVendedor.DropDown
        Me.cbVendedor.DataSource = Me.DsVendedor.Tables("CONFIG_USUARIO")
        Me.cbVendedor.DisplayMember = "USUARIO"
    End Sub

    Private Sub cbVendedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbVendedor.SelectedIndexChanged
        vendedor = Trim(Me.DsVendedor.Tables("CONFIG_USUARIO").Rows(Me.cbVendedor.SelectedIndex).Item(6).ToString)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        btnListado30_Click(sender, e, vendedorObligatorio:=False)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        btnListado60_Click(sender, e, vendedorObligatorio:=False)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        btnListadoMenor90_Click(sender, e, vendedorObligatorio:=False)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        btnListadoMayor90_Click(sender, e, vendedorObligatorio:=False)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        btnParaCobrarHoy_Click(sender, e, vendedorObligatorio:=True)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        btnParaCobrarEstaSemana_Click(sender, e, vendedorObligatorio:=True)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        btnMontoCobrarenelMes_Click(sender, e, vendedorObligatorio:=True)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        btnMontoCobradoenelMes_Click(sender, e, vendedorObligatorio:=True)
    End Sub
End Class