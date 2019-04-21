Public Class GenManager
    Private Sub Label58_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV3.CellContentClick

    End Sub

    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles Payment.Click

    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDGV.CellContentClick

    End Sub

    Private Sub SalesOrder_Click(sender As Object, e As EventArgs) Handles SalesOrder.Click

    End Sub

    Private Sub GenManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Customer_Payment' table. You can move, or remove it, as needed.
        Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)
        'TODO: This line of code loads data into the 'RecSpecDataset.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        'TODO: This line of code loads data into the 'RecSpecDataset.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Item' table. You can move, or remove it, as needed.
        Me.Purchase_ItemTableAdapter.Fill(Me.RecSpecDataset.Purchase_Item)
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Order' table. You can move, or remove it, as needed.
        Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
        'TODO: This line of code loads data into the 'RecSpecDataset.Sales_Order' table. You can move, or remove it, as needed.
        Me.Sales_OrderTableAdapter.Fill(Me.RecSpecDataset.Sales_Order)
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        'TODO: This line of code loads data into the 'RecSpecDataset.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not Button11.Text = "Cancel" Then
            EmployeeDGV.ReadOnly = False
            EmployeeDGV.AllowUserToAddRows = True
            EmployeeDGV.GridColor = Color.Crimson
            Button11.Text = "Cancel"
            Button11.Image = My.Resources._return
            Button11.ImageAlign = ContentAlignment.MiddleCenter
            Button6.Enabled = False
            MsgBox("Add new employee, or edit existing employees!")
        Else
            EmployeeDGV.ReadOnly = True
            EmployeeDGV.AllowUserToAddRows = False
            EmployeeDGV.GridColor = Color.Gray
            Button11.Text = "Add New/Edit Employees"
            Button11.Image = My.Resources.Pencil_icon
            Button11.ImageAlign = ContentAlignment.MiddleCenter
            Button6.Enabled = True
            Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not Button6.Text = "Cancel" Then
            EmployeeDGV.ReadOnly = False
            EmployeeDGV.AllowUserToDeleteRows = True
            EmployeeDGV.GridColor = Color.Crimson
            Button6.Text = "Cancel"
            Button6.Image = My.Resources._return
            Button6.ImageAlign = ContentAlignment.TopCenter
            Button11.Enabled = False
            MsgBox("Select employees then press delete key! Click on the Save button when done!")
        Else
            Button6.Text = "Remove"
            EmployeeDGV.ReadOnly = True
            EmployeeDGV.AllowUserToDeleteRows = False
            EmployeeDGV.GridColor = Color.Gray
            Button6.Image = My.Resources.bin_red_full_icon
            Button6.ImageAlign = ContentAlignment.TopCenter
            Button11.Enabled = True
            Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button11.Text = "Cancel" Or Button6.Text = "Cancel" Then
            EmployeeBindingSource.EndEdit()
            Try
                EmployeeTableAdapter.Update(RecSpecDataset.Employee)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            EmployeeDGV.ReadOnly = True
            EmployeeDGV.AllowUserToAddRows = False
            EmployeeDGV.AllowUserToDeleteRows = False
            EmployeeDGV.GridColor = Color.Gray
            Button11.Image = My.Resources.Pencil_icon
            Button11.ImageAlign = ContentAlignment.TopCenter
            Button11.Text = "Add New/Edit Employees"
            Button11.Enabled = True

            Button6.Image = My.Resources.bin_red_full_icon
            Button6.ImageAlign = ContentAlignment.TopCenter
            Button6.Text = "Remove"
            Button6.Enabled = True
            Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)

        End If
    End Sub

    Private Sub Update1_Click(sender As Object, e As EventArgs) Handles Update1.Click
        If Not Update1.Text = "Cancel" Then
            DGV1.ReadOnly = False
            DGV1.AllowUserToAddRows = True
            DGV1.GridColor = Color.Crimson
            Update1.Text = "Cancel"
            Update1.Image = My.Resources._return
            Update1.ImageAlign = ContentAlignment.MiddleCenter
            Remove1.Enabled = False
            MsgBox("Add new product, or edit existing products!")
        Else
            DGV1.ReadOnly = True
            DGV1.AllowUserToAddRows = False
            DGV1.GridColor = Color.Gray
            Update1.Text = "Add New/Edit Products"
            Update1.Image = My.Resources.Pencil_icon
            Update1.ImageAlign = ContentAlignment.MiddleCenter
            Remove1.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        End If
    End Sub

    Private Sub Remove1_Click(sender As Object, e As EventArgs) Handles Remove1.Click
        If Not Remove1.Text = "Cancel" Then
            DGV1.ReadOnly = False
            DGV1.AllowUserToDeleteRows = True
            DGV1.GridColor = Color.Crimson
            Remove1.Text = "Cancel"
            Remove1.Image = My.Resources._return
            Remove1.ImageAlign = ContentAlignment.TopCenter
            Update1.Enabled = False
            MsgBox("Select products then press delete key! Click on the Save button when done!")
        Else
            Remove1.Text = "Remove"
            DGV1.ReadOnly = True
            DGV1.AllowUserToDeleteRows = False
            DGV1.GridColor = Color.Gray
            Remove1.Image = My.Resources.bin_red_full_icon
            Remove1.ImageAlign = ContentAlignment.TopCenter
            Update1.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        End If
    End Sub

    Private Sub Save1_Click(sender As Object, e As EventArgs) Handles Save1.Click
        If Update1.Text = "Cancel" Or Remove1.Text = "Cancel" Then
            ProductBindingSource.EndEdit()
            Try
                ProductTableAdapter.Update(RecSpecDataset.Product)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            DGV1.ReadOnly = True
            DGV1.AllowUserToAddRows = False
            DGV1.AllowUserToDeleteRows = False
            DGV1.GridColor = Color.Gray
            Update1.Image = My.Resources.Pencil_icon
            Update1.ImageAlign = ContentAlignment.TopCenter
            Update1.Text = "Add New/Edit Products"
            Update1.Enabled = True

            Remove1.Image = My.Resources.bin_red_full_icon
            Remove1.ImageAlign = ContentAlignment.TopCenter
            Remove1.Text = "Remove"
            Remove1.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        End If
    End Sub

    Private Sub Update3_Click(sender As Object, e As EventArgs) Handles Update3.Click
        If Not Update3.Text = "Cancel" Then
            DGV3.ReadOnly = False
            DGV3.AllowUserToAddRows = True
            DGV3.GridColor = Color.Crimson
            Update3.Text = "Cancel"
            Update3.Image = My.Resources._return
            Update3.ImageAlign = ContentAlignment.MiddleCenter
            Remove3.Enabled = False
            MsgBox("Add new supplier, or edit existing suppliers!")
        Else
            DGV3.ReadOnly = True
            DGV3.AllowUserToAddRows = False
            DGV3.GridColor = Color.Gray
            Update3.Text = "Add New/Edit Suppliers"
            Update3.Image = My.Resources.Pencil_icon
            Update3.ImageAlign = ContentAlignment.MiddleCenter
            Remove3.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)

        End If
    End Sub

    Private Sub Remove3_Click(sender As Object, e As EventArgs) Handles Remove3.Click
        If Not Remove3.Text = "Cancel" Then
            DGV3.ReadOnly = False
            DGV3.AllowUserToDeleteRows = True
            DGV3.GridColor = Color.Crimson
            Remove3.Text = "Cancel"
            Remove3.Image = My.Resources._return
            Remove3.ImageAlign = ContentAlignment.TopCenter
            Update3.Enabled = False
            MsgBox("Select suppliers then press delete key! Click on the Save button when done!")
        Else
            Remove3.Text = "Remove"
            DGV3.ReadOnly = True
            DGV3.AllowUserToDeleteRows = False
            DGV3.GridColor = Color.Gray
            Remove3.Image = My.Resources.bin_red_full_icon
            Remove3.ImageAlign = ContentAlignment.TopCenter
            Update3.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        End If
    End Sub

    Private Sub Save3_Click(sender As Object, e As EventArgs) Handles Save3.Click
        If Update3.Text = "Cancel" Or Remove3.Text = "Cancel" Then
            SupplierBindingSource.EndEdit()
            Try
                SupplierTableAdapter.Update(RecSpecDataset.Supplier)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            DGV3.ReadOnly = True
            DGV3.AllowUserToAddRows = False
            DGV3.AllowUserToDeleteRows = False
            DGV3.GridColor = Color.Gray
            Update3.Image = My.Resources.Pencil_icon
            Update3.ImageAlign = ContentAlignment.TopCenter
            Update3.Text = "Add New/Edit Suppliers"
            Update3.Enabled = True

            Remove3.Image = My.Resources.bin_red_full_icon
            Remove3.ImageAlign = ContentAlignment.TopCenter
            Remove3.Text = "Remove"
            Remove3.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        End If
    End Sub

    Private Sub Update4_Click(sender As Object, e As EventArgs) Handles Update4.Click
        If Not Update4.Text = "Cancel" Then
            DGV4.ReadOnly = False
            DGV4.AllowUserToAddRows = True
            DGV4.GridColor = Color.Crimson
            Update4.Text = "Cancel"
            Update4.Image = My.Resources._return
            Update4.ImageAlign = ContentAlignment.MiddleCenter
            Remove4.Enabled = False
            MsgBox("Add new customer, or edit existing customers!")
        Else
            DGV4.ReadOnly = True
            DGV4.AllowUserToAddRows = False
            DGV4.GridColor = Color.Gray
            Update4.Text = "Add New/Edit Customers"
            Update4.Image = My.Resources.Pencil_icon
            Update4.ImageAlign = ContentAlignment.MiddleCenter
            Remove4.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)

        End If
    End Sub

    Private Sub Remove4_Click(sender As Object, e As EventArgs) Handles Remove4.Click
        If Not Remove4.Text = "Cancel" Then
            DGV4.ReadOnly = False
            DGV4.AllowUserToDeleteRows = True
            DGV4.GridColor = Color.Crimson
            Remove4.Text = "Cancel"
            Remove4.Image = My.Resources._return
            Remove4.ImageAlign = ContentAlignment.TopCenter
            Update4.Enabled = False
            MsgBox("Select customers then press delete key! Click on the Save button when done!")
        Else
            Remove4.Text = "Remove"
            DGV4.ReadOnly = True
            DGV4.AllowUserToDeleteRows = False
            DGV4.GridColor = Color.Gray
            Remove4.Image = My.Resources.bin_red_full_icon
            Remove4.ImageAlign = ContentAlignment.TopCenter
            Update4.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        End If
    End Sub

    Private Sub Save4_Click(sender As Object, e As EventArgs) Handles Save4.Click
        If Update4.Text = "Cancel" Or Remove4.Text = "Cancel" Then
            CustomerTableBindingSource.EndEdit()
            Try
                CustomerTableTableAdapter.Update(RecSpecDataset.CustomerTable)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            DGV4.ReadOnly = True
            DGV4.AllowUserToAddRows = False
            DGV4.AllowUserToDeleteRows = False
            DGV4.GridColor = Color.Gray
            Update4.Image = My.Resources.Pencil_icon
            Update4.ImageAlign = ContentAlignment.TopCenter
            Update4.Text = "Add New/Edit Customers"
            Update4.Enabled = True

            Remove4.Image = My.Resources.bin_red_full_icon
            Remove4.ImageAlign = ContentAlignment.TopCenter
            Remove4.Text = "Remove"
            Remove4.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        End If
    End Sub

    Private Sub Update5_Click(sender As Object, e As EventArgs) Handles Update5.Click
        If Not Update5.Text = "Cancel" Then
            DGV5.ReadOnly = False
            DGV5.AllowUserToAddRows = True
            DGV5.GridColor = Color.Crimson
            Update5.Text = "Cancel"
            Update5.Image = My.Resources._return
            Update5.ImageAlign = ContentAlignment.MiddleCenter
            Remove5.Enabled = False
            MsgBox("Add new customer payment, or edit existing customer payments!")
        Else
            DGV5.ReadOnly = True
            DGV5.AllowUserToAddRows = False
            DGV5.GridColor = Color.Gray
            Update5.Text = "Add New/Edit Customer Payments"
            Update5.Image = My.Resources.Pencil_icon
            Update5.ImageAlign = ContentAlignment.MiddleCenter
            Remove5.Enabled = True
            Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)

        End If
    End Sub

    Private Sub Remove5_Click(sender As Object, e As EventArgs) Handles Remove5.Click
        If Not Remove5.Text = "Cancel" Then
            DGV5.ReadOnly = False
            DGV5.AllowUserToDeleteRows = True
            DGV5.GridColor = Color.Crimson
            Remove5.Text = "Cancel"
            Remove5.Image = My.Resources._return
            Remove5.ImageAlign = ContentAlignment.TopCenter
            Update5.Enabled = False
            MsgBox("Select customer payments then press delete key! Click on the Save button when done!")
        Else
            Remove5.Text = "Remove"
            DGV5.ReadOnly = True
            DGV5.AllowUserToDeleteRows = False
            DGV5.GridColor = Color.Gray
            Remove5.Image = My.Resources.bin_red_full_icon
            Remove5.ImageAlign = ContentAlignment.TopCenter
            Update5.Enabled = True
            Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)
        End If
    End Sub

    Private Sub Save5_Click(sender As Object, e As EventArgs) Handles Save5.Click
        If Update5.Text = "Cancel" Or Remove5.Text = "Cancel" Then
            CustomerPaymentBindingSource.EndEdit()
            Try
                Customer_PaymentTableAdapter.Update(RecSpecDataset.Customer_Payment)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            DGV5.ReadOnly = True
            DGV5.AllowUserToAddRows = False
            DGV5.AllowUserToDeleteRows = False
            DGV5.GridColor = Color.Gray
            Update5.Image = My.Resources.Pencil_icon
            Update5.ImageAlign = ContentAlignment.TopCenter
            Update5.Text = "Add New/Edit Customer Payments"
            Update5.Enabled = True

            Remove5.Image = My.Resources.bin_red_full_icon
            Remove5.ImageAlign = ContentAlignment.TopCenter
            Remove5.Text = "Remove"
            Remove5.Enabled = True
            Me.Customer_PaymentTableAdapter.Fill(Me.RecSpecDataset.Customer_Payment)
        End If
    End Sub

    Private Sub S2_Click(sender As Object, e As EventArgs) Handles S2.Click
        Dim query As String

        Select Case CB2.Text
            Case "by Product Code"
                query = "Product_Code LIKE '%" + QB2.Text + "%'"
            Case "by Product Name"
                query = "Prod_Name LIKE '%" + QB2.Text + "%'"
            Case "by Stock level"
                query = "Prod_Stock_Level LIKE '" + QB2.Text + "'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            ProductBindingSource.RemoveFilter()
        Else
            ProductBindingSource.Filter = query
        End If
    End Sub

    Private Sub QB2_Enter(sender As Object, e As EventArgs) Handles QB2.Enter
        QB2.Text = ""
    End Sub

    Private Sub S1_Click(sender As Object, e As EventArgs) Handles S1.Click
        Dim query As String

        Select Case CB1.Text
            Case "by Employee ID"
                query = "CAST(Employee_ID as CHAR) LIKE '%" + QB1.Text + "%'"
            Case "by Employee Name"
                query = "Emp_FName LIKE '%" + QB1.Text + "%'"
            Case "by Employee Type"
                query = "Emp_Type LIKE '%" + QB1.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            EmployeeBindingSource.RemoveFilter()
        Else
            EmployeeBindingSource.Filter = query
        End If
    End Sub
    Private Sub QB1_Enter(sender As Object, e As EventArgs) Handles QB1.Enter
        QB1.Text = ""
    End Sub

    Private Sub S3_Click(sender As Object, e As EventArgs) Handles S3.Click
        Dim query As String

        Select Case CB3.Text
            Case "by Sales Order ID"
                query = "Sales_Order_ID LIKE '%" + QB3.Text + "%'"
            Case "by Product Code"
                query = "Product_Code LIKE '%" + QB3.Text + "%'"
            Case "by Customer ID"
                query = "Customer_ID LIKE '%" + QB3.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            SalesOrderBindingSource.RemoveFilter()
        Else
            SalesOrderBindingSource.Filter = query
        End If
    End Sub
    Private Sub QB3_Enter(sender As Object, e As EventArgs) Handles QB3.Enter
        QB3.Text = ""
    End Sub
    Private Sub S5_Click(sender As Object, e As EventArgs) Handles S3.Click
        Dim query As String

        Select Case CB5.Text
            Case "by Supplier ID"
                query = "Suppier_ID LIKE '%" + QB5.Text + "%'"
            Case "by Supplier Name"
                query = "Supp_Name LIKE '%" + QB5.Text + "%'"
            Case "by Supplier City"
                query = "Supp_City LIKE '%" + QB5.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            SupplierBindingSource.RemoveFilter()
        Else
            SupplierBindingSource.Filter = query
        End If
    End Sub
    Private Sub QB5_Enter(sender As Object, e As EventArgs) Handles QB5.Enter
        QB5.Text = ""
    End Sub
    Private Sub S6_Click(sender As Object, e As EventArgs) Handles S6.Click
        Dim query As String

        Select Case CB6.Text
            Case "by Customer ID"
                query = "Customer_ID LIKE '%" + QB6.Text + "%'"
            Case "by Customer Name"
                query = "Cust_FName LIKE '%" + QB6.Text + "%'"
            Case "by Customer City"
                query = "Cust_City LIKE '%" + QB6.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            CustomerTableBindingSource.RemoveFilter()
        Else
            CustomerTableBindingSource.Filter = query
        End If
    End Sub
    Private Sub QB6_Enter(sender As Object, e As EventArgs) Handles QB6.Enter
        QB6.Text = ""
    End Sub
    Private Sub S7_Click(sender As Object, e As EventArgs) Handles S7.Click
        Dim query As String

        Select Case CB7.Text
            Case "by Customer Payment ID"
                query = "Cust_Payment_ID LIKE '%" + QB7.Text + "%'"
            Case "by Customer Payment Type"
                query = "Cust_Payment_Type LIKE '%" + QB7.Text + "%'"
            Case "by Customer ID"
                query = "Customer_ID LIKE '%" + QB7.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            CustomerPaymentBindingSource.RemoveFilter()
        Else
            CustomerPaymentBindingSource.Filter = query
        End If
    End Sub
    Private Sub QB7_Enter(sender As Object, e As EventArgs) Handles QB7.Enter
        QB7.Text = ""
    End Sub
End Class