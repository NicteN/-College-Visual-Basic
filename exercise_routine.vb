Public Class exercise_routine
    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        GroupBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            GroupBox2.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            GroupBox2.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
            Button1.Text = "하체운동 루틴 살펴보기"
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Button1.Text = "가슴운동 루틴 살펴보기"
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Button1.Text = "어깨운동 루틴 살펴보기"
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Button1.Text = "이두운동 루틴 살펴보기"
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Button1.Text = "삼두운동 루틴 살펴보기"
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Button1.Text = "복근운동 루틴 살펴보기"
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Get_exercise_Pic.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://www.youtube.com/results?search_query=%EC%9A%B4%EB%8F%99+%EC%8B%9C%EC%9E%91%ED%95%98%EA%B8%B0")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "가슴운동 루틴 살펴보기" Then
            chest_ex.Show()
        ElseIf Button1.Text = "어깨운동 루틴 살펴보기" Then
            shoulder_ex.Show()
        ElseIf Button1.Text = "이두운동 루틴 살펴보기" Then
            biceps_ex.Show()
        ElseIf Button1.Text = "삼두운동 루틴 살펴보기" Then
            triceps_ex.Show()
        ElseIf Button1.Text = "복근운동 루틴 살펴보기" Then
            abs_ex.Show()
        ElseIf Button1.Text = "하체운동 루틴 살펴보기" Then
            lowerbody_ex.Show()
        End If
    End Sub
End Class