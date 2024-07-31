Public Class Form2
    Private Sub Btnswap_Click(sender As Object, e As EventArgs) Handles Btnswap.Click
        Dim a, b As Integer
        a = Txt1before.Text
        b = Txt2before.Text
        a = a + b
        b = a - b
        a = a - b
        Txt1after.Text = a
        Txt2after.Text = b
    End Sub
End Class