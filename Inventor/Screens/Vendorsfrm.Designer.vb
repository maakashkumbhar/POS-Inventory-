<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendorsfrm
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
        Dim Vendors_IDLabel As System.Windows.Forms.Label
        Dim Vendor_nameLabel As System.Windows.Forms.Label
        Dim Vendor_AddressLabel As System.Windows.Forms.Label
        Dim Vendor_ContactLabel As System.Windows.Forms.Label
        Dim Vendor_GSTINLabel As System.Windows.Forms.Label
        Dim Vendor_EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendorsfrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InturnDataSet = New Inventor.InturnDataSet()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorsTableAdapter = New Inventor.InturnDataSetTableAdapters.VendorsTableAdapter()
        Me.TableAdapterManager = New Inventor.InturnDataSetTableAdapters.TableAdapterManager()
        Me.VendorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VendorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VendorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendors_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_GSTINTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Vendors_IDLabel = New System.Windows.Forms.Label()
        Vendor_nameLabel = New System.Windows.Forms.Label()
        Vendor_AddressLabel = New System.Windows.Forms.Label()
        Vendor_ContactLabel = New System.Windows.Forms.Label()
        Vendor_GSTINLabel = New System.Windows.Forms.Label()
        Vendor_EmailLabel = New System.Windows.Forms.Label()
        CType(Me.InturnDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendorsBindingNavigator.SuspendLayout()
        CType(Me.VendorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vendors_IDLabel
        '
        Vendors_IDLabel.AutoSize = True
        Vendors_IDLabel.Location = New System.Drawing.Point(206, 90)
        Vendors_IDLabel.Name = "Vendors_IDLabel"
        Vendors_IDLabel.Size = New System.Drawing.Size(63, 13)
        Vendors_IDLabel.TabIndex = 3
        Vendors_IDLabel.Text = "Vendors ID:"
        '
        'Vendor_nameLabel
        '
        Vendor_nameLabel.AutoSize = True
        Vendor_nameLabel.Location = New System.Drawing.Point(206, 138)
        Vendor_nameLabel.Name = "Vendor_nameLabel"
        Vendor_nameLabel.Size = New System.Drawing.Size(73, 13)
        Vendor_nameLabel.TabIndex = 5
        Vendor_nameLabel.Text = "Vendor name:"
        '
        'Vendor_AddressLabel
        '
        Vendor_AddressLabel.AutoSize = True
        Vendor_AddressLabel.Location = New System.Drawing.Point(206, 192)
        Vendor_AddressLabel.Name = "Vendor_AddressLabel"
        Vendor_AddressLabel.Size = New System.Drawing.Size(85, 13)
        Vendor_AddressLabel.TabIndex = 7
        Vendor_AddressLabel.Text = "Vendor Address:"
        '
        'Vendor_ContactLabel
        '
        Vendor_ContactLabel.AutoSize = True
        Vendor_ContactLabel.Location = New System.Drawing.Point(652, 90)
        Vendor_ContactLabel.Name = "Vendor_ContactLabel"
        Vendor_ContactLabel.Size = New System.Drawing.Size(84, 13)
        Vendor_ContactLabel.TabIndex = 9
        Vendor_ContactLabel.Text = "Vendor Contact:"
        '
        'Vendor_GSTINLabel
        '
        Vendor_GSTINLabel.AutoSize = True
        Vendor_GSTINLabel.Location = New System.Drawing.Point(652, 192)
        Vendor_GSTINLabel.Name = "Vendor_GSTINLabel"
        Vendor_GSTINLabel.Size = New System.Drawing.Size(80, 13)
        Vendor_GSTINLabel.TabIndex = 11
        Vendor_GSTINLabel.Text = "Vendor GSTIN:"
        '
        'Vendor_EmailLabel
        '
        Vendor_EmailLabel.AutoSize = True
        Vendor_EmailLabel.Location = New System.Drawing.Point(652, 138)
        Vendor_EmailLabel.Name = "Vendor_EmailLabel"
        Vendor_EmailLabel.Size = New System.Drawing.Size(72, 13)
        Vendor_EmailLabel.TabIndex = 13
        Vendor_EmailLabel.Text = "Vendor Email:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 678)
        Me.Panel1.TabIndex = 0
        '
        'InturnDataSet
        '
        Me.InturnDataSet.DataSetName = "InturnDataSet"
        Me.InturnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorsBindingSource
        '
        Me.VendorsBindingSource.DataMember = "Vendors"
        Me.VendorsBindingSource.DataSource = Me.InturnDataSet
        '
        'VendorsTableAdapter
        '
        Me.VendorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.StockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Inventor.InturnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Me.VendorsTableAdapter
        '
        'VendorsBindingNavigator
        '
        Me.VendorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VendorsBindingNavigator.BindingSource = Me.VendorsBindingSource
        Me.VendorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VendorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VendorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VendorsBindingNavigatorSaveItem})
        Me.VendorsBindingNavigator.Location = New System.Drawing.Point(155, 0)
        Me.VendorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VendorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VendorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VendorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VendorsBindingNavigator.Name = "VendorsBindingNavigator"
        Me.VendorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VendorsBindingNavigator.Size = New System.Drawing.Size(1040, 25)
        Me.VendorsBindingNavigator.TabIndex = 1
        Me.VendorsBindingNavigator.Text = "BindingNavigator1"
        Me.VendorsBindingNavigator.Visible = False
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
        'VendorsBindingNavigatorSaveItem
        '
        Me.VendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VendorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("VendorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VendorsBindingNavigatorSaveItem.Name = "VendorsBindingNavigatorSaveItem"
        Me.VendorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VendorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VendorsDataGridView
        '
        Me.VendorsDataGridView.AllowUserToAddRows = False
        Me.VendorsDataGridView.AllowUserToDeleteRows = False
        Me.VendorsDataGridView.AutoGenerateColumns = False
        Me.VendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VendorsDataGridView.DataSource = Me.VendorsBindingSource
        Me.VendorsDataGridView.Location = New System.Drawing.Point(161, 346)
        Me.VendorsDataGridView.Name = "VendorsDataGridView"
        Me.VendorsDataGridView.ReadOnly = True
        Me.VendorsDataGridView.Size = New System.Drawing.Size(1014, 320)
        Me.VendorsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Vendors_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Vendors_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 88
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Vendor_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Vendor_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Vendor_Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Vendor_Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Vendor_Contact"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vendor_Contact"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 109
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Vendor_GSTIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vendor_GSTIN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Vendor_Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Vendor_Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Vendors_IDTextBox
        '
        Me.Vendors_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Vendors_ID", True))
        Me.Vendors_IDTextBox.Location = New System.Drawing.Point(297, 87)
        Me.Vendors_IDTextBox.Name = "Vendors_IDTextBox"
        Me.Vendors_IDTextBox.Size = New System.Drawing.Size(277, 20)
        Me.Vendors_IDTextBox.TabIndex = 4
        '
        'Vendor_nameTextBox
        '
        Me.Vendor_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Vendor_name", True))
        Me.Vendor_nameTextBox.Location = New System.Drawing.Point(297, 135)
        Me.Vendor_nameTextBox.Name = "Vendor_nameTextBox"
        Me.Vendor_nameTextBox.Size = New System.Drawing.Size(277, 20)
        Me.Vendor_nameTextBox.TabIndex = 6
        '
        'Vendor_AddressTextBox
        '
        Me.Vendor_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Vendor_Address", True))
        Me.Vendor_AddressTextBox.Location = New System.Drawing.Point(297, 188)
        Me.Vendor_AddressTextBox.Name = "Vendor_AddressTextBox"
        Me.Vendor_AddressTextBox.Size = New System.Drawing.Size(277, 20)
        Me.Vendor_AddressTextBox.TabIndex = 8
        '
        'Vendor_ContactTextBox
        '
        Me.Vendor_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Vendor_Contact", True))
        Me.Vendor_ContactTextBox.Location = New System.Drawing.Point(756, 94)
        Me.Vendor_ContactTextBox.Name = "Vendor_ContactTextBox"
        Me.Vendor_ContactTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Vendor_ContactTextBox.TabIndex = 10
        '
        'Vendor_GSTINTextBox
        '
        Me.Vendor_GSTINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Vendor_GSTIN", True))
        Me.Vendor_GSTINTextBox.Location = New System.Drawing.Point(756, 185)
        Me.Vendor_GSTINTextBox.Name = "Vendor_GSTINTextBox"
        Me.Vendor_GSTINTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Vendor_GSTINTextBox.TabIndex = 12
        '
        'Vendor_EmailTextBox
        '
        Me.Vendor_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Vendor_Email", True))
        Me.Vendor_EmailTextBox.Location = New System.Drawing.Point(756, 138)
        Me.Vendor_EmailTextBox.Name = "Vendor_EmailTextBox"
        Me.Vendor_EmailTextBox.Size = New System.Drawing.Size(281, 20)
        Me.Vendor_EmailTextBox.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Image = Global.Inventor.My.Resources.Resources.icons8_save_100
        Me.Button2.Location = New System.Drawing.Point(494, 231)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 106)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Save"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Inventor.My.Resources.Resources.icons8_delete_100
        Me.Button3.Location = New System.Drawing.Point(708, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 105)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Delete"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Inventor.My.Resources.Resources.icons8_close_window_100
        Me.Button4.Location = New System.Drawing.Point(931, 231)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 105)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Exit"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Inventor.My.Resources.Resources.icons8_add_user_male_80
        Me.Button1.Location = New System.Drawing.Point(297, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 97)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Add New "
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(623, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Vendors "
        '
        'Vendorsfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 678)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Vendor_EmailLabel)
        Me.Controls.Add(Me.Vendor_EmailTextBox)
        Me.Controls.Add(Vendor_GSTINLabel)
        Me.Controls.Add(Me.Vendor_GSTINTextBox)
        Me.Controls.Add(Vendor_ContactLabel)
        Me.Controls.Add(Me.Vendor_ContactTextBox)
        Me.Controls.Add(Vendor_AddressLabel)
        Me.Controls.Add(Me.Vendor_AddressTextBox)
        Me.Controls.Add(Vendor_nameLabel)
        Me.Controls.Add(Me.Vendor_nameTextBox)
        Me.Controls.Add(Vendors_IDLabel)
        Me.Controls.Add(Me.Vendors_IDTextBox)
        Me.Controls.Add(Me.VendorsDataGridView)
        Me.Controls.Add(Me.VendorsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Vendorsfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendorsfrm"
        CType(Me.InturnDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendorsBindingNavigator.ResumeLayout(False)
        Me.VendorsBindingNavigator.PerformLayout()
        CType(Me.VendorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents InturnDataSet As Inventor.InturnDataSet
    Friend WithEvents VendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendorsTableAdapter As Inventor.InturnDataSetTableAdapters.VendorsTableAdapter
    Friend WithEvents TableAdapterManager As Inventor.InturnDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendorsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VendorsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VendorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendors_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_GSTINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
