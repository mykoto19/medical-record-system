Public Class FormHome

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        FormLogin.Show()
        FormLogin.txtUsername.Focus()
        Me.Close()
    End Sub

    Private Sub btnSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignup.Click
        FormSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub btnPatList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatList.Click
        FormPatients.Show()
        Me.Hide()
    End Sub
End Class