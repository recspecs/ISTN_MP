Public Class WarehouseManager
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub WarehouseManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class