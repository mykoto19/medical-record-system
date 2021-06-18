Public Class FormLogin

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "Group1" And txtPass.Text = "project" Then
            MessageBox.Show("Your Now Logged in.", "Success!.")
            FormHome.Show()
            Me.Hide()
            'txtUsername.Text = ""
            'txtPass.Text = ""
        ElseIf txtUsername.Text = "" And txtPass.Text = "" Then
            MessageBox.Show("No Username and Password Found.", "Warning!")
            txtUsername.Focus()

        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("No Username Found.", "Warning!")
            txtUsername.Focus()

        ElseIf txtPass.Text = "" Then
            MessageBox.Show("No Password Found.", "Warning!")
            txtUsername.Focus()
        Else
            MessageBox.Show("Invalid Input.", "Warning!")
            txtUsername.Focus()
        End If

        txtUsername.Text = ""
        txtPass.Text = ""

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        btnLogin.Enabled = True
    End Sub

End Class
