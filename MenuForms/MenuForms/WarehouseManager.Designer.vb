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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vat = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PONum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbcSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PurchaseOrder = New System.Windows.Forms.TabPage()
        Me.lblPoDetails = New System.Windows.Forms.Label()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.btnEmpEdit = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.PoProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoCostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PurchaseOrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurOrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoPurTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivingStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNewEmp = New System.Windows.Forms.Button()
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tc_WarehouseManager.SuspendLayout
        Me.InventoryTab.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PurchaseOrder.SuspendLayout
        Me.Panel6.SuspendLayout
        CType(Me.DataGridView7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        Me.ProductTableAdapter.ClearBeforeFill = true
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
        Me.InventoryTab.Size = New System.Drawing.Size(1240, 618)
        Me.InventoryTab.TabIndex = 1
        Me.InventoryTab.Text = "Products"
        Me.InventoryTab.UseVisualStyleBackColor = true
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
        Me.btrnDisableProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btrnDisableProduct.Image = Global.MenuForms.My.Resources.Resources.network_error_icon
        Me.btrnDisableProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btrnDisableProduct.Location = New System.Drawing.Point(717, 4)
        Me.btrnDisableProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btrnDisableProduct.Name = "btrnDisableProduct"
        Me.btrnDisableProduct.Size = New System.Drawing.Size(121, 118)
        Me.btrnDisableProduct.TabIndex = 31
        Me.btrnDisableProduct.Text = "Deactivate Product"
        Me.btrnDisableProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btrnDisableProduct.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = Global.MenuForms.My.Resources.Resources.bin_red_full_icon
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(536, 4)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(121, 118)
        Me.btnRemove.TabIndex = 30
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSave.Image = Global.MenuForms.My.Resources.Resources.Save_icon
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(350, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 118)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAddNewProduct.Image = Global.MenuForms.My.Resources.Resources.add_icon
        Me.btnAddNewProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddNewProduct.Location = New System.Drawing.Point(5, 4)
        Me.btnAddNewProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(121, 118)
        Me.btnAddNewProduct.TabIndex = 27
        Me.btnAddNewProduct.Text = "Add New Product"
        Me.btnAddNewProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddNewProduct.UseVisualStyleBackColor = true
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
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
        Me.btnUpdate.UseCompatibleTextRendering = true
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'cbSearchParam
        '
        Me.cbSearchParam.FormattingEnabled = true
        Me.cbSearchParam.Items.AddRange(New Object() {"By Product Code", "By Name"})
        Me.cbSearchParam.Location = New System.Drawing.Point(924, 176)
        Me.cbSearchParam.Name = "cbSearchParam"
        Me.cbSearchParam.Size = New System.Drawing.Size(151, 25)
        Me.cbSearchParam.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = true
        Me.DataGridView1.AutoGenerateColumns = false
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCode, Me.ProductDescript, Me.SellingPrice, Me.OnHand, Me.Vat, Me.Active, Me.PONum, Me.PoDate, Me.ReturnId, Me.LastReturnDate, Me.tbcSupplier})
        Me.DataGridView1.DataSource = Me.RecSpecDatasetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 220)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1211, 390)
        Me.DataGridView1.TabIndex = 16
        '
        'ProductCode
        '
        Me.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductCode.DividerWidth = 1
        Me.ProductCode.FillWeight = 80!
        Me.ProductCode.HeaderText = "Product Code"
        Me.ProductCode.MinimumWidth = 40
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = true
        '
        'ProductDescript
        '
        Me.ProductDescript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductDescript.FillWeight = 200!
        Me.ProductDescript.HeaderText = "Product Name"
        Me.ProductDescript.MinimumWidth = 80
        Me.ProductDescript.Name = "ProductDescript"
        '
        'SellingPrice
        '
        Me.SellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SellingPrice.FillWeight = 88.55048!
        Me.SellingPrice.HeaderText = "Selling Price"
        Me.SellingPrice.Name = "SellingPrice"
        '
        'OnHand
        '
        Me.OnHand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OnHand.FillWeight = 88.55048!
        Me.OnHand.HeaderText = "On Hand"
        Me.OnHand.Name = "OnHand"
        '
        'Vat
        '
        Me.Vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Vat.FillWeight = 50!
        Me.Vat.HeaderText = "Vat"
        Me.Vat.MinimumWidth = 25
        Me.Vat.Name = "Vat"
        '
        'Active
        '
        Me.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Active.FillWeight = 50!
        Me.Active.HeaderText = "Active"
        Me.Active.MinimumWidth = 25
        Me.Active.Name = "Active"
        '
        'PONum
        '
        Me.PONum.HeaderText = "PO Number"
        Me.PONum.Name = "PONum"
        '
        'PoDate
        '
        Me.PoDate.HeaderText = "Last PO Date"
        Me.PoDate.Name = "PoDate"
        '
        'ReturnId
        '
        Me.ReturnId.HeaderText = "Return ID"
        Me.ReturnId.Name = "ReturnId"
        '
        'LastReturnDate
        '
        Me.LastReturnDate.HeaderText = "Last Return Date"
        Me.LastReturnDate.Name = "LastReturnDate"
        '
        'tbcSupplier
        '
        Me.tbcSupplier.HeaderText = "Supplier"
        Me.tbcSupplier.Name = "tbcSupplier"
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
        Me.Button7.UseVisualStyleBackColor = true
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
        Me.PurchaseOrder.UseVisualStyleBackColor = true
        '
        'lblPoDetails
        '
        Me.lblPoDetails.AutoSize = true
        Me.lblPoDetails.Location = New System.Drawing.Point(78, 421)
        Me.lblPoDetails.Name = "lblPoDetails"
        Me.lblPoDetails.Size = New System.Drawing.Size(142, 17)
        Me.lblPoDetails.TabIndex = 77
        Me.lblPoDetails.Text = "Purchase Order Details"
        '
        'lblPO
        '
        Me.lblPO.AutoSize = true
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
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.Button19.UseVisualStyleBackColor = true
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
        Me.Button27.UseVisualStyleBackColor = true
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
        Me.btnEmpEdit.UseCompatibleTextRendering = true
        Me.btnEmpEdit.UseVisualStyleBackColor = true
        '
        'Button30
        '
        Me.Button30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button30.Image = Global.MenuForms.My.Resources.Resources.searchico2n
        Me.Button30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button30.Location = New System.Drawing.Point(227, 147)
        Me.Button30.Name = "Button30"
        Me.Button30.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button30.Size = New System.Drawing.Size(141, 28)
        Me.Button30.TabIndex = 74
        Me.Button30.Text = "Search"
        Me.Button30.UseVisualStyleBackColor = true
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(629, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 25)
        Me.ComboBox1.TabIndex = 73
        Me.ComboBox1.Text = "Search criteria..."
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox6.Location = New System.Drawing.Point(392, 147)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(194, 25)
        Me.TextBox6.TabIndex = 72
        Me.TextBox6.Text = "Enter query ..."
        '
        'DataGridView7
        '
        Me.DataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView7.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
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
        Me.PoProductCode.FillWeight = 60!
        Me.PoProductCode.HeaderText = "Product Code"
        Me.PoProductCode.Name = "PoProductCode"
        '
        'PoProductName
        '
        Me.PoProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PoProductName.FillWeight = 200!
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
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseOrderID, Me.PurOrderDate, Me.PoPurTotal, Me.ReceivingStatus, Me.ReceivedDate, Me.RecEmployee, Me.Supp})
        Me.DataGridView2.Location = New System.Drawing.Point(81, 195)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(831, 213)
        Me.DataGridView2.TabIndex = 61
        '
        'PurchaseOrderID
        '
        Me.PurchaseOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PurchaseOrderID.FillWeight = 50!
        Me.PurchaseOrderID.HeaderText = "PO-ID"
        Me.PurchaseOrderID.Name = "PurchaseOrderID"
        '
        'PurOrderDate
        '
        Me.PurOrderDate.FillWeight = 53.53319!
        Me.PurOrderDate.HeaderText = "PO-Date"
        Me.PurOrderDate.Name = "PurOrderDate"
        '
        'PoPurTotal
        '
        Me.PoPurTotal.FillWeight = 79.38996!
        Me.PoPurTotal.HeaderText = "PO Total"
        Me.PoPurTotal.Name = "PoPurTotal"
        '
        'ReceivingStatus
        '
        Me.ReceivingStatus.FillWeight = 102.4783!
        Me.ReceivingStatus.HeaderText = "Receiving Status"
        Me.ReceivingStatus.Name = "ReceivingStatus"
        '
        'ReceivedDate
        '
        Me.ReceivedDate.HeaderText = "Received Date"
        Me.ReceivedDate.Name = "ReceivedDate"
        '
        'RecEmployee
        '
        Me.RecEmployee.FillWeight = 141.5038!
        Me.RecEmployee.HeaderText = "Receiving Employee"
        Me.RecEmployee.Name = "RecEmployee"
        '
        'Supp
        '
        Me.Supp.FillWeight = 123.0947!
        Me.Supp.HeaderText = "Supplier"
        Me.Supp.Name = "Supp"
        '
        'btnNewEmp
        '
        Me.btnNewEmp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnNewEmp.Image = Global.MenuForms.My.Resources.Resources.add_icon
        Me.btnNewEmp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewEmp.Location = New System.Drawing.Point(22, 15)
        Me.btnNewEmp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewEmp.Name = "btnNewEmp"
        Me.btnNewEmp.Size = New System.Drawing.Size(125, 104)
        Me.btnNewEmp.TabIndex = 28
        Me.btnNewEmp.Text = "Add new "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"purchase order"
        Me.btnNewEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewEmp.UseVisualStyleBackColor = true
        '
        'WarehouseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 701)
        Me.Controls.Add(Me.Tc_WarehouseManager)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WarehouseManager"
        Me.Text = "Warehouse Manager"
        Me.TopMost = true
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.Tc_WarehouseManager.ResumeLayout(false)
        Me.InventoryTab.ResumeLayout(false)
        Me.InventoryTab.PerformLayout
        Me.Panel1.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PurchaseOrder.ResumeLayout(false)
        Me.PurchaseOrder.PerformLayout
        Me.Panel6.ResumeLayout(false)
        CType(Me.DataGridView7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

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
    Friend WithEvents ProductCode As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescript As DataGridViewTextBoxColumn
    Friend WithEvents SellingPrice As DataGridViewTextBoxColumn
    Friend WithEvents OnHand As DataGridViewTextBoxColumn
    Friend WithEvents Vat As DataGridViewCheckBoxColumn
    Friend WithEvents Active As DataGridViewCheckBoxColumn
    Friend WithEvents PONum As DataGridViewTextBoxColumn
    Friend WithEvents PoDate As DataGridViewTextBoxColumn
    Friend WithEvents ReturnId As DataGridViewTextBoxColumn
    Friend WithEvents LastReturnDate As DataGridViewTextBoxColumn
    Friend WithEvents tbcSupplier As DataGridViewTextBoxColumn
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
    Friend WithEvents PurchaseOrderID As DataGridViewTextBoxColumn
    Friend WithEvents PurOrderDate As DataGridViewTextBoxColumn
    Friend WithEvents PoPurTotal As DataGridViewTextBoxColumn
    Friend WithEvents ReceivingStatus As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDate As DataGridViewTextBoxColumn
    Friend WithEvents RecEmployee As DataGridViewTextBoxColumn
    Friend WithEvents Supp As DataGridViewTextBoxColumn
End Class
