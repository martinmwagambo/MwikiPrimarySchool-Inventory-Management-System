<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items_Details
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
        Dim ITEM_NAMELabel As System.Windows.Forms.Label
        Dim ITEM_IDLabel As System.Windows.Forms.Label
        Dim SUPPLIER_IDLabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim UNITS_IN_STOCKLabel As System.Windows.Forms.Label
        Dim UNITS_ON_ORDERLabel As System.Windows.Forms.Label
        Dim QUANTITY_PER_UNITLabel As System.Windows.Forms.Label
        Dim CATEGORY_IDLabel As System.Windows.Forms.Label
        Dim DESCRIPTIONLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items_Details))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.ITEMS_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ITEMS_DETAILSTableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.ITEMS_DETAILSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.ITEMS_DETAILSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ITEMS_DETAILSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ITEM_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.ITEM_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SUPPLIER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.UNITS_IN_STOCKTextBox = New System.Windows.Forms.TextBox()
        Me.UNITS_ON_ORDERTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITY_PER_UNITTextBox = New System.Windows.Forms.TextBox()
        Me.CATEGORY_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPTIONTextBox = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnItemRecordNavigationForm = New System.Windows.Forms.Button()
        Me.ITEMS_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ITEM_NAMELabel = New System.Windows.Forms.Label()
        ITEM_IDLabel = New System.Windows.Forms.Label()
        SUPPLIER_IDLabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        UNITS_IN_STOCKLabel = New System.Windows.Forms.Label()
        UNITS_ON_ORDERLabel = New System.Windows.Forms.Label()
        QUANTITY_PER_UNITLabel = New System.Windows.Forms.Label()
        CATEGORY_IDLabel = New System.Windows.Forms.Label()
        DESCRIPTIONLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITEMS_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITEMS_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ITEMS_DETAILSBindingNavigator.SuspendLayout()
        CType(Me.ITEMS_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ITEM_NAMELabel
        '
        ITEM_NAMELabel.AutoSize = True
        ITEM_NAMELabel.Location = New System.Drawing.Point(12, 50)
        ITEM_NAMELabel.Name = "ITEM_NAMELabel"
        ITEM_NAMELabel.Size = New System.Drawing.Size(70, 13)
        ITEM_NAMELabel.TabIndex = 1
        ITEM_NAMELabel.Text = "ITEM NAME:"
        '
        'ITEM_IDLabel
        '
        ITEM_IDLabel.AutoSize = True
        ITEM_IDLabel.Location = New System.Drawing.Point(12, 76)
        ITEM_IDLabel.Name = "ITEM_IDLabel"
        ITEM_IDLabel.Size = New System.Drawing.Size(50, 13)
        ITEM_IDLabel.TabIndex = 3
        ITEM_IDLabel.Text = "ITEM ID:"
        '
        'SUPPLIER_IDLabel
        '
        SUPPLIER_IDLabel.AutoSize = True
        SUPPLIER_IDLabel.Location = New System.Drawing.Point(12, 102)
        SUPPLIER_IDLabel.Name = "SUPPLIER_IDLabel"
        SUPPLIER_IDLabel.Size = New System.Drawing.Size(77, 13)
        SUPPLIER_IDLabel.TabIndex = 5
        SUPPLIER_IDLabel.Text = "SUPPLIER ID:"
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(12, 128)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(71, 13)
        UNIT_PRICELabel.TabIndex = 7
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'UNITS_IN_STOCKLabel
        '
        UNITS_IN_STOCKLabel.AutoSize = True
        UNITS_IN_STOCKLabel.Location = New System.Drawing.Point(12, 154)
        UNITS_IN_STOCKLabel.Name = "UNITS_IN_STOCKLabel"
        UNITS_IN_STOCKLabel.Size = New System.Drawing.Size(96, 13)
        UNITS_IN_STOCKLabel.TabIndex = 9
        UNITS_IN_STOCKLabel.Text = "UNITS IN STOCK:"
        '
        'UNITS_ON_ORDERLabel
        '
        UNITS_ON_ORDERLabel.AutoSize = True
        UNITS_ON_ORDERLabel.Location = New System.Drawing.Point(12, 180)
        UNITS_ON_ORDERLabel.Name = "UNITS_ON_ORDERLabel"
        UNITS_ON_ORDERLabel.Size = New System.Drawing.Size(104, 13)
        UNITS_ON_ORDERLabel.TabIndex = 11
        UNITS_ON_ORDERLabel.Text = "UNITS ON ORDER:"
        '
        'QUANTITY_PER_UNITLabel
        '
        QUANTITY_PER_UNITLabel.AutoSize = True
        QUANTITY_PER_UNITLabel.Location = New System.Drawing.Point(12, 206)
        QUANTITY_PER_UNITLabel.Name = "QUANTITY_PER_UNITLabel"
        QUANTITY_PER_UNITLabel.Size = New System.Drawing.Size(119, 13)
        QUANTITY_PER_UNITLabel.TabIndex = 13
        QUANTITY_PER_UNITLabel.Text = "QUANTITY PER UNIT:"
        '
        'CATEGORY_IDLabel
        '
        CATEGORY_IDLabel.AutoSize = True
        CATEGORY_IDLabel.Location = New System.Drawing.Point(12, 232)
        CATEGORY_IDLabel.Name = "CATEGORY_IDLabel"
        CATEGORY_IDLabel.Size = New System.Drawing.Size(83, 13)
        CATEGORY_IDLabel.TabIndex = 15
        CATEGORY_IDLabel.Text = "CATEGORY ID:"
        '
        'DESCRIPTIONLabel
        '
        DESCRIPTIONLabel.AutoSize = True
        DESCRIPTIONLabel.Location = New System.Drawing.Point(12, 258)
        DESCRIPTIONLabel.Name = "DESCRIPTIONLabel"
        DESCRIPTIONLabel.Size = New System.Drawing.Size(83, 13)
        DESCRIPTIONLabel.TabIndex = 17
        DESCRIPTIONLabel.Text = "DESCRIPTION:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ITEMS_DETAILSBindingSource
        '
        Me.ITEMS_DETAILSBindingSource.DataMember = "ITEMS DETAILS"
        Me.ITEMS_DETAILSBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'ITEMS_DETAILSTableAdapter
        '
        Me.ITEMS_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.HEAD_OF_DEPARTMENT_TABLETableAdapter = Nothing
        Me.TableAdapterManager.ITEMS_DETAILSTableAdapter = Me.ITEMS_DETAILSTableAdapter
        Me.TableAdapterManager.REQUISITION_ORDER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STORES_TABLETableAdapter = Nothing
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ITEMS_DETAILSBindingNavigator
        '
        Me.ITEMS_DETAILSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ITEMS_DETAILSBindingNavigator.BindingSource = Me.ITEMS_DETAILSBindingSource
        Me.ITEMS_DETAILSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ITEMS_DETAILSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ITEMS_DETAILSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ITEMS_DETAILSBindingNavigatorSaveItem})
        Me.ITEMS_DETAILSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ITEMS_DETAILSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ITEMS_DETAILSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ITEMS_DETAILSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ITEMS_DETAILSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ITEMS_DETAILSBindingNavigator.Name = "ITEMS_DETAILSBindingNavigator"
        Me.ITEMS_DETAILSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ITEMS_DETAILSBindingNavigator.Size = New System.Drawing.Size(852, 25)
        Me.ITEMS_DETAILSBindingNavigator.TabIndex = 0
        Me.ITEMS_DETAILSBindingNavigator.Text = "BindingNavigator1"
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
        'ITEMS_DETAILSBindingNavigatorSaveItem
        '
        Me.ITEMS_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ITEMS_DETAILSBindingNavigatorSaveItem.Image = CType(resources.GetObject("ITEMS_DETAILSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ITEMS_DETAILSBindingNavigatorSaveItem.Name = "ITEMS_DETAILSBindingNavigatorSaveItem"
        Me.ITEMS_DETAILSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ITEMS_DETAILSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ITEM_NAMETextBox
        '
        Me.ITEM_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "ITEM NAME", True))
        Me.ITEM_NAMETextBox.Location = New System.Drawing.Point(137, 47)
        Me.ITEM_NAMETextBox.Name = "ITEM_NAMETextBox"
        Me.ITEM_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEM_NAMETextBox.TabIndex = 2
        '
        'ITEM_IDTextBox
        '
        Me.ITEM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "ITEM ID", True))
        Me.ITEM_IDTextBox.Location = New System.Drawing.Point(137, 73)
        Me.ITEM_IDTextBox.Name = "ITEM_IDTextBox"
        Me.ITEM_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEM_IDTextBox.TabIndex = 4
        '
        'SUPPLIER_IDTextBox
        '
        Me.SUPPLIER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "SUPPLIER ID", True))
        Me.SUPPLIER_IDTextBox.Location = New System.Drawing.Point(137, 99)
        Me.SUPPLIER_IDTextBox.Name = "SUPPLIER_IDTextBox"
        Me.SUPPLIER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUPPLIER_IDTextBox.TabIndex = 6
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(137, 125)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNIT_PRICETextBox.TabIndex = 8
        '
        'UNITS_IN_STOCKTextBox
        '
        Me.UNITS_IN_STOCKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "UNITS IN STOCK", True))
        Me.UNITS_IN_STOCKTextBox.Location = New System.Drawing.Point(137, 151)
        Me.UNITS_IN_STOCKTextBox.Name = "UNITS_IN_STOCKTextBox"
        Me.UNITS_IN_STOCKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNITS_IN_STOCKTextBox.TabIndex = 10
        '
        'UNITS_ON_ORDERTextBox
        '
        Me.UNITS_ON_ORDERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "UNITS ON ORDER", True))
        Me.UNITS_ON_ORDERTextBox.Location = New System.Drawing.Point(137, 177)
        Me.UNITS_ON_ORDERTextBox.Name = "UNITS_ON_ORDERTextBox"
        Me.UNITS_ON_ORDERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNITS_ON_ORDERTextBox.TabIndex = 12
        '
        'QUANTITY_PER_UNITTextBox
        '
        Me.QUANTITY_PER_UNITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "QUANTITY PER UNIT", True))
        Me.QUANTITY_PER_UNITTextBox.Location = New System.Drawing.Point(137, 203)
        Me.QUANTITY_PER_UNITTextBox.Name = "QUANTITY_PER_UNITTextBox"
        Me.QUANTITY_PER_UNITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITY_PER_UNITTextBox.TabIndex = 14
        '
        'CATEGORY_IDTextBox
        '
        Me.CATEGORY_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "CATEGORY ID", True))
        Me.CATEGORY_IDTextBox.Location = New System.Drawing.Point(137, 229)
        Me.CATEGORY_IDTextBox.Name = "CATEGORY_IDTextBox"
        Me.CATEGORY_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CATEGORY_IDTextBox.TabIndex = 16
        '
        'DESCRIPTIONTextBox
        '
        Me.DESCRIPTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ITEMS_DETAILSBindingSource, "DESCRIPTION", True))
        Me.DESCRIPTIONTextBox.Location = New System.Drawing.Point(137, 255)
        Me.DESCRIPTIONTextBox.Name = "DESCRIPTIONTextBox"
        Me.DESCRIPTIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DESCRIPTIONTextBox.TabIndex = 18
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(142, 365)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 38
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(276, 365)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 37
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(142, 294)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 36
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(276, 294)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 35
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(425, 294)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 34
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(16, 365)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 33
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(15, 294)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 32
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnItemRecordNavigationForm
        '
        Me.BtnItemRecordNavigationForm.Location = New System.Drawing.Point(513, 339)
        Me.BtnItemRecordNavigationForm.Name = "BtnItemRecordNavigationForm"
        Me.BtnItemRecordNavigationForm.Size = New System.Drawing.Size(156, 25)
        Me.BtnItemRecordNavigationForm.TabIndex = 31
        Me.BtnItemRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnItemRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'ITEMS_DETAILSDataGridView
        '
        Me.ITEMS_DETAILSDataGridView.AutoGenerateColumns = False
        Me.ITEMS_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ITEMS_DETAILSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ITEMS_DETAILSDataGridView.DataSource = Me.ITEMS_DETAILSBindingSource
        Me.ITEMS_DETAILSDataGridView.Location = New System.Drawing.Point(297, 47)
        Me.ITEMS_DETAILSDataGridView.Name = "ITEMS_DETAILSDataGridView"
        Me.ITEMS_DETAILSDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.ITEMS_DETAILSDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ITEM NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ITEM NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ITEM ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ITEM ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SUPPLIER ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SUPPLIER ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UNITS IN STOCK"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UNITS IN STOCK"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UNITS ON ORDER"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UNITS ON ORDER"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QUANTITY PER UNIT"
        Me.DataGridViewTextBoxColumn7.HeaderText = "QUANTITY PER UNIT"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CATEGORY ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CATEGORY ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Items_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(852, 417)
        Me.Controls.Add(Me.ITEMS_DETAILSDataGridView)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnItemRecordNavigationForm)
        Me.Controls.Add(ITEM_NAMELabel)
        Me.Controls.Add(Me.ITEM_NAMETextBox)
        Me.Controls.Add(ITEM_IDLabel)
        Me.Controls.Add(Me.ITEM_IDTextBox)
        Me.Controls.Add(SUPPLIER_IDLabel)
        Me.Controls.Add(Me.SUPPLIER_IDTextBox)
        Me.Controls.Add(UNIT_PRICELabel)
        Me.Controls.Add(Me.UNIT_PRICETextBox)
        Me.Controls.Add(UNITS_IN_STOCKLabel)
        Me.Controls.Add(Me.UNITS_IN_STOCKTextBox)
        Me.Controls.Add(UNITS_ON_ORDERLabel)
        Me.Controls.Add(Me.UNITS_ON_ORDERTextBox)
        Me.Controls.Add(QUANTITY_PER_UNITLabel)
        Me.Controls.Add(Me.QUANTITY_PER_UNITTextBox)
        Me.Controls.Add(CATEGORY_IDLabel)
        Me.Controls.Add(Me.CATEGORY_IDTextBox)
        Me.Controls.Add(DESCRIPTIONLabel)
        Me.Controls.Add(Me.DESCRIPTIONTextBox)
        Me.Controls.Add(Me.ITEMS_DETAILSBindingNavigator)
        Me.Name = "Items_Details"
        Me.Text = "Items_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITEMS_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITEMS_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ITEMS_DETAILSBindingNavigator.ResumeLayout(False)
        Me.ITEMS_DETAILSBindingNavigator.PerformLayout()
        CType(Me.ITEMS_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents ITEMS_DETAILSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ITEMS_DETAILSTableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.ITEMS_DETAILSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ITEMS_DETAILSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ITEMS_DETAILSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ITEM_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEM_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SUPPLIER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNIT_PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNITS_IN_STOCKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNITS_ON_ORDERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITY_PER_UNITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CATEGORY_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPTIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnItemRecordNavigationForm As System.Windows.Forms.Button
    Friend WithEvents ITEMS_DETAILSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
