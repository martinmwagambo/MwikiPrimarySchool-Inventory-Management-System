<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category_Table
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
        Dim CATEGORY_NAMELabel As System.Windows.Forms.Label
        Dim CATEGORY_IDLabel As System.Windows.Forms.Label
        Dim DESCRIPTIONLabel As System.Windows.Forms.Label
        Dim CONSUMABLE_INVENTORYLabel As System.Windows.Forms.Label
        Dim EXPENDABLE_INVENTORYLabel As System.Windows.Forms.Label
        Dim PERMANENT_INVENTORYLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category_Table))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.CATEGORY_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATEGORY_TABLETableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.CATEGORY_TABLETableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.CATEGORY_TABLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CATEGORY_TABLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CATEGORY_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.CATEGORY_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPTIONTextBox = New System.Windows.Forms.TextBox()
        Me.CONSUMABLE_INVENTORYCheckBox = New System.Windows.Forms.CheckBox()
        Me.EXPENDABLE_INVENTORYCheckBox = New System.Windows.Forms.CheckBox()
        Me.PERMANENT_INVENTORYCheckBox = New System.Windows.Forms.CheckBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnCategoryRecordNavigationForm = New System.Windows.Forms.Button()
        Me.CATEGORY_TABLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CATEGORY_NAMELabel = New System.Windows.Forms.Label()
        CATEGORY_IDLabel = New System.Windows.Forms.Label()
        DESCRIPTIONLabel = New System.Windows.Forms.Label()
        CONSUMABLE_INVENTORYLabel = New System.Windows.Forms.Label()
        EXPENDABLE_INVENTORYLabel = New System.Windows.Forms.Label()
        PERMANENT_INVENTORYLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORY_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORY_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CATEGORY_TABLEBindingNavigator.SuspendLayout()
        CType(Me.CATEGORY_TABLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CATEGORY_NAMELabel
        '
        CATEGORY_NAMELabel.AutoSize = True
        CATEGORY_NAMELabel.Location = New System.Drawing.Point(12, 42)
        CATEGORY_NAMELabel.Name = "CATEGORY_NAMELabel"
        CATEGORY_NAMELabel.Size = New System.Drawing.Size(103, 13)
        CATEGORY_NAMELabel.TabIndex = 1
        CATEGORY_NAMELabel.Text = "CATEGORY NAME:"
        '
        'CATEGORY_IDLabel
        '
        CATEGORY_IDLabel.AutoSize = True
        CATEGORY_IDLabel.Location = New System.Drawing.Point(12, 68)
        CATEGORY_IDLabel.Name = "CATEGORY_IDLabel"
        CATEGORY_IDLabel.Size = New System.Drawing.Size(83, 13)
        CATEGORY_IDLabel.TabIndex = 3
        CATEGORY_IDLabel.Text = "CATEGORY ID:"
        '
        'DESCRIPTIONLabel
        '
        DESCRIPTIONLabel.AutoSize = True
        DESCRIPTIONLabel.Location = New System.Drawing.Point(12, 94)
        DESCRIPTIONLabel.Name = "DESCRIPTIONLabel"
        DESCRIPTIONLabel.Size = New System.Drawing.Size(83, 13)
        DESCRIPTIONLabel.TabIndex = 5
        DESCRIPTIONLabel.Text = "DESCRIPTION:"
        '
        'CONSUMABLE_INVENTORYLabel
        '
        CONSUMABLE_INVENTORYLabel.AutoSize = True
        CONSUMABLE_INVENTORYLabel.Location = New System.Drawing.Point(12, 122)
        CONSUMABLE_INVENTORYLabel.Name = "CONSUMABLE_INVENTORYLabel"
        CONSUMABLE_INVENTORYLabel.Size = New System.Drawing.Size(150, 13)
        CONSUMABLE_INVENTORYLabel.TabIndex = 7
        CONSUMABLE_INVENTORYLabel.Text = "CONSUMABLE INVENTORY:"
        '
        'EXPENDABLE_INVENTORYLabel
        '
        EXPENDABLE_INVENTORYLabel.AutoSize = True
        EXPENDABLE_INVENTORYLabel.Location = New System.Drawing.Point(12, 152)
        EXPENDABLE_INVENTORYLabel.Name = "EXPENDABLE_INVENTORYLabel"
        EXPENDABLE_INVENTORYLabel.Size = New System.Drawing.Size(147, 13)
        EXPENDABLE_INVENTORYLabel.TabIndex = 9
        EXPENDABLE_INVENTORYLabel.Text = "EXPENDABLE INVENTORY:"
        '
        'PERMANENT_INVENTORYLabel
        '
        PERMANENT_INVENTORYLabel.AutoSize = True
        PERMANENT_INVENTORYLabel.Location = New System.Drawing.Point(12, 182)
        PERMANENT_INVENTORYLabel.Name = "PERMANENT_INVENTORYLabel"
        PERMANENT_INVENTORYLabel.Size = New System.Drawing.Size(144, 13)
        PERMANENT_INVENTORYLabel.TabIndex = 11
        PERMANENT_INVENTORYLabel.Text = "PERMANENT INVENTORY:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CATEGORY_TABLEBindingSource
        '
        Me.CATEGORY_TABLEBindingSource.DataMember = "CATEGORY TABLE"
        Me.CATEGORY_TABLEBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'CATEGORY_TABLETableAdapter
        '
        Me.CATEGORY_TABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_TABLETableAdapter = Me.CATEGORY_TABLETableAdapter
        Me.TableAdapterManager.EQUIPMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.HEAD_OF_DEPARTMENT_TABLETableAdapter = Nothing
        Me.TableAdapterManager.ITEMS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.REQUISITION_ORDER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STORES_TABLETableAdapter = Nothing
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CATEGORY_TABLEBindingNavigator
        '
        Me.CATEGORY_TABLEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CATEGORY_TABLEBindingNavigator.BindingSource = Me.CATEGORY_TABLEBindingSource
        Me.CATEGORY_TABLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CATEGORY_TABLEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CATEGORY_TABLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CATEGORY_TABLEBindingNavigatorSaveItem})
        Me.CATEGORY_TABLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CATEGORY_TABLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CATEGORY_TABLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CATEGORY_TABLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CATEGORY_TABLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CATEGORY_TABLEBindingNavigator.Name = "CATEGORY_TABLEBindingNavigator"
        Me.CATEGORY_TABLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CATEGORY_TABLEBindingNavigator.Size = New System.Drawing.Size(978, 25)
        Me.CATEGORY_TABLEBindingNavigator.TabIndex = 0
        Me.CATEGORY_TABLEBindingNavigator.Text = "BindingNavigator1"
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
        'CATEGORY_TABLEBindingNavigatorSaveItem
        '
        Me.CATEGORY_TABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CATEGORY_TABLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("CATEGORY_TABLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CATEGORY_TABLEBindingNavigatorSaveItem.Name = "CATEGORY_TABLEBindingNavigatorSaveItem"
        Me.CATEGORY_TABLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CATEGORY_TABLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CATEGORY_NAMETextBox
        '
        Me.CATEGORY_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CATEGORY_TABLEBindingSource, "CATEGORY NAME", True))
        Me.CATEGORY_NAMETextBox.Location = New System.Drawing.Point(168, 39)
        Me.CATEGORY_NAMETextBox.Name = "CATEGORY_NAMETextBox"
        Me.CATEGORY_NAMETextBox.Size = New System.Drawing.Size(104, 20)
        Me.CATEGORY_NAMETextBox.TabIndex = 2
        '
        'CATEGORY_IDTextBox
        '
        Me.CATEGORY_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CATEGORY_TABLEBindingSource, "CATEGORY ID", True))
        Me.CATEGORY_IDTextBox.Location = New System.Drawing.Point(168, 65)
        Me.CATEGORY_IDTextBox.Name = "CATEGORY_IDTextBox"
        Me.CATEGORY_IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CATEGORY_IDTextBox.TabIndex = 4
        '
        'DESCRIPTIONTextBox
        '
        Me.DESCRIPTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CATEGORY_TABLEBindingSource, "DESCRIPTION", True))
        Me.DESCRIPTIONTextBox.Location = New System.Drawing.Point(168, 91)
        Me.DESCRIPTIONTextBox.Name = "DESCRIPTIONTextBox"
        Me.DESCRIPTIONTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DESCRIPTIONTextBox.TabIndex = 6
        '
        'CONSUMABLE_INVENTORYCheckBox
        '
        Me.CONSUMABLE_INVENTORYCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CATEGORY_TABLEBindingSource, "CONSUMABLE INVENTORY", True))
        Me.CONSUMABLE_INVENTORYCheckBox.Location = New System.Drawing.Point(168, 117)
        Me.CONSUMABLE_INVENTORYCheckBox.Name = "CONSUMABLE_INVENTORYCheckBox"
        Me.CONSUMABLE_INVENTORYCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.CONSUMABLE_INVENTORYCheckBox.TabIndex = 8
        Me.CONSUMABLE_INVENTORYCheckBox.UseVisualStyleBackColor = True
        '
        'EXPENDABLE_INVENTORYCheckBox
        '
        Me.EXPENDABLE_INVENTORYCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CATEGORY_TABLEBindingSource, "EXPENDABLE INVENTORY", True))
        Me.EXPENDABLE_INVENTORYCheckBox.Location = New System.Drawing.Point(168, 147)
        Me.EXPENDABLE_INVENTORYCheckBox.Name = "EXPENDABLE_INVENTORYCheckBox"
        Me.EXPENDABLE_INVENTORYCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EXPENDABLE_INVENTORYCheckBox.TabIndex = 10
        Me.EXPENDABLE_INVENTORYCheckBox.UseVisualStyleBackColor = True
        '
        'PERMANENT_INVENTORYCheckBox
        '
        Me.PERMANENT_INVENTORYCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CATEGORY_TABLEBindingSource, "PERMANENT INVENTORY", True))
        Me.PERMANENT_INVENTORYCheckBox.Location = New System.Drawing.Point(168, 177)
        Me.PERMANENT_INVENTORYCheckBox.Name = "PERMANENT_INVENTORYCheckBox"
        Me.PERMANENT_INVENTORYCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PERMANENT_INVENTORYCheckBox.TabIndex = 12
        Me.PERMANENT_INVENTORYCheckBox.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(144, 348)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 29
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(278, 348)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 28
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(144, 277)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 27
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(278, 277)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 26
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(412, 277)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 25
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(18, 348)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 24
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(17, 277)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 23
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnCategoryRecordNavigationForm
        '
        Me.BtnCategoryRecordNavigationForm.Location = New System.Drawing.Point(500, 349)
        Me.BtnCategoryRecordNavigationForm.Name = "BtnCategoryRecordNavigationForm"
        Me.BtnCategoryRecordNavigationForm.Size = New System.Drawing.Size(143, 23)
        Me.BtnCategoryRecordNavigationForm.TabIndex = 22
        Me.BtnCategoryRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnCategoryRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'CATEGORY_TABLEDataGridView
        '
        Me.CATEGORY_TABLEDataGridView.AutoGenerateColumns = False
        Me.CATEGORY_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CATEGORY_TABLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3})
        Me.CATEGORY_TABLEDataGridView.DataSource = Me.CATEGORY_TABLEBindingSource
        Me.CATEGORY_TABLEDataGridView.Location = New System.Drawing.Point(314, 39)
        Me.CATEGORY_TABLEDataGridView.Name = "CATEGORY_TABLEDataGridView"
        Me.CATEGORY_TABLEDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.CATEGORY_TABLEDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CATEGORY NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CATEGORY NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CATEGORY ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CATEGORY ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CONSUMABLE INVENTORY"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CONSUMABLE INVENTORY"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "EXPENDABLE INVENTORY"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "EXPENDABLE INVENTORY"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "PERMANENT INVENTORY"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "PERMANENT INVENTORY"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'Category_Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 396)
        Me.Controls.Add(Me.CATEGORY_TABLEDataGridView)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnCategoryRecordNavigationForm)
        Me.Controls.Add(CATEGORY_NAMELabel)
        Me.Controls.Add(Me.CATEGORY_NAMETextBox)
        Me.Controls.Add(CATEGORY_IDLabel)
        Me.Controls.Add(Me.CATEGORY_IDTextBox)
        Me.Controls.Add(DESCRIPTIONLabel)
        Me.Controls.Add(Me.DESCRIPTIONTextBox)
        Me.Controls.Add(CONSUMABLE_INVENTORYLabel)
        Me.Controls.Add(Me.CONSUMABLE_INVENTORYCheckBox)
        Me.Controls.Add(EXPENDABLE_INVENTORYLabel)
        Me.Controls.Add(Me.EXPENDABLE_INVENTORYCheckBox)
        Me.Controls.Add(PERMANENT_INVENTORYLabel)
        Me.Controls.Add(Me.PERMANENT_INVENTORYCheckBox)
        Me.Controls.Add(Me.CATEGORY_TABLEBindingNavigator)
        Me.Name = "Category_Table"
        Me.Text = "Category_Table"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORY_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORY_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CATEGORY_TABLEBindingNavigator.ResumeLayout(False)
        Me.CATEGORY_TABLEBindingNavigator.PerformLayout()
        CType(Me.CATEGORY_TABLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents CATEGORY_TABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CATEGORY_TABLETableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.CATEGORY_TABLETableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CATEGORY_TABLEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CATEGORY_TABLEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CATEGORY_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CATEGORY_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPTIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONSUMABLE_INVENTORYCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EXPENDABLE_INVENTORYCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PERMANENT_INVENTORYCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnCategoryRecordNavigationForm As System.Windows.Forms.Button
    Friend WithEvents CATEGORY_TABLEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
