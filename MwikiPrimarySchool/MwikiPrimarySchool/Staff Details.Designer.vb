<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Details
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
        Dim TITLELabel As System.Windows.Forms.Label
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim LAST_NAMELabel As System.Windows.Forms.Label
        Dim STAFF_IDLabel As System.Windows.Forms.Label
        Dim TEACHINGLabel As System.Windows.Forms.Label
        Dim HODLabel As System.Windows.Forms.Label
        Dim SUBJECTLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim TEL_NOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Details))
        Me.MwikiprimaryimsDataSet = New WindowsApplication1.mwikiprimaryimsDataSet()
        Me.STAFF_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFF_DETAILSTableAdapter = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.STAFF_DETAILSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager()
        Me.STAFF_DETAILSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.STAFF_DETAILSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.STAFF_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TEACHINGCheckBox = New System.Windows.Forms.CheckBox()
        Me.HODTextBox = New System.Windows.Forms.TextBox()
        Me.SUBJECTTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.TEL_NOTextBox = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.BtnFirstRecord = New System.Windows.Forms.Button()
        Me.BtnstaffRecordNavigationForm = New System.Windows.Forms.Button()
        TITLELabel = New System.Windows.Forms.Label()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        LAST_NAMELabel = New System.Windows.Forms.Label()
        STAFF_IDLabel = New System.Windows.Forms.Label()
        TEACHINGLabel = New System.Windows.Forms.Label()
        HODLabel = New System.Windows.Forms.Label()
        SUBJECTLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        TEL_NOLabel = New System.Windows.Forms.Label()
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFF_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFF_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STAFF_DETAILSBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Location = New System.Drawing.Point(12, 40)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(40, 13)
        TITLELabel.TabIndex = 1
        TITLELabel.Text = "TITLE:"
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(12, 66)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(75, 13)
        FIRST_NAMELabel.TabIndex = 3
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'LAST_NAMELabel
        '
        LAST_NAMELabel.AutoSize = True
        LAST_NAMELabel.Location = New System.Drawing.Point(12, 92)
        LAST_NAMELabel.Name = "LAST_NAMELabel"
        LAST_NAMELabel.Size = New System.Drawing.Size(71, 13)
        LAST_NAMELabel.TabIndex = 5
        LAST_NAMELabel.Text = "LAST NAME:"
        '
        'STAFF_IDLabel
        '
        STAFF_IDLabel.AutoSize = True
        STAFF_IDLabel.Location = New System.Drawing.Point(12, 118)
        STAFF_IDLabel.Name = "STAFF_IDLabel"
        STAFF_IDLabel.Size = New System.Drawing.Size(57, 13)
        STAFF_IDLabel.TabIndex = 7
        STAFF_IDLabel.Text = "STAFF ID:"
        '
        'TEACHINGLabel
        '
        TEACHINGLabel.AutoSize = True
        TEACHINGLabel.Location = New System.Drawing.Point(12, 146)
        TEACHINGLabel.Name = "TEACHINGLabel"
        TEACHINGLabel.Size = New System.Drawing.Size(65, 13)
        TEACHINGLabel.TabIndex = 9
        TEACHINGLabel.Text = "TEACHING:"
        '
        'HODLabel
        '
        HODLabel.AutoSize = True
        HODLabel.Location = New System.Drawing.Point(12, 174)
        HODLabel.Name = "HODLabel"
        HODLabel.Size = New System.Drawing.Size(34, 13)
        HODLabel.TabIndex = 11
        HODLabel.Text = "HOD:"
        '
        'SUBJECTLabel
        '
        SUBJECTLabel.AutoSize = True
        SUBJECTLabel.Location = New System.Drawing.Point(12, 200)
        SUBJECTLabel.Name = "SUBJECTLabel"
        SUBJECTLabel.Size = New System.Drawing.Size(58, 13)
        SUBJECTLabel.TabIndex = 13
        SUBJECTLabel.Text = "SUBJECT:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(12, 226)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 15
        DOBLabel.Text = "DOB:"
        '
        'TEL_NOLabel
        '
        TEL_NOLabel.AutoSize = True
        TEL_NOLabel.Location = New System.Drawing.Point(12, 252)
        TEL_NOLabel.Name = "TEL_NOLabel"
        TEL_NOLabel.Size = New System.Drawing.Size(49, 13)
        TEL_NOLabel.TabIndex = 17
        TEL_NOLabel.Text = "TEL NO:"
        '
        'MwikiprimaryimsDataSet
        '
        Me.MwikiprimaryimsDataSet.DataSetName = "mwikiprimaryimsDataSet"
        Me.MwikiprimaryimsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STAFF_DETAILSBindingSource
        '
        Me.STAFF_DETAILSBindingSource.DataMember = "STAFF DETAILS"
        Me.STAFF_DETAILSBindingSource.DataSource = Me.MwikiprimaryimsDataSet
        '
        'STAFF_DETAILSTableAdapter
        '
        Me.STAFF_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CATEGORY_TABLETableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTS_TABLETableAdapter = Nothing
        Me.TableAdapterManager.HEAD_OF_DEPARTMENT_TABLETableAdapter = Nothing
        Me.TableAdapterManager.ITEMS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.REQUISITION_ORDER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.STAFF_DETAILSTableAdapter = Me.STAFF_DETAILSTableAdapter
        Me.TableAdapterManager.STORES_TABLETableAdapter = Nothing
        Me.TableAdapterManager.STUDENTS_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.SUPPLIER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'STAFF_DETAILSBindingNavigator
        '
        Me.STAFF_DETAILSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.STAFF_DETAILSBindingNavigator.BindingSource = Me.STAFF_DETAILSBindingSource
        Me.STAFF_DETAILSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.STAFF_DETAILSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.STAFF_DETAILSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.STAFF_DETAILSBindingNavigatorSaveItem})
        Me.STAFF_DETAILSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.STAFF_DETAILSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.STAFF_DETAILSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.STAFF_DETAILSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.STAFF_DETAILSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.STAFF_DETAILSBindingNavigator.Name = "STAFF_DETAILSBindingNavigator"
        Me.STAFF_DETAILSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.STAFF_DETAILSBindingNavigator.Size = New System.Drawing.Size(740, 25)
        Me.STAFF_DETAILSBindingNavigator.TabIndex = 0
        Me.STAFF_DETAILSBindingNavigator.Text = "BindingNavigator1"
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
        'STAFF_DETAILSBindingNavigatorSaveItem
        '
        Me.STAFF_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.STAFF_DETAILSBindingNavigatorSaveItem.Image = CType(resources.GetObject("STAFF_DETAILSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.STAFF_DETAILSBindingNavigatorSaveItem.Name = "STAFF_DETAILSBindingNavigatorSaveItem"
        Me.STAFF_DETAILSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.STAFF_DETAILSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "TITLE", True))
        Me.TITLETextBox.Location = New System.Drawing.Point(93, 37)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(104, 20)
        Me.TITLETextBox.TabIndex = 2
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "FIRST NAME", True))
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(93, 63)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(104, 20)
        Me.FIRST_NAMETextBox.TabIndex = 4
        '
        'LAST_NAMETextBox
        '
        Me.LAST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "LAST NAME", True))
        Me.LAST_NAMETextBox.Location = New System.Drawing.Point(93, 89)
        Me.LAST_NAMETextBox.Name = "LAST_NAMETextBox"
        Me.LAST_NAMETextBox.Size = New System.Drawing.Size(104, 20)
        Me.LAST_NAMETextBox.TabIndex = 6
        '
        'STAFF_IDTextBox
        '
        Me.STAFF_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "STAFF ID", True))
        Me.STAFF_IDTextBox.Location = New System.Drawing.Point(93, 115)
        Me.STAFF_IDTextBox.Name = "STAFF_IDTextBox"
        Me.STAFF_IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.STAFF_IDTextBox.TabIndex = 8
        '
        'TEACHINGCheckBox
        '
        Me.TEACHINGCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.STAFF_DETAILSBindingSource, "TEACHING", True))
        Me.TEACHINGCheckBox.Location = New System.Drawing.Point(93, 141)
        Me.TEACHINGCheckBox.Name = "TEACHINGCheckBox"
        Me.TEACHINGCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.TEACHINGCheckBox.TabIndex = 10
        Me.TEACHINGCheckBox.UseVisualStyleBackColor = True
        '
        'HODTextBox
        '
        Me.HODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "HOD", True))
        Me.HODTextBox.Location = New System.Drawing.Point(93, 171)
        Me.HODTextBox.Name = "HODTextBox"
        Me.HODTextBox.Size = New System.Drawing.Size(104, 20)
        Me.HODTextBox.TabIndex = 12
        '
        'SUBJECTTextBox
        '
        Me.SUBJECTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "SUBJECT", True))
        Me.SUBJECTTextBox.Location = New System.Drawing.Point(93, 197)
        Me.SUBJECTTextBox.Name = "SUBJECTTextBox"
        Me.SUBJECTTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SUBJECTTextBox.TabIndex = 14
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "DOB", True))
        Me.DOBTextBox.Location = New System.Drawing.Point(93, 223)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DOBTextBox.TabIndex = 16
        '
        'TEL_NOTextBox
        '
        Me.TEL_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STAFF_DETAILSBindingSource, "TEL NO", True))
        Me.TEL_NOTextBox.Location = New System.Drawing.Point(93, 249)
        Me.TEL_NOTextBox.Name = "TEL_NOTextBox"
        Me.TEL_NOTextBox.Size = New System.Drawing.Size(104, 20)
        Me.TEL_NOTextBox.TabIndex = 18
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(142, 372)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 38
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(276, 372)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 24)
        Me.BtnSave.TabIndex = 37
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Location = New System.Drawing.Point(142, 301)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(78, 24)
        Me.BtnPrevious.TabIndex = 36
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(276, 301)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(78, 24)
        Me.BtnNext.TabIndex = 35
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.Location = New System.Drawing.Point(436, 301)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnLastRecord.TabIndex = 34
        Me.BtnLastRecord.Text = "Last Record"
        Me.BtnLastRecord.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(16, 372)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(78, 24)
        Me.BtnAddnew.TabIndex = 33
        Me.BtnAddnew.Text = "Add New"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'BtnFirstRecord
        '
        Me.BtnFirstRecord.Location = New System.Drawing.Point(15, 301)
        Me.BtnFirstRecord.Name = "BtnFirstRecord"
        Me.BtnFirstRecord.Size = New System.Drawing.Size(78, 24)
        Me.BtnFirstRecord.TabIndex = 32
        Me.BtnFirstRecord.Text = "First Record"
        Me.BtnFirstRecord.UseVisualStyleBackColor = True
        '
        'BtnstaffRecordNavigationForm
        '
        Me.BtnstaffRecordNavigationForm.Location = New System.Drawing.Point(506, 347)
        Me.BtnstaffRecordNavigationForm.Name = "BtnstaffRecordNavigationForm"
        Me.BtnstaffRecordNavigationForm.Size = New System.Drawing.Size(160, 31)
        Me.BtnstaffRecordNavigationForm.TabIndex = 31
        Me.BtnstaffRecordNavigationForm.Text = "Record Navigation Form"
        Me.BtnstaffRecordNavigationForm.UseVisualStyleBackColor = True
        '
        'Staff_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 437)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.BtnFirstRecord)
        Me.Controls.Add(Me.BtnstaffRecordNavigationForm)
        Me.Controls.Add(TITLELabel)
        Me.Controls.Add(Me.TITLETextBox)
        Me.Controls.Add(FIRST_NAMELabel)
        Me.Controls.Add(Me.FIRST_NAMETextBox)
        Me.Controls.Add(LAST_NAMELabel)
        Me.Controls.Add(Me.LAST_NAMETextBox)
        Me.Controls.Add(STAFF_IDLabel)
        Me.Controls.Add(Me.STAFF_IDTextBox)
        Me.Controls.Add(TEACHINGLabel)
        Me.Controls.Add(Me.TEACHINGCheckBox)
        Me.Controls.Add(HODLabel)
        Me.Controls.Add(Me.HODTextBox)
        Me.Controls.Add(SUBJECTLabel)
        Me.Controls.Add(Me.SUBJECTTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBTextBox)
        Me.Controls.Add(TEL_NOLabel)
        Me.Controls.Add(Me.TEL_NOTextBox)
        Me.Controls.Add(Me.STAFF_DETAILSBindingNavigator)
        Me.Name = "Staff_Details"
        Me.Text = "Staff_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MwikiprimaryimsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFF_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFF_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STAFF_DETAILSBindingNavigator.ResumeLayout(False)
        Me.STAFF_DETAILSBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MwikiprimaryimsDataSet As WindowsApplication1.mwikiprimaryimsDataSet
    Friend WithEvents STAFF_DETAILSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STAFF_DETAILSTableAdapter As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.STAFF_DETAILSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.mwikiprimaryimsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents STAFF_DETAILSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents STAFF_DETAILSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TITLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIRST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LAST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents STAFF_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TEACHINGCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SUBJECTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TEL_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLastRecord As System.Windows.Forms.Button
    Friend WithEvents BtnAddnew As System.Windows.Forms.Button
    Friend WithEvents BtnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents BtnstaffRecordNavigationForm As System.Windows.Forms.Button
End Class
