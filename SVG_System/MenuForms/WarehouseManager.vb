Public Class WarehouseManager


    Private Sub WarehouseManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Item' table. You can move, or remove it, as needed.
        Me.Purchase_ItemTableAdapter.Fill(Me.RecSpecDataset.Purchase_Item)
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Order' table. You can move, or remove it, as needed.
        Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
        'TODO: This line of code loads data into the 'RecSpecDataset.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        Me.DoubleBuffered = True
        Me.CenterToScreen()
    End Sub

#Region "Product tab"

    Private Sub Product_init()
        SetAllFormat(WMProductsTab, flpProducts, tlpProduct, dgvProduct, "Prod_")

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
        If btnAddEditProduct.Text = "Cancel" Or btnRemoveProduct.Text = "Cancel" Then
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

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click, tbQueryProduct.TextChanged
        Dim query As String

        Select Case cbCriteriaProduct.Text
            Case "By Product Code"
                query = "Product_Code LIKE '%" + tbQueryProduct.Text + "%'"
            Case "By Product Name"
                query = "Prod_Name LIKE '%" + tbQueryProduct.Text + "%'"
            Case "By Stock Level"
                query = "Prod_Stock_Level LIKE '" + tbQueryProduct.Text + "%'"
            Case "By Categories"
                query = "Prod_Categories LIKE '" + tbQueryProduct.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            ProductBindingSource.RemoveFilter()
        Else
            ProductBindingSource.Filter = query
        End If
    End Sub




#End Region

#Region "Purchase Order Tab"
    Private Sub PurchaseOrder_Init()

        'Size and position the buttons and search bar
        'flpPO.SetBounds((Me.ClientSize.Width - flpPO.Width) / 2, Me.ClientSize.Height * 0.01, 588, 146)
        tlpPO.SetBounds((Me.ClientSize.Width - tlpPO.Width) / 2, Me.ClientSize.Height * 0.2, 862, 60)

        'size and position top dgv
        dgvPO.Width = Me.ClientSize.Width * 0.9
        dgvPO.Height = Me.ClientSize.Height * 0.28
        dgvPO.Left = Me.ClientSize.Width * 0.05
        dgvPO.Top = Me.ClientSize.Height * 0.28
        lblPO.Location = New Point(dgvPO.Left, dgvPO.Top - lblPO.Height - 2)
        'size and position bottom dgv
        dgvPOD.Width = Me.ClientSize.Width * 0.9
        dgvPOD.Height = Me.ClientSize.Height * 0.28
        dgvPOD.Left = Me.ClientSize.Width * 0.05
        dgvPOD.Top = Me.ClientSize.Height * 0.6
        dgvPOD.AutoGenerateColumns = True
        dgvPOD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPOD.ReadOnly = True
        lblPoDetails.Location = New Point(dgvPOD.Left, dgvPOD.Top - lblPO.Height - 2)
        '
        For Each i In dgvPO.Columns
            i.HeaderText = i.HeaderText.ToString.Replace("PO_", "").Replace("_", " ")
        Next
        For Each i In dgvPOD.Columns
            i.HeaderText = i.HeaderText.ToString.Replace("_", " ")
        Next

        tbPOTotal.Width = (dgvPOD.Width / 7) - dgvPOD.RowHeadersWidth
        tbPOTotal.Height = 25
        flpPOTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpPOTotal.AutoSize = True
        flpPOTotal.Top = dgvPOD.Bottom + 5
        flpPOTotal.Left = dgvPOD.Left + dgvPOD.Width - flpPOTotal.Width





    End Sub


    Private Sub dgvPO_EditingControlShowing(ByVal sender As System.Object, ByVal e As DataGridViewEditingControlShowingEventArgs)

        If dgvPO.CurrentCell.OwningColumn.HeaderText = "Customer" Then

            Dim query = (From c In RecSpecDataset.CustomerTable.AsEnumerable()
                         Select c.Field(Of String)("Cust_FName")).ToArray()

            Dim autotext As TextBox = TryCast(e.Control, TextBox)
            If autotext IsNot Nothing Then
                autotext.AutoCompleteMode = AutoCompleteMode.Suggest
                autotext.AutoCompleteSource = AutoCompleteSource.CustomSource
                Dim atCols As New AutoCompleteStringCollection()
                atCols.AddRange(query)
                autotext.AutoCompleteCustomSource = atCols
            End If
        End If
    End Sub


    Private Sub dgvPO_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPO.CellEnter
        Dim poID = dgvPO.Rows(e.RowIndex).Cells("PONoDataGridViewTextBoxColumn").Value.ToString()
        Purchase_ItemTableAdapter.Fill(RecSpecDataset.Purchase_Item)
        ProductTableAdapter.Fill(RecSpecDataset.Product)

        Dim res = From i In RecSpecDataset.Purchase_Item.AsEnumerable
                  Where i.PO_No = poID
                  Select i.Purchase_Item_Line_No, i.PO_No, i.ProductRow.Product_Code, i.ProductRow.Prod_Name,
                  i.Purchase_Item_Qty, i.ProductRow.Prod_Categories, i.Purchase_Item_Price

        dgvPOD.DataSource = res.ToList

        tbPOTotal.Text = dgvPO.Rows(e.RowIndex).Cells("POTotalDataGridViewTextBoxColumn").Value.ToString()

    End Sub

    Private Sub btnSearchPO_Click(sender As Object, e As EventArgs) Handles btnSearchPO.Click, tbQueryPO.TextChanged
        Dim query As String

        Select Case cbCriteriaPO.Text
            Case "By PO No"
                query = "CONVERT(PO_No, System.String) LIKE '%" + tbQuerySupplier.Text + "%'"
            Case "By PO Date"
                query = "PO_Date LIKE '%" + tbQuerySupplier.Text + "%'"
            Case "By PO Received Flag"
                query = "PO_Received_Flag LIKE '%" + tbQuerySupplier.Text + "%'"
            Case "By Supplier"
                query = "Supp_Name LIKE '%" + tbQuerySupplier.Text + "%'"
            Case "By Employee"
                query = "Emp_FName LIKE '%" + tbQuerySupplier.Text + "%'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            PurchaseOrderBindingSource.RemoveFilter()
        Else
            PurchaseOrderBindingSource.Filter = query
        End If
    End Sub




#End Region

#Region "Supplier tab"

    Private Sub Supplier_Init()
        SetAllFormat(WMSupplierTab, flpSupplier, tlpSupplier, dgvSupplier, "Supp_")
    End Sub



    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click, tbQuerySupplier.TextChanged
        Dim query As String

        Select Case cbCriteriaSupplier.Text
            Case "By Supplier ID"
                query = "Convert(Supplier_ID, System.String) LIKE '" + tbQuerySupplier.Text + "%'"
            Case "By Supplier Name"
                query = "Supp_Name LIKE '%" + tbQuerySupplier.Text + "%'"
            Case "By Contact Person"
                query = "Supp_Contact_Person LIKE '%" + tbQuerySupplier.Text + "%'"
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
            btnAddEditSupplier.Image = My.Resources.pencil961
            btnAddEditSupplier.ImageAlign = ContentAlignment.MiddleCenter
            btnRemoveSupplier.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)

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
            btnRemoveSupplier.Image = My.Resources.redbin296
            btnRemoveSupplier.ImageAlign = ContentAlignment.TopCenter
            btnAddEditSupplier.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        End If
    End Sub

    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs) Handles btnSaveSupplier.Click
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
            btnAddEditSupplier.Image = My.Resources.pencil961
            btnAddEditSupplier.ImageAlign = ContentAlignment.TopCenter
            btnAddEditSupplier.Text = "Add New/Edit Suppliers"
            btnAddEditSupplier.Enabled = True

            btnRemoveSupplier.Image = My.Resources.redbin296
            btnRemoveSupplier.ImageAlign = ContentAlignment.TopCenter
            btnRemoveSupplier.Text = "Remove"
            btnRemoveSupplier.Enabled = True
            Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
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

        End If

        tpage.ResumeLayout()
        tpage.Invalidate()

    End Sub

    Private Sub tbQuerySupplier_Enter(sender As Object, e As EventArgs) Handles tbQuerySupplier.Enter
        tbQuerySupplier.Text = ""
    End Sub

    Private Sub tbQueryPO_Enter(sender As Object, e As EventArgs) Handles tbQueryPO.Enter
        tbQueryPO.Text = ""
    End Sub

    Private Sub tbQueryProduct_Enter(sender As Object, e As EventArgs) Handles tbQueryProduct.Enter
        tbQueryProduct.Text = ""
    End Sub
End Class