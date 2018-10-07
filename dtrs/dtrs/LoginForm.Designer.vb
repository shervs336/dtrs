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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.btnReturnToMainMenu = New System.Windows.Forms.Button()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Location = New System.Drawing.Point(368, 135)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(55, 13)
        Me.labelUsername.TabIndex = 0
        Me.labelUsername.Text = "Username"
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Location = New System.Drawing.Point(370, 188)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(53, 13)
        Me.labelPassword.TabIndex = 1
        Me.labelPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.AccessibleName = "username"
        Me.txtUsername.Location = New System.Drawing.Point(442, 135)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(305, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.AccessibleName = "password"
        Me.txtPassword.Location = New System.Drawing.Point(442, 185)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(305, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(442, 235)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'LogoBox
        '
        Me.LogoBox.Image = CType(resources.GetObject("LogoBox.Image"), System.Drawing.Image)
        Me.LogoBox.Location = New System.Drawing.Point(45, 84)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(303, 264)
        Me.LogoBox.TabIndex = 5
        Me.LogoBox.TabStop = False
        '
        'btnReturnToMainMenu
        '
        Me.btnReturnToMainMenu.Location = New System.Drawing.Point(548, 235)
        Me.btnReturnToMainMenu.Name = "btnReturnToMainMenu"
        Me.btnReturnToMainMenu.Size = New System.Drawing.Size(140, 23)
        Me.btnReturnToMainMenu.TabIndex = 6
        Me.btnReturnToMainMenu.Text = "Return To Main Menu"
        Me.btnReturnToMainMenu.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.btnReturnToMainMenu)
        Me.Controls.Add(Me.LogoBox)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.labelUsername)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Time Record Management System"
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelUsername As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents LogoBox As PictureBox
    Friend WithEvents btnReturnToMainMenu As Button
End Class
