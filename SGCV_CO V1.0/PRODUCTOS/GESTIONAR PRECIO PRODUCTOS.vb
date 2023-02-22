Public Class GESTIONAR_PRECIO_PRODUCTOS

    Dim DaProducto, DaCuotasCredito As New SqlClient.SqlDataAdapter
    Dim DsProducto, DsCuotasCredito As New Data.DataSet
    Dim CODIGO_PROD, articulo As String
    Dim PRECIO_PROD, COD_PROD, precio_contado, precio_credito, para_Codigo As Integer
    Dim nombre, codigo, descrip, paraModificarPrecio, paraDefinirPrecio, bandera_ok As Integer

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

    Private Sub GESTIONAR_PRECIO_PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()
        codigo = 0
        nombre = 0
        descrip = 0
        paraModificarPrecio = 0
        paraDefinirPrecio = 0
        bandera_ok = 0
    End Sub

    Private Sub txtBuscar_Producto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar_Producto.TextChanged

        If Me.rbNombre.Checked = True Then
            Try
                conectar()
                Dim sel As String
                SQLconexion.Open()
                sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & Trim(Me.txtBuscar_Producto.Text) & "%'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaProducto = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsProducto = New Data.DataSet
                DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
                'asignar dataset al datagrid
                Me.dg_Producto.DataSource = Me.DsProducto
                Me.dg_Producto.DataMember = "TP_PRODUCTO"

                Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Else
            If Me.rbCodigo.Checked = True Then
                Try
                    conectar()
                    Dim sel As String
                    SQLconexion.Open()
                    sel = "SELECT * FROM TP_PRODUCTO WHERE CODIGO LIKE '%" & Trim(Me.txtBuscar_Producto.Text) & "%'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaProducto = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    DsProducto = New Data.DataSet
                    DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
                    'asignar dataset al datagrid
                    Me.dg_Producto.DataSource = Me.DsProducto
                    Me.dg_Producto.DataMember = "TP_PRODUCTO"

                    Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try
            Else
                If Me.rbDescripcion.Checked = True Then
                    Try
                        conectar()
                        Dim sel As String
                        SQLconexion.Open()
                        sel = "SELECT * FROM TP_PRODUCTO WHERE DESCRIPCION LIKE '%" & Trim(Me.txtBuscar_Producto.Text) & "%'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        'crear adapter
                        DaProducto = New SqlClient.SqlDataAdapter(cmm)
                        'crear dataset
                        DsProducto = New Data.DataSet
                        DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
                        'asignar dataset al datagrid
                        Me.dg_Producto.DataSource = Me.DsProducto
                        Me.dg_Producto.DataMember = "TP_PRODUCTO"

                        Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
                        SQLconexion.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                End If
            End If
        End If
       
    End Sub

    Private Sub btnAplicar_Precio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar_Precio.Click

        If paraModificarPrecio = 0 Then
            MessageBox.Show("DEBE SELECCIONAR MODIFICAR PRECIO POR ITEM O POR COMPLETO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtProductoAfectado.Focus()
        Else
            If paraDefinirPrecio = 0 Then
                MessageBox.Show("DEBE SELECCIONAR DEFINIR PRECIO POR MONTO FIJO O PORCENTAJE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtProductoAfectado.Focus()
            Else
                If Me.txtPrecio_Contado.Text = "" Then
                    MessageBox.Show("DEBE INGRESAR MONTO PARA APLICAR PRECIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtPrecio_Contado.Focus()
                Else
                    If Me.rbporCOMPLETO.Checked = True Then

                        For i = 0 To Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Count - 1
                            Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Position = i

                            COD_PROD = CInt(Me.DsProducto.Tables("TP_PRODUCTO").Rows(Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Position).Item("COD_PRODUCTO").ToString)
                            CODIGO_PROD = Trim(Me.DsProducto.Tables("TP_PRODUCTO").Rows(Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Position).Item("CODIGO").ToString)
                            PRECIO_PROD = CInt(Me.DsProducto.Tables("TP_PRODUCTO").Rows(Me.BindingContext(Me.DsProducto, "TP_PRODUCTO").Position).Item("PRECIO_COMPRA").ToString)

                            Dim contado, precioActualizado As Integer
                            contado = CInt(Me.txtPrecio_Contado.Text)

                            If Me.rbPrecioFijo.Checked = True Then
                                precioActualizado = PRECIO_PROD + contado
                            Else
                                If Me.rbPrecioPorcentaje.Checked = True Then
                                    precio_contado = PRECIO_PROD * (contado / 100)
                                    precioActualizado = PRECIO_PROD + precio_contado
                                End If
                            End If

                            conectar()
                            Dim sel As String
                            sel = "UPDATE TP_PRODUCTO SET PRECIO_CONTADO =" & precioActualizado & ",OBSERVACION = '" & Trim(Me.txtPromocion.Text) & "'" & _
                            " WHERE CODIGO ='" & CODIGO_PROD & "'"
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()
                            bandera_ok = 1
                        Next
                    Else
                        If Me.rbporITEM.Checked = True Then

                            If articulo = "" Then
                                MessageBox.Show("DEBE SELECCIONAR ARTICULO A MODIFICAR PRECIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.txtBuscar_Producto.Focus()
                            Else
                                CODIGO_PROD = articulo
                                PRECIO_PROD = Seleccionar_PrecioProducto_codigo(articulo)


                                Dim contado, precioActualizado As Integer
                                contado = CInt(Me.txtPrecio_Contado.Text)

                                If Me.rbPrecioFijo.Checked = True Then
                                    precioActualizado = PRECIO_PROD + contado
                                Else
                                    If Me.rbPrecioPorcentaje.Checked = True Then
                                        precio_contado = (PRECIO_PROD * (contado / 100))
                                        precioActualizado = PRECIO_PROD + precio_contado
                                    End If
                                End If

                                conectar()
                                Dim sel As String
                                sel = "UPDATE TP_PRODUCTO SET PRECIO_CONTADO =" & precioActualizado & ",OBSERVACION = '" & Trim(Me.txtPromocion.Text) & "' " & _
                                " WHERE CODIGO LIKE '" & CODIGO_PROD & "'"
                                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                SQLconexion.Open()
                                Dim t As Integer = CInt(cmm.ExecuteScalar())
                                cmm.Dispose()
                                SQLconexion.Close()
                                bandera_ok = 1
                            End If
                        End If
                    End If

                    If bandera_ok = 1 Then
                        MessageBox.Show("PROCESADO CORRECTAMENTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtBuscar_Producto.Clear()
                        Me.txtMonto_Contado.Clear()
                        Me.txtPrecio_Contado.Clear()
                        Me.txtProducto_Seleccionado.Clear()
                        Me.txtProductoAfectado.Clear()
                        Me.rbporITEM.Checked = False
                        Me.rbporCOMPLETO.Checked = False
                        Me.rbPrecioFijo.Checked = False
                        Me.rbPrecioPorcentaje.Checked = False

                        codigo = 0
                        nombre = 0
                        descrip = 0
                        paraModificarPrecio = 0
                        paraDefinirPrecio = 0
                        bandera_ok = 0
                        Ver_Detalles_Productos_Precios_()
                    End If
                End If
            End If
        End If

    End Sub

    Function Seleccionar_CodProducto(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_PRODUCTO FROM TP_PRODUCTO WHERE NOMBRE = '" & a & "'"
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

    Function Seleccionar_CodigoProducto_nom(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CODIGO FROM TP_PRODUCTO WHERE NOMBRE = '" & a & "'"
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

    Function Seleccionar_CodigoProducto_descrip(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CODIGO FROM TP_PRODUCTO WHERE DESCRIPCION = '" & a & "'"
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

    Function Seleccionar_PrecioProducto_nom(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PRECIO_COMPRA FROM TP_PRODUCTO WHERE NOMBRE = '" & a & "'"
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

    Function Seleccionar_PrecioProducto_codigo(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PRECIO_COMPRA FROM TP_PRODUCTO WHERE CODIGO = '" & a & "'"
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

    Function Seleccionar_PrecioProducto_descrip(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PRECIO_COMPRA FROM TP_PRODUCTO WHERE DESCRIPCION = '" & a & "'"
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

    Sub Ver_Detalles_Productos_Precios(ByVal a As String)
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_PRODUCTO WHERE CODIGO = '" & a & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            'asignar dataset al datagrid
            Me.dg_Producto.DataSource = Me.DsProducto
            Me.dg_Producto.DataMember = "TP_PRODUCTO"

            Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Sub Ver_Detalles_Productos_Precios_()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_PRODUCTO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            'asignar dataset al datagrid
            Me.dg_Producto.DataSource = Me.DsProducto
            Me.dg_Producto.DataMember = "TP_PRODUCTO"

            Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtLimpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLimpiar.Click
        Me.txtBuscar_Producto.Clear()
        Me.txtMonto_Contado.Clear()
        Me.txtPrecio_Contado.Clear()
        Me.txtProducto_Seleccionado.Clear()
        Me.txtProductoAfectado.Clear()
        Me.rbporITEM.Checked = False
        Me.rbporCOMPLETO.Checked = False
        Me.rbPrecioFijo.Checked = False
        Me.rbPrecioPorcentaje.Checked = False

        Ver_Detalles_Productos_Precios("PATO FEO")

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dg_Producto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Producto.Click
        Me.txtProducto_Seleccionado.Text = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 1))
        Me.txtDetalles_Promo.Text = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 7))
        Me.txtMonto_Contado.Text = Puntos(CInt(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 4)))
        para_Codigo = CInt(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 6))
        Me.txtProductoAfectado.Text = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 0))
        articulo = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 0))
    End Sub

    Private Sub rbNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombre.Click
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub rbCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigo.Click
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub rbDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDescripcion.Click
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub rbporITEM_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbporITEM.Leave
        paraModificarPrecio = 1
    End Sub

    Private Sub rbporCOMPLETO_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbporCOMPLETO.Leave
        paraModificarPrecio = 1
    End Sub

    Private Sub rbPrecioFijo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPrecioFijo.Leave
        paraDefinirPrecio = 1
        Me.Label14.Text = "EL MONTO QUE SE APLICARA SERA MONTO FIJO"
    End Sub

    Private Sub rbPrecioPorcentaje_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPrecioPorcentaje.Leave
        paraDefinirPrecio = 1
        Me.Label14.Text = "EL MONTO QUE SE APLICARA SERA MONTO EN %"
    End Sub
End Class