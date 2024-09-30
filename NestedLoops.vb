Public Class Form1
    ' Event handler for button click
    Private Sub btnShowTable_Click(sender As Object, e As EventArgs) Handles btnShowTable.Click
        ' Clear the textbox before displaying the table
        txtMultiplicationTable.Clear()

        ' Outer loop for the rows (1 to 10)
        For i As Integer = 1 To 10
            ' Inner loop for the columns (1 to 10)
            For j As Integer = 1 To 10
                ' Append the multiplication result to the textbox
                txtMultiplicationTable.AppendText((i * j).ToString() & vbTab)  ' Tab space between columns
            Next
            ' Move to the next line after each row
            txtMultiplicationTable.AppendText(vbCrLf)
        Next
    End Sub

    Private Sub txtMultiplicationTable_TextChanged(sender As Object, e As EventArgs) Handles txtMultiplicationTable.TextChanged

    End Sub
End Class
