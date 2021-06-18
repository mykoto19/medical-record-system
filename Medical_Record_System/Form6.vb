Public Class FormInit
    Private Access As New DBControl

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FormPatients.Show()
        Me.Close()
    End Sub


    Private Sub btnPatientInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatientInfo.Click


        FormPatientInfo.Show()

        FormPatients.Hide()
        Me.Hide()
    End Sub

    'Private Sub temper()
    'Access.AddParam("@id", FormPatients.dgvPatients.CurrentRow.Cells(0).Value.ToString)
    'Access.AddParam("@temp", "Medical_Record.Temperature")
    'Access.ExecQuery("SELECT Temperature FROM Medical_Record WHERE ID=@id")

    'Dim r As DataTable = Access.DBDT

    'FormPatientRecord.txtTemperature.Text = r("Temperature").ToString
    'End Sub

    Private Sub btnMedRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedRec.Click

        'Dim myID As String

        'Access.AddParam("@id", FormPatientInfo.lblTitle.Text)
        'Access.AddParam("@temp", FormPatientRecord.txtTemperature.Text)
        'Access.ExecQuery("SELECT * FROM Medical_Record WHERE ID=@id")

        'FormPatientRecord.lblID.Text = FormPatients.dgvPatients.CurrentRow.Cells(0).Value.ToString



        'FormPatientRecord.lblID.Text = ("ID").ToString
        'temper()
        'FormPatientRecord.txtLeft_Lung.Text = ("LungL").ToString
        'FormPatientRecord.txtRight_Lung.Text = ("LungR").ToString
        'FormPatientRecord.txtBreathing.Text = ("Breathing").ToString
        'FormPatientRecord.txtPulse.Text = ("Pulse").ToString
        'FormPatientRecord.txtBP.Text = ("BloodPressure").ToString
        'FormPatientRecord.txtHeart.Text = ("Heart").ToString
        'FormPatientRecord.txtDigestive.Text = ("Digestion").ToString
        'FormPatientRecord.txtGen_Urinary.Text = ("Genito_Urinary").ToString
        'FormPatientRecord.txtSkin.Text = ("Skin").ToString
        'FormPatientRecord.txtLocomotive.Text = ("Locomotive").ToString
        'FormPatientRecord.txtColorPerception.Text = ("EyeColorPercep").ToString
        'FormPatientRecord.txtVisionTest.Text = ("EyeVisionTest").ToString
        'FormPatientRecord.txtLeftEar.Text = ("EarL").ToString
        'FormPatientRecord.txtRightEar.Text = ("EarR").ToString
        'FormPatientRecord.txtNose.Text = ("Nose").ToString
        'FormPatientRecord.txtThroat.Text = ("Throat").ToString
        'FormPatientRecord.txtTeeth_Gums.Text = ("Teeth").ToString
        'FormPatientRecord.txtRecommend.Text = ("Recommendation").ToString
        'FormPatientRecord.txtDate.Text = ("Check_UpDate").ToString

        FormPatientRecord.Show()

        FormPatients.Hide()
        Me.Hide()
    End Sub
End Class