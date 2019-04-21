Public Class WarehouseManager


    Private Sub WarehouseManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Item' table. You can move, or remove it, as needed.
        Me.Purchase_ItemTableAdapter.Fill(Me.RecSpecDataset.Purchase_Item)
        'TODO: This line of code loads data into the 'RecSpecDataset.Sale_Item' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Order' table. You can move, or remove it, as needed.
        Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)




    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not btnUpdate.Text = "Cancel" Then
            ProductDGV.ReadOnly = False
            ProductDGV.AllowUserToAddRows = True
            ProductDGV.GridColor = Color.Crimson
            btnUpdate.Text = "Cancel"
            btnUpdate.Image = My.Resources._return
            btnUpdate.ImageAlign = ContentAlignment.MiddleCenter
            btnRemove.Enabled = False
            MsgBox("Add new product, or edit existing products!")
        Else
            ProductDGV.ReadOnly = True
            ProductDGV.AllowUserToAddRows = False
            ProductDGV.GridColor = Color.Gray
            btnUpdate.Text = "Add New/Edit Products"
            btnUpdate.Image = My.Resources.Pencil_icon
            btnUpdate.ImageAlign = ContentAlignment.MiddleCenter
            btnRemove.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        End If




    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnUpdate.Text = "Cancel" Or btnRemove.Text = "Cancel" Then
            ProductBindingSource.EndEdit()
            Try
                ProductTableAdapter.Update(RecSpecDataset.Product)
                MsgBox("Information saved!")
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
            ProductDGV.ReadOnly = True
            ProductDGV.AllowUserToAddRows = False
            ProductDGV.AllowUserToDeleteRows = False
            ProductDGV.GridColor = Color.Gray
            btnUpdate.Image = My.Resources.Pencil_icon
            btnUpdate.ImageAlign = ContentAlignment.TopCenter
            btnUpdate.Text = "Add New/Edit Products"
            btnUpdate.Enabled = True

            btnRemove.Image = My.Resources.bin_red_full_icon
            btnRemove.ImageAlign = ContentAlignment.TopCenter
            btnRemove.Text = "Remove"
            btnRemove.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If Not btnRemove.Text = "Cancel" Then
            ProductDGV.ReadOnly = False
            ProductDGV.AllowUserToDeleteRows = True
            ProductDGV.GridColor = Color.Crimson
            btnRemove.Text = "Cancel"
            btnRemove.Image = My.Resources._return
            btnRemove.ImageAlign = ContentAlignment.TopCenter
            btnUpdate.Enabled = False
            MsgBox("Select products then press delete key! Click on the Save button when done!")
        Else
            btnRemove.Text = "Remove"
            ProductDGV.ReadOnly = True
            ProductDGV.AllowUserToDeleteRows = False
            ProductDGV.GridColor = Color.Gray
            btnRemove.Image = My.Resources.bin_red_full_icon
            btnRemove.ImageAlign = ContentAlignment.TopCenter
            btnUpdate.Enabled = True
            Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        End If

    End Sub


    Private Sub btnEmpEdit_Click(sender As Object, e As EventArgs) Handles btnEmpEdit.Click


        If Not btnEmpEdit.Text = "Cancel" Then
            PurchaseOrderDGV.ReadOnly = False
            PurchaseOrderDGV.AllowUserToAddRows = True
            PurchaseOrderDGV.GridColor = Color.Crimson
            PurchaseOrderDetailsDGV.ReadOnly = False
            PurchaseOrderDetailsDGV.AllowUserToAddRows = True
            PurchaseOrderDetailsDGV.GridColor = Color.Crimson
            btnEmpEdit.Text = "Cancel"
            btnEmpEdit.Image = My.Resources._return
            btnEmpEdit.ImageAlign = ContentAlignment.MiddleCenter
            Button19.Enabled = False
            MsgBox("Add new purchase order, or edit existing existing orders!")
        Else
            PurchaseOrderDGV.ReadOnly = True
            PurchaseOrderDGV.AllowUserToAddRows = False
            PurchaseOrderDGV.GridColor = Color.Gray
            PurchaseOrderDetailsDGV.ReadOnly = True
            PurchaseOrderDetailsDGV.AllowUserToAddRows = False
            PurchaseOrderDetailsDGV.GridColor = Color.Gray
            btnEmpEdit.Text = "Add New/Edit Purchase Order"
            btnEmpEdit.TextAlign = ContentAlignment.BottomCenter
            btnEmpEdit.Image = My.Resources.Pencil_icon
            btnEmpEdit.ImageAlign = ContentAlignment.TopCenter
            Button19.Enabled = True
            Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
            Me.Purchase_ItemTableAdapter.Fill(Me.RecSpecDataset.Purchase_Item)

        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        PurchaseOrderBindingSource1.EndEdit()
        PurchaseItemBindingSource1.EndEdit()
        Purchase_OrderTableAdapter.Update(RecSpecDataset.Purchase_Order)
        Purchase_ItemTableAdapter.Update(RecSpecDataset.Purchase_Item)
        MsgBox("Information saved!")

        PurchaseOrderDGV.ReadOnly = True
        PurchaseOrderDGV.AllowUserToAddRows = False
        PurchaseOrderDGV.AllowUserToDeleteRows = False
        PurchaseOrderDGV.GridColor = Color.Gray

        PurchaseOrderDetailsDGV.ReadOnly = True
        PurchaseOrderDetailsDGV.AllowUserToAddRows = False
        PurchaseOrderDetailsDGV.AllowUserToDeleteRows = False
        PurchaseOrderDetailsDGV.GridColor = Color.Gray

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click


        If Not Button19.Text = "Cancel" Then
            PurchaseOrderDGV.ReadOnly = False
            PurchaseOrderDGV.AllowUserToDeleteRows = True
            PurchaseOrderDGV.GridColor = Color.Crimson
            PurchaseOrderDetailsDGV.ReadOnly = False
            PurchaseOrderDetailsDGV.AllowUserToDeleteRows = True
            PurchaseOrderDetailsDGV.GridColor = Color.Crimson
            Button19.Text = "Cancel"
            Button19.TextAlign = ContentAlignment.BottomCenter
            Button19.Image = My.Resources._return
            Button19.ImageAlign = ContentAlignment.TopCenter
            btnEmpEdit.Enabled = False
            MsgBox("Select a row to delete, then press the delete key. Press the Save Button when done!")
        Else
            Button19.Text = "Remove"
            Button19.TextAlign = ContentAlignment.BottomCenter
            PurchaseOrderDGV.ReadOnly = True
            PurchaseOrderDGV.AllowUserToDeleteRows = False
            PurchaseOrderDGV.GridColor = Color.Gray
            PurchaseOrderDetailsDGV.ReadOnly = True
            PurchaseOrderDetailsDGV.AllowUserToDeleteRows = False
            PurchaseOrderDetailsDGV.GridColor = Color.Gray
            Button19.Image = My.Resources.bin_red_full_icon
            Button19.ImageAlign = ContentAlignment.TopCenter
            btnEmpEdit.Enabled = True
            Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
            Me.Purchase_ItemTableAdapter.Fill(Me.RecSpecDataset.Purchase_Item)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub









    Private Sub InventoryTab_Click(sender As Object, e As EventArgs) Handles InventoryTab.Click

    End Sub







    Private Sub PurchaseOrderDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchaseOrderDGV.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ProductDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDGV.CellContentClick

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim query As String

        Select Case CriteriaBox.Text
            Case "by Product Code"
                query = "Product_Code LIKE '%" + Querybox.Text + "%'"
            Case "by Product Name"
                query = "Prod_Name LIKE '%" + Querybox.Text + "%'"
            Case "by Stock level"
                query = "Prod_Stock_Level LIKE '" + Querybox.Text + "'"
            Case Else
                query = ""
        End Select

        If query.Length = 0 Then
            ProductBindingSource.RemoveFilter()
        Else
            ProductBindingSource.Filter = query
        End If
    End Sub

    Private Sub ProductBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CriteriaBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CriteriaBox.SelectedIndexChanged

    End Sub

    Private Sub Querybox_Enter(sender As Object, e As EventArgs) Handles Querybox.Enter
        Querybox.Text = ""
    End Sub


End Class