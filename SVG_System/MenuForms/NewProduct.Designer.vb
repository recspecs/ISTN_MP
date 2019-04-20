<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProduct
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
        Me.radioYes = New System.Windows.Forms.RadioButton()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioNo = New System.Windows.Forms.RadioButton()
        Me.lboxCategories = New System.Windows.Forms.ListBox()
        Me.SupplierTextBox = New System.Windows.Forms.ComboBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ActiveNO = New System.Windows.Forms.RadioButton()
        Me.ActiveYES = New System.Windows.Forms.RadioButton()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SellingPriceTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radioYes
        '
        Me.radioYes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioYes.AutoSize = True
        Me.radioYes.Checked = True
        Me.radioYes.Location = New System.Drawing.Point(6, 16)
        Me.radioYes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radioYes.Name = "radioYes"
        Me.radioYes.Size = New System.Drawing.Size(45, 21)
        Me.radioYes.TabIndex = 1
        Me.radioYes.TabStop = True
        Me.radioYes.Text = "Yes"
        Me.radioYes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.radioYes.UseVisualStyleBackColor = True
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(193, 31)
        Me.ProductCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(186, 25)
        Me.ProductCodeTextBox.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Selling Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOnHand
        '
        Me.lblOnHand.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblOnHand.AutoSize = True
        Me.lblOnHand.Location = New System.Drawing.Point(65, 139)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(60, 17)
        Me.lblOnHand.TabIndex = 34
        Me.lblOnHand.Text = "On Hand"
        Me.lblOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(441, 198)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(71, 17)
        Me.lblCategory.TabIndex = 32
        Me.lblCategory.Text = "Categories"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProductNameTextBox.Location = New System.Drawing.Point(193, 81)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(487, 25)
        Me.ProductNameTextBox.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "VAT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Product Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Product Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radioNo
        '
        Me.radioNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radioNo.AutoSize = True
        Me.radioNo.Location = New System.Drawing.Point(134, 18)
        Me.radioNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radioNo.Name = "radioNo"
        Me.radioNo.Size = New System.Drawing.Size(44, 21)
        Me.radioNo.TabIndex = 41
        Me.radioNo.Text = "No"
        Me.radioNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.radioNo.UseVisualStyleBackColor = True
        '
        'lboxCategories
        '
        Me.lboxCategories.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lboxCategories.FormattingEnabled = True
        Me.lboxCategories.ItemHeight = 17
        Me.lboxCategories.Items.AddRange(New Object() {"Food", "Softdrink"})
        Me.lboxCategories.Location = New System.Drawing.Point(518, 198)
        Me.lboxCategories.Name = "lboxCategories"
        Me.lboxCategories.Size = New System.Drawing.Size(162, 174)
        Me.lboxCategories.TabIndex = 44
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SupplierTextBox.FormattingEnabled = True
        Me.SupplierTextBox.Location = New System.Drawing.Point(193, 347)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.Size = New System.Drawing.Size(186, 25)
        Me.SupplierTextBox.TabIndex = 45
        '
        'lblSupplier
        '
        Me.lblSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(65, 355)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(56, 17)
        Me.lblSupplier.TabIndex = 46
        Me.lblSupplier.Text = "Supplier"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.MenuForms.My.Resources.Resources.Action_ok_icon
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(193, 419)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnAdd.Size = New System.Drawing.Size(92, 40)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.MenuForms.My.Resources.Resources.delete_icon__1_
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(444, 419)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnCancel.Size = New System.Drawing.Size(92, 40)
        Me.btnCancel.TabIndex = 48
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Active"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActiveNO
        '
        Me.ActiveNO.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ActiveNO.AutoSize = True
        Me.ActiveNO.Location = New System.Drawing.Point(134, 25)
        Me.ActiveNO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ActiveNO.Name = "ActiveNO"
        Me.ActiveNO.Size = New System.Drawing.Size(44, 21)
        Me.ActiveNO.TabIndex = 50
        Me.ActiveNO.Text = "No"
        Me.ActiveNO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ActiveNO.UseVisualStyleBackColor = True
        '
        'ActiveYES
        '
        Me.ActiveYES.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ActiveYES.AutoSize = True
        Me.ActiveYES.Checked = True
        Me.ActiveYES.Location = New System.Drawing.Point(6, 23)
        Me.ActiveYES.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ActiveYES.Name = "ActiveYES"
        Me.ActiveYES.Size = New System.Drawing.Size(45, 21)
        Me.ActiveYES.TabIndex = 49
        Me.ActiveYES.TabStop = True
        Me.ActiveYES.Text = "Yes"
        Me.ActiveYES.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ActiveYES.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(193, 139)
        Me.MaskedTextBox1.Mask = "00000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.MaskedTextBox1.TabIndex = 51
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'SellingPriceTextBox
        '
        Me.SellingPriceTextBox.Location = New System.Drawing.Point(193, 235)
        Me.SellingPriceTextBox.Mask = "0000.00"
        Me.SellingPriceTextBox.Name = "SellingPriceTextBox"
        Me.SellingPriceTextBox.Size = New System.Drawing.Size(100, 25)
        Me.SellingPriceTextBox.TabIndex = 52
        Me.SellingPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SellingPriceTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ActiveYES)
        Me.GroupBox1.Controls.Add(Me.ActiveNO)
        Me.GroupBox1.Location = New System.Drawing.Point(193, 266)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 63)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioYes)
        Me.GroupBox2.Controls.Add(Me.radioNo)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 59)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'NewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SellingPriceTextBox)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.SupplierTextBox)
        Me.Controls.Add(Me.lboxCategories)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProductCodeTextBox)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblOnHand)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NewProduct"
        Me.Text = "Add New Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents radioYes As RadioButton
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOnHand As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents radioNo As RadioButton
    Friend WithEvents lboxCategories As ListBox
    Friend WithEvents SupplierTextBox As ComboBox
    Friend WithEvents lblSupplier As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ActiveNO As RadioButton
    Friend WithEvents ActiveYES As RadioButton
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents SellingPriceTextBox As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
