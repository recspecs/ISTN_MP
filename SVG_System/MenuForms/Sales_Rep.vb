Public Class Sales_Rep

    Private Sub Sales_Rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        'TODO: This line of code loads data into the 'RecSpecDataset.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset.CustomerTable)
        'TODO: This line of code loads data into the 'RecspecDataset.CustomerTable' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.RecSpecDataset.Product)
        Me.CustomerTableTableAdapter.Fill(Me.RecspecDataset.CustomerTable)

    End Sub

    Private Sub Btn3Remove_Click(sender As Object, e As EventArgs) Handles Btn3Remove.Click
        DGVCust.ReadOnly = False
        DGVCust.AllowUserToDeleteRows = True

        Dim ans As MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BSCust.RemoveCurrent()
        End If
    End Sub

    Private Sub Btn12Save_Click(sender As Object, e As EventArgs) Handles Btn12Save.Click

        BSCust.EndEdit()
        CustomerTableTableAdapter.Update(RecSpecDataset.CustomerTable)
        MsgBox("Information saved")
        DGVCust.ReadOnly = True
        DGVCust.AllowUserToAddRows = False

    End Sub

    Private Sub Btn13Edit_Click(sender As Object, e As EventArgs) Handles Btn13Edit.Click
        DGVCust.ReadOnly = False
        DGVCust.AllowUserToAddRows = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DGVProd.ReadOnly = False
        DGVProd.AllowUserToAddRows = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        DGVProd.ReadOnly = False
        DGVProd.AllowUserToDeleteRows = True

        Dim ans As MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BSProd.RemoveCurrent()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BSProd.EndEdit()
        ProductTableAdapter.Update(RecSpecDataset.Product)
        MsgBox("Information saved")
        DGVProd.ReadOnly = True
        DGVProd.AllowUserToAddRows = False
    End Sub
End Class