<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DTRForm
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
        Me.Database3SADDataSet = New dtrs.Database3SADDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGEmployeeLogin = New System.Windows.Forms.DataGridView()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGEmployeeLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database3SADDataSet
        '
        Me.Database3SADDataSet.DataSetName = "Database3SADDataSet"
        Me.Database3SADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name :"
        '
        'DGEmployeeLogin
        '
        Me.DGEmployeeLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmployeeLogin.Location = New System.Drawing.Point(12, 127)
        Me.DGEmployeeLogin.Name = "DGEmployeeLogin"
        Me.DGEmployeeLogin.Size = New System.Drawing.Size(784, 394)
        Me.DGEmployeeLogin.TabIndex = 4
        '
        'FullNameLabel
        '
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameLabel.Location = New System.Drawing.Point(101, 21)
        Me.FullNameLabel.Name = "FullNameLabel"
        Me.FullNameLabel.Size = New System.Drawing.Size(85, 20)
        Me.FullNameLabel.TabIndex = 5
        Me.FullNameLabel.Text = "Full_Name"
        '
        'PositionLabel
        '
        Me.PositionLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PositionLabel.AutoSize = True
        Me.PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionLabel.Location = New System.Drawing.Point(101, 63)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(65, 20)
        Me.PositionLabel.TabIndex = 7
        Me.PositionLabel.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Position :"
        '
        'DTRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 553)
        Me.Controls.Add(Me.PositionLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FullNameLabel)
        Me.Controls.Add(Me.DGEmployeeLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DTRForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGEmployeeLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database3SADDataSet As Database3SADDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents DGEmployeeLogin As DataGridView
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents PositionLabel As Label
    Friend WithEvents Label4 As Label
End Class
