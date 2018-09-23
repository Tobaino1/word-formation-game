Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("you will be redirected to another form, Click on any of the lists of forms of word formation button and follow the instructions in the form, best of luck user!") Then

        End If
        Dim frm2 As New Form1
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay

    End Sub

   
End Class