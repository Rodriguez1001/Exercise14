Public MustInherit Class Contestant
    Public Property Score As Integer
    MustOverride Function Choice() As String
End Class
