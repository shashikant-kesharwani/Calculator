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

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = False
        Btn4.Enabled = False
        Btn5.Enabled = False
        Btn6.Enabled = False
        Btn7.Enabled = False
        Btn8.Enabled = False
        Btn9.Enabled = False
        Btnzero.Enabled = False
        Btndecimal.Enabled = False
        Btndoublezero.Enabled = False
        Btnadd.Enabled = False
        Btnsub.Enabled = False
        Btnmulti.Enabled = False
        Btndiv.Enabled = False
        Btnequal.Enabled = False
        Btnclear.Enabled = False

    End Sub

    Private Sub Btnonoff_Click(sender As Object, e As EventArgs) Handles Btnonoff.Click
        If Btnonoff.Text = "ON" Then
            Btn1.Enabled = True
            Btn2.Enabled = True
            Btn3.Enabled = True
            Btn4.Enabled = True
            Btn5.Enabled = True
            Btn6.Enabled = True
            Btn7.Enabled = True
            Btn8.Enabled = True
            Btn9.Enabled = True
            Btnzero.Enabled = True
            Btndecimal.Enabled = True
            Btndoublezero.Enabled = True
            Btnadd.Enabled = True
            Btnsub.Enabled = True
            Btnmulti.Enabled = True
            Btndiv.Enabled = True
            Btnequal.Enabled = True
            Btnclear.Enabled = True
            Btnonoff.Text = "OFF"
        Else
            Btn1.Enabled = False
            Btn2.Enabled = False
            Btn3.Enabled = False
            Btn4.Enabled = False
            Btn5.Enabled = False
            Btn6.Enabled = False
            Btn7.Enabled = False
            Btn8.Enabled = False
            Btn9.Enabled = False
            Btnzero.Enabled = False
            Btndecimal.Enabled = False
            Btndoublezero.Enabled = False
            Btnadd.Enabled = False
            Btnsub.Enabled = False
            Btnmulti.Enabled = False
            Btndiv.Enabled = False
            Btnequal.Enabled = False
            Btnclear.Enabled = False
            Btnonoff.Text = "ON"


        End If
    End Sub
End Class