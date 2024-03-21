
' Polymorphism: The ATM class has a method Operate which operates on any object implementing the InterfaceATM interface. 
' This method can accept any class that implements the interface, allowing it to perform polymorphic behavior.

Public Class ATM
    Public Shared Sub Operate(account As InterfaceATM, amount As Double)
        account.Withdraw(amount)
        account.Deposit(amount)
        Dim balance As Double = account.GetBalance()
        Console.WriteLine("Current balance: " & balance)
    End Sub
End Class