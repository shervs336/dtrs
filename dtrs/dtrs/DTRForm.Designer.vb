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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DTRForm))
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim Time_InLabel As System.Windows.Forms.Label
        Dim Time_OutLabel As System.Windows.Forms.Label
        Dim Total_HoursLabel As System.Windows.Forms.Label
        Dim Shift_DateLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tbl_employee_loginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_employee_loginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Time_InDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Time_OutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Total_HoursTextBox = New System.Windows.Forms.TextBox()
        Me.Shift_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_employee_loginDataGridView = New System.Windows.Forms.DataGridView()
        Me.FillByEmployeeIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Employee_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Employee_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByEmployeeIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_employee_loginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database3SADDataSet = New dtrs.Database3SADDataSet()
        Me.Tbl_employee_loginTableAdapter = New dtrs.Database3SADDataSetTableAdapters.tbl_employee_loginTableAdapter()
        Me.TableAdapterManager = New dtrs.Database3SADDataSetTableAdapters.TableAdapterManager()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Time_InLabel = New System.Windows.Forms.Label()
        Time_OutLabel = New System.Windows.Forms.Label()
        Total_HoursLabel = New System.Windows.Forms.Label()
        Shift_DateLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_employee_loginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_employee_loginBindingNavigator.SuspendLayout()
        CType(Me.Tbl_employee_loginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByEmployeeIDToolStrip.SuspendLayout()
        CType(Me.Tbl_employee_loginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name :"
        '
        'FullNameLabel
        '
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameLabel.Location = New System.Drawing.Point(101, 66)
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
        Me.PositionLabel.Location = New System.Drawing.Point(101, 108)
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
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Position :"
        '
        'Tbl_employee_loginBindingNavigator
        '
        Me.Tbl_employee_loginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_employee_loginBindingNavigator.BindingSource = Me.Tbl_employee_loginBindingSource
        Me.Tbl_employee_loginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_employee_loginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_employee_loginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_employee_loginBindingNavigatorSaveItem})
        Me.Tbl_employee_loginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_employee_loginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_employee_loginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_employee_loginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_employee_loginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_employee_loginBindingNavigator.Name = "Tbl_employee_loginBindingNavigator"
        Me.Tbl_employee_loginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_employee_loginBindingNavigator.Size = New System.Drawing.Size(816, 25)
        Me.Tbl_employee_loginBindingNavigator.TabIndex = 8
        Me.Tbl_employee_loginBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tbl_employee_loginBindingNavigatorSaveItem
        '
        Me.Tbl_employee_loginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_employee_loginBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_employee_loginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_employee_loginBindingNavigatorSaveItem.Name = "Tbl_employee_loginBindingNavigatorSaveItem"
        Me.Tbl_employee_loginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_employee_loginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Location = New System.Drawing.Point(13, 145)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(70, 13)
        Employee_IDLabel.TabIndex = 8
        Employee_IDLabel.Text = "Employee ID:"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employee_loginBindingSource, "Employee_ID", True))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(89, 142)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Employee_IDTextBox.TabIndex = 9
        '
        'Time_InLabel
        '
        Time_InLabel.AutoSize = True
        Time_InLabel.Location = New System.Drawing.Point(13, 172)
        Time_InLabel.Name = "Time_InLabel"
        Time_InLabel.Size = New System.Drawing.Size(45, 13)
        Time_InLabel.TabIndex = 10
        Time_InLabel.Text = "Time In:"
        '
        'Time_InDateTimePicker
        '
        Me.Time_InDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_employee_loginBindingSource, "Time_In", True))
        Me.Time_InDateTimePicker.Location = New System.Drawing.Point(89, 168)
        Me.Time_InDateTimePicker.Name = "Time_InDateTimePicker"
        Me.Time_InDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Time_InDateTimePicker.TabIndex = 11
        '
        'Time_OutLabel
        '
        Time_OutLabel.AutoSize = True
        Time_OutLabel.Location = New System.Drawing.Point(13, 198)
        Time_OutLabel.Name = "Time_OutLabel"
        Time_OutLabel.Size = New System.Drawing.Size(53, 13)
        Time_OutLabel.TabIndex = 12
        Time_OutLabel.Text = "Time Out:"
        '
        'Time_OutDateTimePicker
        '
        Me.Time_OutDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_employee_loginBindingSource, "Time_Out", True))
        Me.Time_OutDateTimePicker.Location = New System.Drawing.Point(89, 194)
        Me.Time_OutDateTimePicker.Name = "Time_OutDateTimePicker"
        Me.Time_OutDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Time_OutDateTimePicker.TabIndex = 13
        '
        'Total_HoursLabel
        '
        Total_HoursLabel.AutoSize = True
        Total_HoursLabel.Location = New System.Drawing.Point(13, 223)
        Total_HoursLabel.Name = "Total_HoursLabel"
        Total_HoursLabel.Size = New System.Drawing.Size(65, 13)
        Total_HoursLabel.TabIndex = 14
        Total_HoursLabel.Text = "Total Hours:"
        '
        'Total_HoursTextBox
        '
        Me.Total_HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employee_loginBindingSource, "Total_Hours", True))
        Me.Total_HoursTextBox.Location = New System.Drawing.Point(89, 220)
        Me.Total_HoursTextBox.Name = "Total_HoursTextBox"
        Me.Total_HoursTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_HoursTextBox.TabIndex = 15
        '
        'Shift_DateLabel
        '
        Shift_DateLabel.AutoSize = True
        Shift_DateLabel.Location = New System.Drawing.Point(13, 250)
        Shift_DateLabel.Name = "Shift_DateLabel"
        Shift_DateLabel.Size = New System.Drawing.Size(57, 13)
        Shift_DateLabel.TabIndex = 16
        Shift_DateLabel.Text = "Shift Date:"
        '
        'Shift_DateDateTimePicker
        '
        Me.Shift_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_employee_loginBindingSource, "Shift_Date", True))
        Me.Shift_DateDateTimePicker.Location = New System.Drawing.Point(89, 246)
        Me.Shift_DateDateTimePicker.Name = "Shift_DateDateTimePicker"
        Me.Shift_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Shift_DateDateTimePicker.TabIndex = 17
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(13, 275)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 18
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_employee_loginBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(89, 272)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 19
        '
        'Tbl_employee_loginDataGridView
        '
        Me.Tbl_employee_loginDataGridView.AutoGenerateColumns = False
        Me.Tbl_employee_loginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_employee_loginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tbl_employee_loginDataGridView.DataSource = Me.Tbl_employee_loginBindingSource
        Me.Tbl_employee_loginDataGridView.Location = New System.Drawing.Point(306, 68)
        Me.Tbl_employee_loginDataGridView.Name = "Tbl_employee_loginDataGridView"
        Me.Tbl_employee_loginDataGridView.Size = New System.Drawing.Size(490, 499)
        Me.Tbl_employee_loginDataGridView.TabIndex = 19
        '
        'FillByEmployeeIDToolStrip
        '
        Me.FillByEmployeeIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Employee_IDToolStripLabel, Me.Employee_IDToolStripTextBox, Me.FillByEmployeeIDToolStripButton})
        Me.FillByEmployeeIDToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByEmployeeIDToolStrip.Name = "FillByEmployeeIDToolStrip"
        Me.FillByEmployeeIDToolStrip.Size = New System.Drawing.Size(816, 25)
        Me.FillByEmployeeIDToolStrip.TabIndex = 20
        Me.FillByEmployeeIDToolStrip.Text = "FillByEmployeeIDToolStrip"
        '
        'Employee_IDToolStripLabel
        '
        Me.Employee_IDToolStripLabel.Name = "Employee_IDToolStripLabel"
        Me.Employee_IDToolStripLabel.Size = New System.Drawing.Size(78, 22)
        Me.Employee_IDToolStripLabel.Text = "Employee_ID:"
        '
        'Employee_IDToolStripTextBox
        '
        Me.Employee_IDToolStripTextBox.Name = "Employee_IDToolStripTextBox"
        Me.Employee_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByEmployeeIDToolStripButton
        '
        Me.FillByEmployeeIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByEmployeeIDToolStripButton.Name = "FillByEmployeeIDToolStripButton"
        Me.FillByEmployeeIDToolStripButton.Size = New System.Drawing.Size(102, 22)
        Me.FillByEmployeeIDToolStripButton.Text = "FillByEmployeeID"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Time_In"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Time_In"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Time_Out"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Time_Out"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Total_Hours"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total_Hours"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Shift_Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Shift_Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Tbl_employee_loginBindingSource
        '
        Me.Tbl_employee_loginBindingSource.DataMember = "tbl_employee_login"
        Me.Tbl_employee_loginBindingSource.DataSource = Me.Database3SADDataSet
        '
        'Database3SADDataSet
        '
        Me.Database3SADDataSet.DataSetName = "Database3SADDataSet"
        Me.Database3SADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_employee_loginTableAdapter
        '
        Me.Tbl_employee_loginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_adminsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_employee_loginTableAdapter = Me.Tbl_employee_loginTableAdapter
        Me.TableAdapterManager.tbl_employeesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_payroll_periodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_positionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_salaryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = dtrs.Database3SADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DTRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 570)
        Me.Controls.Add(Me.FillByEmployeeIDToolStrip)
        Me.Controls.Add(Me.Tbl_employee_loginDataGridView)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Time_InLabel)
        Me.Controls.Add(Me.Time_InDateTimePicker)
        Me.Controls.Add(Time_OutLabel)
        Me.Controls.Add(Me.Time_OutDateTimePicker)
        Me.Controls.Add(Total_HoursLabel)
        Me.Controls.Add(Me.Total_HoursTextBox)
        Me.Controls.Add(Shift_DateLabel)
        Me.Controls.Add(Me.Shift_DateDateTimePicker)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Tbl_employee_loginBindingNavigator)
        Me.Controls.Add(Me.PositionLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FullNameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DTRForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Tbl_employee_loginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_employee_loginBindingNavigator.ResumeLayout(False)
        Me.Tbl_employee_loginBindingNavigator.PerformLayout()
        CType(Me.Tbl_employee_loginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByEmployeeIDToolStrip.ResumeLayout(False)
        Me.FillByEmployeeIDToolStrip.PerformLayout()
        CType(Me.Tbl_employee_loginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database3SADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database3SADDataSet As Database3SADDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents PositionLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tbl_employee_loginBindingSource As BindingSource
    Friend WithEvents Tbl_employee_loginTableAdapter As Database3SADDataSetTableAdapters.tbl_employee_loginTableAdapter
    Friend WithEvents TableAdapterManager As Database3SADDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_employee_loginBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_employee_loginBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Employee_IDTextBox As TextBox
    Friend WithEvents Time_InDateTimePicker As DateTimePicker
    Friend WithEvents Time_OutDateTimePicker As DateTimePicker
    Friend WithEvents Total_HoursTextBox As TextBox
    Friend WithEvents Shift_DateDateTimePicker As DateTimePicker
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Tbl_employee_loginDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FillByEmployeeIDToolStrip As ToolStrip
    Friend WithEvents Employee_IDToolStripLabel As ToolStripLabel
    Friend WithEvents Employee_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByEmployeeIDToolStripButton As ToolStripButton
End Class
