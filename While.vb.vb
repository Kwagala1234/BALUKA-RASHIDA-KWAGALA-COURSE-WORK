Public Class Form1
    ' Event handler for button click
    Private Sub btnCountDown_Click(sender As Object, e As EventArgs) Handles btnCountDown.Click
        ' Get the number from the textbox
        Dim number As Integer

        If Integer.TryParse(txtNumber.Text, number) Then
            lblCountdownResult.Text = ""  ' Clear previous result

            ' While loop to count down from the given number to zero
            While number >= 0
                lblCountdownResult.Text &= number.ToString() & " "  ' Append each number to the label with a space
                number -= 1
            End While
        Else
            lblCountdownResult.Text = "Please enter a valid number."  ' Show error if input is not a valid number
        End If
    End Sub
End Class
