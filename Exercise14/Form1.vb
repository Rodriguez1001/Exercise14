Public Class Form1
    Dim gameNumber As Integer = 1
    Dim person As New Human
    Dim machine As New Computer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click

        Dim humanChoice As String
        Dim computerChoice As String
        Dim result As String

        humanChoice = person.Choice()
        computerChoice = machine.Choice()

        Select Case humanChoice
            Case "Rock"
                Select Case computerChoice
                    Case "Paper"
                        machine.Score += 1
                        result = "Computer Wins"
                    Case "Scissors"
                        person.Score += 1
                        result = "You Win"
                    Case Else 'Rock
                        result = "Tie"
                End Select

            Case "Paper"
                Select Case computerChoice
                    Case "Rock"
                        person.Score += 1
                        result = "You Win"
                    Case "Scissors"
                        machine.Score += 1
                        result = "Computer Wins"
                    Case Else 'paper
                        result = "Tie"
                End Select

            Case "Scissors"
                Select Case computerChoice
                    Case "Rock"
                        machine.Score += 1
                        result = "Computer Wins"
                    Case "Paper"
                        person.Score += 1
                        result = "You Win"
                    Case Else 'Scissors
                        result = "Tie"
                End Select
        End Select

        MessageBox.Show("YOUR Choice: " & humanChoice & "  COMPUTER Choice: " & computerChoice & "  " & result, " RESULT")
        txtHumanScore.Text = CStr(person.Score)
        txtComputerScore.Text = CStr(machine.Score)
        gameNumber += 1
        BtnPlay.Text = "Play Game #" & (gameNumber)

    End Sub
End Class

