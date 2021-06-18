Public Class FormMedicalSign

    Private Access As New DBControl

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        FormHome.Show()
        Me.Close()
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

    Private Sub TextBox_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTemperature.TextChanged,
        txtLeft_Lung.TextChanged, txtRight_Lung.TextChanged, txtBreathing.TextChanged, txtPulse.TextChanged, txtBP.TextChanged, txtHeart.TextChanged,
        txtDigestive.TextChanged, txtGen_Urinary.TextChanged, txtSkin.TextChanged, txtLocomotive.TextChanged, txtColorPerception.TextChanged, txtVisionTest.TextChanged,
        txtLeftEar.TextChanged, txtRightEar.TextChanged, txtNose.TextChanged, txtThroat.TextChanged, txtTeeth_Gums.TextChanged, txtRecommend.TextChanged

        If Not String.IsNullOrWhiteSpace(txtTemperature.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtLeft_Lung.Text) AndAlso Not String.IsNullOrWhiteSpace(txtRight_Lung.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtBreathing.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPulse.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtBP.Text) AndAlso Not String.IsNullOrWhiteSpace(txtHeart.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtDigestive.Text) AndAlso Not String.IsNullOrWhiteSpace(txtGen_Urinary.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtSkin.Text) AndAlso Not String.IsNullOrWhiteSpace(txtLocomotive.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtColorPerception.Text) AndAlso Not String.IsNullOrWhiteSpace(txtVisionTest.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtLeftEar.Text) AndAlso Not String.IsNullOrWhiteSpace(txtRightEar.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtNose.Text) AndAlso Not String.IsNullOrWhiteSpace(txtThroat.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtTeeth_Gums.Text) AndAlso Not String.IsNullOrWhiteSpace(txtRecommend.Text) Then Exit Sub

    End Sub

    Private Sub AddRecord()
        Access.AddParam("@pid", lblID.Text)
        Access.AddParam("@temp", txtTemperature.Text)
        Access.AddParam("@lungL", txtLeft_Lung.Text)
        Access.AddParam("@lungR", txtRight_Lung.Text)
        Access.AddParam("@breath", txtBreathing.Text)
        Access.AddParam("@pulse", txtPulse.Text)
        Access.AddParam("@bp", txtBP.Text)
        Access.AddParam("@heart", txtHeart.Text)
        Access.AddParam("@digest", txtDigestive.Text)
        Access.AddParam("@genuri", txtGen_Urinary.Text)
        Access.AddParam("@skin", txtSkin.Text)
        Access.AddParam("@loco", txtLocomotive.Text)
        Access.AddParam("@percep", txtColorPerception.Text)
        Access.AddParam("@vision", txtVisionTest.Text)
        Access.AddParam("@earL", txtLeftEar.Text)
        Access.AddParam("@earR", txtRightEar.Text)
        Access.AddParam("@nose", txtNose.Text)
        Access.AddParam("@throat", txtThroat.Text)
        Access.AddParam("@teeth", txtTeeth_Gums.Text)
        Access.AddParam("@recommend", txtRecommend.Text)
        Access.AddParam("@date", DateTimePicker1.Text)


        Access.ExecQuery("INSERT INTO Medical_Record(ID,Temperature,LungL,LungR,Breathing,Pulse,BloodPressure,Heart,Digestion,Genito_Urinary,Skin,Locomotive,EyeColorPercep,EyeVisionTest,EarL,EarR,Nose,Throat,Teeth,Recommendation,Check_UpDate) " & _
                         "VALUES(@pid,@temp,@lungL,@lungR,@breath,@pulse,@bp,@heart,@digest,@genuri,@skin,@loco,@percep,@vision,@earL,@earR,@nose,@throat,@teeth,@recommend,@date)")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        MsgBox("Record was added successfully!")

        'FormPatients.PatientsGrid()
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        AddRecord()
        FormHome.Show()
        Me.Close()
    End Sub

End Class