Imports System.Data
Imports System.Data.OleDb


Public NotInheritable Class DBMngr

    Dim cnnOLEDB As New OleDbConnection

    Dim cmdOLEDB As New OleDbCommand

    Dim cmdInsert As New OleDbCommand

    Dim cmdUpdate As New OleDbCommand

    Dim cmdDelete As New OleDbCommand

    Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        System.Environment.CurrentDirectory & "\MAPI_DB.accdb"

    Private Shared ReadOnly _instance As New Lazy(Of DBMngr)(Function() New DBMngr(),
                                    System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
        cnnOLEDB.ConnectionString = strConnectionString
        cnnOLEDB.Open()
    End Sub

    Public Shared ReadOnly Property Instance() As DBMngr
        Get
            Return _instance.Value
        End Get
    End Property

    Public Function selectFromDB(selectStr As String)
        Dim selection As New List(Of String)
        cmdOLEDB.CommandText = "SELECT " & selectStr
        Console.WriteLine("COMAND: " & cmdOLEDB.CommandText)
        cmdOLEDB.Connection = cnnOLEDB
        Try
            Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader


            If rdrOLEDB.HasRows Then
                Do While rdrOLEDB.Read()
                    For i As Integer = 0 To rdrOLEDB.FieldCount - 1 Step 1
                        selection.Add(rdrOLEDB.Item(i).ToString)
                        Console.WriteLine(rdrOLEDB.Item(i).ToString)
                    Next
                Loop
            Else
                Console.WriteLine("No rows returned.")
            End If
            rdrOLEDB.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DB_ERROR")
        End Try


        Return selection

    End Function

    Public Sub insertInDB(insertStr As String)
        Try
            cmdInsert.CommandText = "INSERT " & insertStr

            Console.WriteLine("COMAND: " & cmdInsert.CommandText)

            cmdInsert.CommandType = CommandType.Text

            cmdInsert.Connection = cnnOLEDB

            cmdInsert.ExecuteNonQuery()
            cmdInsert.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DB_ERROR")
        End Try
    End Sub

    Public Sub updateDB(updateStr As String)
        Try
            cmdUpdate.CommandText = "UPDATE " & updateStr

            Console.WriteLine("COMAND: " & cmdUpdate.CommandText)

            cmdUpdate.CommandType = CommandType.Text

            cmdUpdate.Connection = cnnOLEDB

            cmdUpdate.ExecuteNonQuery()
            cmdUpdate.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DB_ERROR")
        End Try
    End Sub

    Public Sub deleteFromDB(deleteStr As String)
        Try
            cmdDelete.CommandText = "DELETE " & deleteStr

            Console.WriteLine("COMAND: " & cmdDelete.CommandText)

            cmdDelete.CommandType = CommandType.Text

            cmdDelete.Connection = cnnOLEDB

            cmdDelete.ExecuteNonQuery()

            cmdDelete.Dispose()
            cmdUpdate.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DB_ERROR")
        End Try
    End Sub

End Class
