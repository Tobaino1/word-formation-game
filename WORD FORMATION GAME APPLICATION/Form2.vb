Public Class Form2

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm1 As New Form1
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm3 As New Form1
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm4 As New Form1
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm5 As New Form1
        Me.Hide()
        Form5.Show()
    End Sub
End Class