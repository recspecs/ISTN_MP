Public Class SalesRep
    Private Sub SalesRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        Me.Sales_OrderTableAdapter.Fill(Me.RecSpecDataset.Sales_Order)

        Me.Sales_OrderTableAdapter.Fill(Me.RecSpecDataset.Sales_Order)

        Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        Me.Sale_ItemTableAdapter.Fill(Me.RecSpecDataset.Sale_Item)
        Me.Sales_OrderTableAdapter.Fill(Me.RecSpecDataset.Sales_Order)

        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        SetFormat4SO(SalesOrderTabRep, flpSO, tlpSO, dgvSO, dgvSODetails, "Cust_", "Prod_")


    End Sub


#Region "Sales Order Tab"


    Private Sub SalesOrder_Init()
        SetFormat4SO(SalesOrderTabRep, flpSO, tlpSO, dgvSO, dgvSODetails, "Cust_", "Prod_")
        dgvSO.Columns(3).HeaderText = "Customer"
        dgvSO.Columns(4).HeaderText = "Employee"

    End Sub


    Private Sub SetFormat4SO(ByRef tPage As TabPage, pan As FlowLayoutPanel, searchBar As TableLayoutPanel, ByRef dgvTop As DataGridView, ByRef dgvBottom As DataGridView, prefixTop As String, prefixBottom As String)

        tPage.SuspendLayout()

        'Layout dgvSO
        dgvTop.Width = Me.ClientSize.Width * 0.9
        dgvTop.Height = Me.ClientSize.Height * 0.28
        dgvTop.Left = Me.ClientSize.Width * 0.05
        dgvTop.Top = Me.ClientSize.Height * 0.28
        lblSO.Location = New Point(dgvSO.Left, dgvSO.Top - lblSO.Height - 2)
        'Layout dgvSODetails
        dgvBottom.Width = Me.ClientSize.Width * 0.9
        dgvBottom.Height = Me.ClientSize.Height * 0.28
        dgvBottom.Left = Me.ClientSize.Width * 0.05
        dgvBottom.Top = Me.ClientSize.Height * 0.6
        dgvBottom.AutoGenerateColumns = True
        dgvBottom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBottom.ReadOnly = True
        lblSODetails.Location = New Point(dgvBottom.Left, dgvBottom.Top - lblSODetails.Height - 2)

        'format column headers for display
        For Each i In dgvTop.Columns
            i.HeaderText = i.HeaderText.ToString.Replace(prefixTop, "").Replace("_", " ")
        Next
        For Each i In dgvBottom.Columns
            i.HeaderText = i.HeaderText.ToString.Replace(prefixBottom, "").Replace("_", " ")
        Next

        'Layout search bar and buttons
        searchBar.SetBounds((Me.ClientSize.Width - searchBar.Width) / 2, Me.ClientSize.Height * 0.2, 862, 60)
        flpSO.SetBounds((Me.ClientSize.Width - flpSO.Width) / 2, Me.ClientSize.Height * 0.01, 588, 146)



        'layout totals box
        tbSOTotal.Width = (dgvBottom.Width / dgvBottom.Columns.Count) - dgvBottom.RowHeadersWidth
        tbSOTotal.Height = 25
        flpSOTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpSOTotal.AutoSize = True
        flpSOTotal.Top = dgvBottom.Bottom + 5
        flpSOTotal.Left = dgvBottom.Left + dgvBottom.Width - flpSOTotal.Width



        tPage.ResumeLayout()
        tPage.Invalidate()

    End Sub








    Private Sub dgvSO_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSO.CellEnter

        'setup datasource and bind to Bottom dgv
        Dim soID = dgvSO.Rows(e.RowIndex).Cells("SalesOrderIDDataGridViewTextBoxColumn").Value.ToString()
        ProductTableAdapter.Fill(RecSpecDataset.Product)
        Sale_ItemTableAdapter.Fill(RecSpecDataset.Sale_Item)

        Dim inter = From i In RecSpecDataset.Sale_Item.AsEnumerable
                    Where i.Sale_Order_ID = soID
                    Select i.Sales_Item_Line_No, i.Sale_Order_ID, i.ProductRow.Product_Code, i.ProductRow.Prod_Name,
                i.Sale_Item_Qty, i.ProductRow.Prod_Categories, i.Sale_Item_Price

        dgvSODetails.DataSource = inter.ToList


        tbSOTotal.Text = dgvSO.Rows(dgvSO.CurrentCell.RowIndex).Cells("SaleTotalDataGridViewTextBoxColumn").Value.ToString()

    End Sub

    Private Sub btnSearchSO_Click(sender As Object, e As EventArgs) Handles btnSearchSO.Click
        Dim query As String = ""

        Select Case cbCriteriaSO.Text
            Case "By Sales Order ID"
                query = "Sales_Order_ID LIKE '%" + tbQuerySO.Text + "%'"
            Case "By Customer"
                query = "Cust_FName LIKE '%" + tbQuerySO.Text + "%'"
            Case "By Employee"
                query = "Emp_FName LIKE '%" + tbQuerySO.Text + "%'"
            Case Else
                query = ""
        End Select

        If String.IsNullOrWhiteSpace(query) Then
            SalesOrderBindingSource.RemoveFilter()
        Else
            SalesOrderBindingSource.Filter = query

        End If
    End Sub










#End Region


#Region "Product tab"

    Private Sub Product_init()
        SetAllFormat(ProductTabRep, flpProducts, tlpProduct, dgvProduct, "Prod_")
    End Sub

    Private Sub ProductTabRep_Enter(sender As Object, e As EventArgs) Handles ProductTabRep.Enter
        Product_init()
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
            btnAddEditProduct.Image = My.Resources.pencil961
            btnAddEditProduct.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveProduct.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

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
            btnRemoveProduct.Image = My.Resources.redbin296
            btnRemoveProduct.ImageAlign = ContentAlignment.TopCenter
            btnAddEditProduct.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        End If
    End Sub


    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        If btnAddEditSO.Text = "Cancel" Or btnRemoveProduct.Text = "Cancel" Then
            ProductBindingSource.EndEdit()
            Try
                ProductTableAdapter.Update(Me.RecSpecDataset.Product)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            dgvProduct.ReadOnly = True
            dgvProduct.AllowUserToAddRows = False
            dgvProduct.AllowUserToDeleteRows = False
            dgvProduct.GridColor = Color.Gray
            btnAddEditProduct.Image = My.Resources.pencil961
            btnAddEditProduct.ImageAlign = ContentAlignment.TopCenter
            btnAddEditProduct.Text = "Add New/Edit Products"
            btnAddEditProduct.Enabled = True

            btnRemoveProduct.Image = My.Resources.redbin296
            btnRemoveProduct.ImageAlign = ContentAlignment.TopCenter
            btnRemoveProduct.Text = "Remove"
            btnRemoveProduct.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        End If
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        Dim query As String

        Select Case cbCriteriaProduct.Text
            Case "By Product Code"
                query = "Product_Code LIKE '%" + tbQueryProduct.Text + "%'"
            Case "By Product Name"
                query = "Prod_Name LIKE '%" + tbQueryProduct.Text + "%'"
            Case "By Stock Level"
                query = "Prod_Stock_Level LIKE '" + tbQueryProduct.Text + "%'"
            Case "By Categories"
                query = "Prod_Categories LIKE '%" + tbQueryProduct.Text + "%'"
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

#Region "Customer tab"
    Private Sub Customer_Init()
        SetAllFormat(CustomerTabRep, flpCustomer, tlpCustomer, dgvCustomer, "Cust_")
        dgvCustomer.Columns(1).HeaderText = "First Name"
        dgvCustomer.Columns(2).HeaderText = "Surname"
    End Sub


    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        Dim query As String

        Select Case cbCriteriaCustomer.Text
            Case "By Customer ID"
                query = "Convert(Customer_ID, System.String) LIKE '" + tbQueryCustomer.Text + "%'"
            Case "By First Name"
                query = "Cust_FName LIKE '" + tbQueryCustomer.Text + "%'"
            Case "By Surname"
                query = "Cust_LName LIKE '" + tbQueryCustomer.Text + "%'"
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
            btnAddEditCustomer.Image = My.Resources.pencil961
            btnAddEditCustomer.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveCustomer.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)

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
            btnRemoveCustomer.Image = My.Resources.redbin296
            btnRemoveCustomer.ImageAlign = ContentAlignment.TopCenter
            btnAddEditCustomer.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        End If
    End Sub

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        If btnAddEditCustomer.Text = "Cancel" Or btnRemoveCustomer.Text = "Cancel" Then
            CustomerTableBindingSource.EndEdit()
            Try
                CustomerTableTableAdapter.Update(Me.RecSpecDataset.CustomerTable)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            dgvCustomer.ReadOnly = True
            dgvCustomer.AllowUserToAddRows = False
            dgvCustomer.AllowUserToDeleteRows = False
            dgvCustomer.GridColor = Color.Gray
            btnAddEditCustomer.Image = My.Resources.pencil961
            btnAddEditCustomer.ImageAlign = ContentAlignment.TopCenter
            btnAddEditCustomer.Text = "Add New/Edit Customers"
            btnAddEditCustomer.Enabled = True

            btnRemoveCustomer.Image = My.Resources.redbin296
            btnRemoveCustomer.ImageAlign = ContentAlignment.TopCenter
            btnRemoveCustomer.Text = "Remove"
            btnRemoveCustomer.Enabled = True
            Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        End If
    End Sub

#End Region



    Private Sub SalesRepTabControl_Selected(sender As Object, e As TabControlEventArgs) Handles SalesRepTabControl.Selected
        Select Case e.TabPage.Name
            Case "ProductTabRep"
                Product_init()
            Case "SalesOrderTabRep"
                SalesOrder_Init()
            Case "CustomerTabRep"
                Customer_Init()
            Case Else
                MsgBox("No such tab exist!")
        End Select

    End Sub



    Private Sub SetAllFormat(ByRef tPage As TabPage, ByRef pan As FlowLayoutPanel, ByRef searchBar As TableLayoutPanel, ByRef dgv As DataGridView, prefix As String)
        'position the search bar

        tPage.SuspendLayout()

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

        End If

        tPage.ResumeLayout()
        tPage.Invalidate()

    End Sub









    Private Sub tbQuerySO_KeyDown(sender As Object, e As KeyEventArgs) Handles tbQuerySO.KeyDown, tbQueryProduct.KeyDown, tbQueryCustomer.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim tbSender = TryCast(sender, TextBox)

            Select Case tbSender.Name
                Case "tbQuerySO" : btnSearchSO.PerformClick() : e.Handled = True : e.SuppressKeyPress = True
                Case "tbQueryProduct" : btnSearchProduct.PerformClick() : e.Handled = True : e.SuppressKeyPress = True
                Case "tbQueryCustomer" : btnSearchCustomer.PerformClick() : e.Handled = True : e.SuppressKeyPress = True
            End Select
        End If
    End Sub



End Class