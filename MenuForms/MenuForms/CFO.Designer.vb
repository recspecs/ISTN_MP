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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CaptureSalesOrderTab = New System.Windows.Forms.TabPage()
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
        Me.Product_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sales_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout
        Me.CaptureSalesOrderTab.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage1.SuspendLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage3.SuspendLayout
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CaptureSalesOrderTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 4)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1380, 1095)
        Me.TabControl1.TabIndex = 1
        '
        'CaptureSalesOrderTab
        '
        Me.CaptureSalesOrderTab.Controls.Add(Me.Button1)
        Me.CaptureSalesOrderTab.Controls.Add(Me.ComboBox1)
        Me.CaptureSalesOrderTab.Controls.Add(Me.OrderDateBox)
        Me.CaptureSalesOrderTab.Controls.Add(Me.Label5)
        Me.CaptureSalesOrderTab.Controls.Add(Me.Label4)
        Me.CaptureSalesOrderTab.Controls.Add(Me.Label3)
        Me.CaptureSalesOrderTab.Controls.Add(Me.Label2)
        Me.CaptureSalesOrderTab.Controls.Add(Me.Label1)
        Me.CaptureSalesOrderTab.Controls.Add(Me.CustomerPaymentIDTextBox)
        Me.CaptureSalesOrderTab.Controls.Add(Me.CustomerIDTextBox)
        Me.CaptureSalesOrderTab.Controls.Add(Me.SalesOrderIDTextBox)
        Me.CaptureSalesOrderTab.Controls.Add(Me.DataGridView1)
        Me.CaptureSalesOrderTab.Location = New System.Drawing.Point(4, 26)
        Me.CaptureSalesOrderTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CaptureSalesOrderTab.Name = "CaptureSalesOrderTab"
        Me.CaptureSalesOrderTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CaptureSalesOrderTab.Size = New System.Drawing.Size(1372, 1065)
        Me.CaptureSalesOrderTab.TabIndex = 1
        Me.CaptureSalesOrderTab.Text = "Capture Sales Order"
        Me.CaptureSalesOrderTab.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 165)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Capture Sales Order"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(231, 163)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 25)
        Me.ComboBox1.TabIndex = 12
        '
        'OrderDateBox
        '
        Me.OrderDateBox.Location = New System.Drawing.Point(231, 60)
        Me.OrderDateBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderDateBox.Name = "OrderDateBox"
        Me.OrderDateBox.Size = New System.Drawing.Size(233, 25)
        Me.OrderDateBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(13, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employee ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(13, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Customer Payment ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(13, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sales Order ID"
        '
        'CustomerPaymentIDTextBox
        '
        Me.CustomerPaymentIDTextBox.Location = New System.Drawing.Point(231, 128)
        Me.CustomerPaymentIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerPaymentIDTextBox.Name = "CustomerPaymentIDTextBox"
        Me.CustomerPaymentIDTextBox.Size = New System.Drawing.Size(233, 25)
        Me.CustomerPaymentIDTextBox.TabIndex = 4
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(231, 94)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(233, 25)
        Me.CustomerIDTextBox.TabIndex = 3
        '
        'SalesOrderIDTextBox
        '
        Me.SalesOrderIDTextBox.Location = New System.Drawing.Point(231, 26)
        Me.SalesOrderIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SalesOrderIDTextBox.Name = "SalesOrderIDTextBox"
        Me.SalesOrderIDTextBox.Size = New System.Drawing.Size(233, 25)
        Me.SalesOrderIDTextBox.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = true
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Code, Me.Product_Name, Me.Product_Price, Me.Product_Qty, Me.Subtotal, Me.Sales_Total})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 225)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(882, 642)
        Me.DataGridView1.TabIndex = 0
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
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1372, 1069)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Customer Accounts"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Customer_ID, Me.Customer_Payment_ID, Me.Sales_Order_ID, Me.Payment_Type, Me.Payment_Total, Me.Payment_Date, Me.Employee_ID})
        Me.DataGridView2.Location = New System.Drawing.Point(493, 85)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(867, 976)
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
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(490, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "View Customer Payments"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = true
        Me.ComboBox2.Location = New System.Drawing.Point(493, 50)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(233, 25)
        Me.ComboBox2.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.Location = New System.Drawing.Point(182, 324)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 103)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Add Payment"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Customer_IDComboBox
        '
        Me.Customer_IDComboBox.FormattingEnabled = true
        Me.Customer_IDComboBox.Location = New System.Drawing.Point(182, 50)
        Me.Customer_IDComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Customer_IDComboBox.Name = "Customer_IDComboBox"
        Me.Customer_IDComboBox.Size = New System.Drawing.Size(233, 25)
        Me.Customer_IDComboBox.TabIndex = 15
        '
        'Employee_IDComboBox
        '
        Me.Employee_IDComboBox.FormattingEnabled = true
        Me.Employee_IDComboBox.Location = New System.Drawing.Point(182, 262)
        Me.Employee_IDComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Employee_IDComboBox.Name = "Employee_IDComboBox"
        Me.Employee_IDComboBox.Size = New System.Drawing.Size(233, 25)
        Me.Employee_IDComboBox.TabIndex = 14
        '
        'Payment_TypeComboBox
        '
        Me.Payment_TypeComboBox.FormattingEnabled = true
        Me.Payment_TypeComboBox.Location = New System.Drawing.Point(182, 153)
        Me.Payment_TypeComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Payment_TypeComboBox.Name = "Payment_TypeComboBox"
        Me.Payment_TypeComboBox.Size = New System.Drawing.Size(233, 25)
        Me.Payment_TypeComboBox.TabIndex = 13
        '
        'Cust_Payment_DateBox
        '
        Me.Cust_Payment_DateBox.Location = New System.Drawing.Point(182, 222)
        Me.Cust_Payment_DateBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cust_Payment_DateBox.Name = "Cust_Payment_DateBox"
        Me.Cust_Payment_DateBox.Size = New System.Drawing.Size(233, 25)
        Me.Cust_Payment_DateBox.TabIndex = 12
        '
        'Cust_Payment_TotalTextBox
        '
        Me.Cust_Payment_TotalTextBox.Location = New System.Drawing.Point(182, 187)
        Me.Cust_Payment_TotalTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cust_Payment_TotalTextBox.Name = "Cust_Payment_TotalTextBox"
        Me.Cust_Payment_TotalTextBox.Size = New System.Drawing.Size(233, 25)
        Me.Cust_Payment_TotalTextBox.TabIndex = 11
        '
        'Sales_Order_IDTextbox
        '
        Me.Sales_Order_IDTextbox.Location = New System.Drawing.Point(182, 119)
        Me.Sales_Order_IDTextbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sales_Order_IDTextbox.Name = "Sales_Order_IDTextbox"
        Me.Sales_Order_IDTextbox.Size = New System.Drawing.Size(233, 25)
        Me.Sales_Order_IDTextbox.TabIndex = 9
        '
        'Cust_Payment_IDTextBox
        '
        Me.Cust_Payment_IDTextBox.Location = New System.Drawing.Point(182, 85)
        Me.Cust_Payment_IDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cust_Payment_IDTextBox.Name = "Cust_Payment_IDTextBox"
        Me.Cust_Payment_IDTextBox.Size = New System.Drawing.Size(233, 25)
        Me.Cust_Payment_IDTextBox.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(7, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Customer ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(7, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Employee ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(7, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Payment Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(7, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Payment Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(7, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Payment Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(7, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Customer Payment ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(7, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
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
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1372, 1069)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Supplier Accounts"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(822, 54)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(201, 61)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "View All Supplier Payments"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button4.Location = New System.Drawing.Point(226, 136)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(233, 103)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Add Payment"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(226, 76)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(233, 25)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(226, 39)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 25)
        Me.TextBox1.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(13, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Purchase Order Payment"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(13, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Purchase Order No"
        '
        'Product_Code
        '
        Me.Product_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Product_Code.HeaderText = "Product Code"
        Me.Product_Code.Name = "Product_Code"
        '
        'Product_Name
        '
        Me.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        '
        'Product_Price
        '
        Me.Product_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Product_Price.HeaderText = "Product Price"
        Me.Product_Price.Name = "Product_Price"
        '
        'Product_Qty
        '
        Me.Product_Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Product_Qty.HeaderText = "Product Quantity"
        Me.Product_Qty.Name = "Product_Qty"
        '
        'Subtotal
        '
        Me.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'Sales_Total
        '
        Me.Sales_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Sales_Total.HeaderText = "Sales Total"
        Me.Sales_Total.Name = "Sales_Total"
        '
        'CFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 1061)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CFO"
        Me.Text = "CFO"
        Me.TabControl1.ResumeLayout(false)
        Me.CaptureSalesOrderTab.ResumeLayout(false)
        Me.CaptureSalesOrderTab.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CaptureSalesOrderTab As TabPage
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
    Friend WithEvents Product_Code As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Product_Price As DataGridViewTextBoxColumn
    Friend WithEvents Product_Qty As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Sales_Total As DataGridViewTextBoxColumn
End Class
