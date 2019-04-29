<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenManager))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FKPurchaseItemPurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecSpecDataset = New MenuForms.RecSpecDataset()
        Me.PaymentTab = New System.Windows.Forms.TabPage()
        Me.tlpPayment = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchPayment = New System.Windows.Forms.Button()
        Me.tbQueryPayment = New System.Windows.Forms.TextBox()
        Me.cbCriteriaPayment = New System.Windows.Forms.ComboBox()
        Me.flpPayment = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditPayment = New System.Windows.Forms.Button()
        Me.btnSavePayment = New System.Windows.Forms.Button()
        Me.btnRemovePayment = New System.Windows.Forms.Button()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.CustPaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPaymentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPaymentTotalAmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTab = New System.Windows.Forms.TabPage()
        Me.tlpCustomer = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.tbQueryCustomer = New System.Windows.Forms.TextBox()
        Me.cbCriteriaCustomer = New System.Windows.Forms.ComboBox()
        Me.flpCustomer = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditCustomer = New System.Windows.Forms.Button()
        Me.btnSaveCustomer = New System.Windows.Forms.Button()
        Me.btnRemoveCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustBussinessNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustAddress1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustAddress2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustSuburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTab = New System.Windows.Forms.TabPage()
        Me.tlpSupplier = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchSupplier = New System.Windows.Forms.Button()
        Me.tbQuerySupplier = New System.Windows.Forms.TextBox()
        Me.cbCriteriaSupplier = New System.Windows.Forms.ComboBox()
        Me.flpSupplier = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditSupplier = New System.Windows.Forms.Button()
        Me.btnSaveSupplier = New System.Windows.Forms.Button()
        Me.btnRemoveSupplier = New System.Windows.Forms.Button()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.SuppierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.POTab = New System.Windows.Forms.TabPage()
        Me.tlpPO = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchPO = New System.Windows.Forms.Button()
        Me.tbQueryPO = New System.Windows.Forms.TextBox()
        Me.cbCriteriaPO = New System.Windows.Forms.ComboBox()
        Me.flpPO = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditPO = New System.Windows.Forms.Button()
        Me.btnSavePO = New System.Windows.Forms.Button()
        Me.btnRemovePO = New System.Windows.Forms.Button()
        Me.lblPoDetails = New System.Windows.Forms.Label()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.DGV2_2 = New System.Windows.Forms.DataGridView()
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseItemQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseItemPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.PONoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POReceivedFlagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesOrderTab = New System.Windows.Forms.TabPage()
        Me.tlpSO = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchSO = New System.Windows.Forms.Button()
        Me.tbQuerySO = New System.Windows.Forms.TextBox()
        Me.cbCriteriaSO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvSO = New System.Windows.Forms.DataGridView()
        Me.SalesOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleOrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust_FName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_FName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTab = New System.Windows.Forms.TabPage()
        Me.tlpProduct = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchProduct = New System.Windows.Forms.Button()
        Me.tbQueryProduct = New System.Windows.Forms.TextBox()
        Me.cbCriteriaProduct = New System.Windows.Forms.ComboBox()
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
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagerFormTabControl = New System.Windows.Forms.TabControl()
        Me.EmployeeTab = New System.Windows.Forms.TabPage()
        Me.flpEmployee = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditEmployee = New System.Windows.Forms.Button()
        Me.btnSaveEmployee = New System.Windows.Forms.Button()
        Me.btnRemoveEmployee = New System.Windows.Forms.Button()
        Me.FinalSearchLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchEmployee = New System.Windows.Forms.Button()
        Me.tbQueryEmployee = New System.Windows.Forms.TextBox()
        Me.cbCriteriaEmployee = New System.Windows.Forms.ComboBox()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpFNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpSNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpEmailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpPasswordDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpContactNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.EmployeeTableAdapter()
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.Sales_OrderTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Sales_OrderTableAdapter()
        Me.Purchase_OrderTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter()
        Me.Purchase_ItemTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Purchase_ItemTableAdapter()
        Me.SupplierTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.SupplierTableAdapter()
        Me.CustomerTableTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.CustomerTableTableAdapter()
        Me.Customer_PaymentTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.Customer_PaymentTableAdapter()
        Me.EmpTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpSNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FKPurchaseItemPurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentTab.SuspendLayout()
        Me.tlpPayment.SuspendLayout()
        Me.flpPayment.SuspendLayout()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerTab.SuspendLayout()
        Me.tlpCustomer.SuspendLayout()
        Me.flpCustomer.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierTab.SuspendLayout()
        Me.tlpSupplier.SuspendLayout()
        Me.flpSupplier.SuspendLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POTab.SuspendLayout()
        Me.tlpPO.SuspendLayout()
        Me.flpPO.SuspendLayout()
        CType(Me.DGV2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesOrderTab.SuspendLayout()
        Me.tlpSO.SuspendLayout()
        CType(Me.dgvSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductTab.SuspendLayout()
        Me.tlpProduct.SuspendLayout()
        Me.flpProducts.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManagerFormTabControl.SuspendLayout()
        Me.EmployeeTab.SuspendLayout()
        Me.flpEmployee.SuspendLayout()
        Me.FinalSearchLayout.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FKPurchaseItemPurchaseOrderBindingSource
        '
        Me.FKPurchaseItemPurchaseOrderBindingSource.DataMember = "FK_Purchase_Item_Purchase_Order"
        Me.FKPurchaseItemPurchaseOrderBindingSource.DataSource = Me.PurchaseOrderBindingSource
        '
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "Purchase_Order"
        Me.PurchaseOrderBindingSource.DataSource = Me.RecSpecDataset
        '
        'RecSpecDataset
        '
        Me.RecSpecDataset.DataSetName = "RecSpecDataset"
        Me.RecSpecDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentTab
        '
        Me.PaymentTab.Controls.Add(Me.tlpPayment)
        Me.PaymentTab.Controls.Add(Me.flpPayment)
        Me.PaymentTab.Controls.Add(Me.dgvPayment)
        Me.PaymentTab.Location = New System.Drawing.Point(4, 26)
        Me.PaymentTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaymentTab.Name = "PaymentTab"
        Me.PaymentTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaymentTab.Size = New System.Drawing.Size(1094, 749)
        Me.PaymentTab.TabIndex = 14
        Me.PaymentTab.Text = "Customer Payment"
        Me.PaymentTab.UseVisualStyleBackColor = True
        Me.PaymentTab.UseWaitCursor = True
        '
        'tlpPayment
        '
        Me.tlpPayment.ColumnCount = 3
        Me.tlpPayment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPayment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPayment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPayment.Controls.Add(Me.btnSearchPayment, 0, 0)
        Me.tlpPayment.Controls.Add(Me.tbQueryPayment, 1, 0)
        Me.tlpPayment.Controls.Add(Me.cbCriteriaPayment, 2, 0)
        Me.tlpPayment.Location = New System.Drawing.Point(159, 249)
        Me.tlpPayment.Name = "tlpPayment"
        Me.tlpPayment.RowCount = 1
        Me.tlpPayment.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPayment.Size = New System.Drawing.Size(862, 60)
        Me.tlpPayment.TabIndex = 88
        Me.tlpPayment.UseWaitCursor = True
        '
        'btnSearchPayment
        '
        Me.btnSearchPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchPayment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPayment.Image = CType(resources.GetObject("btnSearchPayment.Image"), System.Drawing.Image)
        Me.btnSearchPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchPayment.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchPayment.Name = "btnSearchPayment"
        Me.btnSearchPayment.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSearchPayment.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchPayment.TabIndex = 70
        Me.btnSearchPayment.Text = "Search"
        Me.btnSearchPayment.UseVisualStyleBackColor = True
        Me.btnSearchPayment.UseWaitCursor = True
        '
        'tbQueryPayment
        '
        Me.tbQueryPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbQueryPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryPayment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryPayment.Location = New System.Drawing.Point(317, 17)
        Me.tbQueryPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQueryPayment.Multiline = True
        Me.tbQueryPayment.Name = "tbQueryPayment"
        Me.tbQueryPayment.Size = New System.Drawing.Size(226, 25)
        Me.tbQueryPayment.TabIndex = 68
        Me.tbQueryPayment.Text = "Enter query ..."
        Me.tbQueryPayment.UseWaitCursor = True
        '
        'cbCriteriaPayment
        '
        Me.cbCriteriaPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaPayment.FormattingEnabled = True
        Me.cbCriteriaPayment.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaPayment.Location = New System.Drawing.Point(605, 19)
        Me.cbCriteriaPayment.Name = "cbCriteriaPayment"
        Me.cbCriteriaPayment.Size = New System.Drawing.Size(226, 25)
        Me.cbCriteriaPayment.TabIndex = 71
        Me.cbCriteriaPayment.Text = "Select criteria"
        Me.cbCriteriaPayment.UseWaitCursor = True
        '
        'flpPayment
        '
        Me.flpPayment.AutoSize = True
        Me.flpPayment.Controls.Add(Me.btnAddEditPayment)
        Me.flpPayment.Controls.Add(Me.btnSavePayment)
        Me.flpPayment.Controls.Add(Me.btnRemovePayment)
        Me.flpPayment.Location = New System.Drawing.Point(227, 75)
        Me.flpPayment.Name = "flpPayment"
        Me.flpPayment.Size = New System.Drawing.Size(588, 146)
        Me.flpPayment.TabIndex = 87
        Me.flpPayment.UseWaitCursor = True
        '
        'btnAddEditPayment
        '
        Me.btnAddEditPayment.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditPayment.Image = CType(resources.GetObject("btnAddEditPayment.Image"), System.Drawing.Image)
        Me.btnAddEditPayment.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditPayment.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditPayment.Name = "btnAddEditPayment"
        Me.btnAddEditPayment.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditPayment.TabIndex = 32
        Me.btnAddEditPayment.Text = "Add/Edit"
        Me.btnAddEditPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditPayment.UseCompatibleTextRendering = True
        Me.btnAddEditPayment.UseVisualStyleBackColor = True
        Me.btnAddEditPayment.UseWaitCursor = True
        '
        'btnSavePayment
        '
        Me.btnSavePayment.Image = CType(resources.GetObject("btnSavePayment.Image"), System.Drawing.Image)
        Me.btnSavePayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSavePayment.Location = New System.Drawing.Point(221, 5)
        Me.btnSavePayment.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSavePayment.Name = "btnSavePayment"
        Me.btnSavePayment.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnSavePayment.Size = New System.Drawing.Size(146, 136)
        Me.btnSavePayment.TabIndex = 30
        Me.btnSavePayment.Text = "Save"
        Me.btnSavePayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSavePayment.UseVisualStyleBackColor = True
        Me.btnSavePayment.UseWaitCursor = True
        '
        'btnRemovePayment
        '
        Me.btnRemovePayment.AutoSize = True
        Me.btnRemovePayment.Image = CType(resources.GetObject("btnRemovePayment.Image"), System.Drawing.Image)
        Me.btnRemovePayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemovePayment.Location = New System.Drawing.Point(427, 5)
        Me.btnRemovePayment.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemovePayment.Name = "btnRemovePayment"
        Me.btnRemovePayment.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnRemovePayment.Size = New System.Drawing.Size(146, 136)
        Me.btnRemovePayment.TabIndex = 31
        Me.btnRemovePayment.Text = "Remove"
        Me.btnRemovePayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemovePayment.UseVisualStyleBackColor = True
        Me.btnRemovePayment.UseWaitCursor = True
        '
        'dgvPayment
        '
        Me.dgvPayment.AllowUserToAddRows = False
        Me.dgvPayment.AllowUserToDeleteRows = False
        Me.dgvPayment.AutoGenerateColumns = False
        Me.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustPaymentIDDataGridViewTextBoxColumn, Me.CustPaymentTypeDataGridViewTextBoxColumn, Me.CustPaymentTotalAmtDataGridViewTextBoxColumn, Me.CustPaymentDateDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn3, Me.CustomerIDDataGridViewTextBoxColumn2})
        Me.dgvPayment.DataSource = Me.CustomerPaymentBindingSource
        Me.dgvPayment.Location = New System.Drawing.Point(74, 379)
        Me.dgvPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.ReadOnly = True
        Me.dgvPayment.Size = New System.Drawing.Size(986, 333)
        Me.dgvPayment.TabIndex = 3
        Me.dgvPayment.UseWaitCursor = True
        '
        'CustPaymentIDDataGridViewTextBoxColumn
        '
        Me.CustPaymentIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_Payment_ID"
        Me.CustPaymentIDDataGridViewTextBoxColumn.HeaderText = "Cust_Payment_ID"
        Me.CustPaymentIDDataGridViewTextBoxColumn.Name = "CustPaymentIDDataGridViewTextBoxColumn"
        Me.CustPaymentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustPaymentTypeDataGridViewTextBoxColumn
        '
        Me.CustPaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "Cust_Payment_Type"
        Me.CustPaymentTypeDataGridViewTextBoxColumn.HeaderText = "Cust_Payment_Type"
        Me.CustPaymentTypeDataGridViewTextBoxColumn.Name = "CustPaymentTypeDataGridViewTextBoxColumn"
        Me.CustPaymentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustPaymentTotalAmtDataGridViewTextBoxColumn
        '
        Me.CustPaymentTotalAmtDataGridViewTextBoxColumn.DataPropertyName = "Cust_Payment_Total_Amt"
        Me.CustPaymentTotalAmtDataGridViewTextBoxColumn.HeaderText = "Cust_Payment_Total_Amt"
        Me.CustPaymentTotalAmtDataGridViewTextBoxColumn.Name = "CustPaymentTotalAmtDataGridViewTextBoxColumn"
        Me.CustPaymentTotalAmtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustPaymentDateDataGridViewTextBoxColumn
        '
        Me.CustPaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Cust_Payment_Date"
        Me.CustPaymentDateDataGridViewTextBoxColumn.HeaderText = "Cust_Payment_Date"
        Me.CustPaymentDateDataGridViewTextBoxColumn.Name = "CustPaymentDateDataGridViewTextBoxColumn"
        Me.CustPaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeIDDataGridViewTextBoxColumn3
        '
        Me.EmployeeIDDataGridViewTextBoxColumn3.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn3.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn3.Name = "EmployeeIDDataGridViewTextBoxColumn3"
        Me.EmployeeIDDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CustomerIDDataGridViewTextBoxColumn2
        '
        Me.CustomerIDDataGridViewTextBoxColumn2.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn2.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn2.Name = "CustomerIDDataGridViewTextBoxColumn2"
        Me.CustomerIDDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'CustomerPaymentBindingSource
        '
        Me.CustomerPaymentBindingSource.DataMember = "Customer_Payment"
        Me.CustomerPaymentBindingSource.DataSource = Me.RecSpecDataset
        '
        'CustomerTab
        '
        Me.CustomerTab.Controls.Add(Me.tlpCustomer)
        Me.CustomerTab.Controls.Add(Me.flpCustomer)
        Me.CustomerTab.Controls.Add(Me.dgvCustomer)
        Me.CustomerTab.Location = New System.Drawing.Point(4, 26)
        Me.CustomerTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerTab.Name = "CustomerTab"
        Me.CustomerTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerTab.Size = New System.Drawing.Size(1094, 749)
        Me.CustomerTab.TabIndex = 12
        Me.CustomerTab.Text = "Customer"
        Me.CustomerTab.UseVisualStyleBackColor = True
        Me.CustomerTab.UseWaitCursor = True
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
        Me.tlpCustomer.Location = New System.Drawing.Point(137, 235)
        Me.tlpCustomer.Name = "tlpCustomer"
        Me.tlpCustomer.RowCount = 1
        Me.tlpCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpCustomer.Size = New System.Drawing.Size(862, 60)
        Me.tlpCustomer.TabIndex = 86
        Me.tlpCustomer.UseWaitCursor = True
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
        Me.btnSearchCustomer.UseWaitCursor = True
        '
        'tbQueryCustomer
        '
        Me.tbQueryCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbQueryCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryCustomer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryCustomer.Location = New System.Drawing.Point(317, 17)
        Me.tbQueryCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQueryCustomer.Multiline = True
        Me.tbQueryCustomer.Name = "tbQueryCustomer"
        Me.tbQueryCustomer.Size = New System.Drawing.Size(226, 25)
        Me.tbQueryCustomer.TabIndex = 68
        Me.tbQueryCustomer.Text = "Enter query ..."
        Me.tbQueryCustomer.UseWaitCursor = True
        '
        'cbCriteriaCustomer
        '
        Me.cbCriteriaCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaCustomer.FormattingEnabled = True
        Me.cbCriteriaCustomer.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaCustomer.Location = New System.Drawing.Point(605, 19)
        Me.cbCriteriaCustomer.Name = "cbCriteriaCustomer"
        Me.cbCriteriaCustomer.Size = New System.Drawing.Size(226, 25)
        Me.cbCriteriaCustomer.TabIndex = 71
        Me.cbCriteriaCustomer.Text = "Select criteria"
        Me.cbCriteriaCustomer.UseWaitCursor = True
        '
        'flpCustomer
        '
        Me.flpCustomer.AutoSize = True
        Me.flpCustomer.Controls.Add(Me.btnAddEditCustomer)
        Me.flpCustomer.Controls.Add(Me.btnSaveCustomer)
        Me.flpCustomer.Controls.Add(Me.btnRemoveCustomer)
        Me.flpCustomer.Location = New System.Drawing.Point(205, 61)
        Me.flpCustomer.Name = "flpCustomer"
        Me.flpCustomer.Size = New System.Drawing.Size(588, 146)
        Me.flpCustomer.TabIndex = 85
        Me.flpCustomer.UseWaitCursor = True
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
        Me.btnAddEditCustomer.UseWaitCursor = True
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
        Me.btnSaveCustomer.UseWaitCursor = True
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
        Me.btnRemoveCustomer.UseWaitCursor = True
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
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn1, Me.CustFNameDataGridViewTextBoxColumn, Me.CustLNameDataGridViewTextBoxColumn, Me.CustTypeDataGridViewTextBoxColumn, Me.CustBussinessNameDataGridViewTextBoxColumn, Me.CustEmailDataGridViewTextBoxColumn, Me.CustAddress1DataGridViewTextBoxColumn, Me.CustAddress2DataGridViewTextBoxColumn, Me.CustSuburbDataGridViewTextBoxColumn, Me.CustCityDataGridViewTextBoxColumn, Me.CustPostalCodeDataGridViewTextBoxColumn, Me.CustContactNoDataGridViewTextBoxColumn, Me.CustBalanceDataGridViewTextBoxColumn})
        Me.dgvCustomer.DataSource = Me.CustomerTableBindingSource
        Me.dgvCustomer.Location = New System.Drawing.Point(43, 370)
        Me.dgvCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.Size = New System.Drawing.Size(975, 363)
        Me.dgvCustomer.TabIndex = 10
        Me.dgvCustomer.UseWaitCursor = True
        '
        'CustomerIDDataGridViewTextBoxColumn1
        '
        Me.CustomerIDDataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.Name = "CustomerIDDataGridViewTextBoxColumn1"
        Me.CustomerIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn1.Width = 106
        '
        'CustFNameDataGridViewTextBoxColumn
        '
        Me.CustFNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.HeaderText = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.Name = "CustFNameDataGridViewTextBoxColumn"
        Me.CustFNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustFNameDataGridViewTextBoxColumn.Width = 104
        '
        'CustLNameDataGridViewTextBoxColumn
        '
        Me.CustLNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_LName"
        Me.CustLNameDataGridViewTextBoxColumn.HeaderText = "Cust_LName"
        Me.CustLNameDataGridViewTextBoxColumn.Name = "CustLNameDataGridViewTextBoxColumn"
        Me.CustLNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustLNameDataGridViewTextBoxColumn.Width = 104
        '
        'CustTypeDataGridViewTextBoxColumn
        '
        Me.CustTypeDataGridViewTextBoxColumn.DataPropertyName = "Cust_Type"
        Me.CustTypeDataGridViewTextBoxColumn.HeaderText = "Cust_Type"
        Me.CustTypeDataGridViewTextBoxColumn.Name = "CustTypeDataGridViewTextBoxColumn"
        Me.CustTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustTypeDataGridViewTextBoxColumn.Width = 90
        '
        'CustBussinessNameDataGridViewTextBoxColumn
        '
        Me.CustBussinessNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_Bussiness_Name"
        Me.CustBussinessNameDataGridViewTextBoxColumn.HeaderText = "Cust_Bussiness_Name"
        Me.CustBussinessNameDataGridViewTextBoxColumn.Name = "CustBussinessNameDataGridViewTextBoxColumn"
        Me.CustBussinessNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustBussinessNameDataGridViewTextBoxColumn.Width = 158
        '
        'CustEmailDataGridViewTextBoxColumn
        '
        Me.CustEmailDataGridViewTextBoxColumn.DataPropertyName = "Cust_Email"
        Me.CustEmailDataGridViewTextBoxColumn.HeaderText = "Cust_Email"
        Me.CustEmailDataGridViewTextBoxColumn.Name = "CustEmailDataGridViewTextBoxColumn"
        Me.CustEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustEmailDataGridViewTextBoxColumn.Width = 94
        '
        'CustAddress1DataGridViewTextBoxColumn
        '
        Me.CustAddress1DataGridViewTextBoxColumn.DataPropertyName = "Cust_Address1"
        Me.CustAddress1DataGridViewTextBoxColumn.HeaderText = "Cust_Address1"
        Me.CustAddress1DataGridViewTextBoxColumn.Name = "CustAddress1DataGridViewTextBoxColumn"
        Me.CustAddress1DataGridViewTextBoxColumn.ReadOnly = True
        Me.CustAddress1DataGridViewTextBoxColumn.Width = 118
        '
        'CustAddress2DataGridViewTextBoxColumn
        '
        Me.CustAddress2DataGridViewTextBoxColumn.DataPropertyName = "Cust_Address2"
        Me.CustAddress2DataGridViewTextBoxColumn.HeaderText = "Cust_Address2"
        Me.CustAddress2DataGridViewTextBoxColumn.Name = "CustAddress2DataGridViewTextBoxColumn"
        Me.CustAddress2DataGridViewTextBoxColumn.ReadOnly = True
        Me.CustAddress2DataGridViewTextBoxColumn.Width = 118
        '
        'CustSuburbDataGridViewTextBoxColumn
        '
        Me.CustSuburbDataGridViewTextBoxColumn.DataPropertyName = "Cust_Suburb"
        Me.CustSuburbDataGridViewTextBoxColumn.HeaderText = "Cust_Suburb"
        Me.CustSuburbDataGridViewTextBoxColumn.Name = "CustSuburbDataGridViewTextBoxColumn"
        Me.CustSuburbDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustSuburbDataGridViewTextBoxColumn.Width = 105
        '
        'CustCityDataGridViewTextBoxColumn
        '
        Me.CustCityDataGridViewTextBoxColumn.DataPropertyName = "Cust_City"
        Me.CustCityDataGridViewTextBoxColumn.HeaderText = "Cust_City"
        Me.CustCityDataGridViewTextBoxColumn.Name = "CustCityDataGridViewTextBoxColumn"
        Me.CustCityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustCityDataGridViewTextBoxColumn.Width = 84
        '
        'CustPostalCodeDataGridViewTextBoxColumn
        '
        Me.CustPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "Cust_Postal_Code"
        Me.CustPostalCodeDataGridViewTextBoxColumn.HeaderText = "Cust_Postal_Code"
        Me.CustPostalCodeDataGridViewTextBoxColumn.Name = "CustPostalCodeDataGridViewTextBoxColumn"
        Me.CustPostalCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustPostalCodeDataGridViewTextBoxColumn.Width = 134
        '
        'CustContactNoDataGridViewTextBoxColumn
        '
        Me.CustContactNoDataGridViewTextBoxColumn.DataPropertyName = "Cust_Contact_No"
        Me.CustContactNoDataGridViewTextBoxColumn.HeaderText = "Cust_Contact_No"
        Me.CustContactNoDataGridViewTextBoxColumn.Name = "CustContactNoDataGridViewTextBoxColumn"
        Me.CustContactNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustContactNoDataGridViewTextBoxColumn.Width = 130
        '
        'CustBalanceDataGridViewTextBoxColumn
        '
        Me.CustBalanceDataGridViewTextBoxColumn.DataPropertyName = "Cust_Balance"
        Me.CustBalanceDataGridViewTextBoxColumn.HeaderText = "Cust_Balance"
        Me.CustBalanceDataGridViewTextBoxColumn.Name = "CustBalanceDataGridViewTextBoxColumn"
        Me.CustBalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustBalanceDataGridViewTextBoxColumn.Width = 107
        '
        'CustomerTableBindingSource
        '
        Me.CustomerTableBindingSource.DataMember = "CustomerTable"
        Me.CustomerTableBindingSource.DataSource = Me.RecSpecDataset
        '
        'SupplierTab
        '
        Me.SupplierTab.Controls.Add(Me.tlpSupplier)
        Me.SupplierTab.Controls.Add(Me.flpSupplier)
        Me.SupplierTab.Controls.Add(Me.dgvSupplier)
        Me.SupplierTab.Location = New System.Drawing.Point(4, 26)
        Me.SupplierTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SupplierTab.Name = "SupplierTab"
        Me.SupplierTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SupplierTab.Size = New System.Drawing.Size(1094, 749)
        Me.SupplierTab.TabIndex = 13
        Me.SupplierTab.Text = "Supplier"
        Me.SupplierTab.UseVisualStyleBackColor = True
        Me.SupplierTab.UseWaitCursor = True
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
        Me.tlpSupplier.Location = New System.Drawing.Point(129, 225)
        Me.tlpSupplier.Name = "tlpSupplier"
        Me.tlpSupplier.RowCount = 1
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSupplier.Size = New System.Drawing.Size(862, 60)
        Me.tlpSupplier.TabIndex = 84
        Me.tlpSupplier.UseWaitCursor = True
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
        Me.btnSearchSupplier.UseWaitCursor = True
        '
        'tbQuerySupplier
        '
        Me.tbQuerySupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQuerySupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbQuerySupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQuerySupplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuerySupplier.Location = New System.Drawing.Point(317, 17)
        Me.tbQuerySupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQuerySupplier.Multiline = True
        Me.tbQuerySupplier.Name = "tbQuerySupplier"
        Me.tbQuerySupplier.Size = New System.Drawing.Size(226, 25)
        Me.tbQuerySupplier.TabIndex = 68
        Me.tbQuerySupplier.Text = "Enter query ..."
        Me.tbQuerySupplier.UseWaitCursor = True
        '
        'cbCriteriaSupplier
        '
        Me.cbCriteriaSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaSupplier.FormattingEnabled = True
        Me.cbCriteriaSupplier.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaSupplier.Location = New System.Drawing.Point(605, 19)
        Me.cbCriteriaSupplier.Name = "cbCriteriaSupplier"
        Me.cbCriteriaSupplier.Size = New System.Drawing.Size(226, 25)
        Me.cbCriteriaSupplier.TabIndex = 71
        Me.cbCriteriaSupplier.Text = "Select criteria"
        Me.cbCriteriaSupplier.UseWaitCursor = True
        '
        'flpSupplier
        '
        Me.flpSupplier.AutoSize = True
        Me.flpSupplier.Controls.Add(Me.btnAddEditSupplier)
        Me.flpSupplier.Controls.Add(Me.btnSaveSupplier)
        Me.flpSupplier.Controls.Add(Me.btnRemoveSupplier)
        Me.flpSupplier.Location = New System.Drawing.Point(197, 51)
        Me.flpSupplier.Name = "flpSupplier"
        Me.flpSupplier.Size = New System.Drawing.Size(588, 146)
        Me.flpSupplier.TabIndex = 83
        Me.flpSupplier.UseWaitCursor = True
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
        Me.btnAddEditSupplier.UseWaitCursor = True
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
        Me.btnSaveSupplier.UseWaitCursor = True
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
        Me.btnRemoveSupplier.UseWaitCursor = True
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.AutoGenerateColumns = False
        Me.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppierIDDataGridViewTextBoxColumn, Me.SuppNameDataGridViewTextBoxColumn, Me.SuppContactNoDataGridViewTextBoxColumn, Me.SuppEmailDataGridViewTextBoxColumn, Me.SuppContactPersonDataGridViewTextBoxColumn, Me.SuppAddress1DataGridViewTextBoxColumn, Me.SuppAddress2DataGridViewTextBoxColumn, Me.SuppSurburbDataGridViewTextBoxColumn, Me.SuppCityDataGridViewTextBoxColumn, Me.SuppPostalCodeDataGridViewTextBoxColumn})
        Me.dgvSupplier.DataSource = Me.SupplierBindingSource
        Me.dgvSupplier.Location = New System.Drawing.Point(39, 318)
        Me.dgvSupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.Size = New System.Drawing.Size(1000, 413)
        Me.dgvSupplier.TabIndex = 61
        Me.dgvSupplier.UseWaitCursor = True
        '
        'SuppierIDDataGridViewTextBoxColumn
        '
        Me.SuppierIDDataGridViewTextBoxColumn.DataPropertyName = "Suppier_ID"
        Me.SuppierIDDataGridViewTextBoxColumn.HeaderText = "Suppier_ID"
        Me.SuppierIDDataGridViewTextBoxColumn.Name = "SuppierIDDataGridViewTextBoxColumn"
        Me.SuppierIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'POTab
        '
        Me.POTab.Controls.Add(Me.tlpPO)
        Me.POTab.Controls.Add(Me.flpPO)
        Me.POTab.Controls.Add(Me.lblPoDetails)
        Me.POTab.Controls.Add(Me.lblPO)
        Me.POTab.Controls.Add(Me.DGV2_2)
        Me.POTab.Controls.Add(Me.dgvPO)
        Me.POTab.Location = New System.Drawing.Point(4, 26)
        Me.POTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POTab.Name = "POTab"
        Me.POTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POTab.Size = New System.Drawing.Size(1094, 749)
        Me.POTab.TabIndex = 7
        Me.POTab.Text = "Purchase Order"
        Me.POTab.UseVisualStyleBackColor = True
        Me.POTab.UseWaitCursor = True
        '
        'tlpPO
        '
        Me.tlpPO.ColumnCount = 3
        Me.tlpPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpPO.Controls.Add(Me.btnSearchPO, 0, 0)
        Me.tlpPO.Controls.Add(Me.tbQueryPO, 1, 0)
        Me.tlpPO.Controls.Add(Me.cbCriteriaPO, 2, 0)
        Me.tlpPO.Location = New System.Drawing.Point(131, 181)
        Me.tlpPO.Name = "tlpPO"
        Me.tlpPO.RowCount = 1
        Me.tlpPO.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPO.Size = New System.Drawing.Size(862, 60)
        Me.tlpPO.TabIndex = 82
        Me.tlpPO.UseWaitCursor = True
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
        Me.btnSearchPO.UseWaitCursor = True
        '
        'tbQueryPO
        '
        Me.tbQueryPO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbQueryPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryPO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryPO.Location = New System.Drawing.Point(317, 17)
        Me.tbQueryPO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQueryPO.Multiline = True
        Me.tbQueryPO.Name = "tbQueryPO"
        Me.tbQueryPO.Size = New System.Drawing.Size(226, 25)
        Me.tbQueryPO.TabIndex = 68
        Me.tbQueryPO.Text = "Enter query ..."
        Me.tbQueryPO.UseWaitCursor = True
        '
        'cbCriteriaPO
        '
        Me.cbCriteriaPO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaPO.FormattingEnabled = True
        Me.cbCriteriaPO.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaPO.Location = New System.Drawing.Point(605, 19)
        Me.cbCriteriaPO.Name = "cbCriteriaPO"
        Me.cbCriteriaPO.Size = New System.Drawing.Size(226, 25)
        Me.cbCriteriaPO.TabIndex = 71
        Me.cbCriteriaPO.Text = "Select criteria"
        Me.cbCriteriaPO.UseWaitCursor = True
        '
        'flpPO
        '
        Me.flpPO.AutoSize = True
        Me.flpPO.Controls.Add(Me.btnAddEditPO)
        Me.flpPO.Controls.Add(Me.btnSavePO)
        Me.flpPO.Controls.Add(Me.btnRemovePO)
        Me.flpPO.Location = New System.Drawing.Point(199, 7)
        Me.flpPO.Name = "flpPO"
        Me.flpPO.Size = New System.Drawing.Size(588, 146)
        Me.flpPO.TabIndex = 81
        Me.flpPO.UseWaitCursor = True
        '
        'btnAddEditPO
        '
        Me.btnAddEditPO.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditPO.Image = CType(resources.GetObject("btnAddEditPO.Image"), System.Drawing.Image)
        Me.btnAddEditPO.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditPO.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditPO.Name = "btnAddEditPO"
        Me.btnAddEditPO.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditPO.TabIndex = 32
        Me.btnAddEditPO.Text = "Add/Edit"
        Me.btnAddEditPO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditPO.UseCompatibleTextRendering = True
        Me.btnAddEditPO.UseVisualStyleBackColor = True
        Me.btnAddEditPO.UseWaitCursor = True
        '
        'btnSavePO
        '
        Me.btnSavePO.Image = CType(resources.GetObject("btnSavePO.Image"), System.Drawing.Image)
        Me.btnSavePO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSavePO.Location = New System.Drawing.Point(221, 5)
        Me.btnSavePO.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSavePO.Name = "btnSavePO"
        Me.btnSavePO.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnSavePO.Size = New System.Drawing.Size(146, 136)
        Me.btnSavePO.TabIndex = 30
        Me.btnSavePO.Text = "Save"
        Me.btnSavePO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSavePO.UseVisualStyleBackColor = True
        Me.btnSavePO.UseWaitCursor = True
        '
        'btnRemovePO
        '
        Me.btnRemovePO.AutoSize = True
        Me.btnRemovePO.Image = CType(resources.GetObject("btnRemovePO.Image"), System.Drawing.Image)
        Me.btnRemovePO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemovePO.Location = New System.Drawing.Point(427, 5)
        Me.btnRemovePO.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemovePO.Name = "btnRemovePO"
        Me.btnRemovePO.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnRemovePO.Size = New System.Drawing.Size(146, 136)
        Me.btnRemovePO.TabIndex = 31
        Me.btnRemovePO.Text = "Remove"
        Me.btnRemovePO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemovePO.UseVisualStyleBackColor = True
        Me.btnRemovePO.UseWaitCursor = True
        '
        'lblPoDetails
        '
        Me.lblPoDetails.AutoSize = True
        Me.lblPoDetails.Location = New System.Drawing.Point(91, 510)
        Me.lblPoDetails.Name = "lblPoDetails"
        Me.lblPoDetails.Size = New System.Drawing.Size(142, 17)
        Me.lblPoDetails.TabIndex = 77
        Me.lblPoDetails.Text = "Purchase Order Details"
        Me.lblPoDetails.UseWaitCursor = True
        '
        'lblPO
        '
        Me.lblPO.AutoSize = True
        Me.lblPO.Location = New System.Drawing.Point(91, 255)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(105, 17)
        Me.lblPO.TabIndex = 76
        Me.lblPO.Text = "Purchase Orders"
        Me.lblPO.UseWaitCursor = True
        '
        'DGV2_2
        '
        Me.DGV2_2.AllowUserToAddRows = False
        Me.DGV2_2.AllowUserToDeleteRows = False
        Me.DGV2_2.AutoGenerateColumns = False
        Me.DGV2_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV2_2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV2_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseItemLineNoDataGridViewTextBoxColumn, Me.PONoDataGridViewTextBoxColumn1, Me.PurchaseItemQtyDataGridViewTextBoxColumn, Me.PurchaseItemPriceDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn2})
        Me.DGV2_2.DataSource = Me.FKPurchaseItemPurchaseOrderBindingSource
        Me.DGV2_2.Location = New System.Drawing.Point(94, 531)
        Me.DGV2_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV2_2.Name = "DGV2_2"
        Me.DGV2_2.ReadOnly = True
        Me.DGV2_2.Size = New System.Drawing.Size(969, 193)
        Me.DGV2_2.TabIndex = 62
        Me.DGV2_2.UseWaitCursor = True
        '
        'PurchaseItemLineNoDataGridViewTextBoxColumn
        '
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Item_Line_No"
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.HeaderText = "Purchase_Item_Line_No"
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.Name = "PurchaseItemLineNoDataGridViewTextBoxColumn"
        Me.PurchaseItemLineNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PONoDataGridViewTextBoxColumn1
        '
        Me.PONoDataGridViewTextBoxColumn1.DataPropertyName = "PO_No"
        Me.PONoDataGridViewTextBoxColumn1.HeaderText = "PO_No"
        Me.PONoDataGridViewTextBoxColumn1.Name = "PONoDataGridViewTextBoxColumn1"
        Me.PONoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PurchaseItemQtyDataGridViewTextBoxColumn
        '
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Item_Qty"
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.HeaderText = "Purchase_Item_Qty"
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.Name = "PurchaseItemQtyDataGridViewTextBoxColumn"
        Me.PurchaseItemQtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurchaseItemPriceDataGridViewTextBoxColumn
        '
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Item_Price"
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.HeaderText = "Purchase_Item_Price"
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.Name = "PurchaseItemPriceDataGridViewTextBoxColumn"
        Me.PurchaseItemPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductCodeDataGridViewTextBoxColumn2
        '
        Me.ProductCodeDataGridViewTextBoxColumn2.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn2.HeaderText = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn2.Name = "ProductCodeDataGridViewTextBoxColumn2"
        Me.ProductCodeDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'dgvPO
        '
        Me.dgvPO.AllowUserToAddRows = False
        Me.dgvPO.AllowUserToDeleteRows = False
        Me.dgvPO.AutoGenerateColumns = False
        Me.dgvPO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONoDataGridViewTextBoxColumn, Me.PODateDataGridViewTextBoxColumn, Me.POTotalDataGridViewTextBoxColumn, Me.POReceivedFlagDataGridViewCheckBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn2, Me.SupplierIDDataGridViewTextBoxColumn})
        Me.dgvPO.DataSource = Me.PurchaseOrderBindingSource
        Me.dgvPO.Location = New System.Drawing.Point(94, 276)
        Me.dgvPO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.ReadOnly = True
        Me.dgvPO.Size = New System.Drawing.Size(969, 225)
        Me.dgvPO.TabIndex = 61
        Me.dgvPO.UseWaitCursor = True
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
        'EmployeeIDDataGridViewTextBoxColumn2
        '
        Me.EmployeeIDDataGridViewTextBoxColumn2.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn2.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn2.Name = "EmployeeIDDataGridViewTextBoxColumn2"
        Me.EmployeeIDDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesOrderTab
        '
        Me.SalesOrderTab.Controls.Add(Me.tlpSO)
        Me.SalesOrderTab.Controls.Add(Me.Label2)
        Me.SalesOrderTab.Controls.Add(Me.dgvSO)
        Me.SalesOrderTab.Location = New System.Drawing.Point(4, 26)
        Me.SalesOrderTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalesOrderTab.Name = "SalesOrderTab"
        Me.SalesOrderTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalesOrderTab.Size = New System.Drawing.Size(1094, 749)
        Me.SalesOrderTab.TabIndex = 16
        Me.SalesOrderTab.Text = "Sales Order"
        Me.SalesOrderTab.UseVisualStyleBackColor = True
        Me.SalesOrderTab.UseWaitCursor = True
        '
        'tlpSO
        '
        Me.tlpSO.ColumnCount = 3
        Me.tlpSO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSO.Controls.Add(Me.btnSearchSO, 0, 0)
        Me.tlpSO.Controls.Add(Me.tbQuerySO, 1, 0)
        Me.tlpSO.Controls.Add(Me.cbCriteriaSO, 2, 0)
        Me.tlpSO.Location = New System.Drawing.Point(129, 73)
        Me.tlpSO.Name = "tlpSO"
        Me.tlpSO.RowCount = 1
        Me.tlpSO.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSO.Size = New System.Drawing.Size(862, 60)
        Me.tlpSO.TabIndex = 85
        Me.tlpSO.UseWaitCursor = True
        '
        'btnSearchSO
        '
        Me.btnSearchSO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchSO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSO.Image = CType(resources.GetObject("btnSearchSO.Image"), System.Drawing.Image)
        Me.btnSearchSO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchSO.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchSO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchSO.Name = "btnSearchSO"
        Me.btnSearchSO.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSearchSO.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchSO.TabIndex = 70
        Me.btnSearchSO.Text = "Search"
        Me.btnSearchSO.UseVisualStyleBackColor = True
        Me.btnSearchSO.UseWaitCursor = True
        '
        'tbQuerySO
        '
        Me.tbQuerySO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQuerySO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbQuerySO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQuerySO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuerySO.Location = New System.Drawing.Point(317, 17)
        Me.tbQuerySO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQuerySO.Multiline = True
        Me.tbQuerySO.Name = "tbQuerySO"
        Me.tbQuerySO.Size = New System.Drawing.Size(226, 25)
        Me.tbQuerySO.TabIndex = 68
        Me.tbQuerySO.Text = "Enter query ..."
        Me.tbQuerySO.UseWaitCursor = True
        '
        'cbCriteriaSO
        '
        Me.cbCriteriaSO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaSO.FormattingEnabled = True
        Me.cbCriteriaSO.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaSO.Location = New System.Drawing.Point(605, 19)
        Me.cbCriteriaSO.Name = "cbCriteriaSO"
        Me.cbCriteriaSO.Size = New System.Drawing.Size(226, 25)
        Me.cbCriteriaSO.TabIndex = 71
        Me.cbCriteriaSO.Text = "Select criteria"
        Me.cbCriteriaSO.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Sales Orders"
        Me.Label2.UseWaitCursor = True
        '
        'dgvSO
        '
        Me.dgvSO.AllowUserToAddRows = False
        Me.dgvSO.AllowUserToDeleteRows = False
        Me.dgvSO.AutoGenerateColumns = False
        Me.dgvSO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSO.ColumnHeadersVisible = False
        Me.dgvSO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalesOrderIDDataGridViewTextBoxColumn, Me.SaleOrderDateDataGridViewTextBoxColumn, Me.SaleTotalDataGridViewTextBoxColumn, Me.Cust_FName, Me.Emp_FName})
        Me.dgvSO.DataSource = Me.SalesOrderBindingSource
        Me.dgvSO.Location = New System.Drawing.Point(141, 194)
        Me.dgvSO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSO.Name = "dgvSO"
        Me.dgvSO.ReadOnly = True
        Me.dgvSO.Size = New System.Drawing.Size(805, 386)
        Me.dgvSO.TabIndex = 61
        Me.dgvSO.UseWaitCursor = True
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
        'Cust_FName
        '
        Me.Cust_FName.DataPropertyName = "Cust_FName"
        Me.Cust_FName.HeaderText = "Cust_FName"
        Me.Cust_FName.Name = "Cust_FName"
        Me.Cust_FName.ReadOnly = True
        '
        'Emp_FName
        '
        Me.Emp_FName.DataPropertyName = "Emp_FName"
        Me.Emp_FName.HeaderText = "Emp_FName"
        Me.Emp_FName.Name = "Emp_FName"
        Me.Emp_FName.ReadOnly = True
        '
        'SalesOrderBindingSource
        '
        Me.SalesOrderBindingSource.DataMember = "Sales_Order"
        Me.SalesOrderBindingSource.DataSource = Me.RecSpecDataset
        '
        'ProductTab
        '
        Me.ProductTab.Controls.Add(Me.tlpProduct)
        Me.ProductTab.Controls.Add(Me.flpProducts)
        Me.ProductTab.Controls.Add(Me.dgvProduct)
        Me.ProductTab.Location = New System.Drawing.Point(4, 26)
        Me.ProductTab.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ProductTab.Name = "ProductTab"
        Me.ProductTab.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ProductTab.Size = New System.Drawing.Size(1094, 749)
        Me.ProductTab.TabIndex = 15
        Me.ProductTab.Text = "Products"
        Me.ProductTab.UseVisualStyleBackColor = True
        Me.ProductTab.UseWaitCursor = True
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
        Me.tlpProduct.Location = New System.Drawing.Point(131, 206)
        Me.tlpProduct.Name = "tlpProduct"
        Me.tlpProduct.RowCount = 1
        Me.tlpProduct.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpProduct.Size = New System.Drawing.Size(862, 60)
        Me.tlpProduct.TabIndex = 80
        Me.tlpProduct.UseWaitCursor = True
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
        Me.btnSearchProduct.UseWaitCursor = True
        '
        'tbQueryProduct
        '
        Me.tbQueryProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbQueryProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryProduct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryProduct.Location = New System.Drawing.Point(317, 17)
        Me.tbQueryProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQueryProduct.Multiline = True
        Me.tbQueryProduct.Name = "tbQueryProduct"
        Me.tbQueryProduct.Size = New System.Drawing.Size(226, 25)
        Me.tbQueryProduct.TabIndex = 68
        Me.tbQueryProduct.Text = "Enter query ..."
        Me.tbQueryProduct.UseWaitCursor = True
        '
        'cbCriteriaProduct
        '
        Me.cbCriteriaProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaProduct.FormattingEnabled = True
        Me.cbCriteriaProduct.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaProduct.Location = New System.Drawing.Point(605, 19)
        Me.cbCriteriaProduct.Name = "cbCriteriaProduct"
        Me.cbCriteriaProduct.Size = New System.Drawing.Size(226, 25)
        Me.cbCriteriaProduct.TabIndex = 71
        Me.cbCriteriaProduct.Text = "Select criteria"
        Me.cbCriteriaProduct.UseWaitCursor = True
        '
        'flpProducts
        '
        Me.flpProducts.AutoSize = True
        Me.flpProducts.Controls.Add(Me.btnAddEditProduct)
        Me.flpProducts.Controls.Add(Me.btnSaveProduct)
        Me.flpProducts.Controls.Add(Me.btnRemoveProduct)
        Me.flpProducts.Location = New System.Drawing.Point(199, 32)
        Me.flpProducts.Name = "flpProducts"
        Me.flpProducts.Size = New System.Drawing.Size(588, 146)
        Me.flpProducts.TabIndex = 79
        Me.flpProducts.UseWaitCursor = True
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
        Me.btnAddEditProduct.UseWaitCursor = True
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
        Me.btnSaveProduct.UseWaitCursor = True
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
        Me.btnRemoveProduct.UseWaitCursor = True
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.AutoGenerateColumns = False
        Me.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.ColumnHeadersVisible = False
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCodeDataGridViewTextBoxColumn, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdCostPriceDataGridViewTextBoxColumn, Me.ProdStockLevelDataGridViewTextBoxColumn, Me.ProdVATDataGridViewCheckBoxColumn, Me.ProdActiveDataGridViewCheckBoxColumn, Me.ProdCategoriesDataGridViewTextBoxColumn, Me.ProdReorderThresholdDataGridViewTextBoxColumn})
        Me.dgvProduct.DataSource = Me.ProductBindingSource
        Me.dgvProduct.Location = New System.Drawing.Point(56, 299)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(1000, 440)
        Me.dgvProduct.TabIndex = 78
        Me.dgvProduct.UseWaitCursor = True
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
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.RecSpecDataset
        '
        'ManagerFormTabControl
        '
        Me.ManagerFormTabControl.Controls.Add(Me.EmployeeTab)
        Me.ManagerFormTabControl.Controls.Add(Me.ProductTab)
        Me.ManagerFormTabControl.Controls.Add(Me.SalesOrderTab)
        Me.ManagerFormTabControl.Controls.Add(Me.POTab)
        Me.ManagerFormTabControl.Controls.Add(Me.SupplierTab)
        Me.ManagerFormTabControl.Controls.Add(Me.CustomerTab)
        Me.ManagerFormTabControl.Controls.Add(Me.PaymentTab)
        Me.ManagerFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerFormTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ManagerFormTabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ManagerFormTabControl.Name = "ManagerFormTabControl"
        Me.ManagerFormTabControl.SelectedIndex = 0
        Me.ManagerFormTabControl.ShowToolTips = True
        Me.ManagerFormTabControl.Size = New System.Drawing.Size(1102, 779)
        Me.ManagerFormTabControl.TabIndex = 1
        Me.ManagerFormTabControl.UseWaitCursor = True
        '
        'EmployeeTab
        '
        Me.EmployeeTab.Controls.Add(Me.flpEmployee)
        Me.EmployeeTab.Controls.Add(Me.FinalSearchLayout)
        Me.EmployeeTab.Controls.Add(Me.dgvEmployee)
        Me.EmployeeTab.Location = New System.Drawing.Point(4, 26)
        Me.EmployeeTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeeTab.Name = "EmployeeTab"
        Me.EmployeeTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeeTab.Size = New System.Drawing.Size(1094, 749)
        Me.EmployeeTab.TabIndex = 3
        Me.EmployeeTab.Text = "Employee"
        Me.EmployeeTab.UseVisualStyleBackColor = True
        Me.EmployeeTab.UseWaitCursor = True
        '
        'flpEmployee
        '
        Me.flpEmployee.AutoSize = True
        Me.flpEmployee.Controls.Add(Me.btnAddEditEmployee)
        Me.flpEmployee.Controls.Add(Me.btnSaveEmployee)
        Me.flpEmployee.Controls.Add(Me.btnRemoveEmployee)
        Me.flpEmployee.Location = New System.Drawing.Point(221, 54)
        Me.flpEmployee.Name = "flpEmployee"
        Me.flpEmployee.Size = New System.Drawing.Size(588, 146)
        Me.flpEmployee.TabIndex = 72
        Me.flpEmployee.UseWaitCursor = True
        '
        'btnAddEditEmployee
        '
        Me.btnAddEditEmployee.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditEmployee.Image = CType(resources.GetObject("btnAddEditEmployee.Image"), System.Drawing.Image)
        Me.btnAddEditEmployee.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditEmployee.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditEmployee.Name = "btnAddEditEmployee"
        Me.btnAddEditEmployee.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditEmployee.TabIndex = 32
        Me.btnAddEditEmployee.Text = "Add/Edit"
        Me.btnAddEditEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditEmployee.UseCompatibleTextRendering = True
        Me.btnAddEditEmployee.UseVisualStyleBackColor = True
        Me.btnAddEditEmployee.UseWaitCursor = True
        '
        'btnSaveEmployee
        '
        Me.btnSaveEmployee.Image = CType(resources.GetObject("btnSaveEmployee.Image"), System.Drawing.Image)
        Me.btnSaveEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveEmployee.Location = New System.Drawing.Point(221, 5)
        Me.btnSaveEmployee.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSaveEmployee.Name = "btnSaveEmployee"
        Me.btnSaveEmployee.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnSaveEmployee.Size = New System.Drawing.Size(146, 136)
        Me.btnSaveEmployee.TabIndex = 30
        Me.btnSaveEmployee.Text = "Save"
        Me.btnSaveEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveEmployee.UseVisualStyleBackColor = True
        Me.btnSaveEmployee.UseWaitCursor = True
        '
        'btnRemoveEmployee
        '
        Me.btnRemoveEmployee.AutoSize = True
        Me.btnRemoveEmployee.Image = CType(resources.GetObject("btnRemoveEmployee.Image"), System.Drawing.Image)
        Me.btnRemoveEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveEmployee.Location = New System.Drawing.Point(427, 5)
        Me.btnRemoveEmployee.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemoveEmployee.Name = "btnRemoveEmployee"
        Me.btnRemoveEmployee.Padding = New System.Windows.Forms.Padding(0, 13, 0, 0)
        Me.btnRemoveEmployee.Size = New System.Drawing.Size(146, 136)
        Me.btnRemoveEmployee.TabIndex = 31
        Me.btnRemoveEmployee.Text = "Remove"
        Me.btnRemoveEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveEmployee.UseVisualStyleBackColor = True
        Me.btnRemoveEmployee.UseWaitCursor = True
        '
        'FinalSearchLayout
        '
        Me.FinalSearchLayout.ColumnCount = 3
        Me.FinalSearchLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.FinalSearchLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.FinalSearchLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.FinalSearchLayout.Controls.Add(Me.btnSearchEmployee, 0, 0)
        Me.FinalSearchLayout.Controls.Add(Me.tbQueryEmployee, 1, 0)
        Me.FinalSearchLayout.Controls.Add(Me.cbCriteriaEmployee, 2, 0)
        Me.FinalSearchLayout.Location = New System.Drawing.Point(153, 228)
        Me.FinalSearchLayout.Name = "FinalSearchLayout"
        Me.FinalSearchLayout.RowCount = 1
        Me.FinalSearchLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FinalSearchLayout.Size = New System.Drawing.Size(862, 60)
        Me.FinalSearchLayout.TabIndex = 73
        Me.FinalSearchLayout.UseWaitCursor = True
        '
        'btnSearchEmployee
        '
        Me.btnSearchEmployee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchEmployee.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchEmployee.Image = CType(resources.GetObject("btnSearchEmployee.Image"), System.Drawing.Image)
        Me.btnSearchEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchEmployee.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchEmployee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchEmployee.Name = "btnSearchEmployee"
        Me.btnSearchEmployee.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSearchEmployee.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchEmployee.TabIndex = 70
        Me.btnSearchEmployee.Text = "Search"
        Me.btnSearchEmployee.UseVisualStyleBackColor = True
        Me.btnSearchEmployee.UseWaitCursor = True
        '
        'tbQueryEmployee
        '
        Me.tbQueryEmployee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.tbQueryEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryEmployee.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQueryEmployee.Location = New System.Drawing.Point(317, 17)
        Me.tbQueryEmployee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbQueryEmployee.Multiline = True
        Me.tbQueryEmployee.Name = "tbQueryEmployee"
        Me.tbQueryEmployee.Size = New System.Drawing.Size(226, 25)
        Me.tbQueryEmployee.TabIndex = 68
        Me.tbQueryEmployee.Text = "Enter Query..."
        Me.tbQueryEmployee.UseWaitCursor = True
        '
        'cbCriteriaEmployee
        '
        Me.cbCriteriaEmployee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaEmployee.FormattingEnabled = True
        Me.cbCriteriaEmployee.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaEmployee.Location = New System.Drawing.Point(605, 17)
        Me.cbCriteriaEmployee.Name = "cbCriteriaEmployee"
        Me.cbCriteriaEmployee.Size = New System.Drawing.Size(226, 25)
        Me.cbCriteriaEmployee.TabIndex = 71
        Me.cbCriteriaEmployee.Text = "Choose search criteria..."
        Me.cbCriteriaEmployee.UseWaitCursor = True
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.AllowUserToResizeRows = False
        Me.dgvEmployee.AutoGenerateColumns = False
        Me.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn1, Me.EmpFNameDataGridViewTextBoxColumn1, Me.EmpSNameDataGridViewTextBoxColumn1, Me.EmpEmailDataGridViewTextBoxColumn1, Me.EmpPasswordDataGridViewTextBoxColumn1, Me.EmpContactNoDataGridViewTextBoxColumn1, Me.EmpTypeDataGridViewTextBoxColumn1})
        Me.dgvEmployee.DataSource = Me.EmployeeBindingSource
        Me.dgvEmployee.Location = New System.Drawing.Point(70, 380)
        Me.dgvEmployee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        Me.dgvEmployee.Size = New System.Drawing.Size(981, 327)
        Me.dgvEmployee.TabIndex = 51
        Me.dgvEmployee.UseWaitCursor = True
        '
        'EmployeeIDDataGridViewTextBoxColumn1
        '
        Me.EmployeeIDDataGridViewTextBoxColumn1.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn1.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn1.Name = "EmployeeIDDataGridViewTextBoxColumn1"
        Me.EmployeeIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EmpFNameDataGridViewTextBoxColumn1
        '
        Me.EmpFNameDataGridViewTextBoxColumn1.DataPropertyName = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn1.HeaderText = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn1.Name = "EmpFNameDataGridViewTextBoxColumn1"
        Me.EmpFNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EmpSNameDataGridViewTextBoxColumn1
        '
        Me.EmpSNameDataGridViewTextBoxColumn1.DataPropertyName = "Emp_SName"
        Me.EmpSNameDataGridViewTextBoxColumn1.HeaderText = "Emp_SName"
        Me.EmpSNameDataGridViewTextBoxColumn1.Name = "EmpSNameDataGridViewTextBoxColumn1"
        Me.EmpSNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EmpEmailDataGridViewTextBoxColumn1
        '
        Me.EmpEmailDataGridViewTextBoxColumn1.DataPropertyName = "Emp_Email"
        Me.EmpEmailDataGridViewTextBoxColumn1.HeaderText = "Emp_Email"
        Me.EmpEmailDataGridViewTextBoxColumn1.Name = "EmpEmailDataGridViewTextBoxColumn1"
        Me.EmpEmailDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EmpPasswordDataGridViewTextBoxColumn1
        '
        Me.EmpPasswordDataGridViewTextBoxColumn1.DataPropertyName = "Emp_Password"
        Me.EmpPasswordDataGridViewTextBoxColumn1.HeaderText = "Emp_Password"
        Me.EmpPasswordDataGridViewTextBoxColumn1.Name = "EmpPasswordDataGridViewTextBoxColumn1"
        Me.EmpPasswordDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EmpContactNoDataGridViewTextBoxColumn1
        '
        Me.EmpContactNoDataGridViewTextBoxColumn1.DataPropertyName = "Emp_Contact_No"
        Me.EmpContactNoDataGridViewTextBoxColumn1.HeaderText = "Emp_Contact_No"
        Me.EmpContactNoDataGridViewTextBoxColumn1.Name = "EmpContactNoDataGridViewTextBoxColumn1"
        Me.EmpContactNoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EmpTypeDataGridViewTextBoxColumn1
        '
        Me.EmpTypeDataGridViewTextBoxColumn1.DataPropertyName = "Emp_Type"
        Me.EmpTypeDataGridViewTextBoxColumn1.HeaderText = "Emp_Type"
        Me.EmpTypeDataGridViewTextBoxColumn1.Name = "EmpTypeDataGridViewTextBoxColumn1"
        Me.EmpTypeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PurchaseItemBindingSource
        '
        Me.PurchaseItemBindingSource.DataMember = "Purchase_Item"
        Me.PurchaseItemBindingSource.DataSource = Me.RecSpecDataset
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'Sales_OrderTableAdapter
        '
        Me.Sales_OrderTableAdapter.ClearBeforeFill = True
        '
        'Purchase_OrderTableAdapter
        '
        Me.Purchase_OrderTableAdapter.ClearBeforeFill = True
        '
        'Purchase_ItemTableAdapter
        '
        Me.Purchase_ItemTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableTableAdapter
        '
        Me.CustomerTableTableAdapter.ClearBeforeFill = True
        '
        'Customer_PaymentTableAdapter
        '
        Me.Customer_PaymentTableAdapter.ClearBeforeFill = True
        '
        'EmpTypeDataGridViewTextBoxColumn
        '
        Me.EmpTypeDataGridViewTextBoxColumn.DataPropertyName = "Emp_Type"
        Me.EmpTypeDataGridViewTextBoxColumn.HeaderText = "Emp_Type"
        Me.EmpTypeDataGridViewTextBoxColumn.Name = "EmpTypeDataGridViewTextBoxColumn"
        Me.EmpTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpContactNoDataGridViewTextBoxColumn
        '
        Me.EmpContactNoDataGridViewTextBoxColumn.DataPropertyName = "Emp_Contact_No"
        Me.EmpContactNoDataGridViewTextBoxColumn.HeaderText = "Emp_Contact_No"
        Me.EmpContactNoDataGridViewTextBoxColumn.Name = "EmpContactNoDataGridViewTextBoxColumn"
        Me.EmpContactNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpPasswordDataGridViewTextBoxColumn
        '
        Me.EmpPasswordDataGridViewTextBoxColumn.DataPropertyName = "Emp_Password"
        Me.EmpPasswordDataGridViewTextBoxColumn.HeaderText = "Emp_Password"
        Me.EmpPasswordDataGridViewTextBoxColumn.Name = "EmpPasswordDataGridViewTextBoxColumn"
        Me.EmpPasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpEmailDataGridViewTextBoxColumn
        '
        Me.EmpEmailDataGridViewTextBoxColumn.DataPropertyName = "Emp_Email"
        Me.EmpEmailDataGridViewTextBoxColumn.HeaderText = "Emp_Email"
        Me.EmpEmailDataGridViewTextBoxColumn.Name = "EmpEmailDataGridViewTextBoxColumn"
        Me.EmpEmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpSNameDataGridViewTextBoxColumn
        '
        Me.EmpSNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_SName"
        Me.EmpSNameDataGridViewTextBoxColumn.HeaderText = "Emp_SName"
        Me.EmpSNameDataGridViewTextBoxColumn.Name = "EmpSNameDataGridViewTextBoxColumn"
        Me.EmpSNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpFNameDataGridViewTextBoxColumn
        '
        Me.EmpFNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn.HeaderText = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn.Name = "EmpFNameDataGridViewTextBoxColumn"
        Me.EmpFNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1102, 779)
        Me.Controls.Add(Me.ManagerFormTabControl)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager"
        Me.UseWaitCursor = True
        CType(Me.FKPurchaseItemPurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecSpecDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentTab.ResumeLayout(False)
        Me.PaymentTab.PerformLayout()
        Me.tlpPayment.ResumeLayout(False)
        Me.tlpPayment.PerformLayout()
        Me.flpPayment.ResumeLayout(False)
        Me.flpPayment.PerformLayout()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerTab.ResumeLayout(False)
        Me.CustomerTab.PerformLayout()
        Me.tlpCustomer.ResumeLayout(False)
        Me.tlpCustomer.PerformLayout()
        Me.flpCustomer.ResumeLayout(False)
        Me.flpCustomer.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierTab.ResumeLayout(False)
        Me.SupplierTab.PerformLayout()
        Me.tlpSupplier.ResumeLayout(False)
        Me.tlpSupplier.PerformLayout()
        Me.flpSupplier.ResumeLayout(False)
        Me.flpSupplier.PerformLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POTab.ResumeLayout(False)
        Me.POTab.PerformLayout()
        Me.tlpPO.ResumeLayout(False)
        Me.tlpPO.PerformLayout()
        Me.flpPO.ResumeLayout(False)
        Me.flpPO.PerformLayout()
        CType(Me.DGV2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesOrderTab.ResumeLayout(False)
        Me.SalesOrderTab.PerformLayout()
        Me.tlpSO.ResumeLayout(False)
        Me.tlpSO.PerformLayout()
        CType(Me.dgvSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductTab.ResumeLayout(False)
        Me.ProductTab.PerformLayout()
        Me.tlpProduct.ResumeLayout(False)
        Me.tlpProduct.PerformLayout()
        Me.flpProducts.ResumeLayout(False)
        Me.flpProducts.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManagerFormTabControl.ResumeLayout(False)
        Me.EmployeeTab.ResumeLayout(False)
        Me.EmployeeTab.PerformLayout()
        Me.flpEmployee.ResumeLayout(False)
        Me.flpEmployee.PerformLayout()
        Me.FinalSearchLayout.ResumeLayout(False)
        Me.FinalSearchLayout.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecSpecDataset As RecSpecDataset
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As RecSpecDatasetTableAdapters.EmployeeTableAdapter
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As RecSpecDatasetTableAdapters.ProductTableAdapter
    Friend WithEvents SalesOrderBindingSource As BindingSource
    Friend WithEvents Sales_OrderTableAdapter As RecSpecDatasetTableAdapters.Sales_OrderTableAdapter
    Friend WithEvents PurchaseOrderBindingSource As BindingSource
    Friend WithEvents Purchase_OrderTableAdapter As RecSpecDatasetTableAdapters.Purchase_OrderTableAdapter
    Friend WithEvents PurchaseItemBindingSource As BindingSource
    Friend WithEvents Purchase_ItemTableAdapter As RecSpecDatasetTableAdapters.Purchase_ItemTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As RecSpecDatasetTableAdapters.SupplierTableAdapter
    Friend WithEvents CustomerTableBindingSource As BindingSource
    Friend WithEvents CustomerTableTableAdapter As RecSpecDatasetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents CustomerPaymentBindingSource As BindingSource
    Friend WithEvents Customer_PaymentTableAdapter As RecSpecDatasetTableAdapters.Customer_PaymentTableAdapter
    Friend WithEvents FKPurchaseItemPurchaseOrderBindingSource As BindingSource
    Friend WithEvents PaymentTab As TabPage
    Friend WithEvents dgvPayment As DataGridView
    Friend WithEvents CustPaymentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPaymentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPaymentTotalAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerTab As TabPage
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustBussinessNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustAddress1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustAddress2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustSuburbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustCityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierTab As TabPage
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents SuppierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppContactPersonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppAddress1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppAddress2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppSurburbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppCityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppPostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POTab As TabPage
    Friend WithEvents lblPoDetails As Label
    Friend WithEvents lblPO As Label
    Friend WithEvents DGV2_2 As DataGridView
    Friend WithEvents PurchaseItemLineNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PONoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseItemQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseItemPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dgvPO As DataGridView
    Friend WithEvents PONoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PODateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POReceivedFlagDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesOrderTab As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvSO As DataGridView
    Friend WithEvents SalesOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleOrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cust_FName As DataGridViewTextBoxColumn
    Friend WithEvents Emp_FName As DataGridViewTextBoxColumn
    Friend WithEvents ProductTab As TabPage
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdCostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdStockLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdVATDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProdActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProdCategoriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdReorderThresholdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerFormTabControl As TabControl
    Friend WithEvents tlpSO As TableLayoutPanel
    Friend WithEvents btnSearchSO As Button
    Friend WithEvents tbQuerySO As TextBox
    Friend WithEvents cbCriteriaSO As ComboBox
    Friend WithEvents tlpProduct As TableLayoutPanel
    Friend WithEvents btnSearchProduct As Button
    Friend WithEvents tbQueryProduct As TextBox
    Friend WithEvents cbCriteriaProduct As ComboBox
    Friend WithEvents flpProducts As FlowLayoutPanel
    Friend WithEvents btnAddEditProduct As Button
    Friend WithEvents btnSaveProduct As Button
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents tlpPO As TableLayoutPanel
    Friend WithEvents btnSearchPO As Button
    Friend WithEvents tbQueryPO As TextBox
    Friend WithEvents cbCriteriaPO As ComboBox
    Friend WithEvents flpPO As FlowLayoutPanel
    Friend WithEvents btnAddEditPO As Button
    Friend WithEvents btnSavePO As Button
    Friend WithEvents btnRemovePO As Button
    Friend WithEvents tlpSupplier As TableLayoutPanel
    Friend WithEvents btnSearchSupplier As Button
    Friend WithEvents tbQuerySupplier As TextBox
    Friend WithEvents cbCriteriaSupplier As ComboBox
    Friend WithEvents flpSupplier As FlowLayoutPanel
    Friend WithEvents btnAddEditSupplier As Button
    Friend WithEvents btnSaveSupplier As Button
    Friend WithEvents btnRemoveSupplier As Button
    Friend WithEvents tlpCustomer As TableLayoutPanel
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents tbQueryCustomer As TextBox
    Friend WithEvents cbCriteriaCustomer As ComboBox
    Friend WithEvents flpCustomer As FlowLayoutPanel
    Friend WithEvents btnAddEditCustomer As Button
    Friend WithEvents btnSaveCustomer As Button
    Friend WithEvents btnRemoveCustomer As Button
    Friend WithEvents tlpPayment As TableLayoutPanel
    Friend WithEvents btnSearchPayment As Button
    Friend WithEvents tbQueryPayment As TextBox
    Friend WithEvents cbCriteriaPayment As ComboBox
    Friend WithEvents flpPayment As FlowLayoutPanel
    Friend WithEvents btnAddEditPayment As Button
    Friend WithEvents btnSavePayment As Button
    Friend WithEvents btnRemovePayment As Button
    Friend WithEvents EmployeeTab As TabPage
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpFNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpSNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpEmailDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpPasswordDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpContactNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpTypeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpSNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveEmployee As Button
    Friend WithEvents btnSaveEmployee As Button
    Friend WithEvents btnAddEditEmployee As Button
    Friend WithEvents cbCriteriaEmployee As ComboBox
    Friend WithEvents tbQueryEmployee As TextBox
    Friend WithEvents btnSearchEmployee As Button
    Friend WithEvents FinalSearchLayout As TableLayoutPanel
    Friend WithEvents flpEmployee As FlowLayoutPanel
End Class
