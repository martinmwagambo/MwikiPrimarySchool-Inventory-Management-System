<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Head_Of_Department_Table
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
        Dim NUMBER_OF_ITEMSLabel As System.Windows.Forms.Label
        Dim ITEMS_DELIVEREDLabel As System.Windows.Forms.Label
        Dim SUPPLIER_IDLabel As System.Windows.Forms.Label
        Dim DATE_OF_DELIVERYLabel As System.Windows.Forms.Label
        Dim APPROVEDLabel As System.Windows.Forms.Label
        Dim DEFERREDLabel As System.Windows.Forms.Label
        Dim HODLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Head_Of_Department_Table))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.HEAD_OF_DEPARTMENT_TABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HEAD_OF_DEPARTMENT_TABLETableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.HEAD_OF_DEPARTMENT_TABLETableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NUMBER_OF_ITEMSTextBox = New System.Windows.Forms.TextBox()
        Me.ITEMS_DELIVEREDTextBox = New System.Windows.Forms.TextBox()
        Me.SUPPLIER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_DELIVERYTextBox = New System.Windows.Forms.TextBox()
        Me.APPROVEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.DEFERREDCheckBox = New System.Windows.Forms.CheckBox()
        Me.HODTextBox = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnHODRecordNavigationForm = New System.Windows.Forms.Button()
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        NUMBER_OF_ITEMSLabel = New System.Windows.Forms.Label()
        ITEMS_DELIVEREDLabel = New System.Windows.Forms.Label()
        SUPPLIER_IDLabel = New System.Windows.Forms.Label()
        DATE_OF_DELIVERYLabel = New System.Windows.Forms.Label()
        APPROVEDLabel = New System.Windows.Forms.Label()
        DEFERREDLabel = New System.Windows.Forms.Label()
        HODLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.SuspendLayout()
        CType(Me.HEAD_OF_DEPARTMENT_TABLEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NUMBER_OF_ITEMSLabel
        '
        NUMBER_OF_ITEMSLabel.AutoSize = True
        NUMBER_OF_ITEMSLabel.Location = New System.Drawing.Point(12, 41)
        NUMBER_OF_ITEMSLabel.Name = "NUMBER_OF_ITEMSLabel"
        NUMBER_OF_ITEMSLabel.Size = New System.Drawing.Size(110, 13)
        NUMBER_OF_ITEMSLabel.TabIndex = 1
        NUMBER_OF_ITEMSLabel.Text = "NUMBER OF ITEMS:"
        '
        'ITEMS_DELIVEREDLabel
        '
        ITEMS_DELIVEREDLabel.AutoSize = True
        ITEMS_DELIVEREDLabel.Location = New System.Drawing.Point(12, 67)
        ITEMS_DELIVEREDLabel.Name = "ITEMS_DELIVEREDLabel"
        ITEMS_DELIVEREDLabel.Size = New System.Drawing.Size(107, 13)
        ITEMS_DELIVEREDLabel.TabIndex = 3
        ITEMS_DELIVEREDLabel.Text = "ITEMS DELIVERED:"
        '
        'SUPPLIER_IDLabel
        '
        SUPPLIER_IDLabel.AutoSize = True
        SUPPLIER_IDLabel.Location = New System.Drawing.Point(12, 93)
        SUPPLIER_IDLabel.Name = "SUPPLIER_IDLabel"
        SUPPLIER_IDLabel.Size = New System.Drawing.Size(77, 13)
        SUPPLIER_IDLabel.TabIndex = 5
        SUPPLIER_IDLabel.Text = "SUPPLIER ID:"
        '
        'DATE_OF_DELIVERYLabel
        '
        DATE_OF_DELIVERYLabel.AutoSize = True
        DATE_OF_DELIVERYLabel.Location = New System.Drawing.Point(12, 119)
        DATE_OF_DELIVERYLabel.Name = "DATE_OF_DELIVERYLabel"
        DATE_OF_DELIVERYLabel.Size = New System.Drawing.Size(112, 13)
        DATE_OF_DELIVERYLabel.TabIndex = 7
        DATE_OF_DELIVERYLabel.Text = "DATE OF DELIVERY:"
        '
        'APPROVEDLabel
        '
        APPROVEDLabel.AutoSize = True
        APPROVEDLabel.Location = New System.Drawing.Point(12, 147)
        APPROVEDLabel.Name = "APPROVEDLabel"
        APPROVEDLabel.Size = New System.Drawing.Size(69, 13)
        APPROVEDLabel.TabIndex = 9
        APPROVEDLabel.Text = "APPROVED:"
        '
        'DEFERREDLabel
        '
        DEFERREDLabel.AutoSize = True
        DEFERREDLabel.Location = New System.Drawing.Point(12, 177)
        DEFERREDLabel.Name = "DEFERREDLabel"
        DEFERREDLabel.Size = New System.Drawing.Size(69, 13)
        DEFERREDLabel.TabIndex = 11
        DEFERREDLabel.Text = "DEFERRED:"
        '
        'HODLabel
        '
        HODLabel.AutoSize = True
        HODLabel.Location = New System.Drawing.Point(12, 205)
        HODLabel.Name = "HODLabel"
        HODLabel.Size = New System.Drawing.Size(34, 13)
        HODLabel.TabIndex = 13
        HODLabel.Text = "HOD:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HEAD_OF_DEPARTMENT_TABLEBindingSource
        '
        Me.HEAD_OF_DEPARTMENT_TABLEBindingSource.DataMember = "HEAD OF DEPARTMENT TABLE"
        Me.HEAD_OF_DEPARTMENT_TABLEBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'HEAD_OF_DEPARTMENT_TABLETableAdapter
        '
        Me.HEAD_OF_DEPARTMENT_TABLETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.HEAD_OF_DEPARTMENT_TABLETableAdapter = Me.HEAD_OF_DEPARTMENT_TABLETableAdapter
        Me.TableAdapterManager.ITEMS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.REQUISITION_ORDER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STORES_TABLETableAdapter = Nothing
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HEAD_OF_DEPARTMENT_TABLEBindingNavigator
        '
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.BindingSource = Me.HEAD_OF_DEPARTMENT_TABLEBindingSource
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem})
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.Name = "HEAD_OF_DEPARTMENT_TABLEBindingNavigator"
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.Size = New System.Drawing.Size(838, 25)
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.TabIndex = 0
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.Text = "BindingNavigator1"
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
        'HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem
        '
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem.Image = CType(resources.GetObject("HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem.Name = "HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem"
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NUMBER_OF_ITEMSTextBox
        '
        Me.NUMBER_OF_ITEMSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, "NUMBER OF ITEMS", True))
        Me.NUMBER_OF_ITEMSTextBox.Location = New System.Drawing.Point(130, 38)
        Me.NUMBER_OF_ITEMSTextBox.Name = "NUMBER_OF_ITEMSTextBox"
        Me.NUMBER_OF_ITEMSTextBox.Size = New System.Drawing.Size(104, 20)
        Me.NUMBER_OF_ITEMSTextBox.TabIndex = 2
        '
        'ITEMS_DELIVEREDTextBox
        '
        Me.ITEMS_DELIVEREDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, "ITEMS DELIVERED", True))
        Me.ITEMS_DELIVEREDTextBox.Location = New System.Drawing.Point(130, 64)
        Me.ITEMS_DELIVEREDTextBox.Name = "ITEMS_DELIVEREDTextBox"
        Me.ITEMS_DELIVEREDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ITEMS_DELIVEREDTextBox.TabIndex = 4
        '
        'SUPPLIER_IDTextBox
        '
        Me.SUPPLIER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, "SUPPLIER ID", True))
        Me.SUPPLIER_IDTextBox.Location = New System.Drawing.Point(130, 90)
        Me.SUPPLIER_IDTextBox.Name = "SUPPLIER_IDTextBox"
        Me.SUPPLIER_IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SUPPLIER_IDTextBox.TabIndex = 6
        '
        'DATE_OF_DELIVERYTextBox
        '
        Me.DATE_OF_DELIVERYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, "DATE OF DELIVERY", True))
        Me.DATE_OF_DELIVERYTextBox.Location = New System.Drawing.Point(130, 116)
        Me.DATE_OF_DELIVERYTextBox.Name = "DATE_OF_DELIVERYTextBox"
        Me.DATE_OF_DELIVERYTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DATE_OF_DELIVERYTextBox.TabIndex = 8
        '
        'APPROVEDCheckBox
        '
        Me.APPROVEDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, "APPROVED", True))
        Me.APPROVEDCheckBox.Location = New System.Drawing.Point(130, 142)
        Me.APPROVEDCheckBox.Name = "APPROVEDCheckBox"
        Me.APPROVEDCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.APPROVEDCheckBox.TabIndex = 10
        Me.APPROVEDCheckBox.UseVisualStyleBackColor = True
        '
        'DEFERREDCheckBox
        '
        Me.DEFERREDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, "DEFERRED", True))
        Me.DEFERREDCheckBox.Location = New System.Drawing.Point(130, 172)
        Me.DEFERREDCheckBox.Name = "DEFERREDCheckBox"
        Me.DEFERREDCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DEFERREDCheckBox.TabIndex = 12
        Me.DEFERREDCheckBox.UseVisualStyleBackColor = True
        '
        'HODTextBox
        '
        Me.HODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, "HOD", True))
        Me.HODTextBox.Location = New System.Drawing.Point(130, 202)
        Me.HODTextBox.Name = "HODTextBox"
        Me.HODTextBox.Size = New System.Drawing.Size(104, 20)
        Me.HODTextBox.TabIndex = 14
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(404, 333)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrint.TabIndex = 40
        Me.BtnPrint.Text = "Print Form"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(142, 333)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 39
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(276, 333)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 38
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(142, 262)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 37
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(276, 262)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 36
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(404, 262)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 35
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(16, 333)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 34
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(15, 262)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 33
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnHODRecordNavigationForm
        '
        Me.BtnHODRecordNavigationForm.Location = New System.Drawing.Point(519, 305)
        Me.BtnHODRecordNavigationForm.Name = "BtnHODRecordNavigationForm"
        Me.BtnHODRecordNavigationForm.Size = New System.Drawing.Size(157, 23)
        Me.BtnHODRecordNavigationForm.TabIndex = 32
        Me.BtnHODRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnHODRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'HEAD_OF_DEPARTMENT_TABLEDataGridView
        '
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.AutoGenerateColumns = False
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn5})
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.DataSource = Me.HEAD_OF_DEPARTMENT_TABLEBindingSource
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.Location = New System.Drawing.Point(289, 28)
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.Name = "HEAD_OF_DEPARTMENT_TABLEDataGridView"
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.Size = New System.Drawing.Size(537, 220)
        Me.HEAD_OF_DEPARTMENT_TABLEDataGridView.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NUMBER OF ITEMS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NUMBER OF ITEMS"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SUPPLIER ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SUPPLIER ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DATE OF DELIVERY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DATE OF DELIVERY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "APPROVED"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "APPROVED"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "DEFERRED"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "DEFERRED"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HOD"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HOD"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Head_Of_Department_Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 378)
        Me.Controls.Add(Me.HEAD_OF_DEPARTMENT_TABLEDataGridView)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnHODRecordNavigationForm)
        Me.Controls.Add(NUMBER_OF_ITEMSLabel)
        Me.Controls.Add(Me.NUMBER_OF_ITEMSTextBox)
        Me.Controls.Add(ITEMS_DELIVEREDLabel)
        Me.Controls.Add(Me.ITEMS_DELIVEREDTextBox)
        Me.Controls.Add(SUPPLIER_IDLabel)
        Me.Controls.Add(Me.SUPPLIER_IDTextBox)
        Me.Controls.Add(DATE_OF_DELIVERYLabel)
        Me.Controls.Add(Me.DATE_OF_DELIVERYTextBox)
        Me.Controls.Add(APPROVEDLabel)
        Me.Controls.Add(Me.APPROVEDCheckBox)
        Me.Controls.Add(DEFERREDLabel)
        Me.Controls.Add(Me.DEFERREDCheckBox)
        Me.Controls.Add(HODLabel)
        Me.Controls.Add(Me.HODTextBox)
        Me.Controls.Add(Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator)
        Me.Name = "Head_Of_Department_Table"
        Me.Text = "Head_Of_Department_Table"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HEAD_OF_DEPARTMENT_TABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.ResumeLayout(False)
        Me.HEAD_OF_DEPARTMENT_TABLEBindingNavigator.PerformLayout()
        CType(Me.HEAD_OF_DEPARTMENT_TABLEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents HEAD_OF_DEPARTMENT_TABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HEAD_OF_DEPARTMENT_TABLETableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.HEAD_OF_DEPARTMENT_TABLETableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HEAD_OF_DEPARTMENT_TABLEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NUMBER_OF_ITEMSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEMS_DELIVEREDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SUPPLIER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_OF_DELIVERYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APPROVEDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DEFERREDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnHODRecordNavigationForm As System.Windows.Forms.Button
    Friend WithEvents HEAD_OF_DEPARTMENT_TABLEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
