Module CONEXION
    Public Sub conectar()
        usuario_ = "sa"
        contrasena_ = "Cesar?1983"
        'servidor = "LJCOMERCIAL" 'servidor de LJ COMERCIAL
        servidor = "CESAR-LEZCANO"
        bbdd = "ljcomercial"
        conexionbd = "server ='" & servidor & "';database ='" & bbdd & "' ; user id ='" & usuario_ & "'; password ='" & contrasena_ & "'"
        SQLconexion.ConnectionString = conexionbd

    End Sub
End Module
