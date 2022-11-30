Public Class Calculator
    Inherits AddingMachine
    Function Multiply() As Double
        Return FirstNumber * SecondNumber
    End Function
    Function Divide() As Double
        Return FirstNumber / SecondNumber
    End Function
End Class
