<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requisition_Order_Details
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
        Dim ORDER_IDLabel As System.Windows.Forms.Label
        Dim ITEMS_APPROVEDLabel As System.Windows.Forms.Label
        Dim ITEMS_DROPPED_DEFERREDLabel As System.Windows.Forms.Label
        Dim ITEMS_RE_ORDEREDLabel As System.Windows.Forms.Label
        Dim ITEM_IDLabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim SUPPLIER_IDLabel As System.Windows.Forms.Label
        Dim ORDER_DATELabel As System.Windows.Forms.Label
        Dim DATE_OF_DELIVERYLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requisition_Order_Details))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.REQUISITION_ORDER_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REQUISITION_ORDER_DETAILSTableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.REQUISITION_ORDER_DETAILSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.REQUISITION_ORDER_DETAILSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ORDER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ITEMS_APPROVEDTextBox = New System.Windows.Forms.TextBox()
        Me.ITEMS_DROPPED_DEFERREDTextBox = New System.Windows.Forms.TextBox()
        Me.ITEMS_RE_ORDEREDTextBox = New System.Windows.Forms.TextBox()
        Me.ITEM_IDTextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.SUPPLIER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ORDER_DATETextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_DELIVERYTextBox = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnRequisitionOrderRecordNavigationForm = New System.Windows.Forms.Button()
        ORDER_IDLabel = New System.Windows.Forms.Label()
        ITEMS_APPROVEDLabel = New System.Windows.Forms.Label()
        ITEMS_DROPPED_DEFERREDLabel = New System.Windows.Forms.Label()
        ITEMS_RE_ORDEREDLabel = New System.Windows.Forms.Label()
        ITEM_IDLabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        SUPPLIER_IDLabel = New System.Windows.Forms.Label()
        ORDER_DATELabel = New System.Windows.Forms.Label()
        DATE_OF_DELIVERYLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQUISITION_ORDER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQUISITION_ORDER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ORDER_IDLabel
        '
        ORDER_IDLabel.AutoSize = True
        ORDER_IDLabel.Location = New System.Drawing.Point(12, 46)
        ORDER_IDLabel.Name = "ORDER_IDLabel"
        ORDER_IDLabel.Size = New System.Drawing.Size(63, 13)
        ORDER_IDLabel.TabIndex = 1
        ORDER_IDLabel.Text = "ORDER ID:"
        '
        'ITEMS_APPROVEDLabel
        '
        ITEMS_APPROVEDLabel.AutoSize = True
        ITEMS_APPROVEDLabel.Location = New System.Drawing.Point(12, 72)
        ITEMS_APPROVEDLabel.Name = "ITEMS_APPROVEDLabel"
        ITEMS_APPROVEDLabel.Size = New System.Drawing.Size(105, 13)
        ITEMS_APPROVEDLabel.TabIndex = 3
        ITEMS_APPROVEDLabel.Text = "ITEMS APPROVED:"
        '
        'ITEMS_DROPPED_DEFERREDLabel
        '
        ITEMS_DROPPED_DEFERREDLabel.AutoSize = True
        ITEMS_DROPPED_DEFERREDLabel.Location = New System.Drawing.Point(12, 98)
        ITEMS_DROPPED_DEFERREDLabel.Name = "ITEMS_DROPPED_DEFERREDLabel"
        ITEMS_DROPPED_DEFERREDLabel.Size = New System.Drawing.Size(163, 13)
        ITEMS_DROPPED_DEFERREDLabel.TabIndex = 5
        ITEMS_DROPPED_DEFERREDLabel.Text = "ITEMS DROPPED/DEFERRED:"
        '
        'ITEMS_RE_ORDEREDLabel
        '
        ITEMS_RE_ORDEREDLabel.AutoSize = True
        ITEMS_RE_ORDEREDLabel.Location = New System.Drawing.Point(12, 124)
        ITEMS_RE_ORDEREDLabel.Name = "ITEMS_RE_ORDEREDLabel"
        ITEMS_RE_ORDEREDLabel.Size = New System.Drawing.Size(118, 13)
        ITEMS_RE_ORDEREDLabel.TabIndex = 7
        ITEMS_RE_ORDEREDLabel.Text = "ITEMS RE-ORDERED:"
        '
        'ITEM_IDLabel
        '
        ITEM_IDLabel.AutoSize = True
        ITEM_IDLabel.Location = New System.Drawing.Point(12, 150)
        ITEM_IDLabel.Name = "ITEM_IDLabel"
        ITEM_IDLabel.Size = New System.Drawing.Size(50, 13)
        ITEM_IDLabel.TabIndex = 9
        ITEM_IDLabel.Text = "ITEM ID:"
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(12, 176)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(71, 13)
        UNIT_PRICELabel.TabIndex = 11
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(12, 202)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 13
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'SUPPLIER_IDLabel
        '
        SUPPLIER_IDLabel.AutoSize = True
        SUPPLIER_IDLabel.Location = New System.Drawing.Point(12, 228)
        SUPPLIER_IDLabel.Name = "SUPPLIER_IDLabel"
        SUPPLIER_IDLabel.Size = New System.Drawing.Size(77, 13)
        SUPPLIER_IDLabel.TabIndex = 15
        SUPPLIER_IDLabel.Text = "SUPPLIER ID:"
        '
        'ORDER_DATELabel
        '
        ORDER_DATELabel.AutoSize = True
        ORDER_DATELabel.Location = New System.Drawing.Point(12, 254)
        ORDER_DATELabel.Name = "ORDER_DATELabel"
        ORDER_DATELabel.Size = New System.Drawing.Size(81, 13)
        ORDER_DATELabel.TabIndex = 17
        ORDER_DATELabel.Text = "ORDER DATE:"
        '
        'DATE_OF_DELIVERYLabel
        '
        DATE_OF_DELIVERYLabel.AutoSize = True
        DATE_OF_DELIVERYLabel.Location = New System.Drawing.Point(12, 280)
        DATE_OF_DELIVERYLabel.Name = "DATE_OF_DELIVERYLabel"
        DATE_OF_DELIVERYLabel.Size = New System.Drawing.Size(112, 13)
        DATE_OF_DELIVERYLabel.TabIndex = 19
        DATE_OF_DELIVERYLabel.Text = "DATE OF DELIVERY:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REQUISITION_ORDER_DETAILSBindingSource
        '
        Me.REQUISITION_ORDER_DETAILSBindingSource.DataMember = "REQUISITION ORDER DETAILS"
        Me.REQUISITION_ORDER_DETAILSBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'REQUISITION_ORDER_DETAILSTableAdapter
        '
        Me.REQUISITION_ORDER_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.HEAD_OF_DEPARTMENT_TABLETableAdapter = Nothing
        Me.TableAdapterManager.ITEMS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.REQUISITION_ORDER_DETAILSTableAdapter = Me.REQUISITION_ORDER_DETAILSTableAdapter
        Me.TableAdapterManager.STAFF_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STORES_TABLETableAdapter = Nothing
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'REQUISITION_ORDER_DETAILSBindingNavigator
        '
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.BindingSource = Me.REQUISITION_ORDER_DETAILSBindingSource
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem})
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.Name = "REQUISITION_ORDER_DETAILSBindingNavigator"
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.Size = New System.Drawing.Size(843, 25)
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.TabIndex = 0
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.Text = "BindingNavigator1"
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
        'REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem
        '
        Me.REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem.Image = CType(resources.GetObject("REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem.Name = "REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem"
        Me.REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ORDER_IDTextBox
        '
        Me.ORDER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox.Location = New System.Drawing.Point(181, 43)
        Me.ORDER_IDTextBox.Name = "ORDER_IDTextBox"
        Me.ORDER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ORDER_IDTextBox.TabIndex = 2
        '
        'ITEMS_APPROVEDTextBox
        '
        Me.ITEMS_APPROVEDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "ITEMS APPROVED", True))
        Me.ITEMS_APPROVEDTextBox.Location = New System.Drawing.Point(181, 69)
        Me.ITEMS_APPROVEDTextBox.Name = "ITEMS_APPROVEDTextBox"
        Me.ITEMS_APPROVEDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEMS_APPROVEDTextBox.TabIndex = 4
        '
        'ITEMS_DROPPED_DEFERREDTextBox
        '
        Me.ITEMS_DROPPED_DEFERREDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "ITEMS DROPPED/DEFERRED", True))
        Me.ITEMS_DROPPED_DEFERREDTextBox.Location = New System.Drawing.Point(181, 95)
        Me.ITEMS_DROPPED_DEFERREDTextBox.Name = "ITEMS_DROPPED_DEFERREDTextBox"
        Me.ITEMS_DROPPED_DEFERREDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEMS_DROPPED_DEFERREDTextBox.TabIndex = 6
        '
        'ITEMS_RE_ORDEREDTextBox
        '
        Me.ITEMS_RE_ORDEREDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "ITEMS RE-ORDERED", True))
        Me.ITEMS_RE_ORDEREDTextBox.Location = New System.Drawing.Point(181, 121)
        Me.ITEMS_RE_ORDEREDTextBox.Name = "ITEMS_RE_ORDEREDTextBox"
        Me.ITEMS_RE_ORDEREDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEMS_RE_ORDEREDTextBox.TabIndex = 8
        '
        'ITEM_IDTextBox
        '
        Me.ITEM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "ITEM ID", True))
        Me.ITEM_IDTextBox.Location = New System.Drawing.Point(181, 147)
        Me.ITEM_IDTextBox.Name = "ITEM_IDTextBox"
        Me.ITEM_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEM_IDTextBox.TabIndex = 10
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(181, 173)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNIT_PRICETextBox.TabIndex = 12
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(181, 199)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox.TabIndex = 14
        '
        'SUPPLIER_IDTextBox
        '
        Me.SUPPLIER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "SUPPLIER ID", True))
        Me.SUPPLIER_IDTextBox.Location = New System.Drawing.Point(181, 225)
        Me.SUPPLIER_IDTextBox.Name = "SUPPLIER_IDTextBox"
        Me.SUPPLIER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUPPLIER_IDTextBox.TabIndex = 16
        '
        'ORDER_DATETextBox
        '
        Me.ORDER_DATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "ORDER DATE", True))
        Me.ORDER_DATETextBox.Location = New System.Drawing.Point(181, 251)
        Me.ORDER_DATETextBox.Name = "ORDER_DATETextBox"
        Me.ORDER_DATETextBox.Size = New System.Drawing.Size(100, 20)
        Me.ORDER_DATETextBox.TabIndex = 18
        '
        'DATE_OF_DELIVERYTextBox
        '
        Me.DATE_OF_DELIVERYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REQUISITION_ORDER_DETAILSBindingSource, "DATE OF DELIVERY", True))
        Me.DATE_OF_DELIVERYTextBox.Location = New System.Drawing.Point(181, 277)
        Me.DATE_OF_DELIVERYTextBox.Name = "DATE_OF_DELIVERYTextBox"
        Me.DATE_OF_DELIVERYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DATE_OF_DELIVERYTextBox.TabIndex = 20
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(142, 391)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 38
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(276, 391)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 37
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(142, 320)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 36
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(276, 320)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 35
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(412, 320)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 34
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(16, 391)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 33
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(15, 320)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 32
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnRequisitionOrderRecordNavigationForm
        '
        Me.BtnRequisitionOrderRecordNavigationForm.Location = New System.Drawing.Point(491, 362)
        Me.BtnRequisitionOrderRecordNavigationForm.Name = "BtnRequisitionOrderRecordNavigationForm"
        Me.BtnRequisitionOrderRecordNavigationForm.Size = New System.Drawing.Size(158, 30)
        Me.BtnRequisitionOrderRecordNavigationForm.TabIndex = 31
        Me.BtnRequisitionOrderRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnRequisitionOrderRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'Requisition_Order_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 420)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnRequisitionOrderRecordNavigationForm)
        Me.Controls.Add(ORDER_IDLabel)
        Me.Controls.Add(Me.ORDER_IDTextBox)
        Me.Controls.Add(ITEMS_APPROVEDLabel)
        Me.Controls.Add(Me.ITEMS_APPROVEDTextBox)
        Me.Controls.Add(ITEMS_DROPPED_DEFERREDLabel)
        Me.Controls.Add(Me.ITEMS_DROPPED_DEFERREDTextBox)
        Me.Controls.Add(ITEMS_RE_ORDEREDLabel)
        Me.Controls.Add(Me.ITEMS_RE_ORDEREDTextBox)
        Me.Controls.Add(ITEM_IDLabel)
        Me.Controls.Add(Me.ITEM_IDTextBox)
        Me.Controls.Add(UNIT_PRICELabel)
        Me.Controls.Add(Me.UNIT_PRICETextBox)
        Me.Controls.Add(QUANTITYLabel)
        Me.Controls.Add(Me.QUANTITYTextBox)
        Me.Controls.Add(SUPPLIER_IDLabel)
        Me.Controls.Add(Me.SUPPLIER_IDTextBox)
        Me.Controls.Add(ORDER_DATELabel)
        Me.Controls.Add(Me.ORDER_DATETextBox)
        Me.Controls.Add(DATE_OF_DELIVERYLabel)
        Me.Controls.Add(Me.DATE_OF_DELIVERYTextBox)
        Me.Controls.Add(Me.REQUISITION_ORDER_DETAILSBindingNavigator)
        Me.Name = "Requisition_Order_Details"
        Me.Text = "Requisition_Order_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQUISITION_ORDER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQUISITION_ORDER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.ResumeLayout(False)
        Me.REQUISITION_ORDER_DETAILSBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents REQUISITION_ORDER_DETAILSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REQUISITION_ORDER_DETAILSTableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.REQUISITION_ORDER_DETAILSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REQUISITION_ORDER_DETAILSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ORDER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEMS_APPROVEDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEMS_DROPPED_DEFERREDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEMS_RE_ORDEREDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEM_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNIT_PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SUPPLIER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ORDER_DATETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_OF_DELIVERYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnRequisitionOrderRecordNavigationForm As System.Windows.Forms.Button
End Class
