Public Class Form1
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click

        Dim Marks As Integer

        If IsNumeric(txtMarks.Text) = True Then
            Marks = txtMarks.Text

        Else
            MsgBox("INVALID SCORE! ENTER A NUMBER")

            Exit Sub
        End If

        If Marks < 0 Or Marks > 100 Then
            MsgBox("Invalid Score")

        ElseIf Marks < 50 Then
            MsgBox("Fail")

        ElseIf Marks >= 50 Then
            MsgBox("PASS")
        End If

    End Sub
End Class
