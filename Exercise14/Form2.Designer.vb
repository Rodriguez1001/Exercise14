<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSubtract = New System.Windows.Forms.Button()
        Me.BtnMultiply = New System.Windows.Forms.Button()
        Me.BtnDivide = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Second Number"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(146, 77)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 23)
        Me.txtNumber1.TabIndex = 2
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(146, 118)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 23)
        Me.txtNumber2.TabIndex = 3
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(84, 174)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSubtract
        '
        Me.BtnSubtract.Location = New System.Drawing.Point(189, 174)
        Me.BtnSubtract.Name = "BtnSubtract"
        Me.BtnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubtract.TabIndex = 5
        Me.BtnSubtract.Text = "-"
        Me.BtnSubtract.UseVisualStyleBackColor = True
        '
        'BtnMultiply
        '
        Me.BtnMultiply.Location = New System.Drawing.Point(84, 213)
        Me.BtnMultiply.Name = "BtnMultiply"
        Me.BtnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.BtnMultiply.TabIndex = 6
        Me.BtnMultiply.Text = "x"
        Me.BtnMultiply.UseVisualStyleBackColor = True
        '
        'BtnDivide
        '
        Me.BtnDivide.Location = New System.Drawing.Point(189, 213)
        Me.BtnDivide.Name = "BtnDivide"
        Me.BtnDivide.Size = New System.Drawing.Size(75, 23)
        Me.BtnDivide.TabIndex = 7
        Me.BtnDivide.Text = "div"
        Me.BtnDivide.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(319, 176)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(113, 19)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Adding Machine"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(319, 215)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 19)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Calculator"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(146, 271)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(188, 23)
        Me.txtResult.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Result:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 353)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.BtnDivide)
        Me.Controls.Add(Me.BtnMultiply)
        Me.Controls.Add(Me.BtnSubtract)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSubtract As Button
    Friend WithEvents BtnMultiply As Button
    Friend WithEvents BtnDivide As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label3 As Label
End Class
