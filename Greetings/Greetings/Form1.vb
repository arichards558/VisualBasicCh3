Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Dim strName As String

        strName = txtUserName.Text
        lblGreeting.Text = "Hello " + strName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblGreeting.Click

    End Sub
End Class
