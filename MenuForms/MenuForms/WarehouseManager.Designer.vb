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
        Me.RecSpecDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecSpecDataset = New MenuForms.RecSpecDataset()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdateReturned = New System.Windows.Forms.Button()
        Me.btnViewRet = New System.Windows.Forms.Button()
        Me.btnAddRet = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txbOrderID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSearchOrderID = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage3.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.Tc_WarehouseManager.SuspendLayout
        Me.InventoryTab.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox13)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Button8)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.btnUpdateReturned)
        Me.TabPage3.Controls.Add(Me.btnViewRet)
        Me.TabPage3.Controls.Add(Me.btnAddRet)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1265, 618)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Returns"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(614, 17)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(140, 25)
        Me.TextBox13.TabIndex = 22
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(162, 336)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(157, 25)
        Me.TextBox9.TabIndex = 19
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(162, 289)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(157, 25)
        Me.TextBox8.TabIndex = 18
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(162, 246)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(157, 25)
        Me.TextBox7.TabIndex = 17
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(162, 200)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(157, 25)
        Me.TextBox6.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(162, 156)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(157, 25)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(162, 60)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(157, 25)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(162, 17)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 25)
        Me.TextBox2.TabIndex = 12
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(448, 14)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 30)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "Search Returns Order"
        Me.Button8.UseVisualStyleBackColor = true
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 106)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePicker1.TabIndex = 20
        '
        'btnUpdateReturned
        '
        Me.btnUpdateReturned.Location = New System.Drawing.Point(448, 336)
        Me.btnUpdateReturned.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdateReturned.Name = "btnUpdateReturned"
        Me.btnUpdateReturned.Size = New System.Drawing.Size(159, 30)
        Me.btnUpdateReturned.TabIndex = 11
        Me.btnUpdateReturned.Text = "Update Returned Goods"
        Me.btnUpdateReturned.UseVisualStyleBackColor = true
        '
        'btnViewRet
        '
        Me.btnViewRet.Location = New System.Drawing.Point(448, 280)
        Me.btnViewRet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewRet.Name = "btnViewRet"
        Me.btnViewRet.Size = New System.Drawing.Size(159, 30)
        Me.btnViewRet.TabIndex = 10
        Me.btnViewRet.Text = "View Returned Goods"
        Me.btnViewRet.UseVisualStyleBackColor = true
        '
        'btnAddRet
        '
        Me.btnAddRet.Location = New System.Drawing.Point(448, 220)
        Me.btnAddRet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddRet.Name = "btnAddRet"
        Me.btnAddRet.Size = New System.Drawing.Size(159, 30)
        Me.btnAddRet.TabIndex = 9
        Me.btnAddRet.Text = "Add Returned Goods"
        Me.btnAddRet.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(19, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Product ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(19, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sale Order ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(19, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Amount of Returns"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(19, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(19, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Product Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(19, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Returned Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Return Product QTY"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Return ID"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.txbOrderID)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.btnSearchOrderID)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1327, 618)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Orders"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(253, 370)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 25)
        Me.TextBox1.TabIndex = 15
        '
        'txbOrderID
        '
        Me.txbOrderID.Location = New System.Drawing.Point(337, 92)
        Me.txbOrderID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbOrderID.Name = "txbOrderID"
        Me.txbOrderID.Size = New System.Drawing.Size(159, 25)
        Me.txbOrderID.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(232, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Order ID :"
        '
        'btnSearchOrderID
        '
        Me.btnSearchOrderID.Location = New System.Drawing.Point(30, 367)
        Me.btnSearchOrderID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchOrderID.Name = "btnSearchOrderID"
        Me.btnSearchOrderID.Size = New System.Drawing.Size(152, 30)
        Me.btnSearchOrderID.TabIndex = 12
        Me.btnSearchOrderID.Text = "Search by Order ID"
        Me.btnSearchOrderID.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(30, 89)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 30)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Remove Order"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(30, 37)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 30)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "View Orders"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Tc_WarehouseManager
        '
        Me.Tc_WarehouseManager.AccessibleName = ""
        Me.Tc_WarehouseManager.Controls.Add(Me.TabPage1)
        Me.Tc_WarehouseManager.Controls.Add(Me.InventoryTab)
        Me.Tc_WarehouseManager.Controls.Add(Me.TabPage3)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
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
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.Tc_WarehouseManager.ResumeLayout(false)
        Me.InventoryTab.ResumeLayout(false)
        Me.InventoryTab.PerformLayout
        Me.Panel1.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents RecSpecDataset As RecSpecDataset
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As RecSpecDatasetTableAdapters.ProductTableAdapter
    Friend WithEvents RecSpecDatasetBindingSource As BindingSource
    Friend WithEvents ProName As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnUpdateReturned As Button
    Friend WithEvents btnViewRet As Button
    Friend WithEvents btnAddRet As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txbOrderID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnSearchOrderID As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
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
End Class
