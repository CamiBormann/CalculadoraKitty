Public Class Form1
    Dim NUM1, NUM2, operacion As String
    Dim EXEPCION As Integer = 0

    Private Sub Bt7_Click(sender As Object, e As EventArgs) Handles Bt7.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "7"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt8_Click(sender As Object, e As EventArgs) Handles Bt8.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "8"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt9_Click(sender As Object, e As EventArgs) Handles Bt9.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "9"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt4_Click(sender As Object, e As EventArgs) Handles Bt4.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "4"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt5_Click(sender As Object, e As EventArgs) Handles Bt5.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "5"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt6_Click(sender As Object, e As EventArgs) Handles Bt6.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "6"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt1_Click(sender As Object, e As EventArgs) Handles Bt1.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "1"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt2_Click(sender As Object, e As EventArgs) Handles Bt2.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "2"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub Bt3_Click(sender As Object, e As EventArgs) Handles Bt3.Click
        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "3"
        If operacion IsNot Nothing Then
            txtDisplay.Text = ""
        End If
    End Sub

    Private Sub sumar_Click(sender As Object, e As EventArgs) Handles sumar.Click
        operacion = "+"
        NUM1 = txtDisplay.Text
        txtDisplay.Text = ""
    End Sub

    Private Sub restar_Click(sender As Object, e As EventArgs) Handles restar.Click
        operacion = "-"
        NUM1 = txtDisplay.Text
        txtDisplay.Text = ""
    End Sub

    Private Sub multiplicar_Click(sender As Object, e As EventArgs) Handles multiplicar.Click
        operacion = "*"
        NUM1 = txtDisplay.Text
        txtDisplay.Text = ""
    End Sub

    Private Sub dividir_Click(sender As Object, e As EventArgs) Handles dividir.Click
        operacion = "/"
        NUM1 = txtDisplay.Text
        txtDisplay.Text = ""
    End Sub

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click
        NUM2 = txtDisplay.Text
        Calcular(NUM1, NUM2, operacion)
    End Sub

    Private Sub Bt0_Click(sender As Object, e As EventArgs) Handles Bt0.Click

        If EXEPCION <> 0 Then
            txtDisplay.Text = ""
            EXEPCION = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "0"
        If operacion IsNot Nothing Then
        End If
    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        txtDisplay.Text = ""
    End Sub

    Sub Calcular(n1 As String, n2 As String, op As String)
        Dim Total As String = ""
        Dim NUMERO1 As Decimal = Convert.ToDecimal(n1)
        Dim NUMERO2 As Decimal = Convert.ToDecimal(n2)
        Select Case op
            Case "+"
                Total = NUMERO1 + NUMERO2
            Case "-"
                Total = NUMERO1 - NUMERO2
            Case "*"
                Total = NUMERO1 * NUMERO2
            Case "/"
                If NUMERO2 = 0 Then
                    Total = "¡ERROR!"
                Else
                    Total = NUMERO1 / NUMERO2

                End If
        End Select
        VolverBlanco()
        txtDisplay.Text = Total
        EXEPCION = 1
    End Sub
    Sub VolverBlanco()
        NUM1 = Nothing
        NUM2 = Nothing
        operacion = Nothing
    End Sub
End Class
