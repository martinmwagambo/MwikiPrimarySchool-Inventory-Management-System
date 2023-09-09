<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers_Details
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
        Dim COMPANY_NAMELabel As System.Windows.Forms.Label
        Dim SUPPLIERS_IDLabel As System.Windows.Forms.Label
        Dim CONTACT_NAMELabel As System.Windows.Forms.Label
        Dim CONTACT_TITLELabel As System.Windows.Forms.Label
        Dim ADRESSLabel As System.Windows.Forms.Label
        Dim ITEMS_DELIVEREDLabel As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim DATE_OF_DELIVERYLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suppliers_Details))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.SUPPLIER_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUPPLIER_DETAILSTableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.SUPPLIER_DETAILSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.SUPPLIER_DETAILSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SUPPLIER_DETAILSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.COMPANY_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.SUPPLIERS_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CONTACT_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.CONTACT_TITLETextBox = New System.Windows.Forms.TextBox()
        Me.ADRESSTextBox = New System.Windows.Forms.TextBox()
        Me.ITEMS_DELIVEREDTextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_DELIVERYTextBox = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnPrintPreview = New System.Windows.Forms.Button()
        Me.BtnDisplayReport = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnSupplierRecordNavigationForm = New System.Windows.Forms.Button()
        Me.ReportGroupBox = New System.Windows.Forms.GroupBox()
        Me.TxtReport = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        COMPANY_NAMELabel = New System.Windows.Forms.Label()
        SUPPLIERS_IDLabel = New System.Windows.Forms.Label()
        CONTACT_NAMELabel = New System.Windows.Forms.Label()
        CONTACT_TITLELabel = New System.Windows.Forms.Label()
        ADRESSLabel = New System.Windows.Forms.Label()
        ITEMS_DELIVEREDLabel = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        DATE_OF_DELIVERYLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SUPPLIER_DETAILSBindingNavigator.SuspendLayout()
        Me.ReportGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'COMPANY_NAMELabel
        '
        COMPANY_NAMELabel.AutoSize = True
        COMPANY_NAMELabel.Location = New System.Drawing.Point(12, 35)
        COMPANY_NAMELabel.Name = "COMPANY_NAMELabel"
        COMPANY_NAMELabel.Size = New System.Drawing.Size(97, 13)
        COMPANY_NAMELabel.TabIndex = 1
        COMPANY_NAMELabel.Text = "COMPANY NAME:"
        '
        'SUPPLIERS_IDLabel
        '
        SUPPLIERS_IDLabel.AutoSize = True
        SUPPLIERS_IDLabel.Location = New System.Drawing.Point(12, 61)
        SUPPLIERS_IDLabel.Name = "SUPPLIERS_IDLabel"
        SUPPLIERS_IDLabel.Size = New System.Drawing.Size(84, 13)
        SUPPLIERS_IDLabel.TabIndex = 3
        SUPPLIERS_IDLabel.Text = "SUPPLIERS ID:"
        '
        'CONTACT_NAMELabel
        '
        CONTACT_NAMELabel.AutoSize = True
        CONTACT_NAMELabel.Location = New System.Drawing.Point(12, 87)
        CONTACT_NAMELabel.Name = "CONTACT_NAMELabel"
        CONTACT_NAMELabel.Size = New System.Drawing.Size(95, 13)
        CONTACT_NAMELabel.TabIndex = 5
        CONTACT_NAMELabel.Text = "CONTACT NAME:"
        '
        'CONTACT_TITLELabel
        '
        CONTACT_TITLELabel.AutoSize = True
        CONTACT_TITLELabel.Location = New System.Drawing.Point(12, 113)
        CONTACT_TITLELabel.Name = "CONTACT_TITLELabel"
        CONTACT_TITLELabel.Size = New System.Drawing.Size(94, 13)
        CONTACT_TITLELabel.TabIndex = 7
        CONTACT_TITLELabel.Text = "CONTACT TITLE:"
        '
        'ADRESSLabel
        '
        ADRESSLabel.AutoSize = True
        ADRESSLabel.Location = New System.Drawing.Point(12, 139)
        ADRESSLabel.Name = "ADRESSLabel"
        ADRESSLabel.Size = New System.Drawing.Size(54, 13)
        ADRESSLabel.TabIndex = 9
        ADRESSLabel.Text = "ADRESS:"
        '
        'ITEMS_DELIVEREDLabel
        '
        ITEMS_DELIVEREDLabel.AutoSize = True
        ITEMS_DELIVEREDLabel.Location = New System.Drawing.Point(12, 165)
        ITEMS_DELIVEREDLabel.Name = "ITEMS_DELIVEREDLabel"
        ITEMS_DELIVEREDLabel.Size = New System.Drawing.Size(107, 13)
        ITEMS_DELIVEREDLabel.TabIndex = 11
        ITEMS_DELIVEREDLabel.Text = "ITEMS DELIVERED:"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(12, 191)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(48, 13)
        PHONELabel.TabIndex = 13
        PHONELabel.Text = "PHONE:"
        '
        'DATE_OF_DELIVERYLabel
        '
        DATE_OF_DELIVERYLabel.AutoSize = True
        DATE_OF_DELIVERYLabel.Location = New System.Drawing.Point(12, 217)
        DATE_OF_DELIVERYLabel.Name = "DATE_OF_DELIVERYLabel"
        DATE_OF_DELIVERYLabel.Size = New System.Drawing.Size(112, 13)
        DATE_OF_DELIVERYLabel.TabIndex = 15
        DATE_OF_DELIVERYLabel.Text = "DATE OF DELIVERY:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SUPPLIER_DETAILSBindingSource
        '
        Me.SUPPLIER_DETAILSBindingSource.DataMember = "SUPPLIER DETAILS"
        Me.SUPPLIER_DETAILSBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'SUPPLIER_DETAILSTableAdapter
        '
        Me.SUPPLIER_DETAILSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Me.SUPPLIER_DETAILSTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SUPPLIER_DETAILSBindingNavigator
        '
        Me.SUPPLIER_DETAILSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SUPPLIER_DETAILSBindingNavigator.BindingSource = Me.SUPPLIER_DETAILSBindingSource
        Me.SUPPLIER_DETAILSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SUPPLIER_DETAILSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SUPPLIER_DETAILSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SUPPLIER_DETAILSBindingNavigatorSaveItem})
        Me.SUPPLIER_DETAILSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SUPPLIER_DETAILSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SUPPLIER_DETAILSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SUPPLIER_DETAILSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SUPPLIER_DETAILSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SUPPLIER_DETAILSBindingNavigator.Name = "SUPPLIER_DETAILSBindingNavigator"
        Me.SUPPLIER_DETAILSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SUPPLIER_DETAILSBindingNavigator.Size = New System.Drawing.Size(888, 25)
        Me.SUPPLIER_DETAILSBindingNavigator.TabIndex = 0
        Me.SUPPLIER_DETAILSBindingNavigator.Text = "BindingNavigator1"
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
        'SUPPLIER_DETAILSBindingNavigatorSaveItem
        '
        Me.SUPPLIER_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SUPPLIER_DETAILSBindingNavigatorSaveItem.Image = CType(resources.GetObject("SUPPLIER_DETAILSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SUPPLIER_DETAILSBindingNavigatorSaveItem.Name = "SUPPLIER_DETAILSBindingNavigatorSaveItem"
        Me.SUPPLIER_DETAILSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SUPPLIER_DETAILSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'COMPANY_NAMETextBox
        '
        Me.COMPANY_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "COMPANY NAME", True))
        Me.COMPANY_NAMETextBox.Location = New System.Drawing.Point(130, 32)
        Me.COMPANY_NAMETextBox.Name = "COMPANY_NAMETextBox"
        Me.COMPANY_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.COMPANY_NAMETextBox.TabIndex = 2
        '
        'SUPPLIERS_IDTextBox
        '
        Me.SUPPLIERS_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "SUPPLIERS ID", True))
        Me.SUPPLIERS_IDTextBox.Location = New System.Drawing.Point(130, 58)
        Me.SUPPLIERS_IDTextBox.Name = "SUPPLIERS_IDTextBox"
        Me.SUPPLIERS_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUPPLIERS_IDTextBox.TabIndex = 4
        '
        'CONTACT_NAMETextBox
        '
        Me.CONTACT_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "CONTACT NAME", True))
        Me.CONTACT_NAMETextBox.Location = New System.Drawing.Point(130, 84)
        Me.CONTACT_NAMETextBox.Name = "CONTACT_NAMETextBox"
        Me.CONTACT_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CONTACT_NAMETextBox.TabIndex = 6
        '
        'CONTACT_TITLETextBox
        '
        Me.CONTACT_TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "CONTACT TITLE", True))
        Me.CONTACT_TITLETextBox.Location = New System.Drawing.Point(130, 110)
        Me.CONTACT_TITLETextBox.Name = "CONTACT_TITLETextBox"
        Me.CONTACT_TITLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CONTACT_TITLETextBox.TabIndex = 8
        '
        'ADRESSTextBox
        '
        Me.ADRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "ADRESS", True))
        Me.ADRESSTextBox.Location = New System.Drawing.Point(130, 136)
        Me.ADRESSTextBox.Name = "ADRESSTextBox"
        Me.ADRESSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ADRESSTextBox.TabIndex = 10
        '
        'ITEMS_DELIVEREDTextBox
        '
        Me.ITEMS_DELIVEREDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "ITEMS DELIVERED", True))
        Me.ITEMS_DELIVEREDTextBox.Location = New System.Drawing.Point(130, 162)
        Me.ITEMS_DELIVEREDTextBox.Name = "ITEMS_DELIVEREDTextBox"
        Me.ITEMS_DELIVEREDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ITEMS_DELIVEREDTextBox.TabIndex = 12
        '
        'PHONETextBox
        '
        Me.PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "PHONE", True))
        Me.PHONETextBox.Location = New System.Drawing.Point(130, 188)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PHONETextBox.TabIndex = 14
        '
        'DATE_OF_DELIVERYTextBox
        '
        Me.DATE_OF_DELIVERYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SUPPLIER_DETAILSBindingSource, "DATE OF DELIVERY", True))
        Me.DATE_OF_DELIVERYTextBox.Location = New System.Drawing.Point(130, 214)
        Me.DATE_OF_DELIVERYTextBox.Name = "DATE_OF_DELIVERYTextBox"
        Me.DATE_OF_DELIVERYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DATE_OF_DELIVERYTextBox.TabIndex = 16
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(575, 333)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrint.TabIndex = 48
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Location = New System.Drawing.Point(449, 333)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrintPreview.TabIndex = 47
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'BtnDisplayReport
        '
        Me.BtnDisplayReport.Location = New System.Drawing.Point(575, 259)
        Me.BtnDisplayReport.Name = "BtnDisplayReport"
        Me.BtnDisplayReport.Size = New System.Drawing.Size(78, 45)
        Me.BtnDisplayReport.TabIndex = 46
        Me.BtnDisplayReport.Text = "Display Report"
        Me.BtnDisplayReport.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(152, 333)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 45
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(286, 333)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 44
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(152, 262)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 43
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(286, 262)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 42
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(449, 262)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 41
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(26, 333)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 40
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(25, 262)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 39
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnSupplierRecordNavigationForm
        '
        Me.BtnSupplierRecordNavigationForm.Location = New System.Drawing.Point(679, 259)
        Me.BtnSupplierRecordNavigationForm.Name = "BtnSupplierRecordNavigationForm"
        Me.BtnSupplierRecordNavigationForm.Size = New System.Drawing.Size(140, 31)
        Me.BtnSupplierRecordNavigationForm.TabIndex = 38
        Me.BtnSupplierRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnSupplierRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'ReportGroupBox
        '
        Me.ReportGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ReportGroupBox.Controls.Add(Me.TxtReport)
        Me.ReportGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportGroupBox.ForeColor = System.Drawing.Color.Red
        Me.ReportGroupBox.Location = New System.Drawing.Point(286, 35)
        Me.ReportGroupBox.Name = "ReportGroupBox"
        Me.ReportGroupBox.Size = New System.Drawing.Size(449, 200)
        Me.ReportGroupBox.TabIndex = 49
        Me.ReportGroupBox.TabStop = False
        Me.ReportGroupBox.Text = "Report"
        '
        'TxtReport
        '
        Me.TxtReport.Location = New System.Drawing.Point(31, 20)
        Me.TxtReport.Multiline = True
        Me.TxtReport.Name = "TxtReport"
        Me.TxtReport.Size = New System.Drawing.Size(380, 164)
        Me.TxtReport.TabIndex = 0
        '
        'PrintDocument1
        '
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
        'Suppliers_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(888, 382)
        Me.Controls.Add(Me.ReportGroupBox)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnPrintPreview)
        Me.Controls.Add(Me.BtnDisplayReport)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnSupplierRecordNavigationForm)
        Me.Controls.Add(COMPANY_NAMELabel)
        Me.Controls.Add(Me.COMPANY_NAMETextBox)
        Me.Controls.Add(SUPPLIERS_IDLabel)
        Me.Controls.Add(Me.SUPPLIERS_IDTextBox)
        Me.Controls.Add(CONTACT_NAMELabel)
        Me.Controls.Add(Me.CONTACT_NAMETextBox)
        Me.Controls.Add(CONTACT_TITLELabel)
        Me.Controls.Add(Me.CONTACT_TITLETextBox)
        Me.Controls.Add(ADRESSLabel)
        Me.Controls.Add(Me.ADRESSTextBox)
        Me.Controls.Add(ITEMS_DELIVEREDLabel)
        Me.Controls.Add(Me.ITEMS_DELIVEREDTextBox)
        Me.Controls.Add(PHONELabel)
        Me.Controls.Add(Me.PHONETextBox)
        Me.Controls.Add(DATE_OF_DELIVERYLabel)
        Me.Controls.Add(Me.DATE_OF_DELIVERYTextBox)
        Me.Controls.Add(Me.SUPPLIER_DETAILSBindingNavigator)
        Me.Name = "Suppliers_Details"
        Me.Text = "Suppliers_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SUPPLIER_DETAILSBindingNavigator.ResumeLayout(False)
        Me.SUPPLIER_DETAILSBindingNavigator.PerformLayout()
        Me.ReportGroupBox.ResumeLayout(False)
        Me.ReportGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents SUPPLIER_DETAILSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SUPPLIER_DETAILSTableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.SUPPLIER_DETAILSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SUPPLIER_DETAILSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SUPPLIER_DETAILSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents COMPANY_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SUPPLIERS_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONTACT_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONTACT_TITLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITEMS_DELIVEREDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PHONETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_OF_DELIVERYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents BtnDisplayReport As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnSupplierRecordNavigationForm As System.Windows.Forms.Button
    Friend WithEvents ReportGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtReport As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
