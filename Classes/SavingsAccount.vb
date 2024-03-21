Public Class SavingsAccount

    ' Inheritance - Here we are inheriting Withdrwa & Deposit methods from base class Account
    ' This class inherits from the Account class, thereby inheriting its properties and methods. 
    ' It also overrides the Withdraw method to provide additional functionality.

    Inherits Account
    
    ' Polymorphism
    Implements InterfaceATM 

    Public Overrides Sub Withdraw(amount As Double)
        MyBase.Withdraw(amount)
        balance -= 0.1 * amount
    End Sub

    Public Overrides Sub Deposit(amount As Double) Implements InterfaceATM.Deposit
        MyBase.Deposit(amount)
    End Sub

    Public Overrides Function GetBalance() As Double Implements InterfaceATM.GetBalance
        Return MyBase.GetBalance()
    End Function
End Class
