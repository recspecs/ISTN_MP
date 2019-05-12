<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesRep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesRep))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SalesRepTabControl = New System.Windows.Forms.TabControl()
        Me.ProductTabRep = New System.Windows.Forms.TabPage()
        Me.flpProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditProduct = New System.Windows.Forms.Button()
        Me.btnSaveProduct = New System.Windows.Forms.Button()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.ProductCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdStockLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdVATDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdCategoriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdReorderThresholdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecSpecDataset = New MenuForms.RecSpecDataset()
        Me.tlpProduct = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchProduct = New System.Windows.Forms.Button()
        Me.tbQueryProduct = New System.Windows.Forms.TextBox()
        Me.cbCriteriaProduct = New System.Windows.Forms.ComboBox()
        Me.SalesOrderTabRep = New System.Windows.Forms.TabPage()
        Me.flpSOTotal = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblSOTotal = New System.Windows.Forms.Label()
        Me.tbSOTotal = New System.Windows.Forms.TextBox()
        Me.dgvSODetails = New System.Windows.Forms.DataGridView()
        Me.SalesItemLineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleItemQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleItemPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdVATDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKSaleItemSalesOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSODetails = New System.Windows.Forms.Label()
        Me.lblSO = New System.Windows.Forms.Label()
        Me.dgvSO = New System.Windows.Forms.DataGridView()
        Me.SalesOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleOrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpSO = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchSO = New System.Windows.Forms.Button()
        Me.tbQuerySO = New System.Windows.Forms.TextBox()
        Me.cbCriteriaSO = New System.Windows.Forms.ComboBox()
        Me.flpSO = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditSO = New System.Windows.Forms.Button()
        Me.btnSaveSO = New System.Windows.Forms.Button()
        Me.btnRemoveSO = New System.Windows.Forms.Button()
        Me.CustomerTabRep = New System.Windows.Forms.TabPage()
        Me.tlpCustomer = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.tbQueryCustomer = New System.Windows.Forms.TextBox()
        Me.cbCriteriaCustomer = New System.Windows.Forms.ComboBox()
        Me.flpCustomer = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditCustomer = New System.Windows.Forms.Button()
        Me.btnSaveCustomer = New System.Windows.Forms.Button()
        Me.btnRemoveCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sale_ItemTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Sale_ItemTableAdapter()
        Me.CustomerTableTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.CustomerTableTableAdapter()
        Me.Sales_OrderTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Sales_OrderTableAdapter()
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.SalesRepTabControl.SuspendLayout()
        Me.ProductTabRep.SuspendLayout()
        Me.flpProducts.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpProduct.SuspendLayout()
        Me.SalesOrderTabRep.SuspendLayout()
        Me.flpSOTotal.SuspendLayout()
        CType(Me.dgvSODetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSaleItemSalesOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpSO.SuspendLayout()
        Me.flpSO.SuspendLayout()
        Me.CustomerTabRep.SuspendLayout()
        Me.tlpCustomer.SuspendLayout()
        Me.flpCustomer.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesRepTabControl
        '
        Me.SalesRepTabControl.Controls.Add(Me.ProductTabRep)
        Me.SalesRepTabControl.Controls.Add(Me.SalesOrderTabRep)
        Me.SalesRepTabControl.Controls.Add(Me.CustomerTabRep)
        Me.SalesRepTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalesRepTabControl.Location = New System.Drawing.Point(0, 0)
        Me.SalesRepTabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalesRepTabControl.Name = "SalesRepTabControl"
        Me.SalesRepTabControl.SelectedIndex = 0
        Me.SalesRepTabControl.Size = New System.Drawing.Size(1310, 793)
        Me.SalesRepTabControl.TabIndex = 0
        '
        'ProductTabRep
        '
        Me.ProductTabRep.Controls.Add(Me.flpProducts)
        Me.ProductTabRep.Controls.Add(Me.dgvProduct)
        Me.ProductTabRep.Controls.Add(Me.tlpProduct)
        Me.ProductTabRep.Location = New System.Drawing.Point(4, 26)
        Me.ProductTabRep.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.ProductTabRep.Name = "ProductTabRep"
        Me.ProductTabRep.Padding = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.ProductTabRep.Size = New System.Drawing.Size(1302, 763)
        Me.ProductTabRep.TabIndex = 16
        Me.ProductTabRep.Text = "Products"
        Me.ProductTabRep.UseVisualStyleBackColor = True
        '
        'flpProducts
        '
        Me.flpProducts.Controls.Add(Me.btnAddEditProduct)
        Me.flpProducts.Controls.Add(Me.btnSaveProduct)
        Me.flpProducts.Controls.Add(Me.btnRemoveProduct)
        Me.flpProducts.Location = New System.Drawing.Point(232, 20)
        Me.flpProducts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpProducts.Name = "flpProducts"
        Me.flpProducts.Size = New System.Drawing.Size(588, 146)
        Me.flpProducts.TabIndex = 79
        '
        'btnAddEditProduct
        '
        Me.btnAddEditProduct.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditProduct.Image = CType(resources.GetObject("btnAddEditProduct.Image"), System.Drawing.Image)
        Me.btnAddEditProduct.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditProduct.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditProduct.Name = "btnAddEditProduct"
        Me.btnAddEditProduct.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditProduct.TabIndex = 32
        Me.btnAddEditProduct.Text = "Add/Edit"
        Me.btnAddEditProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditProduct.UseCompatibleTextRendering = True
        Me.btnAddEditProduct.UseVisualStyleBackColor = True
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.Image = CType(resources.GetObject("btnSaveProduct.Image"), System.Drawing.Image)
        Me.btnSaveProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveProduct.Location = New System.Drawing.Point(221, 5)
        Me.btnSaveProduct.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnSaveProduct.Size = New System.Drawing.Size(146, 136)
        Me.btnSaveProduct.TabIndex = 30
        Me.btnSaveProduct.Text = "Save"
        Me.btnSaveProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveProduct.UseVisualStyleBackColor = True
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.AutoSize = True
        Me.btnRemoveProduct.Image = CType(resources.GetObject("btnRemoveProduct.Image"), System.Drawing.Image)
        Me.btnRemoveProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveProduct.Location = New System.Drawing.Point(427, 5)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnRemoveProduct.Size = New System.Drawing.Size(146, 136)
        Me.btnRemoveProduct.TabIndex = 31
        Me.btnRemoveProduct.Text = "Remove"
        Me.btnRemoveProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveProduct.UseVisualStyleBackColor = True
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvProduct.AutoGenerateColumns = False
        Me.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCodeDataGridViewTextBoxColumn1, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdCostPriceDataGridViewTextBoxColumn, Me.ProdStockLevelDataGridViewTextBoxColumn, Me.ProdVATDataGridViewCheckBoxColumn1, Me.ProdActiveDataGridViewCheckBoxColumn, Me.ProdCategoriesDataGridViewTextBoxColumn, Me.ProdReorderThresholdDataGridViewTextBoxColumn})
        Me.dgvProduct.DataSource = Me.ProductBindingSource
        Me.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvProduct.Location = New System.Drawing.Point(73, 287)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.Size = New System.Drawing.Size(1000, 410)
        Me.dgvProduct.TabIndex = 78
        '
        'ProductCodeDataGridViewTextBoxColumn1
        '
        Me.ProductCodeDataGridViewTextBoxColumn1.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn1.HeaderText = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn1.Name = "ProductCodeDataGridViewTextBoxColumn1"
        Me.ProductCodeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProdNameDataGridViewTextBoxColumn
        '
        Me.ProdNameDataGridViewTextBoxColumn.DataPropertyName = "Prod_Name"
        Me.ProdNameDataGridViewTextBoxColumn.HeaderText = "Prod_Name"
        Me.ProdNameDataGridViewTextBoxColumn.Name = "ProdNameDataGridViewTextBoxColumn"
        Me.ProdNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdCostPriceDataGridViewTextBoxColumn
        '
        Me.ProdCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Prod_Cost_Price"
        Me.ProdCostPriceDataGridViewTextBoxColumn.HeaderText = "Prod_Cost_Price"
        Me.ProdCostPriceDataGridViewTextBoxColumn.Name = "ProdCostPriceDataGridViewTextBoxColumn"
        Me.ProdCostPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdStockLevelDataGridViewTextBoxColumn
        '
        Me.ProdStockLevelDataGridViewTextBoxColumn.DataPropertyName = "Prod_Stock_Level"
        Me.ProdStockLevelDataGridViewTextBoxColumn.HeaderText = "Prod_Stock_Level"
        Me.ProdStockLevelDataGridViewTextBoxColumn.Name = "ProdStockLevelDataGridViewTextBoxColumn"
        Me.ProdStockLevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdVATDataGridViewCheckBoxColumn1
        '
        Me.ProdVATDataGridViewCheckBoxColumn1.DataPropertyName = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn1.HeaderText = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn1.Name = "ProdVATDataGridViewCheckBoxColumn1"
        Me.ProdVATDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'ProdActiveDataGridViewCheckBoxColumn
        '
        Me.ProdActiveDataGridViewCheckBoxColumn.DataPropertyName = "Prod_Active"
        Me.ProdActiveDataGridViewCheckBoxColumn.HeaderText = "Prod_Active"
        Me.ProdActiveDataGridViewCheckBoxColumn.Name = "ProdActiveDataGridViewCheckBoxColumn"
        Me.ProdActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ProdCategoriesDataGridViewTextBoxColumn
        '
        Me.ProdCategoriesDataGridViewTextBoxColumn.DataPropertyName = "Prod_Categories"
        Me.ProdCategoriesDataGridViewTextBoxColumn.HeaderText = "Prod_Categories"
        Me.ProdCategoriesDataGridViewTextBoxColumn.Name = "ProdCategoriesDataGridViewTextBoxColumn"
        Me.ProdCategoriesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdReorderThresholdDataGridViewTextBoxColumn
        '
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Reorder_Threshold"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.HeaderText = "Prod_Reorder_Threshold"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.Name = "ProdReorderThresholdDataGridViewTextBoxColumn"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.RecSpecDataset
        '
        'RecSpecDataset
        '
        Me.RecSpecDataset.DataSetName = "RecSpecDataset"
        Me.RecSpecDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tlpProduct
        '
        Me.tlpProduct.ColumnCount = 3
        Me.tlpProduct.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpProduct.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpProduct.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpProduct.Controls.Add(Me.btnSearchProduct, 0, 0)
        Me.tlpProduct.Controls.Add(Me.tbQueryProduct, 1, 0)
        Me.tlpProduct.Controls.Add(Me.cbCriteriaProduct, 2, 0)
        Me.tlpProduct.Location = New System.Drawing.Point(117, 191)
        Me.tlpProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpProduct.Name = "tlpProduct"
        Me.tlpProduct.RowCount = 1
        Me.tlpProduct.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpProduct.Size = New System.Drawing.Size(862, 60)
        Me.tlpProduct.TabIndex = 89
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchProduct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchProduct.Image = CType(resources.GetObject("btnSearchProduct.Image"), System.Drawing.Image)
        Me.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchProduct.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchProduct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnSearchProduct.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchProduct.TabIndex = 70
        Me.btnSearchProduct.Text = "Search"
        Me.btnSearchProduct.UseVisualStyleBackColor = True
        '
        'tbQueryProduct
        '
        Me.tbQueryProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryProduct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryProduct.Location = New System.Drawing.Point(299, 17)
        Me.tbQueryProduct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbQueryProduct.Multiline = True
        Me.tbQueryProduct.Name = "tbQueryProduct"
        Me.tbQueryProduct.Size = New System.Drawing.Size(263, 25)
        Me.tbQueryProduct.TabIndex = 68
        Me.tbQueryProduct.Text = "Enter query ..."
        '
        'cbCriteriaProduct
        '
        Me.cbCriteriaProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaProduct.FormattingEnabled = True
        Me.cbCriteriaProduct.Items.AddRange(New Object() {"By Product Code", "By Product Name", "By Stock Level", "By Categories"})
        Me.cbCriteriaProduct.Location = New System.Drawing.Point(586, 19)
        Me.cbCriteriaProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbCriteriaProduct.Name = "cbCriteriaProduct"
        Me.cbCriteriaProduct.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaProduct.TabIndex = 71
        Me.cbCriteriaProduct.Text = "By Product Code"
        '
        'SalesOrderTabRep
        '
        Me.SalesOrderTabRep.Controls.Add(Me.flpSOTotal)
        Me.SalesOrderTabRep.Controls.Add(Me.dgvSODetails)
        Me.SalesOrderTabRep.Controls.Add(Me.lblSODetails)
        Me.SalesOrderTabRep.Controls.Add(Me.lblSO)
        Me.SalesOrderTabRep.Controls.Add(Me.dgvSO)
        Me.SalesOrderTabRep.Controls.Add(Me.tlpSO)
        Me.SalesOrderTabRep.Controls.Add(Me.flpSO)
        Me.SalesOrderTabRep.Location = New System.Drawing.Point(4, 26)
        Me.SalesOrderTabRep.Name = "SalesOrderTabRep"
        Me.SalesOrderTabRep.Padding = New System.Windows.Forms.Padding(3)
        Me.SalesOrderTabRep.Size = New System.Drawing.Size(1302, 763)
        Me.SalesOrderTabRep.TabIndex = 17
        Me.SalesOrderTabRep.Text = "Sales Order"
        Me.SalesOrderTabRep.UseVisualStyleBackColor = True
        '
        'flpSOTotal
        '
        Me.flpSOTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpSOTotal.Controls.Add(Me.lblSOTotal)
        Me.flpSOTotal.Controls.Add(Me.tbSOTotal)
        Me.flpSOTotal.Location = New System.Drawing.Point(766, 698)
        Me.flpSOTotal.Name = "flpSOTotal"
        Me.flpSOTotal.Size = New System.Drawing.Size(300, 31)
        Me.flpSOTotal.TabIndex = 95
        '
        'lblSOTotal
        '
        Me.lblSOTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSOTotal.AutoSize = True
        Me.lblSOTotal.Location = New System.Drawing.Point(3, 7)
        Me.lblSOTotal.Name = "lblSOTotal"
        Me.lblSOTotal.Size = New System.Drawing.Size(105, 17)
        Me.lblSOTotal.TabIndex = 91
        Me.lblSOTotal.Text = "Sales OrderTotal"
        '
        'tbSOTotal
        '
        Me.tbSOTotal.Location = New System.Drawing.Point(114, 3)
        Me.tbSOTotal.Name = "tbSOTotal"
        Me.tbSOTotal.Size = New System.Drawing.Size(150, 25)
        Me.tbSOTotal.TabIndex = 90
        '
        'dgvSODetails
        '
        Me.dgvSODetails.AllowUserToAddRows = False
        Me.dgvSODetails.AllowUserToDeleteRows = False
        Me.dgvSODetails.AllowUserToResizeRows = False
        Me.dgvSODetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvSODetails.AutoGenerateColumns = False
        Me.dgvSODetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSODetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSODetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalesItemLineNoDataGridViewTextBoxColumn, Me.SaleOrderIDDataGridViewTextBoxColumn, Me.SaleItemQtyDataGridViewTextBoxColumn, Me.SaleItemPriceDataGridViewTextBoxColumn, Me.ProdVATDataGridViewCheckBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn})
        Me.dgvSODetails.DataSource = Me.FKSaleItemSalesOrderBindingSource
        Me.dgvSODetails.Location = New System.Drawing.Point(96, 486)
        Me.dgvSODetails.Name = "dgvSODetails"
        Me.dgvSODetails.ReadOnly = True
        Me.dgvSODetails.Size = New System.Drawing.Size(968, 150)
        Me.dgvSODetails.TabIndex = 94
        '
        'SalesItemLineNoDataGridViewTextBoxColumn
        '
        Me.SalesItemLineNoDataGridViewTextBoxColumn.DataPropertyName = "Sales_Item_Line_No"
        Me.SalesItemLineNoDataGridViewTextBoxColumn.HeaderText = "Sales_Item_Line_No"
        Me.SalesItemLineNoDataGridViewTextBoxColumn.Name = "SalesItemLineNoDataGridViewTextBoxColumn"
        Me.SalesItemLineNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleOrderIDDataGridViewTextBoxColumn
        '
        Me.SaleOrderIDDataGridViewTextBoxColumn.DataPropertyName = "Sale_Order_ID"
        Me.SaleOrderIDDataGridViewTextBoxColumn.HeaderText = "Sale_Order_ID"
        Me.SaleOrderIDDataGridViewTextBoxColumn.Name = "SaleOrderIDDataGridViewTextBoxColumn"
        Me.SaleOrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleItemQtyDataGridViewTextBoxColumn
        '
        Me.SaleItemQtyDataGridViewTextBoxColumn.DataPropertyName = "Sale_Item_Qty"
        Me.SaleItemQtyDataGridViewTextBoxColumn.HeaderText = "Sale_Item_Qty"
        Me.SaleItemQtyDataGridViewTextBoxColumn.Name = "SaleItemQtyDataGridViewTextBoxColumn"
        Me.SaleItemQtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleItemPriceDataGridViewTextBoxColumn
        '
        Me.SaleItemPriceDataGridViewTextBoxColumn.DataPropertyName = "Sale_Item_Price"
        Me.SaleItemPriceDataGridViewTextBoxColumn.HeaderText = "Sale_Item_Price"
        Me.SaleItemPriceDataGridViewTextBoxColumn.Name = "SaleItemPriceDataGridViewTextBoxColumn"
        Me.SaleItemPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdVATDataGridViewCheckBoxColumn
        '
        Me.ProdVATDataGridViewCheckBoxColumn.DataPropertyName = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn.HeaderText = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn.Name = "ProdVATDataGridViewCheckBoxColumn"
        Me.ProdVATDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FKSaleItemSalesOrderBindingSource
        '
        Me.FKSaleItemSalesOrderBindingSource.DataMember = "FK_Sale_Item_Sales_Order"
        Me.FKSaleItemSalesOrderBindingSource.DataSource = Me.SalesOrderBindingSource
        '
        'SalesOrderBindingSource
        '
        Me.SalesOrderBindingSource.DataMember = "Sales_Order"
        Me.SalesOrderBindingSource.DataSource = Me.RecSpecDataset
        '
        'lblSODetails
        '
        Me.lblSODetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSODetails.AutoSize = True
        Me.lblSODetails.Location = New System.Drawing.Point(96, 465)
        Me.lblSODetails.Name = "lblSODetails"
        Me.lblSODetails.Size = New System.Drawing.Size(120, 17)
        Me.lblSODetails.TabIndex = 93
        Me.lblSODetails.Text = "Sales Order Details"
        '
        'lblSO
        '
        Me.lblSO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSO.AutoSize = True
        Me.lblSO.Location = New System.Drawing.Point(96, 240)
        Me.lblSO.Name = "lblSO"
        Me.lblSO.Size = New System.Drawing.Size(83, 17)
        Me.lblSO.TabIndex = 92
        Me.lblSO.Text = "Sales Orders"
        '
        'dgvSO
        '
        Me.dgvSO.AllowUserToAddRows = False
        Me.dgvSO.AllowUserToDeleteRows = False
        Me.dgvSO.AllowUserToResizeRows = False
        Me.dgvSO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvSO.AutoGenerateColumns = False
        Me.dgvSO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalesOrderIDDataGridViewTextBoxColumn, Me.SaleOrderDateDataGridViewTextBoxColumn, Me.SaleTotalDataGridViewTextBoxColumn, Me.EmpFNameDataGridViewTextBoxColumn, Me.CustFNameDataGridViewTextBoxColumn})
        Me.dgvSO.DataSource = Me.SalesOrderBindingSource
        Me.dgvSO.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSO.Location = New System.Drawing.Point(96, 259)
        Me.dgvSO.Name = "dgvSO"
        Me.dgvSO.ReadOnly = True
        Me.dgvSO.Size = New System.Drawing.Size(968, 150)
        Me.dgvSO.TabIndex = 91
        '
        'SalesOrderIDDataGridViewTextBoxColumn
        '
        Me.SalesOrderIDDataGridViewTextBoxColumn.DataPropertyName = "Sales_Order_ID"
        Me.SalesOrderIDDataGridViewTextBoxColumn.HeaderText = "Sales_Order_ID"
        Me.SalesOrderIDDataGridViewTextBoxColumn.Name = "SalesOrderIDDataGridViewTextBoxColumn"
        Me.SalesOrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleOrderDateDataGridViewTextBoxColumn
        '
        Me.SaleOrderDateDataGridViewTextBoxColumn.DataPropertyName = "Sale_Order_Date"
        Me.SaleOrderDateDataGridViewTextBoxColumn.HeaderText = "Sale_Order_Date"
        Me.SaleOrderDateDataGridViewTextBoxColumn.Name = "SaleOrderDateDataGridViewTextBoxColumn"
        Me.SaleOrderDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleTotalDataGridViewTextBoxColumn
        '
        Me.SaleTotalDataGridViewTextBoxColumn.DataPropertyName = "Sale_Total"
        Me.SaleTotalDataGridViewTextBoxColumn.HeaderText = "Sale_Total"
        Me.SaleTotalDataGridViewTextBoxColumn.Name = "SaleTotalDataGridViewTextBoxColumn"
        Me.SaleTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpFNameDataGridViewTextBoxColumn
        '
        Me.EmpFNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn.HeaderText = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn.Name = "EmpFNameDataGridViewTextBoxColumn"
        Me.EmpFNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustFNameDataGridViewTextBoxColumn
        '
        Me.CustFNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.HeaderText = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.Name = "CustFNameDataGridViewTextBoxColumn"
        Me.CustFNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'tlpSO
        '
        Me.tlpSO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpSO.ColumnCount = 3
        Me.tlpSO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSO.Controls.Add(Me.btnSearchSO, 0, 0)
        Me.tlpSO.Controls.Add(Me.tbQuerySO, 1, 0)
        Me.tlpSO.Controls.Add(Me.cbCriteriaSO, 2, 0)
        Me.tlpSO.Location = New System.Drawing.Point(124, 171)
        Me.tlpSO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpSO.Name = "tlpSO"
        Me.tlpSO.RowCount = 1
        Me.tlpSO.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSO.Size = New System.Drawing.Size(862, 60)
        Me.tlpSO.TabIndex = 90
        '
        'btnSearchSO
        '
        Me.btnSearchSO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchSO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSO.Image = CType(resources.GetObject("btnSearchSO.Image"), System.Drawing.Image)
        Me.btnSearchSO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchSO.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchSO.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSearchSO.Name = "btnSearchSO"
        Me.btnSearchSO.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnSearchSO.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchSO.TabIndex = 70
        Me.btnSearchSO.Text = "Search"
        Me.btnSearchSO.UseVisualStyleBackColor = True
        '
        'tbQuerySO
        '
        Me.tbQuerySO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQuerySO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQuerySO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuerySO.Location = New System.Drawing.Point(299, 17)
        Me.tbQuerySO.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbQuerySO.Multiline = True
        Me.tbQuerySO.Name = "tbQuerySO"
        Me.tbQuerySO.Size = New System.Drawing.Size(263, 25)
        Me.tbQuerySO.TabIndex = 68
        Me.tbQuerySO.Text = "Enter query ..."
        '
        'cbCriteriaSO
        '
        Me.cbCriteriaSO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaSO.FormattingEnabled = True
        Me.cbCriteriaSO.Items.AddRange(New Object() {"By Customer ID", "By First Name", "By Surname"})
        Me.cbCriteriaSO.Location = New System.Drawing.Point(586, 17)
        Me.cbCriteriaSO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbCriteriaSO.Name = "cbCriteriaSO"
        Me.cbCriteriaSO.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaSO.TabIndex = 71
        Me.cbCriteriaSO.Text = "Select criteria"
        '
        'flpSO
        '
        Me.flpSO.Controls.Add(Me.btnAddEditSO)
        Me.flpSO.Controls.Add(Me.btnSaveSO)
        Me.flpSO.Controls.Add(Me.btnRemoveSO)
        Me.flpSO.Location = New System.Drawing.Point(265, 7)
        Me.flpSO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpSO.Name = "flpSO"
        Me.flpSO.Size = New System.Drawing.Size(588, 146)
        Me.flpSO.TabIndex = 80
        '
        'btnAddEditSO
        '
        Me.btnAddEditSO.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditSO.Image = CType(resources.GetObject("btnAddEditSO.Image"), System.Drawing.Image)
        Me.btnAddEditSO.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditSO.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditSO.Name = "btnAddEditSO"
        Me.btnAddEditSO.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditSO.TabIndex = 32
        Me.btnAddEditSO.Text = "Add/Edit"
        Me.btnAddEditSO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditSO.UseCompatibleTextRendering = True
        Me.btnAddEditSO.UseVisualStyleBackColor = True
        '
        'btnSaveSO
        '
        Me.btnSaveSO.Image = CType(resources.GetObject("btnSaveSO.Image"), System.Drawing.Image)
        Me.btnSaveSO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveSO.Location = New System.Drawing.Point(221, 5)
        Me.btnSaveSO.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSaveSO.Name = "btnSaveSO"
        Me.btnSaveSO.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnSaveSO.Size = New System.Drawing.Size(146, 136)
        Me.btnSaveSO.TabIndex = 30
        Me.btnSaveSO.Text = "Save"
        Me.btnSaveSO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveSO.UseVisualStyleBackColor = True
        '
        'btnRemoveSO
        '
        Me.btnRemoveSO.AutoSize = True
        Me.btnRemoveSO.Image = CType(resources.GetObject("btnRemoveSO.Image"), System.Drawing.Image)
        Me.btnRemoveSO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveSO.Location = New System.Drawing.Point(427, 5)
        Me.btnRemoveSO.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemoveSO.Name = "btnRemoveSO"
        Me.btnRemoveSO.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnRemoveSO.Size = New System.Drawing.Size(146, 136)
        Me.btnRemoveSO.TabIndex = 31
        Me.btnRemoveSO.Text = "Remove"
        Me.btnRemoveSO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveSO.UseVisualStyleBackColor = True
        '
        'CustomerTabRep
        '
        Me.CustomerTabRep.Controls.Add(Me.tlpCustomer)
        Me.CustomerTabRep.Controls.Add(Me.flpCustomer)
        Me.CustomerTabRep.Controls.Add(Me.dgvCustomer)
        Me.CustomerTabRep.Location = New System.Drawing.Point(4, 26)
        Me.CustomerTabRep.Name = "CustomerTabRep"
        Me.CustomerTabRep.Padding = New System.Windows.Forms.Padding(3)
        Me.CustomerTabRep.Size = New System.Drawing.Size(1302, 763)
        Me.CustomerTabRep.TabIndex = 18
        Me.CustomerTabRep.Text = "Customer"
        Me.CustomerTabRep.UseVisualStyleBackColor = True
        '
        'tlpCustomer
        '
        Me.tlpCustomer.ColumnCount = 3
        Me.tlpCustomer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpCustomer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpCustomer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpCustomer.Controls.Add(Me.btnSearchCustomer, 0, 0)
        Me.tlpCustomer.Controls.Add(Me.tbQueryCustomer, 1, 0)
        Me.tlpCustomer.Controls.Add(Me.cbCriteriaCustomer, 2, 0)
        Me.tlpCustomer.Location = New System.Drawing.Point(260, 221)
        Me.tlpCustomer.Name = "tlpCustomer"
        Me.tlpCustomer.RowCount = 1
        Me.tlpCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpCustomer.Size = New System.Drawing.Size(862, 60)
        Me.tlpCustomer.TabIndex = 89
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchCustomer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomer.Image = CType(resources.GetObject("btnSearchCustomer.Image"), System.Drawing.Image)
        Me.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchCustomer.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSearchCustomer.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchCustomer.TabIndex = 70
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'tbQueryCustomer
        '
        Me.tbQueryCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryCustomer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryCustomer.Location = New System.Drawing.Point(299, 17)
        Me.tbQueryCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQueryCustomer.Multiline = True
        Me.tbQueryCustomer.Name = "tbQueryCustomer"
        Me.tbQueryCustomer.Size = New System.Drawing.Size(263, 25)
        Me.tbQueryCustomer.TabIndex = 68
        Me.tbQueryCustomer.Text = "Enter query ..."
        '
        'cbCriteriaCustomer
        '
        Me.cbCriteriaCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaCustomer.FormattingEnabled = True
        Me.cbCriteriaCustomer.Items.AddRange(New Object() {"By Customer ID", "By First Name", "By Surname", "By Business Name"})
        Me.cbCriteriaCustomer.Location = New System.Drawing.Point(586, 19)
        Me.cbCriteriaCustomer.Name = "cbCriteriaCustomer"
        Me.cbCriteriaCustomer.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaCustomer.TabIndex = 71
        Me.cbCriteriaCustomer.Text = "By Customer ID"
        '
        'flpCustomer
        '
        Me.flpCustomer.AutoSize = True
        Me.flpCustomer.Controls.Add(Me.btnAddEditCustomer)
        Me.flpCustomer.Controls.Add(Me.btnSaveCustomer)
        Me.flpCustomer.Controls.Add(Me.btnRemoveCustomer)
        Me.flpCustomer.Location = New System.Drawing.Point(328, 47)
        Me.flpCustomer.Name = "flpCustomer"
        Me.flpCustomer.Size = New System.Drawing.Size(588, 146)
        Me.flpCustomer.TabIndex = 88
        '
        'btnAddEditCustomer
        '
        Me.btnAddEditCustomer.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditCustomer.Image = CType(resources.GetObject("btnAddEditCustomer.Image"), System.Drawing.Image)
        Me.btnAddEditCustomer.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditCustomer.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditCustomer.Name = "btnAddEditCustomer"
        Me.btnAddEditCustomer.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditCustomer.TabIndex = 32
        Me.btnAddEditCustomer.Text = "Add/Edit"
        Me.btnAddEditCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditCustomer.UseCompatibleTextRendering = True
        Me.btnAddEditCustomer.UseVisualStyleBackColor = True
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Image = CType(resources.GetObject("btnSaveCustomer.Image"), System.Drawing.Image)
        Me.btnSaveCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveCustomer.Location = New System.Drawing.Point(221, 5)
        Me.btnSaveCustomer.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnSaveCustomer.Size = New System.Drawing.Size(146, 136)
        Me.btnSaveCustomer.TabIndex = 30
        Me.btnSaveCustomer.Text = "Save"
        Me.btnSaveCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveCustomer.UseVisualStyleBackColor = True
        '
        'btnRemoveCustomer
        '
        Me.btnRemoveCustomer.AutoSize = True
        Me.btnRemoveCustomer.Image = CType(resources.GetObject("btnRemoveCustomer.Image"), System.Drawing.Image)
        Me.btnRemoveCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveCustomer.Location = New System.Drawing.Point(427, 5)
        Me.btnRemoveCustomer.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemoveCustomer.Name = "btnRemoveCustomer"
        Me.btnRemoveCustomer.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnRemoveCustomer.Size = New System.Drawing.Size(146, 136)
        Me.btnRemoveCustomer.TabIndex = 31
        Me.btnRemoveCustomer.Text = "Remove"
        Me.btnRemoveCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveCustomer.UseVisualStyleBackColor = True
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.AutoGenerateColumns = False
        Me.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.DataSource = Me.CustomerTableBindingSource
        Me.dgvCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvCustomer.Location = New System.Drawing.Point(166, 356)
        Me.dgvCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.Size = New System.Drawing.Size(975, 363)
        Me.dgvCustomer.TabIndex = 87
        '
        'Sale_ItemTableAdapter
        '
        Me.Sale_ItemTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableTableAdapter
        '
        Me.CustomerTableTableAdapter.ClearBeforeFill = True
        '
        'Sales_OrderTableAdapter
        '
        Me.Sales_OrderTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'SalesRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 793)
        Me.Controls.Add(Me.SalesRepTabControl)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1330, 836)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1330, 836)
        Me.Name = "SalesRep"
        Me.Text = "SalesRep"
        Me.SalesRepTabControl.ResumeLayout(False)
        Me.ProductTabRep.ResumeLayout(False)
        Me.flpProducts.ResumeLayout(False)
        Me.flpProducts.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpProduct.ResumeLayout(False)
        Me.tlpProduct.PerformLayout()
        Me.SalesOrderTabRep.ResumeLayout(False)
        Me.SalesOrderTabRep.PerformLayout()
        Me.flpSOTotal.ResumeLayout(False)
        Me.flpSOTotal.PerformLayout()
        CType(Me.dgvSODetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSaleItemSalesOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpSO.ResumeLayout(False)
        Me.tlpSO.PerformLayout()
        Me.flpSO.ResumeLayout(False)
        Me.flpSO.PerformLayout()
        Me.CustomerTabRep.ResumeLayout(False)
        Me.CustomerTabRep.PerformLayout()
        Me.tlpCustomer.ResumeLayout(False)
        Me.tlpCustomer.PerformLayout()
        Me.flpCustomer.ResumeLayout(False)
        Me.flpCustomer.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SalesRepTabControl As TabControl
    Friend WithEvents ProductTabRep As TabPage
    Friend WithEvents flpProducts As FlowLayoutPanel
    Friend WithEvents btnAddEditProduct As Button
    Friend WithEvents btnSaveProduct As Button
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents tlpProduct As TableLayoutPanel
    Friend WithEvents btnSearchProduct As Button
    Friend WithEvents tbQueryProduct As TextBox
    Friend WithEvents cbCriteriaProduct As ComboBox
    Friend WithEvents SalesOrderTabRep As TabPage
    Friend WithEvents dgvSO As DataGridView
    Friend WithEvents tlpSO As TableLayoutPanel
    Friend WithEvents btnSearchSO As Button
    Friend WithEvents tbQuerySO As TextBox
    Friend WithEvents cbCriteriaSO As ComboBox
    Friend WithEvents flpSO As FlowLayoutPanel
    Friend WithEvents btnAddEditSO As Button
    Friend WithEvents btnSaveSO As Button
    Friend WithEvents btnRemoveSO As Button
    Friend WithEvents lblSO As Label
    Friend WithEvents dgvSODetails As DataGridView
    Friend WithEvents lblSODetails As Label
    Friend WithEvents Sale_ItemTableAdapter As RecSpecDatasetTableAdapters.Sale_ItemTableAdapter
    Friend WithEvents flpSOTotal As FlowLayoutPanel
    Friend WithEvents lblSOTotal As Label
    Friend WithEvents tbSOTotal As TextBox
    Friend WithEvents CustomerTabRep As TabPage
    Friend WithEvents tlpCustomer As TableLayoutPanel
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents tbQueryCustomer As TextBox
    Friend WithEvents cbCriteriaCustomer As ComboBox
    Friend WithEvents flpCustomer As FlowLayoutPanel
    Friend WithEvents btnAddEditCustomer As Button
    Friend WithEvents btnSaveCustomer As Button
    Friend WithEvents btnRemoveCustomer As Button
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents CustomerTableBindingSource As BindingSource
    Friend WithEvents CustomerTableTableAdapter As RecSpecDatasetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents RecSpecDataset As RecSpecDataset
    Friend WithEvents SalesOrderBindingSource As BindingSource
    Friend WithEvents Sales_OrderTableAdapter As RecSpecDatasetTableAdapters.Sales_OrderTableAdapter
    Friend WithEvents SalesItemLineNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleItemQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleItemPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdVATDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FKSaleItemSalesOrderBindingSource As BindingSource
    Friend WithEvents SalesOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleOrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As RecSpecDatasetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdStockLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdVATDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ProdActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProdCategoriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdReorderThresholdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
