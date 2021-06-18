Public Class FormPatients

    Private Access As New DBControl

    Private Function NoErrors(Optional ByVal Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs)
        PatientsGrid()
    End Sub

    Public Sub PatientsGrid()
        Access.ExecQuery("SELECT * FROM Persona_Info ORDER BY ID ASC")

        If NoErrors(True) = False Then Exit Sub

        dgvPatients.DataSource = Access.DBDT
    End Sub

    Private Sub SearchID(ByVal YourName As String)
        Access.AddParam("@name", "%" & YourName & "%")
        Access.ExecQuery("SELECT * FROM Persona_Info " & _
                         "WHERE FullName LIKE @name;")



        If NoErrors(True) = False Then Exit Sub

        dgvPatients.DataSource = Access.DBDT
    End Sub

    Private Sub DeletePatient()
        If MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo, "Confirm Delete?") = MsgBoxResult.No Then Exit Sub
        Access.AddParam("@id", txtID.Text)
        Access.ExecQuery("DELETE FROM Persona_Info WHERE ID=@id")
        'Access.ExecQuery("DELETE FROM Medical_Record WHERE ID=@id")
        DeleteRecord()
        txtID.Clear()
        PatientsGrid()
    End Sub

    Private Sub DeleteRecord()

        Access.AddParam("@id", txtID.Text)
        Access.ExecQuery("DELETE FROM Medical_Record WHERE ID=@id")

        txtID.Clear()

    End Sub

    Private Sub SelectPatient2()
        Access.AddParam("@id", dgvPatients.CurrentRow.Cells(0).Value.ToString)
        'Access.AddParam("@id", FormInit.lblTitle.Text)
        Access.ExecQuery("SELECT TOP 1 Medical_Record.ID, Temperature,LungL,LungR,Breathing,Pulse,BloodPressure,Heart,Digestion,Genito_Urinary,Skin,Locomotive,EyeColorPercep,EyeVisionTest,EarL,EarR,Nose,Throat,Teeth,Recommendation,Check_UpDate " & _
                         "FROM Persona_Info " & _
                         "INNER JOIN Medical_Record ON Persona_Info.ID = Medical_Record.ID " & _
                         "WHERE Persona_Info.ID=@id")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        Dim r As DataRow = Access.DBDT.Rows(0)

        FormPatientRecord.lblID.Text = r("ID").ToString

        FormPatientRecord.txtTemperature.Text = r("Temperature").ToString
        FormPatientRecord.txtLeft_Lung.Text = r("LungL").ToString
        FormPatientRecord.txtRight_Lung.Text = r("LungR").ToString
        FormPatientRecord.txtBreathing.Text = r("Breathing").ToString
        FormPatientRecord.txtPulse.Text = r("Pulse").ToString
        FormPatientRecord.txtBP.Text = r("BloodPressure").ToString
        FormPatientRecord.txtHeart.Text = r("Heart").ToString
        FormPatientRecord.txtDigestive.Text = r("Digestion").ToString
        FormPatientRecord.txtGen_Urinary.Text = r("Genito_Urinary").ToString
        FormPatientRecord.txtSkin.Text = r("Skin").ToString
        FormPatientRecord.txtLocomotive.Text = r("Locomotive").ToString
        FormPatientRecord.txtColorPerception.Text = r("EyeColorPercep").ToString
        FormPatientRecord.txtVisionTest.Text = r("EyeVisionTest").ToString
        FormPatientRecord.txtLeftEar.Text = r("EarL").ToString
        FormPatientRecord.txtRightEar.Text = r("EarR").ToString
        FormPatientRecord.txtNose.Text = r("Nose").ToString
        FormPatientRecord.txtThroat.Text = r("Throat").ToString
        FormPatientRecord.txtTeeth_Gums.Text = r("Teeth").ToString
        FormPatientRecord.txtRecommend.Text = r("Recommendation").ToString
        FormPatientRecord.CheckUpDate.Text = r("Check_UpDate").ToString
    End Sub

    Private Sub SelectPatient(ByVal YourID As String)
        Access.AddParam("@id", YourID)
        Access.ExecQuery("SELECT TOP 1 ID, FullName, Course_Year, Address, Age, Gender, Civil_Status, Height_cm, Weight_kg FROM Persona_Info WHERE ID=@id")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        Dim r As DataRow = Access.DBDT.Rows(0)
        txtID.Text = r("ID").ToString

        FormPatientInfo.grpPersonInfo.Text = r("ID").ToString
        FormPatientInfo.txtName.Text = r("FullName").ToString
        FormPatientInfo.txtCourse.Text = r("Course_Year").ToString
        FormPatientInfo.txtAddress.Text = r("Address").ToString
        FormPatientInfo.txtAge.Text = r("Age").ToString
        FormPatientInfo.cbxGender.Text = r("Gender").ToString
        FormPatientInfo.cbxStatus.Text = r("Civil_Status").ToString
        FormPatientInfo.txtHeight.Text = r("Height_cm").ToString
        FormPatientInfo.txtWeight.Text = r("Weight_kg").ToString



        'Dim form As New FormInit

        'form.txtID.Text = dgvPatients.CurrentRow.Cells(0).Value.ToString
        'form.txtFname.Text = dgvPatients.CurrentRow.Cells(1).Value.ToString
        'form.txtCourse.Text = dgvPatients.CurrentRow.Cells(2).Value.ToString
        'form.txtGender.Text = dgvPatients.CurrentRow.Cells(5).Value.ToString

        'FormInit.ShowDialog()
    End Sub


    'Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
    'FormInit.Show()
    'Me.Hide()
    'End Sub

    Public Sub dgvPatients_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPatients.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        SelectPatient(dgvPatients.Item(0, e.RowIndex).Value)
        SelectPatient2()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeletePatient()
        'DeleteRecord()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FormHome.Show()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchID(txtSearch.Text)
        btnSelect.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim form As New FormInit

        form.lblTitle.Text = dgvPatients.CurrentRow.Cells(0).Value.ToString
        form.txtFname.Text = dgvPatients.CurrentRow.Cells(1).Value.ToString
        form.txtCourse.Text = dgvPatients.CurrentRow.Cells(2).Value.ToString
        form.txtGender.Text = dgvPatients.CurrentRow.Cells(5).Value.ToString

        form.ShowDialog()
    End Sub

    Private Sub dgvPatients_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPatients.CellContentClick


    End Sub

    'Public Sub PerInfo()
    'Dim myForm As New FormPatientInfo

    'myForm.lblTitle.Text = dgvPatients.CurrentRow.Cells(0).Value.ToString
    'myForm.txtName.Text = dgvPatients.CurrentRow.Cells(1).Value.ToString
    'myForm.txtCourse.Text = dgvPatients.CurrentRow.Cells(2).Value.ToString
    'myForm.txtAddress.Text = dgvPatients.CurrentRow.Cells(3).Value.ToString
    'myForm.txtAge.Text = dgvPatients.CurrentRow.Cells(4).Value.ToString
    'myForm.cbxGender.Text = dgvPatients.CurrentRow.Cells(5).Value.ToString
    'myForm.cbxStatus.Text = dgvPatients.CurrentRow.Cells(6).Value.ToString
    'myForm.txtHeight.Text = dgvPatients.CurrentRow.Cells(7).Value.ToString
    'myForm.txtWeight.Text = dgvPatients.CurrentRow.Cells(8).Value.ToString
    'End Sub

    Private Sub dgvPatients_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPatients.DoubleClick
        Dim form As New FormInit

        form.lblTitle.Text = dgvPatients.CurrentRow.Cells(0).Value.ToString
        form.txtFname.Text = dgvPatients.CurrentRow.Cells(1).Value.ToString
        form.txtCourse.Text = dgvPatients.CurrentRow.Cells(2).Value.ToString
        form.txtGender.Text = dgvPatients.CurrentRow.Cells(5).Value.ToString



        form.ShowDialog()
    End Sub
End Class