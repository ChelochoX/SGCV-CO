Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class PREPARAR_PRESUPUESTO

    Dim Retorno As SqlClient.SqlDataReader
    Dim DaProducto, DaDetallePresu, DaCabeceraPresu As New SqlClient.SqlDataAdapter
    Dim DsProducto, DsDetallePresu, DsCabeceraPresu As New Data.DataSet
    Dim fecha As Date
    Dim mensaje_ejemplo, mensaje_obs, paraBorrar As String
    Dim bandera, contador, TotalPrecio, TotalCantidad As Integer
    Dim paraBorrarCantidad, paraBorrarMonto As Integer


    Sub Cargar_Datos()

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub


    Private Sub PREPARAR_PRESUPUESTO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()
        fecha = DateTime.Now

        'CONTADOR CABECERA
        contador = contador_() + 1
        Me.txtPresupuestoNum.Text = contador
        '
        'MESAJE EJEMPLO
        mensaje_ejemplo = "A través de la presente, LJ Comercial, le extiende sus más cordiales saludos y hace de su conocimiento " & _
            "una amplia variedad de productos de uso domesticos y de oficinas que pone a su disposicion de las mas reconocidas marcas del Pais." + vbNewLine
        mensaje_ejemplo += "A continuacion detallamos los productos de gran calidad al precio mas bajo para tener la preferencia de nuestros clientes:" + vbNewLine
        Me.txtMensaje1.Text = mensaje_ejemplo

        mensaje_obs = "Precios válidos hasta el 1 de noviembre de 2020" + vbNewLine
        mensaje_obs += "Todos sus pedidos incluirán sin costo adicional el envío hasta sus deposito de nuestra mercancía, " & _
            "también tenemos facilidades de pago y le garantizamos un servicio oportuno y un trato amable." + vbNewLine
        mensaje_obs += "Agradecemos su preferencia y lo esperamos en nuestra sucursal, de Lunes a Viernes, de 8:00 a 17:00 horas, y sábados de 8:00 a 12:00"
        Me.txtMensaje_Obs.Text = mensaje_obs

        AutoCompetadoTexto(txtArticulo)
        bandera = 0

        'VISUALIZAR CABECERA
        Visualizar_Cabecera()

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

    End Sub

    Sub AutoCompetadoTexto(ByVal Texto As TextBox)
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT NOMBRE FROM TP_PRODUCTO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            Retorno = cmm.ExecuteReader
            While Retorno.Read
                Texto.AutoCompleteCustomSource.Add(Retorno.Item("NOMBRE"))
            End While
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub


    Private Sub rbMensaje_Ejemplo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMensaje_Ejemplo.CheckedChanged
        Me.txtMensaje1.Clear()
        Me.txtMensaje1.Text = mensaje_ejemplo
    End Sub

    Private Sub rbMensaje_Editado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMensaje_Editado.CheckedChanged
        Me.txtMensaje1.Clear()
        Me.txtMensaje1.Focus()
    End Sub

    Function Existe_Producto(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_PRODUCTO WHERE CODIGO = '" & a & "'"
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

    Function Existe_Producto1(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CODIGO FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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

    Private Sub txtCodigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave

        If Me.txtCodigo.Text = "" Then

        Else
            If Existe_Producto(Trim(Me.txtCodigo.Text)) = 0 Then
                MessageBox.Show("PRODUCTO NO EXISTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCodigo.Clear()
            Else
                Dim i As Integer
                For i = 0 To Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Count - 1
                    Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Position = i
                    If (Trim(Me.txtCodigo.Text)) = (Trim(Me.DsProducto.Tables("TP_PRODUCTO").Rows(Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Position).Item("CODIGO").ToString)) Then

                        Me.txtArticulo.Text = Trim(Me.DsProducto.Tables("TP_PRODUCTO").Rows(Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Position).Item("NOMBRE").ToString)

                    End If
                Next
            End If
            Me.txtArticulo.Focus()
        End If
    End Sub

    Private Sub txtArticulo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArticulo.Leave
        Me.txtCodigo.Text = Existe_Producto1(Trim(Me.txtArticulo.Text))
        Me.txtCantidad.Focus()
    End Sub

    Function contador_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(MAX(COD_CAB_PRESUPUESTO),0) FROM VF_CABECERA_PRESUPUESTO"
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

    Function contadorDetalle_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(MAX(COD_DET_PRESUPUESTO),0) FROM VF_DETALLE_PRESUPUESTO"
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


    Private Sub btnAgregar_Producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar_Producto.Click

        Try
            If Me.txtCodigo.Text = "" Then
                MessageBox.Show("NO INGRESAR CODIGO VACIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Me.txtArticulo.Text = "" Then
                    MessageBox.Show("NO INGRESAR NOMBRE VACIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If (Me.txtCodigo.Text = "") Or (Me.txtCodigo.Text = "0") Then
                        MessageBox.Show("NO INGRESAR CANTIDAD VACIO o NULO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If (Me.txtPrecio_Unitario.Text = "") Or (Me.txtPrecio_Unitario.Text = "0") Then
                            MessageBox.Show("NO INGRESAR PRECIO VACIO o NULO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'INSERTAMOS CABECERA
                            If bandera = 0 Then
                                bandera = 1

                                SQLconexion.Open()
                                Dim sqlbuilder As New System.Text.StringBuilder
                                With sqlbuilder
                                    .Append("INSERT INTO VF_CABECERA_PRESUPUESTO")
                                    .Append(" VALUES ('")
                                    .Append(contador & "','")
                                    .Append(CDate(Today) & "','")
                                    .Append(Trim(Me.txtFecha.Text) & "','")
                                    .Append(Trim(Me.txtDestinadoA.Text) & "','")
                                    .Append(Trim(Me.txtMensaje1.Text) & "','")
                                    .Append(Trim(Me.txtMensaje_Obs.Text) & "','")
                                    .Append(Trim(Me.txtDatosVendedor.Text) & "','")
                                    .Append(Trim(Me.txtContactoVendedor.Text) & "')")

                                End With

                                cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                                cmm.ExecuteNonQuery()
                                SQLconexion.Close()
                                cmm.Dispose()
                                SQLconexion.Dispose()
                            End If

                            'INSERTAMOS DETALLE
                            'CONTADOR DETALLE
                            Dim contador_detalle As Integer
                            contador_detalle = contadorDetalle_() + 1

                            'CALCULO TOTAL POR ITEM
                            Dim TotalporItem As Integer
                            TotalporItem = CInt(txtCantidad.Text) * CInt(txtPrecio_Unitario.Text)
                            'CALCULO PRESUPUESTO
                            TotalPrecio = TotalPrecio + TotalporItem
                            Me.txtTotalPresupuesto.Text = CStr(Puntos(TotalPrecio))
                            'CALCULO CANTIDAD
                            TotalCantidad = TotalCantidad + CInt(txtCantidad.Text)
                            Me.txtTotalCantidad.Text = CStr(Puntos(TotalCantidad))


                            SQLconexion.Open()
                            Dim sqlbuilder1 As New System.Text.StringBuilder
                            With sqlbuilder1
                                .Append("INSERT INTO VF_DETALLE_PRESUPUESTO")
                                .Append(" VALUES ('")
                                .Append(contador_detalle & "','")
                                .Append(contador & "','")
                                .Append(Trim(Me.txtCodigo.Text) & "','")
                                .Append(Trim(Me.txtArticulo.Text) & "','")
                                .Append(CInt(Me.txtCantidad.Text) & "','")
                                .Append(CInt(Me.txtPrecio_Unitario.Text) & "','")
                                .Append(CInt(TotalporItem) & "')")

                            End With

                            cmm = New SqlClient.SqlCommand(sqlbuilder1.ToString, SQLconexion)
                            cmm.ExecuteNonQuery()
                            SQLconexion.Close()
                            cmm.Dispose()
                            SQLconexion.Dispose()

                            'LIMPIAR LOS CAMPOS
                            Me.txtCodigo.Clear()
                            Me.txtArticulo.Clear()
                            Me.txtCantidad.Clear()
                            Me.txtPrecio_Unitario.Clear()

                        End If
                    End If
                End If
            End If

            Visualizar_Detalle(contador)

        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    '** VISUALIZAR DETALLE DE PRESUPUESTO***
    Public Sub Visualizar_Detalle(ByVal a As Integer)

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_PRESUPUESTO WHERE COD_CAB_PRESUPUESTO = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            DaDetallePresu = New SqlClient.SqlDataAdapter(cmm)
            DsDetallePresu = New Data.DataSet
            DaDetallePresu.Fill(Me.DsDetallePresu, "VF_DETALLE_PRESUPUESTO")

            Me.dg_presupuesto.DataSource = Me.DsDetallePresu
            Me.dg_presupuesto.DataMember = "VF_DETALLE_PRESUPUESTO"

            DaDetallePresu.Update(Me.DsDetallePresu, "VF_DETALLE_PRESUPUESTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    '** VISUALIZAR CABECERA DE PRESUPUESTO***
    Public Sub Visualizar_Cabecera()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_CABECERA_PRESUPUESTO ORDER BY FECHA_INSERTADO DESC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            DaCabeceraPresu = New SqlClient.SqlDataAdapter(cmm)
            DsCabeceraPresu = New Data.DataSet
            DaCabeceraPresu.Fill(Me.DsCabeceraPresu, "VF_CABECERA_PRESUPUESTO")

            Me.dg_SegPresupuesto.DataSource = Me.DsCabeceraPresu
            Me.dg_SegPresupuesto.DataMember = "VF_CABECERA_PRESUPUESTO"

            DaCabeceraPresu.Update(Me.DsCabeceraPresu, "VF_CABECERA_PRESUPUESTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub brnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnGuardar.Click

        If Me.txtDatosVendedor.Text = "" Then

        Else
            'ACTUALIZAMOS LOS CAMPOS RESTANTES
            Try
                Dim sel As String
                sel = "UPDATE VF_CABECERA_PRESUPUESTO SET DATOS_VENDEDOR = '" & Trim(Me.txtDatosVendedor.Text) & "'," & _
                "TELEFONO_VENDEDOR = '" & Trim(Me.txtContactoVendedor.Text) & "' " & _
                "WHERE COD_CAB_PRESUPUESTO = " & contador & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

            bandera = 0
            'CONTADOR CABECERA
            contador = contador_() + 1
            Me.txtPresupuestoNum.Text = contador
            'VISUALAR DETALLE
            Visualizar_Detalle(0)
            'VISUALIZAR CABECERA
            Visualizar_Cabecera()
            'VACIAMOS LOS TEXT
            Me.txtFecha.Clear()
            Me.txtDestinadoA.Clear()
            Me.txtTotalPresupuesto.Clear()
            Me.txtTotalPresupuesto.Clear()
            Me.txtDatosVendedor.Clear()
            Me.txtContactoVendedor.Clear()

        End If

    End Sub

    Private Sub dg_presupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg_presupuesto.Click
        Try
            paraBorrar = Me.dg_presupuesto.Item(Me.dg_presupuesto.CurrentRowIndex, 0)
            paraBorrarCantidad = Me.dg_presupuesto.Item(Me.dg_presupuesto.CurrentRowIndex, 2)
            paraBorrarMonto = Me.dg_presupuesto.Item(Me.dg_presupuesto.CurrentRowIndex, 4)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnQuitar_Producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar_Producto.Click

        If paraBorrar = "" Then

        Else

            Try
                Dim sel As String
                sel = "DELETE FROM VF_DETALLE_PRESUPUESTO WHERE CODIGO_ARTICULO = '" & paraBorrar & "' AND COD_CAB_PRESUPUESTO = " & contador & " "
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
            'MOSTRAMOS LA GRILLA DESCONTADO
            Visualizar_Detalle(contador)
            'DESCONTAMOS DEL TOTAL DE CANTIDAD Y MONTO
            TotalPrecio = TotalPrecio - paraBorrarMonto
            Me.txtTotalPresupuesto.Text = CStr(Puntos(TotalPrecio))
            TotalCantidad = TotalCantidad - paraBorrarCantidad
            Me.txtTotalCantidad.Text = CStr(Puntos(TotalCantidad))

        End If
    End Sub

    Private Sub rbPie_MensajeEjemplo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPie_MensajeEjemplo.CheckedChanged
        Me.txtMensaje_Obs.Clear()
        Me.txtMensaje_Obs.Text = mensaje_obs
    End Sub

    Private Sub rbPie_MensajeEditado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPie_MensajeEditado.CheckedChanged
        Me.txtMensaje_Obs.Clear()
        Me.txtMensaje_Obs.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        If COMPLETO_PROCESO(contador) = 0 Then
            'ELIMINAMOS LOS REGISTROS DE LA TABLAS INCOMPLETAS
            'CABECERA
            Try
                Dim sel As String
                sel = "DELETE FROM VF_CABECERA_PRESUPUESTO WHERE COD_CAB_PRESUPUESTO = " & contador & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
            'DETALLE
            Try
                Dim sel As String
                sel = "DELETE FROM VF_DETALLE_PRESUPUESTO WHERE COD_CAB_PRESUPUESTO = " & contador & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        End If

        Me.Close()

    End Sub

    Function COMPLETO_PROCESO(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(DATOS_VENDEDOR,0) FROM VF_CABECERA_PRESUPUESTO WHERE COD_CAB_PRESUPUESTO = " & a & ""
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

    Private Sub dg_SegPresupuesto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg_SegPresupuesto.DoubleClick

        Dim paraReporte As Integer
        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        If Me.dg_SegPresupuesto.CurrentRowIndex < 0 Then

        Else
            paraReporte = Me.dg_SegPresupuesto.Item(Me.dg_SegPresupuesto.CurrentRowIndex, 0)

            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("REPORTE_PRESUPUESTO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUMERO_PRESUPUESTO", paraReporte)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New REPORTE_PRESUPUESTO
                info.SetDataSource(ds)
                info.SetParameterValue("@NUMERO_PRESUPUESTO", paraReporte)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                info.PrintOptions.PrinterName = impresosaPredt
                info.PrintToPrinter(1, False, 0, 0)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If

    End Sub
End Class