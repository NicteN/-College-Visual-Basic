Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        exercise_routine.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.youtube.com/results?search_query=%ED%97%AC%EC%8A%A4%EC%98%81%EC%83%81")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nutrient_standards.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        bmi.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        info.Show()
    End Sub
End Class
