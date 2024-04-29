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
        ScoreLabel = New Label()
        QuestionLabel = New Label()
        Label3 = New Label()
        ResultLabel = New Label()
        ScoreTextBox = New TextBox()
        AnswerTextBox = New TextBox()
        ResultTextBox = New TextBox()
        ExitButton = New Button()
        SubmitButton = New Button()
        SuspendLayout()
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ScoreLabel.Location = New Point(153, 61)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(132, 59)
        ScoreLabel.TabIndex = 0
        ScoreLabel.Text = "Score"
        ' 
        ' QuestionLabel
        ' 
        QuestionLabel.AutoSize = True
        QuestionLabel.Location = New Point(58, 160)
        QuestionLabel.Name = "QuestionLabel"
        QuestionLabel.Size = New Size(294, 32)
        QuestionLabel.TabIndex = 1
        QuestionLabel.Text = "How much is 12 times 11?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 32)
        Label3.TabIndex = 2
        Label3.Text = "Answer:"
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Location = New Point(58, 472)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(78, 32)
        ResultLabel.TabIndex = 3
        ResultLabel.Text = "Result"
        ' 
        ' ScoreTextBox
        ' 
        ScoreTextBox.Location = New Point(428, 68)
        ScoreTextBox.Name = "ScoreTextBox"
        ScoreTextBox.ReadOnly = True
        ScoreTextBox.Size = New Size(200, 39)
        ScoreTextBox.TabIndex = 4
        ' 
        ' AnswerTextBox
        ' 
        AnswerTextBox.Location = New Point(428, 236)
        AnswerTextBox.Name = "AnswerTextBox"
        AnswerTextBox.Size = New Size(200, 39)
        AnswerTextBox.TabIndex = 5
        ' 
        ' ResultTextBox
        ' 
        ResultTextBox.Location = New Point(428, 465)
        ResultTextBox.Name = "ResultTextBox"
        ResultTextBox.ReadOnly = True
        ResultTextBox.Size = New Size(200, 39)
        ResultTextBox.TabIndex = 6
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(86, 582)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(150, 46)
        ExitButton.TabIndex = 7
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(428, 344)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(200, 46)
        SubmitButton.TabIndex = 8
        SubmitButton.Text = "Submit Answer"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(739, 677)
        Controls.Add(SubmitButton)
        Controls.Add(ExitButton)
        Controls.Add(ResultTextBox)
        Controls.Add(AnswerTextBox)
        Controls.Add(ScoreTextBox)
        Controls.Add(ResultLabel)
        Controls.Add(Label3)
        Controls.Add(QuestionLabel)
        Controls.Add(ScoreLabel)
        Name = "Form1"
        Text = "Multiplication Teacher"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ScoreLabel As Label
    Friend WithEvents QuestionLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ScoreTextBox As TextBox
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SubmitButton As Button

End Class
