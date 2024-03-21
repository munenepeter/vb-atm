Module MainModule
    Sub Main()
        Dim savingsAccount As New SavingsAccount(1000, 0.05)
        Dim pin As String = "1234"

        ' Using friend class to validate PIN
        If Bank.ValidatePIN(pin) Then
            ATM.Operate(savingsAccount, 500)
        Else
            Console.WriteLine("Invalid PIN")
        End If
    End Sub
End Module