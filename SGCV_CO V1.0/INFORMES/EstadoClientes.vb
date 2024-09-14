Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class EstadoClientes

    Dim FECHA_INICIAL, FECHA_FINAL, FECHA_FINAL_ As Date

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next

        ' Configurar las credenciales para los subreportes, si existen
        For Each section As Section In myReportDocument.ReportDefinition.Sections
            For Each reportObject As ReportObject In section.ReportObjects
                If reportObject.Kind = ReportObjectKind.SubreportObject Then
                    Dim subReport As SubreportObject = CType(reportObject, SubreportObject)
                    Dim subReportDocument As ReportDocument = subReport.OpenSubreport(subReport.SubreportName)

                    Dim subTables As Tables = subReportDocument.Database.Tables
                    For Each subTable As CrystalDecisions.CrystalReports.Engine.Table In subTables
                        Dim subTableLogonInfo As TableLogOnInfo = subTable.LogOnInfo
                        subTableLogonInfo.ConnectionInfo = myConnectionInfo
                        subTable.ApplyLogOnInfo(subTableLogonInfo)
                    Next
                End If
            Next
        Next
    End Sub

    Private Sub EstadoClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Configurar las credenciales de conexión
        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor
        iconexion.Type = ConnectionInfoType.SQL
        iconexion.IntegratedSecurity = False ' Desactivar autenticación integrada si no se utiliza

    End Sub

    Private Sub btnCerrar_Periodo_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar_Periodo.Click
        If rbDeudaTotalClienteListado.Checked = True Then
            'VENTAS POR VENDEDOR!!
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("EstadoGeneralCuentaCliente", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New EstadoGeneralCuentaCliente

                info.SetDataSource(ds)
                SetDBLogonForReport(iconexion, info)
                Me.crw.ReportSource = info
                ' Desactivar diálogos de login
                Me.crw.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
                Me.crw.ShowParameterPanelButton = False
                Me.crw.ShowGroupTreeButton = False

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        Else
            If rbCarteraClienteDetallado.Checked = True Then
                'VENTAS POR VENDEDOR!!
                Try
                    conectar()
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("CARTERADECLIENTE", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New CarteraCliente

                    info.SetDataSource(ds)
                    SetDBLogonForReport(iconexion, info)
                    Me.crw.ReportSource = info
                    ' Desactivar diálogos de login
                    Me.crw.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
                    Me.crw.ShowParameterPanelButton = False
                    Me.crw.ShowGroupTreeButton = False

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            Else
                If rbDeudaTotalClienteResumido.Checked = True Then
                    'VENTAS POR VENDEDOR!!
                    Try
                        conectar()
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("TotalaCarteraClienteResumido", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New CarteraClienteResumido

                        info.SetDataSource(ds)
                        SetDBLogonForReport(iconexion, info)
                        Me.crw.ReportSource = info
                        ' Desactivar diálogos de login
                        Me.crw.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
                        Me.crw.ShowParameterPanelButton = False
                        Me.crw.ShowGroupTreeButton = False

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class