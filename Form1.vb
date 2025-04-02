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
        If Not (input.Text = "") Then
            Button6_Click(sender, e)
        End If

        op.Text += " + "
        input.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not (input.Text = "") Then
            Button6_Click(sender, e)
        End If
        Dim result = New DataTable().Compute(op.Text, Nothing)

        If result = "∞" Or result = "NaN" Then
            MsgBox("Cannot divide by 0", vbCritical)
            Button7_Click(sender, e)
        Else
            answ.Text = result
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not (input.Text = "") Then
            Button6_Click(sender, e)
        End If
        op.Text += " - "
        input.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not (input.Text = "") Then
            Button6_Click(sender, e)
        End If
        op.Text += " * "
        input.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not (input.Text = "") Then
            Button6_Click(sender, e)
        End If
        op.Text += " / "
        input.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Check() Then
            op.Text += input.Text
            input.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        op.Text = ""
        input.Text = ""
        answ.Text = "-"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim lastSpaceIndex As Integer = op.Text.LastIndexOf(" ")
        If lastSpaceIndex < 0 Then
            op.Text = ""
            Exit Sub
        End If
        Dim trimmedString As String = op.Text.Substring(0, lastSpaceIndex)


        op.Text = trimmedString

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    ' input = input textbox
    ' answ =  Ans label
    ' op = Operations label
End Class
