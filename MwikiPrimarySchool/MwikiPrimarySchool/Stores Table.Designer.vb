<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stores_Table
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
        Dim SUPPLIER_IDLabel As System.Windows.Forms.Label
        Dim ITEMS_DELIVEREDLabel As System.Windows.Forms.Label
        Dim ITEMS_IDLabel As System.Windows.Forms.Label
        Dim DATE_OF_DELIVERYLabel As System.Windows.Forms.Label
        Dim LOCATION_STOREDLabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim QUALITYLabel As System.Windows.Forms.Label
        Dim TYPE_OF_ITEMLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stores_Table))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.STORES_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STORES_TABLETableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.STORES_TABLETableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.STORES_TABLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.STORES_TABLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SUPPLIER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ITEMS_DELIVEREDTextBox = New System.Windows.Forms.TextBox()
        Me.ITEMS_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_DELIVERYTextBox = New System.Windows.Forms.TextBox()
        Me.LOCATION_STOREDTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.QUALITYTextBox = New System.Windows.Forms.TextBox()
        Me.TYPE_OF_ITEMTextBox = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnStoresRecordNavigationForm = New System.Windows.Forms.Button()
        Me.STORES_TABLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        SUPPLIER_IDLabel = New System.Windows.Forms.Label()
        ITEMS_DELIVEREDLabel = New System.Windows.Forms.Label()
        ITEMS_IDLabel = New System.Windows.Forms.Label()
        DATE_OF_DELIVERYLabel = New System.Windows.Forms.Label()
        LOCATION_STOREDLabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        QUALITYLabel = New System.Windows.Forms.Label()
        TYPE_OF_ITEMLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STORES_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STORES_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STORES_TABLEBindingNavigator.SuspendLayout()
        CType(Me.STORES_TABLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SUPPLIER_IDLabel
        '
        SUPPLIER_IDLabel.AutoSize = True
        SUPPLIER_IDLabel.Location = New System.Drawing.Point(12, 34)
        SUPPLIER_IDLabel.Name = "SUPPLIER_IDLabel"
        SUPPLIER_IDLabel.Size = New System.Drawing.Size(77, 13)
        SUPPLIER_IDLabel.TabIndex = 1
        SUPPLIER_IDLabel.Text = "SUPPLIER ID:"
        '
        'ITEMS_DELIVEREDLabel
        '
        ITEMS_DELIVEREDLabel.AutoSize = True
        ITEMS_DELIVEREDLabel.Location = New System.Drawing.Point(12, 60)
        ITEMS_DELIVEREDLabel.Name = "ITEMS_DELIVEREDLabel"
        ITEMS_DELIVEREDLabel.Size = New System.Drawing.Size(107, 13)
        ITEMS_DELIVEREDLabel.TabIndex = 3
        ITEMS_DELIVEREDLabel.Text = "ITEMS DELIVERED:"
        '
        'ITEMS_IDLabel
        '
        ITEMS_IDLabel.AutoSize = True
        ITEMS_IDLabel.Location = New System.Drawing.Point(12, 86)
        ITEMS_IDLabel.Name = "ITEMS_IDLabel"
        ITEMS_IDLabel.Size = New System.Drawing.Size(57, 13)
        ITEMS_IDLabel.TabIndex = 5
        ITEMS_IDLabel.Text = "ITEMS ID:"
        '
        'DATE_OF_DELIVERYLabel
        '
        DATE_OF_DELIVERYLabel.AutoSize = True
        DATE_OF_DELIVERYLabel.Location = New System.Drawing.Point(12, 112)
        DATE_OF_DELIVERYLabel.Name = "DATE_OF_DELIVERYLabel"
        DATE_OF_DELIVERYLabel.Size = New System.Drawing.Size(112, 13)
        DATE_OF_DELIVERYLabel.TabIndex = 7
        DATE_OF_DELIVERYLabel.Text = "DATE OF DELIVERY:"
        '
        'LOCATION_STOREDLabel
        '
        LOCATION_STOREDLabel.AutoSize = True
        LOCATION_STOREDLabel.Location = New System.Drawing.Point(12, 138)
        LOCATION_STOREDLabel.Name = "LOCATION_STOREDLabel"
        LOCATION_STOREDLabel.Size = New System.Drawing.Size(112, 13)
        LOCATION_STOREDLabel.TabIndex = 9
        LOCATION_STOREDLabel.Text = "LOCATION STORED:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(12, 164)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 11
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(12, 190)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(71, 13)
        UNIT_PRICELabel.TabIndex = 13
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'QUALITYLabel
        '
        QUALITYLabel.AutoSize = True
        QUALITYLabel.Location = New System.Drawing.Point(12, 216)
        QUALITYLabel.Name = "QUALITYLabel"
        QUALITYLabel.Size = New System.Drawing.Size(56, 13)
        QUALITYLabel.TabIndex = 15
        QUALITYLabel.Text = "QUALITY:"
        '
        'TYPE_OF_ITEMLabel
        '
        TYPE_OF_ITEMLabel.AutoSize = True
        TYPE_OF_ITEMLabel.Location = New System.Drawing.Point(12, 242)
        TYPE_OF_ITEMLabel.Name = "TYPE_OF_ITEMLabel"
        TYPE_OF_ITEMLabel.Size = New System.Drawing.Size(84, 13)
        TYPE_OF_ITEMLabel.TabIndex = 17
        TYPE_OF_ITEMLabel.Text = "TYPE OF ITEM:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STORES_TABLEBindingSource
        '
        Me.STORES_TABLEBindingSource.DataMember = "STORES TABLE"
        Me.STORES_TABLEBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'STORES_TABLETableAdapter
        '
        Me.STORES_TABLETableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.STORES_TABLETableAdapter = Me.STORES_TABLETableAdapter
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STORES_TABLEBindingNavigator
        '
        Me.STORES_TABLEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.STORES_TABLEBindingNavigator.BindingSource = Me.STORES_TABLEBindingSource
        Me.STORES_TABLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.STORES_TABLEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.STORES_TABLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.STORES_TABLEBindingNavigatorSaveItem})
        Me.STORES_TABLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.STORES_TABLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.STORES_TABLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.STORES_TABLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.STORES_TABLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.STORES_TABLEBindingNavigator.Name = "STORES_TABLEBindingNavigator"
        Me.STORES_TABLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.STORES_TABLEBindingNavigator.Size = New System.Drawing.Size(998, 25)
        Me.STORES_TABLEBindingNavigator.TabIndex = 0
        Me.STORES_TABLEBindingNavigator.Text = "BindingNavigator1"
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
        'STORES_TABLEBindingNavigatorSaveItem
        '
        Me.STORES_TABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.STORES_TABLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("STORES_TABLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.STORES_TABLEBindingNavigatorSaveItem.Name = "STORES_TABLEBindingNavigatorSaveItem"
        Me.STORES_TABLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.STORES_TABLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SUPPLIER_IDTextBox
        '
        Me.SUPPLIER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "SUPPLIER ID", True))
        Me.SUPPLIER_IDTextBox.Location = New System.Drawing.Point(130, 31)
        Me.SUPPLIER_IDTextBox.Name = "SUPPLIER_IDTextBox"
        Me.SUPPLIER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUPPLIER_IDTextBox.TabIndex = 2
        '
        'ITEMS_DELIVEREDTextBox
        '
        Me.ITEMS_DELIVEREDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "ITEMS DELIVERED", True))
        Me.ITEMS_DELIVEREDTextBox.Location = New System.Drawing.Point(130, 57)
        Me.ITEMS_DELIVEREDTextBox.Name = "ITEMS_DELIVEREDTextBox"
        Me.ITEMS_DELIVEREDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEMS_DELIVEREDTextBox.TabIndex = 4
        '
        'ITEMS_IDTextBox
        '
        Me.ITEMS_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "ITEMS ID", True))
        Me.ITEMS_IDTextBox.Location = New System.Drawing.Point(130, 83)
        Me.ITEMS_IDTextBox.Name = "ITEMS_IDTextBox"
        Me.ITEMS_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEMS_IDTextBox.TabIndex = 6
        '
        'DATE_OF_DELIVERYTextBox
        '
        Me.DATE_OF_DELIVERYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "DATE OF DELIVERY", True))
        Me.DATE_OF_DELIVERYTextBox.Location = New System.Drawing.Point(130, 109)
        Me.DATE_OF_DELIVERYTextBox.Name = "DATE_OF_DELIVERYTextBox"
        Me.DATE_OF_DELIVERYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DATE_OF_DELIVERYTextBox.TabIndex = 8
        '
        'LOCATION_STOREDTextBox
        '
        Me.LOCATION_STOREDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "LOCATION STORED", True))
        Me.LOCATION_STOREDTextBox.Location = New System.Drawing.Point(130, 135)
        Me.LOCATION_STOREDTextBox.Name = "LOCATION_STOREDTextBox"
        Me.LOCATION_STOREDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LOCATION_STOREDTextBox.TabIndex = 10
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(130, 161)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox.TabIndex = 12
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(130, 187)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNIT_PRICETextBox.TabIndex = 14
        '
        'QUALITYTextBox
        '
        Me.QUALITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "QUALITY", True))
        Me.QUALITYTextBox.Location = New System.Drawing.Point(130, 213)
        Me.QUALITYTextBox.Name = "QUALITYTextBox"
        Me.QUALITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUALITYTextBox.TabIndex = 16
        '
        'TYPE_OF_ITEMTextBox
        '
        Me.TYPE_OF_ITEMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STORES_TABLEBindingSource, "TYPE OF ITEM", True))
        Me.TYPE_OF_ITEMTextBox.Location = New System.Drawing.Point(130, 239)
        Me.TYPE_OF_ITEMTextBox.Name = "TYPE_OF_ITEMTextBox"
        Me.TYPE_OF_ITEMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TYPE_OF_ITEMTextBox.TabIndex = 18
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(145, 361)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 38
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(279, 361)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 37
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(145, 290)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 36
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(279, 290)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 35
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(440, 290)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 34
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(19, 361)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 33
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(18, 290)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 32
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnStoresRecordNavigationForm
        '
        Me.BtnStoresRecordNavigationForm.Location = New System.Drawing.Point(569, 331)
        Me.BtnStoresRecordNavigationForm.Name = "BtnStoresRecordNavigationForm"
        Me.BtnStoresRecordNavigationForm.Size = New System.Drawing.Size(130, 29)
        Me.BtnStoresRecordNavigationForm.TabIndex = 31
        Me.BtnStoresRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnStoresRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'STORES_TABLEDataGridView
        '
        Me.STORES_TABLEDataGridView.AutoGenerateColumns = False
        Me.STORES_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STORES_TABLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.STORES_TABLEDataGridView.DataSource = Me.STORES_TABLEBindingSource
        Me.STORES_TABLEDataGridView.Location = New System.Drawing.Point(279, 31)
        Me.STORES_TABLEDataGridView.Name = "STORES_TABLEDataGridView"
        Me.STORES_TABLEDataGridView.Size = New System.Drawing.Size(719, 220)
        Me.STORES_TABLEDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SUPPLIER ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SUPPLIER ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ITEMS DELIVERED"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ITEMS DELIVERED"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ITEMS ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ITEMS ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DATE OF DELIVERY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DATE OF DELIVERY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LOCATION STORED"
        Me.DataGridViewTextBoxColumn5.HeaderText = "LOCATION STORED"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QUALITY"
        Me.DataGridViewTextBoxColumn8.HeaderText = "QUALITY"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TYPE OF ITEM"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TYPE OF ITEM"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Stores_Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 428)
        Me.Controls.Add(Me.STORES_TABLEDataGridView)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnStoresRecordNavigationForm)
        Me.Controls.Add(SUPPLIER_IDLabel)
        Me.Controls.Add(Me.SUPPLIER_IDTextBox)
        Me.Controls.Add(ITEMS_DELIVEREDLabel)
        Me.Controls.Add(Me.ITEMS_DELIVEREDTextBox)
        Me.Controls.Add(ITEMS_IDLabel)
        Me.Controls.Add(Me.ITEMS_IDTextBox)
        Me.Controls.Add(DATE_OF_DELIVERYLabel)
        Me.Controls.Add(Me.DATE_OF_DELIVERYTextBox)
        Me.Controls.Add(LOCATION_STOREDLabel)
        Me.Controls.Add(Me.LOCATION_STOREDTextBox)
        Me.Controls.Add(QUANTITYLabel)
        Me.Controls.Add(Me.QUANTITYTextBox)
        Me.Controls.Add(UNIT_PRICELabel)
        Me.Controls.Add(Me.UNIT_PRICETextBox)
        Me.Controls.Add(QUALITYLabel)
        Me.Controls.Add(Me.QUALITYTextBox)
        Me.Controls.Add(TYPE_OF_ITEMLabel)
        Me.Controls.Add(Me.TYPE_OF_ITEMTextBox)
        Me.Controls.Add(Me.STORES_TABLEBindingNavigator)
        Me.Name = "Stores_Table"
        Me.Text = "Stores_Table"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STORES_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STORES_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STORES_TABLEBindingNavigator.ResumeLayout(False)
        Me.STORES_TABLEBindingNavigator.PerformLayout()
        CType(Me.STORES_TABLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents STORES_TABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STORES_TABLETableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.STORES_TABLETableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STORES_TABLEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents STORES_TABLEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SUPPLIER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEMS_DELIVEREDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEMS_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_OF_DELIVERYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LOCATION_STOREDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNIT_PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUALITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TYPE_OF_ITEMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnStoresRecordNavigationForm As System.Windows.Forms.Button
    Friend WithEvents STORES_TABLEDataGridView As System.Windows.Forms.DataGridView
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
