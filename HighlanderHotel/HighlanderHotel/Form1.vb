Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtMisc.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblAddCharges.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblRmCharge.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblRoomCharges.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles lblTx.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables for the calculations
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubTotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D


        Try
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightlyCharge.Text)
            lblRmCharge.Text = decAddCharges.ToString("c")

            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMisc.Text)
            lblAddCharge.Text = decAddCharges.ToString("c")

            decSubTotal = decRoomCharges + decAddCharges
            lblSbTot.Text = decSubTotal.ToString("c")

            decTax = decSubTotal * decTAX_RATE
            lblTx.Text = decTax.ToString("c")

            decTotal = decSubTotal + decTax
            lblTotchrg.Text = decTotal.ToString("c")

        Catch ex As Exception
            MessageBox.Show("All input must be calid numeric values.")
        End Try

    End Sub

    Private Sub txtRoomService_TextChanged(sender As Object, e As EventArgs) Handles txtRoomService.TextChanged

    End Sub
End Class
