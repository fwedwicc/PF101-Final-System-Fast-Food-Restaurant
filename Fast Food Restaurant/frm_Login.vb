Public Class frm_Login
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If txt_user.Text = "ADMIN" And txt_password.Text = "admin123" Then
            Timer1.Start()
        Else
            MsgBox("Your Input is Invalid! Try again.")
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_user.Text = ""
        txt_password.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Value += 12
        If ProgressBar.Value = ProgressBar.Maximum Then
            Timer1.Enabled = False
            Hide()
            Form1.Show()
        End If
    End Sub
End Class