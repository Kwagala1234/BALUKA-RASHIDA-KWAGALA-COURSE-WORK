Public Class Form1
    ' Event handler for the button click
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' Try to parse the input to a number
        Dim number As Integer

        If Integer.TryParse(txtNumber.Text, number) Then
            ' Check if the number is positive, negative, or zero
            If number > 0 Then
                lblResult.Text = "Positive Number"
            ElseIf number < 0 Then
                lblResult.Text = "Negative Number"
            Else
                lblResult.Text = "Zero"
            End If
        Else
            ' Display an error message if the input is not a valid number
            lblResult.Text = "Please enter a valid number."
        End If
    End Sub
End Class
