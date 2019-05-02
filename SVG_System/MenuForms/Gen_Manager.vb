Public Class GenManager



    Private Sub GenManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SupplierTableAdapter.Fill(Me.RecspecDataset.Supplier)

        Me.Customer_PaymentTableAdapter.Fill(Me.RecspecDataset.Customer_Payment)

        Me.CustomerTableTableAdapter.Fill(Me.RecspecDataset.CustomerTable)

        Me.Purchase_ItemTableAdapter.Fill(Me.RecspecDataset.Purchase_Item)

        Me.Sale_ItemTableAdapter.Fill(Me.RecspecDataset.Sale_Item)

        Me.Purchase_OrderTableAdapter.Fill(Me.RecspecDataset.Purchase_Order)

        Me.Sales_OrderTableAdapter.Fill(Me.RecspecDataset.Sales_Order)

        Me.ProductTableAdapter.Fill(Me.RecspecDataset.Product)

        Me.EmployeeTableAdapter.Fill(Me.RecspecDataset.Employee)









        Me.DoubleBuffered = True
        Me.CenterToScreen()
    End Sub


#Region "Employee tab"
    Private Sub Employee_Init()

        SetAllFormat(EmployeeTab, flpEmployee, FinalSearchLayout, dgvEmployee, "Emp_")

        dgvEmployee.Columns(1).HeaderText = "First Name"
        dgvEmployee.Columns(2).HeaderText = "Surname"

        'MsgBox(flpEmployee.Left.ToString + " " + flpEmployee.Top.ToString + " " + flpEmployee.Width.ToString + " " + flpEmployee.Height.ToString)
        'MsgBox(FinalSearchLayout.Left.ToString + " " + FinalSearchLayout.Top.ToString + " " + FinalSearchLayout.Width.ToString + " " + FinalSearchLayout.Height.ToString)
        'MsgBox(dgvEmployee.Left.ToString + " " + dgvEmployee.Top.ToString + " " + dgvEmployee.Width.ToString + " " + dgvEmployee.Height.ToString)

    End Sub

    Private Sub tbQueryEmployee_Enter(sender As Object, e As EventArgs) Handles tbQueryEmployee.Enter
        tbQueryEmployee.Text = ""
    End Sub


    Private Sub btnAddEdit_Click(sender As Object, e As EventArgs) Handles btnAddEditEmployee.Click
        If Not btnAddEditEmployee.Text = "Cancel" Then
            dgvEmployee.ReadOnly = False
            dgvEmployee.AllowUserToAddRows = True
            dgvEmployee.GridColor = Color.Crimson
            btnAddEditEmployee.Text = "Cancel"
            btnAddEditEmployee.Image = My.Resources._return
            btnAddEditEmployee.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveEmployee.Enabled = False
            MsgBox("Add new employee, or edit existing employees!")
        Else
            dgvEmployee.ReadOnly = True
            dgvEmployee.AllowUserToAddRows = False
            dgvEmployee.GridColor = Color.Gray
            btnAddEditEmployee.Text = "Add New/Edit Employees"
            btnAddEditEmployee.Image = My.Resources.pencil96
            btnAddEditEmployee.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveEmployee.Enabled = True
            Me.EmployeeTableAdapter.Fill(Me.RecspecDataset.Employee)

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemoveEmployee.Click
        If Not btnRemoveEmployee.Text = "Cancel" Then
            dgvEmployee.ReadOnly = False
            dgvEmployee.AllowUserToDeleteRows = True
            dgvEmployee.GridColor = Color.Crimson
            btnRemoveEmployee.Text = "Cancel"
            btnRemoveEmployee.Image = My.Resources._return
            btnRemoveEmployee.ImageAlign = ContentAlignment.TopCenter
            btnAddEditEmployee.Enabled = False
            MsgBox("Select employees then press delete key! Click on the Save button when done!")
        Else
            btnRemoveEmployee.Text = "Remove"
            dgvEmployee.ReadOnly = True
            dgvEmployee.AllowUserToDeleteRows = False
            dgvEmployee.GridColor = Color.Gray
            btnRemoveEmployee.Image = My.Resources.bin_red_full_icon
            btnRemoveEmployee.ImageAlign = ContentAlignment.TopCenter
            btnAddEditEmployee.Enabled = True
            Me.EmployeeTableAdapter.Fill(Me.RecspecDataset.Employee)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveEmployee.Click
        If btnAddEditEmployee.Text = "Cancel" Or btnRemoveEmployee.Text = "Cancel" Then
            EmployeeBindingSource.EndEdit()
            Try
                EmployeeTableAdapter.Update(Me.RecspecDataset.Employee)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            dgvEmployee.ReadOnly = True
            dgvEmployee.AllowUserToAddRows = False
            dgvEmployee.AllowUserToDeleteRows = False
            dgvEmployee.GridColor = Color.Gray
            btnAddEditEmployee.Image = My.Resources.pencil96
            btnAddEditEmployee.ImageAlign = ContentAlignment.TopCenter
            btnAddEditEmployee.Text = "Add New/Edit Employees"
            btnAddEditEmployee.Enabled = True

            btnRemoveEmployee.Image = My.Resources.bin_red_full_icon
            btnRemoveEmployee.ImageAlign = ContentAlignment.TopCenter
            btnRemoveEmployee.Text = "Remove"
            btnRemoveEmployee.Enabled = True
            Me.EmployeeTableAdapter.Fill(Me.RecspecDataset.Employee)

        End If
    End Sub

    Private Sub btnSearchEmployee_Click(sender As Object, e As EventArgs) Handles btnSearchEmployee.Click
        Dim query As String

        Select Case cbCriteriaEmployee.Text
            Case "by Employee ID"
                query = "CONVERT(Employee_ID, System.String) LIKE '%" + tbQueryEmployee.Text + "%'"
            Case "by Employee Name"
                query = "Emp_FName LIKE '%" + tbQueryEmployee.Text + "%'"
            Case "by Employee Type"
                query = "Emp_Type LIKE '%" + tbQueryEmployee.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            EmployeeBindingSource.RemoveFilter()
        Else
            EmployeeBindingSource.Filter = query
        End If
    End Sub



#End Region


#Region "Product tab"

    Private Sub Product_init()
        SetAllFormat(ProductTab, flpProducts, tlpProduct, dgvProduct, "Prod_")

    End Sub


    Private Sub btnAddEditProduct_Click(sender As Object, e As EventArgs) Handles btnAddEditProduct.Click
        If Not btnAddEditProduct.Text = "Cancel" Then
            dgvProduct.ReadOnly = False
            dgvProduct.AllowUserToAddRows = True
            dgvProduct.GridColor = Color.Crimson
            btnAddEditProduct.Text = "Cancel"
            btnAddEditProduct.Image = My.Resources._return
            btnAddEditProduct.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveProduct.Enabled = False
            MsgBox("Add new product, or edit existing products!")
        Else
            dgvProduct.ReadOnly = True
            dgvProduct.AllowUserToAddRows = False
            dgvProduct.GridColor = Color.Gray
            btnAddEditProduct.Text = "Add New/Edit Products"
            btnAddEditProduct.Image = My.Resources.pencil96
            btnAddEditProduct.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveProduct.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecspecDataset.Product)

        End If
    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        If Not btnRemoveProduct.Text = "Cancel" Then
            dgvProduct.ReadOnly = False
            dgvProduct.AllowUserToDeleteRows = True
            dgvProduct.GridColor = Color.Crimson
            btnRemoveProduct.Text = "Cancel"
            btnRemoveProduct.Image = My.Resources._return
            btnRemoveProduct.ImageAlign = ContentAlignment.TopCenter
            btnAddEditProduct.Enabled = False
            MsgBox("Select products then press delete key! Click on the Save button when done!")
        Else
            btnRemoveProduct.Text = "Remove"
            dgvProduct.ReadOnly = True
            dgvProduct.AllowUserToDeleteRows = False
            dgvProduct.GridColor = Color.Gray
            btnRemoveProduct.Image = My.Resources.bin_red_full_icon
            btnRemoveProduct.ImageAlign = ContentAlignment.TopCenter
            btnAddEditProduct.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecspecDataset.Product)
        End If
    End Sub


    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        If btnAddEditPO.Text = "Cancel" Or btnRemoveProduct.Text = "Cancel" Then
            ProductBindingSource.EndEdit()
            Try
                ProductTableAdapter.Update(RecspecDataset.Product)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            dgvProduct.ReadOnly = True
            dgvProduct.AllowUserToAddRows = False
            dgvProduct.AllowUserToDeleteRows = False
            dgvProduct.GridColor = Color.Gray
            btnAddEditProduct.Image = My.Resources.pencil96
            btnAddEditProduct.ImageAlign = ContentAlignment.TopCenter
            btnAddEditProduct.Text = "Add New/Edit Products"
            btnAddEditProduct.Enabled = True

            btnRemoveProduct.Image = My.Resources.bin_red_full_icon
            btnRemoveProduct.ImageAlign = ContentAlignment.TopCenter
            btnRemoveProduct.Text = "Remove"
            btnRemoveProduct.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecspecDataset.Product)

        End If
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        Dim query As String

        Select Case cbCriteriaProduct.Text
            Case "by Product Code"
                query = "Product_Code LIKE '%" + tbQueryProduct.Text + "%'"
            Case "by Product Name"
                query = "Prod_Name LIKE '%" + tbQueryProduct.Text + "%'"
            Case "by Stock level"
                query = "Prod_Stock_Level LIKE '" + tbQueryProduct.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            ProductBindingSource.RemoveFilter()
        Else
            ProductBindingSource.Filter = query
        End If
    End Sub


    Private Sub tbQueryProduct_Enter(sender As Object, e As EventArgs) Handles tbQueryProduct.Enter
        tbQueryProduct.Text = ""
    End Sub


#End Region

#Region "Sales Order tab"

    Private Sub SalesOrder_Init()
        SetFormat4Dbl(SalesOrderTab, tlpSO, dgvSO, dgvSOBottom, "Cust_", "Prod_")
        dgvSO.Columns(3).HeaderText = "Customer"
        dgvSO.Columns(4).HeaderText = "Employee"

    End Sub

    Private Sub tbQuerySO_Enter(sender As Object, e As EventArgs) Handles tbQuerySO.Enter
        tbQuerySO.Text = ""
    End Sub


    Private Sub btnSearchSO_Click(sender As Object, e As EventArgs) Handles btnSearchSO.Click
        Dim query As String

        Select Case cbCriteriaSO.Text
            Case "by Sales Order ID"
                query = "Sales_Order_ID LIKE '%" + tbQuerySO.Text + "%'"
            Case "by Product Code"
                query = "Product_Code LIKE '%" + tbQuerySO.Text + "%'"
            Case "by Customer ID"
                query = "Convert(Customer_ID, System.String) LIKE '%" + tbQuerySO.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            SalesOrderBindingSource.RemoveFilter()
        Else
            SalesOrderBindingSource.Filter = query
        End If
    End Sub

#End Region


#Region "Purchase Order Tab"
    Private Sub PurchaseOrder_Init()
        SetAllFormat(POTab, flpPO, Nothing, dgvPO, "ZZZ")
        SetAllFormat(POTab, Nothing, Nothing, DGV2_2, "ZZZ")
    End Sub





#End Region

#Region "Supplier tab"

    Private Sub Supplier_Init()
        SetAllFormat(SupplierTab, flpSupplier, tlpSupplier, dgvSupplier, "Supp_")
    End Sub

    Private Sub tbQuerySupplier_Enter(sender As Object, e As EventArgs) Handles tbQuerySupplier.Enter
        tbQuerySupplier.Text = ""
    End Sub

    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        Dim query As String

        Select Case cbCriteriaSupplier.Text
            Case "by Supplier ID"
                query = "Convert(Suppier_ID, System.String) LIKE '%" + tbQuerySupplier.Text + "%'"
            Case "by Supplier Name"
                query = "Supp_Name LIKE '%" + tbQuerySupplier.Text + "%'"
            Case "by Supplier City"
                query = "Supp_City LIKE '%" + tbQuerySupplier.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            SupplierBindingSource.RemoveFilter()
        Else
            SupplierBindingSource.Filter = query
        End If
    End Sub


    Private Sub btnAddEditSupplier_Click(sender As Object, e As EventArgs) Handles btnAddEditSupplier.Click
        If Not btnAddEditSupplier.Text = "Cancel" Then
            dgvSupplier.ReadOnly = False
            dgvSupplier.AllowUserToAddRows = True
            dgvSupplier.GridColor = Color.Crimson
            btnAddEditSupplier.Text = "Cancel"
            btnAddEditSupplier.Image = My.Resources._return
            btnAddEditSupplier.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveSupplier.Enabled = False
            MsgBox("Add new supplier, or edit existing suppliers!")
        Else
            dgvSupplier.ReadOnly = True
            dgvSupplier.AllowUserToAddRows = False
            dgvSupplier.GridColor = Color.Gray
            btnAddEditSupplier.Text = "Add New/Edit Suppliers"
            btnAddEditSupplier.Image = My.Resources.pencil96
            btnAddEditSupplier.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveSupplier.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecspecDataset.Supplier)

        End If
    End Sub

    Private Sub btnRemoveSupplier_Click(sender As Object, e As EventArgs) Handles btnRemoveSupplier.Click
        If Not btnRemoveSupplier.Text = "Cancel" Then
            dgvSupplier.ReadOnly = False
            dgvSupplier.AllowUserToDeleteRows = True
            dgvSupplier.GridColor = Color.Crimson
            btnRemoveSupplier.Text = "Cancel"
            btnRemoveSupplier.Image = My.Resources._return
            btnRemoveSupplier.ImageAlign = ContentAlignment.TopCenter
            btnAddEditSupplier.Enabled = False
            MsgBox("Select suppliers then press delete key! Click on the Save button when done!")
        Else
            btnRemoveSupplier.Text = "Remove"
            dgvSupplier.ReadOnly = True
            dgvSupplier.AllowUserToDeleteRows = False
            dgvSupplier.GridColor = Color.Gray
            btnRemoveSupplier.Image = My.Resources.bin_red_full_icon
            btnRemoveSupplier.ImageAlign = ContentAlignment.TopCenter
            btnAddEditSupplier.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecspecDataset.Supplier)
        End If
    End Sub

    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs) Handles btnSaveSupplier.Click
        If btnAddEditSupplier.Text = "Cancel" Or btnRemoveSupplier.Text = "Cancel" Then
            SupplierBindingSource.EndEdit()
            Try
                SupplierTableAdapter.Update(RecspecDataset.Supplier)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            dgvSupplier.ReadOnly = True
            dgvSupplier.AllowUserToAddRows = False
            dgvSupplier.AllowUserToDeleteRows = False
            dgvSupplier.GridColor = Color.Gray
            btnAddEditSupplier.Image = My.Resources.pencil96
            btnAddEditSupplier.ImageAlign = ContentAlignment.TopCenter
            btnAddEditSupplier.Text = "Add New/Edit Suppliers"
            btnAddEditSupplier.Enabled = True

            btnRemoveSupplier.Image = My.Resources.bin_red_full_icon
            btnRemoveSupplier.ImageAlign = ContentAlignment.TopCenter
            btnRemoveSupplier.Text = "Remove"
            btnRemoveSupplier.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecspecDataset.Supplier)
        End If
    End Sub

#End Region




#Region "Customer tab"
    Private Sub Customer_Init()
        SetAllFormat(CustomerTab, flpCustomer, tlpCustomer, dgvCustomer, "Cust_")
        dgvCustomer.Columns(1).HeaderText = "First Name"
        dgvCustomer.Columns(2).HeaderText = "Surname"
    End Sub


    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        Dim query As String

        Select Case cbCriteriaCustomer.Text
            Case "by Customer ID"
                query = "Convert(Customer_ID, System.String) LIKE '%" + tbQueryCustomer.Text + "%'"
            Case "by Customer Name"
                query = "Cust_FName LIKE '%" + tbQueryCustomer.Text + "%'"
            Case "by Customer City"
                query = "Cust_City LIKE '%" + tbQueryCustomer.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            CustomerTableBindingSource.RemoveFilter()
        Else
            CustomerTableBindingSource.Filter = query
        End If
    End Sub
    Private Sub tbQueryCustomer_Enter(sender As Object, e As EventArgs) Handles tbQueryCustomer.Enter
        tbQueryCustomer.Text = ""
    End Sub


    Private Sub btnAddEditCustomer_Click(sender As Object, e As EventArgs) Handles btnAddEditCustomer.Click
        If Not btnAddEditCustomer.Text = "Cancel" Then
            dgvCustomer.ReadOnly = False
            dgvCustomer.AllowUserToAddRows = True
            dgvCustomer.GridColor = Color.Crimson
            btnAddEditCustomer.Text = "Cancel"
            btnAddEditCustomer.Image = My.Resources._return
            btnAddEditCustomer.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveCustomer.Enabled = False
            MsgBox("Add new customer, or edit existing customers!")
        Else
            dgvCustomer.ReadOnly = True
            dgvCustomer.AllowUserToAddRows = False
            dgvCustomer.GridColor = Color.Gray
            btnAddEditCustomer.Text = "Add New/Edit Customers"
            btnAddEditCustomer.Image = My.Resources.pencil96
            btnAddEditCustomer.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveCustomer.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecspecDataset.CustomerTable)

        End If
    End Sub

    Private Sub btnRemoveCustomer_Click(sender As Object, e As EventArgs) Handles btnRemoveCustomer.Click
        If Not btnRemoveCustomer.Text = "Cancel" Then
            dgvCustomer.ReadOnly = False
            dgvCustomer.AllowUserToDeleteRows = True
            dgvCustomer.GridColor = Color.Crimson
            btnRemoveCustomer.Text = "Cancel"
            btnRemoveCustomer.Image = My.Resources._return
            btnRemoveCustomer.ImageAlign = ContentAlignment.TopCenter
            btnAddEditCustomer.Enabled = False
            MsgBox("Select customers then press delete key! Click on the Save button when done!")
        Else
            btnRemoveCustomer.Text = "Remove"
            dgvCustomer.ReadOnly = True
            dgvCustomer.AllowUserToDeleteRows = False
            dgvCustomer.GridColor = Color.Gray
            btnRemoveCustomer.Image = My.Resources.bin_red_full_icon
            btnRemoveCustomer.ImageAlign = ContentAlignment.TopCenter
            btnAddEditCustomer.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecspecDataset.CustomerTable)
        End If
    End Sub

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        If btnAddEditCustomer.Text = "Cancel" Or btnRemoveCustomer.Text = "Cancel" Then
            CustomerTableBindingSource.EndEdit()
            Try
                CustomerTableTableAdapter.Update(RecspecDataset.CustomerTable)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            dgvCustomer.ReadOnly = True
            dgvCustomer.AllowUserToAddRows = False
            dgvCustomer.AllowUserToDeleteRows = False
            dgvCustomer.GridColor = Color.Gray
            btnAddEditCustomer.Image = My.Resources.pencil96
            btnAddEditCustomer.ImageAlign = ContentAlignment.TopCenter
            btnAddEditCustomer.Text = "Add New/Edit Customers"
            btnAddEditCustomer.Enabled = True

            btnRemoveCustomer.Image = My.Resources.bin_red_full_icon
            btnRemoveCustomer.ImageAlign = ContentAlignment.TopCenter
            btnRemoveCustomer.Text = "Remove"
            btnRemoveCustomer.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecspecDataset.CustomerTable)
        End If
    End Sub

#End Region



#Region "Payments tab"
    Private Sub Payment_Init()
        SetAllFormat(PaymentTab, flpPayment, tlpPayment, dgvPayment, "Cust_")

    End Sub

    Private Sub btnSearchPayment_Click(sender As Object, e As EventArgs) Handles btnSearchPayment.Click
        Dim query As String

        Select Case cbCriteriaPayment.Text
            Case "by Customer Payment ID"
                query = "Cust_Payment_ID LIKE '%" + tbQueryPayment.Text + "%'"
            Case "by Customer Payment Type"
                query = "Cust_Payment_Type LIKE '%" + tbQueryPayment.Text + "%'"
            Case "by Customer ID"
                query = "Convert(Customer_ID, System.String) LIKE '%" + tbQueryPayment.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            CustomerPaymentBindingSource.RemoveFilter()
        Else
            CustomerPaymentBindingSource.Filter = query
        End If
    End Sub
    Private Sub tbQueryPayment_Enter(sender As Object, e As EventArgs) Handles tbQueryPayment.Enter

        tbQueryPayment.Text = ""
    End Sub


    Private Sub btnAddEditPayment_Click(sender As Object, e As EventArgs) Handles btnAddEditPayment.Click
        If Not btnAddEditPayment.Text = "Cancel" Then
            dgvPayment.ReadOnly = False
            dgvPayment.AllowUserToAddRows = True
            dgvPayment.GridColor = Color.Crimson
            btnAddEditPayment.Text = "Cancel"
            btnAddEditPayment.Image = My.Resources._return
            btnAddEditPayment.ImageAlign = ContentAlignment.MiddleCenter
            btnRemovePayment.Enabled = False
            MsgBox("Add new customer payment, or edit existing customer payments!")
        Else
            dgvPayment.ReadOnly = True
            dgvPayment.AllowUserToAddRows = False
            dgvPayment.GridColor = Color.Gray
            btnAddEditPayment.Text = "Add New/Edit Customer Payments"
            btnAddEditPayment.Image = My.Resources.pencil96
            btnAddEditPayment.ImageAlign = ContentAlignment.MiddleCenter
            btnRemovePayment.Enabled = True
            Me.Customer_PaymentTableAdapter.Fill(Me.RecspecDataset.Customer_Payment)

        End If
    End Sub

    Private Sub btnRemovePayment_Click(sender As Object, e As EventArgs) Handles btnRemovePayment.Click
        If Not btnRemovePayment.Text = "Cancel" Then
            dgvPayment.ReadOnly = False
            dgvPayment.AllowUserToDeleteRows = True
            dgvPayment.GridColor = Color.Crimson
            btnRemovePayment.Text = "Cancel"
            btnRemovePayment.Image = My.Resources._return
            btnRemovePayment.ImageAlign = ContentAlignment.TopCenter
            btnAddEditPayment.Enabled = False
            MsgBox("Select customer payments then press delete key! Click on the Save button when done!")
        Else
            btnRemovePayment.Text = "Remove"
            dgvPayment.ReadOnly = True
            dgvPayment.AllowUserToDeleteRows = False
            dgvPayment.GridColor = Color.Gray
            btnRemovePayment.Image = My.Resources.bin_red_full_icon
            btnRemovePayment.ImageAlign = ContentAlignment.TopCenter
            btnAddEditPayment.Enabled = True
            Me.Customer_PaymentTableAdapter.Fill(Me.RecspecDataset.Customer_Payment)
        End If
    End Sub

    Private Sub btnSavePayment_Click(sender As Object, e As EventArgs) Handles btnSavePayment.Click
        If btnAddEditPayment.Text = "Cancel" Or btnRemovePayment.Text = "Cancel" Then
            CustomerPaymentBindingSource.EndEdit()
            Try
                Customer_PaymentTableAdapter.Update(RecspecDataset.Customer_Payment)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            dgvPayment.ReadOnly = True
            dgvPayment.AllowUserToAddRows = False
            dgvPayment.AllowUserToDeleteRows = False
            dgvPayment.GridColor = Color.Gray
            btnAddEditPayment.Image = My.Resources.pencil96
            btnAddEditPayment.ImageAlign = ContentAlignment.TopCenter
            btnAddEditPayment.Text = "Add New/Edit Customer Payments"
            btnAddEditPayment.Enabled = True

            btnRemovePayment.Image = My.Resources.bin_red_full_icon
            btnRemovePayment.ImageAlign = ContentAlignment.TopCenter
            btnRemovePayment.Text = "Remove"
            btnRemovePayment.Enabled = True
            Me.Customer_PaymentTableAdapter.Fill(Me.RecspecDataset.Customer_Payment)
        End If
    End Sub

#End Region











    Private Sub SetAllFormat(ByRef tpage As TabPage, ByRef pan As FlowLayoutPanel, ByRef searchBar As TableLayoutPanel, ByRef dgv As DataGridView, prefix As String)
        'position the search bar

        tpage.SuspendLayout()

        If (searchBar IsNot Nothing And pan IsNot Nothing) Then
            searchBar.Top = Me.ClientSize.Height * 0.25
            searchBar.Left = (Me.ClientSize.Width - searchBar.Width) / 2
        End If

        'dgv.SetBounds(66, 317, 1179, 396)

        dgv.Width = Me.ClientSize.Width * 0.9
        dgv.Left = Me.ClientSize.Width * 0.05
        dgv.Height = Me.ClientSize.Height * 0.5
        dgv.Top = Me.ClientSize.Height * 0.4



        'format column headers for display
        For Each i In dgv.Columns
            i.HeaderText = i.HeaderText.ToString.Replace(prefix, "").Replace("_", " ")
        Next
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersVisible = True
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToOrderColumns = False
        dgv.AllowUserToResizeColumns = True
        dgv.AllowUserToResizeRows = False

        'position the buttons
        If pan IsNot Nothing Then



            pan.Size = New Size(588, 146)
            pan.SetBounds((Me.ClientSize.Width - pan.Width) / 2,
                           Me.ClientSize.Height * 0.05,
                           pan.Width, pan.Height)


            'pan.Left = (Me.ClientSize.Width - pan.Size.Width) / 2
            'pan.Top = Me.ClientSize.Height * 0.05
        End If

        tpage.ResumeLayout()
        tpage.Invalidate()

    End Sub

    Private Sub SetFormat4Dbl(ByRef tpage As TabPage, ByRef searchBar As TableLayoutPanel, ByRef dgvTop As DataGridView, ByRef dgvBottom As DataGridView, prefixTop As String, prefixBottom As String)
        'format column headers for display
        For Each i In dgvTop.Columns
            i.HeaderText = i.HeaderText.ToString.Replace(prefixTop, "").Replace("_", " ")
        Next
        For Each i In dgvBottom.Columns
            i.HeaderText = i.HeaderText.ToString.Replace(prefixBottom, "").Replace("_", " ")
        Next

        dgvTop.Width = Me.ClientSize.Width * 0.9
        dgvTop.Height = Me.ClientSize.Height * 0.3
        dgvTop.Left = Me.ClientSize.Width * 0.05
        dgvTop.Top = Me.ClientSize.Height * 0.2

        dgvBottom.Width = Me.ClientSize.Width * 0.9
        dgvBottom.Height = Me.ClientSize.Height * 0.3
        dgvBottom.Left = Me.ClientSize.Width * 0.05
        dgvBottom.Top = Me.ClientSize.Height * 0.6


        searchBar.Top = Me.ClientSize.Height * 0.1
        searchBar.Left = (Me.ClientSize.Width - searchBar.Width) / 2

    End Sub














    Private Sub ManagerFormTabControl_Selected(sender As Object, e As TabControlEventArgs) Handles ManagerFormTabControl.Selected

        Select Case e.TabPage.Name
            Case "PaymentTab"
                Payment_Init()
            Case "ProductTab"
                Product_init()
            Case "SalesOrderTab"
                SalesOrder_Init()
            Case "POTab"
                PurchaseOrder_Init()
            Case "SupplierTab"
                Supplier_Init()
            Case "CustomerTab"
                Customer_Init()
            Case "EmployeeTab"
                Employee_Init()
            Case Else
                MsgBox("No such tab exist!")
        End Select

    End Sub

    Private Sub EmployeeTab_Enter(sender As Object, e As EventArgs) Handles EmployeeTab.Enter
        Employee_Init()
    End Sub



    Private Sub dgvSO_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSO.RowEnter
        'Dim soID = MenuForms.RecSpecDataset.Sale_Order.Rows.Item(e.RowIndex).Item("Sales_Order_ID").ToString
        'TA_SODetails.Fill(MenuForms.RecSpecDataset.SO_Details, "403")

    End Sub
End Class