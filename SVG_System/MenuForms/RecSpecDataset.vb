

Partial Public Class RecSpecDataset
    Partial Public Class CustomerTableDataTable
        Private Sub CustomerTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Customer_IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
