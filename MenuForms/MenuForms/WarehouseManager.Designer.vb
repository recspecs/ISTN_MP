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
        Me.Tc_WarehouseManager = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txbOrderID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSearchOrderID = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProductTab = New System.Windows.Forms.TabPage()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txbSearchDef = New System.Windows.Forms.TextBox()
        Me.btnSearchDefective = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddNewProduct = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecSpecDataset = New MenuForms.RecSpecDataset()
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.RecSpecDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tc_WarehouseManager.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.ProductTab.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.TabPage4.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Tc_WarehouseManager
        '
        Me.Tc_WarehouseManager.AccessibleName = ""
        Me.Tc_WarehouseManager.Controls.Add(Me.TabPage1)
        Me.Tc_WarehouseManager.Controls.Add(Me.ProductTab)
        Me.Tc_WarehouseManager.Controls.Add(Me.TabPage3)
        Me.Tc_WarehouseManager.Controls.Add(Me.TabPage4)
        Me.Tc_WarehouseManager.Location = New System.Drawing.Point(13, 13)
        Me.Tc_WarehouseManager.Name = "Tc_WarehouseManager"
        Me.Tc_WarehouseManager.SelectedIndex = 0
        Me.Tc_WarehouseManager.Size = New System.Drawing.Size(936, 691)
        Me.Tc_WarehouseManager.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.txbOrderID)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.btnSearchOrderID)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(928, 665)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Orders"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 283)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 15
        '
        'txbOrderID
        '
        Me.txbOrderID.Location = New System.Drawing.Point(289, 70)
        Me.txbOrderID.Name = "txbOrderID"
        Me.txbOrderID.Size = New System.Drawing.Size(137, 20)
        Me.txbOrderID.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(199, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Order ID :"
        '
        'btnSearchOrderID
        '
        Me.btnSearchOrderID.Location = New System.Drawing.Point(26, 281)
        Me.btnSearchOrderID.Name = "btnSearchOrderID"
        Me.btnSearchOrderID.Size = New System.Drawing.Size(130, 23)
        Me.btnSearchOrderID.TabIndex = 12
        Me.btnSearchOrderID.Text = "Search by Order ID"
        Me.btnSearchOrderID.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(26, 68)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Remove Order"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "View Orders"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'ProductTab
        '
        Me.ProductTab.Controls.Add(Me.btnRemove)
        Me.ProductTab.Controls.Add(Me.btnSave)
        Me.ProductTab.Controls.Add(Me.btnUpdate)
        Me.ProductTab.Controls.Add(Me.btnAddNewProduct)
        Me.ProductTab.Controls.Add(Me.DataGridView1)
        Me.ProductTab.Controls.Add(Me.TextBox21)
        Me.ProductTab.Controls.Add(Me.Button7)
        Me.ProductTab.Controls.Add(Me.Button5)
        Me.ProductTab.Controls.Add(Me.TextBox20)
        Me.ProductTab.Controls.Add(Me.ComboBox1)
        Me.ProductTab.Controls.Add(Me.TextBox19)
        Me.ProductTab.Controls.Add(Me.TextBox18)
        Me.ProductTab.Controls.Add(Me.TextBox17)
        Me.ProductTab.Controls.Add(Me.TextBox16)
        Me.ProductTab.Controls.Add(Me.Label23)
        Me.ProductTab.Controls.Add(Me.Label22)
        Me.ProductTab.Controls.Add(Me.Label21)
        Me.ProductTab.Controls.Add(Me.Label20)
        Me.ProductTab.Controls.Add(Me.Label19)
        Me.ProductTab.Controls.Add(Me.Label18)
        Me.ProductTab.Location = New System.Drawing.Point(4, 22)
        Me.ProductTab.Name = "ProductTab"
        Me.ProductTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductTab.Size = New System.Drawing.Size(928, 665)
        Me.ProductTab.TabIndex = 1
        Me.ProductTab.Text = "Product"
        Me.ProductTab.UseVisualStyleBackColor = true
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(214, 251)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(279, 20)
        Me.TextBox21.TabIndex = 15
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(86, 248)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 23)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Search Product"
        Me.Button7.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(229, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Update Store QTY"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(748, 229)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(748, 187)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(748, 143)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 9
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(748, 103)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 8
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(748, 61)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 7
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(748, 22)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Location = New System.Drawing.Point(636, 232)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Returns ID"
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Location = New System.Drawing.Point(636, 190)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "VAT"
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Location = New System.Drawing.Point(636, 146)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Store QTY"
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Location = New System.Drawing.Point(636, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Product Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Location = New System.Drawing.Point(636, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Selling Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(636, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Product Code"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox13)
        Me.TabPage3.Controls.Add(Me.Button8)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.TextBox2)
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
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(928, 665)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Returns"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(526, 13)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(121, 20)
        Me.TextBox13.TabIndex = 22
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(384, 11)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(119, 23)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "Search Returns Order"
        Me.Button8.UseVisualStyleBackColor = true
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(139, 81)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(139, 257)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(135, 20)
        Me.TextBox9.TabIndex = 19
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(139, 221)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(135, 20)
        Me.TextBox8.TabIndex = 18
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(139, 188)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(135, 20)
        Me.TextBox7.TabIndex = 17
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(139, 153)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(135, 20)
        Me.TextBox6.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(139, 119)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(135, 20)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(139, 46)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(135, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 20)
        Me.TextBox2.TabIndex = 12
        '
        'btnUpdateReturned
        '
        Me.btnUpdateReturned.Location = New System.Drawing.Point(384, 257)
        Me.btnUpdateReturned.Name = "btnUpdateReturned"
        Me.btnUpdateReturned.Size = New System.Drawing.Size(136, 23)
        Me.btnUpdateReturned.TabIndex = 11
        Me.btnUpdateReturned.Text = "Update Returned Goods"
        Me.btnUpdateReturned.UseVisualStyleBackColor = true
        '
        'btnViewRet
        '
        Me.btnViewRet.Location = New System.Drawing.Point(384, 214)
        Me.btnViewRet.Name = "btnViewRet"
        Me.btnViewRet.Size = New System.Drawing.Size(136, 23)
        Me.btnViewRet.TabIndex = 10
        Me.btnViewRet.Text = "View Returned Goods"
        Me.btnViewRet.UseVisualStyleBackColor = true
        '
        'btnAddRet
        '
        Me.btnAddRet.Location = New System.Drawing.Point(384, 168)
        Me.btnAddRet.Name = "btnAddRet"
        Me.btnAddRet.Size = New System.Drawing.Size(136, 23)
        Me.btnAddRet.TabIndex = 9
        Me.btnAddRet.Text = "Add Returned Goods"
        Me.btnAddRet.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(16, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Product ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(16, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sale Order ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(16, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Amount of Returns"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(16, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(16, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Product Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(16, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Returned Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(16, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Return Product QTY"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Return ID"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox12)
        Me.TabPage4.Controls.Add(Me.TextBox11)
        Me.TabPage4.Controls.Add(Me.DateTimePicker2)
        Me.TabPage4.Controls.Add(Me.TextBox10)
        Me.TabPage4.Controls.Add(Me.TextBox4)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.txbSearchDef)
        Me.TabPage4.Controls.Add(Me.btnSearchDefective)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(928, 665)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Defective"
        Me.TabPage4.UseVisualStyleBackColor = true
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(140, 158)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 16
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(140, 120)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(126, 20)
        Me.TextBox11.TabIndex = 15
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(140, 81)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 14
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(140, 51)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(126, 20)
        Me.TextBox10.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(140, 16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(126, 20)
        Me.TextBox4.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "View Defective Items"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Add Defective Item"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'txbSearchDef
        '
        Me.txbSearchDef.Location = New System.Drawing.Point(467, 19)
        Me.txbSearchDef.Name = "txbSearchDef"
        Me.txbSearchDef.Size = New System.Drawing.Size(163, 20)
        Me.txbSearchDef.TabIndex = 9
        '
        'btnSearchDefective
        '
        Me.btnSearchDefective.Location = New System.Drawing.Point(320, 17)
        Me.btnSearchDefective.Name = "btnSearchDefective"
        Me.btnSearchDefective.Size = New System.Drawing.Size(127, 23)
        Me.btnSearchDefective.TabIndex = 8
        Me.btnSearchDefective.Text = "Search Defective Item"
        Me.btnSearchDefective.UseVisualStyleBackColor = true
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(13, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Sale Order ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(13, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Product Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(13, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Returned Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(13, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Product QTY"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(13, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Product Code"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = true
        Me.DataGridView1.AutoGenerateColumns = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.RecSpecDatasetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(86, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(784, 369)
        Me.DataGridView1.TabIndex = 16
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.Location = New System.Drawing.Point(86, 87)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(104, 90)
        Me.btnAddNewProduct.TabIndex = 17
        Me.btnAddNewProduct.Text = "Add New Product"
        Me.btnAddNewProduct.UseVisualStyleBackColor = true
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(214, 87)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 90)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(340, 87)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 90)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(486, 87)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(104, 90)
        Me.btnRemove.TabIndex = 20
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = true
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
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = true
        '
        'RecSpecDatasetBindingSource
        '
        Me.RecSpecDatasetBindingSource.DataSource = Me.RecSpecDataset
        Me.RecSpecDatasetBindingSource.Position = 0
        '
        'WarehouseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 768)
        Me.Controls.Add(Me.Tc_WarehouseManager)
        Me.Name = "WarehouseManager"
        Me.Text = "Warehouse Manager"
        Me.Tc_WarehouseManager.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.ProductTab.ResumeLayout(false)
        Me.ProductTab.PerformLayout
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        Me.TabPage4.ResumeLayout(false)
        Me.TabPage4.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Tc_WarehouseManager As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ProductTab As TabPage
    Friend WithEvents TabPage3 As TabPage
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
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSearchOrderID As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txbSearchDef As TextBox
    Friend WithEvents btnSearchDefective As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txbOrderID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddNewProduct As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RecSpecDataset As RecSpecDataset
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As RecSpecDatasetTableAdapters.ProductTableAdapter
    Friend WithEvents RecSpecDatasetBindingSource As BindingSource
End Class
