Public Class WarehouseManager
    

    Private Sub WarehouseManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Item' table. You can move, or remove it, as needed.
        Me.Purchase_ItemTableAdapter.Fill(Me.RecSpecDataset.Purchase_Item)
        'TODO: This line of code loads data into the 'RecSpecDataset.Sale_Item' table. You can move, or remove it, as needed.
        Me.Sale_ItemTableAdapter.Fill(Me.RecSpecDataset.Sale_Item)
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Order' table. You can move, or remove it, as needed.
        Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)




    End Sub

    Private Sub btrnDisableProduct_Click(sender As Object, e As EventArgs) 

    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ProductDGV.ReadOnly = False
        ProductDGV.AllowUserToAddRows = True
        ProductDGV.GridColor = Color.Crimson
        MsgBox("Add new product, or edit existing products!")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ProductBindingSource.EndEdit()
        ProductTableAdapter.Update(RecSpecDataset.Product)
        MsgBox("Information saved!")
        ProductDGV.ReadOnly = True
        ProductDGV.AllowUserToAddRows = False
        ProductDGV.AllowUserToDeleteRows = False
        ProductDGV.GridColor = Color.Gray
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ProductDGV.ReadOnly = False
        ProductDGV.AllowUserToDeleteRows = True
        ProductDGV.GridColor = Color.Crimson
        MsgBox("Select products to delete! Click on the Save button when done!")
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
        PurchaseOrderBindingSource.EndEdit()
        PurchaseItemBindingSource.EndEdit()
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
            Prod_NameToolStrip1.Show()
            Product_CodeToolStrip.Hide()
        Else
            Prod_NameToolStrip1.Hide()
            Product_CodeToolStrip.Show()
        End If
    End Sub

    Private Sub InventoryTab_Click(sender As Object, e As EventArgs) Handles InventoryTab.Click

    End Sub

    Private Sub Prod_NameToolStripButton1_Click(sender As Object, e As EventArgs) Handles Prod_NameToolStripButton1.Click
        Try
            Me.ProductTableAdapter.Prod_Name(Me.RecSpecDataset.Product, Prod_NameToolStripTextBox1.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Product_CodeToolStripButton_Click(sender As Object, e As EventArgs) Handles Product_CodeToolStripButton.Click
        Try
            Me.ProductTableAdapter.Product_Code(Me.RecSpecDataset.Product, Product_CodeToolStripTextBox.Text & "%")
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

    Private Sub PO_DateToolStripButton_Click(sender As Object, e As EventArgs) Handles PO_DateToolStripButton.Click
        Try
            Me.Purchase_OrderTableAdapter.PO_Date(Me.RecSpecDataset.Purchase_Order, PO_DateToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem Is "Date" Then
            PO_DateToolStrip.Show()
            PO_NoToolStrip.Hide()
        Else
            PO_DateToolStrip.Hide()
            PO_NoToolStrip.Show()
        End If
    End Sub
End Class