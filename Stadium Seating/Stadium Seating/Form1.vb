Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblClassB.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblClassC.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtClassB_TextChanged(sender As Object, e As EventArgs) Handles txtClassB.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblRevOne As Double
        Dim dblRevTwo As Double
        Dim dblRevThree As Double
        Dim dblTotal As Double
        Try
            dblRevOne = CDbl(12) *
                CDbl(txtClassA.Text)
            lblClassA.Text = dblRevOne.ToString()

            dblRevTwo = CDbl(10) *
                CDbl(txtClassB.Text)
            lblClassB.Text = dblRevTwo.ToString()

            dblRevThree = CDbl(8) *
                CDbl(txtClassC.Text)
            lblClassC.Text = dblRevThree.ToString()

            dblTotal = CDbl(dblRevOne) + CDbl(dblRevTwo) + CDbl(dblRevThree)
            lblTotRev.Text = dblTotal.ToString()
        Catch ex As Exception

        End Try

    End Sub
End Class
