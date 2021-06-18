<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.lblMedRec2 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnPatList = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMedRec2
        '
        Me.lblMedRec2.AutoSize = True
        Me.lblMedRec2.BackColor = System.Drawing.Color.Transparent
        Me.lblMedRec2.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedRec2.ForeColor = System.Drawing.Color.Teal
        Me.lblMedRec2.Location = New System.Drawing.Point(202, 67)
        Me.lblMedRec2.Name = "lblMedRec2"
        Me.lblMedRec2.Size = New System.Drawing.Size(360, 30)
        Me.lblMedRec2.TabIndex = 6
        Me.lblMedRec2.Text = "Medical Record System"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.BackColor = System.Drawing.Color.Transparent
        Me.lblName2.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName2.ForeColor = System.Drawing.Color.Teal
        Me.lblName2.Location = New System.Drawing.Point(192, 37)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(382, 30)
        Me.lblName2.TabIndex = 5
        Me.lblName2.Text = "Guimaras State College"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Black
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(269, 266)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(206, 55)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.Black
        Me.btnSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.Location = New System.Drawing.Point(269, 144)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(206, 55)
        Me.btnSignup.TabIndex = 1
        Me.btnSignup.Text = "Sign Up"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnPatList
        '
        Me.btnPatList.BackColor = System.Drawing.Color.Black
        Me.btnPatList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatList.ForeColor = System.Drawing.Color.White
        Me.btnPatList.Location = New System.Drawing.Point(269, 205)
        Me.btnPatList.Name = "btnPatList"
        Me.btnPatList.Size = New System.Drawing.Size(206, 55)
        Me.btnPatList.TabIndex = 2
        Me.btnPatList.Text = "Patients List"
        Me.btnPatList.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(102, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(717, 381)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPatList)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblMedRec2)
        Me.Controls.Add(Me.lblName2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMedRec2 As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnSignup As System.Windows.Forms.Button
    Friend WithEvents btnPatList As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
