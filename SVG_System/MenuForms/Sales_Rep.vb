Public Class Sales_Rep

    Private Sub Sales_Rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset1.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.RecSpecDataset1.CustomerTable)

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
        CustomerTableTableAdapter.Update(RecSpecDataset1.CustomerTable)
        MsgBox("Information saved")
        DGVCust.ReadOnly = False
        DGVCust.AllowUserToAddRows = True

    End Sub

    Private Sub Btn13Edit_Click(sender As Object, e As EventArgs) Handles Btn13Edit.Click
        DGVCust.ReadOnly = False
        DGVCust.AllowUserToAddRows = True

    End Sub

    Private Sub Btn14NewCust_Click(sender As Object, e As EventArgs)
        DGVCust.ReadOnly = False
        DGVCust.AllowUserToAddRows = True
    End Sub

    Private Sub DGVCust_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCust.CellContentClick

    End Sub
End Class