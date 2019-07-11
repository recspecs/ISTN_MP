<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseManager))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.WarehouseManagerTabControl = New System.Windows.Forms.TabControl()
        Me.WMProductsTab = New System.Windows.Forms.TabPage()
        Me.flpProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditProduct = New System.Windows.Forms.Button()
        Me.btnSaveProduct = New System.Windows.Forms.Button()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdStockLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdVATDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdCategoriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdReorderThresholdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecSpecDataset = New MenuForms.RecSpecDataset()
        Me.tlpProduct = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchProduct = New System.Windows.Forms.Button()
        Me.tbQueryProduct = New System.Windows.Forms.TextBox()
        Me.cbCriteriaProduct = New System.Windows.Forms.ComboBox()
        Me.WMPurchaseOrderTab = New System.Windows.Forms.TabPage()
        Me.lblPoDetails = New System.Windows.Forms.Label()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.PONoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POReceivedFlagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supp_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_FName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvPOD = New System.Windows.Forms.DataGridView()
        Me.tlpPO = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchPO = New System.Windows.Forms.Button()
        Me.tbQueryPO = New System.Windows.Forms.TextBox()
        Me.cbCriteriaPO = New System.Windows.Forms.ComboBox()
        Me.flpPOTotal = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblPOTotal = New System.Windows.Forms.Label()
        Me.tbPOTotal = New System.Windows.Forms.TextBox()
        Me.WMSupplierTab = New System.Windows.Forms.TabPage()
        Me.tlpSupplier = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchSupplier = New System.Windows.Forms.Button()
        Me.tbQuerySupplier = New System.Windows.Forms.TextBox()
        Me.cbCriteriaSupplier = New System.Windows.Forms.ComboBox()
        Me.flpSupplier = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditSupplier = New System.Windows.Forms.Button()
        Me.btnSaveSupplier = New System.Windows.Forms.Button()
        Me.btnRemoveSupplier = New System.Windows.Forms.Button()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppContactPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppAddress1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppAddress2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppSurburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppPostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.SupplierTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.SupplierTableAdapter()
        Me.Purchase_OrderTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter()
        Me.PurchaseItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchase_ItemTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Purchase_ItemTableAdapter()
        Me.WarehouseManagerTabControl.SuspendLayout()
        Me.WMProductsTab.SuspendLayout()
        Me.flpProducts.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpProduct.SuspendLayout()
        Me.WMPurchaseOrderTab.SuspendLayout()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPO.SuspendLayout()
        Me.flpPOTotal.SuspendLayout()
        Me.WMSupplierTab.SuspendLayout()
        Me.tlpSupplier.SuspendLayout()
        Me.flpSupplier.SuspendLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WarehouseManagerTabControl
        '
        Me.WarehouseManagerTabControl.Controls.Add(Me.WMProductsTab)
        Me.WarehouseManagerTabControl.Controls.Add(Me.WMPurchaseOrderTab)
        Me.WarehouseManagerTabControl.Controls.Add(Me.WMSupplierTab)
        Me.WarehouseManagerTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WarehouseManagerTabControl.Location = New System.Drawing.Point(0, 0)
        Me.WarehouseManagerTabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WarehouseManagerTabControl.Name = "WarehouseManagerTabControl"
        Me.WarehouseManagerTabControl.SelectedIndex = 0
        Me.WarehouseManagerTabControl.Size = New System.Drawing.Size(1314, 797)
        Me.WarehouseManagerTabControl.TabIndex = 0
        '
        'WMProductsTab
        '
        Me.WMProductsTab.Controls.Add(Me.flpProducts)
        Me.WMProductsTab.Controls.Add(Me.dgvProduct)
        Me.WMProductsTab.Controls.Add(Me.tlpProduct)
        Me.WMProductsTab.Location = New System.Drawing.Point(4, 26)
        Me.WMProductsTab.Name = "WMProductsTab"
        Me.WMProductsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.WMProductsTab.Size = New System.Drawing.Size(1306, 767)
        Me.WMProductsTab.TabIndex = 15
        Me.WMProductsTab.Text = "Products"
        Me.WMProductsTab.UseVisualStyleBackColor = True
        '
        'flpProducts
        '
        Me.flpProducts.Controls.Add(Me.btnAddEditProduct)
        Me.flpProducts.Controls.Add(Me.btnSaveProduct)
        Me.flpProducts.Controls.Add(Me.btnRemoveProduct)
        Me.flpProducts.Location = New System.Drawing.Point(157, 31)
        Me.flpProducts.Name = "flpProducts"
        Me.flpProducts.Size = New System.Drawing.Size(588, 146)
        Me.flpProducts.TabIndex = 91
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
        Me.btnSaveProduct.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
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
        Me.btnRemoveProduct.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
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
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCodeDataGridViewTextBoxColumn, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdCostPriceDataGridViewTextBoxColumn, Me.ProdStockLevelDataGridViewTextBoxColumn, Me.ProdVATDataGridViewCheckBoxColumn, Me.ProdActiveDataGridViewCheckBoxColumn, Me.ProdCategoriesDataGridViewTextBoxColumn, Me.ProdReorderThresholdDataGridViewTextBoxColumn})
        Me.dgvProduct.DataSource = Me.ProductBindingSource
        Me.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvProduct.Location = New System.Drawing.Point(14, 298)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(1000, 410)
        Me.dgvProduct.TabIndex = 90
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
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
        'ProdVATDataGridViewCheckBoxColumn
        '
        Me.ProdVATDataGridViewCheckBoxColumn.DataPropertyName = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn.HeaderText = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn.Name = "ProdVATDataGridViewCheckBoxColumn"
        Me.ProdVATDataGridViewCheckBoxColumn.ReadOnly = True
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
        Me.tlpProduct.Location = New System.Drawing.Point(70, 208)
        Me.tlpProduct.Name = "tlpProduct"
        Me.tlpProduct.RowCount = 1
        Me.tlpProduct.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpProduct.Size = New System.Drawing.Size(862, 60)
        Me.tlpProduct.TabIndex = 92
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchProduct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchProduct.Image = CType(resources.GetObject("btnSearchProduct.Image"), System.Drawing.Image)
        Me.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchProduct.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
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
        Me.tbQueryProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.cbCriteriaProduct.Location = New System.Drawing.Point(586, 17)
        Me.cbCriteriaProduct.Name = "cbCriteriaProduct"
        Me.cbCriteriaProduct.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaProduct.TabIndex = 71
        Me.cbCriteriaProduct.Text = "By Product Code"
        '
        'WMPurchaseOrderTab
        '
        Me.WMPurchaseOrderTab.Controls.Add(Me.lblPoDetails)
        Me.WMPurchaseOrderTab.Controls.Add(Me.lblPO)
        Me.WMPurchaseOrderTab.Controls.Add(Me.dgvPO)
        Me.WMPurchaseOrderTab.Controls.Add(Me.dgvPOD)
        Me.WMPurchaseOrderTab.Controls.Add(Me.tlpPO)
        Me.WMPurchaseOrderTab.Controls.Add(Me.flpPOTotal)
        Me.WMPurchaseOrderTab.Location = New System.Drawing.Point(4, 26)
        Me.WMPurchaseOrderTab.Name = "WMPurchaseOrderTab"
        Me.WMPurchaseOrderTab.Padding = New System.Windows.Forms.Padding(3)
        Me.WMPurchaseOrderTab.Size = New System.Drawing.Size(1306, 767)
        Me.WMPurchaseOrderTab.TabIndex = 16
        Me.WMPurchaseOrderTab.Text = "Purchase Order"
        Me.WMPurchaseOrderTab.UseVisualStyleBackColor = True
        '
        'lblPoDetails
        '
        Me.lblPoDetails.AutoSize = True
        Me.lblPoDetails.Location = New System.Drawing.Point(30, 374)
        Me.lblPoDetails.Name = "lblPoDetails"
        Me.lblPoDetails.Size = New System.Drawing.Size(142, 17)
        Me.lblPoDetails.TabIndex = 107
        Me.lblPoDetails.Text = "Purchase Order Details"
        '
        'lblPO
        '
        Me.lblPO.AutoSize = True
        Me.lblPO.Location = New System.Drawing.Point(30, 98)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(105, 17)
        Me.lblPO.TabIndex = 106
        Me.lblPO.Text = "Purchase Orders"
        '
        'dgvPO
        '
        Me.dgvPO.AllowUserToAddRows = False
        Me.dgvPO.AllowUserToDeleteRows = False
        Me.dgvPO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvPO.AutoGenerateColumns = False
        Me.dgvPO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONoDataGridViewTextBoxColumn, Me.PODateDataGridViewTextBoxColumn, Me.POTotalDataGridViewTextBoxColumn, Me.POReceivedFlagDataGridViewCheckBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.Supp_Name, Me.Emp_FName})
        Me.dgvPO.DataSource = Me.PurchaseOrderBindingSource
        Me.dgvPO.Location = New System.Drawing.Point(33, 123)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.ReadOnly = True
        Me.dgvPO.Size = New System.Drawing.Size(899, 232)
        Me.dgvPO.TabIndex = 105
        '
        'PONoDataGridViewTextBoxColumn
        '
        Me.PONoDataGridViewTextBoxColumn.DataPropertyName = "PO_No"
        Me.PONoDataGridViewTextBoxColumn.HeaderText = "PO_No"
        Me.PONoDataGridViewTextBoxColumn.Name = "PONoDataGridViewTextBoxColumn"
        Me.PONoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PODateDataGridViewTextBoxColumn
        '
        Me.PODateDataGridViewTextBoxColumn.DataPropertyName = "PO_Date"
        Me.PODateDataGridViewTextBoxColumn.HeaderText = "PO_Date"
        Me.PODateDataGridViewTextBoxColumn.Name = "PODateDataGridViewTextBoxColumn"
        Me.PODateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POTotalDataGridViewTextBoxColumn
        '
        Me.POTotalDataGridViewTextBoxColumn.DataPropertyName = "PO_Total"
        Me.POTotalDataGridViewTextBoxColumn.HeaderText = "PO_Total"
        Me.POTotalDataGridViewTextBoxColumn.Name = "POTotalDataGridViewTextBoxColumn"
        Me.POTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POReceivedFlagDataGridViewCheckBoxColumn
        '
        Me.POReceivedFlagDataGridViewCheckBoxColumn.DataPropertyName = "PO_Received_Flag"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.HeaderText = "PO_Received_Flag"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.Name = "POReceivedFlagDataGridViewCheckBoxColumn"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIDDataGridViewTextBoxColumn.Visible = False
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIDDataGridViewTextBoxColumn.Visible = False
        '
        'Supp_Name
        '
        Me.Supp_Name.DataPropertyName = "Supp_Name"
        Me.Supp_Name.HeaderText = "Supp_Name"
        Me.Supp_Name.Name = "Supp_Name"
        Me.Supp_Name.ReadOnly = True
        '
        'Emp_FName
        '
        Me.Emp_FName.DataPropertyName = "Emp_FName"
        Me.Emp_FName.HeaderText = "Emp_FName"
        Me.Emp_FName.Name = "Emp_FName"
        Me.Emp_FName.ReadOnly = True
        '
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "Purchase_Order"
        Me.PurchaseOrderBindingSource.DataSource = Me.RecSpecDataset
        '
        'dgvPOD
        '
        Me.dgvPOD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPOD.Location = New System.Drawing.Point(33, 394)
        Me.dgvPOD.Name = "dgvPOD"
        Me.dgvPOD.Size = New System.Drawing.Size(899, 172)
        Me.dgvPOD.TabIndex = 103
        '
        'tlpPO
        '
        Me.tlpPO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpPO.ColumnCount = 3
        Me.tlpPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPO.Controls.Add(Me.btnSearchPO, 0, 0)
        Me.tlpPO.Controls.Add(Me.tbQueryPO, 1, 0)
        Me.tlpPO.Controls.Add(Me.cbCriteriaPO, 2, 0)
        Me.tlpPO.Location = New System.Drawing.Point(33, 35)
        Me.tlpPO.Name = "tlpPO"
        Me.tlpPO.RowCount = 1
        Me.tlpPO.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPO.Size = New System.Drawing.Size(862, 60)
        Me.tlpPO.TabIndex = 102
        '
        'btnSearchPO
        '
        Me.btnSearchPO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchPO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPO.Image = CType(resources.GetObject("btnSearchPO.Image"), System.Drawing.Image)
        Me.btnSearchPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchPO.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchPO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchPO.Name = "btnSearchPO"
        Me.btnSearchPO.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSearchPO.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchPO.TabIndex = 70
        Me.btnSearchPO.Text = "Search"
        Me.btnSearchPO.UseVisualStyleBackColor = True
        '
        'tbQueryPO
        '
        Me.tbQueryPO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryPO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryPO.Location = New System.Drawing.Point(299, 17)
        Me.tbQueryPO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQueryPO.Multiline = True
        Me.tbQueryPO.Name = "tbQueryPO"
        Me.tbQueryPO.Size = New System.Drawing.Size(263, 25)
        Me.tbQueryPO.TabIndex = 68
        Me.tbQueryPO.Text = "Enter query ..."
        '
        'cbCriteriaPO
        '
        Me.cbCriteriaPO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaPO.FormattingEnabled = True
        Me.cbCriteriaPO.Items.AddRange(New Object() {"By PO No", "By PO Date", "By PO Received Flag", "By Supplier", "By Employee"})
        Me.cbCriteriaPO.Location = New System.Drawing.Point(586, 17)
        Me.cbCriteriaPO.Name = "cbCriteriaPO"
        Me.cbCriteriaPO.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaPO.TabIndex = 71
        Me.cbCriteriaPO.Text = "By PO No"
        '
        'flpPOTotal
        '
        Me.flpPOTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpPOTotal.Controls.Add(Me.lblPOTotal)
        Me.flpPOTotal.Controls.Add(Me.tbPOTotal)
        Me.flpPOTotal.Location = New System.Drawing.Point(658, 722)
        Me.flpPOTotal.Name = "flpPOTotal"
        Me.flpPOTotal.Size = New System.Drawing.Size(290, 31)
        Me.flpPOTotal.TabIndex = 104
        '
        'lblPOTotal
        '
        Me.lblPOTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPOTotal.AutoSize = True
        Me.lblPOTotal.Location = New System.Drawing.Point(3, 7)
        Me.lblPOTotal.Name = "lblPOTotal"
        Me.lblPOTotal.Size = New System.Drawing.Size(127, 17)
        Me.lblPOTotal.TabIndex = 91
        Me.lblPOTotal.Text = "Purchase OrderTotal"
        '
        'tbPOTotal
        '
        Me.tbPOTotal.Location = New System.Drawing.Point(136, 3)
        Me.tbPOTotal.Name = "tbPOTotal"
        Me.tbPOTotal.Size = New System.Drawing.Size(150, 25)
        Me.tbPOTotal.TabIndex = 90
        '
        'WMSupplierTab
        '
        Me.WMSupplierTab.Controls.Add(Me.tlpSupplier)
        Me.WMSupplierTab.Controls.Add(Me.flpSupplier)
        Me.WMSupplierTab.Controls.Add(Me.dgvSupplier)
        Me.WMSupplierTab.Location = New System.Drawing.Point(4, 26)
        Me.WMSupplierTab.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.WMSupplierTab.Name = "WMSupplierTab"
        Me.WMSupplierTab.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.WMSupplierTab.Size = New System.Drawing.Size(1306, 767)
        Me.WMSupplierTab.TabIndex = 14
        Me.WMSupplierTab.Text = "Supplier"
        Me.WMSupplierTab.UseVisualStyleBackColor = True
        '
        'tlpSupplier
        '
        Me.tlpSupplier.ColumnCount = 3
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSupplier.Controls.Add(Me.btnSearchSupplier, 0, 0)
        Me.tlpSupplier.Controls.Add(Me.tbQuerySupplier, 1, 0)
        Me.tlpSupplier.Controls.Add(Me.cbCriteriaSupplier, 2, 0)
        Me.tlpSupplier.Location = New System.Drawing.Point(101, 191)
        Me.tlpSupplier.Name = "tlpSupplier"
        Me.tlpSupplier.RowCount = 1
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSupplier.Size = New System.Drawing.Size(862, 60)
        Me.tlpSupplier.TabIndex = 87
        '
        'btnSearchSupplier
        '
        Me.btnSearchSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchSupplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSupplier.Image = CType(resources.GetObject("btnSearchSupplier.Image"), System.Drawing.Image)
        Me.btnSearchSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchSupplier.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchSupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchSupplier.Name = "btnSearchSupplier"
        Me.btnSearchSupplier.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSearchSupplier.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchSupplier.TabIndex = 70
        Me.btnSearchSupplier.Text = "Search"
        Me.btnSearchSupplier.UseVisualStyleBackColor = True
        '
        'tbQuerySupplier
        '
        Me.tbQuerySupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQuerySupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQuerySupplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuerySupplier.Location = New System.Drawing.Point(299, 17)
        Me.tbQuerySupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQuerySupplier.Multiline = True
        Me.tbQuerySupplier.Name = "tbQuerySupplier"
        Me.tbQuerySupplier.Size = New System.Drawing.Size(263, 25)
        Me.tbQuerySupplier.TabIndex = 68
        Me.tbQuerySupplier.Text = "Enter query ..."
        '
        'cbCriteriaSupplier
        '
        Me.cbCriteriaSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaSupplier.FormattingEnabled = True
        Me.cbCriteriaSupplier.Items.AddRange(New Object() {"By Supplier ID", "By Supplier Name", "By Contact Person"})
        Me.cbCriteriaSupplier.Location = New System.Drawing.Point(586, 19)
        Me.cbCriteriaSupplier.Name = "cbCriteriaSupplier"
        Me.cbCriteriaSupplier.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaSupplier.TabIndex = 71
        Me.cbCriteriaSupplier.Text = "By Supplier ID"
        '
        'flpSupplier
        '
        Me.flpSupplier.AutoSize = True
        Me.flpSupplier.Controls.Add(Me.btnAddEditSupplier)
        Me.flpSupplier.Controls.Add(Me.btnSaveSupplier)
        Me.flpSupplier.Controls.Add(Me.btnRemoveSupplier)
        Me.flpSupplier.Location = New System.Drawing.Point(169, 17)
        Me.flpSupplier.Name = "flpSupplier"
        Me.flpSupplier.Size = New System.Drawing.Size(588, 146)
        Me.flpSupplier.TabIndex = 86
        '
        'btnAddEditSupplier
        '
        Me.btnAddEditSupplier.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditSupplier.Image = CType(resources.GetObject("btnAddEditSupplier.Image"), System.Drawing.Image)
        Me.btnAddEditSupplier.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditSupplier.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditSupplier.Name = "btnAddEditSupplier"
        Me.btnAddEditSupplier.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditSupplier.TabIndex = 32
        Me.btnAddEditSupplier.Text = "Add/Edit"
        Me.btnAddEditSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditSupplier.UseCompatibleTextRendering = True
        Me.btnAddEditSupplier.UseVisualStyleBackColor = True
        '
        'btnSaveSupplier
        '
        Me.btnSaveSupplier.Image = CType(resources.GetObject("btnSaveSupplier.Image"), System.Drawing.Image)
        Me.btnSaveSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveSupplier.Location = New System.Drawing.Point(221, 5)
        Me.btnSaveSupplier.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSaveSupplier.Name = "btnSaveSupplier"
        Me.btnSaveSupplier.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnSaveSupplier.Size = New System.Drawing.Size(146, 136)
        Me.btnSaveSupplier.TabIndex = 30
        Me.btnSaveSupplier.Text = "Save"
        Me.btnSaveSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveSupplier.UseVisualStyleBackColor = True
        '
        'btnRemoveSupplier
        '
        Me.btnRemoveSupplier.AutoSize = True
        Me.btnRemoveSupplier.Image = CType(resources.GetObject("btnRemoveSupplier.Image"), System.Drawing.Image)
        Me.btnRemoveSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveSupplier.Location = New System.Drawing.Point(427, 5)
        Me.btnRemoveSupplier.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemoveSupplier.Name = "btnRemoveSupplier"
        Me.btnRemoveSupplier.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnRemoveSupplier.Size = New System.Drawing.Size(146, 136)
        Me.btnRemoveSupplier.TabIndex = 31
        Me.btnRemoveSupplier.Text = "Remove"
        Me.btnRemoveSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveSupplier.UseVisualStyleBackColor = True
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.AutoGenerateColumns = False
        Me.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.SuppNameDataGridViewTextBoxColumn, Me.SuppContactNoDataGridViewTextBoxColumn, Me.SuppEmailDataGridViewTextBoxColumn, Me.SuppContactPersonDataGridViewTextBoxColumn, Me.SuppAddress1DataGridViewTextBoxColumn, Me.SuppAddress2DataGridViewTextBoxColumn, Me.SuppSurburbDataGridViewTextBoxColumn, Me.SuppCityDataGridViewTextBoxColumn, Me.SuppPostalCodeDataGridViewTextBoxColumn})
        Me.dgvSupplier.DataSource = Me.SupplierBindingSource
        Me.dgvSupplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSupplier.Location = New System.Drawing.Point(11, 284)
        Me.dgvSupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.Size = New System.Drawing.Size(1000, 413)
        Me.dgvSupplier.TabIndex = 85
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Supplier_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Supplier_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SuppNameDataGridViewTextBoxColumn
        '
        Me.SuppNameDataGridViewTextBoxColumn.DataPropertyName = "Supp_Name"
        Me.SuppNameDataGridViewTextBoxColumn.HeaderText = "Supp_Name"
        Me.SuppNameDataGridViewTextBoxColumn.Name = "SuppNameDataGridViewTextBoxColumn"
        Me.SuppNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppContactNoDataGridViewTextBoxColumn
        '
        Me.SuppContactNoDataGridViewTextBoxColumn.DataPropertyName = "Supp_Contact_No"
        Me.SuppContactNoDataGridViewTextBoxColumn.HeaderText = "Supp_Contact_No"
        Me.SuppContactNoDataGridViewTextBoxColumn.Name = "SuppContactNoDataGridViewTextBoxColumn"
        Me.SuppContactNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppEmailDataGridViewTextBoxColumn
        '
        Me.SuppEmailDataGridViewTextBoxColumn.DataPropertyName = "Supp_Email"
        Me.SuppEmailDataGridViewTextBoxColumn.HeaderText = "Supp_Email"
        Me.SuppEmailDataGridViewTextBoxColumn.Name = "SuppEmailDataGridViewTextBoxColumn"
        Me.SuppEmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppContactPersonDataGridViewTextBoxColumn
        '
        Me.SuppContactPersonDataGridViewTextBoxColumn.DataPropertyName = "Supp_Contact_Person"
        Me.SuppContactPersonDataGridViewTextBoxColumn.HeaderText = "Supp_Contact_Person"
        Me.SuppContactPersonDataGridViewTextBoxColumn.Name = "SuppContactPersonDataGridViewTextBoxColumn"
        Me.SuppContactPersonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppAddress1DataGridViewTextBoxColumn
        '
        Me.SuppAddress1DataGridViewTextBoxColumn.DataPropertyName = "Supp_Address1"
        Me.SuppAddress1DataGridViewTextBoxColumn.HeaderText = "Supp_Address1"
        Me.SuppAddress1DataGridViewTextBoxColumn.Name = "SuppAddress1DataGridViewTextBoxColumn"
        Me.SuppAddress1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppAddress2DataGridViewTextBoxColumn
        '
        Me.SuppAddress2DataGridViewTextBoxColumn.DataPropertyName = "Supp_Address2"
        Me.SuppAddress2DataGridViewTextBoxColumn.HeaderText = "Supp_Address2"
        Me.SuppAddress2DataGridViewTextBoxColumn.Name = "SuppAddress2DataGridViewTextBoxColumn"
        Me.SuppAddress2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppSurburbDataGridViewTextBoxColumn
        '
        Me.SuppSurburbDataGridViewTextBoxColumn.DataPropertyName = "Supp_Surburb"
        Me.SuppSurburbDataGridViewTextBoxColumn.HeaderText = "Supp_Surburb"
        Me.SuppSurburbDataGridViewTextBoxColumn.Name = "SuppSurburbDataGridViewTextBoxColumn"
        Me.SuppSurburbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppCityDataGridViewTextBoxColumn
        '
        Me.SuppCityDataGridViewTextBoxColumn.DataPropertyName = "Supp_City"
        Me.SuppCityDataGridViewTextBoxColumn.HeaderText = "Supp_City"
        Me.SuppCityDataGridViewTextBoxColumn.Name = "SuppCityDataGridViewTextBoxColumn"
        Me.SuppCityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppPostalCodeDataGridViewTextBoxColumn
        '
        Me.SuppPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "Supp_Postal_Code"
        Me.SuppPostalCodeDataGridViewTextBoxColumn.HeaderText = "Supp_Postal_Code"
        Me.SuppPostalCodeDataGridViewTextBoxColumn.Name = "SuppPostalCodeDataGridViewTextBoxColumn"
        Me.SuppPostalCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.RecSpecDataset
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Purchase_OrderTableAdapter
        '
        Me.Purchase_OrderTableAdapter.ClearBeforeFill = True
        '
        'PurchaseItemBindingSource
        '
        Me.PurchaseItemBindingSource.DataMember = "Purchase_Item"
        Me.PurchaseItemBindingSource.DataSource = Me.RecSpecDataset
        '
        'Purchase_ItemTableAdapter
        '
        Me.Purchase_ItemTableAdapter.ClearBeforeFill = True
        '
        'WarehouseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 797)
        Me.Controls.Add(Me.WarehouseManagerTabControl)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WarehouseManager"
        Me.Text = "WarehouseManager"
        Me.WarehouseManagerTabControl.ResumeLayout(False)
        Me.WMProductsTab.ResumeLayout(False)
        Me.flpProducts.ResumeLayout(False)
        Me.flpProducts.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpProduct.ResumeLayout(False)
        Me.tlpProduct.PerformLayout()
        Me.WMPurchaseOrderTab.ResumeLayout(False)
        Me.WMPurchaseOrderTab.PerformLayout()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPO.ResumeLayout(False)
        Me.tlpPO.PerformLayout()
        Me.flpPOTotal.ResumeLayout(False)
        Me.flpPOTotal.PerformLayout()
        Me.WMSupplierTab.ResumeLayout(False)
        Me.WMSupplierTab.PerformLayout()
        Me.tlpSupplier.ResumeLayout(False)
        Me.tlpSupplier.PerformLayout()
        Me.flpSupplier.ResumeLayout(False)
        Me.flpSupplier.PerformLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WarehouseManagerTabControl As TabControl
    Friend WithEvents WMSupplierTab As TabPage
    Friend WithEvents WMProductsTab As TabPage
    Friend WithEvents WMPurchaseOrderTab As TabPage
    Friend WithEvents flpProducts As FlowLayoutPanel
    Friend WithEvents btnAddEditProduct As Button
    Friend WithEvents btnSaveProduct As Button
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents tlpProduct As TableLayoutPanel
    Friend WithEvents btnSearchProduct As Button
    Friend WithEvents tbQueryProduct As TextBox
    Friend WithEvents cbCriteriaProduct As ComboBox
    Friend WithEvents dgvPO As DataGridView
    Friend WithEvents dgvPOD As DataGridView
    Friend WithEvents tlpPO As TableLayoutPanel
    Friend WithEvents btnSearchPO As Button
    Friend WithEvents tbQueryPO As TextBox
    Friend WithEvents cbCriteriaPO As ComboBox
    Friend WithEvents flpPOTotal As FlowLayoutPanel
    Friend WithEvents lblPOTotal As Label
    Friend WithEvents tbPOTotal As TextBox
    Friend WithEvents RecSpecDataset As RecSpecDataset
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As RecSpecDatasetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdStockLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdVATDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProdActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProdCategoriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdReorderThresholdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As RecSpecDatasetTableAdapters.SupplierTableAdapter
    Friend WithEvents PurchaseOrderBindingSource As BindingSource
    Friend WithEvents Purchase_OrderTableAdapter As RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter
    Friend WithEvents PONoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PODateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POReceivedFlagDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Supp_Name As DataGridViewTextBoxColumn
    Friend WithEvents Emp_FName As DataGridViewTextBoxColumn
    Friend WithEvents tlpSupplier As TableLayoutPanel
    Friend WithEvents btnSearchSupplier As Button
    Friend WithEvents tbQuerySupplier As TextBox
    Friend WithEvents cbCriteriaSupplier As ComboBox
    Friend WithEvents flpSupplier As FlowLayoutPanel
    Friend WithEvents btnAddEditSupplier As Button
    Friend WithEvents btnSaveSupplier As Button
    Friend WithEvents btnRemoveSupplier As Button
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SuppNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppContactPersonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppAddress1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppAddress2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppSurburbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppCityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppPostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblPO As Label
    Friend WithEvents lblPoDetails As Label
    Friend WithEvents PurchaseItemBindingSource As BindingSource
    Friend WithEvents Purchase_ItemTableAdapter As RecSpecDatasetTableAdapters.Purchase_ItemTableAdapter
End Class
