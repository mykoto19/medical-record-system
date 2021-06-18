<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatientRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPatientRecord))
        Me.txtBreathing = New System.Windows.Forms.TextBox()
        Me.lblBreathing = New System.Windows.Forms.Label()
        Me.txtLeft_Lung = New System.Windows.Forms.TextBox()
        Me.txtRight_Lung = New System.Windows.Forms.TextBox()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.txtPulse = New System.Windows.Forms.TextBox()
        Me.lblPulse = New System.Windows.Forms.Label()
        Me.lblLungs = New System.Windows.Forms.Label()
        Me.lblBP = New System.Windows.Forms.Label()
        Me.txtBP = New System.Windows.Forms.TextBox()
        Me.lblHeart = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupRecommend = New System.Windows.Forms.GroupBox()
        Me.txtRecommend = New System.Windows.Forms.TextBox()
        Me.lblFluoroscopy = New System.Windows.Forms.Label()
        Me.GroupOthers = New System.Windows.Forms.GroupBox()
        Me.lblTeeth_Gums = New System.Windows.Forms.Label()
        Me.txtTeeth_Gums = New System.Windows.Forms.TextBox()
        Me.txtThroat = New System.Windows.Forms.TextBox()
        Me.lblThroat = New System.Windows.Forms.Label()
        Me.txtNose = New System.Windows.Forms.TextBox()
        Me.lblNose = New System.Windows.Forms.Label()
        Me.txtRightEar = New System.Windows.Forms.TextBox()
        Me.txtLeftEar = New System.Windows.Forms.TextBox()
        Me.lblRightEar = New System.Windows.Forms.Label()
        Me.lblLeftEar = New System.Windows.Forms.Label()
        Me.lblEars = New System.Windows.Forms.Label()
        Me.txtVisionTest = New System.Windows.Forms.TextBox()
        Me.lblVisionTest = New System.Windows.Forms.Label()
        Me.txtColorPerception = New System.Windows.Forms.TextBox()
        Me.lblColorPerception = New System.Windows.Forms.Label()
        Me.lblEyes = New System.Windows.Forms.Label()
        Me.lblLocomotive = New System.Windows.Forms.Label()
        Me.txtLocomotive = New System.Windows.Forms.TextBox()
        Me.lblSkin = New System.Windows.Forms.Label()
        Me.txtSkin = New System.Windows.Forms.TextBox()
        Me.lblGen_Urinary = New System.Windows.Forms.Label()
        Me.txtGen_Urinary = New System.Windows.Forms.TextBox()
        Me.lblDigestive = New System.Windows.Forms.Label()
        Me.txtDigestive = New System.Windows.Forms.TextBox()
        Me.GroupCirculatory = New System.Windows.Forms.GroupBox()
        Me.txtHeart = New System.Windows.Forms.TextBox()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.GroupRespiratory = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.CheckUpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCheckUpDate = New System.Windows.Forms.Label()
        Me.GroupRecommend.SuspendLayout()
        Me.GroupOthers.SuspendLayout()
        Me.GroupCirculatory.SuspendLayout()
        Me.GroupRespiratory.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBreathing
        '
        Me.txtBreathing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBreathing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBreathing.Location = New System.Drawing.Point(32, 103)
        Me.txtBreathing.Multiline = True
        Me.txtBreathing.Name = "txtBreathing"
        Me.txtBreathing.ReadOnly = True
        Me.txtBreathing.Size = New System.Drawing.Size(459, 60)
        Me.txtBreathing.TabIndex = 5
        '
        'lblBreathing
        '
        Me.lblBreathing.AutoSize = True
        Me.lblBreathing.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreathing.Location = New System.Drawing.Point(6, 82)
        Me.lblBreathing.Name = "lblBreathing"
        Me.lblBreathing.Size = New System.Drawing.Size(84, 18)
        Me.lblBreathing.TabIndex = 27
        Me.lblBreathing.Text = "Breathing:"
        '
        'txtLeft_Lung
        '
        Me.txtLeft_Lung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeft_Lung.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeft_Lung.Location = New System.Drawing.Point(87, 46)
        Me.txtLeft_Lung.Name = "txtLeft_Lung"
        Me.txtLeft_Lung.ReadOnly = True
        Me.txtLeft_Lung.Size = New System.Drawing.Size(148, 23)
        Me.txtLeft_Lung.TabIndex = 3
        '
        'txtRight_Lung
        '
        Me.txtRight_Lung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRight_Lung.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRight_Lung.Location = New System.Drawing.Point(319, 46)
        Me.txtRight_Lung.Name = "txtRight_Lung"
        Me.txtRight_Lung.ReadOnly = True
        Me.txtRight_Lung.Size = New System.Drawing.Size(148, 23)
        Me.txtRight_Lung.TabIndex = 4
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.Location = New System.Drawing.Point(268, 52)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(45, 17)
        Me.lblRight.TabIndex = 25
        Me.lblRight.Text = "Right:"
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeft.Location = New System.Drawing.Point(48, 52)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(36, 17)
        Me.lblLeft.TabIndex = 24
        Me.lblLeft.Text = "Left:"
        '
        'txtPulse
        '
        Me.txtPulse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulse.Location = New System.Drawing.Point(60, 19)
        Me.txtPulse.Name = "txtPulse"
        Me.txtPulse.ReadOnly = True
        Me.txtPulse.Size = New System.Drawing.Size(141, 23)
        Me.txtPulse.TabIndex = 6
        '
        'lblPulse
        '
        Me.lblPulse.AutoSize = True
        Me.lblPulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulse.Location = New System.Drawing.Point(6, 22)
        Me.lblPulse.Name = "lblPulse"
        Me.lblPulse.Size = New System.Drawing.Size(53, 17)
        Me.lblPulse.TabIndex = 31
        Me.lblPulse.Text = "Pulse:"
        '
        'lblLungs
        '
        Me.lblLungs.AutoSize = True
        Me.lblLungs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLungs.Location = New System.Drawing.Point(29, 34)
        Me.lblLungs.Name = "lblLungs"
        Me.lblLungs.Size = New System.Drawing.Size(52, 17)
        Me.lblLungs.TabIndex = 23
        Me.lblLungs.Text = "Lungs"
        '
        'lblBP
        '
        Me.lblBP.AutoSize = True
        Me.lblBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBP.Location = New System.Drawing.Point(245, 22)
        Me.lblBP.Name = "lblBP"
        Me.lblBP.Size = New System.Drawing.Size(124, 17)
        Me.lblBP.TabIndex = 29
        Me.lblBP.Text = "Blood Pressure:"
        '
        'txtBP
        '
        Me.txtBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBP.Location = New System.Drawing.Point(375, 19)
        Me.txtBP.Name = "txtBP"
        Me.txtBP.ReadOnly = True
        Me.txtBP.Size = New System.Drawing.Size(141, 23)
        Me.txtBP.TabIndex = 7
        '
        'lblHeart
        '
        Me.lblHeart.AutoSize = True
        Me.lblHeart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeart.Location = New System.Drawing.Point(6, 51)
        Me.lblHeart.Name = "lblHeart"
        Me.lblHeart.Size = New System.Drawing.Size(48, 17)
        Me.lblHeart.TabIndex = 28
        Me.lblHeart.Text = "Heart"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(551, 519)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 42)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupRecommend
        '
        Me.GroupRecommend.Controls.Add(Me.txtRecommend)
        Me.GroupRecommend.Location = New System.Drawing.Point(952, 81)
        Me.GroupRecommend.Name = "GroupRecommend"
        Me.GroupRecommend.Size = New System.Drawing.Size(299, 368)
        Me.GroupRecommend.TabIndex = 36
        Me.GroupRecommend.TabStop = False
        Me.GroupRecommend.Text = "Recommendation"
        '
        'txtRecommend
        '
        Me.txtRecommend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecommend.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecommend.Location = New System.Drawing.Point(6, 23)
        Me.txtRecommend.Multiline = True
        Me.txtRecommend.Name = "txtRecommend"
        Me.txtRecommend.ReadOnly = True
        Me.txtRecommend.Size = New System.Drawing.Size(287, 324)
        Me.txtRecommend.TabIndex = 20
        '
        'lblFluoroscopy
        '
        Me.lblFluoroscopy.AutoSize = True
        Me.lblFluoroscopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFluoroscopy.Location = New System.Drawing.Point(6, 16)
        Me.lblFluoroscopy.Name = "lblFluoroscopy"
        Me.lblFluoroscopy.Size = New System.Drawing.Size(107, 18)
        Me.lblFluoroscopy.TabIndex = 22
        Me.lblFluoroscopy.Text = "Fluoroscopy:"
        '
        'GroupOthers
        '
        Me.GroupOthers.Controls.Add(Me.lblTeeth_Gums)
        Me.GroupOthers.Controls.Add(Me.txtTeeth_Gums)
        Me.GroupOthers.Controls.Add(Me.txtThroat)
        Me.GroupOthers.Controls.Add(Me.lblThroat)
        Me.GroupOthers.Controls.Add(Me.txtNose)
        Me.GroupOthers.Controls.Add(Me.lblNose)
        Me.GroupOthers.Controls.Add(Me.txtRightEar)
        Me.GroupOthers.Controls.Add(Me.txtLeftEar)
        Me.GroupOthers.Controls.Add(Me.lblRightEar)
        Me.GroupOthers.Controls.Add(Me.lblLeftEar)
        Me.GroupOthers.Controls.Add(Me.lblEars)
        Me.GroupOthers.Controls.Add(Me.txtVisionTest)
        Me.GroupOthers.Controls.Add(Me.lblVisionTest)
        Me.GroupOthers.Controls.Add(Me.txtColorPerception)
        Me.GroupOthers.Controls.Add(Me.lblColorPerception)
        Me.GroupOthers.Controls.Add(Me.lblEyes)
        Me.GroupOthers.Controls.Add(Me.lblLocomotive)
        Me.GroupOthers.Controls.Add(Me.txtLocomotive)
        Me.GroupOthers.Controls.Add(Me.lblSkin)
        Me.GroupOthers.Controls.Add(Me.txtSkin)
        Me.GroupOthers.Controls.Add(Me.lblGen_Urinary)
        Me.GroupOthers.Controls.Add(Me.txtGen_Urinary)
        Me.GroupOthers.Controls.Add(Me.lblDigestive)
        Me.GroupOthers.Controls.Add(Me.txtDigestive)
        Me.GroupOthers.Location = New System.Drawing.Point(553, 49)
        Me.GroupOthers.Name = "GroupOthers"
        Me.GroupOthers.Size = New System.Drawing.Size(379, 467)
        Me.GroupOthers.TabIndex = 35
        Me.GroupOthers.TabStop = False
        Me.GroupOthers.Text = "Others"
        '
        'lblTeeth_Gums
        '
        Me.lblTeeth_Gums.AutoSize = True
        Me.lblTeeth_Gums.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeeth_Gums.Location = New System.Drawing.Point(9, 410)
        Me.lblTeeth_Gums.Name = "lblTeeth_Gums"
        Me.lblTeeth_Gums.Size = New System.Drawing.Size(133, 17)
        Me.lblTeeth_Gums.TabIndex = 63
        Me.lblTeeth_Gums.Text = "Teeth and Gums:"
        '
        'txtTeeth_Gums
        '
        Me.txtTeeth_Gums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeeth_Gums.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeeth_Gums.Location = New System.Drawing.Point(167, 405)
        Me.txtTeeth_Gums.Name = "txtTeeth_Gums"
        Me.txtTeeth_Gums.ReadOnly = True
        Me.txtTeeth_Gums.Size = New System.Drawing.Size(195, 23)
        Me.txtTeeth_Gums.TabIndex = 19
        '
        'txtThroat
        '
        Me.txtThroat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtThroat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThroat.Location = New System.Drawing.Point(167, 379)
        Me.txtThroat.Name = "txtThroat"
        Me.txtThroat.ReadOnly = True
        Me.txtThroat.Size = New System.Drawing.Size(195, 23)
        Me.txtThroat.TabIndex = 18
        '
        'lblThroat
        '
        Me.lblThroat.AutoSize = True
        Me.lblThroat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThroat.Location = New System.Drawing.Point(9, 384)
        Me.lblThroat.Name = "lblThroat"
        Me.lblThroat.Size = New System.Drawing.Size(61, 17)
        Me.lblThroat.TabIndex = 59
        Me.lblThroat.Text = "Throat:"
        '
        'txtNose
        '
        Me.txtNose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNose.Location = New System.Drawing.Point(167, 353)
        Me.txtNose.Name = "txtNose"
        Me.txtNose.ReadOnly = True
        Me.txtNose.Size = New System.Drawing.Size(195, 23)
        Me.txtNose.TabIndex = 17
        '
        'lblNose
        '
        Me.lblNose.AutoSize = True
        Me.lblNose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNose.Location = New System.Drawing.Point(9, 358)
        Me.lblNose.Name = "lblNose"
        Me.lblNose.Size = New System.Drawing.Size(50, 17)
        Me.lblNose.TabIndex = 57
        Me.lblNose.Text = "Nose:"
        '
        'txtRightEar
        '
        Me.txtRightEar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRightEar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRightEar.Location = New System.Drawing.Point(244, 313)
        Me.txtRightEar.Name = "txtRightEar"
        Me.txtRightEar.ReadOnly = True
        Me.txtRightEar.Size = New System.Drawing.Size(117, 23)
        Me.txtRightEar.TabIndex = 16
        '
        'txtLeftEar
        '
        Me.txtLeftEar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeftEar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeftEar.Location = New System.Drawing.Point(58, 313)
        Me.txtLeftEar.Name = "txtLeftEar"
        Me.txtLeftEar.ReadOnly = True
        Me.txtLeftEar.Size = New System.Drawing.Size(117, 23)
        Me.txtLeftEar.TabIndex = 15
        '
        'lblRightEar
        '
        Me.lblRightEar.AutoSize = True
        Me.lblRightEar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightEar.Location = New System.Drawing.Point(193, 318)
        Me.lblRightEar.Name = "lblRightEar"
        Me.lblRightEar.Size = New System.Drawing.Size(45, 17)
        Me.lblRightEar.TabIndex = 28
        Me.lblRightEar.Text = "Right:"
        '
        'lblLeftEar
        '
        Me.lblLeftEar.AutoSize = True
        Me.lblLeftEar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftEar.Location = New System.Drawing.Point(16, 318)
        Me.lblLeftEar.Name = "lblLeftEar"
        Me.lblLeftEar.Size = New System.Drawing.Size(36, 17)
        Me.lblLeftEar.TabIndex = 28
        Me.lblLeftEar.Text = "Left:"
        '
        'lblEars
        '
        Me.lblEars.AutoSize = True
        Me.lblEars.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEars.Location = New System.Drawing.Point(9, 289)
        Me.lblEars.Name = "lblEars"
        Me.lblEars.Size = New System.Drawing.Size(41, 17)
        Me.lblEars.TabIndex = 55
        Me.lblEars.Text = "Ears"
        '
        'txtVisionTest
        '
        Me.txtVisionTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVisionTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisionTest.Location = New System.Drawing.Point(167, 216)
        Me.txtVisionTest.Name = "txtVisionTest"
        Me.txtVisionTest.ReadOnly = True
        Me.txtVisionTest.Size = New System.Drawing.Size(195, 23)
        Me.txtVisionTest.TabIndex = 14
        '
        'lblVisionTest
        '
        Me.lblVisionTest.AutoSize = True
        Me.lblVisionTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisionTest.Location = New System.Drawing.Point(32, 221)
        Me.lblVisionTest.Name = "lblVisionTest"
        Me.lblVisionTest.Size = New System.Drawing.Size(82, 17)
        Me.lblVisionTest.TabIndex = 51
        Me.lblVisionTest.Text = "Vision Test:"
        '
        'txtColorPerception
        '
        Me.txtColorPerception.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColorPerception.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColorPerception.Location = New System.Drawing.Point(167, 190)
        Me.txtColorPerception.Name = "txtColorPerception"
        Me.txtColorPerception.ReadOnly = True
        Me.txtColorPerception.Size = New System.Drawing.Size(195, 23)
        Me.txtColorPerception.TabIndex = 13
        '
        'lblColorPerception
        '
        Me.lblColorPerception.AutoSize = True
        Me.lblColorPerception.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorPerception.Location = New System.Drawing.Point(32, 195)
        Me.lblColorPerception.Name = "lblColorPerception"
        Me.lblColorPerception.Size = New System.Drawing.Size(117, 17)
        Me.lblColorPerception.TabIndex = 49
        Me.lblColorPerception.Text = "Color Perception:"
        '
        'lblEyes
        '
        Me.lblEyes.AutoSize = True
        Me.lblEyes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEyes.Location = New System.Drawing.Point(9, 164)
        Me.lblEyes.Name = "lblEyes"
        Me.lblEyes.Size = New System.Drawing.Size(43, 17)
        Me.lblEyes.TabIndex = 48
        Me.lblEyes.Text = "Eyes"
        '
        'lblLocomotive
        '
        Me.lblLocomotive.AutoSize = True
        Me.lblLocomotive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocomotive.Location = New System.Drawing.Point(9, 95)
        Me.lblLocomotive.Name = "lblLocomotive"
        Me.lblLocomotive.Size = New System.Drawing.Size(152, 17)
        Me.lblLocomotive.TabIndex = 45
        Me.lblLocomotive.Text = "Locomotive System:"
        '
        'txtLocomotive
        '
        Me.txtLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocomotive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocomotive.Location = New System.Drawing.Point(167, 90)
        Me.txtLocomotive.Name = "txtLocomotive"
        Me.txtLocomotive.ReadOnly = True
        Me.txtLocomotive.Size = New System.Drawing.Size(195, 23)
        Me.txtLocomotive.TabIndex = 12
        '
        'lblSkin
        '
        Me.lblSkin.AutoSize = True
        Me.lblSkin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkin.Location = New System.Drawing.Point(9, 69)
        Me.lblSkin.Name = "lblSkin"
        Me.lblSkin.Size = New System.Drawing.Size(44, 17)
        Me.lblSkin.TabIndex = 43
        Me.lblSkin.Text = "Skin:"
        '
        'txtSkin
        '
        Me.txtSkin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSkin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSkin.Location = New System.Drawing.Point(167, 64)
        Me.txtSkin.Name = "txtSkin"
        Me.txtSkin.ReadOnly = True
        Me.txtSkin.Size = New System.Drawing.Size(195, 23)
        Me.txtSkin.TabIndex = 11
        '
        'lblGen_Urinary
        '
        Me.lblGen_Urinary.AutoSize = True
        Me.lblGen_Urinary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGen_Urinary.Location = New System.Drawing.Point(9, 43)
        Me.lblGen_Urinary.Name = "lblGen_Urinary"
        Me.lblGen_Urinary.Size = New System.Drawing.Size(120, 17)
        Me.lblGen_Urinary.TabIndex = 41
        Me.lblGen_Urinary.Text = "Genito-Urinary:"
        '
        'txtGen_Urinary
        '
        Me.txtGen_Urinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGen_Urinary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGen_Urinary.Location = New System.Drawing.Point(167, 38)
        Me.txtGen_Urinary.Name = "txtGen_Urinary"
        Me.txtGen_Urinary.ReadOnly = True
        Me.txtGen_Urinary.Size = New System.Drawing.Size(195, 23)
        Me.txtGen_Urinary.TabIndex = 10
        '
        'lblDigestive
        '
        Me.lblDigestive.AutoSize = True
        Me.lblDigestive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigestive.Location = New System.Drawing.Point(9, 17)
        Me.lblDigestive.Name = "lblDigestive"
        Me.lblDigestive.Size = New System.Drawing.Size(137, 17)
        Me.lblDigestive.TabIndex = 39
        Me.lblDigestive.Text = "Digestive System:"
        '
        'txtDigestive
        '
        Me.txtDigestive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDigestive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigestive.Location = New System.Drawing.Point(167, 12)
        Me.txtDigestive.Name = "txtDigestive"
        Me.txtDigestive.ReadOnly = True
        Me.txtDigestive.Size = New System.Drawing.Size(195, 23)
        Me.txtDigestive.TabIndex = 9
        '
        'GroupCirculatory
        '
        Me.GroupCirculatory.Controls.Add(Me.txtPulse)
        Me.GroupCirculatory.Controls.Add(Me.lblPulse)
        Me.GroupCirculatory.Controls.Add(Me.txtHeart)
        Me.GroupCirculatory.Controls.Add(Me.lblBP)
        Me.GroupCirculatory.Controls.Add(Me.txtBP)
        Me.GroupCirculatory.Controls.Add(Me.lblHeart)
        Me.GroupCirculatory.Location = New System.Drawing.Point(15, 316)
        Me.GroupCirculatory.Name = "GroupCirculatory"
        Me.GroupCirculatory.Size = New System.Drawing.Size(522, 182)
        Me.GroupCirculatory.TabIndex = 34
        Me.GroupCirculatory.TabStop = False
        Me.GroupCirculatory.Text = "Circulatory System"
        '
        'txtHeart
        '
        Me.txtHeart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeart.Location = New System.Drawing.Point(32, 74)
        Me.txtHeart.Multiline = True
        Me.txtHeart.Name = "txtHeart"
        Me.txtHeart.ReadOnly = True
        Me.txtHeart.Size = New System.Drawing.Size(459, 87)
        Me.txtHeart.TabIndex = 8
        '
        'txtTemperature
        '
        Me.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.Location = New System.Drawing.Point(194, 63)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.ReadOnly = True
        Me.txtTemperature.Size = New System.Drawing.Size(72, 23)
        Me.txtTemperature.TabIndex = 2
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.Location = New System.Drawing.Point(12, 68)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(176, 18)
        Me.lblTemperature.TabIndex = 33
        Me.lblTemperature.Text = "Temperature(Celsius):"
        '
        'GroupRespiratory
        '
        Me.GroupRespiratory.Controls.Add(Me.txtBreathing)
        Me.GroupRespiratory.Controls.Add(Me.lblBreathing)
        Me.GroupRespiratory.Controls.Add(Me.txtRight_Lung)
        Me.GroupRespiratory.Controls.Add(Me.txtLeft_Lung)
        Me.GroupRespiratory.Controls.Add(Me.lblRight)
        Me.GroupRespiratory.Controls.Add(Me.lblLeft)
        Me.GroupRespiratory.Controls.Add(Me.lblLungs)
        Me.GroupRespiratory.Controls.Add(Me.lblFluoroscopy)
        Me.GroupRespiratory.Location = New System.Drawing.Point(15, 112)
        Me.GroupRespiratory.Name = "GroupRespiratory"
        Me.GroupRespiratory.Size = New System.Drawing.Size(522, 172)
        Me.GroupRespiratory.TabIndex = 32
        Me.GroupRespiratory.TabStop = False
        Me.GroupRespiratory.Text = "Respiratory System"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(12, 23)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(155, 29)
        Me.lblID.TabIndex = 31
        Me.lblID.Text = "Patient's ID"
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.Color.Black
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.ForeColor = System.Drawing.Color.White
        Me.btnGoBack.Location = New System.Drawing.Point(1135, 520)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(116, 42)
        Me.btnGoBack.TabIndex = 22
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(472, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(222, 33)
        Me.lblTitle.TabIndex = 30
        Me.lblTitle.Text = "Medical Record"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Black
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(12, 519)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 42)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'CheckUpDate
        '
        Me.CheckUpDate.CustomFormat = ""
        Me.CheckUpDate.Enabled = False
        Me.CheckUpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckUpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckUpDate.Location = New System.Drawing.Point(975, 29)
        Me.CheckUpDate.Name = "CheckUpDate"
        Me.CheckUpDate.Size = New System.Drawing.Size(276, 23)
        Me.CheckUpDate.TabIndex = 1
        Me.CheckUpDate.Value = New Date(2019, 11, 26, 0, 0, 0, 0)
        '
        'lblCheckUpDate
        '
        Me.lblCheckUpDate.AutoSize = True
        Me.lblCheckUpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckUpDate.Location = New System.Drawing.Point(955, 9)
        Me.lblCheckUpDate.Name = "lblCheckUpDate"
        Me.lblCheckUpDate.Size = New System.Drawing.Size(117, 17)
        Me.lblCheckUpDate.TabIndex = 37
        Me.lblCheckUpDate.Text = "Last Check-up:"
        '
        'FormPatientRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1263, 573)
        Me.Controls.Add(Me.lblCheckUpDate)
        Me.Controls.Add(Me.CheckUpDate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupRecommend)
        Me.Controls.Add(Me.GroupOthers)
        Me.Controls.Add(Me.GroupCirculatory)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.GroupRespiratory)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPatientRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Medical Form"
        Me.GroupRecommend.ResumeLayout(False)
        Me.GroupRecommend.PerformLayout()
        Me.GroupOthers.ResumeLayout(False)
        Me.GroupOthers.PerformLayout()
        Me.GroupCirculatory.ResumeLayout(False)
        Me.GroupCirculatory.PerformLayout()
        Me.GroupRespiratory.ResumeLayout(False)
        Me.GroupRespiratory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBreathing As System.Windows.Forms.TextBox
    Friend WithEvents lblBreathing As System.Windows.Forms.Label
    Friend WithEvents txtLeft_Lung As System.Windows.Forms.TextBox
    Friend WithEvents txtRight_Lung As System.Windows.Forms.TextBox
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents txtPulse As System.Windows.Forms.TextBox
    Friend WithEvents lblPulse As System.Windows.Forms.Label
    Friend WithEvents lblLungs As System.Windows.Forms.Label
    Friend WithEvents lblBP As System.Windows.Forms.Label
    Friend WithEvents txtBP As System.Windows.Forms.TextBox
    Friend WithEvents lblHeart As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupRecommend As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecommend As System.Windows.Forms.TextBox
    Friend WithEvents lblFluoroscopy As System.Windows.Forms.Label
    Friend WithEvents GroupOthers As System.Windows.Forms.GroupBox
    Friend WithEvents lblTeeth_Gums As System.Windows.Forms.Label
    Friend WithEvents txtTeeth_Gums As System.Windows.Forms.TextBox
    Friend WithEvents txtThroat As System.Windows.Forms.TextBox
    Friend WithEvents lblThroat As System.Windows.Forms.Label
    Friend WithEvents txtNose As System.Windows.Forms.TextBox
    Friend WithEvents lblNose As System.Windows.Forms.Label
    Friend WithEvents txtRightEar As System.Windows.Forms.TextBox
    Friend WithEvents txtLeftEar As System.Windows.Forms.TextBox
    Friend WithEvents lblRightEar As System.Windows.Forms.Label
    Friend WithEvents lblLeftEar As System.Windows.Forms.Label
    Friend WithEvents lblEars As System.Windows.Forms.Label
    Friend WithEvents txtVisionTest As System.Windows.Forms.TextBox
    Friend WithEvents lblVisionTest As System.Windows.Forms.Label
    Friend WithEvents txtColorPerception As System.Windows.Forms.TextBox
    Friend WithEvents lblColorPerception As System.Windows.Forms.Label
    Friend WithEvents lblEyes As System.Windows.Forms.Label
    Friend WithEvents lblLocomotive As System.Windows.Forms.Label
    Friend WithEvents txtLocomotive As System.Windows.Forms.TextBox
    Friend WithEvents lblSkin As System.Windows.Forms.Label
    Friend WithEvents txtSkin As System.Windows.Forms.TextBox
    Friend WithEvents lblGen_Urinary As System.Windows.Forms.Label
    Friend WithEvents txtGen_Urinary As System.Windows.Forms.TextBox
    Friend WithEvents lblDigestive As System.Windows.Forms.Label
    Friend WithEvents txtDigestive As System.Windows.Forms.TextBox
    Friend WithEvents GroupCirculatory As System.Windows.Forms.GroupBox
    Friend WithEvents txtHeart As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperature As System.Windows.Forms.TextBox
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents GroupRespiratory As System.Windows.Forms.GroupBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents CheckUpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCheckUpDate As System.Windows.Forms.Label
End Class
