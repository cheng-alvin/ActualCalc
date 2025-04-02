<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        ans = New Label()
        input = New TextBox()
        operations = New Label()
        op = New Label()
        Button2 = New Button()
        answ = New Label()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(83, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(73, 70)
        Button1.TabIndex = 0
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(320, 201)
        Button3.Name = "Button3"
        Button3.Size = New Size(73, 70)
        Button3.TabIndex = 2
        Button3.Text = "/"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(241, 201)
        Button4.Name = "Button4"
        Button4.Size = New Size(73, 70)
        Button4.TabIndex = 3
        Button4.Text = "x"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(162, 201)
        Button5.Name = "Button5"
        Button5.Size = New Size(73, 70)
        Button5.TabIndex = 4
        Button5.Text = "-"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' ans
        ' 
        ans.AutoSize = True
        ans.Location = New Point(536, 212)
        ans.Name = "ans"
        ans.Size = New Size(0, 31)
        ans.TabIndex = 5
        ' 
        ' input
        ' 
        input.Location = New Point(83, 98)
        input.Name = "input"
        input.Size = New Size(241, 38)
        input.TabIndex = 6
        ' 
        ' operations
        ' 
        operations.AutoSize = True
        operations.Location = New Point(263, 44)
        operations.Name = "operations"
        operations.Size = New Size(0, 31)
        operations.TabIndex = 7
        ' 
        ' op
        ' 
        op.AutoSize = True
        op.Location = New Point(83, 44)
        op.Name = "op"
        op.Size = New Size(0, 31)
        op.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(440, 201)
        Button2.Name = "Button2"
        Button2.Size = New Size(73, 70)
        Button2.TabIndex = 9
        Button2.Text = "="
        Button2.UseVisualStyleBackColor = True
        ' 
        ' answ
        ' 
        answ.AutoSize = True
        answ.Location = New Point(631, 162)
        answ.Name = "answ"
        answ.Size = New Size(24, 31)
        answ.TabIndex = 10
        answ.Text = "-"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(83, 324)
        Button6.Name = "Button6"
        Button6.Size = New Size(163, 51)
        Button6.TabIndex = 11
        Button6.Text = "Apply"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(278, 324)
        Button7.Name = "Button7"
        Button7.Size = New Size(163, 51)
        Button7.TabIndex = 12
        Button7.Text = "Clear"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(386, 98)
        Button8.Name = "Button8"
        Button8.Size = New Size(150, 46)
        Button8.TabIndex = 13
        Button8.Text = "Back "
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 453)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(answ)
        Controls.Add(Button2)
        Controls.Add(op)
        Controls.Add(operations)
        Controls.Add(input)
        Controls.Add(ans)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ans As Label
    Friend WithEvents input As TextBox
    Friend WithEvents operations As Label
    Friend WithEvents op As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents answ As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button

End Class
