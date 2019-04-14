Public Class WarehouseManager
    

    Private Sub WarehouseManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        cbSearchParam.SelectedIndex = 0
        

    End Sub

    Private Sub btrnDisableProduct_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnAddNewProduct_Click(sender As Object, e As EventArgs) Handles btnAddNewProduct.Click

    End Sub

    Private Sub InventoryTab_Click(sender As Object, e As EventArgs) Handles InventoryTab.Click

    End Sub
End Class