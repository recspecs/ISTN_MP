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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PurchaseOrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purchase_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Tc_WarehouseManager.SuspendLayout
        Me.InventoryTab.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PurchaseOrder.SuspendLayout
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
        Me.Tc_WarehouseManager.Controls.Add(Me.PurchaseOrder)
        Me.Tc_WarehouseManager.Controls.Add(Me.InventoryTab)
        Me.Tc_WarehouseManager.Location = New System.Drawing.Point(15, 17)
        Me.Tc_WarehouseManager.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tc_WarehouseManager.Name = "Tc_WarehouseManager"
        Me.Tc_WarehouseManager.SelectedIndex = 0
        Me.Tc_WarehouseManager.Size = New System.Drawing.Size(1248, 648)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
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
        Me.PurchaseOrder.Controls.Add(Me.Button22)
        Me.PurchaseOrder.Controls.Add(Me.ComboBox5)
        Me.PurchaseOrder.Controls.Add(Me.TextBox1)
        Me.PurchaseOrder.Controls.Add(Me.DataGridView2)
        Me.PurchaseOrder.Controls.Add(Me.ComboBox2)
        Me.PurchaseOrder.Controls.Add(Me.ComboBox1)
        Me.PurchaseOrder.Controls.Add(Me.DateTimePicker2)
        Me.PurchaseOrder.Controls.Add(Me.TextBox58)
        Me.PurchaseOrder.Controls.Add(Me.Label53)
        Me.PurchaseOrder.Controls.Add(Me.Label54)
        Me.PurchaseOrder.Controls.Add(Me.Label57)
        Me.PurchaseOrder.Controls.Add(Me.Label58)
        Me.PurchaseOrder.Location = New System.Drawing.Point(4, 26)
        Me.PurchaseOrder.Name = "PurchaseOrder"
        Me.PurchaseOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.PurchaseOrder.Size = New System.Drawing.Size(1240, 618)
        Me.PurchaseOrder.TabIndex = 8
        Me.PurchaseOrder.Text = "Purchase Order"
        Me.PurchaseOrder.UseVisualStyleBackColor = true
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseOrderID, Me.Product_Code, Me.ProductName, Me.Cost_Price, Me.Purchase_Quantity, Me.Subtotal, Me.Total_Cost})
        Me.DataGridView2.Location = New System.Drawing.Point(82, 274)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(831, 345)
        Me.DataGridView2.TabIndex = 60
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = true
        Me.ComboBox2.Location = New System.Drawing.Point(374, 185)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 25)
        Me.ComboBox2.TabIndex = 59
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(374, 158)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 25)
        Me.ComboBox1.TabIndex = 58
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(374, 132)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker2.TabIndex = 57
        '
        'TextBox58
        '
        Me.TextBox58.Location = New System.Drawing.Point(374, 106)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(200, 25)
        Me.TextBox58.TabIndex = 49
        '
        'Label53
        '
        Me.Label53.AutoSize = true
        Me.Label53.Location = New System.Drawing.Point(234, 158)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(72, 17)
        Me.Label53.TabIndex = 48
        Me.Label53.Text = "Supplier ID"
        '
        'Label54
        '
        Me.Label54.AutoSize = true
        Me.Label54.Location = New System.Drawing.Point(234, 184)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(81, 17)
        Me.Label54.TabIndex = 47
        Me.Label54.Text = "Employee ID"
        '
        'Label57
        '
        Me.Label57.AutoSize = true
        Me.Label57.Location = New System.Drawing.Point(234, 132)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(130, 17)
        Me.Label57.TabIndex = 44
        Me.Label57.Text = "Purchase Order Date"
        '
        'Label58
        '
        Me.Label58.AutoSize = true
        Me.Label58.Location = New System.Drawing.Point(234, 109)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(121, 17)
        Me.Label58.TabIndex = 43
        Me.Label58.Text = "Purchase Order No"
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button22.Image = Global.MenuForms.My.Resources.Resources.search_ico2n
        Me.Button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button22.Location = New System.Drawing.Point(214, 219)
        Me.Button22.Name = "Button22"
        Me.Button22.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button22.Size = New System.Drawing.Size(141, 28)
        Me.Button22.TabIndex = 73
        Me.Button22.Text = "Search"
        Me.Button22.UseVisualStyleBackColor = true
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ComboBox5.FormattingEnabled = true
        Me.ComboBox5.Location = New System.Drawing.Point(616, 219)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(159, 25)
        Me.ComboBox5.TabIndex = 72
        Me.ComboBox5.Text = "Search criteria..."
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(379, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(194, 25)
        Me.TextBox1.TabIndex = 71
        Me.TextBox1.Text = "Enter query ..."
        '
        'PurchaseOrderID
        '
        Me.PurchaseOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PurchaseOrderID.FillWeight = 50!
        Me.PurchaseOrderID.HeaderText = "PO-ID"
        Me.PurchaseOrderID.Name = "PurchaseOrderID"
        '
        'Product_Code
        '
        Me.Product_Code.FillWeight = 53.53319!
        Me.Product_Code.HeaderText = "Product Code"
        Me.Product_Code.Name = "Product_Code"
        '
        'ProductName
        '
        Me.ProductName.FillWeight = 200!
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        '
        'Cost_Price
        '
        Me.Cost_Price.FillWeight = 79.38996!
        Me.Cost_Price.HeaderText = "Cost Price"
        Me.Cost_Price.Name = "Cost_Price"
        '
        'Purchase_Quantity
        '
        Me.Purchase_Quantity.FillWeight = 102.4783!
        Me.Purchase_Quantity.HeaderText = "Purchase Quantity"
        Me.Purchase_Quantity.Name = "Purchase_Quantity"
        '
        'Subtotal
        '
        Me.Subtotal.FillWeight = 123.0947!
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'Total_Cost
        '
        Me.Total_Cost.FillWeight = 141.5038!
        Me.Total_Cost.HeaderText = "Total Cost"
        Me.Total_Cost.Name = "Total_Cost"
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
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox58 As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Button22 As Button
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PurchaseOrderID As DataGridViewTextBoxColumn
    Friend WithEvents Product_Code As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Cost_Price As DataGridViewTextBoxColumn
    Friend WithEvents Purchase_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Total_Cost As DataGridViewTextBoxColumn
End Class
