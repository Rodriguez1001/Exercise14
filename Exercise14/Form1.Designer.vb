<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHumanScore = New System.Windows.Forms.TextBox()
        Me.txtComputerScore = New System.Windows.Forms.TextBox()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computers Score:"
        '
        'txtHumanScore
        '
        Me.txtHumanScore.Location = New System.Drawing.Point(201, 86)
        Me.txtHumanScore.Name = "txtHumanScore"
        Me.txtHumanScore.Size = New System.Drawing.Size(46, 23)
        Me.txtHumanScore.TabIndex = 2
        '
        'txtComputerScore
        '
        Me.txtComputerScore.Location = New System.Drawing.Point(436, 86)
        Me.txtComputerScore.Name = "txtComputerScore"
        Me.txtComputerScore.Size = New System.Drawing.Size(38, 23)
        Me.txtComputerScore.TabIndex = 3
        '
        'BtnPlay
        '
        Me.BtnPlay.Location = New System.Drawing.Point(274, 158)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(137, 28)
        Me.BtnPlay.TabIndex = 4
        Me.BtnPlay.Text = "Play Game #"
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 296)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.txtComputerScore)
        Me.Controls.Add(Me.txtHumanScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHumanScore As TextBox
    Friend WithEvents txtComputerScore As TextBox
    Friend WithEvents BtnPlay As Button
End Class
