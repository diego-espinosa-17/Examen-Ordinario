Public Class Form1
    Private Sub BotonSubtotal_Click(sender As Object, e As EventArgs) Handles BotonSubtotal.Click
        ValorSubtotal.Text = Val(TextBox2.Text) * Val(TextBox1.Text)
    End Sub

    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles RestarUno.Click
        If Val(TextBox2.Text) = 0 Then
            TextBox2.Text = 0
        ElseIf Val(TextBox2.Text) >= 0 Then
            TextBox2.Text = Val(TextBox2.Text) - 1
        End If
    End Sub

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles SumarUno.Click
        TextBox2.Text = Val(TextBox2.Text) + 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ValorIVA.Text = Val(ValorSubtotal.Text) * 0.16
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ValorTotal.Text = Val(ValorSubtotal.Text) + Val(ValorIVA.Text)
    End Sub
End Class
