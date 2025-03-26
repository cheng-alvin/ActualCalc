Imports System.Linq.Expressions

Public Class Form1
    Private Function Check()
        If input.Text = "" Then
            MsgBox("Please enter a number")
            Return False
        End If
        If Not (IsNumeric(input.Text)) Then
            MsgBox("Please enter a valid number")
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        op.Text += " + "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = New DataTable().Compute(op.Text, Nothing)
        answ.Text = result
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        op.Text += " - "
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        op.Text += " * "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        op.Text += " / "
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Check() Then
            op.Text += input.Text
            input.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        op.Text = ""
        input.Text = ""
        answ.Text = "-"
    End Sub




    ' input = input textbox
    ' answ =  Ans label
    ' op = Operations label
End Class
