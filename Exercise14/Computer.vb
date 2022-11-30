Public Class Computer
    Inherits Contestant
    Overrides Function Choice() As String
        Dim Choices() As String = {"Rock", "Paper", "Scissors"}

        Dim randomNumber As New Random
        Return Choices(randomNumber.Next(0, 3))
    End Function
End Class
