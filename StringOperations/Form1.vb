Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fullName As String = txtFirst.Text & " " & txtFather.Text & " " & txtGrand.Text
        Dim startIndex As Integer = txtFirst.Text.Length + 1
        Dim length As Integer = txtFather.Text.Length
        txtResult.Text = fullName.Substring(startIndex, length)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fullName As String = txtFirst.Text & " " & txtFather.Text & " " & txtGrand.Text
        Dim startRemoveIndex As Integer = txtFirst.Text.Length + 1 + txtFather.Text.Length
        txtResult.Text = fullName.Remove(startRemoveIndex)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fullName As String = txtFirst.Text & " " & txtFather.Text & " " & txtGrand.Text
        Dim newName As String = "أحمد "
        txtResult.Text = fullName.Insert(0, newName)
    End Sub

End Class