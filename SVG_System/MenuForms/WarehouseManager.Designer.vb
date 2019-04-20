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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RecSpecDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecSpecDataset = New MenuForms.RecSpecDataset()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.Tc_WarehouseManager = New System.Windows.Forms.TabControl()
        Me.InventoryTab = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Prod_NameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Prod_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Prod_NameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Product_Code1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Product_CodeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Product_Code1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btrnDisableProduct = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdStockLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdCategoriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdReorderThresholdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrder = New System.Windows.Forms.TabPage()
        Me.lblPoDetails = New System.Windows.Forms.Label()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.btnEmpEdit = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.PurchaseOrderDetailsDGV = New System.Windows.Forms.DataGridView()
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseItemQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseItemPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderDGV = New System.Windows.Forms.DataGridView()
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchase_OrderTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter()
        Me.SaleItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sale_ItemTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Sale_ItemTableAdapter()
        Me.Purchase_ItemTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Purchase_ItemTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PONoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POReceivedFlagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.RecSpecDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tc_WarehouseManager.SuspendLayout()
        Me.InventoryTab.SuspendLayout()
        Me.Prod_NameToolStrip.SuspendLayout()
        Me.Product_Code1ToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchaseOrder.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PurchaseOrderDetailsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecSpecDatasetBindingSource
        '
        Me.RecSpecDatasetBindingSource.DataSource = Me.RecSpecDataset
        Me.RecSpecDatasetBindingSource.Position = 0
        '
        'RecSpecDataset
        '
        Me.RecSpecDataset.DataSetName = "RecSpecDataset"
        Me.RecSpecDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.RecSpecDataset
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'Tc_WarehouseManager
        '
        Me.Tc_WarehouseManager.AccessibleName = ""
        Me.Tc_WarehouseManager.Controls.Add(Me.InventoryTab)
        Me.Tc_WarehouseManager.Controls.Add(Me.PurchaseOrder)
        Me.Tc_WarehouseManager.Location = New System.Drawing.Point(15, 17)
        Me.Tc_WarehouseManager.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tc_WarehouseManager.Name = "Tc_WarehouseManager"
        Me.Tc_WarehouseManager.SelectedIndex = 0
        Me.Tc_WarehouseManager.Size = New System.Drawing.Size(1267, 717)
        Me.Tc_WarehouseManager.TabIndex = 0
        '
        'InventoryTab
        '
        Me.InventoryTab.AutoScroll = True
        Me.InventoryTab.Controls.Add(Me.Label1)
        Me.InventoryTab.Controls.Add(Me.ComboBox2)
        Me.InventoryTab.Controls.Add(Me.Prod_NameToolStrip)
        Me.InventoryTab.Controls.Add(Me.Product_Code1ToolStrip)
        Me.InventoryTab.Controls.Add(Me.Panel1)
        Me.InventoryTab.Controls.Add(Me.ProductDGV)
        Me.InventoryTab.Location = New System.Drawing.Point(4, 26)
        Me.InventoryTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryTab.Name = "InventoryTab"
        Me.InventoryTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryTab.Size = New System.Drawing.Size(1259, 687)
        Me.InventoryTab.TabIndex = 1
        Me.InventoryTab.Text = "Products"
        Me.InventoryTab.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Product Name", "Product Code"})
        Me.ComboBox2.Location = New System.Drawing.Point(187, 188)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox2.TabIndex = 28
        Me.ComboBox2.Text = "Search Criteria"
        '
        'Prod_NameToolStrip
        '
        Me.Prod_NameToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Prod_NameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Prod_NameToolStripTextBox, Me.Prod_NameToolStripButton})
        Me.Prod_NameToolStrip.Location = New System.Drawing.Point(311, 188)
        Me.Prod_NameToolStrip.Name = "Prod_NameToolStrip"
        Me.Prod_NameToolStrip.Size = New System.Drawing.Size(160, 25)
        Me.Prod_NameToolStrip.TabIndex = 1
        Me.Prod_NameToolStrip.Text = "Prod_NameToolStrip"
        Me.Prod_NameToolStrip.Visible = False
        '
        'Prod_NameToolStripTextBox
        '
        Me.Prod_NameToolStripTextBox.Name = "Prod_NameToolStripTextBox"
        Me.Prod_NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Prod_NameToolStripButton
        '
        Me.Prod_NameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Prod_NameToolStripButton.Name = "Prod_NameToolStripButton"
        Me.Prod_NameToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.Prod_NameToolStripButton.Text = "Search"
        '
        'Product_Code1ToolStrip
        '
        Me.Product_Code1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Product_Code1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Product_CodeToolStripTextBox, Me.Product_Code1ToolStripButton})
        Me.Product_Code1ToolStrip.Location = New System.Drawing.Point(311, 188)
        Me.Product_Code1ToolStrip.Name = "Product_Code1ToolStrip"
        Me.Product_Code1ToolStrip.Size = New System.Drawing.Size(160, 25)
        Me.Product_Code1ToolStrip.TabIndex = 1
        Me.Product_Code1ToolStrip.Text = "Product_Code1ToolStrip"
        Me.Product_Code1ToolStrip.Visible = False
        '
        'Product_CodeToolStripTextBox
        '
        Me.Product_CodeToolStripTextBox.Name = "Product_CodeToolStripTextBox"
        Me.Product_CodeToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Product_Code1ToolStripButton
        '
        Me.Product_Code1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Product_Code1ToolStripButton.Name = "Product_Code1ToolStripButton"
        Me.Product_Code1ToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.Product_Code1ToolStripButton.Text = "Search"
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.btrnDisableProduct)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Location = New System.Drawing.Point(252, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 126)
        Me.Panel1.TabIndex = 27
        '
        'btrnDisableProduct
        '
        Me.btrnDisableProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btrnDisableProduct.Image = Global.MenuForms.My.Resources.Resources.network_error_icon
        Me.btrnDisableProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btrnDisableProduct.Location = New System.Drawing.Point(552, 4)
        Me.btrnDisableProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btrnDisableProduct.Name = "btrnDisableProduct"
        Me.btrnDisableProduct.Size = New System.Drawing.Size(161, 118)
        Me.btrnDisableProduct.TabIndex = 31
        Me.btrnDisableProduct.Text = "Deactivate Product"
        Me.btrnDisableProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btrnDisableProduct.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnUpdate.Image = Global.MenuForms.My.Resources.Resources.Pencil_icon
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.Location = New System.Drawing.Point(0, 4)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(161, 118)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Add New/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edit Products"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseCompatibleTextRendering = True
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Image = Global.MenuForms.My.Resources.Resources.Save_icon
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(369, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 118)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = Global.MenuForms.My.Resources.Resources.bin_red_full_icon
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(185, 4)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(161, 118)
        Me.btnRemove.TabIndex = 30
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'ProductDGV
        '
        Me.ProductDGV.AllowUserToAddRows = False
        Me.ProductDGV.AllowUserToDeleteRows = False
        Me.ProductDGV.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCodeDataGridViewTextBoxColumn, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdCostPriceDataGridViewTextBoxColumn, Me.ProdStockLevelDataGridViewTextBoxColumn, Me.ProdVATDataGridViewTextBoxColumn, Me.ProdActiveDataGridViewCheckBoxColumn, Me.ProdCategoriesDataGridViewTextBoxColumn, Me.ProdReorderThresholdDataGridViewTextBoxColumn})
        Me.ProductDGV.DataSource = Me.ProductBindingSource2
        Me.ProductDGV.Location = New System.Drawing.Point(19, 220)
        Me.ProductDGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductDGV.MultiSelect = False
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.ReadOnly = True
        Me.ProductDGV.Size = New System.Drawing.Size(1211, 390)
        Me.ProductDGV.TabIndex = 16
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
        'ProdVATDataGridViewTextBoxColumn
        '
        Me.ProdVATDataGridViewTextBoxColumn.DataPropertyName = "Prod_VAT"
        Me.ProdVATDataGridViewTextBoxColumn.HeaderText = "Prod_VAT"
        Me.ProdVATDataGridViewTextBoxColumn.Name = "ProdVATDataGridViewTextBoxColumn"
        Me.ProdVATDataGridViewTextBoxColumn.ReadOnly = True
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
        'ProductBindingSource2
        '
        Me.ProductBindingSource2.DataMember = "Product"
        Me.ProductBindingSource2.DataSource = Me.RecSpecDatasetBindingSource
        '
        'PurchaseOrder
        '
        Me.PurchaseOrder.Controls.Add(Me.Label2)
        Me.PurchaseOrder.Controls.Add(Me.lblPoDetails)
        Me.PurchaseOrder.Controls.Add(Me.lblPO)
        Me.PurchaseOrder.Controls.Add(Me.Panel6)
        Me.PurchaseOrder.Controls.Add(Me.ComboBox1)
        Me.PurchaseOrder.Controls.Add(Me.PurchaseOrderDetailsDGV)
        Me.PurchaseOrder.Controls.Add(Me.PurchaseOrderDGV)
        Me.PurchaseOrder.Location = New System.Drawing.Point(4, 26)
        Me.PurchaseOrder.Name = "PurchaseOrder"
        Me.PurchaseOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.PurchaseOrder.Size = New System.Drawing.Size(1259, 687)
        Me.PurchaseOrder.TabIndex = 8
        Me.PurchaseOrder.Text = "Purchase Order"
        Me.PurchaseOrder.UseVisualStyleBackColor = True
        '
        'lblPoDetails
        '
        Me.lblPoDetails.AutoSize = True
        Me.lblPoDetails.Location = New System.Drawing.Point(78, 446)
        Me.lblPoDetails.Name = "lblPoDetails"
        Me.lblPoDetails.Size = New System.Drawing.Size(142, 17)
        Me.lblPoDetails.TabIndex = 77
        Me.lblPoDetails.Text = "Purchase Order Details"
        '
        'lblPO
        '
        Me.lblPO.AutoSize = True
        Me.lblPO.Location = New System.Drawing.Point(78, 204)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(105, 17)
        Me.lblPO.TabIndex = 76
        Me.lblPO.Text = "Purchase Orders"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button19)
        Me.Panel6.Controls.Add(Me.btnEmpEdit)
        Me.Panel6.Controls.Add(Me.Button27)
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(297, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(446, 149)
        Me.Panel6.TabIndex = 75
        '
        'Button19
        '
        Me.Button19.Image = Global.MenuForms.My.Resources.Resources.bin_red_full_icon
        Me.Button19.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button19.Location = New System.Drawing.Point(310, 4)
        Me.Button19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button19.Name = "Button19"
        Me.Button19.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Button19.Size = New System.Drawing.Size(125, 141)
        Me.Button19.TabIndex = 31
        Me.Button19.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remove"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'btnEmpEdit
        '
        Me.btnEmpEdit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnEmpEdit.Image = Global.MenuForms.My.Resources.Resources.Pencil_icon
        Me.btnEmpEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmpEdit.Location = New System.Drawing.Point(12, 4)
        Me.btnEmpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEmpEdit.Name = "btnEmpEdit"
        Me.btnEmpEdit.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.btnEmpEdit.Size = New System.Drawing.Size(125, 141)
        Me.btnEmpEdit.TabIndex = 29
        Me.btnEmpEdit.Text = "Add New/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edit Purchase Order"
        Me.btnEmpEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmpEdit.UseCompatibleTextRendering = True
        Me.btnEmpEdit.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Image = Global.MenuForms.My.Resources.Resources.Save_icon
        Me.Button27.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button27.Location = New System.Drawing.Point(158, 4)
        Me.Button27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button27.Name = "Button27"
        Me.Button27.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Button27.Size = New System.Drawing.Size(125, 141)
        Me.Button27.TabIndex = 30
        Me.Button27.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'PurchaseOrderDetailsDGV
        '
        Me.PurchaseOrderDetailsDGV.AllowUserToAddRows = False
        Me.PurchaseOrderDetailsDGV.AllowUserToDeleteRows = False
        Me.PurchaseOrderDetailsDGV.AutoGenerateColumns = False
        Me.PurchaseOrderDetailsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PurchaseOrderDetailsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PurchaseOrderDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseOrderDetailsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseItemLineNoDataGridViewTextBoxColumn, Me.PONoDataGridViewTextBoxColumn1, Me.PurchaseItemQtyDataGridViewTextBoxColumn, Me.PurchaseItemPriceDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn1})
        Me.PurchaseOrderDetailsDGV.DataSource = Me.PurchaseItemBindingSource
        Me.PurchaseOrderDetailsDGV.Location = New System.Drawing.Point(81, 470)
        Me.PurchaseOrderDetailsDGV.MultiSelect = False
        Me.PurchaseOrderDetailsDGV.Name = "PurchaseOrderDetailsDGV"
        Me.PurchaseOrderDetailsDGV.ReadOnly = True
        Me.PurchaseOrderDetailsDGV.Size = New System.Drawing.Size(831, 204)
        Me.PurchaseOrderDetailsDGV.TabIndex = 62
        '
        'PurchaseItemLineNoDataGridViewTextBoxColumn
        '
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Item_Line_No"
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.HeaderText = "Purchase Item ID"
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.Name = "PurchaseItemLineNoDataGridViewTextBoxColumn"
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PONoDataGridViewTextBoxColumn1
        '
        Me.PONoDataGridViewTextBoxColumn1.DataPropertyName = "PO_No"
        Me.PONoDataGridViewTextBoxColumn1.HeaderText = "Purchase Order No"
        Me.PONoDataGridViewTextBoxColumn1.Name = "PONoDataGridViewTextBoxColumn1"
        Me.PONoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PurchaseItemQtyDataGridViewTextBoxColumn
        '
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Item_Qty"
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.HeaderText = "Purchase Item Quantity"
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.Name = "PurchaseItemQtyDataGridViewTextBoxColumn"
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurchaseItemPriceDataGridViewTextBoxColumn
        '
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Item_Price"
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.HeaderText = "Purchase Item Price"
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.Name = "PurchaseItemPriceDataGridViewTextBoxColumn"
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductCodeDataGridViewTextBoxColumn1
        '
        Me.ProductCodeDataGridViewTextBoxColumn1.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn1.HeaderText = "Product ID"
        Me.ProductCodeDataGridViewTextBoxColumn1.Name = "ProductCodeDataGridViewTextBoxColumn1"
        Me.ProductCodeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PurchaseItemBindingSource
        '
        Me.PurchaseItemBindingSource.DataMember = "Purchase_Item"
        Me.PurchaseItemBindingSource.DataSource = Me.RecSpecDataset
        '
        'PurchaseOrderDGV
        '
        Me.PurchaseOrderDGV.AllowUserToAddRows = False
        Me.PurchaseOrderDGV.AllowUserToDeleteRows = False
        Me.PurchaseOrderDGV.AutoGenerateColumns = False
        Me.PurchaseOrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PurchaseOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseOrderDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONoDataGridViewTextBoxColumn, Me.PODateDataGridViewTextBoxColumn, Me.POTotalDataGridViewTextBoxColumn, Me.POReceivedFlagDataGridViewCheckBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn})
        Me.PurchaseOrderDGV.DataSource = Me.PurchaseOrderBindingSource
        Me.PurchaseOrderDGV.Location = New System.Drawing.Point(81, 224)
        Me.PurchaseOrderDGV.MultiSelect = False
        Me.PurchaseOrderDGV.Name = "PurchaseOrderDGV"
        Me.PurchaseOrderDGV.ReadOnly = True
        Me.PurchaseOrderDGV.Size = New System.Drawing.Size(831, 213)
        Me.PurchaseOrderDGV.TabIndex = 61
        '
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "Purchase_Order"
        Me.PurchaseOrderBindingSource.DataSource = Me.RecSpecDatasetBindingSource
        '
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "Product"
        Me.ProductBindingSource1.DataSource = Me.RecSpecDatasetBindingSource
        '
        'Purchase_OrderTableAdapter
        '
        Me.Purchase_OrderTableAdapter.ClearBeforeFill = True
        '
        'SaleItemBindingSource
        '
        Me.SaleItemBindingSource.DataMember = "Sale_Item"
        Me.SaleItemBindingSource.DataSource = Me.RecSpecDataset
        '
        'Sale_ItemTableAdapter
        '
        Me.Sale_ItemTableAdapter.ClearBeforeFill = True
        '
        'Purchase_ItemTableAdapter
        '
        Me.Purchase_ItemTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Search By:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(199, 161)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 25)
        Me.ComboBox1.TabIndex = 73
        Me.ComboBox1.Text = "Search criteria..."
        '
        'PONoDataGridViewTextBoxColumn
        '
        Me.PONoDataGridViewTextBoxColumn.DataPropertyName = "PO_No"
        Me.PONoDataGridViewTextBoxColumn.HeaderText = "Purchase Order No"
        Me.PONoDataGridViewTextBoxColumn.Name = "PONoDataGridViewTextBoxColumn"
        Me.PONoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PODateDataGridViewTextBoxColumn
        '
        Me.PODateDataGridViewTextBoxColumn.DataPropertyName = "PO_Date"
        Me.PODateDataGridViewTextBoxColumn.HeaderText = "Purchase Order Date (YYYY/MM/DD)"
        Me.PODateDataGridViewTextBoxColumn.Name = "PODateDataGridViewTextBoxColumn"
        Me.PODateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POTotalDataGridViewTextBoxColumn
        '
        Me.POTotalDataGridViewTextBoxColumn.DataPropertyName = "PO_Total"
        Me.POTotalDataGridViewTextBoxColumn.HeaderText = "Purchase Order Total"
        Me.POTotalDataGridViewTextBoxColumn.Name = "POTotalDataGridViewTextBoxColumn"
        Me.POTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POReceivedFlagDataGridViewCheckBoxColumn
        '
        Me.POReceivedFlagDataGridViewCheckBoxColumn.DataPropertyName = "PO_Received_Flag"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.HeaderText = "Receiving Status"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.Name = "POReceivedFlagDataGridViewCheckBoxColumn"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Search By:"
        '
        'WarehouseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 726)
        Me.Controls.Add(Me.Tc_WarehouseManager)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WarehouseManager"
        Me.Text = "Warehouse Manager"
        Me.TopMost = True
        CType(Me.RecSpecDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tc_WarehouseManager.ResumeLayout(False)
        Me.InventoryTab.ResumeLayout(False)
        Me.InventoryTab.PerformLayout()
        Me.Prod_NameToolStrip.ResumeLayout(False)
        Me.Prod_NameToolStrip.PerformLayout()
        Me.Product_Code1ToolStrip.ResumeLayout(False)
        Me.Product_Code1ToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PurchaseOrder.ResumeLayout(False)
        Me.PurchaseOrder.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PurchaseOrderDetailsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecSpecDataset As RecSpecDataset
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As RecSpecDatasetTableAdapters.ProductTableAdapter
    Friend WithEvents RecSpecDatasetBindingSource As BindingSource
    Friend WithEvents ProName As DataGridViewTextBoxColumn
    Friend WithEvents Tc_WarehouseManager As TabControl
    Friend WithEvents InventoryTab As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btrnDisableProduct As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents ProductDGV As DataGridView
    Friend WithEvents PurchaseOrder As TabPage
    Friend WithEvents lblPoDetails As Label
    Friend WithEvents lblPO As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button19 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents btnEmpEdit As Button
    Friend WithEvents PurchaseOrderDetailsDGV As DataGridView
    Friend WithEvents PurchaseOrderDGV As DataGridView
    Friend WithEvents ProductBindingSource2 As BindingSource
    Friend WithEvents ProductBindingSource1 As BindingSource
    Friend WithEvents ProdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdStockLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProdCategoriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdReorderThresholdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseOrderBindingSource As BindingSource
    Friend WithEvents Purchase_OrderTableAdapter As RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VATDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CategoriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReorderThresholdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleItemBindingSource As BindingSource
    Friend WithEvents Sale_ItemTableAdapter As RecSpecDatasetTableAdapters.Sale_ItemTableAdapter
    Friend WithEvents PurchaseItemBindingSource As BindingSource
    Friend WithEvents Purchase_ItemTableAdapter As RecSpecDatasetTableAdapters.Purchase_ItemTableAdapter
    Friend WithEvents PurchaseItemLineNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PONoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseItemQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseItemPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Product_Code1ToolStrip As ToolStrip
    Friend WithEvents Product_CodeToolStripTextBox As ToolStripTextBox
    Friend WithEvents Product_Code1ToolStripButton As ToolStripButton
    Friend WithEvents Prod_NameToolStrip As ToolStrip
    Friend WithEvents Prod_NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents Prod_NameToolStripButton As ToolStripButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PONoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PODateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POReceivedFlagDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
