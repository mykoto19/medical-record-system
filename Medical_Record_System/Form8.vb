Public Class FormPatientRecord

    Private Access As New DBControl

    Private Function NoErrors(Optional ByVal Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) 'REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        FormPatients.Show()
        Me.Close()
    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim form As New FormPassConfirm2
        form.ShowDialog()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Access.AddParam("@temp", txtTemperature.Text)
        Access.AddParam("@leftLung", txtLeft_Lung.Text)
        Access.AddParam("@rightLung", txtRight_Lung.Text)
        Access.AddParam("@breath", txtBreathing.Text)
        Access.AddParam("@pulse", txtPulse.Text)
        Access.AddParam("@bp", txtBP.Text)
        Access.AddParam("@heart", txtHeart.Text)
        Access.AddParam("@digest", txtDigestive.Text)
        Access.AddParam("@genito", txtGen_Urinary.Text)
        Access.AddParam("@skin", txtSkin.Text)
        Access.AddParam("@loco", txtLocomotive.Text)
        Access.AddParam("@color", txtColorPerception.Text)
        Access.AddParam("@vision", txtVisionTest.Text)
        Access.AddParam("@leftEar", txtLeftEar.Text)
        Access.AddParam("@rightEar", txtRightEar.Text)
        Access.AddParam("@nose", txtNose.Text)
        Access.AddParam("@throat", txtThroat.Text)
        Access.AddParam("@teeth", txtTeeth_Gums.Text)
        Access.AddParam("@recommend", txtRecommend.Text)
        Access.AddParam("@date", CheckUpDate.Text)
        Access.AddParam("@id", FormPatients.dgvPatients.CurrentRow.Cells(0).Value.ToString)

        Access.ExecQuery("UPDATE Medical_Record " & _
                         "SET Temperature=@temp, LungL=@leftLung, LungR=@rightLung, Breathing=@breath, Pulse=@pulse, BloodPressure=@bp, Heart=@heart, Digestion=@digest, Genito_Urinary=@genito, Skin=@skin, Locomotive=@loco, EyeColorPercep=@color, EyeVisionTest=@vision, EarL=@leftEar, EarR=@rightEar, Nose=@nose, Throat=@throat, Teeth=@teeth, Recommendation=@recommend, Check_UpDate=@date " & _
                         "WHERE ID=@id")

        If NoErrors(True) = False Then Exit Sub

        MessageBox.Show("Record Updated.", "Success!")
    End Sub

    Private Sub txtTemperature_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTemperature.KeyPress
        Dim dot As Integer
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If e.KeyChar = "." And Not txtTemperature.Text.IndexOf(".") = -1 Then
            e.Handled = False
            dot = txtTemperature.Text.IndexOf(".")
            If dot > -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lblCheckUpDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCheckUpDate.Click

    End Sub
End Class