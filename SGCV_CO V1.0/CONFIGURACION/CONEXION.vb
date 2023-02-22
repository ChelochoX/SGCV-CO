Module CONEXION
    Public Sub conectar()
        usuario_ = "sa"
        contrasena_ = "Cesar1983"
        'servidor = "LAPTOP-RAHBKGCL" 'servidor de LJ COMERCIAL
        'servidor = "LAPTOP-6V5VESVJ\SQLEXPRESS" 'servidor de LJ COMERCIAL maquina nueva
        servidor = "DESKTOP-EPTCAVH\SQL08R2"
        bbdd = "LJ COMERCIAL"
        conexionbd = "server ='" & servidor & "';database ='" & bbdd & "' ; user id ='" & usuario_ & "'; password ='" & contrasena_ & "'"
        SQLconexion.ConnectionString = conexionbd

    End Sub
End Module
