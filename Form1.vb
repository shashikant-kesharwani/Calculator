Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        TextBox3.Text = c
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a - b
        TextBox3.Text = c
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a / b
        TextBox3.Text = c
    End Sub
End Class
