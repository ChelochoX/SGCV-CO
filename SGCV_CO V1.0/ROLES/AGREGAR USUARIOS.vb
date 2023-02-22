Public Class AGREGAR_USUARIOS
    Dim contador, cod_usuario As Integer
    Dim DaUsuario As New SqlClient.SqlDataAdapter
    Dim DPTO As String

    Private Sub AGREGAR_USUARIOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Visualizar_Usuario()
        Me.txtSucursal.Text = Trim(Nombre_Sucursal())
        Dim Departamento() As String = {"CAJA", "VENTAS SALON", "COBRANZA EXTERNA", "COBRANZA SALON", "VENTAS EXTERNAS", "DEPOSITO"}
        For Each item As String In Departamento
            cbDpto.Items.Add(item)
        Next
        Me.txtEstado.Text = "BLOQUEADO"
    End Sub

    Function Nombre_Sucursal() As String
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

    Function Contador_Usuario() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_USUARIO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function
    Function existe_usuario(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_USUARIO WHERE CEDULA = '" & a & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If Me.txtDatos_Personales.Text = "" Then
            MessageBox.Show("INGRESAR DATOS PERSONALES ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDatos_Personales.Focus()
        Else
            contador = Contador_Usuario() + 1
            Try
                SQLconexion.Open()
                Dim sqlbuilder As New System.Text.StringBuilder
                With sqlbuilder
                    .Append("INSERT INTO CONFIG_USUARIO")
                    .Append(" VALUES ('")
                    .Append(contador & "','")
                    .Append(CStr(Me.txtCIP.Text) & "','")
                    .Append(CStr(Me.txtDatos_Personales.Text) & "','")
                    .Append(CStr(Me.txtTelefono.Text) & "','")
                    .Append(CStr(Me.txtDireccion.Text) & "','")
                    .Append("BLOQUEADO" & "','")
                    .Append(txtUsuario.Text & "','")
                    .Append("" & "','")
                    .Append(Trim(Me.txtSucursal.Text) & "','")
                    .Append(Trim(Me.txtDepto.Text) & "','")
                    .Append("" & "')")

                End With

                cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                cmm.ExecuteNonQuery()
                SQLconexion.Close()
                cmm.Dispose()
                SQLconexion.Dispose()

            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

                'LIMPIAR LOS CAMPOS
                Me.txtCIP.Clear()
                Me.txtDatos_Personales.Clear()
                Me.txtTelefono.Clear()
                Me.txtDireccion.Clear()
                Me.txtEstado.Clear()
                Me.txtSucursal.Clear()
                Me.txtDepto.Clear()
            End If
        Me.txtEstado.Text = "BLOQUEADO"
        Visualizar_Usuario()

    End Sub

    Sub Visualizar_Usuario()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_USUARIO "
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaUsuario = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("USUARIO")
            DaUsuario.Fill(dt)
            SQLconexion.Close()

            With ListBox1
                .DataSource = dt
                .DisplayMember = "DATOS USUARIO"
                .ValueMember = "DATOS_PERSONALES"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click

        Dim NOMBRE As String
        Dim Da As New SqlClient.SqlDataAdapter
        NOMBRE = Me.ListBox1.Text
        'crear dataset
        Dim dt As New DataTable
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & NOMBRE & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaUsuario = New SqlClient.SqlDataAdapter(cmm)
            DaUsuario.Fill(dt)
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        If NOMBRE = dt.Rows(0)("DATOS_PERSONALES").ToString Then
            Me.txtCIP.Text = dt.Rows(0)("CEDULA").ToString
            Me.txtDatos_Personales.Text = dt.Rows(0)("DATOS_PERSONALES").ToString
            Me.txtTelefono.Text = dt.Rows(0)("TELEFONO").ToString
            Me.txtDireccion.Text = dt.Rows(0)("DIRECCION").ToString
            Me.txtEstado.Text = dt.Rows(0)("ESTADO").ToString
            Me.txtSucursal.Text = dt.Rows(0)("SUCURSAL").ToString
            Me.txtDepto.Text = dt.Rows(0)("DEPARTAMENTO").ToString
            Me.txtUsuario.Text = dt.Rows(0)("USUARIO").ToString
            cod_usuario = CInt(dt.Rows(0)("COD_USUARIO"))
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE CONFIG_USUARIO SET CEDULA='" & Trim(Me.txtCIP.Text) & "'," & _
            "TELEFONO='" & Trim(Me.txtTelefono.Text) & "',DIRECCION='" & Trim(Me.txtDireccion.Text) & "'," & _
            "DATOS_PERSONALES= '" & Trim(Me.txtDatos_Personales.Text) & "',DEPARTAMENTO= '" & Trim(Me.txtDepto.Text) & "' WHERE COD_USUARIO = " & cod_usuario & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        Visualizar_Usuario()

        'LIMPIAR LOS CAMPOS
        Me.txtCIP.Clear()
        Me.txtDatos_Personales.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtEstado.Clear()
        Me.txtSucursal.Clear()
        Me.txtDepto.Clear()

    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()
    End Sub

    Private Sub cbDpto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDpto.SelectedIndexChanged
        Me.txtDepto.Text = Me.cbDpto.SelectedItem.ToString
    End Sub

    Private Sub txtCIP_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCIP.Leave
        If existe_usuario(Trim(Me.txtCIP.Text)) > 0 Then
            MessageBox.Show("YA EXISTE REGISTRO CON LA MISMA CEDULA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtCIP.Focus()
        End If
    End Sub

    Private Sub txtDatos_Personales_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos_Personales.Leave

    End Sub
End Class