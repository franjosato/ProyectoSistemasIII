Imports MySql.Data.MySqlClient

Module Module1
    Public conex As New MySqlConnection("server=localhost; database=sistemas3; user id=root; password=sistemas123")
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public sql As String
    Public comando As MySqlCommand


End Module
