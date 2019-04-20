Public Class Login
    Private Sub CaptureOrderToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddStockToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If SalesRepRadioButton.Checked = True Then
            Sales_Rep.Show()
            Me.Hide()
        ElseIf WarehouseMngRadioBtn.Checked = True Then
            GenManager.Show()
            Me.Hide()
        End If
    End Sub
End Class
