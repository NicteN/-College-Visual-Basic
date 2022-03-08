Public Class bmi

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Dim height, weight, man_result As Double
            height = TextBox1.Text / 100
            weight = TextBox2.Text
            man_result = weight / (height) ^ 2
            TextBox4.Text = man_result
            If man_result < 20 Then
                TextBox5.Text = "남자 BMI 기준 저체중입니다."
            ElseIf man_result < 24 Then
                TextBox5.Text = "남자 BMI 기준 정상입니다."
            ElseIf man_result < 30 Then
                TextBox5.Text = "남자 BMI 기준 약간 비만입니다."
            Else
                TextBox5.Text = "남자 BMI 기준 과체중입니다."
            End If
        ElseIf RadioButton2.Checked Then
            Dim height, weight, woman_result As Double
            height = TextBox1.Text / 100
            weight = TextBox2.Text
            woman_result = weight / (height) ^ 2
            TextBox4.Text = woman_result
            If woman_result < 18 Then
                TextBox5.Text = "여자 BMI 기준 저체중입니다."
            ElseIf woman_result < 22 Then
                TextBox5.Text = "여자 BMI 기준 정상입니다."
            ElseIf woman_result < 25 Then
                TextBox5.Text = "여자 BMI 기준 약간 비만입니다."
            Else
                TextBox5.Text = "여자 BMI 기준 과체중입니다."
            End If
        Else
            MsgBox("모든 항목을 선택 / 입력 후 재 시도 바랍니다.", "오류")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class