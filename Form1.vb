Public Class Form1
    Dim ObjRandomNumber As New Random
    Dim FirstInteger, SecondInteger As Integer
    Dim ScoreShortInteger As Short = 5

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GenerateQuestion()
        FirstInteger = ObjRandomNumber.Next(9, 13)
        SecondInteger = ObjRandomNumber.Next(9, 13)
        QuestionLabel.Text = "How much is " & FirstInteger & " times " & SecondInteger & "?"
        AnswerTextBox.Text = ""
        ResultTextBox.Text = ""
        AnswerTextBox.Focus()
    End Sub

    Private Function GenerateOutput() As String
        Dim RandomOutput As Integer
        RandomOutput = ObjRandomNumber.Next(1, 5)
        Select Case RandomOutput
            Case 1
                Return "Good Job"
            Case 2
                Return "Excellent"
            Case 3
                Return "Very Good"
            Case 4
                Return "Way to go"
        End Select
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GenerateQuestion()
    End Sub

    Private Sub SubmitAnswerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Dim YourAnswerInteger As Integer

        Try
            YourAnswerInteger = CInt(AnswerTextBox.Text)
            If YourAnswerInteger = FirstInteger * SecondInteger Then
                ResultTextBox.Text = GenerateOutput()
                ScoreShortInteger += 2
                ScoreTextBox.Text = ScoreShortInteger.ToString
                GenerateQuestion()
            Else
                ResultTextBox.Text = "Try again"
                AnswerTextBox.Clear()
                AnswerTextBox.Focus()
                ScoreShortInteger -= 1
                ScoreTextBox.Text = ScoreShortInteger.ToString
            End If

            If ScoreShortInteger > 99 Then
                ResultTextBox.Text = "Perfect"
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Please enter a number")
        End Try
    End Sub
End Class
