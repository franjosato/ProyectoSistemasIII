Imports MySql.Data.MySqlClient

Module Mod_Base_de_Datos
    Public cn As New MySqlConnection
    Public da As MySqlDataAdapter
    'Public dt As DataTable
    Public sql As String
    Public cmd As MySqlCommand
    Public sdr As MySqlDataReader
    Public sentencia As String
    Public sentencia1 As String
    Public stringco As String = "server=localhost;user id=root;password=f2481995;persistsecurityinfo=True;database=sis3"

    Public Sub Conectar()
        cn.Close()
        cn.ConnectionString = "server=localhost;user id=root;password=f2481995;persistsecurityinfo=True;database=sis3"
        cn.Open()
    End Sub

    Public Sub Desconectar()
        sdr.Close()
        cn.Close()
    End Sub

    Public Sub CSelect(ByRef Sentencia As String)
        Try
            Conectar()
            cmd = New MySqlCommand(Sentencia, cn)
            sdr = cmd.ExecuteReader
            sdr.Read()
            'cn.Close
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Comando(ByRef sentencia As String)
        Try
            Conectar()
            cmd = New MySqlCommand(sentencia, cn)
            sdr = cmd.ExecuteReader()

            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function comando22(ByRef strg As String) As Boolean

        Using conn As New MySqlConnection(stringco)
            Using sqlc As New MySqlCommand()

                With sqlc
                    .CommandText = strg
                    .Connection = conn
                    .CommandType = CommandType.Text
                End With

                Try
                    conn.Open()
                    sqlc.ExecuteNonQuery()
                    Return True
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    Return False
                Finally
                    conn.Close()
                End Try
            End Using

        End Using

    End Function

    Public Function Datos(ByRef sen As String) As DataTable
        Dim dt As New DataTable
        Conectar()
        Dim comando As New MySqlCommand(sen, cn)
        Dim adap As New MySqlDataAdapter(comando)

        adap.Fill(dt)
        cn.Close()
        Return dt
    End Function




End Module