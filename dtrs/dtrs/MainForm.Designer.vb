<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ShowMainDTR = New System.Windows.Forms.Button()
        Me.ShowLoginForm = New System.Windows.Forms.Button()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowMainDTR
        '
        Me.ShowMainDTR.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowMainDTR.Location = New System.Drawing.Point(324, 102)
        Me.ShowMainDTR.Name = "ShowMainDTR"
        Me.ShowMainDTR.Size = New System.Drawing.Size(448, 84)
        Me.ShowMainDTR.TabIndex = 0
        Me.ShowMainDTR.Text = "Employees"
        Me.ShowMainDTR.UseVisualStyleBackColor = True
        '
        'ShowLoginForm
        '
        Me.ShowLoginForm.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowLoginForm.Location = New System.Drawing.Point(324, 192)
        Me.ShowLoginForm.Name = "ShowLoginForm"
        Me.ShowLoginForm.Size = New System.Drawing.Size(448, 84)
        Me.ShowLoginForm.TabIndex = 1
        Me.ShowLoginForm.Text = "Admin"
        Me.ShowLoginForm.UseVisualStyleBackColor = True
        '
        'LogoBox
        '
        Me.LogoBox.Image = CType(resources.GetObject("LogoBox.Image"), System.Drawing.Image)
        Me.LogoBox.Location = New System.Drawing.Point(12, 73)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(303, 264)
        Me.LogoBox.TabIndex = 6
        Me.LogoBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.LogoBox)
        Me.Controls.Add(Me.ShowLoginForm)
        Me.Controls.Add(Me.ShowMainDTR)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Time Record Management System"
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShowMainDTR As Button
    Friend WithEvents ShowLoginForm As Button
    Friend WithEvents LogoBox As PictureBox
End Class
