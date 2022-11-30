Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adder As New AddingMachine()
        Dim calc As New Calculator()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        BtnMultiply.Visible = False
        BtnDivide.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        BtnMultiply.Visible = True
        BtnDivide.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim adder As New AddingMachine()
        Dim calc As New Calculator()

        If RadioButton1.Checked Then
            adder.FirstNumber = CDbl(txtNumber1.Text)
            adder.SecondNumber = CDbl(txtNumber2.Text)
            txtResult.Text = CStr(adder.Add)
        Else
            calc.FirstNumber = CDbl(txtNumber1.Text)
            calc.SecondNumber = CDbl(txtNumber2.Text)
            txtResult.Text = CStr(calc.Add)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click
        Dim adder As New AddingMachine()
        Dim calc As New Calculator()

        If RadioButton1.Checked Then
            adder.FirstNumber = CDbl(txtNumber1.Text)
            adder.SecondNumber = CDbl(txtNumber2.Text)
            txtResult.Text = CStr(adder.Subtract)
        Else
            calc.FirstNumber = CDbl(txtNumber1.Text)
            calc.SecondNumber = CDbl(txtNumber2.Text)
            txtResult.Text = CStr(calc.Subtract)
        End If
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        Dim calc As New Calculator()

        calc.FirstNumber = CDbl(txtNumber1.Text)
        calc.SecondNumber = CDbl(txtNumber2.Text)
        txtResult.Text = CStr(calc.Multiply)

    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        Dim calc As New Calculator()

        calc.FirstNumber = CDbl(txtNumber1.Text)
        calc.SecondNumber = CDbl(txtNumber2.Text)
        txtResult.Text = CStr(calc.Divide)
    End Sub
End Class