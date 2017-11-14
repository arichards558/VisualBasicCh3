Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblMPG As Double
        Try
            dblMPG = CDbl(txtMiles.Text) /
                CDbl(txtGallons.Text)
            lblMPG.Text = dblMPG.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMiles.Clear()

    End Sub
End Class
