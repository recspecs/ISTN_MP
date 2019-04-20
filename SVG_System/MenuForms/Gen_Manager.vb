Public Class GenManager


    Private Sub GenManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.RecSpecDataset.Supplier)
        DataGridView3.AutoGenerateColumns = False
        DataGridView8.AutoGenerateColumns = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = "Edit" Then
            btnAddsupp.Enabled = False
            Button4.Enabled = False
            Button3.Enabled = False
            TextBox2.Enabled = False
            ComboBox4.Enabled = False
            Button7.Text = "Cancel"
            DataGridView3.ReadOnly = False
            DataGridView8.ReadOnly = False
        Else
            Button7.Text = "Edit"
            btnAddsupp.Enabled = True
            Button4.Enabled = True
            Button3.Enabled = True
            TextBox2.Enabled = True
            ComboBox4.Enabled = True
            DataGridView3.ReadOnly = True
            DataGridView8.ReadOnly = True
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button7.Text = "Cancel" Then
            For Each i In Me.Controls
                i.Enabled = True
            Next

            Me.SupplierBindingSource.EndEdit()
            Try
                SupplierTableAdapter.Update(Me.RecSpecDataset.Supplier)
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub DataGridView3_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView3.DoubleClick
        If (DataGridView3.ReadOnly = True) Then
            MsgBox("Click on 'Edit' to enter Edit Mode")
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.SupplierBindingSource.EndEdit()
            Try
                SupplierTableAdapter.Update(Me.RecSpecDataset.Supplier)
            Catch ex As DataException
                MsgBox(ex.StackTrace)
            End Try
        End If

    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click

    End Sub
End Class