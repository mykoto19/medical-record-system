Public Class FormPassConfirm2

    Dim attempts As Integer = 0

    Private Sub goUpdate2()
        FormPatientRecord.btnSave.Enabled = True
        FormPatientRecord.txtTemperature.ReadOnly = False
        FormPatientRecord.txtLeft_Lung.ReadOnly = False
        FormPatientRecord.txtRight_Lung.ReadOnly = False
        FormPatientRecord.txtBreathing.ReadOnly = False
        FormPatientRecord.txtPulse.ReadOnly = False
        FormPatientRecord.txtBP.ReadOnly = False
        FormPatientRecord.txtHeart.ReadOnly = False
        FormPatientRecord.txtDigestive.ReadOnly = False
        FormPatientRecord.txtGen_Urinary.ReadOnly = False
        FormPatientRecord.txtSkin.ReadOnly = False
        FormPatientRecord.txtLocomotive.ReadOnly = False
        FormPatientRecord.txtColorPerception.ReadOnly = False
        FormPatientRecord.txtVisionTest.ReadOnly = False
        FormPatientRecord.txtLeftEar.ReadOnly = False
        FormPatientRecord.txtRightEar.ReadOnly = False
        FormPatientRecord.txtNose.ReadOnly = False
        FormPatientRecord.txtThroat.ReadOnly = False
        FormPatientRecord.txtTeeth_Gums.ReadOnly = False
        FormPatientRecord.txtRecommend.ReadOnly = False
        FormPatientRecord.CheckUpDate.Enabled = True

        FormPatientRecord.btnUpdate.Enabled = False

        FormPatientRecord.lblCheckUpDate.Text = "Date:"

        Me.Close()
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        'Dim attempts As Integer = 0

        If txtPass.Text = "project" Then
            goUpdate2()

        Else
            'MessageBox.Show("Wrong Password!", "Error!")
            attempts += 1
            If attempts = 3 Then

                MessageBox.Show("Youv'e reached the maximum attempts. Please login again.", "Information.")
                FormHome.Close()
                FormPatients.Close()
                FormInit.Close()
                FormPatientRecord.Close()
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