<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDTRForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.TextBox()
        Me.btnTimeIn = New System.Windows.Forms.Button()
        Me.btnTimeOut = New System.Windows.Forms.Button()
        Me.DGEmployeeDTR = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelEmployeeName = New System.Windows.Forms.Label()
        CType(Me.DGEmployeeDTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmployeeID
        '
        Me.EmployeeID.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.Location = New System.Drawing.Point(412, 19)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(218, 47)
        Me.EmployeeID.TabIndex = 2
        '
        'btnTimeIn
        '
        Me.btnTimeIn.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.Location = New System.Drawing.Point(167, 78)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(218, 80)
        Me.btnTimeIn.TabIndex = 3
        Me.btnTimeIn.Text = "Time In"
        Me.btnTimeIn.UseVisualStyleBackColor = True
        '
        'btnTimeOut
        '
        Me.btnTimeOut.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.Location = New System.Drawing.Point(412, 78)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(218, 80)
        Me.btnTimeOut.TabIndex = 4
        Me.btnTimeOut.Text = "Time Out"
        Me.btnTimeOut.UseVisualStyleBackColor = True
        '
        'DGEmployeeDTR
        '
        Me.DGEmployeeDTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmployeeDTR.Location = New System.Drawing.Point(263, 180)
        Me.DGEmployeeDTR.Name = "DGEmployeeDTR"
        Me.DGEmployeeDTR.Size = New System.Drawing.Size(503, 269)
        Me.DGEmployeeDTR.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee Name:"
        '
        'LabelEmployeeName
        '
        Me.LabelEmployeeName.AutoSize = True
        Me.LabelEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployeeName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelEmployeeName.Location = New System.Drawing.Point(11, 215)
        Me.LabelEmployeeName.Name = "LabelEmployeeName"
        Me.LabelEmployeeName.Size = New System.Drawing.Size(0, 29)
        Me.LabelEmployeeName.TabIndex = 7
        '
        'EmployeeDTRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.LabelEmployeeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGEmployeeDTR)
        Me.Controls.Add(Me.btnTimeOut)
        Me.Controls.Add(Me.btnTimeIn)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeDTRForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Time Record Management System"
        CType(Me.DGEmployeeDTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeID As TextBox
    Friend WithEvents btnTimeIn As Button
    Friend WithEvents btnTimeOut As Button

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents DGEmployeeDTR As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelEmployeeName As Label
End Class
