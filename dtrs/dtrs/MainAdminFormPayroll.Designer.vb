<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainAdminFormPayroll
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainAdminFormPayroll))
        Dim IDLabel As System.Windows.Forms.Label
        Dim Start_PeriodLabel As System.Windows.Forms.Label
        Dim End_PeriodLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Database3SADDataSet = New dtrs.Database3SADDataSet()
        Me.Tbl_payroll_periodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_payroll_periodTableAdapter = New dtrs.Database3SADDataSetTableAdapters.tbl_payroll_periodTableAdapter()
        Me.TableAdapterManager = New dtrs.Database3SADDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_payroll_periodBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_payroll_periodBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_payroll_periodDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Start_PeriodDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_PeriodDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IDLabel = New System.Windows.Forms.Label()
        Start_PeriodLabel = New System.Windows.Forms.Label()
        End_PeriodLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_payroll_periodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_payroll_periodBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_payroll_periodBindingNavigator.SuspendLayout()
        CType(Me.Tbl_payroll_periodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem, Me.PositionsToolStripMenuItem, Me.AdminsToolStripMenuItem, Me.SalaryToolStripMenuItem, Me.PayrollPeriodToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'Tbl_payroll_periodBindingSource
        '
        Me.Tbl_payroll_periodBindingSource.DataMember = "tbl_payroll_period"
        Me.Tbl_payroll_periodBindingSource.DataSource = Me.Database3SADDataSet
        '
        'Tbl_payroll_periodTableAdapter
        '
        Me.Tbl_payroll_periodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_adminsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_employee_loginTableAdapter = Nothing
        Me.TableAdapterManager.tbl_employeesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_payroll_periodTableAdapter = Me.Tbl_payroll_periodTableAdapter
        Me.TableAdapterManager.tbl_positionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_salaryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = dtrs.Database3SADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_payroll_periodBindingNavigator
        '
        Me.Tbl_payroll_periodBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_payroll_periodBindingNavigator.BindingSource = Me.Tbl_payroll_periodBindingSource
        Me.Tbl_payroll_periodBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_payroll_periodBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_payroll_periodBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_payroll_periodBindingNavigatorSaveItem})
        Me.Tbl_payroll_periodBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.Tbl_payroll_periodBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_payroll_periodBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_payroll_periodBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_payroll_periodBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_payroll_periodBindingNavigator.Name = "Tbl_payroll_periodBindingNavigator"
        Me.Tbl_payroll_periodBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_payroll_periodBindingNavigator.Size = New System.Drawing.Size(808, 25)
        Me.Tbl_payroll_periodBindingNavigator.TabIndex = 3
        Me.Tbl_payroll_periodBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tbl_payroll_periodBindingNavigatorSaveItem
        '
        Me.Tbl_payroll_periodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_payroll_periodBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_payroll_periodBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_payroll_periodBindingNavigatorSaveItem.Name = "Tbl_payroll_periodBindingNavigatorSaveItem"
        Me.Tbl_payroll_periodBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tbl_payroll_periodBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_payroll_periodDataGridView
        '
        Me.Tbl_payroll_periodDataGridView.AutoGenerateColumns = False
        Me.Tbl_payroll_periodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_payroll_periodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Tbl_payroll_periodDataGridView.DataSource = Me.Tbl_payroll_periodBindingSource
        Me.Tbl_payroll_periodDataGridView.Location = New System.Drawing.Point(298, 78)
        Me.Tbl_payroll_periodDataGridView.Name = "Tbl_payroll_periodDataGridView"
        Me.Tbl_payroll_periodDataGridView.Size = New System.Drawing.Size(490, 360)
        Me.Tbl_payroll_periodDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Start_Period"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Start_Period"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "End_Period"
        Me.DataGridViewTextBoxColumn3.HeaderText = "End_Period"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 81)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_payroll_periodBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(83, 78)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 4
        '
        'Start_PeriodLabel
        '
        Start_PeriodLabel.AutoSize = True
        Start_PeriodLabel.Location = New System.Drawing.Point(12, 108)
        Start_PeriodLabel.Name = "Start_PeriodLabel"
        Start_PeriodLabel.Size = New System.Drawing.Size(65, 13)
        Start_PeriodLabel.TabIndex = 5
        Start_PeriodLabel.Text = "Start Period:"
        '
        'Start_PeriodDateTimePicker
        '
        Me.Start_PeriodDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_payroll_periodBindingSource, "Start_Period", True))
        Me.Start_PeriodDateTimePicker.Location = New System.Drawing.Point(83, 104)
        Me.Start_PeriodDateTimePicker.Name = "Start_PeriodDateTimePicker"
        Me.Start_PeriodDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Start_PeriodDateTimePicker.TabIndex = 6
        '
        'End_PeriodLabel
        '
        End_PeriodLabel.AutoSize = True
        End_PeriodLabel.Location = New System.Drawing.Point(12, 134)
        End_PeriodLabel.Name = "End_PeriodLabel"
        End_PeriodLabel.Size = New System.Drawing.Size(62, 13)
        End_PeriodLabel.TabIndex = 7
        End_PeriodLabel.Text = "End Period:"
        '
        'End_PeriodDateTimePicker
        '
        Me.End_PeriodDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_payroll_periodBindingSource, "End_Period", True))
        Me.End_PeriodDateTimePicker.Location = New System.Drawing.Point(83, 130)
        Me.End_PeriodDateTimePicker.Name = "End_PeriodDateTimePicker"
        Me.End_PeriodDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.End_PeriodDateTimePicker.TabIndex = 8
        '
        'MainAdminFormPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 458)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Start_PeriodLabel)
        Me.Controls.Add(Me.Start_PeriodDateTimePicker)
        Me.Controls.Add(End_PeriodLabel)
        Me.Controls.Add(Me.End_PeriodDateTimePicker)
        Me.Controls.Add(Me.Tbl_payroll_periodDataGridView)
        Me.Controls.Add(Me.Tbl_payroll_periodBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MainAdminFormPayroll"
        Me.Text = "MainAdminFormPayroll"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_payroll_periodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_payroll_periodBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_payroll_periodBindingNavigator.ResumeLayout(False)
        Me.Tbl_payroll_periodBindingNavigator.PerformLayout()
        CType(Me.Tbl_payroll_periodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PositionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollPeriodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Database3SADDataSet As Database3SADDataSet
    Friend WithEvents Tbl_payroll_periodBindingSource As BindingSource
    Friend WithEvents Tbl_payroll_periodTableAdapter As Database3SADDataSetTableAdapters.tbl_payroll_periodTableAdapter
    Friend WithEvents TableAdapterManager As Database3SADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_payroll_periodBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_payroll_periodBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_payroll_periodDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Start_PeriodDateTimePicker As DateTimePicker
    Friend WithEvents End_PeriodDateTimePicker As DateTimePicker
End Class
