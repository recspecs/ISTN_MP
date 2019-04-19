Public Class WarehouseManager
    

    Private Sub WarehouseManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Purchase_Order' table. You can move, or remove it, as needed.
        Me.Purchase_OrderTableAdapter.Fill(Me.RecSpecDataset.Purchase_Order)
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

        cbSearchParam.SelectedIndex = 0
        

    End Sub

    Private Sub btrnDisableProduct_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class