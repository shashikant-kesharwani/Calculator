Public Class Form4
    Private Sub Btncal_Click(sender As Object, e As EventArgs) Handles Btncal.Click
        Dim cel As Double
        Dim fah As Single
        cel = Txtcelcius.Text
        fah = (9 / 5) * cel + 32
        Txtfah.Text = fah
    End Sub
End Class