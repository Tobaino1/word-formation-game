Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New Form1
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim answer As String
        answer = TextBox1.Text
        If answer = "display" Then

            MessageBox.Show(" you are right the answer is display, anagram the next word")
            Else
        MessageBox.Show("you are wrong, try again")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim answer As String
        answer = TextBox2.Text
        If answer = "computer" Then

            MessageBox.Show("you are right the answer is computer, anagram the next word")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim answer As String
        answer = TextBox3.Text
        If answer = "instruction" Then
            MessageBox.Show("you are right the answer is instruction, anagram the next word")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim answer As String
        answer = TextBox4.Text
        If answer = "connection" Then
            MessageBox.Show("you are right the answer is connection, anagram the next word")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim answer As String
        answer = TextBox5.Text
        If answer = "architecture" Then
            MessageBox.Show("you are right the answer is architecture, anagram the next word")
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim answer As String
        answer = TextBox6.Text
        If answer = "arrangement" Then
            MessageBox.Show("you are right the answer is arrangement, anagram the next word")
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim answer As String
        answer = TextBox7.Text
        If answer = "project" Then
            MessageBox.Show("you are right the answer is project, anagram the next word")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim answer As String
        answer = TextBox8.Text
        If answer = "correction" Then
            MessageBox.Show("you are right the answer is correction, anagram the next word")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim answer As String
        answer = TextBox9.Text
        If answer = "continental" Then
            MessageBox.Show("you are right the answer is continental, anagram the next word")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim answer As String
        answer = TextBox10.Text
        If answer = "television" Then
            MessageBox.Show("you are right the answer is television, anagram the next word")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim answer As String
        answer = TextBox11.Text
        If answer = "algorithm" Then
            MessageBox.Show("you are right the answer is algorithm, anagram the next word")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim answer As String
        answer = TextBox12.Text
        If answer = "institution" Then
            MessageBox.Show("you are right the answer is institution, anagram the next word")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim answer As String
        answer = TextBox13.Text
        If answer = "development" Then
            MessageBox.Show("you are right the answer is development, anagram the next word")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim answer As String
        answer = TextBox14.Text
        If answer = "independent" Then
            MessageBox.Show("you are right the answer is independent, anagram the next word")
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim answer As String
        answer = TextBox15.Text
        If answer = "application" Then
            MessageBox.Show("you are right the answer is application, anagram the next word")
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox5.Text = ""

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox4.Text = ""

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox2.Text = ""

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox3.Text = ""

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox6.Text = ""

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox7.Text = ""

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox8.Text = ""

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox9.Text = ""

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox10.Text = ""

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox11.Text = ""

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox12.Text = ""

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TextBox13.Text = ""

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox14.Text = ""

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox15.Text = ""

    End Sub
End Class