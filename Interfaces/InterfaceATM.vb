Public Interface InterfaceATM
    Sub Withdraw(amount As Double)
    Sub Deposit(amount As Double)
    Overloads Function GetBalance() As Double
End Interface