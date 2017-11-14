Public Class Form1

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblAverage.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        txtScore4.Clear()
        txtScore5.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblAverage As Double
        Dim dblTotal As Double
        Try
            dblTotal = CDbl(txtScore1.Text) + CDbl(txtScore2.Text) + CDbl(txtScore3.Text) + CDbl(txtScore4.Text) + CDbl(txtScore5.Text)

            dblAverage = CDbl(dblTotal) /
                CDbl(5)
            lblAverage.Text = dblAverage.ToString()
        Catch ex As Exception

        End Try
    End Sub
End Class
