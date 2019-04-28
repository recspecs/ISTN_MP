Public Class GenManager

    Public UserFormSize = My.Settings.FormSize

    Private Sub GenManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)
        Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        Me.Purchase_ItemTableAdapter.Fill(Me.RecSpecDataset.Purchase_Item)
        Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
        Me.Sales_OrderTableAdapter.Fill(Me.RecSpecDataset.Sales_Order)
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)


        Me.Size = UserFormSize
        Me.CenterToScreen()

    End Sub


#Region "Employee tab"
    Private Sub Employee_Enter(sender As Object, e As EventArgs) Handles EmployeeTab.Enter

        SetDGVFormat(flpEmployee, dgvEmployee, "Emp_")
        dgvEmployee.Columns(1).HeaderText = "First Name"
        dgvEmployee.Columns(2).HeaderText = "Surname"


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
            Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)

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
            Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveEmployee.Click
        If btnAddEditEmployee.Text = "Cancel" Or btnRemoveEmployee.Text = "Cancel" Then
            EmployeeBindingSource.EndEdit()
            Try
                EmployeeTableAdapter.Update(RecSpecDataset.Employee)
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
            Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)

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


    Private Sub btnAddEdit1_Click(sender As Object, e As EventArgs)
        If Not btnAddEditEmployee.Text = "Cancel" Then
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
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        End If
    End Sub

    Private Sub btnRemove1_Click(sender As Object, e As EventArgs)
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
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        End If
    End Sub



    Private Sub btnSave1_Click(sender As Object, e As EventArgs)
        If btnAddEditPO.Text = "Cancel" Or btnRemoveProduct.Text = "Cancel" Then
            ProductBindingSource.EndEdit()
            Try
                ProductTableAdapter.Update(RecSpecDataset.Product)
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
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        End If
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs)
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


    Private Sub tbQueryProduct_Enter(sender As Object, e As EventArgs)
        tbQueryProduct.Text = ""
    End Sub




#End Region

#Region "Sales Order tab"



    Private Sub tbQuerySO_Enter(sender As Object, e As EventArgs)
        tbQuerySO.Text = ""
    End Sub


    Private Sub btnSearchSO_Click(sender As Object, e As EventArgs)
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




#Region "Supplier tab"


    Private Sub tbQuerySupplier_Enter(sender As Object, e As EventArgs)
        tbQuerySupplier.Text = ""
    End Sub

    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs)
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


    Private Sub btnAddEditSupplier_Click(sender As Object, e As EventArgs)
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
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)

        End If
    End Sub

    Private Sub btnRemoveSupplier_Click(sender As Object, e As EventArgs)
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
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        End If
    End Sub

    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs)
        If btnAddEditSupplier.Text = "Cancel" Or btnRemoveSupplier.Text = "Cancel" Then
            SupplierBindingSource.EndEdit()
            Try
                SupplierTableAdapter.Update(RecSpecDataset.Supplier)
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
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        End If
    End Sub

#End Region




#Region "Customer tab"

    Private Sub S6_Click(sender As Object, e As EventArgs)
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
    Private Sub tbQueryCustomer_Enter(sender As Object, e As EventArgs)
        tbQueryCustomer.Text = ""
    End Sub


    Private Sub btnAddEditCustomer_Click(sender As Object, e As EventArgs)
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
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)

        End If
    End Sub

    Private Sub btnRemoveCustomer_Click(sender As Object, e As EventArgs)
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
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        End If
    End Sub

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs)
        If btnAddEditCustomer.Text = "Cancel" Or btnRemoveCustomer.Text = "Cancel" Then
            CustomerTableBindingSource.EndEdit()
            Try
                CustomerTableTableAdapter.Update(RecSpecDataset.CustomerTable)
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
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        End If
    End Sub

#End Region



#Region "Payments tab"

    Private Sub btnSearchPayment_Click(sender As Object, e As EventArgs)
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
    Private Sub tbQueryPayment_Enter(sender As Object, e As EventArgs)
        tbQueryPayment.Text = ""
    End Sub


    Private Sub btnAddEditPayment_Click(sender As Object, e As EventArgs)
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
            Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)

        End If
    End Sub

    Private Sub btnRemovePayment_Click(sender As Object, e As EventArgs)
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
            Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)
        End If
    End Sub

    Private Sub btnSavePayment_Click(sender As Object, e As EventArgs)
        If btnAddEditPayment.Text = "Cancel" Or btnRemovePayment.Text = "Cancel" Then
            CustomerPaymentBindingSource.EndEdit()
            Try
                Customer_PaymentTableAdapter.Update(RecSpecDataset.Customer_Payment)
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
            Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)
        End If
    End Sub

#End Region











    Private Sub SetDGVFormat(ByRef pan As Panel, ByRef dgv As DataGridView, prefix As String)



        dgv.Width = dgv.Parent.Width * 0.9
        dgv.Left = dgv.Parent.Width * 0.05

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
            pan.Left = (pan.Parent.Width - pan.Width) / 2
        End If






    End Sub




    Private Sub Products_Enter(sender As Object, e As EventArgs) Handles ProductTab.Enter
        SetDGVFormat(flpProducts, dgvProduct, "Prod_")

    End Sub

    Private Sub SalesOrder_Enter(sender As Object, e As EventArgs) Handles SalesOrderTab.Enter
        SetDGVFormat(Nothing, dgvSO, "Cust_")
        dgvSO.Columns(3).HeaderText = "Customer"
        dgvSO.Columns(4).HeaderText = "Employee"

    End Sub

    Private Sub Supplier_Enter(sender As Object, e As EventArgs) Handles SupplierTab.Enter
        SetDGVFormat(flpSupplier, dgvSupplier, "Supp_")
    End Sub

    Private Sub PurchaseOrder_Enter(sender As Object, e As EventArgs) Handles POTab.Enter
        SetDGVFormat(flpPO, dgvPO, "ZZZ")
        SetDGVFormat(Nothing, DGV2_2, "ZZZ")
    End Sub

    Private Sub Customer_Enter(sender As Object, e As EventArgs) Handles Customer.Enter
        SetDGVFormat(flpCustomer, dgvCustomer, "Cust_")
        dgvCustomer.Columns(1).HeaderText = "First Name"
        dgvCustomer.Columns(2).HeaderText = "Surname"
    End Sub

    Private Sub Payment_Enter(sender As Object, e As EventArgs) Handles Payment.Enter
        SetDGVFormat(flpPayment, dgvPayment, "Cust_")
    End Sub

    Private Sub Customer_Click(sender As Object, e As EventArgs) Handles Customer.Click

    End Sub




End Class