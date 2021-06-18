Public Class FormPatientInfo
    Private Access As New DBControl

    Private CurrentRecord As Integer = 0


    Private Function NoErrors(Optional ByVal Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) 'REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function

    'Public Sub PatientInfo()

    'Access.AddParam()

    'Access.ExecQuery("SELECT ID('" & lblTitle.Text & "'),FullName('" & txtName.Text & "'),Course_Year('" & txtCourse.Text & "'),Address('" & txtAddress.Text & "'),Age('" & txtAge.Text & "'),Gender('" & cbxGender.Text & "'),Civil_Status('" & cbxStatus.Text & "'),Height_cm('" & txtHeight.Text & "'),Weight_kg('" & txtWeight.Text & "') " & _
    '"FROM Persona_Info WHERE ID = '" & FormInit.lblTitle.Text & "'")

    'Dim r As DataRow
    'lblTitle.Text = FormPatients.dgvPatients.CurrentRow.Cells(0).Value.ToString
    'txtName.Text = FormPatients.dgvPatients.CurrentRow.Cells(1).Value.ToString
    'txtCourse.Text = FormPatients.dgvPatients.CurrentRow.Cells(2).Value.ToString
    'txtAddress.Text = FormPatients.dgvPatients.CurrentRow.Cells(3).Value.ToString
    'txtAge.Text = FormPatients.dgvPatients.CurrentRow.Cells(4).Value.ToString
    'cbxGender.Text = FormPatients.dgvPatients.CurrentRow.Cells(5).Value.ToString
    'cbxStatus.Text = FormPatients.dgvPatients.CurrentRow.Cells(6).Value.ToString
    'txtHeight.Text = FormPatients.dgvPatients.CurrentRow.Cells(7).Value.ToString
    'txtWeight.Text = FormPatients.dgvPatients.CurrentRow.Cells(8).Value.ToString

    'End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FormPatients.Show()
        Me.Close()
    End Sub

    

    Private Sub UpdateInfo()
        If String.IsNullOrEmpty(grpPersonInfo.Text) Then Exit Sub

        Access.AddParam("@name", txtName.Text)
        Access.AddParam("@course", txtCourse.Text)
        Access.AddParam("@address", txtAddress.Text)
        Access.AddParam("@age", CInt(txtAge.Text))
        Access.AddParam("@gender", cbxGender.Text)
        Access.AddParam("@status", cbxStatus.Text)
        Access.AddParam("@height", CDbl(txtHeight.Text))
        Access.AddParam("@weight", CDbl(txtWeight.Text))
        Access.AddParam("@id", grpPersonInfo.Text)

        Access.ExecQuery("UPDATE Persona_Info " & _
                         "SET FullName=@name,Course_Year=@course,Address=@address,Age=@age,Gender=@gender,Civil_Status=@status,Height_cm=@height,Weight_kg=@weight " & _
                         "WHERE ID=@id")

        If NoErrors(True) = False Then Exit Sub

        MessageBox.Show("Information Updated.", "Success!")
        FormPatients.PatientsGrid()
    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim form As New FormPassConfirm
        form.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        UpdateInfo()

    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtCourse.Text = ""
        txtAddress.Text = ""
        txtAge.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
    End Sub

    Private Sub txtHeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHeight.KeyPress
        Dim dot As Integer
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If e.KeyChar = "." And Not txtHeight.Text.IndexOf(".") = -1 Then
            e.Handled = False
            dot = txtHeight.Text.IndexOf(".")
            If dot > -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        Dim dot As Integer
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

        If e.KeyChar = "." And Not txtWeight.Text.IndexOf(".") = -1 Then
            e.Handled = False
            dot = txtWeight.Text.IndexOf(".")
            If dot > -1 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class