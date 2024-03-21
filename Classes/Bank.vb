
Imports System.Data.SqlClient

' Friend Class: The Bank class is declared as a friend class, which means it has access to all members of other classes within the same assembly. This encapsulates PIN validation logic within the scope of the bank class.

Friend Class Bank
    Private Shared Function ValidatePIN(pin As String) As Boolean
       Dim connectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\gadgetDatabase.mdf;Integrated Security=True"

        ' SQL query to check if PIN exists in the database
        Dim query As String = "SELECT COUNT(*) FROM ATM WHERE PIN = @pin"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@pin", pin)

                connection.Open()

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If result is greater than 0, PIN is valid
                Return result > 0
            End Using
        End Using
    End Function
End Class
