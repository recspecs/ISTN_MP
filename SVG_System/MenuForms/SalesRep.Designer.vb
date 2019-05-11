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
        Me.SalesRepTabControl = New System.Windows.Forms.TabControl()
        Me.ProductTab = New System.Windows.Forms.TabPage()
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
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.SalesRepTabControl.SuspendLayout
        Me.ProductTab.SuspendLayout
        Me.flpProducts.SuspendLayout
        CType(Me.dgvProduct,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tlpProduct.SuspendLayout
        Me.SuspendLayout
        '
        'SalesRepTabControl
        '
        Me.SalesRepTabControl.Controls.Add(Me.ProductTab)
        Me.SalesRepTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalesRepTabControl.Location = New System.Drawing.Point(0, 0)
        Me.SalesRepTabControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalesRepTabControl.Name = "SalesRepTabControl"
        Me.SalesRepTabControl.SelectedIndex = 0
        Me.SalesRepTabControl.Size = New System.Drawing.Size(1314, 797)
        Me.SalesRepTabControl.TabIndex = 0
        '
        'ProductTab
        '
        Me.ProductTab.Controls.Add(Me.flpProducts)
        Me.ProductTab.Controls.Add(Me.dgvProduct)
        Me.ProductTab.Controls.Add(Me.tlpProduct)
        Me.ProductTab.Location = New System.Drawing.Point(4, 26)
        Me.ProductTab.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.ProductTab.Name = "ProductTab"
        Me.ProductTab.Padding = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.ProductTab.Size = New System.Drawing.Size(1306, 767)
        Me.ProductTab.TabIndex = 16
        Me.ProductTab.Text = "Products"
        Me.ProductTab.UseVisualStyleBackColor = true
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
        Me.btnAddEditProduct.Image = CType(resources.GetObject("btnAddEditProduct.Image"),System.Drawing.Image)
        Me.btnAddEditProduct.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditProduct.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditProduct.Name = "btnAddEditProduct"
        Me.btnAddEditProduct.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditProduct.TabIndex = 32
        Me.btnAddEditProduct.Text = "Add/Edit"
        Me.btnAddEditProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditProduct.UseCompatibleTextRendering = true
        Me.btnAddEditProduct.UseVisualStyleBackColor = true
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.Image = CType(resources.GetObject("btnSaveProduct.Image"),System.Drawing.Image)
        Me.btnSaveProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveProduct.Location = New System.Drawing.Point(221, 5)
        Me.btnSaveProduct.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnSaveProduct.Size = New System.Drawing.Size(146, 136)
        Me.btnSaveProduct.TabIndex = 30
        Me.btnSaveProduct.Text = "Save"
        Me.btnSaveProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveProduct.UseVisualStyleBackColor = true
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.AutoSize = true
        Me.btnRemoveProduct.Image = CType(resources.GetObject("btnRemoveProduct.Image"),System.Drawing.Image)
        Me.btnRemoveProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveProduct.Location = New System.Drawing.Point(427, 5)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnRemoveProduct.Size = New System.Drawing.Size(146, 136)
        Me.btnRemoveProduct.TabIndex = 31
        Me.btnRemoveProduct.Text = "Remove"
        Me.btnRemoveProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveProduct.UseVisualStyleBackColor = true
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = false
        Me.dgvProduct.AllowUserToDeleteRows = false
        Me.dgvProduct.AllowUserToResizeRows = false
        Me.dgvProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvProduct.AutoGenerateColumns = false
        Me.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCodeDataGridViewTextBoxColumn, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdCostPriceDataGridViewTextBoxColumn, Me.ProdStockLevelDataGridViewTextBoxColumn, Me.ProdVATDataGridViewCheckBoxColumn, Me.ProdActiveDataGridViewCheckBoxColumn, Me.ProdCategoriesDataGridViewTextBoxColumn, Me.ProdReorderThresholdDataGridViewTextBoxColumn})
        Me.dgvProduct.DataSource = Me.ProductBindingSource
        Me.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvProduct.Location = New System.Drawing.Point(75, 289)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = true
        Me.dgvProduct.Size = New System.Drawing.Size(1000, 410)
        Me.dgvProduct.TabIndex = 78
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "Product_Code"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = true
        '
        'ProdNameDataGridViewTextBoxColumn
        '
        Me.ProdNameDataGridViewTextBoxColumn.DataPropertyName = "Prod_Name"
        Me.ProdNameDataGridViewTextBoxColumn.HeaderText = "Prod_Name"
        Me.ProdNameDataGridViewTextBoxColumn.Name = "ProdNameDataGridViewTextBoxColumn"
        Me.ProdNameDataGridViewTextBoxColumn.ReadOnly = true
        '
        'ProdCostPriceDataGridViewTextBoxColumn
        '
        Me.ProdCostPriceDataGridViewTextBoxColumn.DataPropertyName = "Prod_Cost_Price"
        Me.ProdCostPriceDataGridViewTextBoxColumn.HeaderText = "Prod_Cost_Price"
        Me.ProdCostPriceDataGridViewTextBoxColumn.Name = "ProdCostPriceDataGridViewTextBoxColumn"
        Me.ProdCostPriceDataGridViewTextBoxColumn.ReadOnly = true
        '
        'ProdStockLevelDataGridViewTextBoxColumn
        '
        Me.ProdStockLevelDataGridViewTextBoxColumn.DataPropertyName = "Prod_Stock_Level"
        Me.ProdStockLevelDataGridViewTextBoxColumn.HeaderText = "Prod_Stock_Level"
        Me.ProdStockLevelDataGridViewTextBoxColumn.Name = "ProdStockLevelDataGridViewTextBoxColumn"
        Me.ProdStockLevelDataGridViewTextBoxColumn.ReadOnly = true
        '
        'ProdVATDataGridViewCheckBoxColumn
        '
        Me.ProdVATDataGridViewCheckBoxColumn.DataPropertyName = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn.HeaderText = "Prod_VAT"
        Me.ProdVATDataGridViewCheckBoxColumn.Name = "ProdVATDataGridViewCheckBoxColumn"
        Me.ProdVATDataGridViewCheckBoxColumn.ReadOnly = true
        '
        'ProdActiveDataGridViewCheckBoxColumn
        '
        Me.ProdActiveDataGridViewCheckBoxColumn.DataPropertyName = "Prod_Active"
        Me.ProdActiveDataGridViewCheckBoxColumn.HeaderText = "Prod_Active"
        Me.ProdActiveDataGridViewCheckBoxColumn.Name = "ProdActiveDataGridViewCheckBoxColumn"
        Me.ProdActiveDataGridViewCheckBoxColumn.ReadOnly = true
        '
        'ProdCategoriesDataGridViewTextBoxColumn
        '
        Me.ProdCategoriesDataGridViewTextBoxColumn.DataPropertyName = "Prod_Categories"
        Me.ProdCategoriesDataGridViewTextBoxColumn.HeaderText = "Prod_Categories"
        Me.ProdCategoriesDataGridViewTextBoxColumn.Name = "ProdCategoriesDataGridViewTextBoxColumn"
        Me.ProdCategoriesDataGridViewTextBoxColumn.ReadOnly = true
        '
        'ProdReorderThresholdDataGridViewTextBoxColumn
        '
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Reorder_Threshold"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.HeaderText = "Prod_Reorder_Threshold"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.Name = "ProdReorderThresholdDataGridViewTextBoxColumn"
        Me.ProdReorderThresholdDataGridViewTextBoxColumn.ReadOnly = true
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
        Me.btnSearchProduct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSearchProduct.Image = CType(resources.GetObject("btnSearchProduct.Image"),System.Drawing.Image)
        Me.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchProduct.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchProduct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnSearchProduct.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchProduct.TabIndex = 70
        Me.btnSearchProduct.Text = "Search"
        Me.btnSearchProduct.UseVisualStyleBackColor = true
        '
        'tbQueryProduct
        '
        Me.tbQueryProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryProduct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbQueryProduct.Location = New System.Drawing.Point(299, 17)
        Me.tbQueryProduct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbQueryProduct.Multiline = true
        Me.tbQueryProduct.Name = "tbQueryProduct"
        Me.tbQueryProduct.Size = New System.Drawing.Size(263, 25)
        Me.tbQueryProduct.TabIndex = 68
        Me.tbQueryProduct.Text = "Enter query ..."
        '
        'cbCriteriaProduct
        '
        Me.cbCriteriaProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaProduct.FormattingEnabled = true
        Me.cbCriteriaProduct.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaProduct.Location = New System.Drawing.Point(586, 19)
        Me.cbCriteriaProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbCriteriaProduct.Name = "cbCriteriaProduct"
        Me.cbCriteriaProduct.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaProduct.TabIndex = 71
        Me.cbCriteriaProduct.Text = "Select criteria"
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = true
        '
        'SalesRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 797)
        Me.ControlBox = false
        Me.Controls.Add(Me.SalesRepTabControl)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(1330, 836)
        Me.MinimumSize = New System.Drawing.Size(1330, 836)
        Me.Name = "SalesRep"
        Me.Text = "SalesRep"
        Me.SalesRepTabControl.ResumeLayout(false)
        Me.ProductTab.ResumeLayout(false)
        Me.flpProducts.ResumeLayout(false)
        Me.flpProducts.PerformLayout
        CType(Me.dgvProduct,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpProduct.ResumeLayout(false)
        Me.tlpProduct.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SalesRepTabControl As TabControl
    Friend WithEvents ProductTab As TabPage
    Friend WithEvents flpProducts As FlowLayoutPanel
    Friend WithEvents btnAddEditProduct As Button
    Friend WithEvents btnSaveProduct As Button
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents tlpProduct As TableLayoutPanel
    Friend WithEvents btnSearchProduct As Button
    Friend WithEvents tbQueryProduct As TextBox
    Friend WithEvents cbCriteriaProduct As ComboBox
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
End Class
