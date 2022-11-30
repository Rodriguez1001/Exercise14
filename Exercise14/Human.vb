Public Class Human
    Inherits Contestant
    Overrides Function Choice() As String
        Return InputBox("Enter your choice (Rock, Paper, or Scissors):")
    End Function
End Class
