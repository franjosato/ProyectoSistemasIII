Imports MySql.Data.MySqlClient

Module Module1
    Public cn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public sql As String
    Public cmd As MySqlCommand
    Public sdr As MySqlDataReader

    Public Sub Conectar()
        cn.ConnectionString = "server=localhost;user id=root;password=f2481995;persistsecurityinfo=True;database=sis3"
        cn.Open()
    End Sub

    Public Sub Desconectar()
        cn.Close()
    End Sub

    Public Sub CSelect(ByRef Sentencia As String)
        cmd = New MySqlCommand(Sentencia, cn)
        sdr = cmd.ExecuteReader()
        sdr.Read()

    End Sub
End Module
