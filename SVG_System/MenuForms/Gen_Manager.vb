Public Class GenManager
    Private Sub Label58_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles Payment.Click

    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick

    End Sub

    Private Sub SalesOrder_Click(sender As Object, e As EventArgs) Handles SalesOrder.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub GenManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.RecSpecDataset.Employee)





    End Sub

    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub
End Class