<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(35, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(39, 303)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(154, 20)
        Me.txtPassword.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(39, 206)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(154, 20)
        Me.txtUsername.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogin.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnLogin.Location = New System.Drawing.Point(426, 293)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(139, 35)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSignUp.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.btnSignUp.Location = New System.Drawing.Point(426, 198)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(139, 31)
        Me.btnSignUp.TabIndex = 9
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(35, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Welcome!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(35, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "STOCK MANAGEMENT SYSTEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(422, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Create a new account"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(422, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Login to an existing account"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 386)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "LoginForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
