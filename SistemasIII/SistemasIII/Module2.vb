Imports MySql.Data
Imports MySql.Data.MySqlClient
Module Module2
    'Cadena conexion

    'Metodo para cargar los datos de la BD
    'Public Function Datos(Str As String) As DataTable
    'Dim dot As New DataTable()
    'Conectar()
    ''Consulta a la tabla Paises
    'Dim comando As New MySqlCommand(Str, cn)
    '
    'Dim adap As New MySqlDataAdapter(comando)
    '
    'adap.Fill(dot)
    'Return dot
    'End Function

    'Metodo para cargar la coleccion de datos para el AutoComplete
    Public Function Autocompletar(Str As String, colum As String) As AutoCompleteStringCollection
        Dim dot As DataTable = Datos(Str)

        Dim coleccion As New AutoCompleteStringCollection()
        'Recorrer y cargar los items para el Autocompletado
        For Each row As DataRow In dot.Rows
            coleccion.Add(Convert.ToString(row(colum)))
        Next

        Return coleccion
    End Function
End Module
