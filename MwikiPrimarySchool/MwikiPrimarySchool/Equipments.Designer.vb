<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipments
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
        Dim ITEMS_TAKENLabel As System.Windows.Forms.Label
        Dim ITEM_IDLabel As System.Windows.Forms.Label
        Dim STAFF_IDLabel As System.Windows.Forms.Label
        Dim STUDENTS_IDLabel As System.Windows.Forms.Label
        Dim RETURNEDLabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim PENALTYLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipments))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.EQUIPMENTS_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTS_TABLETableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.EQUIPMENTS_TABLETableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.EQUIPMENTS_TABLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EQUIPMENTS_TABLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ITEMS_TAKENTextBox = New System.Windows.Forms.TextBox()
        Me.ITEM_IDTextBox = New System.Windows.Forms.TextBox()
        Me.STAFF_IDTextBox = New System.Windows.Forms.TextBox()
        Me.STUDENTS_IDTextBox = New System.Windows.Forms.TextBox()
        Me.RETURNEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.PENALTYCheckBox = New System.Windows.Forms.CheckBox()
        Me.PenaltyGroupBox = New System.Windows.Forms.GroupBox()
        Me.TxtPenalty = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.BtnPenalty = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnEquipmentRecordNavigationForm = New System.Windows.Forms.Button()
        ITEMS_TAKENLabel = New System.Windows.Forms.Label()
        ITEM_IDLabel = New System.Windows.Forms.Label()
        STAFF_IDLabel = New System.Windows.Forms.Label()
        STUDENTS_IDLabel = New System.Windows.Forms.Label()
        RETURNEDLabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        PENALTYLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTS_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTS_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EQUIPMENTS_TABLEBindingNavigator.SuspendLayout()
        Me.PenaltyGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ITEMS_TAKENLabel
        '
        ITEMS_TAKENLabel.AutoSize = True
        ITEMS_TAKENLabel.Location = New System.Drawing.Point(12, 42)
        ITEMS_TAKENLabel.Name = "ITEMS_TAKENLabel"
        ITEMS_TAKENLabel.Size = New System.Drawing.Size(82, 13)
        ITEMS_TAKENLabel.TabIndex = 1
        ITEMS_TAKENLabel.Text = "ITEMS TAKEN:"
        '
        'ITEM_IDLabel
        '
        ITEM_IDLabel.AutoSize = True
        ITEM_IDLabel.Location = New System.Drawing.Point(12, 68)
        ITEM_IDLabel.Name = "ITEM_IDLabel"
        ITEM_IDLabel.Size = New System.Drawing.Size(50, 13)
        ITEM_IDLabel.TabIndex = 3
        ITEM_IDLabel.Text = "ITEM ID:"
        '
        'STAFF_IDLabel
        '
        STAFF_IDLabel.AutoSize = True
        STAFF_IDLabel.Location = New System.Drawing.Point(12, 94)
        STAFF_IDLabel.Name = "STAFF_IDLabel"
        STAFF_IDLabel.Size = New System.Drawing.Size(57, 13)
        STAFF_IDLabel.TabIndex = 5
        STAFF_IDLabel.Text = "STAFF ID:"
        '
        'STUDENTS_IDLabel
        '
        STUDENTS_IDLabel.AutoSize = True
        STUDENTS_IDLabel.Location = New System.Drawing.Point(12, 120)
        STUDENTS_IDLabel.Name = "STUDENTS_IDLabel"
        STUDENTS_IDLabel.Size = New System.Drawing.Size(83, 13)
        STUDENTS_IDLabel.TabIndex = 7
        STUDENTS_IDLabel.Text = "STUDENTS ID:"
        '
        'RETURNEDLabel
        '
        RETURNEDLabel.AutoSize = True
        RETURNEDLabel.Location = New System.Drawing.Point(12, 148)
        RETURNEDLabel.Name = "RETURNEDLabel"
        RETURNEDLabel.Size = New System.Drawing.Size(71, 13)
        RETURNEDLabel.TabIndex = 9
        RETURNEDLabel.Text = "RETURNED:"
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
        'PENALTYLabel
        '
        PENALTYLabel.AutoSize = True
        PENALTYLabel.Location = New System.Drawing.Point(12, 204)
        PENALTYLabel.Name = "PENALTYLabel"
        PENALTYLabel.Size = New System.Drawing.Size(59, 13)
        PENALTYLabel.TabIndex = 13
        PENALTYLabel.Text = "PENALTY:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EQUIPMENTS_TABLEBindingSource
        '
        Me.EQUIPMENTS_TABLEBindingSource.DataMember = "EQUIPMENTS TABLE"
        Me.EQUIPMENTS_TABLEBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'EQUIPMENTS_TABLETableAdapter
        '
        Me.EQUIPMENTS_TABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTS_TABLETableAdapter = Me.EQUIPMENTS_TABLETableAdapter
        Me.TableAdapterManager.HEAD_OF_DEPARTMENT_TABLETableAdapter = Nothing
        Me.TableAdapterManager.ITEMS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.REQUISITION_ORDER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STORES_TABLETableAdapter = Nothing
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EQUIPMENTS_TABLEBindingNavigator
        '
        Me.EQUIPMENTS_TABLEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EQUIPMENTS_TABLEBindingNavigator.BindingSource = Me.EQUIPMENTS_TABLEBindingSource
        Me.EQUIPMENTS_TABLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EQUIPMENTS_TABLEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EQUIPMENTS_TABLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EQUIPMENTS_TABLEBindingNavigatorSaveItem})
        Me.EQUIPMENTS_TABLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EQUIPMENTS_TABLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EQUIPMENTS_TABLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EQUIPMENTS_TABLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EQUIPMENTS_TABLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EQUIPMENTS_TABLEBindingNavigator.Name = "EQUIPMENTS_TABLEBindingNavigator"
        Me.EQUIPMENTS_TABLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EQUIPMENTS_TABLEBindingNavigator.Size = New System.Drawing.Size(881, 25)
        Me.EQUIPMENTS_TABLEBindingNavigator.TabIndex = 0
        Me.EQUIPMENTS_TABLEBindingNavigator.Text = "BindingNavigator1"
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
        'EQUIPMENTS_TABLEBindingNavigatorSaveItem
        '
        Me.EQUIPMENTS_TABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EQUIPMENTS_TABLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("EQUIPMENTS_TABLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EQUIPMENTS_TABLEBindingNavigatorSaveItem.Name = "EQUIPMENTS_TABLEBindingNavigatorSaveItem"
        Me.EQUIPMENTS_TABLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EQUIPMENTS_TABLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ITEMS_TAKENTextBox
        '
        Me.ITEMS_TAKENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPMENTS_TABLEBindingSource, "ITEMS TAKEN", True))
        Me.ITEMS_TAKENTextBox.Location = New System.Drawing.Point(101, 39)
        Me.ITEMS_TAKENTextBox.Name = "ITEMS_TAKENTextBox"
        Me.ITEMS_TAKENTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ITEMS_TAKENTextBox.TabIndex = 2
        '
        'ITEM_IDTextBox
        '
        Me.ITEM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPMENTS_TABLEBindingSource, "ITEM ID", True))
        Me.ITEM_IDTextBox.Location = New System.Drawing.Point(101, 65)
        Me.ITEM_IDTextBox.Name = "ITEM_IDTextBox"
        Me.ITEM_IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ITEM_IDTextBox.TabIndex = 4
        '
        'STAFF_IDTextBox
        '
        Me.STAFF_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPMENTS_TABLEBindingSource, "STAFF ID", True))
        Me.STAFF_IDTextBox.Location = New System.Drawing.Point(101, 91)
        Me.STAFF_IDTextBox.Name = "STAFF_IDTextBox"
        Me.STAFF_IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.STAFF_IDTextBox.TabIndex = 6
        '
        'STUDENTS_IDTextBox
        '
        Me.STUDENTS_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPMENTS_TABLEBindingSource, "STUDENTS ID", True))
        Me.STUDENTS_IDTextBox.Location = New System.Drawing.Point(101, 117)
        Me.STUDENTS_IDTextBox.Name = "STUDENTS_IDTextBox"
        Me.STUDENTS_IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.STUDENTS_IDTextBox.TabIndex = 8
        '
        'RETURNEDCheckBox
        '
        Me.RETURNEDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EQUIPMENTS_TABLEBindingSource, "RETURNED", True))
        Me.RETURNEDCheckBox.Location = New System.Drawing.Point(101, 143)
        Me.RETURNEDCheckBox.Name = "RETURNEDCheckBox"
        Me.RETURNEDCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.RETURNEDCheckBox.TabIndex = 10
        Me.RETURNEDCheckBox.UseVisualStyleBackColor = True
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPMENTS_TABLEBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(101, 173)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(104, 20)
        Me.UNIT_PRICETextBox.TabIndex = 12
        '
        'PENALTYCheckBox
        '
        Me.PENALTYCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EQUIPMENTS_TABLEBindingSource, "PENALTY", True))
        Me.PENALTYCheckBox.Location = New System.Drawing.Point(101, 199)
        Me.PENALTYCheckBox.Name = "PENALTYCheckBox"
        Me.PENALTYCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PENALTYCheckBox.TabIndex = 14
        Me.PENALTYCheckBox.UseVisualStyleBackColor = True
        '
        'PenaltyGroupBox
        '
        Me.PenaltyGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.PenaltyGroupBox.Controls.Add(Me.TxtPenalty)
        Me.PenaltyGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PenaltyGroupBox.ForeColor = System.Drawing.Color.Red
        Me.PenaltyGroupBox.Location = New System.Drawing.Point(276, 39)
        Me.PenaltyGroupBox.Name = "PenaltyGroupBox"
        Me.PenaltyGroupBox.Size = New System.Drawing.Size(449, 200)
        Me.PenaltyGroupBox.TabIndex = 34
        Me.PenaltyGroupBox.TabStop = False
        Me.PenaltyGroupBox.Text = "Penalty"
        '
        'TxtPenalty
        '
        Me.TxtPenalty.Location = New System.Drawing.Point(31, 20)
        Me.TxtPenalty.Multiline = True
        Me.TxtPenalty.Name = "TxtPenalty"
        Me.TxtPenalty.Size = New System.Drawing.Size(380, 164)
        Me.TxtPenalty.TabIndex = 0
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(552, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 29)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Print Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btnprint
        '
        Me.Btnprint.Location = New System.Drawing.Point(552, 312)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(72, 29)
        Me.Btnprint.TabIndex = 47
        Me.Btnprint.Text = "Print"
        Me.Btnprint.UseVisualStyleBackColor = True
        '
        'BtnPenalty
        '
        Me.BtnPenalty.Location = New System.Drawing.Point(415, 247)
        Me.BtnPenalty.Name = "BtnPenalty"
        Me.BtnPenalty.Size = New System.Drawing.Size(78, 38)
        Me.BtnPenalty.TabIndex = 46
        Me.BtnPenalty.Text = "Display Penalty"
        Me.BtnPenalty.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(144, 318)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 45
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(278, 318)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 44
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(144, 247)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 43
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(278, 247)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 42
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(415, 318)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 41
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(18, 318)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 40
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(17, 247)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 39
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnEquipmentRecordNavigationForm
        '
        Me.BtnEquipmentRecordNavigationForm.Location = New System.Drawing.Point(690, 283)
        Me.BtnEquipmentRecordNavigationForm.Name = "BtnEquipmentRecordNavigationForm"
        Me.BtnEquipmentRecordNavigationForm.Size = New System.Drawing.Size(149, 23)
        Me.BtnEquipmentRecordNavigationForm.TabIndex = 38
        Me.BtnEquipmentRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnEquipmentRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'Equipments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(881, 387)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btnprint)
        Me.Controls.Add(Me.BtnPenalty)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnEquipmentRecordNavigationForm)
        Me.Controls.Add(Me.PenaltyGroupBox)
        Me.Controls.Add(ITEMS_TAKENLabel)
        Me.Controls.Add(Me.ITEMS_TAKENTextBox)
        Me.Controls.Add(ITEM_IDLabel)
        Me.Controls.Add(Me.ITEM_IDTextBox)
        Me.Controls.Add(STAFF_IDLabel)
        Me.Controls.Add(Me.STAFF_IDTextBox)
        Me.Controls.Add(STUDENTS_IDLabel)
        Me.Controls.Add(Me.STUDENTS_IDTextBox)
        Me.Controls.Add(RETURNEDLabel)
        Me.Controls.Add(Me.RETURNEDCheckBox)
        Me.Controls.Add(UNIT_PRICELabel)
        Me.Controls.Add(Me.UNIT_PRICETextBox)
        Me.Controls.Add(PENALTYLabel)
        Me.Controls.Add(Me.PENALTYCheckBox)
        Me.Controls.Add(Me.EQUIPMENTS_TABLEBindingNavigator)
        Me.Name = "Equipments"
        Me.Text = "Equipments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTS_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTS_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EQUIPMENTS_TABLEBindingNavigator.ResumeLayout(False)
        Me.EQUIPMENTS_TABLEBindingNavigator.PerformLayout()
        Me.PenaltyGroupBox.ResumeLayout(False)
        Me.PenaltyGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents EQUIPMENTS_TABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTS_TABLETableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.EQUIPMENTS_TABLETableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EQUIPMENTS_TABLEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EQUIPMENTS_TABLEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ITEMS_TAKENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEM_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STAFF_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STUDENTS_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RETURNEDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UNIT_PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PENALTYCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PenaltyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPenalty As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btnprint As System.Windows.Forms.Button
    Friend WithEvents BtnPenalty As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnEquipmentRecordNavigationForm As System.Windows.Forms.Button
End Class
