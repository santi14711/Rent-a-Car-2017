
Imports System.Data.Odbc
Imports System.IO
Imports System.Reflection

Module Module_ODBC

    'Variables ODBC
    Dim cm As New Odbc.OdbcCommand
    Dim da As Odbc.OdbcDataAdapter
    Dim ds As Data.DataSet
    Dim dr As Odbc.OdbcDataReader
    Dim cx As Odbc.OdbcConnection
    Public dt As Data.DataTable
    'Variables privadas accedidas por Get y Set
    Dim usuario As String
    Dim contraseña As String


    Function GetUsuario() As String
        Return usuario
    End Function

    Sub SetUsuario(user As String)
        usuario = user
    End Sub

    Function GetContraseña() As String
        Return contraseña
    End Function

    Sub SetContraseña(password As String)
        contraseña = password
    End Sub


    Function Connect(usuario, contraseña) As Boolean

        Try

            cx = New Odbc.OdbcConnection

            'cx.ConnectionString = "DRIVER=IBM INFORMIX ODBC DRIVER (64-bit);UID=" + usuario + ";PWD=" + contraseña + ";DATABASE=npgbdproyecto;HOST=*" + HostName + ";SERVER=ol_informix1;SERVICE=1526;PROTOCOL=olsoctcp;CLIENT_LOCALE=en_US.CP1252;DB_LOCALE=en_US.819;"

            'ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("ConJefe").ConnectionString

            ' Dim hola As String = Application.StartupPath 'probar conexion con startuppath

            'cx.ConnectionString = "FileDsn=C:\Users\admin\Desktop\Rent a Car 3\Proyecto ITS 2017\bin\Debug\hola.dsn; UID=" + usuario + ";PWD=" + contraseña + ""

            'cx.ConnectionString = "FileDsn=" + AppDomain.CurrentDomain.BaseDirectory + "hola.dsn;UID=" + usuario + ";PWD=" + contraseña
            cx.ConnectionString = "FileDsn=" + AppDomain.CurrentDomain.BaseDirectory + "gabriel.dsn;UID=" + usuario + ";PWD=" + contraseña
            cx.Open()


            Return True
        Catch ex As Exception
            Return False

        End Try
    End Function

    Function sentenciasNonQuery(sentencia) As Boolean
        Dim nrofilas As Integer
        Connect(usuario, contraseña)


        Try
            cm.Connection = cx
            cm.CommandText = sentencia
            nrofilas = cm.ExecuteNonQuery()
            If Not nrofilas = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try


    End Function

    Function executescalar(esto As String, deaca As String, donde As String, sea As String) As String
        Dim id As String
        Connect(usuario, contraseña)
        Try
            cm.Connection = cx
            cm.CommandText = "select " + esto + " from " + deaca + " where " + donde + " = '" + sea + "'"
            id = cm.ExecuteScalar()
            Return id

        Catch ex As Exception
            MessageBox.Show("error executescalar" + ex.Message)
            Return False
        End Try

    End Function

    Function executescalar2(esto As String, deaca As String, donde As String) As String
        Dim id As String
        Connect(usuario, contraseña)
        Try
            cm.Connection = cx
            cm.CommandText = "select " + esto + " from " + deaca + " where " + donde + ""
            id = cm.ExecuteScalar()

            Return id
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function





    Function Execute(sentencia As String) As DataTable

        dt = New Data.DataTable

        Connect(usuario, contraseña)

        Try

            cm.Connection = cx

            cm.CommandText = sentencia

            dt.Load(cm.ExecuteReader())

            Return dt

        Catch ex As Exception


        Finally

            Cerrar()

        End Try

    End Function

    Function Cerrar() As Boolean

        Try

            cx.Close()

            Return True

        Catch ex As Exception

            MessageBox.Show("Se produjo un error en el cierre de la conexion :  " + ex.Message)

            Return False

        End Try

    End Function

    Public Function DataGrids(com As String, dgv As DataGridView) As Boolean
        dt = New Data.DataTable
        Try

            Execute(com)

            dgv.DataSource = dt

            Return True

        Catch ex As Exception

            MessageBox.Show("Se produjo un error en el relleno del DataGridView : " + ex.Message)

            Return False

        Finally

            Cerrar()

        End Try

    End Function

End Module
