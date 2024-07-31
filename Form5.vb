Public Class Form5
    Dim num1, num2 As Decimal
    Dim op As Char
    Private Sub Txtnum_TextChanged(sender As Object, e As EventArgs) Handles Txtnum.TextChanged

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Txtnum.Text &= Btn1.Text
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Txtnum.Text &= Btn2.Text
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Txtnum.Text &= Btn3.Text
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Txtnum.Text &= Btn4.Text
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Txtnum.Text &= Btn5.Text
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Txtnum.Text &= Btn6.Text
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Txtnum.Text &= Btn7.Text
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Txtnum.Text &= Btn8.Text
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Txtnum.Text &= Btn9.Text
    End Sub

    Private Sub Btnzero_Click(sender As Object, e As EventArgs) Handles Btnzero.Click
        Txtnum.Text &= Btnzero.Text
    End Sub

    Private Sub Btndecimal_Click(sender As Object, e As EventArgs) Handles Btndecimal.Click
        Txtnum.Text &= Btndecimal.Text
    End Sub

    Private Sub Btndoublezero_Click(sender As Object, e As EventArgs) Handles Btndoublezero.Click
        Txtnum.Text &= Btndoublezero.Text
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        num1 = Txtnum.Text
        Txtnum.Clear()
        op = "+"
    End Sub

    Private Sub Btnsub_Click(sender As Object, e As EventArgs) Handles Btnsub.Click
        num1 = Txtnum.Text
        Txtnum.Clear()
        op = "-"
    End Sub

    Private Sub Btnmulti_Click(sender As Object, e As EventArgs) Handles Btnmulti.Click
        num1 = Txtnum.Text
        Txtnum.Clear()
        op = "*"
    End Sub

    Private Sub Btndiv_Click(sender As Object, e As EventArgs) Handles Btndiv.Click
        num1 = Txtnum.Text
        Txtnum.Clear()
        op = "/"
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Txtnum.Clear()
    End Sub

    Private Sub Btnequal_Click(sender As Object, e As EventArgs) Handles Btnequal.Click
        num2 = Txtnum.Text
        Txtnum.Clear()
        If op = "+" Then
            Txtnum.Text = num1 + num2
        End If
        If op = "-" Then
            Txtnum.Text = num1 - num2
        End If
        If op = "*" Then
            Txtnum.Text = num1 * num2
        End If
        If op = "/" Then
            Txtnum.Text = num1 / num2
        End If
    End Sub
End Class