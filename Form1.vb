Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Height As Double
        Dim Weight As Double
        Dim BMI As Double

        Weight = Val(txtWeight.Text)
        Height = Val(txtHeight.Text)


        BMI = Val(Weight / (Height ^ 2))

        txtBMI.Text = Val(BMI)

        If BMI < 18 Then
            txtComment.Text = ("You are underweight")

        ElseIf BMI >= 18 And BMI < 26 Then
            txtComment.Text = ("You have a normal healthy weight")

        Else
            txtComment.Text = ("You are overweight")
        End If

    End Sub
End Class


