Public Class Questionaire
    Public score As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Form4.Show()
        If RadioButton1.Checked Then
            score += 1
        End If
        If RadioButton2.Checked Then
            score += 1
        End If
        If RadioButton3.Checked Then
            score += 1
        End If
        If RadioButton4.Checked Then
            score += 1
        End If

        If RadioButton5.Checked Then
            score += 1
        End If
        If RadioButton6.Checked Then
            score += 1
        End If

        If RadioButton7.Checked Then
            score += 1
        End If
        If RadioButton8.Checked Then
            score += 1
        End If
        If RadioButton9.Checked Then
            score += 1
        End If
        If RadioButton10.Checked Then
            score += 1
        End If
        If RadioButton11.Checked Then
            score += 1
        End If
        If RadioButton12.Checked Then
            score += 1
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class