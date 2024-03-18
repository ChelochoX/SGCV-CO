Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System

Module CredencialesParaReporte


    Public Class ManejadorReportes
        Public Shared Sub ConfigurarCredenciales(reporte As ReportDocument)

            Dim connectionInfo As New ConnectionInfo()

            ' Detecta si estás en tu máquina de desarrollo o en la máquina del cliente
            Dim esMaquinaDeDesarrollo As Boolean = DetectarMaquinaDeDesarrollo()

            If esMaquinaDeDesarrollo Then
                ' Configura las credenciales para tu máquina de desarrollo
                connectionInfo.ServerName = "CESAREXCELSIS\SQLEXP2008R2"
                connectionInfo.DatabaseName = "ljcomercial"
                connectionInfo.UserID = "sa"
                connectionInfo.Password = "Lezcano??Express2008R2"
            Else
                ' Configura las credenciales para la máquina del cliente (producción)
                connectionInfo.ServerName = "LJCOMERCIAL"
                connectionInfo.DatabaseName = "ljcomercial"
                connectionInfo.UserID = "sa"
                connectionInfo.Password = "Cesar?1983"
            End If

            ' Aplica las credenciales a todas las tablas del reporte
            For Each tabla As CrystalDecisions.CrystalReports.Engine.Table In reporte.Database.Tables
                Dim tableLogonInfo As CrystalDecisions.Shared.TableLogOnInfo = tabla.LogOnInfo
                tableLogonInfo.ConnectionInfo = connectionInfo
                tabla.ApplyLogOnInfo(tableLogonInfo)
            Next
        End Sub

        Private Shared Function DetectarMaquinaDeDesarrollo() As Boolean
            Dim respuesta As Boolean
            If ambiente = "desarrollo" Then
                respuesta = True
            Else
                respuesta = False
            End If
            Return respuesta
        End Function
    End Class

End Module
