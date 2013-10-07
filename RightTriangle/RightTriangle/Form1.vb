Option Strict On
Public Class Form1



    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim s1 As Double = CDbl(txtSideOne.Text)
        Dim s2 As Double = CDbl(txtSideTwo.Text)

        Dim s3 As Double

        s3 = hypotenuse(s1, s2)

        txtHyp.Text = CStr(s3)

    End Sub
    Function hypotenuse(ByVal a As Double, b As Double) As Double
        Dim c As Double = Math.Sqrt((a ^ 2 + b ^ 2))
        Return c

    End Function
End Class
