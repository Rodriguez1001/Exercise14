Public Class AddingMachine
    Public Property FirstNumber() As Double
    Public Property SecondNumber() As Double

    Function Add() As Double
        Return FirstNumber + SecondNumber
    End Function

    Function Subtract() As Double
        Return FirstNumber - SecondNumber
    End Function
End Class
