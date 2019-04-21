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
            btnRemove.Enabled = True

            btnRemove.Image = My.Resources.bin_red_full_icon
            btnRemove.ImageAlign = ContentAlignment.TopCenter
            btnRemove.Text = "Remove"
            btnRemove.Enabled = True
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
        PurchaseOrderDGV.ReadOnly = False
        PurchaseOrderDGV.AllowUserToAddRows = True
        PurchaseOrderDGV.GridColor = Color.Crimson
        PurchaseOrderDetailsDGV.ReadOnly = False
        PurchaseOrderDetailsDGV.AllowUserToAddRows = True
        PurchaseOrderDetailsDGV.GridColor = Color.Crimson
        MsgBox("Add new purchase order, or edit existing existing orders!")

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
        PurchaseOrderDGV.ReadOnly = False
        PurchaseOrderDGV.AllowUserToDeleteRows = True
        PurchaseOrderDGV.GridColor = Color.Crimson
        PurchaseOrderDetailsDGV.ReadOnly = False
        PurchaseOrderDetailsDGV.AllowUserToDeleteRows = True
        PurchaseOrderDetailsDGV.GridColor = Color.Crimson
        MsgBox("Select purchase orders to delete! Click on the Save button when done!")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub







    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem Is "Product Name" Then
            Prod_NameToolStrip.Show()
            Product_CodeToolStrip.Hide()
        Else
            Prod_NameToolStrip.Hide()
            Product_CodeToolStrip.Show()
        End If
    End Sub

    Private Sub InventoryTab_Click(sender As Object, e As EventArgs) Handles InventoryTab.Click

    End Sub





    Private Sub Product_CodeToolStripButton_Click(sender As Object, e As EventArgs) Handles Product_CodeToolStripButton.Click
        Try
            Me.ProductTableAdapter.Product_Code(Me.RecSpecDataset.Product, Product_CodeToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Prod_NameToolStripButton_Click(sender As Object, e As EventArgs) Handles Prod_NameToolStripButton.Click
        Try
            Me.ProductTableAdapter.Prod_Name(Me.RecSpecDataset.Product, Prod_NameToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PO_NoToolStripButton_Click(sender As Object, e As EventArgs) Handles PO_NoToolStripButton.Click
        Try
            Me.Purchase_OrderTableAdapter.PO_No(Me.RecSpecDataset.Purchase_Order, PO_NoToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PI_IDToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Purchase_ItemTableAdapter.PI_ID(Me.RecSpecDataset.Purchase_Item)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PurchaseOrderDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchaseOrderDGV.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ProductDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDGV.CellContentClick

    End Sub
End Class