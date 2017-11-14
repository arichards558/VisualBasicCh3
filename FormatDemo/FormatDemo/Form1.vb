Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnFormatted.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblFormat.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnLDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("D")
        lblFormat.Text = strResult
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnLTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("T")
        lblFormat.Text = strResult
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFixedF.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("f")
        lblFormat.Text = strResult
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExpo.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("e")
        lblFormat.Text = strResult
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnDateAndTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("F")
        lblFormat.Text = strResult
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("p")
        lblFormat.Text = strResult
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("c")
        lblFormat.Text = strResult
    End Sub

    Private Sub btnNumberF_Click(sender As Object, e As EventArgs) Handles btnNumberF.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("n")
        lblFormat.Text = strResult
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("d")
        lblFormat.Text = strResult
    End Sub

    Private Sub btnSTime_Click(sender As Object, e As EventArgs) Handles btnSTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("t")
        lblFormat.Text = strResult
    End Sub
End Class
