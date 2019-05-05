Public Class SalesRep
    Private Sub SalesRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)

    End Sub
End Class