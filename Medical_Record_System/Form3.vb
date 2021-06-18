Public Class FormSignUp

    Private Access As New DBControl

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        FormHome.Show()
        Me.Close()
    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))

        End If

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

    'Public Sub NumberOnly(ByRef sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    'Asc(e.KeyChar) <= 48 Or Asc(e.KeyChar) >= 57
    'End Sub

    Private Sub TextBox_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged, txtID.TextChanged, txtAddress.TextChanged,
        txtAge.TextChanged, txtCourse.TextChanged, txtHeight.TextChanged, txtWeight.TextChanged

        If Not String.IsNullOrWhiteSpace(txtName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtID.Text) AndAlso Not String.IsNullOrWhiteSpace(txtAddress.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtAge.Text) AndAlso Not String.IsNullOrWhiteSpace(txtCourse.Text) AndAlso Not String.IsNullOrWhiteSpace(txtHeight.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtWeight.Text) Then
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub AddPatient()
        Access.AddParam("@pid", txtID.Text)
        Access.AddParam("@name", txtName.Text)
        Access.AddParam("@course", txtCourse.Text)
        Access.AddParam("@address", txtAddress.Text)
        Access.AddParam("@age", CInt(txtAge.Text))
        Access.AddParam("@gender", cbxGender.Text)
        Access.AddParam("@status", cbxStatus.Text)
        Access.AddParam("@height", CDbl(txtHeight.Text))
        Access.AddParam("@weigth", CDbl(txtWeight.Text))


        Access.ExecQuery("INSERT INTO Persona_Info(ID,FullName,Course_Year,Address,Age,Gender,Civil_Status,Height_cm,Weight_kg) " & _
                         "VALUES(@pid,@name,@course,@address,@age,@gender,@status,@heigth,@weight)")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        MsgBox("User was added successfully!")

        'FormPatients.PatientsGrid()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        AddPatient()
        FormMedicalSign.lblID.Text = txtID.Text
        btnProceed.Enabled = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtID.Clear()
        txtCourse.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        txtHeight.Clear()
        txtWeight.Clear()
        cbxGender.Text = ""
        cbxStatus.Text = ""
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        FormMedicalSign.Show()
        Me.Close()
    End Sub

End Class