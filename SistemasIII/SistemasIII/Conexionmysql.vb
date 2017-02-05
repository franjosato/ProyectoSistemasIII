Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Conexionmysql
    Public _cadena As String ' se usa únicamente para obtener los datos de conexión
    Public _conexion As MySqlConnection 'esta variable se encargara de conectar la BD


    Public Function conexion_global() As Boolean 'se crea una funcion publica boleana como estamos en un modulo esto evitara colocar el mismo método en diferentes forms 
        Dim _estado As Boolean = True 'automáticamente se vuelve verdadera la funcion

        Try
            _cadena = ("server=localhost; database=sistemas3; user id=root; password=sistemas123") 'aqui se conecta a la BD de mysql
            _conexion = New MySqlConnection(_cadena)
            _conexion.Open() '.Open hace el enlace con la BD
        Catch ex As Exception 'en caso contrario
            MessageBox.Show(ex.Message) 'mostrara un mensaje de error
            _estado = False
        End Try 'fin del try

        Return _estado ' en una funcion siempre debe de existir un return. el caso es que en cuanto termine de revisar mandará exactamente el estado en el que se encuentre


    End Function ' se termina la función


    Public Sub cerrar()
        _conexion.Close()


    End Sub
End Module
