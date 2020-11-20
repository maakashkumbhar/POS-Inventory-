<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockFrm
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
        Dim Stock_IDLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim Stock_AmountLabel As System.Windows.Forms.Label
        Dim Stock_In_DateLabel As System.Windows.Forms.Label
        Dim Vendor_NameLabel As System.Windows.Forms.Label
        Dim Vendor_GSTINLabel As System.Windows.Forms.Label
        Dim Vendor_ContactLabel As System.Windows.Forms.Label
        Dim Total_PaidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockFrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StockBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InturnDataSet = New Inventor.InturnDataSet()
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
        Me.StockBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_In_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Vendor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_GSTINTextBox = New System.Windows.Forms.TextBox()
        Me.Vendor_ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchProductsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Product_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Product_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchProductsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StockTableAdapter = New Inventor.InturnDataSetTableAdapters.StockTableAdapter()
        Me.TableAdapterManager = New Inventor.InturnDataSetTableAdapters.TableAdapterManager()
        Me.ProductsTableAdapter = New Inventor.InturnDataSetTableAdapters.ProductsTableAdapter()
        Stock_IDLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        Stock_AmountLabel = New System.Windows.Forms.Label()
        Stock_In_DateLabel = New System.Windows.Forms.Label()
        Vendor_NameLabel = New System.Windows.Forms.Label()
        Vendor_GSTINLabel = New System.Windows.Forms.Label()
        Vendor_ContactLabel = New System.Windows.Forms.Label()
        Total_PaidLabel = New System.Windows.Forms.Label()
        CType(Me.StockBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StockBindingNavigator.SuspendLayout()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InturnDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchProductsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Stock_IDLabel
        '
        Stock_IDLabel.AutoSize = True
        Stock_IDLabel.Location = New System.Drawing.Point(187, 67)
        Stock_IDLabel.Name = "Stock_IDLabel"
        Stock_IDLabel.Size = New System.Drawing.Size(52, 13)
        Stock_IDLabel.TabIndex = 3
        Stock_IDLabel.Text = "Stock ID:"
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(185, 111)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(78, 13)
        Product_NameLabel.TabIndex = 5
        Product_NameLabel.Text = "Product Name:"
        '
        'Stock_AmountLabel
        '
        Stock_AmountLabel.AutoSize = True
        Stock_AmountLabel.Location = New System.Drawing.Point(187, 155)
        Stock_AmountLabel.Name = "Stock_AmountLabel"
        Stock_AmountLabel.Size = New System.Drawing.Size(77, 13)
        Stock_AmountLabel.TabIndex = 7
        Stock_AmountLabel.Text = "Stock Amount:"
        '
        'Stock_In_DateLabel
        '
        Stock_In_DateLabel.AutoSize = True
        Stock_In_DateLabel.Location = New System.Drawing.Point(187, 204)
        Stock_In_DateLabel.Name = "Stock_In_DateLabel"
        Stock_In_DateLabel.Size = New System.Drawing.Size(76, 13)
        Stock_In_DateLabel.TabIndex = 9
        Stock_In_DateLabel.Text = "Stock In Date:"
        '
        'Vendor_NameLabel
        '
        Vendor_NameLabel.AutoSize = True
        Vendor_NameLabel.Location = New System.Drawing.Point(594, 67)
        Vendor_NameLabel.Name = "Vendor_NameLabel"
        Vendor_NameLabel.Size = New System.Drawing.Size(75, 13)
        Vendor_NameLabel.TabIndex = 11
        Vendor_NameLabel.Text = "Vendor Name:"
        '
        'Vendor_GSTINLabel
        '
        Vendor_GSTINLabel.AutoSize = True
        Vendor_GSTINLabel.Location = New System.Drawing.Point(594, 115)
        Vendor_GSTINLabel.Name = "Vendor_GSTINLabel"
        Vendor_GSTINLabel.Size = New System.Drawing.Size(80, 13)
        Vendor_GSTINLabel.TabIndex = 13
        Vendor_GSTINLabel.Text = "Vendor GSTIN:"
        '
        'Vendor_ContactLabel
        '
        Vendor_ContactLabel.AutoSize = True
        Vendor_ContactLabel.Location = New System.Drawing.Point(594, 159)
        Vendor_ContactLabel.Name = "Vendor_ContactLabel"
        Vendor_ContactLabel.Size = New System.Drawing.Size(84, 13)
        Vendor_ContactLabel.TabIndex = 15
        Vendor_ContactLabel.Text = "Vendor Contact:"
        '
        'Total_PaidLabel
        '
        Total_PaidLabel.AutoSize = True
        Total_PaidLabel.Location = New System.Drawing.Point(594, 207)
        Total_PaidLabel.Name = "Total_PaidLabel"
        Total_PaidLabel.Size = New System.Drawing.Size(58, 13)
        Total_PaidLabel.TabIndex = 17
        Total_PaidLabel.Text = "Total Paid:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 732)
        Me.Panel1.TabIndex = 0
        '
        'StockBindingNavigator
        '
        Me.StockBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StockBindingNavigator.BindingSource = Me.StockBindingSource
        Me.StockBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StockBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StockBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StockBindingNavigatorSaveItem})
        Me.StockBindingNavigator.Location = New System.Drawing.Point(146, 0)
        Me.StockBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StockBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StockBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StockBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StockBindingNavigator.Name = "StockBindingNavigator"
        Me.StockBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StockBindingNavigator.Size = New System.Drawing.Size(1301, 25)
        Me.StockBindingNavigator.TabIndex = 1
        Me.StockBindingNavigator.Text = "BindingNavigator1"
        Me.StockBindingNavigator.Visible = False
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
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.InturnDataSet
        '
        'InturnDataSet
        '
        Me.InturnDataSet.DataSetName = "InturnDataSet"
        Me.InturnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'StockBindingNavigatorSaveItem
        '
        Me.StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StockBindingNavigatorSaveItem.Image = CType(resources.GetObject("StockBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StockBindingNavigatorSaveItem.Name = "StockBindingNavigatorSaveItem"
        Me.StockBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StockBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AllowUserToAddRows = False
        Me.StockDataGridView.AllowUserToDeleteRows = False
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(153, 288)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.ReadOnly = True
        Me.StockDataGridView.Size = New System.Drawing.Size(876, 394)
        Me.StockDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Stock_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Stock_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 77
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Stock_Amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Stock_Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Stock_In Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Stock_In Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 101
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Vendor_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vendor_Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Vendor_GSTIN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Vendor_GSTIN"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Vendor_Contact"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Vendor_Contact"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total_Paid"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total_Paid"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Stock_IDTextBox
        '
        Me.Stock_IDTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Stock_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Stock_ID", True))
        Me.Stock_IDTextBox.Location = New System.Drawing.Point(271, 67)
        Me.Stock_IDTextBox.Name = "Stock_IDTextBox"
        Me.Stock_IDTextBox.Size = New System.Drawing.Size(239, 20)
        Me.Stock_IDTextBox.TabIndex = 4
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Product_Name", True))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(271, 108)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(239, 20)
        Me.Product_NameTextBox.TabIndex = 6
        '
        'Stock_AmountTextBox
        '
        Me.Stock_AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Stock_Amount", True))
        Me.Stock_AmountTextBox.Location = New System.Drawing.Point(271, 148)
        Me.Stock_AmountTextBox.Name = "Stock_AmountTextBox"
        Me.Stock_AmountTextBox.Size = New System.Drawing.Size(239, 20)
        Me.Stock_AmountTextBox.TabIndex = 8
        '
        'Stock_In_DateDateTimePicker
        '
        Me.Stock_In_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StockBindingSource, "Stock_In Date", True))
        Me.Stock_In_DateDateTimePicker.Location = New System.Drawing.Point(271, 197)
        Me.Stock_In_DateDateTimePicker.Name = "Stock_In_DateDateTimePicker"
        Me.Stock_In_DateDateTimePicker.Size = New System.Drawing.Size(239, 20)
        Me.Stock_In_DateDateTimePicker.TabIndex = 10
        '
        'Vendor_NameTextBox
        '
        Me.Vendor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Vendor_Name", True))
        Me.Vendor_NameTextBox.Location = New System.Drawing.Point(708, 60)
        Me.Vendor_NameTextBox.Name = "Vendor_NameTextBox"
        Me.Vendor_NameTextBox.Size = New System.Drawing.Size(256, 20)
        Me.Vendor_NameTextBox.TabIndex = 12
        '
        'Vendor_GSTINTextBox
        '
        Me.Vendor_GSTINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Vendor_GSTIN", True))
        Me.Vendor_GSTINTextBox.Location = New System.Drawing.Point(708, 108)
        Me.Vendor_GSTINTextBox.Name = "Vendor_GSTINTextBox"
        Me.Vendor_GSTINTextBox.Size = New System.Drawing.Size(256, 20)
        Me.Vendor_GSTINTextBox.TabIndex = 14
        '
        'Vendor_ContactTextBox
        '
        Me.Vendor_ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Vendor_Contact", True))
        Me.Vendor_ContactTextBox.Location = New System.Drawing.Point(708, 156)
        Me.Vendor_ContactTextBox.Name = "Vendor_ContactTextBox"
        Me.Vendor_ContactTextBox.Size = New System.Drawing.Size(256, 20)
        Me.Vendor_ContactTextBox.TabIndex = 16
        '
        'Total_PaidTextBox
        '
        Me.Total_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Total_Paid", True))
        Me.Total_PaidTextBox.Location = New System.Drawing.Point(708, 207)
        Me.Total_PaidTextBox.Name = "Total_PaidTextBox"
        Me.Total_PaidTextBox.Size = New System.Drawing.Size(256, 20)
        Me.Total_PaidTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Image = Global.Inventor.My.Resources.Resources.icons8_add_new_80
        Me.Button1.Location = New System.Drawing.Point(1030, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 111)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "New Stock"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Inventor.My.Resources.Resources.icons8_save_100
        Me.Button2.Location = New System.Drawing.Point(1030, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 108)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Save"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Inventor.My.Resources.Resources.icons8_delete_100
        Me.Button3.Location = New System.Drawing.Point(1156, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 111)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Inventor.My.Resources.Resources.icons8_close_window_100
        Me.Button4.Location = New System.Drawing.Point(1156, 155)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 108)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Exit"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(696, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Stock Maintainance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.ProductsDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(1032, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 404)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(157, 371)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 27)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Search Products:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(276, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(97, 22)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(173, 20)
        Me.TextBox6.TabIndex = 15
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.AllowUserToAddRows = False
        Me.ProductsDataGridView.AllowUserToDeleteRows = False
        Me.ProductsDataGridView.AutoGenerateColumns = False
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.ProductsDataGridView.DataSource = Me.ProductsBindingSource
        Me.ProductsDataGridView.Location = New System.Drawing.Point(5, 51)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.ReadOnly = True
        Me.ProductsDataGridView.Size = New System.Drawing.Size(350, 314)
        Me.ProductsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Product_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Product_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Product_Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.InturnDataSet
        '
        'SearchProductsToolStrip
        '
        Me.SearchProductsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Product_NameToolStripLabel, Me.Product_NameToolStripTextBox, Me.SearchProductsToolStripButton})
        Me.SearchProductsToolStrip.Location = New System.Drawing.Point(146, 0)
        Me.SearchProductsToolStrip.Name = "SearchProductsToolStrip"
        Me.SearchProductsToolStrip.Size = New System.Drawing.Size(1253, 25)
        Me.SearchProductsToolStrip.TabIndex = 25
        Me.SearchProductsToolStrip.Text = "SearchProductsToolStrip"
        Me.SearchProductsToolStrip.Visible = False
        '
        'Product_NameToolStripLabel
        '
        Me.Product_NameToolStripLabel.Name = "Product_NameToolStripLabel"
        Me.Product_NameToolStripLabel.Size = New System.Drawing.Size(89, 22)
        Me.Product_NameToolStripLabel.Text = "Product_Name:"
        '
        'Product_NameToolStripTextBox
        '
        Me.Product_NameToolStripTextBox.Name = "Product_NameToolStripTextBox"
        Me.Product_NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SearchProductsToolStripButton
        '
        Me.SearchProductsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchProductsToolStripButton.Name = "SearchProductsToolStripButton"
        Me.SearchProductsToolStripButton.Size = New System.Drawing.Size(92, 22)
        Me.SearchProductsToolStripButton.Text = "searchProducts"
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.StockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = Inventor.InturnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'StockFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.SearchProductsToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Total_PaidLabel)
        Me.Controls.Add(Me.Total_PaidTextBox)
        Me.Controls.Add(Vendor_ContactLabel)
        Me.Controls.Add(Me.Vendor_ContactTextBox)
        Me.Controls.Add(Vendor_GSTINLabel)
        Me.Controls.Add(Me.Vendor_GSTINTextBox)
        Me.Controls.Add(Vendor_NameLabel)
        Me.Controls.Add(Me.Vendor_NameTextBox)
        Me.Controls.Add(Stock_In_DateLabel)
        Me.Controls.Add(Me.Stock_In_DateDateTimePicker)
        Me.Controls.Add(Stock_AmountLabel)
        Me.Controls.Add(Me.Stock_AmountTextBox)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Product_NameTextBox)
        Me.Controls.Add(Stock_IDLabel)
        Me.Controls.Add(Me.Stock_IDTextBox)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(Me.StockBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StockFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StockBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StockBindingNavigator.ResumeLayout(False)
        Me.StockBindingNavigator.PerformLayout()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InturnDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchProductsToolStrip.ResumeLayout(False)
        Me.SearchProductsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents InturnDataSet As Inventor.InturnDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As Inventor.InturnDataSetTableAdapters.StockTableAdapter
    Friend WithEvents TableAdapterManager As Inventor.InturnDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StockBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Product_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_In_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Vendor_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_GSTINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_PaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Inventor.InturnDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents SearchProductsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Product_NameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Product_NameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchProductsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
