Public Class Form3
    Private Sub Btncircle_Click(sender As Object, e As EventArgs) Handles Btncircle.Click
        Const pie As Double = 3.1415
        Dim r, area As Double
        r = Txtradius.Text
        area = pie * r * r
        Txtareacircle.Text = area
    End Sub

    Private Sub Btntri_Click(sender As Object, e As EventArgs) Handles Btntri.Click
        Dim b, h, area As Double
        b = Txtbase.Text
        h = Txtheight.Text
        area = (1 / 2) * b * h
        Txtareatri.Text = area
    End Sub

    Private Sub Btnrect_Click(sender As Object, e As EventArgs) Handles Btnrect.Click
        Dim l, w, area As Double
        l = Txtlength.Text
        w = Txtwidth.Text
        area = l * w
        Txtarearect.Text = area
    End Sub
End Class