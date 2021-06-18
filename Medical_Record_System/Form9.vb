Public Class FormPassConfirm

    Dim attempts As Integer = 0

    Dim go As Boolean = True

    Private Sub goUpdate()

        FormPatientInfo.txtName.ReadOnly = False
        FormPatientInfo.txtCourse.ReadOnly = False
        FormPatientInfo.txtAddress.ReadOnly = False
        FormPatientInfo.txtAge.ReadOnly = False
        FormPatientInfo.cbxGender.Enabled = True
        FormPatientInfo.cbxStatus.Enabled = True
        FormPatientInfo.txtHeight.ReadOnly = False
        FormPatientInfo.txtWeight.ReadOnly = False
        FormPatientInfo.btnSave.Enabled = True
        FormPatientInfo.btnClear.Enabled = True

        FormPatientInfo.btnUpdate.Enabled = False


        Me.Close()



    End Sub

    'Private Sub goDisabled()

    'go = False

    'End Sub


    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        If txtPass.Text = "project" Then

            goUpdate()

        Else
            'MessageBox.Show("Wrong Password!", "Error!")
            attempts += 1
            If attempts = 3 Then

                MessageBox.Show("Youv'e reached the maximum attempts. Please login again.", "Information.")
                FormHome.Close()
                FormPatients.Close()
                FormInit.Close()
                FormPatientInfo.Close()
                FormLogin.Show()

            Else
                MessageBox.Show("Wrong Password!", "Error!")

                txtPass.Focus()

            End If
        End If
        txtPass.Text = ""

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class