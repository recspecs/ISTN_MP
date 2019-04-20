<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSalesOrder
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OrderDateBox = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblSalesOrderId = New System.Windows.Forms.Label()
        Me.CustomerPaymentIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.SalesOrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancelNewSalesOrder = New System.Windows.Forms.Button()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(239, 133)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'OrderDateBox
        '
        Me.OrderDateBox.Location = New System.Drawing.Point(239, 54)
        Me.OrderDateBox.Name = "OrderDateBox"
        Me.OrderDateBox.Size = New System.Drawing.Size(200, 20)
        Me.OrderDateBox.TabIndex = 47
        '
        'Label34
        '
        Me.Label34.AutoSize = true
        Me.Label34.Location = New System.Drawing.Point(52, 133)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 13)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "Employee ID"
        '
        'Label35
        '
        Me.Label35.AutoSize = true
        Me.Label35.Location = New System.Drawing.Point(52, 106)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(109, 13)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "Customer Payment ID"
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Location = New System.Drawing.Point(52, 80)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(65, 13)
        Me.Label36.TabIndex = 44
        Me.Label36.Text = "Customer ID"
        '
        'Label37
        '
        Me.Label37.AutoSize = true
        Me.Label37.Location = New System.Drawing.Point(52, 54)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 13)
        Me.Label37.TabIndex = 43
        Me.Label37.Text = "Order Date"
        '
        'lblSalesOrderId
        '
        Me.lblSalesOrderId.AutoSize = true
        Me.lblSalesOrderId.Location = New System.Drawing.Point(52, 28)
        Me.lblSalesOrderId.Name = "lblSalesOrderId"
        Me.lblSalesOrderId.Size = New System.Drawing.Size(76, 13)
        Me.lblSalesOrderId.TabIndex = 42
        Me.lblSalesOrderId.Text = "Sales Order ID"
        '
        'CustomerPaymentIDTextBox
        '
        Me.CustomerPaymentIDTextBox.Location = New System.Drawing.Point(239, 106)
        Me.CustomerPaymentIDTextBox.Name = "CustomerPaymentIDTextBox"
        Me.CustomerPaymentIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerPaymentIDTextBox.TabIndex = 41
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(239, 80)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox.TabIndex = 40
        '
        'SalesOrderIDTextBox
        '
        Me.SalesOrderIDTextBox.Location = New System.Drawing.Point(239, 28)
        Me.SalesOrderIDTextBox.Name = "SalesOrderIDTextBox"
        Me.SalesOrderIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesOrderIDTextBox.TabIndex = 39
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = true
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.UnitsColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView1.Location = New System.Drawing.Point(41, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(647, 321)
        Me.DataGridView1.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'UnitsColumn1
        '
        Me.UnitsColumn1.HeaderText = "Product Name"
        Me.UnitsColumn1.Name = "UnitsColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Selling Price"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Units"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vat"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Active"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAdd.Image = Global.MenuForms.My.Resources.Resources.ok
        Me.btnAdd.Location = New System.Drawing.Point(454, 39)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnAdd.Size = New System.Drawing.Size(107, 98)
        Me.btnAdd.TabIndex = 71
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnCancelNewSalesOrder
        '
        Me.btnCancelNewSalesOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancelNewSalesOrder.Image = Global.MenuForms.My.Resources.Resources.delete48x48
        Me.btnCancelNewSalesOrder.Location = New System.Drawing.Point(581, 39)
        Me.btnCancelNewSalesOrder.Name = "btnCancelNewSalesOrder"
        Me.btnCancelNewSalesOrder.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnCancelNewSalesOrder.Size = New System.Drawing.Size(107, 98)
        Me.btnCancelNewSalesOrder.TabIndex = 72
        Me.btnCancelNewSalesOrder.Text = "Cancel"
        Me.btnCancelNewSalesOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelNewSalesOrder.UseVisualStyleBackColor = true
        '
        'NewSalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 528)
        Me.Controls.Add(Me.btnCancelNewSalesOrder)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.OrderDateBox)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.lblSalesOrderId)
        Me.Controls.Add(Me.CustomerPaymentIDTextBox)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.SalesOrderIDTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "NewSalesOrder"
        Me.Text = "New Sales Order"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OrderDateBox As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents lblSalesOrderId As Label
    Friend WithEvents CustomerPaymentIDTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents SalesOrderIDTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UnitsColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancelNewSalesOrder As Button
End Class
