<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Details
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
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim LAST_NAMELabel As System.Windows.Forms.Label
        Dim STUDENT_IDLabel As System.Windows.Forms.Label
        Dim DATE_OF_ADMLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim CLASSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Details))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.STUDENTS_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENTS_DETAILSTableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.STUDENTS_DETAILSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.STUDENTS_DETAILSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.STUDENTS_DETAILSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.STUDENT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_ADMTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.CLASSTextBox = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnStudentsRecordNavigationForm = New System.Windows.Forms.Button()
        Me.STUDENTS_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnStudentRecordNavigationForm = New System.Windows.Forms.Button()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        LAST_NAMELabel = New System.Windows.Forms.Label()
        STUDENT_IDLabel = New System.Windows.Forms.Label()
        DATE_OF_ADMLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        CLASSLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTS_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTS_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STUDENTS_DETAILSBindingNavigator.SuspendLayout()
        CType(Me.STUDENTS_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(12, 38)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(75, 13)
        FIRST_NAMELabel.TabIndex = 1
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'LAST_NAMELabel
        '
        LAST_NAMELabel.AutoSize = True
        LAST_NAMELabel.Location = New System.Drawing.Point(12, 64)
        LAST_NAMELabel.Name = "LAST_NAMELabel"
        LAST_NAMELabel.Size = New System.Drawing.Size(71, 13)
        LAST_NAMELabel.TabIndex = 3
        LAST_NAMELabel.Text = "LAST NAME:"
        '
        'STUDENT_IDLabel
        '
        STUDENT_IDLabel.AutoSize = True
        STUDENT_IDLabel.Location = New System.Drawing.Point(12, 90)
        STUDENT_IDLabel.Name = "STUDENT_IDLabel"
        STUDENT_IDLabel.Size = New System.Drawing.Size(76, 13)
        STUDENT_IDLabel.TabIndex = 5
        STUDENT_IDLabel.Text = "STUDENT ID:"
        '
        'DATE_OF_ADMLabel
        '
        DATE_OF_ADMLabel.AutoSize = True
        DATE_OF_ADMLabel.Location = New System.Drawing.Point(12, 116)
        DATE_OF_ADMLabel.Name = "DATE_OF_ADMLabel"
        DATE_OF_ADMLabel.Size = New System.Drawing.Size(83, 13)
        DATE_OF_ADMLabel.TabIndex = 7
        DATE_OF_ADMLabel.Text = "DATE OF ADM:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(12, 142)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 9
        DOBLabel.Text = "DOB:"
        '
        'CLASSLabel
        '
        CLASSLabel.AutoSize = True
        CLASSLabel.Location = New System.Drawing.Point(12, 168)
        CLASSLabel.Name = "CLASSLabel"
        CLASSLabel.Size = New System.Drawing.Size(44, 13)
        CLASSLabel.TabIndex = 11
        CLASSLabel.Text = "CLASS:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENTS_DETAILSBindingSource
        '
        Me.STUDENTS_DETAILSBindingSource.DataMember = "STUDENTS DETAILS"
        Me.STUDENTS_DETAILSBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'STUDENTS_DETAILSTableAdapter
        '
        Me.STUDENTS_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.HEAD_OF_DEPARTMENT_TABLETableAdapter = Nothing
        Me.TableAdapterManager.ITEMS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.REQUISITION_ORDER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STORES_TABLETableAdapter = Nothing
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Me.STUDENTS_DETAILSTableAdapter
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STUDENTS_DETAILSBindingNavigator
        '
        Me.STUDENTS_DETAILSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.STUDENTS_DETAILSBindingNavigator.BindingSource = Me.STUDENTS_DETAILSBindingSource
        Me.STUDENTS_DETAILSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.STUDENTS_DETAILSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.STUDENTS_DETAILSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.STUDENTS_DETAILSBindingNavigatorSaveItem})
        Me.STUDENTS_DETAILSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.STUDENTS_DETAILSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.STUDENTS_DETAILSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.STUDENTS_DETAILSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.STUDENTS_DETAILSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.STUDENTS_DETAILSBindingNavigator.Name = "STUDENTS_DETAILSBindingNavigator"
        Me.STUDENTS_DETAILSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.STUDENTS_DETAILSBindingNavigator.Size = New System.Drawing.Size(857, 25)
        Me.STUDENTS_DETAILSBindingNavigator.TabIndex = 0
        Me.STUDENTS_DETAILSBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'STUDENTS_DETAILSBindingNavigatorSaveItem
        '
        Me.STUDENTS_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.STUDENTS_DETAILSBindingNavigatorSaveItem.Image = CType(resources.GetObject("STUDENTS_DETAILSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.STUDENTS_DETAILSBindingNavigatorSaveItem.Name = "STUDENTS_DETAILSBindingNavigatorSaveItem"
        Me.STUDENTS_DETAILSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.STUDENTS_DETAILSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENTS_DETAILSBindingSource, "FIRST NAME", True))
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(101, 35)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.FIRST_NAMETextBox.TabIndex = 2
        '
        'LAST_NAMETextBox
        '
        Me.LAST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENTS_DETAILSBindingSource, "LAST NAME", True))
        Me.LAST_NAMETextBox.Location = New System.Drawing.Point(101, 61)
        Me.LAST_NAMETextBox.Name = "LAST_NAMETextBox"
        Me.LAST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.LAST_NAMETextBox.TabIndex = 4
        '
        'STUDENT_IDTextBox
        '
        Me.STUDENT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENTS_DETAILSBindingSource, "STUDENT ID", True))
        Me.STUDENT_IDTextBox.Location = New System.Drawing.Point(101, 87)
        Me.STUDENT_IDTextBox.Name = "STUDENT_IDTextBox"
        Me.STUDENT_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.STUDENT_IDTextBox.TabIndex = 6
        '
        'DATE_OF_ADMTextBox
        '
        Me.DATE_OF_ADMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENTS_DETAILSBindingSource, "DATE OF ADM", True))
        Me.DATE_OF_ADMTextBox.Location = New System.Drawing.Point(101, 113)
        Me.DATE_OF_ADMTextBox.Name = "DATE_OF_ADMTextBox"
        Me.DATE_OF_ADMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DATE_OF_ADMTextBox.TabIndex = 8
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENTS_DETAILSBindingSource, "DOB", True))
        Me.DOBTextBox.Location = New System.Drawing.Point(101, 139)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DOBTextBox.TabIndex = 10
        '
        'CLASSTextBox
        '
        Me.CLASSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENTS_DETAILSBindingSource, "CLASS", True))
        Me.CLASSTextBox.Location = New System.Drawing.Point(101, 165)
        Me.CLASSTextBox.Name = "CLASSTextBox"
        Me.CLASSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CLASSTextBox.TabIndex = 12
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(149, 358)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 38
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(283, 358)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 37
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(149, 287)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 36
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(283, 287)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 35
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(446, 287)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 34
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(23, 358)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 33
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(22, 287)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 32
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnStudentsRecordNavigationForm
        '
        Me.BtnStudentsRecordNavigationForm.Location = New System.Drawing.Point(589, 335)
        Me.BtnStudentsRecordNavigationForm.Name = "BtnStudentsRecordNavigationForm"
        Me.BtnStudentsRecordNavigationForm.Size = New System.Drawing.Size(130, 29)
        Me.BtnStudentsRecordNavigationForm.TabIndex = 31
        Me.BtnStudentsRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnStudentsRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'STUDENTS_DETAILSDataGridView
        '
        Me.STUDENTS_DETAILSDataGridView.AutoGenerateColumns = False
        Me.STUDENTS_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STUDENTS_DETAILSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.STUDENTS_DETAILSDataGridView.DataSource = Me.STUDENTS_DETAILSBindingSource
        Me.STUDENTS_DETAILSDataGridView.Location = New System.Drawing.Point(243, 35)
        Me.STUDENTS_DETAILSDataGridView.Name = "STUDENTS_DETAILSDataGridView"
        Me.STUDENTS_DETAILSDataGridView.Size = New System.Drawing.Size(602, 203)
        Me.STUDENTS_DETAILSDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FIRST NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FIRST NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LAST NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LAST NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "STUDENT ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "STUDENT ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DATE OF ADM"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DATE OF ADM"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CLASS"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CLASS"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'BtnStudentRecordNavigationForm
        '
        Me.BtnStudentRecordNavigationForm.Location = New System.Drawing.Point(589, 335)
        Me.BtnStudentRecordNavigationForm.Name = "BtnStudentRecordNavigationForm"
        Me.BtnStudentRecordNavigationForm.Size = New System.Drawing.Size(130, 29)
        Me.BtnStudentRecordNavigationForm.TabIndex = 31
        Me.BtnStudentRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnStudentRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'Student_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 402)
        Me.Controls.Add(Me.STUDENTS_DETAILSDataGridView)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnStudentsRecordNavigationForm)
        Me.Controls.Add(FIRST_NAMELabel)
        Me.Controls.Add(Me.FIRST_NAMETextBox)
        Me.Controls.Add(LAST_NAMELabel)
        Me.Controls.Add(Me.LAST_NAMETextBox)
        Me.Controls.Add(STUDENT_IDLabel)
        Me.Controls.Add(Me.STUDENT_IDTextBox)
        Me.Controls.Add(DATE_OF_ADMLabel)
        Me.Controls.Add(Me.DATE_OF_ADMTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBTextBox)
        Me.Controls.Add(CLASSLabel)
        Me.Controls.Add(Me.CLASSTextBox)
        Me.Controls.Add(Me.STUDENTS_DETAILSBindingNavigator)
        Me.Name = "Student_Details"
        Me.Text = "Student_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTS_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTS_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STUDENTS_DETAILSBindingNavigator.ResumeLayout(False)
        Me.STUDENTS_DETAILSBindingNavigator.PerformLayout()
        CType(Me.STUDENTS_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents STUDENTS_DETAILSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STUDENTS_DETAILSTableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.STUDENTS_DETAILSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STUDENTS_DETAILSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents STUDENTS_DETAILSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FIRST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LAST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents STUDENT_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_OF_ADMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CLASSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnStudentsRecordNavigationForm As System.Windows.Forms.Button
    Friend WithEvents STUDENTS_DETAILSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnStudentRecordNavigationForm As System.Windows.Forms.Button
End Class
