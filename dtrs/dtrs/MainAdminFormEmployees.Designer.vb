<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainAdminFormEmployees
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Date_HiredLabel As System.Windows.Forms.Label
        Dim RateLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Database3SADDataSet = New dtrs.Database3SADDataSet()
        Me.Tbl_positionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewDTRButton = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New dtrs.Database3SADDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_positionsTableAdapter = New dtrs.Database3SADDataSetTableAdapters.tbl_positionsTableAdapter()
        Me.Tbl_employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_employeesTableAdapter = New dtrs.Database3SADDataSetTableAdapters.tbl_employeesTableAdapter()
        Me.Tbl_employeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Date_HiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RateTextBox = New System.Windows.Forms.TextBox()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Date_HiredLabel = New System.Windows.Forms.Label()
        RateLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_positionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_employeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 67)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 20
        IDLabel.Text = "ID:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Location = New System.Drawing.Point(12, 93)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(57, 13)
        Full_NameLabel.TabIndex = 22
        Full_NameLabel.Text = "Full Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 119)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 24
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(12, 145)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 26
        PhoneLabel.Text = "Phone:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(12, 171)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 28
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(12, 197)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 30
        AgeLabel.Text = "Age:"
        '
        'Date_HiredLabel
        '
        Date_HiredLabel.AutoSize = True
        Date_HiredLabel.Location = New System.Drawing.Point(12, 250)
        Date_HiredLabel.Name = "Date_HiredLabel"
        Date_HiredLabel.Size = New System.Drawing.Size(61, 13)
        Date_HiredLabel.TabIndex = 34
        Date_HiredLabel.Text = "Date Hired:"
        '
        'RateLabel
        '
        RateLabel.AutoSize = True
        RateLabel.Location = New System.Drawing.Point(12, 275)
        RateLabel.Name = "RateLabel"
        RateLabel.Size = New System.Drawing.Size(33, 13)
        RateLabel.TabIndex = 36
        RateLabel.Text = "Rate:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(13, 223)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 39
        PositionLabel.Text = "Position:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem, Me.PositionsToolStripMenuItem, Me.AdminsToolStripMenuItem, Me.SalaryToolStripMenuItem, Me.PayrollPeriodToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(840, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        '
        'PositionsToolStripMenuItem
        '
        Me.PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem"
        Me.PositionsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PositionsToolStripMenuItem.Text = "Positions"
        '
        'AdminsToolStripMenuItem
        '
        Me.AdminsToolStripMenuItem.Name = "AdminsToolStripMenuItem"
        Me.AdminsToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AdminsToolStripMenuItem.Text = "Admins"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SalaryToolStripMenuItem.Text = "Salary"
        '
        'PayrollPeriodToolStripMenuItem
        '
        Me.PayrollPeriodToolStripMenuItem.Name = "PayrollPeriodToolStripMenuItem"
        Me.PayrollPeriodToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.PayrollPeriodToolStripMenuItem.Text = "Payroll Period"
        '
        'Database3SADDataSet
        '
        Me.Database3SADDataSet.DataSetName = "Database3SADDataSet"
        Me.Database3SADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_positionsBindingSource
        '
        Me.Tbl_positionsBindingSource.DataMember = "tbl_positions"
        Me.Tbl_positionsBindingSource.DataSource = Me.Database3SADDataSet
        '
        'ViewDTRButton
        '
        Me.ViewDTRButton.Location = New System.Drawing.Point(79, 307)
        Me.ViewDTRButton.Name = "ViewDTRButton"
        Me.ViewDTRButton.Size = New System.Drawing.Size(75, 23)
        Me.ViewDTRButton.TabIndex = 20
        Me.ViewDTRButton.Text = "View DTR"
        Me.ViewDTRButton.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_adminsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_employee_loginTableAdapter = Nothing
        Me.TableAdapterManager.tbl_employeesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_payroll_periodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_positionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_salaryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = dtrs.Database3SADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_positionsTableAdapter
        '
        Me.Tbl_positionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_employeesBindingSource
        '
        Me.Tbl_employeesBindingSource.DataMember = "tbl_employees"
        Me.Tbl_employeesBindingSource.DataSource = Me.Database3SADDataSet
        '
        'Tbl_employeesTableAdapter
        '
        Me.Tbl_employeesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_employeesDataGridView
        '
        Me.Tbl_employeesDataGridView.AutoGenerateColumns = False
        Me.Tbl_employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_employeesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewComboBoxColumn, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Tbl_employeesDataGridView.DataSource = Me.Tbl_employeesBindingSource
        Me.Tbl_employeesDataGridView.Location = New System.Drawing.Point(290, 67)
        Me.Tbl_employeesDataGridView.Name = "Tbl_employeesDataGridView"
        Me.Tbl_employeesDataGridView.Size = New System.Drawing.Size(535, 561)
        Me.Tbl_employeesDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Full_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewComboBoxColumn
        '
        Me.DataGridViewComboBoxColumn.DataPropertyName = "Position"
        Me.DataGridViewComboBoxColumn.DataSource = Me.Tbl_positionsBindingSource
        Me.DataGridViewComboBoxColumn.DisplayMember = "description"
        Me.DataGridViewComboBoxColumn.HeaderText = "Position"
        Me.DataGridViewComboBoxColumn.Name = "DataGridViewComboBoxColumn"
        Me.DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn.ValueMember = "description"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Date_Hired"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date_Hired"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Rate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(79, 64)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 21
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "Full_Name", True))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(79, 90)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Full_NameTextBox.TabIndex = 23
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(79, 116)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 25
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(79, 142)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 27
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(79, 168)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 29
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(79, 194)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgeTextBox.TabIndex = 31
        '
        'Date_HiredDateTimePicker
        '
        Me.Date_HiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_employeesBindingSource, "Date_Hired", True))
        Me.Date_HiredDateTimePicker.Location = New System.Drawing.Point(79, 246)
        Me.Date_HiredDateTimePicker.Name = "Date_HiredDateTimePicker"
        Me.Date_HiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_HiredDateTimePicker.TabIndex = 35
        '
        'RateTextBox
        '
        Me.RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "Rate", True))
        Me.RateTextBox.Location = New System.Drawing.Point(79, 272)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RateTextBox.TabIndex = 37
        '
        'PositionComboBox
        '
        Me.PositionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employeesBindingSource, "Position", True))
        Me.PositionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_employeesBindingSource, "Position", True))
        Me.PositionComboBox.DataSource = Me.Tbl_positionsBindingSource
        Me.PositionComboBox.DisplayMember = "description"
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Location = New System.Drawing.Point(79, 219)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PositionComboBox.TabIndex = 40
        Me.PositionComboBox.ValueMember = "description"
        '
        'MainAdminFormEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 714)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionComboBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Date_HiredLabel)
        Me.Controls.Add(Me.Date_HiredDateTimePicker)
        Me.Controls.Add(RateLabel)
        Me.Controls.Add(Me.RateTextBox)
        Me.Controls.Add(Me.Tbl_employeesDataGridView)
        Me.Controls.Add(Me.ViewDTRButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MainAdminFormEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin - Daily Time Record Management System - Employees"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_positionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_employeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PositionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Database3SADDataSet As Database3SADDataSet
    Friend WithEvents TableAdapterManager As Database3SADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_positionsBindingSource As BindingSource
    Friend WithEvents Tbl_positionsTableAdapter As Database3SADDataSetTableAdapters.tbl_positionsTableAdapter
    Friend WithEvents ViewDTRButton As Button
    Friend WithEvents Tbl_employeesBindingSource As BindingSource
    Friend WithEvents Tbl_employeesTableAdapter As Database3SADDataSetTableAdapters.tbl_employeesTableAdapter
    Friend WithEvents Tbl_employeesDataGridView As DataGridView
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents Date_HiredDateTimePicker As DateTimePicker
    Friend WithEvents RateTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents PositionComboBox As ComboBox
    Friend WithEvents PayrollPeriodToolStripMenuItem As ToolStripMenuItem
End Class
