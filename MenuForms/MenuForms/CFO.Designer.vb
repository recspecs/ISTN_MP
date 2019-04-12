<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFO
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OrderDateBox = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerPaymentIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.SalesOrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Product_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sales_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Customer_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_Payment_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sales_Order_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Customer_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.Employee_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.Payment_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Cust_Payment_DateBox = New System.Windows.Forms.DateTimePicker()
        Me.Cust_Payment_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_Order_IDTextbox = New System.Windows.Forms.TextBox()
        Me.Cust_Payment_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1183, 837)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.OrderDateBox)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.CustomerPaymentIDTextBox)
        Me.TabPage2.Controls.Add(Me.CustomerIDTextBox)
        Me.TabPage2.Controls.Add(Me.SalesOrderIDTextBox)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1175, 811)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Capture Sales Order"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(404, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 126)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Capture Sales Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(198, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'OrderDateBox
        '
        Me.OrderDateBox.Location = New System.Drawing.Point(198, 46)
        Me.OrderDateBox.Name = "OrderDateBox"
        Me.OrderDateBox.Size = New System.Drawing.Size(200, 20)
        Me.OrderDateBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employee ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Customer Payment ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sales Order ID"
        '
        'CustomerPaymentIDTextBox
        '
        Me.CustomerPaymentIDTextBox.Location = New System.Drawing.Point(198, 98)
        Me.CustomerPaymentIDTextBox.Name = "CustomerPaymentIDTextBox"
        Me.CustomerPaymentIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerPaymentIDTextBox.TabIndex = 4
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(198, 72)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox.TabIndex = 3
        '
        'SalesOrderIDTextBox
        '
        Me.SalesOrderIDTextBox.Location = New System.Drawing.Point(198, 20)
        Me.SalesOrderIDTextBox.Name = "SalesOrderIDTextBox"
        Me.SalesOrderIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesOrderIDTextBox.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Code, Me.Product_Name, Me.Product_Price, Me.Product_Qty, Me.Subtotal, Me.Sales_Total})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(647, 491)
        Me.DataGridView1.TabIndex = 0
        '
        'Product_Code
        '
        Me.Product_Code.HeaderText = "Product Code"
        Me.Product_Code.Name = "Product_Code"
        '
        'Product_Name
        '
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        '
        'Product_Price
        '
        Me.Product_Price.HeaderText = "Product Price"
        Me.Product_Price.Name = "Product_Price"
        '
        'Product_Qty
        '
        Me.Product_Qty.HeaderText = "Product Quantity"
        Me.Product_Qty.Name = "Product_Qty"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'Sales_Total
        '
        Me.Sales_Total.HeaderText = "Sales Total"
        Me.Sales_Total.Name = "Sales_Total"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Customer_IDComboBox)
        Me.TabPage1.Controls.Add(Me.Employee_IDComboBox)
        Me.TabPage1.Controls.Add(Me.Payment_TypeComboBox)
        Me.TabPage1.Controls.Add(Me.Cust_Payment_DateBox)
        Me.TabPage1.Controls.Add(Me.Cust_Payment_TotalTextBox)
        Me.TabPage1.Controls.Add(Me.Sales_Order_IDTextbox)
        Me.TabPage1.Controls.Add(Me.Cust_Payment_IDTextBox)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1175, 811)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Customer Accounts"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Customer_ID, Me.Customer_Payment_ID, Me.Sales_Order_ID, Me.Payment_Type, Me.Payment_Total, Me.Payment_Date, Me.Employee_ID})
        Me.DataGridView2.Location = New System.Drawing.Point(423, 65)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(743, 746)
        Me.DataGridView2.TabIndex = 20
        '
        'Customer_ID
        '
        Me.Customer_ID.HeaderText = "Customer ID"
        Me.Customer_ID.Name = "Customer_ID"
        '
        'Customer_Payment_ID
        '
        Me.Customer_Payment_ID.HeaderText = "Customer Payment ID"
        Me.Customer_Payment_ID.Name = "Customer_Payment_ID"
        '
        'Sales_Order_ID
        '
        Me.Sales_Order_ID.HeaderText = "Sales Order ID"
        Me.Sales_Order_ID.Name = "Sales_Order_ID"
        '
        'Payment_Type
        '
        Me.Payment_Type.HeaderText = "Payment Type"
        Me.Payment_Type.Name = "Payment_Type"
        '
        'Payment_Total
        '
        Me.Payment_Total.HeaderText = "Payment Total"
        Me.Payment_Total.Name = "Payment_Total"
        '
        'Payment_Date
        '
        Me.Payment_Date.HeaderText = "Payment Date"
        Me.Payment_Date.Name = "Payment_Date"
        '
        'Employee_ID
        '
        Me.Employee_ID.HeaderText = "Employee ID"
        Me.Employee_ID.Name = "Employee_ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(420, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "View Customer Payments"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(423, 38)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(156, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 79)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Add Payment"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Customer_IDComboBox
        '
        Me.Customer_IDComboBox.FormattingEnabled = True
        Me.Customer_IDComboBox.Location = New System.Drawing.Point(156, 38)
        Me.Customer_IDComboBox.Name = "Customer_IDComboBox"
        Me.Customer_IDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Customer_IDComboBox.TabIndex = 15
        '
        'Employee_IDComboBox
        '
        Me.Employee_IDComboBox.FormattingEnabled = True
        Me.Employee_IDComboBox.Location = New System.Drawing.Point(156, 200)
        Me.Employee_IDComboBox.Name = "Employee_IDComboBox"
        Me.Employee_IDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Employee_IDComboBox.TabIndex = 14
        '
        'Payment_TypeComboBox
        '
        Me.Payment_TypeComboBox.FormattingEnabled = True
        Me.Payment_TypeComboBox.Location = New System.Drawing.Point(156, 117)
        Me.Payment_TypeComboBox.Name = "Payment_TypeComboBox"
        Me.Payment_TypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Payment_TypeComboBox.TabIndex = 13
        '
        'Cust_Payment_DateBox
        '
        Me.Cust_Payment_DateBox.Location = New System.Drawing.Point(156, 170)
        Me.Cust_Payment_DateBox.Name = "Cust_Payment_DateBox"
        Me.Cust_Payment_DateBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_Payment_DateBox.TabIndex = 12
        '
        'Cust_Payment_TotalTextBox
        '
        Me.Cust_Payment_TotalTextBox.Location = New System.Drawing.Point(156, 143)
        Me.Cust_Payment_TotalTextBox.Name = "Cust_Payment_TotalTextBox"
        Me.Cust_Payment_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_Payment_TotalTextBox.TabIndex = 11
        '
        'Sales_Order_IDTextbox
        '
        Me.Sales_Order_IDTextbox.Location = New System.Drawing.Point(156, 91)
        Me.Sales_Order_IDTextbox.Name = "Sales_Order_IDTextbox"
        Me.Sales_Order_IDTextbox.Size = New System.Drawing.Size(200, 20)
        Me.Sales_Order_IDTextbox.TabIndex = 9
        '
        'Cust_Payment_IDTextBox
        '
        Me.Cust_Payment_IDTextBox.Location = New System.Drawing.Point(156, 65)
        Me.Cust_Payment_IDTextBox.Name = "Cust_Payment_IDTextBox"
        Me.Cust_Payment_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_Payment_IDTextBox.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Customer ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Employee ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Payment Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Payment Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Payment Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Customer Payment ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sales Order ID"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1175, 811)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Supplier Accounts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(705, 41)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(172, 47)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "View All Supplier Payments"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(194, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 79)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Add Payment"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(194, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(194, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Purchase Order Payment"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Purchase Order No"
        '
        'CFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 842)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CFO"
        Me.Text = "CFO"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OrderDateBox As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerPaymentIDTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents SalesOrderIDTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Product_Code As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Product_Price As DataGridViewTextBoxColumn
    Friend WithEvents Product_Qty As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Sales_Total As DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Customer_ID As DataGridViewTextBoxColumn
    Friend WithEvents Customer_Payment_ID As DataGridViewTextBoxColumn
    Friend WithEvents Sales_Order_ID As DataGridViewTextBoxColumn
    Friend WithEvents Payment_Type As DataGridViewTextBoxColumn
    Friend WithEvents Payment_Total As DataGridViewTextBoxColumn
    Friend WithEvents Payment_Date As DataGridViewTextBoxColumn
    Friend WithEvents Employee_ID As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Customer_IDComboBox As ComboBox
    Friend WithEvents Employee_IDComboBox As ComboBox
    Friend WithEvents Payment_TypeComboBox As ComboBox
    Friend WithEvents Cust_Payment_DateBox As DateTimePicker
    Friend WithEvents Cust_Payment_TotalTextBox As TextBox
    Friend WithEvents Sales_Order_IDTextbox As TextBox
    Friend WithEvents Cust_Payment_IDTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
End Class
