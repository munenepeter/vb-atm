Public Class Account

    ' Encapsulation - Data members are encapsulated within classes, and access to them is controlled through methods.
    ' In our case, balance field is encapsulated and accessed via method GetBalance.
    Protected balance As Double

    Public Sub New(initialBalance As Double)
        balance = initialBalance
    End Sub

    Public Overridable Sub Withdraw(amount As Double)
        balance -= amount
    End Sub

    Public Overridable Sub Deposit(amount As Double)
        balance += amount
    End Sub

    ' Here we expose a public method to access the private - encapsulated balance property
    Public Function GetBalance() As Double
        Return balance
    End Function
End Class