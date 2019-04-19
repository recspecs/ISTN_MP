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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btrnDisableProduct = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNewProduct = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cbSearchParam = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdStockLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdVATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdCategoriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdReorderThresholdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PurchaseOrder = New System.Windows.Forms.TabPage()
        Me.lblPoDetails = New System.Windows.Forms.Label()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.btnEmpEdit = New System.Windows.Forms.Button()
        Me.btnNewEmp = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.PoProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoCostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PONoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POReceivedFlagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchase_OrderTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter()
        CType(Me.RecSpecDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tc_WarehouseManager.SuspendLayout()
        Me.InventoryTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchaseOrder.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Tc_WarehouseManager.Size = New System.Drawing.Size(1248, 686)
        Me.Tc_WarehouseManager.TabIndex = 0
        '
        'InventoryTab
        '
        Me.InventoryTab.Controls.Add(Me.Panel1)
        Me.InventoryTab.Controls.Add(Me.cbSearchParam)
        Me.InventoryTab.Controls.Add(Me.DataGridView1)
        Me.InventoryTab.Controls.Add(Me.TextBox21)
        Me.InventoryTab.Controls.Add(Me.Button7)
        Me.InventoryTab.Location = New System.Drawing.Point(4, 26)
        Me.InventoryTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryTab.Name = "InventoryTab"
        Me.InventoryTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryTab.Size = New System.Drawing.Size(1240, 656)
        Me.InventoryTab.TabIndex = 1
        Me.InventoryTab.Text = "Products"
        Me.InventoryTab.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.btrnDisableProduct)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAddNewProduct)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Location = New System.Drawing.Point(205, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 126)
        Me.Panel1.TabIndex = 27
        '
        'btrnDisableProduct
        '
        Me.btrnDisableProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btrnDisableProduct.Image = Global.MenuForms.My.Resources.Resources.network_error_icon
        Me.btrnDisableProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btrnDisableProduct.Location = New System.Drawing.Point(717, 4)
        Me.btrnDisableProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btrnDisableProduct.Name = "btrnDisableProduct"
        Me.btrnDisableProduct.Size = New System.Drawing.Size(121, 118)
        Me.btrnDisableProduct.TabIndex = 31
        Me.btrnDisableProduct.Text = "Deactivate Product"
        Me.btrnDisableProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btrnDisableProduct.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = Global.MenuForms.My.Resources.Resources.bin_red_full_icon
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(536, 4)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(121, 118)
        Me.btnRemove.TabIndex = 30
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Image = Global.MenuForms.My.Resources.Resources.Save_icon
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(350, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 118)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNewProduct.Image = Global.MenuForms.My.Resources.Resources.add_icon
        Me.btnAddNewProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddNewProduct.Location = New System.Drawing.Point(5, 4)
        Me.btnAddNewProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(121, 118)
        Me.btnAddNewProduct.TabIndex = 27
        Me.btnAddNewProduct.Text = "Add New Product"
        Me.btnAddNewProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddNewProduct.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnUpdate.Image = Global.MenuForms.My.Resources.Resources.Pencil_icon
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.Location = New System.Drawing.Point(175, 4)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 118)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseCompatibleTextRendering = True
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cbSearchParam
        '
        Me.cbSearchParam.FormattingEnabled = True
        Me.cbSearchParam.Items.AddRange(New Object() {"By Product Code", "By Name"})
        Me.cbSearchParam.Location = New System.Drawing.Point(924, 176)
        Me.cbSearchParam.Name = "cbSearchParam"
        Me.cbSearchParam.Size = New System.Drawing.Size(151, 25)
        Me.cbSearchParam.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCodeDataGridViewTextBoxColumn, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdCostPriceDataGridViewTextBoxColumn, Me.ProdStockLevelDataGridViewTextBoxColumn, Me.ProdVATDataGridViewTextBoxColumn, Me.ProdActiveDataGridViewCheckBoxColumn, Me.ProdCategoriesDataGridViewTextBoxColumn, Me.ProdReorderThresholdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(19, 220)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1211, 390)
        Me.DataGridView1.TabIndex = 16
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        '
        'ProdNameDataGridViewTextBoxColumn
        '
        Me.ProdNameDataGridViewTextBoxColumn.DataPropertyName = "Prod_Name"
        Me.ProdNameDataGridViewTextBoxColumn.HeaderText = "Prod_Name"
        Me.ProdNameDataGridViewTextBoxColumn.Name = "ProdNameDataGridViewTextBoxColumn"
        '
        'ProdCostPriceDataGridViewTextBoxColumn
        '
        Me.ProdCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Prod_Cost_Price"
        Me.ProdCostPriceDataGridViewTextBoxColumn.HeaderText = "Prod_Cost_Price"
        Me.ProdCostPriceDataGridViewTextBoxColumn.Name = "ProdCostPriceDataGridViewTextBoxColumn"
        '
        'ProdStockLevelDataGridViewTextBoxColumn
        '
        Me.ProdStockLevelDataGridViewTextBoxColumn.DataPropertyName = "Prod_Stock_Level"
        Me.ProdStockLevelDataGridViewTextBoxColumn.HeaderText = "Prod_Stock_Level"
        Me.ProdStockLevelDataGridViewTextBoxColumn.Name = "ProdStockLevelDataGridViewTextBoxColumn"
        '
        'ProdVATDataGridViewTextBoxColumn
        '
        Me.ProdVATDataGridViewTextBoxColumn.DataPropertyName = "Prod_VAT"
        Me.ProdVATDataGridViewTextBoxColumn.HeaderText = "Prod_VAT"
        Me.ProdVATDataGridViewTextBoxColumn.Name = "ProdVATDataGridViewTextBoxColumn"
        '
        'ProdActiveDataGridViewCheckBoxColumn
        '
        Me.ProdActiveDataGridViewCheckBoxColumn.DataPropertyName = "Prod_Active"
        Me.ProdActiveDataGridViewCheckBoxColumn.HeaderText = "Prod_Active"
        Me.ProdActiveDataGridViewCheckBoxColumn.Name = "ProdActiveDataGridViewCheckBoxColumn"
        '
        'ProdCategoriesDataGridViewTextBoxColumn
        '
        Me.ProdCategoriesDataGridViewTextBoxColumn.DataPropertyName = "Prod_Categories"
        Me.ProdCategoriesDataGridViewTextBoxColumn.HeaderText = "Prod_Categories"
        Me.ProdCategoriesDataGridViewTextBoxColumn.Name = "ProdCategoriesDataGridViewTextBoxColumn"
        '
        'ProdReorderThresholdDataGridViewTextBoxColumn
        '
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Reorder_Threshold"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.HeaderText = "Prod_Reorder_Threshold"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.Name = "ProdReorderThresholdDataGridViewTextBoxColumn"
        '
        'ProductBindingSource2
        '
        Me.ProductBindingSource2.DataMember = "Product"
        Me.ProductBindingSource2.DataSource = Me.RecSpecDatasetBindingSource
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(330, 176)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(560, 25)
        Me.TextBox21.TabIndex = 15
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(180, 172)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 30)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Search Product"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PurchaseOrder
        '
        Me.PurchaseOrder.Controls.Add(Me.lblPoDetails)
        Me.PurchaseOrder.Controls.Add(Me.lblPO)
        Me.PurchaseOrder.Controls.Add(Me.Panel6)
        Me.PurchaseOrder.Controls.Add(Me.Button30)
        Me.PurchaseOrder.Controls.Add(Me.ComboBox1)
        Me.PurchaseOrder.Controls.Add(Me.TextBox6)
        Me.PurchaseOrder.Controls.Add(Me.DataGridView7)
        Me.PurchaseOrder.Controls.Add(Me.DataGridView2)
        Me.PurchaseOrder.Location = New System.Drawing.Point(4, 26)
        Me.PurchaseOrder.Name = "PurchaseOrder"
        Me.PurchaseOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.PurchaseOrder.Size = New System.Drawing.Size(1240, 656)
        Me.PurchaseOrder.TabIndex = 8
        Me.PurchaseOrder.Text = "Purchase Order"
        Me.PurchaseOrder.UseVisualStyleBackColor = True
        '
        'lblPoDetails
        '
        Me.lblPoDetails.AutoSize = True
        Me.lblPoDetails.Location = New System.Drawing.Point(78, 421)
        Me.lblPoDetails.Name = "lblPoDetails"
        Me.lblPoDetails.Size = New System.Drawing.Size(142, 17)
        Me.lblPoDetails.TabIndex = 77
        Me.lblPoDetails.Text = "Purchase Order Details"
        '
        'lblPO
        '
        Me.lblPO.AutoSize = True
        Me.lblPO.Location = New System.Drawing.Point(78, 179)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(105, 17)
        Me.lblPO.TabIndex = 76
        Me.lblPO.Text = "Purchase Orders"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button19)
        Me.Panel6.Controls.Add(Me.Button27)
        Me.Panel6.Controls.Add(Me.btnEmpEdit)
        Me.Panel6.Controls.Add(Me.btnNewEmp)
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(193, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(624, 135)
        Me.Panel6.TabIndex = 75
        '
        'Button19
        '
        Me.Button19.Image = Global.MenuForms.My.Resources.Resources.bin_red_full_icon
        Me.Button19.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button19.Location = New System.Drawing.Point(485, 15)
        Me.Button19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button19.Name = "Button19"
        Me.Button19.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Button19.Size = New System.Drawing.Size(125, 104)
        Me.Button19.TabIndex = 31
        Me.Button19.Text = "Remove"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Image = Global.MenuForms.My.Resources.Resources.Save_icon
        Me.Button27.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button27.Location = New System.Drawing.Point(333, 15)
        Me.Button27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button27.Name = "Button27"
        Me.Button27.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Button27.Size = New System.Drawing.Size(125, 104)
        Me.Button27.TabIndex = 30
        Me.Button27.Text = "Save"
        Me.Button27.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button27.UseVisualStyleBackColor = True
        '
        'btnEmpEdit
        '
        Me.btnEmpEdit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnEmpEdit.Image = Global.MenuForms.My.Resources.Resources.Pencil_icon
        Me.btnEmpEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmpEdit.Location = New System.Drawing.Point(187, 15)
        Me.btnEmpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEmpEdit.Name = "btnEmpEdit"
        Me.btnEmpEdit.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.btnEmpEdit.Size = New System.Drawing.Size(125, 104)
        Me.btnEmpEdit.TabIndex = 29
        Me.btnEmpEdit.Text = "Edit"
        Me.btnEmpEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmpEdit.UseCompatibleTextRendering = True
        Me.btnEmpEdit.UseVisualStyleBackColor = True
        '
        'btnNewEmp
        '
        Me.btnNewEmp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewEmp.Image = Global.MenuForms.My.Resources.Resources.add_icon
        Me.btnNewEmp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewEmp.Location = New System.Drawing.Point(22, 15)
        Me.btnNewEmp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewEmp.Name = "btnNewEmp"
        Me.btnNewEmp.Size = New System.Drawing.Size(125, 104)
        Me.btnNewEmp.TabIndex = 28
        Me.btnNewEmp.Text = "Add new " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "purchase order"
        Me.btnNewEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewEmp.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Image = Global.MenuForms.My.Resources.Resources.searchico2n
        Me.Button30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button30.Location = New System.Drawing.Point(227, 147)
        Me.Button30.Name = "Button30"
        Me.Button30.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button30.Size = New System.Drawing.Size(141, 28)
        Me.Button30.TabIndex = 74
        Me.Button30.Text = "Search"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(629, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 25)
        Me.ComboBox1.TabIndex = 73
        Me.ComboBox1.Text = "Search criteria..."
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(392, 147)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(194, 25)
        Me.TextBox6.TabIndex = 72
        Me.TextBox6.Text = "Enter query ..."
        '
        'DataGridView7
        '
        Me.DataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView7.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PoProductCode, Me.PoProductName, Me.PoCostPrice, Me.PurchaseQty})
        Me.DataGridView7.Location = New System.Drawing.Point(81, 441)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(831, 204)
        Me.DataGridView7.TabIndex = 62
        '
        'PoProductCode
        '
        Me.PoProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PoProductCode.FillWeight = 60.0!
        Me.PoProductCode.HeaderText = "Product Code"
        Me.PoProductCode.Name = "PoProductCode"
        '
        'PoProductName
        '
        Me.PoProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PoProductName.FillWeight = 200.0!
        Me.PoProductName.HeaderText = "Product Name"
        Me.PoProductName.Name = "PoProductName"
        '
        'PoCostPrice
        '
        Me.PoCostPrice.HeaderText = "Cost Price"
        Me.PoCostPrice.Name = "PoCostPrice"
        '
        'PurchaseQty
        '
        Me.PurchaseQty.HeaderText = "Purchase Qty"
        Me.PurchaseQty.Name = "PurchaseQty"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONoDataGridViewTextBoxColumn, Me.PODateDataGridViewTextBoxColumn, Me.POTotalDataGridViewTextBoxColumn, Me.POReceivedFlagDataGridViewCheckBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PurchaseOrderBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(81, 195)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(831, 213)
        Me.DataGridView2.TabIndex = 61
        '
        'PONoDataGridViewTextBoxColumn
        '
        Me.PONoDataGridViewTextBoxColumn.DataPropertyName = "PO_No"
        Me.PONoDataGridViewTextBoxColumn.HeaderText = "Purchase Order No"
        Me.PONoDataGridViewTextBoxColumn.Name = "PONoDataGridViewTextBoxColumn"
        '
        'PODateDataGridViewTextBoxColumn
        '
        Me.PODateDataGridViewTextBoxColumn.DataPropertyName = "PO_Date"
        Me.PODateDataGridViewTextBoxColumn.HeaderText = "Purchase Order Date"
        Me.PODateDataGridViewTextBoxColumn.Name = "PODateDataGridViewTextBoxColumn"
        '
        'POTotalDataGridViewTextBoxColumn
        '
        Me.POTotalDataGridViewTextBoxColumn.DataPropertyName = "PO_Total"
        Me.POTotalDataGridViewTextBoxColumn.HeaderText = "Purchase Order Total"
        Me.POTotalDataGridViewTextBoxColumn.Name = "POTotalDataGridViewTextBoxColumn"
        '
        'POReceivedFlagDataGridViewCheckBoxColumn
        '
        Me.POReceivedFlagDataGridViewCheckBoxColumn.DataPropertyName = "PO_Received_Flag"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.HeaderText = "Receiving Status"
        Me.POReceivedFlagDataGridViewCheckBoxColumn.Name = "POReceivedFlagDataGridViewCheckBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
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
        'WarehouseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 701)
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
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PurchaseOrder.ResumeLayout(False)
        Me.PurchaseOrder.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAddNewProduct As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cbSearchParam As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents PurchaseOrder As TabPage
    Friend WithEvents lblPoDetails As Label
    Friend WithEvents lblPO As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button19 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents btnEmpEdit As Button
    Friend WithEvents btnNewEmp As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents PoProductCode As DataGridViewTextBoxColumn
    Friend WithEvents PoProductName As DataGridViewTextBoxColumn
    Friend WithEvents PoCostPrice As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseQty As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ProductBindingSource2 As BindingSource
    Friend WithEvents ProductBindingSource1 As BindingSource
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdStockLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdVATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProdCategoriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdReorderThresholdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseOrderBindingSource As BindingSource
    Friend WithEvents Purchase_OrderTableAdapter As RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter
    Friend WithEvents PONoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PODateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POReceivedFlagDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
