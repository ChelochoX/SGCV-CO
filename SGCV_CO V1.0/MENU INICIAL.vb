Public Class MENU_INICIAL

    Private Sub tmOcultar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultar.Tick
        If panelMenu.Width <= 80 Then
            Me.tmOcultar.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrar.Tick
        If panelMenu.Width >= 200 Then
            Me.tmMostrar.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If panelMenu.Width = 200 Then
            Me.tmOcultar.Enabled = True
        Else
            If panelMenu.Width = 80 Then
                Me.tmMostrar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnCerrarMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarMenu.Click
        Me.Close()
        Dim FormLogeo As New Logeo_de_Usuario
        FormLogeo.Show()

    End Sub

    Private Sub tmMostrarbtnCliente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarbtnCliente.Tick
        If panelBotonesClientes.Width >= 358 Then
            Me.tmMostrarbtnCliente.Enabled = False
        Else
            Me.panelBotonesClientes.Width = panelBotonesClientes.Width + 20
        End If
    End Sub

    Private Sub tmOcultarbtnClientes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarbtnClientes.Tick
        If panelBotonesClientes.Width <= 78 Then
            Me.tmOcultarbtnClientes.Enabled = False
        Else
            Me.panelBotonesClientes.Width = panelBotonesClientes.Width - 20
        End If
    End Sub

    Private Sub btnCLientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLientes.Click
        panelBotonesClientes.Visible = True
        panelbtnProductos.Visible = False
        panelCompras.Visible = False
        panelBtnVentas.Visible = False
        panelCaja.Visible = False
        panelInformes.Visible = False
        panelConfig.Visible = False

        panelbtnProductos.Width = 72
        panelCompras.Width = 57
        panelBtnVentas.Width = 52
        panelCaja.Width = 47
        panelInformes.Width = 32
        panelConfig.Width = 32

        If panelBotonesClientes.Width = 358 Then
            Me.tmOcultarbtnClientes.Enabled = True
        Else
            If panelBotonesClientes.Width = 78 Then
                Me.tmMostrarbtnCliente.Enabled = True
            End If
        End If
    End Sub

    Private Sub MENU_INICIAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        panelBotonesClientes.Visible = False
        panelbtnProductos.Visible = False
        panelCompras.Visible = False
        panelBtnVentas.Visible = False
        panelCaja.Visible = False
        panelInformes.Visible = False
        panelConfig.Visible = False

        panelBotonesClientes.Width = 78
        panelbtnProductos.Width = 72
        panelCompras.Width = 57
        panelBtnVentas.Width = 52
        panelCaja.Width = 47
        panelInformes.Width = 32
        panelConfig.Width = 32

        Me.btnUsuariologeado.Text = usuario_AUX
        Me.btnFechaLogeo.Text = Today

    End Sub

    Private Sub tmOcultarbtnProductos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarbtnProductos.Tick
        If panelbtnProductos.Width <= 72 Then
            Me.tmOcultarbtnProductos.Enabled = False
        Else
            Me.panelbtnProductos.Width = panelbtnProductos.Width - 20
        End If
    End Sub

    Private Sub tmMostrarbtnProductos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarbtnProductos.Tick
        If panelbtnProductos.Width >= 512 Then
            Me.tmMostrarbtnProductos.Enabled = False
        Else
            Me.panelbtnProductos.Width = panelbtnProductos.Width + 20
        End If
    End Sub

    Private Sub btnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click

        panelbtnProductos.Visible = True
        panelBotonesClientes.Visible = False
        panelCompras.Visible = False
        panelBtnVentas.Visible = False
        panelCaja.Visible = False
        panelInformes.Visible = False
        panelConfig.Visible = False

        panelBotonesClientes.Width = 78
        panelCompras.Width = 57
        panelBtnVentas.Width = 52
        panelCaja.Width = 47
        panelInformes.Width = 32
        panelConfig.Width = 32

        If panelbtnProductos.Width = 512 Then
            Me.tmOcultarbtnProductos.Enabled = True
        Else
            If panelbtnProductos.Width = 72 Then
                Me.tmMostrarbtnProductos.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmOcultarCompras_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarCompras.Tick
        If panelCompras.Width <= 57 Then
            Me.tmOcultarCompras.Enabled = False
        Else
            Me.panelCompras.Width = panelCompras.Width - 20
        End If
    End Sub

    Private Sub tmMostrarCompras_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarCompras.Tick
        If panelCompras.Width >= 817 Then
            Me.tmMostrarCompras.Enabled = False
        Else
            Me.panelCompras.Width = panelCompras.Width + 20
        End If
    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click

        panelBotonesClientes.Visible = False
        panelbtnProductos.Visible = False
        panelBtnVentas.Visible = False
        panelCompras.Visible = True
        panelCaja.Visible = False
        panelInformes.Visible = False
        panelConfig.Visible = False

        panelBotonesClientes.Width = 78
        panelbtnProductos.Width = 72
        panelBtnVentas.Width = 52
        panelCaja.Width = 47
        panelInformes.Width = 32
        panelConfig.Width = 32

        If panelCompras.Width = 817 Then
            Me.tmOcultarCompras.Enabled = True
        Else
            If panelCompras.Width = 57 Then
                Me.tmMostrarCompras.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmOcultarBtnVentas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarBtnVentas.Tick
        If panelBtnVentas.Width <= 57 Then
            Me.tmOcultarBtnVentas.Enabled = False
        Else
            Me.panelBtnVentas.Width = panelBtnVentas.Width - 20
        End If
    End Sub

    Private Sub tmMostarBtnVenas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostarBtnVenas.Tick
        If panelBtnVentas.Width >= 512 Then
            Me.tmMostarBtnVenas.Enabled = False
        Else
            Me.panelBtnVentas.Width = panelBtnVentas.Width + 20
        End If
    End Sub

    Private Sub btnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentas.Click

        panelBotonesClientes.Visible = False
        panelbtnProductos.Visible = False
        panelCompras.Visible = False
        panelBtnVentas.Visible = True
        panelCaja.Visible = False
        panelInformes.Visible = False
        panelConfig.Visible = False

        panelBotonesClientes.Width = 78
        panelbtnProductos.Width = 72
        panelCompras.Width = 57
        panelCaja.Width = 47
        panelInformes.Width = 32
        panelConfig.Width = 32

        If panelBtnVentas.Width = 512 Then
            Me.tmOcultarBtnVentas.Enabled = True
        Else
            If panelBtnVentas.Width = 52 Then
                Me.tmMostarBtnVenas.Enabled = True
            End If
        End If

    End Sub

    Private Sub tmOcultarBtnCaja_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarBtnCaja.Tick
        If panelCaja.Width <= 47 Then
            Me.tmOcultarBtnCaja.Enabled = False
        Else
            Me.panelCaja.Width = panelCaja.Width - 20
        End If
    End Sub

    Private Sub tmMostrarBtnCaja_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarBtnCaja.Tick
        If panelCaja.Width >= 667 Then
            Me.tmMostrarBtnCaja.Enabled = False
        Else
            Me.panelCaja.Width = panelCaja.Width + 20
        End If
    End Sub

    Private Sub btnCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaja.Click

        panelBotonesClientes.Visible = False
        panelbtnProductos.Visible = False
        panelCompras.Visible = False
        panelBtnVentas.Visible = False
        panelCaja.Visible = True
        panelInformes.Visible = False
        panelConfig.Visible = False

        panelBotonesClientes.Width = 78
        panelbtnProductos.Width = 72
        panelCompras.Width = 57
        panelBtnVentas.Width = 52
        panelInformes.Width = 32
        panelConfig.Width = 32

        If panelCaja.Width = 667 Then
            Me.tmOcultarBtnCaja.Enabled = True
        Else
            If panelCaja.Width = 47 Then
                Me.tmMostrarBtnCaja.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmOcultarBtnInformes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarBtnInformes.Tick
        If panelInformes.Width <= 32 Then
            Me.tmOcultarBtnInformes.Enabled = False
        Else
            Me.panelInformes.Width = panelInformes.Width - 20
        End If
    End Sub

    Private Sub btnInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformes.Click

        panelBotonesClientes.Visible = False
        panelbtnProductos.Visible = False
        panelCompras.Visible = False
        panelBtnVentas.Visible = False
        panelCaja.Visible = False
        panelInformes.Visible = True
        panelConfig.Visible = False

        panelBotonesClientes.Width = 78
        panelbtnProductos.Width = 72
        panelCompras.Width = 57
        panelBtnVentas.Width = 52
        panelCaja.Width = 47
        panelConfig.Width = 32

        If panelInformes.Width = 512 Then
            Me.tmOcultarBtnInformes.Enabled = True
        Else
            If panelInformes.Width = 32 Then
                Me.tmMostrarBtnInformes.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmMostrarBtnInformes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarBtnInformes.Tick
        If panelInformes.Width >= 512 Then
            Me.tmMostrarBtnInformes.Enabled = False
        Else
            Me.panelInformes.Width = panelInformes.Width + 20
        End If
    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click

        panelBotonesClientes.Visible = False
        panelbtnProductos.Visible = False
        panelCompras.Visible = False
        panelBtnVentas.Visible = False
        panelCaja.Visible = False
        panelInformes.Visible = False
        panelConfig.Visible = True

        panelBotonesClientes.Width = 78
        panelbtnProductos.Width = 72
        panelCompras.Width = 57
        panelBtnVentas.Width = 52
        panelCaja.Width = 47
        panelInformes.Width = 32

        If panelConfig.Width = 672 Then
            Me.tmOcultarBtnConfig.Enabled = True
        Else
            If panelConfig.Width = 32 Then
                Me.tmMostrarBtnConfig.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmOcultarBtnConfig_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmOcultarBtnConfig.Tick
        If panelConfig.Width <= 32 Then
            Me.tmOcultarBtnConfig.Enabled = False
        Else
            Me.panelConfig.Width = panelConfig.Width - 20
        End If
    End Sub

    Private Sub tmMostrarBtnConfig_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmMostrarBtnConfig.Tick
        If panelConfig.Width >= 672 Then
            Me.tmMostrarBtnConfig.Enabled = False
        Else
            Me.panelConfig.Width = panelConfig.Width + 20
        End If
    End Sub

    Private Sub btnRegistroCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroCliente.Click
        Dim FRM_REGISTROCLIENTES As New REGISTRO_CLIENTE
        FRM_REGISTROCLIENTES.Show()
    End Sub
    Private Sub btnReporteClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteClientes.Click
        Dim FRM_REPORTE_CLIENTES As New REPORTE_CLIENTES
        FRM_REPORTE_CLIENTES.Show()
    End Sub

    Private Sub btnUtilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUtilidad.Click

    End Sub
End Class