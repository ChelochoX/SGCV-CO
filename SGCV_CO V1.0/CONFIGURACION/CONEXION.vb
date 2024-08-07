Module CONEXION
    Public Sub conectar()
        usuario_ = "sa"
        contrasena_ = "Cesar?1983"
        'contrasena_ = "Lezcano??Express2008R2"
        'Maquina de Pedro
        servidor = "LJCOMERCIAL" 'servidor de LJ COMERCIAL
        'Maquina de Chelo Particular
        'servidor = "CESAR-LEZCANO"
        'Maquina de Chelo Nuevo Gris
        'servidor = "CESAREXCELSIS\SQLEXP2008R2"
        bbdd = "ljcomercial"
        'ambiente = "desarrollo"
        ambiente = "produccion"
        conexionbd = "server ='" & servidor & "';database ='" & bbdd & "' ; user id ='" & usuario_ & "'; password ='" & contrasena_ & "'"
        SQLconexion.ConnectionString = conexionbd
    End Sub
End Module
