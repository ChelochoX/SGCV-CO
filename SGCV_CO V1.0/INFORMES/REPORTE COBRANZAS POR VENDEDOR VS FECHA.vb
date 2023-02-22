Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class REPORTE_COBRANZAS_POR_VENDEDOR_VS_FECHA

    Dim DaVendedor As New SqlClient.SqlDataAdapter
    Dim DsVendedor As New Data.DataSet
    Dim dsMeses As New DataTable("meses")
    Dim boton1, boton2, boton3, boton4, boton5, boton6, boton7, boton8, boton9, boton10, boton11, boton12, boton13 As Integer
    Dim TodoslosMeses, PorMes As Integer
    'definimos variables
    Dim v_vendedor, v_nombreMes As String
    Dim v_mes, v_ultimoDia, year, v_usuario As String


    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_USUARIO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaVendedor = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsVendedor = New Data.DataSet
            DaVendedor.Fill(Me.DsVendedor, "CONFIG_USUARIO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Private Sub REPORTE_COBRANZAS_POR_VENDEDOR_VS_FECHA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()
        V_DETALLADO = 0
        V_RESUMIDO = 0
        TodoslosMeses = 0
        PorMes = 0
        v_nombreMes = ""

        'CARGAMOS LOS VENDEDORES
        Me.lstVendedores.DataSource = Me.DsVendedor.Tables("CONFIG_USUARIO")
        'Me.lstVendedores.DisplayMember = "DATOS_PERSONALES"
        Me.lstVendedores.ValueMember = "DATOS_PERSONALES"

        'CARGAMOS LOS AÑOS
        Me.lstAnho.DataSource = Enumerable.Range(2018, 20).ToList
        Me.lstAnho.SelectedIndex = lstAnho.Items.IndexOf(Now.Year)

        ''
        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor
        iconexion.Type = ConnectionInfoType.SQL
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        'DECLARAMOS LAS VARIABLES QUE USAREMOS PARA LOS REPORTES
        Dim FECHA_INI, FECHA_INI_ As String
        Dim FECHA_FIN, FECHA_FIN_ As String
        '  Dim VENDEDOR As String

        'CONCATENAMOS LOS DATOS SI ES POR MES
        If v_mes = "" Then
            v_mes = "01"
        End If

        FECHA_INI = year & "/" & v_mes.PadLeft(2, "0"c) & "/" & "01"
        FECHA_FIN = year & "/" & v_mes.PadLeft(2, "0"c) & "/" & v_ultimoDia
        '
        'CONCATENAMOS LOS DATOS SI ES PARA TODOS LOS MESES
        'FECHA_INI_ = year & "/" & "01/01"
        'FECHA_FIN_ = year & "/" & "12/31"
        '
        If Me.rbTodosVendedores.Checked = True Then
            If TodoslosMeses = 1 Then
                MessageBox.Show("ESTA OPCION NO ESTA CONTEMPLADA PARA EL INFORME", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If PorMes = 1 Then
                    If V_DETALLADO = 1 Then
                        MessageBox.Show("ESTA OPCION NO ESTA CONTEMPLADA PARA EL INFORME", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If V_RESUMIDO = 1 Then
                            Try
                                conectar()
                                Dim dt As New DataTable
                                Dim da As New SqlDataAdapter("COBRANZAS_POR_VENDEDOR_MES", SQLconexion)
                                da.SelectCommand.CommandType = CommandType.StoredProcedure
                                da.SelectCommand.Parameters.AddWithValue("@FECHA_INI", FECHA_INI)
                                da.SelectCommand.Parameters.AddWithValue("@FECHA_FIN", FECHA_FIN)
                                da.Fill(dt)

                                Dim ds As New Data.DataSet
                                ds.Tables.Add(dt)

                                Dim info As New INF_COBRANZAPORVEND_PORMES_RESUMIDO

                                info.SetDataSource(ds)
                                info.SetParameterValue("@FECHA_INI", FECHA_INI)
                                info.SetParameterValue("@FECHA_FIN", FECHA_FIN)
                                SetDBLogonForReport(iconexion, info)
                                Me.crw.ReportSource = info

                            Catch ex As Exception
                                MessageBox.Show(ex.ToString)
                                SQLconexion.Close()
                            End Try
                        End If
                    End If
                End If
            End If
        Else
            If Me.rbPorVendedor.Checked = True Then
                '
                If TodoslosMeses = 1 Then
                    '
                    If V_DETALLADO = 1 Then
                        MessageBox.Show("ESTA OPCION NO ESTA CONTEMPLADA PARA EL INFORME", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If V_RESUMIDO = 1 Then
                            Try
                                conectar()
                                Dim dt As New DataTable
                                Dim da As New SqlDataAdapter("REPORTE_COBRANZAS_PORVENDEDOR_TODOSMES", SQLconexion)
                                da.SelectCommand.CommandType = CommandType.StoredProcedure
                                da.SelectCommand.Parameters.AddWithValue("@ANHO", year)
                                da.SelectCommand.Parameters.AddWithValue("@USUARIO", v_vendedor)
                                da.Fill(dt)

                                Dim ds As New Data.DataSet
                                ds.Tables.Add(dt)

                                Dim info As New INF_COBRANZAPORVEND_TODOMESES_RESUMIDO

                                info.SetDataSource(ds)
                                info.SetParameterValue("@ANHO", year)
                                info.SetParameterValue("@USUARIO", v_vendedor)
                                SetDBLogonForReport(iconexion, info)
                                Me.crw.ReportSource = info

                            Catch ex As Exception
                                MessageBox.Show(ex.ToString)
                                SQLconexion.Close()
                            End Try
                        End If
                    End If
                Else
                    If PorMes = 1 Then
                        If V_DETALLADO = 1 Then
                            Try
                                conectar()
                                Dim dt As New DataTable
                                Dim da As New SqlDataAdapter("REPORTE_COBRANZAS_PORVENDEDOR_PORMES", SQLconexion)
                                da.SelectCommand.CommandType = CommandType.StoredProcedure
                                da.SelectCommand.Parameters.AddWithValue("@FECHA_INI", FECHA_INI)
                                da.SelectCommand.Parameters.AddWithValue("@FECHA_FIN", FECHA_FIN)
                                da.SelectCommand.Parameters.AddWithValue("@USUARIO", v_vendedor)
                                da.Fill(dt)

                                Dim ds As New Data.DataSet
                                ds.Tables.Add(dt)

                                Dim info As New INF_COBRANZAPORVEND_PORMES

                                info.SetDataSource(ds)
                                info.SetParameterValue("@FECHA_INI", FECHA_INI)
                                info.SetParameterValue("@FECHA_FIN", FECHA_FIN)
                                info.SetParameterValue("@USUARIO", v_vendedor)
                                SetDBLogonForReport(iconexion, info)
                                Me.crw.ReportSource = info

                            Catch ex As Exception
                                MessageBox.Show(ex.ToString)
                                SQLconexion.Close()
                            End Try
                        Else
                            If V_RESUMIDO = 1 Then
                                MessageBox.Show("ESTA OPCION NO ESTA CONTEMPLADA PARA EL INFORME", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '
     
    End Sub

    Private Sub rbDetallado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDetallado.CheckedChanged
        V_DETALLADO = 1
        V_RESUMIDO = 0
    End Sub

    Private Sub rbResumido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbResumido.CheckedChanged
        V_RESUMIDO = 1
        V_DETALLADO = 0
    End Sub

    Private Sub lstVendedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVendedores.SelectedIndexChanged
        v_vendedor = Trim(Me.DsVendedor.Tables("CONFIG_USUARIO").Rows(Me.lstVendedores.SelectedIndex).Item(2).ToString)
        v_usuario = Trim(Me.DsVendedor.Tables("CONFIG_USUARIO").Rows(Me.lstVendedores.SelectedIndex).Item(6).ToString)
    End Sub

    Sub Verificar_Click()
        If boton1 = 1 Then
            btnEnero.BackColor = Color.Yellow
            btnEnero.ForeColor = Color.Blue
        Else
            btnEnero.BackColor = Color.White
            btnEnero.ForeColor = Color.Green
        End If

        If boton2 = 1 Then
            btnFebrero.BackColor = Color.Yellow
            btnFebrero.ForeColor = Color.Blue
        Else
            btnFebrero.BackColor = Color.White
            btnFebrero.ForeColor = Color.Green
        End If

        If boton3 = 1 Then
            btnMarzo.BackColor = Color.Yellow
            btnMarzo.ForeColor = Color.Blue
        Else
            btnMarzo.BackColor = Color.White
            btnMarzo.ForeColor = Color.Green
        End If

        If boton4 = 1 Then
            btnAbril.BackColor = Color.Yellow
            btnAbril.ForeColor = Color.Blue
        Else
            btnAbril.BackColor = Color.White
            btnAbril.ForeColor = Color.Green
        End If

        If boton5 = 1 Then
            btnMayo.BackColor = Color.Yellow
            btnMayo.ForeColor = Color.Blue
        Else
            btnMayo.BackColor = Color.White
            btnMayo.ForeColor = Color.Green
        End If

        If boton6 = 1 Then
            btnJunio.BackColor = Color.Yellow
            btnJunio.ForeColor = Color.Blue
        Else
            btnJunio.BackColor = Color.White
            btnJunio.ForeColor = Color.Green
        End If

        If boton7 = 1 Then
            btnJulio.BackColor = Color.Yellow
            btnJulio.ForeColor = Color.Blue
        Else
            btnJulio.BackColor = Color.White
            btnJulio.ForeColor = Color.Green
        End If

        If boton8 = 1 Then
            btnAgosto.BackColor = Color.Yellow
            btnAgosto.ForeColor = Color.Blue
        Else
            btnAgosto.BackColor = Color.White
            btnAgosto.ForeColor = Color.Green
        End If

        If boton9 = 1 Then
            btnSetiembre.BackColor = Color.Yellow
            btnSetiembre.ForeColor = Color.Blue
        Else
            btnSetiembre.BackColor = Color.White
            btnSetiembre.ForeColor = Color.Green
        End If

        If boton10 = 1 Then
            btnOctubre.BackColor = Color.Yellow
            btnOctubre.ForeColor = Color.Blue
        Else
            btnOctubre.BackColor = Color.White
            btnOctubre.ForeColor = Color.Green
        End If

        If boton11 = 1 Then
            btnNoviembre.BackColor = Color.Yellow
            btnNoviembre.ForeColor = Color.Blue
        Else
            btnNoviembre.BackColor = Color.White
            btnNoviembre.ForeColor = Color.Green
        End If

        If boton12 = 1 Then
            btnDiciembre.BackColor = Color.Yellow
            btnDiciembre.ForeColor = Color.Blue
        Else
            btnDiciembre.BackColor = Color.White
            btnDiciembre.ForeColor = Color.Green
        End If

        If boton13 = 1 Then
            btnTodos.BackColor = Color.Yellow
            btnTodos.ForeColor = Color.Blue
        Else
            btnTodos.BackColor = Color.White
            btnTodos.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 1
        Verificar_Click()
        TodoslosMeses = 1
        PorMes = 0
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbDetallado.Enabled = False
            Me.rbResumido.Enabled = True
        End If
    End Sub

    Private Sub btnEnero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnero.Click
        boton1 = 1
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "ENERO"
        v_mes = "01"
        v_ultimoDia = 30
        TodoslosMeses = 0
        PorMes = 1
        '
        If rbTodosVendedores.Checked = True Then
            Me.rbResumido.Enabled = True
            Me.rbDetallado.Enabled = False
        End If

        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnFebrero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFebrero.Click
        boton1 = 0
        boton2 = 1
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "FEBRERO"
        v_mes = "02"
        v_ultimoDia = 29
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnMarzo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarzo.Click
        boton1 = 0
        boton2 = 0
        boton3 = 1
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "MARZO"
        v_mes = "03"
        v_ultimoDia = 31
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnAbril_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbril.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 1
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "ABRIL"
        v_mes = "04"
        v_ultimoDia = 30
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnMayo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMayo.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 1
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "MAYO"
        v_mes = "05"
        v_ultimoDia = 31
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnJunio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJunio.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 1
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "JUNIO"
        v_mes = "06"
        v_ultimoDia = 30
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnJulio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJulio.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 1
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "JULIO"
        v_mes = "07"
        v_ultimoDia = 31
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnAgosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgosto.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 1
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "AGOSTO"
        v_mes = "08"
        v_ultimoDia = 31
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnSetiembre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetiembre.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 1
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "SEPTIEMBRE"
        v_mes = "09"
        v_ultimoDia = 30
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnOctubre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOctubre.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 1
        boton11 = 0
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "OCTUBRE"
        v_mes = "10"
        v_ultimoDia = 30
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnNoviembre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviembre.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 1
        boton12 = 0
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "NOVIEMBRE"
        v_mes = "11"
        v_ultimoDia = 30
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub btnDiciembre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiciembre.Click
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 1
        boton13 = 0
        Verificar_Click()
        v_nombreMes = "DICIEMBRE"
        v_mes = "12"
        v_ultimoDia = 30
        TodoslosMeses = 0
        PorMes = 1
        '
        If Me.rbPorVendedor.Checked = True Then
            Me.rbResumido.Enabled = False
            Me.rbDetallado.Enabled = True
        End If
    End Sub

    Private Sub rbTodosVendedores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTodosVendedores.CheckedChanged
        If Me.rbTodosVendedores.Checked = True Then
            boton13 = 0
            Verificar_Click()
            Me.btnTodos.Enabled = False
            Me.lstVendedores.Enabled = False
        End If
    End Sub

    Private Sub lstAnho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAnho.SelectedIndexChanged
        year = Trim(Me.lstAnho.SelectedValue.ToString())
    End Sub

    Private Sub rbPorVendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPorVendedor.CheckedChanged
        If Me.rbPorVendedor.Checked = True Then
            Me.btnTodos.Enabled = True
            Me.lstVendedores.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class