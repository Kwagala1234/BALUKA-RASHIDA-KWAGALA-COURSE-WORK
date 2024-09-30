Public Class Form1
    ' Event handler for the button click
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Retrieve input from the textboxes
        Dim userName As String = txtName.Text
        Dim userAge As String = txtAge.Text
        Dim userColor As String = txtColor.Text

        ' Display a message box with the entered information
        MessageBox.Show("Hello " & userName & "! You are " & userAge & " years old and your favorite color is " & userColor & ".", "User Information")
    End Sub
End Class
